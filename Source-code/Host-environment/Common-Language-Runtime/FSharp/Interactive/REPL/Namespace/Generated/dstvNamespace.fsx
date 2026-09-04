#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module dstv =
    let _prefixId = PrefixId.fromNamespaceLabel "http://w3id.org/dstv#" "dstv"
    let _namespaceIri = _prefixId.prefix ""
    let AdjustmentProcess = _prefixId.prefix "AdjustmentProcess"
    let BottomReference = _prefixId.prefix "BottomReference"
    /// <summary>
    ///   <para>rdfs:comment : b^^xsd:string</para>
    ///   <a href="http://w3id.org/dstv#BottomView">dstv:BottomView</a>
    /// </summary>
    let BottomView = _prefixId.prefix "BottomView"
    let Depth = _prefixId.prefix "Depth"
    let DepthDeviation = _prefixId.prefix "DepthDeviation"
    let DepthTolerance = _prefixId.prefix "DepthTolerance"
    let DeviationValues = _prefixId.prefix "DeviationValues"
    let Diameter = _prefixId.prefix "Diameter"
    let DiameterDeviation = _prefixId.prefix "DiameterDeviation"
    let DiameterTolerance = _prefixId.prefix "DiameterTolerance"
    let DimensionalReference = _prefixId.prefix "DimensionalReference"
    let Distance = _prefixId.prefix "Distance"
    let DistanceSUM = _prefixId.prefix "DistanceSUM"
    let DistanceSUMDeviation = _prefixId.prefix "DistanceSUMDeviation"
    let DistanceSUMTolerance = _prefixId.prefix "DistanceSUMTolerance"
    let DistanceX = _prefixId.prefix "DistanceX"
    let DistanceXDeviation = _prefixId.prefix "DistanceXDeviation"
    let DistanceXTolerance = _prefixId.prefix "DistanceXTolerance"
    let DistanceY = _prefixId.prefix "DistanceY"
    let DistanceYDeviation = _prefixId.prefix "DistanceYDeviation"
    let DistanceYTolerance = _prefixId.prefix "DistanceYTolerance"
    let Drill = _prefixId.prefix "Drill"
    let DrillMeasurement = _prefixId.prefix "DrillMeasurement"
    let Feature = _prefixId.prefix "Feature"
    let FeatureValues = _prefixId.prefix "FeatureValues"
    /// <summary>
    ///   <para>rdfs:comment : f^^xsd:string</para>
    ///   <a href="http://w3id.org/dstv#FrontView">dstv:FrontView</a>
    /// </summary>
    let FrontView = _prefixId.prefix "FrontView"
    let MeasuredDepth = _prefixId.prefix "MeasuredDepth"
    let MeasuredDiameter = _prefixId.prefix "MeasuredDiameter"
    let MeasuredDistanceSUM = _prefixId.prefix "MeasuredDistanceSUM"
    let MeasuredDistanceX = _prefixId.prefix "MeasuredDistanceX"
    let MeasuredDistanceY = _prefixId.prefix "MeasuredDistanceY"
    let MeasuredValues = _prefixId.prefix "MeasuredValues"
    let MeasurementProcess = _prefixId.prefix "MeasurementProcess"
    let PlannedDepth = _prefixId.prefix "PlannedDepth"
    let PlannedDiameter = _prefixId.prefix "PlannedDiameter"
    let PlannedDistanceSUM = _prefixId.prefix "PlannedDistanceSUM"
    let PlannedDistanceX = _prefixId.prefix "PlannedDistanceX"
    let PlannedDistanceY = _prefixId.prefix "PlannedDistanceY"
    let PlannedValues = _prefixId.prefix "PlannedValues"
    let ProductionProcess = _prefixId.prefix "ProductionProcess"
    /// <summary>
    ///   <para>rdfs:comment : r^^xsd:string</para>
    ///   <a href="http://w3id.org/dstv#RearView">dstv:RearView</a>
    /// </summary>
    let RearView = _prefixId.prefix "RearView"
    let ReferenceView = _prefixId.prefix "ReferenceView"
    let SymmetricalReference = _prefixId.prefix "SymmetricalReference"
    /// <summary>
    ///   <para>rdfs:comment : The element hljob is an optional element of hl. It is created for each through hole of the corresponding reference plane.^^xsd:stringrdfs:comment : hljob^^xsd:string</para>
    ///   <a href="http://w3id.org/dstv#ThroughHoleDrill">dstv:ThroughHoleDrill</a>
    /// </summary>
    let ThroughHoleDrill = _prefixId.prefix "ThroughHoleDrill"
    let ThroughHoleDrillMeasurement = _prefixId.prefix "ThroughHoleDrillMeasurement"
    let ToleranceBool = _prefixId.prefix "ToleranceBool"
    let ToleranceValues = _prefixId.prefix "ToleranceValues"
    let TopReference = _prefixId.prefix "TopReference"
    /// <summary>
    ///   <para>rdfs:comment : t^^xsd:string</para>
    ///   <a href="http://w3id.org/dstv#TopView">dstv:TopView</a>
    /// </summary>
    let TopView = _prefixId.prefix "TopView"
    let TroughHole = _prefixId.prefix "TroughHole"
    let ValidationProcess = _prefixId.prefix "ValidationProcess"
    let Vertex = _prefixId.prefix "Vertex"
    let VertexX = _prefixId.prefix "VertexX"
    let VertexY = _prefixId.prefix "VertexY"
    let describedInIfcFeature = _prefixId.prefix "describedInIfcFeature"
    let hasDeviationValues = _prefixId.prefix "hasDeviationValues"
    let hasDiameter = _prefixId.prefix "hasDiameter"
    let hasDiameterDeviation = _prefixId.prefix "hasDiameterDeviation"
    let hasDiameterTolerance = _prefixId.prefix "hasDiameterTolerance"
    let hasDimensionalReference = _prefixId.prefix "hasDimensionalReference"
    let hasFeature = _prefixId.prefix "hasFeature"
    let hasMaxBound = _prefixId.prefix "hasMaxBound"
    let hasMeasuredDiameter = _prefixId.prefix "hasMeasuredDiameter"
    let hasMeasuredValue = _prefixId.prefix "hasMeasuredValue"
    let hasMeasurement = _prefixId.prefix "hasMeasurement"
    let hasMinBound = _prefixId.prefix "hasMinBound"
    let hasPlannedDiameter = _prefixId.prefix "hasPlannedDiameter"
    let hasPlannedValue = _prefixId.prefix "hasPlannedValue"
    /// <summary>
    ///   <para>rdfs:comment : dstvNC Level^^xsd:string</para>
    ///   <a href="http://w3id.org/dstv#hasReferenceView">dstv:hasReferenceView</a>
    /// </summary>
    let hasReferenceView = _prefixId.prefix "hasReferenceView"
    let hasTolerances = _prefixId.prefix "hasTolerances"
    let hasVertex = _prefixId.prefix "hasVertex"
    let hasVertexX = _prefixId.prefix "hasVertexX"
    let hasVertexY = _prefixId.prefix "hasVertexY"
    let inTolerance = _prefixId.prefix "inTolerance"
