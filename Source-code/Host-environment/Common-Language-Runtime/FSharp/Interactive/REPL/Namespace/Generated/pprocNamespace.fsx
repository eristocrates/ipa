#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module pproc =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://contsem.unizar.es/def/sector-publico/pproc#" "pproc"

    /// <summary>
    ///   <para>rdfs:label : Accepted tenderrdfs:label : Oferta admitida</para>
    ///   <para>rdfs:comment : Class describing the tenders accepted in the procurement public contract.rdfs:comment : Clase para definir las ofertas que se han admitido a licitación.</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#AcceptedTender">pproc:AcceptedTender</a>
    /// </summary>
    let AcceptedTender = _prefixId.prefix "AcceptedTender"
    /// <summary>
    ///   <para>rdfs:label : Additional information noticerdfs:label : Anuncio de información adicional</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#AdditionalInformationNotice">pproc:AdditionalInformationNotice</a>
    /// </summary>
    let AdditionalInformationNotice = _prefixId.prefix "AdditionalInformationNotice"
    let AdministrativeInformation = _prefixId.prefix "AdministrativeInformation"
    /// <summary>
    ///   <para>rdfs:label : Agreement contractrdfs:label : Concierto</para>
    ///   <para>rdfs:comment : Class describing the contract concerts with natural or legal person performing similar services at the public service in question.rdfs:comment : Contrato de los conciertos con persona natural o jurídica que venga realizando prestaciones análogas a las que constituyen el servicio público de que se trate.</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#AgreementContract">pproc:AgreementContract</a>
    /// </summary>
    let AgreementContract = _prefixId.prefix "AgreementContract"
    /// <summary>
    ///   <para>rdfs:label : Awarded tenderrdfs:label : Oferta adjudicada</para>
    ///   <para>rdfs:comment : Class describing the awarded tenders.rdfs:comment : Clase para definir las oferta que han sido adjudicadas.</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#AwardedTender">pproc:AwardedTender</a>
    /// </summary>
    let AwardedTender = _prefixId.prefix "AwardedTender"
    /// <summary>
    ///   <para>rdfs:label : Briefingrdfs:label : Reunión informativa</para>
    ///   <para>rdfs:comment : Informative meeting about the public procurement contract.rdfs:comment : Reunión informativa sobre la licitación del contrato.</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#Briefing">pproc:Briefing</a>
    /// </summary>
    let Briefing = _prefixId.prefix "Briefing"
    /// <summary>
    ///   <para>rdfs:label : Bundle pricerdfs:label : Precio de paquete</para>
    ///   <para>rdfs:comment : Class used to describe the price a set of objets.
    ///
    /// Can be used to define the total price of an gr:Offering. Its value must be equal to the gr:UnitPriceSpecification multiplied by the number of items.rdfs:comment : Clase que representa el precio de conjuntos de objetos o un paquete determinado.
    ///
    /// Se utiliza para especificar el precio de la clase gr:Offering cuando este precio se refiere al del conjunto de los objetos (y no a su precio unitario).</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#BundlePriceSpecification">pproc:BundlePriceSpecification</a>
    /// </summary>
    let BundlePriceSpecification = _prefixId.prefix "BundlePriceSpecification"
    /// <summary>
    ///   <para>rdfs:label : Buy contractrdfs:label : Contrato de compra</para>
    ///   <para>rdfs:comment : Class to describe the supplies contracts aimed to buy supplies.rdfs:comment : Clase de los contratos de suministros cuyo objeto es la compra de bienes.</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#BuyContract">pproc:BuyContract</a>
    /// </summary>
    let BuyContract = _prefixId.prefix "BuyContract"
    /// <summary>
    ///   <para>rdfs:label : Tender committeerdfs:label : Comité de contratación</para>
    ///   <para>rdfs:comment : Abstract class describing a set of persons in committee and its roles.rdfs:comment : Clase abstracta que representa un conjunto de personas en comité y sus roles dentro del esta agrupación.</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#Committee">pproc:Committee</a>
    /// </summary>
    let Committee = _prefixId.prefix "Committee"
    /// <summary>
    ///   <para>rdfs:label : Committee memberrdfs:label : Miembro del comité</para>
    ///   <para>rdfs:comment : Class that describes the member a committee.rdfs:comment : Miembro perteneciente a un comité de contratación concreto.</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#CommitteeMember">pproc:CommitteeMember</a>
    /// </summary>
    let CommitteeMember = _prefixId.prefix "CommitteeMember"
    /// <summary>
    ///   <para>rdfs:label : Concession contractrdfs:label : Concesión</para>
    ///   <para>rdfs:comment : Class of the contracts in which the awarded tenderer manage the public service themselves.rdfs:comment : Clase de los contratos en los que el empresario gestionará el servicio a su propio riesgo y ventura.</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#ConcessionContract">pproc:ConcessionContract</a>
    /// </summary>
    let ConcessionContract = _prefixId.prefix "ConcessionContract"
    /// <summary>
    ///   <para>rdfs:label : Conclusion contractrdfs:label : Contrato de establecimiento</para>
    ///   <para>rdfs:comment : Class describing the contracts consisting in the conclusion of a framework agreement or a dynamic purchasing system.rdfs:comment : Clase de los contratos que consisten en el establecimiento de un acuerdo marco o un sistema dinámico de contratación.</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#ConclusionContract">pproc:ConclusionContract</a>
    /// </summary>
    let ConclusionContract = _prefixId.prefix "ConclusionContract"
    /// <summary>
    ///   <para>rdfs:label : Public contractrdfs:label : Contrato público</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#Contract">pproc:Contract</a>
    /// </summary>
    let Contract = _prefixId.prefix "Contract"
    /// <summary>
    ///   <para>rdfs:label : Contract activitesrdfs:label : Trámites del contrato</para>
    ///   <para>rdfs:comment : Class describing all activities of a contract (e.g. meetings or agreements of the contracting body).rdfs:comment : Clase que engloba todos los trámites de un contrato (e.g. reuniones ó acuerdos del órgano de contratación).</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#ContractActivities">pproc:ContractActivities</a>
    /// </summary>
    let ContractActivities = _prefixId.prefix "ContractActivities"
    /// <summary>
    ///   <para>rdfs:label : Contract additional obligationsrdfs:label : Obligaciones accesorias del contrato</para>
    ///   <para>rdfs:comment : Class describing the additional obligations the contract needs (e.g. guarantees or advertisement costs)rdfs:comment : Clase que define las obligaciones accesorias de un contrato (e.g. garantías ó gastos de publicidad).</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#ContractAdditionalObligations">pproc:ContractAdditionalObligations</a>
    /// </summary>
    let ContractAdditionalObligations = _prefixId.prefix "ContractAdditionalObligations"
    /// <summary>
    ///   <para>rdfs:label : Contract award noticerdfs:label : Anuncio de adjudicación</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#ContractAwardNotice">pproc:ContractAwardNotice</a>
    /// </summary>
    let ContractAwardNotice = _prefixId.prefix "ContractAwardNotice"
    /// <summary>
    ///   <para>rdfs:label : Contract bodiesrdfs:label : Órganos del contrato</para>
    ///   <para>rdfs:comment : Class describing the bodies related to the contract.rdfs:comment : Clase que engloba los órganos relacionados con un contrato (e.g. mesa de contratación ó comité de expertos).</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#ContractBodies">pproc:ContractBodies</a>
    /// </summary>
    let ContractBodies = _prefixId.prefix "ContractBodies"
    /// <summary>
    ///   <para>rdfs:label : Contract economic conditionsrdfs:label : Condiciones económicas del contrato</para>
    ///   <para>rdfs:comment : Class defining the actual economic conditions of the contract (e.g. budget or the formula that describes the revision of its price).rdfs:comment : Clase que define las condiciones económicas del contrato (e.g. presupuesto ó revisión de precios).</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#ContractEconomicConditions">pproc:ContractEconomicConditions</a>
    /// </summary>
    let ContractEconomicConditions = _prefixId.prefix "ContractEconomicConditions"
    /// <summary>
    ///   <para>rdfs:label : Contract execution conditionsrdfs:label : Condiciones de ejecución del contrato</para>
    ///   <para>rdfs:comment : Class that defines the execution conditions of the contract (e.g. special execution conditions or subcontracting percentage amounts).rdfs:comment : Clase que define las condiciones de ejecución de un contrato (e.g. condiciones especiales ó subcontratación).</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#ContractExecutionConditions">pproc:ContractExecutionConditions</a>
    /// </summary>
    let ContractExecutionConditions = _prefixId.prefix "ContractExecutionConditions"
    /// <summary>
    ///   <para>rdfs:label : Contract modificationrdfs:label : Modificación del contrato</para>
    ///   <para>rdfs:comment : During the execution of a contract it could happen that the contract should be modified, to describe these kind of situations we use this class.rdfs:comment : Durante un contrato se puede dar también la necesidad de modificarlo una vez iniciada su ejecución, para plasmar este tipo de casos se debe utilizar esta clase.</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#ContractModification">pproc:ContractModification</a>
    /// </summary>
    let ContractModification = _prefixId.prefix "ContractModification"

    /// <summary>
    ///   <para>rdfs:label : Contract modification conditionsrdfs:label : Condiciones para la modificación del contrato</para>
    ///   <para>rdfs:comment : Class describing the conditions for which a contract can be modified (e.g. maximum percentage of its price or budget).rdfs:comment : Clase que define las condiciones para la modificación de un contrato (e.g. porcentaje máximo de modificación del presupuesto).</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#ContractModificationConditions">pproc:ContractModificationConditions</a>
    /// </summary>
    let ContractModificationConditions =
        _prefixId.prefix "ContractModificationConditions"

    /// <summary>
    ///   <para>rdfs:label : Contract noticerdfs:label : Anuncio de licitación</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#ContractNotice">pproc:ContractNotice</a>
    /// </summary>
    let ContractNotice = _prefixId.prefix "ContractNotice"
    /// <summary>
    ///   <para>rdfs:label : Contract objectrdfs:label : Objeto del contato</para>
    ///   <para>rdfs:comment : Class that defines the object of the contract and the conditions or modifications the contract can have.rdfs:comment : Clase que define el objeto del contrato y las diferentes condiciones, obligaciones y modificaciones de este.</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#ContractObject">pproc:ContractObject</a>
    /// </summary>
    let ContractObject = _prefixId.prefix "ContractObject"
    /// <summary>
    ///   <para>rdfs:label : Contract or procedure extinctionrdfs:label : Extinción del contrato o del procedimiento</para>
    ///   <para>rdfs:comment : Abstract class. There are some circumstances resulting in the extinction of the procedure of the contract or the contract itself. To describe that situations we may use one of its subclasses.rdfs:comment : Clase abstracta. Existe una serie de circunstancias que derivan en la extinctión del contrato o procedimiento. Para describir estas situaciones se hace uso de una de sus subclases.</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#ContractOrProcedureExtinction">pproc:ContractOrProcedureExtinction</a>
    /// </summary>
    let ContractOrProcedureExtinction = _prefixId.prefix "ContractOrProcedureExtinction"

    /// <summary>
    ///   <para>rdfs:label : Contract procedurerdfs:label : Procedimiento del contrato</para>
    ///   <para>rdfs:comment : Class that specifies the procedure of a contract (e.g. type of procedure or its urgency).rdfs:comment : Clase que define las especificaciones del procedimiento de un contrato (e.g. tipo de procedimiento o de tramitación).</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#ContractProcedureSpecifications">pproc:ContractProcedureSpecifications</a>
    /// </summary>
    let ContractProcedureSpecifications =
        _prefixId.prefix "ContractProcedureSpecifications"

    /// <summary>
    ///   <para>rdfs:label : Contract resolutionrdfs:label : Resolución del contrato</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#ContractResolution">pproc:ContractResolution</a>
    /// </summary>
    let ContractResolution = _prefixId.prefix "ContractResolution"
    /// <summary>
    ///   <para>rdfs:label : Contract temporal conditionsrdfs:label : Condiciones temporales del contrato</para>
    ///   <para>rdfs:comment : Class that describes the temporal conditions of the contract.rdfs:comment : Clase que define las condiciones temporales de un contrato (e.g. plazo ó prórrogas).</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#ContractTemporalConditions">pproc:ContractTemporalConditions</a>
    /// </summary>
    let ContractTemporalConditions = _prefixId.prefix "ContractTemporalConditions"
    /// <summary>
    ///   <para>rdfs:label : Contract with lotsrdfs:label : Contrato con lotes</para>
    ///   <para>rdfs:comment : Class of the contract that have lots.rdfs:comment : Clase de los contratos dividos en lotes.
    ///
    /// Cuando un contrato de muy grande, este puede ser dividido en diversos lotes por la entidad contratante. Las empresas presentan las ofertas a estos lotes separadamente (y no al contrato "raíz"), realizándose la adjudicación de la misma manera.</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#ContractWithLots">pproc:ContractWithLots</a>
    /// </summary>
    let ContractWithLots = _prefixId.prefix "ContractWithLots"
    /// <summary>
    ///   <para>rdfs:label : Contract without lotsrdfs:label : Contrato sin lotes</para>
    ///   <para>rdfs:comment : Class to describe the contract not divided into lots.rdfs:comment : Clase de los contratos que no están dividos en lotes.</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#ContractWithoutLots">pproc:ContractWithoutLots</a>
    /// </summary>
    let ContractWithoutLots = _prefixId.prefix "ContractWithoutLots"
    /// <summary>
    ///   <para>rdfs:label : Contracting body agreementrdfs:label : Acuerdo del órgano de contratación</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#ContractingBodyAgreement">pproc:ContractingBodyAgreement</a>
    /// </summary>
    let ContractingBodyAgreement = _prefixId.prefix "ContractingBodyAgreement"
    /// <summary>
    ///   <para>rdfs:label : Correction noticerdfs:label : Anuncio de corrección</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#CorrectionNotice">pproc:CorrectionNotice</a>
    /// </summary>
    let CorrectionNotice = _prefixId.prefix "CorrectionNotice"
    /// <summary>
    ///   <para>rdfs:label : Criterion scorerdfs:label : Valoración de criterio</para>
    ///   <para>rdfs:comment : Class to describe an award criterion and its score.rdfs:comment : Clase para valorar individualmente un criterio de adjudicación. Esta formada por una puntuación (contsem:score) y un criterio (contsem:criterion).</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#CriterionScore">pproc:CriterionScore</a>
    /// </summary>
    let CriterionScore = _prefixId.prefix "CriterionScore"
    /// <summary>
    ///   <para>rdfs:label : Derivative contractrdfs:label : Contrato derivado</para>
    ///   <para>rdfs:comment : Class describing contracts derived from a framework agreement or a dynamic purchasing system.rdfs:comment : Clase de los contratos derivados de un acuerdo marco o un sistema dinámico de contratación.</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#DerivativeContract">pproc:DerivativeContract</a>
    /// </summary>
    let DerivativeContract = _prefixId.prefix "DerivativeContract"

    /// <summary>
    ///   <para>rdfs:label : Dynamic purchasing system conclusion contractrdfs:label : Contrato de establecimiento de un sistema dinámico de contratación</para>
    ///   <para>rdfs:comment : Class describing the contracts consisting in the conclusion of a dynamic purchasing system.rdfs:comment : Clase de los contratos que consisten en el establecimiento de un sistema dinámico de contratación.</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#DynamicPurchasingSystemConclusionContract">pproc:DynamicPurchasingSystemConclusionContract</a>
    /// </summary>
    let DynamicPurchasingSystemConclusionContract =
        _prefixId.prefix "DynamicPurchasingSystemConclusionContract"

    /// <summary>
    ///   <para>rdfs:label : Dynamic purchasing system derivative contractrdfs:label : Contrato derivado de un sistema dinámico de contratación</para>
    ///   <para>rdfs:comment : Class describing contracts derived from a dynamic purchasing system.rdfs:comment : Clase de los contratos derivados de un sistema dinámico de contratación</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#DynamicPurchasingSystemDerivativeContract">pproc:DynamicPurchasingSystemDerivativeContract</a>
    /// </summary>
    let DynamicPurchasingSystemDerivativeContract =
        _prefixId.prefix "DynamicPurchasingSystemDerivativeContract"

    /// <summary>
    ///   <para>rdfs:label : Electronic auctionrdfs:label : Subasta electrónica</para>
    ///   <para>rdfs:comment : Class that specifies the existence of an electronic auction of one or more of the award criterions.rdfs:comment : Clase para especificar la realización de una subasta electrónica de uno o más criterios de adjudicación.</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#ElectronicAuction">pproc:ElectronicAuction</a>
    /// </summary>
    let ElectronicAuction = _prefixId.prefix "ElectronicAuction"
    /// <summary>
    ///   <para>rdfs:label : Electronic auction phaserdfs:label : Fase de subasta electrónica</para>
    ///   <para>rdfs:comment : Class describing a phase of an electronic auction.rdfs:comment : Fase de la subasta electrónica de uno o más de los criterios de adjudicación del contrato.</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#ElectronicAuctionPhase">pproc:ElectronicAuctionPhase</a>
    /// </summary>
    let ElectronicAuctionPhase = _prefixId.prefix "ElectronicAuctionPhase"
    let Emergency = _prefixId.prefix "Emergency"
    /// <summary>
    ///   <para>rdfs:label : Excluded tenderrdfs:label : Oferta excluída</para>
    ///   <para>rdfs:comment : Class that defines the tenders excluded from the procurement procedure.rdfs:comment : Define las ofertas que han sido excluídas del proceso de licitación.</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#ExcludedTender">pproc:ExcludedTender</a>
    /// </summary>
    let ExcludedTender = _prefixId.prefix "ExcludedTender"
    /// <summary>
    ///   <para>rdfs:label : Expert committeerdfs:label : Comité de expertos</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#ExpertCommittee">pproc:ExpertCommittee</a>
    /// </summary>
    let ExpertCommittee = _prefixId.prefix "ExpertCommittee"
    let Express = _prefixId.prefix "Express"
    /// <summary>
    ///   <para>rdfs:label : Extendable contractrdfs:label : Contrato prorrogable</para>
    ///   <para>rdfs:comment : Class describing contracts whose end date can be extended.rdfs:comment : Contratos públicos cuya fecha de ejecución puede ser pospuesta o extendida.</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#ExtendableContract">pproc:ExtendableContract</a>
    /// </summary>
    let ExtendableContract = _prefixId.prefix "ExtendableContract"
    /// <summary>
    ///   <para>rdfs:label : Formalization noticerdfs:label : Anuncio de formalización</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#FormalizationNotice">pproc:FormalizationNotice</a>
    /// </summary>
    let FormalizationNotice = _prefixId.prefix "FormalizationNotice"
    /// <summary>
    ///   <para>rdfs:label : Formalized tenderrdfs:label : Oferta formalizada</para>
    ///   <para>rdfs:comment : Class describing tenders being formalized.rdfs:comment : Clase para definir la oferta que se ha formalizado.</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#FormalizedTender">pproc:FormalizedTender</a>
    /// </summary>
    let FormalizedTender = _prefixId.prefix "FormalizedTender"
    /// <summary>
    ///   <para>rdfs:label : Framework agreement or dynamic purchasing systemrdfs:label : Acuerdo marco o Sistema Dinámico de contratación</para>
    ///   <para>rdfs:comment : Class used to describe a contract that is a declaration of a framework agreement or a dynamic purchasing system.rdfs:comment : Clase a utilizar cuando estemos ante un contrato que consiste en la declaración, tanto de un acuerdo marco como de un sistema dinámico de contratación.</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#FrameworkAgreement">pproc:FrameworkAgreement</a>
    /// </summary>
    let FrameworkAgreement = _prefixId.prefix "FrameworkAgreement"
    /// <summary>
    ///   <para>rdfs:label : Framework conclusion contractrdfs:label : Contrato de establecimiento de un acuerdo marco</para>
    ///   <para>rdfs:comment : Class describing the contracts consisting in the conclusion of a framework agreement.rdfs:comment : Clase de los contratos que consisten en el establecimiento de un acuerdo marco.</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#FrameworkConclusionContract">pproc:FrameworkConclusionContract</a>
    /// </summary>
    let FrameworkConclusionContract = _prefixId.prefix "FrameworkConclusionContract"
    /// <summary>
    ///   <para>rdfs:label : Framework derivative contractrdfs:label : Contrato derivado de un acuerdo marco</para>
    ///   <para>rdfs:comment : Class describing contracts derived from a framework agreement.rdfs:comment : Clase de los contratos derivados de un acuerdo marco</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#FrameworkDerivativeContract">pproc:FrameworkDerivativeContract</a>
    /// </summary>
    let FrameworkDerivativeContract = _prefixId.prefix "FrameworkDerivativeContract"
    /// <summary>
    ///   <para>rdfs:label : Harmonized contractrdfs:label : Contrato armonizado</para>
    ///   <para>rdfs:comment : Class to describe harmonized contracts (i.e. contracts that reachs the threshold to be treated as highlighted in the procurement Directives of the European Commision and European Council).rdfs:comment : Clase de los contratos armonizados (i.e. contratos que alcanzan el umbral para actuar conforme a las Directivas del Parlamento Europeo y del Consejo en contratos públicos)</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#HarmonizedContract">pproc:HarmonizedContract</a>
    /// </summary>
    let HarmonizedContract = _prefixId.prefix "HarmonizedContract"
    let InformationKindScheme = _prefixId.prefix "InformationKindScheme"
    /// <summary>
    ///   <para>rdfs:label : Information providerrdfs:label : Proveedor de información</para>
    ///   <para>rdfs:comment : Class defining the provider of information about the contract.rdfs:comment : Proveedor de información sobre la licitación del contrato.</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#InformationProvider">pproc:InformationProvider</a>
    /// </summary>
    let InformationProvider = _prefixId.prefix "InformationProvider"
    /// <summary>
    ///   <para>rdfs:label : Lease contractrdfs:label : Arrendamiento financiero</para>
    ///   <para>rdfs:comment : Class defining supplies contracts aimed to lease supplies.rdfs:comment : Clase de los contratos de suministros cuyo objeto es el arrendamiento financiero de bienes.
    ///
    /// Popularmente conocido como 'renting' en España.</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#LeaseContract">pproc:LeaseContract</a>
    /// </summary>
    let LeaseContract = _prefixId.prefix "LeaseContract"
    /// <summary>
    ///   <para>rdfs:label : Legal remedyrdfs:label : Recurso legal</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#LegalRemedy">pproc:LegalRemedy</a>
    /// </summary>
    let LegalRemedy = _prefixId.prefix "LegalRemedy"
    /// <summary>
    ///   <para>rdfs:label : Lotrdfs:label : Lote</para>
    ///   <para>rdfs:comment : Class describing contracts that are an actual lot of another contract.rdfs:comment : Clase de los contratos que representan un lote perteneciente a otro contrato.</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#Lot">pproc:Lot</a>
    /// </summary>
    let Lot = _prefixId.prefix "Lot"
    let Minor = _prefixId.prefix "Minor"
    /// <summary>
    ///   <para>rdfs:label : Mixed capital company contractrdfs:label : Contrato de sociedad de economia mixta</para>
    ///   <para>rdfs:comment : Class describing the contracts where the contracting authority participates concurrently with the natural or legal person.rdfs:comment : Los contrato de sociedad de economia mixta son aquellos en que la Administración participe, por sí o por medio de una entidad pública, en concurrencia con personas naturales o jurídicas.</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#MixedCapitalCompanyContract">pproc:MixedCapitalCompanyContract</a>
    /// </summary>
    let MixedCapitalCompanyContract = _prefixId.prefix "MixedCapitalCompanyContract"
    /// <summary>
    ///   <para>rdfs:label : Mixed contractrdfs:label : Contrato mixto</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#MixedContract">pproc:MixedContract</a>
    /// </summary>
    let MixedContract = _prefixId.prefix "MixedContract"
    /// <summary>
    ///   <para>rdfs:label : Multiannual contractrdfs:label : Contrato plurianual</para>
    ///   <para>rdfs:comment : Class describing the multiannual contracts (i.e. contract whose duration extends over more than one financial year).rdfs:comment : Clase de los contrato plurianuales (i.e. contratos cuya duración se extiende durante más de un ejercicio contable).</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#MultiannualContract">pproc:MultiannualContract</a>
    /// </summary>
    let MultiannualContract = _prefixId.prefix "MultiannualContract"
    let Negotiated = _prefixId.prefix "Negotiated"
    let NegotiatedWithPublicity = _prefixId.prefix "NegotiatedWithPublicity"
    let NegotiatedWithoutPublicity = _prefixId.prefix "NegotiatedWithoutPublicity"
    /// <summary>
    ///   <para>rdfs:label : Noticerdfs:label : Anuncio</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#Notice">pproc:Notice</a>
    /// </summary>
    let Notice = _prefixId.prefix "Notice"
    /// <summary>
    ///   <para>rdfs:label : Objective award criterionrdfs:label : Criterio de adjudicación objetivo</para>
    ///   <para>rdfs:comment : Class describing criterioa that depend on a value judgement.rdfs:comment : Clase para definir criterios que dependen de un juicio de valor.</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#ObjectiveAwardCriterion">pproc:ObjectiveAwardCriterion</a>
    /// </summary>
    let ObjectiveAwardCriterion = _prefixId.prefix "ObjectiveAwardCriterion"
    /// <summary>
    ///   <para>rdfs:label : Ordinary administrative remedyrdfs:label : Recurso administrativo ordinario</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#OrdinaryAdministrativeRemedy">pproc:OrdinaryAdministrativeRemedy</a>
    /// </summary>
    let OrdinaryAdministrativeRemedy = _prefixId.prefix "OrdinaryAdministrativeRemedy"
    /// <summary>
    ///   <para>rdfs:label : Precomercial procurementrdfs:label : Compra pública pre-comercial</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#PrecomercialProcurement">pproc:PrecomercialProcurement</a>
    /// </summary>
    let PrecomercialProcurement = _prefixId.prefix "PrecomercialProcurement"
    /// <summary>
    ///   <para>rdfs:label : Prior information noticerdfs:label : Anuncio de información previa</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#PriorInformationNotice">pproc:PriorInformationNotice</a>
    /// </summary>
    let PriorInformationNotice = _prefixId.prefix "PriorInformationNotice"
    /// <summary>
    ///   <para>rdfs:label : Private contractrdfs:label : Contrato privado</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#PrivateContract">pproc:PrivateContract</a>
    /// </summary>
    let PrivateContract = _prefixId.prefix "PrivateContract"
    /// <summary>
    ///   <para>rdfs:label : Procedure resignationrdfs:label : Desistimiento del procedimiento</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#ProcedureResignation">pproc:ProcedureResignation</a>
    /// </summary>
    let ProcedureResignation = _prefixId.prefix "ProcedureResignation"
    let ProcedureTypeScheme = _prefixId.prefix "ProcedureTypeScheme"
    /// <summary>
    ///   <para>rdfs:label : Procedure voidrdfs:label : Procedimiento desierto</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#ProcedureVoid">pproc:ProcedureVoid</a>
    /// </summary>
    let ProcedureVoid = _prefixId.prefix "ProcedureVoid"
    /// <summary>
    ///   <para>rdfs:label : Procedure waiverdfs:label : Renuncia del procedimiento</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#ProcedureWaive">pproc:ProcedureWaive</a>
    /// </summary>
    let ProcedureWaive = _prefixId.prefix "ProcedureWaive"

    /// <summary>
    ///   <para>rdfs:label : Public-private partnership contractrdfs:label : Contrato de colaboración público-privada</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#PublicPrivatePartnershipContract">pproc:PublicPrivatePartnershipContract</a>
    /// </summary>
    let PublicPrivatePartnershipContract =
        _prefixId.prefix "PublicPrivatePartnershipContract"

    /// <summary>
    ///   <para>rdfs:label : Public services management contractrdfs:label : Contrato de gestión de servicios públicos</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#PublicServicesManagementContract">pproc:PublicServicesManagementContract</a>
    /// </summary>
    let PublicServicesManagementContract =
        _prefixId.prefix "PublicServicesManagementContract"

    /// <summary>
    ///   <para>rdfs:label : Public works concession contractrdfs:label : Contrato de concesión de obras públicas</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#PublicWorksConcessionContract">pproc:PublicWorksConcessionContract</a>
    /// </summary>
    let PublicWorksConcessionContract = _prefixId.prefix "PublicWorksConcessionContract"
    let Regular = _prefixId.prefix "Regular"
    let RegularOpen = _prefixId.prefix "RegularOpen"
    /// <summary>
    ///   <para>rdfs:label : Remedyrdfs:label : Recurso</para>
    ///   <para>rdfs:comment : Remedy lodged concerning a resolution about the procurement procedure.rdfs:comment : Recurso interpuesto sobre alguna de las resoluciones del proceso de licitación.</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#Remedy">pproc:Remedy</a>
    /// </summary>
    let Remedy = _prefixId.prefix "Remedy"
    /// <summary>
    ///   <para>rdfs:label : Rent contractrdfs:label : Contrato de alquiler</para>
    ///   <para>rdfs:comment : Class defining supplies contracts aimed to rent supplies.rdfs:comment : Clase de los contratos de suministros cuyo objeto es el alquiler de bienes.</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#RentContract">pproc:RentContract</a>
    /// </summary>
    let RentContract = _prefixId.prefix "RentContract"
    /// <summary>
    ///   <para>rdfs:label : Services contractrdfs:label : Contrato de servicios</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#ServicesContract">pproc:ServicesContract</a>
    /// </summary>
    let ServicesContract = _prefixId.prefix "ServicesContract"
    /// <summary>
    ///   <para>rdfs:label : Shared result agreement contractrdfs:label : Gestión interesada</para>
    ///   <para>rdfs:comment : Class describing contracts whose operation results are shared among the contracting authority and the tenderer.rdfs:comment : Clase de los contrato en cuya virtud la Administración y el empresario participarán en los resultados de la explotación del servicio en la proporción que se establezca en el contrato.</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#SharedResultAgreementContract">pproc:SharedResultAgreementContract</a>
    /// </summary>
    let SharedResultAgreementContract = _prefixId.prefix "SharedResultAgreementContract"
    let SimpleOpen = _prefixId.prefix "SimpleOpen"
    /// <summary>
    ///   <para>rdfs:label : Special administrative contractrdfs:label : Contrato administrativo especial</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#SpecialAdministrativeContract">pproc:SpecialAdministrativeContract</a>
    /// </summary>
    let SpecialAdministrativeContract = _prefixId.prefix "SpecialAdministrativeContract"
    /// <summary>
    ///   <para>rdfs:label : Special administrative remedyrdfs:label : Recurso administrativo especial</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#SpecialAdministrativeRemedy">pproc:SpecialAdministrativeRemedy</a>
    /// </summary>
    let SpecialAdministrativeRemedy = _prefixId.prefix "SpecialAdministrativeRemedy"
    /// <summary>
    ///   <para>rdfs:label : Subjective award criterionrdfs:label : Criterio de adjudicación subjetivo</para>
    ///   <para>rdfs:comment : Class used to describe criteria that depend on a subjetive opinion.rdfs:comment : Clase para especificar los criterios que dependen de una opinion subjetiva.</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#SubjectiveAwardCriterion">pproc:SubjectiveAwardCriterion</a>
    /// </summary>
    let SubjectiveAwardCriterion = _prefixId.prefix "SubjectiveAwardCriterion"
    /// <summary>
    ///   <para>rdfs:label : Supplies contractrdfs:label : Contrato de suministros</para>
    ///   <para>rdfs:comment : Class describing contracts whose object is the acquisition of supplies.rdfs:comment : Clase de los contratos cuyo objeto es la adquisición de suministros. Esta adquisición puede ser bien mediante compra, alquiler o arrendamiento financiero.</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#SuppliesContract">pproc:SuppliesContract</a>
    /// </summary>
    let SuppliesContract = _prefixId.prefix "SuppliesContract"
    /// <summary>
    ///   <para>rdfs:label : Technical committeerdfs:label : Organismo técnico</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#TechnicalCommittee">pproc:TechnicalCommittee</a>
    /// </summary>
    let TechnicalCommittee = _prefixId.prefix "TechnicalCommittee"
    let TechnicalInformation = _prefixId.prefix "TechnicalInformation"
    /// <summary>
    ///   <para>rdfs:label : Tender committeerdfs:label : Mesa de contratación</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#TenderCommittee">pproc:TenderCommittee</a>
    /// </summary>
    let TenderCommittee = _prefixId.prefix "TenderCommittee"
    /// <summary>
    ///   <para>rdfs:label : Tender meetingrdfs:label : Reunión de la mesa de contratación</para>
    ///   <para>rdfs:comment : Class describing the meetings of tender committee.rdfs:comment : Clase para describir las reuniones que la mesa de contratación, comité de expertos u organismos técnicas han realizado.</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#TenderMeeting">pproc:TenderMeeting</a>
    /// </summary>
    let TenderMeeting = _prefixId.prefix "TenderMeeting"
    /// <summary>
    ///   <para>rdfs:label : Tender requirementsrdfs:label : Requisitos para las ofertas</para>
    ///   <para>rdfs:comment : Class to define the tender requirements needed to submit a tender (e.g. tender document needs).rdfs:comment : Clase que define los requisitos exigidos a las ofertas a presentar (e.g. plazo o documentación a presentar).</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#TenderRequirements">pproc:TenderRequirements</a>
    /// </summary>
    let TenderRequirements = _prefixId.prefix "TenderRequirements"
    /// <summary>
    ///   <para>rdfs:label : Tenderers requirementsrdfs:label : Requisitos de los licitadores</para>
    ///   <para>rdfs:comment : Class defining the tenderers requirements (e.g. required classification or financial capability).rdfs:comment : Clase que define los requisitos exigidos a los licitadores (e.g. clasificación profesional ó solvencia económica).</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#TenderersRequirements">pproc:TenderersRequirements</a>
    /// </summary>
    let TenderersRequirements = _prefixId.prefix "TenderersRequirements"
    let UrgencyTypeScheme = _prefixId.prefix "UrgencyTypeScheme"
    /// <summary>
    ///   <para>rdfs:label : Works contractrdfs:label : Contrato de obras</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#WorksContract">pproc:WorksContract</a>
    /// </summary>
    let WorksContract = _prefixId.prefix "WorksContract"
    /// <summary>
    ///   <para>rdfs:label : Actual durationrdfs:label : Duración final</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#actualDuration">pproc:actualDuration</a>
    /// </summary>
    let actualDuration = _prefixId.prefix "actualDuration"
    /// <summary>
    ///   <para>rdfs:label : Additional document referencerdfs:label : Documentación adicional</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#additionalDocumentReference">pproc:additionalDocumentReference</a>
    /// </summary>
    let additionalDocumentReference = _prefixId.prefix "additionalDocumentReference"
    /// <summary>
    ///   <para>rdfs:label : Additional object of contractrdfs:label : Objeto adicional del contrato</para>
    ///   <para>rdfs:comment : Property that points to the concept of the CPV code of an object.
    ///
    /// The concept used should be a valid representation of a CPV code, as it is in http://cpv.data.ac.uk/.rdfs:comment : Representación CPV del objeto de un contrato.
    ///
    /// Debe apuntar a un concepto de objeto siguiendo la clasificación CPV de algún esquema de conceptos SKOS, como http://cpv.data.ac.uk/.</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#additionalObject">pproc:additionalObject</a>
    /// </summary>
    let additionalObject = _prefixId.prefix "additionalObject"
    /// <summary>
    ///   <para>rdfs:label : Advertisement amountrdfs:label : Gastos de publicidad</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#advertisementAmount">pproc:advertisementAmount</a>
    /// </summary>
    let advertisementAmount = _prefixId.prefix "advertisementAmount"
    /// <summary>
    ///   <para>rdfs:label : Alternate memberrdfs:label : Miembro suplente</para>
    ///   <para>rdfs:comment : Points to an alternate member of a committee.rdfs:comment : Miembro suplente en una mesa de contratación.</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#alternateMember">pproc:alternateMember</a>
    /// </summary>
    let alternateMember = _prefixId.prefix "alternateMember"

    /// <summary>
    ///   <para>rdfs:label : Assumption protecting the chosen procedure typerdfs:label : Supuesto que ampara el uso del procedimiento elegido</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#assumptionProtectingProcedureType">pproc:assumptionProtectingProcedureType</a>
    /// </summary>
    let assumptionProtectingProcedureType =
        _prefixId.prefix "assumptionProtectingProcedureType"

    /// <summary>
    ///   <para>rdfs:label : Award agreementrdfs:label : Acuerdo de adjudicación</para>
    ///   <para>rdfs:comment : Points to the body agreement where a tender has been awarded.rdfs:comment : Indica el acuerdo del órgano de contratación donde se ha adjudicado el contrato a un licitador.</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#awardAgreement">pproc:awardAgreement</a>
    /// </summary>
    let awardAgreement = _prefixId.prefix "awardAgreement"
    /// <summary>
    ///   <para>rdfs:label : Date of awardrdfs:label : Fecha de adjudicación</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#awardDate">pproc:awardDate</a>
    /// </summary>
    let awardDate = _prefixId.prefix "awardDate"
    /// <summary>
    ///   <para>rdfs:label : Briefingrdfs:label : Reunión informativa</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#briefing">pproc:briefing</a>
    /// </summary>
    let briefing = _prefixId.prefix "briefing"
    /// <summary>
    ///   <para>rdfs:label : Contract budget pricerdfs:label : Presupuesto del contrato</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#budgetPrice">pproc:budgetPrice</a>
    /// </summary>
    let budgetPrice = _prefixId.prefix "budgetPrice"
    /// <summary>
    ///   <para>rdfs:label : Committeerdfs:label : Comité</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#committee">pproc:committee</a>
    /// </summary>
    let committee = _prefixId.prefix "committee"
    /// <summary>
    ///   <para>rdfs:label : Complementary contractrdfs:label : Contrato complementario</para>
    ///   <para>rdfs:comment : Relates a contract with a complementary contract.rdfs:comment : Relaciona un contrato con otro contrato complementario.</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#complementaryContract">pproc:complementaryContract</a>
    /// </summary>
    let complementaryContract = _prefixId.prefix "complementaryContract"
    /// <summary>
    ///   <para>rdfs:label : Compulsory means for executionrdfs:label : Adscripción de medios</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#compulsoryMeansForExecution">pproc:compulsoryMeansForExecution</a>
    /// </summary>
    let compulsoryMeansForExecution = _prefixId.prefix "compulsoryMeansForExecution"
    /// <summary>
    ///   <para>rdfs:label : Construction subsidiesrdfs:label : Aportaciones públicas</para>
    ///   <para>rdfs:comment : Description of the public subsidies to construction works contracts.rdfs:comment : Descripción de las aportaciones públicas a la construcción.</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#constructionSubsidies">pproc:constructionSubsidies</a>
    /// </summary>
    let constructionSubsidies = _prefixId.prefix "constructionSubsidies"
    /// <summary>
    ///   <para>rdfs:label : Contract activitiesrdfs:label : Trámites del contrato</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#contractActivites">pproc:contractActivites</a>
    /// </summary>
    let contractActivites = _prefixId.prefix "contractActivites"
    /// <summary>
    ///   <para>rdfs:label : Contract additional obligationsrdfs:label : Obligaciones accesorias del contrato</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#contractAdditionalObligations">pproc:contractAdditionalObligations</a>
    /// </summary>
    let contractAdditionalObligations = _prefixId.prefix "contractAdditionalObligations"
    /// <summary>
    ///   <para>rdfs:label : Contract bodiesrdfs:label : Órganos del contrato</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#contractBodies">pproc:contractBodies</a>
    /// </summary>
    let contractBodies = _prefixId.prefix "contractBodies"
    /// <summary>
    ///   <para>rdfs:label : Contract economic conditionsrdfs:label : Condiciones económicas del contrato</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#contractEconomicConditions">pproc:contractEconomicConditions</a>
    /// </summary>
    let contractEconomicConditions = _prefixId.prefix "contractEconomicConditions"
    /// <summary>
    ///   <para>rdfs:label : Contract execution conditionsrdfs:label : Condiciones de ejecución del contrato</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#contractExecutionConditions">pproc:contractExecutionConditions</a>
    /// </summary>
    let contractExecutionConditions = _prefixId.prefix "contractExecutionConditions"
    /// <summary>
    ///   <para>rdfs:label : Contract modificationrdfs:label : Modificación de contrato</para>
    ///   <para>rdfs:comment : Points to contract modifications being made.rdfs:comment : Indica la modificación efectuada en un contrato.</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#contractModification">pproc:contractModification</a>
    /// </summary>
    let contractModification = _prefixId.prefix "contractModification"

    /// <summary>
    ///   <para>rdfs:label : Contract modification conditionsrdfs:label : Condiciones para la modificación del contrato</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#contractModificationConditions">pproc:contractModificationConditions</a>
    /// </summary>
    let contractModificationConditions =
        _prefixId.prefix "contractModificationConditions"

    /// <summary>
    ///   <para>rdfs:label : Object of the contractrdfs:label : Objeto del contrato</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#contractObject">pproc:contractObject</a>
    /// </summary>
    let contractObject = _prefixId.prefix "contractObject"
    /// <summary>
    ///   <para>rdfs:label : Contract or procedure extinctionrdfs:label : Extinción de contrato o de procedimiento</para>
    ///   <para>rdfs:comment : Abstract property pointing to extinction of contract or procedure. Use any of its subclasses.rdfs:comment : Propiedad abstracta que indica la extinción de un contrato por resolución, renuncia o abandono. O bien la extinción del procedimiento al ser declarado desierto.
    ///
    /// Utilizar una de sus subclases.</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#contractOrProcedureExtinction">pproc:contractOrProcedureExtinction</a>
    /// </summary>
    let contractOrProcedureExtinction = _prefixId.prefix "contractOrProcedureExtinction"

    /// <summary>
    ///   <para>rdfs:label : Contract procedure specificationsrdfs:label : Especificaciones del procedimiento del contrato</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#contractProcedureSpecifications">pproc:contractProcedureSpecifications</a>
    /// </summary>
    let contractProcedureSpecifications =
        _prefixId.prefix "contractProcedureSpecifications"

    /// <summary>
    ///   <para>rdfs:label : Contract resolutionrdfs:label : Resolución de contrato</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#contractResolution">pproc:contractResolution</a>
    /// </summary>
    let contractResolution = _prefixId.prefix "contractResolution"
    /// <summary>
    ///   <para>rdfs:label : Contract temporal conditionsrdfs:label : Condiciones temporales del contrato</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#contractTemporalConditions">pproc:contractTemporalConditions</a>
    /// </summary>
    let contractTemporalConditions = _prefixId.prefix "contractTemporalConditions"
    /// <summary>
    ///   <para>rdfs:label : Contracting bodyrdfs:label : Órgano de contratación</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#contractingBody">pproc:contractingBody</a>
    /// </summary>
    let contractingBody = _prefixId.prefix "contractingBody"
    /// <summary>
    ///   <para>rdfs:label : Contracting body agreementrdfs:label : Acuerdo del órgano de contratación</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#contractingBodyAgreement">pproc:contractingBodyAgreement</a>
    /// </summary>
    let contractingBodyAgreement = _prefixId.prefix "contractingBodyAgreement"
    /// <summary>
    ///   <para>rdfs:label : Criterionrdfs:label : Criterio</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#criterion">pproc:criterion</a>
    /// </summary>
    let criterion = _prefixId.prefix "criterion"
    /// <summary>
    ///   <para>rdfs:label : Criterion evaluation moderdfs:label : Forma de evaluación del criterio</para>
    ///   <para>rdfs:comment : Property textually describing the criterion evaluarion mode.rdfs:comment : Propiedad para describir la forma de valoración del criterio.</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#criterionEvaluationMode">pproc:criterionEvaluationMode</a>
    /// </summary>
    let criterionEvaluationMode = _prefixId.prefix "criterionEvaluationMode"
    /// <summary>
    ///   <para>rdfs:label : Criterion maximum and minimum scorerdfs:label : Puntuación máxima y mínima del criterio</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#criterionMaxAndMinScores">pproc:criterionMaxAndMinScores</a>
    /// </summary>
    let criterionMaxAndMinScores = _prefixId.prefix "criterionMaxAndMinScores"
    /// <summary>
    ///   <para>rdfs:label : Criterion scorerdfs:label : Valoración de criterio</para>
    ///   <para>rdfs:comment : Property that points to an unique criterion and its score.rdfs:comment : Especifica la valoración de un único criterio, por lo que se utilizará una vez por cada criterio de adjudicación presente en el contrato.</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#criterionScore">pproc:criterionScore</a>
    /// </summary>
    let criterionScore = _prefixId.prefix "criterionScore"
    /// <summary>
    ///   <para>rdfs:label : Delegating authorityrdfs:label : Entidad delegante</para>
    ///   <para>rdfs:comment : Points to the authority that is delegating the contract.rdfs:comment : Indica la entidad que delega la licitación de este contrato.</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#delegatingAuthority">pproc:delegatingAuthority</a>
    /// </summary>
    let delegatingAuthority = _prefixId.prefix "delegatingAuthority"
    /// <summary>
    ///   <para>rdfs:label : Document referencerdfs:label : Documentación</para>
    ///   <para>rdfs:comment : Links to external documents.rdfs:comment : Enlace a documentación.
    ///
    /// Propiedad similar a pc:attachment, pero sin dominio fijo, pues esta misma propiedad puede utilizarse con múltiples clases (e.g. pc:Contract ó contsem:TenderMeeting)</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#documentReference">pproc:documentReference</a>
    /// </summary>
    let documentReference = _prefixId.prefix "documentReference"
    /// <summary>
    ///   <para>rdfs:label : Durationrdfs:label : Duración</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#duration">pproc:duration</a>
    /// </summary>
    let duration = _prefixId.prefix "duration"
    /// <summary>
    ///   <para>rdfs:label : Duration changerdfs:label : Variación del plazo</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#durationChange">pproc:durationChange</a>
    /// </summary>
    let durationChange = _prefixId.prefix "durationChange"
    /// <summary>
    ///   <para>rdfs:label : Early tramitationrdfs:label : Tramitación anticipada</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#earlyTramitation">pproc:earlyTramitation</a>
    /// </summary>
    let earlyTramitation = _prefixId.prefix "earlyTramitation"
    /// <summary>
    ///   <para>rdfs:label : Electronic auctionrdfs:label : Subasta electrónica</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#electronicAuction">pproc:electronicAuction</a>
    /// </summary>
    let electronicAuction = _prefixId.prefix "electronicAuction"
    /// <summary>
    ///   <para>rdfs:label : Electronic auction phaserdfs:label : Fase de subasta electrónica</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#electronicAuctionPhase">pproc:electronicAuctionPhase</a>
    /// </summary>
    let electronicAuctionPhase = _prefixId.prefix "electronicAuctionPhase"
    /// <summary>
    ///   <para>rdfs:label : Electronic auction webrdfs:label : Web de la subasta electrónica</para>
    ///   <para>rdfs:comment : Property that indicated where the electronic auction is made or where we can look for more information about the auction.rdfs:comment : Apunta a la web donde puede se realiza la subasta electrónica, o en su defecto, donde se pueda encontrar más información acerca de la subasta electrónica.</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#electronicAuctionWeb">pproc:electronicAuctionWeb</a>
    /// </summary>
    let electronicAuctionWeb = _prefixId.prefix "electronicAuctionWeb"
    /// <summary>
    ///   <para>rdfs:label : End moderdfs:label : Modo de finalización</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#endMode">pproc:endMode</a>
    /// </summary>
    let endMode = _prefixId.prefix "endMode"
    /// <summary>
    ///   <para>rdfs:label : Estimated durationrdfs:label : Duración estimada</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#estimatedDuration">pproc:estimatedDuration</a>
    /// </summary>
    let estimatedDuration = _prefixId.prefix "estimatedDuration"
    /// <summary>
    ///   <para>rdfs:label : Estimated end daterdfs:label : Fecha estimada de finalización</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#estimatedEndDate">pproc:estimatedEndDate</a>
    /// </summary>
    let estimatedEndDate = _prefixId.prefix "estimatedEndDate"
    /// <summary>
    ///   <para>rdfs:label : Estimated value of the contractrdfs:label : Valor estimado del contrato</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#estimatedValue">pproc:estimatedValue</a>
    /// </summary>
    let estimatedValue = _prefixId.prefix "estimatedValue"
    /// <summary>
    ///   <para>rdfs:label : Execution requerimentsrdfs:label : Condiciones de ejecución</para>
    ///   <para>rdfs:comment : Property to define alternative execution requirements (e.g. legal form to be adopted by tenderers).rdfs:comment : Campo para definir las condiciones de ejecución del contrato si las hubiera (e.g. forma jurídica a adoptar por la agrupación de contratistas)</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#executionRequeriments">pproc:executionRequeriments</a>
    /// </summary>
    let executionRequeriments = _prefixId.prefix "executionRequeriments"
    /// <summary>
    ///   <para>rdfs:label : Expected cause modificationrdfs:label : Causas previstas de modificación</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#expectedCauseModification">pproc:expectedCauseModification</a>
    /// </summary>
    let expectedCauseModification = _prefixId.prefix "expectedCauseModification"
    /// <summary>
    ///   <para>rdfs:label : Extinction causerdfs:label : Causa de extinctión</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#extinctionCause">pproc:extinctionCause</a>
    /// </summary>
    let extinctionCause = _prefixId.prefix "extinctionCause"
    /// <summary>
    ///   <para>rdfs:label : Feerdfs:label : Canon</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#feePrice">pproc:feePrice</a>
    /// </summary>
    let feePrice = _prefixId.prefix "feePrice"
    /// <summary>
    ///   <para>rdfs:label : Final financial guaranteerdfs:label : Garantía definitiva</para>
    ///   <para>rdfs:comment : The range of this property must be a percentage (i.e. float between 0.0 and 100.0)rdfs:comment : El rango en esta propiedad indica un porcentaje, por lo que el rango del número real a utilizar debe estar comprendido entre 0.0 y 100.0.</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#finalFinancialGuarantee">pproc:finalFinancialGuarantee</a>
    /// </summary>
    let finalFinancialGuarantee = _prefixId.prefix "finalFinancialGuarantee"

    /// <summary>
    ///   <para>rdfs:label : Final financial guarantee durationrdfs:label : Plazo de la garantía definitiva</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#finalFinancialGuaranteeDuration">pproc:finalFinancialGuaranteeDuration</a>
    /// </summary>
    let finalFinancialGuaranteeDuration =
        _prefixId.prefix "finalFinancialGuaranteeDuration"

    /// <summary>
    ///   <para>rdfs:label : Formalized daterdfs:label : Fecha de formalización</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#formalizedDate">pproc:formalizedDate</a>
    /// </summary>
    let formalizedDate = _prefixId.prefix "formalizedDate"
    /// <summary>
    ///   <para>rdfs:label : Framework agreementrdfs:label : Acuerdo marco o sistema dinámico de contratación</para>
    ///   <para>rdfs:comment : Property that indicates the framework agreement in which the contract consists.
    ///
    /// This property is used when the actual contract consist in the declaration of a framework agreement or a dynamic purchasing system.rdfs:comment : Señala al acuerdo marco o sistema dinámico de contratación en el cual consiste el contrato.
    ///
    /// Esta propiedad se utiliza cuando el actual contrato consista en la declaración de un acuerdo marco o un sistema dinámico de contratación.</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#frameworkAgreement">pproc:frameworkAgreement</a>
    /// </summary>
    let frameworkAgreement = _prefixId.prefix "frameworkAgreement"

    /// <summary>
    ///   <para>rdfs:label : Framework agreement derivative contractrdfs:label : Contrato derivado de un acuerdo marco</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#frameworkAgreementDerivativeContract">pproc:frameworkAgreementDerivativeContract</a>
    /// </summary>
    let frameworkAgreementDerivativeContract =
        _prefixId.prefix "frameworkAgreementDerivativeContract"

    /// <summary>
    ///   <para>rdfs:label : Full memberrdfs:label : Miembro titular</para>
    ///   <para>rdfs:comment : Points to a full member of a committee.rdfs:comment : Miembro titular en una mesa de contratación.</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#fullMember">pproc:fullMember</a>
    /// </summary>
    let fullMember = _prefixId.prefix "fullMember"
    /// <summary>
    ///   <para>rdfs:label : Information kindrdfs:label : Tipo de información</para>
    ///   <para>rdfs:comment : Property pointing to the type of the information is provided.rdfs:comment : Indica el tipo de información que suministra un proveedor de información.
    ///
    /// Es posible utilizar esta propiedad numerosas veces para indicar diversos tipos de información.</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#informationKind">pproc:informationKind</a>
    /// </summary>
    let informationKind = _prefixId.prefix "informationKind"
    /// <summary>
    ///   <para>rdfs:label : Is negotiablerdfs:label : Es negociable</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#isNegotiable">pproc:isNegotiable</a>
    /// </summary>
    let isNegotiable = _prefixId.prefix "isNegotiable"
    /// <summary>
    ///   <para>rdfs:label : Itemrdfs:label : Artículo</para>
    ///   <para>rdfs:comment : Property for attachment of an item to a tender.</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#item">pproc:item</a>
    /// </summary>
    let item = _prefixId.prefix "item"
    /// <summary>
    ///   <para>rdfs:label : Legal document referencerdfs:label : Pliego de cláusulas administrativas</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#legalDocumentReference">pproc:legalDocumentReference</a>
    /// </summary>
    let legalDocumentReference = _prefixId.prefix "legalDocumentReference"
    /// <summary>
    ///   <para>rdfs:label : Place of contract's realizationrdfs:label : Lugar de realización del contrato</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#location">pproc:location</a>
    /// </summary>
    let location = _prefixId.prefix "location"
    /// <summary>
    ///   <para>rdfs:label : Lodged remedy daterdfs:label : Fecha de interposición del recurso</para>
    ///   <para>rdfs:comment : Date where a remedy is lodged.rdfs:comment : Fecha en la cual se ha interpuesto el recurso ante el órgano oficial.</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#lodgedRemedyDate">pproc:lodgedRemedyDate</a>
    /// </summary>
    let lodgedRemedyDate = _prefixId.prefix "lodgedRemedyDate"
    /// <summary>
    ///   <para>rdfs:label : Lotrdfs:label : Lote^^xsd:string</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#lot">pproc:lot</a>
    /// </summary>
    let lot = _prefixId.prefix "lot"
    /// <summary>
    ///   <para>rdfs:label : Main object of contractrdfs:label : Principal objeto del contrato</para>
    ///   <para>rdfs:comment : Property that points to the concept of the CPV code of an object.
    ///
    /// The concept used should be a valid representation of a CPV code, as it is in http://cpv.data.ac.uk/.rdfs:comment : Representación CPV del objeto de un contrato.
    ///
    /// Debe apuntar a un concepto de objeto siguiendo la clasificación CPV de algún esquema de conceptos SKOS, como http://cpv.data.ac.uk/.</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#mainObject">pproc:mainObject</a>
    /// </summary>
    let mainObject = _prefixId.prefix "mainObject"
    /// <summary>
    ///   <para>rdfs:label : Managing departmentrdfs:label : Servicio gestor</para>
    ///   <para>rdfs:comment : Property that indicates the managing departament responsible of the contract.rdfs:comment : Servicio perteneciente a la entidad contratante que se encarga de la publicación y administración de este contrato.</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#managingDepartment">pproc:managingDepartment</a>
    /// </summary>
    let managingDepartment = _prefixId.prefix "managingDepartment"
    /// <summary>
    ///   <para>rdfs:label : Maximum budget changerdfs:label : Modificación máxima de presupuesto</para>
    ///   <para>rdfs:comment : The range of this property must be a percentage (i.e. float between 0.0 and 100.0)rdfs:comment : El rango en esta propiedad indica un porcentaje, por lo que el rango del número real a utilizar debe estar comprendido entre 0.0 y 100.0.</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#maxBudgetChange">pproc:maxBudgetChange</a>
    /// </summary>
    let maxBudgetChange = _prefixId.prefix "maxBudgetChange"
    /// <summary>
    ///   <para>rdfs:label : Maximum final price changerdfs:label : Modificación máxima sobre precio final</para>
    ///   <para>rdfs:comment : The range of this property must be a percentage (i.e. float between 0.0 and 100.0)rdfs:comment : El rango en esta propiedad indica un porcentaje, por lo que el rango del número real a utilizar debe estar comprendido entre 0.0 y 100.0.</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#maxFinalPriceChange">pproc:maxFinalPriceChange</a>
    /// </summary>
    let maxFinalPriceChange = _prefixId.prefix "maxFinalPriceChange"
    /// <summary>
    ///   <para>rdfs:label : Maximum number of invitationsrdfs:label : Número máximo de invitaciones</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#maxInvitations">pproc:maxInvitations</a>
    /// </summary>
    let maxInvitations = _prefixId.prefix "maxInvitations"
    /// <summary>
    ///   <para>rdfs:label : Maximum number of operatorsrdfs:label : Número máximo de participantes</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#maxNumberOfOperators">pproc:maxNumberOfOperators</a>
    /// </summary>
    let maxNumberOfOperators = _prefixId.prefix "maxNumberOfOperators"
    /// <summary>
    ///   <para>rdfs:label : Maximum subcontractingrdfs:label : Subcontratación máxima</para>
    ///   <para>rdfs:comment : The range of this property must be a percentage (i.e. float between 0.0 and 100.0)rdfs:comment : El rango en esta propiedad indica un porcentaje, por lo que el rango del número real a utilizar debe estar comprendido entre 0.0 y 100.0.</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#maxSubcontracting">pproc:maxSubcontracting</a>
    /// </summary>
    let maxSubcontracting = _prefixId.prefix "maxSubcontracting"
    /// <summary>
    ///   <para>rdfs:label : Minimum number of invitationsrdfs:label : Número mínimo de invitaciones</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#minInvitations">pproc:minInvitations</a>
    /// </summary>
    let minInvitations = _prefixId.prefix "minInvitations"
    /// <summary>
    ///   <para>rdfs:label : Minimum number of operatorsrdfs:label : Número mínimo de participantes</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#minNumberOfOperators">pproc:minNumberOfOperators</a>
    /// </summary>
    let minNumberOfOperators = _prefixId.prefix "minNumberOfOperators"
    /// <summary>
    ///   <para>rdfs:label : Minimum subcontractingrdfs:label : Subcontratación mínima</para>
    ///   <para>rdfs:comment : The range of this property must be a percentage (i.e. float between 0.0 and 100.0)rdfs:comment : El rango en esta propiedad indica un porcentaje, por lo que el rango del número real a utilizar debe estar comprendido entre 0.0 y 100.0.</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#minSubcontracting">pproc:minSubcontracting</a>
    /// </summary>
    let minSubcontracting = _prefixId.prefix "minSubcontracting"
    /// <summary>
    ///   <para>rdfs:label : Minutes document referencerdfs:label : Acta</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#minutesDocumentReference">pproc:minutesDocumentReference</a>
    /// </summary>
    let minutesDocumentReference = _prefixId.prefix "minutesDocumentReference"
    /// <summary>
    ///   <para>rdfs:label : Modification reasonrdfs:label : Justificación de la modificación</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#modificationReason">pproc:modificationReason</a>
    /// </summary>
    let modificationReason = _prefixId.prefix "modificationReason"
    /// <summary>
    ///   <para>rdfs:label : Modification scoperdfs:label : Alcance de la modificación</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#modificationScope">pproc:modificationScope</a>
    /// </summary>
    let modificationScope = _prefixId.prefix "modificationScope"
    /// <summary>
    ///   <para>rdfs:label : Noticerdfs:label : Anuncio</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#notice">pproc:notice</a>
    /// </summary>
    let notice = _prefixId.prefix "notice"
    /// <summary>
    ///   <para>rdfs:label : Date of notice publicationrdfs:label : Fecha de publicación del anuncio</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#noticeDate">pproc:noticeDate</a>
    /// </summary>
    let noticeDate = _prefixId.prefix "noticeDate"
    /// <summary>
    ///   <para>rdfs:label : Notice sent daterdfs:label : Fecha de envio del anuncio</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#noticeSentDate">pproc:noticeSentDate</a>
    /// </summary>
    let noticeSentDate = _prefixId.prefix "noticeSentDate"
    /// <summary>
    ///   <para>rdfs:label : Notice siterdfs:label : Medio de publicación del anuncio</para>
    ///   <para>rdfs:comment : Property that indicates the sire where the notice is published. Normally it would be an official source, like the Official Jounral of the European Union, but it can be anywhere else, like press.rdfs:comment : Esta propiedad se refiere al medio donde ha publicado el anuncio. Habitualmente este será un boletín o diario oficial, por ejemplo, el DOUE, BOE o boletín autonómico correspondiente, pero puede ser que sea publicado en prensa u otros medios.</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#noticeSite">pproc:noticeSite</a>
    /// </summary>
    let noticeSite = _prefixId.prefix "noticeSite"
    /// <summary>
    ///   <para>rdfs:label : Notice webrdfs:label : Web del anuncio</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#noticeWeb">pproc:noticeWeb</a>
    /// </summary>
    let noticeWeb = _prefixId.prefix "noticeWeb"
    /// <summary>
    ///   <para>rdfs:label : Number of lotsrdfs:label : Número de lotes</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#numberOfLots">pproc:numberOfLots</a>
    /// </summary>
    let numberOfLots = _prefixId.prefix "numberOfLots"
    /// <summary>
    ///   <para>rdfs:label : Offered durationrdfs:label : Plazo de ejecución ofertado</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#offeredDuration">pproc:offeredDuration</a>
    /// </summary>
    let offeredDuration = _prefixId.prefix "offeredDuration"
    /// <summary>
    ///   <para>rdfs:label : Offered end daterdfs:label : Fecha de finalización ofertada</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#offeredEndDate">pproc:offeredEndDate</a>
    /// </summary>
    let offeredEndDate = _prefixId.prefix "offeredEndDate"
    /// <summary>
    ///   <para>rdfs:label : Other ability requisitesrdfs:label : Otros requisitos</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#otherAbilityRequisites">pproc:otherAbilityRequisites</a>
    /// </summary>
    let otherAbilityRequisites = _prefixId.prefix "otherAbilityRequisites"
    /// <summary>
    ///   <para>rdfs:label : Other award termsrdfs:label : Otras condiciones de la adjudicación</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#otherAwardTerms">pproc:otherAwardTerms</a>
    /// </summary>
    let otherAwardTerms = _prefixId.prefix "otherAwardTerms"
    /// <summary>
    ///   <para>rdfs:label : Other guaranteerdfs:label : Otras garantías</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#otherGuarantee">pproc:otherGuarantee</a>
    /// </summary>
    let otherGuarantee = _prefixId.prefix "otherGuarantee"
    /// <summary>
    ///   <para>rdfs:label : Pricerdfs:label : Precio</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#price">pproc:price</a>
    /// </summary>
    let price = _prefixId.prefix "price"
    /// <summary>
    ///   <para>rdfs:label : Price percentage changerdfs:label : Porcentaje de variación sobre el precio</para>
    ///   <para>rdfs:comment : The range of this property must be a percentage (i.e. float between 0.0 and 100.0)rdfs:comment : El rango en esta propiedad indica un porcentaje, por lo que el rango del número real a utilizar debe estar comprendido entre 0.0 y 100.0.</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#pricePercentageChange">pproc:pricePercentageChange</a>
    /// </summary>
    let pricePercentageChange = _prefixId.prefix "pricePercentageChange"
    /// <summary>
    ///   <para>rdfs:label : Price review allowablerdfs:label : Revisión de precios permitida</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#priceReviewAllowable">pproc:priceReviewAllowable</a>
    /// </summary>
    let priceReviewAllowable = _prefixId.prefix "priceReviewAllowable"
    /// <summary>
    ///   <para>rdfs:label : Price Review Indexrdfs:label : Fórmula de revisión de precios</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#priceReviewIndex">pproc:priceReviewIndex</a>
    /// </summary>
    let priceReviewIndex = _prefixId.prefix "priceReviewIndex"
    /// <summary>
    ///   <para>rdfs:label : Procedure resignationrdfs:label : Desistimiento del procedimiento</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#procedureResignation">pproc:procedureResignation</a>
    /// </summary>
    let procedureResignation = _prefixId.prefix "procedureResignation"
    /// <summary>
    ///   <para>rdfs:label : Procedure typerdfs:label : Tipo de procedimiento</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#procedureType">pproc:procedureType</a>
    /// </summary>
    let procedureType = _prefixId.prefix "procedureType"
    /// <summary>
    ///   <para>rdfs:label : Procedure voidrdfs:label : Procedimiento desierto</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#procedureVoid">pproc:procedureVoid</a>
    /// </summary>
    let procedureVoid = _prefixId.prefix "procedureVoid"
    /// <summary>
    ///   <para>rdfs:label : Procedure waiverdfs:label : Renuncia del procedimiento</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#procedureWaive">pproc:procedureWaive</a>
    /// </summary>
    let procedureWaive = _prefixId.prefix "procedureWaive"
    /// <summary>
    ///   <para>rdfs:label : Prorogation number expectedrdfs:label : Prórrogas previstas</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#prorogationsExpected">pproc:prorogationsExpected</a>
    /// </summary>
    let prorogationsExpected = _prefixId.prefix "prorogationsExpected"
    /// <summary>
    ///   <para>rdfs:label : Provisionrdfs:label : Prestación</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#provision">pproc:provision</a>
    /// </summary>
    let provision = _prefixId.prefix "provision"
    /// <summary>
    ///   <para>rdfs:label : Provisional financial guaranteerdfs:label : Garantía provisional</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#provisionalFinancialGuarantee">pproc:provisionalFinancialGuarantee</a>
    /// </summary>
    let provisionalFinancialGuarantee = _prefixId.prefix "provisionalFinancialGuarantee"
    /// <summary>
    ///   <para>rdfs:label : Recurrent remedyrdfs:label : Recurso recurrente</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#recurrentRemedy">pproc:recurrentRemedy</a>
    /// </summary>
    let recurrentRemedy = _prefixId.prefix "recurrentRemedy"
    /// <summary>
    ///   <para>rdfs:label : Remedyrdfs:label : Recurso</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#remedy">pproc:remedy</a>
    /// </summary>
    let remedy = _prefixId.prefix "remedy"
    /// <summary>
    ///   <para>rdfs:label : Remedy interposed tordfs:label : Recurso interpuesto a</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#remedyInterposedTo">pproc:remedyInterposedTo</a>
    /// </summary>
    let remedyInterposedTo = _prefixId.prefix "remedyInterposedTo"
    /// <summary>
    ///   <para>rdfs:label : Remedy reasonrdfs:label : Causa del recurso</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#remedyReason">pproc:remedyReason</a>
    /// </summary>
    let remedyReason = _prefixId.prefix "remedyReason"
    /// <summary>
    ///   <para>rdfs:label : Remedy resolutionrdfs:label : Resolución del recurso</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#remedyResolution">pproc:remedyResolution</a>
    /// </summary>
    let remedyResolution = _prefixId.prefix "remedyResolution"
    /// <summary>
    ///   <para>rdfs:label : Remedy resolution daterdfs:label : Fecha de resolución del recurso</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#remedyResolutionDate">pproc:remedyResolutionDate</a>
    /// </summary>
    let remedyResolutionDate = _prefixId.prefix "remedyResolutionDate"
    /// <summary>
    ///   <para>rdfs:label : Remedy resultrdfs:label : Resultado del recurso</para>
    ///   <para>rdfs:comment : Contains the result of a lodged remedy. Normally it would contains values like "Estimated", "Rejected" or "Partially estimated".rdfs:comment : Contiene el resultado del recurso interpuesto en un contrato. Normalmente el valor de esta propiedad incluirá valores como "Estimado", "Estimado parcialmente" o "Desestimado".</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#remedyResult">pproc:remedyResult</a>
    /// </summary>
    let remedyResult = _prefixId.prefix "remedyResult"
    /// <summary>
    ///   <para>rdfs:label : Required classificationrdfs:label : Clasificación requerida</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#requiredClassification">pproc:requiredClassification</a>
    /// </summary>
    let requiredClassification = _prefixId.prefix "requiredClassification"

    /// <summary>
    ///   <para>rdfs:label : Required economic and financial standingrdfs:label : Solvencia económica y financiera requerida</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#requiredEconomicAndFinancialStanding">pproc:requiredEconomicAndFinancialStanding</a>
    /// </summary>
    let requiredEconomicAndFinancialStanding =
        _prefixId.prefix "requiredEconomicAndFinancialStanding"

    /// <summary>
    ///   <para>rdfs:label : Required technical and professional abilityrdfs:label : Solvencia técnica y profesional requerida</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#requiredTechnicalAndProfessionalAbility">pproc:requiredTechnicalAndProfessionalAbility</a>
    /// </summary>
    let requiredTechnicalAndProfessionalAbility =
        _prefixId.prefix "requiredTechnicalAndProfessionalAbility"

    /// <summary>
    ///   <para>rdfs:label : Reserved contract restrictionsrdfs:label : Contratos reservados</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#reservedContractRestrictions">pproc:reservedContractRestrictions</a>
    /// </summary>
    let reservedContractRestrictions = _prefixId.prefix "reservedContractRestrictions"
    /// <summary>
    ///   <para>rdfs:label : Resolution document referencerdfs:label : Resolución</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#resolutionDocumentReference">pproc:resolutionDocumentReference</a>
    /// </summary>
    let resolutionDocumentReference = _prefixId.prefix "resolutionDocumentReference"
    /// <summary>
    ///   <para>rdfs:label : Scorerdfs:label : Puntuaciónrdfs:label : Valoración</para>
    ///   <para>rdfs:comment : Indica la puntuación que ha recibido un criterio.</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#score">pproc:score</a>
    /// </summary>
    let score = _prefixId.prefix "score"
    /// <summary>
    ///   <para>rdfs:label : Technical document referencerdfs:label : Pliego de prescripciones técnicas</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#technicalDocumentReference">pproc:technicalDocumentReference</a>
    /// </summary>
    let technicalDocumentReference = _prefixId.prefix "technicalDocumentReference"
    /// <summary>
    ///   <para>rdfs:label : Tender admission meetingrdfs:label : Reunión sobre admisión de licitadores</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#tenderAdmissionMeeting">pproc:tenderAdmissionMeeting</a>
    /// </summary>
    let tenderAdmissionMeeting = _prefixId.prefix "tenderAdmissionMeeting"
    /// <summary>
    ///   <para>rdfs:label : Tender briefingrdfs:label : Reunión informativa</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#tenderBriefing">pproc:tenderBriefing</a>
    /// </summary>
    let tenderBriefing = _prefixId.prefix "tenderBriefing"

    /// <summary>
    ///   <para>rdfs:label : Tender committee appointment daterdfs:label : Fecha de nombramiento</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#tenderCommitteeAppointmentDate">pproc:tenderCommitteeAppointmentDate</a>
    /// </summary>
    let tenderCommitteeAppointmentDate =
        _prefixId.prefix "tenderCommitteeAppointmentDate"

    /// <summary>
    ///   <para>rdfs:label : Tender committee rolerdfs:label : Cargo en el comité de contratación</para>
    ///   <para>rdfs:comment : Indicated the role of a person inside the committee.rdfs:comment : Indica el cargo que una persona ostenta dentro del comité del contratación.</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#tenderCommitteeRole">pproc:tenderCommitteeRole</a>
    /// </summary>
    let tenderCommitteeRole = _prefixId.prefix "tenderCommitteeRole"
    /// <summary>
    ///   <para>rdfs:label : Time-limit for submission of tenders or requests to participaterdfs:label : Fecha límite para la presentación de ofertas o de peticiones a participar</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#tenderDeadline">pproc:tenderDeadline</a>
    /// </summary>
    let tenderDeadline = _prefixId.prefix "tenderDeadline"
    /// <summary>
    ///   <para>rdfs:label : Tender document needsrdfs:label : Documentación a presentar</para>
    ///   <para>rdfs:comment : Defines the necessary documentation a tender must include.rdfs:comment : Define la documentación necesaria a presentar en las ofertas.</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#tenderDocumentNeeds">pproc:tenderDocumentNeeds</a>
    /// </summary>
    let tenderDocumentNeeds = _prefixId.prefix "tenderDocumentNeeds"
    /// <summary>
    ///   <para>rdfs:label : Start date of the tender dossierrdfs:label : Fecha de la resolución del inicio del expediente de contratación</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#tenderDossierStartDate">pproc:tenderDossierStartDate</a>
    /// </summary>
    let tenderDossierStartDate = _prefixId.prefix "tenderDossierStartDate"
    /// <summary>
    ///   <para>rdfs:label : Tender information providerrdfs:label : Proveedor de información sobre la licitación</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#tenderInformationProvider">pproc:tenderInformationProvider</a>
    /// </summary>
    let tenderInformationProvider = _prefixId.prefix "tenderInformationProvider"
    /// <summary>
    ///   <para>rdfs:label : Tender manteinance durationrdfs:label : Plazo de vigencia de las ofertas</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#tenderManteinanceDuration">pproc:tenderManteinanceDuration</a>
    /// </summary>
    let tenderManteinanceDuration = _prefixId.prefix "tenderManteinanceDuration"
    /// <summary>
    ///   <para>rdfs:label : Tender meetingrdfs:label : Reunión de la mesa de contratación</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#tenderMeeting">pproc:tenderMeeting</a>
    /// </summary>
    let tenderMeeting = _prefixId.prefix "tenderMeeting"
    /// <summary>
    ///   <para>rdfs:label : Tender purposerdfs:label : Propósito de la reunión</para>
    ///   <para>rdfs:comment : Indicates the purpose of the meeting (e.g. opening of first envelope).rdfs:comment : Indica, de manera textual, el propósito de la reunión de contratación (e.g. apertura de sobre A)</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#tenderPurpose">pproc:tenderPurpose</a>
    /// </summary>
    let tenderPurpose = _prefixId.prefix "tenderPurpose"
    /// <summary>
    ///   <para>rdfs:label : Tender requirementsrdfs:label : Requisitos para las ofertas</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#tenderRequirements">pproc:tenderRequirements</a>
    /// </summary>
    let tenderRequirements = _prefixId.prefix "tenderRequirements"
    /// <summary>
    ///   <para>rdfs:label : Tender submission locationrdfs:label : Sede de presentación de las ofertas</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#tenderSubmissionLocation">pproc:tenderSubmissionLocation</a>
    /// </summary>
    let tenderSubmissionLocation = _prefixId.prefix "tenderSubmissionLocation"
    /// <summary>
    ///   <para>rdfs:label : Tender submission moderdfs:label : Modalidad de presentación</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#tenderSubmissionMode">pproc:tenderSubmissionMode</a>
    /// </summary>
    let tenderSubmissionMode = _prefixId.prefix "tenderSubmissionMode"

    /// <summary>
    ///   <para>rdfs:label : Tender submission supported languagerdfs:label : Idioma admitido en la presentación de oferta</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#tenderSubmissionSupportedLanguage">pproc:tenderSubmissionSupportedLanguage</a>
    /// </summary>
    let tenderSubmissionSupportedLanguage =
        _prefixId.prefix "tenderSubmissionSupportedLanguage"

    /// <summary>
    ///   <para>rdfs:label : Tenderers requirementsrdfs:label : Requisitos de los licitadores</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#tenderersRequirements">pproc:tenderersRequirements</a>
    /// </summary>
    let tenderersRequirements = _prefixId.prefix "tenderersRequirements"
    /// <summary>
    ///   <para>rdfs:label : Urgency typerdfs:label : Tipo de tramitación</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#urgencyType">pproc:urgencyType</a>
    /// </summary>
    let urgencyType = _prefixId.prefix "urgencyType"
    /// <summary>
    ///   <para>rdfs:label : Variant admissionrdfs:label : Admisión de variantes</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#variantAdmission">pproc:variantAdmission</a>
    /// </summary>
    let variantAdmission = _prefixId.prefix "variantAdmission"
    /// <summary>
    ///   <para>rdfs:label : Variant descriptionrdfs:label : Descripción de las variantes</para>
    ///   <para>rdfs:comment : Property to describe the allowed variantes when submitting a variant of a contract.rdfs:comment : Campo para incluir la descripción, alcance, plazo u otros aspectos que están permitidos al presentar variantes en un contrato.</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#variantDescription">pproc:variantDescription</a>
    /// </summary>
    let variantDescription = _prefixId.prefix "variantDescription"
    /// <summary>
    ///   <para>rdfs:label : Website with informationrdfs:label : Web con información</para>
    ///   <a href="http://contsem.unizar.es/def/sector-publico/pproc#websiteWithInformation">pproc:websiteWithInformation</a>
    /// </summary>
    let websiteWithInformation = _prefixId.prefix "websiteWithInformation"
