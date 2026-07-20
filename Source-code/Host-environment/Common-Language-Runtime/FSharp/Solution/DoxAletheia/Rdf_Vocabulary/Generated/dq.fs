namespace http.def.seegrid.csiro.au.isotc211.iso19115._2003.dataquality.hash

open DoxAletheia

module dq =
    let _namespace_name =
        "http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#CompletenessOmission"></see>
    /// </summary>
    let CompletenessOmission = _prefix "CompletenessOmission"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#DataQuality"></see>
    /// </summary>
    let DataQuality = _prefix "DataQuality"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#Result"></see>
    /// </summary>
    let Result = _prefix "Result"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#level"></see>
    /// </summary>
    let level = _prefix "level"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#lineage"></see>
    /// </summary>
    let lineage = _prefix "lineage"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#GriddedDataPositionalAccuracy"></see>
    /// </summary>
    let GriddedDataPositionalAccuracy = _prefix "GriddedDataPositionalAccuracy"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#CompletenessCommission"></see>
    /// </summary>
    let CompletenessCommission = _prefix "CompletenessCommission"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#AccuracyOfATimeMeasurement"></see>
    /// </summary>
    let AccuracyOfATimeMeasurement = _prefix "AccuracyOfATimeMeasurement"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#QuantitativeAttributeAccuracy"></see>
    /// </summary>
    let QuantitativeAttributeAccuracy = _prefix "QuantitativeAttributeAccuracy"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#evaluationMethodType"></see>
    /// </summary>
    let evaluationMethodType = _prefix "evaluationMethodType"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#errorStatistic"></see>
    /// </summary>
    let errorStatistic = _prefix "errorStatistic"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#FormatConsistency"></see>
    /// </summary>
    let FormatConsistency = _prefix "FormatConsistency"

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#RelativeInternalPositionalAccuracy"></see>
    /// </summary>
    let RelativeInternalPositionalAccuracy =
        _prefix "RelativeInternalPositionalAccuracy"

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#nameOfMeasure"></see>
    /// </summary>
    let nameOfMeasure = _prefix "nameOfMeasure"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#measureDescription"></see>
    /// </summary>
    let measureDescription = _prefix "measureDescription"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#TopologicalConsistency"></see>
    /// </summary>
    let TopologicalConsistency = _prefix "TopologicalConsistency"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#LogicalConsistency"></see>
    /// </summary>
    let LogicalConsistency = _prefix "LogicalConsistency"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#report"></see>
    /// </summary>
    let report = _prefix "report"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#TemporalAccuracy"></see>
    /// </summary>
    let TemporalAccuracy = _prefix "TemporalAccuracy"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#QuantitativeResult"></see>
    /// </summary>
    let QuantitativeResult = _prefix "QuantitativeResult"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#ConceptualConsistency"></see>
    /// </summary>
    let ConceptualConsistency = _prefix "ConceptualConsistency"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#ThematicClassificationCorrectness"></see>
    /// </summary>
    let ThematicClassificationCorrectness = _prefix "ThematicClassificationCorrectness"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#evaluationMethodDescription"></see>
    /// </summary>
    let evaluationMethodDescription = _prefix "evaluationMethodDescription"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#levelDescription"></see>
    /// </summary>
    let levelDescription = _prefix "levelDescription"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#ConformanceResult"></see>
    /// </summary>
    let ConformanceResult = _prefix "ConformanceResult"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#valueType"></see>
    /// </summary>
    let valueType = _prefix "valueType"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#pass"></see>
    /// </summary>
    let pass = _prefix "pass"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#TemporalConsistency"></see>
    /// </summary>
    let TemporalConsistency = _prefix "TemporalConsistency"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#NonQuantitativeAttributeAccuracy"></see>
    /// </summary>
    let NonQuantitativeAttributeAccuracy = _prefix "NonQuantitativeAttributeAccuracy"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#dateTime"></see>
    /// </summary>
    let dateTime = _prefix "dateTime"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#measureIdentification"></see>
    /// </summary>
    let measureIdentification = _prefix "measureIdentification"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#value"></see>
    /// </summary>
    let value = _prefix "value"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#DomainConsistency"></see>
    /// </summary>
    let DomainConsistency = _prefix "DomainConsistency"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#explanation"></see>
    /// </summary>
    let explanation = _prefix "explanation"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#extent"></see>
    /// </summary>
    let extent = _prefix "extent"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#PositionalAccuracy"></see>
    /// </summary>
    let PositionalAccuracy = _prefix "PositionalAccuracy"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#EvaluationMethodTypeCode"></see>
    /// </summary>
    let EvaluationMethodTypeCode = _prefix "EvaluationMethodTypeCode"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#scope"></see>
    /// </summary>
    let scope = _prefix "scope"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#TemporalValidity"></see>
    /// </summary>
    let TemporalValidity = _prefix "TemporalValidity"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#specification"></see>
    /// </summary>
    let specification = _prefix "specification"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#Element"></see>
    /// </summary>
    let Element = _prefix "Element"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#Scope"></see>
    /// </summary>
    let Scope = _prefix "Scope"

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#AbsoluteExternalPositionalAccuracy"></see>
    /// </summary>
    let AbsoluteExternalPositionalAccuracy =
        _prefix "AbsoluteExternalPositionalAccuracy"

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#evaluationProcedure"></see>
    /// </summary>
    let evaluationProcedure = _prefix "evaluationProcedure"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#Completeness"></see>
    /// </summary>
    let Completeness = _prefix "Completeness"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#result"></see>
    /// </summary>
    let result = _prefix "result"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#ThematicAccuracy"></see>
    /// </summary>
    let ThematicAccuracy = _prefix "ThematicAccuracy"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#valueUnit"></see>
    /// </summary>
    let valueUnit = _prefix "valueUnit"
