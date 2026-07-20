namespace http.w3id.org.dstv.hash

open DoxAletheia

module dstv =
    let _namespace_name = "http://w3id.org/dstv#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/dstv#Depth"></see>
    /// </summary>
    let Depth = _prefix "Depth"
    /// <summary>
    ///   <see href="http://w3id.org/dstv#Diameter"></see>
    /// </summary>
    let Diameter = _prefix "Diameter"
    /// <summary>
    ///   <see href="http://w3id.org/dstv#Distance"></see>
    /// </summary>
    let Distance = _prefix "Distance"
    /// <summary>
    ///   <see href="http://w3id.org/dstv#Vertex"></see>
    /// </summary>
    let Vertex = _prefix "Vertex"
    /// <summary>
    ///   <see href="http://w3id.org/dstv#VertexX"></see>
    /// </summary>
    let VertexX = _prefix "VertexX"
    /// <summary>
    ///   <see href="http://w3id.org/dstv#VertexY"></see>
    /// </summary>
    let VertexY = _prefix "VertexY"
    /// <summary>
    ///   <see href="http://w3id.org/dstv#MeasuredValues"></see>
    /// </summary>
    let MeasuredValues = _prefix "MeasuredValues"
    /// <summary>
    ///   <see href="http://w3id.org/dstv#PlannedValues"></see>
    /// </summary>
    let PlannedValues = _prefix "PlannedValues"
    /// <summary>
    ///   <see href="http://w3id.org/dstv#ToleranceValues"></see>
    /// </summary>
    let ToleranceValues = _prefix "ToleranceValues"
    /// <summary>
    ///   <see href="http://w3id.org/dstv#AdjustmentProcess"></see>
    /// </summary>
    let AdjustmentProcess = _prefix "AdjustmentProcess"
    /// <summary>
    ///   <see href="http://w3id.org/dstv#BottomReference"></see>
    /// </summary>
    let BottomReference = _prefix "BottomReference"
    /// <summary>
    ///   <see href="http://w3id.org/dstv#DimensionalReference"></see>
    /// </summary>
    let DimensionalReference = _prefix "DimensionalReference"
    /// <summary>
    /// b
    /// <see href="http://w3id.org/dstv#BottomView"></see></summary>
    let BottomView = _prefix "BottomView"
    /// <summary>
    ///   <see href="http://w3id.org/dstv#ReferenceView"></see>
    /// </summary>
    let ReferenceView = _prefix "ReferenceView"
    /// <summary>
    ///   <see href="http://w3id.org/dstv#FeatureValues"></see>
    /// </summary>
    let FeatureValues = _prefix "FeatureValues"
    /// <summary>
    ///   <see href="http://w3id.org/dstv#DepthDeviation"></see>
    /// </summary>
    let DepthDeviation = _prefix "DepthDeviation"
    /// <summary>
    ///   <see href="http://w3id.org/dstv#DeviationValues"></see>
    /// </summary>
    let DeviationValues = _prefix "DeviationValues"
    /// <summary>
    ///   <see href="http://w3id.org/dstv#DepthTolerance"></see>
    /// </summary>
    let DepthTolerance = _prefix "DepthTolerance"
    /// <summary>
    ///   <see href="http://w3id.org/dstv#DiameterDeviation"></see>
    /// </summary>
    let DiameterDeviation = _prefix "DiameterDeviation"
    /// <summary>
    ///   <see href="http://w3id.org/dstv#DiameterTolerance"></see>
    /// </summary>
    let DiameterTolerance = _prefix "DiameterTolerance"
    /// <summary>
    ///   <see href="http://w3id.org/dstv#DistanceSUM"></see>
    /// </summary>
    let DistanceSUM = _prefix "DistanceSUM"
    /// <summary>
    ///   <see href="http://w3id.org/dstv#DistanceSUMDeviation"></see>
    /// </summary>
    let DistanceSUMDeviation = _prefix "DistanceSUMDeviation"
    /// <summary>
    ///   <see href="http://w3id.org/dstv#DistanceSUMTolerance"></see>
    /// </summary>
    let DistanceSUMTolerance = _prefix "DistanceSUMTolerance"
    /// <summary>
    ///   <see href="http://w3id.org/dstv#DistanceX"></see>
    /// </summary>
    let DistanceX = _prefix "DistanceX"
    /// <summary>
    ///   <see href="http://w3id.org/dstv#DistanceXDeviation"></see>
    /// </summary>
    let DistanceXDeviation = _prefix "DistanceXDeviation"
    /// <summary>
    ///   <see href="http://w3id.org/dstv#DistanceXTolerance"></see>
    /// </summary>
    let DistanceXTolerance = _prefix "DistanceXTolerance"
    /// <summary>
    ///   <see href="http://w3id.org/dstv#DistanceY"></see>
    /// </summary>
    let DistanceY = _prefix "DistanceY"
    /// <summary>
    ///   <see href="http://w3id.org/dstv#DistanceYDeviation"></see>
    /// </summary>
    let DistanceYDeviation = _prefix "DistanceYDeviation"
    /// <summary>
    ///   <see href="http://w3id.org/dstv#DistanceYTolerance"></see>
    /// </summary>
    let DistanceYTolerance = _prefix "DistanceYTolerance"
    /// <summary>
    ///   <see href="http://w3id.org/dstv#Drill"></see>
    /// </summary>
    let Drill = _prefix "Drill"
    /// <summary>
    ///   <see href="http://w3id.org/dstv#ProductionProcess"></see>
    /// </summary>
    let ProductionProcess = _prefix "ProductionProcess"
    /// <summary>
    ///   <see href="http://w3id.org/dstv#DrillMeasurement"></see>
    /// </summary>
    let DrillMeasurement = _prefix "DrillMeasurement"
    /// <summary>
    ///   <see href="http://w3id.org/dstv#MeasurementProcess"></see>
    /// </summary>
    let MeasurementProcess = _prefix "MeasurementProcess"
    /// <summary>
    ///   <see href="http://w3id.org/dstv#Feature"></see>
    /// </summary>
    let Feature = _prefix "Feature"
    /// <summary>
    /// f
    /// <see href="http://w3id.org/dstv#FrontView"></see></summary>
    let FrontView = _prefix "FrontView"
    /// <summary>
    ///   <see href="http://w3id.org/dstv#MeasuredDepth"></see>
    /// </summary>
    let MeasuredDepth = _prefix "MeasuredDepth"
    /// <summary>
    ///   <see href="http://w3id.org/dstv#MeasuredDiameter"></see>
    /// </summary>
    let MeasuredDiameter = _prefix "MeasuredDiameter"
    /// <summary>
    ///   <see href="http://w3id.org/dstv#MeasuredDistanceSUM"></see>
    /// </summary>
    let MeasuredDistanceSUM = _prefix "MeasuredDistanceSUM"
    /// <summary>
    ///   <see href="http://w3id.org/dstv#MeasuredDistanceX"></see>
    /// </summary>
    let MeasuredDistanceX = _prefix "MeasuredDistanceX"
    /// <summary>
    ///   <see href="http://w3id.org/dstv#MeasuredDistanceY"></see>
    /// </summary>
    let MeasuredDistanceY = _prefix "MeasuredDistanceY"
    /// <summary>
    ///   <see href="http://w3id.org/dstv#PlannedDepth"></see>
    /// </summary>
    let PlannedDepth = _prefix "PlannedDepth"
    /// <summary>
    ///   <see href="http://w3id.org/dstv#PlannedDiameter"></see>
    /// </summary>
    let PlannedDiameter = _prefix "PlannedDiameter"
    /// <summary>
    ///   <see href="http://w3id.org/dstv#PlannedDistanceSUM"></see>
    /// </summary>
    let PlannedDistanceSUM = _prefix "PlannedDistanceSUM"
    /// <summary>
    ///   <see href="http://w3id.org/dstv#PlannedDistanceX"></see>
    /// </summary>
    let PlannedDistanceX = _prefix "PlannedDistanceX"
    /// <summary>
    ///   <see href="http://w3id.org/dstv#PlannedDistanceY"></see>
    /// </summary>
    let PlannedDistanceY = _prefix "PlannedDistanceY"
    /// <summary>
    /// r
    /// <see href="http://w3id.org/dstv#RearView"></see></summary>
    let RearView = _prefix "RearView"
    /// <summary>
    ///   <see href="http://w3id.org/dstv#SymmetricalReference"></see>
    /// </summary>
    let SymmetricalReference = _prefix "SymmetricalReference"
    /// <summary>
    /// The element hljob is an optional element of hl. It is created for each through hole of the corresponding reference plane.
    /// hljob
    /// <see href="http://w3id.org/dstv#ThroughHoleDrill"></see></summary>
    let ThroughHoleDrill = _prefix "ThroughHoleDrill"
    /// <summary>
    ///   <see href="http://w3id.org/dstv#hasMeasurement"></see>
    /// </summary>
    let hasMeasurement = _prefix "hasMeasurement"
    /// <summary>
    ///   <see href="http://w3id.org/dstv#ThroughHoleDrillMeasurement"></see>
    /// </summary>
    let ThroughHoleDrillMeasurement = _prefix "ThroughHoleDrillMeasurement"
    /// <summary>
    ///   <see href="http://w3id.org/dstv#hasDiameter"></see>
    /// </summary>
    let hasDiameter = _prefix "hasDiameter"
    /// <summary>
    ///   <see href="http://w3id.org/dstv#ToleranceBool"></see>
    /// </summary>
    let ToleranceBool = _prefix "ToleranceBool"
    /// <summary>
    ///   <see href="http://w3id.org/dstv#TopReference"></see>
    /// </summary>
    let TopReference = _prefix "TopReference"
    /// <summary>
    /// t
    /// <see href="http://w3id.org/dstv#TopView"></see></summary>
    let TopView = _prefix "TopView"
    /// <summary>
    ///   <see href="http://w3id.org/dstv#TroughHole"></see>
    /// </summary>
    let TroughHole = _prefix "TroughHole"
    /// <summary>
    ///   <see href="http://w3id.org/dstv#ValidationProcess"></see>
    /// </summary>
    let ValidationProcess = _prefix "ValidationProcess"
    /// <summary>
    ///   <see href="http://w3id.org/dstv#describedInIfcFeature"></see>
    /// </summary>
    let describedInIfcFeature = _prefix "describedInIfcFeature"
    /// <summary>
    ///   <see href="http://w3id.org/dstv#hasDeviationValues"></see>
    /// </summary>
    let hasDeviationValues = _prefix "hasDeviationValues"
    /// <summary>
    ///   <see href="http://w3id.org/dstv#hasFeature"></see>
    /// </summary>
    let hasFeature = _prefix "hasFeature"
    /// <summary>
    ///   <see href="http://w3id.org/dstv#hasDiameterDeviation"></see>
    /// </summary>
    let hasDiameterDeviation = _prefix "hasDiameterDeviation"
    /// <summary>
    ///   <see href="http://w3id.org/dstv#hasDiameterTolerance"></see>
    /// </summary>
    let hasDiameterTolerance = _prefix "hasDiameterTolerance"
    /// <summary>
    ///   <see href="http://w3id.org/dstv#hasTolerances"></see>
    /// </summary>
    let hasTolerances = _prefix "hasTolerances"
    /// <summary>
    ///   <see href="http://w3id.org/dstv#hasDimensionalReference"></see>
    /// </summary>
    let hasDimensionalReference = _prefix "hasDimensionalReference"
    /// <summary>
    ///   <see href="http://w3id.org/dstv#hasMaxBound"></see>
    /// </summary>
    let hasMaxBound = _prefix "hasMaxBound"
    /// <summary>
    ///   <see href="http://w3id.org/dstv#hasMeasuredDiameter"></see>
    /// </summary>
    let hasMeasuredDiameter = _prefix "hasMeasuredDiameter"
    /// <summary>
    ///   <see href="http://w3id.org/dstv#hasMeasuredValue"></see>
    /// </summary>
    let hasMeasuredValue = _prefix "hasMeasuredValue"
    /// <summary>
    ///   <see href="http://w3id.org/dstv#hasMinBound"></see>
    /// </summary>
    let hasMinBound = _prefix "hasMinBound"
    /// <summary>
    ///   <see href="http://w3id.org/dstv#hasPlannedDiameter"></see>
    /// </summary>
    let hasPlannedDiameter = _prefix "hasPlannedDiameter"
    /// <summary>
    ///   <see href="http://w3id.org/dstv#hasPlannedValue"></see>
    /// </summary>
    let hasPlannedValue = _prefix "hasPlannedValue"
    /// <summary>
    /// dstvNC Level
    /// <see href="http://w3id.org/dstv#hasReferenceView"></see></summary>
    let hasReferenceView = _prefix "hasReferenceView"
    /// <summary>
    ///   <see href="http://w3id.org/dstv#hasVertex"></see>
    /// </summary>
    let hasVertex = _prefix "hasVertex"
    /// <summary>
    ///   <see href="http://w3id.org/dstv#hasVertexX"></see>
    /// </summary>
    let hasVertexX = _prefix "hasVertexX"
    /// <summary>
    ///   <see href="http://w3id.org/dstv#hasVertexY"></see>
    /// </summary>
    let hasVertexY = _prefix "hasVertexY"
    /// <summary>
    ///   <see href="http://w3id.org/dstv#inTolerance"></see>
    /// </summary>
    let inTolerance = _prefix "inTolerance"
