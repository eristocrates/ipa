namespace http.eulersharp.sourceforge.net._2003._03swap.sparqlAnalysis.hash

open DoxAletheia

module swap_sparqlAnalysis =
    let _namespace_name =
        "http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis#AnalysisQuery"></see>
    /// </summary>
    let AnalysisQuery = _prefix "AnalysisQuery"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis#CancelledClinicalAnalysisQuery"></see>
    /// </summary>
    let CancelledClinicalAnalysisQuery = _prefix "CancelledClinicalAnalysisQuery"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis#ClinicalAnalysisQuery"></see>
    /// </summary>
    let ClinicalAnalysisQuery = _prefix "ClinicalAnalysisQuery"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis#hasDataSetQuery"></see>
    /// </summary>
    let hasDataSetQuery = _prefix "hasDataSetQuery"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis#ClinicalDataSetQuery"></see>
    /// </summary>
    let ClinicalDataSetQuery = _prefix "ClinicalDataSetQuery"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis#ClinicalAnalysisResult"></see>
    /// </summary>
    let ClinicalAnalysisResult = _prefix "ClinicalAnalysisResult"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis#ClinicalDataRepository"></see>
    /// </summary>
    let ClinicalDataRepository = _prefix "ClinicalDataRepository"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis#DataRepository"></see>
    /// </summary>
    let DataRepository = _prefix "DataRepository"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis#DataSetQuery"></see>
    /// </summary>
    let DataSetQuery = _prefix "DataSetQuery"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis#CompletedClinicalAnalysisQuery"></see>
    /// </summary>
    let CompletedClinicalAnalysisQuery = _prefix "CompletedClinicalAnalysisQuery"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis#InvalidClinicalAnalysisResult"></see>
    /// </summary>
    let InvalidClinicalAnalysisResult = _prefix "InvalidClinicalAnalysisResult"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis#InvalidClinicalDataSetQuery"></see>
    /// </summary>
    let InvalidClinicalDataSetQuery = _prefix "InvalidClinicalDataSetQuery"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis#SubmittedClinicalAnalysisQuery"></see>
    /// </summary>
    let SubmittedClinicalAnalysisQuery = _prefix "SubmittedClinicalAnalysisQuery"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis#dataRepositoryOf"></see>
    /// </summary>
    let dataRepositoryOf = _prefix "dataRepositoryOf"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis#hasDataRepository"></see>
    /// </summary>
    let hasDataRepository = _prefix "hasDataRepository"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis#dataSetQueryOf"></see>
    /// </summary>
    let dataSetQueryOf = _prefix "dataSetQueryOf"
