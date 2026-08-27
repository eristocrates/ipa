namespace https.spec.edmcouncil.org.fibo.ontology.DER.DerivativesContracts.SwapsIndividuals.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_der_drc_swpind =
    let _namespace_iri = Namespace_Iri fibo_der_drc_swpind |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-der-drc-swpind:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Swaps Individuals Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/SwapsIndividuals/">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/SwapsIndividuals/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_der_drc_swpind, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-swpind:BloombergSDR</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-der-drc-swp:SwapDataRepository</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Bloomberg SDR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/SwapsIndividuals/BloombergSDR">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/SwapsIndividuals/BloombergSDR</seealso>
    let BloombergSDR =
        Prefixed_Name(fibo_der_drc_swpind, "BloombergSDR") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-swpind:ChicagoMercantileExchange</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-mkt:DesignatedContractMarket</para>
    ///   <para>fibo-fbc-fct-fse:SelfRegulatingOrganization</para>
    ///   <para>fibo-der-drc-swp:SwapDataRepository</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Chicago Mercantile Exchange"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/SwapsIndividuals/ChicagoMercantileExchange">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/SwapsIndividuals/ChicagoMercantileExchange</seealso>
    let ChicagoMercantileExchange =
        Prefixed_Name(fibo_der_drc_swpind, "ChicagoMercantileExchange") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-swpind:DTCCDataRepository</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-der-drc-swp:SwapDataRepository</para>
    ///
    /// labels<para>"DTCC Data Repository"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/SwapsIndividuals/DTCCDataRepository">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/SwapsIndividuals/DTCCDataRepository</seealso>
    let DTCCDataRepository =
        Prefixed_Name(fibo_der_drc_swpind, "DTCCDataRepository") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-swpind:ICETradeVault</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-der-drc-swp:SwapDataRepository</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ICE Trade Vault"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/SwapsIndividuals/ICETradeVault">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/SwapsIndividuals/ICETradeVault</seealso>
    let ICETradeVault =
        Prefixed_Name(fibo_der_drc_swpind, "ICETradeVault") |> PrefixedName
