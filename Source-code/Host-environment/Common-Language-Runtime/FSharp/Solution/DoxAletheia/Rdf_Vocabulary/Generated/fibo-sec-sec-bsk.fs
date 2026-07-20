namespace https.spec.edmcouncil.org.fibo.ontology.SEC.Securities.Baskets.slash

open DoxAletheia

module fibo_sec_sec_bsk =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Baskets/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Baskets/BasketOfIndices"></see>
    /// </summary>
    let BasketOfIndices = _prefix "BasketOfIndices"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Baskets/BasketOfIndicesConstituent"></see>
    /// </summary>
    let BasketOfIndicesConstituent = _prefix "BasketOfIndicesConstituent"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Baskets/BasketOfSecurities"></see>
    /// </summary>
    let BasketOfSecurities = _prefix "BasketOfSecurities"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Baskets/SecuritiesBasketConstituent"></see>
    /// </summary>
    let SecuritiesBasketConstituent = _prefix "SecuritiesBasketConstituent"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Baskets/MixedBasket"></see>
    /// </summary>
    let MixedBasket = _prefix "MixedBasket"
