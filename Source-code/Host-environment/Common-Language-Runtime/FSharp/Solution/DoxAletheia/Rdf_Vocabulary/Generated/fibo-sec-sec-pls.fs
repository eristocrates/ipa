namespace https.spec.edmcouncil.org.fibo.ontology.SEC.Securities.Pools.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_sec_sec_pls =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Pools/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Pools/CollectiveInvestmentVehicle"></see>
    /// </summary>
    let CollectiveInvestmentVehicle =
        Namespaced_IRI.parse _namespace_name "CollectiveInvestmentVehicle" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Pools/PooledFund"></see>
    /// </summary>
    let PooledFund = Namespaced_IRI.parse _namespace_name "PooledFund" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Pools/DebtPool"></see>
    /// </summary>
    let DebtPool = Namespaced_IRI.parse _namespace_name "DebtPool" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Pools/InstrumentPool"></see>
    /// </summary>
    let InstrumentPool =
        Namespaced_IRI.parse _namespace_name "InstrumentPool" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Pools/FundFamily"></see>
    /// </summary>
    let FundFamily = Namespaced_IRI.parse _namespace_name "FundFamily" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Pools/ManagedInvestment"></see>
    /// </summary>
    let ManagedInvestment =
        Namespaced_IRI.parse _namespace_name "ManagedInvestment" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Pools/Pool"></see>
    /// </summary>
    let Pool = Namespaced_IRI.parse _namespace_name "Pool" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Pools/InstrumentPoolAsAsset"></see>
    /// </summary>
    let InstrumentPoolAsAsset =
        Namespaced_IRI.parse _namespace_name "InstrumentPoolAsAsset" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Pools/PoolConstituent"></see>
    /// </summary>
    let PoolConstituent =
        Namespaced_IRI.parse _namespace_name "PoolConstituent" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Pools/PrivateFund"></see>
    /// </summary>
    let PrivateFund =
        Namespaced_IRI.parse _namespace_name "PrivateFund" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Pools/SecuritiesPool"></see>
    /// </summary>
    let SecuritiesPool =
        Namespaced_IRI.parse _namespace_name "SecuritiesPool" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Pools/SecuritiesPoolConstituent"></see>
    /// </summary>
    let SecuritiesPoolConstituent =
        Namespaced_IRI.parse _namespace_name "SecuritiesPoolConstituent" |> NamespacedName
