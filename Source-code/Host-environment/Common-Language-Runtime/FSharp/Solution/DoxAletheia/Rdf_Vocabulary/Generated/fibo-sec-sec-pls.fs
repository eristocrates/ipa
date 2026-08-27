namespace https.spec.edmcouncil.org.fibo.ontology.SEC.Securities.Pools.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_sec_sec_pls =
    let _namespace_iri = Namespace_Iri fibo_sec_sec_pls |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-sec-sec-pls:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Securities Pools Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Pools/">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Pools/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_sec_sec_pls, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-pls:CollectiveInvestmentVehicle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"collective investment vehicle"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Pools/CollectiveInvestmentVehicle">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Pools/CollectiveInvestmentVehicle</seealso>
    let CollectiveInvestmentVehicle =
        Prefixed_Name(fibo_sec_sec_pls, "CollectiveInvestmentVehicle") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-pls:DebtPool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"debt pool"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Pools/DebtPool">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Pools/DebtPool</seealso>
    let DebtPool = Prefixed_Name(fibo_sec_sec_pls, "DebtPool") |> PrefixedName
    /// <summary>
    ///   <para>fibo-sec-sec-pls:FundFamily</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"fund family"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Pools/FundFamily">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Pools/FundFamily</seealso>
    let FundFamily = Prefixed_Name(fibo_sec_sec_pls, "FundFamily") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-pls:InstrumentPool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"instrument pool"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Pools/InstrumentPool">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Pools/InstrumentPool</seealso>
    let InstrumentPool =
        Prefixed_Name(fibo_sec_sec_pls, "InstrumentPool") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-pls:InstrumentPoolAsAsset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"instrument pool as asset"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Pools/InstrumentPoolAsAsset">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Pools/InstrumentPoolAsAsset</seealso>
    let InstrumentPoolAsAsset =
        Prefixed_Name(fibo_sec_sec_pls, "InstrumentPoolAsAsset") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-pls:ManagedInvestment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"managed investment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Pools/ManagedInvestment">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Pools/ManagedInvestment</seealso>
    let ManagedInvestment =
        Prefixed_Name(fibo_sec_sec_pls, "ManagedInvestment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-pls:Pool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"pool"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Pools/Pool">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Pools/Pool</seealso>
    let Pool = Prefixed_Name(fibo_sec_sec_pls, "Pool") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-pls:PoolConstituent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"pool constituent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Pools/PoolConstituent">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Pools/PoolConstituent</seealso>
    let PoolConstituent =
        Prefixed_Name(fibo_sec_sec_pls, "PoolConstituent") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-pls:PooledFund</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"pooled fund"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Pools/PooledFund">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Pools/PooledFund</seealso>
    let PooledFund = Prefixed_Name(fibo_sec_sec_pls, "PooledFund") |> PrefixedName
    /// <summary>
    ///   <para>fibo-sec-sec-pls:PrivateFund</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"private fund"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Pools/PrivateFund">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Pools/PrivateFund</seealso>
    let PrivateFund = Prefixed_Name(fibo_sec_sec_pls, "PrivateFund") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-pls:SecuritiesPool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"securities pool"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Pools/SecuritiesPool">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Pools/SecuritiesPool</seealso>
    let SecuritiesPool =
        Prefixed_Name(fibo_sec_sec_pls, "SecuritiesPool") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-pls:SecuritiesPoolConstituent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Pools/SecuritiesPoolConstituent">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Pools/SecuritiesPoolConstituent</seealso>
    let SecuritiesPoolConstituent =
        Prefixed_Name(fibo_sec_sec_pls, "SecuritiesPoolConstituent") |> PrefixedName
