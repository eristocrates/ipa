namespace https.spec.edmcouncil.org.fibo.ontology.DER.DerivativesContracts.CommoditiesContracts.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_der_drc_comm =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/AgriculturalResource"></see>
    /// </summary>
    let AgriculturalResource =
        Namespaced_IRI.parse _namespace_name "AgriculturalResource" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/BaseMetal"></see>
    /// </summary>
    let BaseMetal = Namespaced_IRI.parse _namespace_name "BaseMetal" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/Metal"></see>
    /// </summary>
    let Metal = Namespaced_IRI.parse _namespace_name "Metal" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/BasketOfCommodities"></see>
    /// </summary>
    let BasketOfCommodities =
        Namespaced_IRI.parse _namespace_name "BasketOfCommodities" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/CommodityBasketConstituent"></see>
    /// </summary>
    let CommodityBasketConstituent =
        Namespaced_IRI.parse _namespace_name "CommodityBasketConstituent" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/Bullion"></see>
    /// </summary>
    let Bullion = Namespaced_IRI.parse _namespace_name "Bullion" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/hasCommodityValueAsOfDate"></see>
    /// </summary>
    let hasCommodityValueAsOfDate =
        Namespaced_IRI.parse _namespace_name "hasCommodityValueAsOfDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/CommodityDerivative"></see>
    /// </summary>
    let CommodityDerivative =
        Namespaced_IRI.parse _namespace_name "CommodityDerivative" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/CommodityDerivativeUnderlier"></see>
    /// </summary>
    let CommodityDerivativeUnderlier =
        Namespaced_IRI.parse _namespace_name "CommodityDerivativeUnderlier" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/CommodityForward"></see>
    /// </summary>
    let CommodityForward =
        Namespaced_IRI.parse _namespace_name "CommodityForward" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/CommodityFuture"></see>
    /// </summary>
    let CommodityFuture =
        Namespaced_IRI.parse _namespace_name "CommodityFuture" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/CommodityIndex"></see>
    /// </summary>
    let CommodityIndex =
        Namespaced_IRI.parse _namespace_name "CommodityIndex" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/CommodityOption"></see>
    /// </summary>
    let CommodityOption =
        Namespaced_IRI.parse _namespace_name "CommodityOption" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/CommodityReturnLeg"></see>
    /// </summary>
    let CommodityReturnLeg =
        Namespaced_IRI.parse _namespace_name "CommodityReturnLeg" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/CommoditySpotContract"></see>
    /// </summary>
    let CommoditySpotContract =
        Namespaced_IRI.parse _namespace_name "CommoditySpotContract" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/CommoditySwap"></see>
    /// </summary>
    let CommoditySwap =
        Namespaced_IRI.parse _namespace_name "CommoditySwap" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/EnergyResource"></see>
    /// </summary>
    let EnergyResource =
        Namespaced_IRI.parse _namespace_name "EnergyResource" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/EnergyTransmissionRights"></see>
    /// </summary>
    let EnergyTransmissionRights =
        Namespaced_IRI.parse _namespace_name "EnergyTransmissionRights" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/EnvironmentalResource"></see>
    /// </summary>
    let EnvironmentalResource =
        Namespaced_IRI.parse _namespace_name "EnvironmentalResource" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/ExtractionResource"></see>
    /// </summary>
    let ExtractionResource =
        Namespaced_IRI.parse _namespace_name "ExtractionResource" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/FertilizerResource"></see>
    /// </summary>
    let FertilizerResource =
        Namespaced_IRI.parse _namespace_name "FertilizerResource" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/FreightResource"></see>
    /// </summary>
    let FreightResource =
        Namespaced_IRI.parse _namespace_name "FreightResource" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/GasCommodity"></see>
    /// </summary>
    let GasCommodity =
        Namespaced_IRI.parse _namespace_name "GasCommodity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/GeneratedResource"></see>
    /// </summary>
    let GeneratedResource =
        Namespaced_IRI.parse _namespace_name "GeneratedResource" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/GrainCommodity"></see>
    /// </summary>
    let GrainCommodity =
        Namespaced_IRI.parse _namespace_name "GrainCommodity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/IndustrialResource"></see>
    /// </summary>
    let IndustrialResource =
        Namespaced_IRI.parse _namespace_name "IndustrialResource" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/MeatCommodity"></see>
    /// </summary>
    let MeatCommodity =
        Namespaced_IRI.parse _namespace_name "MeatCommodity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/OilCommodity"></see>
    /// </summary>
    let OilCommodity =
        Namespaced_IRI.parse _namespace_name "OilCommodity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/hasGrade"></see>
    /// </summary>
    let hasGrade = Namespaced_IRI.parse _namespace_name "hasGrade" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/OilGrade"></see>
    /// </summary>
    let OilGrade = Namespaced_IRI.parse _namespace_name "OilGrade" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/PaperResource"></see>
    /// </summary>
    let PaperResource =
        Namespaced_IRI.parse _namespace_name "PaperResource" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/PolypropyleneResource"></see>
    /// </summary>
    let PolypropyleneResource =
        Namespaced_IRI.parse _namespace_name "PolypropyleneResource" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/ServiceResource"></see>
    /// </summary>
    let ServiceResource =
        Namespaced_IRI.parse _namespace_name "ServiceResource" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/WeatherDerivative"></see>
    /// </summary>
    let WeatherDerivative =
        Namespaced_IRI.parse _namespace_name "WeatherDerivative" |> NamespacedName
