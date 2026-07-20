namespace https.spec.edmcouncil.org.fibo.ontology.IND.MarketIndices.BasketIndices.slash

open DoxAletheia

module fibo_ind_mkt_bas =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/BasketOfCreditRisks"></see>
    /// </summary>
    let BasketOfCreditRisks = _prefix "BasketOfCreditRisks"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/CreditIndexConstituent"></see>
    /// </summary>
    let CreditIndexConstituent = _prefix "CreditIndexConstituent"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/BasketOfEquities"></see>
    /// </summary>
    let BasketOfEquities = _prefix "BasketOfEquities"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/CapitalizationBasedWeightingFunction"></see>
    /// </summary>
    let CapitalizationBasedWeightingFunction =
        _prefix "CapitalizationBasedWeightingFunction"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/hasMarketCapitalization"></see>
    /// </summary>
    let hasMarketCapitalization = _prefix "hasMarketCapitalization"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/MarketCapitalization"></see>
    /// </summary>
    let MarketCapitalization = _prefix "MarketCapitalization"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/CreditIndex"></see>
    /// </summary>
    let CreditIndex = _prefix "CreditIndex"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/ReferenceIndex"></see>
    /// </summary>
    let ReferenceIndex = _prefix "ReferenceIndex"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/EquityIndex"></see>
    /// </summary>
    let EquityIndex = _prefix "EquityIndex"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/hasMarketCapitalizationValue"></see>
    /// </summary>
    let hasMarketCapitalizationValue = _prefix "hasMarketCapitalizationValue"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/hasDebtRanking"></see>
    /// </summary>
    let hasDebtRanking = _prefix "hasDebtRanking"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/hasIndexName"></see>
    /// </summary>
    let hasIndexName = _prefix "hasIndexName"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/hasIndexValue"></see>
    /// </summary>
    let hasIndexValue = _prefix "hasIndexValue"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/hasOriginalNotionalValue"></see>
    /// </summary>
    let hasOriginalNotionalValue = _prefix "hasOriginalNotionalValue"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/hasPremium"></see>
    /// </summary>
    let hasPremium = _prefix "hasPremium"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/hasSpreadRange"></see>
    /// </summary>
    let hasSpreadRange = _prefix "hasSpreadRange"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/hasUpFrontFee"></see>
    /// </summary>
    let hasUpFrontFee = _prefix "hasUpFrontFee"
