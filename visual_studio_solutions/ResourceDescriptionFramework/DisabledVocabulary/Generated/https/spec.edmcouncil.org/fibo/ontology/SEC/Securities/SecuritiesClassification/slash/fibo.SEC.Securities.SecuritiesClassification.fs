namespace Fibo.SEC.Securities.SecuritiesClassification.Namespace
module SecuritiesClassification =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesClassification/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/SEC/Securities/SecuritiesClassification.rdf") (Some @"fibo.SEC.Securities.SecuritiesClassification") None
    let AssetClass = {_prefixID with _localName = "AssetClass"}
    let ClassificationOfFinancialInstrumentsCodeScheme = {_prefixID with _localName = "ClassificationOfFinancialInstrumentsCodeScheme"}
    let FinancialInstrumentClassificationCode = {_prefixID with _localName = "FinancialInstrumentClassificationCode"}
    let FinancialInstrumentClassificationScheme = {_prefixID with _localName = "FinancialInstrumentClassificationScheme"}
    let FinancialInstrumentClassifier = {_prefixID with _localName = "FinancialInstrumentClassifier"}
    let GlobalIndustryClassificationStandardsClassifier = {_prefixID with _localName = "GlobalIndustryClassificationStandardsClassifier"}
    let GlobalIndustryClassificationStandardsScheme = {_prefixID with _localName = "GlobalIndustryClassificationStandardsScheme"}
    let ``ISO10962-201910-CodeScheme`` = {_prefixID with _localName = "ISO10962-201910-CodeScheme"}
    let IndustryClassificationBenchmarkClassifier = {_prefixID with _localName = "IndustryClassificationBenchmarkClassifier"}
    let IndustryClassificationBenchmarkScheme = {_prefixID with _localName = "IndustryClassificationBenchmarkScheme"}