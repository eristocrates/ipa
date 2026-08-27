namespace https.spec.edmcouncil.org.fibo.ontology.IND.ForeignExchange.ForeignExchange.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_ind_fx_fx =
    let _namespace_iri = Namespace_Iri fibo_ind_fx_fx |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-ind-fx-fx:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Foreign Exchange Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/">https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_ind_fx_fx, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-fx-fx:CurrencyConversionService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"currency conversion service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/CurrencyConversionService">https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/CurrencyConversionService</seealso>
    let CurrencyConversionService =
        Prefixed_Name(fibo_ind_fx_fx, "CurrencyConversionService") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-fx-fx:CurrencyForwardRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"currency forward rate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/CurrencyForwardRate">https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/CurrencyForwardRate</seealso>
    let CurrencyForwardRate =
        Prefixed_Name(fibo_ind_fx_fx, "CurrencyForwardRate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-fx-fx:CurrencyForwardRateVolatility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"currency forward rate volatility"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/CurrencyForwardRateVolatility">https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/CurrencyForwardRateVolatility</seealso>
    let CurrencyForwardRateVolatility =
        Prefixed_Name(fibo_ind_fx_fx, "CurrencyForwardRateVolatility") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-fx-fx:CurrencySpotBuyRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"currency spot buy rate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/CurrencySpotBuyRate">https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/CurrencySpotBuyRate</seealso>
    let CurrencySpotBuyRate =
        Prefixed_Name(fibo_ind_fx_fx, "CurrencySpotBuyRate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-fx-fx:CurrencySpotMidRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"currency spot mid rate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/CurrencySpotMidRate">https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/CurrencySpotMidRate</seealso>
    let CurrencySpotMidRate =
        Prefixed_Name(fibo_ind_fx_fx, "CurrencySpotMidRate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-fx-fx:CurrencySpotRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"currency spot rate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/CurrencySpotRate">https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/CurrencySpotRate</seealso>
    let CurrencySpotRate =
        Prefixed_Name(fibo_ind_fx_fx, "CurrencySpotRate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-fx-fx:CurrencySpotSellRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"currency spot sell rate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/CurrencySpotSellRate">https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/CurrencySpotSellRate</seealso>
    let CurrencySpotSellRate =
        Prefixed_Name(fibo_ind_fx_fx, "CurrencySpotSellRate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-fx-fx:CurrencySpotVolatility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"currency spot volatility"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/CurrencySpotVolatility">https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/CurrencySpotVolatility</seealso>
    let CurrencySpotVolatility =
        Prefixed_Name(fibo_ind_fx_fx, "CurrencySpotVolatility") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-fx-fx:ExchangeRateStructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"exchange rate structure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/ExchangeRateStructure">https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/ExchangeRateStructure</seealso>
    let ExchangeRateStructure =
        Prefixed_Name(fibo_ind_fx_fx, "ExchangeRateStructure") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-fx-fx:ExchangeRateVolatility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"exchange rate volatility"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/ExchangeRateVolatility">https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/ExchangeRateVolatility</seealso>
    let ExchangeRateVolatility =
        Prefixed_Name(fibo_ind_fx_fx, "ExchangeRateVolatility") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-fx-fx:ForeignExchangeService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"foreign exchange service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/ForeignExchangeService">https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/ForeignExchangeService</seealso>
    let ForeignExchangeService =
        Prefixed_Name(fibo_ind_fx_fx, "ForeignExchangeService") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-fx-fx:InternationalElectronicFundsTransferService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"international electronic funds transfer service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/InternationalElectronicFundsTransferService">https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/InternationalElectronicFundsTransferService</seealso>
    let InternationalElectronicFundsTransferService =
        Prefixed_Name(fibo_ind_fx_fx, "InternationalElectronicFundsTransferService") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-fx-fx:QuotedExchangeRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"quoted exchange rate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/QuotedExchangeRate">https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/QuotedExchangeRate</seealso>
    let QuotedExchangeRate =
        Prefixed_Name(fibo_ind_fx_fx, "QuotedExchangeRate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-fx-fx:hasExchangeRateQuotationSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has exchange rate quotation source"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/hasExchangeRateQuotationSource">https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/hasExchangeRateQuotationSource</seealso>
    let hasExchangeRateQuotationSource =
        Prefixed_Name(fibo_ind_fx_fx, "hasExchangeRateQuotationSource") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-fx-fx:hasQuotationBlockAmountBasis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has quotation block amount basis"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/hasQuotationBlockAmountBasis">https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/hasQuotationBlockAmountBasis</seealso>
    let hasQuotationBlockAmountBasis =
        Prefixed_Name(fibo_ind_fx_fx, "hasQuotationBlockAmountBasis") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-fx-fx:hasQuotationSettlementBasis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has quotation settlement basis"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/hasQuotationSettlementBasis">https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/hasQuotationSettlementBasis</seealso>
    let hasQuotationSettlementBasis =
        Prefixed_Name(fibo_ind_fx_fx, "hasQuotationSettlementBasis") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-fx-fx:hasQuoteCurrency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has quote currency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/hasQuoteCurrency">https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/hasQuoteCurrency</seealso>
    let hasQuoteCurrency =
        Prefixed_Name(fibo_ind_fx_fx, "hasQuoteCurrency") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-fx-fx:hasQuotedExchangeRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has quoted exchange rate"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/hasQuotedExchangeRate">https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/hasQuotedExchangeRate</seealso>
    let hasQuotedExchangeRate =
        Prefixed_Name(fibo_ind_fx_fx, "hasQuotedExchangeRate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-fx-fx:isPremiumOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is premium on"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/isPremiumOn">https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/isPremiumOn</seealso>
    let isPremiumOn = Prefixed_Name(fibo_ind_fx_fx, "isPremiumOn") |> PrefixedName
