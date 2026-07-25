namespace http.www.sensormeasurement.appspot.com.ont.transport.traffic.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module traffic =
    let _namespace_iri = Namespace_Iri traffic |> NamespaceIRI
    /// <summary>
    ///   <para>traffic:c</para>
    /// </summary>
    /// <remarks>
    ///   <para>swrl:Variable</para>
    /// </remarks>
    /// <seealso href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#c">http://www.sensormeasurement.appspot.com/ont/transport/traffic#c</seealso>
    let c = Prefixed_Name(traffic, "c") |> PrefixedName
    /// <summary>
    ///   <para>traffic:MaintainSpeed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#MaintainSpeed">http://www.sensormeasurement.appspot.com/ont/transport/traffic#MaintainSpeed</seealso>
    let MaintainSpeed = Prefixed_Name(traffic, "MaintainSpeed") |> PrefixedName

    /// <summary>
    ///   <para>traffic:bigSpeedDifference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#bigSpeedDifference">http://www.sensormeasurement.appspot.com/ont/transport/traffic#bigSpeedDifference</seealso>
    let bigSpeedDifference =
        Prefixed_Name(traffic, "bigSpeedDifference") |> PrefixedName

    /// <summary>
    ///   <para>traffic:Vehicle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#Vehicle">http://www.sensormeasurement.appspot.com/ont/transport/traffic#Vehicle</seealso>
    let Vehicle = Prefixed_Name(traffic, "Vehicle") |> PrefixedName
    /// <summary>
    ///   <para>traffic:Accelerate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#Accelerate">http://www.sensormeasurement.appspot.com/ont/transport/traffic#Accelerate</seealso>
    let Accelerate = Prefixed_Name(traffic, "Accelerate") |> PrefixedName

    /// <summary>
    ///   <para>traffic:speedWithBehindCar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#speedWithBehindCar">http://www.sensormeasurement.appspot.com/ont/transport/traffic#speedWithBehindCar</seealso>
    let speedWithBehindCar =
        Prefixed_Name(traffic, "speedWithBehindCar") |> PrefixedName

    /// <summary>
    ///   <para>traffic:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>voaf:Vocabulary</para>
    ///   <para>owl:Ontology</para>
    ///   <para> An ontology to describe the management of the traffic</para>
    /// </remarks>
    /// <seealso href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#">http://www.sensormeasurement.appspot.com/ont/transport/traffic#</seealso>
    let _prefix_iri = Prefixed_Name(traffic, "") |> PrefixedName
    /// <summary>
    ///   <para>traffic:Action</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#Action">http://www.sensormeasurement.appspot.com/ont/transport/traffic#Action</seealso>
    let Action = Prefixed_Name(traffic, "Action") |> PrefixedName
    /// <summary>
    ///   <para>traffic:isActionDoneBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#isActionDoneBy">http://www.sensormeasurement.appspot.com/ont/transport/traffic#isActionDoneBy</seealso>
    let isActionDoneBy = Prefixed_Name(traffic, "isActionDoneBy") |> PrefixedName
    /// <summary>
    ///   <para>traffic:Position</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#Position">http://www.sensormeasurement.appspot.com/ont/transport/traffic#Position</seealso>
    let Position = Prefixed_Name(traffic, "Position") |> PrefixedName
    /// <summary>
    ///   <para>traffic:Space</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#Space">http://www.sensormeasurement.appspot.com/ont/transport/traffic#Space</seealso>
    let Space = Prefixed_Name(traffic, "Space") |> PrefixedName
    /// <summary>
    ///   <para>traffic:Car1</para>
    /// </summary>
    /// <remarks>
    ///   <para>traffic:Vehicle</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#Car1">http://www.sensormeasurement.appspot.com/ont/transport/traffic#Car1</seealso>
    let Car1 = Prefixed_Name(traffic, "Car1") |> PrefixedName
    /// <summary>
    ///   <para>traffic:Car2</para>
    /// </summary>
    /// <remarks>
    ///   <para>traffic:Vehicle</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#Car2">http://www.sensormeasurement.appspot.com/ont/transport/traffic#Car2</seealso>
    let Car2 = Prefixed_Name(traffic, "Car2") |> PrefixedName
    /// <summary>
    ///   <para>traffic:Car3</para>
    /// </summary>
    /// <remarks>
    ///   <para>traffic:Vehicle</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#Car3">http://www.sensormeasurement.appspot.com/ont/transport/traffic#Car3</seealso>
    let Car3 = Prefixed_Name(traffic, "Car3") |> PrefixedName
    /// <summary>
    ///   <para>traffic:Car4</para>
    /// </summary>
    /// <remarks>
    ///   <para>traffic:Vehicle</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#Car4">http://www.sensormeasurement.appspot.com/ont/transport/traffic#Car4</seealso>
    let Car4 = Prefixed_Name(traffic, "Car4") |> PrefixedName
    /// <summary>
    ///   <para>traffic:doesAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#doesAction">http://www.sensormeasurement.appspot.com/ont/transport/traffic#doesAction</seealso>
    let doesAction = Prefixed_Name(traffic, "doesAction") |> PrefixedName
    /// <summary>
    ///   <para>traffic:position</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#position">http://www.sensormeasurement.appspot.com/ont/transport/traffic#position</seealso>
    let position = Prefixed_Name(traffic, "position") |> PrefixedName
    /// <summary>
    ///   <para>traffic:speedWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#speedWith">http://www.sensormeasurement.appspot.com/ont/transport/traffic#speedWith</seealso>
    let speedWith = Prefixed_Name(traffic, "speedWith") |> PrefixedName
    /// <summary>
    ///   <para>traffic:hasDirectionValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#hasDirectionValue">http://www.sensormeasurement.appspot.com/ont/transport/traffic#hasDirectionValue</seealso>
    let hasDirectionValue = Prefixed_Name(traffic, "hasDirectionValue") |> PrefixedName
    /// <summary>
    ///   <para>traffic:movement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#movement">http://www.sensormeasurement.appspot.com/ont/transport/traffic#movement</seealso>
    let movement = Prefixed_Name(traffic, "movement") |> PrefixedName
    /// <summary>
    ///   <para>traffic:hasSpace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#hasSpace">http://www.sensormeasurement.appspot.com/ont/transport/traffic#hasSpace</seealso>
    let hasSpace = Prefixed_Name(traffic, "hasSpace") |> PrefixedName
    /// <summary>
    ///   <para>traffic:hasSpeedValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#hasSpeedValue">http://www.sensormeasurement.appspot.com/ont/transport/traffic#hasSpeedValue</seealso>
    let hasSpeedValue = Prefixed_Name(traffic, "hasSpeedValue") |> PrefixedName
    /// <summary>
    ///   <para>traffic:hasXValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#hasXValue">http://www.sensormeasurement.appspot.com/ont/transport/traffic#hasXValue</seealso>
    let hasXValue = Prefixed_Name(traffic, "hasXValue") |> PrefixedName
    /// <summary>
    ///   <para>traffic:SoftDecelerate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#SoftDecelerate">http://www.sensormeasurement.appspot.com/ont/transport/traffic#SoftDecelerate</seealso>
    let SoftDecelerate = Prefixed_Name(traffic, "SoftDecelerate") |> PrefixedName
    /// <summary>
    ///   <para>traffic:LastBeforeGap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#LastBeforeGap">http://www.sensormeasurement.appspot.com/ont/transport/traffic#LastBeforeGap</seealso>
    let LastBeforeGap = Prefixed_Name(traffic, "LastBeforeGap") |> PrefixedName
    /// <summary>
    ///   <para>traffic:NotOvertaker</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#NotOvertaker">http://www.sensormeasurement.appspot.com/ont/transport/traffic#NotOvertaker</seealso>
    let NotOvertaker = Prefixed_Name(traffic, "NotOvertaker") |> PrefixedName
    /// <summary>
    ///   <para>traffic:beforeTheGap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#beforeTheGap">http://www.sensormeasurement.appspot.com/ont/transport/traffic#beforeTheGap</seealso>
    let beforeTheGap = Prefixed_Name(traffic, "beforeTheGap") |> PrefixedName

    /// <summary>
    ///   <para>traffic:lastFirstBeforeAfter-TheGap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#lastFirstBeforeAfter-TheGap">http://www.sensormeasurement.appspot.com/ont/transport/traffic#lastFirstBeforeAfter-TheGap</seealso>
    let lastFirstBeforeAfter_TheGap =
        Prefixed_Name(traffic, "lastFirstBeforeAfter-TheGap") |> PrefixedName

    /// <summary>
    ///   <para>traffic:speedWithOvertaker</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#speedWithOvertaker">http://www.sensormeasurement.appspot.com/ont/transport/traffic#speedWithOvertaker</seealso>
    let speedWithOvertaker =
        Prefixed_Name(traffic, "speedWithOvertaker") |> PrefixedName

    /// <summary>
    ///   <para>traffic:isInFrontOfOvertaker</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#isInFrontOfOvertaker">http://www.sensormeasurement.appspot.com/ont/transport/traffic#isInFrontOfOvertaker</seealso>
    let isInFrontOfOvertaker =
        Prefixed_Name(traffic, "isInFrontOfOvertaker") |> PrefixedName

    /// <summary>
    ///   <para>traffic:AfterGap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#AfterGap">http://www.sensormeasurement.appspot.com/ont/transport/traffic#AfterGap</seealso>
    let AfterGap = Prefixed_Name(traffic, "AfterGap") |> PrefixedName
    /// <summary>
    ///   <para>traffic:hasSpaceBehind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#hasSpaceBehind">http://www.sensormeasurement.appspot.com/ont/transport/traffic#hasSpaceBehind</seealso>
    let hasSpaceBehind = Prefixed_Name(traffic, "hasSpaceBehind") |> PrefixedName
    /// <summary>
    ///   <para>traffic:Decelerate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#Decelerate">http://www.sensormeasurement.appspot.com/ont/transport/traffic#Decelerate</seealso>
    let Decelerate = Prefixed_Name(traffic, "Decelerate") |> PrefixedName
    /// <summary>
    ///   <para>traffic:Ahead</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#Ahead">http://www.sensormeasurement.appspot.com/ont/transport/traffic#Ahead</seealso>
    let Ahead = Prefixed_Name(traffic, "Ahead") |> PrefixedName
    /// <summary>
    ///   <para>traffic:hasYValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#hasYValue">http://www.sensormeasurement.appspot.com/ont/transport/traffic#hasYValue</seealso>
    let hasYValue = Prefixed_Name(traffic, "hasYValue") |> PrefixedName
    /// <summary>
    ///   <para>traffic:BeforeGap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#BeforeGap">http://www.sensormeasurement.appspot.com/ont/transport/traffic#BeforeGap</seealso>
    let BeforeGap = Prefixed_Name(traffic, "BeforeGap") |> PrefixedName
    /// <summary>
    ///   <para>traffic:ChangeLine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#ChangeLine">http://www.sensormeasurement.appspot.com/ont/transport/traffic#ChangeLine</seealso>
    let ChangeLine = Prefixed_Name(traffic, "ChangeLine") |> PrefixedName
    /// <summary>
    ///   <para>traffic:Lateral</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#Lateral">http://www.sensormeasurement.appspot.com/ont/transport/traffic#Lateral</seealso>
    let Lateral = Prefixed_Name(traffic, "Lateral") |> PrefixedName
    /// <summary>
    ///   <para>traffic:SoftAccelerate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#SoftAccelerate">http://www.sensormeasurement.appspot.com/ont/transport/traffic#SoftAccelerate</seealso>
    let SoftAccelerate = Prefixed_Name(traffic, "SoftAccelerate") |> PrefixedName
    /// <summary>
    ///   <para>traffic:isOvertaking</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#isOvertaking">http://www.sensormeasurement.appspot.com/ont/transport/traffic#isOvertaking</seealso>
    let isOvertaking = Prefixed_Name(traffic, "isOvertaking") |> PrefixedName

    /// <summary>
    ///   <para>traffic:MaintainDistanceWithCarInFront</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#MaintainDistanceWithCarInFront">http://www.sensormeasurement.appspot.com/ont/transport/traffic#MaintainDistanceWithCarInFront</seealso>
    let MaintainDistanceWithCarInFront =
        Prefixed_Name(traffic, "MaintainDistanceWithCarInFront") |> PrefixedName

    /// <summary>
    ///   <para>traffic:hasSpaceAhead</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#hasSpaceAhead">http://www.sensormeasurement.appspot.com/ont/transport/traffic#hasSpaceAhead</seealso>
    let hasSpaceAhead = Prefixed_Name(traffic, "hasSpaceAhead") |> PrefixedName
    /// <summary>
    ///   <para>traffic:hasSpaceLateral</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#hasSpaceLateral">http://www.sensormeasurement.appspot.com/ont/transport/traffic#hasSpaceLateral</seealso>
    let hasSpaceLateral = Prefixed_Name(traffic, "hasSpaceLateral") |> PrefixedName
    /// <summary>
    ///   <para>traffic:Behind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#Behind">http://www.sensormeasurement.appspot.com/ont/transport/traffic#Behind</seealso>
    let Behind = Prefixed_Name(traffic, "Behind") |> PrefixedName
    /// <summary>
    ///   <para>traffic:Overtaker</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#Overtaker">http://www.sensormeasurement.appspot.com/ont/transport/traffic#Overtaker</seealso>
    let Overtaker = Prefixed_Name(traffic, "Overtaker") |> PrefixedName
    /// <summary>
    ///   <para>traffic:speedWithAheadCar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#speedWithAheadCar">http://www.sensormeasurement.appspot.com/ont/transport/traffic#speedWithAheadCar</seealso>
    let speedWithAheadCar = Prefixed_Name(traffic, "speedWithAheadCar") |> PrefixedName
    /// <summary>
    ///   <para>traffic:NoSpace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#NoSpace">http://www.sensormeasurement.appspot.com/ont/transport/traffic#NoSpace</seealso>
    let NoSpace = Prefixed_Name(traffic, "NoSpace") |> PrefixedName
    /// <summary>
    ///   <para>traffic:FirstAfterGap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#FirstAfterGap">http://www.sensormeasurement.appspot.com/ont/transport/traffic#FirstAfterGap</seealso>
    let FirstAfterGap = Prefixed_Name(traffic, "FirstAfterGap") |> PrefixedName

    /// <summary>
    ///   <para>traffic:speedWithBeforeTheGapCar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#speedWithBeforeTheGapCar">http://www.sensormeasurement.appspot.com/ont/transport/traffic#speedWithBeforeTheGapCar</seealso>
    let speedWithBeforeTheGapCar =
        Prefixed_Name(traffic, "speedWithBeforeTheGapCar") |> PrefixedName
