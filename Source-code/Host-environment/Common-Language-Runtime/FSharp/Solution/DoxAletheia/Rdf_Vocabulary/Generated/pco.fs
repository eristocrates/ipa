namespace http.purl.org.procurement.public_contracts.hash

open DoxAletheia.Rdf_Vocabulary

module pco =
    let _namespace_name = "http://purl.org/procurement/public-contracts#"

    /// <summary>
    /// Class for description of criteria combination used for tender evaluation
    /// <see href="http://purl.org/procurement/public-contracts#AwardCriteriaCombination"></see></summary>
    let AwardCriteriaCombination =
        Namespaced_IRI.parse _namespace_name "AwardCriteriaCombination" |> NamespacedName

    /// <summary>
    /// An instance of this class is an abstract information entity about a public contract. It consists of all currently known information about a contract, e.g., a contracting authority, services or supplies which shall be purchased, and contract conditions (e.g., important dates, expected price, etc.). It also informs about tenders received from particular bidders and about an accepted tender. If the contract has already been realized it also informs about an actual price of realization, etc.
    /// <see href="http://purl.org/procurement/public-contracts#Contract"></see></summary>
    let Contract = Namespaced_IRI.parse _namespace_name "Contract" |> NamespacedName

    /// <summary>
    /// Class for description of one criterion and its weight
    /// <see href="http://purl.org/procurement/public-contracts#CriterionWeighting"></see></summary>
    let CriterionWeighting =
        Namespaced_IRI.parse _namespace_name "CriterionWeighting" |> NamespacedName

    /// <summary>
    /// Class for decribing a framework agreement
    /// <see href="http://purl.org/procurement/public-contracts#FrameworkAgreement"></see></summary>
    let FrameworkAgreement =
        Namespaced_IRI.parse _namespace_name "FrameworkAgreement" |> NamespacedName

    /// <summary>
    /// Basic class for decribing a tender submitted by a bidder
    /// <see href="http://purl.org/procurement/public-contracts#Tender"></see></summary>
    let Tender = Namespaced_IRI.parse _namespace_name "Tender" |> NamespacedName

    /// <summary>
    /// Opening of tenders submitted for a public contract
    /// <see href="http://purl.org/procurement/public-contracts#TendersOpening"></see></summary>
    let TendersOpening =
        Namespaced_IRI.parse _namespace_name "TendersOpening" |> NamespacedName

    /// <summary>
    /// Property for actual end date of public contract's realization. Cardinality 0..1
    /// <see href="http://purl.org/procurement/public-contracts#actualEndDate"></see></summary>
    let actualEndDate =
        Namespaced_IRI.parse _namespace_name "actualEndDate" |> NamespacedName

    /// <summary>
    /// Property for actual price of the public contract. Cardinality 0..1
    /// <see href="http://purl.org/procurement/public-contracts#actualPrice"></see></summary>
    let actualPrice =
        Namespaced_IRI.parse _namespace_name "actualPrice" |> NamespacedName

    /// <summary>
    /// Abstract property for price of public contract
    /// <see href="http://purl.org/procurement/public-contracts#contractPrice"></see></summary>
    let contractPrice =
        Namespaced_IRI.parse _namespace_name "contractPrice" |> NamespacedName

    /// <summary>
    /// CPV (Common Procurement Vocabulary) code describing an additional object of a public contract. Cardinality 0..*
    /// <see href="http://purl.org/procurement/public-contracts#additionalObject"></see></summary>
    let additionalObject =
        Namespaced_IRI.parse _namespace_name "additionalObject" |> NamespacedName

    /// <summary>
    /// Property for a price stated on the contract with the supplier. Cardinality 0..1
    /// <see href="http://purl.org/procurement/public-contracts#agreedPrice"></see></summary>
    let agreedPrice =
        Namespaced_IRI.parse _namespace_name "agreedPrice" |> NamespacedName

    /// <summary>
    /// Property for attachment of documents containing the agreement between supplier and contractor. Cardinality 0..*
    /// <see href="http://purl.org/procurement/public-contracts#agreement"></see></summary>
    let agreement = Namespaced_IRI.parse _namespace_name "agreement" |> NamespacedName
    /// <summary>
    /// Property for attachment of other documents. For attachment of contract specification use pc:specification. For attachment of contract agreement use pc:agreement. Cardinality 0..*
    /// <see href="http://purl.org/procurement/public-contracts#attachment"></see></summary>
    let attachment = Namespaced_IRI.parse _namespace_name "attachment" |> NamespacedName

    /// <summary>
    /// Property for a kind of a contracting authority. Only a predefined SKOS concept can be used. Cardinality 0..1
    /// <see href="http://purl.org/procurement/public-contracts#authorityKind"></see></summary>
    let authorityKind =
        Namespaced_IRI.parse _namespace_name "authorityKind" |> NamespacedName

    /// <summary>
    /// Property for criteria combination for tender evaluation. Cardinality 0..1
    /// <see href="http://purl.org/procurement/public-contracts#awardCriteriaCombination"></see></summary>
    let awardCriteriaCombination =
        Namespaced_IRI.parse _namespace_name "awardCriteriaCombination" |> NamespacedName

    /// <summary>
    /// Property for setting a criterion for tender evaluation. Cardinality 0..*
    /// <see href="http://purl.org/procurement/public-contracts#awardCriterion"></see></summary>
    let awardCriterion =
        Namespaced_IRI.parse _namespace_name "awardCriterion" |> NamespacedName

    /// <summary>
    /// Property for date of contract award to a bidder. Cardinality 0..1
    /// <see href="http://purl.org/procurement/public-contracts#awardDate"></see></summary>
    let awardDate = Namespaced_IRI.parse _namespace_name "awardDate" |> NamespacedName

    /// <summary>
    /// Property for awarded tender submitted by a bidder. Cardinality 0..1
    /// <see href="http://purl.org/procurement/public-contracts#awardedTender"></see></summary>
    let awardedTender =
        Namespaced_IRI.parse _namespace_name "awardedTender" |> NamespacedName

    /// <summary>
    /// Property for a tender submitted by a bidder. Cardinality 0..*
    /// <see href="http://purl.org/procurement/public-contracts#tender"></see></summary>
    let tender = Namespaced_IRI.parse _namespace_name "tender" |> NamespacedName
    /// <summary>
    /// Property for bidder submitting the tender. Cardinality 0..1
    /// <see href="http://purl.org/procurement/public-contracts#bidder"></see></summary>
    let bidder = Namespaced_IRI.parse _namespace_name "bidder" |> NamespacedName
    /// <summary>
    /// Property for contact information for a person or place responsible for a communication with the public and bidders. If there are more contact places or persons (e.g., for collecting documentation to the public contract), there is a separate contact for each person. Cardinality 0..*
    /// <see href="http://purl.org/procurement/public-contracts#contact"></see></summary>
    let contact = Namespaced_IRI.parse _namespace_name "contact" |> NamespacedName
    /// <summary>
    /// Public contract, for which tenders are opened
    /// <see href="http://purl.org/procurement/public-contracts#contract"></see></summary>
    let contract = Namespaced_IRI.parse _namespace_name "contract" |> NamespacedName

    /// <summary>
    /// Institution which issues a public contract, receives tenders to the contract and chooses a suitable supplier on the base of the conditions given by the contract. Cardinality 0..1
    /// <see href="http://purl.org/procurement/public-contracts#contractingAuthority"></see></summary>
    let contractingAuthority =
        Namespaced_IRI.parse _namespace_name "contractingAuthority" |> NamespacedName

    /// <summary>
    /// Property for criterion weight for tender evaluation. Cardinality 0..1
    /// <see href="http://purl.org/procurement/public-contracts#criterionWeight"></see></summary>
    let criterionWeight =
        Namespaced_IRI.parse _namespace_name "criterionWeight" |> NamespacedName

    /// <summary>
    /// Property for price of documentation for public contract. Cardinality 0..1
    /// <see href="http://purl.org/procurement/public-contracts#documentationPrice"></see></summary>
    let documentationPrice =
        Namespaced_IRI.parse _namespace_name "documentationPrice" |> NamespacedName

    /// <summary>
    /// Property for time limit for receipt of requests for documentation. Cardinality 0..1
    /// <see href="http://purl.org/procurement/public-contracts#documentationRequestDeadline"></see></summary>
    let documentationRequestDeadline =
        Namespaced_IRI.parse _namespace_name "documentationRequestDeadline" |> NamespacedName

    /// <summary>
    /// Property for duration of contract. The duration may be described in days, months, years, etc. Cardinality 0..1
    /// <see href="http://purl.org/procurement/public-contracts#duration"></see></summary>
    let duration = Namespaced_IRI.parse _namespace_name "duration" |> NamespacedName

    /// <summary>
    /// Property for estimated end date of public contract realization. Cardinality 0..1
    /// <see href="http://purl.org/procurement/public-contracts#estimatedEndDate"></see></summary>
    let estimatedEndDate =
        Namespaced_IRI.parse _namespace_name "estimatedEndDate" |> NamespacedName

    /// <summary>
    /// Property for estimated price of public contract. It can be an exact estimation or an interval. Cardinality 0..1
    /// <see href="http://purl.org/procurement/public-contracts#estimatedPrice"></see></summary>
    let estimatedPrice =
        Namespaced_IRI.parse _namespace_name "estimatedPrice" |> NamespacedName

    /// <summary>
    /// Expected number of operators of framework agreement. Cardinality 0..1
    /// <see href="http://purl.org/procurement/public-contracts#expectedNumberOfOperators"></see></summary>
    let expectedNumberOfOperators =
        Namespaced_IRI.parse _namespace_name "expectedNumberOfOperators" |> NamespacedName

    /// <summary>
    /// Property for a framework agreement on which base a public contract was issued. Cardinality 0..1
    /// <see href="http://purl.org/procurement/public-contracts#frameworkAgreement"></see></summary>
    let frameworkAgreement =
        Namespaced_IRI.parse _namespace_name "frameworkAgreement" |> NamespacedName

    /// <summary>
    /// An item inquired by a public contract. It can be a combination of several products or services which can be expressed using properties of gr:Offering. Cardinality 0..*
    /// <see href="http://purl.org/procurement/public-contracts#item"></see></summary>
    let item = Namespaced_IRI.parse _namespace_name "item" |> NamespacedName
    /// <summary>
    /// Kind of a public contract specifies a basic focus of the contract on works, supplies or services. Only a predefined SKOS concept can be used. Cardinality 0..1
    /// <see href="http://purl.org/procurement/public-contracts#kind"></see></summary>
    let kind = Namespaced_IRI.parse _namespace_name "kind" |> NamespacedName
    /// <summary>
    /// Place of delivery of contracted product or performance of contracted service. Cardinality 0..*
    /// <see href="http://purl.org/procurement/public-contracts#location"></see></summary>
    let location = Namespaced_IRI.parse _namespace_name "location" |> NamespacedName
    /// <summary>
    /// Property for specifying contract lot. When contract is too big, it is split to lots by contracting authority. Bidders then tender each lot separately. For each lot the authority awards a separate tender. The contract itself has no tenders. Cardinality 0..*
    /// <see href="http://purl.org/procurement/public-contracts#lot"></see></summary>
    let lot = Namespaced_IRI.parse _namespace_name "lot" |> NamespacedName

    /// <summary>
    /// Property for main activity of contracting authority. Only a predefined SKOS concept can be used. Cardinality 0..1
    /// <see href="http://purl.org/procurement/public-contracts#mainActivity"></see></summary>
    let mainActivity =
        Namespaced_IRI.parse _namespace_name "mainActivity" |> NamespacedName

    /// <summary>
    /// CPV (Common Procurement Vocabulary) code describing the main object of a public contract. Cardinality 0..1
    /// <see href="http://purl.org/procurement/public-contracts#mainObject"></see></summary>
    let mainObject = Namespaced_IRI.parse _namespace_name "mainObject" |> NamespacedName

    /// <summary>
    /// Property for number of tenders received. Cardinality 0..1
    /// <see href="http://purl.org/procurement/public-contracts#numberOfTenders"></see></summary>
    let numberOfTenders =
        Namespaced_IRI.parse _namespace_name "numberOfTenders" |> NamespacedName

    /// <summary>
    /// Property for price offered by supplier. Cardinality 0..1
    /// <see href="http://purl.org/procurement/public-contracts#offeredPrice"></see></summary>
    let offeredPrice =
        Namespaced_IRI.parse _namespace_name "offeredPrice" |> NamespacedName

    /// <summary>
    /// Contract award on behalf of other contracting authorities. Cardinality 0..*
    /// <see href="http://purl.org/procurement/public-contracts#onBehalfOf"></see></summary>
    let onBehalfOf = Namespaced_IRI.parse _namespace_name "onBehalfOf" |> NamespacedName

    /// <summary>
    /// Type of procedure of a public contract specifies a procedure which is applied to publish information about the contract and choose a supplier. Only a predefined value can be used. Cardinality 0..1
    /// <see href="http://purl.org/procurement/public-contracts#procedureType"></see></summary>
    let procedureType =
        Namespaced_IRI.parse _namespace_name "procedureType" |> NamespacedName

    /// <summary>
    /// Property for the internet address of the profile of contracting authority (URL). Cardinality 0..1
    /// <see href="http://purl.org/procurement/public-contracts#profile"></see></summary>
    let profile = Namespaced_IRI.parse _namespace_name "profile" |> NamespacedName

    /// <summary>
    /// Property for attachment of documents containing the contract specification. Cardinality 0..*
    /// <see href="http://purl.org/procurement/public-contracts#specification"></see></summary>
    let specification =
        Namespaced_IRI.parse _namespace_name "specification" |> NamespacedName

    /// <summary>
    /// Property for start date of public contract realization coming from the contract's text. Cardinality 0..1
    /// <see href="http://purl.org/procurement/public-contracts#startDate"></see></summary>
    let startDate = Namespaced_IRI.parse _namespace_name "startDate" |> NamespacedName
    /// <summary>
    /// Property for used tender subsidy. Cardinality 0..*
    /// <see href="http://purl.org/procurement/public-contracts#subsidy"></see></summary>
    let subsidy = Namespaced_IRI.parse _namespace_name "subsidy" |> NamespacedName

    /// <summary>
    /// Property for time limit for receipt of tenders or requests to participate. Cardinality 0..1
    /// <see href="http://purl.org/procurement/public-contracts#tenderDeadline"></see></summary>
    let tenderDeadline =
        Namespaced_IRI.parse _namespace_name "tenderDeadline" |> NamespacedName

    /// <summary>
    /// Property for expressing minimum time frame during which the tenderer must maintain the tender. The duration may be described in days, months, years, etc. Cardinality 0..1
    /// <see href="http://purl.org/procurement/public-contracts#tenderMaintenanceDuration"></see></summary>
    let tenderMaintenanceDuration =
        Namespaced_IRI.parse _namespace_name "tenderMaintenanceDuration" |> NamespacedName

    /// <summary>
    /// Property for attaching criterion that is weighted. Cardinality 0..1
    /// <see href="http://purl.org/procurement/public-contracts#weightedCriterion"></see></summary>
    let weightedCriterion =
        Namespaced_IRI.parse _namespace_name "weightedCriterion" |> NamespacedName
