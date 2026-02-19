namespace Swap.sparqlAnalysisTemplate.Namespace
module sparqlAnalysisTemplate =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysisTemplate#" (Some "http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysisTemplate") (Some "swap.sparqlAnalysisTemplate") None
    let AnalysisResultBinding = {_prefixID with _localName = "AnalysisResultBinding"}
    let ClinicalAnalysisQueryTemplate = {_prefixID with _localName = "ClinicalAnalysisQueryTemplate"}
    let ClinicalAnalysisQueryTemplateBinding = {_prefixID with _localName = "ClinicalAnalysisQueryTemplateBinding"}
    let ClinicalAnalysisResultBinding = {_prefixID with _localName = "ClinicalAnalysisResultBinding"}
    let resultBindingOf = {_prefixID with _localName = "resultBindingOf"}