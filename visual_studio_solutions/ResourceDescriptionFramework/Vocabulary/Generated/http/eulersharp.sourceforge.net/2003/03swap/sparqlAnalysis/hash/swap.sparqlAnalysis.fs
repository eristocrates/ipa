namespace Swap.sparqlAnalysis.Namespace
module sparqlAnalysis =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis#" (Some "http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis") (Some "swap.sparqlAnalysis") None
    let AnalysisQuery = {_prefixID with _localName = "AnalysisQuery"}
    let CancelledClinicalAnalysisQuery = {_prefixID with _localName = "CancelledClinicalAnalysisQuery"}
    let ClinicalAnalysisQuery = {_prefixID with _localName = "ClinicalAnalysisQuery"}
    let ClinicalAnalysisResult = {_prefixID with _localName = "ClinicalAnalysisResult"}
    let ClinicalDataRepository = {_prefixID with _localName = "ClinicalDataRepository"}
    let ClinicalDataSetQuery = {_prefixID with _localName = "ClinicalDataSetQuery"}
    let CompletedClinicalAnalysisQuery = {_prefixID with _localName = "CompletedClinicalAnalysisQuery"}
    let DataRepository = {_prefixID with _localName = "DataRepository"}
    let DataSetQuery = {_prefixID with _localName = "DataSetQuery"}
    let InvalidClinicalAnalysisResult = {_prefixID with _localName = "InvalidClinicalAnalysisResult"}
    let InvalidClinicalDataSetQuery = {_prefixID with _localName = "InvalidClinicalDataSetQuery"}
    let SubmittedClinicalAnalysisQuery = {_prefixID with _localName = "SubmittedClinicalAnalysisQuery"}
    let dataRepositoryOf = {_prefixID with _localName = "dataRepositoryOf"}
    let dataSetQueryOf = {_prefixID with _localName = "dataSetQueryOf"}
    let hasDataRepository = {_prefixID with _localName = "hasDataRepository"}
    let hasDataSetQuery = {_prefixID with _localName = "hasDataSetQuery"}