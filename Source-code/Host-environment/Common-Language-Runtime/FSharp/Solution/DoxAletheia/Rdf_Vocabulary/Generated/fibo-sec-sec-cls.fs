namespace https.spec.edmcouncil.org.fibo.ontology.SEC.Securities.SecuritiesClassification.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_sec_sec_cls =
    let _namespace_iri = Namespace_Iri fibo_sec_sec_cls |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-sec-sec-cls:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Securities Classification Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesClassification/">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesClassification/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_sec_sec_cls, "") |> PrefixedName
    /// <summary>
    ///   <para>fibo-sec-sec-cls:AssetClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"asset class"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesClassification/AssetClass">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesClassification/AssetClass</seealso>
    let AssetClass = Prefixed_Name(fibo_sec_sec_cls, "AssetClass") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-cls:ClassificationOfFinancialInstrumentsCodeScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"classification of financial instruments code scheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesClassification/ClassificationOfFinancialInstrumentsCodeScheme">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesClassification/ClassificationOfFinancialInstrumentsCodeScheme</seealso>
    let ClassificationOfFinancialInstrumentsCodeScheme =
        Prefixed_Name(fibo_sec_sec_cls, "ClassificationOfFinancialInstrumentsCodeScheme") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-cls:FinancialInstrumentClassificationCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"financial instrument classification code"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesClassification/FinancialInstrumentClassificationCode">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesClassification/FinancialInstrumentClassificationCode</seealso>
    let FinancialInstrumentClassificationCode =
        Prefixed_Name(fibo_sec_sec_cls, "FinancialInstrumentClassificationCode") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-cls:FinancialInstrumentClassificationScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"financial instrument classification scheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesClassification/FinancialInstrumentClassificationScheme">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesClassification/FinancialInstrumentClassificationScheme</seealso>
    let FinancialInstrumentClassificationScheme =
        Prefixed_Name(fibo_sec_sec_cls, "FinancialInstrumentClassificationScheme") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-cls:FinancialInstrumentClassifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"financial instrument classifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesClassification/FinancialInstrumentClassifier">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesClassification/FinancialInstrumentClassifier</seealso>
    let FinancialInstrumentClassifier =
        Prefixed_Name(fibo_sec_sec_cls, "FinancialInstrumentClassifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-cls:GlobalIndustryClassificationStandardsClassifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Global Industry Classification Standards classifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesClassification/GlobalIndustryClassificationStandardsClassifier">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesClassification/GlobalIndustryClassificationStandardsClassifier</seealso>
    let GlobalIndustryClassificationStandardsClassifier =
        Prefixed_Name(fibo_sec_sec_cls, "GlobalIndustryClassificationStandardsClassifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-cls:GlobalIndustryClassificationStandardsScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-arr-cls:IndustrySectorClassificationScheme</para>
    ///
    /// labels<para>"Global Industry Classification Standards scheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesClassification/GlobalIndustryClassificationStandardsScheme">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesClassification/GlobalIndustryClassificationStandardsScheme</seealso>
    let GlobalIndustryClassificationStandardsScheme =
        Prefixed_Name(fibo_sec_sec_cls, "GlobalIndustryClassificationStandardsScheme") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-cls:ISO10962-201910-CodeScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-sec-sec-cls:ClassificationOfFinancialInstrumentsCodeScheme</para>
    ///
    /// labels<para>"ISO 10962 2019-10 code set"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesClassification/ISO10962-201910-CodeScheme">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesClassification/ISO10962-201910-CodeScheme</seealso>
    let ISO10962_201910_CodeScheme =
        Prefixed_Name(fibo_sec_sec_cls, "ISO10962-201910-CodeScheme") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-cls:IndustryClassificationBenchmarkClassifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"industry classification benchmark classifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesClassification/IndustryClassificationBenchmarkClassifier">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesClassification/IndustryClassificationBenchmarkClassifier</seealso>
    let IndustryClassificationBenchmarkClassifier =
        Prefixed_Name(fibo_sec_sec_cls, "IndustryClassificationBenchmarkClassifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-cls:IndustryClassificationBenchmarkScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-arr-cls:IndustrySectorClassificationScheme</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Industry Classification Benchmark scheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesClassification/IndustryClassificationBenchmarkScheme">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesClassification/IndustryClassificationBenchmarkScheme</seealso>
    let IndustryClassificationBenchmarkScheme =
        Prefixed_Name(fibo_sec_sec_cls, "IndustryClassificationBenchmarkScheme") |> PrefixedName
