namespace http.purl.org.procurement.public_contracts.hash

open DoxAletheia

module pco =
    let _namespace_name = "http://purl.org/procurement/public-contracts#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Class for description of criteria combination used for tender evaluation
    /// <see href="http://purl.org/procurement/public-contracts#AwardCriteriaCombination"></see></summary>
    let AwardCriteriaCombination = _prefix "AwardCriteriaCombination"
    /// <summary>
    /// An instance of this class is an abstract information entity about a public contract. It consists of all currently known information about a contract, e.g., a contracting authority, services or supplies which shall be purchased, and contract conditions (e.g., important dates, expected price, etc.). It also informs about tenders received from particular bidders and about an accepted tender. If the contract has already been realized it also informs about an actual price of realization, etc.
    /// <see href="http://purl.org/procurement/public-contracts#Contract"></see></summary>
    let Contract = _prefix "Contract"
    /// <summary>
    /// Class for description of one criterion and its weight
    /// <see href="http://purl.org/procurement/public-contracts#CriterionWeighting"></see></summary>
    let CriterionWeighting = _prefix "CriterionWeighting"
    /// <summary>
    /// Class for decribing a framework agreement
    /// <see href="http://purl.org/procurement/public-contracts#FrameworkAgreement"></see></summary>
    let FrameworkAgreement = _prefix "FrameworkAgreement"
    /// <summary>
    /// Basic class for decribing a tender submitted by a bidder
    /// <see href="http://purl.org/procurement/public-contracts#Tender"></see></summary>
    let Tender = _prefix "Tender"
    /// <summary>
    /// Opening of tenders submitted for a public contract
    /// <see href="http://purl.org/procurement/public-contracts#TendersOpening"></see></summary>
    let TendersOpening = _prefix "TendersOpening"
    /// <summary>
    /// Property for actual end date of public contract's realization. Cardinality 0..1
    /// <see href="http://purl.org/procurement/public-contracts#actualEndDate"></see></summary>
    let actualEndDate = _prefix "actualEndDate"
    /// <summary>
    /// Property for actual price of the public contract. Cardinality 0..1
    /// <see href="http://purl.org/procurement/public-contracts#actualPrice"></see></summary>
    let actualPrice = _prefix "actualPrice"
    /// <summary>
    /// Abstract property for price of public contract
    /// <see href="http://purl.org/procurement/public-contracts#contractPrice"></see></summary>
    let contractPrice = _prefix "contractPrice"
    /// <summary>
    /// CPV (Common Procurement Vocabulary) code describing an additional object of a public contract. Cardinality 0..*
    /// <see href="http://purl.org/procurement/public-contracts#additionalObject"></see></summary>
    let additionalObject = _prefix "additionalObject"
    /// <summary>
    /// Property for a price stated on the contract with the supplier. Cardinality 0..1
    /// <see href="http://purl.org/procurement/public-contracts#agreedPrice"></see></summary>
    let agreedPrice = _prefix "agreedPrice"
    /// <summary>
    /// Property for attachment of documents containing the agreement between supplier and contractor. Cardinality 0..*
    /// <see href="http://purl.org/procurement/public-contracts#agreement"></see></summary>
    let agreement = _prefix "agreement"
    /// <summary>
    /// Property for attachment of other documents. For attachment of contract specification use pc:specification. For attachment of contract agreement use pc:agreement. Cardinality 0..*
    /// <see href="http://purl.org/procurement/public-contracts#attachment"></see></summary>
    let attachment = _prefix "attachment"
    /// <summary>
    /// Property for a kind of a contracting authority. Only a predefined SKOS concept can be used. Cardinality 0..1
    /// <see href="http://purl.org/procurement/public-contracts#authorityKind"></see></summary>
    let authorityKind = _prefix "authorityKind"
    /// <summary>
    /// Property for criteria combination for tender evaluation. Cardinality 0..1
    /// <see href="http://purl.org/procurement/public-contracts#awardCriteriaCombination"></see></summary>
    let awardCriteriaCombination = _prefix "awardCriteriaCombination"
    /// <summary>
    /// Property for setting a criterion for tender evaluation. Cardinality 0..*
    /// <see href="http://purl.org/procurement/public-contracts#awardCriterion"></see></summary>
    let awardCriterion = _prefix "awardCriterion"
    /// <summary>
    /// Property for date of contract award to a bidder. Cardinality 0..1
    /// <see href="http://purl.org/procurement/public-contracts#awardDate"></see></summary>
    let awardDate = _prefix "awardDate"
    /// <summary>
    /// Property for awarded tender submitted by a bidder. Cardinality 0..1
    /// <see href="http://purl.org/procurement/public-contracts#awardedTender"></see></summary>
    let awardedTender = _prefix "awardedTender"
    /// <summary>
    /// Property for a tender submitted by a bidder. Cardinality 0..*
    /// <see href="http://purl.org/procurement/public-contracts#tender"></see></summary>
    let tender = _prefix "tender"
    /// <summary>
    /// Property for bidder submitting the tender. Cardinality 0..1
    /// <see href="http://purl.org/procurement/public-contracts#bidder"></see></summary>
    let bidder = _prefix "bidder"
    /// <summary>
    /// Property for contact information for a person or place responsible for a communication with the public and bidders. If there are more contact places or persons (e.g., for collecting documentation to the public contract), there is a separate contact for each person. Cardinality 0..*
    /// <see href="http://purl.org/procurement/public-contracts#contact"></see></summary>
    let contact = _prefix "contact"
    /// <summary>
    /// Public contract, for which tenders are opened
    /// <see href="http://purl.org/procurement/public-contracts#contract"></see></summary>
    let contract = _prefix "contract"
    /// <summary>
    /// Institution which issues a public contract, receives tenders to the contract and chooses a suitable supplier on the base of the conditions given by the contract. Cardinality 0..1
    /// <see href="http://purl.org/procurement/public-contracts#contractingAuthority"></see></summary>
    let contractingAuthority = _prefix "contractingAuthority"
    /// <summary>
    /// Property for criterion weight for tender evaluation. Cardinality 0..1
    /// <see href="http://purl.org/procurement/public-contracts#criterionWeight"></see></summary>
    let criterionWeight = _prefix "criterionWeight"
    /// <summary>
    /// Property for price of documentation for public contract. Cardinality 0..1
    /// <see href="http://purl.org/procurement/public-contracts#documentationPrice"></see></summary>
    let documentationPrice = _prefix "documentationPrice"
    /// <summary>
    /// Property for time limit for receipt of requests for documentation. Cardinality 0..1
    /// <see href="http://purl.org/procurement/public-contracts#documentationRequestDeadline"></see></summary>
    let documentationRequestDeadline = _prefix "documentationRequestDeadline"
    /// <summary>
    /// Property for duration of contract. The duration may be described in days, months, years, etc. Cardinality 0..1
    /// <see href="http://purl.org/procurement/public-contracts#duration"></see></summary>
    let duration = _prefix "duration"
    /// <summary>
    /// Property for estimated end date of public contract realization. Cardinality 0..1
    /// <see href="http://purl.org/procurement/public-contracts#estimatedEndDate"></see></summary>
    let estimatedEndDate = _prefix "estimatedEndDate"
    /// <summary>
    /// Property for estimated price of public contract. It can be an exact estimation or an interval. Cardinality 0..1
    /// <see href="http://purl.org/procurement/public-contracts#estimatedPrice"></see></summary>
    let estimatedPrice = _prefix "estimatedPrice"
    /// <summary>
    /// Expected number of operators of framework agreement. Cardinality 0..1
    /// <see href="http://purl.org/procurement/public-contracts#expectedNumberOfOperators"></see></summary>
    let expectedNumberOfOperators = _prefix "expectedNumberOfOperators"
    /// <summary>
    /// Property for a framework agreement on which base a public contract was issued. Cardinality 0..1
    /// <see href="http://purl.org/procurement/public-contracts#frameworkAgreement"></see></summary>
    let frameworkAgreement = _prefix "frameworkAgreement"
    /// <summary>
    /// An item inquired by a public contract. It can be a combination of several products or services which can be expressed using properties of gr:Offering. Cardinality 0..*
    /// <see href="http://purl.org/procurement/public-contracts#item"></see></summary>
    let item = _prefix "item"
    /// <summary>
    /// Kind of a public contract specifies a basic focus of the contract on works, supplies or services. Only a predefined SKOS concept can be used. Cardinality 0..1
    /// <see href="http://purl.org/procurement/public-contracts#kind"></see></summary>
    let kind = _prefix "kind"
    /// <summary>
    /// Place of delivery of contracted product or performance of contracted service. Cardinality 0..*
    /// <see href="http://purl.org/procurement/public-contracts#location"></see></summary>
    let location = _prefix "location"
    /// <summary>
    /// Property for specifying contract lot. When contract is too big, it is split to lots by contracting authority. Bidders then tender each lot separately. For each lot the authority awards a separate tender. The contract itself has no tenders. Cardinality 0..*
    /// <see href="http://purl.org/procurement/public-contracts#lot"></see></summary>
    let lot = _prefix "lot"
    /// <summary>
    /// Property for main activity of contracting authority. Only a predefined SKOS concept can be used. Cardinality 0..1
    /// <see href="http://purl.org/procurement/public-contracts#mainActivity"></see></summary>
    let mainActivity = _prefix "mainActivity"
    /// <summary>
    /// CPV (Common Procurement Vocabulary) code describing the main object of a public contract. Cardinality 0..1
    /// <see href="http://purl.org/procurement/public-contracts#mainObject"></see></summary>
    let mainObject = _prefix "mainObject"
    /// <summary>
    /// Property for number of tenders received. Cardinality 0..1
    /// <see href="http://purl.org/procurement/public-contracts#numberOfTenders"></see></summary>
    let numberOfTenders = _prefix "numberOfTenders"
    /// <summary>
    /// Property for price offered by supplier. Cardinality 0..1
    /// <see href="http://purl.org/procurement/public-contracts#offeredPrice"></see></summary>
    let offeredPrice = _prefix "offeredPrice"
    /// <summary>
    /// Contract award on behalf of other contracting authorities. Cardinality 0..*
    /// <see href="http://purl.org/procurement/public-contracts#onBehalfOf"></see></summary>
    let onBehalfOf = _prefix "onBehalfOf"
    /// <summary>
    /// Type of procedure of a public contract specifies a procedure which is applied to publish information about the contract and choose a supplier. Only a predefined value can be used. Cardinality 0..1
    /// <see href="http://purl.org/procurement/public-contracts#procedureType"></see></summary>
    let procedureType = _prefix "procedureType"
    /// <summary>
    /// Property for the internet address of the profile of contracting authority (URL). Cardinality 0..1
    /// <see href="http://purl.org/procurement/public-contracts#profile"></see></summary>
    let profile = _prefix "profile"
    /// <summary>
    /// Property for attachment of documents containing the contract specification. Cardinality 0..*
    /// <see href="http://purl.org/procurement/public-contracts#specification"></see></summary>
    let specification = _prefix "specification"
    /// <summary>
    /// Property for start date of public contract realization coming from the contract's text. Cardinality 0..1
    /// <see href="http://purl.org/procurement/public-contracts#startDate"></see></summary>
    let startDate = _prefix "startDate"
    /// <summary>
    /// Property for used tender subsidy. Cardinality 0..*
    /// <see href="http://purl.org/procurement/public-contracts#subsidy"></see></summary>
    let subsidy = _prefix "subsidy"
    /// <summary>
    /// Property for time limit for receipt of tenders or requests to participate. Cardinality 0..1
    /// <see href="http://purl.org/procurement/public-contracts#tenderDeadline"></see></summary>
    let tenderDeadline = _prefix "tenderDeadline"
    /// <summary>
    /// Property for expressing minimum time frame during which the tenderer must maintain the tender. The duration may be described in days, months, years, etc. Cardinality 0..1
    /// <see href="http://purl.org/procurement/public-contracts#tenderMaintenanceDuration"></see></summary>
    let tenderMaintenanceDuration = _prefix "tenderMaintenanceDuration"
    /// <summary>
    /// Property for attaching criterion that is weighted. Cardinality 0..1
    /// <see href="http://purl.org/procurement/public-contracts#weightedCriterion"></see></summary>
    let weightedCriterion = _prefix "weightedCriterion"
