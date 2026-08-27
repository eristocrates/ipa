namespace http.w3id.org.dstv.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module dstv =
    let _namespace_iri = Namespace_Iri dstv |> NamespaceIRI
    /// <summary>
    ///   <para>dstv:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/dstv#">http://w3id.org/dstv#</seealso>
    let _prefix_iri = Prefixed_Name(dstv, "") |> PrefixedName
    /// <summary>
    ///   <para>dstv:AdjustmentProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/dstv#AdjustmentProcess">http://w3id.org/dstv#AdjustmentProcess</seealso>
    let AdjustmentProcess = Prefixed_Name(dstv, "AdjustmentProcess") |> PrefixedName
    /// <summary>
    ///   <para>dstv:BottomReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/dstv#BottomReference">http://w3id.org/dstv#BottomReference</seealso>
    let BottomReference = Prefixed_Name(dstv, "BottomReference") |> PrefixedName
    /// <summary>
    ///   <para>dstv:BottomView</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"b"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/dstv#BottomView">http://w3id.org/dstv#BottomView</seealso>
    let BottomView = Prefixed_Name(dstv, "BottomView") |> PrefixedName
    /// <summary>
    ///   <para>dstv:Depth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/dstv#Depth">http://w3id.org/dstv#Depth</seealso>
    let Depth = Prefixed_Name(dstv, "Depth") |> PrefixedName
    /// <summary>
    ///   <para>dstv:DepthDeviation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/dstv#DepthDeviation">http://w3id.org/dstv#DepthDeviation</seealso>
    let DepthDeviation = Prefixed_Name(dstv, "DepthDeviation") |> PrefixedName
    /// <summary>
    ///   <para>dstv:DepthTolerance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/dstv#DepthTolerance">http://w3id.org/dstv#DepthTolerance</seealso>
    let DepthTolerance = Prefixed_Name(dstv, "DepthTolerance") |> PrefixedName
    /// <summary>
    ///   <para>dstv:DeviationValues</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/dstv#DeviationValues">http://w3id.org/dstv#DeviationValues</seealso>
    let DeviationValues = Prefixed_Name(dstv, "DeviationValues") |> PrefixedName
    /// <summary>
    ///   <para>dstv:Diameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/dstv#Diameter">http://w3id.org/dstv#Diameter</seealso>
    let Diameter = Prefixed_Name(dstv, "Diameter") |> PrefixedName
    /// <summary>
    ///   <para>dstv:DiameterDeviation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/dstv#DiameterDeviation">http://w3id.org/dstv#DiameterDeviation</seealso>
    let DiameterDeviation = Prefixed_Name(dstv, "DiameterDeviation") |> PrefixedName
    /// <summary>
    ///   <para>dstv:DiameterTolerance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/dstv#DiameterTolerance">http://w3id.org/dstv#DiameterTolerance</seealso>
    let DiameterTolerance = Prefixed_Name(dstv, "DiameterTolerance") |> PrefixedName

    /// <summary>
    ///   <para>dstv:DimensionalReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/dstv#DimensionalReference">http://w3id.org/dstv#DimensionalReference</seealso>
    let DimensionalReference =
        Prefixed_Name(dstv, "DimensionalReference") |> PrefixedName

    /// <summary>
    ///   <para>dstv:Distance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/dstv#Distance">http://w3id.org/dstv#Distance</seealso>
    let Distance = Prefixed_Name(dstv, "Distance") |> PrefixedName
    /// <summary>
    ///   <para>dstv:DistanceSUM</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/dstv#DistanceSUM">http://w3id.org/dstv#DistanceSUM</seealso>
    let DistanceSUM = Prefixed_Name(dstv, "DistanceSUM") |> PrefixedName

    /// <summary>
    ///   <para>dstv:DistanceSUMDeviation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/dstv#DistanceSUMDeviation">http://w3id.org/dstv#DistanceSUMDeviation</seealso>
    let DistanceSUMDeviation =
        Prefixed_Name(dstv, "DistanceSUMDeviation") |> PrefixedName

    /// <summary>
    ///   <para>dstv:DistanceSUMTolerance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/dstv#DistanceSUMTolerance">http://w3id.org/dstv#DistanceSUMTolerance</seealso>
    let DistanceSUMTolerance =
        Prefixed_Name(dstv, "DistanceSUMTolerance") |> PrefixedName

    /// <summary>
    ///   <para>dstv:DistanceX</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/dstv#DistanceX">http://w3id.org/dstv#DistanceX</seealso>
    let DistanceX = Prefixed_Name(dstv, "DistanceX") |> PrefixedName
    /// <summary>
    ///   <para>dstv:DistanceXDeviation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/dstv#DistanceXDeviation">http://w3id.org/dstv#DistanceXDeviation</seealso>
    let DistanceXDeviation = Prefixed_Name(dstv, "DistanceXDeviation") |> PrefixedName
    /// <summary>
    ///   <para>dstv:DistanceXTolerance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/dstv#DistanceXTolerance">http://w3id.org/dstv#DistanceXTolerance</seealso>
    let DistanceXTolerance = Prefixed_Name(dstv, "DistanceXTolerance") |> PrefixedName
    /// <summary>
    ///   <para>dstv:DistanceY</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/dstv#DistanceY">http://w3id.org/dstv#DistanceY</seealso>
    let DistanceY = Prefixed_Name(dstv, "DistanceY") |> PrefixedName
    /// <summary>
    ///   <para>dstv:DistanceYDeviation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/dstv#DistanceYDeviation">http://w3id.org/dstv#DistanceYDeviation</seealso>
    let DistanceYDeviation = Prefixed_Name(dstv, "DistanceYDeviation") |> PrefixedName
    /// <summary>
    ///   <para>dstv:DistanceYTolerance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/dstv#DistanceYTolerance">http://w3id.org/dstv#DistanceYTolerance</seealso>
    let DistanceYTolerance = Prefixed_Name(dstv, "DistanceYTolerance") |> PrefixedName
    /// <summary>
    ///   <para>dstv:Drill</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/dstv#Drill">http://w3id.org/dstv#Drill</seealso>
    let Drill = Prefixed_Name(dstv, "Drill") |> PrefixedName
    /// <summary>
    ///   <para>dstv:DrillMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/dstv#DrillMeasurement">http://w3id.org/dstv#DrillMeasurement</seealso>
    let DrillMeasurement = Prefixed_Name(dstv, "DrillMeasurement") |> PrefixedName
    /// <summary>
    ///   <para>dstv:Feature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/dstv#Feature">http://w3id.org/dstv#Feature</seealso>
    let Feature = Prefixed_Name(dstv, "Feature") |> PrefixedName
    /// <summary>
    ///   <para>dstv:FeatureValues</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/dstv#FeatureValues">http://w3id.org/dstv#FeatureValues</seealso>
    let FeatureValues = Prefixed_Name(dstv, "FeatureValues") |> PrefixedName
    /// <summary>
    ///   <para>dstv:FrontView</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"f"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/dstv#FrontView">http://w3id.org/dstv#FrontView</seealso>
    let FrontView = Prefixed_Name(dstv, "FrontView") |> PrefixedName
    /// <summary>
    ///   <para>dstv:MeasuredDepth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/dstv#MeasuredDepth">http://w3id.org/dstv#MeasuredDepth</seealso>
    let MeasuredDepth = Prefixed_Name(dstv, "MeasuredDepth") |> PrefixedName
    /// <summary>
    ///   <para>dstv:MeasuredDiameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/dstv#MeasuredDiameter">http://w3id.org/dstv#MeasuredDiameter</seealso>
    let MeasuredDiameter = Prefixed_Name(dstv, "MeasuredDiameter") |> PrefixedName
    /// <summary>
    ///   <para>dstv:MeasuredDistanceSUM</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/dstv#MeasuredDistanceSUM">http://w3id.org/dstv#MeasuredDistanceSUM</seealso>
    let MeasuredDistanceSUM = Prefixed_Name(dstv, "MeasuredDistanceSUM") |> PrefixedName
    /// <summary>
    ///   <para>dstv:MeasuredDistanceX</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/dstv#MeasuredDistanceX">http://w3id.org/dstv#MeasuredDistanceX</seealso>
    let MeasuredDistanceX = Prefixed_Name(dstv, "MeasuredDistanceX") |> PrefixedName
    /// <summary>
    ///   <para>dstv:MeasuredDistanceY</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/dstv#MeasuredDistanceY">http://w3id.org/dstv#MeasuredDistanceY</seealso>
    let MeasuredDistanceY = Prefixed_Name(dstv, "MeasuredDistanceY") |> PrefixedName
    /// <summary>
    ///   <para>dstv:MeasuredValues</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/dstv#MeasuredValues">http://w3id.org/dstv#MeasuredValues</seealso>
    let MeasuredValues = Prefixed_Name(dstv, "MeasuredValues") |> PrefixedName
    /// <summary>
    ///   <para>dstv:MeasurementProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/dstv#MeasurementProcess">http://w3id.org/dstv#MeasurementProcess</seealso>
    let MeasurementProcess = Prefixed_Name(dstv, "MeasurementProcess") |> PrefixedName
    /// <summary>
    ///   <para>dstv:PlannedDepth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/dstv#PlannedDepth">http://w3id.org/dstv#PlannedDepth</seealso>
    let PlannedDepth = Prefixed_Name(dstv, "PlannedDepth") |> PrefixedName
    /// <summary>
    ///   <para>dstv:PlannedDiameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/dstv#PlannedDiameter">http://w3id.org/dstv#PlannedDiameter</seealso>
    let PlannedDiameter = Prefixed_Name(dstv, "PlannedDiameter") |> PrefixedName
    /// <summary>
    ///   <para>dstv:PlannedDistanceSUM</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/dstv#PlannedDistanceSUM">http://w3id.org/dstv#PlannedDistanceSUM</seealso>
    let PlannedDistanceSUM = Prefixed_Name(dstv, "PlannedDistanceSUM") |> PrefixedName
    /// <summary>
    ///   <para>dstv:PlannedDistanceX</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/dstv#PlannedDistanceX">http://w3id.org/dstv#PlannedDistanceX</seealso>
    let PlannedDistanceX = Prefixed_Name(dstv, "PlannedDistanceX") |> PrefixedName
    /// <summary>
    ///   <para>dstv:PlannedDistanceY</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/dstv#PlannedDistanceY">http://w3id.org/dstv#PlannedDistanceY</seealso>
    let PlannedDistanceY = Prefixed_Name(dstv, "PlannedDistanceY") |> PrefixedName
    /// <summary>
    ///   <para>dstv:PlannedValues</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/dstv#PlannedValues">http://w3id.org/dstv#PlannedValues</seealso>
    let PlannedValues = Prefixed_Name(dstv, "PlannedValues") |> PrefixedName
    /// <summary>
    ///   <para>dstv:ProductionProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/dstv#ProductionProcess">http://w3id.org/dstv#ProductionProcess</seealso>
    let ProductionProcess = Prefixed_Name(dstv, "ProductionProcess") |> PrefixedName
    /// <summary>
    ///   <para>dstv:RearView</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"r"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/dstv#RearView">http://w3id.org/dstv#RearView</seealso>
    let RearView = Prefixed_Name(dstv, "RearView") |> PrefixedName
    /// <summary>
    ///   <para>dstv:ReferenceView</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/dstv#ReferenceView">http://w3id.org/dstv#ReferenceView</seealso>
    let ReferenceView = Prefixed_Name(dstv, "ReferenceView") |> PrefixedName

    /// <summary>
    ///   <para>dstv:SymmetricalReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/dstv#SymmetricalReference">http://w3id.org/dstv#SymmetricalReference</seealso>
    let SymmetricalReference =
        Prefixed_Name(dstv, "SymmetricalReference") |> PrefixedName

    /// <summary>
    ///   <para>dstv:ThroughHoleDrill</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The element hljob is an optional element of hl. It is created for each through hole of the corresponding reference plane."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"hljob"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/dstv#ThroughHoleDrill">http://w3id.org/dstv#ThroughHoleDrill</seealso>
    let ThroughHoleDrill = Prefixed_Name(dstv, "ThroughHoleDrill") |> PrefixedName

    /// <summary>
    ///   <para>dstv:ThroughHoleDrillMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/dstv#ThroughHoleDrillMeasurement">http://w3id.org/dstv#ThroughHoleDrillMeasurement</seealso>
    let ThroughHoleDrillMeasurement =
        Prefixed_Name(dstv, "ThroughHoleDrillMeasurement") |> PrefixedName

    /// <summary>
    ///   <para>dstv:ToleranceBool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/dstv#ToleranceBool">http://w3id.org/dstv#ToleranceBool</seealso>
    let ToleranceBool = Prefixed_Name(dstv, "ToleranceBool") |> PrefixedName
    /// <summary>
    ///   <para>dstv:ToleranceValues</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/dstv#ToleranceValues">http://w3id.org/dstv#ToleranceValues</seealso>
    let ToleranceValues = Prefixed_Name(dstv, "ToleranceValues") |> PrefixedName
    /// <summary>
    ///   <para>dstv:TopReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/dstv#TopReference">http://w3id.org/dstv#TopReference</seealso>
    let TopReference = Prefixed_Name(dstv, "TopReference") |> PrefixedName
    /// <summary>
    ///   <para>dstv:TopView</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"t"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/dstv#TopView">http://w3id.org/dstv#TopView</seealso>
    let TopView = Prefixed_Name(dstv, "TopView") |> PrefixedName
    /// <summary>
    ///   <para>dstv:TroughHole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/dstv#TroughHole">http://w3id.org/dstv#TroughHole</seealso>
    let TroughHole = Prefixed_Name(dstv, "TroughHole") |> PrefixedName
    /// <summary>
    ///   <para>dstv:ValidationProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/dstv#ValidationProcess">http://w3id.org/dstv#ValidationProcess</seealso>
    let ValidationProcess = Prefixed_Name(dstv, "ValidationProcess") |> PrefixedName
    /// <summary>
    ///   <para>dstv:Vertex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/dstv#Vertex">http://w3id.org/dstv#Vertex</seealso>
    let Vertex = Prefixed_Name(dstv, "Vertex") |> PrefixedName
    /// <summary>
    ///   <para>dstv:VertexX</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/dstv#VertexX">http://w3id.org/dstv#VertexX</seealso>
    let VertexX = Prefixed_Name(dstv, "VertexX") |> PrefixedName
    /// <summary>
    ///   <para>dstv:VertexY</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/dstv#VertexY">http://w3id.org/dstv#VertexY</seealso>
    let VertexY = Prefixed_Name(dstv, "VertexY") |> PrefixedName

    /// <summary>
    ///   <para>dstv:describedInIfcFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/dstv#describedInIfcFeature">http://w3id.org/dstv#describedInIfcFeature</seealso>
    let describedInIfcFeature =
        Prefixed_Name(dstv, "describedInIfcFeature") |> PrefixedName

    /// <summary>
    ///   <para>dstv:hasDeviationValues</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/dstv#hasDeviationValues">http://w3id.org/dstv#hasDeviationValues</seealso>
    let hasDeviationValues = Prefixed_Name(dstv, "hasDeviationValues") |> PrefixedName
    /// <summary>
    ///   <para>dstv:hasDiameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/dstv#hasDiameter">http://w3id.org/dstv#hasDiameter</seealso>
    let hasDiameter = Prefixed_Name(dstv, "hasDiameter") |> PrefixedName

    /// <summary>
    ///   <para>dstv:hasDiameterDeviation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/dstv#hasDiameterDeviation">http://w3id.org/dstv#hasDiameterDeviation</seealso>
    let hasDiameterDeviation =
        Prefixed_Name(dstv, "hasDiameterDeviation") |> PrefixedName

    /// <summary>
    ///   <para>dstv:hasDiameterTolerance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/dstv#hasDiameterTolerance">http://w3id.org/dstv#hasDiameterTolerance</seealso>
    let hasDiameterTolerance =
        Prefixed_Name(dstv, "hasDiameterTolerance") |> PrefixedName

    /// <summary>
    ///   <para>dstv:hasDimensionalReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/dstv#hasDimensionalReference">http://w3id.org/dstv#hasDimensionalReference</seealso>
    let hasDimensionalReference =
        Prefixed_Name(dstv, "hasDimensionalReference") |> PrefixedName

    /// <summary>
    ///   <para>dstv:hasFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/dstv#hasFeature">http://w3id.org/dstv#hasFeature</seealso>
    let hasFeature = Prefixed_Name(dstv, "hasFeature") |> PrefixedName
    /// <summary>
    ///   <para>dstv:hasMaxBound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/dstv#hasMaxBound">http://w3id.org/dstv#hasMaxBound</seealso>
    let hasMaxBound = Prefixed_Name(dstv, "hasMaxBound") |> PrefixedName
    /// <summary>
    ///   <para>dstv:hasMeasuredDiameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/dstv#hasMeasuredDiameter">http://w3id.org/dstv#hasMeasuredDiameter</seealso>
    let hasMeasuredDiameter = Prefixed_Name(dstv, "hasMeasuredDiameter") |> PrefixedName
    /// <summary>
    ///   <para>dstv:hasMeasuredValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/dstv#hasMeasuredValue">http://w3id.org/dstv#hasMeasuredValue</seealso>
    let hasMeasuredValue = Prefixed_Name(dstv, "hasMeasuredValue") |> PrefixedName
    /// <summary>
    ///   <para>dstv:hasMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/dstv#hasMeasurement">http://w3id.org/dstv#hasMeasurement</seealso>
    let hasMeasurement = Prefixed_Name(dstv, "hasMeasurement") |> PrefixedName
    /// <summary>
    ///   <para>dstv:hasMinBound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/dstv#hasMinBound">http://w3id.org/dstv#hasMinBound</seealso>
    let hasMinBound = Prefixed_Name(dstv, "hasMinBound") |> PrefixedName
    /// <summary>
    ///   <para>dstv:hasPlannedDiameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/dstv#hasPlannedDiameter">http://w3id.org/dstv#hasPlannedDiameter</seealso>
    let hasPlannedDiameter = Prefixed_Name(dstv, "hasPlannedDiameter") |> PrefixedName
    /// <summary>
    ///   <para>dstv:hasPlannedValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/dstv#hasPlannedValue">http://w3id.org/dstv#hasPlannedValue</seealso>
    let hasPlannedValue = Prefixed_Name(dstv, "hasPlannedValue") |> PrefixedName
    /// <summary>
    ///   <para>dstv:hasReferenceView</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"dstvNC Level"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/dstv#hasReferenceView">http://w3id.org/dstv#hasReferenceView</seealso>
    let hasReferenceView = Prefixed_Name(dstv, "hasReferenceView") |> PrefixedName
    /// <summary>
    ///   <para>dstv:hasTolerances</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/dstv#hasTolerances">http://w3id.org/dstv#hasTolerances</seealso>
    let hasTolerances = Prefixed_Name(dstv, "hasTolerances") |> PrefixedName
    /// <summary>
    ///   <para>dstv:hasVertex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/dstv#hasVertex">http://w3id.org/dstv#hasVertex</seealso>
    let hasVertex = Prefixed_Name(dstv, "hasVertex") |> PrefixedName
    /// <summary>
    ///   <para>dstv:hasVertexX</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/dstv#hasVertexX">http://w3id.org/dstv#hasVertexX</seealso>
    let hasVertexX = Prefixed_Name(dstv, "hasVertexX") |> PrefixedName
    /// <summary>
    ///   <para>dstv:hasVertexY</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/dstv#hasVertexY">http://w3id.org/dstv#hasVertexY</seealso>
    let hasVertexY = Prefixed_Name(dstv, "hasVertexY") |> PrefixedName
    /// <summary>
    ///   <para>dstv:inTolerance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/dstv#inTolerance">http://w3id.org/dstv#inTolerance</seealso>
    let inTolerance = Prefixed_Name(dstv, "inTolerance") |> PrefixedName
