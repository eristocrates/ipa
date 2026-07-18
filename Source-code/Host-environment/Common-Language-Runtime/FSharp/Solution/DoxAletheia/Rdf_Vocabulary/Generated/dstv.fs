namespace http.w3id.org.dstv.hash

open DoxAletheia.Rdf_Vocabulary

module dstv =
    let _namespace_name = "http://w3id.org/dstv#"
    /// <summary>
    ///   <see href="http://w3id.org/dstv#Depth"></see>
    /// </summary>
    let Depth = Namespaced_IRI.parse _namespace_name "Depth" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/dstv#Diameter"></see>
    /// </summary>
    let Diameter = Namespaced_IRI.parse _namespace_name "Diameter" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/dstv#Distance"></see>
    /// </summary>
    let Distance = Namespaced_IRI.parse _namespace_name "Distance" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/dstv#Vertex"></see>
    /// </summary>
    let Vertex = Namespaced_IRI.parse _namespace_name "Vertex" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/dstv#VertexX"></see>
    /// </summary>
    let VertexX = Namespaced_IRI.parse _namespace_name "VertexX" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/dstv#VertexY"></see>
    /// </summary>
    let VertexY = Namespaced_IRI.parse _namespace_name "VertexY" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/dstv#MeasuredValues"></see>
    /// </summary>
    let MeasuredValues =
        Namespaced_IRI.parse _namespace_name "MeasuredValues" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/dstv#PlannedValues"></see>
    /// </summary>
    let PlannedValues =
        Namespaced_IRI.parse _namespace_name "PlannedValues" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/dstv#ToleranceValues"></see>
    /// </summary>
    let ToleranceValues =
        Namespaced_IRI.parse _namespace_name "ToleranceValues" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/dstv#AdjustmentProcess"></see>
    /// </summary>
    let AdjustmentProcess =
        Namespaced_IRI.parse _namespace_name "AdjustmentProcess" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/dstv#BottomReference"></see>
    /// </summary>
    let BottomReference =
        Namespaced_IRI.parse _namespace_name "BottomReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/dstv#DimensionalReference"></see>
    /// </summary>
    let DimensionalReference =
        Namespaced_IRI.parse _namespace_name "DimensionalReference" |> NamespacedName

    /// <summary>
    /// b
    /// <see href="http://w3id.org/dstv#BottomView"></see></summary>
    let BottomView = Namespaced_IRI.parse _namespace_name "BottomView" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/dstv#ReferenceView"></see>
    /// </summary>
    let ReferenceView =
        Namespaced_IRI.parse _namespace_name "ReferenceView" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/dstv#FeatureValues"></see>
    /// </summary>
    let FeatureValues =
        Namespaced_IRI.parse _namespace_name "FeatureValues" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/dstv#DepthDeviation"></see>
    /// </summary>
    let DepthDeviation =
        Namespaced_IRI.parse _namespace_name "DepthDeviation" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/dstv#DeviationValues"></see>
    /// </summary>
    let DeviationValues =
        Namespaced_IRI.parse _namespace_name "DeviationValues" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/dstv#DepthTolerance"></see>
    /// </summary>
    let DepthTolerance =
        Namespaced_IRI.parse _namespace_name "DepthTolerance" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/dstv#DiameterDeviation"></see>
    /// </summary>
    let DiameterDeviation =
        Namespaced_IRI.parse _namespace_name "DiameterDeviation" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/dstv#DiameterTolerance"></see>
    /// </summary>
    let DiameterTolerance =
        Namespaced_IRI.parse _namespace_name "DiameterTolerance" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/dstv#DistanceSUM"></see>
    /// </summary>
    let DistanceSUM =
        Namespaced_IRI.parse _namespace_name "DistanceSUM" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/dstv#DistanceSUMDeviation"></see>
    /// </summary>
    let DistanceSUMDeviation =
        Namespaced_IRI.parse _namespace_name "DistanceSUMDeviation" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/dstv#DistanceSUMTolerance"></see>
    /// </summary>
    let DistanceSUMTolerance =
        Namespaced_IRI.parse _namespace_name "DistanceSUMTolerance" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/dstv#DistanceX"></see>
    /// </summary>
    let DistanceX = Namespaced_IRI.parse _namespace_name "DistanceX" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/dstv#DistanceXDeviation"></see>
    /// </summary>
    let DistanceXDeviation =
        Namespaced_IRI.parse _namespace_name "DistanceXDeviation" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/dstv#DistanceXTolerance"></see>
    /// </summary>
    let DistanceXTolerance =
        Namespaced_IRI.parse _namespace_name "DistanceXTolerance" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/dstv#DistanceY"></see>
    /// </summary>
    let DistanceY = Namespaced_IRI.parse _namespace_name "DistanceY" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/dstv#DistanceYDeviation"></see>
    /// </summary>
    let DistanceYDeviation =
        Namespaced_IRI.parse _namespace_name "DistanceYDeviation" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/dstv#DistanceYTolerance"></see>
    /// </summary>
    let DistanceYTolerance =
        Namespaced_IRI.parse _namespace_name "DistanceYTolerance" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/dstv#Drill"></see>
    /// </summary>
    let Drill = Namespaced_IRI.parse _namespace_name "Drill" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/dstv#ProductionProcess"></see>
    /// </summary>
    let ProductionProcess =
        Namespaced_IRI.parse _namespace_name "ProductionProcess" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/dstv#DrillMeasurement"></see>
    /// </summary>
    let DrillMeasurement =
        Namespaced_IRI.parse _namespace_name "DrillMeasurement" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/dstv#MeasurementProcess"></see>
    /// </summary>
    let MeasurementProcess =
        Namespaced_IRI.parse _namespace_name "MeasurementProcess" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/dstv#Feature"></see>
    /// </summary>
    let Feature = Namespaced_IRI.parse _namespace_name "Feature" |> NamespacedName
    /// <summary>
    /// f
    /// <see href="http://w3id.org/dstv#FrontView"></see></summary>
    let FrontView = Namespaced_IRI.parse _namespace_name "FrontView" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/dstv#MeasuredDepth"></see>
    /// </summary>
    let MeasuredDepth =
        Namespaced_IRI.parse _namespace_name "MeasuredDepth" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/dstv#MeasuredDiameter"></see>
    /// </summary>
    let MeasuredDiameter =
        Namespaced_IRI.parse _namespace_name "MeasuredDiameter" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/dstv#MeasuredDistanceSUM"></see>
    /// </summary>
    let MeasuredDistanceSUM =
        Namespaced_IRI.parse _namespace_name "MeasuredDistanceSUM" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/dstv#MeasuredDistanceX"></see>
    /// </summary>
    let MeasuredDistanceX =
        Namespaced_IRI.parse _namespace_name "MeasuredDistanceX" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/dstv#MeasuredDistanceY"></see>
    /// </summary>
    let MeasuredDistanceY =
        Namespaced_IRI.parse _namespace_name "MeasuredDistanceY" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/dstv#PlannedDepth"></see>
    /// </summary>
    let PlannedDepth =
        Namespaced_IRI.parse _namespace_name "PlannedDepth" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/dstv#PlannedDiameter"></see>
    /// </summary>
    let PlannedDiameter =
        Namespaced_IRI.parse _namespace_name "PlannedDiameter" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/dstv#PlannedDistanceSUM"></see>
    /// </summary>
    let PlannedDistanceSUM =
        Namespaced_IRI.parse _namespace_name "PlannedDistanceSUM" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/dstv#PlannedDistanceX"></see>
    /// </summary>
    let PlannedDistanceX =
        Namespaced_IRI.parse _namespace_name "PlannedDistanceX" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/dstv#PlannedDistanceY"></see>
    /// </summary>
    let PlannedDistanceY =
        Namespaced_IRI.parse _namespace_name "PlannedDistanceY" |> NamespacedName

    /// <summary>
    /// r
    /// <see href="http://w3id.org/dstv#RearView"></see></summary>
    let RearView = Namespaced_IRI.parse _namespace_name "RearView" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/dstv#SymmetricalReference"></see>
    /// </summary>
    let SymmetricalReference =
        Namespaced_IRI.parse _namespace_name "SymmetricalReference" |> NamespacedName

    /// <summary>
    /// The element hljob is an optional element of hl. It is created for each through hole of the corresponding reference plane.
    /// hljob
    /// <see href="http://w3id.org/dstv#ThroughHoleDrill"></see></summary>
    let ThroughHoleDrill =
        Namespaced_IRI.parse _namespace_name "ThroughHoleDrill" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/dstv#hasMeasurement"></see>
    /// </summary>
    let hasMeasurement =
        Namespaced_IRI.parse _namespace_name "hasMeasurement" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/dstv#ThroughHoleDrillMeasurement"></see>
    /// </summary>
    let ThroughHoleDrillMeasurement =
        Namespaced_IRI.parse _namespace_name "ThroughHoleDrillMeasurement" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/dstv#hasDiameter"></see>
    /// </summary>
    let hasDiameter =
        Namespaced_IRI.parse _namespace_name "hasDiameter" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/dstv#ToleranceBool"></see>
    /// </summary>
    let ToleranceBool =
        Namespaced_IRI.parse _namespace_name "ToleranceBool" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/dstv#TopReference"></see>
    /// </summary>
    let TopReference =
        Namespaced_IRI.parse _namespace_name "TopReference" |> NamespacedName

    /// <summary>
    /// t
    /// <see href="http://w3id.org/dstv#TopView"></see></summary>
    let TopView = Namespaced_IRI.parse _namespace_name "TopView" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/dstv#TroughHole"></see>
    /// </summary>
    let TroughHole = Namespaced_IRI.parse _namespace_name "TroughHole" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/dstv#ValidationProcess"></see>
    /// </summary>
    let ValidationProcess =
        Namespaced_IRI.parse _namespace_name "ValidationProcess" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/dstv#describedInIfcFeature"></see>
    /// </summary>
    let describedInIfcFeature =
        Namespaced_IRI.parse _namespace_name "describedInIfcFeature" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/dstv#hasDeviationValues"></see>
    /// </summary>
    let hasDeviationValues =
        Namespaced_IRI.parse _namespace_name "hasDeviationValues" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/dstv#hasFeature"></see>
    /// </summary>
    let hasFeature = Namespaced_IRI.parse _namespace_name "hasFeature" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/dstv#hasDiameterDeviation"></see>
    /// </summary>
    let hasDiameterDeviation =
        Namespaced_IRI.parse _namespace_name "hasDiameterDeviation" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/dstv#hasDiameterTolerance"></see>
    /// </summary>
    let hasDiameterTolerance =
        Namespaced_IRI.parse _namespace_name "hasDiameterTolerance" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/dstv#hasTolerances"></see>
    /// </summary>
    let hasTolerances =
        Namespaced_IRI.parse _namespace_name "hasTolerances" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/dstv#hasDimensionalReference"></see>
    /// </summary>
    let hasDimensionalReference =
        Namespaced_IRI.parse _namespace_name "hasDimensionalReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/dstv#hasMaxBound"></see>
    /// </summary>
    let hasMaxBound =
        Namespaced_IRI.parse _namespace_name "hasMaxBound" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/dstv#hasMeasuredDiameter"></see>
    /// </summary>
    let hasMeasuredDiameter =
        Namespaced_IRI.parse _namespace_name "hasMeasuredDiameter" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/dstv#hasMeasuredValue"></see>
    /// </summary>
    let hasMeasuredValue =
        Namespaced_IRI.parse _namespace_name "hasMeasuredValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/dstv#hasMinBound"></see>
    /// </summary>
    let hasMinBound =
        Namespaced_IRI.parse _namespace_name "hasMinBound" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/dstv#hasPlannedDiameter"></see>
    /// </summary>
    let hasPlannedDiameter =
        Namespaced_IRI.parse _namespace_name "hasPlannedDiameter" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/dstv#hasPlannedValue"></see>
    /// </summary>
    let hasPlannedValue =
        Namespaced_IRI.parse _namespace_name "hasPlannedValue" |> NamespacedName

    /// <summary>
    /// dstvNC Level
    /// <see href="http://w3id.org/dstv#hasReferenceView"></see></summary>
    let hasReferenceView =
        Namespaced_IRI.parse _namespace_name "hasReferenceView" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/dstv#hasVertex"></see>
    /// </summary>
    let hasVertex = Namespaced_IRI.parse _namespace_name "hasVertex" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/dstv#hasVertexX"></see>
    /// </summary>
    let hasVertexX = Namespaced_IRI.parse _namespace_name "hasVertexX" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/dstv#hasVertexY"></see>
    /// </summary>
    let hasVertexY = Namespaced_IRI.parse _namespace_name "hasVertexY" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/dstv#inTolerance"></see>
    /// </summary>
    let inTolerance =
        Namespaced_IRI.parse _namespace_name "inTolerance" |> NamespacedName
