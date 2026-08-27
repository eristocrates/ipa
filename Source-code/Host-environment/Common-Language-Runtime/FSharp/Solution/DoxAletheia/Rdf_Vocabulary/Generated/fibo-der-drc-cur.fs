namespace https.spec.edmcouncil.org.fibo.ontology.DER.DerivativesContracts.CurrencyContracts.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_der_drc_cur =
    let _namespace_iri = Namespace_Iri fibo_der_drc_cur |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-der-drc-cur:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Currency Contracts Ontology"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CurrencyContracts/">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CurrencyContracts/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_der_drc_cur, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-cur:CurrencyDerivative</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"currency derivative"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CurrencyContracts/CurrencyDerivative">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CurrencyContracts/CurrencyDerivative</seealso>
    let CurrencyDerivative =
        Prefixed_Name(fibo_der_drc_cur, "CurrencyDerivative") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-cur:CurrencyForward</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"currency forward"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CurrencyContracts/CurrencyForward">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CurrencyContracts/CurrencyForward</seealso>
    let CurrencyForward =
        Prefixed_Name(fibo_der_drc_cur, "CurrencyForward") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-cur:CurrencyForwardOutright</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"currency forward outright"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CurrencyContracts/CurrencyForwardOutright">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CurrencyContracts/CurrencyForwardOutright</seealso>
    let CurrencyForwardOutright =
        Prefixed_Name(fibo_der_drc_cur, "CurrencyForwardOutright") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-cur:CurrencyOption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"currency option"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CurrencyContracts/CurrencyOption">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CurrencyContracts/CurrencyOption</seealso>
    let CurrencyOption =
        Prefixed_Name(fibo_der_drc_cur, "CurrencyOption") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-cur:CurrencySpotContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"currency spot contract"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CurrencyContracts/CurrencySpotContract">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CurrencyContracts/CurrencySpotContract</seealso>
    let CurrencySpotContract =
        Prefixed_Name(fibo_der_drc_cur, "CurrencySpotContract") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-cur:CurrencySpotForwardSwap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"currency spot forward swap"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CurrencyContracts/CurrencySpotForwardSwap">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CurrencyContracts/CurrencySpotForwardSwap</seealso>
    let CurrencySpotForwardSwap =
        Prefixed_Name(fibo_der_drc_cur, "CurrencySpotForwardSwap") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-cur:CurrencySwap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"currency swap"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CurrencyContracts/CurrencySwap">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CurrencyContracts/CurrencySwap</seealso>
    let CurrencySwap = Prefixed_Name(fibo_der_drc_cur, "CurrencySwap") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-cur:CurrencyVolatilityOption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"currency volatility option"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CurrencyContracts/CurrencyVolatilityOption">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CurrencyContracts/CurrencyVolatilityOption</seealso>
    let CurrencyVolatilityOption =
        Prefixed_Name(fibo_der_drc_cur, "CurrencyVolatilityOption") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-cur:ForeignExchangeMasterAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"foreign exchange master agreement"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CurrencyContracts/ForeignExchangeMasterAgreement">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CurrencyContracts/ForeignExchangeMasterAgreement</seealso>
    let ForeignExchangeMasterAgreement =
        Prefixed_Name(fibo_der_drc_cur, "ForeignExchangeMasterAgreement") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-cur:ForeignExchangeSettlementNettingProvision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"foreign exchange settlement netting provision"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CurrencyContracts/ForeignExchangeSettlementNettingProvision">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CurrencyContracts/ForeignExchangeSettlementNettingProvision</seealso>
    let ForeignExchangeSettlementNettingProvision =
        Prefixed_Name(fibo_der_drc_cur, "ForeignExchangeSettlementNettingProvision") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-cur:hasForwardExchangeRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has forward exchange rate"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CurrencyContracts/hasForwardExchangeRate">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CurrencyContracts/hasForwardExchangeRate</seealso>
    let hasForwardExchangeRate =
        Prefixed_Name(fibo_der_drc_cur, "hasForwardExchangeRate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-cur:hasSpotExchangeRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has spot exchange rate"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CurrencyContracts/hasSpotExchangeRate">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CurrencyContracts/hasSpotExchangeRate</seealso>
    let hasSpotExchangeRate =
        Prefixed_Name(fibo_der_drc_cur, "hasSpotExchangeRate") |> PrefixedName
