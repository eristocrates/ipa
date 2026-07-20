namespace https.spec.edmcouncil.org.fibo.ontology.SEC.Securities.SecuritiesClassification.slash

open DoxAletheia

module fibo_sec_sec_cls =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesClassification/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesClassification/FinancialInstrumentClassifier"></see>
    /// </summary>
    let FinancialInstrumentClassifier = _prefix "FinancialInstrumentClassifier"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesClassification/AssetClass"></see>
    /// </summary>
    let AssetClass = _prefix "AssetClass"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesClassification/ClassificationOfFinancialInstrumentsCodeScheme"></see>
    /// </summary>
    let ClassificationOfFinancialInstrumentsCodeScheme =
        _prefix "ClassificationOfFinancialInstrumentsCodeScheme"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesClassification/FinancialInstrumentClassificationScheme"></see>
    /// </summary>
    let FinancialInstrumentClassificationScheme =
        _prefix "FinancialInstrumentClassificationScheme"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesClassification/FinancialInstrumentClassificationCode"></see>
    /// </summary>
    let FinancialInstrumentClassificationCode =
        _prefix "FinancialInstrumentClassificationCode"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesClassification/GlobalIndustryClassificationStandardsClassifier"></see>
    /// </summary>
    let GlobalIndustryClassificationStandardsClassifier =
        _prefix "GlobalIndustryClassificationStandardsClassifier"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesClassification/GlobalIndustryClassificationStandardsScheme"></see>
    /// </summary>
    let GlobalIndustryClassificationStandardsScheme =
        _prefix "GlobalIndustryClassificationStandardsScheme"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesClassification/ISO10962-201910-CodeScheme"></see>
    /// </summary>
    let ``ISO10962-201910-CodeScheme`` = _prefix "ISO10962-201910-CodeScheme"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesClassification/IndustryClassificationBenchmarkClassifier"></see>
    /// </summary>
    let IndustryClassificationBenchmarkClassifier =
        _prefix "IndustryClassificationBenchmarkClassifier"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesClassification/IndustryClassificationBenchmarkScheme"></see>
    /// </summary>
    let IndustryClassificationBenchmarkScheme =
        _prefix "IndustryClassificationBenchmarkScheme"
