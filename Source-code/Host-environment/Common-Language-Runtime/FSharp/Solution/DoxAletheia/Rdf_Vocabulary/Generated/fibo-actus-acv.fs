namespace https.spec.edmcouncil.org.fibo.ontology.ACTUS.ACTUSTaxonomy.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_actus_acv =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSCashFlowFamily"></see>
    /// </summary>
    let ACTUSCashFlowFamily =
        Namespaced_IRI.parse _namespace_name "ACTUSCashFlowFamily" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/AlgorithmicContractTypesClassificationScheme"></see>
    /// </summary>
    let AlgorithmicContractTypesClassificationScheme =
        Namespaced_IRI.parse _namespace_name "AlgorithmicContractTypesClassificationScheme" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSCashFlowFamily-Basic"></see>
    /// </summary>
    let ``ACTUSCashFlowFamily-Basic`` =
        Namespaced_IRI.parse _namespace_name "ACTUSCashFlowFamily-Basic" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSCashFlowFamily-Combined"></see>
    /// </summary>
    let ``ACTUSCashFlowFamily-Combined`` =
        Namespaced_IRI.parse _namespace_name "ACTUSCashFlowFamily-Combined" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSCashFlowFamily-CreditEnhancement"></see>
    /// </summary>
    let ``ACTUSCashFlowFamily-CreditEnhancement`` =
        Namespaced_IRI.parse _namespace_name "ACTUSCashFlowFamily-CreditEnhancement" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSCashflowCategory"></see>
    /// </summary>
    let ACTUSCashflowCategory =
        Namespaced_IRI.parse _namespace_name "ACTUSCashflowCategory" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSCashflowCategory-Asymmetric"></see>
    /// </summary>
    let ``ACTUSCashflowCategory-Asymmetric`` =
        Namespaced_IRI.parse _namespace_name "ACTUSCashflowCategory-Asymmetric" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSCashflowCategory-CreditEnhancement"></see>
    /// </summary>
    let ``ACTUSCashflowCategory-CreditEnhancement`` =
        Namespaced_IRI.parse _namespace_name "ACTUSCashflowCategory-CreditEnhancement" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSCashflowCategory-FixedIncome"></see>
    /// </summary>
    let ``ACTUSCashflowCategory-FixedIncome`` =
        Namespaced_IRI.parse _namespace_name "ACTUSCashflowCategory-FixedIncome" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSCashflowCategory-Ownership"></see>
    /// </summary>
    let ``ACTUSCashflowCategory-Ownership`` =
        Namespaced_IRI.parse _namespace_name "ACTUSCashflowCategory-Ownership" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSCashflowCategory-Securitization"></see>
    /// </summary>
    let ``ACTUSCashflowCategory-Securitization`` =
        Namespaced_IRI.parse _namespace_name "ACTUSCashflowCategory-Securitization" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSCashflowCategory-Symmetric"></see>
    /// </summary>
    let ``ACTUSCashflowCategory-Symmetric`` =
        Namespaced_IRI.parse _namespace_name "ACTUSCashflowCategory-Symmetric" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType"></see>
    /// </summary>
    let ACTUSContractType =
        Namespaced_IRI.parse _namespace_name "ACTUSContractType" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/hasCoverageDescription"></see>
    /// </summary>
    let hasCoverageDescription =
        Namespaced_IRI.parse _namespace_name "hasCoverageDescription" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-Annuity"></see>
    /// </summary>
    let ``ACTUSContractType-Annuity`` =
        Namespaced_IRI.parse _namespace_name "ACTUSContractType-Annuity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-BondWithWarrant"></see>
    /// </summary>
    let ``ACTUSContractType-BondWithWarrant`` =
        Namespaced_IRI.parse _namespace_name "ACTUSContractType-BondWithWarrant" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-BoundaryControlledSwitch"></see>
    /// </summary>
    let ``ACTUSContractType-BoundaryControlledSwitch`` =
        Namespaced_IRI.parse _namespace_name "ACTUSContractType-BoundaryControlledSwitch" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-CallMoney"></see>
    /// </summary>
    let ``ACTUSContractType-CallMoney`` =
        Namespaced_IRI.parse _namespace_name "ACTUSContractType-CallMoney" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-CapFloorOption"></see>
    /// </summary>
    let ``ACTUSContractType-CapFloorOption`` =
        Namespaced_IRI.parse _namespace_name "ACTUSContractType-CapFloorOption" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-Cash"></see>
    /// </summary>
    let ``ACTUSContractType-Cash`` =
        Namespaced_IRI.parse _namespace_name "ACTUSContractType-Cash" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-Collateral"></see>
    /// </summary>
    let ``ACTUSContractType-Collateral`` =
        Namespaced_IRI.parse _namespace_name "ACTUSContractType-Collateral" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-Commodity"></see>
    /// </summary>
    let ``ACTUSContractType-Commodity`` =
        Namespaced_IRI.parse _namespace_name "ACTUSContractType-Commodity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-ConvertibleNote"></see>
    /// </summary>
    let ``ACTUSContractType-ConvertibleNote`` =
        Namespaced_IRI.parse _namespace_name "ACTUSContractType-ConvertibleNote" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-CreditDefaultSwap"></see>
    /// </summary>
    let ``ACTUSContractType-CreditDefaultSwap`` =
        Namespaced_IRI.parse _namespace_name "ACTUSContractType-CreditDefaultSwap" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-CreditLinkedNote"></see>
    /// </summary>
    let ``ACTUSContractType-CreditLinkedNote`` =
        Namespaced_IRI.parse _namespace_name "ACTUSContractType-CreditLinkedNote" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-ExoticAnnuity"></see>
    /// </summary>
    let ``ACTUSContractType-ExoticAnnuity`` =
        Namespaced_IRI.parse _namespace_name "ACTUSContractType-ExoticAnnuity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-ExoticLinearAmortizer"></see>
    /// </summary>
    let ``ACTUSContractType-ExoticLinearAmortizer`` =
        Namespaced_IRI.parse _namespace_name "ACTUSContractType-ExoticLinearAmortizer" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-ExoticNegativeAmortizer"></see>
    /// </summary>
    let ``ACTUSContractType-ExoticNegativeAmortizer`` =
        Namespaced_IRI.parse _namespace_name "ACTUSContractType-ExoticNegativeAmortizer" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-ExoticOption"></see>
    /// </summary>
    let ``ACTUSContractType-ExoticOption`` =
        Namespaced_IRI.parse _namespace_name "ACTUSContractType-ExoticOption" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-ForeignExchangeOutright"></see>
    /// </summary>
    let ``ACTUSContractType-ForeignExchangeOutright`` =
        Namespaced_IRI.parse _namespace_name "ACTUSContractType-ForeignExchangeOutright" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-Future"></see>
    /// </summary>
    let ``ACTUSContractType-Future`` =
        Namespaced_IRI.parse _namespace_name "ACTUSContractType-Future" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-Guarantee"></see>
    /// </summary>
    let ``ACTUSContractType-Guarantee`` =
        Namespaced_IRI.parse _namespace_name "ACTUSContractType-Guarantee" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-LinearAmortizer"></see>
    /// </summary>
    let ``ACTUSContractType-LinearAmortizer`` =
        Namespaced_IRI.parse _namespace_name "ACTUSContractType-LinearAmortizer" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-Margining"></see>
    /// </summary>
    let ``ACTUSContractType-Margining`` =
        Namespaced_IRI.parse _namespace_name "ACTUSContractType-Margining" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-NegativeAmortizer"></see>
    /// </summary>
    let ``ACTUSContractType-NegativeAmortizer`` =
        Namespaced_IRI.parse _namespace_name "ACTUSContractType-NegativeAmortizer" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-Option"></see>
    /// </summary>
    let ``ACTUSContractType-Option`` =
        Namespaced_IRI.parse _namespace_name "ACTUSContractType-Option" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-PerpetualBond"></see>
    /// </summary>
    let ``ACTUSContractType-PerpetualBond`` =
        Namespaced_IRI.parse _namespace_name "ACTUSContractType-PerpetualBond" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-PlainVanillaSwap"></see>
    /// </summary>
    let ``ACTUSContractType-PlainVanillaSwap`` =
        Namespaced_IRI.parse _namespace_name "ACTUSContractType-PlainVanillaSwap" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-PrincipalAtMaturity"></see>
    /// </summary>
    let ``ACTUSContractType-PrincipalAtMaturity`` =
        Namespaced_IRI.parse _namespace_name "ACTUSContractType-PrincipalAtMaturity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-RepurchaseAgreement"></see>
    /// </summary>
    let ``ACTUSContractType-RepurchaseAgreement`` =
        Namespaced_IRI.parse _namespace_name "ACTUSContractType-RepurchaseAgreement" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-SecuritizationCreditRisk"></see>
    /// </summary>
    let ``ACTUSContractType-SecuritizationCreditRisk`` =
        Namespaced_IRI.parse _namespace_name "ACTUSContractType-SecuritizationCreditRisk" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-SecuritizationMarketRisk"></see>
    /// </summary>
    let ``ACTUSContractType-SecuritizationMarketRisk`` =
        Namespaced_IRI.parse _namespace_name "ACTUSContractType-SecuritizationMarketRisk" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-Stock"></see>
    /// </summary>
    let ``ACTUSContractType-Stock`` =
        Namespaced_IRI.parse _namespace_name "ACTUSContractType-Stock" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-Swap"></see>
    /// </summary>
    let ``ACTUSContractType-Swap`` =
        Namespaced_IRI.parse _namespace_name "ACTUSContractType-Swap" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-TotalReturnSwap"></see>
    /// </summary>
    let ``ACTUSContractType-TotalReturnSwap`` =
        Namespaced_IRI.parse _namespace_name "ACTUSContractType-TotalReturnSwap" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-UndefinedMaturityProfile"></see>
    /// </summary>
    let ``ACTUSContractType-UndefinedMaturityProfile`` =
        Namespaced_IRI.parse _namespace_name "ACTUSContractType-UndefinedMaturityProfile" |> NamespacedName
