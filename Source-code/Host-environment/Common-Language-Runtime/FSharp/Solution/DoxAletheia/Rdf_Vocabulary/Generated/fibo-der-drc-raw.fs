namespace https.spec.edmcouncil.org.fibo.ontology.DER.DerivativesContracts.RightsAndWarrants.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_der_drc_raw =
    let _namespace_iri = Namespace_Iri fibo_der_drc_raw |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-der-drc-raw:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Rights and Warrants Ontology"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_der_drc_raw, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-raw:AllotmentRight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"allotment right"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/AllotmentRight">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/AllotmentRight</seealso>
    let AllotmentRight =
        Prefixed_Name(fibo_der_drc_raw, "AllotmentRight") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-raw:AllotmentRightFormula</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"allotment right formula"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/AllotmentRightFormula">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/AllotmentRightFormula</seealso>
    let AllotmentRightFormula =
        Prefixed_Name(fibo_der_drc_raw, "AllotmentRightFormula") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-raw:BarrierInstrumentBasedMiniFutureCertificate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"barrier instrument-based mini-future certificate"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/BarrierInstrumentBasedMiniFutureCertificate">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/BarrierInstrumentBasedMiniFutureCertificate</seealso>
    let BarrierInstrumentBasedMiniFutureCertificate =
        Prefixed_Name(fibo_der_drc_raw, "BarrierInstrumentBasedMiniFutureCertificate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-raw:BarrierUnderlyingMiniFutureCertificate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"barrier underlying mini-future certificate"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/BarrierUnderlyingMiniFutureCertificate">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/BarrierUnderlyingMiniFutureCertificate</seealso>
    let BarrierUnderlyingMiniFutureCertificate =
        Prefixed_Name(fibo_der_drc_raw, "BarrierUnderlyingMiniFutureCertificate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-raw:BasketWarrant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"basket warrant"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/BasketWarrant">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/BasketWarrant</seealso>
    let BasketWarrant = Prefixed_Name(fibo_der_drc_raw, "BasketWarrant") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-raw:BondPurchaseRight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"bond purchase right"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/BondPurchaseRight">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/BondPurchaseRight</seealso>
    let BondPurchaseRight =
        Prefixed_Name(fibo_der_drc_raw, "BondPurchaseRight") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-raw:BondSubscriptionRight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"bond subscription right"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/BondSubscriptionRight">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/BondSubscriptionRight</seealso>
    let BondSubscriptionRight =
        Prefixed_Name(fibo_der_drc_raw, "BondSubscriptionRight") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-raw:CallPutWarrant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"call put warrant"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/CallPutWarrant">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/CallPutWarrant</seealso>
    let CallPutWarrant =
        Prefixed_Name(fibo_der_drc_raw, "CallPutWarrant") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-raw:CallWarrant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"call warrant"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/CallWarrant">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/CallWarrant</seealso>
    let CallWarrant = Prefixed_Name(fibo_der_drc_raw, "CallWarrant") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-raw:CombinedInstrumentsPurchaseRight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"combined instruments purchase right"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/CombinedInstrumentsPurchaseRight">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/CombinedInstrumentsPurchaseRight</seealso>
    let CombinedInstrumentsPurchaseRight =
        Prefixed_Name(fibo_der_drc_raw, "CombinedInstrumentsPurchaseRight") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-raw:CombinedInstrumentsSubscriptionRight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"combined instruments subscription right"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/CombinedInstrumentsSubscriptionRight">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/CombinedInstrumentsSubscriptionRight</seealso>
    let CombinedInstrumentsSubscriptionRight =
        Prefixed_Name(fibo_der_drc_raw, "CombinedInstrumentsSubscriptionRight") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-raw:CommodityWarrant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"commodity warrant"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/CommodityWarrant">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/CommodityWarrant</seealso>
    let CommodityWarrant =
        Prefixed_Name(fibo_der_drc_raw, "CommodityWarrant") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-raw:CommonConvertibleSharePurchaseRight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"common convertible share purchase right"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/CommonConvertibleSharePurchaseRight">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/CommonConvertibleSharePurchaseRight</seealso>
    let CommonConvertibleSharePurchaseRight =
        Prefixed_Name(fibo_der_drc_raw, "CommonConvertibleSharePurchaseRight") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-raw:CommonConvertibleShareSubscriptionRight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"common convertible share subscription right"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/CommonConvertibleShareSubscriptionRight">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/CommonConvertibleShareSubscriptionRight</seealso>
    let CommonConvertibleShareSubscriptionRight =
        Prefixed_Name(fibo_der_drc_raw, "CommonConvertibleShareSubscriptionRight") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-raw:CommonSharePurchaseRight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"common share purchase right"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/CommonSharePurchaseRight">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/CommonSharePurchaseRight</seealso>
    let CommonSharePurchaseRight =
        Prefixed_Name(fibo_der_drc_raw, "CommonSharePurchaseRight") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-raw:CommonShareSubscriptionRight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"common share subscription right"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/CommonShareSubscriptionRight">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/CommonShareSubscriptionRight</seealso>
    let CommonShareSubscriptionRight =
        Prefixed_Name(fibo_der_drc_raw, "CommonShareSubscriptionRight") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-raw:CompanyWarrant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/CompanyWarrant">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/CompanyWarrant</seealso>
    let CompanyWarrant =
        Prefixed_Name(fibo_der_drc_raw, "CompanyWarrant") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-raw:ConstantLeverageCertificate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"constant leverage certificate"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/ConstantLeverageCertificate">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/ConstantLeverageCertificate</seealso>
    let ConstantLeverageCertificate =
        Prefixed_Name(fibo_der_drc_raw, "ConstantLeverageCertificate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-raw:CoveredWarrant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"covered warrant"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/CoveredWarrant">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/CoveredWarrant</seealso>
    let CoveredWarrant =
        Prefixed_Name(fibo_der_drc_raw, "CoveredWarrant") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-raw:CurrencyWarrant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"currency warrant"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/CurrencyWarrant">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/CurrencyWarrant</seealso>
    let CurrencyWarrant =
        Prefixed_Name(fibo_der_drc_raw, "CurrencyWarrant") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-raw:DebtWarrant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"debt warrant"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/DebtWarrant">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/DebtWarrant</seealso>
    let DebtWarrant = Prefixed_Name(fibo_der_drc_raw, "DebtWarrant") |> PrefixedName
    /// <summary>
    ///   <para>fibo-der-drc-raw:EquityWarrant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"equity warrant"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/EquityWarrant">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/EquityWarrant</seealso>
    let EquityWarrant = Prefixed_Name(fibo_der_drc_raw, "EquityWarrant") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-raw:ExchangeTradedWarrant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"exchange-traded warrant"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/ExchangeTradedWarrant">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/ExchangeTradedWarrant</seealso>
    let ExchangeTradedWarrant =
        Prefixed_Name(fibo_der_drc_raw, "ExchangeTradedWarrant") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-raw:ExoticWarrant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"exotic warrant"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/ExoticWarrant">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/ExoticWarrant</seealso>
    let ExoticWarrant = Prefixed_Name(fibo_der_drc_raw, "ExoticWarrant") |> PrefixedName
    /// <summary>
    ///   <para>fibo-der-drc-raw:IndexWarrant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"index warrant"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/IndexWarrant">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/IndexWarrant</seealso>
    let IndexWarrant = Prefixed_Name(fibo_der_drc_raw, "IndexWarrant") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-raw:LongMiniFutureCertificate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"long mini-future certificate"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/LongMiniFutureCertificate">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/LongMiniFutureCertificate</seealso>
    let LongMiniFutureCertificate =
        Prefixed_Name(fibo_der_drc_raw, "LongMiniFutureCertificate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-raw:MiniFutureCertificate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"mini-future certificate"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/MiniFutureCertificate">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/MiniFutureCertificate</seealso>
    let MiniFutureCertificate =
        Prefixed_Name(fibo_der_drc_raw, "MiniFutureCertificate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-raw:NakedWarrant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"naked warrant"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/NakedWarrant">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/NakedWarrant</seealso>
    let NakedWarrant = Prefixed_Name(fibo_der_drc_raw, "NakedWarrant") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-raw:PerpetualWarrant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"perpetual warrant"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/PerpetualWarrant">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/PerpetualWarrant</seealso>
    let PerpetualWarrant =
        Prefixed_Name(fibo_der_drc_raw, "PerpetualWarrant") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-raw:PreferredConvertibleSharePurchaseRight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"preferred convertible share purchase right"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/PreferredConvertibleSharePurchaseRight">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/PreferredConvertibleSharePurchaseRight</seealso>
    let PreferredConvertibleSharePurchaseRight =
        Prefixed_Name(fibo_der_drc_raw, "PreferredConvertibleSharePurchaseRight") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-raw:PreferredConvertibleShareSubscriptionRight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"preferred convertible share subscription right"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/PreferredConvertibleShareSubscriptionRight">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/PreferredConvertibleShareSubscriptionRight</seealso>
    let PreferredConvertibleShareSubscriptionRight =
        Prefixed_Name(fibo_der_drc_raw, "PreferredConvertibleShareSubscriptionRight") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-raw:PreferredSharePurchaseRight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"preferred share purchase right"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/PreferredSharePurchaseRight">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/PreferredSharePurchaseRight</seealso>
    let PreferredSharePurchaseRight =
        Prefixed_Name(fibo_der_drc_raw, "PreferredSharePurchaseRight") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-raw:PreferredShareSubscriptionRight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"preferred share subscription right"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/PreferredShareSubscriptionRight">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/PreferredShareSubscriptionRight</seealso>
    let PreferredShareSubscriptionRight =
        Prefixed_Name(fibo_der_drc_raw, "PreferredShareSubscriptionRight") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-raw:PrivateWarrant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"private warrant"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/PrivateWarrant">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/PrivateWarrant</seealso>
    let PrivateWarrant =
        Prefixed_Name(fibo_der_drc_raw, "PrivateWarrant") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-raw:PublicWarrant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"public warrant"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/PublicWarrant">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/PublicWarrant</seealso>
    let PublicWarrant = Prefixed_Name(fibo_der_drc_raw, "PublicWarrant") |> PrefixedName
    /// <summary>
    ///   <para>fibo-der-drc-raw:PurchaseRight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"purchase right"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/PurchaseRight">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/PurchaseRight</seealso>
    let PurchaseRight = Prefixed_Name(fibo_der_drc_raw, "PurchaseRight") |> PrefixedName
    /// <summary>
    ///   <para>fibo-der-drc-raw:PutWarrant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"put warrant"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/PutWarrant">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/PutWarrant</seealso>
    let PutWarrant = Prefixed_Name(fibo_der_drc_raw, "PutWarrant") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-raw:ShortMiniFutureCertificate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"short mini-future certificate"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/ShortMiniFutureCertificate">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/ShortMiniFutureCertificate</seealso>
    let ShortMiniFutureCertificate =
        Prefixed_Name(fibo_der_drc_raw, "ShortMiniFutureCertificate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-raw:StructuredWarrant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"structured warrant"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/StructuredWarrant">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/StructuredWarrant</seealso>
    let StructuredWarrant =
        Prefixed_Name(fibo_der_drc_raw, "StructuredWarrant") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-raw:SubscriptionRight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"subscription right"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/SubscriptionRight">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/SubscriptionRight</seealso>
    let SubscriptionRight =
        Prefixed_Name(fibo_der_drc_raw, "SubscriptionRight") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-raw:TraditionalWarrant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"traditional warrant"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/TraditionalWarrant">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/TraditionalWarrant</seealso>
    let TraditionalWarrant =
        Prefixed_Name(fibo_der_drc_raw, "TraditionalWarrant") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-raw:Warrant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"warrant"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/Warrant">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/Warrant</seealso>
    let Warrant = Prefixed_Name(fibo_der_drc_raw, "Warrant") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-raw:hasConversionRatio</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has conversion ratio"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/hasConversionRatio">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/hasConversionRatio</seealso>
    let hasConversionRatio =
        Prefixed_Name(fibo_der_drc_raw, "hasConversionRatio") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-raw:hasOversubscribeOption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has oversubscribe option"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/hasOversubscribeOption">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/hasOversubscribeOption</seealso>
    let hasOversubscribeOption =
        Prefixed_Name(fibo_der_drc_raw, "hasOversubscribeOption") |> PrefixedName
