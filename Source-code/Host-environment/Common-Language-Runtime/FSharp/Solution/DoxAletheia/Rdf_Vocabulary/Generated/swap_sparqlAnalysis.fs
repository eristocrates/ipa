namespace http.eulersharp.sourceforge.net._2003._03swap.sparqlAnalysis.hash

open DoxAletheia.Rdf_Vocabulary

module swap_sparqlAnalysis =
    let _namespace_name =
        "http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis#"

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis#AnalysisQuery"></see>
    /// </summary>
    let AnalysisQuery =
        Namespaced_IRI.parse _namespace_name "AnalysisQuery" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis#CancelledClinicalAnalysisQuery"></see>
    /// </summary>
    let CancelledClinicalAnalysisQuery =
        Namespaced_IRI.parse _namespace_name "CancelledClinicalAnalysisQuery" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis#ClinicalAnalysisQuery"></see>
    /// </summary>
    let ClinicalAnalysisQuery =
        Namespaced_IRI.parse _namespace_name "ClinicalAnalysisQuery" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis#hasDataSetQuery"></see>
    /// </summary>
    let hasDataSetQuery =
        Namespaced_IRI.parse _namespace_name "hasDataSetQuery" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis#ClinicalDataSetQuery"></see>
    /// </summary>
    let ClinicalDataSetQuery =
        Namespaced_IRI.parse _namespace_name "ClinicalDataSetQuery" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis#ClinicalAnalysisResult"></see>
    /// </summary>
    let ClinicalAnalysisResult =
        Namespaced_IRI.parse _namespace_name "ClinicalAnalysisResult" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis#ClinicalDataRepository"></see>
    /// </summary>
    let ClinicalDataRepository =
        Namespaced_IRI.parse _namespace_name "ClinicalDataRepository" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis#DataRepository"></see>
    /// </summary>
    let DataRepository =
        Namespaced_IRI.parse _namespace_name "DataRepository" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis#DataSetQuery"></see>
    /// </summary>
    let DataSetQuery =
        Namespaced_IRI.parse _namespace_name "DataSetQuery" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis#CompletedClinicalAnalysisQuery"></see>
    /// </summary>
    let CompletedClinicalAnalysisQuery =
        Namespaced_IRI.parse _namespace_name "CompletedClinicalAnalysisQuery" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis#InvalidClinicalAnalysisResult"></see>
    /// </summary>
    let InvalidClinicalAnalysisResult =
        Namespaced_IRI.parse _namespace_name "InvalidClinicalAnalysisResult" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis#InvalidClinicalDataSetQuery"></see>
    /// </summary>
    let InvalidClinicalDataSetQuery =
        Namespaced_IRI.parse _namespace_name "InvalidClinicalDataSetQuery" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis#SubmittedClinicalAnalysisQuery"></see>
    /// </summary>
    let SubmittedClinicalAnalysisQuery =
        Namespaced_IRI.parse _namespace_name "SubmittedClinicalAnalysisQuery" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis#dataRepositoryOf"></see>
    /// </summary>
    let dataRepositoryOf =
        Namespaced_IRI.parse _namespace_name "dataRepositoryOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis#hasDataRepository"></see>
    /// </summary>
    let hasDataRepository =
        Namespaced_IRI.parse _namespace_name "hasDataRepository" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis#dataSetQueryOf"></see>
    /// </summary>
    let dataSetQueryOf =
        Namespaced_IRI.parse _namespace_name "dataSetQueryOf" |> NamespacedName
