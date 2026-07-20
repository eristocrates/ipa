namespace https.spec.edmcouncil.org.fibo.ontology.SEC.Securities.SecurityAssets.slash

open DoxAletheia

module fibo_sec_sec_ast =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecurityAssets/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecurityAssets/hasAcquisitionPrice"></see>
    /// </summary>
    let hasAcquisitionPrice = _prefix "hasAcquisitionPrice"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecurityAssets/Portfolio"></see>
    /// </summary>
    let Portfolio = _prefix "Portfolio"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecurityAssets/PortfolioHolding"></see>
    /// </summary>
    let PortfolioHolding = _prefix "PortfolioHolding"
