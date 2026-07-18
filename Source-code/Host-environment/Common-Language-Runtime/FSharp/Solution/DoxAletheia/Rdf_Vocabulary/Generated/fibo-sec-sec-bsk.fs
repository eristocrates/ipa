namespace https.spec.edmcouncil.org.fibo.ontology.SEC.Securities.Baskets.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_sec_sec_bsk =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Baskets/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Baskets/BasketOfIndices"></see>
    /// </summary>
    let BasketOfIndices =
        Namespaced_IRI.parse _namespace_name "BasketOfIndices" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Baskets/BasketOfIndicesConstituent"></see>
    /// </summary>
    let BasketOfIndicesConstituent =
        Namespaced_IRI.parse _namespace_name "BasketOfIndicesConstituent" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Baskets/BasketOfSecurities"></see>
    /// </summary>
    let BasketOfSecurities =
        Namespaced_IRI.parse _namespace_name "BasketOfSecurities" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Baskets/SecuritiesBasketConstituent"></see>
    /// </summary>
    let SecuritiesBasketConstituent =
        Namespaced_IRI.parse _namespace_name "SecuritiesBasketConstituent" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Baskets/MixedBasket"></see>
    /// </summary>
    let MixedBasket =
        Namespaced_IRI.parse _namespace_name "MixedBasket" |> NamespacedName
