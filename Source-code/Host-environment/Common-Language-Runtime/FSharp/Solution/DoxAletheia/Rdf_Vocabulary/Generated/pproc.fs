namespace http.contsem.unizar.es.def.sector_publico.pproc.hash

open DoxAletheia

module pproc =
    let _namespace_name = "http://contsem.unizar.es/def/sector-publico/pproc#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#MixedContract"></see>
    /// </summary>
    let MixedContract = _prefix "MixedContract"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#PrecomercialProcurement"></see>
    /// </summary>
    let PrecomercialProcurement = _prefix "PrecomercialProcurement"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#PrivateContract"></see>
    /// </summary>
    let PrivateContract = _prefix "PrivateContract"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#PublicPrivatePartnershipContract"></see>
    /// </summary>
    let PublicPrivatePartnershipContract = _prefix "PublicPrivatePartnershipContract"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#PublicServicesManagementContract"></see>
    /// </summary>
    let PublicServicesManagementContract = _prefix "PublicServicesManagementContract"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#PublicWorksConcessionContract"></see>
    /// </summary>
    let PublicWorksConcessionContract = _prefix "PublicWorksConcessionContract"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#ServicesContract"></see>
    /// </summary>
    let ServicesContract = _prefix "ServicesContract"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#SpecialAdministrativeContract"></see>
    /// </summary>
    let SpecialAdministrativeContract = _prefix "SpecialAdministrativeContract"
    /// <summary>
    /// Class describing contracts whose object is the acquisition of supplies.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#SuppliesContract"></see></summary>
    let SuppliesContract = _prefix "SuppliesContract"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#WorksContract"></see>
    /// </summary>
    let WorksContract = _prefix "WorksContract"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#AdditionalInformationNotice"></see>
    /// </summary>
    let AdditionalInformationNotice = _prefix "AdditionalInformationNotice"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#ContractAwardNotice"></see>
    /// </summary>
    let ContractAwardNotice = _prefix "ContractAwardNotice"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#ContractNotice"></see>
    /// </summary>
    let ContractNotice = _prefix "ContractNotice"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#CorrectionNotice"></see>
    /// </summary>
    let CorrectionNotice = _prefix "CorrectionNotice"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#FormalizationNotice"></see>
    /// </summary>
    let FormalizationNotice = _prefix "FormalizationNotice"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#PriorInformationNotice"></see>
    /// </summary>
    let PriorInformationNotice = _prefix "PriorInformationNotice"
    /// <summary>
    /// Class of the contract that have lots.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#ContractWithLots"></see></summary>
    let ContractWithLots = _prefix "ContractWithLots"
    /// <summary>
    /// Class to describe the contract not divided into lots.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#ContractWithoutLots"></see></summary>
    let ContractWithoutLots = _prefix "ContractWithoutLots"
    /// <summary>
    /// Class describing contracts that are an actual lot of another contract.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#Lot"></see></summary>
    let Lot = _prefix "Lot"
    /// <summary>
    /// Class to describe the supplies contracts aimed to buy supplies.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#BuyContract"></see></summary>
    let BuyContract = _prefix "BuyContract"
    /// <summary>
    /// Class defining supplies contracts aimed to lease supplies.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#LeaseContract"></see></summary>
    let LeaseContract = _prefix "LeaseContract"
    /// <summary>
    /// Class defining supplies contracts aimed to rent supplies.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#RentContract"></see></summary>
    let RentContract = _prefix "RentContract"
    /// <summary>
    /// Class describing the contract concerts with natural or legal person performing similar services at the public service in question.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#AgreementContract"></see></summary>
    let AgreementContract = _prefix "AgreementContract"
    /// <summary>
    /// Class of the contracts in which the awarded tenderer manage the public service themselves.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#ConcessionContract"></see></summary>
    let ConcessionContract = _prefix "ConcessionContract"
    /// <summary>
    /// Class describing the contracts where the contracting authority participates concurrently with the natural or legal person.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#MixedCapitalCompanyContract"></see></summary>
    let MixedCapitalCompanyContract = _prefix "MixedCapitalCompanyContract"
    /// <summary>
    /// Class describing contracts whose operation results are shared among the contracting authority and the tenderer.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#SharedResultAgreementContract"></see></summary>
    let SharedResultAgreementContract = _prefix "SharedResultAgreementContract"
    /// <summary>
    /// Class describing the tenders accepted in the procurement public contract.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#AcceptedTender"></see></summary>
    let AcceptedTender = _prefix "AcceptedTender"
    /// <summary>
    /// Class that defines the tenders excluded from the procurement procedure.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#ExcludedTender"></see></summary>
    let ExcludedTender = _prefix "ExcludedTender"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#Notice"></see>
    /// </summary>
    let Notice = _prefix "Notice"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#AdministrativeInformation"></see>
    /// </summary>
    let AdministrativeInformation = _prefix "AdministrativeInformation"
    /// <summary>
    /// Scheme that indicates the type of the information that can be provided.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#InformationKindScheme"></see></summary>
    let InformationKindScheme = _prefix "InformationKindScheme"
    /// <summary>
    /// Class describing the awarded tenders.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#AwardedTender"></see></summary>
    let AwardedTender = _prefix "AwardedTender"
    /// <summary>
    /// Informative meeting about the public procurement contract.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#Briefing"></see></summary>
    let Briefing = _prefix "Briefing"
    /// <summary>
    /// Class used to describe the price a set of objets.
    ///
    /// Can be used to define the total price of an gr:Offering. Its value must be equal to the gr:UnitPriceSpecification multiplied by the number of items.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#BundlePriceSpecification"></see></summary>
    let BundlePriceSpecification = _prefix "BundlePriceSpecification"
    /// <summary>
    /// Abstract class describing a set of persons in committee and its roles.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#Committee"></see></summary>
    let Committee = _prefix "Committee"
    /// <summary>
    /// Class that describes the member a committee.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#CommitteeMember"></see></summary>
    let CommitteeMember = _prefix "CommitteeMember"
    /// <summary>
    /// Class describing the contracts consisting in the conclusion of a framework agreement or a dynamic purchasing system.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#ConclusionContract"></see></summary>
    let ConclusionContract = _prefix "ConclusionContract"
    /// <summary>
    /// Class used to describe a contract that is a declaration of a framework agreement or a dynamic purchasing system.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#FrameworkAgreement"></see></summary>
    let FrameworkAgreement = _prefix "FrameworkAgreement"
    /// <summary>
    /// Property that indicates the framework agreement in which the contract consists.
    ///
    /// This property is used when the actual contract consist in the declaration of a framework agreement or a dynamic purchasing system.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#frameworkAgreement"></see></summary>
    let frameworkAgreement = _prefix "frameworkAgreement"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#Contract"></see>
    /// </summary>
    let Contract = _prefix "Contract"
    /// <summary>
    /// Class describing contracts derived from a framework agreement or a dynamic purchasing system.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#DerivativeContract"></see></summary>
    let DerivativeContract = _prefix "DerivativeContract"
    /// <summary>
    /// Class describing all activities of a contract (e.g. meetings or agreements of the contracting body).
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#ContractActivities"></see></summary>
    let ContractActivities = _prefix "ContractActivities"
    /// <summary>
    /// Class describing the additional obligations the contract needs (e.g. guarantees or advertisement costs)
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#ContractAdditionalObligations"></see></summary>
    let ContractAdditionalObligations = _prefix "ContractAdditionalObligations"
    /// <summary>
    /// Class describing the bodies related to the contract.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#ContractBodies"></see></summary>
    let ContractBodies = _prefix "ContractBodies"
    /// <summary>
    /// Class defining the actual economic conditions of the contract (e.g. budget or the formula that describes the revision of its price).
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#ContractEconomicConditions"></see></summary>
    let ContractEconomicConditions = _prefix "ContractEconomicConditions"
    /// <summary>
    /// Class that defines the execution conditions of the contract (e.g. special execution conditions or subcontracting percentage amounts).
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#ContractExecutionConditions"></see></summary>
    let ContractExecutionConditions = _prefix "ContractExecutionConditions"
    /// <summary>
    /// During the execution of a contract it could happen that the contract should be modified, to describe these kind of situations we use this class.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#ContractModification"></see></summary>
    let ContractModification = _prefix "ContractModification"
    /// <summary>
    /// Class describing the conditions for which a contract can be modified (e.g. maximum percentage of its price or budget).
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#ContractModificationConditions"></see></summary>
    let ContractModificationConditions = _prefix "ContractModificationConditions"
    /// <summary>
    /// Class that defines the object of the contract and the conditions or modifications the contract can have.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#ContractObject"></see></summary>
    let ContractObject = _prefix "ContractObject"
    /// <summary>
    /// Abstract class. There are some circumstances resulting in the extinction of the procedure of the contract or the contract itself. To describe that situations we may use one of its subclasses.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#ContractOrProcedureExtinction"></see></summary>
    let ContractOrProcedureExtinction = _prefix "ContractOrProcedureExtinction"
    /// <summary>
    /// Class that specifies the procedure of a contract (e.g. type of procedure or its urgency).
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#ContractProcedureSpecifications"></see></summary>
    let ContractProcedureSpecifications = _prefix "ContractProcedureSpecifications"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#ContractResolution"></see>
    /// </summary>
    let ContractResolution = _prefix "ContractResolution"
    /// <summary>
    /// Class that describes the temporal conditions of the contract.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#ContractTemporalConditions"></see></summary>
    let ContractTemporalConditions = _prefix "ContractTemporalConditions"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#lot"></see>
    /// </summary>
    let lot = _prefix "lot"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#numberOfLots"></see>
    /// </summary>
    let numberOfLots = _prefix "numberOfLots"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#ContractingBodyAgreement"></see>
    /// </summary>
    let ContractingBodyAgreement = _prefix "ContractingBodyAgreement"
    /// <summary>
    /// Class to describe an award criterion and its score.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#CriterionScore"></see></summary>
    let CriterionScore = _prefix "CriterionScore"

    /// <summary>
    /// Class describing the contracts consisting in the conclusion of a dynamic purchasing system.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#DynamicPurchasingSystemConclusionContract"></see></summary>
    let DynamicPurchasingSystemConclusionContract =
        _prefix "DynamicPurchasingSystemConclusionContract"

    /// <summary>
    /// Class describing contracts derived from a dynamic purchasing system.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#DynamicPurchasingSystemDerivativeContract"></see></summary>
    let DynamicPurchasingSystemDerivativeContract =
        _prefix "DynamicPurchasingSystemDerivativeContract"

    /// <summary>
    /// Class that specifies the existence of an electronic auction of one or more of the award criterions.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#ElectronicAuction"></see></summary>
    let ElectronicAuction = _prefix "ElectronicAuction"
    /// <summary>
    /// Class describing a phase of an electronic auction.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#ElectronicAuctionPhase"></see></summary>
    let ElectronicAuctionPhase = _prefix "ElectronicAuctionPhase"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#Emergency"></see>
    /// </summary>
    let Emergency = _prefix "Emergency"
    /// <summary>
    /// Scheme that defines the kinds of urgency a procedure can follow.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#UrgencyTypeScheme"></see></summary>
    let UrgencyTypeScheme = _prefix "UrgencyTypeScheme"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#ExpertCommittee"></see>
    /// </summary>
    let ExpertCommittee = _prefix "ExpertCommittee"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#Express"></see>
    /// </summary>
    let Express = _prefix "Express"
    /// <summary>
    /// Class describing contracts whose end date can be extended.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#ExtendableContract"></see></summary>
    let ExtendableContract = _prefix "ExtendableContract"
    /// <summary>
    /// Class describing tenders being formalized.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#FormalizedTender"></see></summary>
    let FormalizedTender = _prefix "FormalizedTender"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#formalizedDate"></see>
    /// </summary>
    let formalizedDate = _prefix "formalizedDate"
    /// <summary>
    /// Class describing the contracts consisting in the conclusion of a framework agreement.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#FrameworkConclusionContract"></see></summary>
    let FrameworkConclusionContract = _prefix "FrameworkConclusionContract"
    /// <summary>
    /// Class describing contracts derived from a framework agreement.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#FrameworkDerivativeContract"></see></summary>
    let FrameworkDerivativeContract = _prefix "FrameworkDerivativeContract"
    /// <summary>
    /// Class to describe harmonized contracts (i.e. contracts that reachs the threshold to be treated as highlighted in the procurement Directives of the European Commision and European Council).
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#HarmonizedContract"></see></summary>
    let HarmonizedContract = _prefix "HarmonizedContract"
    /// <summary>
    /// Class defining the provider of information about the contract.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#InformationProvider"></see></summary>
    let InformationProvider = _prefix "InformationProvider"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#LegalRemedy"></see>
    /// </summary>
    let LegalRemedy = _prefix "LegalRemedy"
    /// <summary>
    /// Remedy lodged concerning a resolution about the procurement procedure.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#Remedy"></see></summary>
    let Remedy = _prefix "Remedy"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#Minor"></see>
    /// </summary>
    let Minor = _prefix "Minor"
    /// <summary>
    /// Scheme defining the procedure to be followed in a tender.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#ProcedureTypeScheme"></see></summary>
    let ProcedureTypeScheme = _prefix "ProcedureTypeScheme"
    /// <summary>
    /// Class describing the multiannual contracts (i.e. contract whose duration extends over more than one financial year).
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#MultiannualContract"></see></summary>
    let MultiannualContract = _prefix "MultiannualContract"
    /// <summary>
    /// Abstract concept defining the procedure of the contract as negotiated.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#Negotiated"></see></summary>
    let Negotiated = _prefix "Negotiated"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#NegotiatedWithoutPublicity"></see>
    /// </summary>
    let NegotiatedWithoutPublicity = _prefix "NegotiatedWithoutPublicity"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#NegotiatedWithPublicity"></see>
    /// </summary>
    let NegotiatedWithPublicity = _prefix "NegotiatedWithPublicity"
    /// <summary>
    /// Class describing criterioa that depend on a value judgement.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#ObjectiveAwardCriterion"></see></summary>
    let ObjectiveAwardCriterion = _prefix "ObjectiveAwardCriterion"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#OrdinaryAdministrativeRemedy"></see>
    /// </summary>
    let OrdinaryAdministrativeRemedy = _prefix "OrdinaryAdministrativeRemedy"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#ProcedureResignation"></see>
    /// </summary>
    let ProcedureResignation = _prefix "ProcedureResignation"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#ProcedureVoid"></see>
    /// </summary>
    let ProcedureVoid = _prefix "ProcedureVoid"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#ProcedureWaive"></see>
    /// </summary>
    let ProcedureWaive = _prefix "ProcedureWaive"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#Regular"></see>
    /// </summary>
    let Regular = _prefix "Regular"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#RegularOpen"></see>
    /// </summary>
    let RegularOpen = _prefix "RegularOpen"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#SimpleOpen"></see>
    /// </summary>
    let SimpleOpen = _prefix "SimpleOpen"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#SpecialAdministrativeRemedy"></see>
    /// </summary>
    let SpecialAdministrativeRemedy = _prefix "SpecialAdministrativeRemedy"
    /// <summary>
    /// Class used to describe criteria that depend on a subjetive opinion.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#SubjectiveAwardCriterion"></see></summary>
    let SubjectiveAwardCriterion = _prefix "SubjectiveAwardCriterion"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#TechnicalCommittee"></see>
    /// </summary>
    let TechnicalCommittee = _prefix "TechnicalCommittee"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#TechnicalInformation"></see>
    /// </summary>
    let TechnicalInformation = _prefix "TechnicalInformation"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#TenderCommittee"></see>
    /// </summary>
    let TenderCommittee = _prefix "TenderCommittee"
    /// <summary>
    /// Class describing the meetings of tender committee.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#TenderMeeting"></see></summary>
    let TenderMeeting = _prefix "TenderMeeting"
    /// <summary>
    /// Class to define the tender requirements needed to submit a tender (e.g. tender document needs).
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#TenderRequirements"></see></summary>
    let TenderRequirements = _prefix "TenderRequirements"
    /// <summary>
    /// Class defining the tenderers requirements (e.g. required classification or financial capability).
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#TenderersRequirements"></see></summary>
    let TenderersRequirements = _prefix "TenderersRequirements"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#actualDuration"></see>
    /// </summary>
    let actualDuration = _prefix "actualDuration"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#duration"></see>
    /// </summary>
    let duration = _prefix "duration"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#additionalDocumentReference"></see>
    /// </summary>
    let additionalDocumentReference = _prefix "additionalDocumentReference"
    /// <summary>
    /// Links to external documents.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#documentReference"></see></summary>
    let documentReference = _prefix "documentReference"
    /// <summary>
    /// Property that points to the concept of the CPV code of an object.
    ///
    /// The concept used should be a valid representation of a CPV code, as it is in http://cpv.data.ac.uk/.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#additionalObject"></see></summary>
    let additionalObject = _prefix "additionalObject"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#advertisementAmount"></see>
    /// </summary>
    let advertisementAmount = _prefix "advertisementAmount"
    /// <summary>
    /// Points to an alternate member of a committee.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#alternateMember"></see></summary>
    let alternateMember = _prefix "alternateMember"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#assumptionProtectingProcedureType"></see>
    /// </summary>
    let assumptionProtectingProcedureType = _prefix "assumptionProtectingProcedureType"
    /// <summary>
    /// Points to the body agreement where a tender has been awarded.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#awardAgreement"></see></summary>
    let awardAgreement = _prefix "awardAgreement"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#awardDate"></see>
    /// </summary>
    let awardDate = _prefix "awardDate"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#briefing"></see>
    /// </summary>
    let briefing = _prefix "briefing"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#budgetPrice"></see>
    /// </summary>
    let budgetPrice = _prefix "budgetPrice"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#price"></see>
    /// </summary>
    let price = _prefix "price"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#committee"></see>
    /// </summary>
    let committee = _prefix "committee"
    /// <summary>
    /// Relates a contract with a complementary contract.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#complementaryContract"></see></summary>
    let complementaryContract = _prefix "complementaryContract"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#compulsoryMeansForExecution"></see>
    /// </summary>
    let compulsoryMeansForExecution = _prefix "compulsoryMeansForExecution"
    /// <summary>
    /// Description of the public subsidies to construction works contracts.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#constructionSubsidies"></see></summary>
    let constructionSubsidies = _prefix "constructionSubsidies"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#contractActivites"></see>
    /// </summary>
    let contractActivites = _prefix "contractActivites"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#contractAdditionalObligations"></see>
    /// </summary>
    let contractAdditionalObligations = _prefix "contractAdditionalObligations"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#contractBodies"></see>
    /// </summary>
    let contractBodies = _prefix "contractBodies"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#contractEconomicConditions"></see>
    /// </summary>
    let contractEconomicConditions = _prefix "contractEconomicConditions"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#contractExecutionConditions"></see>
    /// </summary>
    let contractExecutionConditions = _prefix "contractExecutionConditions"
    /// <summary>
    /// Points to contract modifications being made.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#contractModification"></see></summary>
    let contractModification = _prefix "contractModification"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#contractModificationConditions"></see>
    /// </summary>
    let contractModificationConditions = _prefix "contractModificationConditions"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#contractObject"></see>
    /// </summary>
    let contractObject = _prefix "contractObject"
    /// <summary>
    /// Abstract property pointing to extinction of contract or procedure. Use any of its subclasses.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#contractOrProcedureExtinction"></see></summary>
    let contractOrProcedureExtinction = _prefix "contractOrProcedureExtinction"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#contractProcedureSpecifications"></see>
    /// </summary>
    let contractProcedureSpecifications = _prefix "contractProcedureSpecifications"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#contractResolution"></see>
    /// </summary>
    let contractResolution = _prefix "contractResolution"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#contractTemporalConditions"></see>
    /// </summary>
    let contractTemporalConditions = _prefix "contractTemporalConditions"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#contractingBody"></see>
    /// </summary>
    let contractingBody = _prefix "contractingBody"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#contractingBodyAgreement"></see>
    /// </summary>
    let contractingBodyAgreement = _prefix "contractingBodyAgreement"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#criterion"></see>
    /// </summary>
    let criterion = _prefix "criterion"
    /// <summary>
    /// Property textually describing the criterion evaluarion mode.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#criterionEvaluationMode"></see></summary>
    let criterionEvaluationMode = _prefix "criterionEvaluationMode"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#criterionMaxAndMinScores"></see>
    /// </summary>
    let criterionMaxAndMinScores = _prefix "criterionMaxAndMinScores"
    /// <summary>
    /// Property that points to an unique criterion and its score.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#criterionScore"></see></summary>
    let criterionScore = _prefix "criterionScore"
    /// <summary>
    /// Points to the authority that is delegating the contract.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#delegatingAuthority"></see></summary>
    let delegatingAuthority = _prefix "delegatingAuthority"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#durationChange"></see>
    /// </summary>
    let durationChange = _prefix "durationChange"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#earlyTramitation"></see>
    /// </summary>
    let earlyTramitation = _prefix "earlyTramitation"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#electronicAuction"></see>
    /// </summary>
    let electronicAuction = _prefix "electronicAuction"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#electronicAuctionPhase"></see>
    /// </summary>
    let electronicAuctionPhase = _prefix "electronicAuctionPhase"
    /// <summary>
    /// Property that indicated where the electronic auction is made or where we can look for more information about the auction.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#electronicAuctionWeb"></see></summary>
    let electronicAuctionWeb = _prefix "electronicAuctionWeb"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#endMode"></see>
    /// </summary>
    let endMode = _prefix "endMode"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#estimatedDuration"></see>
    /// </summary>
    let estimatedDuration = _prefix "estimatedDuration"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#estimatedEndDate"></see>
    /// </summary>
    let estimatedEndDate = _prefix "estimatedEndDate"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#estimatedValue"></see>
    /// </summary>
    let estimatedValue = _prefix "estimatedValue"
    /// <summary>
    /// Property to define alternative execution requirements (e.g. legal form to be adopted by tenderers).
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#executionRequeriments"></see></summary>
    let executionRequeriments = _prefix "executionRequeriments"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#expectedCauseModification"></see>
    /// </summary>
    let expectedCauseModification = _prefix "expectedCauseModification"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#extinctionCause"></see>
    /// </summary>
    let extinctionCause = _prefix "extinctionCause"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#feePrice"></see>
    /// </summary>
    let feePrice = _prefix "feePrice"
    /// <summary>
    /// The range of this property must be a percentage (i.e. float between 0.0 and 100.0)
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#finalFinancialGuarantee"></see></summary>
    let finalFinancialGuarantee = _prefix "finalFinancialGuarantee"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#finalFinancialGuaranteeDuration"></see>
    /// </summary>
    let finalFinancialGuaranteeDuration = _prefix "finalFinancialGuaranteeDuration"

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#frameworkAgreementDerivativeContract"></see>
    /// </summary>
    let frameworkAgreementDerivativeContract =
        _prefix "frameworkAgreementDerivativeContract"

    /// <summary>
    /// Points to a full member of a committee.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#fullMember"></see></summary>
    let fullMember = _prefix "fullMember"
    /// <summary>
    /// Property pointing to the type of the information is provided.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#informationKind"></see></summary>
    let informationKind = _prefix "informationKind"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#isNegotiable"></see>
    /// </summary>
    let isNegotiable = _prefix "isNegotiable"
    /// <summary>
    /// Property for attachment of an item to a tender.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#item"></see></summary>
    let item = _prefix "item"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#legalDocumentReference"></see>
    /// </summary>
    let legalDocumentReference = _prefix "legalDocumentReference"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#location"></see>
    /// </summary>
    let location = _prefix "location"
    /// <summary>
    /// Date where a remedy is lodged.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#lodgedRemedyDate"></see></summary>
    let lodgedRemedyDate = _prefix "lodgedRemedyDate"
    /// <summary>
    /// Property that points to the concept of the CPV code of an object.
    ///
    /// The concept used should be a valid representation of a CPV code, as it is in http://cpv.data.ac.uk/.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#mainObject"></see></summary>
    let mainObject = _prefix "mainObject"
    /// <summary>
    /// Property that indicates the managing departament responsible of the contract.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#managingDepartment"></see></summary>
    let managingDepartment = _prefix "managingDepartment"
    /// <summary>
    /// The range of this property must be a percentage (i.e. float between 0.0 and 100.0)
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#maxBudgetChange"></see></summary>
    let maxBudgetChange = _prefix "maxBudgetChange"
    /// <summary>
    /// The range of this property must be a percentage (i.e. float between 0.0 and 100.0)
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#maxFinalPriceChange"></see></summary>
    let maxFinalPriceChange = _prefix "maxFinalPriceChange"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#maxInvitations"></see>
    /// </summary>
    let maxInvitations = _prefix "maxInvitations"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#maxNumberOfOperators"></see>
    /// </summary>
    let maxNumberOfOperators = _prefix "maxNumberOfOperators"
    /// <summary>
    /// The range of this property must be a percentage (i.e. float between 0.0 and 100.0)
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#maxSubcontracting"></see></summary>
    let maxSubcontracting = _prefix "maxSubcontracting"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#minInvitations"></see>
    /// </summary>
    let minInvitations = _prefix "minInvitations"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#minNumberOfOperators"></see>
    /// </summary>
    let minNumberOfOperators = _prefix "minNumberOfOperators"
    /// <summary>
    /// The range of this property must be a percentage (i.e. float between 0.0 and 100.0)
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#minSubcontracting"></see></summary>
    let minSubcontracting = _prefix "minSubcontracting"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#minutesDocumentReference"></see>
    /// </summary>
    let minutesDocumentReference = _prefix "minutesDocumentReference"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#modificationReason"></see>
    /// </summary>
    let modificationReason = _prefix "modificationReason"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#modificationScope"></see>
    /// </summary>
    let modificationScope = _prefix "modificationScope"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#notice"></see>
    /// </summary>
    let notice = _prefix "notice"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#noticeDate"></see>
    /// </summary>
    let noticeDate = _prefix "noticeDate"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#noticeSentDate"></see>
    /// </summary>
    let noticeSentDate = _prefix "noticeSentDate"
    /// <summary>
    /// Property that indicates the sire where the notice is published. Normally it would be an official source, like the Official Jounral of the European Union, but it can be anywhere else, like press.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#noticeSite"></see></summary>
    let noticeSite = _prefix "noticeSite"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#noticeWeb"></see>
    /// </summary>
    let noticeWeb = _prefix "noticeWeb"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#offeredDuration"></see>
    /// </summary>
    let offeredDuration = _prefix "offeredDuration"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#offeredEndDate"></see>
    /// </summary>
    let offeredEndDate = _prefix "offeredEndDate"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#otherAbilityRequisites"></see>
    /// </summary>
    let otherAbilityRequisites = _prefix "otherAbilityRequisites"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#otherAwardTerms"></see>
    /// </summary>
    let otherAwardTerms = _prefix "otherAwardTerms"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#otherGuarantee"></see>
    /// </summary>
    let otherGuarantee = _prefix "otherGuarantee"
    /// <summary>
    /// The range of this property must be a percentage (i.e. float between 0.0 and 100.0)
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#pricePercentageChange"></see></summary>
    let pricePercentageChange = _prefix "pricePercentageChange"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#priceReviewAllowable"></see>
    /// </summary>
    let priceReviewAllowable = _prefix "priceReviewAllowable"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#priceReviewIndex"></see>
    /// </summary>
    let priceReviewIndex = _prefix "priceReviewIndex"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#procedureResignation"></see>
    /// </summary>
    let procedureResignation = _prefix "procedureResignation"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#procedureType"></see>
    /// </summary>
    let procedureType = _prefix "procedureType"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#procedureVoid"></see>
    /// </summary>
    let procedureVoid = _prefix "procedureVoid"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#procedureWaive"></see>
    /// </summary>
    let procedureWaive = _prefix "procedureWaive"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#prorogationsExpected"></see>
    /// </summary>
    let prorogationsExpected = _prefix "prorogationsExpected"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#provision"></see>
    /// </summary>
    let provision = _prefix "provision"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#provisionalFinancialGuarantee"></see>
    /// </summary>
    let provisionalFinancialGuarantee = _prefix "provisionalFinancialGuarantee"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#recurrentRemedy"></see>
    /// </summary>
    let recurrentRemedy = _prefix "recurrentRemedy"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#remedy"></see>
    /// </summary>
    let remedy = _prefix "remedy"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#remedyInterposedTo"></see>
    /// </summary>
    let remedyInterposedTo = _prefix "remedyInterposedTo"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#remedyReason"></see>
    /// </summary>
    let remedyReason = _prefix "remedyReason"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#remedyResolution"></see>
    /// </summary>
    let remedyResolution = _prefix "remedyResolution"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#remedyResolutionDate"></see>
    /// </summary>
    let remedyResolutionDate = _prefix "remedyResolutionDate"
    /// <summary>
    /// Contains the result of a lodged remedy. Normally it would contains values like "Estimated", "Rejected" or "Partially estimated".
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#remedyResult"></see></summary>
    let remedyResult = _prefix "remedyResult"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#requiredClassification"></see>
    /// </summary>
    let requiredClassification = _prefix "requiredClassification"

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#requiredEconomicAndFinancialStanding"></see>
    /// </summary>
    let requiredEconomicAndFinancialStanding =
        _prefix "requiredEconomicAndFinancialStanding"

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#requiredTechnicalAndProfessionalAbility"></see>
    /// </summary>
    let requiredTechnicalAndProfessionalAbility =
        _prefix "requiredTechnicalAndProfessionalAbility"

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#reservedContractRestrictions"></see>
    /// </summary>
    let reservedContractRestrictions = _prefix "reservedContractRestrictions"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#resolutionDocumentReference"></see>
    /// </summary>
    let resolutionDocumentReference = _prefix "resolutionDocumentReference"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#score"></see>
    /// </summary>
    let score = _prefix "score"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#technicalDocumentReference"></see>
    /// </summary>
    let technicalDocumentReference = _prefix "technicalDocumentReference"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#tenderAdmissionMeeting"></see>
    /// </summary>
    let tenderAdmissionMeeting = _prefix "tenderAdmissionMeeting"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#tenderBriefing"></see>
    /// </summary>
    let tenderBriefing = _prefix "tenderBriefing"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#tenderCommitteeAppointmentDate"></see>
    /// </summary>
    let tenderCommitteeAppointmentDate = _prefix "tenderCommitteeAppointmentDate"
    /// <summary>
    /// Indicated the role of a person inside the committee.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#tenderCommitteeRole"></see></summary>
    let tenderCommitteeRole = _prefix "tenderCommitteeRole"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#tenderDeadline"></see>
    /// </summary>
    let tenderDeadline = _prefix "tenderDeadline"
    /// <summary>
    /// Defines the necessary documentation a tender must include.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#tenderDocumentNeeds"></see></summary>
    let tenderDocumentNeeds = _prefix "tenderDocumentNeeds"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#tenderDossierStartDate"></see>
    /// </summary>
    let tenderDossierStartDate = _prefix "tenderDossierStartDate"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#tenderInformationProvider"></see>
    /// </summary>
    let tenderInformationProvider = _prefix "tenderInformationProvider"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#tenderManteinanceDuration"></see>
    /// </summary>
    let tenderManteinanceDuration = _prefix "tenderManteinanceDuration"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#tenderMeeting"></see>
    /// </summary>
    let tenderMeeting = _prefix "tenderMeeting"
    /// <summary>
    /// Indicates the purpose of the meeting (e.g. opening of first envelope).
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#tenderPurpose"></see></summary>
    let tenderPurpose = _prefix "tenderPurpose"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#tenderRequirements"></see>
    /// </summary>
    let tenderRequirements = _prefix "tenderRequirements"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#tenderSubmissionLocation"></see>
    /// </summary>
    let tenderSubmissionLocation = _prefix "tenderSubmissionLocation"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#tenderSubmissionMode"></see>
    /// </summary>
    let tenderSubmissionMode = _prefix "tenderSubmissionMode"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#tenderSubmissionSupportedLanguage"></see>
    /// </summary>
    let tenderSubmissionSupportedLanguage = _prefix "tenderSubmissionSupportedLanguage"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#tenderersRequirements"></see>
    /// </summary>
    let tenderersRequirements = _prefix "tenderersRequirements"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#urgencyType"></see>
    /// </summary>
    let urgencyType = _prefix "urgencyType"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#variantAdmission"></see>
    /// </summary>
    let variantAdmission = _prefix "variantAdmission"
    /// <summary>
    /// Property to describe the allowed variantes when submitting a variant of a contract.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#variantDescription"></see></summary>
    let variantDescription = _prefix "variantDescription"
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#websiteWithInformation"></see>
    /// </summary>
    let websiteWithInformation = _prefix "websiteWithInformation"
