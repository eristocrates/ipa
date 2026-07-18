namespace http.www.sensormeasurement.appspot.com.ont.transport.traffic.hash

open DoxAletheia.Rdf_Vocabulary

module traffic =
    let _namespace_name =
        "http://www.sensormeasurement.appspot.com/ont/transport/traffic#"

    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#MaintainSpeed"></see>
    /// </summary>
    let MaintainSpeed =
        Namespaced_IRI.parse _namespace_name "MaintainSpeed" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#c"></see>
    /// </summary>
    let c = Namespaced_IRI.parse _namespace_name "c" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#Behind"></see>
    /// </summary>
    let Behind = Namespaced_IRI.parse _namespace_name "Behind" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#Overtaker"></see>
    /// </summary>
    let Overtaker = Namespaced_IRI.parse _namespace_name "Overtaker" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#bigSpeedDifference"></see>
    /// </summary>
    let bigSpeedDifference =
        Namespaced_IRI.parse _namespace_name "bigSpeedDifference" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#speedWithAheadCar"></see>
    /// </summary>
    let speedWithAheadCar =
        Namespaced_IRI.parse _namespace_name "speedWithAheadCar" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#speedWithBehindCar"></see>
    /// </summary>
    let speedWithBehindCar =
        Namespaced_IRI.parse _namespace_name "speedWithBehindCar" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#SoftDecelerate"></see>
    /// </summary>
    let SoftDecelerate =
        Namespaced_IRI.parse _namespace_name "SoftDecelerate" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#LastBeforeGap"></see>
    /// </summary>
    let LastBeforeGap =
        Namespaced_IRI.parse _namespace_name "LastBeforeGap" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#NotOvertaker"></see>
    /// </summary>
    let NotOvertaker =
        Namespaced_IRI.parse _namespace_name "NotOvertaker" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#speedWithOvertaker"></see>
    /// </summary>
    let speedWithOvertaker =
        Namespaced_IRI.parse _namespace_name "speedWithOvertaker" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#AfterGap"></see>
    /// </summary>
    let AfterGap = Namespaced_IRI.parse _namespace_name "AfterGap" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#isInFrontOfOvertaker"></see>
    /// </summary>
    let isInFrontOfOvertaker =
        Namespaced_IRI.parse _namespace_name "isInFrontOfOvertaker" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#Accelerate"></see>
    /// </summary>
    let Accelerate = Namespaced_IRI.parse _namespace_name "Accelerate" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#BeforeGap"></see>
    /// </summary>
    let BeforeGap = Namespaced_IRI.parse _namespace_name "BeforeGap" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#NoSpace"></see>
    /// </summary>
    let NoSpace = Namespaced_IRI.parse _namespace_name "NoSpace" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#FirstAfterGap"></see>
    /// </summary>
    let FirstAfterGap =
        Namespaced_IRI.parse _namespace_name "FirstAfterGap" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#Lateral"></see>
    /// </summary>
    let Lateral = Namespaced_IRI.parse _namespace_name "Lateral" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#speedWithBeforeTheGapCar"></see>
    /// </summary>
    let speedWithBeforeTheGapCar =
        Namespaced_IRI.parse _namespace_name "speedWithBeforeTheGapCar" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#SoftAccelerate"></see>
    /// </summary>
    let SoftAccelerate =
        Namespaced_IRI.parse _namespace_name "SoftAccelerate" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#Vehicle"></see>
    /// </summary>
    let Vehicle = Namespaced_IRI.parse _namespace_name "Vehicle" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#isOvertaking"></see>
    /// </summary>
    let isOvertaking =
        Namespaced_IRI.parse _namespace_name "isOvertaking" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#MaintainDistanceWithCarInFront"></see>
    /// </summary>
    let MaintainDistanceWithCarInFront =
        Namespaced_IRI.parse _namespace_name "MaintainDistanceWithCarInFront" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#hasSpaceAhead"></see>
    /// </summary>
    let hasSpaceAhead =
        Namespaced_IRI.parse _namespace_name "hasSpaceAhead" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#hasSpaceLateral"></see>
    /// </summary>
    let hasSpaceLateral =
        Namespaced_IRI.parse _namespace_name "hasSpaceLateral" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#Ahead"></see>
    /// </summary>
    let Ahead = Namespaced_IRI.parse _namespace_name "Ahead" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#beforeTheGap"></see>
    /// </summary>
    let beforeTheGap =
        Namespaced_IRI.parse _namespace_name "beforeTheGap" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#lastFirstBeforeAfter-TheGap"></see>
    /// </summary>
    let ``lastFirstBeforeAfter-TheGap`` =
        Namespaced_IRI.parse _namespace_name "lastFirstBeforeAfter-TheGap" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#hasSpaceBehind"></see>
    /// </summary>
    let hasSpaceBehind =
        Namespaced_IRI.parse _namespace_name "hasSpaceBehind" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#Decelerate"></see>
    /// </summary>
    let Decelerate = Namespaced_IRI.parse _namespace_name "Decelerate" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#ChangeLine"></see>
    /// </summary>
    let ChangeLine = Namespaced_IRI.parse _namespace_name "ChangeLine" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#Action"></see>
    /// </summary>
    let Action = Namespaced_IRI.parse _namespace_name "Action" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#isActionDoneBy"></see>
    /// </summary>
    let isActionDoneBy =
        Namespaced_IRI.parse _namespace_name "isActionDoneBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#Position"></see>
    /// </summary>
    let Position = Namespaced_IRI.parse _namespace_name "Position" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#Space"></see>
    /// </summary>
    let Space = Namespaced_IRI.parse _namespace_name "Space" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#Car1"></see>
    /// </summary>
    let Car1 = Namespaced_IRI.parse _namespace_name "Car1" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#Car2"></see>
    /// </summary>
    let Car2 = Namespaced_IRI.parse _namespace_name "Car2" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#Car3"></see>
    /// </summary>
    let Car3 = Namespaced_IRI.parse _namespace_name "Car3" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#Car4"></see>
    /// </summary>
    let Car4 = Namespaced_IRI.parse _namespace_name "Car4" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#doesAction"></see>
    /// </summary>
    let doesAction = Namespaced_IRI.parse _namespace_name "doesAction" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#position"></see>
    /// </summary>
    let position = Namespaced_IRI.parse _namespace_name "position" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#speedWith"></see>
    /// </summary>
    let speedWith = Namespaced_IRI.parse _namespace_name "speedWith" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#hasDirectionValue"></see>
    /// </summary>
    let hasDirectionValue =
        Namespaced_IRI.parse _namespace_name "hasDirectionValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#movement"></see>
    /// </summary>
    let movement = Namespaced_IRI.parse _namespace_name "movement" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#hasSpace"></see>
    /// </summary>
    let hasSpace = Namespaced_IRI.parse _namespace_name "hasSpace" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#hasSpeedValue"></see>
    /// </summary>
    let hasSpeedValue =
        Namespaced_IRI.parse _namespace_name "hasSpeedValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#hasXValue"></see>
    /// </summary>
    let hasXValue = Namespaced_IRI.parse _namespace_name "hasXValue" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#hasYValue"></see>
    /// </summary>
    let hasYValue = Namespaced_IRI.parse _namespace_name "hasYValue" |> NamespacedName
