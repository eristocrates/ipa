namespace http.contsem.unizar.es.def.sector_publico.pproc.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module pproc =
    let _namespace_iri = Namespace_Iri pproc |> NamespaceIRI
    /// <summary>
    ///   <para>pproc:MixedContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Mixed contract</para><para>Contrato mixto</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#MixedContract">http://contsem.unizar.es/def/sector-publico/pproc#MixedContract</seealso>
    let MixedContract = Prefixed_Name(pproc, "MixedContract") |> PrefixedName

    /// <summary>
    ///   <para>pproc:PublicPrivatePartnershipContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Contrato de colaboración público-privada</para><para>Public-private partnership contract</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#PublicPrivatePartnershipContract">http://contsem.unizar.es/def/sector-publico/pproc#PublicPrivatePartnershipContract</seealso>
    let PublicPrivatePartnershipContract =
        Prefixed_Name(pproc, "PublicPrivatePartnershipContract") |> PrefixedName

    /// <summary>
    ///   <para>pproc:PublicWorksConcessionContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Contrato de concesión de obras públicas</para><para>Public works concession contract</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#PublicWorksConcessionContract">http://contsem.unizar.es/def/sector-publico/pproc#PublicWorksConcessionContract</seealso>
    let PublicWorksConcessionContract =
        Prefixed_Name(pproc, "PublicWorksConcessionContract") |> PrefixedName

    /// <summary>
    ///   <para>pproc:PrecomercialProcurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Compra pública pre-comercial</para><para>Precomercial procurement</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#PrecomercialProcurement">http://contsem.unizar.es/def/sector-publico/pproc#PrecomercialProcurement</seealso>
    let PrecomercialProcurement =
        Prefixed_Name(pproc, "PrecomercialProcurement") |> PrefixedName

    /// <summary>
    ///   <para>pproc:PublicServicesManagementContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Contrato de gestión de servicios públicos</para><para>Public services management contract</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#PublicServicesManagementContract">http://contsem.unizar.es/def/sector-publico/pproc#PublicServicesManagementContract</seealso>
    let PublicServicesManagementContract =
        Prefixed_Name(pproc, "PublicServicesManagementContract") |> PrefixedName

    /// <summary>
    ///   <para>pproc:SpecialAdministrativeContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Contrato administrativo especial</para><para>Special administrative contract</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#SpecialAdministrativeContract">http://contsem.unizar.es/def/sector-publico/pproc#SpecialAdministrativeContract</seealso>
    let SpecialAdministrativeContract =
        Prefixed_Name(pproc, "SpecialAdministrativeContract") |> PrefixedName

    /// <summary>
    ///   <para>pproc:SuppliesContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class describing contracts whose object is the acquisition of supplies.</para>
    ///   <para>Clase de los contratos cuyo objeto es la adquisición de suministros. Esta adquisición puede ser bien mediante compra, alquiler o arrendamiento financiero.</para>
    /// labels<para>Contrato de suministros</para><para>Supplies contract</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#SuppliesContract">http://contsem.unizar.es/def/sector-publico/pproc#SuppliesContract</seealso>
    let SuppliesContract = Prefixed_Name(pproc, "SuppliesContract") |> PrefixedName
    /// <summary>
    ///   <para>pproc:CorrectionNotice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Anuncio de corrección</para><para>Correction notice</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#CorrectionNotice">http://contsem.unizar.es/def/sector-publico/pproc#CorrectionNotice</seealso>
    let CorrectionNotice = Prefixed_Name(pproc, "CorrectionNotice") |> PrefixedName

    /// <summary>
    ///   <para>pproc:maxFinalPriceChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The range of this property must be a percentage (i.e. float between 0.0 and 100.0)</para>
    ///   <para>El rango en esta propiedad indica un porcentaje, por lo que el rango del número real a utilizar debe estar comprendido entre 0.0 y 100.0.</para>
    /// labels<para>Modificación máxima sobre precio final</para><para>Maximum final price change</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#maxFinalPriceChange">http://contsem.unizar.es/def/sector-publico/pproc#maxFinalPriceChange</seealso>
    let maxFinalPriceChange =
        Prefixed_Name(pproc, "maxFinalPriceChange") |> PrefixedName

    /// <summary>
    ///   <para>pproc:maxInvitations</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Número máximo de invitaciones</para><para>Maximum number of invitations</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#maxInvitations">http://contsem.unizar.es/def/sector-publico/pproc#maxInvitations</seealso>
    let maxInvitations = Prefixed_Name(pproc, "maxInvitations") |> PrefixedName
    /// <summary>
    ///   <para>pproc:maxSubcontracting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>El rango en esta propiedad indica un porcentaje, por lo que el rango del número real a utilizar debe estar comprendido entre 0.0 y 100.0.</para>
    ///   <para>The range of this property must be a percentage (i.e. float between 0.0 and 100.0)</para>
    /// labels<para>Maximum subcontracting</para><para>Subcontratación máxima</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#maxSubcontracting">http://contsem.unizar.es/def/sector-publico/pproc#maxSubcontracting</seealso>
    let maxSubcontracting = Prefixed_Name(pproc, "maxSubcontracting") |> PrefixedName
    /// <summary>
    ///   <para>pproc:minInvitations</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Minimum number of invitations</para><para>Número mínimo de invitaciones</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#minInvitations">http://contsem.unizar.es/def/sector-publico/pproc#minInvitations</seealso>
    let minInvitations = Prefixed_Name(pproc, "minInvitations") |> PrefixedName

    /// <summary>
    ///   <para>pproc:minNumberOfOperators</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Número mínimo de participantes</para><para>Minimum number of operators</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#minNumberOfOperators">http://contsem.unizar.es/def/sector-publico/pproc#minNumberOfOperators</seealso>
    let minNumberOfOperators =
        Prefixed_Name(pproc, "minNumberOfOperators") |> PrefixedName

    /// <summary>
    ///   <para>pproc:minutesDocumentReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Minutes document reference</para><para>Acta</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#minutesDocumentReference">http://contsem.unizar.es/def/sector-publico/pproc#minutesDocumentReference</seealso>
    let minutesDocumentReference =
        Prefixed_Name(pproc, "minutesDocumentReference") |> PrefixedName

    /// <summary>
    ///   <para>pproc:notice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Anuncio</para><para>Notice</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#notice">http://contsem.unizar.es/def/sector-publico/pproc#notice</seealso>
    let notice = Prefixed_Name(pproc, "notice") |> PrefixedName
    /// <summary>
    ///   <para>pproc:noticeSentDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Fecha de envio del anuncio</para><para>Notice sent date</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#noticeSentDate">http://contsem.unizar.es/def/sector-publico/pproc#noticeSentDate</seealso>
    let noticeSentDate = Prefixed_Name(pproc, "noticeSentDate") |> PrefixedName
    /// <summary>
    ///   <para>pproc:noticeWeb</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Web del anuncio</para><para>Notice web</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#noticeWeb">http://contsem.unizar.es/def/sector-publico/pproc#noticeWeb</seealso>
    let noticeWeb = Prefixed_Name(pproc, "noticeWeb") |> PrefixedName

    /// <summary>
    ///   <para>pproc:otherAbilityRequisites</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Other ability requisites</para><para>Otros requisitos</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#otherAbilityRequisites">http://contsem.unizar.es/def/sector-publico/pproc#otherAbilityRequisites</seealso>
    let otherAbilityRequisites =
        Prefixed_Name(pproc, "otherAbilityRequisites") |> PrefixedName

    /// <summary>
    ///   <para>pproc:PriorInformationNotice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Anuncio de información previa</para><para>Prior information notice</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#PriorInformationNotice">http://contsem.unizar.es/def/sector-publico/pproc#PriorInformationNotice</seealso>
    let PriorInformationNotice =
        Prefixed_Name(pproc, "PriorInformationNotice") |> PrefixedName

    /// <summary>
    ///   <para>pproc:Lot</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Clase de los contratos que representan un lote perteneciente a otro contrato.</para>
    ///   <para>Class describing contracts that are an actual lot of another contract.</para>
    /// labels<para>Lote</para><para>Lot</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#Lot">http://contsem.unizar.es/def/sector-publico/pproc#Lot</seealso>
    let Lot = Prefixed_Name(pproc, "Lot") |> PrefixedName
    /// <summary>
    ///   <para>pproc:LegalRemedy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Recurso legal</para><para>Legal remedy</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#LegalRemedy">http://contsem.unizar.es/def/sector-publico/pproc#LegalRemedy</seealso>
    let LegalRemedy = Prefixed_Name(pproc, "LegalRemedy") |> PrefixedName

    /// <summary>
    ///   <para>pproc:MultiannualContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class describing the multiannual contracts (i.e. contract whose duration extends over more than one financial year).</para>
    ///   <para>Clase de los contrato plurianuales (i.e. contratos cuya duración se extiende durante más de un ejercicio contable).</para>
    /// labels<para>Multiannual contract</para><para>Contrato plurianual</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#MultiannualContract">http://contsem.unizar.es/def/sector-publico/pproc#MultiannualContract</seealso>
    let MultiannualContract =
        Prefixed_Name(pproc, "MultiannualContract") |> PrefixedName

    /// <summary>
    ///   <para>pproc:otherGuarantee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Otras garantías</para><para>Other guarantee</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#otherGuarantee">http://contsem.unizar.es/def/sector-publico/pproc#otherGuarantee</seealso>
    let otherGuarantee = Prefixed_Name(pproc, "otherGuarantee") |> PrefixedName

    /// <summary>
    ///   <para>pproc:priceReviewAllowable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Revisión de precios permitida</para><para>Price review allowable</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#priceReviewAllowable">http://contsem.unizar.es/def/sector-publico/pproc#priceReviewAllowable</seealso>
    let priceReviewAllowable =
        Prefixed_Name(pproc, "priceReviewAllowable") |> PrefixedName

    /// <summary>
    ///   <para>pproc:procedureResignation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Desistimiento del procedimiento</para><para>Procedure resignation</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#procedureResignation">http://contsem.unizar.es/def/sector-publico/pproc#procedureResignation</seealso>
    let procedureResignation =
        Prefixed_Name(pproc, "procedureResignation") |> PrefixedName

    /// <summary>
    ///   <para>pproc:procedureType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Tipo de procedimiento</para><para>Procedure type</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#procedureType">http://contsem.unizar.es/def/sector-publico/pproc#procedureType</seealso>
    let procedureType = Prefixed_Name(pproc, "procedureType") |> PrefixedName

    /// <summary>
    ///   <para>pproc:DynamicPurchasingSystemDerivativeContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Clase de los contratos derivados de un sistema dinámico de contratación</para>
    ///   <para>Class describing contracts derived from a dynamic purchasing system.</para>
    /// labels<para>Contrato derivado de un sistema dinámico de contratación</para><para>Dynamic purchasing system derivative contract</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#DynamicPurchasingSystemDerivativeContract">http://contsem.unizar.es/def/sector-publico/pproc#DynamicPurchasingSystemDerivativeContract</seealso>
    let DynamicPurchasingSystemDerivativeContract =
        Prefixed_Name(pproc, "DynamicPurchasingSystemDerivativeContract") |> PrefixedName

    /// <summary>
    ///   <para>pproc:ElectronicAuction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class that specifies the existence of an electronic auction of one or more of the award criterions.</para>
    ///   <para>Clase para especificar la realización de una subasta electrónica de uno o más criterios de adjudicación.</para>
    /// labels<para>Subasta electrónica</para><para>Electronic auction</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#ElectronicAuction">http://contsem.unizar.es/def/sector-publico/pproc#ElectronicAuction</seealso>
    let ElectronicAuction = Prefixed_Name(pproc, "ElectronicAuction") |> PrefixedName
    /// <summary>
    ///   <para>pproc:UrgencyTypeScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Scheme that defines the kinds of urgency a procedure can follow.</para>
    /// labels<para>Esquema de tipos de urgencia</para><para>Urgency type scheme</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#UrgencyTypeScheme">http://contsem.unizar.es/def/sector-publico/pproc#UrgencyTypeScheme</seealso>
    let UrgencyTypeScheme = Prefixed_Name(pproc, "UrgencyTypeScheme") |> PrefixedName

    /// <summary>
    ///   <para>pproc:maxNumberOfOperators</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Número máximo de participantes</para><para>Maximum number of operators</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#maxNumberOfOperators">http://contsem.unizar.es/def/sector-publico/pproc#maxNumberOfOperators</seealso>
    let maxNumberOfOperators =
        Prefixed_Name(pproc, "maxNumberOfOperators") |> PrefixedName

    /// <summary>
    ///   <para>pproc:minSubcontracting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The range of this property must be a percentage (i.e. float between 0.0 and 100.0)</para>
    ///   <para>El rango en esta propiedad indica un porcentaje, por lo que el rango del número real a utilizar debe estar comprendido entre 0.0 y 100.0.</para>
    /// labels<para>Subcontratación mínima</para><para>Minimum subcontracting</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#minSubcontracting">http://contsem.unizar.es/def/sector-publico/pproc#minSubcontracting</seealso>
    let minSubcontracting = Prefixed_Name(pproc, "minSubcontracting") |> PrefixedName
    /// <summary>
    ///   <para>pproc:noticeDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Fecha de publicación del anuncio</para><para>Date of notice publication</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#noticeDate">http://contsem.unizar.es/def/sector-publico/pproc#noticeDate</seealso>
    let noticeDate = Prefixed_Name(pproc, "noticeDate") |> PrefixedName
    /// <summary>
    ///   <para>pproc:noticeSite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Property that indicates the sire where the notice is published. Normally it would be an official source, like the Official Jounral of the European Union, but it can be anywhere else, like press.</para>
    ///   <para>Esta propiedad se refiere al medio donde ha publicado el anuncio. Habitualmente este será un boletín o diario oficial, por ejemplo, el DOUE, BOE o boletín autonómico correspondiente, pero puede ser que sea publicado en prensa u otros medios.</para>
    /// labels<para>Medio de publicación del anuncio</para><para>Notice site</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#noticeSite">http://contsem.unizar.es/def/sector-publico/pproc#noticeSite</seealso>
    let noticeSite = Prefixed_Name(pproc, "noticeSite") |> PrefixedName
    /// <summary>
    ///   <para>pproc:offeredDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Plazo de ejecución ofertado</para><para>Offered duration</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#offeredDuration">http://contsem.unizar.es/def/sector-publico/pproc#offeredDuration</seealso>
    let offeredDuration = Prefixed_Name(pproc, "offeredDuration") |> PrefixedName
    /// <summary>
    ///   <para>pproc:offeredEndDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Fecha de finalización ofertada</para><para>Offered end date</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#offeredEndDate">http://contsem.unizar.es/def/sector-publico/pproc#offeredEndDate</seealso>
    let offeredEndDate = Prefixed_Name(pproc, "offeredEndDate") |> PrefixedName
    /// <summary>
    ///   <para>pproc:otherAwardTerms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Otras condiciones de la adjudicación</para><para>Other award terms</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#otherAwardTerms">http://contsem.unizar.es/def/sector-publico/pproc#otherAwardTerms</seealso>
    let otherAwardTerms = Prefixed_Name(pproc, "otherAwardTerms") |> PrefixedName

    /// <summary>
    ///   <para>pproc:pricePercentageChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The range of this property must be a percentage (i.e. float between 0.0 and 100.0)</para>
    ///   <para>El rango en esta propiedad indica un porcentaje, por lo que el rango del número real a utilizar debe estar comprendido entre 0.0 y 100.0.</para>
    /// labels<para>Porcentaje de variación sobre el precio</para><para>Price percentage change</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#pricePercentageChange">http://contsem.unizar.es/def/sector-publico/pproc#pricePercentageChange</seealso>
    let pricePercentageChange =
        Prefixed_Name(pproc, "pricePercentageChange") |> PrefixedName

    /// <summary>
    ///   <para>pproc:priceReviewIndex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Fórmula de revisión de precios</para><para>Price Review Index</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#priceReviewIndex">http://contsem.unizar.es/def/sector-publico/pproc#priceReviewIndex</seealso>
    let priceReviewIndex = Prefixed_Name(pproc, "priceReviewIndex") |> PrefixedName
    /// <summary>
    ///   <para>pproc:procedureVoid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Procedimiento desierto</para><para>Procedure void</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#procedureVoid">http://contsem.unizar.es/def/sector-publico/pproc#procedureVoid</seealso>
    let procedureVoid = Prefixed_Name(pproc, "procedureVoid") |> PrefixedName

    /// <summary>
    ///   <para>pproc:prorogationsExpected</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Prorogation number expected</para><para>Prórrogas previstas</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#prorogationsExpected">http://contsem.unizar.es/def/sector-publico/pproc#prorogationsExpected</seealso>
    let prorogationsExpected =
        Prefixed_Name(pproc, "prorogationsExpected") |> PrefixedName

    /// <summary>
    ///   <para>pproc:provision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Prestación</para><para>Provision</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#provision">http://contsem.unizar.es/def/sector-publico/pproc#provision</seealso>
    let provision = Prefixed_Name(pproc, "provision") |> PrefixedName
    /// <summary>
    ///   <para>pproc:recurrentRemedy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Recurso recurrente</para><para>Recurrent remedy</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#recurrentRemedy">http://contsem.unizar.es/def/sector-publico/pproc#recurrentRemedy</seealso>
    let recurrentRemedy = Prefixed_Name(pproc, "recurrentRemedy") |> PrefixedName
    /// <summary>
    ///   <para>pproc:remedyInterposedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Recurso interpuesto a</para><para>Remedy interposed to</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#remedyInterposedTo">http://contsem.unizar.es/def/sector-publico/pproc#remedyInterposedTo</seealso>
    let remedyInterposedTo = Prefixed_Name(pproc, "remedyInterposedTo") |> PrefixedName
    /// <summary>
    ///   <para>pproc:remedyReason</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Causa del recurso</para><para>Remedy reason</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#remedyReason">http://contsem.unizar.es/def/sector-publico/pproc#remedyReason</seealso>
    let remedyReason = Prefixed_Name(pproc, "remedyReason") |> PrefixedName
    /// <summary>
    ///   <para>pproc:remedyResolution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Resolución del recurso</para><para>Remedy resolution</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#remedyResolution">http://contsem.unizar.es/def/sector-publico/pproc#remedyResolution</seealso>
    let remedyResolution = Prefixed_Name(pproc, "remedyResolution") |> PrefixedName
    /// <summary>
    ///   <para>pproc:remedyResult</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Contiene el resultado del recurso interpuesto en un contrato. Normalmente el valor de esta propiedad incluirá valores como "Estimado", "Estimado parcialmente" o "Desestimado".</para>
    ///   <para>Contains the result of a lodged remedy. Normally it would contains values like "Estimated", "Rejected" or "Partially estimated".</para>
    /// labels<para>Resultado del recurso</para><para>Remedy result</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#remedyResult">http://contsem.unizar.es/def/sector-publico/pproc#remedyResult</seealso>
    let remedyResult = Prefixed_Name(pproc, "remedyResult") |> PrefixedName

    /// <summary>
    ///   <para>pproc:requiredClassification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Clasificación requerida</para><para>Required classification</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#requiredClassification">http://contsem.unizar.es/def/sector-publico/pproc#requiredClassification</seealso>
    let requiredClassification =
        Prefixed_Name(pproc, "requiredClassification") |> PrefixedName

    /// <summary>
    ///   <para>pproc:reservedContractRestrictions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Reserved contract restrictions</para><para>Contratos reservados</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#reservedContractRestrictions">http://contsem.unizar.es/def/sector-publico/pproc#reservedContractRestrictions</seealso>
    let reservedContractRestrictions =
        Prefixed_Name(pproc, "reservedContractRestrictions") |> PrefixedName

    /// <summary>
    ///   <para>pproc:resolutionDocumentReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Resolution document reference</para><para>Resolución</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#resolutionDocumentReference">http://contsem.unizar.es/def/sector-publico/pproc#resolutionDocumentReference</seealso>
    let resolutionDocumentReference =
        Prefixed_Name(pproc, "resolutionDocumentReference") |> PrefixedName

    /// <summary>
    ///   <para>pproc:tenderAdmissionMeeting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Reunión sobre admisión de licitadores</para><para>Tender admission meeting</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#tenderAdmissionMeeting">http://contsem.unizar.es/def/sector-publico/pproc#tenderAdmissionMeeting</seealso>
    let tenderAdmissionMeeting =
        Prefixed_Name(pproc, "tenderAdmissionMeeting") |> PrefixedName

    /// <summary>
    ///   <para>pproc:tenderBriefing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Reunión informativa</para><para>Tender briefing</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#tenderBriefing">http://contsem.unizar.es/def/sector-publico/pproc#tenderBriefing</seealso>
    let tenderBriefing = Prefixed_Name(pproc, "tenderBriefing") |> PrefixedName

    /// <summary>
    ///   <para>pproc:tenderCommitteeAppointmentDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Tender committee appointment date</para><para>Fecha de nombramiento</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#tenderCommitteeAppointmentDate">http://contsem.unizar.es/def/sector-publico/pproc#tenderCommitteeAppointmentDate</seealso>
    let tenderCommitteeAppointmentDate =
        Prefixed_Name(pproc, "tenderCommitteeAppointmentDate") |> PrefixedName

    /// <summary>
    ///   <para>pproc:tenderDeadline</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Fecha límite para la presentación de ofertas o de peticiones a participar</para><para>Time-limit for submission of tenders or requests to participate</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#tenderDeadline">http://contsem.unizar.es/def/sector-publico/pproc#tenderDeadline</seealso>
    let tenderDeadline = Prefixed_Name(pproc, "tenderDeadline") |> PrefixedName

    /// <summary>
    ///   <para>pproc:tenderDocumentNeeds</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Define la documentación necesaria a presentar en las ofertas.</para>
    ///   <para>Defines the necessary documentation a tender must include.</para>
    /// labels<para>Documentación a presentar</para><para>Tender document needs</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#tenderDocumentNeeds">http://contsem.unizar.es/def/sector-publico/pproc#tenderDocumentNeeds</seealso>
    let tenderDocumentNeeds =
        Prefixed_Name(pproc, "tenderDocumentNeeds") |> PrefixedName

    /// <summary>
    ///   <para>pproc:tenderInformationProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Proveedor de información sobre la licitación</para><para>Tender information provider</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#tenderInformationProvider">http://contsem.unizar.es/def/sector-publico/pproc#tenderInformationProvider</seealso>
    let tenderInformationProvider =
        Prefixed_Name(pproc, "tenderInformationProvider") |> PrefixedName

    /// <summary>
    ///   <para>pproc:tenderManteinanceDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Plazo de vigencia de las ofertas</para><para>Tender manteinance duration</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#tenderManteinanceDuration">http://contsem.unizar.es/def/sector-publico/pproc#tenderManteinanceDuration</seealso>
    let tenderManteinanceDuration =
        Prefixed_Name(pproc, "tenderManteinanceDuration") |> PrefixedName

    /// <summary>
    ///   <para>pproc:tenderMeeting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Reunión de la mesa de contratación</para><para>Tender meeting</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#tenderMeeting">http://contsem.unizar.es/def/sector-publico/pproc#tenderMeeting</seealso>
    let tenderMeeting = Prefixed_Name(pproc, "tenderMeeting") |> PrefixedName
    /// <summary>
    ///   <para>pproc:tenderRequirements</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Requisitos para las ofertas</para><para>Tender requirements</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#tenderRequirements">http://contsem.unizar.es/def/sector-publico/pproc#tenderRequirements</seealso>
    let tenderRequirements = Prefixed_Name(pproc, "tenderRequirements") |> PrefixedName

    /// <summary>
    ///   <para>pproc:tenderSubmissionLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Sede de presentación de las ofertas</para><para>Tender submission location</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#tenderSubmissionLocation">http://contsem.unizar.es/def/sector-publico/pproc#tenderSubmissionLocation</seealso>
    let tenderSubmissionLocation =
        Prefixed_Name(pproc, "tenderSubmissionLocation") |> PrefixedName

    /// <summary>
    ///   <para>pproc:tenderersRequirements</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Requisitos de los licitadores</para><para>Tenderers requirements</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#tenderersRequirements">http://contsem.unizar.es/def/sector-publico/pproc#tenderersRequirements</seealso>
    let tenderersRequirements =
        Prefixed_Name(pproc, "tenderersRequirements") |> PrefixedName

    /// <summary>
    ///   <para>pproc:urgencyType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Tipo de tramitación</para><para>Urgency type</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#urgencyType">http://contsem.unizar.es/def/sector-publico/pproc#urgencyType</seealso>
    let urgencyType = Prefixed_Name(pproc, "urgencyType") |> PrefixedName
    /// <summary>
    ///   <para>pproc:variantAdmission</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Admisión de variantes</para><para>Variant admission</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#variantAdmission">http://contsem.unizar.es/def/sector-publico/pproc#variantAdmission</seealso>
    let variantAdmission = Prefixed_Name(pproc, "variantAdmission") |> PrefixedName

    /// <summary>
    ///   <para>pproc:websiteWithInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Website with information</para><para>Web con información</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#websiteWithInformation">http://contsem.unizar.es/def/sector-publico/pproc#websiteWithInformation</seealso>
    let websiteWithInformation =
        Prefixed_Name(pproc, "websiteWithInformation") |> PrefixedName

    /// <summary>
    ///   <para>pproc:ContractAwardNotice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Anuncio de adjudicación</para><para>Contract award notice</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#ContractAwardNotice">http://contsem.unizar.es/def/sector-publico/pproc#ContractAwardNotice</seealso>
    let ContractAwardNotice =
        Prefixed_Name(pproc, "ContractAwardNotice") |> PrefixedName

    /// <summary>
    ///   <para>pproc:ContractWithLots</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Clase de los contratos dividos en lotes.
    ///
    /// Cuando un contrato de muy grande, este puede ser dividido en diversos lotes por la entidad contratante. Las empresas presentan las ofertas a estos lotes separadamente (y no al contrato "raíz"), realizándose la adjudicación de la misma manera.</para>
    ///   <para>Class of the contract that have lots.</para>
    /// labels<para>Contract with lots</para><para>Contrato con lotes</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#ContractWithLots">http://contsem.unizar.es/def/sector-publico/pproc#ContractWithLots</seealso>
    let ContractWithLots = Prefixed_Name(pproc, "ContractWithLots") |> PrefixedName
    /// <summary>
    ///   <para>pproc:remedy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Recurso</para><para>Remedy</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#remedy">http://contsem.unizar.es/def/sector-publico/pproc#remedy</seealso>
    let remedy = Prefixed_Name(pproc, "remedy") |> PrefixedName

    /// <summary>
    ///   <para>pproc:remedyResolutionDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Fecha de resolución del recurso</para><para>Remedy resolution date</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#remedyResolutionDate">http://contsem.unizar.es/def/sector-publico/pproc#remedyResolutionDate</seealso>
    let remedyResolutionDate =
        Prefixed_Name(pproc, "remedyResolutionDate") |> PrefixedName

    /// <summary>
    ///   <para>pproc:requiredEconomicAndFinancialStanding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Solvencia económica y financiera requerida</para><para>Required economic and financial standing</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#requiredEconomicAndFinancialStanding">http://contsem.unizar.es/def/sector-publico/pproc#requiredEconomicAndFinancialStanding</seealso>
    let requiredEconomicAndFinancialStanding =
        Prefixed_Name(pproc, "requiredEconomicAndFinancialStanding") |> PrefixedName

    /// <summary>
    ///   <para>pproc:requiredTechnicalAndProfessionalAbility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Required technical and professional ability</para><para>Solvencia técnica y profesional requerida</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#requiredTechnicalAndProfessionalAbility">http://contsem.unizar.es/def/sector-publico/pproc#requiredTechnicalAndProfessionalAbility</seealso>
    let requiredTechnicalAndProfessionalAbility =
        Prefixed_Name(pproc, "requiredTechnicalAndProfessionalAbility") |> PrefixedName

    /// <summary>
    ///   <para>pproc:score</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Indica la puntuación que ha recibido un criterio.</para>
    /// labels<para>Puntuación</para><para>Valoración</para><para>Score</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#score">http://contsem.unizar.es/def/sector-publico/pproc#score</seealso>
    let score = Prefixed_Name(pproc, "score") |> PrefixedName

    /// <summary>
    ///   <para>pproc:technicalDocumentReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Pliego de prescripciones técnicas</para><para>Technical document reference</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#technicalDocumentReference">http://contsem.unizar.es/def/sector-publico/pproc#technicalDocumentReference</seealso>
    let technicalDocumentReference =
        Prefixed_Name(pproc, "technicalDocumentReference") |> PrefixedName

    /// <summary>
    ///   <para>pproc:tenderCommitteeRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicated the role of a person inside the committee.</para>
    ///   <para>Indica el cargo que una persona ostenta dentro del comité del contratación.</para>
    /// labels<para>Cargo en el comité de contratación</para><para>Tender committee role</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#tenderCommitteeRole">http://contsem.unizar.es/def/sector-publico/pproc#tenderCommitteeRole</seealso>
    let tenderCommitteeRole =
        Prefixed_Name(pproc, "tenderCommitteeRole") |> PrefixedName

    /// <summary>
    ///   <para>pproc:tenderDossierStartDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Fecha de la resolución del inicio del expediente de contratación</para><para>Start date of the tender dossier</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#tenderDossierStartDate">http://contsem.unizar.es/def/sector-publico/pproc#tenderDossierStartDate</seealso>
    let tenderDossierStartDate =
        Prefixed_Name(pproc, "tenderDossierStartDate") |> PrefixedName

    /// <summary>
    ///   <para>pproc:tenderPurpose</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates the purpose of the meeting (e.g. opening of first envelope).</para>
    ///   <para>Indica, de manera textual, el propósito de la reunión de contratación (e.g. apertura de sobre A)</para>
    /// labels<para>Propósito de la reunión</para><para>Tender purpose</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#tenderPurpose">http://contsem.unizar.es/def/sector-publico/pproc#tenderPurpose</seealso>
    let tenderPurpose = Prefixed_Name(pproc, "tenderPurpose") |> PrefixedName

    /// <summary>
    ///   <para>pproc:tenderSubmissionMode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Modalidad de presentación</para><para>Tender submission mode</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#tenderSubmissionMode">http://contsem.unizar.es/def/sector-publico/pproc#tenderSubmissionMode</seealso>
    let tenderSubmissionMode =
        Prefixed_Name(pproc, "tenderSubmissionMode") |> PrefixedName

    /// <summary>
    ///   <para>pproc:tenderSubmissionSupportedLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Idioma admitido en la presentación de oferta</para><para>Tender submission supported language</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#tenderSubmissionSupportedLanguage">http://contsem.unizar.es/def/sector-publico/pproc#tenderSubmissionSupportedLanguage</seealso>
    let tenderSubmissionSupportedLanguage =
        Prefixed_Name(pproc, "tenderSubmissionSupportedLanguage") |> PrefixedName

    /// <summary>
    ///   <para>pproc:RentContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class defining supplies contracts aimed to rent supplies.</para>
    ///   <para>Clase de los contratos de suministros cuyo objeto es el alquiler de bienes.</para>
    /// labels<para>Contrato de alquiler</para><para>Rent contract</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#RentContract">http://contsem.unizar.es/def/sector-publico/pproc#RentContract</seealso>
    let RentContract = Prefixed_Name(pproc, "RentContract") |> PrefixedName
    /// <summary>
    ///   <para>pproc:Negotiated</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Abstract concept defining the procedure of the contract as negotiated.</para>
    /// labels<para>Negotiated</para><para>Negociado</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#Negotiated">http://contsem.unizar.es/def/sector-publico/pproc#Negotiated</seealso>
    let Negotiated = Prefixed_Name(pproc, "Negotiated") |> PrefixedName
    /// <summary>
    ///   <para>pproc:procedureWaive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Renuncia del procedimiento</para><para>Procedure waive</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#procedureWaive">http://contsem.unizar.es/def/sector-publico/pproc#procedureWaive</seealso>
    let procedureWaive = Prefixed_Name(pproc, "procedureWaive") |> PrefixedName

    /// <summary>
    ///   <para>pproc:provisionalFinancialGuarantee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Provisional financial guarantee</para><para>Garantía provisional</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#provisionalFinancialGuarantee">http://contsem.unizar.es/def/sector-publico/pproc#provisionalFinancialGuarantee</seealso>
    let provisionalFinancialGuarantee =
        Prefixed_Name(pproc, "provisionalFinancialGuarantee") |> PrefixedName

    /// <summary>
    ///   <para>pproc:BuyContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class to describe the supplies contracts aimed to buy supplies.</para>
    ///   <para>Clase de los contratos de suministros cuyo objeto es la compra de bienes.</para>
    /// labels<para>Contrato de compra</para><para>Buy contract</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#BuyContract">http://contsem.unizar.es/def/sector-publico/pproc#BuyContract</seealso>
    let BuyContract = Prefixed_Name(pproc, "BuyContract") |> PrefixedName
    /// <summary>
    ///   <para>pproc:AgreementContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Contrato de los conciertos con persona natural o jurídica que venga realizando prestaciones análogas a las que constituyen el servicio público de que se trate.</para>
    ///   <para>Class describing the contract concerts with natural or legal person performing similar services at the public service in question.</para>
    /// labels<para>Agreement contract</para><para>Concierto</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#AgreementContract">http://contsem.unizar.es/def/sector-publico/pproc#AgreementContract</seealso>
    let AgreementContract = Prefixed_Name(pproc, "AgreementContract") |> PrefixedName
    /// <summary>
    ///   <para>pproc:LeaseContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class defining supplies contracts aimed to lease supplies.</para>
    ///   <para>Clase de los contratos de suministros cuyo objeto es el arrendamiento financiero de bienes.
    ///
    /// Popularmente conocido como 'renting' en España.</para>
    /// labels<para>Arrendamiento financiero</para><para>Lease contract</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#LeaseContract">http://contsem.unizar.es/def/sector-publico/pproc#LeaseContract</seealso>
    let LeaseContract = Prefixed_Name(pproc, "LeaseContract") |> PrefixedName
    /// <summary>
    ///   <para>pproc:ConcessionContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Clase de los contratos en los que el empresario gestionará el servicio a su propio riesgo y ventura.</para>
    ///   <para>Class of the contracts in which the awarded tenderer manage the public service themselves.</para>
    /// labels<para>Concession contract</para><para>Concesión</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#ConcessionContract">http://contsem.unizar.es/def/sector-publico/pproc#ConcessionContract</seealso>
    let ConcessionContract = Prefixed_Name(pproc, "ConcessionContract") |> PrefixedName

    /// <summary>
    ///   <para>pproc:SharedResultAgreementContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class describing contracts whose operation results are shared among the contracting authority and the tenderer.</para>
    ///   <para>Clase de los contrato en cuya virtud la Administración y el empresario participarán en los resultados de la explotación del servicio en la proporción que se establezca en el contrato.</para>
    /// labels<para>Shared result agreement contract</para><para>Gestión interesada</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#SharedResultAgreementContract">http://contsem.unizar.es/def/sector-publico/pproc#SharedResultAgreementContract</seealso>
    let SharedResultAgreementContract =
        Prefixed_Name(pproc, "SharedResultAgreementContract") |> PrefixedName

    /// <summary>
    ///   <para>pproc:MixedCapitalCompanyContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Los contrato de sociedad de economia mixta son aquellos en que la Administración participe, por sí o por medio de una entidad pública, en concurrencia con personas naturales o jurídicas.</para>
    ///   <para>Class describing the contracts where the contracting authority participates concurrently with the natural or legal person.</para>
    /// labels<para>Contrato de sociedad de economia mixta</para><para>Mixed capital company contract</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#MixedCapitalCompanyContract">http://contsem.unizar.es/def/sector-publico/pproc#MixedCapitalCompanyContract</seealso>
    let MixedCapitalCompanyContract =
        Prefixed_Name(pproc, "MixedCapitalCompanyContract") |> PrefixedName

    /// <summary>
    ///   <para>pproc:AcceptedTender</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class describing the tenders accepted in the procurement public contract.</para>
    ///   <para>Clase para definir las ofertas que se han admitido a licitación.</para>
    /// labels<para>Oferta admitida</para><para>Accepted tender</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#AcceptedTender">http://contsem.unizar.es/def/sector-publico/pproc#AcceptedTender</seealso>
    let AcceptedTender = Prefixed_Name(pproc, "AcceptedTender") |> PrefixedName
    /// <summary>
    ///   <para>pproc:ExcludedTender</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class that defines the tenders excluded from the procurement procedure.</para>
    ///   <para>Define las ofertas que han sido excluídas del proceso de licitación.</para>
    /// labels<para>Excluded tender</para><para>Oferta excluída</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#ExcludedTender">http://contsem.unizar.es/def/sector-publico/pproc#ExcludedTender</seealso>
    let ExcludedTender = Prefixed_Name(pproc, "ExcludedTender") |> PrefixedName
    /// <summary>
    ///   <para>pproc:variantDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Campo para incluir la descripción, alcance, plazo u otros aspectos que están permitidos al presentar variantes en un contrato.</para>
    ///   <para>Property to describe the allowed variantes when submitting a variant of a contract.</para>
    /// labels<para>Descripción de las variantes</para><para>Variant description</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#variantDescription">http://contsem.unizar.es/def/sector-publico/pproc#variantDescription</seealso>
    let variantDescription = Prefixed_Name(pproc, "variantDescription") |> PrefixedName

    /// <summary>
    ///   <para>pproc:AdministrativeInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Información administrativa</para><para>Administrative information</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#AdministrativeInformation">http://contsem.unizar.es/def/sector-publico/pproc#AdministrativeInformation</seealso>
    let AdministrativeInformation =
        Prefixed_Name(pproc, "AdministrativeInformation") |> PrefixedName

    /// <summary>
    ///   <para>pproc:Briefing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Reunión informativa sobre la licitación del contrato.</para>
    ///   <para>Informative meeting about the public procurement contract.</para>
    /// labels<para>Reunión informativa</para><para>Briefing</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#Briefing">http://contsem.unizar.es/def/sector-publico/pproc#Briefing</seealso>
    let Briefing = Prefixed_Name(pproc, "Briefing") |> PrefixedName
    /// <summary>
    ///   <para>pproc:CommitteeMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class that describes the member a committee.</para>
    ///   <para>Miembro perteneciente a un comité de contratación concreto.</para>
    /// labels<para>Miembro del comité</para><para>Committee member</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#CommitteeMember">http://contsem.unizar.es/def/sector-publico/pproc#CommitteeMember</seealso>
    let CommitteeMember = Prefixed_Name(pproc, "CommitteeMember") |> PrefixedName
    /// <summary>
    ///   <para>pproc:ConclusionContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Clase de los contratos que consisten en el establecimiento de un acuerdo marco o un sistema dinámico de contratación.</para>
    ///   <para>Class describing the contracts consisting in the conclusion of a framework agreement or a dynamic purchasing system.</para>
    /// labels<para>Contrato de establecimiento</para><para>Conclusion contract</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#ConclusionContract">http://contsem.unizar.es/def/sector-publico/pproc#ConclusionContract</seealso>
    let ConclusionContract = Prefixed_Name(pproc, "ConclusionContract") |> PrefixedName
    /// <summary>
    ///   <para>pproc:Contract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Contrato público</para><para>Public contract</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#Contract">http://contsem.unizar.es/def/sector-publico/pproc#Contract</seealso>
    let Contract = Prefixed_Name(pproc, "Contract") |> PrefixedName
    /// <summary>
    ///   <para>pproc:DerivativeContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Clase de los contratos derivados de un acuerdo marco o un sistema dinámico de contratación.</para>
    ///   <para>Class describing contracts derived from a framework agreement or a dynamic purchasing system.</para>
    /// labels<para>Derivative contract</para><para>Contrato derivado</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#DerivativeContract">http://contsem.unizar.es/def/sector-publico/pproc#DerivativeContract</seealso>
    let DerivativeContract = Prefixed_Name(pproc, "DerivativeContract") |> PrefixedName

    /// <summary>
    ///   <para>pproc:ContractAdditionalObligations</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class describing the additional obligations the contract needs (e.g. guarantees or advertisement costs)</para>
    ///   <para>Clase que define las obligaciones accesorias de un contrato (e.g. garantías ó gastos de publicidad).</para>
    /// labels<para>Obligaciones accesorias del contrato</para><para>Contract additional obligations</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#ContractAdditionalObligations">http://contsem.unizar.es/def/sector-publico/pproc#ContractAdditionalObligations</seealso>
    let ContractAdditionalObligations =
        Prefixed_Name(pproc, "ContractAdditionalObligations") |> PrefixedName

    /// <summary>
    ///   <para>pproc:contractTemporalConditions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Condiciones temporales del contrato</para><para>Contract temporal conditions</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#contractTemporalConditions">http://contsem.unizar.es/def/sector-publico/pproc#contractTemporalConditions</seealso>
    let contractTemporalConditions =
        Prefixed_Name(pproc, "contractTemporalConditions") |> PrefixedName

    /// <summary>
    ///   <para>pproc:contractingBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Órgano de contratación</para><para>Contracting body</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#contractingBody">http://contsem.unizar.es/def/sector-publico/pproc#contractingBody</seealso>
    let contractingBody = Prefixed_Name(pproc, "contractingBody") |> PrefixedName

    /// <summary>
    ///   <para>pproc:contractingBodyAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Acuerdo del órgano de contratación</para><para>Contracting body agreement</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#contractingBodyAgreement">http://contsem.unizar.es/def/sector-publico/pproc#contractingBodyAgreement</seealso>
    let contractingBodyAgreement =
        Prefixed_Name(pproc, "contractingBodyAgreement") |> PrefixedName

    /// <summary>
    ///   <para>pproc:Notice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Anuncio</para><para>Notice</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#Notice">http://contsem.unizar.es/def/sector-publico/pproc#Notice</seealso>
    let Notice = Prefixed_Name(pproc, "Notice") |> PrefixedName

    /// <summary>
    ///   <para>pproc:InformationKindScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Scheme that indicates the type of the information that can be provided.</para>
    /// labels<para>Esquema de tipos de información</para><para>Information kind scheme</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#InformationKindScheme">http://contsem.unizar.es/def/sector-publico/pproc#InformationKindScheme</seealso>
    let InformationKindScheme =
        Prefixed_Name(pproc, "InformationKindScheme") |> PrefixedName

    /// <summary>
    ///   <para>pproc:AwardedTender</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class describing the awarded tenders.</para>
    ///   <para>Clase para definir las oferta que han sido adjudicadas.</para>
    /// labels<para>Oferta adjudicada</para><para>Awarded tender</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#AwardedTender">http://contsem.unizar.es/def/sector-publico/pproc#AwardedTender</seealso>
    let AwardedTender = Prefixed_Name(pproc, "AwardedTender") |> PrefixedName

    /// <summary>
    ///   <para>pproc:TenderersRequirements</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Clase que define los requisitos exigidos a los licitadores (e.g. clasificación profesional ó solvencia económica).</para>
    ///   <para>Class defining the tenderers requirements (e.g. required classification or financial capability).</para>
    /// labels<para>Requisitos de los licitadores</para><para>Tenderers requirements</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#TenderersRequirements">http://contsem.unizar.es/def/sector-publico/pproc#TenderersRequirements</seealso>
    let TenderersRequirements =
        Prefixed_Name(pproc, "TenderersRequirements") |> PrefixedName

    /// <summary>
    ///   <para>pproc:actualDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Actual duration</para><para>Duración final</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#actualDuration">http://contsem.unizar.es/def/sector-publico/pproc#actualDuration</seealso>
    let actualDuration = Prefixed_Name(pproc, "actualDuration") |> PrefixedName

    /// <summary>
    ///   <para>pproc:additionalDocumentReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Additional document reference</para><para>Documentación adicional</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#additionalDocumentReference">http://contsem.unizar.es/def/sector-publico/pproc#additionalDocumentReference</seealso>
    let additionalDocumentReference =
        Prefixed_Name(pproc, "additionalDocumentReference") |> PrefixedName

    /// <summary>
    ///   <para>pproc:advertisementAmount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Gastos de publicidad</para><para>Advertisement amount</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#advertisementAmount">http://contsem.unizar.es/def/sector-publico/pproc#advertisementAmount</seealso>
    let advertisementAmount =
        Prefixed_Name(pproc, "advertisementAmount") |> PrefixedName

    /// <summary>
    ///   <para>pproc:awardAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indica el acuerdo del órgano de contratación donde se ha adjudicado el contrato a un licitador.</para>
    ///   <para>Points to the body agreement where a tender has been awarded.</para>
    /// labels<para>Acuerdo de adjudicación</para><para>Award agreement</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#awardAgreement">http://contsem.unizar.es/def/sector-publico/pproc#awardAgreement</seealso>
    let awardAgreement = Prefixed_Name(pproc, "awardAgreement") |> PrefixedName
    /// <summary>
    ///   <para>pproc:awardDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Fecha de adjudicación</para><para>Date of award</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#awardDate">http://contsem.unizar.es/def/sector-publico/pproc#awardDate</seealso>
    let awardDate = Prefixed_Name(pproc, "awardDate") |> PrefixedName
    /// <summary>
    ///   <para>pproc:briefing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Reunión informativa</para><para>Briefing</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#briefing">http://contsem.unizar.es/def/sector-publico/pproc#briefing</seealso>
    let briefing = Prefixed_Name(pproc, "briefing") |> PrefixedName
    /// <summary>
    ///   <para>pproc:budgetPrice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Presupuesto del contrato</para><para>Contract budget price</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#budgetPrice">http://contsem.unizar.es/def/sector-publico/pproc#budgetPrice</seealso>
    let budgetPrice = Prefixed_Name(pproc, "budgetPrice") |> PrefixedName
    /// <summary>
    ///   <para>pproc:committee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Committee</para><para>Comité</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#committee">http://contsem.unizar.es/def/sector-publico/pproc#committee</seealso>
    let committee = Prefixed_Name(pproc, "committee") |> PrefixedName

    /// <summary>
    ///   <para>pproc:complementaryContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates a contract with a complementary contract.</para>
    ///   <para>Relaciona un contrato con otro contrato complementario.</para>
    /// labels<para>Contrato complementario</para><para>Complementary contract</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#complementaryContract">http://contsem.unizar.es/def/sector-publico/pproc#complementaryContract</seealso>
    let complementaryContract =
        Prefixed_Name(pproc, "complementaryContract") |> PrefixedName

    /// <summary>
    ///   <para>pproc:constructionSubsidies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Descripción de las aportaciones públicas a la construcción.</para>
    ///   <para>Description of the public subsidies to construction works contracts.</para>
    /// labels<para>Construction subsidies</para><para>Aportaciones públicas</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#constructionSubsidies">http://contsem.unizar.es/def/sector-publico/pproc#constructionSubsidies</seealso>
    let constructionSubsidies =
        Prefixed_Name(pproc, "constructionSubsidies") |> PrefixedName

    /// <summary>
    ///   <para>pproc:contractActivites</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Trámites del contrato</para><para>Contract activities</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#contractActivites">http://contsem.unizar.es/def/sector-publico/pproc#contractActivites</seealso>
    let contractActivites = Prefixed_Name(pproc, "contractActivites") |> PrefixedName

    /// <summary>
    ///   <para>pproc:BundlePriceSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class used to describe the price a set of objets.
    ///
    /// Can be used to define the total price of an gr:Offering. Its value must be equal to the gr:UnitPriceSpecification multiplied by the number of items.</para>
    ///   <para>Clase que representa el precio de conjuntos de objetos o un paquete determinado.
    ///
    /// Se utiliza para especificar el precio de la clase gr:Offering cuando este precio se refiere al del conjunto de los objetos (y no a su precio unitario).</para>
    /// labels<para>Precio de paquete</para><para>Bundle price</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#BundlePriceSpecification">http://contsem.unizar.es/def/sector-publico/pproc#BundlePriceSpecification</seealso>
    let BundlePriceSpecification =
        Prefixed_Name(pproc, "BundlePriceSpecification") |> PrefixedName

    /// <summary>
    ///   <para>pproc:Committee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Abstract class describing a set of persons in committee and its roles.</para>
    ///   <para>Clase abstracta que representa un conjunto de personas en comité y sus roles dentro del esta agrupación.</para>
    /// labels<para>Comité de contratación</para><para>Tender committee</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#Committee">http://contsem.unizar.es/def/sector-publico/pproc#Committee</seealso>
    let Committee = Prefixed_Name(pproc, "Committee") |> PrefixedName
    /// <summary>
    ///   <para>pproc:frameworkAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Property that indicates the framework agreement in which the contract consists.
    ///
    /// This property is used when the actual contract consist in the declaration of a framework agreement or a dynamic purchasing system.</para>
    ///   <para>Señala al acuerdo marco o sistema dinámico de contratación en el cual consiste el contrato.
    ///
    /// Esta propiedad se utiliza cuando el actual contrato consista en la declaración de un acuerdo marco o un sistema dinámico de contratación.</para>
    /// labels<para>Acuerdo marco o sistema dinámico de contratación</para><para>Framework agreement</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#frameworkAgreement">http://contsem.unizar.es/def/sector-publico/pproc#frameworkAgreement</seealso>
    let frameworkAgreement = Prefixed_Name(pproc, "frameworkAgreement") |> PrefixedName
    /// <summary>
    ///   <para>pproc:ContractBodies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Clase que engloba los órganos relacionados con un contrato (e.g. mesa de contratación ó comité de expertos).</para>
    ///   <para>Class describing the bodies related to the contract.</para>
    /// labels<para>Órganos del contrato</para><para>Contract bodies</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#ContractBodies">http://contsem.unizar.es/def/sector-publico/pproc#ContractBodies</seealso>
    let ContractBodies = Prefixed_Name(pproc, "ContractBodies") |> PrefixedName

    /// <summary>
    ///   <para>pproc:ContractModification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>During the execution of a contract it could happen that the contract should be modified, to describe these kind of situations we use this class.</para>
    ///   <para>Durante un contrato se puede dar también la necesidad de modificarlo una vez iniciada su ejecución, para plasmar este tipo de casos se debe utilizar esta clase.</para>
    /// labels<para>Modificación del contrato</para><para>Contract modification</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#ContractModification">http://contsem.unizar.es/def/sector-publico/pproc#ContractModification</seealso>
    let ContractModification =
        Prefixed_Name(pproc, "ContractModification") |> PrefixedName

    /// <summary>
    ///   <para>pproc:criterionMaxAndMinScores</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Puntuación máxima y mínima del criterio</para><para>Criterion maximum and minimum score</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#criterionMaxAndMinScores">http://contsem.unizar.es/def/sector-publico/pproc#criterionMaxAndMinScores</seealso>
    let criterionMaxAndMinScores =
        Prefixed_Name(pproc, "criterionMaxAndMinScores") |> PrefixedName

    /// <summary>
    ///   <para>pproc:delegatingAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indica la entidad que delega la licitación de este contrato.</para>
    ///   <para>Points to the authority that is delegating the contract.</para>
    /// labels<para>Delegating authority</para><para>Entidad delegante</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#delegatingAuthority">http://contsem.unizar.es/def/sector-publico/pproc#delegatingAuthority</seealso>
    let delegatingAuthority =
        Prefixed_Name(pproc, "delegatingAuthority") |> PrefixedName

    /// <summary>
    ///   <para>pproc:electronicAuction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Subasta electrónica</para><para>Electronic auction</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#electronicAuction">http://contsem.unizar.es/def/sector-publico/pproc#electronicAuction</seealso>
    let electronicAuction = Prefixed_Name(pproc, "electronicAuction") |> PrefixedName
    /// <summary>
    ///   <para>pproc:endMode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Modo de finalización</para><para>End mode</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#endMode">http://contsem.unizar.es/def/sector-publico/pproc#endMode</seealso>
    let endMode = Prefixed_Name(pproc, "endMode") |> PrefixedName
    /// <summary>
    ///   <para>pproc:estimatedEndDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Fecha estimada de finalización</para><para>Estimated end date</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#estimatedEndDate">http://contsem.unizar.es/def/sector-publico/pproc#estimatedEndDate</seealso>
    let estimatedEndDate = Prefixed_Name(pproc, "estimatedEndDate") |> PrefixedName
    /// <summary>
    ///   <para>pproc:estimatedValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Estimated value of the contract</para><para>Valor estimado del contrato</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#estimatedValue">http://contsem.unizar.es/def/sector-publico/pproc#estimatedValue</seealso>
    let estimatedValue = Prefixed_Name(pproc, "estimatedValue") |> PrefixedName

    /// <summary>
    ///   <para>pproc:executionRequeriments</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Campo para definir las condiciones de ejecución del contrato si las hubiera (e.g. forma jurídica a adoptar por la agrupación de contratistas)</para>
    ///   <para>Property to define alternative execution requirements (e.g. legal form to be adopted by tenderers).</para>
    /// labels<para>Condiciones de ejecución</para><para>Execution requeriments</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#executionRequeriments">http://contsem.unizar.es/def/sector-publico/pproc#executionRequeriments</seealso>
    let executionRequeriments =
        Prefixed_Name(pproc, "executionRequeriments") |> PrefixedName

    /// <summary>
    ///   <para>pproc:extinctionCause</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Causa de extinctión</para><para>Extinction cause</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#extinctionCause">http://contsem.unizar.es/def/sector-publico/pproc#extinctionCause</seealso>
    let extinctionCause = Prefixed_Name(pproc, "extinctionCause") |> PrefixedName
    /// <summary>
    ///   <para>pproc:feePrice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Canon</para><para>Fee</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#feePrice">http://contsem.unizar.es/def/sector-publico/pproc#feePrice</seealso>
    let feePrice = Prefixed_Name(pproc, "feePrice") |> PrefixedName

    /// <summary>
    ///   <para>pproc:finalFinancialGuaranteeDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Final financial guarantee duration</para><para>Plazo de la garantía definitiva</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#finalFinancialGuaranteeDuration">http://contsem.unizar.es/def/sector-publico/pproc#finalFinancialGuaranteeDuration</seealso>
    let finalFinancialGuaranteeDuration =
        Prefixed_Name(pproc, "finalFinancialGuaranteeDuration") |> PrefixedName

    /// <summary>
    ///   <para>pproc:fullMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Miembro titular en una mesa de contratación.</para>
    ///   <para>Points to a full member of a committee.</para>
    /// labels<para>Miembro titular</para><para>Full member</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#fullMember">http://contsem.unizar.es/def/sector-publico/pproc#fullMember</seealso>
    let fullMember = Prefixed_Name(pproc, "fullMember") |> PrefixedName
    /// <summary>
    ///   <para>pproc:informationKind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indica el tipo de información que suministra un proveedor de información.
    ///
    /// Es posible utilizar esta propiedad numerosas veces para indicar diversos tipos de información.</para>
    ///   <para>Property pointing to the type of the information is provided.</para>
    /// labels<para>Tipo de información</para><para>Information kind</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#informationKind">http://contsem.unizar.es/def/sector-publico/pproc#informationKind</seealso>
    let informationKind = Prefixed_Name(pproc, "informationKind") |> PrefixedName
    /// <summary>
    ///   <para>pproc:duration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Duration</para><para>Duración</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#duration">http://contsem.unizar.es/def/sector-publico/pproc#duration</seealso>
    let duration = Prefixed_Name(pproc, "duration") |> PrefixedName
    /// <summary>
    ///   <para>pproc:documentReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Enlace a documentación.
    ///
    /// Propiedad similar a pc:attachment, pero sin dominio fijo, pues esta misma propiedad puede utilizarse con múltiples clases (e.g. pc:Contract ó contsem:TenderMeeting)</para>
    ///   <para>Links to external documents.</para>
    /// labels<para>Document reference</para><para>Documentación</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#documentReference">http://contsem.unizar.es/def/sector-publico/pproc#documentReference</seealso>
    let documentReference = Prefixed_Name(pproc, "documentReference") |> PrefixedName

    /// <summary>
    ///   <para>pproc:assumptionProtectingProcedureType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Supuesto que ampara el uso del procedimiento elegido</para><para>Assumption protecting the chosen procedure type</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#assumptionProtectingProcedureType">http://contsem.unizar.es/def/sector-publico/pproc#assumptionProtectingProcedureType</seealso>
    let assumptionProtectingProcedureType =
        Prefixed_Name(pproc, "assumptionProtectingProcedureType") |> PrefixedName

    /// <summary>
    ///   <para>pproc:additionalObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property that points to the concept of the CPV code of an object.
    ///
    /// The concept used should be a valid representation of a CPV code, as it is in http://cpv.data.ac.uk/.</para>
    ///   <para>Representación CPV del objeto de un contrato.
    ///
    /// Debe apuntar a un concepto de objeto siguiendo la clasificación CPV de algún esquema de conceptos SKOS, como http://cpv.data.ac.uk/.</para>
    /// labels<para>Additional object of contract</para><para>Objeto adicional del contrato</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#additionalObject">http://contsem.unizar.es/def/sector-publico/pproc#additionalObject</seealso>
    let additionalObject = Prefixed_Name(pproc, "additionalObject") |> PrefixedName
    /// <summary>
    ///   <para>pproc:alternateMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Points to an alternate member of a committee.</para>
    ///   <para>Miembro suplente en una mesa de contratación.</para>
    /// labels<para>Alternate member</para><para>Miembro suplente</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#alternateMember">http://contsem.unizar.es/def/sector-publico/pproc#alternateMember</seealso>
    let alternateMember = Prefixed_Name(pproc, "alternateMember") |> PrefixedName
    /// <summary>
    ///   <para>pproc:price</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Precio</para><para>Price</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#price">http://contsem.unizar.es/def/sector-publico/pproc#price</seealso>
    let price = Prefixed_Name(pproc, "price") |> PrefixedName

    /// <summary>
    ///   <para>pproc:compulsoryMeansForExecution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Compulsory means for execution</para><para>Adscripción de medios</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#compulsoryMeansForExecution">http://contsem.unizar.es/def/sector-publico/pproc#compulsoryMeansForExecution</seealso>
    let compulsoryMeansForExecution =
        Prefixed_Name(pproc, "compulsoryMeansForExecution") |> PrefixedName

    /// <summary>
    ///   <para>pproc:contractAdditionalObligations</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Obligaciones accesorias del contrato</para><para>Contract additional obligations</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#contractAdditionalObligations">http://contsem.unizar.es/def/sector-publico/pproc#contractAdditionalObligations</seealso>
    let contractAdditionalObligations =
        Prefixed_Name(pproc, "contractAdditionalObligations") |> PrefixedName

    /// <summary>
    ///   <para>pproc:contractEconomicConditions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Condiciones económicas del contrato</para><para>Contract economic conditions</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#contractEconomicConditions">http://contsem.unizar.es/def/sector-publico/pproc#contractEconomicConditions</seealso>
    let contractEconomicConditions =
        Prefixed_Name(pproc, "contractEconomicConditions") |> PrefixedName

    /// <summary>
    ///   <para>pproc:contractExecutionConditions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Condiciones de ejecución del contrato</para><para>Contract execution conditions</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#contractExecutionConditions">http://contsem.unizar.es/def/sector-publico/pproc#contractExecutionConditions</seealso>
    let contractExecutionConditions =
        Prefixed_Name(pproc, "contractExecutionConditions") |> PrefixedName

    /// <summary>
    ///   <para>pproc:contractModificationConditions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Condiciones para la modificación del contrato</para><para>Contract modification conditions</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#contractModificationConditions">http://contsem.unizar.es/def/sector-publico/pproc#contractModificationConditions</seealso>
    let contractModificationConditions =
        Prefixed_Name(pproc, "contractModificationConditions") |> PrefixedName

    /// <summary>
    ///   <para>pproc:contractOrProcedureExtinction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Abstract property pointing to extinction of contract or procedure. Use any of its subclasses.</para>
    ///   <para>Propiedad abstracta que indica la extinción de un contrato por resolución, renuncia o abandono. O bien la extinción del procedimiento al ser declarado desierto.
    ///
    /// Utilizar una de sus subclases.</para>
    /// labels<para>Extinción de contrato o de procedimiento</para><para>Contract or procedure extinction</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#contractOrProcedureExtinction">http://contsem.unizar.es/def/sector-publico/pproc#contractOrProcedureExtinction</seealso>
    let contractOrProcedureExtinction =
        Prefixed_Name(pproc, "contractOrProcedureExtinction") |> PrefixedName

    /// <summary>
    ///   <para>pproc:contractProcedureSpecifications</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Especificaciones del procedimiento del contrato</para><para>Contract procedure specifications</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#contractProcedureSpecifications">http://contsem.unizar.es/def/sector-publico/pproc#contractProcedureSpecifications</seealso>
    let contractProcedureSpecifications =
        Prefixed_Name(pproc, "contractProcedureSpecifications") |> PrefixedName

    /// <summary>
    ///   <para>pproc:contractBodies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Órganos del contrato</para><para>Contract bodies</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#contractBodies">http://contsem.unizar.es/def/sector-publico/pproc#contractBodies</seealso>
    let contractBodies = Prefixed_Name(pproc, "contractBodies") |> PrefixedName

    /// <summary>
    ///   <para>pproc:contractModification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Points to contract modifications being made.</para>
    ///   <para>Indica la modificación efectuada en un contrato.</para>
    /// labels<para>Modificación de contrato</para><para>Contract modification</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#contractModification">http://contsem.unizar.es/def/sector-publico/pproc#contractModification</seealso>
    let contractModification =
        Prefixed_Name(pproc, "contractModification") |> PrefixedName

    /// <summary>
    ///   <para>pproc:contractObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Object of the contract</para><para>Objeto del contrato</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#contractObject">http://contsem.unizar.es/def/sector-publico/pproc#contractObject</seealso>
    let contractObject = Prefixed_Name(pproc, "contractObject") |> PrefixedName
    /// <summary>
    ///   <para>pproc:contractResolution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Resolución de contrato</para><para>Contract resolution</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#contractResolution">http://contsem.unizar.es/def/sector-publico/pproc#contractResolution</seealso>
    let contractResolution = Prefixed_Name(pproc, "contractResolution") |> PrefixedName
    /// <summary>
    ///   <para>pproc:FrameworkAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Clase a utilizar cuando estemos ante un contrato que consiste en la declaración, tanto de un acuerdo marco como de un sistema dinámico de contratación.</para>
    ///   <para>Class used to describe a contract that is a declaration of a framework agreement or a dynamic purchasing system.</para>
    /// labels<para>Framework agreement or dynamic purchasing system</para><para>Acuerdo marco o Sistema Dinámico de contratación</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#FrameworkAgreement">http://contsem.unizar.es/def/sector-publico/pproc#FrameworkAgreement</seealso>
    let FrameworkAgreement = Prefixed_Name(pproc, "FrameworkAgreement") |> PrefixedName
    /// <summary>
    ///   <para>pproc:ContractActivities</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Clase que engloba todos los trámites de un contrato (e.g. reuniones ó acuerdos del órgano de contratación).</para>
    ///   <para>Class describing all activities of a contract (e.g. meetings or agreements of the contracting body).</para>
    /// labels<para>Trámites del contrato</para><para>Contract activites</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#ContractActivities">http://contsem.unizar.es/def/sector-publico/pproc#ContractActivities</seealso>
    let ContractActivities = Prefixed_Name(pproc, "ContractActivities") |> PrefixedName

    /// <summary>
    ///   <para>pproc:ContractExecutionConditions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class that defines the execution conditions of the contract (e.g. special execution conditions or subcontracting percentage amounts).</para>
    ///   <para>Clase que define las condiciones de ejecución de un contrato (e.g. condiciones especiales ó subcontratación).</para>
    /// labels<para>Condiciones de ejecución del contrato</para><para>Contract execution conditions</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#ContractExecutionConditions">http://contsem.unizar.es/def/sector-publico/pproc#ContractExecutionConditions</seealso>
    let ContractExecutionConditions =
        Prefixed_Name(pproc, "ContractExecutionConditions") |> PrefixedName

    /// <summary>
    ///   <para>pproc:criterion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Criterion</para><para>Criterio</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#criterion">http://contsem.unizar.es/def/sector-publico/pproc#criterion</seealso>
    let criterion = Prefixed_Name(pproc, "criterion") |> PrefixedName

    /// <summary>
    ///   <para>pproc:criterionEvaluationMode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Propiedad para describir la forma de valoración del criterio.</para>
    ///   <para>Property textually describing the criterion evaluarion mode.</para>
    /// labels<para>Forma de evaluación del criterio</para><para>Criterion evaluation mode</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#criterionEvaluationMode">http://contsem.unizar.es/def/sector-publico/pproc#criterionEvaluationMode</seealso>
    let criterionEvaluationMode =
        Prefixed_Name(pproc, "criterionEvaluationMode") |> PrefixedName

    /// <summary>
    ///   <para>pproc:criterionScore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property that points to an unique criterion and its score.</para>
    ///   <para>Especifica la valoración de un único criterio, por lo que se utilizará una vez por cada criterio de adjudicación presente en el contrato.</para>
    /// labels<para>Valoración de criterio</para><para>Criterion score</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#criterionScore">http://contsem.unizar.es/def/sector-publico/pproc#criterionScore</seealso>
    let criterionScore = Prefixed_Name(pproc, "criterionScore") |> PrefixedName
    /// <summary>
    ///   <para>pproc:durationChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Variación del plazo</para><para>Duration change</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#durationChange">http://contsem.unizar.es/def/sector-publico/pproc#durationChange</seealso>
    let durationChange = Prefixed_Name(pproc, "durationChange") |> PrefixedName
    /// <summary>
    ///   <para>pproc:earlyTramitation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Tramitación anticipada</para><para>Early tramitation</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#earlyTramitation">http://contsem.unizar.es/def/sector-publico/pproc#earlyTramitation</seealso>
    let earlyTramitation = Prefixed_Name(pproc, "earlyTramitation") |> PrefixedName

    /// <summary>
    ///   <para>pproc:electronicAuctionPhase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Fase de subasta electrónica</para><para>Electronic auction phase</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#electronicAuctionPhase">http://contsem.unizar.es/def/sector-publico/pproc#electronicAuctionPhase</seealso>
    let electronicAuctionPhase =
        Prefixed_Name(pproc, "electronicAuctionPhase") |> PrefixedName

    /// <summary>
    ///   <para>pproc:electronicAuctionWeb</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Apunta a la web donde puede se realiza la subasta electrónica, o en su defecto, donde se pueda encontrar más información acerca de la subasta electrónica.</para>
    ///   <para>Property that indicated where the electronic auction is made or where we can look for more information about the auction.</para>
    /// labels<para>Web de la subasta electrónica</para><para>Electronic auction web</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#electronicAuctionWeb">http://contsem.unizar.es/def/sector-publico/pproc#electronicAuctionWeb</seealso>
    let electronicAuctionWeb =
        Prefixed_Name(pproc, "electronicAuctionWeb") |> PrefixedName

    /// <summary>
    ///   <para>pproc:ContractEconomicConditions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Clase que define las condiciones económicas del contrato (e.g. presupuesto ó revisión de precios).</para>
    ///   <para>Class defining the actual economic conditions of the contract (e.g. budget or the formula that describes the revision of its price).</para>
    /// labels<para>Condiciones económicas del contrato</para><para>Contract economic conditions</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#ContractEconomicConditions">http://contsem.unizar.es/def/sector-publico/pproc#ContractEconomicConditions</seealso>
    let ContractEconomicConditions =
        Prefixed_Name(pproc, "ContractEconomicConditions") |> PrefixedName

    /// <summary>
    ///   <para>pproc:ContractModificationConditions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Clase que define las condiciones para la modificación de un contrato (e.g. porcentaje máximo de modificación del presupuesto).</para>
    ///   <para>Class describing the conditions for which a contract can be modified (e.g. maximum percentage of its price or budget).</para>
    /// labels<para>Condiciones para la modificación del contrato</para><para>Contract modification conditions</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#ContractModificationConditions">http://contsem.unizar.es/def/sector-publico/pproc#ContractModificationConditions</seealso>
    let ContractModificationConditions =
        Prefixed_Name(pproc, "ContractModificationConditions") |> PrefixedName

    /// <summary>
    ///   <para>pproc:ContractObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Clase que define el objeto del contrato y las diferentes condiciones, obligaciones y modificaciones de este.</para>
    ///   <para>Class that defines the object of the contract and the conditions or modifications the contract can have.</para>
    /// labels<para>Objeto del contato</para><para>Contract object</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#ContractObject">http://contsem.unizar.es/def/sector-publico/pproc#ContractObject</seealso>
    let ContractObject = Prefixed_Name(pproc, "ContractObject") |> PrefixedName

    /// <summary>
    ///   <para>pproc:ContractOrProcedureExtinction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Abstract class. There are some circumstances resulting in the extinction of the procedure of the contract or the contract itself. To describe that situations we may use one of its subclasses.</para>
    ///   <para>Clase abstracta. Existe una serie de circunstancias que derivan en la extinctión del contrato o procedimiento. Para describir estas situaciones se hace uso de una de sus subclases.</para>
    /// labels<para>Extinción del contrato o del procedimiento</para><para>Contract or procedure extinction</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#ContractOrProcedureExtinction">http://contsem.unizar.es/def/sector-publico/pproc#ContractOrProcedureExtinction</seealso>
    let ContractOrProcedureExtinction =
        Prefixed_Name(pproc, "ContractOrProcedureExtinction") |> PrefixedName

    /// <summary>
    ///   <para>pproc:ContractResolution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Resolución del contrato</para><para>Contract resolution</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#ContractResolution">http://contsem.unizar.es/def/sector-publico/pproc#ContractResolution</seealso>
    let ContractResolution = Prefixed_Name(pproc, "ContractResolution") |> PrefixedName
    /// <summary>
    ///   <para>pproc:lot</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Lote</para><para>Lot</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#lot">http://contsem.unizar.es/def/sector-publico/pproc#lot</seealso>
    let lot = Prefixed_Name(pproc, "lot") |> PrefixedName
    /// <summary>
    ///   <para>pproc:numberOfLots</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Número de lotes</para><para>Number of lots</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#numberOfLots">http://contsem.unizar.es/def/sector-publico/pproc#numberOfLots</seealso>
    let numberOfLots = Prefixed_Name(pproc, "numberOfLots") |> PrefixedName

    /// <summary>
    ///   <para>pproc:ContractingBodyAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Acuerdo del órgano de contratación</para><para>Contracting body agreement</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#ContractingBodyAgreement">http://contsem.unizar.es/def/sector-publico/pproc#ContractingBodyAgreement</seealso>
    let ContractingBodyAgreement =
        Prefixed_Name(pproc, "ContractingBodyAgreement") |> PrefixedName

    /// <summary>
    ///   <para>pproc:CriterionScore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class to describe an award criterion and its score.</para>
    ///   <para>Clase para valorar individualmente un criterio de adjudicación. Esta formada por una puntuación (contsem:score) y un criterio (contsem:criterion).</para>
    /// labels<para>Valoración de criterio</para><para>Criterion score</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#CriterionScore">http://contsem.unizar.es/def/sector-publico/pproc#CriterionScore</seealso>
    let CriterionScore = Prefixed_Name(pproc, "CriterionScore") |> PrefixedName

    /// <summary>
    ///   <para>pproc:DynamicPurchasingSystemConclusionContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class describing the contracts consisting in the conclusion of a dynamic purchasing system.</para>
    ///   <para>Clase de los contratos que consisten en el establecimiento de un sistema dinámico de contratación.</para>
    /// labels<para>Contrato de establecimiento de un sistema dinámico de contratación</para><para>Dynamic purchasing system conclusion contract</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#DynamicPurchasingSystemConclusionContract">http://contsem.unizar.es/def/sector-publico/pproc#DynamicPurchasingSystemConclusionContract</seealso>
    let DynamicPurchasingSystemConclusionContract =
        Prefixed_Name(pproc, "DynamicPurchasingSystemConclusionContract") |> PrefixedName

    /// <summary>
    ///   <para>pproc:ElectronicAuctionPhase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Fase de la subasta electrónica de uno o más de los criterios de adjudicación del contrato.</para>
    ///   <para>Class describing a phase of an electronic auction.</para>
    /// labels<para>Fase de subasta electrónica</para><para>Electronic auction phase</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#ElectronicAuctionPhase">http://contsem.unizar.es/def/sector-publico/pproc#ElectronicAuctionPhase</seealso>
    let ElectronicAuctionPhase =
        Prefixed_Name(pproc, "ElectronicAuctionPhase") |> PrefixedName

    /// <summary>
    ///   <para>pproc:Emergency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Emergencia</para><para>Emergency</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#Emergency">http://contsem.unizar.es/def/sector-publico/pproc#Emergency</seealso>
    let Emergency = Prefixed_Name(pproc, "Emergency") |> PrefixedName
    /// <summary>
    ///   <para>pproc:ExpertCommittee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Comité de expertos</para><para>Expert committee</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#ExpertCommittee">http://contsem.unizar.es/def/sector-publico/pproc#ExpertCommittee</seealso>
    let ExpertCommittee = Prefixed_Name(pproc, "ExpertCommittee") |> PrefixedName
    /// <summary>
    ///   <para>pproc:Express</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Express</para><para>Urgente</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#Express">http://contsem.unizar.es/def/sector-publico/pproc#Express</seealso>
    let Express = Prefixed_Name(pproc, "Express") |> PrefixedName
    /// <summary>
    ///   <para>pproc:FormalizedTender</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Clase para definir la oferta que se ha formalizado.</para>
    ///   <para>Class describing tenders being formalized.</para>
    /// labels<para>Oferta formalizada</para><para>Formalized tender</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#FormalizedTender">http://contsem.unizar.es/def/sector-publico/pproc#FormalizedTender</seealso>
    let FormalizedTender = Prefixed_Name(pproc, "FormalizedTender") |> PrefixedName
    /// <summary>
    ///   <para>pproc:formalizedDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Fecha de formalización</para><para>Formalized date</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#formalizedDate">http://contsem.unizar.es/def/sector-publico/pproc#formalizedDate</seealso>
    let formalizedDate = Prefixed_Name(pproc, "formalizedDate") |> PrefixedName

    /// <summary>
    ///   <para>pproc:FrameworkDerivativeContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Clase de los contratos derivados de un acuerdo marco</para>
    ///   <para>Class describing contracts derived from a framework agreement.</para>
    /// labels<para>Contrato derivado de un acuerdo marco</para><para>Framework derivative contract</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#FrameworkDerivativeContract">http://contsem.unizar.es/def/sector-publico/pproc#FrameworkDerivativeContract</seealso>
    let FrameworkDerivativeContract =
        Prefixed_Name(pproc, "FrameworkDerivativeContract") |> PrefixedName

    /// <summary>
    ///   <para>pproc:HarmonizedContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class to describe harmonized contracts (i.e. contracts that reachs the threshold to be treated as highlighted in the procurement Directives of the European Commision and European Council).</para>
    ///   <para>Clase de los contratos armonizados (i.e. contratos que alcanzan el umbral para actuar conforme a las Directivas del Parlamento Europeo y del Consejo en contratos públicos)</para>
    /// labels<para>Contrato armonizado</para><para>Harmonized contract</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#HarmonizedContract">http://contsem.unizar.es/def/sector-publico/pproc#HarmonizedContract</seealso>
    let HarmonizedContract = Prefixed_Name(pproc, "HarmonizedContract") |> PrefixedName

    /// <summary>
    ///   <para>pproc:InformationProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class defining the provider of information about the contract.</para>
    ///   <para>Proveedor de información sobre la licitación del contrato.</para>
    /// labels<para>Proveedor de información</para><para>Information provider</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#InformationProvider">http://contsem.unizar.es/def/sector-publico/pproc#InformationProvider</seealso>
    let InformationProvider =
        Prefixed_Name(pproc, "InformationProvider") |> PrefixedName

    /// <summary>
    ///   <para>pproc:Remedy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Recurso interpuesto sobre alguna de las resoluciones del proceso de licitación.</para>
    ///   <para>Remedy lodged concerning a resolution about the procurement procedure.</para>
    /// labels<para>Recurso</para><para>Remedy</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#Remedy">http://contsem.unizar.es/def/sector-publico/pproc#Remedy</seealso>
    let Remedy = Prefixed_Name(pproc, "Remedy") |> PrefixedName
    /// <summary>
    ///   <para>pproc:Minor</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Minor</para><para>Menor</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#Minor">http://contsem.unizar.es/def/sector-publico/pproc#Minor</seealso>
    let Minor = Prefixed_Name(pproc, "Minor") |> PrefixedName

    /// <summary>
    ///   <para>pproc:ProcedureTypeScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>Scheme defining the procedure to be followed in a tender.</para>
    /// labels<para>Esquema de tipos de procedimiento</para><para>Procedure type scheme</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#ProcedureTypeScheme">http://contsem.unizar.es/def/sector-publico/pproc#ProcedureTypeScheme</seealso>
    let ProcedureTypeScheme =
        Prefixed_Name(pproc, "ProcedureTypeScheme") |> PrefixedName

    /// <summary>
    ///   <para>pproc:NegotiatedWithoutPublicity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Negotiated without publicity</para><para>Negociado sin publicidad</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#NegotiatedWithoutPublicity">http://contsem.unizar.es/def/sector-publico/pproc#NegotiatedWithoutPublicity</seealso>
    let NegotiatedWithoutPublicity =
        Prefixed_Name(pproc, "NegotiatedWithoutPublicity") |> PrefixedName

    /// <summary>
    ///   <para>pproc:NegotiatedWithPublicity</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Negotiated with publicity</para><para>Negociado con publicidad</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#NegotiatedWithPublicity">http://contsem.unizar.es/def/sector-publico/pproc#NegotiatedWithPublicity</seealso>
    let NegotiatedWithPublicity =
        Prefixed_Name(pproc, "NegotiatedWithPublicity") |> PrefixedName

    /// <summary>
    ///   <para>pproc:ObjectiveAwardCriterion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class describing criterioa that depend on a value judgement.</para>
    ///   <para>Clase para definir criterios que dependen de un juicio de valor.</para>
    /// labels<para>Criterio de adjudicación objetivo</para><para>Objective award criterion</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#ObjectiveAwardCriterion">http://contsem.unizar.es/def/sector-publico/pproc#ObjectiveAwardCriterion</seealso>
    let ObjectiveAwardCriterion =
        Prefixed_Name(pproc, "ObjectiveAwardCriterion") |> PrefixedName

    /// <summary>
    ///   <para>pproc:OrdinaryAdministrativeRemedy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Recurso administrativo ordinario</para><para>Ordinary administrative remedy</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#OrdinaryAdministrativeRemedy">http://contsem.unizar.es/def/sector-publico/pproc#OrdinaryAdministrativeRemedy</seealso>
    let OrdinaryAdministrativeRemedy =
        Prefixed_Name(pproc, "OrdinaryAdministrativeRemedy") |> PrefixedName

    /// <summary>
    ///   <para>pproc:ProcedureResignation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Desistimiento del procedimiento</para><para>Procedure resignation</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#ProcedureResignation">http://contsem.unizar.es/def/sector-publico/pproc#ProcedureResignation</seealso>
    let ProcedureResignation =
        Prefixed_Name(pproc, "ProcedureResignation") |> PrefixedName

    /// <summary>
    ///   <para>pproc:ProcedureVoid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Procedimiento desierto</para><para>Procedure void</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#ProcedureVoid">http://contsem.unizar.es/def/sector-publico/pproc#ProcedureVoid</seealso>
    let ProcedureVoid = Prefixed_Name(pproc, "ProcedureVoid") |> PrefixedName
    /// <summary>
    ///   <para>pproc:ProcedureWaive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Renuncia del procedimiento</para><para>Procedure waive</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#ProcedureWaive">http://contsem.unizar.es/def/sector-publico/pproc#ProcedureWaive</seealso>
    let ProcedureWaive = Prefixed_Name(pproc, "ProcedureWaive") |> PrefixedName
    /// <summary>
    ///   <para>pproc:Regular</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Ordinaria</para><para>Regular</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#Regular">http://contsem.unizar.es/def/sector-publico/pproc#Regular</seealso>
    let Regular = Prefixed_Name(pproc, "Regular") |> PrefixedName
    /// <summary>
    ///   <para>pproc:RegularOpen</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Abierto ordinario</para><para>Regular open</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#RegularOpen">http://contsem.unizar.es/def/sector-publico/pproc#RegularOpen</seealso>
    let RegularOpen = Prefixed_Name(pproc, "RegularOpen") |> PrefixedName
    /// <summary>
    ///   <para>pproc:SimpleOpen</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Abierto simple</para><para>Simple open</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#SimpleOpen">http://contsem.unizar.es/def/sector-publico/pproc#SimpleOpen</seealso>
    let SimpleOpen = Prefixed_Name(pproc, "SimpleOpen") |> PrefixedName

    /// <summary>
    ///   <para>pproc:SpecialAdministrativeRemedy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Recurso administrativo especial</para><para>Special administrative remedy</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#SpecialAdministrativeRemedy">http://contsem.unizar.es/def/sector-publico/pproc#SpecialAdministrativeRemedy</seealso>
    let SpecialAdministrativeRemedy =
        Prefixed_Name(pproc, "SpecialAdministrativeRemedy") |> PrefixedName

    /// <summary>
    ///   <para>pproc:SubjectiveAwardCriterion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Clase para especificar los criterios que dependen de una opinion subjetiva.</para>
    ///   <para>Class used to describe criteria that depend on a subjetive opinion.</para>
    /// labels<para>Criterio de adjudicación subjetivo</para><para>Subjective award criterion</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#SubjectiveAwardCriterion">http://contsem.unizar.es/def/sector-publico/pproc#SubjectiveAwardCriterion</seealso>
    let SubjectiveAwardCriterion =
        Prefixed_Name(pproc, "SubjectiveAwardCriterion") |> PrefixedName

    /// <summary>
    ///   <para>pproc:TechnicalCommittee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Technical committee</para><para>Organismo técnico</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#TechnicalCommittee">http://contsem.unizar.es/def/sector-publico/pproc#TechnicalCommittee</seealso>
    let TechnicalCommittee = Prefixed_Name(pproc, "TechnicalCommittee") |> PrefixedName

    /// <summary>
    ///   <para>pproc:TechnicalInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Technical information</para><para>Información técnica</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#TechnicalInformation">http://contsem.unizar.es/def/sector-publico/pproc#TechnicalInformation</seealso>
    let TechnicalInformation =
        Prefixed_Name(pproc, "TechnicalInformation") |> PrefixedName

    /// <summary>
    ///   <para>pproc:TenderCommittee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Mesa de contratación</para><para>Tender committee</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#TenderCommittee">http://contsem.unizar.es/def/sector-publico/pproc#TenderCommittee</seealso>
    let TenderCommittee = Prefixed_Name(pproc, "TenderCommittee") |> PrefixedName
    /// <summary>
    ///   <para>pproc:TenderMeeting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class describing the meetings of tender committee.</para>
    ///   <para>Clase para describir las reuniones que la mesa de contratación, comité de expertos u organismos técnicas han realizado.</para>
    /// labels<para>Reunión de la mesa de contratación</para><para>Tender meeting</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#TenderMeeting">http://contsem.unizar.es/def/sector-publico/pproc#TenderMeeting</seealso>
    let TenderMeeting = Prefixed_Name(pproc, "TenderMeeting") |> PrefixedName
    /// <summary>
    ///   <para>pproc:TenderRequirements</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Clase que define los requisitos exigidos a las ofertas a presentar (e.g. plazo o documentación a presentar).</para>
    ///   <para>Class to define the tender requirements needed to submit a tender (e.g. tender document needs).</para>
    /// labels<para>Requisitos para las ofertas</para><para>Tender requirements</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#TenderRequirements">http://contsem.unizar.es/def/sector-publico/pproc#TenderRequirements</seealso>
    let TenderRequirements = Prefixed_Name(pproc, "TenderRequirements") |> PrefixedName

    /// <summary>
    ///   <para>pproc:ContractTemporalConditions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Clase que define las condiciones temporales de un contrato (e.g. plazo ó prórrogas).</para>
    ///   <para>Class that describes the temporal conditions of the contract.</para>
    /// labels<para>Condiciones temporales del contrato</para><para>Contract temporal conditions</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#ContractTemporalConditions">http://contsem.unizar.es/def/sector-publico/pproc#ContractTemporalConditions</seealso>
    let ContractTemporalConditions =
        Prefixed_Name(pproc, "ContractTemporalConditions") |> PrefixedName

    /// <summary>
    ///   <para>pproc:finalFinancialGuarantee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>El rango en esta propiedad indica un porcentaje, por lo que el rango del número real a utilizar debe estar comprendido entre 0.0 y 100.0.</para>
    ///   <para>The range of this property must be a percentage (i.e. float between 0.0 and 100.0)</para>
    /// labels<para>Final financial guarantee</para><para>Garantía definitiva</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#finalFinancialGuarantee">http://contsem.unizar.es/def/sector-publico/pproc#finalFinancialGuarantee</seealso>
    let finalFinancialGuarantee =
        Prefixed_Name(pproc, "finalFinancialGuarantee") |> PrefixedName

    /// <summary>
    ///   <para>pproc:frameworkAgreementDerivativeContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Framework agreement derivative contract</para><para>Contrato derivado de un acuerdo marco</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#frameworkAgreementDerivativeContract">http://contsem.unizar.es/def/sector-publico/pproc#frameworkAgreementDerivativeContract</seealso>
    let frameworkAgreementDerivativeContract =
        Prefixed_Name(pproc, "frameworkAgreementDerivativeContract") |> PrefixedName

    /// <summary>
    ///   <para>pproc:isNegotiable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Es negociable</para><para>Is negotiable</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#isNegotiable">http://contsem.unizar.es/def/sector-publico/pproc#isNegotiable</seealso>
    let isNegotiable = Prefixed_Name(pproc, "isNegotiable") |> PrefixedName
    /// <summary>
    ///   <para>pproc:item</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property for attachment of an item to a tender.</para>
    /// labels<para>Artículo</para><para>Item</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#item">http://contsem.unizar.es/def/sector-publico/pproc#item</seealso>
    let item = Prefixed_Name(pproc, "item") |> PrefixedName

    /// <summary>
    ///   <para>pproc:legalDocumentReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Pliego de cláusulas administrativas</para><para>Legal document reference</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#legalDocumentReference">http://contsem.unizar.es/def/sector-publico/pproc#legalDocumentReference</seealso>
    let legalDocumentReference =
        Prefixed_Name(pproc, "legalDocumentReference") |> PrefixedName

    /// <summary>
    ///   <para>pproc:lodgedRemedyDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Fecha en la cual se ha interpuesto el recurso ante el órgano oficial.</para>
    ///   <para>Date where a remedy is lodged.</para>
    /// labels<para>Fecha de interposición del recurso</para><para>Lodged remedy date</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#lodgedRemedyDate">http://contsem.unizar.es/def/sector-publico/pproc#lodgedRemedyDate</seealso>
    let lodgedRemedyDate = Prefixed_Name(pproc, "lodgedRemedyDate") |> PrefixedName

    /// <summary>
    ///   <para>pproc:ContractProcedureSpecifications</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Clase que define las especificaciones del procedimiento de un contrato (e.g. tipo de procedimiento o de tramitación).</para>
    ///   <para>Class that specifies the procedure of a contract (e.g. type of procedure or its urgency).</para>
    /// labels<para>Procedimiento del contrato</para><para>Contract procedure</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#ContractProcedureSpecifications">http://contsem.unizar.es/def/sector-publico/pproc#ContractProcedureSpecifications</seealso>
    let ContractProcedureSpecifications =
        Prefixed_Name(pproc, "ContractProcedureSpecifications") |> PrefixedName

    /// <summary>
    ///   <para>pproc:expectedCauseModification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Causas previstas de modificación</para><para>Expected cause modification</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#expectedCauseModification">http://contsem.unizar.es/def/sector-publico/pproc#expectedCauseModification</seealso>
    let expectedCauseModification =
        Prefixed_Name(pproc, "expectedCauseModification") |> PrefixedName

    /// <summary>
    ///   <para>pproc:estimatedDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Estimated duration</para><para>Duración estimada</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#estimatedDuration">http://contsem.unizar.es/def/sector-publico/pproc#estimatedDuration</seealso>
    let estimatedDuration = Prefixed_Name(pproc, "estimatedDuration") |> PrefixedName
    /// <summary>
    ///   <para>pproc:location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Lugar de realización del contrato</para><para>Place of contract's realization</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#location">http://contsem.unizar.es/def/sector-publico/pproc#location</seealso>
    let location = Prefixed_Name(pproc, "location") |> PrefixedName
    /// <summary>
    ///   <para>pproc:mainObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property that points to the concept of the CPV code of an object.
    ///
    /// The concept used should be a valid representation of a CPV code, as it is in http://cpv.data.ac.uk/.</para>
    ///   <para>Representación CPV del objeto de un contrato.
    ///
    /// Debe apuntar a un concepto de objeto siguiendo la clasificación CPV de algún esquema de conceptos SKOS, como http://cpv.data.ac.uk/.</para>
    /// labels<para>Principal objeto del contrato</para><para>Main object of contract</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#mainObject">http://contsem.unizar.es/def/sector-publico/pproc#mainObject</seealso>
    let mainObject = Prefixed_Name(pproc, "mainObject") |> PrefixedName
    /// <summary>
    ///   <para>pproc:managingDepartment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Servicio perteneciente a la entidad contratante que se encarga de la publicación y administración de este contrato.</para>
    ///   <para>Property that indicates the managing departament responsible of the contract.</para>
    /// labels<para>Managing department</para><para>Servicio gestor</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#managingDepartment">http://contsem.unizar.es/def/sector-publico/pproc#managingDepartment</seealso>
    let managingDepartment = Prefixed_Name(pproc, "managingDepartment") |> PrefixedName
    /// <summary>
    ///   <para>pproc:maxBudgetChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>El rango en esta propiedad indica un porcentaje, por lo que el rango del número real a utilizar debe estar comprendido entre 0.0 y 100.0.</para>
    ///   <para>The range of this property must be a percentage (i.e. float between 0.0 and 100.0)</para>
    /// labels<para>Modificación máxima de presupuesto</para><para>Maximum budget change</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#maxBudgetChange">http://contsem.unizar.es/def/sector-publico/pproc#maxBudgetChange</seealso>
    let maxBudgetChange = Prefixed_Name(pproc, "maxBudgetChange") |> PrefixedName
    /// <summary>
    ///   <para>pproc:PrivateContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Private contract</para><para>Contrato privado</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#PrivateContract">http://contsem.unizar.es/def/sector-publico/pproc#PrivateContract</seealso>
    let PrivateContract = Prefixed_Name(pproc, "PrivateContract") |> PrefixedName
    /// <summary>
    ///   <para>pproc:ServicesContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Contrato de servicios</para><para>Services contract</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#ServicesContract">http://contsem.unizar.es/def/sector-publico/pproc#ServicesContract</seealso>
    let ServicesContract = Prefixed_Name(pproc, "ServicesContract") |> PrefixedName
    /// <summary>
    ///   <para>pproc:WorksContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Contrato de obras</para><para>Works contract</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#WorksContract">http://contsem.unizar.es/def/sector-publico/pproc#WorksContract</seealso>
    let WorksContract = Prefixed_Name(pproc, "WorksContract") |> PrefixedName

    /// <summary>
    ///   <para>pproc:AdditionalInformationNotice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Anuncio de información adicional</para><para>Additional information notice</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#AdditionalInformationNotice">http://contsem.unizar.es/def/sector-publico/pproc#AdditionalInformationNotice</seealso>
    let AdditionalInformationNotice =
        Prefixed_Name(pproc, "AdditionalInformationNotice") |> PrefixedName

    /// <summary>
    ///   <para>pproc:ContractNotice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Anuncio de licitación</para><para>Contract notice</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#ContractNotice">http://contsem.unizar.es/def/sector-publico/pproc#ContractNotice</seealso>
    let ContractNotice = Prefixed_Name(pproc, "ContractNotice") |> PrefixedName

    /// <summary>
    ///   <para>pproc:FormalizationNotice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Anuncio de formalización</para><para>Formalization notice</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#FormalizationNotice">http://contsem.unizar.es/def/sector-publico/pproc#FormalizationNotice</seealso>
    let FormalizationNotice =
        Prefixed_Name(pproc, "FormalizationNotice") |> PrefixedName

    /// <summary>
    ///   <para>pproc:ContractWithoutLots</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Clase de los contratos que no están dividos en lotes.</para>
    ///   <para>Class to describe the contract not divided into lots.</para>
    /// labels<para>Contract without lots</para><para>Contrato sin lotes</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#ContractWithoutLots">http://contsem.unizar.es/def/sector-publico/pproc#ContractWithoutLots</seealso>
    let ContractWithoutLots =
        Prefixed_Name(pproc, "ContractWithoutLots") |> PrefixedName

    /// <summary>
    ///   <para>pproc:ExtendableContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Contratos públicos cuya fecha de ejecución puede ser pospuesta o extendida.</para>
    ///   <para>Class describing contracts whose end date can be extended.</para>
    /// labels<para>Contrato prorrogable</para><para>Extendable contract</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#ExtendableContract">http://contsem.unizar.es/def/sector-publico/pproc#ExtendableContract</seealso>
    let ExtendableContract = Prefixed_Name(pproc, "ExtendableContract") |> PrefixedName

    /// <summary>
    ///   <para>pproc:FrameworkConclusionContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Clase de los contratos que consisten en el establecimiento de un acuerdo marco.</para>
    ///   <para>Class describing the contracts consisting in the conclusion of a framework agreement.</para>
    /// labels<para>Contrato de establecimiento de un acuerdo marco</para><para>Framework conclusion contract</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#FrameworkConclusionContract">http://contsem.unizar.es/def/sector-publico/pproc#FrameworkConclusionContract</seealso>
    let FrameworkConclusionContract =
        Prefixed_Name(pproc, "FrameworkConclusionContract") |> PrefixedName

    /// <summary>
    ///   <para>pproc:modificationReason</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Justificación de la modificación</para><para>Modification reason</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#modificationReason">http://contsem.unizar.es/def/sector-publico/pproc#modificationReason</seealso>
    let modificationReason = Prefixed_Name(pproc, "modificationReason") |> PrefixedName
    /// <summary>
    ///   <para>pproc:modificationScope</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Alcance de la modificación</para><para>Modification scope</para></remarks>
    /// <seealso href="http://contsem.unizar.es/def/sector-publico/pproc#modificationScope">http://contsem.unizar.es/def/sector-publico/pproc#modificationScope</seealso>
    let modificationScope = Prefixed_Name(pproc, "modificationScope") |> PrefixedName
