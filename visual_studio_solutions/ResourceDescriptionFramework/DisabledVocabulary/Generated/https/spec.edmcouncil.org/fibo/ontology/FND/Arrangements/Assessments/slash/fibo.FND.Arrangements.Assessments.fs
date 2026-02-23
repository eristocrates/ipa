namespace Fibo.FND.Arrangements.Assessments.Namespace
module Assessments =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/FND/Arrangements/Assessments.rdf") (Some @"fibo.FND.Arrangements.Assessments") None
    let Appraisal = {_prefixID with _localName = "Appraisal"}
    let AppraisedValue = {_prefixID with _localName = "AppraisedValue"}
    let Appraiser = {_prefixID with _localName = "Appraiser"}
    let AssessmentActivity = {_prefixID with _localName = "AssessmentActivity"}
    let AssessmentEvent = {_prefixID with _localName = "AssessmentEvent"}
    let AssessmentReport = {_prefixID with _localName = "AssessmentReport"}
    let ExpectedValue = {_prefixID with _localName = "ExpectedValue"}
    let FairValue = {_prefixID with _localName = "FairValue"}
    let MarketValue = {_prefixID with _localName = "MarketValue"}
    let ObservedValue = {_prefixID with _localName = "ObservedValue"}
    let Opinion = {_prefixID with _localName = "Opinion"}
    let PresentValue = {_prefixID with _localName = "PresentValue"}
    let QualitativeValue = {_prefixID with _localName = "QualitativeValue"}
    let QuantitativeValue = {_prefixID with _localName = "QuantitativeValue"}
    let ReferenceValue = {_prefixID with _localName = "ReferenceValue"}
    let ValuationMethod = {_prefixID with _localName = "ValuationMethod"}
    let Value = {_prefixID with _localName = "Value"}
    let ValueAssessment = {_prefixID with _localName = "ValueAssessment"}
    let appliesMethodology = {_prefixID with _localName = "appliesMethodology"}
    let estimatesValueAt = {_prefixID with _localName = "estimatesValueAt"}
    let hasAppraiser = {_prefixID with _localName = "hasAppraiser"}
    let hasDateOfAssessment = {_prefixID with _localName = "hasDateOfAssessment"}
    let hasEstimatedValue = {_prefixID with _localName = "hasEstimatedValue"}
    let isEstimatedValueOf = {_prefixID with _localName = "isEstimatedValueOf"}