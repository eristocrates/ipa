namespace http.def.seegrid.csiro.au.isotc211.iso19115._2003.dataquality.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module dq =
    let _namespace_iri = Namespace_Iri dq |> NamespaceIRI

    /// <summary>
    ///   <para>dq:AbsoluteExternalPositionalAccuracy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Absolute external positional accuracy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#AbsoluteExternalPositionalAccuracy">http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#AbsoluteExternalPositionalAccuracy</seealso>
    let AbsoluteExternalPositionalAccuracy =
        Prefixed_Name(dq, "AbsoluteExternalPositionalAccuracy") |> PrefixedName

    /// <summary>
    ///   <para>dq:AccuracyOfATimeMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Accuracy of a Time measurement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#AccuracyOfATimeMeasurement">http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#AccuracyOfATimeMeasurement</seealso>
    let AccuracyOfATimeMeasurement =
        Prefixed_Name(dq, "AccuracyOfATimeMeasurement") |> PrefixedName

    /// <summary>
    ///   <para>dq:Completeness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Completeness"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#Completeness">http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#Completeness</seealso>
    let Completeness = Prefixed_Name(dq, "Completeness") |> PrefixedName

    /// <summary>
    ///   <para>dq:CompletenessCommission</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Completeness commission"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#CompletenessCommission">http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#CompletenessCommission</seealso>
    let CompletenessCommission =
        Prefixed_Name(dq, "CompletenessCommission") |> PrefixedName

    /// <summary>
    ///   <para>dq:CompletenessOmission</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Completeness omission"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#CompletenessOmission">http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#CompletenessOmission</seealso>
    let CompletenessOmission = Prefixed_Name(dq, "CompletenessOmission") |> PrefixedName

    /// <summary>
    ///   <para>dq:ConceptualConsistency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Conceptual consistency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#ConceptualConsistency">http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#ConceptualConsistency</seealso>
    let ConceptualConsistency =
        Prefixed_Name(dq, "ConceptualConsistency") |> PrefixedName

    /// <summary>
    ///   <para>dq:ConformanceResult</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Conformance result"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#ConformanceResult">http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#ConformanceResult</seealso>
    let ConformanceResult = Prefixed_Name(dq, "ConformanceResult") |> PrefixedName
    /// <summary>
    ///   <para>dq:DataQuality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Data quality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#DataQuality">http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#DataQuality</seealso>
    let DataQuality = Prefixed_Name(dq, "DataQuality") |> PrefixedName
    /// <summary>
    ///   <para>dq:DomainConsistency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Domain consistency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#DomainConsistency">http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#DomainConsistency</seealso>
    let DomainConsistency = Prefixed_Name(dq, "DomainConsistency") |> PrefixedName
    /// <summary>
    ///   <para>dq:Element</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Element"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#Element">http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#Element</seealso>
    let Element = Prefixed_Name(dq, "Element") |> PrefixedName

    /// <summary>
    ///   <para>dq:EvaluationMethodTypeCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Evaluation method code"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#EvaluationMethodTypeCode">http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#EvaluationMethodTypeCode</seealso>
    let EvaluationMethodTypeCode =
        Prefixed_Name(dq, "EvaluationMethodTypeCode") |> PrefixedName

    /// <summary>
    ///   <para>dq:FormatConsistency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Format consistency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#FormatConsistency">http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#FormatConsistency</seealso>
    let FormatConsistency = Prefixed_Name(dq, "FormatConsistency") |> PrefixedName

    /// <summary>
    ///   <para>dq:GriddedDataPositionalAccuracy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Gridded data positional accuracy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#GriddedDataPositionalAccuracy">http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#GriddedDataPositionalAccuracy</seealso>
    let GriddedDataPositionalAccuracy =
        Prefixed_Name(dq, "GriddedDataPositionalAccuracy") |> PrefixedName

    /// <summary>
    ///   <para>dq:LogicalConsistency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Logical consistency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#LogicalConsistency">http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#LogicalConsistency</seealso>
    let LogicalConsistency = Prefixed_Name(dq, "LogicalConsistency") |> PrefixedName

    /// <summary>
    ///   <para>dq:NonQuantitativeAttributeAccuracy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Non quantitative attribute accuracy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#NonQuantitativeAttributeAccuracy">http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#NonQuantitativeAttributeAccuracy</seealso>
    let NonQuantitativeAttributeAccuracy =
        Prefixed_Name(dq, "NonQuantitativeAttributeAccuracy") |> PrefixedName

    /// <summary>
    ///   <para>dq:PositionalAccuracy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Positional accuracy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#PositionalAccuracy">http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#PositionalAccuracy</seealso>
    let PositionalAccuracy = Prefixed_Name(dq, "PositionalAccuracy") |> PrefixedName

    /// <summary>
    ///   <para>dq:QuantitativeAttributeAccuracy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Quantitative attribute accuracy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#QuantitativeAttributeAccuracy">http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#QuantitativeAttributeAccuracy</seealso>
    let QuantitativeAttributeAccuracy =
        Prefixed_Name(dq, "QuantitativeAttributeAccuracy") |> PrefixedName

    /// <summary>
    ///   <para>dq:QuantitativeResult</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Quantitative result"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#QuantitativeResult">http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#QuantitativeResult</seealso>
    let QuantitativeResult = Prefixed_Name(dq, "QuantitativeResult") |> PrefixedName

    /// <summary>
    ///   <para>dq:RelativeInternalPositionalAccuracy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Relative internal positional accuracy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#RelativeInternalPositionalAccuracy">http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#RelativeInternalPositionalAccuracy</seealso>
    let RelativeInternalPositionalAccuracy =
        Prefixed_Name(dq, "RelativeInternalPositionalAccuracy") |> PrefixedName

    /// <summary>
    ///   <para>dq:Result</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Result"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#Result">http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#Result</seealso>
    let Result = Prefixed_Name(dq, "Result") |> PrefixedName
    /// <summary>
    ///   <para>dq:Scope</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Scope"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#Scope">http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#Scope</seealso>
    let Scope = Prefixed_Name(dq, "Scope") |> PrefixedName
    /// <summary>
    ///   <para>dq:TemporalAccuracy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Temporal accuracy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#TemporalAccuracy">http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#TemporalAccuracy</seealso>
    let TemporalAccuracy = Prefixed_Name(dq, "TemporalAccuracy") |> PrefixedName
    /// <summary>
    ///   <para>dq:TemporalConsistency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Temporal consistency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#TemporalConsistency">http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#TemporalConsistency</seealso>
    let TemporalConsistency = Prefixed_Name(dq, "TemporalConsistency") |> PrefixedName
    /// <summary>
    ///   <para>dq:TemporalValidity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Temporal validity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#TemporalValidity">http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#TemporalValidity</seealso>
    let TemporalValidity = Prefixed_Name(dq, "TemporalValidity") |> PrefixedName
    /// <summary>
    ///   <para>dq:ThematicAccuracy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Thematic accuracy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#ThematicAccuracy">http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#ThematicAccuracy</seealso>
    let ThematicAccuracy = Prefixed_Name(dq, "ThematicAccuracy") |> PrefixedName

    /// <summary>
    ///   <para>dq:ThematicClassificationCorrectness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Thematic classification correctness"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#ThematicClassificationCorrectness">http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#ThematicClassificationCorrectness</seealso>
    let ThematicClassificationCorrectness =
        Prefixed_Name(dq, "ThematicClassificationCorrectness") |> PrefixedName

    /// <summary>
    ///   <para>dq:TopologicalConsistency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Topological consistency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#TopologicalConsistency">http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#TopologicalConsistency</seealso>
    let TopologicalConsistency =
        Prefixed_Name(dq, "TopologicalConsistency") |> PrefixedName

    /// <summary>
    ///   <para>dq:dateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"date time"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#dateTime">http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#dateTime</seealso>
    let dateTime = Prefixed_Name(dq, "dateTime") |> PrefixedName
    /// <summary>
    ///   <para>dq:errorStatistic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"error statistic"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#errorStatistic">http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#errorStatistic</seealso>
    let errorStatistic = Prefixed_Name(dq, "errorStatistic") |> PrefixedName

    /// <summary>
    ///   <para>dq:evaluationMethodDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"evaluation method description"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#evaluationMethodDescription">http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#evaluationMethodDescription</seealso>
    let evaluationMethodDescription =
        Prefixed_Name(dq, "evaluationMethodDescription") |> PrefixedName

    /// <summary>
    ///   <para>dq:evaluationMethodType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"evaluation method type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#evaluationMethodType">http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#evaluationMethodType</seealso>
    let evaluationMethodType = Prefixed_Name(dq, "evaluationMethodType") |> PrefixedName
    /// <summary>
    ///   <para>dq:evaluationProcedure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"evaluation procedure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#evaluationProcedure">http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#evaluationProcedure</seealso>
    let evaluationProcedure = Prefixed_Name(dq, "evaluationProcedure") |> PrefixedName
    /// <summary>
    ///   <para>dq:explanation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"explanation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#explanation">http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#explanation</seealso>
    let explanation = Prefixed_Name(dq, "explanation") |> PrefixedName
    /// <summary>
    ///   <para>dq:extent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"extent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#extent">http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#extent</seealso>
    let extent = Prefixed_Name(dq, "extent") |> PrefixedName
    /// <summary>
    ///   <para>dq:level</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"level"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#level">http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#level</seealso>
    let level = Prefixed_Name(dq, "level") |> PrefixedName
    /// <summary>
    ///   <para>dq:levelDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"level description"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#levelDescription">http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#levelDescription</seealso>
    let levelDescription = Prefixed_Name(dq, "levelDescription") |> PrefixedName
    /// <summary>
    ///   <para>dq:lineage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"lineage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#lineage">http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#lineage</seealso>
    let lineage = Prefixed_Name(dq, "lineage") |> PrefixedName
    /// <summary>
    ///   <para>dq:measureDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"measure description"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#measureDescription">http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#measureDescription</seealso>
    let measureDescription = Prefixed_Name(dq, "measureDescription") |> PrefixedName

    /// <summary>
    ///   <para>dq:measureIdentification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"measure identification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#measureIdentification">http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#measureIdentification</seealso>
    let measureIdentification =
        Prefixed_Name(dq, "measureIdentification") |> PrefixedName

    /// <summary>
    ///   <para>dq:nameOfMeasure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"name of measure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#nameOfMeasure">http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#nameOfMeasure</seealso>
    let nameOfMeasure = Prefixed_Name(dq, "nameOfMeasure") |> PrefixedName
    /// <summary>
    ///   <para>dq:pass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"pass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#pass">http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#pass</seealso>
    let pass = Prefixed_Name(dq, "pass") |> PrefixedName
    /// <summary>
    ///   <para>dq:report</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"report"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#report">http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#report</seealso>
    let report = Prefixed_Name(dq, "report") |> PrefixedName
    /// <summary>
    ///   <para>dq:result</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"result"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#result">http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#result</seealso>
    let result = Prefixed_Name(dq, "result") |> PrefixedName
    /// <summary>
    ///   <para>dq:scope</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"scope"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#scope">http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#scope</seealso>
    let scope = Prefixed_Name(dq, "scope") |> PrefixedName
    /// <summary>
    ///   <para>dq:specification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"specification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#specification">http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#specification</seealso>
    let specification = Prefixed_Name(dq, "specification") |> PrefixedName
    /// <summary>
    ///   <para>dq:value</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#value">http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#value</seealso>
    let value = Prefixed_Name(dq, "value") |> PrefixedName
    /// <summary>
    ///   <para>dq:valueType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"value type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#valueType">http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#valueType</seealso>
    let valueType = Prefixed_Name(dq, "valueType") |> PrefixedName
    /// <summary>
    ///   <para>dq:valueUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"unit of measure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#valueUnit">http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#valueUnit</seealso>
    let valueUnit = Prefixed_Name(dq, "valueUnit") |> PrefixedName
