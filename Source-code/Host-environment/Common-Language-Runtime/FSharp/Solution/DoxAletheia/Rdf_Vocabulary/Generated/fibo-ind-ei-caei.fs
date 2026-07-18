namespace https.spec.edmcouncil.org.fibo.ontology.IND.EconomicIndicators.NorthAmericanIndicators.CAEconomicIndicators.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_ind_ei_caei =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/CAEconomicIndicators/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/CAEconomicIndicators/CanadianConsumerPriceIndex"></see>
    /// </summary>
    let CanadianConsumerPriceIndex =
        Namespaced_IRI.parse _namespace_name "CanadianConsumerPriceIndex" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/CAEconomicIndicators/CanadianStatisticsPublisher"></see>
    /// </summary>
    let CanadianStatisticsPublisher =
        Namespaced_IRI.parse _namespace_name "CanadianStatisticsPublisher" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/CAEconomicIndicators/StatisticsCanada"></see>
    /// </summary>
    let StatisticsCanada =
        Namespaced_IRI.parse _namespace_name "StatisticsCanada" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/CAEconomicIndicators/CanadianHouseholdsConsumersUniverse"></see>
    /// </summary>
    let CanadianHouseholdsConsumersUniverse =
        Namespaced_IRI.parse _namespace_name "CanadianHouseholdsConsumersUniverse" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/CAEconomicIndicators/CanadianProducerPriceIndex"></see>
    /// </summary>
    let CanadianProducerPriceIndex =
        Namespaced_IRI.parse _namespace_name "CanadianProducerPriceIndex" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/CAEconomicIndicators/IndustrialProductsSector"></see>
    /// </summary>
    let IndustrialProductsSector =
        Namespaced_IRI.parse _namespace_name "IndustrialProductsSector" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/CAEconomicIndicators/NewHousingSector"></see>
    /// </summary>
    let NewHousingSector =
        Namespaced_IRI.parse _namespace_name "NewHousingSector" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/CAEconomicIndicators/RawMaterialsSector"></see>
    /// </summary>
    let RawMaterialsSector =
        Namespaced_IRI.parse _namespace_name "RawMaterialsSector" |> NamespacedName
