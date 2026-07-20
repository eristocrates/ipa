namespace https.spec.edmcouncil.org.fibo.ontology.SEC.Equities.DepositaryReceipts.slash

open DoxAletheia

module fibo_sec_eq_dr =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/AmericanDepositaryReceipt"></see>
    /// </summary>
    let AmericanDepositaryReceipt = _prefix "AmericanDepositaryReceipt"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/DepositaryReceipt"></see>
    /// </summary>
    let DepositaryReceipt = _prefix "DepositaryReceipt"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/AmericanDepositaryReceiptLevel"></see>
    /// </summary>
    let AmericanDepositaryReceiptLevel = _prefix "AmericanDepositaryReceiptLevel"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/AmericanDepositaryReceiptLevelScheme"></see>
    /// </summary>
    let AmericanDepositaryReceiptLevelScheme =
        _prefix "AmericanDepositaryReceiptLevelScheme"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/ChineseDepositaryReceipt"></see>
    /// </summary>
    let ChineseDepositaryReceipt = _prefix "ChineseDepositaryReceipt"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/GlobalDepositaryReceipt"></see>
    /// </summary>
    let GlobalDepositaryReceipt = _prefix "GlobalDepositaryReceipt"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/hasMultiplier"></see>
    /// </summary>
    let hasMultiplier = _prefix "hasMultiplier"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/hasTradedSecurity"></see>
    /// </summary>
    let hasTradedSecurity = _prefix "hasTradedSecurity"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/EuropeanDepositaryReceipt"></see>
    /// </summary>
    let EuropeanDepositaryReceipt = _prefix "EuropeanDepositaryReceipt"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/HongKongDepositaryReceipt"></see>
    /// </summary>
    let HongKongDepositaryReceipt = _prefix "HongKongDepositaryReceipt"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/IndianDepositoryReceipt"></see>
    /// </summary>
    let IndianDepositoryReceipt = _prefix "IndianDepositoryReceipt"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/JapaneseDepositaryReceipt"></see>
    /// </summary>
    let JapaneseDepositaryReceipt = _prefix "JapaneseDepositaryReceipt"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/LevelIAmericanDepositaryReceipt"></see>
    /// </summary>
    let LevelIAmericanDepositaryReceipt = _prefix "LevelIAmericanDepositaryReceipt"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/LevelIIAmericanDepositaryReceipt"></see>
    /// </summary>
    let LevelIIAmericanDepositaryReceipt = _prefix "LevelIIAmericanDepositaryReceipt"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/LevelIIIAmericanDepositaryReceipt"></see>
    /// </summary>
    let LevelIIIAmericanDepositaryReceipt = _prefix "LevelIIIAmericanDepositaryReceipt"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/LuxembourgDepositaryReceipt"></see>
    /// </summary>
    let LuxembourgDepositaryReceipt = _prefix "LuxembourgDepositaryReceipt"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/OffshoreDepositaryReceipt"></see>
    /// </summary>
    let OffshoreDepositaryReceipt = _prefix "OffshoreDepositaryReceipt"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/SponsoredDepositaryReceipt"></see>
    /// </summary>
    let SponsoredDepositaryReceipt = _prefix "SponsoredDepositaryReceipt"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/ParticipatoryNote"></see>
    /// </summary>
    let ParticipatoryNote = _prefix "ParticipatoryNote"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/PrivatelyPlacedDepositaryReceipt"></see>
    /// </summary>
    let PrivatelyPlacedDepositaryReceipt = _prefix "PrivatelyPlacedDepositaryReceipt"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/UnsponsoredDepositaryReceipt"></see>
    /// </summary>
    let UnsponsoredDepositaryReceipt = _prefix "UnsponsoredDepositaryReceipt"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/hasNumberOfDepositaryReceiptsIssued"></see>
    /// </summary>
    let hasNumberOfDepositaryReceiptsIssued =
        _prefix "hasNumberOfDepositaryReceiptsIssued"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/hasTradedShare"></see>
    /// </summary>
    let hasTradedShare = _prefix "hasTradedShare"
