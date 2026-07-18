namespace http.cef.uv.es.lodroadtran18.def.transporte.dtx_srti.hash

open DoxAletheia.Rdf_Vocabulary

module dtx_srti =
    let _namespace_name = "http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#"
    /// <summary>
    /// An air crash adjacent to the roadway which may cause traffic disruption.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#airCrash"></see></summary>
    let airCrash = Namespaced_IRI.parse _namespace_name "airCrash" |> NamespacedName

    /// <summary>
    /// Children on the roadway which may cause traffic disruption.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#childrenOnRoadway"></see></summary>
    let childrenOnRoadway =
        Namespaced_IRI.parse _namespace_name "childrenOnRoadway" |> NamespacedName

    /// <summary>
    /// Clearance work associated with an earlier traffic problem which may cause traffic disruption.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#clearanceWork"></see></summary>
    let clearanceWork =
        Namespaced_IRI.parse _namespace_name "clearanceWork" |> NamespacedName

    /// <summary>
    /// Cyclists on the roadway which may cause traffic disruption.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#cyclistsOnRoadway"></see></summary>
    let cyclistsOnRoadway =
        Namespaced_IRI.parse _namespace_name "cyclistsOnRoadway" |> NamespacedName

    /// <summary>
    /// Incidents are chance occurrences involving vehicles from the traffic stream, which could present potential hazards to road users.  This item excludes accidents.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#incident"></see></summary>
    let incident = Namespaced_IRI.parse _namespace_name "incident" |> NamespacedName

    /// <summary>
    /// The road may be obstructed or traffic hindered due to objects laying on the roadway.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#objectOnTheRoad"></see></summary>
    let objectOnTheRoad =
        Namespaced_IRI.parse _namespace_name "objectOnTheRoad" |> NamespacedName

    /// <summary>
    /// Other. Other than as defined in this enumeration.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#other"></see></summary>
    let other = Namespaced_IRI.parse _namespace_name "other" |> NamespacedName

    /// <summary>
    /// People on the roadway which may cause traffic disruption.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#peopleOnRoadway"></see></summary>
    let peopleOnRoadway =
        Namespaced_IRI.parse _namespace_name "peopleOnRoadway" |> NamespacedName

    /// <summary>
    /// A rail crash adjacent to the roadway which may cause traffic disruption.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#railCrash"></see></summary>
    let railCrash = Namespaced_IRI.parse _namespace_name "railCrash" |> NamespacedName

    /// <summary>
    /// Work is being undertaken by emergency services which may present a hazard to road users.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#rescueAndRecoveryWork"></see></summary>
    let rescueAndRecoveryWork =
        Namespaced_IRI.parse _namespace_name "rescueAndRecoveryWork" |> NamespacedName

    /// <summary>
    /// Spillage of transported goods on the roadway which may cause traffic disruption.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#shedLoad"></see></summary>
    let shedLoad = Namespaced_IRI.parse _namespace_name "shedLoad" |> NamespacedName

    /// <summary>
    /// Includes all situations where a spillage has occurred on the roadway due to an earlier incident.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#spillageOnTheRoad"></see></summary>
    let spillageOnTheRoad =
        Namespaced_IRI.parse _namespace_name "spillageOnTheRoad" |> NamespacedName

    /// <summary>
    /// An accident area which has not been protected and may present a hazard to road users.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#unprotectedAccidentArea"></see></summary>
    let unprotectedAccidentArea =
        Namespaced_IRI.parse _namespace_name "unprotectedAccidentArea" |> NamespacedName

    /// <summary>
    /// Maintenance of road, associated infrastructure or equipments.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#maintenanceWork"></see></summary>
    let maintenanceWork =
        Namespaced_IRI.parse _namespace_name "maintenanceWork" |> NamespacedName

    /// <summary>
    /// Repair work to road, associated infrastructure or equipments.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#repairWork"></see></summary>
    let repairWork = Namespaced_IRI.parse _namespace_name "repairWork" |> NamespacedName

    /// <summary>
    /// Work associated with relaying or renewal of worn-out road surface (pavement).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#resurfacingWork"></see></summary>
    let resurfacingWork =
        Namespaced_IRI.parse _namespace_name "resurfacingWork" |> NamespacedName

    /// <summary>
    /// Striping and repainting of road markings, plus placement or replacement of reflecting studs (cats' eyes).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadMarkingWork"></see></summary>
    let roadMarkingWork =
        Namespaced_IRI.parse _namespace_name "roadMarkingWork" |> NamespacedName

    /// <summary>
    /// Snowploughs or other similar mechanical devices in use to clear snow from the road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#snowploughsInUse"></see></summary>
    let snowploughsInUse =
        Namespaced_IRI.parse _namespace_name "snowploughsInUse" |> NamespacedName

    /// <summary>
    /// Value measured vertically above the reference ellipsoid
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ellipsoidalHeight"></see></summary>
    let ellipsoidalHeight =
        Namespaced_IRI.parse _namespace_name "ellipsoidalHeight" |> NamespacedName

    /// <summary>
    /// Height type corresponding a value measured along direction of gravity above the reference geoid i.e. equipotential surface of the Earth's gravity field which globally approximates mean sea level.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#gravityRelatedHeight"></see></summary>
    let gravityRelatedHeight =
        Namespaced_IRI.parse _namespace_name "gravityRelatedHeight" |> NamespacedName

    /// <summary>
    /// Height type corresponding to value masured vertically above the ground level at this point.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#relativeHeight"></see></summary>
    let relativeHeight =
        Namespaced_IRI.parse _namespace_name "relativeHeight" |> NamespacedName

    /// <summary>
    /// Dissemination of the information is extremely urgent.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#extremelyUrgent"></see></summary>
    let extremelyUrgent =
        Namespaced_IRI.parse _namespace_name "extremelyUrgent" |> NamespacedName

    /// <summary>
    /// Dissemination of the information is of normal urgency.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#normalUrgency"></see></summary>
    let normalUrgency =
        Namespaced_IRI.parse _namespace_name "normalUrgency" |> NamespacedName

    /// <summary>
    /// Dissemination of the information is urgent.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#urgent"></see></summary>
    let urgent = Namespaced_IRI.parse _namespace_name "urgent" |> NamespacedName

    /// <summary>
    /// A patrol of an automobile club.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#automobileClubPatrol"></see></summary>
    let automobileClubPatrol =
        Namespaced_IRI.parse _namespace_name "automobileClubPatrol" |> NamespacedName

    /// <summary>
    /// A camera observation (either still or video camera).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#cameraObservation"></see></summary>
    let cameraObservation =
        Namespaced_IRI.parse _namespace_name "cameraObservation" |> NamespacedName

    /// <summary>
    /// An operator of freight vehicles.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#freightVehicleOperator"></see></summary>
    let freightVehicleOperator =
        Namespaced_IRI.parse _namespace_name "freightVehicleOperator" |> NamespacedName

    /// <summary>
    /// A station dedicated to the monitoring of the road network by processing inductive loop information.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#inductionLoopMonitoringStation"></see></summary>
    let inductionLoopMonitoringStation =
        Namespaced_IRI.parse _namespace_name "inductionLoopMonitoringStation" |> NamespacedName

    /// <summary>
    /// A station dedicated to the monitoring of the road network by processing infrared image information.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#infraredMonitoringStation"></see></summary>
    let infraredMonitoringStation =
        Namespaced_IRI.parse _namespace_name "infraredMonitoringStation" |> NamespacedName

    /// <summary>
    /// A station dedicated to the monitoring of the road network by processing microwave information.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#microwaveMonitoringStation"></see></summary>
    let microwaveMonitoringStation =
        Namespaced_IRI.parse _namespace_name "microwaveMonitoringStation" |> NamespacedName

    /// <summary>
    /// A caller using a mobile telephone (who may or may not be on the road network).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#mobileTelephoneCaller"></see></summary>
    let mobileTelephoneCaller =
        Namespaced_IRI.parse _namespace_name "mobileTelephoneCaller" |> NamespacedName

    /// <summary>
    /// Emergency service patrols other than police.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#nonPoliceEmergencyServicePatrol"></see></summary>
    let nonPoliceEmergencyServicePatrol =
        Namespaced_IRI.parse _namespace_name "nonPoliceEmergencyServicePatrol" |> NamespacedName

    /// <summary>
    /// Personnel from a vehicle belonging to the road operator or authority or any emergency service, including authorised breakdown service organisations.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#otherOfficialVehicle"></see></summary>
    let otherOfficialVehicle =
        Namespaced_IRI.parse _namespace_name "otherOfficialVehicle" |> NamespacedName

    /// <summary>
    /// A police patrol.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#policePatrol"></see></summary>
    let policePatrol =
        Namespaced_IRI.parse _namespace_name "policePatrol" |> NamespacedName

    /// <summary>
    /// A private breakdown service.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#privateBreakdownService"></see></summary>
    let privateBreakdownService =
        Namespaced_IRI.parse _namespace_name "privateBreakdownService" |> NamespacedName

    /// <summary>
    /// A utility organisation, either public or private.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#publicAndPrivateUtilities"></see></summary>
    let publicAndPrivateUtilities =
        Namespaced_IRI.parse _namespace_name "publicAndPrivateUtilities" |> NamespacedName

    /// <summary>
    /// A motorist who is an officially registered observer.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#registeredMotoristObserver"></see></summary>
    let registeredMotoristObserver =
        Namespaced_IRI.parse _namespace_name "registeredMotoristObserver" |> NamespacedName

    /// <summary>
    /// A road authority.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadAuthorities"></see></summary>
    let roadAuthorities =
        Namespaced_IRI.parse _namespace_name "roadAuthorities" |> NamespacedName

    /// <summary>
    /// A patrol of the road operator or authority.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadOperatorPatrol"></see></summary>
    let roadOperatorPatrol =
        Namespaced_IRI.parse _namespace_name "roadOperatorPatrol" |> NamespacedName

    /// <summary>
    /// A caller who is using an emergency roadside telephone.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadsideTelephoneCaller"></see></summary>
    let roadsideTelephoneCaller =
        Namespaced_IRI.parse _namespace_name "roadsideTelephoneCaller" |> NamespacedName

    /// <summary>
    /// A spotter aircraft of an organisation specifically assigned to the monitoring of the traffic network.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#spotterAircraft"></see></summary>
    let spotterAircraft =
        Namespaced_IRI.parse _namespace_name "spotterAircraft" |> NamespacedName

    /// <summary>
    /// A station, usually automatic, dedicated to the monitoring of the road network.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#trafficMonitoringStation"></see></summary>
    let trafficMonitoringStation =
        Namespaced_IRI.parse _namespace_name "trafficMonitoringStation" |> NamespacedName

    /// <summary>
    /// An operator of a transit service, e.g. bus link operator.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#transitOperator"></see></summary>
    let transitOperator =
        Namespaced_IRI.parse _namespace_name "transitOperator" |> NamespacedName

    /// <summary>
    /// A specially equipped vehicle used to provide measurements.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#vehicleProbeMeasurement"></see></summary>
    let vehicleProbeMeasurement =
        Namespaced_IRI.parse _namespace_name "vehicleProbeMeasurement" |> NamespacedName

    /// <summary>
    /// A station dedicated to the monitoring of the road network by processing video image information.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#videoProcessingMonitoringStation"></see></summary>
    let videoProcessingMonitoringStation =
        Namespaced_IRI.parse _namespace_name "videoProcessingMonitoringStation" |> NamespacedName

    /// <summary>
    /// Against line direction
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#againstLineDirection"></see></summary>
    let againstLineDirection =
        Namespaced_IRI.parse _namespace_name "againstLineDirection" |> NamespacedName

    /// <summary>
    /// Both directions.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#bothDirections"></see></summary>
    let bothDirections =
        Namespaced_IRI.parse _namespace_name "bothDirections" |> NamespacedName

    /// <summary>
    /// No orientation or unknown
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#noOrientationOrUnknown"></see></summary>
    let noOrientationOrUnknown =
        Namespaced_IRI.parse _namespace_name "noOrientationOrUnknown" |> NamespacedName

    /// <summary>
    /// With line direction
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#withLineDirection"></see></summary>
    let withLineDirection =
        Namespaced_IRI.parse _namespace_name "withLineDirection" |> NamespacedName

    /// <summary>
    /// Allow emergency vehicles to pass
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#allowEmergencyVehiclesToPass"></see></summary>
    let allowEmergencyVehiclesToPass =
        Namespaced_IRI.parse _namespace_name "allowEmergencyVehiclesToPass" |> NamespacedName

    /// <summary>
    /// Approach with care
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#approachWithCare"></see></summary>
    let approachWithCare =
        Namespaced_IRI.parse _namespace_name "approachWithCare" |> NamespacedName

    /// <summary>
    /// Avoid the area
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#avoidTheArea"></see></summary>
    let avoidTheArea =
        Namespaced_IRI.parse _namespace_name "avoidTheArea" |> NamespacedName

    /// <summary>
    /// Close all windows turn off heater and vents
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#closeAllWindowsTurnOffHeaterAndVents"></see></summary>
    let closeAllWindowsTurnOffHeaterAndVents =
        Namespaced_IRI.parse _namespace_name "closeAllWindowsTurnOffHeaterAndVents" |> NamespacedName

    /// <summary>
    /// Cross junction with care
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#crossJunctionWithCare"></see></summary>
    let crossJunctionWithCare =
        Namespaced_IRI.parse _namespace_name "crossJunctionWithCare" |> NamespacedName

    /// <summary>
    /// Do not allow unnecessary gaps
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#doNotAllowUnnecessaryGaps"></see></summary>
    let doNotAllowUnnecessaryGaps =
        Namespaced_IRI.parse _namespace_name "doNotAllowUnnecessaryGaps" |> NamespacedName

    /// <summary>
    /// Do not leave your vehicle
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#doNotLeaveYourVehicle"></see></summary>
    let doNotLeaveYourVehicle =
        Namespaced_IRI.parse _namespace_name "doNotLeaveYourVehicle" |> NamespacedName

    /// <summary>
    /// Do not throw out any burning objects
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#doNotThrowOutAnyBurningObjects"></see></summary>
    let doNotThrowOutAnyBurningObjects =
        Namespaced_IRI.parse _namespace_name "doNotThrowOutAnyBurningObjects" |> NamespacedName

    /// <summary>
    /// Do not use navigation systems
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#doNotUseNavigationSystems"></see></summary>
    let doNotUseNavigationSystems =
        Namespaced_IRI.parse _namespace_name "doNotUseNavigationSystems" |> NamespacedName

    /// <summary>
    /// Drive carefully.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#driveCarefully"></see></summary>
    let driveCarefully =
        Namespaced_IRI.parse _namespace_name "driveCarefully" |> NamespacedName

    /// <summary>
    /// Drive with extreme caution
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#driveWithExtremeCaution"></see></summary>
    let driveWithExtremeCaution =
        Namespaced_IRI.parse _namespace_name "driveWithExtremeCaution" |> NamespacedName

    /// <summary>
    /// Flash your lights
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#flashYourLights"></see></summary>
    let flashYourLights =
        Namespaced_IRI.parse _namespace_name "flashYourLights" |> NamespacedName

    /// <summary>
    /// Follow the vehicle in front smoothly
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#followTheVehicleInFrontSmoothly"></see></summary>
    let followTheVehicleInFrontSmoothly =
        Namespaced_IRI.parse _namespace_name "followTheVehicleInFrontSmoothly" |> NamespacedName

    /// <summary>
    /// In emergency wait for patrol service
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#inEmergencyWaitForPatrolService"></see></summary>
    let inEmergencyWaitForPatrolService =
        Namespaced_IRI.parse _namespace_name "inEmergencyWaitForPatrolService" |> NamespacedName

    /// <summary>
    /// Increase normal following distance
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#increaseNormalFollowingDistance"></see></summary>
    let increaseNormalFollowingDistance =
        Namespaced_IRI.parse _namespace_name "increaseNormalFollowingDistance" |> NamespacedName

    /// <summary>
    /// Keep your distance.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#keepYourDistance"></see></summary>
    let keepYourDistance =
        Namespaced_IRI.parse _namespace_name "keepYourDistance" |> NamespacedName

    /// <summary>
    /// Leave your vehicle proceed to next safe place
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#leaveYourVehicleProceedToNextSafePlace"></see></summary>
    let leaveYourVehicleProceedToNextSafePlace =
        Namespaced_IRI.parse _namespace_name "leaveYourVehicleProceedToNextSafePlace" |> NamespacedName

    /// <summary>
    /// No naked flames.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#noNakedFlames"></see></summary>
    let noNakedFlames =
        Namespaced_IRI.parse _namespace_name "noNakedFlames" |> NamespacedName

    /// <summary>
    /// No overtaking on the specified section of road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#noOvertaking"></see></summary>
    let noOvertaking =
        Namespaced_IRI.parse _namespace_name "noOvertaking" |> NamespacedName

    /// <summary>
    /// No smoking.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#noSmoking"></see></summary>
    let noSmoking = Namespaced_IRI.parse _namespace_name "noSmoking" |> NamespacedName
    /// <summary>
    /// No stopping.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#noStopping"></see></summary>
    let noStopping = Namespaced_IRI.parse _namespace_name "noStopping" |> NamespacedName
    /// <summary>
    /// No U-turns.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#noUturns"></see></summary>
    let noUturns = Namespaced_IRI.parse _namespace_name "noUturns" |> NamespacedName

    /// <summary>
    /// Observe current amber alert (an emergency alert issued for a missing or abducted child).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#observeAmberAlert"></see></summary>
    let observeAmberAlert =
        Namespaced_IRI.parse _namespace_name "observeAmberAlert" |> NamespacedName

    /// <summary>
    /// Observe signals.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#observeSignals"></see></summary>
    let observeSignals =
        Namespaced_IRI.parse _namespace_name "observeSignals" |> NamespacedName

    /// <summary>
    /// Observe signs.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#observeSigns"></see></summary>
    let observeSigns =
        Namespaced_IRI.parse _namespace_name "observeSigns" |> NamespacedName

    /// <summary>
    /// Only travel if absolutely necessary.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onlyTravelIfAbsolutelyNecessary"></see></summary>
    let onlyTravelIfAbsolutelyNecessary =
        Namespaced_IRI.parse _namespace_name "onlyTravelIfAbsolutelyNecessary" |> NamespacedName

    /// <summary>
    /// Overtake with care.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#overtakeWithCare"></see></summary>
    let overtakeWithCare =
        Namespaced_IRI.parse _namespace_name "overtakeWithCare" |> NamespacedName

    /// <summary>
    /// Pull over to the edge of the roadway.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#pullOverToTheEdgeOfTheRoadway"></see></summary>
    let pullOverToTheEdgeOfTheRoadway =
        Namespaced_IRI.parse _namespace_name "pullOverToTheEdgeOfTheRoadway" |> NamespacedName

    /// <summary>
    /// Stop at next safe place.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#stopAtNextSafePlace"></see></summary>
    let stopAtNextSafePlace =
        Namespaced_IRI.parse _namespace_name "stopAtNextSafePlace" |> NamespacedName

    /// <summary>
    /// Stop at next rest service area or car park.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#stopAtNextServiceArea"></see></summary>
    let stopAtNextServiceArea =
        Namespaced_IRI.parse _namespace_name "stopAtNextServiceArea" |> NamespacedName

    /// <summary>
    /// Switch off engine.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#switchOffEngine"></see></summary>
    let switchOffEngine =
        Namespaced_IRI.parse _namespace_name "switchOffEngine" |> NamespacedName

    /// <summary>
    /// Switch off mobile phones and two-way radios.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#switchOffMobilePhonesAndTwoWayRadios"></see></summary>
    let switchOffMobilePhonesAndTwoWayRadios =
        Namespaced_IRI.parse _namespace_name "switchOffMobilePhonesAndTwoWayRadios" |> NamespacedName

    /// <summary>
    /// Test your brakes.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#testYourBrakes"></see></summary>
    let testYourBrakes =
        Namespaced_IRI.parse _namespace_name "testYourBrakes" |> NamespacedName

    /// <summary>
    /// Use bus service.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#useBusService"></see></summary>
    let useBusService =
        Namespaced_IRI.parse _namespace_name "useBusService" |> NamespacedName

    /// <summary>
    /// Use fog lights.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#useFogLights"></see></summary>
    let useFogLights =
        Namespaced_IRI.parse _namespace_name "useFogLights" |> NamespacedName

    /// <summary>
    /// Use hazard warning lights.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#useHazardWarningLights"></see></summary>
    let useHazardWarningLights =
        Namespaced_IRI.parse _namespace_name "useHazardWarningLights" |> NamespacedName

    /// <summary>
    /// Use headlights.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#useHeadlights"></see></summary>
    let useHeadlights =
        Namespaced_IRI.parse _namespace_name "useHeadlights" |> NamespacedName

    /// <summary>
    /// Use rail service.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#useRailService"></see></summary>
    let useRailService =
        Namespaced_IRI.parse _namespace_name "useRailService" |> NamespacedName

    /// <summary>
    /// Use tram service.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#useTramService"></see></summary>
    let useTramService =
        Namespaced_IRI.parse _namespace_name "useTramService" |> NamespacedName

    /// <summary>
    /// Use underground service.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#useUndergroundService"></see></summary>
    let useUndergroundService =
        Namespaced_IRI.parse _namespace_name "useUndergroundService" |> NamespacedName

    /// <summary>
    /// Wait for escort vehicle.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#waitForEscortVehicle"></see></summary>
    let waitForEscortVehicle =
        Namespaced_IRI.parse _namespace_name "waitForEscortVehicle" |> NamespacedName

    /// <summary>
    /// At national borders
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#atBorders"></see></summary>
    let atBorders = Namespaced_IRI.parse _namespace_name "atBorders" |> NamespacedName

    /// <summary>
    /// At high altitudes
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#atHighAltitudes"></see></summary>
    let atHighAltitudes =
        Namespaced_IRI.parse _namespace_name "atHighAltitudes" |> NamespacedName

    /// <summary>
    /// In built up areas, i.e. villages, towns and cities
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#inBuiltUpAreas"></see></summary>
    let inBuiltUpAreas =
        Namespaced_IRI.parse _namespace_name "inBuiltUpAreas" |> NamespacedName

    /// <summary>
    /// On sections of the road where it runs through or adjacent to forested areas
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#inForestedAreas"></see></summary>
    let inForestedAreas =
        Namespaced_IRI.parse _namespace_name "inForestedAreas" |> NamespacedName

    /// <summary>
    /// In galleries
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#inGalleries"></see></summary>
    let inGalleries =
        Namespaced_IRI.parse _namespace_name "inGalleries" |> NamespacedName

    /// <summary>
    /// In low-lying areas
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#inLowLyingAreas"></see></summary>
    let inLowLyingAreas =
        Namespaced_IRI.parse _namespace_name "inLowLyingAreas" |> NamespacedName

    /// <summary>
    /// In rural areas, i.e. outside villages, towns and cities
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#inRuralAreas"></see></summary>
    let inRuralAreas =
        Namespaced_IRI.parse _namespace_name "inRuralAreas" |> NamespacedName

    /// <summary>
    /// In shaded areas
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#inShadedAreas"></see></summary>
    let inShadedAreas =
        Namespaced_IRI.parse _namespace_name "inShadedAreas" |> NamespacedName

    /// <summary>
    /// In the city centre areas
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#inTheInnerCityAreas"></see></summary>
    let inTheInnerCityAreas =
        Namespaced_IRI.parse _namespace_name "inTheInnerCityAreas" |> NamespacedName

    /// <summary>
    /// In tunnels
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#inTunnels"></see></summary>
    let inTunnels = Namespaced_IRI.parse _namespace_name "inTunnels" |> NamespacedName
    /// <summary>
    /// On bridges
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onBridges"></see></summary>
    let onBridges = Namespaced_IRI.parse _namespace_name "onBridges" |> NamespacedName

    /// <summary>
    /// On downhill sections of the road
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onDownhillSections"></see></summary>
    let onDownhillSections =
        Namespaced_IRI.parse _namespace_name "onDownhillSections" |> NamespacedName

    /// <summary>
    /// On elevated sections of the road
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onElevatedSections"></see></summary>
    let onElevatedSections =
        Namespaced_IRI.parse _namespace_name "onElevatedSections" |> NamespacedName

    /// <summary>
    /// On entering or leaving tunnels
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onEnteringOrLeavingTunnels"></see></summary>
    let onEnteringOrLeavingTunnels =
        Namespaced_IRI.parse _namespace_name "onEnteringOrLeavingTunnels" |> NamespacedName

    /// <summary>
    /// On flyover sections of the road, i.e. sections of the road which pass over another road
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onFlyovers"></see></summary>
    let onFlyovers = Namespaced_IRI.parse _namespace_name "onFlyovers" |> NamespacedName
    /// <summary>
    /// On mountain passes
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onPasses"></see></summary>
    let onPasses = Namespaced_IRI.parse _namespace_name "onPasses" |> NamespacedName

    /// <summary>
    /// On underground sections of the road
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onUndergroundSections"></see></summary>
    let onUndergroundSections =
        Namespaced_IRI.parse _namespace_name "onUndergroundSections" |> NamespacedName

    /// <summary>
    /// On underpasses, i.e. sections of the road which pass under another road
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onUnderpasses"></see></summary>
    let onUnderpasses =
        Namespaced_IRI.parse _namespace_name "onUnderpasses" |> NamespacedName

    /// <summary>
    /// The information is real. It is not a test or exercise.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#real"></see></summary>
    let real = Namespaced_IRI.parse _namespace_name "real" |> NamespacedName

    /// <summary>
    /// The information is part of an exercise which is for testing security.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#securityExercise"></see></summary>
    let securityExercise =
        Namespaced_IRI.parse _namespace_name "securityExercise" |> NamespacedName

    /// <summary>
    /// The information is part of an exercise which includes tests of associated technical subsystems.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#technicalExercise"></see></summary>
    let technicalExercise =
        Namespaced_IRI.parse _namespace_name "technicalExercise" |> NamespacedName

    /// <summary>
    /// The information is part of a test for checking the exchange of this type of information.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#test"></see></summary>
    let test = Namespaced_IRI.parse _namespace_name "test" |> NamespacedName
    /// <summary>
    /// Motorway
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#motorway"></see></summary>
    let motorway = Namespaced_IRI.parse _namespace_name "motorway" |> NamespacedName

    /// <summary>
    /// Multiple carriageway
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#multipleCarriageway"></see></summary>
    let multipleCarriageway =
        Namespaced_IRI.parse _namespace_name "multipleCarriageway" |> NamespacedName

    /// <summary>
    /// Roundabout
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roundabout"></see></summary>
    let roundabout = Namespaced_IRI.parse _namespace_name "roundabout" |> NamespacedName

    /// <summary>
    /// Single carriageway
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#singleCarriageway"></see></summary>
    let singleCarriageway =
        Namespaced_IRI.parse _namespace_name "singleCarriageway" |> NamespacedName

    /// <summary>
    /// Slip Road. The nature of the linear element is a slip road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#slipRoad"></see></summary>
    let slipRoad = Namespaced_IRI.parse _namespace_name "slipRoad" |> NamespacedName

    /// <summary>
    /// Traffic square
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#trafficSquare"></see></summary>
    let trafficSquare =
        Namespaced_IRI.parse _namespace_name "trafficSquare" |> NamespacedName

    /// <summary>
    /// Undefined
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#undefined"></see></summary>
    let undefined = Namespaced_IRI.parse _namespace_name "undefined" |> NamespacedName
    /// <summary>
    /// A major gathering of people that could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#crowd"></see></summary>
    let crowd = Namespaced_IRI.parse _namespace_name "crowd" |> NamespacedName

    /// <summary>
    /// A public protest with the potential to disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#demonstration"></see></summary>
    let demonstration =
        Namespaced_IRI.parse _namespace_name "demonstration" |> NamespacedName

    /// <summary>
    /// A situation where a definite area is being cleared due to dangerous conditions or for security reasons.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#evacuation"></see></summary>
    let evacuation = Namespaced_IRI.parse _namespace_name "evacuation" |> NamespacedName

    /// <summary>
    /// Height above mean sea high water level.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#aboveSeaLevelTPEGHeight"></see></summary>
    let aboveSeaLevelTPEGHeight =
        Namespaced_IRI.parse _namespace_name "aboveSeaLevelTPEGHeight" |> NamespacedName

    /// <summary>
    /// Above street level
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#aboveStreetLevelTPEGHeight"></see></summary>
    let aboveStreetLevelTPEGHeight =
        Namespaced_IRI.parse _namespace_name "aboveStreetLevelTPEGHeight" |> NamespacedName

    /// <summary>
    /// Above
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#aboveTPEGHeight"></see></summary>
    let aboveTPEGHeight =
        Namespaced_IRI.parse _namespace_name "aboveTPEGHeight" |> NamespacedName

    /// <summary>
    /// At service area.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#atSeaLevelTPEGHeight"></see></summary>
    let atSeaLevelTPEGHeight =
        Namespaced_IRI.parse _namespace_name "atSeaLevelTPEGHeight" |> NamespacedName

    /// <summary>
    /// At street level.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#atStreetLevelTPEGHeight"></see></summary>
    let atStreetLevelTPEGHeight =
        Namespaced_IRI.parse _namespace_name "atStreetLevelTPEGHeight" |> NamespacedName

    /// <summary>
    /// At height of specified location.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#atTPEGHeight"></see></summary>
    let atTPEGHeight =
        Namespaced_IRI.parse _namespace_name "atTPEGHeight" |> NamespacedName

    /// <summary>
    /// Height below mean sea high water level.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#belowSeaLevelTPEGHeight"></see></summary>
    let belowSeaLevelTPEGHeight =
        Namespaced_IRI.parse _namespace_name "belowSeaLevelTPEGHeight" |> NamespacedName

    /// <summary>
    /// Height below street level.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#belowStreetLevelTPEGHeight"></see></summary>
    let belowStreetLevelTPEGHeight =
        Namespaced_IRI.parse _namespace_name "belowStreetLevelTPEGHeight" |> NamespacedName

    /// <summary>
    /// Height below specified location.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#belowTPEGHeight"></see></summary>
    let belowTPEGHeight =
        Namespaced_IRI.parse _namespace_name "belowTPEGHeight" |> NamespacedName

    /// <summary>
    /// Undefined height reference.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#undefinedTPEGHeight"></see></summary>
    let undefinedTPEGHeight =
        Namespaced_IRI.parse _namespace_name "undefinedTPEGHeight" |> NamespacedName

    /// <summary>
    /// Perceived by supplier as being of an unknown level.
    /// Unknow mobility of the describe element of a situation.
    /// Driving conditions are unknown.
    /// Accident cause is unknown.
    /// Direction is unknown.
    /// The trend of traffic conditions is currently unknown.
    /// Unknown height reference.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#unknown"></see></summary>
    let unknown = Namespaced_IRI.parse _namespace_name "unknown" |> NamespacedName

    /// <summary>
    /// Do not use stud tyres.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#doNoUseStudTyres"></see></summary>
    let doNoUseStudTyres =
        Namespaced_IRI.parse _namespace_name "doNoUseStudTyres" |> NamespacedName

    /// <summary>
    /// Use snow chains.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#useSnowChains"></see></summary>
    let useSnowChains =
        Namespaced_IRI.parse _namespace_name "useSnowChains" |> NamespacedName

    /// <summary>
    /// Use snow chains or snow tyres.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#useSnowChainsOrTyres"></see></summary>
    let useSnowChainsOrTyres =
        Namespaced_IRI.parse _namespace_name "useSnowChainsOrTyres" |> NamespacedName

    /// <summary>
    /// Use snow tyres.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#useSnowTyres"></see></summary>
    let useSnowTyres =
        Namespaced_IRI.parse _namespace_name "useSnowTyres" |> NamespacedName

    /// <summary>
    /// The carrying of winter equipment (snow chains and/or snow tyres) is required.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#winterEquipmentOnBoardRequired"></see></summary>
    let winterEquipmentOnBoardRequired =
        Namespaced_IRI.parse _namespace_name "winterEquipmentOnBoardRequired" |> NamespacedName

    /// <summary>
    /// Indicates that both directions of traffic flow are affected by the situation or relate to the traffic data.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#both"></see></summary>
    let both = Namespaced_IRI.parse _namespace_name "both" |> NamespacedName
    /// <summary>
    /// On the left side of the road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#left"></see></summary>
    let left = Namespaced_IRI.parse _namespace_name "left" |> NamespacedName

    /// <summary>
    /// On road or unknown
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onRoadOrUnknown"></see></summary>
    let onRoadOrUnknown =
        Namespaced_IRI.parse _namespace_name "onRoadOrUnknown" |> NamespacedName

    /// <summary>
    /// On the right side of the road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#right"></see></summary>
    let right = Namespaced_IRI.parse _namespace_name "right" |> NamespacedName
    /// <summary>
    /// Ferry service.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ferry"></see></summary>
    let ferry = Namespaced_IRI.parse _namespace_name "ferry" |> NamespacedName

    /// <summary>
    /// Name of a road network junction where two or more roads join.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#junctionName"></see></summary>
    let junctionName =
        Namespaced_IRI.parse _namespace_name "junctionName" |> NamespacedName

    /// <summary>
    /// The described event, action or item is currently active regardless of the definition of the validity time specification.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#active"></see></summary>
    let active = Namespaced_IRI.parse _namespace_name "active" |> NamespacedName

    /// <summary>
    /// The validity status of the described event, action or item is in accordance with the definition of the validity time specification.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#definedByValidityTimeSpec"></see></summary>
    let definedByValidityTimeSpec =
        Namespaced_IRI.parse _namespace_name "definedByValidityTimeSpec" |> NamespacedName

    /// <summary>
    /// The described event, action or item is currently planned regardless of the definition of the validity time specification.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#planned"></see></summary>
    let planned = Namespaced_IRI.parse _namespace_name "planned" |> NamespacedName
    /// <summary>
    /// The described event, action or item is currently suspended, that is inactive, regardless of the definition of the validity time specification.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#suspended"></see></summary>
    let suspended = Namespaced_IRI.parse _namespace_name "suspended" |> NamespacedName

    /// <summary>
    /// Abnormal traffic information.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#abnormalLoad"></see></summary>
    let abnormalLoad =
        Namespaced_IRI.parse _namespace_name "abnormalLoad" |> NamespacedName

    /// <summary>
    /// Broken down heavy lorry/lorries on the carriageway which may cause traffic disruption.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#brokenDownHeavyLorry"></see></summary>
    let brokenDownHeavyLorry =
        Namespaced_IRI.parse _namespace_name "brokenDownHeavyLorry" |> NamespacedName

    /// <summary>
    /// Broken down vehicle(s) on the carriageway which may cause traffic disruption.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#brokenDownVehicle"></see></summary>
    let brokenDownVehicle =
        Namespaced_IRI.parse _namespace_name "brokenDownVehicle" |> NamespacedName

    /// <summary>
    /// A group of vehicles moving together in formation which may cause traffic disruption.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#convoy"></see></summary>
    let convoy = Namespaced_IRI.parse _namespace_name "convoy" |> NamespacedName

    /// <summary>
    /// Damaged vehicle(s) on the carriageway which may cause traffic disruption.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#damagedVehicle"></see></summary>
    let damagedVehicle =
        Namespaced_IRI.parse _namespace_name "damagedVehicle" |> NamespacedName

    /// <summary>
    /// A vehicle of length greater than that normally allowed which may cause traffic disruption.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#longLoad"></see></summary>
    let longLoad = Namespaced_IRI.parse _namespace_name "longLoad" |> NamespacedName

    /// <summary>
    /// A group of military vehicles moving together in formation which may cause traffic disruption.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#militaryConvoy"></see></summary>
    let militaryConvoy =
        Namespaced_IRI.parse _namespace_name "militaryConvoy" |> NamespacedName

    /// <summary>
    /// A vehicle travelling at well below normal highway speeds which may cause traffic disruption.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#slowVehicle"></see></summary>
    let slowVehicle =
        Namespaced_IRI.parse _namespace_name "slowVehicle" |> NamespacedName

    /// <summary>
    /// A vehicle is or has been on fire and may cause traffic disruption.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#vehicleOnFire"></see></summary>
    let vehicleOnFire =
        Namespaced_IRI.parse _namespace_name "vehicleOnFire" |> NamespacedName

    /// <summary>
    /// A vehicle is travelling the wrong way along a divided highway (i.e. on the wrong side).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#vehicleOnWrongCarriageway"></see></summary>
    let vehicleOnWrongCarriageway =
        Namespaced_IRI.parse _namespace_name "vehicleOnWrongCarriageway" |> NamespacedName

    /// <summary>
    /// One or more vehicles are stuck (i.e. unable to move) due to environmental conditions such as a snow drift or severe icy road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#vehicleStuck"></see></summary>
    let vehicleStuck =
        Namespaced_IRI.parse _namespace_name "vehicleStuck" |> NamespacedName

    /// <summary>
    /// A vehicle of width greater than that normally allowed which may cause traffic disruption.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#vehicleWithOverwideLoad"></see></summary>
    let vehicleWithOverwideLoad =
        Namespaced_IRI.parse _namespace_name "vehicleWithOverwideLoad" |> NamespacedName

    /// <summary>
    /// The carriageway is totally obstructed in the specified direction due to an unplanned event.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#carriagewayBlocked"></see></summary>
    let carriagewayBlocked =
        Namespaced_IRI.parse _namespace_name "carriagewayBlocked" |> NamespacedName

    /// <summary>
    /// The carriageway is partially obstructed in the specified direction due to an unplanned event.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#carriagewayPartiallyObstructed"></see></summary>
    let carriagewayPartiallyObstructed =
        Namespaced_IRI.parse _namespace_name "carriagewayPartiallyObstructed" |> NamespacedName

    /// <summary>
    /// One or more lanes is totally obstructed in the specified direction due to an unplanned event.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#lanesBlocked"></see></summary>
    let lanesBlocked =
        Namespaced_IRI.parse _namespace_name "lanesBlocked" |> NamespacedName

    /// <summary>
    /// One or more lanes is partially obstructed in the specified direction due to an unplanned event.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#lanesPartiallyObstructed"></see></summary>
    let lanesPartiallyObstructed =
        Namespaced_IRI.parse _namespace_name "lanesPartiallyObstructed" |> NamespacedName

    /// <summary>
    /// The road is totally obstructed, for all vehicles in both directions, due to an unplanned event.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadBlocked"></see></summary>
    let roadBlocked =
        Namespaced_IRI.parse _namespace_name "roadBlocked" |> NamespacedName

    /// <summary>
    /// The road is partially obstructed in both directions due to an unplanned event.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadPartiallyObstructed"></see></summary>
    let roadPartiallyObstructed =
        Namespaced_IRI.parse _namespace_name "roadPartiallyObstructed" |> NamespacedName

    /// <summary>
    /// Arithmetic average of sample values based on a fixed number of samples.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#arithmeticAverageOfSamplesBasedOnAFixedNumberOfSamples"></see></summary>
    let arithmeticAverageOfSamplesBasedOnAFixedNumberOfSamples =
        Namespaced_IRI.parse _namespace_name "arithmeticAverageOfSamplesBasedOnAFixedNumberOfSamples" |> NamespacedName

    /// <summary>
    /// Arithmetic average of sample values in a time period.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#arithmeticAverageOfSamplesInATimePeriod"></see></summary>
    let arithmeticAverageOfSamplesInATimePeriod =
        Namespaced_IRI.parse _namespace_name "arithmeticAverageOfSamplesInATimePeriod" |> NamespacedName

    /// <summary>
    /// Harmonic average of sample values in a time period.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#harmonicAverageOfSamplesInATimePeriod"></see></summary>
    let harmonicAverageOfSamplesInATimePeriod =
        Namespaced_IRI.parse _namespace_name "harmonicAverageOfSamplesInATimePeriod" |> NamespacedName

    /// <summary>
    /// Median of sample values taken over a time period.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#medianOfSamplesInATimePeriod"></see></summary>
    let medianOfSamplesInATimePeriod =
        Namespaced_IRI.parse _namespace_name "medianOfSamplesInATimePeriod" |> NamespacedName

    /// <summary>
    /// Moving average of sample values.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#movingAverageOfSamples"></see></summary>
    let movingAverageOfSamples =
        Namespaced_IRI.parse _namespace_name "movingAverageOfSamples" |> NamespacedName

    /// <summary>
    /// Broken down vehicle (i.e. it is immobile due to mechanical breakdown).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#brokenDown"></see></summary>
    let brokenDown = Namespaced_IRI.parse _namespace_name "brokenDown" |> NamespacedName
    /// <summary>
    /// Burnt out vehicle, but fire is extinguished.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#burntOut"></see></summary>
    let burntOut = Namespaced_IRI.parse _namespace_name "burntOut" |> NamespacedName
    /// <summary>
    /// Vehicle is damaged following an incident or collision. It may be able or not to move by itself.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#damaged"></see></summary>
    let damaged = Namespaced_IRI.parse _namespace_name "damaged" |> NamespacedName

    /// <summary>
    /// Vehicle is damaged following an incident or collision. It is immobilized and therefore needs assistance to be moved.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#damagedAndImmobililized"></see></summary>
    let damagedAndImmobililized =
        Namespaced_IRI.parse _namespace_name "damagedAndImmobililized" |> NamespacedName

    /// <summary>
    /// The pulling vehicle is in a jackknifed position with its trailer
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#jacknifed"></see></summary>
    let jacknifed = Namespaced_IRI.parse _namespace_name "jacknifed" |> NamespacedName
    /// <summary>
    /// Vehicle is on fire.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onFire"></see></summary>
    let onFire = Namespaced_IRI.parse _namespace_name "onFire" |> NamespacedName
    /// <summary>
    /// Vehicle is on its side or upside down
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#overturned"></see></summary>
    let overturned = Namespaced_IRI.parse _namespace_name "overturned" |> NamespacedName
    /// <summary>
    /// Vehicle has come to rest not facing its intended line of travel.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#spunAround"></see></summary>
    let spunAround = Namespaced_IRI.parse _namespace_name "spunAround" |> NamespacedName
    /// <summary>
    /// The road surface has sunken or collapsed in places due to burst pipes.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#burstPipe"></see></summary>
    let burstPipe = Namespaced_IRI.parse _namespace_name "burstPipe" |> NamespacedName

    /// <summary>
    /// Traffic may be disrupted due to local flooding and/or subsidence because of a broken water main.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#burstWaterMain"></see></summary>
    let burstWaterMain =
        Namespaced_IRI.parse _namespace_name "burstWaterMain" |> NamespacedName

    /// <summary>
    /// The road surface has sunken or collapsed in places due to sewer failure.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#collapsedSewer"></see></summary>
    let collapsedSewer =
        Namespaced_IRI.parse _namespace_name "collapsedSewer" |> NamespacedName

    /// <summary>
    /// Damage to a bridge that may cause traffic disruption.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#damagedBridge"></see></summary>
    let damagedBridge =
        Namespaced_IRI.parse _namespace_name "damagedBridge" |> NamespacedName

    /// <summary>
    /// Damage to a crash barrier that may cause traffic disruption.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#damagedCrashBarrier"></see></summary>
    let damagedCrashBarrier =
        Namespaced_IRI.parse _namespace_name "damagedCrashBarrier" |> NamespacedName

    /// <summary>
    /// Damage to an elevated section of the carriageway over another carriageway that may cause traffic disruption.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#damagedFlyover"></see></summary>
    let damagedFlyover =
        Namespaced_IRI.parse _namespace_name "damagedFlyover" |> NamespacedName

    /// <summary>
    /// Damage to a gallery that may cause traffic disruption.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#damagedGallery"></see></summary>
    let damagedGallery =
        Namespaced_IRI.parse _namespace_name "damagedGallery" |> NamespacedName

    /// <summary>
    /// Damage to a gantry above the roadway that may cause traffic disruption.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#damagedGantry"></see></summary>
    let damagedGantry =
        Namespaced_IRI.parse _namespace_name "damagedGantry" |> NamespacedName

    /// <summary>
    /// Damage to the road surface that may cause traffic disruption.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#damagedRoadSurface"></see></summary>
    let damagedRoadSurface =
        Namespaced_IRI.parse _namespace_name "damagedRoadSurface" |> NamespacedName

    /// <summary>
    /// Damage to a tunnel that may cause traffic disruption.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#damagedTunnel"></see></summary>
    let damagedTunnel =
        Namespaced_IRI.parse _namespace_name "damagedTunnel" |> NamespacedName

    /// <summary>
    /// Damage to a viaduct that may cause traffic disruption.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#damagedViaduct"></see></summary>
    let damagedViaduct =
        Namespaced_IRI.parse _namespace_name "damagedViaduct" |> NamespacedName

    /// <summary>
    /// The road is obstructed or partially obstructed by one or more fallen power cables.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#fallenPowerCables"></see></summary>
    let fallenPowerCables =
        Namespaced_IRI.parse _namespace_name "fallenPowerCables" |> NamespacedName

    /// <summary>
    /// Traffic may be disrupted due to an explosion hazard from gas escaping in or near the roadway.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#gasLeak"></see></summary>
    let gasLeak = Namespaced_IRI.parse _namespace_name "gasLeak" |> NamespacedName
    /// <summary>
    /// Weak bridge capable of carrying a reduced load, typically with a reduced weight limit restriction imposed.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#weakBridge"></see></summary>
    let weakBridge = Namespaced_IRI.parse _namespace_name "weakBridge" |> NamespacedName
    /// <summary>
    /// Main road, highest importanceMain road, highest importance
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#frc0"></see></summary>
    let frc0 = Namespaced_IRI.parse _namespace_name "frc0" |> NamespacedName
    /// <summary>
    /// First class road
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#frc1"></see></summary>
    let frc1 = Namespaced_IRI.parse _namespace_name "frc1" |> NamespacedName
    /// <summary>
    /// Second class road
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#frc2"></see></summary>
    let frc2 = Namespaced_IRI.parse _namespace_name "frc2" |> NamespacedName
    /// <summary>
    /// Third class road
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#frc3"></see></summary>
    let frc3 = Namespaced_IRI.parse _namespace_name "frc3" |> NamespacedName
    /// <summary>
    /// Fourth class road
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#frc4"></see></summary>
    let frc4 = Namespaced_IRI.parse _namespace_name "frc4" |> NamespacedName
    /// <summary>
    /// Fifth class road
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#frc5"></see></summary>
    let frc5 = Namespaced_IRI.parse _namespace_name "frc5" |> NamespacedName
    /// <summary>
    /// Sixth class road
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#frc6"></see></summary>
    let frc6 = Namespaced_IRI.parse _namespace_name "frc6" |> NamespacedName
    /// <summary>
    /// Other class road, lowest importance
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#frc7"></see></summary>
    let frc7 = Namespaced_IRI.parse _namespace_name "frc7" |> NamespacedName
    /// <summary>
    /// The roadworks are likely to cause major traffic disruption.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#major"></see></summary>
    let major = Namespaced_IRI.parse _namespace_name "major" |> NamespacedName

    /// <summary>
    /// The roadworks are likely to cause a medium level of traffic disruption.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#mediumRoadworksScale"></see></summary>
    let mediumRoadworksScale =
        Namespaced_IRI.parse _namespace_name "mediumRoadworksScale" |> NamespacedName

    /// <summary>
    /// The roadworks are likely to cause minor traffic disruption.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#minor"></see></summary>
    let minor = Namespaced_IRI.parse _namespace_name "minor" |> NamespacedName
    /// <summary>
    /// Perceived by supplier as being of a high level.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#high"></see></summary>
    let high = Namespaced_IRI.parse _namespace_name "high" |> NamespacedName
    /// <summary>
    /// Perceived by supplier as being of the highest level.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#highest"></see></summary>
    let highest = Namespaced_IRI.parse _namespace_name "highest" |> NamespacedName
    /// <summary>
    /// Perceived by supplier as being of a low level.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#low"></see></summary>
    let low = Namespaced_IRI.parse _namespace_name "low" |> NamespacedName
    /// <summary>
    /// Perceived by supplier as being of the lowest discernible level.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#lowest"></see></summary>
    let lowest = Namespaced_IRI.parse _namespace_name "lowest" |> NamespacedName
    /// <summary>
    /// Perceived by supplier as being of a medium level.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#medium"></see></summary>
    let medium = Namespaced_IRI.parse _namespace_name "medium" |> NamespacedName
    /// <summary>
    /// Perceived by supplier as having a severity rating of none.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#none"></see></summary>
    let none = Namespaced_IRI.parse _namespace_name "none" |> NamespacedName

    /// <summary>
    /// Administrative atoll
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#administrativeAtoll"></see></summary>
    let administrativeAtoll =
        Namespaced_IRI.parse _namespace_name "administrativeAtoll" |> NamespacedName

    /// <summary>
    /// Administrative region
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#administrativeRegion"></see></summary>
    let administrativeRegion =
        Namespaced_IRI.parse _namespace_name "administrativeRegion" |> NamespacedName

    /// <summary>
    /// Administrative territory
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#administrativeTerritory"></see></summary>
    let administrativeTerritory =
        Namespaced_IRI.parse _namespace_name "administrativeTerritory" |> NamespacedName

    /// <summary>
    /// Arctic region
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#arcticRegion"></see></summary>
    let arcticRegion =
        Namespaced_IRI.parse _namespace_name "arcticRegion" |> NamespacedName

    /// <summary>
    /// Autonomous city
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#autonomousCity"></see></summary>
    let autonomousCity =
        Namespaced_IRI.parse _namespace_name "autonomousCity" |> NamespacedName

    /// <summary>
    /// Autonomous city in North Africa
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#autonomousCityInNorthAfrica"></see></summary>
    let autonomousCityInNorthAfrica =
        Namespaced_IRI.parse _namespace_name "autonomousCityInNorthAfrica" |> NamespacedName

    /// <summary>
    /// Autonomous community
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#autonomousCommunity"></see></summary>
    let autonomousCommunity =
        Namespaced_IRI.parse _namespace_name "autonomousCommunity" |> NamespacedName

    /// <summary>
    /// Autonomous district
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#autonomousDistrict"></see></summary>
    let autonomousDistrict =
        Namespaced_IRI.parse _namespace_name "autonomousDistrict" |> NamespacedName

    /// <summary>
    /// Autonomous province
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#autonomousProvince"></see></summary>
    let autonomousProvince =
        Namespaced_IRI.parse _namespace_name "autonomousProvince" |> NamespacedName

    /// <summary>
    /// Autonomous region
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#autonomousRegion"></see></summary>
    let autonomousRegion =
        Namespaced_IRI.parse _namespace_name "autonomousRegion" |> NamespacedName

    /// <summary>
    /// Canton
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#canton"></see></summary>
    let canton = Namespaced_IRI.parse _namespace_name "canton" |> NamespacedName

    /// <summary>
    /// Capital city
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#capitalCity"></see></summary>
    let capitalCity =
        Namespaced_IRI.parse _namespace_name "capitalCity" |> NamespacedName

    /// <summary>
    /// City
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#city"></see></summary>
    let city = Namespaced_IRI.parse _namespace_name "city" |> NamespacedName

    /// <summary>
    /// City municipality
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#cityMunicipality"></see></summary>
    let cityMunicipality =
        Namespaced_IRI.parse _namespace_name "cityMunicipality" |> NamespacedName

    /// <summary>
    /// City of county right
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#cityOfCountyRight"></see></summary>
    let cityOfCountyRight =
        Namespaced_IRI.parse _namespace_name "cityOfCountyRight" |> NamespacedName

    /// <summary>
    /// Commune
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#commune"></see></summary>
    let commune = Namespaced_IRI.parse _namespace_name "commune" |> NamespacedName

    /// <summary>
    /// Council area
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#councilArea"></see></summary>
    let councilArea =
        Namespaced_IRI.parse _namespace_name "councilArea" |> NamespacedName

    /// <summary>
    /// EN ISO 3166-1 two-character country code.
    /// Country
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#country"></see></summary>
    let country = Namespaced_IRI.parse _namespace_name "country" |> NamespacedName
    /// <summary>
    /// County
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#county"></see></summary>
    let county = Namespaced_IRI.parse _namespace_name "county" |> NamespacedName
    /// <summary>
    /// Department
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#department"></see></summary>
    let department = Namespaced_IRI.parse _namespace_name "department" |> NamespacedName
    /// <summary>
    /// Dependency
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#dependency"></see></summary>
    let dependency = Namespaced_IRI.parse _namespace_name "dependency" |> NamespacedName
    /// <summary>
    /// District
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#district"></see></summary>
    let district = Namespaced_IRI.parse _namespace_name "district" |> NamespacedName

    /// <summary>
    /// District municipality
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#districtMunicipality"></see></summary>
    let districtMunicipality =
        Namespaced_IRI.parse _namespace_name "districtMunicipality" |> NamespacedName

    /// <summary>
    /// District with special status
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#districtWithSpecialStatus"></see></summary>
    let districtWithSpecialStatus =
        Namespaced_IRI.parse _namespace_name "districtWithSpecialStatus" |> NamespacedName

    /// <summary>
    /// Entity
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#entity"></see></summary>
    let entity = Namespaced_IRI.parse _namespace_name "entity" |> NamespacedName

    /// <summary>
    /// Geographical entity
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#geographicalEntity"></see></summary>
    let geographicalEntity =
        Namespaced_IRI.parse _namespace_name "geographicalEntity" |> NamespacedName

    /// <summary>
    /// Governorate
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#governorate"></see></summary>
    let governorate =
        Namespaced_IRI.parse _namespace_name "governorate" |> NamespacedName

    /// <summary>
    /// Länder
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#laender"></see></summary>
    let laender = Namespaced_IRI.parse _namespace_name "laender" |> NamespacedName

    /// <summary>
    /// Local Council
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#localCouncil"></see></summary>
    let localCouncil =
        Namespaced_IRI.parse _namespace_name "localCouncil" |> NamespacedName

    /// <summary>
    /// London borough
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#londonBorough"></see></summary>
    let londonBorough =
        Namespaced_IRI.parse _namespace_name "londonBorough" |> NamespacedName

    /// <summary>
    /// Metropolitan area
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#metropolitanArea"></see></summary>
    let metropolitanArea =
        Namespaced_IRI.parse _namespace_name "metropolitanArea" |> NamespacedName

    /// <summary>
    /// Metropolitan department
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#metropolitanDepartment"></see></summary>
    let metropolitanDepartment =
        Namespaced_IRI.parse _namespace_name "metropolitanDepartment" |> NamespacedName

    /// <summary>
    /// Metropolitan district
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#metropolitanDistrict"></see></summary>
    let metropolitanDistrict =
        Namespaced_IRI.parse _namespace_name "metropolitanDistrict" |> NamespacedName

    /// <summary>
    /// Metropolitan region
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#metropolitanRegion"></see></summary>
    let metropolitanRegion =
        Namespaced_IRI.parse _namespace_name "metropolitanRegion" |> NamespacedName

    /// <summary>
    /// Municipality
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#municipality"></see></summary>
    let municipality =
        Namespaced_IRI.parse _namespace_name "municipality" |> NamespacedName

    /// <summary>
    /// Overseas department
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#overseasDepartment"></see></summary>
    let overseasDepartment =
        Namespaced_IRI.parse _namespace_name "overseasDepartment" |> NamespacedName

    /// <summary>
    /// Overseas region
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#overseasRegion"></see></summary>
    let overseasRegion =
        Namespaced_IRI.parse _namespace_name "overseasRegion" |> NamespacedName

    /// <summary>
    /// Overseas territorial collectivity
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#overseasTerritorialCollectivity"></see></summary>
    let overseasTerritorialCollectivity =
        Namespaced_IRI.parse _namespace_name "overseasTerritorialCollectivity" |> NamespacedName

    /// <summary>
    /// Parish
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#parish"></see></summary>
    let parish = Namespaced_IRI.parse _namespace_name "parish" |> NamespacedName
    /// <summary>
    /// Province
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#province"></see></summary>
    let province = Namespaced_IRI.parse _namespace_name "province" |> NamespacedName
    /// <summary>
    /// Quarter
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#quarter"></see></summary>
    let quarter = Namespaced_IRI.parse _namespace_name "quarter" |> NamespacedName
    /// <summary>
    /// Region
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#region"></see></summary>
    let region = Namespaced_IRI.parse _namespace_name "region" |> NamespacedName
    /// <summary>
    /// Republic
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#republic"></see></summary>
    let republic = Namespaced_IRI.parse _namespace_name "republic" |> NamespacedName

    /// <summary>
    /// Republic city
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#republicanCity"></see></summary>
    let republicanCity =
        Namespaced_IRI.parse _namespace_name "republicanCity" |> NamespacedName

    /// <summary>
    /// Self-governed part
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#selfGovernedPart"></see></summary>
    let selfGovernedPart =
        Namespaced_IRI.parse _namespace_name "selfGovernedPart" |> NamespacedName

    /// <summary>
    /// Special Municipality
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#specialMunicipality"></see></summary>
    let specialMunicipality =
        Namespaced_IRI.parse _namespace_name "specialMunicipality" |> NamespacedName

    /// <summary>
    /// State
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#state"></see></summary>
    let state = Namespaced_IRI.parse _namespace_name "state" |> NamespacedName

    /// <summary>
    /// Territorial unit
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#territorialUnit"></see></summary>
    let territorialUnit =
        Namespaced_IRI.parse _namespace_name "territorialUnit" |> NamespacedName

    /// <summary>
    /// Territory
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#territory"></see></summary>
    let territory = Namespaced_IRI.parse _namespace_name "territory" |> NamespacedName

    /// <summary>
    /// Two tier country
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#twoTierCounty"></see></summary>
    let twoTierCounty =
        Namespaced_IRI.parse _namespace_name "twoTierCounty" |> NamespacedName

    /// <summary>
    /// Unitary Authority
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#unitaryAuthority"></see></summary>
    let unitaryAuthority =
        Namespaced_IRI.parse _namespace_name "unitaryAuthority" |> NamespacedName

    /// <summary>
    /// Ward
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ward"></see></summary>
    let ward = Namespaced_IRI.parse _namespace_name "ward" |> NamespacedName

    /// <summary>
    /// Around a bend in the road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#aroundABendInRoad"></see></summary>
    let aroundABendInRoad =
        Namespaced_IRI.parse _namespace_name "aroundABendInRoad" |> NamespacedName

    /// <summary>
    /// On border crossing.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onBorder"></see></summary>
    let onBorder = Namespaced_IRI.parse _namespace_name "onBorder" |> NamespacedName
    /// <summary>
    /// On mountain pass.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onPass"></see></summary>
    let onPass = Namespaced_IRI.parse _namespace_name "onPass" |> NamespacedName

    /// <summary>
    /// Over the crest of a hill.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#overCrestOfHill"></see></summary>
    let overCrestOfHill =
        Namespaced_IRI.parse _namespace_name "overCrestOfHill" |> NamespacedName

    /// <summary>
    /// Agricultural show or event which could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#agriculturalShow"></see></summary>
    let agriculturalShow =
        Namespaced_IRI.parse _namespace_name "agriculturalShow" |> NamespacedName

    /// <summary>
    /// Air show or other aeronautical event which could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#airShow"></see></summary>
    let airShow = Namespaced_IRI.parse _namespace_name "airShow" |> NamespacedName

    /// <summary>
    /// Athletics event that could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#athleticsMeeting"></see></summary>
    let athleticsMeeting =
        Namespaced_IRI.parse _namespace_name "athleticsMeeting" |> NamespacedName

    /// <summary>
    /// Ball game event that could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ballGame"></see></summary>
    let ballGame = Namespaced_IRI.parse _namespace_name "ballGame" |> NamespacedName

    /// <summary>
    /// Baseball game event that could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#baseballGame"></see></summary>
    let baseballGame =
        Namespaced_IRI.parse _namespace_name "baseballGame" |> NamespacedName

    /// <summary>
    /// Basketball game event that could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#basketballGame"></see></summary>
    let basketballGame =
        Namespaced_IRI.parse _namespace_name "basketballGame" |> NamespacedName

    /// <summary>
    /// Bicycle race that could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#bicycleRace"></see></summary>
    let bicycleRace =
        Namespaced_IRI.parse _namespace_name "bicycleRace" |> NamespacedName

    /// <summary>
    /// Regatta (boat race event of sailing, powerboat or rowing) that could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#boatRace"></see></summary>
    let boatRace = Namespaced_IRI.parse _namespace_name "boatRace" |> NamespacedName
    /// <summary>
    /// Boat show which could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#boatShow"></see></summary>
    let boatShow = Namespaced_IRI.parse _namespace_name "boatShow" |> NamespacedName

    /// <summary>
    /// Boxing event that could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#boxingTournament"></see></summary>
    let boxingTournament =
        Namespaced_IRI.parse _namespace_name "boxingTournament" |> NamespacedName

    /// <summary>
    /// Bull fighting event that could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#bullFight"></see></summary>
    let bullFight = Namespaced_IRI.parse _namespace_name "bullFight" |> NamespacedName

    /// <summary>
    /// Formal or religious act, rite or ceremony that could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ceremonialEvent"></see></summary>
    let ceremonialEvent =
        Namespaced_IRI.parse _namespace_name "ceremonialEvent" |> NamespacedName

    /// <summary>
    /// Commercial event which could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#commercialEvent"></see></summary>
    let commercialEvent =
        Namespaced_IRI.parse _namespace_name "commercialEvent" |> NamespacedName

    /// <summary>
    /// Concert event that could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#concert"></see></summary>
    let concert = Namespaced_IRI.parse _namespace_name "concert" |> NamespacedName

    /// <summary>
    /// Cricket match that could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#cricketMatch"></see></summary>
    let cricketMatch =
        Namespaced_IRI.parse _namespace_name "cricketMatch" |> NamespacedName

    /// <summary>
    /// Cultural event which could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#culturalEvent"></see></summary>
    let culturalEvent =
        Namespaced_IRI.parse _namespace_name "culturalEvent" |> NamespacedName

    /// <summary>
    /// Major display or trade show which could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#exhibition"></see></summary>
    let exhibition = Namespaced_IRI.parse _namespace_name "exhibition" |> NamespacedName
    /// <summary>
    /// Periodic (e.g. annual), often traditional, gathering for entertainment or trade promotion, which could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#fair"></see></summary>
    let fair = Namespaced_IRI.parse _namespace_name "fair" |> NamespacedName
    /// <summary>
    /// Celebratory event or series of events which could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#festival"></see></summary>
    let festival = Namespaced_IRI.parse _namespace_name "festival" |> NamespacedName

    /// <summary>
    /// Film or TV making event which could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#filmTVMaking"></see></summary>
    let filmTVMaking =
        Namespaced_IRI.parse _namespace_name "filmTVMaking" |> NamespacedName

    /// <summary>
    /// Football match that could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#footballMatch"></see></summary>
    let footballMatch =
        Namespaced_IRI.parse _namespace_name "footballMatch" |> NamespacedName

    /// <summary>
    /// Periodic (e.g. annual), often traditional, gathering for entertainment, which could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#funfair"></see></summary>
    let funfair = Namespaced_IRI.parse _namespace_name "funfair" |> NamespacedName

    /// <summary>
    /// Gardening and/or flower show or event which could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#gardeningOrFlowerShow"></see></summary>
    let gardeningOrFlowerShow =
        Namespaced_IRI.parse _namespace_name "gardeningOrFlowerShow" |> NamespacedName

    /// <summary>
    /// Golf tournament event that could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#golfTournament"></see></summary>
    let golfTournament =
        Namespaced_IRI.parse _namespace_name "golfTournament" |> NamespacedName

    /// <summary>
    /// Hockey game event that could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hockeyGame"></see></summary>
    let hockeyGame = Namespaced_IRI.parse _namespace_name "hockeyGame" |> NamespacedName

    /// <summary>
    /// Horse race meeting that could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#horseRaceMeeting"></see></summary>
    let horseRaceMeeting =
        Namespaced_IRI.parse _namespace_name "horseRaceMeeting" |> NamespacedName

    /// <summary>
    /// Large sporting event of an international nature that could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#internationalSportsMeeting"></see></summary>
    let internationalSportsMeeting =
        Namespaced_IRI.parse _namespace_name "internationalSportsMeeting" |> NamespacedName

    /// <summary>
    /// Significant organised event either on or near the roadway which could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#majorEvent"></see></summary>
    let majorEvent = Namespaced_IRI.parse _namespace_name "majorEvent" |> NamespacedName
    /// <summary>
    /// Marathon, cross-country or road running event that could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#marathon"></see></summary>
    let marathon = Namespaced_IRI.parse _namespace_name "marathon" |> NamespacedName
    /// <summary>
    /// Periodic (e.g. weekly) gathering for buying and selling, which could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#market"></see></summary>
    let market = Namespaced_IRI.parse _namespace_name "market" |> NamespacedName
    /// <summary>
    /// Sports match of unspecified type that could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#match"></see></summary>
    let match_ = Namespaced_IRI.parse _namespace_name "match" |> NamespacedName
    /// <summary>
    /// Motor show which could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#motorShow"></see></summary>
    let motorShow = Namespaced_IRI.parse _namespace_name "motorShow" |> NamespacedName

    /// <summary>
    /// Motor sport race meeting that could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#motorSportRaceMeeting"></see></summary>
    let motorSportRaceMeeting =
        Namespaced_IRI.parse _namespace_name "motorSportRaceMeeting" |> NamespacedName

    /// <summary>
    /// Formal display or organized procession which could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#parade"></see></summary>
    let parade = Namespaced_IRI.parse _namespace_name "parade" |> NamespacedName
    /// <summary>
    /// An organised procession which could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#procession"></see></summary>
    let procession = Namespaced_IRI.parse _namespace_name "procession" |> NamespacedName

    /// <summary>
    /// Race meeting (other than horse or motor sport) that could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#raceMeeting"></see></summary>
    let raceMeeting =
        Namespaced_IRI.parse _namespace_name "raceMeeting" |> NamespacedName

    /// <summary>
    /// Rugby match that could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#rugbyMatch"></see></summary>
    let rugbyMatch = Namespaced_IRI.parse _namespace_name "rugbyMatch" |> NamespacedName

    /// <summary>
    /// A series of significant organised events either on or near the roadway which could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#severalMajorEvents"></see></summary>
    let severalMajorEvents =
        Namespaced_IRI.parse _namespace_name "severalMajorEvents" |> NamespacedName

    /// <summary>
    /// Entertainment event that could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#show"></see></summary>
    let show = Namespaced_IRI.parse _namespace_name "show" |> NamespacedName

    /// <summary>
    /// Horse showing jumping and tournament event that could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#showJumping"></see></summary>
    let showJumping =
        Namespaced_IRI.parse _namespace_name "showJumping" |> NamespacedName

    /// <summary>
    /// Sports event of unspecified type that could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#sportsMeeting"></see></summary>
    let sportsMeeting =
        Namespaced_IRI.parse _namespace_name "sportsMeeting" |> NamespacedName

    /// <summary>
    /// Public ceremony or visit of national or international significance which could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#stateOccasion"></see></summary>
    let stateOccasion =
        Namespaced_IRI.parse _namespace_name "stateOccasion" |> NamespacedName

    /// <summary>
    /// Tennis tournament that could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tennisTournament"></see></summary>
    let tennisTournament =
        Namespaced_IRI.parse _namespace_name "tennisTournament" |> NamespacedName

    /// <summary>
    /// Sporting event or series of events of unspecified type lasting more than one day which could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tournament"></see></summary>
    let tournament = Namespaced_IRI.parse _namespace_name "tournament" |> NamespacedName
    /// <summary>
    /// A periodic (e.g. annual), often traditional, gathering for trade promotion, which could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tradeFair"></see></summary>
    let tradeFair = Namespaced_IRI.parse _namespace_name "tradeFair" |> NamespacedName

    /// <summary>
    /// Water sports meeting that could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#waterSportsMeeting"></see></summary>
    let waterSportsMeeting =
        Namespaced_IRI.parse _namespace_name "waterSportsMeeting" |> NamespacedName

    /// <summary>
    /// Winter sports meeting or event (e.g. skiing, ski jumping, skating) that could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#winterSportsMeeting"></see></summary>
    let winterSportsMeeting =
        Namespaced_IRI.parse _namespace_name "winterSportsMeeting" |> NamespacedName

    /// <summary>
    /// Driving conditions are hazardous due to environmental conditions.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hazardous"></see></summary>
    let hazardous = Namespaced_IRI.parse _namespace_name "hazardous" |> NamespacedName
    /// <summary>
    /// Current conditions are making driving impossible.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#impossible"></see></summary>
    let impossible = Namespaced_IRI.parse _namespace_name "impossible" |> NamespacedName
    /// <summary>
    /// Driving conditions are normal.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#normal"></see></summary>
    let normal = Namespaced_IRI.parse _namespace_name "normal" |> NamespacedName

    /// <summary>
    /// The roadway is passable to vehicles with driver care.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#passableWithCare"></see></summary>
    let passableWithCare =
        Namespaced_IRI.parse _namespace_name "passableWithCare" |> NamespacedName

    /// <summary>
    /// Driving conditions are very hazardous due to environmental conditions.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#veryHazardous"></see></summary>
    let veryHazardous =
        Namespaced_IRI.parse _namespace_name "veryHazardous" |> NamespacedName

    /// <summary>
    /// Driving conditions are consistent with those expected in winter.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#winterConditions"></see></summary>
    let winterConditions =
        Namespaced_IRI.parse _namespace_name "winterConditions" |> NamespacedName

    /// <summary>
    /// Traffic is heavy at the specified location (i.e. average speed is between 75% and 90% of its free-flow level).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#heavyTraffic"></see></summary>
    let heavyTraffic =
        Namespaced_IRI.parse _namespace_name "heavyTraffic" |> NamespacedName

    /// <summary>
    /// Traffic is queuing at the specified location, although there is still some traffic movement (i.e. average speed is between 10% and 25% of its free-flow level).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#queuingTraffic"></see></summary>
    let queuingTraffic =
        Namespaced_IRI.parse _namespace_name "queuingTraffic" |> NamespacedName

    /// <summary>
    /// Traffic is slow moving at the specified location, but not yet forming queues (i.e. average speed is between 25% and 75% of its free-flow level).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#slowTraffic"></see></summary>
    let slowTraffic =
        Namespaced_IRI.parse _namespace_name "slowTraffic" |> NamespacedName

    /// <summary>
    /// Traffic is stationary, or very near stationary, at the specified location (i.e. average speed is less than 10% of its free-flow level).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#stationaryTraffic"></see></summary>
    let stationaryTraffic =
        Namespaced_IRI.parse _namespace_name "stationaryTraffic" |> NamespacedName

    /// <summary>
    /// There are abnormal traffic conditions of an unspecified nature at the specified location.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#unspecifiedAbnormalTraffic"></see></summary>
    let unspecifiedAbnormalTraffic =
        Namespaced_IRI.parse _namespace_name "unspecifiedAbnormalTraffic" |> NamespacedName

    /// <summary>
    /// Blasting or quarrying work at the specified location.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#blastingWork"></see></summary>
    let blastingWork =
        Namespaced_IRI.parse _namespace_name "blastingWork" |> NamespacedName

    /// <summary>
    /// Construction work of a general nature at the specified location.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#constructionWork"></see></summary>
    let constructionWork =
        Namespaced_IRI.parse _namespace_name "constructionWork" |> NamespacedName

    /// <summary>
    /// The described element of a situation is moving.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#mobile"></see></summary>
    let mobile = Namespaced_IRI.parse _namespace_name "mobile" |> NamespacedName
    /// <summary>
    /// The described element of a situation is stationary.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#stationary"></see></summary>
    let stationary = Namespaced_IRI.parse _namespace_name "stationary" |> NamespacedName

    /// <summary>
    /// Avoidance of obstacles on the roadway.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#avoidanceOfObstacles"></see></summary>
    let avoidanceOfObstacles =
        Namespaced_IRI.parse _namespace_name "avoidanceOfObstacles" |> NamespacedName

    /// <summary>
    /// Driver distraction.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#driverDistraction"></see></summary>
    let driverDistraction =
        Namespaced_IRI.parse _namespace_name "driverDistraction" |> NamespacedName

    /// <summary>
    /// Driver under the influence of drugs.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#driverDrugAbuse"></see></summary>
    let driverDrugAbuse =
        Namespaced_IRI.parse _namespace_name "driverDrugAbuse" |> NamespacedName

    /// <summary>
    /// Driver illness.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#driverIllness"></see></summary>
    let driverIllness =
        Namespaced_IRI.parse _namespace_name "driverIllness" |> NamespacedName

    /// <summary>
    /// Loss of vehicle control due to excessive vehicle speed.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#exceedingSpeedsLimits"></see></summary>
    let exceedingSpeedsLimits =
        Namespaced_IRI.parse _namespace_name "exceedingSpeedsLimits" |> NamespacedName

    /// <summary>
    /// Driver abilities reduced due to driving under the influence of alcohol. Alcohol levels above nationally accepted limit.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#excessAlcohol"></see></summary>
    let excessAlcohol =
        Namespaced_IRI.parse _namespace_name "excessAlcohol" |> NamespacedName

    /// <summary>
    /// Excessive tiredness of the driver.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#excessiveDriverTiredness"></see></summary>
    let excessiveDriverTiredness =
        Namespaced_IRI.parse _namespace_name "excessiveDriverTiredness" |> NamespacedName

    /// <summary>
    /// A driving manoeuvre which was not permitted.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#impermissibleManoeuvre"></see></summary>
    let impermissibleManoeuvre =
        Namespaced_IRI.parse _namespace_name "impermissibleManoeuvre" |> NamespacedName

    /// <summary>
    /// Limited or impaired visibility.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#limitedVisibility"></see></summary>
    let limitedVisibility =
        Namespaced_IRI.parse _namespace_name "limitedVisibility" |> NamespacedName

    /// <summary>
    /// Not keeping a safe distance from the vehicle in front.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#notKeepingASafeDistance"></see></summary>
    let notKeepingASafeDistance =
        Namespaced_IRI.parse _namespace_name "notKeepingASafeDistance" |> NamespacedName

    /// <summary>
    /// Driving on the wrong side of the road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onTheWrongSideOfTheRoad"></see></summary>
    let onTheWrongSideOfTheRoad =
        Namespaced_IRI.parse _namespace_name "onTheWrongSideOfTheRoad" |> NamespacedName

    /// <summary>
    /// Pedestrian in the roadway.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#pedestrianInRoad"></see></summary>
    let pedestrianInRoad =
        Namespaced_IRI.parse _namespace_name "pedestrianInRoad" |> NamespacedName

    /// <summary>
    /// Not keeping to lane.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#poorLaneAdherence"></see></summary>
    let poorLaneAdherence =
        Namespaced_IRI.parse _namespace_name "poorLaneAdherence" |> NamespacedName

    /// <summary>
    /// Poor judgement when merging at an entry or exit point of a carriageway or junction.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#poorMergeEntryOrExitJudgement"></see></summary>
    let poorMergeEntryOrExitJudgement =
        Namespaced_IRI.parse _namespace_name "poorMergeEntryOrExitJudgement" |> NamespacedName

    /// <summary>
    /// Poor road surface condition.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#poorRoadSurfaceCondition"></see></summary>
    let poorRoadSurfaceCondition =
        Namespaced_IRI.parse _namespace_name "poorRoadSurfaceCondition" |> NamespacedName

    /// <summary>
    /// Poor road surface adherence.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#poorSurfaceAdherence"></see></summary>
    let poorSurfaceAdherence =
        Namespaced_IRI.parse _namespace_name "poorSurfaceAdherence" |> NamespacedName

    /// <summary>
    /// Undisclosed cause.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#undisclosed"></see></summary>
    let undisclosed =
        Namespaced_IRI.parse _namespace_name "undisclosed" |> NamespacedName

    /// <summary>
    /// Malfunction or failure of vehicle function.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#vehicleFailure"></see></summary>
    let vehicleFailure =
        Namespaced_IRI.parse _namespace_name "vehicleFailure" |> NamespacedName

    /// <summary>
    /// Adult.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#adult"></see></summary>
    let adult = Namespaced_IRI.parse _namespace_name "adult" |> NamespacedName
    /// <summary>
    /// Child (age 4 to 17).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#child"></see></summary>
    let child = Namespaced_IRI.parse _namespace_name "child" |> NamespacedName

    /// <summary>
    /// A member of the emergency services, other than the police.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#emergencyServicesPerson"></see></summary>
    let emergencyServicesPerson =
        Namespaced_IRI.parse _namespace_name "emergencyServicesPerson" |> NamespacedName

    /// <summary>
    /// A member of the fire service.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#fireman"></see></summary>
    let fireman = Namespaced_IRI.parse _namespace_name "fireman" |> NamespacedName
    /// <summary>
    /// Infant (age 0 to 3).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#infant"></see></summary>
    let infant = Namespaced_IRI.parse _namespace_name "infant" |> NamespacedName

    /// <summary>
    /// A member of the medical service.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#medicalStaff"></see></summary>
    let medicalStaff =
        Namespaced_IRI.parse _namespace_name "medicalStaff" |> NamespacedName

    /// <summary>
    /// A member of the general public.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#memberOfThePublic"></see></summary>
    let memberOfThePublic =
        Namespaced_IRI.parse _namespace_name "memberOfThePublic" |> NamespacedName

    /// <summary>
    /// A member of the police force.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#policeman"></see></summary>
    let policeman = Namespaced_IRI.parse _namespace_name "policeman" |> NamespacedName
    /// <summary>
    /// A politician.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#politician"></see></summary>
    let politician = Namespaced_IRI.parse _namespace_name "politician" |> NamespacedName

    /// <summary>
    /// A passenger on or from a public transport vehicle.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#publicTransportPassenger"></see></summary>
    let publicTransportPassenger =
        Namespaced_IRI.parse _namespace_name "publicTransportPassenger" |> NamespacedName

    /// <summary>
    /// A sick person.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#sickPerson"></see></summary>
    let sickPerson = Namespaced_IRI.parse _namespace_name "sickPerson" |> NamespacedName

    /// <summary>
    /// A traffic patrol officer of the road authority.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#trafficOfficer"></see></summary>
    let trafficOfficer =
        Namespaced_IRI.parse _namespace_name "trafficOfficer" |> NamespacedName

    /// <summary>
    /// A member of the local traffic warden service.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#trafficWarden"></see></summary>
    let trafficWarden =
        Namespaced_IRI.parse _namespace_name "trafficWarden" |> NamespacedName

    /// <summary>
    /// A very important person.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#veryImportantPerson"></see></summary>
    let veryImportantPerson =
        Namespaced_IRI.parse _namespace_name "veryImportantPerson" |> NamespacedName

    /// <summary>
    /// A segment (or link) of the road network corresponding to the way in which the road operator has segmented the network.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#segment"></see></summary>
    let segment = Namespaced_IRI.parse _namespace_name "segment" |> NamespacedName
    /// <summary>
    /// Severe skid risk due to black ice (i.e. clear ice, which is impossible or very difficult to see).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#blackIce"></see></summary>
    let blackIce = Namespaced_IRI.parse _namespace_name "blackIce" |> NamespacedName
    /// <summary>
    /// Increased skid risk due to ice (of any kind).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ice"></see></summary>
    let ice = Namespaced_IRI.parse _namespace_name "ice" |> NamespacedName
    /// <summary>
    /// Severe skid risk due to icy patches (i.e. intermittent ice on roadway).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#icyPatches"></see></summary>
    let icyPatches = Namespaced_IRI.parse _namespace_name "icyPatches" |> NamespacedName
    /// <summary>
    /// Snow drifting is in progress or patches of deep snow are present due to earlier drifting.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#snowDrifts"></see></summary>
    let snowDrifts = Namespaced_IRI.parse _namespace_name "snowDrifts" |> NamespacedName

    /// <summary>
    /// Water is resting on the roadway which provides an increased hazard to vehicles.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#surfaceWater"></see></summary>
    let surfaceWater =
        Namespaced_IRI.parse _namespace_name "surfaceWater" |> NamespacedName

    /// <summary>
    /// Indicates if the altitude accuracy is equal to or less than 100 metres
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#equalToOrLessThan100Metres"></see></summary>
    let equalToOrLessThan100Metres =
        Namespaced_IRI.parse _namespace_name "equalToOrLessThan100Metres" |> NamespacedName

    /// <summary>
    /// Indicates if the altitude accuracy is equal to or less than 10 centimetres
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#equalToOrLessThan10Centimetres"></see></summary>
    let equalToOrLessThan10Centimetres =
        Namespaced_IRI.parse _namespace_name "equalToOrLessThan10Centimetres" |> NamespacedName

    /// <summary>
    /// Indicates if the altitude accuracy is equal to or less than 10 metres
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#equalToOrLessThan10Metres"></see></summary>
    let equalToOrLessThan10Metres =
        Namespaced_IRI.parse _namespace_name "equalToOrLessThan10Metres" |> NamespacedName

    /// <summary>
    /// Indicates if the altitude accuracy is equal to or less than 1 centimetre
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#equalToOrLessThan1Centimetre"></see></summary>
    let equalToOrLessThan1Centimetre =
        Namespaced_IRI.parse _namespace_name "equalToOrLessThan1Centimetre" |> NamespacedName

    /// <summary>
    /// Indicates if the altitude accuracy is equal to or less than 1 metre
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#equalToOrLessThan1Metre"></see></summary>
    let equalToOrLessThan1Metre =
        Namespaced_IRI.parse _namespace_name "equalToOrLessThan1Metre" |> NamespacedName

    /// <summary>
    /// Indicates if the altitude accuracy is equal to or less than 200 metres
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#equalToOrLessThan200Metres"></see></summary>
    let equalToOrLessThan200Metres =
        Namespaced_IRI.parse _namespace_name "equalToOrLessThan200Metres" |> NamespacedName

    /// <summary>
    /// Indicates if the altitude accuracy is equal to or less than 20 centimetres
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#equalToOrLessThan20Centimetres"></see></summary>
    let equalToOrLessThan20Centimetres =
        Namespaced_IRI.parse _namespace_name "equalToOrLessThan20Centimetres" |> NamespacedName

    /// <summary>
    /// Indicates if the altitude accuracy is equal to or less than 20 metres
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#equalToOrLessThan20Metres"></see></summary>
    let equalToOrLessThan20Metres =
        Namespaced_IRI.parse _namespace_name "equalToOrLessThan20Metres" |> NamespacedName

    /// <summary>
    /// Indicates if the altitude accuracy is equal to or less than 2 centimetres
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#equalToOrLessThan2Centimetres"></see></summary>
    let equalToOrLessThan2Centimetres =
        Namespaced_IRI.parse _namespace_name "equalToOrLessThan2Centimetres" |> NamespacedName

    /// <summary>
    /// Indicates if the altitude accuracy is equal to or less than 2 metres
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#equalToOrLessThan2Metres"></see></summary>
    let equalToOrLessThan2Metres =
        Namespaced_IRI.parse _namespace_name "equalToOrLessThan2Metres" |> NamespacedName

    /// <summary>
    /// Indicates if the altitude accuracy is equal to or less than 50 centimetres
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#equalToOrLessThan50Centimetres"></see></summary>
    let equalToOrLessThan50Centimetres =
        Namespaced_IRI.parse _namespace_name "equalToOrLessThan50Centimetres" |> NamespacedName

    /// <summary>
    /// Indicates if the altitude accuracy is equal to or less than 50 metres
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#equalToOrLessThan50Metres"></see></summary>
    let equalToOrLessThan50Metres =
        Namespaced_IRI.parse _namespace_name "equalToOrLessThan50Metres" |> NamespacedName

    /// <summary>
    /// Indicates if the altitude accuracy is equal to or less than 5 centimetres
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#equalToOrLessThan5Centimetres"></see></summary>
    let equalToOrLessThan5Centimetres =
        Namespaced_IRI.parse _namespace_name "equalToOrLessThan5Centimetres" |> NamespacedName

    /// <summary>
    /// Indicates if the altitude accuracy is equal to or less than 5 metres
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#equalToOrLessThan5Metres"></see></summary>
    let equalToOrLessThan5Metres =
        Namespaced_IRI.parse _namespace_name "equalToOrLessThan5Metres" |> NamespacedName

    /// <summary>
    /// In the centre of the roadway.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#inTheCentre"></see></summary>
    let inTheCentre =
        Namespaced_IRI.parse _namespace_name "inTheCentre" |> NamespacedName

    /// <summary>
    /// On the left of the roadway.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onTheLeft"></see></summary>
    let onTheLeft = Namespaced_IRI.parse _namespace_name "onTheLeft" |> NamespacedName
    /// <summary>
    /// On the right of the roadway.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onTheRight"></see></summary>
    let onTheRight = Namespaced_IRI.parse _namespace_name "onTheRight" |> NamespacedName

    /// <summary>
    /// The bridge at the specified location has swung or lifted and is therefore temporarily closed to traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#bridgeSwingInOperation"></see></summary>
    let bridgeSwingInOperation =
        Namespaced_IRI.parse _namespace_name "bridgeSwingInOperation" |> NamespacedName

    /// <summary>
    /// A convoy service is in operation.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#convoyService"></see></summary>
    let convoyService =
        Namespaced_IRI.parse _namespace_name "convoyService" |> NamespacedName

    /// <summary>
    /// Signs are being put out before or around an obstacle to protect drivers.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#obstacleSignalling"></see></summary>
    let obstacleSignalling =
        Namespaced_IRI.parse _namespace_name "obstacleSignalling" |> NamespacedName

    /// <summary>
    /// Ramp metering is now active at the specified location.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#rampMeteringInOperation"></see></summary>
    let rampMeteringInOperation =
        Namespaced_IRI.parse _namespace_name "rampMeteringInOperation" |> NamespacedName

    /// <summary>
    /// Traffic is being controlled by temporary traffic lights (red-yellow-green or red-green).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#temporaryTrafficLights"></see></summary>
    let temporaryTrafficLights =
        Namespaced_IRI.parse _namespace_name "temporaryTrafficLights" |> NamespacedName

    /// <summary>
    /// Toll gates are open with no fee collection at the specified location.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tollGatesOpen"></see></summary>
    let tollGatesOpen =
        Namespaced_IRI.parse _namespace_name "tollGatesOpen" |> NamespacedName

    /// <summary>
    /// Traffic is being manually directed.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#trafficBeingManuallyDirected"></see></summary>
    let trafficBeingManuallyDirected =
        Namespaced_IRI.parse _namespace_name "trafficBeingManuallyDirected" |> NamespacedName

    /// <summary>
    /// Traffic in the specified direction is temporarily held up due to an unplanned event (e.g. for clearance of wreckage following an accident).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#trafficHeld"></see></summary>
    let trafficHeld =
        Namespaced_IRI.parse _namespace_name "trafficHeld" |> NamespacedName

    /// <summary>
    /// Name of an administrative area.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#administrativeAreaName"></see></summary>
    let administrativeAreaName =
        Namespaced_IRI.parse _namespace_name "administrativeAreaName" |> NamespacedName

    /// <summary>
    /// Reference name by which administrative area is known.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#administrativeReferenceName"></see></summary>
    let administrativeReferenceName =
        Namespaced_IRI.parse _namespace_name "administrativeReferenceName" |> NamespacedName

    /// <summary>
    /// Name of an airport.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#airportName"></see></summary>
    let airportName =
        Namespaced_IRI.parse _namespace_name "airportName" |> NamespacedName

    /// <summary>
    ///   <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#areaName"></see>
    /// </summary>
    let areaName = Namespaced_IRI.parse _namespace_name "areaName" |> NamespacedName

    /// <summary>
    /// Name of a building.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#buildingName"></see></summary>
    let buildingName =
        Namespaced_IRI.parse _namespace_name "buildingName" |> NamespacedName

    /// <summary>
    /// Identifier of a bus stop on the road network.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#busStopIdentifier"></see></summary>
    let busStopIdentifier =
        Namespaced_IRI.parse _namespace_name "busStopIdentifier" |> NamespacedName

    /// <summary>
    /// Name of a bus stop on the road network.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#busStopName"></see></summary>
    let busStopName =
        Namespaced_IRI.parse _namespace_name "busStopName" |> NamespacedName

    /// <summary>
    /// Name of a canal.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#canalName"></see></summary>
    let canalName = Namespaced_IRI.parse _namespace_name "canalName" |> NamespacedName
    /// <summary>
    /// Name of a county (administrative sub-division).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#countyName"></see></summary>
    let countyName = Namespaced_IRI.parse _namespace_name "countyName" |> NamespacedName

    /// <summary>
    /// Name of a ferry port.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ferryPortName"></see></summary>
    let ferryPortName =
        Namespaced_IRI.parse _namespace_name "ferryPortName" |> NamespacedName

    /// <summary>
    /// Name of a road network intersection.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#intersectionName"></see></summary>
    let intersectionName =
        Namespaced_IRI.parse _namespace_name "intersectionName" |> NamespacedName

    /// <summary>
    /// Name of a lake.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#lakeName"></see></summary>
    let lakeName = Namespaced_IRI.parse _namespace_name "lakeName" |> NamespacedName
    /// <summary>
    /// Name of a road link.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#linkName"></see></summary>
    let linkName = Namespaced_IRI.parse _namespace_name "linkName" |> NamespacedName

    /// <summary>
    /// Local name of a road link.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#localLinkName"></see></summary>
    let localLinkName =
        Namespaced_IRI.parse _namespace_name "localLinkName" |> NamespacedName

    /// <summary>
    /// Name of a metro/underground station.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#metroStationName"></see></summary>
    let metroStationName =
        Namespaced_IRI.parse _namespace_name "metroStationName" |> NamespacedName

    /// <summary>
    /// Name of a nation (e.g. Wales) which is a sub-division of a ISO recognised country.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#nationName"></see></summary>
    let nationName = Namespaced_IRI.parse _namespace_name "nationName" |> NamespacedName

    /// <summary>
    /// Name of a point on the road network which is not at a junction or intersection.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#nonLinkedPointName"></see></summary>
    let nonLinkedPointName =
        Namespaced_IRI.parse _namespace_name "nonLinkedPointName" |> NamespacedName

    /// <summary>
    /// Name of a parking facility.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#parkingFacilityName"></see></summary>
    let parkingFacilityName =
        Namespaced_IRI.parse _namespace_name "parkingFacilityName" |> NamespacedName

    /// <summary>
    /// Name of a specific point.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#pointName"></see></summary>
    let pointName = Namespaced_IRI.parse _namespace_name "pointName" |> NamespacedName

    /// <summary>
    /// Name of a general point of interest.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#pointOfInterestName"></see></summary>
    let pointOfInterestName =
        Namespaced_IRI.parse _namespace_name "pointOfInterestName" |> NamespacedName

    /// <summary>
    /// Name of a railway station.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#railwayStation"></see></summary>
    let railwayStation =
        Namespaced_IRI.parse _namespace_name "railwayStation" |> NamespacedName

    /// <summary>
    /// Name of a geographic region.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#regionName"></see></summary>
    let regionName = Namespaced_IRI.parse _namespace_name "regionName" |> NamespacedName
    /// <summary>
    /// Name of a river.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#riverName"></see></summary>
    let riverName = Namespaced_IRI.parse _namespace_name "riverName" |> NamespacedName
    /// <summary>
    /// Name of a sea.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#seaName"></see></summary>
    let seaName = Namespaced_IRI.parse _namespace_name "seaName" |> NamespacedName

    /// <summary>
    /// Name of a service area on a road network.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#serviceAreaName"></see></summary>
    let serviceAreaName =
        Namespaced_IRI.parse _namespace_name "serviceAreaName" |> NamespacedName

    /// <summary>
    /// Name of a river which is of a tidal nature.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tidalRiverName"></see></summary>
    let tidalRiverName =
        Namespaced_IRI.parse _namespace_name "tidalRiverName" |> NamespacedName

    /// <summary>
    /// Name of a town.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#townName"></see></summary>
    let townName = Namespaced_IRI.parse _namespace_name "townName" |> NamespacedName
    /// <summary>
    /// A boundary between two jurisdictional or administrative areas. These may be legal boundaries such as between counties or countries, maintenance responsibility boundaries or control boundaries.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#boundary"></see></summary>
    let boundary = Namespaced_IRI.parse _namespace_name "boundary" |> NamespacedName

    /// <summary>
    /// A crossing of two or more roads where the precise point of intersection is defined according to specific business rules.
    ///
    /// An point on the road network at which one or more roads intersect.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#intersection"></see></summary>
    let intersection =
        Namespaced_IRI.parse _namespace_name "intersection" |> NamespacedName

    /// <summary>
    /// A visible identifiable physical landmark either alongside or close to the linear object.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#landmark"></see></summary>
    let landmark = Namespaced_IRI.parse _namespace_name "landmark" |> NamespacedName

    /// <summary>
    /// A marker which is usually but not necessarily physical that is one of a sequence which are spaced out along the linear object (road) to provide a location reference. The spacing of markers is not necessarily even.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#referenceMarker"></see></summary>
    let referenceMarker =
        Namespaced_IRI.parse _namespace_name "referenceMarker" |> NamespacedName

    /// <summary>
    /// A topological node defined on a road network. Such nodes may delineate the segmentation of the road network according to defined business rules or may constitute a purely topological representation of a road network.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadNode"></see></summary>
    let roadNode = Namespaced_IRI.parse _namespace_name "roadNode" |> NamespacedName

    /// <summary>
    /// A point on the road network which is not at a junction or intersection.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#nonLinkedPoint"></see></summary>
    let nonLinkedPoint =
        Namespaced_IRI.parse _namespace_name "nonLinkedPoint" |> NamespacedName

    /// <summary>
    /// Observe speed limit.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#observeSpeedLimits"></see></summary>
    let observeSpeedLimits =
        Namespaced_IRI.parse _namespace_name "observeSpeedLimits" |> NamespacedName

    /// <summary>
    /// Police speed checks are in operation.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#policeSpeedChecksInOperation"></see></summary>
    let policeSpeedChecksInOperation =
        Namespaced_IRI.parse _namespace_name "policeSpeedChecksInOperation" |> NamespacedName

    /// <summary>
    /// Reduce your speed.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#reduceYourSpeed"></see></summary>
    let reduceYourSpeed =
        Namespaced_IRI.parse _namespace_name "reduceYourSpeed" |> NamespacedName

    /// <summary>
    /// Same direction as the normal direction of flow at this point on the road network.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#aligned"></see></summary>
    let aligned = Namespaced_IRI.parse _namespace_name "aligned" |> NamespacedName

    /// <summary>
    /// All directions (where more than two are applicable) at this point on the road network.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#allDirections"></see></summary>
    let allDirections =
        Namespaced_IRI.parse _namespace_name "allDirections" |> NamespacedName

    /// <summary>
    /// Anti-clockwise.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#anticlockwise"></see></summary>
    let anticlockwise =
        Namespaced_IRI.parse _namespace_name "anticlockwise" |> NamespacedName

    /// <summary>
    /// Both directions that are applicable at this point on the road network.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#bothWays"></see></summary>
    let bothWays = Namespaced_IRI.parse _namespace_name "bothWays" |> NamespacedName
    /// <summary>
    /// Clockwise.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#clockwise"></see></summary>
    let clockwise = Namespaced_IRI.parse _namespace_name "clockwise" |> NamespacedName
    /// <summary>
    /// East bound general direction.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#eastBound"></see></summary>
    let eastBound = Namespaced_IRI.parse _namespace_name "eastBound" |> NamespacedName

    /// <summary>
    /// Heading towards town centre direction of travel.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#inboundTowardsTown"></see></summary>
    let inboundTowardsTown =
        Namespaced_IRI.parse _namespace_name "inboundTowardsTown" |> NamespacedName

    /// <summary>
    /// Inner ring direction.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#innerRing"></see></summary>
    let innerRing = Namespaced_IRI.parse _namespace_name "innerRing" |> NamespacedName
    /// <summary>
    /// North bound general direction.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#northBound"></see></summary>
    let northBound = Namespaced_IRI.parse _namespace_name "northBound" |> NamespacedName

    /// <summary>
    /// North east bound general direction.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#northEastBound"></see></summary>
    let northEastBound =
        Namespaced_IRI.parse _namespace_name "northEastBound" |> NamespacedName

    /// <summary>
    /// North west bound general direction.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#northWestBound"></see></summary>
    let northWestBound =
        Namespaced_IRI.parse _namespace_name "northWestBound" |> NamespacedName

    /// <summary>
    /// Indicates that the direction of traffic flow affected by the situation or related to the traffic data is in the opposite sense to the direction in which the linear element is defined.
    /// Opposite direction to the normal direction of flow at this point on the road network.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#opposite"></see></summary>
    let opposite = Namespaced_IRI.parse _namespace_name "opposite" |> NamespacedName

    /// <summary>
    /// Heading out of or away from the town centre direction of travel.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#outboundFromTown"></see></summary>
    let outboundFromTown =
        Namespaced_IRI.parse _namespace_name "outboundFromTown" |> NamespacedName

    /// <summary>
    /// Outer ring direction.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#outerRing"></see></summary>
    let outerRing = Namespaced_IRI.parse _namespace_name "outerRing" |> NamespacedName
    /// <summary>
    /// South bound general direction.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#southBound"></see></summary>
    let southBound = Namespaced_IRI.parse _namespace_name "southBound" |> NamespacedName

    /// <summary>
    /// South east bound general direction.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#southEastBound"></see></summary>
    let southEastBound =
        Namespaced_IRI.parse _namespace_name "southEastBound" |> NamespacedName

    /// <summary>
    /// South west bound general direction.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#southWestBound"></see></summary>
    let southWestBound =
        Namespaced_IRI.parse _namespace_name "southWestBound" |> NamespacedName

    /// <summary>
    /// West bound general direction.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#westBound"></see></summary>
    let westBound = Namespaced_IRI.parse _namespace_name "westBound" |> NamespacedName

    /// <summary>
    /// Maintenance vehicles are merging into the traffic flow creating a potential hazard for road users.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#maintenanceVehiclesMergingIntoTrafficFlow"></see></summary>
    let maintenanceVehiclesMergingIntoTrafficFlow =
        Namespaced_IRI.parse _namespace_name "maintenanceVehiclesMergingIntoTrafficFlow" |> NamespacedName

    /// <summary>
    /// Maintenance vehicle(s) are spreading salt and/or grit.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#saltAndGritSpreading"></see></summary>
    let saltAndGritSpreading =
        Namespaced_IRI.parse _namespace_name "saltAndGritSpreading" |> NamespacedName

    /// <summary>
    /// Maintenance vehicles are slow moving.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#slowMoving"></see></summary>
    let slowMoving = Namespaced_IRI.parse _namespace_name "slowMoving" |> NamespacedName

    /// <summary>
    /// Maintenance vehicle(s) are involved in the clearance of snow.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#snowClearing"></see></summary>
    let snowClearing =
        Namespaced_IRI.parse _namespace_name "snowClearing" |> NamespacedName

    /// <summary>
    /// Maintenance vehicles are stopping to service equipments on or next to the roadway.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#stoppingToServiceEquipments"></see></summary>
    let stoppingToServiceEquipments =
        Namespaced_IRI.parse _namespace_name "stoppingToServiceEquipments" |> NamespacedName

    /// <summary>
    /// The direction of navigation in an ALERT-C table that corresponds to the negative offset usage to go from the secondary location to the primary location within the ALERT-C location table.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#negative"></see></summary>
    let negative = Namespaced_IRI.parse _namespace_name "negative" |> NamespacedName
    /// <summary>
    /// The direction of navigation in an ALERT-C table that corresponds to the negative offset usage to go from the secondary location to the primary location within the ALERT-C location table.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#positive"></see></summary>
    let positive = Namespaced_IRI.parse _namespace_name "positive" |> NamespacedName
    /// <summary>
    /// Accidents are situations in which one or more vehicles lose control and do not recover.  They include collisions between vehicle(s) or other road user(s), between vehicle(s) and fixed obstacle(s), or they result from a vehicle running off the road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#accident"></see></summary>
    let accident = Namespaced_IRI.parse _namespace_name "accident" |> NamespacedName

    /// <summary>
    /// Includes all accidents involving at least one vehicle believed to be carrying materials, which could present an additional hazard to road users.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#accidentInvolvingHazardousMaterials"></see></summary>
    let accidentInvolvingHazardousMaterials =
        Namespaced_IRI.parse _namespace_name "accidentInvolvingHazardousMaterials" |> NamespacedName

    /// <summary>
    /// Includes all accidents involving at least one heavy goods vehicle.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#accidentInvolvingHeavyLorries"></see></summary>
    let accidentInvolvingHeavyLorries =
        Namespaced_IRI.parse _namespace_name "accidentInvolvingHeavyLorries" |> NamespacedName

    /// <summary>
    /// Collision of vehicle with another object of unspecified type.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#collision"></see></summary>
    let collision = Namespaced_IRI.parse _namespace_name "collision" |> NamespacedName

    /// <summary>
    /// Includes all accidents involving three or more vehicles.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#multipleVehicleAccident"></see></summary>
    let multipleVehicleAccident =
        Namespaced_IRI.parse _namespace_name "multipleVehicleAccident" |> NamespacedName

    /// <summary>
    /// A descriptor indicating the most significant factor causing an accident.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#accidentCause"></see></summary>
    let accidentCause =
        Namespaced_IRI.parse _namespace_name "accidentCause" |> NamespacedName

    /// <summary>
    /// Traffic congestion.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#congestion"></see></summary>
    let congestion = Namespaced_IRI.parse _namespace_name "congestion" |> NamespacedName

    /// <summary>
    /// Equipment  which is faulty, malfunctioning or not in a fully operational state that may be of interest or concern to road operators and road users.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#equipmentFailure"></see></summary>
    let equipmentFailure =
        Namespaced_IRI.parse _namespace_name "equipmentFailure" |> NamespacedName

    /// <summary>
    /// Failure of road infrastructure.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#infrastructureFailure"></see></summary>
    let infrastructureFailure =
        Namespaced_IRI.parse _namespace_name "infrastructureFailure" |> NamespacedName

    /// <summary>
    /// Obstruction (of unspecified type) on the roadway.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#obstruction"></see></summary>
    let obstruction =
        Namespaced_IRI.parse _namespace_name "obstruction" |> NamespacedName

    /// <summary>
    /// Poor weather conditions.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#poorWeather"></see></summary>
    let poorWeather =
        Namespaced_IRI.parse _namespace_name "poorWeather" |> NamespacedName

    /// <summary>
    /// Problems at the border crossing.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#problemsAtBorderPost"></see></summary>
    let problemsAtBorderPost =
        Namespaced_IRI.parse _namespace_name "problemsAtBorderPost" |> NamespacedName

    /// <summary>
    /// Problems at the customs post on the border.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#problemsAtCustomPost"></see></summary>
    let problemsAtCustomPost =
        Namespaced_IRI.parse _namespace_name "problemsAtCustomPost" |> NamespacedName

    /// <summary>
    /// Problems (of an unspecified nature) on the local roads.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#problemsOnLocalRoads"></see></summary>
    let problemsOnLocalRoads =
        Namespaced_IRI.parse _namespace_name "problemsOnLocalRoads" |> NamespacedName

    /// <summary>
    /// A roadside event (of unspecified nature) whether planned or not.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadsideEvent"></see></summary>
    let roadsideEvent =
        Namespaced_IRI.parse _namespace_name "roadsideEvent" |> NamespacedName

    /// <summary>
    /// A security incident.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#securityIncident"></see></summary>
    let securityIncident =
        Namespaced_IRI.parse _namespace_name "securityIncident" |> NamespacedName

    /// <summary>
    /// A terrorist incident.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#terrorism"></see></summary>
    let terrorism = Namespaced_IRI.parse _namespace_name "terrorism" |> NamespacedName
    /// <summary>
    /// A vandalism incident.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#vandalism"></see></summary>
    let vandalism = Namespaced_IRI.parse _namespace_name "vandalism" |> NamespacedName
    /// <summary>
    /// Bridge on, over or under the highway.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#bridge"></see></summary>
    let bridge = Namespaced_IRI.parse _namespace_name "bridge" |> NamespacedName

    /// <summary>
    /// Buried cables under or along the highway.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#buriedCables"></see></summary>
    let buriedCables =
        Namespaced_IRI.parse _namespace_name "buriedCables" |> NamespacedName

    /// <summary>
    /// Unspecified buried services on, under or along the highway.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#buriedServices"></see></summary>
    let buriedServices =
        Namespaced_IRI.parse _namespace_name "buriedServices" |> NamespacedName

    /// <summary>
    /// Crash barrier.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#crashBarrier"></see></summary>
    let crashBarrier =
        Namespaced_IRI.parse _namespace_name "crashBarrier" |> NamespacedName

    /// <summary>
    /// Gallery.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#gallery"></see></summary>
    let gallery = Namespaced_IRI.parse _namespace_name "gallery" |> NamespacedName
    /// <summary>
    /// Gantry over or above the roadway.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#gantry"></see></summary>
    let gantry = Namespaced_IRI.parse _namespace_name "gantry" |> NamespacedName

    /// <summary>
    /// Gas mains.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#gasMainWork"></see></summary>
    let gasMainWork =
        Namespaced_IRI.parse _namespace_name "gasMainWork" |> NamespacedName

    /// <summary>
    /// Motorway or major road interchange.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#interchange"></see></summary>
    let interchange =
        Namespaced_IRI.parse _namespace_name "interchange" |> NamespacedName

    /// <summary>
    /// Motorway or major road junction.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#junction"></see></summary>
    let junction = Namespaced_IRI.parse _namespace_name "junction" |> NamespacedName

    /// <summary>
    /// Level-crossing or associated equipment.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#levelCrossing"></see></summary>
    let levelCrossing =
        Namespaced_IRI.parse _namespace_name "levelCrossing" |> NamespacedName

    /// <summary>
    /// Road lighting system.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#lightingSystem"></see></summary>
    let lightingSystem =
        Namespaced_IRI.parse _namespace_name "lightingSystem" |> NamespacedName

    /// <summary>
    /// Equipment used for determining traffic measurements.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#measurementEquipment"></see></summary>
    let measurementEquipment =
        Namespaced_IRI.parse _namespace_name "measurementEquipment" |> NamespacedName

    /// <summary>
    /// Installations along the roadway designed to reduce road noise in the surrounding environment.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#noiseProtection"></see></summary>
    let noiseProtection =
        Namespaced_IRI.parse _namespace_name "noiseProtection" |> NamespacedName

    /// <summary>
    /// road
    /// The nature of the linear element is a road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#road"></see></summary>
    let road = Namespaced_IRI.parse _namespace_name "road" |> NamespacedName
    /// <summary>
    /// Road signs.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadSigns"></see></summary>
    let roadSigns = Namespaced_IRI.parse _namespace_name "roadSigns" |> NamespacedName

    /// <summary>
    /// Roadside drains.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadsideDrains"></see></summary>
    let roadsideDrains =
        Namespaced_IRI.parse _namespace_name "roadsideDrains" |> NamespacedName

    /// <summary>
    /// Roadside embankment.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadsideEmbankment"></see></summary>
    let roadsideEmbankment =
        Namespaced_IRI.parse _namespace_name "roadsideEmbankment" |> NamespacedName

    /// <summary>
    /// Roadside equipment.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadsideEquipment"></see></summary>
    let roadsideEquipment =
        Namespaced_IRI.parse _namespace_name "roadsideEquipment" |> NamespacedName

    /// <summary>
    /// Toll gate.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tollGate"></see></summary>
    let tollGate = Namespaced_IRI.parse _namespace_name "tollGate" |> NamespacedName
    /// <summary>
    /// Road tunnel.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tunnel"></see></summary>
    let tunnel = Namespaced_IRI.parse _namespace_name "tunnel" |> NamespacedName
    /// <summary>
    /// Water main under or along the highway.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#waterMain"></see></summary>
    let waterMain = Namespaced_IRI.parse _namespace_name "waterMain" |> NamespacedName
    /// <summary>
    /// On the both sides of the roads.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#bothSides"></see></summary>
    let bothSides = Namespaced_IRI.parse _namespace_name "bothSides" |> NamespacedName

    /// <summary>
    /// For internal use only of the recipient organisation.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#internalUse"></see></summary>
    let internalUse =
        Namespaced_IRI.parse _namespace_name "internalUse" |> NamespacedName

    /// <summary>
    /// No restriction on usage.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#noRestriction"></see></summary>
    let noRestriction =
        Namespaced_IRI.parse _namespace_name "noRestriction" |> NamespacedName

    /// <summary>
    /// Restricted for use only by authorities.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#restrictedToAuthorities"></see></summary>
    let restrictedToAuthorities =
        Namespaced_IRI.parse _namespace_name "restrictedToAuthorities" |> NamespacedName

    /// <summary>
    /// Restricted for use only by authorities and traffic operators.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#restrictedToAuthoritiesAndTrafficOperators"></see></summary>
    let restrictedToAuthoritiesAndTrafficOperators =
        Namespaced_IRI.parse _namespace_name "restrictedToAuthoritiesAndTrafficOperators" |> NamespacedName

    /// <summary>
    /// Restricted for use only by authorities, traffic operators and publishers (service providers).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#restrictedToAuthoritiesTrafficOperatorsAndPublishers"></see></summary>
    let restrictedToAuthoritiesTrafficOperatorsAndPublishers =
        Namespaced_IRI.parse _namespace_name "restrictedToAuthoritiesTrafficOperatorsAndPublishers" |> NamespacedName

    /// <summary>
    /// Restricted for use only by authorities, traffic operators, publishers (service providers) and variable message signs.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#restrictedToAuthoritiesTrafficOperatorsAndVms"></see></summary>
    let restrictedToAuthoritiesTrafficOperatorsAndVms =
        Namespaced_IRI.parse _namespace_name "restrictedToAuthoritiesTrafficOperatorsAndVms" |> NamespacedName

    /// <summary>
    /// On the connecting carriageway.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#connectingCarriageway"></see></summary>
    let connectingCarriageway =
        Namespaced_IRI.parse _namespace_name "connectingCarriageway" |> NamespacedName

    /// <summary>
    /// Independent road or part of a road designated for cycles, signposted as such. A cycle track is separated from other roads or other parts of the same road by structural means.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#cycleTrack"></see></summary>
    let cycleTrack = Namespaced_IRI.parse _namespace_name "cycleTrack" |> NamespacedName

    /// <summary>
    /// On the entry slip road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#entrySlipRoad"></see></summary>
    let entrySlipRoad =
        Namespaced_IRI.parse _namespace_name "entrySlipRoad" |> NamespacedName

    /// <summary>
    /// On the exit slip road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#exitSlipRoad"></see></summary>
    let exitSlipRoad =
        Namespaced_IRI.parse _namespace_name "exitSlipRoad" |> NamespacedName

    /// <summary>
    /// On the flyover, i.e. the section of road passing over another.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#flyover"></see></summary>
    let flyover = Namespaced_IRI.parse _namespace_name "flyover" |> NamespacedName
    /// <summary>
    /// On the footpath
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#footpath"></see></summary>
    let footpath = Namespaced_IRI.parse _namespace_name "footpath" |> NamespacedName

    /// <summary>
    /// On the left hand feeder road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#leftHandFeederRoad"></see></summary>
    let leftHandFeederRoad =
        Namespaced_IRI.parse _namespace_name "leftHandFeederRoad" |> NamespacedName

    /// <summary>
    /// On the left hand parallel carriageway.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#leftHandParallelCarriageway"></see></summary>
    let leftHandParallelCarriageway =
        Namespaced_IRI.parse _namespace_name "leftHandParallelCarriageway" |> NamespacedName

    /// <summary>
    /// On the main carriageway.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#mainCarriageway"></see></summary>
    let mainCarriageway =
        Namespaced_IRI.parse _namespace_name "mainCarriageway" |> NamespacedName

    /// <summary>
    /// On the opposite carriageway.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#oppositeCarriageway"></see></summary>
    let oppositeCarriageway =
        Namespaced_IRI.parse _namespace_name "oppositeCarriageway" |> NamespacedName

    /// <summary>
    /// On the adjacent external parallel carriageway.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#parallelCarriageway"></see></summary>
    let parallelCarriageway =
        Namespaced_IRI.parse _namespace_name "parallelCarriageway" |> NamespacedName

    /// <summary>
    /// On the right hand feeder road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#rightHandFeederRoad"></see></summary>
    let rightHandFeederRoad =
        Namespaced_IRI.parse _namespace_name "rightHandFeederRoad" |> NamespacedName

    /// <summary>
    /// On the right hand parallel carriageway.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#rightHandParallelCarriageway"></see></summary>
    let rightHandParallelCarriageway =
        Namespaced_IRI.parse _namespace_name "rightHandParallelCarriageway" |> NamespacedName

    /// <summary>
    /// On the adjacent service road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#serviceRoad"></see></summary>
    let serviceRoad =
        Namespaced_IRI.parse _namespace_name "serviceRoad" |> NamespacedName

    /// <summary>
    /// On the slip roads.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#slipRoads"></see></summary>
    let slipRoads = Namespaced_IRI.parse _namespace_name "slipRoads" |> NamespacedName
    /// <summary>
    /// On the underpass, i.e. the section of road passing under another.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#underpass"></see></summary>
    let underpass = Namespaced_IRI.parse _namespace_name "underpass" |> NamespacedName

    /// <summary>
    /// On an unspecified carriageway
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#unspecifiedCarriageway"></see></summary>
    let unspecifiedCarriageway =
        Namespaced_IRI.parse _namespace_name "unspecifiedCarriageway" |> NamespacedName

    /// <summary>
    /// Vehicle normally used for agricultural purposes, e.g. tractor, combined harvester etc.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#agriculturalVehicle"></see></summary>
    let agriculturalVehicle =
        Namespaced_IRI.parse _namespace_name "agriculturalVehicle" |> NamespacedName

    /// <summary>
    /// Vehicle of any type.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#anyVehicle"></see></summary>
    let anyVehicle = Namespaced_IRI.parse _namespace_name "anyVehicle" |> NamespacedName

    /// <summary>
    /// Articulated vehicle.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#articulatedVehicle"></see></summary>
    let articulatedVehicle =
        Namespaced_IRI.parse _namespace_name "articulatedVehicle" |> NamespacedName

    /// <summary>
    /// Bicycle.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#bicycle"></see></summary>
    let bicycle = Namespaced_IRI.parse _namespace_name "bicycle" |> NamespacedName
    /// <summary>
    /// Bus.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#bus"></see></summary>
    let bus = Namespaced_IRI.parse _namespace_name "bus" |> NamespacedName
    /// <summary>
    /// Car.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#car"></see></summary>
    let car = Namespaced_IRI.parse _namespace_name "car" |> NamespacedName

    /// <summary>
    /// Car or light vehicle.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#carOrLightVehicle"></see></summary>
    let carOrLightVehicle =
        Namespaced_IRI.parse _namespace_name "carOrLightVehicle" |> NamespacedName

    /// <summary>
    /// Car towing a caravan.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#carWithCaravan"></see></summary>
    let carWithCaravan =
        Namespaced_IRI.parse _namespace_name "carWithCaravan" |> NamespacedName

    /// <summary>
    /// Car towing a trailer.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#carWithTrailer"></see></summary>
    let carWithTrailer =
        Namespaced_IRI.parse _namespace_name "carWithTrailer" |> NamespacedName

    /// <summary>
    /// Caravan.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#caravan"></see></summary>
    let caravan = Namespaced_IRI.parse _namespace_name "caravan" |> NamespacedName

    /// <summary>
    /// Vehicle normally used for construction or maintenance purposes, e.g. digger, excavator, bulldozer, lorry mounted crane etc.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#constructionOrMaintenanceVehicle"></see></summary>
    let constructionOrMaintenanceVehicle =
        Namespaced_IRI.parse _namespace_name "constructionOrMaintenanceVehicle" |> NamespacedName

    /// <summary>
    /// Four wheel drive vehicle.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#fourWheelDrive"></see></summary>
    let fourWheelDrive =
        Namespaced_IRI.parse _namespace_name "fourWheelDrive" |> NamespacedName

    /// <summary>
    /// High sided vehicle.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#highSidedVehicle"></see></summary>
    let highSidedVehicle =
        Namespaced_IRI.parse _namespace_name "highSidedVehicle" |> NamespacedName

    /// <summary>
    /// A heavy lorry that is longer than normal.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#longHeavyLorry"></see></summary>
    let longHeavyLorry =
        Namespaced_IRI.parse _namespace_name "longHeavyLorry" |> NamespacedName

    /// <summary>
    /// Lorry of any type.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#lorry"></see></summary>
    let lorry = Namespaced_IRI.parse _namespace_name "lorry" |> NamespacedName
    /// <summary>
    /// Moped (a two wheeled motor vehicle characterized by a small engine typically less than 50cc and by normally having pedals).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#moped"></see></summary>
    let moped = Namespaced_IRI.parse _namespace_name "moped" |> NamespacedName
    /// <summary>
    /// Motorcycle.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#motorcycle"></see></summary>
    let motorcycle = Namespaced_IRI.parse _namespace_name "motorcycle" |> NamespacedName

    /// <summary>
    /// Three wheeled vehicle comprising a motorcycle with an attached side car.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#motorcycleWithSideCar"></see></summary>
    let motorcycleWithSideCar =
        Namespaced_IRI.parse _namespace_name "motorcycleWithSideCar" |> NamespacedName

    /// <summary>
    /// Motorscooter (a two wheeled motor vehicle characterized by a step-through frame and small diameter wheels).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#motorscooter"></see></summary>
    let motorscooter =
        Namespaced_IRI.parse _namespace_name "motorscooter" |> NamespacedName

    /// <summary>
    /// Vehicle with large tank for carrying bulk liquids.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tanker"></see></summary>
    let tanker = Namespaced_IRI.parse _namespace_name "tanker" |> NamespacedName

    /// <summary>
    /// Three wheeled vehicle of unspecified type.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#threeWheeledVehicle"></see></summary>
    let threeWheeledVehicle =
        Namespaced_IRI.parse _namespace_name "threeWheeledVehicle" |> NamespacedName

    /// <summary>
    /// Trailer.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#trailer"></see></summary>
    let trailer = Namespaced_IRI.parse _namespace_name "trailer" |> NamespacedName
    /// <summary>
    /// Tram.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tram"></see></summary>
    let tram = Namespaced_IRI.parse _namespace_name "tram" |> NamespacedName

    /// <summary>
    /// Two wheeled vehicle of unspecified type.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#twoWheeledVehicle"></see></summary>
    let twoWheeledVehicle =
        Namespaced_IRI.parse _namespace_name "twoWheeledVehicle" |> NamespacedName

    /// <summary>
    /// Van.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#van"></see></summary>
    let van = Namespaced_IRI.parse _namespace_name "van" |> NamespacedName

    /// <summary>
    /// Vehicle (of unspecified type) towing a caravan.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#vehicleWithCaravan"></see></summary>
    let vehicleWithCaravan =
        Namespaced_IRI.parse _namespace_name "vehicleWithCaravan" |> NamespacedName

    /// <summary>
    /// Vehicle with catalytic converter.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#vehicleWithCatalyticConverter"></see></summary>
    let vehicleWithCatalyticConverter =
        Namespaced_IRI.parse _namespace_name "vehicleWithCatalyticConverter" |> NamespacedName

    /// <summary>
    /// Vehicle (of unspecified type) towing a trailer.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#vehicleWithTrailer"></see></summary>
    let vehicleWithTrailer =
        Namespaced_IRI.parse _namespace_name "vehicleWithTrailer" |> NamespacedName

    /// <summary>
    /// Vehicle without catalytic converter.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#vehicleWithoutCatalyticConverter"></see></summary>
    let vehicleWithoutCatalyticConverter =
        Namespaced_IRI.parse _namespace_name "vehicleWithoutCatalyticConverter" |> NamespacedName

    /// <summary>
    /// Vehicle with even numbered registration plate.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#withEvenNumberedRegistrationPlates"></see></summary>
    let withEvenNumberedRegistrationPlates =
        Namespaced_IRI.parse _namespace_name "withEvenNumberedRegistrationPlates" |> NamespacedName

    /// <summary>
    /// Vehicle with odd numbered registration plate.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#withOddNumberedRegistrationPlates"></see></summary>
    let withOddNumberedRegistrationPlates =
        Namespaced_IRI.parse _namespace_name "withOddNumberedRegistrationPlates" |> NamespacedName

    /// <summary>
    /// LAU 1 code
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#lau1Code"></see></summary>
    let lau1Code = Namespaced_IRI.parse _namespace_name "lau1Code" |> NamespacedName
    /// <summary>
    /// LAU 2 code
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#lau2Code"></see></summary>
    let lau2Code = Namespaced_IRI.parse _namespace_name "lau2Code" |> NamespacedName
    /// <summary>
    /// NUTS 1 code
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#nuts1Code"></see></summary>
    let nuts1Code = Namespaced_IRI.parse _namespace_name "nuts1Code" |> NamespacedName
    /// <summary>
    /// NUTS 2 code
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#nuts2Code"></see></summary>
    let nuts2Code = Namespaced_IRI.parse _namespace_name "nuts2Code" |> NamespacedName
    /// <summary>
    /// NUTS 3 code
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#nuts3Code"></see></summary>
    let nuts3Code = Namespaced_IRI.parse _namespace_name "nuts3Code" |> NamespacedName

    /// <summary>
    /// The nature of the linear element is a section of a road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadSection"></see></summary>
    let roadSection =
        Namespaced_IRI.parse _namespace_name "roadSection" |> NamespacedName

    /// <summary>
    /// Air ambulance assistance.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#airAmbulance"></see></summary>
    let airAmbulance =
        Namespaced_IRI.parse _namespace_name "airAmbulance" |> NamespacedName

    /// <summary>
    /// Bus passenger assistance.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#busPassengerAssistance"></see></summary>
    let busPassengerAssistance =
        Namespaced_IRI.parse _namespace_name "busPassengerAssistance" |> NamespacedName

    /// <summary>
    /// Emergency services assistance.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#emergencyServices"></see></summary>
    let emergencyServices =
        Namespaced_IRI.parse _namespace_name "emergencyServices" |> NamespacedName

    /// <summary>
    /// First aid assistance.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#firstAid"></see></summary>
    let firstAid = Namespaced_IRI.parse _namespace_name "firstAid" |> NamespacedName

    /// <summary>
    /// Food delivery.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#foodDelivery"></see></summary>
    let foodDelivery =
        Namespaced_IRI.parse _namespace_name "foodDelivery" |> NamespacedName

    /// <summary>
    /// Helicopter rescue.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#helicopterRescue"></see></summary>
    let helicopterRescue =
        Namespaced_IRI.parse _namespace_name "helicopterRescue" |> NamespacedName

    /// <summary>
    /// Vehicle recovery.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#vehicleRecovery"></see></summary>
    let vehicleRecovery =
        Namespaced_IRI.parse _namespace_name "vehicleRecovery" |> NamespacedName

    /// <summary>
    /// Vehicle repair assistance.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#vehicleRepair"></see></summary>
    let vehicleRepair =
        Namespaced_IRI.parse _namespace_name "vehicleRepair" |> NamespacedName

    /// <summary>
    /// At a motorway interchange.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#atMotorwayInterchange"></see></summary>
    let atMotorwayInterchange =
        Namespaced_IRI.parse _namespace_name "atMotorwayInterchange" |> NamespacedName

    /// <summary>
    /// At rest area off the carriageway.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#atRestArea"></see></summary>
    let atRestArea = Namespaced_IRI.parse _namespace_name "atRestArea" |> NamespacedName

    /// <summary>
    /// At service area.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#atServiceArea"></see></summary>
    let atServiceArea =
        Namespaced_IRI.parse _namespace_name "atServiceArea" |> NamespacedName

    /// <summary>
    /// At toll plaza.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#atTollPlaza"></see></summary>
    let atTollPlaza =
        Namespaced_IRI.parse _namespace_name "atTollPlaza" |> NamespacedName

    /// <summary>
    /// At entry or exit of tunnel.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#atTunnelEntryOrExit"></see></summary>
    let atTunnelEntryOrExit =
        Namespaced_IRI.parse _namespace_name "atTunnelEntryOrExit" |> NamespacedName

    /// <summary>
    /// In gallery.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#inGallery"></see></summary>
    let inGallery = Namespaced_IRI.parse _namespace_name "inGallery" |> NamespacedName
    /// <summary>
    /// In tunnel.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#inTunnel"></see></summary>
    let inTunnel = Namespaced_IRI.parse _namespace_name "inTunnel" |> NamespacedName
    /// <summary>
    /// On bridge
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onBridge"></see></summary>
    let onBridge = Namespaced_IRI.parse _namespace_name "onBridge" |> NamespacedName

    /// <summary>
    /// On connecting carriageway between two different roads or road sections.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onConnector"></see></summary>
    let onConnector =
        Namespaced_IRI.parse _namespace_name "onConnector" |> NamespacedName

    /// <summary>
    /// On elevated section of road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onElevatedSection"></see></summary>
    let onElevatedSection =
        Namespaced_IRI.parse _namespace_name "onElevatedSection" |> NamespacedName

    /// <summary>
    /// On flyover, i.e. on section of road over another road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onFlyover"></see></summary>
    let onFlyover = Namespaced_IRI.parse _namespace_name "onFlyover" |> NamespacedName
    /// <summary>
    /// On ice road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onIceRoad"></see></summary>
    let onIceRoad = Namespaced_IRI.parse _namespace_name "onIceRoad" |> NamespacedName

    /// <summary>
    /// On level-crossing.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onLevelCrossing"></see></summary>
    let onLevelCrossing =
        Namespaced_IRI.parse _namespace_name "onLevelCrossing" |> NamespacedName

    /// <summary>
    /// On road section linking two different roads.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onLinkRoad"></see></summary>
    let onLinkRoad = Namespaced_IRI.parse _namespace_name "onLinkRoad" |> NamespacedName

    /// <summary>
    /// On roundabout.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onRoundabout"></see></summary>
    let onRoundabout =
        Namespaced_IRI.parse _namespace_name "onRoundabout" |> NamespacedName

    /// <summary>
    /// On the roadway.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onTheRoadway"></see></summary>
    let onTheRoadway =
        Namespaced_IRI.parse _namespace_name "onTheRoadway" |> NamespacedName

    /// <summary>
    /// On underground section of road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onUndergroundSection"></see></summary>
    let onUndergroundSection =
        Namespaced_IRI.parse _namespace_name "onUndergroundSection" |> NamespacedName

    /// <summary>
    /// On underpass, i.e. section of road which passes under another road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onUnderpass"></see></summary>
    let onUnderpass =
        Namespaced_IRI.parse _namespace_name "onUnderpass" |> NamespacedName

    /// <summary>
    /// On the main carriageway within a junction between exit slip road and entry slip road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#withinJunction"></see></summary>
    let withinJunction =
        Namespaced_IRI.parse _namespace_name "withinJunction" |> NamespacedName

    /// <summary>
    /// Indicates the accuracy is out of range, i.e. greater than 4 093 cm for horizontal position.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#outOfRange"></see></summary>
    let outOfRange = Namespaced_IRI.parse _namespace_name "outOfRange" |> NamespacedName

    /// <summary>
    /// Indicates the accuracy information is unavailable.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#unavailable"></see></summary>
    let unavailable =
        Namespaced_IRI.parse _namespace_name "unavailable" |> NamespacedName

    /// <summary>
    /// Delays on the road network as a result of any situation which causes hold-ups.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#delays"></see></summary>
    let delays = Namespaced_IRI.parse _namespace_name "delays" |> NamespacedName

    /// <summary>
    /// Delays on the road network whose predicted duration cannot be estimated.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#delaysOfUncertainDuration"></see></summary>
    let delaysOfUncertainDuration =
        Namespaced_IRI.parse _namespace_name "delaysOfUncertainDuration" |> NamespacedName

    /// <summary>
    /// Delays on the road network of unusual severity.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#longDelays"></see></summary>
    let longDelays = Namespaced_IRI.parse _namespace_name "longDelays" |> NamespacedName

    /// <summary>
    /// Delays on the road network of abnormally unusual severity.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#veryLongDelays"></see></summary>
    let veryLongDelays =
        Namespaced_IRI.parse _namespace_name "veryLongDelays" |> NamespacedName

    /// <summary>
    /// The road may be obstructed or partially obstructed due to snow slides.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#avalanches"></see></summary>
    let avalanches = Namespaced_IRI.parse _namespace_name "avalanches" |> NamespacedName

    /// <summary>
    /// The road is obstructed or partially obstructed by one or more fallen trees.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#fallenTrees"></see></summary>
    let fallenTrees =
        Namespaced_IRI.parse _namespace_name "fallenTrees" |> NamespacedName

    /// <summary>
    /// The road is obstructed or partially obstructed by flood water.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#flooding"></see></summary>
    let flooding = Namespaced_IRI.parse _namespace_name "flooding" |> NamespacedName
    /// <summary>
    /// The road may be obstructed or partially obstructed due to landslides.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#landslips"></see></summary>
    let landslips = Namespaced_IRI.parse _namespace_name "landslips" |> NamespacedName
    /// <summary>
    /// The road may be obstructed or partially obstructed due to fallen rocks.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#rockfalls"></see></summary>
    let rockfalls = Namespaced_IRI.parse _namespace_name "rockfalls" |> NamespacedName
    /// <summary>
    /// The road surface has sunken or collapsed in places.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#subsidence"></see></summary>
    let subsidence = Namespaced_IRI.parse _namespace_name "subsidence" |> NamespacedName

    /// <summary>
    /// A point on the road network framed by two other points on the same road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#framedPoint"></see></summary>
    let framedPoint =
        Namespaced_IRI.parse _namespace_name "framedPoint" |> NamespacedName

    /// <summary>
    /// Dedicated car pool lane(s) are in operation for vehicles carrying at least the specified number of occupants.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#carPoolLaneInOperation"></see></summary>
    let carPoolLaneInOperation =
        Namespaced_IRI.parse _namespace_name "carPoolLaneInOperation" |> NamespacedName

    /// <summary>
    /// Carriageway closures are in operation at the specified location.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#carriagewayClosures"></see></summary>
    let carriagewayClosures =
        Namespaced_IRI.parse _namespace_name "carriagewayClosures" |> NamespacedName

    /// <summary>
    /// Clear a lane for emergency vehicles.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#clearALaneForEmergencyVehicles"></see></summary>
    let clearALaneForEmergencyVehicles =
        Namespaced_IRI.parse _namespace_name "clearALaneForEmergencyVehicles" |> NamespacedName

    /// <summary>
    /// Clear a lane for snow ploughs and gritting vehicles.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#clearALaneForSnowploughsAndGrittingVehicles"></see></summary>
    let clearALaneForSnowploughsAndGrittingVehicles =
        Namespaced_IRI.parse _namespace_name "clearALaneForSnowploughsAndGrittingVehicles" |> NamespacedName

    /// <summary>
    /// The road is closed to vehicles with the specified characteristics or all, if none defined, for the duration of the winter.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#closedPermanentlyForTheWinter"></see></summary>
    let closedPermanentlyForTheWinter =
        Namespaced_IRI.parse _namespace_name "closedPermanentlyForTheWinter" |> NamespacedName

    /// <summary>
    /// Two-way traffic is temporarily sharing a single carriageway.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#contraflow"></see></summary>
    let contraflow = Namespaced_IRI.parse _namespace_name "contraflow" |> NamespacedName

    /// <summary>
    /// Do not use the specified lane(s) or carriageway(s).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#doNotUseSpecifiedLanesOrCarriageways"></see></summary>
    let doNotUseSpecifiedLanesOrCarriageways =
        Namespaced_IRI.parse _namespace_name "doNotUseSpecifiedLanesOrCarriageways" |> NamespacedName

    /// <summary>
    /// The hard shoulder is open as an operational lane.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hardShoulderRunningInOperation"></see></summary>
    let hardShoulderRunningInOperation =
        Namespaced_IRI.parse _namespace_name "hardShoulderRunningInOperation" |> NamespacedName

    /// <summary>
    /// A height restriction is in operation.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#heightRestrictionInOperation"></see></summary>
    let heightRestrictionInOperation =
        Namespaced_IRI.parse _namespace_name "heightRestrictionInOperation" |> NamespacedName

    /// <summary>
    /// Road closures occur intermittently on the specified road in the specified direction for short durations.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#intermittentShortTermClosures"></see></summary>
    let intermittentShortTermClosures =
        Namespaced_IRI.parse _namespace_name "intermittentShortTermClosures" |> NamespacedName

    /// <summary>
    /// Keep to the left.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#keepToTheLeft"></see></summary>
    let keepToTheLeft =
        Namespaced_IRI.parse _namespace_name "keepToTheLeft" |> NamespacedName

    /// <summary>
    /// Keep to the right.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#keepToTheRight"></see></summary>
    let keepToTheRight =
        Namespaced_IRI.parse _namespace_name "keepToTheRight" |> NamespacedName

    /// <summary>
    /// Lane closures are in operation at the specified location for vehicles with the specified characteristics or all, if none defined, in the specified direction.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#laneClosures"></see></summary>
    let laneClosures =
        Namespaced_IRI.parse _namespace_name "laneClosures" |> NamespacedName

    /// <summary>
    /// Lane closures are in operation at the specified location for vehicles with the specified characteristics or all, if none defined, in the specified direction.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#lanesDeviated"></see></summary>
    let lanesDeviated =
        Namespaced_IRI.parse _namespace_name "lanesDeviated" |> NamespacedName

    /// <summary>
    /// Normal lane widths are temporarily reduced.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#narrowLanes"></see></summary>
    let narrowLanes =
        Namespaced_IRI.parse _namespace_name "narrowLanes" |> NamespacedName

    /// <summary>
    /// A new layout of lanes/carriageway has been implemented associated with roadworks.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#newRoadworksLayout"></see></summary>
    let newRoadworksLayout =
        Namespaced_IRI.parse _namespace_name "newRoadworksLayout" |> NamespacedName

    /// <summary>
    /// Every night the road is closed to vehicles with the specified characteristics or all, if none defined, in the specified direction by decision of the appropriate authorities.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#overnightClosures"></see></summary>
    let overnightClosures =
        Namespaced_IRI.parse _namespace_name "overnightClosures" |> NamespacedName

    /// <summary>
    /// The road has been cleared of earlier reported problems.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadCleared"></see></summary>
    let roadCleared =
        Namespaced_IRI.parse _namespace_name "roadCleared" |> NamespacedName

    /// <summary>
    /// The road is closed to vehicles with the specified characteristics or all, if none defined, in the specified direction.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadClosed"></see></summary>
    let roadClosed = Namespaced_IRI.parse _namespace_name "roadClosed" |> NamespacedName

    /// <summary>
    /// Traffic officers or police are driving slowly in front of a queue of traffic to create a gap in the traffic to allow for clearance activities to take place in safety on the road ahead.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#rollingRoadBlock"></see></summary>
    let rollingRoadBlock =
        Namespaced_IRI.parse _namespace_name "rollingRoadBlock" |> NamespacedName

    /// <summary>
    /// Dedicated rush (peak) hour lane(s) are in operation.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#rushHourLaneInOperation"></see></summary>
    let rushHourLaneInOperation =
        Namespaced_IRI.parse _namespace_name "rushHourLaneInOperation" |> NamespacedName

    /// <summary>
    /// Traffic is being controlled to move in alternate single lines. This control may be undertaken by traffic lights or flagman.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#singleAlternateLineTraffic"></see></summary>
    let singleAlternateLineTraffic =
        Namespaced_IRI.parse _namespace_name "singleAlternateLineTraffic" |> NamespacedName

    /// <summary>
    /// Dedicated tidal flow lane(s) are in operation in the specified direction.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tidalFlowLaneInOperation"></see></summary>
    let tidalFlowLaneInOperation =
        Namespaced_IRI.parse _namespace_name "tidalFlowLaneInOperation" |> NamespacedName

    /// <summary>
    /// Traffic is being directed back down the opposite carriageway, possibly requiring the temporary removal of the central crash barrier.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#turnAroundInOperation"></see></summary>
    let turnAroundInOperation =
        Namespaced_IRI.parse _namespace_name "turnAroundInOperation" |> NamespacedName

    /// <summary>
    /// The specified lane(s) or carriageway(s) may be used. The normal lane(s) or carriageway(s) restrictions are not currently in force.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#useOfSpecifiedLanesOrCarriagewaysAllowed"></see></summary>
    let useOfSpecifiedLanesOrCarriagewaysAllowed =
        Namespaced_IRI.parse _namespace_name "useOfSpecifiedLanesOrCarriagewaysAllowed" |> NamespacedName

    /// <summary>
    /// Use the specified lane(s) or carriageway(s).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#useSpecifiedLanesOrCarriageways"></see></summary>
    let useSpecifiedLanesOrCarriageways =
        Namespaced_IRI.parse _namespace_name "useSpecifiedLanesOrCarriageways" |> NamespacedName

    /// <summary>
    /// Vehicles are being stored on the roadway and/or at a rest area or service area at the specified location.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#vehicleStorageInOperation"></see></summary>
    let vehicleStorageInOperation =
        Namespaced_IRI.parse _namespace_name "vehicleStorageInOperation" |> NamespacedName

    /// <summary>
    /// A weight restriction is in operation.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#weightRestrictionInOperation"></see></summary>
    let weightRestrictionInOperation =
        Namespaced_IRI.parse _namespace_name "weightRestrictionInOperation" |> NamespacedName

    /// <summary>
    /// Traffic conditions are changing from free-flow to heavy or slow service levels.  Queues may also be expected.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#trafficBuildingUp"></see></summary>
    let trafficBuildingUp =
        Namespaced_IRI.parse _namespace_name "trafficBuildingUp" |> NamespacedName

    /// <summary>
    /// Traffic conditions are changing from heavy or slow service levels to free-flow.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#trafficEasing"></see></summary>
    let trafficEasing =
        Namespaced_IRI.parse _namespace_name "trafficEasing" |> NamespacedName

    /// <summary>
    /// Traffic conditions are currently stable.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#trafficStable"></see></summary>
    let trafficStable =
        Namespaced_IRI.parse _namespace_name "trafficStable" |> NamespacedName

    /// <summary>
    /// The roadworks are expected to last for a long term ( duration &gt; 6 months)
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#longTerm"></see></summary>
    let longTerm = Namespaced_IRI.parse _namespace_name "longTerm" |> NamespacedName
    /// <summary>
    /// The roadworks are expected to last for a medium term (1 month &lt; duration &lt; = 6 months).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#mediumTerm"></see></summary>
    let mediumTerm = Namespaced_IRI.parse _namespace_name "mediumTerm" |> NamespacedName
    /// <summary>
    /// The roadworks are expected to last for a short term ( duration &lt; = 1 month)
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#shortTerm"></see></summary>
    let shortTerm = Namespaced_IRI.parse _namespace_name "shortTerm" |> NamespacedName
    /// <summary>
    /// The source is completely certain of the occurrence of the situation record version content.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#certain"></see></summary>
    let certain = Namespaced_IRI.parse _namespace_name "certain" |> NamespacedName
    /// <summary>
    /// The source has a reasonably low level of confidence of the occurrence of the situation record version content.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#improbable"></see></summary>
    let improbable = Namespaced_IRI.parse _namespace_name "improbable" |> NamespacedName
    /// <summary>
    /// The source has a reasonably high level of confidence of the occurrence of the situation record version content.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#probable"></see></summary>
    let probable = Namespaced_IRI.parse _namespace_name "probable" |> NamespacedName
    /// <summary>
    /// The source has a moderate level of confidence of the occurrence of the situation record version content.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#riskOf"></see></summary>
    let riskOf = Namespaced_IRI.parse _namespace_name "riskOf" |> NamespacedName

    /// <summary>
    /// Increased skid risk due to leaves on road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#leavesOnRoad"></see></summary>
    let leavesOnRoad =
        Namespaced_IRI.parse _namespace_name "leavesOnRoad" |> NamespacedName

    /// <summary>
    /// Increased skid risk and injury risk due to loose chippings on road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#looseChippings"></see></summary>
    let looseChippings =
        Namespaced_IRI.parse _namespace_name "looseChippings" |> NamespacedName

    /// <summary>
    /// Increased skid risk due to loose sand on road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#looseSandOnRoad"></see></summary>
    let looseSandOnRoad =
        Namespaced_IRI.parse _namespace_name "looseSandOnRoad" |> NamespacedName

    /// <summary>
    /// Increased skid risk due to mud on road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#mudOnRoad"></see></summary>
    let mudOnRoad = Namespaced_IRI.parse _namespace_name "mudOnRoad" |> NamespacedName
    /// <summary>
    /// Increased skid risk due to oil on road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#oilOnRoad"></see></summary>
    let oilOnRoad = Namespaced_IRI.parse _namespace_name "oilOnRoad" |> NamespacedName

    /// <summary>
    /// Increased skid risk due to petrol on road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#petrolOnRoad"></see></summary>
    let petrolOnRoad =
        Namespaced_IRI.parse _namespace_name "petrolOnRoad" |> NamespacedName

    /// <summary>
    /// The road surface is damaged, severely rutted or potholed (i.e. it is in a poor state of repair).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadSurfaceInPoorCondition"></see></summary>
    let roadSurfaceInPoorCondition =
        Namespaced_IRI.parse _namespace_name "roadSurfaceInPoorCondition" |> NamespacedName

    /// <summary>
    /// The road surface is slippery due to an unspecified non-weather related cause.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#slipperyRoad"></see></summary>
    let slipperyRoad =
        Namespaced_IRI.parse _namespace_name "slipperyRoad" |> NamespacedName

    /// <summary>
    /// Traffic may be disrupted due to animals on the roadway.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#animalsOnTheRoad"></see></summary>
    let animalsOnTheRoad =
        Namespaced_IRI.parse _namespace_name "animalsOnTheRoad" |> NamespacedName

    /// <summary>
    /// Traffic may be disrupted due to a herd of animals on the roadway.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#herdOfAnimalsOnTheRoad"></see></summary>
    let herdOfAnimalsOnTheRoad =
        Namespaced_IRI.parse _namespace_name "herdOfAnimalsOnTheRoad" |> NamespacedName

    /// <summary>
    /// Traffic may be disrupted due to large animals on the roadway.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#largeAnimalsOnTheRoad"></see></summary>
    let largeAnimalsOnTheRoad =
        Namespaced_IRI.parse _namespace_name "largeAnimalsOnTheRoad" |> NamespacedName

    /// <summary>
    /// Name of a police force control area.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#policeForceControlAreaName"></see></summary>
    let policeForceControlAreaName =
        Namespaced_IRI.parse _namespace_name "policeForceControlAreaName" |> NamespacedName

    /// <summary>
    /// Traffic flow is of an irregular nature, subject to sudden changes in rates.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#erraticFlow"></see></summary>
    let erraticFlow =
        Namespaced_IRI.parse _namespace_name "erraticFlow" |> NamespacedName

    /// <summary>
    /// Traffic flow is smooth.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#smoothFlow"></see></summary>
    let smoothFlow = Namespaced_IRI.parse _namespace_name "smoothFlow" |> NamespacedName
    /// <summary>
    /// Traffic flow is of a stop and go nature with queues forming and ending continuously on the specified section of road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#stopAndGo"></see></summary>
    let stopAndGo = Namespaced_IRI.parse _namespace_name "stopAndGo" |> NamespacedName

    /// <summary>
    /// Traffic is blocked at the specified location and in the specified direction due to an unplanned event.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#trafficBlocked"></see></summary>
    let trafficBlocked =
        Namespaced_IRI.parse _namespace_name "trafficBlocked" |> NamespacedName

    /// <summary>
    /// Includes any general delivery channel such as broadcast channels (e.g. radio, tv, RDS-TMC, TPEG services, etc.) or web publishing available to public or to specific users, depending on Service Provider policies.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#anyGeneralDeliveryService"></see></summary>
    let anyGeneralDeliveryService =
        Namespaced_IRI.parse _namespace_name "anyGeneralDeliveryService" |> NamespacedName

    /// <summary>
    /// Specific services which deliver warning alerts to end users to enhance safety via any specific application available to drivers, including C-ITS services.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#safetyServices"></see></summary>
    let safetyServices =
        Namespaced_IRI.parse _namespace_name "safetyServices" |> NamespacedName

    /// <summary>
    /// Variable Message Signs or any other visual roadside devices which information are accessible to drivers which aim to affect driving style improving safety and road network LoS.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#vms"></see></summary>
    let vms = Namespaced_IRI.parse _namespace_name "vms" |> NamespacedName

    /// <summary>
    /// The name of the road on which the junction point is located.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tpegIlcName1"></see></summary>
    let tpegIlcName1 =
        Namespaced_IRI.parse _namespace_name "tpegIlcName1" |> NamespacedName

    /// <summary>
    /// The name of the first intersecting road at the junction.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tpegIlcName2"></see></summary>
    let tpegIlcName2 =
        Namespaced_IRI.parse _namespace_name "tpegIlcName2" |> NamespacedName

    /// <summary>
    /// The name of the second intersecting road (if one exists) at the junction.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tpegIlcName3"></see></summary>
    let tpegIlcName3 =
        Namespaced_IRI.parse _namespace_name "tpegIlcName3" |> NamespacedName

    /// <summary>
    /// Delay between one hour and three hours.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#betweenOneHourAndThreeHours"></see></summary>
    let betweenOneHourAndThreeHours =
        Namespaced_IRI.parse _namespace_name "betweenOneHourAndThreeHours" |> NamespacedName

    /// <summary>
    /// Delay between ten minutes and thirty minutes.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#betweenTenMinutesAndThirtyMinutes"></see></summary>
    let betweenTenMinutesAndThirtyMinutes =
        Namespaced_IRI.parse _namespace_name "betweenTenMinutesAndThirtyMinutes" |> NamespacedName

    /// <summary>
    /// Delay between thirty minutes and one hour.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#betweenThirtyMinutesAndOneHour"></see></summary>
    let betweenThirtyMinutesAndOneHour =
        Namespaced_IRI.parse _namespace_name "betweenThirtyMinutesAndOneHour" |> NamespacedName

    /// <summary>
    /// Delay between three hours and six hours.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#betweenThreeHoursAndSixHours"></see></summary>
    let betweenThreeHoursAndSixHours =
        Namespaced_IRI.parse _namespace_name "betweenThreeHoursAndSixHours" |> NamespacedName

    /// <summary>
    /// Delay longer than six hours.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#longerThanSixHours"></see></summary>
    let longerThanSixHours =
        Namespaced_IRI.parse _namespace_name "longerThanSixHours" |> NamespacedName

    /// <summary>
    /// Negligible delay.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#negligible"></see></summary>
    let negligible = Namespaced_IRI.parse _namespace_name "negligible" |> NamespacedName

    /// <summary>
    /// Delay up to ten minutes.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#upToTenMinutes"></see></summary>
    let upToTenMinutes =
        Namespaced_IRI.parse _namespace_name "upToTenMinutes" |> NamespacedName

    /// <summary>
    /// A geographic or geometric large area.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#largeArea"></see></summary>
    let largeArea = Namespaced_IRI.parse _namespace_name "largeArea" |> NamespacedName
    /// <summary>
    /// Above or over the normal road grade elevation.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#aboveGrade"></see></summary>
    let aboveGrade = Namespaced_IRI.parse _namespace_name "aboveGrade" |> NamespacedName
    /// <summary>
    /// At the normal road grade elevation.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#atGrade"></see></summary>
    let atGrade = Namespaced_IRI.parse _namespace_name "atGrade" |> NamespacedName
    /// <summary>
    /// Below or under the normal road grade elevation.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#belowGrade"></see></summary>
    let belowGrade = Namespaced_IRI.parse _namespace_name "belowGrade" |> NamespacedName
    /// <summary>
    /// On the carriageway or lane which is inbound towards the centre of the town or city.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#inbound"></see></summary>
    let inbound = Namespaced_IRI.parse _namespace_name "inbound" |> NamespacedName
    /// <summary>
    /// On the carriageway or lane which is outbound from the centre of the town or city.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#outbound"></see></summary>
    let outbound = Namespaced_IRI.parse _namespace_name "outbound" |> NamespacedName

    /// <summary>
    /// Do not follow diversion signs.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#doNotFollowDiversionSigns"></see></summary>
    let doNotFollowDiversionSigns =
        Namespaced_IRI.parse _namespace_name "doNotFollowDiversionSigns" |> NamespacedName

    /// <summary>
    /// Rerouted traffic is not to use the specified entry onto the identified road to commence the alternative route.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#doNotUseEntry"></see></summary>
    let doNotUseEntry =
        Namespaced_IRI.parse _namespace_name "doNotUseEntry" |> NamespacedName

    /// <summary>
    /// Rerouted traffic is not to use the specified exit from the identified road to commence the alternative route.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#doNotUseExit"></see></summary>
    let doNotUseExit =
        Namespaced_IRI.parse _namespace_name "doNotUseExit" |> NamespacedName

    /// <summary>
    /// Rerouted traffic is not to use the specified intersection or junction.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#doNotUseIntersectionOrJunction"></see></summary>
    let doNotUseIntersectionOrJunction =
        Namespaced_IRI.parse _namespace_name "doNotUseIntersectionOrJunction" |> NamespacedName

    /// <summary>
    /// Rerouted traffic is to follow the diversion signs.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#followDiversionSigns"></see></summary>
    let followDiversionSigns =
        Namespaced_IRI.parse _namespace_name "followDiversionSigns" |> NamespacedName

    /// <summary>
    /// Rerouted traffic is to follow local diversion.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#followLocalDiversion"></see></summary>
    let followLocalDiversion =
        Namespaced_IRI.parse _namespace_name "followLocalDiversion" |> NamespacedName

    /// <summary>
    /// Rerouted traffic is to follow the special diversion markers.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#followSpecialMarkers"></see></summary>
    let followSpecialMarkers =
        Namespaced_IRI.parse _namespace_name "followSpecialMarkers" |> NamespacedName

    /// <summary>
    /// Rerouted traffic is to use the specified entry onto the identified road to commence the alternative route.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#useEntry"></see></summary>
    let useEntry = Namespaced_IRI.parse _namespace_name "useEntry" |> NamespacedName
    /// <summary>
    /// Rerouted traffic is to use the specified exit from the identified road to commence the alternative route.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#useExit"></see></summary>
    let useExit = Namespaced_IRI.parse _namespace_name "useExit" |> NamespacedName

    /// <summary>
    /// Rerouted traffic is to use the specified intersection or junction to commence the alternative route.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#useIntersectionOrJunction"></see></summary>
    let useIntersectionOrJunction =
        Namespaced_IRI.parse _namespace_name "useIntersectionOrJunction" |> NamespacedName

    /// <summary>
    /// Traffic flow normal
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#trafficFlowNormal"></see></summary>
    let trafficFlowNormal =
        Namespaced_IRI.parse _namespace_name "trafficFlowNormal" |> NamespacedName

    /// <summary>
    /// Traffic heavier than normal
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#trafficHeavierThanNormal"></see></summary>
    let trafficHeavierThanNormal =
        Namespaced_IRI.parse _namespace_name "trafficHeavierThanNormal" |> NamespacedName

    /// <summary>
    /// Traffic lighter than normal
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#trafficLighterThanNormal"></see></summary>
    let trafficLighterThanNormal =
        Namespaced_IRI.parse _namespace_name "trafficLighterThanNormal" |> NamespacedName

    /// <summary>
    /// Traffic very much heavier than normal
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#trafficVeryMuchHeavierThanNormal"></see></summary>
    let trafficVeryMuchHeavierThanNormal =
        Namespaced_IRI.parse _namespace_name "trafficVeryMuchHeavierThanNormal" |> NamespacedName

    /// <summary>
    /// Traffic very much lighter than normal
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#trafficVeryMuchLighterThanNormal"></see></summary>
    let trafficVeryMuchLighterThanNormal =
        Namespaced_IRI.parse _namespace_name "trafficVeryMuchLighterThanNormal" |> NamespacedName

    /// <summary>
    /// In all lanes of the carriageway.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#allLanesCompleteCarriageway"></see></summary>
    let allLanesCompleteCarriageway =
        Namespaced_IRI.parse _namespace_name "allLanesCompleteCarriageway" |> NamespacedName

    /// <summary>
    /// In the bus lane.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#busLane"></see></summary>
    let busLane = Namespaced_IRI.parse _namespace_name "busLane" |> NamespacedName
    /// <summary>
    /// In the bus stop lane.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#busStop"></see></summary>
    let busStop = Namespaced_IRI.parse _namespace_name "busStop" |> NamespacedName

    /// <summary>
    /// In the carpool lane.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#carPoolLane"></see></summary>
    let carPoolLane =
        Namespaced_IRI.parse _namespace_name "carPoolLane" |> NamespacedName

    /// <summary>
    /// On the central reservation separating the two directional carriageways of the highway.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#centralReservation"></see></summary>
    let centralReservation =
        Namespaced_IRI.parse _namespace_name "centralReservation" |> NamespacedName

    /// <summary>
    /// In the crawler lane - a lane that should be used by slower vehicles.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#crawlerLane"></see></summary>
    let crawlerLane =
        Namespaced_IRI.parse _namespace_name "crawlerLane" |> NamespacedName

    /// <summary>
    /// Part of a carriageway designated for cycles. A cycle lane is distinguished from the rest of the carriageway by longitudinal road markings.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#cycleLane"></see></summary>
    let cycleLane = Namespaced_IRI.parse _namespace_name "cycleLane" |> NamespacedName

    /// <summary>
    /// In the emergency lane.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#emergencyLane"></see></summary>
    let emergencyLane =
        Namespaced_IRI.parse _namespace_name "emergencyLane" |> NamespacedName

    /// <summary>
    /// In the escape lane.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#escapeLane"></see></summary>
    let escapeLane = Namespaced_IRI.parse _namespace_name "escapeLane" |> NamespacedName

    /// <summary>
    /// In the express lane.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#expressLane"></see></summary>
    let expressLane =
        Namespaced_IRI.parse _namespace_name "expressLane" |> NamespacedName

    /// <summary>
    /// On the hard shoulder.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hardShoulder"></see></summary>
    let hardShoulder =
        Namespaced_IRI.parse _namespace_name "hardShoulder" |> NamespacedName

    /// <summary>
    /// In the heavy vehicle lane.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#heavyVehicleLane"></see></summary>
    let heavyVehicleLane =
        Namespaced_IRI.parse _namespace_name "heavyVehicleLane" |> NamespacedName

    /// <summary>
    /// In a lay-by.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#layBy"></see></summary>
    let layBy = Namespaced_IRI.parse _namespace_name "layBy" |> NamespacedName

    /// <summary>
    /// In the left hand turning lane.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#leftHandTurningLane"></see></summary>
    let leftHandTurningLane =
        Namespaced_IRI.parse _namespace_name "leftHandTurningLane" |> NamespacedName

    /// <summary>
    /// In the left lane.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#leftLane"></see></summary>
    let leftLane = Namespaced_IRI.parse _namespace_name "leftLane" |> NamespacedName

    /// <summary>
    /// In the local traffic lane.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#localTrafficLane"></see></summary>
    let localTrafficLane =
        Namespaced_IRI.parse _namespace_name "localTrafficLane" |> NamespacedName

    /// <summary>
    /// In the middle lane.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#middleLane"></see></summary>
    let middleLane = Namespaced_IRI.parse _namespace_name "middleLane" |> NamespacedName

    /// <summary>
    /// In the overtaking lane.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#overtakingLane"></see></summary>
    let overtakingLane =
        Namespaced_IRI.parse _namespace_name "overtakingLane" |> NamespacedName

    /// <summary>
    /// In the right hand turning lane.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#rightHandTurningLane"></see></summary>
    let rightHandTurningLane =
        Namespaced_IRI.parse _namespace_name "rightHandTurningLane" |> NamespacedName

    /// <summary>
    /// In the right lane.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#rightLane"></see></summary>
    let rightLane = Namespaced_IRI.parse _namespace_name "rightLane" |> NamespacedName

    /// <summary>
    /// In the lane dedicated for use during the rush (peak) hour.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#rushHourLane"></see></summary>
    let rushHourLane =
        Namespaced_IRI.parse _namespace_name "rushHourLane" |> NamespacedName

    /// <summary>
    /// In the area/lane reserved for passenger pick-up or set-down.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#setDownArea"></see></summary>
    let setDownArea =
        Namespaced_IRI.parse _namespace_name "setDownArea" |> NamespacedName

    /// <summary>
    /// In a lane dedicated to vehicles that are not permitted to exceed a fixed slow speed.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#slowVehicleLane"></see></summary>
    let slowVehicleLane =
        Namespaced_IRI.parse _namespace_name "slowVehicleLane" |> NamespacedName

    /// <summary>
    /// In the through traffic lane.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#throughTrafficLane"></see></summary>
    let throughTrafficLane =
        Namespaced_IRI.parse _namespace_name "throughTrafficLane" |> NamespacedName

    /// <summary>
    /// In the lane dedicated for use as a tidal flow lane.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tidalFlowLane"></see></summary>
    let tidalFlowLane =
        Namespaced_IRI.parse _namespace_name "tidalFlowLane" |> NamespacedName

    /// <summary>
    /// In the turning lane.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#turningLane"></see></summary>
    let turningLane =
        Namespaced_IRI.parse _namespace_name "turningLane" |> NamespacedName

    /// <summary>
    /// On the verge.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#verge"></see></summary>
    let verge = Namespaced_IRI.parse _namespace_name "verge" |> NamespacedName

    /// <summary>
    /// Accident involving radioactive material.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#accidentInvolvingRadioactiveMaterial"></see></summary>
    let accidentInvolvingRadioactiveMaterial =
        Namespaced_IRI.parse _namespace_name "accidentInvolvingRadioactiveMaterial" |> NamespacedName

    /// <summary>
    /// Application region
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#applicationRegion"></see></summary>
    let applicationRegion =
        Namespaced_IRI.parse _namespace_name "applicationRegion" |> NamespacedName

    /// <summary>
    /// Car park area
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#carParkArea"></see></summary>
    let carParkArea =
        Namespaced_IRI.parse _namespace_name "carParkArea" |> NamespacedName

    /// <summary>
    /// Carpool area
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#carpoolArea"></see></summary>
    let carpoolArea =
        Namespaced_IRI.parse _namespace_name "carpoolArea" |> NamespacedName

    /// <summary>
    /// Continent
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#continent"></see></summary>
    let continent = Namespaced_IRI.parse _namespace_name "continent" |> NamespacedName

    /// <summary>
    /// Group of countries.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#countryGroup"></see></summary>
    let countryGroup =
        Namespaced_IRI.parse _namespace_name "countryGroup" |> NamespacedName

    /// <summary>
    /// Fuzzy area
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#fuzzyArea"></see></summary>
    let fuzzyArea = Namespaced_IRI.parse _namespace_name "fuzzyArea" |> NamespacedName

    /// <summary>
    /// Industrial area
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#industrialArea"></see></summary>
    let industrialArea =
        Namespaced_IRI.parse _namespace_name "industrialArea" |> NamespacedName

    /// <summary>
    /// Lake
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#lake"></see></summary>
    let lake = Namespaced_IRI.parse _namespace_name "lake" |> NamespacedName

    /// <summary>
    /// Meteorological area
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#meteorologicalArea"></see></summary>
    let meteorologicalArea =
        Namespaced_IRI.parse _namespace_name "meteorologicalArea" |> NamespacedName

    /// <summary>
    /// Order 1 administrative area
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#order1AdministrativeArea"></see></summary>
    let order1AdministrativeArea =
        Namespaced_IRI.parse _namespace_name "order1AdministrativeArea" |> NamespacedName

    /// <summary>
    /// Order 2 administrative area
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#order2AdministrativeArea"></see></summary>
    let order2AdministrativeArea =
        Namespaced_IRI.parse _namespace_name "order2AdministrativeArea" |> NamespacedName

    /// <summary>
    /// Order 3 administrative area
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#order3AdministrativeArea"></see></summary>
    let order3AdministrativeArea =
        Namespaced_IRI.parse _namespace_name "order3AdministrativeArea" |> NamespacedName

    /// <summary>
    /// Order 4 administrative area
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#order4AdministrativeArea"></see></summary>
    let order4AdministrativeArea =
        Namespaced_IRI.parse _namespace_name "order4AdministrativeArea" |> NamespacedName

    /// <summary>
    /// Order 5 administrative area
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#order5AdministrativeArea"></see></summary>
    let order5AdministrativeArea =
        Namespaced_IRI.parse _namespace_name "order5AdministrativeArea" |> NamespacedName

    /// <summary>
    /// A park and ride site
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#parkAndRideSite"></see></summary>
    let parkAndRideSite =
        Namespaced_IRI.parse _namespace_name "parkAndRideSite" |> NamespacedName

    /// <summary>
    /// Police force control area
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#policeForceControlArea"></see></summary>
    let policeForceControlArea =
        Namespaced_IRI.parse _namespace_name "policeForceControlArea" |> NamespacedName

    /// <summary>
    /// Road operator control area
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadOperatorControlArea"></see></summary>
    let roadOperatorControlArea =
        Namespaced_IRI.parse _namespace_name "roadOperatorControlArea" |> NamespacedName

    /// <summary>
    /// Rural county
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ruralCounty"></see></summary>
    let ruralCounty =
        Namespaced_IRI.parse _namespace_name "ruralCounty" |> NamespacedName

    /// <summary>
    /// Sea
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#sea"></see></summary>
    let sea = Namespaced_IRI.parse _namespace_name "sea" |> NamespacedName

    /// <summary>
    /// Tourist area
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#touristArea"></see></summary>
    let touristArea =
        Namespaced_IRI.parse _namespace_name "touristArea" |> NamespacedName

    /// <summary>
    /// Traffic area
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#trafficArea"></see></summary>
    let trafficArea =
        Namespaced_IRI.parse _namespace_name "trafficArea" |> NamespacedName

    /// <summary>
    /// Urban county
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#urbanCounty"></see></summary>
    let urbanCounty =
        Namespaced_IRI.parse _namespace_name "urbanCounty" |> NamespacedName

    /// <summary>
    /// Water area
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#waterArea"></see></summary>
    let waterArea = Namespaced_IRI.parse _namespace_name "waterArea" |> NamespacedName
    /// <summary>
    /// Adverse weather conditions are affecting driving conditions.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#badWeather"></see></summary>
    let badWeather = Namespaced_IRI.parse _namespace_name "badWeather" |> NamespacedName

    /// <summary>
    /// Dust blowing across the roadway causing significantly reduced visibility.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#blowingDust"></see></summary>
    let blowingDust =
        Namespaced_IRI.parse _namespace_name "blowingDust" |> NamespacedName

    /// <summary>
    /// Fallen snow moving due to the forces of wind.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#blowingSnow"></see></summary>
    let blowingSnow =
        Namespaced_IRI.parse _namespace_name "blowingSnow" |> NamespacedName

    /// <summary>
    /// Strong cross winds across the direction of the roadway (e.g. on a ridge or bridge).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#crosswinds"></see></summary>
    let crosswinds = Namespaced_IRI.parse _namespace_name "crosswinds" |> NamespacedName

    /// <summary>
    /// Abnormally low temperatures.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#extremeCold"></see></summary>
    let extremeCold =
        Namespaced_IRI.parse _namespace_name "extremeCold" |> NamespacedName

    /// <summary>
    /// Abnormally high expected maximum temperature.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#extremeHeat"></see></summary>
    let extremeHeat =
        Namespaced_IRI.parse _namespace_name "extremeHeat" |> NamespacedName

    /// <summary>
    /// Fog, visibility more than 50m.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#fog"></see></summary>
    let fog = Namespaced_IRI.parse _namespace_name "fog" |> NamespacedName
    /// <summary>
    /// Frost can be expected.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#frost"></see></summary>
    let frost = Namespaced_IRI.parse _namespace_name "frost" |> NamespacedName
    /// <summary>
    /// Small balls of ice and compacted snow.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hail"></see></summary>
    let hail = Namespaced_IRI.parse _namespace_name "hail" |> NamespacedName
    /// <summary>
    /// Rain, visibility more than 50m.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#rain"></see></summary>
    let rain = Namespaced_IRI.parse _namespace_name "rain" |> NamespacedName
    /// <summary>
    /// Sand blowing across the roadway causing significantly reduced visibility.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#sandStorms"></see></summary>
    let sandStorms = Namespaced_IRI.parse _namespace_name "sandStorms" |> NamespacedName

    /// <summary>
    /// Smoke drifting across the roadway causing significantly reduced visibility.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#smokeHazard"></see></summary>
    let smokeHazard =
        Namespaced_IRI.parse _namespace_name "smokeHazard" |> NamespacedName

    /// <summary>
    /// Falling snow, visibility more than 50m.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#snowFall"></see></summary>
    let snowFall = Namespaced_IRI.parse _namespace_name "snowFall" |> NamespacedName

    /// <summary>
    /// Winds between 90 km/h and 120 km/h.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#stormForceWinds"></see></summary>
    let stormForceWinds =
        Namespaced_IRI.parse _namespace_name "stormForceWinds" |> NamespacedName

    /// <summary>
    /// Constantly varying winds, strong at times.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#strongGustsOfWinds"></see></summary>
    let strongGustsOfWinds =
        Namespaced_IRI.parse _namespace_name "strongGustsOfWinds" |> NamespacedName

    /// <summary>
    /// Winds between 40 km/h and 60 km/h.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#strongWinds"></see></summary>
    let strongWinds =
        Namespaced_IRI.parse _namespace_name "strongWinds" |> NamespacedName

    /// <summary>
    /// Large numbers of insects which create a hazard for road users through reduced visibility.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#swarmOfInsects"></see></summary>
    let swarmOfInsects =
        Namespaced_IRI.parse _namespace_name "swarmOfInsects" |> NamespacedName

    /// <summary>
    /// Environmental conditions causing reduced visibility.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#visibilityReduced"></see></summary>
    let visibilityReduced =
        Namespaced_IRI.parse _namespace_name "visibilityReduced" |> NamespacedName

    /// <summary>
    /// A traffic condition which is not normal.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AbnormalTraffic"></see></summary>
    let AbnormalTraffic =
        Namespaced_IRI.parse _namespace_name "AbnormalTraffic" |> NamespacedName

    /// <summary>
    /// The number of vehicles waiting in a queue.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#numberOfVehiclesWaiting"></see></summary>
    let numberOfVehiclesWaiting =
        Namespaced_IRI.parse _namespace_name "numberOfVehiclesWaiting" |> NamespacedName

    /// <summary>
    /// A measure of distance defined in metres in a non negative integer format.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#MetresAsNonNegativeIntegerValue"></see></summary>
    let MetresAsNonNegativeIntegerValue =
        Namespaced_IRI.parse _namespace_name "MetresAsNonNegativeIntegerValue" |> NamespacedName

    /// <summary>
    /// The length of a queue or the average length of queues in separate lanes due to a situation.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#queueLength"></see></summary>
    let queueLength =
        Namespaced_IRI.parse _namespace_name "queueLength" |> NamespacedName

    /// <summary>
    /// A characterization of the trend in the traffic conditions at the specified location and direction.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TrafficTrendTypeEnum"></see></summary>
    let TrafficTrendTypeEnum =
        Namespaced_IRI.parse _namespace_name "TrafficTrendTypeEnum" |> NamespacedName

    /// <summary>
    /// A characterization of the trend in the traffic conditions at the specified location and direction.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasTrafficTrendTypeEnum"></see></summary>
    let hasTrafficTrendTypeEnum =
        Namespaced_IRI.parse _namespace_name "hasTrafficTrendTypeEnum" |> NamespacedName

    /// <summary>
    /// The consistency (steadiness) of the traffic flow.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TrafficFlowCharateristicsEnum"></see></summary>
    let TrafficFlowCharateristicsEnum =
        Namespaced_IRI.parse _namespace_name "TrafficFlowCharateristicsEnum" |> NamespacedName

    /// <summary>
    /// The consistency (steadiness) of the traffic flow.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasTrafficFlowCharacteristicsEnum"></see></summary>
    let hasTrafficFlowCharacteristicsEnum =
        Namespaced_IRI.parse _namespace_name "hasTrafficFlowCharacteristicsEnum" |> NamespacedName

    /// <summary>
    /// Assessment of the traffic flow conditions relative to normally expected conditions at this date/time.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#RelativeTrafficFlowEnum"></see></summary>
    let RelativeTrafficFlowEnum =
        Namespaced_IRI.parse _namespace_name "RelativeTrafficFlowEnum" |> NamespacedName

    /// <summary>
    /// Assessment of the traffic flow conditions relative to normally expected conditions at this date/time.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasRelativeTrafficFlowEnum"></see></summary>
    let hasRelativeTrafficFlowEnum =
        Namespaced_IRI.parse _namespace_name "hasRelativeTrafficFlowEnum" |> NamespacedName

    /// <summary>
    /// Descriptive terms for abnormal traffic conditions specifically relating to the nature of the traffic movement, implying levels of service.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AbnormalTrafficTypeEnum"></see></summary>
    let AbnormalTrafficTypeEnum =
        Namespaced_IRI.parse _namespace_name "AbnormalTrafficTypeEnum" |> NamespacedName

    /// <summary>
    /// A characterization of the nature of abnormal traffic flow, i.e. specifically relating to the nature of the traffic movement, implying a level of service.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAbnormalTrafficType"></see></summary>
    let hasAbnormalTrafficType =
        Namespaced_IRI.parse _namespace_name "hasAbnormalTrafficType" |> NamespacedName

    /// <summary>
    /// An event which is not planned by the traffic operator, which is affecting, or has the potential to affect traffic flow.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TrafficElement"></see></summary>
    let TrafficElement =
        Namespaced_IRI.parse _namespace_name "TrafficElement" |> NamespacedName

    /// <summary>
    /// Collects the added non-SRTI enumerations. Only for organizational purposes
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Non-SRTI_Enum"></see></summary>
    let ``Non-SRTI_Enum`` =
        Namespaced_IRI.parse _namespace_name "Non-SRTI_Enum" |> NamespacedName

    /// <summary>
    /// Accidents are events where one or more vehicles are involved in collisions or in leaving the roadway. These include collisions between vehicles or with other road users or obstacles.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Accident"></see></summary>
    let Accident = Namespaced_IRI.parse _namespace_name "Accident" |> NamespacedName

    /// <summary>
    /// Collection of descriptive terms for types of accidents.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AccidentTypeEnum"></see></summary>
    let AccidentTypeEnum =
        Namespaced_IRI.parse _namespace_name "AccidentTypeEnum" |> NamespacedName

    /// <summary>
    /// A characterization of the nature of the accident.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAccidentType"></see></summary>
    let hasAccidentType =
        Namespaced_IRI.parse _namespace_name "hasAccidentType" |> NamespacedName

    /// <summary>
    /// Any stationary or moving obstacle of a physical nature (e.g. obstacles or vehicles from an earlier accident, shed loads on carriageway, rock fall, abnormal or dangerous loads, or animals etc.) which could disrupt or endanger traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Obstruction"></see></summary>
    let Obstruction =
        Namespaced_IRI.parse _namespace_name "Obstruction" |> NamespacedName

    /// <summary>
    /// Any conditions which have the potential to degrade normal driving conditions.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Conditions"></see></summary>
    let Conditions = Namespaced_IRI.parse _namespace_name "Conditions" |> NamespacedName

    /// <summary>
    /// Collection of descriptive terms for causes of accidents.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AccidentCauseEnum"></see></summary>
    let AccidentCauseEnum =
        Namespaced_IRI.parse _namespace_name "AccidentCauseEnum" |> NamespacedName

    /// <summary>
    /// Only for organizational purposes
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#SituationEnumerations"></see></summary>
    let SituationEnumerations =
        Namespaced_IRI.parse _namespace_name "SituationEnumerations" |> NamespacedName

    /// <summary>
    /// A collection of information relating to human activities external to the traffic stream or roadway which could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Activity"></see></summary>
    let Activity = Namespaced_IRI.parse _namespace_name "Activity" |> NamespacedName
    /// <summary>
    /// An indication of whether the associated instance of a SituationRecord is mobile (e.g. a march or parade moving along a road) or stationary.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Mobility"></see></summary>
    let Mobility = Namespaced_IRI.parse _namespace_name "Mobility" |> NamespacedName

    /// <summary>
    /// Specifies the mobility of activity
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasMobilityOfActivity"></see></summary>
    let hasMobilityOfActivity =
        Namespaced_IRI.parse _namespace_name "hasMobilityOfActivity" |> NamespacedName

    /// <summary>
    /// Alert C location
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertC"></see></summary>
    let AlertC = Namespaced_IRI.parse _namespace_name "AlertC" |> NamespacedName

    /// <summary>
    /// Only for organizational purposes
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#LocationObjects"></see></summary>
    let LocationObjects =
        Namespaced_IRI.parse _namespace_name "LocationObjects" |> NamespacedName

    /// <summary>
    /// An area defined by reference to a predefined ALERT-C location table.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertCArea"></see></summary>
    let AlertCArea = Namespaced_IRI.parse _namespace_name "AlertCArea" |> NamespacedName

    /// <summary>
    /// Version number associated with an ALERT-C table reference.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#alertCLocationTableVersion"></see></summary>
    let alertCLocationTableVersion =
        Namespaced_IRI.parse _namespace_name "alertCLocationTableVersion" |> NamespacedName

    /// <summary>
    /// Number allocated to an ALERT-C table in a country. Ref. EN ISO 14819-3 for the allocation of a location table number.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#alertCLocationTableNumber"></see></summary>
    let alertCLocationTableNumber =
        Namespaced_IRI.parse _namespace_name "alertCLocationTableNumber" |> NamespacedName

    /// <summary>
    /// ALERT-C country code as defined in IEC 62106.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#alertCLocationCountryCode"></see></summary>
    let alertCLocationCountryCode =
        Namespaced_IRI.parse _namespace_name "alertCLocationCountryCode" |> NamespacedName

    /// <summary>
    /// Identification of a specific point, linear or area location in an ALERT-C location table.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertCLocation"></see></summary>
    let AlertCLocation =
        Namespaced_IRI.parse _namespace_name "AlertCLocation" |> NamespacedName

    /// <summary>
    /// Identification of a specific point, linear or area location in an ALERT-C location table.
    /// ALERT-C location
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAlertCLocation"></see></summary>
    let hasAlertCLocation =
        Namespaced_IRI.parse _namespace_name "hasAlertCLocation" |> NamespacedName

    /// <summary>
    /// The direction of traffic flow along the road to which the information relates.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertCDirection"></see></summary>
    let AlertCDirection =
        Namespaced_IRI.parse _namespace_name "AlertCDirection" |> NamespacedName

    /// <summary>
    /// Direction used to reach the primary location from the secondary location in ALERT-C location table, as defined in CEN ISO 14819-1
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertCDirectionEnum"></see></summary>
    let AlertCDirectionEnum =
        Namespaced_IRI.parse _namespace_name "AlertCDirectionEnum" |> NamespacedName

    /// <summary>
    /// Direction of navigation with respect to secondary to primary location (RDS direction)
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAlertCDirectionCoded"></see></summary>
    let hasAlertCDirectionCoded =
        Namespaced_IRI.parse _namespace_name "hasAlertCDirectionCoded" |> NamespacedName

    /// <summary>
    /// Directions of traffic flow relative to the direction in which the linear element is defined.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#LinearDirectionEnum"></see></summary>
    let LinearDirectionEnum =
        Namespaced_IRI.parse _namespace_name "LinearDirectionEnum" |> NamespacedName

    /// <summary>
    /// The direction(s) of traffic flow to which the situation, traffic data or information is related.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAlertCAffectedDirection"></see></summary>
    let hasAlertCAffectedDirection =
        Namespaced_IRI.parse _namespace_name "hasAlertCAffectedDirection" |> NamespacedName

    /// <summary>
    /// Only for organizational purposes
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#LocationReferencingEnumerations"></see></summary>
    let LocationReferencingEnumerations =
        Namespaced_IRI.parse _namespace_name "LocationReferencingEnumerations" |> NamespacedName

    /// <summary>
    /// A linear section along a road defined between two points on the road by reference to a pre-defined ALERT-C location table. When there are multiple instances of AlertCLinear they should represent the same location using different location tables.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertCLinear"></see></summary>
    let AlertCLinear =
        Namespaced_IRI.parse _namespace_name "AlertCLinear" |> NamespacedName

    /// <summary>
    /// A linear section along a road defined by reference to a linear section in a pre-defined ALERT-C location table.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertCLinearByCode"></see></summary>
    let AlertCLinearByCode =
        Namespaced_IRI.parse _namespace_name "AlertCLinearByCode" |> NamespacedName

    /// <summary>
    /// Specific location. Unique code within the ALERT-C location table which identifies the specific point, linear or area location.Unique code within the ALERT-C location table which identifies the specific point, linear or area location.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasLocationCodeForLinearLocation"></see></summary>
    let hasLocationCodeForLinearLocation =
        Namespaced_IRI.parse _namespace_name "hasLocationCodeForLinearLocation" |> NamespacedName

    /// <summary>
    /// The direction of traffic flow along the road to which the information relates.
    /// ALERT-C direction
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAlertCDirection"></see></summary>
    let hasAlertCDirection =
        Namespaced_IRI.parse _namespace_name "hasAlertCDirection" |> NamespacedName

    /// <summary>
    /// A linear section along a road between two points, primary and secondary, which are pre-defined in an ALERT-C location table. Direction is FROM the secondary point TO the primary point, i.e. the primary point is downstream of the secondary point.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertCMethod2Linear"></see></summary>
    let AlertCMethod2Linear =
        Namespaced_IRI.parse _namespace_name "AlertCMethod2Linear" |> NamespacedName

    /// <summary>
    /// The point (called Secondary point) which is at the upstream end of a linear road section. The point is specified by a reference to a point in a pre-defined ALERT-C location table.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertCMethod2SecondaryPointLocation"></see></summary>
    let AlertCMethod2SecondaryPointLocation =
        Namespaced_IRI.parse _namespace_name "AlertCMethod2SecondaryPointLocation" |> NamespacedName

    /// <summary>
    /// The point (called Secondary point) which is at the upstream end of a linear road section. The point is specified by a reference to a point in a pre-defined ALERT-C location table.
    /// ALERT-C method2 secondary point location
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAlertCMethod2SecondaryPointLocation"></see></summary>
    let hasAlertCMethod2SecondaryPointLocation =
        Namespaced_IRI.parse _namespace_name "hasAlertCMethod2SecondaryPointLocation" |> NamespacedName

    /// <summary>
    /// The point (called Primary point) which is either a single point or at the downstream end of a linear road section. The point is specified by a reference to a point in a pre-defined ALERT-C location table.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertCMethod2PrimaryPointLocation"></see></summary>
    let AlertCMethod2PrimaryPointLocation =
        Namespaced_IRI.parse _namespace_name "AlertCMethod2PrimaryPointLocation" |> NamespacedName

    /// <summary>
    /// The point (called Primary point) which is either a single point or at the downstream end of a linear road section. The point is specified by a reference to a point in a pre-defined ALERT-C location table.
    /// ALERT-C method2 primary point location
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAlertCMethod2PrimaryPointLocation"></see></summary>
    let hasAlertCMethod2PrimaryPointLocation =
        Namespaced_IRI.parse _namespace_name "hasAlertCMethod2PrimaryPointLocation" |> NamespacedName

    /// <summary>
    /// A single point on the road network defined by reference to a point in a pre-defined ALERT-C location table and which has an associated direction of traffic flow.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertCMethod2Point"></see></summary>
    let AlertCMethod2Point =
        Namespaced_IRI.parse _namespace_name "AlertCMethod2Point" |> NamespacedName

    /// <summary>
    /// A single point on the road network defined by reference to a pre-defined ALERT-C location table and which has an associated direction of traffic flow.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertCPoint"></see></summary>
    let AlertCPoint =
        Namespaced_IRI.parse _namespace_name "AlertCPoint" |> NamespacedName

    /// <summary>
    /// A linear section along a road between two points, primary and secondary, which are pre-defined ALERT-C locations plus offset distance. Direction is FROM the secondary point TO the primary point, i.e. the primary point is downstream of the secondary point.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertCMethod4Linear"></see></summary>
    let AlertCMethod4Linear =
        Namespaced_IRI.parse _namespace_name "AlertCMethod4Linear" |> NamespacedName

    /// <summary>
    /// The point (called Secondary point) which is at the upstream end of a linear road section. The point is specified by a reference to a point in a pre-defined Alert-C location table plus a non-negative offset distance.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertCMethod4SecondaryPointLocation"></see></summary>
    let AlertCMethod4SecondaryPointLocation =
        Namespaced_IRI.parse _namespace_name "AlertCMethod4SecondaryPointLocation" |> NamespacedName

    /// <summary>
    /// The point (called Secondary point) which is at the upstream end of a linear road section. The point is specified by a reference to a point in a pre-defined Alert-C location table plus a non-negative offset distance.
    /// ALERT-C method4 secondary point location
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAlertCMethod4SecondaryPointLocation"></see></summary>
    let hasAlertCMethod4SecondaryPointLocation =
        Namespaced_IRI.parse _namespace_name "hasAlertCMethod4SecondaryPointLocation" |> NamespacedName

    /// <summary>
    /// The point (called Primary point) which is either a single point or at the downstream end of a linear road section. The point is specified by a reference to a point in a pre-defined ALERT-C location table plus a non-negative offset distance.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertCMethod4PrimaryPointLocation"></see></summary>
    let AlertCMethod4PrimaryPointLocation =
        Namespaced_IRI.parse _namespace_name "AlertCMethod4PrimaryPointLocation" |> NamespacedName

    /// <summary>
    /// The point (called Primary point) which is either a single point or at the downstream end of a linear road section. The point is specified by a reference to a point in a pre-defined ALERT-C location table plus a non-negative offset distance.
    /// ALERT-C method4 primary point location
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAlertCMethod4PrimaryPointLocation"></see></summary>
    let hasAlertCMethod4PrimaryPointLocation =
        Namespaced_IRI.parse _namespace_name "hasAlertCMethod4PrimaryPointLocation" |> NamespacedName

    /// <summary>
    /// A single point on the road network defined by reference to a point in a pre-defined ALERT-C location table plus an offset distance and which has an associated direction of traffic flow.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertCMethod4Point"></see></summary>
    let AlertCMethod4Point =
        Namespaced_IRI.parse _namespace_name "AlertCMethod4Point" |> NamespacedName

    /// <summary>
    /// The non-negative offset distance from the ALERT-C referenced point to the actual point.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OffsetDistance"></see></summary>
    let OffsetDistance =
        Namespaced_IRI.parse _namespace_name "OffsetDistance" |> NamespacedName

    /// <summary>
    /// The non-negative offset distance from the ALERT-C referenced point to the actual point.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOffsetDistance"></see></summary>
    let hasOffsetDistance =
        Namespaced_IRI.parse _namespace_name "hasOffsetDistance" |> NamespacedName

    /// <summary>
    /// A point on the road network which is either a junction point or a non junction point.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegPoint"></see></summary>
    let TpegPoint = Namespaced_IRI.parse _namespace_name "TpegPoint" |> NamespacedName

    /// <summary>
    /// Coded level of vertical accuracy
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AltitudeAccuracyEnum"></see></summary>
    let AltitudeAccuracyEnum =
        Namespaced_IRI.parse _namespace_name "AltitudeAccuracyEnum" |> NamespacedName

    /// <summary>
    /// Evaluation of the altitude confidence assessed according to ETSI ISO 102894-2
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AltitudeConfidence"></see></summary>
    let AltitudeConfidence =
        Namespaced_IRI.parse _namespace_name "AltitudeConfidence" |> NamespacedName

    /// <summary>
    /// Error code for horizontal or vertical position confidence
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PositionConfidenceCodedErrorEnum"></see></summary>
    let PositionConfidenceCodedErrorEnum =
        Namespaced_IRI.parse _namespace_name "PositionConfidenceCodedErrorEnum" |> NamespacedName

    /// <summary>
    /// Error code in case the altitude confidence is out of range or cannot be determined
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasPositionConfidenceCodedErrorEnum"></see></summary>
    let hasPositionConfidenceCodedErrorEnum =
        Namespaced_IRI.parse _namespace_name "hasPositionConfidenceCodedErrorEnum" |> NamespacedName

    /// <summary>
    /// Absolute accuracy of reported value of a geographical point for a confidence level expressed by a coded scale.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAltitudeAccuracyCodedValue"></see></summary>
    let hasAltitudeAccuracyCodedValue =
        Namespaced_IRI.parse _namespace_name "hasAltitudeAccuracyCodedValue" |> NamespacedName

    /// <summary>
    /// Third coordinate for points defined geodetically
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#HeightCoordinateAssociationFrom"></see></summary>
    let HeightCoordinateAssociationFrom =
        Namespaced_IRI.parse _namespace_name "HeightCoordinateAssociationFrom" |> NamespacedName

    /// <summary>
    /// A measured or  value of Angles. An integer number representing an angle in whole degrees between 0 and 359.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AngleInDegreesValue"></see></summary>
    let AngleInDegreesValue =
        Namespaced_IRI.parse _namespace_name "AngleInDegreesValue" |> NamespacedName

    /// <summary>
    /// An obstruction on the road resulting from the presence of animals.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AnimalPresenceObstruction"></see></summary>
    let AnimalPresenceObstruction =
        Namespaced_IRI.parse _namespace_name "AnimalPresenceObstruction" |> NamespacedName

    /// <summary>
    /// Types of animal presence.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AnimalPresenceTypeEmum"></see></summary>
    let AnimalPresenceTypeEmum =
        Namespaced_IRI.parse _namespace_name "AnimalPresenceTypeEmum" |> NamespacedName

    /// <summary>
    /// Indicates the nature of animals present on or near the roadway.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAnimalPresenceTypeEnum"></see></summary>
    let hasAnimalPresenceTypeEnum =
        Namespaced_IRI.parse _namespace_name "hasAnimalPresenceTypeEnum" |> NamespacedName

    /// <summary>
    /// An obstruction on the road caused by one or more vehicles.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#VehicleObstruction"></see></summary>
    let VehicleObstruction =
        Namespaced_IRI.parse _namespace_name "VehicleObstruction" |> NamespacedName

    /// <summary>
    /// Any stationary or moving obstacle of a physical nature, other than of an animal, vehicle, environmental, or damaged equipment nature.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#GeneralObstruction"></see></summary>
    let GeneralObstruction =
        Namespaced_IRI.parse _namespace_name "GeneralObstruction" |> NamespacedName

    /// <summary>
    /// An obstruction on the road resulting from an environmental cause.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#EnvironmentalObstruction"></see></summary>
    let EnvironmentalObstruction =
        Namespaced_IRI.parse _namespace_name "EnvironmentalObstruction" |> NamespacedName

    /// <summary>
    /// Location representing a geographic or geometric defined area which may be qualified by height information to provide additional geospatial discrimination (e.g. for snow in an area but only above a certain altitude). Associations:
    /// 0..*	AlertCArea
    /// 0..1	TpegAreaLocation
    /// 0..1	NamedArea
    /// 0..1	GmlMultiPolygon
    /// 0..1	OpenlrAreaLocationReference
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AreaLocation"></see></summary>
    let AreaLocation =
        Namespaced_IRI.parse _namespace_name "AreaLocation" |> NamespacedName

    /// <summary>
    /// A geographic or geometric area defined by a TPEG-Loc structure which may include height information for additional geospatial discrimination
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegAreaLocation"></see></summary>
    let TpegAreaLocation =
        Namespaced_IRI.parse _namespace_name "TpegAreaLocation" |> NamespacedName

    /// <summary>
    /// A geographic or geometric area defined by a TPEG-Loc structure which may include height information for additional geospatial discrimination.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasTpegAreaLocation"></see></summary>
    let hasTpegAreaLocation =
        Namespaced_IRI.parse _namespace_name "hasTpegAreaLocation" |> NamespacedName

    /// <summary>
    /// A two-dimensional part of the surface of the earth which is bounded by a closed curve. An area location may cover parts of the road network but does not necessarily need to. It is represented according to the OpenLR standard for Area Locations
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrAreaLocationReference"></see></summary>
    let OpenlrAreaLocationReference =
        Namespaced_IRI.parse _namespace_name "OpenlrAreaLocationReference" |> NamespacedName

    /// <summary>
    /// A two-dimensional part of the surface of the earth which is bounded by a closed curve. An area location may cover parts of the road network but does not necessarily need to. It is represented according to the OpenLR standard for Area Locations
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrAreaLocationReference"></see></summary>
    let hasOpenlrAreaLocationReference =
        Namespaced_IRI.parse _namespace_name "hasOpenlrAreaLocationReference" |> NamespacedName

    /// <summary>
    /// An area defined by a name and/or in terms of known boundaries, such as country or county boundaries or allocated control area of particular authority. The attributes do not form a union; instead, the smallest intersection forms the resulting area.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#NamedArea"></see></summary>
    let NamedArea = Namespaced_IRI.parse _namespace_name "NamedArea" |> NamespacedName

    /// <summary>
    /// An area defined by a name and/or in terms of known boundaries, such as country or county boundaries or allocated control area of particular authority. The attributes do not form a union; instead, the smallest intersection forms the resulting area.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasNamedArea"></see></summary>
    let hasNamedArea =
        Namespaced_IRI.parse _namespace_name "hasNamedArea" |> NamespacedName

    /// <summary>
    /// An area defined by a set of polygons acording to GML (EN ISO 19136).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#GmlMultiPolygon"></see></summary>
    let GmlMultiPolygon =
        Namespaced_IRI.parse _namespace_name "GmlMultiPolygon" |> NamespacedName

    /// <summary>
    /// An area defined by a set of polygons acording to GML (EN ISO 19136).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasGmlMultiPolygon"></see></summary>
    let hasGmlMultiPolygon =
        Namespaced_IRI.parse _namespace_name "hasGmlMultiPolygon" |> NamespacedName

    /// <summary>
    /// Type of area place(s)
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AreaPlacesEnum"></see></summary>
    let AreaPlacesEnum =
        Namespaced_IRI.parse _namespace_name "AreaPlacesEnum" |> NamespacedName

    /// <summary>
    /// Places, in generic terms, at which the corresponding information applies.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAreaPlacesEnum"></see></summary>
    let hasAreaPlacesEnum =
        Namespaced_IRI.parse _namespace_name "hasAreaPlacesEnum" |> NamespacedName

    /// <summary>
    /// The specification of a location either on a network (as a point or a linear location) or as an area. This may be provided in one or more referencing systems. Association: 0..1PointCoordinates. In SRTI is not included LocationByReference.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Location"></see></summary>
    let Location = Namespaced_IRI.parse _namespace_name "Location" |> NamespacedName

    /// <summary>
    /// Supplementary positional information which details carriageway and lane locations. Several instances may exist where the element being described extends over more than one carriageway.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Carriageway"></see></summary>
    let Carriageway =
        Namespaced_IRI.parse _namespace_name "Carriageway" |> NamespacedName

    /// <summary>
    /// Normal number of lanes, potentially available for moving traffic, before reduction due to situations. Hard shoulder should not be counted unless it is sometimes used operationally for moving traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#originalNumberOfLanes"></see></summary>
    let originalNumberOfLanes =
        Namespaced_IRI.parse _namespace_name "originalNumberOfLanes" |> NamespacedName

    /// <summary>
    /// List of descriptors identifying specific carriageway details.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#CarriagewayEnum"></see></summary>
    let CarriagewayEnum =
        Namespaced_IRI.parse _namespace_name "CarriagewayEnum" |> NamespacedName

    /// <summary>
    /// Indicates the section of carriageway to which the location relates.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasCarriagewayEnum"></see></summary>
    let hasCarriagewayEnum =
        Namespaced_IRI.parse _namespace_name "hasCarriagewayEnum" |> NamespacedName

    /// <summary>
    /// Supplementary positional information
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#SupplementaryPositionalPack"></see></summary>
    let SupplementaryPositionalPack =
        Namespaced_IRI.parse _namespace_name "SupplementaryPositionalPack" |> NamespacedName

    /// <summary>
    /// Types of causes of situations which are not managed or are off network.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#CauseTypeEnum"></see></summary>
    let CauseTypeEnum =
        Namespaced_IRI.parse _namespace_name "CauseTypeEnum" |> NamespacedName

    /// <summary>
    /// Common classes
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#CommonClasses"></see></summary>
    let CommonClasses =
        Namespaced_IRI.parse _namespace_name "CommonClasses" |> NamespacedName

    /// <summary>
    /// Types of computational methods used in deriving data values for data sets.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ComputationMethodEnum"></see></summary>
    let ComputationMethodEnum =
        Namespaced_IRI.parse _namespace_name "ComputationMethodEnum" |> NamespacedName

    /// <summary>
    /// Only for organizational purposes
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PayLoadEnumerations"></see></summary>
    let PayLoadEnumerations =
        Namespaced_IRI.parse _namespace_name "PayLoadEnumerations" |> NamespacedName

    /// <summary>
    /// Types of the perceived driving conditions.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#DrivingConditionTypeEnum"></see></summary>
    let DrivingConditionTypeEnum =
        Namespaced_IRI.parse _namespace_name "DrivingConditionTypeEnum" |> NamespacedName

    /// <summary>
    /// Types of the perceived driving conditions.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasDrivingConditionTypeEnum"></see></summary>
    let hasDrivingConditionTypeEnum =
        Namespaced_IRI.parse _namespace_name "hasDrivingConditionTypeEnum" |> NamespacedName

    /// <summary>
    /// &lt;&lt;enumeration&gt;&gt; Values of confidentiality.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ConfidentialityValueEnum"></see></summary>
    let ConfidentialityValueEnum =
        Namespaced_IRI.parse _namespace_name "ConfidentialityValueEnum" |> NamespacedName

    /// <summary>
    /// Types of works relating to construction.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ConstructionWorkTypeEnum"></see></summary>
    let ConstructionWorkTypeEnum =
        Namespaced_IRI.parse _namespace_name "ConstructionWorkTypeEnum" |> NamespacedName

    /// <summary>
    /// Roadworks involving the construction of new infrastructure.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ConstructionWorks"></see></summary>
    let ConstructionWorks =
        Namespaced_IRI.parse _namespace_name "ConstructionWorks" |> NamespacedName

    /// <summary>
    /// The type of construction work being performed.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasConstructionWorkType"></see></summary>
    let hasConstructionWorkType =
        Namespaced_IRI.parse _namespace_name "hasConstructionWorkType" |> NamespacedName

    /// <summary>
    /// Highway maintenance, installation and construction activities that may potentially affect traffic operations.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#RoadWorks"></see></summary>
    let RoadWorks = Namespaced_IRI.parse _namespace_name "RoadWorks" |> NamespacedName
    /// <summary>
    /// A data value of something that can be measured or calculated. Any provided meta-data values specified in the attributes override any specified generic characteristics such as defined for a specific measurement in the MeasurementSiteTable.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#DataValue"></see></summary>
    let DataValue = Namespaced_IRI.parse _namespace_name "DataValue" |> NamespacedName

    /// <summary>
    /// The number of input values used in the sampling or measurement period to determine the data value.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#numberOfInputValuesUsed"></see></summary>
    let numberOfInputValuesUsed =
        Namespaced_IRI.parse _namespace_name "numberOfInputValuesUsed" |> NamespacedName

    /// <summary>
    /// The reason why the value is deemed to be erroneous by the supplier.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#reasonForDataError"></see></summary>
    let reasonForDataError =
        Namespaced_IRI.parse _namespace_name "reasonForDataError" |> NamespacedName

    /// <summary>
    /// The number of inputs detected but not completed during the sampling or measurement period; e.g. vehicles detected entering but not exiting the detection zone.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#numberOfIncompleteInputs"></see></summary>
    let numberOfIncompleteInputs =
        Namespaced_IRI.parse _namespace_name "numberOfIncompleteInputs" |> NamespacedName

    /// <summary>
    /// The standard deviation of the sample of input values from which this value was derived, measured in the units of the data value.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#standardDeviation"></see></summary>
    let standardDeviation =
        Namespaced_IRI.parse _namespace_name "standardDeviation" |> NamespacedName

    /// <summary>
    /// Indication of whether the value is deemed to be erroneous by the supplier (true = erroneous). If not present, the data value is assumed to be ok. This may be used when automatic fault detection information relating to sensors is available.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#dataError"></see></summary>
    let dataError = Namespaced_IRI.parse _namespace_name "dataError" |> NamespacedName

    /// <summary>
    /// A measure of data quality assigned to the value by the supplier. 100% equates to ideal/perfect quality. The method of calculation is supplier specific and needs to be agreed between supplier and client.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#supplierCalculatedDataQuality"></see></summary>
    let supplierCalculatedDataQuality =
        Namespaced_IRI.parse _namespace_name "supplierCalculatedDataQuality" |> NamespacedName

    /// <summary>
    /// Method of computation which has been used to compute this data value.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasComputationMethodEnum"></see></summary>
    let hasComputationMethodEnum =
        Namespaced_IRI.parse _namespace_name "hasComputationMethodEnum" |> NamespacedName

    /// <summary>
    /// The extent to which the value is expected to be free from error, measured as a percentage of the data value. 100% means fully accurate.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#accuracy"></see></summary>
    let accuracy = Namespaced_IRI.parse _namespace_name "accuracy" |> NamespacedName

    /// <summary>
    /// Coefficient required when a moving average is computed to give specific weights to the former average and the new data. A typical formula is, F being the smoothing factor: New average = (old average) F + (new data) (1 - F).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#smoothingFactor"></see></summary>
    let smoothingFactor =
        Namespaced_IRI.parse _namespace_name "smoothingFactor" |> NamespacedName

    /// <summary>
    /// The time band within which the additional travel time due to adverse travel conditions of any kind falls, when compared to "normal conditions".
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#DelayBandEnum"></see></summary>
    let DelayBandEnum =
        Namespaced_IRI.parse _namespace_name "DelayBandEnum" |> NamespacedName

    /// <summary>
    /// The details of the delays being caused by the situation element defined in the situation record. It is recommended to only use one of the optional attributes to avoid confusion.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Delays"></see></summary>
    let Delays = Namespaced_IRI.parse _namespace_name "Delays" |> NamespacedName

    /// <summary>
    /// The value of the additional travel time due to adverse travel conditions of any kind, when compared to "normal conditions", given in seconds.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#delayTimeValue"></see></summary>
    let delayTimeValue =
        Namespaced_IRI.parse _namespace_name "delayTimeValue" |> NamespacedName

    /// <summary>
    /// Coarse classification of the delay.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#DelaysTypeEnum"></see></summary>
    let DelaysTypeEnum =
        Namespaced_IRI.parse _namespace_name "DelaysTypeEnum" |> NamespacedName

    /// <summary>
    /// Coarse classification of the delay.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#delaysType"></see></summary>
    let delaysType = Namespaced_IRI.parse _namespace_name "delaysType" |> NamespacedName
    /// <summary>
    /// The time band within which the additional travel time due to adverse travel conditions of any kind falls, when compared to "normal conditions".
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#delayBand"></see></summary>
    let delayBand = Namespaced_IRI.parse _namespace_name "delayBand" |> NamespacedName

    /// <summary>
    /// List of directions of travel.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#DirectionEnum"></see></summary>
    let DirectionEnum =
        Namespaced_IRI.parse _namespace_name "DirectionEnum" |> NamespacedName

    /// <summary>
    /// Main purpose of a direction of a road
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#DirectionPurposeEnum"></see></summary>
    let DirectionPurposeEnum =
        Namespaced_IRI.parse _namespace_name "DirectionPurposeEnum" |> NamespacedName

    /// <summary>
    /// Distance of a point along a linear element either measured from the start node or a defined referent on that linear element, where the start node is relative to the element definition rather than the direction of traffic flow.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#DistanceAlongLinearElement"></see></summary>
    let DistanceAlongLinearElement =
        Namespaced_IRI.parse _namespace_name "DistanceAlongLinearElement" |> NamespacedName

    /// <summary>
    /// Only for organizational purposes.Package LinearReferencing
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#LinearReferencing"></see></summary>
    let LinearReferencing =
        Namespaced_IRI.parse _namespace_name "LinearReferencing" |> NamespacedName

    /// <summary>
    /// Distance of a point along a linear element measured from a "from referent" on the linear element, in the sense relative to the linear element definition rather than the direction of traffic flow or optionally towards a "towards referent".
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#DistanceFromLinearElementReferent"></see></summary>
    let DistanceFromLinearElementReferent =
        Namespaced_IRI.parse _namespace_name "DistanceFromLinearElementReferent" |> NamespacedName

    /// <summary>
    /// A referent on a linear object that has a known location such as a node, a reference marker (e.g. a marker-post), an intersection etc.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Referent"></see></summary>
    let Referent = Namespaced_IRI.parse _namespace_name "Referent" |> NamespacedName

    /// <summary>
    /// A known location along the linear element towards which the distanceAlong is measured, termed the "towardsReferent" in EN ISO 19148.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasReferentTowards"></see></summary>
    let hasReferentTowards =
        Namespaced_IRI.parse _namespace_name "hasReferentTowards" |> NamespacedName

    /// <summary>
    /// A known location along the linear element from which the distanceAlong is measured, termed the "fromReferent" in EN ISO 19148.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasReferentFrom"></see></summary>
    let hasReferentFrom =
        Namespaced_IRI.parse _namespace_name "hasReferentFrom" |> NamespacedName

    /// <summary>
    /// A measure of distance defined in metres in a floating point format.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#MetresAsFloatValue"></see></summary>
    let MetresAsFloatValue =
        Namespaced_IRI.parse _namespace_name "MetresAsFloatValue" |> NamespacedName

    /// <summary>
    /// A measure of distance along a linear element.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#distanceAlong"></see></summary>
    let distanceAlong =
        Namespaced_IRI.parse _namespace_name "distanceAlong" |> NamespacedName

    /// <summary>
    /// Distance of a point along a linear element measured from the start node of the linear element, where start node is relative to the element definition rather than the direction of traffic flow.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#DistanceFromLinearElementStart"></see></summary>
    let DistanceFromLinearElementStart =
        Namespaced_IRI.parse _namespace_name "DistanceFromLinearElementStart" |> NamespacedName

    /// <summary>
    /// Deliberate human action of either a public disorder nature or of a situation alert type which could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#DisturbanceActivity"></see></summary>
    let DisturbanceActivity =
        Namespaced_IRI.parse _namespace_name "DisturbanceActivity" |> NamespacedName

    /// <summary>
    /// Types of disturbance activities.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#DisturbanceActivityTypeEnum"></see></summary>
    let DisturbanceActivityTypeEnum =
        Namespaced_IRI.parse _namespace_name "DisturbanceActivityTypeEnum" |> NamespacedName

    /// <summary>
    /// Data Dictionary.This clause contains the definitions of all enumerations which are used.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Enums"></see></summary>
    let Enums = Namespaced_IRI.parse _namespace_name "Enums" |> NamespacedName

    /// <summary>
    /// Types of environmental obstructions.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#EnvironmentalObstructionTypeEnum"></see></summary>
    let EnvironmentalObstructionTypeEnum =
        Namespaced_IRI.parse _namespace_name "EnvironmentalObstructionTypeEnum" |> NamespacedName

    /// <summary>
    /// Characterization of an obstruction on the road resulting from an environmental cause.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasEnvironmentalObstructionTypeEnum"></see></summary>
    let hasEnvironmentalObstructionTypeEnum =
        Namespaced_IRI.parse _namespace_name "hasEnvironmentalObstructionTypeEnum" |> NamespacedName

    /// <summary>
    /// General instruction and/or message that is issued by the network/road operator which is applicable to drivers and sometimes passengers.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#GeneralInstructionOrMessageToRoadUsers"></see></summary>
    let GeneralInstructionOrMessageToRoadUsers =
        Namespaced_IRI.parse _namespace_name "GeneralInstructionOrMessageToRoadUsers" |> NamespacedName

    /// <summary>
    /// General message that is issued by the network/road operator which is applicable to drivers and sometimes passengers, e.g. details about an amber alert (missing or abducted child alert).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#generalMessageToRoadUsers"></see></summary>
    let generalMessageToRoadUsers =
        Namespaced_IRI.parse _namespace_name "generalMessageToRoadUsers" |> NamespacedName

    /// <summary>
    /// General instructions that may be issued to road users (specifically drivers and sometimes passengers) by an operator or operational system in support of network management activities or emergency situations.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#GeneralInstructionOrMessageToRoadUsersTypeEnum"></see></summary>
    let GeneralInstructionOrMessageToRoadUsersTypeEnum =
        Namespaced_IRI.parse _namespace_name "GeneralInstructionOrMessageToRoadUsersTypeEnum" |> NamespacedName

    /// <summary>
    /// General instruction that is issued by the network/road operator which is applicable to drivers and sometimes passengers.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasGeneralInstructionOrMessageToRoadUsersType"></see></summary>
    let hasGeneralInstructionOrMessageToRoadUsersType =
        Namespaced_IRI.parse _namespace_name "hasGeneralInstructionOrMessageToRoadUsersType" |> NamespacedName

    /// <summary>
    /// Restrictions on road usage, whether by legal order or by operational decisions. It includes road and lane closures, weight and dimensional limits, banned turns, contraflows and alternate traffic operations.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#NetworkManagement"></see></summary>
    let NetworkManagement =
        Namespaced_IRI.parse _namespace_name "NetworkManagement" |> NamespacedName

    /// <summary>
    /// Network management action which is applicable to the road network and its users. "trafficManuallyDirectedBy" is only valid if "hasGeneralNetworkManagementTypeEnum" is set to "trafficBeingManuallyDirected".
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#GeneralNetworkManagement"></see></summary>
    let GeneralNetworkManagement =
        Namespaced_IRI.parse _namespace_name "GeneralNetworkManagement" |> NamespacedName

    /// <summary>
    /// Categories of person.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PersonCategoryEnum"></see></summary>
    let PersonCategoryEnum =
        Namespaced_IRI.parse _namespace_name "PersonCategoryEnum" |> NamespacedName

    /// <summary>
    /// Type of person that is manually directing traffic (applicable if generalNetworkManagementType is set to "trafficBeingManuallyDirected").
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#trafficManuallyDirectedBy"></see></summary>
    let trafficManuallyDirectedBy =
        Namespaced_IRI.parse _namespace_name "trafficManuallyDirectedBy" |> NamespacedName

    /// <summary>
    /// Types of network management actions.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#GeneralNetworkManagementTypeEnum"></see></summary>
    let GeneralNetworkManagementTypeEnum =
        Namespaced_IRI.parse _namespace_name "GeneralNetworkManagementTypeEnum" |> NamespacedName

    /// <summary>
    /// The type of traffic management action instigated by the network/road operator.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasGeneralNetworkManagementType"></see></summary>
    let hasGeneralNetworkManagementType =
        Namespaced_IRI.parse _namespace_name "hasGeneralNetworkManagementType" |> NamespacedName

    /// <summary>
    /// Types of obstructions on the roadway.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ObstructionTypeEnum"></see></summary>
    let ObstructionTypeEnum =
        Namespaced_IRI.parse _namespace_name "ObstructionTypeEnum" |> NamespacedName

    /// <summary>
    /// Characterization of the type of general obstruction.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasObstructionTypeEnum"></see></summary>
    let hasObstructionTypeEnum =
        Namespaced_IRI.parse _namespace_name "hasObstructionTypeEnum" |> NamespacedName

    /// <summary>
    /// The OGC GeoSPARQL standard supports representing and querying geospatial data on the Semantic Web. GeoSPARQL defines a vocabulary for representing geospatial data in RDF, and it defines an extension to the SPARQL query language for processing geospatial data.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#GeoSparqlClasses"></see></summary>
    let GeoSparqlClasses =
        Namespaced_IRI.parse _namespace_name "GeoSparqlClasses" |> NamespacedName

    /// <summary>
    /// Only for organizational purposes
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ImportedClasses"></see></summary>
    let ImportedClasses =
        Namespaced_IRI.parse _namespace_name "ImportedClasses" |> NamespacedName

    /// <summary>
    /// Geo WGS84 vocabulary
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Geo_WGS84"></see></summary>
    let Geo_WGS84 = Namespaced_IRI.parse _namespace_name "Geo_WGS84" |> NamespacedName

    /// <summary>
    /// Descriptor to help to identify a specific location.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#GeographicCharacteristicEnum"></see></summary>
    let GeographicCharacteristicEnum =
        Namespaced_IRI.parse _namespace_name "GeographicCharacteristicEnum" |> NamespacedName

    /// <summary>
    /// GML location
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Gml"></see></summary>
    let Gml = Namespaced_IRI.parse _namespace_name "Gml" |> NamespacedName

    /// <summary>
    /// Line string based on GML (EN ISO 19136) definition: a curve defined by a series of two or more coordinate tuples. Unlike GML may be self-intersecting. If srsName attribute is not present, posList is assumed to use "ETRS89-LatLonh" reference system.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#GmlLineString"></see></summary>
    let GmlLineString =
        Namespaced_IRI.parse _namespace_name "GmlLineString" |> NamespacedName

    /// <summary>
    /// Specifies the Coordinate Reference System (CRS) used to interpret the coordinates in this GmlLineString
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#srsName"></see></summary>
    let srsName = Namespaced_IRI.parse _namespace_name "srsName" |> NamespacedName

    /// <summary>
    /// Provides the size of the tuple of coordinates of each point. This number is 2 or 3. By default when omitted the dimension shall be interpreted as 2.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#srsDimension"></see></summary>
    let srsDimension =
        Namespaced_IRI.parse _namespace_name "srsDimension" |> NamespacedName

    /// <summary>
    /// List of coordinate Tuples define the geometry of this GmlLineString. There must be at least 2 Tuples of coordinates.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#gmlPosList"></see></summary>
    let gmlPosList = Namespaced_IRI.parse _namespace_name "gmlPosList" |> NamespacedName

    /// <summary>
    /// Closed line string not self-intersecting (i.e. having as last point the first point)
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#GmlLinearRing"></see></summary>
    let GmlLinearRing =
        Namespaced_IRI.parse _namespace_name "GmlLinearRing" |> NamespacedName

    /// <summary>
    /// Name of the multi-polygon area
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#gmlAreaName"></see></summary>
    let gmlAreaName =
        Namespaced_IRI.parse _namespace_name "gmlAreaName" |> NamespacedName

    /// <summary>
    /// Planar surface defined by 1 exterior boundary and 0 or more interior boundaries
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#GmlPolygon"></see></summary>
    let GmlPolygon = Namespaced_IRI.parse _namespace_name "GmlPolygon" |> NamespacedName

    /// <summary>
    /// Planar surface defined by 1 exterior boundary and 0 or more interior boundaries
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasGmlPolygon"></see></summary>
    let hasGmlPolygon =
        Namespaced_IRI.parse _namespace_name "hasGmlPolygon" |> NamespacedName

    /// <summary>
    /// A boundary of a polygonal surface consisting of a ring i.e. in the normal 2D case, a closed polygonal line distinguished as exterior. Such a polygonal line has at least 4 pairs of coordinates
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasGmlExteriorLinearRing"></see></summary>
    let hasGmlExteriorLinearRing =
        Namespaced_IRI.parse _namespace_name "hasGmlExteriorLinearRing" |> NamespacedName

    /// <summary>
    /// Management information relating to the data contained within a publication.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#HeaderInformation"></see></summary>
    let HeaderInformation =
        Namespaced_IRI.parse _namespace_name "HeaderInformation" |> NamespacedName

    /// <summary>
    /// Status of the related information (i.e. real, test or exercise).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#InformationStatusEnum"></see></summary>
    let InformationStatusEnum =
        Namespaced_IRI.parse _namespace_name "InformationStatusEnum" |> NamespacedName

    /// <summary>
    /// The status of the related information (real, test, exercise ....).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasInformationStatus"></see></summary>
    let hasInformationStatus =
        Namespaced_IRI.parse _namespace_name "hasInformationStatus" |> NamespacedName

    /// <summary>
    /// The extent to which the related information may be circulated, according to the recipient type. Recipients must comply with this confidentiality statement.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasConfidentiality"></see></summary>
    let hasConfidentiality =
        Namespaced_IRI.parse _namespace_name "hasConfidentiality" |> NamespacedName

    /// <summary>
    /// Third coordinate for points defined geodetically
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#HeightCoordinate"></see></summary>
    let HeightCoordinate =
        Namespaced_IRI.parse _namespace_name "HeightCoordinate" |> NamespacedName

    /// <summary>
    /// Value in metres for the height measured vertically at to the planar coordinates the point corresponding.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#heightValue"></see></summary>
    let heightValue =
        Namespaced_IRI.parse _namespace_name "heightValue" |> NamespacedName

    /// <summary>
    /// Horizontal position accuracy parameters defined according to EN 16803-1
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PositionAccuracy"></see></summary>
    let PositionAccuracy =
        Namespaced_IRI.parse _namespace_name "PositionAccuracy" |> NamespacedName

    /// <summary>
    /// Defines the horizontal position accuracy according EN 16803-1
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasVerticalPositionAccuracy"></see></summary>
    let hasVerticalPositionAccuracy =
        Namespaced_IRI.parse _namespace_name "hasVerticalPositionAccuracy" |> NamespacedName

    /// <summary>
    /// Coded value for type of height
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#HeightTypeEnum"></see></summary>
    let HeightTypeEnum =
        Namespaced_IRI.parse _namespace_name "HeightTypeEnum" |> NamespacedName

    /// <summary>
    /// Type of measured height.When it is omitted it is supposed to be the ellipsoidal height.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasHeightTypeEnum"></see></summary>
    let hasHeightTypeEnum =
        Namespaced_IRI.parse _namespace_name "hasHeightTypeEnum" |> NamespacedName

    /// <summary>
    /// Evaluation of the altitude confidence assessed according to ETSI ISO 102894-2
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAltitudeConfidence"></see></summary>
    let hasAltitudeConfidence =
        Namespaced_IRI.parse _namespace_name "hasAltitudeConfidence" |> NamespacedName

    /// <summary>
    /// Only for organizational purposes.Package PointCoordinates.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PointCoordinatesAssociationsFrom"></see></summary>
    let PointCoordinatesAssociationsFrom =
        Namespaced_IRI.parse _namespace_name "PointCoordinatesAssociationsFrom" |> NamespacedName

    /// <summary>
    /// Only for organizational purposes.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#LocationReferencing"></see></summary>
    let LocationReferencing =
        Namespaced_IRI.parse _namespace_name "LocationReferencing" |> NamespacedName

    /// <summary>
    /// List of height or vertical gradings of road sections.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#HeightGradeEnum"></see></summary>
    let HeightGradeEnum =
        Namespaced_IRI.parse _namespace_name "HeightGradeEnum" |> NamespacedName

    /// <summary>
    /// An assessment of the impact that an event or operator action defined by the situation record has on the driving conditions.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Impact"></see></summary>
    let Impact = Namespaced_IRI.parse _namespace_name "Impact" |> NamespacedName

    /// <summary>
    /// The number of usable lanes in the specified direction which remain fully operational (this may include the hard shoulder if it is being used as an operational lane).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#numberOfOperationalLanes"></see></summary>
    let numberOfOperationalLanes =
        Namespaced_IRI.parse _namespace_name "numberOfOperationalLanes" |> NamespacedName

    /// <summary>
    /// The number of normally usable lanes on the carriageway which are now restricted either fully or partially (this may include the hard shoulder if it is normally available for operational use, e.g. in hard shoulder running schemes).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#numberOfLanesRestricted"></see></summary>
    let numberOfLanesRestricted =
        Namespaced_IRI.parse _namespace_name "numberOfLanesRestricted" |> NamespacedName

    /// <summary>
    /// The ratio of current capacity to the normal (free flow) road capacity in the defined direction, expressed as a percentage. Capacity is the maximum number of vehicles that can pass a specified point on the road, in unit time given the specified conditions.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#capacityRemaining"></see></summary>
    let capacityRemaining =
        Namespaced_IRI.parse _namespace_name "capacityRemaining" |> NamespacedName

    /// <summary>
    /// The total width of the combined operational lanes in the specified direction.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#residualRoadWidth"></see></summary>
    let residualRoadWidth =
        Namespaced_IRI.parse _namespace_name "residualRoadWidth" |> NamespacedName

    /// <summary>
    /// The width of lanes after any lane narrowing
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#residualLaneWidth"></see></summary>
    let residualLaneWidth =
        Namespaced_IRI.parse _namespace_name "residualLaneWidth" |> NamespacedName

    /// <summary>
    /// The details of the delays being caused by the situation element defined in the situation record. It is recommended to only use one of the optional attributes to avoid confusion.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasDelays"></see></summary>
    let hasDelays = Namespaced_IRI.parse _namespace_name "hasDelays" |> NamespacedName

    /// <summary>
    ///   <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#InformationDeliveryServicesEnum"></see>
    /// </summary>
    let InformationDeliveryServicesEnum =
        Namespaced_IRI.parse _namespace_name "InformationDeliveryServicesEnum" |> NamespacedName

    /// <summary>
    /// An obstruction on the road caused by one Infrastructure Damage
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#InfrastructureDamageObstruction"></see></summary>
    let InfrastructureDamageObstruction =
        Namespaced_IRI.parse _namespace_name "InfrastructureDamageObstruction" |> NamespacedName

    /// <summary>
    /// Types of infrastructure damage which may have an effect on the road network.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#InfrastructureDamageTypeEnum"></see></summary>
    let InfrastructureDamageTypeEnum =
        Namespaced_IRI.parse _namespace_name "InfrastructureDamageTypeEnum" |> NamespacedName

    /// <summary>
    /// Types of infrastructure damage which may have an effect on the road network.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasInfrastructureDamageType"></see></summary>
    let hasInfrastructureDamageType =
        Namespaced_IRI.parse _namespace_name "hasInfrastructureDamageType" |> NamespacedName

    /// <summary>
    /// Descriptor identifying infrastructure to help to identify a specific location.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#InfrastructureDescriptorEnum"></see></summary>
    let InfrastructureDescriptorEnum =
        Namespaced_IRI.parse _namespace_name "InfrastructureDescriptorEnum" |> NamespacedName

    /// <summary>
    /// An identifier/name whose range is specific to the particular country.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#InternationalIdentifier"></see></summary>
    let InternationalIdentifier =
        Namespaced_IRI.parse _namespace_name "InternationalIdentifier" |> NamespacedName

    /// <summary>
    /// Identifier or name unique within the specified country.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#nationalIdentifier"></see></summary>
    let nationalIdentifier =
        Namespaced_IRI.parse _namespace_name "nationalIdentifier" |> NamespacedName

    /// <summary>
    /// Iso named area	The ISO 3166-2 representation for the named area.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#IsoNamedArea"></see></summary>
    let IsoNamedArea =
        Namespaced_IRI.parse _namespace_name "IsoNamedArea" |> NamespacedName

    /// <summary>
    /// ISO 3166-2 subdivison types.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#SubdivisionTypeEnum"></see></summary>
    let SubdivisionTypeEnum =
        Namespaced_IRI.parse _namespace_name "SubdivisionTypeEnum" |> NamespacedName

    /// <summary>
    /// The ISO 3166-2 subdivison type for the named area.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasSubdivisionTypeEnum"></see></summary>
    let hasSubdivisionTypeEnum =
        Namespaced_IRI.parse _namespace_name "hasSubdivisionTypeEnum" |> NamespacedName

    /// <summary>
    /// The ISO 3166-2 subdivision code for the named area.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasCountrySubdivision"></see></summary>
    let hasCountrySubdivision =
        Namespaced_IRI.parse _namespace_name "hasCountrySubdivision" |> NamespacedName

    /// <summary>
    /// Multiple (i.e. more than one) physically separate locations arranged as an ordered set that defines an itinerary or route. In SRTI is not included ItineraryByReference
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Itinerary"></see></summary>
    let Itinerary = Namespaced_IRI.parse _namespace_name "Itinerary" |> NamespacedName

    /// <summary>
    /// Represents one or more physically separate locations. Multiple locations may be related, as in an itinerary or route, or may be unrelated. One LocationReference should not use multiple Location objects to represent the same physical location. In SRTI is not included LocationGroup
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#LocationReference"></see></summary>
    let LocationReference =
        Namespaced_IRI.parse _namespace_name "LocationReference" |> NamespacedName

    /// <summary>
    /// Multiple physically separate locations arranged as an ordered set that defines an itinerary or route. The index qualifier indicates the order.
    /// Association: 1..1 Location
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ItineraryByIndexedLocations"></see></summary>
    let ItineraryByIndexedLocations =
        Namespaced_IRI.parse _namespace_name "ItineraryByIndexedLocations" |> NamespacedName

    /// <summary>
    /// A location contained in an itinerary (i.e. an ordered set of locations defining a route or itinerary).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasLocationContainedInItinerary"></see></summary>
    let hasLocationContainedInItinerary =
        Namespaced_IRI.parse _namespace_name "hasLocationContainedInItinerary" |> NamespacedName

    /// <summary>
    /// Country Representation ontology provides a reference model to support the first two parts of ISO 3166, along with the other coding systems:
    ///  - ISO 3166-1 (Country codes) establishes codes that represent the current names of countries, dependencies, and other areas of particular geopolitical interest, on the basis of lists of country names obtained from the United Nations.
    ///  - ISO 3166-2 (Country subdivision code) establishes a code that represents the names of the principal administrative divisions, or similar areas, of the countries, etc. included in the ISO 3166-1.
    ///  - ISO 3166-3 (Code for formerly used names of countries) establishes a code that represents non-current country names, i.e., the country names deleted from ISO 3166 since its first publication in 1974.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#LCC_CountryRepresentation"></see></summary>
    let LCC_CountryRepresentation =
        Namespaced_IRI.parse _namespace_name "LCC_CountryRepresentation" |> NamespacedName

    /// <summary>
    /// Indicates a specific lane or group of lanes.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Lane"></see></summary>
    let Lane = Namespaced_IRI.parse _namespace_name "Lane" |> NamespacedName
    /// <summary>
    /// The number of the lane, where 1 is nearest the hard shoulder/verge and the numbers increase towards the central reservation/road axis.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#laneNumber"></see></summary>
    let laneNumber = Namespaced_IRI.parse _namespace_name "laneNumber" |> NamespacedName
    /// <summary>
    /// List of descriptors identifying specific lanes.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#LaneEnum"></see></summary>
    let LaneEnum = Namespaced_IRI.parse _namespace_name "LaneEnum" |> NamespacedName

    /// <summary>
    /// Indicates the specific lane to which the location relates.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasLaneEnum"></see></summary>
    let hasLaneEnum =
        Namespaced_IRI.parse _namespace_name "hasLaneEnum" |> NamespacedName

    /// <summary>
    /// A linear element along a single linear object, consistent with EN ISO 19148 definitions.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#LinearElement"></see></summary>
    let LinearElement =
        Namespaced_IRI.parse _namespace_name "LinearElement" |> NamespacedName

    /// <summary>
    /// Name of the road
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadName"></see></summary>
    let roadName = Namespaced_IRI.parse _namespace_name "roadName" |> NamespacedName

    /// <summary>
    /// The version of the identified road network reference model.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#linearElementReferenceModelVersion"></see></summary>
    let linearElementReferenceModelVersion =
        Namespaced_IRI.parse _namespace_name "linearElementReferenceModelVersion" |> NamespacedName

    /// <summary>
    /// The identifier of a road network reference model which segments the road network according to specific business rules.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#linearElementReferenceModel"></see></summary>
    let linearElementReferenceModel =
        Namespaced_IRI.parse _namespace_name "linearElementReferenceModel" |> NamespacedName

    /// <summary>
    /// Identifier/number of the road. The road number designated by the road authority
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasRoadNumber"></see></summary>
    let hasRoadNumber =
        Namespaced_IRI.parse _namespace_name "hasRoadNumber" |> NamespacedName

    /// <summary>
    /// List of indicative natures of linear elements.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#LinearElementNatureEnum"></see></summary>
    let LinearElementNatureEnum =
        Namespaced_IRI.parse _namespace_name "LinearElementNatureEnum" |> NamespacedName

    /// <summary>
    /// An indication of the nature of the linear element.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasLinearElementNature"></see></summary>
    let hasLinearElementNature =
        Namespaced_IRI.parse _namespace_name "hasLinearElementNature" |> NamespacedName

    /// <summary>
    /// A linear element along a single linear object defined by its identifier or code in a road network reference model (specified in LinearElement class) which segments the road network according to specific business rules.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#LinearElementByCode"></see></summary>
    let LinearElementByCode =
        Namespaced_IRI.parse _namespace_name "LinearElementByCode" |> NamespacedName

    /// <summary>
    /// An identifier or code of a linear element (or link) in the road network reference model that is specified in the LinearElement class.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#linearElementIdentifier"></see></summary>
    let linearElementIdentifier =
        Namespaced_IRI.parse _namespace_name "linearElementIdentifier" |> NamespacedName

    /// <summary>
    /// A linear element defined by a line string (class GmlLineString).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#LinearElementByLineString"></see></summary>
    let LinearElementByLineString =
        Namespaced_IRI.parse _namespace_name "LinearElementByLineString" |> NamespacedName

    /// <summary>
    /// Line string based on GML (EN ISO 19136) definition: a curve defined by a series of two or more coordinate tuples. Unlike GML may be self-intersecting. If srsName attribute is not present, posList is assumed to use "ETRS89-LatLonh" reference system.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasGmlLineString"></see></summary>
    let hasGmlLineString =
        Namespaced_IRI.parse _namespace_name "hasGmlLineString" |> NamespacedName

    /// <summary>
    /// A linear element along a single linear object defined by its start and end points.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#LinearElementByPoints"></see></summary>
    let LinearElementByPoints =
        Namespaced_IRI.parse _namespace_name "LinearElementByPoints" |> NamespacedName

    /// <summary>
    /// The referent at a known location on the linear object which defines the end of the linear element.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasReferentEndPointLinearElement"></see></summary>
    let hasReferentEndPointLinearElement =
        Namespaced_IRI.parse _namespace_name "hasReferentEndPointLinearElement" |> NamespacedName

    /// <summary>
    /// A referent at a known location on the linear object which is neither the start or end of the linear element.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasReferentIntermediatePointLinearElement"></see></summary>
    let hasReferentIntermediatePointLinearElement =
        Namespaced_IRI.parse _namespace_name "hasReferentIntermediatePointLinearElement" |> NamespacedName

    /// <summary>
    /// The referent at a known location on the linear object which defines the start of the linear element.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasReferentStartPointLinearElement"></see></summary>
    let hasReferentStartPointLinearElement =
        Namespaced_IRI.parse _namespace_name "hasReferentStartPointLinearElement" |> NamespacedName

    /// <summary>
    /// Location representing a linear section with optional directionality defined between two points. Any LinearLocation must have an instance of at least one of these classes. If using multiple instances, producers must take care to ensure they represent the same location.
    /// Associations:
    /// 0..1	OpenlrLinear
    /// 0..1	GmlLineString
    /// 0..1	SupplementaryPositionalDescription
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#LinearLocation"></see></summary>
    let LinearLocation =
        Namespaced_IRI.parse _namespace_name "LinearLocation" |> NamespacedName

    /// <summary>
    /// A collection of supplementary positional information which improves the precision of the location.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#SupplementaryPositionalDescription"></see></summary>
    let SupplementaryPositionalDescription =
        Namespaced_IRI.parse _namespace_name "SupplementaryPositionalDescription" |> NamespacedName

    /// <summary>
    /// Supplementary description that applies to the secondary end of the linear location. Use when properties change along the Linear. For a one-way linear the secondary end should be the destination end.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasSecondarySupplementaryDescription"></see></summary>
    let hasSecondarySupplementaryDescription =
        Namespaced_IRI.parse _namespace_name "hasSecondarySupplementaryDescription" |> NamespacedName

    /// <summary>
    /// OpenLR line location reference
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrLinear"></see></summary>
    let OpenlrLinear =
        Namespaced_IRI.parse _namespace_name "OpenlrLinear" |> NamespacedName

    /// <summary>
    /// OpenLR line location reference
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrLinear"></see></summary>
    let hasOpenlrLinear =
        Namespaced_IRI.parse _namespace_name "hasOpenlrLinear" |> NamespacedName

    /// <summary>
    /// The specification of a location on a network (as a point or a linear location).Association: 0..1 SupplementaryPositionalDescription
    ///
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#NetworkLocation"></see></summary>
    let NetworkLocation =
        Namespaced_IRI.parse _namespace_name "NetworkLocation" |> NamespacedName

    /// <summary>
    /// A linear section along a linear element where the linear element is either a part of or the whole of a linear object (i.e. a road), consistent with ISO 19148 definitions.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#LinearWithinLinearElement"></see></summary>
    let LinearWithinLinearElement =
        Namespaced_IRI.parse _namespace_name "LinearWithinLinearElement" |> NamespacedName

    /// <summary>
    /// The direction of traffic flow on the linear section in terms of general destination direction.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#directionOnLinearSection"></see></summary>
    let directionOnLinearSection =
        Namespaced_IRI.parse _namespace_name "directionOnLinearSection" |> NamespacedName

    /// <summary>
    /// Specifies a linear element along a single linear object, consistent with EN ISO 19148 definitions.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasLinearElement"></see></summary>
    let hasLinearElement =
        Namespaced_IRI.parse _namespace_name "hasLinearElement" |> NamespacedName

    /// <summary>
    /// A point on the linear element that defines the end node of the linear section.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasDistanceAlongLinearElementTo"></see></summary>
    let hasDistanceAlongLinearElementTo =
        Namespaced_IRI.parse _namespace_name "hasDistanceAlongLinearElementTo" |> NamespacedName

    /// <summary>
    /// A point on the linear element that defines the start node of the linear section.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasDistanceAlongLinearElementFrom"></see></summary>
    let hasDistanceAlongLinearElementFrom =
        Namespaced_IRI.parse _namespace_name "hasDistanceAlongLinearElementFrom" |> NamespacedName

    /// <summary>
    /// Identification of whether the linear section that is part of the linear element is at, above or below the normal elevation of a linear element of that type (e.g. road or road section) at that location, typically used to indicate "grade" separation.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasHeightGradeOfLinearSection"></see></summary>
    let hasHeightGradeOfLinearSection =
        Namespaced_IRI.parse _namespace_name "hasHeightGradeOfLinearSection" |> NamespacedName

    /// <summary>
    /// Identification of the road administration area which contains the specified linear section.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAdministrativeAreaOfLinearSection"></see></summary>
    let hasAdministrativeAreaOfLinearSection =
        Namespaced_IRI.parse _namespace_name "hasAdministrativeAreaOfLinearSection" |> NamespacedName

    /// <summary>
    /// The direction of traffic flow on the linear section relative to the direction in which the linear element is defined.
    ///
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#directionRelativeOnLinearSection"></see></summary>
    let directionRelativeOnLinearSection =
        Namespaced_IRI.parse _namespace_name "directionRelativeOnLinearSection" |> NamespacedName

    /// <summary>
    /// In Datex II definition, a pair of planar coordinates defining the geodetic position of a single point using the European Terrestrial Reference System 1989 (ETRS89).
    ///
    /// Note: At the moment, in Spain it is used the WGS84 and so, the 2 references are possible ( geo/wgs84_pos (lat, long) / geo_core (xETRS89,yETRS89) ).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PointCoordinates"></see></summary>
    let PointCoordinates =
        Namespaced_IRI.parse _namespace_name "PointCoordinates" |> NamespacedName

    /// <summary>
    /// Coordinates that may be used by clients for visual display on user interfaces.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasPointCoordinates"></see></summary>
    let hasPointCoordinates =
        Namespaced_IRI.parse _namespace_name "hasPointCoordinates" |> NamespacedName

    /// <summary>
    /// Only for organizational purposes. Package PayloadPublication
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PayLoadPublishing"></see></summary>
    let PayLoadPublishing =
        Namespaced_IRI.parse _namespace_name "PayLoadPublishing" |> NamespacedName

    /// <summary>
    /// Types of maintenance vehicle actions associated with roadworks.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#MaintenanceVehicleActionsEnum"></see></summary>
    let MaintenanceVehicleActionsEnum =
        Namespaced_IRI.parse _namespace_name "MaintenanceVehicleActionsEnum" |> NamespacedName

    /// <summary>
    /// Details of the maintenance vehicles involved in the roadworks activity.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#MaintenanceVehicles"></see></summary>
    let MaintenanceVehicles =
        Namespaced_IRI.parse _namespace_name "MaintenanceVehicles" |> NamespacedName

    /// <summary>
    /// The number of maintenance vehicles associated with the roadworks activities at the specified location.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#numberOfMaintenanceVehicles"></see></summary>
    let numberOfMaintenanceVehicles =
        Namespaced_IRI.parse _namespace_name "numberOfMaintenanceVehicles" |> NamespacedName

    /// <summary>
    /// Roadworks involving the maintenance or installation of infrastructure.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#MaintenanceWorks"></see></summary>
    let MaintenanceWorks =
        Namespaced_IRI.parse _namespace_name "MaintenanceWorks" |> NamespacedName

    /// <summary>
    /// Types of road maintenance.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#RoadMaintenanceTypeEnum"></see></summary>
    let RoadMaintenanceTypeEnum =
        Namespaced_IRI.parse _namespace_name "RoadMaintenanceTypeEnum" |> NamespacedName

    /// <summary>
    /// The type of road maintenance or installation work at the specified location.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasRoadMaintenanceType"></see></summary>
    let hasRoadMaintenanceType =
        Namespaced_IRI.parse _namespace_name "hasRoadMaintenanceType" |> NamespacedName

    /// <summary>
    /// A measured or calculated value of speed.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#SpeedValue"></see></summary>
    let SpeedValue = Namespaced_IRI.parse _namespace_name "SpeedValue" |> NamespacedName
    /// <summary>
    /// Speed of the mobile entity.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#speed"></see></summary>
    let speed = Namespaced_IRI.parse _namespace_name "speed" |> NamespacedName

    /// <summary>
    /// An indication of whether the associated instance of a SituationRecord is mobile (e.g. a march or parade moving along a road) or stationary.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#MobilityTypeEnum"></see></summary>
    let MobilityTypeEnum =
        Namespaced_IRI.parse _namespace_name "MobilityTypeEnum" |> NamespacedName

    /// <summary>
    /// Types of mobility relating to a situation element defined by a SituationReord.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasMobilityType"></see></summary>
    let hasMobilityType =
        Namespaced_IRI.parse _namespace_name "hasMobilityType" |> NamespacedName

    /// <summary>
    /// The name of the area.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#areaNameProperty"></see></summary>
    let areaNameProperty =
        Namespaced_IRI.parse _namespace_name "areaNameProperty" |> NamespacedName

    /// <summary>
    /// Types of areas.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#NamedAreaTypeEnum"></see></summary>
    let NamedAreaTypeEnum =
        Namespaced_IRI.parse _namespace_name "NamedAreaTypeEnum" |> NamespacedName

    /// <summary>
    /// The type of the area.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasNamedAreaTypeEnum"></see></summary>
    let hasNamedAreaTypeEnum =
        Namespaced_IRI.parse _namespace_name "hasNamedAreaTypeEnum" |> NamespacedName

    /// <summary>
    /// A collection of supplementary positional information which improves the precision of the location.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasSupplementaryPositionalDescription"></see></summary>
    let hasSupplementaryPositionalDescription =
        Namespaced_IRI.parse _namespace_name "hasSupplementaryPositionalDescription" |> NamespacedName

    /// <summary>
    /// Actions that a traffic operator can decide to implement to prevent or help correct dangerous or poor driving conditions, including maintenance of the road infrastructure.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OperatorAction"></see></summary>
    let OperatorAction =
        Namespaced_IRI.parse _namespace_name "OperatorAction" |> NamespacedName

    /// <summary>
    /// Types of road surface conditions which are not related to the weather.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#NonWeatherRelatedRoadConditionTypeEnum"></see></summary>
    let NonWeatherRelatedRoadConditionTypeEnum =
        Namespaced_IRI.parse _namespace_name "NonWeatherRelatedRoadConditionTypeEnum" |> NamespacedName

    /// <summary>
    /// Road surface conditions that are not related to the weather but which may affect driving conditions.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#NonWeatherRelatedRoadConditions"></see></summary>
    let NonWeatherRelatedRoadConditions =
        Namespaced_IRI.parse _namespace_name "NonWeatherRelatedRoadConditions" |> NamespacedName

    /// <summary>
    /// The type of road conditions which are not related to the weather.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasNonWeatherRelatedRoadConditionTypeEnum"></see></summary>
    let hasNonWeatherRelatedRoadConditionTypeEnum =
        Namespaced_IRI.parse _namespace_name "hasNonWeatherRelatedRoadConditionTypeEnum" |> NamespacedName

    /// <summary>
    /// Road surface conditions that are related to the weather which may affect the driving conditions, such as ice, snow or water.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#WeatherRelatedRoadConditions"></see></summary>
    let WeatherRelatedRoadConditions =
        Namespaced_IRI.parse _namespace_name "WeatherRelatedRoadConditions" |> NamespacedName

    /// <summary>
    /// Conditions of the road surface which may affect driving conditions. These may be related to the weather (e.g. ice, snow etc.) or to other conditions (e.g. oil, mud, leaves etc. on the road)
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#RoadSurfaceConditions"></see></summary>
    let RoadSurfaceConditions =
        Namespaced_IRI.parse _namespace_name "RoadSurfaceConditions" |> NamespacedName

    /// <summary>
    /// Types of NUTS codes (Nomenclature of territorial units for statistics) including LAU codes (Local Administrative Units).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#NutsCodeTypeEnum"></see></summary>
    let NutsCodeTypeEnum =
        Namespaced_IRI.parse _namespace_name "NutsCodeTypeEnum" |> NamespacedName

    /// <summary>
    /// The NUTS-Code representation for the named area (Nomenclature of territorial units for statistics) or its LAU code representation (Local Administrative Unit).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#NutsNamedArea"></see></summary>
    let NutsNamedArea =
        Namespaced_IRI.parse _namespace_name "NutsNamedArea" |> NamespacedName

    /// <summary>
    /// The NUTS code for the named area.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#nutsCode"></see></summary>
    let nutsCode = Namespaced_IRI.parse _namespace_name "nutsCode" |> NamespacedName

    /// <summary>
    /// The NUTS code type for the named area.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasNutsCodeTypeEnum"></see></summary>
    let hasNutsCodeTypeEnum =
        Namespaced_IRI.parse _namespace_name "hasNutsCodeTypeEnum" |> NamespacedName

    /// <summary>
    /// Number of Obstructions. Not in SRTI profile
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#numberOfObstructions"></see></summary>
    let numberOfObstructions =
        Namespaced_IRI.parse _namespace_name "numberOfObstructions" |> NamespacedName

    /// <summary>
    /// Specifies the mobility of a obstruction
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasMobilityOfObstruction"></see></summary>
    let hasMobilityOfObstruction =
        Namespaced_IRI.parse _namespace_name "hasMobilityOfObstruction" |> NamespacedName

    /// <summary>
    /// The non-negative offset distance from the ALERT-C referenced point to the actual point. The ALERT-C locations in the primary and secondary locations must always encompass the linear section being specified, thus offset distance is towards the other point.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#offsetDistance"></see></summary>
    let offsetDistance =
        Namespaced_IRI.parse _namespace_name "offsetDistance" |> NamespacedName

    /// <summary>
    /// OpenLR location
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenLR"></see></summary>
    let OpenLR = Namespaced_IRI.parse _namespace_name "OpenLR" |> NamespacedName

    /// <summary>
    /// Holds common data that are used both in OpenlrPointAccessPoint and OpenlrPointAlongLine.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrBasePointLocation"></see></summary>
    let OpenlrBasePointLocation =
        Namespaced_IRI.parse _namespace_name "OpenlrBasePointLocation" |> NamespacedName

    /// <summary>
    /// Offsets are used to locate the start and end of a location more precisely than bounding to the nodes in a network.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrOffsets"></see></summary>
    let OpenlrOffsets =
        Namespaced_IRI.parse _namespace_name "OpenlrOffsets" |> NamespacedName

    /// <summary>
    /// Allows for adding offsets to the line location path defined by nodes when the starting (respectively ending) point does not coincide with a node.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrOffsets"></see></summary>
    let hasOpenlrOffsets =
        Namespaced_IRI.parse _namespace_name "hasOpenlrOffsets" |> NamespacedName

    /// <summary>
    /// Enumeration of side of road
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrSideOfRoadEnum"></see></summary>
    let OpenlrSideOfRoadEnum =
        Namespaced_IRI.parse _namespace_name "OpenlrSideOfRoadEnum" |> NamespacedName

    /// <summary>
    /// Provides the of road where the corresponding point lies.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrSideOfRoad"></see></summary>
    let hasOpenlrSideOfRoad =
        Namespaced_IRI.parse _namespace_name "hasOpenlrSideOfRoad" |> NamespacedName

    /// <summary>
    /// Enumeration of side of road
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrOrientationEnum"></see></summary>
    let OpenlrOrientationEnum =
        Namespaced_IRI.parse _namespace_name "OpenlrOrientationEnum" |> NamespacedName

    /// <summary>
    /// Orientation of the driving direction in relation with the direction of the underlying linear
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrOrientation"></see></summary>
    let hasOpenlrOrientation =
        Namespaced_IRI.parse _namespace_name "hasOpenlrOrientation" |> NamespacedName

    /// <summary>
    /// The basis of a location reference is a sequence of location reference points (LRPs).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrLocationReferencePoint"></see></summary>
    let OpenlrLocationReferencePoint =
        Namespaced_IRI.parse _namespace_name "OpenlrLocationReferencePoint" |> NamespacedName

    /// <summary>
    /// Allows defining the first point of the OpenLR path
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrLocationReferencePoint"></see></summary>
    let hasOpenlrLocationReferencePoint =
        Namespaced_IRI.parse _namespace_name "hasOpenlrLocationReferencePoint" |> NamespacedName

    /// <summary>
    /// The sequence of location reference points is terminated by a last location reference point.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrLastLocationReferencePoint"></see></summary>
    let OpenlrLastLocationReferencePoint =
        Namespaced_IRI.parse _namespace_name "OpenlrLastLocationReferencePoint" |> NamespacedName

    /// <summary>
    /// Allows defining the last point of the OpenLR path
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrLastLocationReferencePoint"></see></summary>
    let hasOpenlrLastLocationReferencePoint =
        Namespaced_IRI.parse _namespace_name "hasOpenlrLastLocationReferencePoint" |> NamespacedName

    /// <summary>
    /// A point location is a zero-dimensional element in a map that specifies a geometric location.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrPointLocationReference"></see></summary>
    let OpenlrPointLocationReference =
        Namespaced_IRI.parse _namespace_name "OpenlrPointLocationReference" |> NamespacedName

    /// <summary>
    /// Base class used to hold data about a reference point.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrBaseReferencePoint"></see></summary>
    let OpenlrBaseReferencePoint =
        Namespaced_IRI.parse _namespace_name "OpenlrBaseReferencePoint" |> NamespacedName

    /// <summary>
    /// Line attributes are part of a location reference point and consists of functional road class (FRC),form of way (FOW) and bearing (BEAR) data.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrLineAttributes"></see></summary>
    let OpenlrLineAttributes =
        Namespaced_IRI.parse _namespace_name "OpenlrLineAttributes" |> NamespacedName

    /// <summary>
    /// Properties of the line towards the topologically adjacent OpenLR location referencing point, on the shortest path to that point.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrLineAttributes"></see></summary>
    let hasOpenlrLineAttributes =
        Namespaced_IRI.parse _namespace_name "hasOpenlrLineAttributes" |> NamespacedName

    /// <summary>
    /// The OpenLR method of area definition by providing a center position and a radius
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrCircleLocationReference"></see></summary>
    let OpenlrCircleLocationReference =
        Namespaced_IRI.parse _namespace_name "OpenlrCircleLocationReference" |> NamespacedName

    /// <summary>
    /// The radius of the corresponding circular area.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#openlrRadius"></see></summary>
    let openlrRadius =
        Namespaced_IRI.parse _namespace_name "openlrRadius" |> NamespacedName

    /// <summary>
    /// A geo-coordinate pair is a position in a map defined by its longitude and latitude coordinate values.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrGeoCoordinate"></see></summary>
    let OpenlrGeoCoordinate =
        Namespaced_IRI.parse _namespace_name "OpenlrGeoCoordinate" |> NamespacedName

    /// <summary>
    /// A geo-coordinate pair is a position in a map defined by its longitude and latitude coordinate values.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrGeoCoordinate"></see></summary>
    let hasOpenlrGeoCoordinate =
        Namespaced_IRI.parse _namespace_name "hasOpenlrGeoCoordinate" |> NamespacedName

    /// <summary>
    /// The OpenLR method of area definition by providing a closed path (i.e. a circuit) in the road network.
    /// The boundary always consists of road segments
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrClosedLineLocationReference"></see></summary>
    let OpenlrClosedLineLocationReference =
        Namespaced_IRI.parse _namespace_name "OpenlrClosedLineLocationReference" |> NamespacedName

    /// <summary>
    /// Only for organizational purposes
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrEnumerations"></see></summary>
    let OpenlrEnumerations =
        Namespaced_IRI.parse _namespace_name "OpenlrEnumerations" |> NamespacedName

    /// <summary>
    /// Enumeration of form of way
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrFormOfWayEnum"></see></summary>
    let OpenlrFormOfWayEnum =
        Namespaced_IRI.parse _namespace_name "OpenlrFormOfWayEnum" |> NamespacedName

    /// <summary>
    /// Enumuration of functional road class
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrFunctionalRoadClassEnum"></see></summary>
    let OpenlrFunctionalRoadClassEnum =
        Namespaced_IRI.parse _namespace_name "OpenlrFunctionalRoadClassEnum" |> NamespacedName

    /// <summary>
    /// Corresponding coordinates of an OpenLR point defined by its only coordinates.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrCoordinates"></see></summary>
    let hasOpenlrCoordinates =
        Namespaced_IRI.parse _namespace_name "hasOpenlrCoordinates" |> NamespacedName

    /// <summary>
    /// Area defined using an OpenLR™ method consisting in defining it by a tessellation of rectangles
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrGridLocationReference"></see></summary>
    let OpenlrGridLocationReference =
        Namespaced_IRI.parse _namespace_name "OpenlrGridLocationReference" |> NamespacedName

    /// <summary>
    /// The number that the base rectangle should be multiplied in the north direction
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#openlrNumRows"></see></summary>
    let openlrNumRows =
        Namespaced_IRI.parse _namespace_name "openlrNumRows" |> NamespacedName

    /// <summary>
    /// The number that the base rectangle should be multiplied in the east direction
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#openlrNumColumns"></see></summary>
    let openlrNumColumns =
        Namespaced_IRI.parse _namespace_name "openlrNumColumns" |> NamespacedName

    /// <summary>
    /// Area delimited by a rectangle defined by the geodetic co-ordinates of the two ends of its diagonal from south-west to north-east (the rectangle having two sides that are parallel to lines of latitude)
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrRectangle"></see></summary>
    let OpenlrRectangle =
        Namespaced_IRI.parse _namespace_name "OpenlrRectangle" |> NamespacedName

    /// <summary>
    /// Area delimited by a rectangle defined by the geodetic co-ordinates of the two ends of its diagonal from south-west to north-east (the rectangle having two sides that are parallel to lines of latitude)
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrRectangle"></see></summary>
    let hasOpenlrRectangle =
        Namespaced_IRI.parse _namespace_name "hasOpenlrRectangle" |> NamespacedName

    /// <summary>
    /// Only for organizational purposes.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrLine"></see></summary>
    let OpenlrLine = Namespaced_IRI.parse _namespace_name "OpenlrLine" |> NamespacedName

    /// <summary>
    /// Defines the bearing field as an integer value between 0 and 359
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#openlrBearing"></see></summary>
    let openlrBearing =
        Namespaced_IRI.parse _namespace_name "openlrBearing" |> NamespacedName

    /// <summary>
    /// The lowest FRC to the next point indicates the lowest functional road class used in the location reference path to the next LR-point.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrLowestFrcToNextLRPoint"></see></summary>
    let hasOpenlrLowestFrcToNextLRPoint =
        Namespaced_IRI.parse _namespace_name "hasOpenlrLowestFrcToNextLRPoint" |> NamespacedName

    /// <summary>
    /// A classification based on the importance of the role that the Road Element (or Ferry Connection) performs in the connectivity of the total road network. (EN ISO 14825 § 7.2.88)
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrFormOfWayEnum"></see></summary>
    let hasOpenlrFormOfWayEnum =
        Namespaced_IRI.parse _namespace_name "hasOpenlrFormOfWayEnum" |> NamespacedName

    /// <summary>
    /// A line location reference is defined by an ordered sequence of location reference points and a terminating last location reference point.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrLineLocationReference"></see></summary>
    let OpenlrLineLocationReference =
        Namespaced_IRI.parse _namespace_name "OpenlrLineLocationReference" |> NamespacedName

    /// <summary>
    /// If both direction, this is the reference in the opposite direction against firstDirection.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrOppositeDirection"></see></summary>
    let hasOpenlrOppositeDirection =
        Namespaced_IRI.parse _namespace_name "hasOpenlrOppositeDirection" |> NamespacedName

    /// <summary>
    /// First OpenLR reference in first/main direction.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrFirstDirection"></see></summary>
    let hasOpenlrFirstDirection =
        Namespaced_IRI.parse _namespace_name "hasOpenlrFirstDirection" |> NamespacedName

    /// <summary>
    /// Properties of the path from the associated location reference point to the next location reference point, which are specified to assist correct identification of the point in an external map data source.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrPathAttributes"></see></summary>
    let OpenlrPathAttributes =
        Namespaced_IRI.parse _namespace_name "OpenlrPathAttributes" |> NamespacedName

    /// <summary>
    /// Properties of the path from the associated location reference point to the next location reference point, which are specified to assist correct identification of the point in an external map data source.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrPathAttributes"></see></summary>
    let hasOpenlrPathAttributes =
        Namespaced_IRI.parse _namespace_name "hasOpenlrPathAttributes" |> NamespacedName

    /// <summary>
    /// The positive offset along the line of the location measured along the line reference path between the start point of the location reference and the starting node of the line reference path.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#openlrPositiveOffset"></see></summary>
    let openlrPositiveOffset =
        Namespaced_IRI.parse _namespace_name "openlrPositiveOffset" |> NamespacedName

    /// <summary>
    /// The negative offset along the line of the location measured along the line reference path between the end point of the location reference and the ending node of the line reference path.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#openlrNegativeOffset"></see></summary>
    let openlrNegativeOffset =
        Namespaced_IRI.parse _namespace_name "openlrNegativeOffset" |> NamespacedName

    /// <summary>
    /// The DNP attribute measures the distance in meters between two consecutive location reference-points along the location reference path described in the corresponding enumeration
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#openlrDistanceToNextLRPoint"></see></summary>
    let openlrDistanceToNextLRPoint =
        Namespaced_IRI.parse _namespace_name "openlrDistanceToNextLRPoint" |> NamespacedName

    /// <summary>
    /// A point of interest (POI) along a line with access is a point location which is defined by a linear reference path, an offset value (defining the access point) from the starting node of this path and a coordinate pair that defines the POI itself.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrPoiWithAccessPoint"></see></summary>
    let OpenlrPoiWithAccessPoint =
        Namespaced_IRI.parse _namespace_name "OpenlrPoiWithAccessPoint" |> NamespacedName

    /// <summary>
    /// Point along a line
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrPointAlongLine"></see></summary>
    let OpenlrPointAlongLine =
        Namespaced_IRI.parse _namespace_name "OpenlrPointAlongLine" |> NamespacedName

    /// <summary>
    /// A geodetic coordinate Tuple that defines the vertices of the underlying geometrical polygon.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrPolygonCorners"></see></summary>
    let OpenlrPolygonCorners =
        Namespaced_IRI.parse _namespace_name "OpenlrPolygonCorners" |> NamespacedName

    /// <summary>
    /// The OpenLR method of area definition by providing points that bound the area
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrPolygonLocationReference"></see></summary>
    let OpenlrPolygonLocationReference =
        Namespaced_IRI.parse _namespace_name "OpenlrPolygonLocationReference" |> NamespacedName

    /// <summary>
    /// A geodetic coordinate Tuple that defines the vertices of the underlying geometrical polygon.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrPolygonCorners"></see></summary>
    let hasOpenlrPolygonCorners =
        Namespaced_IRI.parse _namespace_name "hasOpenlrPolygonCorners" |> NamespacedName

    /// <summary>
    /// The upper right corner of the rectangle.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrUpperRight"></see></summary>
    let hasOpenlrUpperRight =
        Namespaced_IRI.parse _namespace_name "hasOpenlrUpperRight" |> NamespacedName

    /// <summary>
    /// The lower left corner of the rectangle.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrLowerLeft"></see></summary>
    let hasOpenlrLowerLeft =
        Namespaced_IRI.parse _namespace_name "hasOpenlrLowerLeft" |> NamespacedName

    /// <summary>
    /// The openLR method of area definition by providing a rectangular shape defined by two geo-coordinate pairs
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrRectangleLocationReference"></see></summary>
    let OpenlrRectangleLocationReference =
        Namespaced_IRI.parse _namespace_name "OpenlrRectangleLocationReference" |> NamespacedName

    /// <summary>
    /// Any situation record. An identifiable versioned instance of a single record/element within a situation.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#SituationRecord"></see></summary>
    let SituationRecord =
        Namespaced_IRI.parse _namespace_name "SituationRecord" |> NamespacedName

    /// <summary>
    /// A continuous or discontinuous period of validity defined by overall bounding start and end times and the possible intersection of valid periods (potentially recurring) with the complement of exception periods (also potentially recurring).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OverallPeriod"></see></summary>
    let OverallPeriod =
        Namespaced_IRI.parse _namespace_name "OverallPeriod" |> NamespacedName

    /// <summary>
    /// A payload publication of traffic related information or associated management information created at a specific point in time that can be exchanged via a DATEX II interface.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PayloadPublication"></see></summary>
    let PayloadPublication =
        Namespaced_IRI.parse _namespace_name "PayloadPublication" |> NamespacedName

    /// <summary>
    /// A classification of the information which is to be found in the publications originating from the particular feed.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#feedType"></see></summary>
    let feedType = Namespaced_IRI.parse _namespace_name "feedType" |> NamespacedName

    /// <summary>
    /// A description of the information which is to be found in the publications originating from the particular feed (URL).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#feedDescription"></see></summary>
    let feedDescription =
        Namespaced_IRI.parse _namespace_name "feedDescription" |> NamespacedName

    /// <summary>
    /// Date/time at which the payload publication was created.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#publicationTime"></see></summary>
    let publicationTime =
        Namespaced_IRI.parse _namespace_name "publicationTime" |> NamespacedName

    /// <summary>
    /// Specifies the publication creator using an international identifier
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#publicationCreator"></see></summary>
    let publicationCreator =
        Namespaced_IRI.parse _namespace_name "publicationCreator" |> NamespacedName

    /// <summary>
    /// The default language used throughout the payload publication
    /// Specifies the language by an ISO 639-1 2-alpha code
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#defaultLanguage"></see></summary>
    let defaultLanguage =
        Namespaced_IRI.parse _namespace_name "defaultLanguage" |> NamespacedName

    /// <summary>
    /// Distance of a point along a linear element measured from the start node expressed as a percentage of the whole length of the linear element, where start node is relative to the element definition rather than the direction of traffic flow.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PercentageDistanceAlongLinearElement"></see></summary>
    let PercentageDistanceAlongLinearElement =
        Namespaced_IRI.parse _namespace_name "PercentageDistanceAlongLinearElement" |> NamespacedName

    /// <summary>
    /// A measure of distance along a linear element from the start of the element expressed as a percentage of the total length of the linear object.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#percentageDistanceAlong"></see></summary>
    let percentageDistanceAlong =
        Namespaced_IRI.parse _namespace_name "percentageDistanceAlong" |> NamespacedName

    /// <summary>
    /// A point on a linear element where the linear element is either a part of or the whole of a linear object (i.e. a road), consistent with EN ISO 19148 definitions.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PointAlongLinearElement"></see></summary>
    let PointAlongLinearElement =
        Namespaced_IRI.parse _namespace_name "PointAlongLinearElement" |> NamespacedName

    /// <summary>
    /// Identification of whether the point on the linear element is at, above or below the normal elevation of a linear element of that type (e.g. road or road section) at that location, typically used to indicate "grade" separation.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasHeightGradeOfPoint"></see></summary>
    let hasHeightGradeOfPoint =
        Namespaced_IRI.parse _namespace_name "hasHeightGradeOfPoint" |> NamespacedName

    /// <summary>
    /// Identification of the road administration area which contains the specified point.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAdministrativeAreaOfPoint"></see></summary>
    let hasAdministrativeAreaOfPoint =
        Namespaced_IRI.parse _namespace_name "hasAdministrativeAreaOfPoint" |> NamespacedName

    /// <summary>
    /// The direction of traffic flow at the specified point relative to the direction in which the linear element is defined.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#directionRelativeAtPoint"></see></summary>
    let directionRelativeAtPoint =
        Namespaced_IRI.parse _namespace_name "directionRelativeAtPoint" |> NamespacedName

    /// <summary>
    /// The direction of traffic flow at the specified point in terms of general destination direction.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#directionAtPoint"></see></summary>
    let directionAtPoint =
        Namespaced_IRI.parse _namespace_name "directionAtPoint" |> NamespacedName

    /// <summary>
    /// Distance of a point along a linear element either measured from the start node or a defined referent on that linear element, where the start node is relative to the element definition rather than the direction of traffic flow.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasDistanceAlongLinearElement"></see></summary>
    let hasDistanceAlongLinearElement =
        Namespaced_IRI.parse _namespace_name "hasDistanceAlongLinearElement" |> NamespacedName

    /// <summary>
    /// A single point defined only by a coordinate set with an optional bearing direction.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PointByCoordinates"></see></summary>
    let PointByCoordinates =
        Namespaced_IRI.parse _namespace_name "PointByCoordinates" |> NamespacedName

    /// <summary>
    /// Accuracy defined by the 95th percentile of the cumulative distribution of position errors
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#bearing"></see></summary>
    let bearing = Namespaced_IRI.parse _namespace_name "bearing" |> NamespacedName

    /// <summary>
    /// A pair of planar coordinates defining the geodetic position of a single point using the European Terrestrial Reference System 1989 (ETRS89).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PointCoordinatesAssociationsTo"></see></summary>
    let PointCoordinatesAssociationsTo =
        Namespaced_IRI.parse _namespace_name "PointCoordinatesAssociationsTo" |> NamespacedName

    /// <summary>
    /// Defines the horizontal position accuracy according EN 16803-1
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasHorizontalPositionAccuracy"></see></summary>
    let hasHorizontalPositionAccuracy =
        Namespaced_IRI.parse _namespace_name "hasHorizontalPositionAccuracy" |> NamespacedName

    /// <summary>
    /// Confidence ellipse position defined in a shape of ellipse with a predefined confidence level (e.g. 95 %). The centre of the ellipse shape corresponds to the reference position point for which the position accuracy is evaluated.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PositionConfidenceEllipse"></see></summary>
    let PositionConfidenceEllipse =
        Namespaced_IRI.parse _namespace_name "PositionConfidenceEllipse" |> NamespacedName

    /// <summary>
    /// Confidence ellipse position defined in a shape of ellipse with a predefined confidence level (e.g. 95 %). The centre of the ellipse shape corresponds to the reference position point for which the position accuracy is evaluated.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasPositionConfidenceEllipse"></see></summary>
    let hasPositionConfidenceEllipse =
        Namespaced_IRI.parse _namespace_name "hasPositionConfidenceEllipse" |> NamespacedName

    /// <summary>
    /// Third coordinate for points defined geodetically
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasHeightCoordinate"></see></summary>
    let hasHeightCoordinate =
        Namespaced_IRI.parse _namespace_name "hasHeightCoordinate" |> NamespacedName

    /// <summary>
    /// Location representing a single geospatial point.
    /// At least one of these aggregated classes must be present. If using multiple instances of the agregated classes, producers must take care to ensure they present the same location.
    ///
    /// Associations:
    /// 0..1	PointByCoordinates
    /// 0..*	PointAlongLinearElement
    /// 0..*	AlertCPoint
    /// 0..1	TpegPointLocation
    /// 0..1	OpenlrPointLocationReference
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PointLocation"></see></summary>
    let PointLocation =
        Namespaced_IRI.parse _namespace_name "PointLocation" |> NamespacedName

    /// <summary>
    /// A single point on the road network defined by a TPEG-Loc structure and which has an associated direction of traffic flow.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegPointLocation"></see></summary>
    let TpegPointLocation =
        Namespaced_IRI.parse _namespace_name "TpegPointLocation" |> NamespacedName

    /// <summary>
    /// PointLocation is associated to TpegPointLocation with cardinality 0..1
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasTpegPointLocation"></see></summary>
    let hasTpegPointLocation =
        Namespaced_IRI.parse _namespace_name "hasTpegPointLocation" |> NamespacedName

    /// <summary>
    /// PointLocation is associated to PointByCoordinates with cardinality 0..1
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasPointByCoordinates"></see></summary>
    let hasPointByCoordinates =
        Namespaced_IRI.parse _namespace_name "hasPointByCoordinates" |> NamespacedName

    /// <summary>
    /// PointLocation is associated to OpenlrPointLocationReference with cardinality 0..1
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrPointLocationReference"></see></summary>
    let hasOpenlrPointLocationReference =
        Namespaced_IRI.parse _namespace_name "hasOpenlrPointLocationReference" |> NamespacedName

    /// <summary>
    /// Any environmental conditions which may be affecting the driving conditions on the road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PoorEnvironmentConditions"></see></summary>
    let PoorEnvironmentConditions =
        Namespaced_IRI.parse _namespace_name "PoorEnvironmentConditions" |> NamespacedName

    /// <summary>
    /// Types of poor environmental conditions.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PoorEnvironmentTypeEnum"></see></summary>
    let PoorEnvironmentTypeEnum =
        Namespaced_IRI.parse _namespace_name "PoorEnvironmentTypeEnum" |> NamespacedName

    /// <summary>
    /// Any environmental conditions which may be affecting the driving conditions on the road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasPoorEnvironmentTypeEnum"></see></summary>
    let hasPoorEnvironmentTypeEnum =
        Namespaced_IRI.parse _namespace_name "hasPoorEnvironmentTypeEnum" |> NamespacedName

    /// <summary>
    /// Accuracy defined by the 95th percentile of the cumulative distribution of position errors
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#accuracyPercentile95"></see></summary>
    let accuracyPercentile95 =
        Namespaced_IRI.parse _namespace_name "accuracyPercentile95" |> NamespacedName

    /// <summary>
    /// Accuracy defined by the 75th percentile of the cumulative distribution of position errors
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#accuracyPercentile75"></see></summary>
    let accuracyPercentile75 =
        Namespaced_IRI.parse _namespace_name "accuracyPercentile75" |> NamespacedName

    /// <summary>
    /// Accuracy defined by the 50th percentile of the cumulative distribution of position errors.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#accuracyPercentile50"></see></summary>
    let accuracyPercentile50 =
        Namespaced_IRI.parse _namespace_name "accuracyPercentile50" |> NamespacedName

    /// <summary>
    /// Indicates whether the ellipse orientation is unavailable (True) or not (False)
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#semiMajorAxisOrientationError"></see></summary>
    let semiMajorAxisOrientationError =
        Namespaced_IRI.parse _namespace_name "semiMajorAxisOrientationError" |> NamespacedName

    /// <summary>
    /// Half of length of the minor axis, i.e. distance between the centre point and minor axis point of the position accuracy ellipse
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#semiMinorAxisLength"></see></summary>
    let semiMinorAxisLength =
        Namespaced_IRI.parse _namespace_name "semiMinorAxisLength" |> NamespacedName

    /// <summary>
    /// Orientation direction of the ellipse major axis of the position accuracy ellipse with regards to the geographic north.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#semiMajorAxisOrientation"></see></summary>
    let semiMajorAxisOrientation =
        Namespaced_IRI.parse _namespace_name "semiMajorAxisOrientation" |> NamespacedName

    /// <summary>
    /// Half of length of the major axis, i.e. distance between the centre point and major axis point of the position accuracy ellipse.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#semiMajorAxisLength"></see></summary>
    let semiMajorAxisLength =
        Namespaced_IRI.parse _namespace_name "semiMajorAxisLength" |> NamespacedName

    /// <summary>
    /// Provides a coded error in case the semi-minor axis length is not defined
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasSemiMinorAxisLengthCodedError"></see></summary>
    let hasSemiMinorAxisLengthCodedError =
        Namespaced_IRI.parse _namespace_name "hasSemiMinorAxisLengthCodedError" |> NamespacedName

    /// <summary>
    /// Provides a coded error in case the semi-major axis length is not defined
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasSemiMajorAxisLengthCodedError"></see></summary>
    let hasSemiMajorAxisLengthCodedError =
        Namespaced_IRI.parse _namespace_name "hasSemiMajorAxisLengthCodedError" |> NamespacedName

    /// <summary>
    /// Levels of confidence that the sender has in the information, ordered {certain, probable, risk of}.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ProbabilityOfOccurrenceEnum"></see></summary>
    let ProbabilityOfOccurrenceEnum =
        Namespaced_IRI.parse _namespace_name "ProbabilityOfOccurrenceEnum" |> NamespacedName

    /// <summary>
    /// Public event
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PublicEvent"></see></summary>
    let PublicEvent =
        Namespaced_IRI.parse _namespace_name "PublicEvent" |> NamespacedName

    /// <summary>
    /// Name of the venue at which the public event is being held
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#venueName"></see></summary>
    let venueName = Namespaced_IRI.parse _namespace_name "venueName" |> NamespacedName

    /// <summary>
    /// Types of public events.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PublicEventTypeEnum"></see></summary>
    let PublicEventTypeEnum =
        Namespaced_IRI.parse _namespace_name "PublicEventTypeEnum" |> NamespacedName

    /// <summary>
    /// RAMON geographic ontology describes countries, NUTS, and Local Administrative Units (LAU) related concepts and properties
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Ramon_geoClasses"></see></summary>
    let Ramon_geoClasses =
        Namespaced_IRI.parse _namespace_name "Ramon_geoClasses" |> NamespacedName

    /// <summary>
    /// The name of the referent, e.g. a junction or intersection name.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#referentName"></see></summary>
    let referentName =
        Namespaced_IRI.parse _namespace_name "referentName" |> NamespacedName

    /// <summary>
    /// Description of the referent.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#referentDescription"></see></summary>
    let referentDescription =
        Namespaced_IRI.parse _namespace_name "referentDescription" |> NamespacedName

    /// <summary>
    /// The identifier of the referent, unique on the specified linear element (i.e. road or part of).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#referentIdentifier"></see></summary>
    let referentIdentifier =
        Namespaced_IRI.parse _namespace_name "referentIdentifier" |> NamespacedName

    /// <summary>
    /// A set of types of known points along a linear object such as a road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ReferentTypeEnum"></see></summary>
    let ReferentTypeEnum =
        Namespaced_IRI.parse _namespace_name "ReferentTypeEnum" |> NamespacedName

    /// <summary>
    /// The type of the referent.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasReferentTypeEnum"></see></summary>
    let hasReferentTypeEnum =
        Namespaced_IRI.parse _namespace_name "hasReferentTypeEnum" |> NamespacedName

    /// <summary>
    /// Identifies a relative position across a carriageway
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#RelativePositionOnCarriagewayEnum"></see></summary>
    let RelativePositionOnCarriagewayEnum =
        Namespaced_IRI.parse _namespace_name "RelativePositionOnCarriagewayEnum" |> NamespacedName

    /// <summary>
    /// Rerouting management action that is issued by the network/road operator.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ReroutingManagement"></see></summary>
    let ReroutingManagement =
        Namespaced_IRI.parse _namespace_name "ReroutingManagement" |> NamespacedName

    /// <summary>
    /// Management actions relating to rerouting.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ReroutingManagementTypeEnum"></see></summary>
    let ReroutingManagementTypeEnum =
        Namespaced_IRI.parse _namespace_name "ReroutingManagementTypeEnum" |> NamespacedName

    /// <summary>
    /// Management actions relating to rerouting.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasReroutingManagementType"></see></summary>
    let hasReroutingManagementType =
        Namespaced_IRI.parse _namespace_name "hasReroutingManagementType" |> NamespacedName

    /// <summary>
    /// Information on a road
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#RoadInformation"></see></summary>
    let RoadInformation =
        Namespaced_IRI.parse _namespace_name "RoadInformation" |> NamespacedName

    /// <summary>
    /// A destination associated with this road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadDestination"></see></summary>
    let roadDestination =
        Namespaced_IRI.parse _namespace_name "roadDestination" |> NamespacedName

    /// <summary>
    /// Road, carriageway or lane management action that is instigated by the network/road operator.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#RoadOrCarriagewayOrLaneManagement"></see></summary>
    let RoadOrCarriagewayOrLaneManagement =
        Namespaced_IRI.parse _namespace_name "RoadOrCarriagewayOrLaneManagement" |> NamespacedName

    /// <summary>
    /// The minimum number of persons required in a vehicle in order for it to be allowed to transit the specified road section.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#minimumCarOccupancy"></see></summary>
    let minimumCarOccupancy =
        Namespaced_IRI.parse _namespace_name "minimumCarOccupancy" |> NamespacedName

    /// <summary>
    /// Management actions relating to road, carriageway or lane usage.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#RoadOrCarriagewayOrLaneManagementTypeEnum"></see></summary>
    let RoadOrCarriagewayOrLaneManagementTypeEnum =
        Namespaced_IRI.parse _namespace_name "RoadOrCarriagewayOrLaneManagementTypeEnum" |> NamespacedName

    /// <summary>
    /// Indicates that the road section where the roadworks are located is under traffic or not under traffic. 'True' indicates the road is under traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#underTraffic"></see></summary>
    let underTraffic =
        Namespaced_IRI.parse _namespace_name "underTraffic" |> NamespacedName

    /// <summary>
    /// Grade of complexity of the roadworks according to the responsible road operator. For example determined by size, duration and/or traffic disruption.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#RoadworksScaleEnum"></see></summary>
    let RoadworksScaleEnum =
        Namespaced_IRI.parse _namespace_name "RoadworksScaleEnum" |> NamespacedName

    /// <summary>
    /// Grade of complexity of the roadworks according to the responsible road operator. For example determined by size, duration and/or traffic disruption.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasRoadworksScaleEnum"></see></summary>
    let hasRoadworksScaleEnum =
        Namespaced_IRI.parse _namespace_name "hasRoadworksScaleEnum" |> NamespacedName

    /// <summary>
    /// An external identifier for the roadworks
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadworksIdentifier"></see></summary>
    let roadworksIdentifier =
        Namespaced_IRI.parse _namespace_name "roadworksIdentifier" |> NamespacedName

    /// <summary>
    /// Details of the maintenance vehicles involved in the roadworks activity.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasMaintenanceVehicles"></see></summary>
    let hasMaintenanceVehicles =
        Namespaced_IRI.parse _namespace_name "hasMaintenanceVehicles" |> NamespacedName

    /// <summary>
    /// The subjects with which the roadworks are associated.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Subjects"></see></summary>
    let Subjects = Namespaced_IRI.parse _namespace_name "Subjects" |> NamespacedName
    /// <summary>
    ///   <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasSubject"></see>
    /// </summary>
    let hasSubject = Namespaced_IRI.parse _namespace_name "hasSubject" |> NamespacedName

    /// <summary>
    /// An indication of whether the associated instance of a SituationRecord is mobile (e.g. a march or parade moving along a road) or stationary.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasMobility"></see></summary>
    let hasMobility =
        Namespaced_IRI.parse _namespace_name "hasMobility" |> NamespacedName

    /// <summary>
    /// Expected durations of roadworks in general terms.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#RoadworksDurationEnum"></see></summary>
    let RoadworksDurationEnum =
        Namespaced_IRI.parse _namespace_name "RoadworksDurationEnum" |> NamespacedName

    /// <summary>
    /// Indicates in general terms the expected duration of the roadworks.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasRoadworksDuration"></see></summary>
    let hasRoadworksDuration =
        Namespaced_IRI.parse _namespace_name "hasRoadworksDuration" |> NamespacedName

    /// <summary>
    /// Indication of whether the roadworks are considered to be urgent whereby emergency work is being, or needs to be, undertaken to mitigate safety concerns. 'True' indicates they are urgent.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#urgentRoadworks"></see></summary>
    let urgentRoadworks =
        Namespaced_IRI.parse _namespace_name "urgentRoadworks" |> NamespacedName

    /// <summary>
    /// Describes an available public transport alternative to the normal route
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#publicTransportAlternative"></see></summary>
    let publicTransportAlternative =
        Namespaced_IRI.parse _namespace_name "publicTransportAlternative" |> NamespacedName

    /// <summary>
    /// Details of road side assistance required or being given.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#RoadsideAssistance"></see></summary>
    let RoadsideAssistance =
        Namespaced_IRI.parse _namespace_name "RoadsideAssistance" |> NamespacedName

    /// <summary>
    /// Indicates the nature of the road side assistance that will be, is or has been provided.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#RoadsideAssistanceTypeEnum"></see></summary>
    let RoadsideAssistanceTypeEnum =
        Namespaced_IRI.parse _namespace_name "RoadsideAssistanceTypeEnum" |> NamespacedName

    /// <summary>
    /// Indicates the nature of the road side assistance that will be, is or has been provided.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasRoadsideAssistenceTypeEnum"></see></summary>
    let hasRoadsideAssistenceTypeEnum =
        Namespaced_IRI.parse _namespace_name "hasRoadsideAssistenceTypeEnum" |> NamespacedName

    /// <summary>
    /// Levels of severity of a situation as whole assessed by the impact that the situation may have on traffic flow as perceived by the supplier.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#SeverityEnum"></see></summary>
    let SeverityEnum =
        Namespaced_IRI.parse _namespace_name "SeverityEnum" |> NamespacedName

    /// <summary>
    /// Location representing a linear section along a single road with optional directionality defined between two points on the same road. No matter the kind of linear reference it uses, the constraint of using only a single road must be preserved. Associations:
    /// 0..1	TpegLinearLocation
    /// 0..*	AlertCLinear
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#SingleRoadLinearLocation"></see></summary>
    let SingleRoadLinearLocation =
        Namespaced_IRI.parse _namespace_name "SingleRoadLinearLocation" |> NamespacedName

    /// <summary>
    /// A linear section along a single road defined between two points on the same road by a TPEG-Loc structure.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegLinearLocation"></see></summary>
    let TpegLinearLocation =
        Namespaced_IRI.parse _namespace_name "TpegLinearLocation" |> NamespacedName

    /// <summary>
    /// A linear section along a single road defined between two points on the same road by a TPEG-Loc structure.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasTpegLinearLocation"></see></summary>
    let hasTpegLinearLocation =
        Namespaced_IRI.parse _namespace_name "hasTpegLinearLocation" |> NamespacedName

    /// <summary>
    /// An identifiable instance of a traffic/travel situation comprising one or more traffic/travel circumstances which are linked by one or more causal relationships. Each traffic/travel circumstance is represented by a Situation Record.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Situation"></see></summary>
    let Situation = Namespaced_IRI.parse _namespace_name "Situation" |> NamespacedName

    /// <summary>
    /// Management information relating to the data contained within a publication.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasHeaderInformation"></see></summary>
    let hasHeaderInformation =
        Namespaced_IRI.parse _namespace_name "hasHeaderInformation" |> NamespacedName

    /// <summary>
    /// Details of the Situation
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasSituationRecord"></see></summary>
    let hasSituationRecord =
        Namespaced_IRI.parse _namespace_name "hasSituationRecord" |> NamespacedName

    /// <summary>
    /// A publication containing zero or more traffic/travel situations.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#SituationPublication"></see></summary>
    let SituationPublication =
        Namespaced_IRI.parse _namespace_name "SituationPublication" |> NamespacedName

    /// <summary>
    /// Version of Situation Record
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#situationRecordVersion"></see></summary>
    let situationRecordVersion =
        Namespaced_IRI.parse _namespace_name "situationRecordVersion" |> NamespacedName

    /// <summary>
    /// Specification of validity, either explicitly or by a validity time period specification which may be discontinuous.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Validity"></see></summary>
    let Validity = Namespaced_IRI.parse _namespace_name "Validity" |> NamespacedName

    /// <summary>
    /// Specification of validity, either explicitly or by a validity time period specification which may be discontinuous.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasValidity"></see></summary>
    let hasValidity =
        Namespaced_IRI.parse _namespace_name "hasValidity" |> NamespacedName

    /// <summary>
    /// An assessment of the impact that an event or operator action defined by the situation record has on the driving conditions.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasImpact"></see></summary>
    let hasImpact = Namespaced_IRI.parse _namespace_name "hasImpact" |> NamespacedName

    /// <summary>
    ///   <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#situationRecordObservationTime"></see>
    /// </summary>
    let situationRecordObservationTime =
        Namespaced_IRI.parse _namespace_name "situationRecordObservationTime" |> NamespacedName

    /// <summary>
    /// The extent to which the related information may be circulated, according to the recipient type. Recipients must comply with this confidentiality statement. This overrides any confidentiality defined for the situation as a whole in the header information.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#confidentialityOverride"></see></summary>
    let confidentialityOverride =
        Namespaced_IRI.parse _namespace_name "confidentialityOverride" |> NamespacedName

    /// <summary>
    /// An assessment of the degree of likelihood that the reported event will occur.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasProbabilityOfOccurrence"></see></summary>
    let hasProbabilityOfOccurrence =
        Namespaced_IRI.parse _namespace_name "hasProbabilityOfOccurrence" |> NamespacedName

    /// <summary>
    /// The date/time that the SituationRecord object (the first version of the record) was created by the original supplier.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#situationRecordCreationTime"></see></summary>
    let situationRecordCreationTime =
        Namespaced_IRI.parse _namespace_name "situationRecordCreationTime" |> NamespacedName

    /// <summary>
    /// Details of the source from which the information was obtained.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Source"></see></summary>
    let Source = Namespaced_IRI.parse _namespace_name "Source" |> NamespacedName
    /// <summary>
    ///   <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasSource"></see>
    /// </summary>
    let hasSource = Namespaced_IRI.parse _namespace_name "hasSource" |> NamespacedName

    /// <summary>
    /// Indicates, whether this SituationRecord specifies a safety related message according to Commission Delegated Regulation (EU) No 886/2013.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#safetyRelatedMessage"></see></summary>
    let safetyRelatedMessage =
        Namespaced_IRI.parse _namespace_name "safetyRelatedMessage" |> NamespacedName

    /// <summary>
    /// A unique alphanumeric reference (e.g. an external reference or a UUID) of the SituationRecord object (the first version of the record) that was created by the original supplier.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#situationRecordCreationReference"></see></summary>
    let situationRecordCreationReference =
        Namespaced_IRI.parse _namespace_name "situationRecordCreationReference" |> NamespacedName

    /// <summary>
    /// The date/time that the current version of the Situation Record was written into the database of the original supplier in the supply chain.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#situationRecordFirstSupplierVersionTime"></see></summary>
    let situationRecordFirstSupplierVersionTime =
        Namespaced_IRI.parse _namespace_name "situationRecordFirstSupplierVersionTime" |> NamespacedName

    /// <summary>
    /// Has a location reference
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasLocationReference"></see></summary>
    let hasLocationReference =
        Namespaced_IRI.parse _namespace_name "hasLocationReference" |> NamespacedName

    /// <summary>
    /// Levels of severity of a situation as whole assessed by the impact that the situation may have on traffic flow as perceived by the supplier.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasSeverityEnum"></see></summary>
    let hasSeverityEnum =
        Namespaced_IRI.parse _namespace_name "hasSeverityEnum" |> NamespacedName

    /// <summary>
    /// An assessment of the impact that an event or operator action defined by the situation record has on the driving conditions, but on opposite direction.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasImpactOnOppositeDirection"></see></summary>
    let hasImpactOnOppositeDirection =
        Namespaced_IRI.parse _namespace_name "hasImpactOnOppositeDirection" |> NamespacedName

    /// <summary>
    /// The date/time that this current version of the SituationRecord within the situation was written into the database of the supplier which is involved in the data exchange. Identity and version of record are defined by the class stereotype implementation.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#situationRecordVersionTime"></see></summary>
    let situationRecordVersionTime =
        Namespaced_IRI.parse _namespace_name "situationRecordVersionTime" |> NamespacedName

    /// <summary>
    /// Skos Vocabulary
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#SkosClasses"></see></summary>
    let SkosClasses =
        Namespaced_IRI.parse _namespace_name "SkosClasses" |> NamespacedName

    /// <summary>
    /// The name of the organisation which has produced the information relating to this version of the information.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#sourceName"></see></summary>
    let sourceName = Namespaced_IRI.parse _namespace_name "sourceName" |> NamespacedName

    /// <summary>
    /// Language independent textual code or identifier for the organisation or the equipment that has produced the information.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#sourceIdentification"></see></summary>
    let sourceIdentification =
        Namespaced_IRI.parse _namespace_name "sourceIdentification" |> NamespacedName

    /// <summary>
    /// An indication as to whether the source deems the associated information to be reliable/correct. "True" indicates it is deemed reliable.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#reliable"></see></summary>
    let reliable = Namespaced_IRI.parse _namespace_name "reliable" |> NamespacedName

    /// <summary>
    /// Information about the technology used for measuring the data or the method used for obtaining qualitative descriptions relating to this version of the information.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#SourceTypeEnum"></see></summary>
    let SourceTypeEnum =
        Namespaced_IRI.parse _namespace_name "SourceTypeEnum" |> NamespacedName

    /// <summary>
    /// Information about the technology used for measuring the data or the method used for obtaining qualitative descriptions relating to this version of the information.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#sourceType"></see></summary>
    let sourceType = Namespaced_IRI.parse _namespace_name "sourceType" |> NamespacedName

    /// <summary>
    /// EN ISO 3166-1 two-character country code of the source of the information.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#sourceCountry"></see></summary>
    let sourceCountry =
        Namespaced_IRI.parse _namespace_name "sourceCountry" |> NamespacedName

    /// <summary>
    /// Speed management action that is instigated by the network/road operator.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#SpeedManagement"></see></summary>
    let SpeedManagement =
        Namespaced_IRI.parse _namespace_name "SpeedManagement" |> NamespacedName

    /// <summary>
    /// Temporary limit defining the maximum advisory or mandatory speed of vehicles.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#temporarySpeedLimit"></see></summary>
    let temporarySpeedLimit =
        Namespaced_IRI.parse _namespace_name "temporarySpeedLimit" |> NamespacedName

    /// <summary>
    /// Management actions relating to speed.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#SpeedManagementTypeEnum"></see></summary>
    let SpeedManagementTypeEnum =
        Namespaced_IRI.parse _namespace_name "SpeedManagementTypeEnum" |> NamespacedName

    /// <summary>
    /// Type of speed management action instigated by operator.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasSpeedManagementType"></see></summary>
    let hasSpeedManagementType =
        Namespaced_IRI.parse _namespace_name "hasSpeedManagementType" |> NamespacedName

    /// <summary>
    /// The subjects with which the roadworks are associated.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#SubjectTypeOfWorksEnum"></see></summary>
    let SubjectTypeOfWorksEnum =
        Namespaced_IRI.parse _namespace_name "SubjectTypeOfWorksEnum" |> NamespacedName

    /// <summary>
    /// The number of subjects on which the roadworks (construction or maintenance) are being performed.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#numberOfSubjects"></see></summary>
    let numberOfSubjects =
        Namespaced_IRI.parse _namespace_name "numberOfSubjects" |> NamespacedName

    /// <summary>
    /// The subject type of the roadworks (i.e. on what the construction or maintenance work is being performed).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasSubjectTypeOfWorks"></see></summary>
    let hasSubjectTypeOfWorks =
        Namespaced_IRI.parse _namespace_name "hasSubjectTypeOfWorks" |> NamespacedName

    /// <summary>
    /// Indicates that the location is given with a precision which is better than the stated value in metres.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#locationPrecision"></see></summary>
    let locationPrecision =
        Namespaced_IRI.parse _namespace_name "locationPrecision" |> NamespacedName

    /// <summary>
    /// Descriptor which identifies infrastructure to help identify the specific location.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasInfrastructureDescriptor"></see></summary>
    let hasInfrastructureDescriptor =
        Namespaced_IRI.parse _namespace_name "hasInfrastructureDescriptor" |> NamespacedName

    /// <summary>
    /// The sequential number of an exit/entrance ramp from a given location in a given direction (normally used to indicate a specific exit/entrance in a complex junction/intersection).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#sequentialRampNumber"></see></summary>
    let sequentialRampNumber =
        Namespaced_IRI.parse _namespace_name "sequentialRampNumber" |> NamespacedName

    /// <summary>
    /// Supplementary human-readable description of the location
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#locationDescription"></see></summary>
    let locationDescription =
        Namespaced_IRI.parse _namespace_name "locationDescription" |> NamespacedName

    /// <summary>
    /// Identifies the main purpose of the road at the location
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasDirectionPurpose"></see></summary>
    let hasDirectionPurpose =
        Namespaced_IRI.parse _namespace_name "hasDirectionPurpose" |> NamespacedName

    /// <summary>
    /// Descriptor which identifies a geographic characteristic to help identify the specific location
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasGeographicDescriptor"></see></summary>
    let hasGeographicDescriptor =
        Namespaced_IRI.parse _namespace_name "hasGeographicDescriptor" |> NamespacedName

    /// <summary>
    /// This indicates the length (measured in metres) of carriageway (and lanes) affected by the associated traffic element.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#lengthAffected"></see></summary>
    let lengthAffected =
        Namespaced_IRI.parse _namespace_name "lengthAffected" |> NamespacedName

    /// <summary>
    /// Relative position across carriageway
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasPositionOnCarriageway"></see></summary>
    let hasPositionOnCarriageway =
        Namespaced_IRI.parse _namespace_name "hasPositionOnCarriageway" |> NamespacedName

    /// <summary>
    /// Types of linear location.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TPEGLoc01LinearLocationSubtypeEnum"></see></summary>
    let TPEGLoc01LinearLocationSubtypeEnum =
        Namespaced_IRI.parse _namespace_name "TPEGLoc01LinearLocationSubtypeEnum" |> NamespacedName

    /// <summary>
    /// Only for organizational purposes
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegEnumerations"></see></summary>
    let TpegEnumerations =
        Namespaced_IRI.parse _namespace_name "TpegEnumerations" |> NamespacedName

    /// <summary>
    /// OWL-Time is an ontology of temporal concepts, for describing the temporal properties of resources. The vocabulary provided expresses facts about relations among instants and intervals, as well as durations. Time positions and durations may be expressed using either the conventional (Gregorian) calendar and clock, or using another temporal reference system such as Unix-time, geologic time, or different calendars.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TimeClasses"></see></summary>
    let TimeClasses =
        Namespaced_IRI.parse _namespace_name "TimeClasses" |> NamespacedName

    /// <summary>
    /// A descriptor for describing an area location.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegAreaDescriptor"></see></summary>
    let TpegAreaDescriptor =
        Namespaced_IRI.parse _namespace_name "TpegAreaDescriptor" |> NamespacedName

    /// <summary>
    /// Descriptors for describing area locations.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegLoc03AreaDescriptorSubtypeEnum"></see></summary>
    let TpegLoc03AreaDescriptorSubtypeEnum =
        Namespaced_IRI.parse _namespace_name "TpegLoc03AreaDescriptorSubtypeEnum" |> NamespacedName

    /// <summary>
    /// The nature of the descriptor used to define the location under consideration (derived from the TPEG Loc table 03).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tpegAreaDescriptorType"></see></summary>
    let tpegAreaDescriptorType =
        Namespaced_IRI.parse _namespace_name "tpegAreaDescriptorType" |> NamespacedName

    /// <summary>
    /// A collection of information providing descriptive references to locations using the TPEG-Loc location referencing approach.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegDescriptor"></see></summary>
    let TpegDescriptor =
        Namespaced_IRI.parse _namespace_name "TpegDescriptor" |> NamespacedName

    /// <summary>
    /// Height information which provides additional discrimination for the applicable area.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegHeight"></see></summary>
    let TpegHeight = Namespaced_IRI.parse _namespace_name "TpegHeight" |> NamespacedName

    /// <summary>
    /// Height information which provides additional discrimination for the applicable area.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasTpegHeight"></see></summary>
    let hasTpegHeight =
        Namespaced_IRI.parse _namespace_name "hasTpegHeight" |> NamespacedName

    /// <summary>
    /// Types of area.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegLoc01AreaLocationSubtypeEnum"></see></summary>
    let TpegLoc01AreaLocationSubtypeEnum =
        Namespaced_IRI.parse _namespace_name "TpegLoc01AreaLocationSubtypeEnum" |> NamespacedName

    /// <summary>
    /// The type of TPEG location.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tpegAreaLocationType"></see></summary>
    let tpegAreaLocationType =
        Namespaced_IRI.parse _namespace_name "tpegAreaLocationType" |> NamespacedName

    /// <summary>
    /// Tpeg location
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegLoc"></see></summary>
    let TpegLoc = Namespaced_IRI.parse _namespace_name "TpegLoc" |> NamespacedName

    /// <summary>
    /// A text string which describes or elaborates the location. Here is used for values distinct to RoadNumbers or AdministrativeUnit.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#descriptorString"></see></summary>
    let descriptorString =
        Namespaced_IRI.parse _namespace_name "descriptorString" |> NamespacedName

    /// <summary>
    /// Describes or elaborates the location. Here is used for values from RoadNumber or AdministrativeUnit.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#descriptor"></see></summary>
    let descriptor = Namespaced_IRI.parse _namespace_name "descriptor" |> NamespacedName

    /// <summary>
    /// A point on the road network which is framed between two other points on the same road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegFramedPoint"></see></summary>
    let TpegFramedPoint =
        Namespaced_IRI.parse _namespace_name "TpegFramedPoint" |> NamespacedName

    /// <summary>
    /// Types of points on the road network framed by two other points on the same road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegLoc01FramedPointLocationSubtypeEnum"></see></summary>
    let TpegLoc01FramedPointLocationSubtypeEnum =
        Namespaced_IRI.parse _namespace_name "TpegLoc01FramedPointLocationSubtypeEnum" |> NamespacedName

    /// <summary>
    /// The type of TPEG location.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tpegFramedPointLocationType"></see></summary>
    let tpegFramedPointLocationType =
        Namespaced_IRI.parse _namespace_name "tpegFramedPointLocationType" |> NamespacedName

    /// <summary>
    /// The location at the down stream end of the linear section of road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasTpegPointTo"></see></summary>
    let hasTpegPointTo =
        Namespaced_IRI.parse _namespace_name "hasTpegPointTo" |> NamespacedName

    /// <summary>
    /// The location at the up stream end of the linear section of road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasTpegPointFrom"></see></summary>
    let hasTpegPointFrom =
        Namespaced_IRI.parse _namespace_name "hasTpegPointFrom" |> NamespacedName

    /// <summary>
    /// A point on the road network which is not a road junction point.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegNonJunctionPoint"></see></summary>
    let TpegNonJunctionPoint =
        Namespaced_IRI.parse _namespace_name "TpegNonJunctionPoint" |> NamespacedName

    /// <summary>
    /// A single non-junction point on the road network which is framed between two other specified points on the road network.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasTpegFramedPoint"></see></summary>
    let hasTpegFramedPoint =
        Namespaced_IRI.parse _namespace_name "hasTpegFramedPoint" |> NamespacedName

    /// <summary>
    /// A geometric area defined by a centre point and a radius.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegGeometricArea"></see></summary>
    let TpegGeometricArea =
        Namespaced_IRI.parse _namespace_name "TpegGeometricArea" |> NamespacedName

    /// <summary>
    /// Name of area.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasTpegAreaDescriptor"></see></summary>
    let hasTpegAreaDescriptor =
        Namespaced_IRI.parse _namespace_name "hasTpegAreaDescriptor" |> NamespacedName

    /// <summary>
    /// The radius of the corresponding circular area
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#radius"></see></summary>
    let radius = Namespaced_IRI.parse _namespace_name "radius" |> NamespacedName

    /// <summary>
    /// Centre point of a circular geometric area.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasCentrePoint"></see></summary>
    let hasCentrePoint =
        Namespaced_IRI.parse _namespace_name "hasCentrePoint" |> NamespacedName

    /// <summary>
    /// A measurement of height in metres
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#height"></see></summary>
    let height = Namespaced_IRI.parse _namespace_name "height" |> NamespacedName

    /// <summary>
    /// Types of height.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegLoc04HeightTypeEnum"></see></summary>
    let TpegLoc04HeightTypeEnum =
        Namespaced_IRI.parse _namespace_name "TpegLoc04HeightTypeEnum" |> NamespacedName

    /// <summary>
    /// A descriptive identification of relative height using TPEG-Loc location referencing.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tpegHeightType"></see></summary>
    let tpegHeightType =
        Namespaced_IRI.parse _namespace_name "tpegHeightType" |> NamespacedName

    /// <summary>
    /// A descriptor for describing a junction by defining the intersecting roads.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegIlcPointDescriptor"></see></summary>
    let TpegIlcPointDescriptor =
        Namespaced_IRI.parse _namespace_name "TpegIlcPointDescriptor" |> NamespacedName

    /// <summary>
    /// Descriptors for describing a junction by identifying the intersecting roads at a road junction.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegLoc03IlcPointDescriptorSubtypeEnum"></see></summary>
    let TpegLoc03IlcPointDescriptorSubtypeEnum =
        Namespaced_IRI.parse _namespace_name "TpegLoc03IlcPointDescriptorSubtypeEnum" |> NamespacedName

    /// <summary>
    /// The nature of the descriptor used to define the location under consideration (derived from the TPEG Loc table 03).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tpegIlcPointDescriptorType"></see></summary>
    let tpegIlcPointDescriptorType =
        Namespaced_IRI.parse _namespace_name "tpegIlcPointDescriptorType" |> NamespacedName

    /// <summary>
    /// A descriptor for describing a point location.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegPointDescriptor"></see></summary>
    let TpegPointDescriptor =
        Namespaced_IRI.parse _namespace_name "TpegPointDescriptor" |> NamespacedName

    /// <summary>
    /// A point on the road network which is a road junction point.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegJunction"></see></summary>
    let TpegJunction =
        Namespaced_IRI.parse _namespace_name "TpegJunction" |> NamespacedName

    /// <summary>
    /// A descriptor for describing a point at a junction on a road network.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegJunctionPointDescriptor"></see></summary>
    let TpegJunctionPointDescriptor =
        Namespaced_IRI.parse _namespace_name "TpegJunctionPointDescriptor" |> NamespacedName

    /// <summary>
    /// A name which identifies a junction point on the road network
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasTpegJunctionPointDescriptor"></see></summary>
    let hasTpegJunctionPointDescriptor =
        Namespaced_IRI.parse _namespace_name "hasTpegJunctionPointDescriptor" |> NamespacedName

    /// <summary>
    /// A descriptor for describing a junction by identifying the intersecting roads at a road junction.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasTpegIlcPointDescriptor"></see></summary>
    let hasTpegIlcPointDescriptor =
        Namespaced_IRI.parse _namespace_name "hasTpegIlcPointDescriptor" |> NamespacedName

    /// <summary>
    /// Descriptors for describing a point at a road junction.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegLoc03JunctionPointDescriptorSubtypeEnum"></see></summary>
    let TpegLoc03JunctionPointDescriptorSubtypeEnum =
        Namespaced_IRI.parse _namespace_name "TpegLoc03JunctionPointDescriptorSubtypeEnum" |> NamespacedName

    /// <summary>
    /// The nature of the descriptor used to define the location under consideration (derived from the TPEG Loc table 03).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tpegJunctionPointDescriptorType"></see></summary>
    let tpegJunctionPointDescriptorType =
        Namespaced_IRI.parse _namespace_name "tpegJunctionPointDescriptorType" |> NamespacedName

    /// <summary>
    /// The type of TPEG location.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tpegLinearLocationType"></see></summary>
    let tpegLinearLocationType =
        Namespaced_IRI.parse _namespace_name "tpegLinearLocationType" |> NamespacedName

    /// <summary>
    /// The direction of traffic flow.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tpegDirection"></see></summary>
    let tpegDirection =
        Namespaced_IRI.parse _namespace_name "tpegDirection" |> NamespacedName

    /// <summary>
    /// Types of simple point.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegLoc01SimplePointLocationSubtypeEnum"></see></summary>
    let TpegLoc01SimplePointLocationSubtypeEnum =
        Namespaced_IRI.parse _namespace_name "TpegLoc01SimplePointLocationSubtypeEnum" |> NamespacedName

    /// <summary>
    /// Descriptors other than junction names and road descriptors which can help to identify the location of points on the road network.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegLoc03OtherPointDescriptorSubtypeEnum"></see></summary>
    let TpegLoc03OtherPointDescriptorSubtypeEnum =
        Namespaced_IRI.parse _namespace_name "TpegLoc03OtherPointDescriptorSubtypeEnum" |> NamespacedName

    /// <summary>
    /// An area defined by a well-known name.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegNamedOnlyArea"></see></summary>
    let TpegNamedOnlyArea =
        Namespaced_IRI.parse _namespace_name "TpegNamedOnlyArea" |> NamespacedName

    /// <summary>
    /// General descriptor for describing a point.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegOtherPointDescriptor"></see></summary>
    let TpegOtherPointDescriptor =
        Namespaced_IRI.parse _namespace_name "TpegOtherPointDescriptor" |> NamespacedName

    /// <summary>
    /// A descriptive name which helps to identify the non-junction point. At least one descriptor must identify the road on which the point is located, i.e. must be of type 'linkName' or 'localLinkName'.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasTpegOtherPointDescriptor"></see></summary>
    let hasTpegOtherPointDescriptor =
        Namespaced_IRI.parse _namespace_name "hasTpegOtherPointDescriptor" |> NamespacedName

    /// <summary>
    /// The nature of the descriptor used to define the location under consideration (derived from the TPEG Loc table 03).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tpegOtherPointDescriptorType"></see></summary>
    let tpegOtherPointDescriptorType =
        Namespaced_IRI.parse _namespace_name "tpegOtherPointDescriptorType" |> NamespacedName

    /// <summary>
    /// A point on the road network which is not bounded by any other points on the road network.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegSimplePoint"></see></summary>
    let TpegSimplePoint =
        Namespaced_IRI.parse _namespace_name "TpegSimplePoint" |> NamespacedName

    /// <summary>
    /// The type of TPEG location.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tpegSimplePointLocationType"></see></summary>
    let tpegSimplePointLocationType =
        Namespaced_IRI.parse _namespace_name "tpegSimplePointLocationType" |> NamespacedName

    /// <summary>
    /// A single point defined by a coordinate set and TPEG descriptors.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasTpegPoint"></see></summary>
    let hasTpegPoint =
        Namespaced_IRI.parse _namespace_name "hasTpegPoint" |> NamespacedName

    /// <summary>
    /// Types of constriction to which traffic is subjected as a result of an event.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TrafficConstrictionTypeEnum"></see></summary>
    let TrafficConstrictionTypeEnum =
        Namespaced_IRI.parse _namespace_name "TrafficConstrictionTypeEnum" |> NamespacedName

    /// <summary>
    /// Types of the constriction to which traffic is subjected as a result of an event.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasTrafficConstrictionTypeEnum"></see></summary>
    let hasTrafficConstrictionTypeEnum =
        Namespaced_IRI.parse _namespace_name "hasTrafficConstrictionTypeEnum" |> NamespacedName

    /// <summary>
    /// Types of public transport information.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TransitServiceInformationEnum"></see></summary>
    let TransitServiceInformationEnum =
        Namespaced_IRI.parse _namespace_name "TransitServiceInformationEnum" |> NamespacedName

    /// <summary>
    /// A specification of periods of validity defined by overall bounding start and end times and the possible intersection of valid periods with exception periods (exception periods overriding valid periods).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#validityTimeSpecification"></see></summary>
    let validityTimeSpecification =
        Namespaced_IRI.parse _namespace_name "validityTimeSpecification" |> NamespacedName

    /// <summary>
    /// Values of validity status that can be assigned to a described event, action or item
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ValidityStatusEnum"></see></summary>
    let ValidityStatusEnum =
        Namespaced_IRI.parse _namespace_name "ValidityStatusEnum" |> NamespacedName

    /// <summary>
    /// Specification of validity, either explicitly overriding the validity time specification or confirming it.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasValidityStatus"></see></summary>
    let hasValidityStatus =
        Namespaced_IRI.parse _namespace_name "hasValidityStatus" |> NamespacedName

    /// <summary>
    ///   <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Vehicle"></see>
    /// </summary>
    let Vehicle = Namespaced_IRI.parse _namespace_name "Vehicle" |> NamespacedName

    /// <summary>
    /// The status of a vehicle.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#VehicleStatusEnum"></see></summary>
    let VehicleStatusEnum =
        Namespaced_IRI.parse _namespace_name "VehicleStatusEnum" |> NamespacedName

    /// <summary>
    /// Vehicle status.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasVehicleStatus"></see></summary>
    let hasVehicleStatus =
        Namespaced_IRI.parse _namespace_name "hasVehicleStatus" |> NamespacedName

    /// <summary>
    /// The characteristics of a vehicle, e.g. lorry of gross weight greater than 30 tonnes.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#VehicleCharacteristics"></see></summary>
    let VehicleCharacteristics =
        Namespaced_IRI.parse _namespace_name "VehicleCharacteristics" |> NamespacedName

    /// <summary>
    /// The characteristics of a vehicle, e.g. lorry of gross weight greater than 30 tonnes.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasVehicleCharacteristics"></see></summary>
    let hasVehicleCharacteristics =
        Namespaced_IRI.parse _namespace_name "hasVehicleCharacteristics" |> NamespacedName

    /// <summary>
    /// A measured or calculated value of the flow rate of vehicles.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#VehicleFlowValue"></see></summary>
    let VehicleFlowValue =
        Namespaced_IRI.parse _namespace_name "VehicleFlowValue" |> NamespacedName

    /// <summary>
    /// A value of vehicle flow rate expressed in vehicles per hour.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#vehicleFlowRate"></see></summary>
    let vehicleFlowRate =
        Namespaced_IRI.parse _namespace_name "vehicleFlowRate" |> NamespacedName

    /// <summary>
    /// Types of vehicle.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#VehicleTypeEnum"></see></summary>
    let VehicleTypeEnum =
        Namespaced_IRI.parse _namespace_name "VehicleTypeEnum" |> NamespacedName

    /// <summary>
    /// Vehicle type.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasVehicleTypeEnum"></see></summary>
    let hasVehicleTypeEnum =
        Namespaced_IRI.parse _namespace_name "hasVehicleTypeEnum" |> NamespacedName

    /// <summary>
    /// Types of obstructions involving vehicles.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#VehicleObstructionTypeEnum"></see></summary>
    let VehicleObstructionTypeEnum =
        Namespaced_IRI.parse _namespace_name "VehicleObstructionTypeEnum" |> NamespacedName

    /// <summary>
    /// Characterization of an obstruction on the road caused by one or more vehicles.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasVehicleObstructionTypeEnum"></see></summary>
    let hasVehicleObstructionTypeEnum =
        Namespaced_IRI.parse _namespace_name "hasVehicleObstructionTypeEnum" |> NamespacedName

    /// <summary>
    /// Types of road surface conditions which are related to the weather.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#WeatherRelatedRoadConditionType"></see></summary>
    let WeatherRelatedRoadConditionType =
        Namespaced_IRI.parse _namespace_name "WeatherRelatedRoadConditionType" |> NamespacedName

    /// <summary>
    /// The type of road surface condition that is related to the weather which is affecting the driving conditions.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasWeatherRelatedRoadConditionTypeEnum"></see></summary>
    let hasWeatherRelatedRoadConditionTypeEnum =
        Namespaced_IRI.parse _namespace_name "hasWeatherRelatedRoadConditionTypeEnum" |> NamespacedName

    /// <summary>
    /// Winter driving management action that is instigated by the network/road operator.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#WinterDrivingManagement"></see></summary>
    let WinterDrivingManagement =
        Namespaced_IRI.parse _namespace_name "WinterDrivingManagement" |> NamespacedName

    /// <summary>
    /// Type of winter equipment management action instigated by operator.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#WinterEquipmentManagementTypeEnum"></see></summary>
    let WinterEquipmentManagementTypeEnum =
        Namespaced_IRI.parse _namespace_name "WinterEquipmentManagementTypeEnum" |> NamespacedName

    /// <summary>
    /// ALERT-C name of a direction e.g. Brussels -&gt; Lille.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#alertCDirectionNamed"></see></summary>
    let alertCDirectionNamed =
        Namespaced_IRI.parse _namespace_name "alertCDirectionNamed" |> NamespacedName

    /// <summary>
    /// Name of ALERT-C location.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#alertCLocationName"></see></summary>
    let alertCLocationName =
        Namespaced_IRI.parse _namespace_name "alertCLocationName" |> NamespacedName

    /// <summary>
    /// The allowed delivery channel.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#allowedDeliveryChannel"></see></summary>
    let allowedDeliveryChannel =
        Namespaced_IRI.parse _namespace_name "allowedDeliveryChannel" |> NamespacedName

    /// <summary>
    /// For organizational purposes
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#geoSparqlDataProperties"></see></summary>
    let geoSparqlDataProperties =
        Namespaced_IRI.parse _namespace_name "geoSparqlDataProperties" |> NamespacedName

    /// <summary>
    /// For organizational purposes
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#importedDataProperties"></see></summary>
    let importedDataProperties =
        Namespaced_IRI.parse _namespace_name "importedDataProperties" |> NamespacedName

    /// <summary>
    /// Only for organizational purposes. GeoSparql object properties
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#geoSparqlObjectProperties"></see></summary>
    let geoSparqlObjectProperties =
        Namespaced_IRI.parse _namespace_name "geoSparqlObjectProperties" |> NamespacedName

    /// <summary>
    /// Only for organizational purposes. Imported object properties
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#importedObjectProperties"></see></summary>
    let importedObjectProperties =
        Namespaced_IRI.parse _namespace_name "importedObjectProperties" |> NamespacedName

    /// <summary>
    /// For organizational purposes. Properties of the WGS84 Geo Positioning by World Wide Web Consortium (W3C). A vocabulary for representing latitude, longitude and altitude information in the WGS84 geodetic reference datum. WGS stands for the World Geodetic Survey.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#geo_WGS84"></see></summary>
    let geo_WGS84 = Namespaced_IRI.parse _namespace_name "geo_WGS84" |> NamespacedName
    /// <summary>
    /// For organizational purposes. Properties of the ontology for the representation of Geographical Objects https://datos.ign.es/def/geo_core
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#geo_core"></see></summary>
    let geo_core = Namespaced_IRI.parse _namespace_name "geo_core" |> NamespacedName

    /// <summary>
    /// ALERT-C Area
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAlertCArea"></see></summary>
    let hasAlertCArea =
        Namespaced_IRI.parse _namespace_name "hasAlertCArea" |> NamespacedName

    /// <summary>
    /// The linear location expressed using AlertC. Multiple instances of AlertCLinear shall represent the same real-world geographic feature.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAlertCLinear"></see></summary>
    let hasAlertCLinear =
        Namespaced_IRI.parse _namespace_name "hasAlertCLinear" |> NamespacedName

    /// <summary>
    /// The point location expressed using AlertC. Multiple instances of AlertCPoint shall represent the same real-world geographic feature.They should represent the same point using different location tables.
    /// PointLocation is associated to AlertCPoint with cardinality 0..*
    /// ALERT-C point
    /// A single point on the road network defined by reference to a pre-defined ALERT-C location table and which has an associated direction of traffic flow.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAlertCPoint"></see></summary>
    let hasAlertCPoint =
        Namespaced_IRI.parse _namespace_name "hasAlertCPoint" |> NamespacedName

    /// <summary>
    /// Supplementary positional information which details carriageway and lane locations. Several instances may exist where the element being described extends over more than one carriageway.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasCarriageway"></see></summary>
    let hasCarriageway =
        Namespaced_IRI.parse _namespace_name "hasCarriageway" |> NamespacedName

    /// <summary>
    /// Deliberate human action of either a public disorder nature or of a situation alert type which could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasDisturbanceActivityTypeEnum"></see></summary>
    let hasDisturbanceActivityTypeEnum =
        Namespaced_IRI.parse _namespace_name "hasDisturbanceActivityTypeEnum" |> NamespacedName

    /// <summary>
    /// A boundary of internal patches of a polygonal surface consisting of a ring feature
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasGmlInteriorLinearRing"></see></summary>
    let hasGmlInteriorLinearRing =
        Namespaced_IRI.parse _namespace_name "hasGmlInteriorLinearRing" |> NamespacedName

    /// <summary>
    /// Indicates a specific lane or group of lanes.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasLane"></see></summary>
    let hasLane = Namespaced_IRI.parse _namespace_name "hasLane" |> NamespacedName

    /// <summary>
    /// Specifies a linear section along a linear element where the linear element is either a part of or the whole of a linear object (i.e. a road), consistent with ISO 19148 definitions.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasLinearWithinLinearElement"></see></summary>
    let hasLinearWithinLinearElement =
        Namespaced_IRI.parse _namespace_name "hasLinearWithinLinearElement" |> NamespacedName

    /// <summary>
    /// It is location reference of ...
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#isLocationReferenceOf"></see></summary>
    let isLocationReferenceOf =
        Namespaced_IRI.parse _namespace_name "isLocationReferenceOf" |> NamespacedName

    /// <summary>
    /// The actions of the maintenance vehicles associated with the roadworks activities.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasMaintenanceVehicleActions"></see></summary>
    let hasMaintenanceVehicleActions =
        Namespaced_IRI.parse _namespace_name "hasMaintenanceVehicleActions" |> NamespacedName

    /// <summary>
    ///   <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOverallEndTime"></see>
    /// </summary>
    let hasOverallEndTime =
        Namespaced_IRI.parse _namespace_name "hasOverallEndTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOverallStartTime"></see>
    /// </summary>
    let hasOverallStartTime =
        Namespaced_IRI.parse _namespace_name "hasOverallStartTime" |> NamespacedName

    /// <summary>
    /// PointLocation is associated to PointAlongLinearElement with cardinality 0..*
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasPointAlongLinearElement"></see></summary>
    let hasPointAlongLinearElement =
        Namespaced_IRI.parse _namespace_name "hasPointAlongLinearElement" |> NamespacedName

    /// <summary>
    /// Specifies types of public events.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasPublicEventType"></see></summary>
    let hasPublicEventType =
        Namespaced_IRI.parse _namespace_name "hasPublicEventType" |> NamespacedName

    /// <summary>
    /// Specifies a referent on a linear object that has a known location such as a node, a reference marker (e.g. a marker-post), an intersection etc.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasReferent"></see></summary>
    let hasReferent =
        Namespaced_IRI.parse _namespace_name "hasReferent" |> NamespacedName

    /// <summary>
    /// Information on a set of one or more roads. The location could correspond to a part of the road identified, the whole stretch of road identified, or a combination of multiple road sections.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasRoadInformation"></see></summary>
    let hasRoadInformation =
        Namespaced_IRI.parse _namespace_name "hasRoadInformation" |> NamespacedName

    /// <summary>
    /// Management actions relating to road, carriageway or lane usage.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasRoadOrCarriagewayOrLaneManagementType"></see></summary>
    let hasRoadOrCarriagewayOrLaneManagementType =
        Namespaced_IRI.parse _namespace_name "hasRoadOrCarriagewayOrLaneManagementType" |> NamespacedName

    /// <summary>
    /// traffic/travel situations.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasSituation"></see></summary>
    let hasSituation =
        Namespaced_IRI.parse _namespace_name "hasSituation" |> NamespacedName

    /// <summary>
    /// The vehicle involved in the accident.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasVehiclesInvolved"></see></summary>
    let hasVehiclesInvolved =
        Namespaced_IRI.parse _namespace_name "hasVehiclesInvolved" |> NamespacedName

    /// <summary>
    /// Type of winter equipment management action instigated by operator.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasWinterEquipmentManagementType"></see></summary>
    let hasWinterEquipmentManagementType =
        Namespaced_IRI.parse _namespace_name "hasWinterEquipmentManagementType" |> NamespacedName

    /// <summary>
    /// Only for organizational purposes. Qudt object properties
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#qudtObjectProperties"></see></summary>
    let qudtObjectProperties =
        Namespaced_IRI.parse _namespace_name "qudtObjectProperties" |> NamespacedName

    /// <summary>
    /// For organizational purposes
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#skosDataProperties"></see></summary>
    let skosDataProperties =
        Namespaced_IRI.parse _namespace_name "skosDataProperties" |> NamespacedName

    /// <summary>
    /// Only for organizational purposes. Skos object properties
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#skosObjectProperties"></see></summary>
    let skosObjectProperties =
        Namespaced_IRI.parse _namespace_name "skosObjectProperties" |> NamespacedName

    /// <summary>
    /// Unique code within the ALERT-C location table which identifies the specific point, linear or area location.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#specificLocation"></see></summary>
    let specificLocation =
        Namespaced_IRI.parse _namespace_name "specificLocation" |> NamespacedName

    /// <summary>
    /// For organizational purposes
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#timeDataProperties"></see></summary>
    let timeDataProperties =
        Namespaced_IRI.parse _namespace_name "timeDataProperties" |> NamespacedName

    /// <summary>
    /// Only for organizational purposes. Time object properties
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#timeObjectProperties"></see></summary>
    let timeObjectProperties =
        Namespaced_IRI.parse _namespace_name "timeObjectProperties" |> NamespacedName
