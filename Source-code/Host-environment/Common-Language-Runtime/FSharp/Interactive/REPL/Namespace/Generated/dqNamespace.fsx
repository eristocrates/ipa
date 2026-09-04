#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module dq =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#" "dq"

    /// <summary>
    ///   <para>skos:notation : DQ_AbsoluteExternalPositionalAccuracy^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Absolute external positional accuracy^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#AbsoluteExternalPositionalAccuracy">dq:AbsoluteExternalPositionalAccuracy</a>
    /// </summary>
    let AbsoluteExternalPositionalAccuracy =
        _prefixId.prefix "AbsoluteExternalPositionalAccuracy"

    /// <summary>
    ///   <para>skos:notation : DQ_AccuracyOfATimeMeasurement^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Accuracy of a Time measurement^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#AccuracyOfATimeMeasurement">dq:AccuracyOfATimeMeasurement</a>
    /// </summary>
    let AccuracyOfATimeMeasurement = _prefixId.prefix "AccuracyOfATimeMeasurement"
    /// <summary>
    ///   <para>skos:notation : DQ_Completeness^^h2o:ISOClassName</para>
    ///   <para>h2o:isAbstract : true^^xsd:boolean</para>
    ///   <para>rdfs:label : Completeness^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#Completeness">dq:Completeness</a>
    /// </summary>
    let Completeness = _prefixId.prefix "Completeness"
    /// <summary>
    ///   <para>skos:notation : DQ_CompletenessCommission^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Completeness commission^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#CompletenessCommission">dq:CompletenessCommission</a>
    /// </summary>
    let CompletenessCommission = _prefixId.prefix "CompletenessCommission"
    /// <summary>
    ///   <para>skos:notation : DQ_CompletenessOmission^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Completeness omission^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#CompletenessOmission">dq:CompletenessOmission</a>
    /// </summary>
    let CompletenessOmission = _prefixId.prefix "CompletenessOmission"
    /// <summary>
    ///   <para>skos:notation : DQ_ConceptualConsistency^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Conceptual consistency^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#ConceptualConsistency">dq:ConceptualConsistency</a>
    /// </summary>
    let ConceptualConsistency = _prefixId.prefix "ConceptualConsistency"
    /// <summary>
    ///   <para>skos:notation : DQ_ConformanceResult^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Conformance result^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#ConformanceResult">dq:ConformanceResult</a>
    /// </summary>
    let ConformanceResult = _prefixId.prefix "ConformanceResult"
    /// <summary>
    ///   <para>rdfs:label : Data quality^^xsd:string</para>
    ///   <para>skos:notation : DQ_DataQuality^^h2o:ISOClassName</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#DataQuality">dq:DataQuality</a>
    /// </summary>
    let DataQuality = _prefixId.prefix "DataQuality"
    /// <summary>
    ///   <para>skos:notation : DQ_DomainConsistency^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Domain consistency^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#DomainConsistency">dq:DomainConsistency</a>
    /// </summary>
    let DomainConsistency = _prefixId.prefix "DomainConsistency"
    /// <summary>
    ///   <para>skos:notation : DQ_Element^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Element^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#Element">dq:Element</a>
    /// </summary>
    let Element = _prefixId.prefix "Element"
    /// <summary>
    ///   <para>skos:notation : DQ_EvaluationMethodTypeCode^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Evaluation method code^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#EvaluationMethodTypeCode">dq:EvaluationMethodTypeCode</a>
    /// </summary>
    let EvaluationMethodTypeCode = _prefixId.prefix "EvaluationMethodTypeCode"
    /// <summary>
    ///   <para>skos:notation : DQ_FormatConsistency^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Format consistency^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#FormatConsistency">dq:FormatConsistency</a>
    /// </summary>
    let FormatConsistency = _prefixId.prefix "FormatConsistency"
    /// <summary>
    ///   <para>skos:notation : DQ_GriddedDataPositionalAccuracy^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Gridded data positional accuracy^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#GriddedDataPositionalAccuracy">dq:GriddedDataPositionalAccuracy</a>
    /// </summary>
    let GriddedDataPositionalAccuracy = _prefixId.prefix "GriddedDataPositionalAccuracy"
    /// <summary>
    ///   <para>skos:notation : DQ_LogicalConsistency^^h2o:ISOClassName</para>
    ///   <para>h2o:isAbstract : true^^xsd:boolean</para>
    ///   <para>rdfs:label : Logical consistency^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#LogicalConsistency">dq:LogicalConsistency</a>
    /// </summary>
    let LogicalConsistency = _prefixId.prefix "LogicalConsistency"

    /// <summary>
    ///   <para>skos:notation : DQ_NonQuantitativeAttributeAccuracy^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Non quantitative attribute accuracy^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#NonQuantitativeAttributeAccuracy">dq:NonQuantitativeAttributeAccuracy</a>
    /// </summary>
    let NonQuantitativeAttributeAccuracy =
        _prefixId.prefix "NonQuantitativeAttributeAccuracy"

    /// <summary>
    ///   <para>skos:notation : DQ_PositionalAccuracy^^h2o:ISOClassName</para>
    ///   <para>h2o:isAbstract : true^^xsd:boolean</para>
    ///   <para>rdfs:label : Positional accuracy^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#PositionalAccuracy">dq:PositionalAccuracy</a>
    /// </summary>
    let PositionalAccuracy = _prefixId.prefix "PositionalAccuracy"
    /// <summary>
    ///   <para>skos:notation : DQ_QuantitativeAttributeAccuracy^^xsd:string</para>
    ///   <para>rdfs:label : Quantitative attribute accuracy^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#QuantitativeAttributeAccuracy">dq:QuantitativeAttributeAccuracy</a>
    /// </summary>
    let QuantitativeAttributeAccuracy = _prefixId.prefix "QuantitativeAttributeAccuracy"
    /// <summary>
    ///   <para>skos:notation : DQ_QuantitativeResult^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Quantitative result^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#QuantitativeResult">dq:QuantitativeResult</a>
    /// </summary>
    let QuantitativeResult = _prefixId.prefix "QuantitativeResult"

    /// <summary>
    ///   <para>skos:notation : DQ_RelativeInternalPositionalAccuracy^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Relative internal positional accuracy^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#RelativeInternalPositionalAccuracy">dq:RelativeInternalPositionalAccuracy</a>
    /// </summary>
    let RelativeInternalPositionalAccuracy =
        _prefixId.prefix "RelativeInternalPositionalAccuracy"

    /// <summary>
    ///   <para>skos:notation : DQ_Result^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Result^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#Result">dq:Result</a>
    /// </summary>
    let Result = _prefixId.prefix "Result"
    /// <summary>
    ///   <para>skos:notation : DQ_Scope^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Scope^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#Scope">dq:Scope</a>
    /// </summary>
    let Scope = _prefixId.prefix "Scope"
    /// <summary>
    ///   <para>skos:notation : DQ_TemporalAccuracy^^h2o:ISOClassName</para>
    ///   <para>h2o:isAbstract : true^^xsd:boolean</para>
    ///   <para>rdfs:label : Temporal accuracy^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#TemporalAccuracy">dq:TemporalAccuracy</a>
    /// </summary>
    let TemporalAccuracy = _prefixId.prefix "TemporalAccuracy"
    /// <summary>
    ///   <para>skos:notation : DQ_TemporalConsistency^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Temporal consistency^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#TemporalConsistency">dq:TemporalConsistency</a>
    /// </summary>
    let TemporalConsistency = _prefixId.prefix "TemporalConsistency"
    /// <summary>
    ///   <para>skos:notation : DQ_TemporalValidity^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Temporal validity^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#TemporalValidity">dq:TemporalValidity</a>
    /// </summary>
    let TemporalValidity = _prefixId.prefix "TemporalValidity"
    /// <summary>
    ///   <para>skos:notation : DQ_ThematicAccuracy^^h2o:ISOClassName</para>
    ///   <para>h2o:isAbstract : true^^xsd:boolean</para>
    ///   <para>rdfs:label : Thematic accuracy^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#ThematicAccuracy">dq:ThematicAccuracy</a>
    /// </summary>
    let ThematicAccuracy = _prefixId.prefix "ThematicAccuracy"

    /// <summary>
    ///   <para>skos:notation : DQ_ThematicClassificationCorrectness^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Thematic classification correctness^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#ThematicClassificationCorrectness">dq:ThematicClassificationCorrectness</a>
    /// </summary>
    let ThematicClassificationCorrectness =
        _prefixId.prefix "ThematicClassificationCorrectness"

    /// <summary>
    ///   <para>skos:notation : DQ_TopologicalConsistency^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Topological consistency^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#TopologicalConsistency">dq:TopologicalConsistency</a>
    /// </summary>
    let TopologicalConsistency = _prefixId.prefix "TopologicalConsistency"
    /// <summary>
    ///   <para>rdfs:label : date time^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#dateTime">dq:dateTime</a>
    /// </summary>
    let dateTime = _prefixId.prefix "dateTime"
    /// <summary>
    ///   <para>rdfs:label : error statistic^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#errorStatistic">dq:errorStatistic</a>
    /// </summary>
    let errorStatistic = _prefixId.prefix "errorStatistic"
    /// <summary>
    ///   <para>rdfs:label : evaluation method description^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#evaluationMethodDescription">dq:evaluationMethodDescription</a>
    /// </summary>
    let evaluationMethodDescription = _prefixId.prefix "evaluationMethodDescription"
    /// <summary>
    ///   <para>rdfs:label : evaluation method type^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#evaluationMethodType">dq:evaluationMethodType</a>
    /// </summary>
    let evaluationMethodType = _prefixId.prefix "evaluationMethodType"
    /// <summary>
    ///   <para>rdfs:label : evaluation procedure^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#evaluationProcedure">dq:evaluationProcedure</a>
    /// </summary>
    let evaluationProcedure = _prefixId.prefix "evaluationProcedure"
    /// <summary>
    ///   <para>rdfs:label : explanation^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#explanation">dq:explanation</a>
    /// </summary>
    let explanation = _prefixId.prefix "explanation"
    /// <summary>
    ///   <para>rdfs:label : extent^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#extent">dq:extent</a>
    /// </summary>
    let extent = _prefixId.prefix "extent"
    /// <summary>
    ///   <para>rdfs:label : level^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#level">dq:level</a>
    /// </summary>
    let level = _prefixId.prefix "level"
    /// <summary>
    ///   <para>rdfs:label : level description^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#levelDescription">dq:levelDescription</a>
    /// </summary>
    let levelDescription = _prefixId.prefix "levelDescription"
    /// <summary>
    ///   <para>rdfs:label : lineage^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#lineage">dq:lineage</a>
    /// </summary>
    let lineage = _prefixId.prefix "lineage"
    /// <summary>
    ///   <para>rdfs:label : measure description^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#measureDescription">dq:measureDescription</a>
    /// </summary>
    let measureDescription = _prefixId.prefix "measureDescription"
    /// <summary>
    ///   <para>rdfs:label : measure identification^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#measureIdentification">dq:measureIdentification</a>
    /// </summary>
    let measureIdentification = _prefixId.prefix "measureIdentification"
    /// <summary>
    ///   <para>rdfs:label : name of measure^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#nameOfMeasure">dq:nameOfMeasure</a>
    /// </summary>
    let nameOfMeasure = _prefixId.prefix "nameOfMeasure"
    /// <summary>
    ///   <para>rdfs:label : pass^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#pass">dq:pass</a>
    /// </summary>
    let pass = _prefixId.prefix "pass"
    /// <summary>
    ///   <para>rdfs:label : report^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#report">dq:report</a>
    /// </summary>
    let report = _prefixId.prefix "report"
    /// <summary>
    ///   <para>rdfs:label : result^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#result">dq:result</a>
    /// </summary>
    let result = _prefixId.prefix "result"
    /// <summary>
    ///   <para>rdfs:label : scope^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#scope">dq:scope</a>
    /// </summary>
    let scope = _prefixId.prefix "scope"
    /// <summary>
    ///   <para>rdfs:label : specification^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#specification">dq:specification</a>
    /// </summary>
    let specification = _prefixId.prefix "specification"
    /// <summary>
    ///   <para>rdfs:label : value^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#value">dq:value</a>
    /// </summary>
    let value = _prefixId.prefix "value"
    /// <summary>
    ///   <para>rdfs:label : value type^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#valueType">dq:valueType</a>
    /// </summary>
    let valueType = _prefixId.prefix "valueType"
    /// <summary>
    ///   <para>rdfs:label : unit of measure^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#valueUnit">dq:valueUnit</a>
    /// </summary>
    let valueUnit = _prefixId.prefix "valueUnit"
