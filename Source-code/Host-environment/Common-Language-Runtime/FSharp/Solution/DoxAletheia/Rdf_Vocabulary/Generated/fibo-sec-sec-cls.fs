namespace https.spec.edmcouncil.org.fibo.ontology.SEC.Securities.SecuritiesClassification.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_sec_sec_cls =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesClassification/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesClassification/FinancialInstrumentClassifier"></see>
    /// </summary>
    let FinancialInstrumentClassifier =
        Namespaced_IRI.parse _namespace_name "FinancialInstrumentClassifier" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesClassification/AssetClass"></see>
    /// </summary>
    let AssetClass = Namespaced_IRI.parse _namespace_name "AssetClass" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesClassification/ClassificationOfFinancialInstrumentsCodeScheme"></see>
    /// </summary>
    let ClassificationOfFinancialInstrumentsCodeScheme =
        Namespaced_IRI.parse _namespace_name "ClassificationOfFinancialInstrumentsCodeScheme" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesClassification/FinancialInstrumentClassificationScheme"></see>
    /// </summary>
    let FinancialInstrumentClassificationScheme =
        Namespaced_IRI.parse _namespace_name "FinancialInstrumentClassificationScheme" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesClassification/FinancialInstrumentClassificationCode"></see>
    /// </summary>
    let FinancialInstrumentClassificationCode =
        Namespaced_IRI.parse _namespace_name "FinancialInstrumentClassificationCode" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesClassification/GlobalIndustryClassificationStandardsClassifier"></see>
    /// </summary>
    let GlobalIndustryClassificationStandardsClassifier =
        Namespaced_IRI.parse _namespace_name "GlobalIndustryClassificationStandardsClassifier" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesClassification/GlobalIndustryClassificationStandardsScheme"></see>
    /// </summary>
    let GlobalIndustryClassificationStandardsScheme =
        Namespaced_IRI.parse _namespace_name "GlobalIndustryClassificationStandardsScheme" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesClassification/ISO10962-201910-CodeScheme"></see>
    /// </summary>
    let ``ISO10962-201910-CodeScheme`` =
        Namespaced_IRI.parse _namespace_name "ISO10962-201910-CodeScheme" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesClassification/IndustryClassificationBenchmarkClassifier"></see>
    /// </summary>
    let IndustryClassificationBenchmarkClassifier =
        Namespaced_IRI.parse _namespace_name "IndustryClassificationBenchmarkClassifier" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesClassification/IndustryClassificationBenchmarkScheme"></see>
    /// </summary>
    let IndustryClassificationBenchmarkScheme =
        Namespaced_IRI.parse _namespace_name "IndustryClassificationBenchmarkScheme" |> NamespacedName
