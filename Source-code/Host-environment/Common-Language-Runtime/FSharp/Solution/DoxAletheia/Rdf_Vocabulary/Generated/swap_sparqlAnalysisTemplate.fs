namespace http.eulersharp.sourceforge.net._2003._03swap.sparqlAnalysisTemplate.hash

open DoxAletheia

module swap_sparqlAnalysisTemplate =
    let _namespace_name =
        "http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysisTemplate#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysisTemplate#AnalysisResultBinding"></see>
    /// </summary>
    let AnalysisResultBinding = _prefix "AnalysisResultBinding"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysisTemplate#ClinicalAnalysisQueryTemplate"></see>
    /// </summary>
    let ClinicalAnalysisQueryTemplate = _prefix "ClinicalAnalysisQueryTemplate"

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysisTemplate#ClinicalAnalysisQueryTemplateBinding"></see>
    /// </summary>
    let ClinicalAnalysisQueryTemplateBinding =
        _prefix "ClinicalAnalysisQueryTemplateBinding"

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysisTemplate#ClinicalAnalysisResultBinding"></see>
    /// </summary>
    let ClinicalAnalysisResultBinding = _prefix "ClinicalAnalysisResultBinding"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysisTemplate#resultBindingOf"></see>
    /// </summary>
    let resultBindingOf = _prefix "resultBindingOf"
