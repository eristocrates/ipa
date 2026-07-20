namespace http.www.sensormeasurement.appspot.com.ont.transport.traffic.hash

open DoxAletheia

module traffic =
    let _namespace_name =
        "http://www.sensormeasurement.appspot.com/ont/transport/traffic#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#MaintainSpeed"></see>
    /// </summary>
    let MaintainSpeed = _prefix "MaintainSpeed"
    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#c"></see>
    /// </summary>
    let c = _prefix "c"
    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#Behind"></see>
    /// </summary>
    let Behind = _prefix "Behind"
    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#Overtaker"></see>
    /// </summary>
    let Overtaker = _prefix "Overtaker"
    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#bigSpeedDifference"></see>
    /// </summary>
    let bigSpeedDifference = _prefix "bigSpeedDifference"
    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#speedWithAheadCar"></see>
    /// </summary>
    let speedWithAheadCar = _prefix "speedWithAheadCar"
    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#speedWithBehindCar"></see>
    /// </summary>
    let speedWithBehindCar = _prefix "speedWithBehindCar"
    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#SoftDecelerate"></see>
    /// </summary>
    let SoftDecelerate = _prefix "SoftDecelerate"
    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#LastBeforeGap"></see>
    /// </summary>
    let LastBeforeGap = _prefix "LastBeforeGap"
    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#NotOvertaker"></see>
    /// </summary>
    let NotOvertaker = _prefix "NotOvertaker"
    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#speedWithOvertaker"></see>
    /// </summary>
    let speedWithOvertaker = _prefix "speedWithOvertaker"
    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#AfterGap"></see>
    /// </summary>
    let AfterGap = _prefix "AfterGap"
    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#isInFrontOfOvertaker"></see>
    /// </summary>
    let isInFrontOfOvertaker = _prefix "isInFrontOfOvertaker"
    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#Accelerate"></see>
    /// </summary>
    let Accelerate = _prefix "Accelerate"
    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#BeforeGap"></see>
    /// </summary>
    let BeforeGap = _prefix "BeforeGap"
    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#NoSpace"></see>
    /// </summary>
    let NoSpace = _prefix "NoSpace"
    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#FirstAfterGap"></see>
    /// </summary>
    let FirstAfterGap = _prefix "FirstAfterGap"
    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#Lateral"></see>
    /// </summary>
    let Lateral = _prefix "Lateral"
    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#speedWithBeforeTheGapCar"></see>
    /// </summary>
    let speedWithBeforeTheGapCar = _prefix "speedWithBeforeTheGapCar"
    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#SoftAccelerate"></see>
    /// </summary>
    let SoftAccelerate = _prefix "SoftAccelerate"
    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#Vehicle"></see>
    /// </summary>
    let Vehicle = _prefix "Vehicle"
    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#isOvertaking"></see>
    /// </summary>
    let isOvertaking = _prefix "isOvertaking"
    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#MaintainDistanceWithCarInFront"></see>
    /// </summary>
    let MaintainDistanceWithCarInFront = _prefix "MaintainDistanceWithCarInFront"
    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#hasSpaceAhead"></see>
    /// </summary>
    let hasSpaceAhead = _prefix "hasSpaceAhead"
    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#hasSpaceLateral"></see>
    /// </summary>
    let hasSpaceLateral = _prefix "hasSpaceLateral"
    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#Ahead"></see>
    /// </summary>
    let Ahead = _prefix "Ahead"
    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#beforeTheGap"></see>
    /// </summary>
    let beforeTheGap = _prefix "beforeTheGap"
    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#lastFirstBeforeAfter-TheGap"></see>
    /// </summary>
    let ``lastFirstBeforeAfter-TheGap`` = _prefix "lastFirstBeforeAfter-TheGap"
    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#hasSpaceBehind"></see>
    /// </summary>
    let hasSpaceBehind = _prefix "hasSpaceBehind"
    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#Decelerate"></see>
    /// </summary>
    let Decelerate = _prefix "Decelerate"
    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#ChangeLine"></see>
    /// </summary>
    let ChangeLine = _prefix "ChangeLine"
    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#Action"></see>
    /// </summary>
    let Action = _prefix "Action"
    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#isActionDoneBy"></see>
    /// </summary>
    let isActionDoneBy = _prefix "isActionDoneBy"
    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#Position"></see>
    /// </summary>
    let Position = _prefix "Position"
    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#Space"></see>
    /// </summary>
    let Space = _prefix "Space"
    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#Car1"></see>
    /// </summary>
    let Car1 = _prefix "Car1"
    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#Car2"></see>
    /// </summary>
    let Car2 = _prefix "Car2"
    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#Car3"></see>
    /// </summary>
    let Car3 = _prefix "Car3"
    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#Car4"></see>
    /// </summary>
    let Car4 = _prefix "Car4"
    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#doesAction"></see>
    /// </summary>
    let doesAction = _prefix "doesAction"
    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#position"></see>
    /// </summary>
    let position = _prefix "position"
    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#speedWith"></see>
    /// </summary>
    let speedWith = _prefix "speedWith"
    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#hasDirectionValue"></see>
    /// </summary>
    let hasDirectionValue = _prefix "hasDirectionValue"
    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#movement"></see>
    /// </summary>
    let movement = _prefix "movement"
    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#hasSpace"></see>
    /// </summary>
    let hasSpace = _prefix "hasSpace"
    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#hasSpeedValue"></see>
    /// </summary>
    let hasSpeedValue = _prefix "hasSpeedValue"
    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#hasXValue"></see>
    /// </summary>
    let hasXValue = _prefix "hasXValue"
    /// <summary>
    ///   <see href="http://www.sensormeasurement.appspot.com/ont/transport/traffic#hasYValue"></see>
    /// </summary>
    let hasYValue = _prefix "hasYValue"
