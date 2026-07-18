namespace https.spec.edmcouncil.org.fibo.ontology.SEC.Securities.SecurityAssets.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_sec_sec_ast =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecurityAssets/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecurityAssets/hasAcquisitionPrice"></see>
    /// </summary>
    let hasAcquisitionPrice =
        Namespaced_IRI.parse _namespace_name "hasAcquisitionPrice" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecurityAssets/Portfolio"></see>
    /// </summary>
    let Portfolio = Namespaced_IRI.parse _namespace_name "Portfolio" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecurityAssets/PortfolioHolding"></see>
    /// </summary>
    let PortfolioHolding =
        Namespaced_IRI.parse _namespace_name "PortfolioHolding" |> NamespacedName
