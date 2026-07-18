namespace http.contsem.unizar.es.def.sector_publico.pproc.hash

open DoxAletheia.Rdf_Vocabulary

module pproc =
    let _namespace_name = "http://contsem.unizar.es/def/sector-publico/pproc#"

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#MixedContract"></see>
    /// </summary>
    let MixedContract =
        Namespaced_IRI.parse _namespace_name "MixedContract" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#PrecomercialProcurement"></see>
    /// </summary>
    let PrecomercialProcurement =
        Namespaced_IRI.parse _namespace_name "PrecomercialProcurement" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#PrivateContract"></see>
    /// </summary>
    let PrivateContract =
        Namespaced_IRI.parse _namespace_name "PrivateContract" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#PublicPrivatePartnershipContract"></see>
    /// </summary>
    let PublicPrivatePartnershipContract =
        Namespaced_IRI.parse _namespace_name "PublicPrivatePartnershipContract" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#PublicServicesManagementContract"></see>
    /// </summary>
    let PublicServicesManagementContract =
        Namespaced_IRI.parse _namespace_name "PublicServicesManagementContract" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#PublicWorksConcessionContract"></see>
    /// </summary>
    let PublicWorksConcessionContract =
        Namespaced_IRI.parse _namespace_name "PublicWorksConcessionContract" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#ServicesContract"></see>
    /// </summary>
    let ServicesContract =
        Namespaced_IRI.parse _namespace_name "ServicesContract" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#SpecialAdministrativeContract"></see>
    /// </summary>
    let SpecialAdministrativeContract =
        Namespaced_IRI.parse _namespace_name "SpecialAdministrativeContract" |> NamespacedName

    /// <summary>
    /// Class describing contracts whose object is the acquisition of supplies.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#SuppliesContract"></see></summary>
    let SuppliesContract =
        Namespaced_IRI.parse _namespace_name "SuppliesContract" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#WorksContract"></see>
    /// </summary>
    let WorksContract =
        Namespaced_IRI.parse _namespace_name "WorksContract" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#AdditionalInformationNotice"></see>
    /// </summary>
    let AdditionalInformationNotice =
        Namespaced_IRI.parse _namespace_name "AdditionalInformationNotice" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#ContractAwardNotice"></see>
    /// </summary>
    let ContractAwardNotice =
        Namespaced_IRI.parse _namespace_name "ContractAwardNotice" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#ContractNotice"></see>
    /// </summary>
    let ContractNotice =
        Namespaced_IRI.parse _namespace_name "ContractNotice" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#CorrectionNotice"></see>
    /// </summary>
    let CorrectionNotice =
        Namespaced_IRI.parse _namespace_name "CorrectionNotice" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#FormalizationNotice"></see>
    /// </summary>
    let FormalizationNotice =
        Namespaced_IRI.parse _namespace_name "FormalizationNotice" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#PriorInformationNotice"></see>
    /// </summary>
    let PriorInformationNotice =
        Namespaced_IRI.parse _namespace_name "PriorInformationNotice" |> NamespacedName

    /// <summary>
    /// Class of the contract that have lots.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#ContractWithLots"></see></summary>
    let ContractWithLots =
        Namespaced_IRI.parse _namespace_name "ContractWithLots" |> NamespacedName

    /// <summary>
    /// Class to describe the contract not divided into lots.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#ContractWithoutLots"></see></summary>
    let ContractWithoutLots =
        Namespaced_IRI.parse _namespace_name "ContractWithoutLots" |> NamespacedName

    /// <summary>
    /// Class describing contracts that are an actual lot of another contract.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#Lot"></see></summary>
    let Lot = Namespaced_IRI.parse _namespace_name "Lot" |> NamespacedName

    /// <summary>
    /// Class to describe the supplies contracts aimed to buy supplies.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#BuyContract"></see></summary>
    let BuyContract =
        Namespaced_IRI.parse _namespace_name "BuyContract" |> NamespacedName

    /// <summary>
    /// Class defining supplies contracts aimed to lease supplies.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#LeaseContract"></see></summary>
    let LeaseContract =
        Namespaced_IRI.parse _namespace_name "LeaseContract" |> NamespacedName

    /// <summary>
    /// Class defining supplies contracts aimed to rent supplies.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#RentContract"></see></summary>
    let RentContract =
        Namespaced_IRI.parse _namespace_name "RentContract" |> NamespacedName

    /// <summary>
    /// Class describing the contract concerts with natural or legal person performing similar services at the public service in question.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#AgreementContract"></see></summary>
    let AgreementContract =
        Namespaced_IRI.parse _namespace_name "AgreementContract" |> NamespacedName

    /// <summary>
    /// Class of the contracts in which the awarded tenderer manage the public service themselves.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#ConcessionContract"></see></summary>
    let ConcessionContract =
        Namespaced_IRI.parse _namespace_name "ConcessionContract" |> NamespacedName

    /// <summary>
    /// Class describing the contracts where the contracting authority participates concurrently with the natural or legal person.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#MixedCapitalCompanyContract"></see></summary>
    let MixedCapitalCompanyContract =
        Namespaced_IRI.parse _namespace_name "MixedCapitalCompanyContract" |> NamespacedName

    /// <summary>
    /// Class describing contracts whose operation results are shared among the contracting authority and the tenderer.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#SharedResultAgreementContract"></see></summary>
    let SharedResultAgreementContract =
        Namespaced_IRI.parse _namespace_name "SharedResultAgreementContract" |> NamespacedName

    /// <summary>
    /// Class describing the tenders accepted in the procurement public contract.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#AcceptedTender"></see></summary>
    let AcceptedTender =
        Namespaced_IRI.parse _namespace_name "AcceptedTender" |> NamespacedName

    /// <summary>
    /// Class that defines the tenders excluded from the procurement procedure.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#ExcludedTender"></see></summary>
    let ExcludedTender =
        Namespaced_IRI.parse _namespace_name "ExcludedTender" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#Notice"></see>
    /// </summary>
    let Notice = Namespaced_IRI.parse _namespace_name "Notice" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#AdministrativeInformation"></see>
    /// </summary>
    let AdministrativeInformation =
        Namespaced_IRI.parse _namespace_name "AdministrativeInformation" |> NamespacedName

    /// <summary>
    /// Scheme that indicates the type of the information that can be provided.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#InformationKindScheme"></see></summary>
    let InformationKindScheme =
        Namespaced_IRI.parse _namespace_name "InformationKindScheme" |> NamespacedName

    /// <summary>
    /// Class describing the awarded tenders.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#AwardedTender"></see></summary>
    let AwardedTender =
        Namespaced_IRI.parse _namespace_name "AwardedTender" |> NamespacedName

    /// <summary>
    /// Informative meeting about the public procurement contract.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#Briefing"></see></summary>
    let Briefing = Namespaced_IRI.parse _namespace_name "Briefing" |> NamespacedName

    /// <summary>
    /// Class used to describe the price a set of objets.
    ///
    /// Can be used to define the total price of an gr:Offering. Its value must be equal to the gr:UnitPriceSpecification multiplied by the number of items.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#BundlePriceSpecification"></see></summary>
    let BundlePriceSpecification =
        Namespaced_IRI.parse _namespace_name "BundlePriceSpecification" |> NamespacedName

    /// <summary>
    /// Abstract class describing a set of persons in committee and its roles.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#Committee"></see></summary>
    let Committee = Namespaced_IRI.parse _namespace_name "Committee" |> NamespacedName

    /// <summary>
    /// Class that describes the member a committee.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#CommitteeMember"></see></summary>
    let CommitteeMember =
        Namespaced_IRI.parse _namespace_name "CommitteeMember" |> NamespacedName

    /// <summary>
    /// Class describing the contracts consisting in the conclusion of a framework agreement or a dynamic purchasing system.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#ConclusionContract"></see></summary>
    let ConclusionContract =
        Namespaced_IRI.parse _namespace_name "ConclusionContract" |> NamespacedName

    /// <summary>
    /// Class used to describe a contract that is a declaration of a framework agreement or a dynamic purchasing system.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#FrameworkAgreement"></see></summary>
    let FrameworkAgreement =
        Namespaced_IRI.parse _namespace_name "FrameworkAgreement" |> NamespacedName

    /// <summary>
    /// Property that indicates the framework agreement in which the contract consists.
    ///
    /// This property is used when the actual contract consist in the declaration of a framework agreement or a dynamic purchasing system.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#frameworkAgreement"></see></summary>
    let frameworkAgreement =
        Namespaced_IRI.parse _namespace_name "frameworkAgreement" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#Contract"></see>
    /// </summary>
    let Contract = Namespaced_IRI.parse _namespace_name "Contract" |> NamespacedName

    /// <summary>
    /// Class describing contracts derived from a framework agreement or a dynamic purchasing system.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#DerivativeContract"></see></summary>
    let DerivativeContract =
        Namespaced_IRI.parse _namespace_name "DerivativeContract" |> NamespacedName

    /// <summary>
    /// Class describing all activities of a contract (e.g. meetings or agreements of the contracting body).
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#ContractActivities"></see></summary>
    let ContractActivities =
        Namespaced_IRI.parse _namespace_name "ContractActivities" |> NamespacedName

    /// <summary>
    /// Class describing the additional obligations the contract needs (e.g. guarantees or advertisement costs)
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#ContractAdditionalObligations"></see></summary>
    let ContractAdditionalObligations =
        Namespaced_IRI.parse _namespace_name "ContractAdditionalObligations" |> NamespacedName

    /// <summary>
    /// Class describing the bodies related to the contract.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#ContractBodies"></see></summary>
    let ContractBodies =
        Namespaced_IRI.parse _namespace_name "ContractBodies" |> NamespacedName

    /// <summary>
    /// Class defining the actual economic conditions of the contract (e.g. budget or the formula that describes the revision of its price).
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#ContractEconomicConditions"></see></summary>
    let ContractEconomicConditions =
        Namespaced_IRI.parse _namespace_name "ContractEconomicConditions" |> NamespacedName

    /// <summary>
    /// Class that defines the execution conditions of the contract (e.g. special execution conditions or subcontracting percentage amounts).
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#ContractExecutionConditions"></see></summary>
    let ContractExecutionConditions =
        Namespaced_IRI.parse _namespace_name "ContractExecutionConditions" |> NamespacedName

    /// <summary>
    /// During the execution of a contract it could happen that the contract should be modified, to describe these kind of situations we use this class.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#ContractModification"></see></summary>
    let ContractModification =
        Namespaced_IRI.parse _namespace_name "ContractModification" |> NamespacedName

    /// <summary>
    /// Class describing the conditions for which a contract can be modified (e.g. maximum percentage of its price or budget).
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#ContractModificationConditions"></see></summary>
    let ContractModificationConditions =
        Namespaced_IRI.parse _namespace_name "ContractModificationConditions" |> NamespacedName

    /// <summary>
    /// Class that defines the object of the contract and the conditions or modifications the contract can have.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#ContractObject"></see></summary>
    let ContractObject =
        Namespaced_IRI.parse _namespace_name "ContractObject" |> NamespacedName

    /// <summary>
    /// Abstract class. There are some circumstances resulting in the extinction of the procedure of the contract or the contract itself. To describe that situations we may use one of its subclasses.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#ContractOrProcedureExtinction"></see></summary>
    let ContractOrProcedureExtinction =
        Namespaced_IRI.parse _namespace_name "ContractOrProcedureExtinction" |> NamespacedName

    /// <summary>
    /// Class that specifies the procedure of a contract (e.g. type of procedure or its urgency).
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#ContractProcedureSpecifications"></see></summary>
    let ContractProcedureSpecifications =
        Namespaced_IRI.parse _namespace_name "ContractProcedureSpecifications" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#ContractResolution"></see>
    /// </summary>
    let ContractResolution =
        Namespaced_IRI.parse _namespace_name "ContractResolution" |> NamespacedName

    /// <summary>
    /// Class that describes the temporal conditions of the contract.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#ContractTemporalConditions"></see></summary>
    let ContractTemporalConditions =
        Namespaced_IRI.parse _namespace_name "ContractTemporalConditions" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#lot"></see>
    /// </summary>
    let lot = Namespaced_IRI.parse _namespace_name "lot" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#numberOfLots"></see>
    /// </summary>
    let numberOfLots =
        Namespaced_IRI.parse _namespace_name "numberOfLots" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#ContractingBodyAgreement"></see>
    /// </summary>
    let ContractingBodyAgreement =
        Namespaced_IRI.parse _namespace_name "ContractingBodyAgreement" |> NamespacedName

    /// <summary>
    /// Class to describe an award criterion and its score.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#CriterionScore"></see></summary>
    let CriterionScore =
        Namespaced_IRI.parse _namespace_name "CriterionScore" |> NamespacedName

    /// <summary>
    /// Class describing the contracts consisting in the conclusion of a dynamic purchasing system.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#DynamicPurchasingSystemConclusionContract"></see></summary>
    let DynamicPurchasingSystemConclusionContract =
        Namespaced_IRI.parse _namespace_name "DynamicPurchasingSystemConclusionContract" |> NamespacedName

    /// <summary>
    /// Class describing contracts derived from a dynamic purchasing system.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#DynamicPurchasingSystemDerivativeContract"></see></summary>
    let DynamicPurchasingSystemDerivativeContract =
        Namespaced_IRI.parse _namespace_name "DynamicPurchasingSystemDerivativeContract" |> NamespacedName

    /// <summary>
    /// Class that specifies the existence of an electronic auction of one or more of the award criterions.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#ElectronicAuction"></see></summary>
    let ElectronicAuction =
        Namespaced_IRI.parse _namespace_name "ElectronicAuction" |> NamespacedName

    /// <summary>
    /// Class describing a phase of an electronic auction.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#ElectronicAuctionPhase"></see></summary>
    let ElectronicAuctionPhase =
        Namespaced_IRI.parse _namespace_name "ElectronicAuctionPhase" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#Emergency"></see>
    /// </summary>
    let Emergency = Namespaced_IRI.parse _namespace_name "Emergency" |> NamespacedName

    /// <summary>
    /// Scheme that defines the kinds of urgency a procedure can follow.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#UrgencyTypeScheme"></see></summary>
    let UrgencyTypeScheme =
        Namespaced_IRI.parse _namespace_name "UrgencyTypeScheme" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#ExpertCommittee"></see>
    /// </summary>
    let ExpertCommittee =
        Namespaced_IRI.parse _namespace_name "ExpertCommittee" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#Express"></see>
    /// </summary>
    let Express = Namespaced_IRI.parse _namespace_name "Express" |> NamespacedName

    /// <summary>
    /// Class describing contracts whose end date can be extended.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#ExtendableContract"></see></summary>
    let ExtendableContract =
        Namespaced_IRI.parse _namespace_name "ExtendableContract" |> NamespacedName

    /// <summary>
    /// Class describing tenders being formalized.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#FormalizedTender"></see></summary>
    let FormalizedTender =
        Namespaced_IRI.parse _namespace_name "FormalizedTender" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#formalizedDate"></see>
    /// </summary>
    let formalizedDate =
        Namespaced_IRI.parse _namespace_name "formalizedDate" |> NamespacedName

    /// <summary>
    /// Class describing the contracts consisting in the conclusion of a framework agreement.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#FrameworkConclusionContract"></see></summary>
    let FrameworkConclusionContract =
        Namespaced_IRI.parse _namespace_name "FrameworkConclusionContract" |> NamespacedName

    /// <summary>
    /// Class describing contracts derived from a framework agreement.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#FrameworkDerivativeContract"></see></summary>
    let FrameworkDerivativeContract =
        Namespaced_IRI.parse _namespace_name "FrameworkDerivativeContract" |> NamespacedName

    /// <summary>
    /// Class to describe harmonized contracts (i.e. contracts that reachs the threshold to be treated as highlighted in the procurement Directives of the European Commision and European Council).
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#HarmonizedContract"></see></summary>
    let HarmonizedContract =
        Namespaced_IRI.parse _namespace_name "HarmonizedContract" |> NamespacedName

    /// <summary>
    /// Class defining the provider of information about the contract.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#InformationProvider"></see></summary>
    let InformationProvider =
        Namespaced_IRI.parse _namespace_name "InformationProvider" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#LegalRemedy"></see>
    /// </summary>
    let LegalRemedy =
        Namespaced_IRI.parse _namespace_name "LegalRemedy" |> NamespacedName

    /// <summary>
    /// Remedy lodged concerning a resolution about the procurement procedure.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#Remedy"></see></summary>
    let Remedy = Namespaced_IRI.parse _namespace_name "Remedy" |> NamespacedName
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#Minor"></see>
    /// </summary>
    let Minor = Namespaced_IRI.parse _namespace_name "Minor" |> NamespacedName

    /// <summary>
    /// Scheme defining the procedure to be followed in a tender.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#ProcedureTypeScheme"></see></summary>
    let ProcedureTypeScheme =
        Namespaced_IRI.parse _namespace_name "ProcedureTypeScheme" |> NamespacedName

    /// <summary>
    /// Class describing the multiannual contracts (i.e. contract whose duration extends over more than one financial year).
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#MultiannualContract"></see></summary>
    let MultiannualContract =
        Namespaced_IRI.parse _namespace_name "MultiannualContract" |> NamespacedName

    /// <summary>
    /// Abstract concept defining the procedure of the contract as negotiated.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#Negotiated"></see></summary>
    let Negotiated = Namespaced_IRI.parse _namespace_name "Negotiated" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#NegotiatedWithoutPublicity"></see>
    /// </summary>
    let NegotiatedWithoutPublicity =
        Namespaced_IRI.parse _namespace_name "NegotiatedWithoutPublicity" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#NegotiatedWithPublicity"></see>
    /// </summary>
    let NegotiatedWithPublicity =
        Namespaced_IRI.parse _namespace_name "NegotiatedWithPublicity" |> NamespacedName

    /// <summary>
    /// Class describing criterioa that depend on a value judgement.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#ObjectiveAwardCriterion"></see></summary>
    let ObjectiveAwardCriterion =
        Namespaced_IRI.parse _namespace_name "ObjectiveAwardCriterion" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#OrdinaryAdministrativeRemedy"></see>
    /// </summary>
    let OrdinaryAdministrativeRemedy =
        Namespaced_IRI.parse _namespace_name "OrdinaryAdministrativeRemedy" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#ProcedureResignation"></see>
    /// </summary>
    let ProcedureResignation =
        Namespaced_IRI.parse _namespace_name "ProcedureResignation" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#ProcedureVoid"></see>
    /// </summary>
    let ProcedureVoid =
        Namespaced_IRI.parse _namespace_name "ProcedureVoid" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#ProcedureWaive"></see>
    /// </summary>
    let ProcedureWaive =
        Namespaced_IRI.parse _namespace_name "ProcedureWaive" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#Regular"></see>
    /// </summary>
    let Regular = Namespaced_IRI.parse _namespace_name "Regular" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#RegularOpen"></see>
    /// </summary>
    let RegularOpen =
        Namespaced_IRI.parse _namespace_name "RegularOpen" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#SimpleOpen"></see>
    /// </summary>
    let SimpleOpen = Namespaced_IRI.parse _namespace_name "SimpleOpen" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#SpecialAdministrativeRemedy"></see>
    /// </summary>
    let SpecialAdministrativeRemedy =
        Namespaced_IRI.parse _namespace_name "SpecialAdministrativeRemedy" |> NamespacedName

    /// <summary>
    /// Class used to describe criteria that depend on a subjetive opinion.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#SubjectiveAwardCriterion"></see></summary>
    let SubjectiveAwardCriterion =
        Namespaced_IRI.parse _namespace_name "SubjectiveAwardCriterion" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#TechnicalCommittee"></see>
    /// </summary>
    let TechnicalCommittee =
        Namespaced_IRI.parse _namespace_name "TechnicalCommittee" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#TechnicalInformation"></see>
    /// </summary>
    let TechnicalInformation =
        Namespaced_IRI.parse _namespace_name "TechnicalInformation" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#TenderCommittee"></see>
    /// </summary>
    let TenderCommittee =
        Namespaced_IRI.parse _namespace_name "TenderCommittee" |> NamespacedName

    /// <summary>
    /// Class describing the meetings of tender committee.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#TenderMeeting"></see></summary>
    let TenderMeeting =
        Namespaced_IRI.parse _namespace_name "TenderMeeting" |> NamespacedName

    /// <summary>
    /// Class to define the tender requirements needed to submit a tender (e.g. tender document needs).
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#TenderRequirements"></see></summary>
    let TenderRequirements =
        Namespaced_IRI.parse _namespace_name "TenderRequirements" |> NamespacedName

    /// <summary>
    /// Class defining the tenderers requirements (e.g. required classification or financial capability).
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#TenderersRequirements"></see></summary>
    let TenderersRequirements =
        Namespaced_IRI.parse _namespace_name "TenderersRequirements" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#actualDuration"></see>
    /// </summary>
    let actualDuration =
        Namespaced_IRI.parse _namespace_name "actualDuration" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#duration"></see>
    /// </summary>
    let duration = Namespaced_IRI.parse _namespace_name "duration" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#additionalDocumentReference"></see>
    /// </summary>
    let additionalDocumentReference =
        Namespaced_IRI.parse _namespace_name "additionalDocumentReference" |> NamespacedName

    /// <summary>
    /// Links to external documents.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#documentReference"></see></summary>
    let documentReference =
        Namespaced_IRI.parse _namespace_name "documentReference" |> NamespacedName

    /// <summary>
    /// Property that points to the concept of the CPV code of an object.
    ///
    /// The concept used should be a valid representation of a CPV code, as it is in http://cpv.data.ac.uk/.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#additionalObject"></see></summary>
    let additionalObject =
        Namespaced_IRI.parse _namespace_name "additionalObject" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#advertisementAmount"></see>
    /// </summary>
    let advertisementAmount =
        Namespaced_IRI.parse _namespace_name "advertisementAmount" |> NamespacedName

    /// <summary>
    /// Points to an alternate member of a committee.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#alternateMember"></see></summary>
    let alternateMember =
        Namespaced_IRI.parse _namespace_name "alternateMember" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#assumptionProtectingProcedureType"></see>
    /// </summary>
    let assumptionProtectingProcedureType =
        Namespaced_IRI.parse _namespace_name "assumptionProtectingProcedureType" |> NamespacedName

    /// <summary>
    /// Points to the body agreement where a tender has been awarded.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#awardAgreement"></see></summary>
    let awardAgreement =
        Namespaced_IRI.parse _namespace_name "awardAgreement" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#awardDate"></see>
    /// </summary>
    let awardDate = Namespaced_IRI.parse _namespace_name "awardDate" |> NamespacedName
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#briefing"></see>
    /// </summary>
    let briefing = Namespaced_IRI.parse _namespace_name "briefing" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#budgetPrice"></see>
    /// </summary>
    let budgetPrice =
        Namespaced_IRI.parse _namespace_name "budgetPrice" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#price"></see>
    /// </summary>
    let price = Namespaced_IRI.parse _namespace_name "price" |> NamespacedName
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#committee"></see>
    /// </summary>
    let committee = Namespaced_IRI.parse _namespace_name "committee" |> NamespacedName

    /// <summary>
    /// Relates a contract with a complementary contract.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#complementaryContract"></see></summary>
    let complementaryContract =
        Namespaced_IRI.parse _namespace_name "complementaryContract" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#compulsoryMeansForExecution"></see>
    /// </summary>
    let compulsoryMeansForExecution =
        Namespaced_IRI.parse _namespace_name "compulsoryMeansForExecution" |> NamespacedName

    /// <summary>
    /// Description of the public subsidies to construction works contracts.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#constructionSubsidies"></see></summary>
    let constructionSubsidies =
        Namespaced_IRI.parse _namespace_name "constructionSubsidies" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#contractActivites"></see>
    /// </summary>
    let contractActivites =
        Namespaced_IRI.parse _namespace_name "contractActivites" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#contractAdditionalObligations"></see>
    /// </summary>
    let contractAdditionalObligations =
        Namespaced_IRI.parse _namespace_name "contractAdditionalObligations" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#contractBodies"></see>
    /// </summary>
    let contractBodies =
        Namespaced_IRI.parse _namespace_name "contractBodies" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#contractEconomicConditions"></see>
    /// </summary>
    let contractEconomicConditions =
        Namespaced_IRI.parse _namespace_name "contractEconomicConditions" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#contractExecutionConditions"></see>
    /// </summary>
    let contractExecutionConditions =
        Namespaced_IRI.parse _namespace_name "contractExecutionConditions" |> NamespacedName

    /// <summary>
    /// Points to contract modifications being made.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#contractModification"></see></summary>
    let contractModification =
        Namespaced_IRI.parse _namespace_name "contractModification" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#contractModificationConditions"></see>
    /// </summary>
    let contractModificationConditions =
        Namespaced_IRI.parse _namespace_name "contractModificationConditions" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#contractObject"></see>
    /// </summary>
    let contractObject =
        Namespaced_IRI.parse _namespace_name "contractObject" |> NamespacedName

    /// <summary>
    /// Abstract property pointing to extinction of contract or procedure. Use any of its subclasses.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#contractOrProcedureExtinction"></see></summary>
    let contractOrProcedureExtinction =
        Namespaced_IRI.parse _namespace_name "contractOrProcedureExtinction" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#contractProcedureSpecifications"></see>
    /// </summary>
    let contractProcedureSpecifications =
        Namespaced_IRI.parse _namespace_name "contractProcedureSpecifications" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#contractResolution"></see>
    /// </summary>
    let contractResolution =
        Namespaced_IRI.parse _namespace_name "contractResolution" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#contractTemporalConditions"></see>
    /// </summary>
    let contractTemporalConditions =
        Namespaced_IRI.parse _namespace_name "contractTemporalConditions" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#contractingBody"></see>
    /// </summary>
    let contractingBody =
        Namespaced_IRI.parse _namespace_name "contractingBody" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#contractingBodyAgreement"></see>
    /// </summary>
    let contractingBodyAgreement =
        Namespaced_IRI.parse _namespace_name "contractingBodyAgreement" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#criterion"></see>
    /// </summary>
    let criterion = Namespaced_IRI.parse _namespace_name "criterion" |> NamespacedName

    /// <summary>
    /// Property textually describing the criterion evaluarion mode.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#criterionEvaluationMode"></see></summary>
    let criterionEvaluationMode =
        Namespaced_IRI.parse _namespace_name "criterionEvaluationMode" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#criterionMaxAndMinScores"></see>
    /// </summary>
    let criterionMaxAndMinScores =
        Namespaced_IRI.parse _namespace_name "criterionMaxAndMinScores" |> NamespacedName

    /// <summary>
    /// Property that points to an unique criterion and its score.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#criterionScore"></see></summary>
    let criterionScore =
        Namespaced_IRI.parse _namespace_name "criterionScore" |> NamespacedName

    /// <summary>
    /// Points to the authority that is delegating the contract.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#delegatingAuthority"></see></summary>
    let delegatingAuthority =
        Namespaced_IRI.parse _namespace_name "delegatingAuthority" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#durationChange"></see>
    /// </summary>
    let durationChange =
        Namespaced_IRI.parse _namespace_name "durationChange" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#earlyTramitation"></see>
    /// </summary>
    let earlyTramitation =
        Namespaced_IRI.parse _namespace_name "earlyTramitation" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#electronicAuction"></see>
    /// </summary>
    let electronicAuction =
        Namespaced_IRI.parse _namespace_name "electronicAuction" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#electronicAuctionPhase"></see>
    /// </summary>
    let electronicAuctionPhase =
        Namespaced_IRI.parse _namespace_name "electronicAuctionPhase" |> NamespacedName

    /// <summary>
    /// Property that indicated where the electronic auction is made or where we can look for more information about the auction.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#electronicAuctionWeb"></see></summary>
    let electronicAuctionWeb =
        Namespaced_IRI.parse _namespace_name "electronicAuctionWeb" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#endMode"></see>
    /// </summary>
    let endMode = Namespaced_IRI.parse _namespace_name "endMode" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#estimatedDuration"></see>
    /// </summary>
    let estimatedDuration =
        Namespaced_IRI.parse _namespace_name "estimatedDuration" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#estimatedEndDate"></see>
    /// </summary>
    let estimatedEndDate =
        Namespaced_IRI.parse _namespace_name "estimatedEndDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#estimatedValue"></see>
    /// </summary>
    let estimatedValue =
        Namespaced_IRI.parse _namespace_name "estimatedValue" |> NamespacedName

    /// <summary>
    /// Property to define alternative execution requirements (e.g. legal form to be adopted by tenderers).
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#executionRequeriments"></see></summary>
    let executionRequeriments =
        Namespaced_IRI.parse _namespace_name "executionRequeriments" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#expectedCauseModification"></see>
    /// </summary>
    let expectedCauseModification =
        Namespaced_IRI.parse _namespace_name "expectedCauseModification" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#extinctionCause"></see>
    /// </summary>
    let extinctionCause =
        Namespaced_IRI.parse _namespace_name "extinctionCause" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#feePrice"></see>
    /// </summary>
    let feePrice = Namespaced_IRI.parse _namespace_name "feePrice" |> NamespacedName

    /// <summary>
    /// The range of this property must be a percentage (i.e. float between 0.0 and 100.0)
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#finalFinancialGuarantee"></see></summary>
    let finalFinancialGuarantee =
        Namespaced_IRI.parse _namespace_name "finalFinancialGuarantee" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#finalFinancialGuaranteeDuration"></see>
    /// </summary>
    let finalFinancialGuaranteeDuration =
        Namespaced_IRI.parse _namespace_name "finalFinancialGuaranteeDuration" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#frameworkAgreementDerivativeContract"></see>
    /// </summary>
    let frameworkAgreementDerivativeContract =
        Namespaced_IRI.parse _namespace_name "frameworkAgreementDerivativeContract" |> NamespacedName

    /// <summary>
    /// Points to a full member of a committee.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#fullMember"></see></summary>
    let fullMember = Namespaced_IRI.parse _namespace_name "fullMember" |> NamespacedName

    /// <summary>
    /// Property pointing to the type of the information is provided.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#informationKind"></see></summary>
    let informationKind =
        Namespaced_IRI.parse _namespace_name "informationKind" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#isNegotiable"></see>
    /// </summary>
    let isNegotiable =
        Namespaced_IRI.parse _namespace_name "isNegotiable" |> NamespacedName

    /// <summary>
    /// Property for attachment of an item to a tender.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#item"></see></summary>
    let item = Namespaced_IRI.parse _namespace_name "item" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#legalDocumentReference"></see>
    /// </summary>
    let legalDocumentReference =
        Namespaced_IRI.parse _namespace_name "legalDocumentReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#location"></see>
    /// </summary>
    let location = Namespaced_IRI.parse _namespace_name "location" |> NamespacedName

    /// <summary>
    /// Date where a remedy is lodged.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#lodgedRemedyDate"></see></summary>
    let lodgedRemedyDate =
        Namespaced_IRI.parse _namespace_name "lodgedRemedyDate" |> NamespacedName

    /// <summary>
    /// Property that points to the concept of the CPV code of an object.
    ///
    /// The concept used should be a valid representation of a CPV code, as it is in http://cpv.data.ac.uk/.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#mainObject"></see></summary>
    let mainObject = Namespaced_IRI.parse _namespace_name "mainObject" |> NamespacedName

    /// <summary>
    /// Property that indicates the managing departament responsible of the contract.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#managingDepartment"></see></summary>
    let managingDepartment =
        Namespaced_IRI.parse _namespace_name "managingDepartment" |> NamespacedName

    /// <summary>
    /// The range of this property must be a percentage (i.e. float between 0.0 and 100.0)
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#maxBudgetChange"></see></summary>
    let maxBudgetChange =
        Namespaced_IRI.parse _namespace_name "maxBudgetChange" |> NamespacedName

    /// <summary>
    /// The range of this property must be a percentage (i.e. float between 0.0 and 100.0)
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#maxFinalPriceChange"></see></summary>
    let maxFinalPriceChange =
        Namespaced_IRI.parse _namespace_name "maxFinalPriceChange" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#maxInvitations"></see>
    /// </summary>
    let maxInvitations =
        Namespaced_IRI.parse _namespace_name "maxInvitations" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#maxNumberOfOperators"></see>
    /// </summary>
    let maxNumberOfOperators =
        Namespaced_IRI.parse _namespace_name "maxNumberOfOperators" |> NamespacedName

    /// <summary>
    /// The range of this property must be a percentage (i.e. float between 0.0 and 100.0)
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#maxSubcontracting"></see></summary>
    let maxSubcontracting =
        Namespaced_IRI.parse _namespace_name "maxSubcontracting" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#minInvitations"></see>
    /// </summary>
    let minInvitations =
        Namespaced_IRI.parse _namespace_name "minInvitations" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#minNumberOfOperators"></see>
    /// </summary>
    let minNumberOfOperators =
        Namespaced_IRI.parse _namespace_name "minNumberOfOperators" |> NamespacedName

    /// <summary>
    /// The range of this property must be a percentage (i.e. float between 0.0 and 100.0)
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#minSubcontracting"></see></summary>
    let minSubcontracting =
        Namespaced_IRI.parse _namespace_name "minSubcontracting" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#minutesDocumentReference"></see>
    /// </summary>
    let minutesDocumentReference =
        Namespaced_IRI.parse _namespace_name "minutesDocumentReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#modificationReason"></see>
    /// </summary>
    let modificationReason =
        Namespaced_IRI.parse _namespace_name "modificationReason" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#modificationScope"></see>
    /// </summary>
    let modificationScope =
        Namespaced_IRI.parse _namespace_name "modificationScope" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#notice"></see>
    /// </summary>
    let notice = Namespaced_IRI.parse _namespace_name "notice" |> NamespacedName
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#noticeDate"></see>
    /// </summary>
    let noticeDate = Namespaced_IRI.parse _namespace_name "noticeDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#noticeSentDate"></see>
    /// </summary>
    let noticeSentDate =
        Namespaced_IRI.parse _namespace_name "noticeSentDate" |> NamespacedName

    /// <summary>
    /// Property that indicates the sire where the notice is published. Normally it would be an official source, like the Official Jounral of the European Union, but it can be anywhere else, like press.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#noticeSite"></see></summary>
    let noticeSite = Namespaced_IRI.parse _namespace_name "noticeSite" |> NamespacedName
    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#noticeWeb"></see>
    /// </summary>
    let noticeWeb = Namespaced_IRI.parse _namespace_name "noticeWeb" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#offeredDuration"></see>
    /// </summary>
    let offeredDuration =
        Namespaced_IRI.parse _namespace_name "offeredDuration" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#offeredEndDate"></see>
    /// </summary>
    let offeredEndDate =
        Namespaced_IRI.parse _namespace_name "offeredEndDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#otherAbilityRequisites"></see>
    /// </summary>
    let otherAbilityRequisites =
        Namespaced_IRI.parse _namespace_name "otherAbilityRequisites" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#otherAwardTerms"></see>
    /// </summary>
    let otherAwardTerms =
        Namespaced_IRI.parse _namespace_name "otherAwardTerms" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#otherGuarantee"></see>
    /// </summary>
    let otherGuarantee =
        Namespaced_IRI.parse _namespace_name "otherGuarantee" |> NamespacedName

    /// <summary>
    /// The range of this property must be a percentage (i.e. float between 0.0 and 100.0)
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#pricePercentageChange"></see></summary>
    let pricePercentageChange =
        Namespaced_IRI.parse _namespace_name "pricePercentageChange" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#priceReviewAllowable"></see>
    /// </summary>
    let priceReviewAllowable =
        Namespaced_IRI.parse _namespace_name "priceReviewAllowable" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#priceReviewIndex"></see>
    /// </summary>
    let priceReviewIndex =
        Namespaced_IRI.parse _namespace_name "priceReviewIndex" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#procedureResignation"></see>
    /// </summary>
    let procedureResignation =
        Namespaced_IRI.parse _namespace_name "procedureResignation" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#procedureType"></see>
    /// </summary>
    let procedureType =
        Namespaced_IRI.parse _namespace_name "procedureType" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#procedureVoid"></see>
    /// </summary>
    let procedureVoid =
        Namespaced_IRI.parse _namespace_name "procedureVoid" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#procedureWaive"></see>
    /// </summary>
    let procedureWaive =
        Namespaced_IRI.parse _namespace_name "procedureWaive" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#prorogationsExpected"></see>
    /// </summary>
    let prorogationsExpected =
        Namespaced_IRI.parse _namespace_name "prorogationsExpected" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#provision"></see>
    /// </summary>
    let provision = Namespaced_IRI.parse _namespace_name "provision" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#provisionalFinancialGuarantee"></see>
    /// </summary>
    let provisionalFinancialGuarantee =
        Namespaced_IRI.parse _namespace_name "provisionalFinancialGuarantee" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#recurrentRemedy"></see>
    /// </summary>
    let recurrentRemedy =
        Namespaced_IRI.parse _namespace_name "recurrentRemedy" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#remedy"></see>
    /// </summary>
    let remedy = Namespaced_IRI.parse _namespace_name "remedy" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#remedyInterposedTo"></see>
    /// </summary>
    let remedyInterposedTo =
        Namespaced_IRI.parse _namespace_name "remedyInterposedTo" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#remedyReason"></see>
    /// </summary>
    let remedyReason =
        Namespaced_IRI.parse _namespace_name "remedyReason" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#remedyResolution"></see>
    /// </summary>
    let remedyResolution =
        Namespaced_IRI.parse _namespace_name "remedyResolution" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#remedyResolutionDate"></see>
    /// </summary>
    let remedyResolutionDate =
        Namespaced_IRI.parse _namespace_name "remedyResolutionDate" |> NamespacedName

    /// <summary>
    /// Contains the result of a lodged remedy. Normally it would contains values like "Estimated", "Rejected" or "Partially estimated".
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#remedyResult"></see></summary>
    let remedyResult =
        Namespaced_IRI.parse _namespace_name "remedyResult" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#requiredClassification"></see>
    /// </summary>
    let requiredClassification =
        Namespaced_IRI.parse _namespace_name "requiredClassification" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#requiredEconomicAndFinancialStanding"></see>
    /// </summary>
    let requiredEconomicAndFinancialStanding =
        Namespaced_IRI.parse _namespace_name "requiredEconomicAndFinancialStanding" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#requiredTechnicalAndProfessionalAbility"></see>
    /// </summary>
    let requiredTechnicalAndProfessionalAbility =
        Namespaced_IRI.parse _namespace_name "requiredTechnicalAndProfessionalAbility" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#reservedContractRestrictions"></see>
    /// </summary>
    let reservedContractRestrictions =
        Namespaced_IRI.parse _namespace_name "reservedContractRestrictions" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#resolutionDocumentReference"></see>
    /// </summary>
    let resolutionDocumentReference =
        Namespaced_IRI.parse _namespace_name "resolutionDocumentReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#score"></see>
    /// </summary>
    let score = Namespaced_IRI.parse _namespace_name "score" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#technicalDocumentReference"></see>
    /// </summary>
    let technicalDocumentReference =
        Namespaced_IRI.parse _namespace_name "technicalDocumentReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#tenderAdmissionMeeting"></see>
    /// </summary>
    let tenderAdmissionMeeting =
        Namespaced_IRI.parse _namespace_name "tenderAdmissionMeeting" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#tenderBriefing"></see>
    /// </summary>
    let tenderBriefing =
        Namespaced_IRI.parse _namespace_name "tenderBriefing" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#tenderCommitteeAppointmentDate"></see>
    /// </summary>
    let tenderCommitteeAppointmentDate =
        Namespaced_IRI.parse _namespace_name "tenderCommitteeAppointmentDate" |> NamespacedName

    /// <summary>
    /// Indicated the role of a person inside the committee.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#tenderCommitteeRole"></see></summary>
    let tenderCommitteeRole =
        Namespaced_IRI.parse _namespace_name "tenderCommitteeRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#tenderDeadline"></see>
    /// </summary>
    let tenderDeadline =
        Namespaced_IRI.parse _namespace_name "tenderDeadline" |> NamespacedName

    /// <summary>
    /// Defines the necessary documentation a tender must include.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#tenderDocumentNeeds"></see></summary>
    let tenderDocumentNeeds =
        Namespaced_IRI.parse _namespace_name "tenderDocumentNeeds" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#tenderDossierStartDate"></see>
    /// </summary>
    let tenderDossierStartDate =
        Namespaced_IRI.parse _namespace_name "tenderDossierStartDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#tenderInformationProvider"></see>
    /// </summary>
    let tenderInformationProvider =
        Namespaced_IRI.parse _namespace_name "tenderInformationProvider" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#tenderManteinanceDuration"></see>
    /// </summary>
    let tenderManteinanceDuration =
        Namespaced_IRI.parse _namespace_name "tenderManteinanceDuration" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#tenderMeeting"></see>
    /// </summary>
    let tenderMeeting =
        Namespaced_IRI.parse _namespace_name "tenderMeeting" |> NamespacedName

    /// <summary>
    /// Indicates the purpose of the meeting (e.g. opening of first envelope).
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#tenderPurpose"></see></summary>
    let tenderPurpose =
        Namespaced_IRI.parse _namespace_name "tenderPurpose" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#tenderRequirements"></see>
    /// </summary>
    let tenderRequirements =
        Namespaced_IRI.parse _namespace_name "tenderRequirements" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#tenderSubmissionLocation"></see>
    /// </summary>
    let tenderSubmissionLocation =
        Namespaced_IRI.parse _namespace_name "tenderSubmissionLocation" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#tenderSubmissionMode"></see>
    /// </summary>
    let tenderSubmissionMode =
        Namespaced_IRI.parse _namespace_name "tenderSubmissionMode" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#tenderSubmissionSupportedLanguage"></see>
    /// </summary>
    let tenderSubmissionSupportedLanguage =
        Namespaced_IRI.parse _namespace_name "tenderSubmissionSupportedLanguage" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#tenderersRequirements"></see>
    /// </summary>
    let tenderersRequirements =
        Namespaced_IRI.parse _namespace_name "tenderersRequirements" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#urgencyType"></see>
    /// </summary>
    let urgencyType =
        Namespaced_IRI.parse _namespace_name "urgencyType" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#variantAdmission"></see>
    /// </summary>
    let variantAdmission =
        Namespaced_IRI.parse _namespace_name "variantAdmission" |> NamespacedName

    /// <summary>
    /// Property to describe the allowed variantes when submitting a variant of a contract.
    /// <see href="http://contsem.unizar.es/def/sector-publico/pproc#variantDescription"></see></summary>
    let variantDescription =
        Namespaced_IRI.parse _namespace_name "variantDescription" |> NamespacedName

    /// <summary>
    ///   <see href="http://contsem.unizar.es/def/sector-publico/pproc#websiteWithInformation"></see>
    /// </summary>
    let websiteWithInformation =
        Namespaced_IRI.parse _namespace_name "websiteWithInformation" |> NamespacedName
