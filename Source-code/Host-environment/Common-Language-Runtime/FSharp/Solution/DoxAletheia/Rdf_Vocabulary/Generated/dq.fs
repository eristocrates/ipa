namespace http.def.seegrid.csiro.au.isotc211.iso19115._2003.dataquality.hash

open DoxAletheia.Rdf_Vocabulary

module dq =
    let _namespace_name =
        "http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#"

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#CompletenessOmission"></see>
    /// </summary>
    let CompletenessOmission =
        Namespaced_IRI.parse _namespace_name "CompletenessOmission" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#DataQuality"></see>
    /// </summary>
    let DataQuality =
        Namespaced_IRI.parse _namespace_name "DataQuality" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#Result"></see>
    /// </summary>
    let Result = Namespaced_IRI.parse _namespace_name "Result" |> NamespacedName
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#level"></see>
    /// </summary>
    let level = Namespaced_IRI.parse _namespace_name "level" |> NamespacedName
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#lineage"></see>
    /// </summary>
    let lineage = Namespaced_IRI.parse _namespace_name "lineage" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#GriddedDataPositionalAccuracy"></see>
    /// </summary>
    let GriddedDataPositionalAccuracy =
        Namespaced_IRI.parse _namespace_name "GriddedDataPositionalAccuracy" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#CompletenessCommission"></see>
    /// </summary>
    let CompletenessCommission =
        Namespaced_IRI.parse _namespace_name "CompletenessCommission" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#AccuracyOfATimeMeasurement"></see>
    /// </summary>
    let AccuracyOfATimeMeasurement =
        Namespaced_IRI.parse _namespace_name "AccuracyOfATimeMeasurement" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#QuantitativeAttributeAccuracy"></see>
    /// </summary>
    let QuantitativeAttributeAccuracy =
        Namespaced_IRI.parse _namespace_name "QuantitativeAttributeAccuracy" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#evaluationMethodType"></see>
    /// </summary>
    let evaluationMethodType =
        Namespaced_IRI.parse _namespace_name "evaluationMethodType" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#errorStatistic"></see>
    /// </summary>
    let errorStatistic =
        Namespaced_IRI.parse _namespace_name "errorStatistic" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#FormatConsistency"></see>
    /// </summary>
    let FormatConsistency =
        Namespaced_IRI.parse _namespace_name "FormatConsistency" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#RelativeInternalPositionalAccuracy"></see>
    /// </summary>
    let RelativeInternalPositionalAccuracy =
        Namespaced_IRI.parse _namespace_name "RelativeInternalPositionalAccuracy" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#nameOfMeasure"></see>
    /// </summary>
    let nameOfMeasure =
        Namespaced_IRI.parse _namespace_name "nameOfMeasure" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#measureDescription"></see>
    /// </summary>
    let measureDescription =
        Namespaced_IRI.parse _namespace_name "measureDescription" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#TopologicalConsistency"></see>
    /// </summary>
    let TopologicalConsistency =
        Namespaced_IRI.parse _namespace_name "TopologicalConsistency" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#LogicalConsistency"></see>
    /// </summary>
    let LogicalConsistency =
        Namespaced_IRI.parse _namespace_name "LogicalConsistency" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#report"></see>
    /// </summary>
    let report = Namespaced_IRI.parse _namespace_name "report" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#TemporalAccuracy"></see>
    /// </summary>
    let TemporalAccuracy =
        Namespaced_IRI.parse _namespace_name "TemporalAccuracy" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#QuantitativeResult"></see>
    /// </summary>
    let QuantitativeResult =
        Namespaced_IRI.parse _namespace_name "QuantitativeResult" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#ConceptualConsistency"></see>
    /// </summary>
    let ConceptualConsistency =
        Namespaced_IRI.parse _namespace_name "ConceptualConsistency" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#ThematicClassificationCorrectness"></see>
    /// </summary>
    let ThematicClassificationCorrectness =
        Namespaced_IRI.parse _namespace_name "ThematicClassificationCorrectness" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#evaluationMethodDescription"></see>
    /// </summary>
    let evaluationMethodDescription =
        Namespaced_IRI.parse _namespace_name "evaluationMethodDescription" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#levelDescription"></see>
    /// </summary>
    let levelDescription =
        Namespaced_IRI.parse _namespace_name "levelDescription" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#ConformanceResult"></see>
    /// </summary>
    let ConformanceResult =
        Namespaced_IRI.parse _namespace_name "ConformanceResult" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#valueType"></see>
    /// </summary>
    let valueType = Namespaced_IRI.parse _namespace_name "valueType" |> NamespacedName
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#pass"></see>
    /// </summary>
    let pass = Namespaced_IRI.parse _namespace_name "pass" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#TemporalConsistency"></see>
    /// </summary>
    let TemporalConsistency =
        Namespaced_IRI.parse _namespace_name "TemporalConsistency" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#NonQuantitativeAttributeAccuracy"></see>
    /// </summary>
    let NonQuantitativeAttributeAccuracy =
        Namespaced_IRI.parse _namespace_name "NonQuantitativeAttributeAccuracy" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#dateTime"></see>
    /// </summary>
    let dateTime = Namespaced_IRI.parse _namespace_name "dateTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#measureIdentification"></see>
    /// </summary>
    let measureIdentification =
        Namespaced_IRI.parse _namespace_name "measureIdentification" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#value"></see>
    /// </summary>
    let value = Namespaced_IRI.parse _namespace_name "value" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#DomainConsistency"></see>
    /// </summary>
    let DomainConsistency =
        Namespaced_IRI.parse _namespace_name "DomainConsistency" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#explanation"></see>
    /// </summary>
    let explanation =
        Namespaced_IRI.parse _namespace_name "explanation" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#extent"></see>
    /// </summary>
    let extent = Namespaced_IRI.parse _namespace_name "extent" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#PositionalAccuracy"></see>
    /// </summary>
    let PositionalAccuracy =
        Namespaced_IRI.parse _namespace_name "PositionalAccuracy" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#EvaluationMethodTypeCode"></see>
    /// </summary>
    let EvaluationMethodTypeCode =
        Namespaced_IRI.parse _namespace_name "EvaluationMethodTypeCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#scope"></see>
    /// </summary>
    let scope = Namespaced_IRI.parse _namespace_name "scope" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#TemporalValidity"></see>
    /// </summary>
    let TemporalValidity =
        Namespaced_IRI.parse _namespace_name "TemporalValidity" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#specification"></see>
    /// </summary>
    let specification =
        Namespaced_IRI.parse _namespace_name "specification" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#Element"></see>
    /// </summary>
    let Element = Namespaced_IRI.parse _namespace_name "Element" |> NamespacedName
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#Scope"></see>
    /// </summary>
    let Scope = Namespaced_IRI.parse _namespace_name "Scope" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#AbsoluteExternalPositionalAccuracy"></see>
    /// </summary>
    let AbsoluteExternalPositionalAccuracy =
        Namespaced_IRI.parse _namespace_name "AbsoluteExternalPositionalAccuracy" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#evaluationProcedure"></see>
    /// </summary>
    let evaluationProcedure =
        Namespaced_IRI.parse _namespace_name "evaluationProcedure" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#Completeness"></see>
    /// </summary>
    let Completeness =
        Namespaced_IRI.parse _namespace_name "Completeness" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#result"></see>
    /// </summary>
    let result = Namespaced_IRI.parse _namespace_name "result" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#ThematicAccuracy"></see>
    /// </summary>
    let ThematicAccuracy =
        Namespaced_IRI.parse _namespace_name "ThematicAccuracy" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#valueUnit"></see>
    /// </summary>
    let valueUnit = Namespaced_IRI.parse _namespace_name "valueUnit" |> NamespacedName
