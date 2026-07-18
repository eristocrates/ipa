namespace https.spec.edmcouncil.org.fibo.ontology.IND.MarketIndices.BasketIndices.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_ind_mkt_bas =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/BasketOfCreditRisks"></see>
    /// </summary>
    let BasketOfCreditRisks =
        Namespaced_IRI.parse _namespace_name "BasketOfCreditRisks" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/CreditIndexConstituent"></see>
    /// </summary>
    let CreditIndexConstituent =
        Namespaced_IRI.parse _namespace_name "CreditIndexConstituent" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/BasketOfEquities"></see>
    /// </summary>
    let BasketOfEquities =
        Namespaced_IRI.parse _namespace_name "BasketOfEquities" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/CapitalizationBasedWeightingFunction"></see>
    /// </summary>
    let CapitalizationBasedWeightingFunction =
        Namespaced_IRI.parse _namespace_name "CapitalizationBasedWeightingFunction" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/hasMarketCapitalization"></see>
    /// </summary>
    let hasMarketCapitalization =
        Namespaced_IRI.parse _namespace_name "hasMarketCapitalization" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/MarketCapitalization"></see>
    /// </summary>
    let MarketCapitalization =
        Namespaced_IRI.parse _namespace_name "MarketCapitalization" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/CreditIndex"></see>
    /// </summary>
    let CreditIndex =
        Namespaced_IRI.parse _namespace_name "CreditIndex" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/ReferenceIndex"></see>
    /// </summary>
    let ReferenceIndex =
        Namespaced_IRI.parse _namespace_name "ReferenceIndex" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/EquityIndex"></see>
    /// </summary>
    let EquityIndex =
        Namespaced_IRI.parse _namespace_name "EquityIndex" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/hasMarketCapitalizationValue"></see>
    /// </summary>
    let hasMarketCapitalizationValue =
        Namespaced_IRI.parse _namespace_name "hasMarketCapitalizationValue" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/hasDebtRanking"></see>
    /// </summary>
    let hasDebtRanking =
        Namespaced_IRI.parse _namespace_name "hasDebtRanking" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/hasIndexName"></see>
    /// </summary>
    let hasIndexName =
        Namespaced_IRI.parse _namespace_name "hasIndexName" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/hasIndexValue"></see>
    /// </summary>
    let hasIndexValue =
        Namespaced_IRI.parse _namespace_name "hasIndexValue" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/hasOriginalNotionalValue"></see>
    /// </summary>
    let hasOriginalNotionalValue =
        Namespaced_IRI.parse _namespace_name "hasOriginalNotionalValue" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/hasPremium"></see>
    /// </summary>
    let hasPremium = Namespaced_IRI.parse _namespace_name "hasPremium" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/hasSpreadRange"></see>
    /// </summary>
    let hasSpreadRange =
        Namespaced_IRI.parse _namespace_name "hasSpreadRange" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/hasUpFrontFee"></see>
    /// </summary>
    let hasUpFrontFee =
        Namespaced_IRI.parse _namespace_name "hasUpFrontFee" |> NamespacedName
