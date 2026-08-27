namespace https.spec.edmcouncil.org.fibo.ontology.SEC.Equities.DepositaryReceipts.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_sec_eq_dr =
    let _namespace_iri = Namespace_Iri fibo_sec_eq_dr |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-sec-eq-dr:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Depositary Receipts"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_sec_eq_dr, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-dr:AmericanDepositaryReceipt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"American depositary receipt"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/AmericanDepositaryReceipt">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/AmericanDepositaryReceipt</seealso>
    let AmericanDepositaryReceipt =
        Prefixed_Name(fibo_sec_eq_dr, "AmericanDepositaryReceipt") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-dr:AmericanDepositaryReceiptLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"American depositary receipt level"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/AmericanDepositaryReceiptLevel">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/AmericanDepositaryReceiptLevel</seealso>
    let AmericanDepositaryReceiptLevel =
        Prefixed_Name(fibo_sec_eq_dr, "AmericanDepositaryReceiptLevel") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-dr:AmericanDepositaryReceiptLevelScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"American depositary receipt level scheme"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/AmericanDepositaryReceiptLevelScheme">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/AmericanDepositaryReceiptLevelScheme</seealso>
    let AmericanDepositaryReceiptLevelScheme =
        Prefixed_Name(fibo_sec_eq_dr, "AmericanDepositaryReceiptLevelScheme") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-dr:ChineseDepositaryReceipt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Chinese depositary receipt"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/ChineseDepositaryReceipt">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/ChineseDepositaryReceipt</seealso>
    let ChineseDepositaryReceipt =
        Prefixed_Name(fibo_sec_eq_dr, "ChineseDepositaryReceipt") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-dr:DepositaryReceipt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"depositary receipt"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/DepositaryReceipt">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/DepositaryReceipt</seealso>
    let DepositaryReceipt =
        Prefixed_Name(fibo_sec_eq_dr, "DepositaryReceipt") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-dr:EuropeanDepositaryReceipt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"European depositary receipt"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/EuropeanDepositaryReceipt">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/EuropeanDepositaryReceipt</seealso>
    let EuropeanDepositaryReceipt =
        Prefixed_Name(fibo_sec_eq_dr, "EuropeanDepositaryReceipt") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-dr:GlobalDepositaryReceipt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"global depositary receipt"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/GlobalDepositaryReceipt">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/GlobalDepositaryReceipt</seealso>
    let GlobalDepositaryReceipt =
        Prefixed_Name(fibo_sec_eq_dr, "GlobalDepositaryReceipt") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-dr:HongKongDepositaryReceipt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Hong Kong depositary receipt"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/HongKongDepositaryReceipt">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/HongKongDepositaryReceipt</seealso>
    let HongKongDepositaryReceipt =
        Prefixed_Name(fibo_sec_eq_dr, "HongKongDepositaryReceipt") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-dr:IndianDepositoryReceipt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Indian depositary receipt"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/IndianDepositoryReceipt">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/IndianDepositoryReceipt</seealso>
    let IndianDepositoryReceipt =
        Prefixed_Name(fibo_sec_eq_dr, "IndianDepositoryReceipt") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-dr:JapaneseDepositaryReceipt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Japanese depositary receipt"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/JapaneseDepositaryReceipt">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/JapaneseDepositaryReceipt</seealso>
    let JapaneseDepositaryReceipt =
        Prefixed_Name(fibo_sec_eq_dr, "JapaneseDepositaryReceipt") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-dr:LevelIAmericanDepositaryReceipt</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-sec-eq-dr:AmericanDepositaryReceiptLevel</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Level I American depositary receipt"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/LevelIAmericanDepositaryReceipt">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/LevelIAmericanDepositaryReceipt</seealso>
    let LevelIAmericanDepositaryReceipt =
        Prefixed_Name(fibo_sec_eq_dr, "LevelIAmericanDepositaryReceipt") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-dr:LevelIIAmericanDepositaryReceipt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-sec-eq-dr:AmericanDepositaryReceiptLevel</para>
    ///
    /// labels<para>"Level II American depositary receipt"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/LevelIIAmericanDepositaryReceipt">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/LevelIIAmericanDepositaryReceipt</seealso>
    let LevelIIAmericanDepositaryReceipt =
        Prefixed_Name(fibo_sec_eq_dr, "LevelIIAmericanDepositaryReceipt") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-dr:LevelIIIAmericanDepositaryReceipt</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-sec-eq-dr:AmericanDepositaryReceiptLevel</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Level III American depositary receipt"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/LevelIIIAmericanDepositaryReceipt">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/LevelIIIAmericanDepositaryReceipt</seealso>
    let LevelIIIAmericanDepositaryReceipt =
        Prefixed_Name(fibo_sec_eq_dr, "LevelIIIAmericanDepositaryReceipt") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-dr:LuxembourgDepositaryReceipt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Luxembourg depositary receipt"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/LuxembourgDepositaryReceipt">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/LuxembourgDepositaryReceipt</seealso>
    let LuxembourgDepositaryReceipt =
        Prefixed_Name(fibo_sec_eq_dr, "LuxembourgDepositaryReceipt") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-dr:OffshoreDepositaryReceipt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"offshore depositary receipt"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/OffshoreDepositaryReceipt">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/OffshoreDepositaryReceipt</seealso>
    let OffshoreDepositaryReceipt =
        Prefixed_Name(fibo_sec_eq_dr, "OffshoreDepositaryReceipt") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-dr:ParticipatoryNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"participatory note"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/ParticipatoryNote">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/ParticipatoryNote</seealso>
    let ParticipatoryNote =
        Prefixed_Name(fibo_sec_eq_dr, "ParticipatoryNote") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-dr:PrivatelyPlacedDepositaryReceipt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"privately placed depositary receipt"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/PrivatelyPlacedDepositaryReceipt">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/PrivatelyPlacedDepositaryReceipt</seealso>
    let PrivatelyPlacedDepositaryReceipt =
        Prefixed_Name(fibo_sec_eq_dr, "PrivatelyPlacedDepositaryReceipt") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-dr:SponsoredDepositaryReceipt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"sponsored depositary receipt"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/SponsoredDepositaryReceipt">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/SponsoredDepositaryReceipt</seealso>
    let SponsoredDepositaryReceipt =
        Prefixed_Name(fibo_sec_eq_dr, "SponsoredDepositaryReceipt") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-dr:UnsponsoredDepositaryReceipt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"unsponsored depositary receipt"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/UnsponsoredDepositaryReceipt">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/UnsponsoredDepositaryReceipt</seealso>
    let UnsponsoredDepositaryReceipt =
        Prefixed_Name(fibo_sec_eq_dr, "UnsponsoredDepositaryReceipt") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-dr:hasMultiplier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has multiplier"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/hasMultiplier">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/hasMultiplier</seealso>
    let hasMultiplier = Prefixed_Name(fibo_sec_eq_dr, "hasMultiplier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-dr:hasNumberOfDepositaryReceiptsIssued</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has number of depositary receipts issued"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/hasNumberOfDepositaryReceiptsIssued">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/hasNumberOfDepositaryReceiptsIssued</seealso>
    let hasNumberOfDepositaryReceiptsIssued =
        Prefixed_Name(fibo_sec_eq_dr, "hasNumberOfDepositaryReceiptsIssued") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-dr:hasTradedSecurity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has traded security"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/hasTradedSecurity">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/hasTradedSecurity</seealso>
    let hasTradedSecurity =
        Prefixed_Name(fibo_sec_eq_dr, "hasTradedSecurity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-dr:hasTradedShare</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has traded share"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/hasTradedShare">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/hasTradedShare</seealso>
    let hasTradedShare = Prefixed_Name(fibo_sec_eq_dr, "hasTradedShare") |> PrefixedName
