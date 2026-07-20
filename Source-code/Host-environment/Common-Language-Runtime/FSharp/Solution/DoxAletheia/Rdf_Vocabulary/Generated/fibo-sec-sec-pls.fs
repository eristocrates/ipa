namespace https.spec.edmcouncil.org.fibo.ontology.SEC.Securities.Pools.slash

open DoxAletheia

module fibo_sec_sec_pls =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Pools/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Pools/CollectiveInvestmentVehicle"></see>
    /// </summary>
    let CollectiveInvestmentVehicle = _prefix "CollectiveInvestmentVehicle"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Pools/PooledFund"></see>
    /// </summary>
    let PooledFund = _prefix "PooledFund"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Pools/DebtPool"></see>
    /// </summary>
    let DebtPool = _prefix "DebtPool"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Pools/InstrumentPool"></see>
    /// </summary>
    let InstrumentPool = _prefix "InstrumentPool"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Pools/FundFamily"></see>
    /// </summary>
    let FundFamily = _prefix "FundFamily"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Pools/ManagedInvestment"></see>
    /// </summary>
    let ManagedInvestment = _prefix "ManagedInvestment"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Pools/Pool"></see>
    /// </summary>
    let Pool = _prefix "Pool"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Pools/InstrumentPoolAsAsset"></see>
    /// </summary>
    let InstrumentPoolAsAsset = _prefix "InstrumentPoolAsAsset"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Pools/PoolConstituent"></see>
    /// </summary>
    let PoolConstituent = _prefix "PoolConstituent"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Pools/PrivateFund"></see>
    /// </summary>
    let PrivateFund = _prefix "PrivateFund"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Pools/SecuritiesPool"></see>
    /// </summary>
    let SecuritiesPool = _prefix "SecuritiesPool"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Pools/SecuritiesPoolConstituent"></see>
    /// </summary>
    let SecuritiesPoolConstituent = _prefix "SecuritiesPoolConstituent"
