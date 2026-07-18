namespace http.eulersharp.sourceforge.net._2003._03swap.sparqlAnalysisTemplate.hash

open DoxAletheia.Rdf_Vocabulary

module swap_sparqlAnalysisTemplate =
    let _namespace_name =
        "http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysisTemplate#"

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysisTemplate#AnalysisResultBinding"></see>
    /// </summary>
    let AnalysisResultBinding =
        Namespaced_IRI.parse _namespace_name "AnalysisResultBinding" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysisTemplate#ClinicalAnalysisQueryTemplate"></see>
    /// </summary>
    let ClinicalAnalysisQueryTemplate =
        Namespaced_IRI.parse _namespace_name "ClinicalAnalysisQueryTemplate" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysisTemplate#ClinicalAnalysisQueryTemplateBinding"></see>
    /// </summary>
    let ClinicalAnalysisQueryTemplateBinding =
        Namespaced_IRI.parse _namespace_name "ClinicalAnalysisQueryTemplateBinding" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysisTemplate#ClinicalAnalysisResultBinding"></see>
    /// </summary>
    let ClinicalAnalysisResultBinding =
        Namespaced_IRI.parse _namespace_name "ClinicalAnalysisResultBinding" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysisTemplate#resultBindingOf"></see>
    /// </summary>
    let resultBindingOf =
        Namespaced_IRI.parse _namespace_name "resultBindingOf" |> NamespacedName
