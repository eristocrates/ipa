namespace https.spec.edmcouncil.org.fibo.ontology.SEC.Equities.DepositaryReceipts.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_sec_eq_dr =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/AmericanDepositaryReceipt"></see>
    /// </summary>
    let AmericanDepositaryReceipt =
        Namespaced_IRI.parse _namespace_name "AmericanDepositaryReceipt" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/DepositaryReceipt"></see>
    /// </summary>
    let DepositaryReceipt =
        Namespaced_IRI.parse _namespace_name "DepositaryReceipt" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/AmericanDepositaryReceiptLevel"></see>
    /// </summary>
    let AmericanDepositaryReceiptLevel =
        Namespaced_IRI.parse _namespace_name "AmericanDepositaryReceiptLevel" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/AmericanDepositaryReceiptLevelScheme"></see>
    /// </summary>
    let AmericanDepositaryReceiptLevelScheme =
        Namespaced_IRI.parse _namespace_name "AmericanDepositaryReceiptLevelScheme" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/ChineseDepositaryReceipt"></see>
    /// </summary>
    let ChineseDepositaryReceipt =
        Namespaced_IRI.parse _namespace_name "ChineseDepositaryReceipt" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/GlobalDepositaryReceipt"></see>
    /// </summary>
    let GlobalDepositaryReceipt =
        Namespaced_IRI.parse _namespace_name "GlobalDepositaryReceipt" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/hasMultiplier"></see>
    /// </summary>
    let hasMultiplier =
        Namespaced_IRI.parse _namespace_name "hasMultiplier" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/hasTradedSecurity"></see>
    /// </summary>
    let hasTradedSecurity =
        Namespaced_IRI.parse _namespace_name "hasTradedSecurity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/EuropeanDepositaryReceipt"></see>
    /// </summary>
    let EuropeanDepositaryReceipt =
        Namespaced_IRI.parse _namespace_name "EuropeanDepositaryReceipt" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/HongKongDepositaryReceipt"></see>
    /// </summary>
    let HongKongDepositaryReceipt =
        Namespaced_IRI.parse _namespace_name "HongKongDepositaryReceipt" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/IndianDepositoryReceipt"></see>
    /// </summary>
    let IndianDepositoryReceipt =
        Namespaced_IRI.parse _namespace_name "IndianDepositoryReceipt" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/JapaneseDepositaryReceipt"></see>
    /// </summary>
    let JapaneseDepositaryReceipt =
        Namespaced_IRI.parse _namespace_name "JapaneseDepositaryReceipt" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/LevelIAmericanDepositaryReceipt"></see>
    /// </summary>
    let LevelIAmericanDepositaryReceipt =
        Namespaced_IRI.parse _namespace_name "LevelIAmericanDepositaryReceipt" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/LevelIIAmericanDepositaryReceipt"></see>
    /// </summary>
    let LevelIIAmericanDepositaryReceipt =
        Namespaced_IRI.parse _namespace_name "LevelIIAmericanDepositaryReceipt" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/LevelIIIAmericanDepositaryReceipt"></see>
    /// </summary>
    let LevelIIIAmericanDepositaryReceipt =
        Namespaced_IRI.parse _namespace_name "LevelIIIAmericanDepositaryReceipt" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/LuxembourgDepositaryReceipt"></see>
    /// </summary>
    let LuxembourgDepositaryReceipt =
        Namespaced_IRI.parse _namespace_name "LuxembourgDepositaryReceipt" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/OffshoreDepositaryReceipt"></see>
    /// </summary>
    let OffshoreDepositaryReceipt =
        Namespaced_IRI.parse _namespace_name "OffshoreDepositaryReceipt" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/SponsoredDepositaryReceipt"></see>
    /// </summary>
    let SponsoredDepositaryReceipt =
        Namespaced_IRI.parse _namespace_name "SponsoredDepositaryReceipt" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/ParticipatoryNote"></see>
    /// </summary>
    let ParticipatoryNote =
        Namespaced_IRI.parse _namespace_name "ParticipatoryNote" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/PrivatelyPlacedDepositaryReceipt"></see>
    /// </summary>
    let PrivatelyPlacedDepositaryReceipt =
        Namespaced_IRI.parse _namespace_name "PrivatelyPlacedDepositaryReceipt" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/UnsponsoredDepositaryReceipt"></see>
    /// </summary>
    let UnsponsoredDepositaryReceipt =
        Namespaced_IRI.parse _namespace_name "UnsponsoredDepositaryReceipt" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/hasNumberOfDepositaryReceiptsIssued"></see>
    /// </summary>
    let hasNumberOfDepositaryReceiptsIssued =
        Namespaced_IRI.parse _namespace_name "hasNumberOfDepositaryReceiptsIssued" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/hasTradedShare"></see>
    /// </summary>
    let hasTradedShare =
        Namespaced_IRI.parse _namespace_name "hasTradedShare" |> NamespacedName
