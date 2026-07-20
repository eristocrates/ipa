namespace http.cef.uv.es.lodroadtran18.def.transporte.dtx_srti.hash

open DoxAletheia

module dtx_srti =
    let _namespace_name = "http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// An air crash adjacent to the roadway which may cause traffic disruption.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#airCrash"></see></summary>
    let airCrash = _prefix "airCrash"
    /// <summary>
    /// Children on the roadway which may cause traffic disruption.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#childrenOnRoadway"></see></summary>
    let childrenOnRoadway = _prefix "childrenOnRoadway"
    /// <summary>
    /// Clearance work associated with an earlier traffic problem which may cause traffic disruption.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#clearanceWork"></see></summary>
    let clearanceWork = _prefix "clearanceWork"
    /// <summary>
    /// Cyclists on the roadway which may cause traffic disruption.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#cyclistsOnRoadway"></see></summary>
    let cyclistsOnRoadway = _prefix "cyclistsOnRoadway"
    /// <summary>
    /// Incidents are chance occurrences involving vehicles from the traffic stream, which could present potential hazards to road users.  This item excludes accidents.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#incident"></see></summary>
    let incident = _prefix "incident"
    /// <summary>
    /// The road may be obstructed or traffic hindered due to objects laying on the roadway.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#objectOnTheRoad"></see></summary>
    let objectOnTheRoad = _prefix "objectOnTheRoad"
    /// <summary>
    /// Other. Other than as defined in this enumeration.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#other"></see></summary>
    let other = _prefix "other"
    /// <summary>
    /// People on the roadway which may cause traffic disruption.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#peopleOnRoadway"></see></summary>
    let peopleOnRoadway = _prefix "peopleOnRoadway"
    /// <summary>
    /// A rail crash adjacent to the roadway which may cause traffic disruption.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#railCrash"></see></summary>
    let railCrash = _prefix "railCrash"
    /// <summary>
    /// Work is being undertaken by emergency services which may present a hazard to road users.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#rescueAndRecoveryWork"></see></summary>
    let rescueAndRecoveryWork = _prefix "rescueAndRecoveryWork"
    /// <summary>
    /// Spillage of transported goods on the roadway which may cause traffic disruption.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#shedLoad"></see></summary>
    let shedLoad = _prefix "shedLoad"
    /// <summary>
    /// Includes all situations where a spillage has occurred on the roadway due to an earlier incident.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#spillageOnTheRoad"></see></summary>
    let spillageOnTheRoad = _prefix "spillageOnTheRoad"
    /// <summary>
    /// An accident area which has not been protected and may present a hazard to road users.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#unprotectedAccidentArea"></see></summary>
    let unprotectedAccidentArea = _prefix "unprotectedAccidentArea"
    /// <summary>
    /// Maintenance of road, associated infrastructure or equipments.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#maintenanceWork"></see></summary>
    let maintenanceWork = _prefix "maintenanceWork"
    /// <summary>
    /// Repair work to road, associated infrastructure or equipments.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#repairWork"></see></summary>
    let repairWork = _prefix "repairWork"
    /// <summary>
    /// Work associated with relaying or renewal of worn-out road surface (pavement).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#resurfacingWork"></see></summary>
    let resurfacingWork = _prefix "resurfacingWork"
    /// <summary>
    /// Striping and repainting of road markings, plus placement or replacement of reflecting studs (cats' eyes).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadMarkingWork"></see></summary>
    let roadMarkingWork = _prefix "roadMarkingWork"
    /// <summary>
    /// Snowploughs or other similar mechanical devices in use to clear snow from the road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#snowploughsInUse"></see></summary>
    let snowploughsInUse = _prefix "snowploughsInUse"
    /// <summary>
    /// Value measured vertically above the reference ellipsoid
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ellipsoidalHeight"></see></summary>
    let ellipsoidalHeight = _prefix "ellipsoidalHeight"
    /// <summary>
    /// Height type corresponding a value measured along direction of gravity above the reference geoid i.e. equipotential surface of the Earth's gravity field which globally approximates mean sea level.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#gravityRelatedHeight"></see></summary>
    let gravityRelatedHeight = _prefix "gravityRelatedHeight"
    /// <summary>
    /// Height type corresponding to value masured vertically above the ground level at this point.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#relativeHeight"></see></summary>
    let relativeHeight = _prefix "relativeHeight"
    /// <summary>
    /// Dissemination of the information is extremely urgent.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#extremelyUrgent"></see></summary>
    let extremelyUrgent = _prefix "extremelyUrgent"
    /// <summary>
    /// Dissemination of the information is of normal urgency.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#normalUrgency"></see></summary>
    let normalUrgency = _prefix "normalUrgency"
    /// <summary>
    /// Dissemination of the information is urgent.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#urgent"></see></summary>
    let urgent = _prefix "urgent"
    /// <summary>
    /// A patrol of an automobile club.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#automobileClubPatrol"></see></summary>
    let automobileClubPatrol = _prefix "automobileClubPatrol"
    /// <summary>
    /// A camera observation (either still or video camera).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#cameraObservation"></see></summary>
    let cameraObservation = _prefix "cameraObservation"
    /// <summary>
    /// An operator of freight vehicles.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#freightVehicleOperator"></see></summary>
    let freightVehicleOperator = _prefix "freightVehicleOperator"
    /// <summary>
    /// A station dedicated to the monitoring of the road network by processing inductive loop information.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#inductionLoopMonitoringStation"></see></summary>
    let inductionLoopMonitoringStation = _prefix "inductionLoopMonitoringStation"
    /// <summary>
    /// A station dedicated to the monitoring of the road network by processing infrared image information.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#infraredMonitoringStation"></see></summary>
    let infraredMonitoringStation = _prefix "infraredMonitoringStation"
    /// <summary>
    /// A station dedicated to the monitoring of the road network by processing microwave information.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#microwaveMonitoringStation"></see></summary>
    let microwaveMonitoringStation = _prefix "microwaveMonitoringStation"
    /// <summary>
    /// A caller using a mobile telephone (who may or may not be on the road network).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#mobileTelephoneCaller"></see></summary>
    let mobileTelephoneCaller = _prefix "mobileTelephoneCaller"
    /// <summary>
    /// Emergency service patrols other than police.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#nonPoliceEmergencyServicePatrol"></see></summary>
    let nonPoliceEmergencyServicePatrol = _prefix "nonPoliceEmergencyServicePatrol"
    /// <summary>
    /// Personnel from a vehicle belonging to the road operator or authority or any emergency service, including authorised breakdown service organisations.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#otherOfficialVehicle"></see></summary>
    let otherOfficialVehicle = _prefix "otherOfficialVehicle"
    /// <summary>
    /// A police patrol.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#policePatrol"></see></summary>
    let policePatrol = _prefix "policePatrol"
    /// <summary>
    /// A private breakdown service.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#privateBreakdownService"></see></summary>
    let privateBreakdownService = _prefix "privateBreakdownService"
    /// <summary>
    /// A utility organisation, either public or private.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#publicAndPrivateUtilities"></see></summary>
    let publicAndPrivateUtilities = _prefix "publicAndPrivateUtilities"
    /// <summary>
    /// A motorist who is an officially registered observer.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#registeredMotoristObserver"></see></summary>
    let registeredMotoristObserver = _prefix "registeredMotoristObserver"
    /// <summary>
    /// A road authority.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadAuthorities"></see></summary>
    let roadAuthorities = _prefix "roadAuthorities"
    /// <summary>
    /// A patrol of the road operator or authority.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadOperatorPatrol"></see></summary>
    let roadOperatorPatrol = _prefix "roadOperatorPatrol"
    /// <summary>
    /// A caller who is using an emergency roadside telephone.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadsideTelephoneCaller"></see></summary>
    let roadsideTelephoneCaller = _prefix "roadsideTelephoneCaller"
    /// <summary>
    /// A spotter aircraft of an organisation specifically assigned to the monitoring of the traffic network.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#spotterAircraft"></see></summary>
    let spotterAircraft = _prefix "spotterAircraft"
    /// <summary>
    /// A station, usually automatic, dedicated to the monitoring of the road network.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#trafficMonitoringStation"></see></summary>
    let trafficMonitoringStation = _prefix "trafficMonitoringStation"
    /// <summary>
    /// An operator of a transit service, e.g. bus link operator.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#transitOperator"></see></summary>
    let transitOperator = _prefix "transitOperator"
    /// <summary>
    /// A specially equipped vehicle used to provide measurements.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#vehicleProbeMeasurement"></see></summary>
    let vehicleProbeMeasurement = _prefix "vehicleProbeMeasurement"
    /// <summary>
    /// A station dedicated to the monitoring of the road network by processing video image information.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#videoProcessingMonitoringStation"></see></summary>
    let videoProcessingMonitoringStation = _prefix "videoProcessingMonitoringStation"
    /// <summary>
    /// Against line direction
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#againstLineDirection"></see></summary>
    let againstLineDirection = _prefix "againstLineDirection"
    /// <summary>
    /// Both directions.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#bothDirections"></see></summary>
    let bothDirections = _prefix "bothDirections"
    /// <summary>
    /// No orientation or unknown
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#noOrientationOrUnknown"></see></summary>
    let noOrientationOrUnknown = _prefix "noOrientationOrUnknown"
    /// <summary>
    /// With line direction
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#withLineDirection"></see></summary>
    let withLineDirection = _prefix "withLineDirection"
    /// <summary>
    /// Allow emergency vehicles to pass
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#allowEmergencyVehiclesToPass"></see></summary>
    let allowEmergencyVehiclesToPass = _prefix "allowEmergencyVehiclesToPass"
    /// <summary>
    /// Approach with care
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#approachWithCare"></see></summary>
    let approachWithCare = _prefix "approachWithCare"
    /// <summary>
    /// Avoid the area
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#avoidTheArea"></see></summary>
    let avoidTheArea = _prefix "avoidTheArea"

    /// <summary>
    /// Close all windows turn off heater and vents
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#closeAllWindowsTurnOffHeaterAndVents"></see></summary>
    let closeAllWindowsTurnOffHeaterAndVents =
        _prefix "closeAllWindowsTurnOffHeaterAndVents"

    /// <summary>
    /// Cross junction with care
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#crossJunctionWithCare"></see></summary>
    let crossJunctionWithCare = _prefix "crossJunctionWithCare"
    /// <summary>
    /// Do not allow unnecessary gaps
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#doNotAllowUnnecessaryGaps"></see></summary>
    let doNotAllowUnnecessaryGaps = _prefix "doNotAllowUnnecessaryGaps"
    /// <summary>
    /// Do not leave your vehicle
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#doNotLeaveYourVehicle"></see></summary>
    let doNotLeaveYourVehicle = _prefix "doNotLeaveYourVehicle"
    /// <summary>
    /// Do not throw out any burning objects
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#doNotThrowOutAnyBurningObjects"></see></summary>
    let doNotThrowOutAnyBurningObjects = _prefix "doNotThrowOutAnyBurningObjects"
    /// <summary>
    /// Do not use navigation systems
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#doNotUseNavigationSystems"></see></summary>
    let doNotUseNavigationSystems = _prefix "doNotUseNavigationSystems"
    /// <summary>
    /// Drive carefully.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#driveCarefully"></see></summary>
    let driveCarefully = _prefix "driveCarefully"
    /// <summary>
    /// Drive with extreme caution
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#driveWithExtremeCaution"></see></summary>
    let driveWithExtremeCaution = _prefix "driveWithExtremeCaution"
    /// <summary>
    /// Flash your lights
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#flashYourLights"></see></summary>
    let flashYourLights = _prefix "flashYourLights"
    /// <summary>
    /// Follow the vehicle in front smoothly
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#followTheVehicleInFrontSmoothly"></see></summary>
    let followTheVehicleInFrontSmoothly = _prefix "followTheVehicleInFrontSmoothly"
    /// <summary>
    /// In emergency wait for patrol service
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#inEmergencyWaitForPatrolService"></see></summary>
    let inEmergencyWaitForPatrolService = _prefix "inEmergencyWaitForPatrolService"
    /// <summary>
    /// Increase normal following distance
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#increaseNormalFollowingDistance"></see></summary>
    let increaseNormalFollowingDistance = _prefix "increaseNormalFollowingDistance"
    /// <summary>
    /// Keep your distance.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#keepYourDistance"></see></summary>
    let keepYourDistance = _prefix "keepYourDistance"

    /// <summary>
    /// Leave your vehicle proceed to next safe place
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#leaveYourVehicleProceedToNextSafePlace"></see></summary>
    let leaveYourVehicleProceedToNextSafePlace =
        _prefix "leaveYourVehicleProceedToNextSafePlace"

    /// <summary>
    /// No naked flames.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#noNakedFlames"></see></summary>
    let noNakedFlames = _prefix "noNakedFlames"
    /// <summary>
    /// No overtaking on the specified section of road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#noOvertaking"></see></summary>
    let noOvertaking = _prefix "noOvertaking"
    /// <summary>
    /// No smoking.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#noSmoking"></see></summary>
    let noSmoking = _prefix "noSmoking"
    /// <summary>
    /// No stopping.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#noStopping"></see></summary>
    let noStopping = _prefix "noStopping"
    /// <summary>
    /// No U-turns.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#noUturns"></see></summary>
    let noUturns = _prefix "noUturns"
    /// <summary>
    /// Observe current amber alert (an emergency alert issued for a missing or abducted child).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#observeAmberAlert"></see></summary>
    let observeAmberAlert = _prefix "observeAmberAlert"
    /// <summary>
    /// Observe signals.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#observeSignals"></see></summary>
    let observeSignals = _prefix "observeSignals"
    /// <summary>
    /// Observe signs.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#observeSigns"></see></summary>
    let observeSigns = _prefix "observeSigns"
    /// <summary>
    /// Only travel if absolutely necessary.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onlyTravelIfAbsolutelyNecessary"></see></summary>
    let onlyTravelIfAbsolutelyNecessary = _prefix "onlyTravelIfAbsolutelyNecessary"
    /// <summary>
    /// Overtake with care.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#overtakeWithCare"></see></summary>
    let overtakeWithCare = _prefix "overtakeWithCare"
    /// <summary>
    /// Pull over to the edge of the roadway.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#pullOverToTheEdgeOfTheRoadway"></see></summary>
    let pullOverToTheEdgeOfTheRoadway = _prefix "pullOverToTheEdgeOfTheRoadway"
    /// <summary>
    /// Stop at next safe place.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#stopAtNextSafePlace"></see></summary>
    let stopAtNextSafePlace = _prefix "stopAtNextSafePlace"
    /// <summary>
    /// Stop at next rest service area or car park.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#stopAtNextServiceArea"></see></summary>
    let stopAtNextServiceArea = _prefix "stopAtNextServiceArea"
    /// <summary>
    /// Switch off engine.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#switchOffEngine"></see></summary>
    let switchOffEngine = _prefix "switchOffEngine"

    /// <summary>
    /// Switch off mobile phones and two-way radios.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#switchOffMobilePhonesAndTwoWayRadios"></see></summary>
    let switchOffMobilePhonesAndTwoWayRadios =
        _prefix "switchOffMobilePhonesAndTwoWayRadios"

    /// <summary>
    /// Test your brakes.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#testYourBrakes"></see></summary>
    let testYourBrakes = _prefix "testYourBrakes"
    /// <summary>
    /// Use bus service.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#useBusService"></see></summary>
    let useBusService = _prefix "useBusService"
    /// <summary>
    /// Use fog lights.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#useFogLights"></see></summary>
    let useFogLights = _prefix "useFogLights"
    /// <summary>
    /// Use hazard warning lights.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#useHazardWarningLights"></see></summary>
    let useHazardWarningLights = _prefix "useHazardWarningLights"
    /// <summary>
    /// Use headlights.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#useHeadlights"></see></summary>
    let useHeadlights = _prefix "useHeadlights"
    /// <summary>
    /// Use rail service.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#useRailService"></see></summary>
    let useRailService = _prefix "useRailService"
    /// <summary>
    /// Use tram service.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#useTramService"></see></summary>
    let useTramService = _prefix "useTramService"
    /// <summary>
    /// Use underground service.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#useUndergroundService"></see></summary>
    let useUndergroundService = _prefix "useUndergroundService"
    /// <summary>
    /// Wait for escort vehicle.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#waitForEscortVehicle"></see></summary>
    let waitForEscortVehicle = _prefix "waitForEscortVehicle"
    /// <summary>
    /// At national borders
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#atBorders"></see></summary>
    let atBorders = _prefix "atBorders"
    /// <summary>
    /// At high altitudes
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#atHighAltitudes"></see></summary>
    let atHighAltitudes = _prefix "atHighAltitudes"
    /// <summary>
    /// In built up areas, i.e. villages, towns and cities
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#inBuiltUpAreas"></see></summary>
    let inBuiltUpAreas = _prefix "inBuiltUpAreas"
    /// <summary>
    /// On sections of the road where it runs through or adjacent to forested areas
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#inForestedAreas"></see></summary>
    let inForestedAreas = _prefix "inForestedAreas"
    /// <summary>
    /// In galleries
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#inGalleries"></see></summary>
    let inGalleries = _prefix "inGalleries"
    /// <summary>
    /// In low-lying areas
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#inLowLyingAreas"></see></summary>
    let inLowLyingAreas = _prefix "inLowLyingAreas"
    /// <summary>
    /// In rural areas, i.e. outside villages, towns and cities
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#inRuralAreas"></see></summary>
    let inRuralAreas = _prefix "inRuralAreas"
    /// <summary>
    /// In shaded areas
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#inShadedAreas"></see></summary>
    let inShadedAreas = _prefix "inShadedAreas"
    /// <summary>
    /// In the city centre areas
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#inTheInnerCityAreas"></see></summary>
    let inTheInnerCityAreas = _prefix "inTheInnerCityAreas"
    /// <summary>
    /// In tunnels
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#inTunnels"></see></summary>
    let inTunnels = _prefix "inTunnels"
    /// <summary>
    /// On bridges
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onBridges"></see></summary>
    let onBridges = _prefix "onBridges"
    /// <summary>
    /// On downhill sections of the road
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onDownhillSections"></see></summary>
    let onDownhillSections = _prefix "onDownhillSections"
    /// <summary>
    /// On elevated sections of the road
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onElevatedSections"></see></summary>
    let onElevatedSections = _prefix "onElevatedSections"
    /// <summary>
    /// On entering or leaving tunnels
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onEnteringOrLeavingTunnels"></see></summary>
    let onEnteringOrLeavingTunnels = _prefix "onEnteringOrLeavingTunnels"
    /// <summary>
    /// On flyover sections of the road, i.e. sections of the road which pass over another road
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onFlyovers"></see></summary>
    let onFlyovers = _prefix "onFlyovers"
    /// <summary>
    /// On mountain passes
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onPasses"></see></summary>
    let onPasses = _prefix "onPasses"
    /// <summary>
    /// On underground sections of the road
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onUndergroundSections"></see></summary>
    let onUndergroundSections = _prefix "onUndergroundSections"
    /// <summary>
    /// On underpasses, i.e. sections of the road which pass under another road
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onUnderpasses"></see></summary>
    let onUnderpasses = _prefix "onUnderpasses"
    /// <summary>
    /// The information is real. It is not a test or exercise.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#real"></see></summary>
    let real = _prefix "real"
    /// <summary>
    /// The information is part of an exercise which is for testing security.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#securityExercise"></see></summary>
    let securityExercise = _prefix "securityExercise"
    /// <summary>
    /// The information is part of an exercise which includes tests of associated technical subsystems.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#technicalExercise"></see></summary>
    let technicalExercise = _prefix "technicalExercise"
    /// <summary>
    /// The information is part of a test for checking the exchange of this type of information.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#test"></see></summary>
    let test = _prefix "test"
    /// <summary>
    /// Motorway
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#motorway"></see></summary>
    let motorway = _prefix "motorway"
    /// <summary>
    /// Multiple carriageway
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#multipleCarriageway"></see></summary>
    let multipleCarriageway = _prefix "multipleCarriageway"
    /// <summary>
    /// Roundabout
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roundabout"></see></summary>
    let roundabout = _prefix "roundabout"
    /// <summary>
    /// Single carriageway
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#singleCarriageway"></see></summary>
    let singleCarriageway = _prefix "singleCarriageway"
    /// <summary>
    /// Slip Road. The nature of the linear element is a slip road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#slipRoad"></see></summary>
    let slipRoad = _prefix "slipRoad"
    /// <summary>
    /// Traffic square
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#trafficSquare"></see></summary>
    let trafficSquare = _prefix "trafficSquare"
    /// <summary>
    /// Undefined
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#undefined"></see></summary>
    let undefined = _prefix "undefined"
    /// <summary>
    /// A major gathering of people that could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#crowd"></see></summary>
    let crowd = _prefix "crowd"
    /// <summary>
    /// A public protest with the potential to disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#demonstration"></see></summary>
    let demonstration = _prefix "demonstration"
    /// <summary>
    /// A situation where a definite area is being cleared due to dangerous conditions or for security reasons.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#evacuation"></see></summary>
    let evacuation = _prefix "evacuation"
    /// <summary>
    /// Height above mean sea high water level.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#aboveSeaLevelTPEGHeight"></see></summary>
    let aboveSeaLevelTPEGHeight = _prefix "aboveSeaLevelTPEGHeight"
    /// <summary>
    /// Above street level
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#aboveStreetLevelTPEGHeight"></see></summary>
    let aboveStreetLevelTPEGHeight = _prefix "aboveStreetLevelTPEGHeight"
    /// <summary>
    /// Above
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#aboveTPEGHeight"></see></summary>
    let aboveTPEGHeight = _prefix "aboveTPEGHeight"
    /// <summary>
    /// At service area.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#atSeaLevelTPEGHeight"></see></summary>
    let atSeaLevelTPEGHeight = _prefix "atSeaLevelTPEGHeight"
    /// <summary>
    /// At street level.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#atStreetLevelTPEGHeight"></see></summary>
    let atStreetLevelTPEGHeight = _prefix "atStreetLevelTPEGHeight"
    /// <summary>
    /// At height of specified location.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#atTPEGHeight"></see></summary>
    let atTPEGHeight = _prefix "atTPEGHeight"
    /// <summary>
    /// Height below mean sea high water level.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#belowSeaLevelTPEGHeight"></see></summary>
    let belowSeaLevelTPEGHeight = _prefix "belowSeaLevelTPEGHeight"
    /// <summary>
    /// Height below street level.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#belowStreetLevelTPEGHeight"></see></summary>
    let belowStreetLevelTPEGHeight = _prefix "belowStreetLevelTPEGHeight"
    /// <summary>
    /// Height below specified location.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#belowTPEGHeight"></see></summary>
    let belowTPEGHeight = _prefix "belowTPEGHeight"
    /// <summary>
    /// Undefined height reference.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#undefinedTPEGHeight"></see></summary>
    let undefinedTPEGHeight = _prefix "undefinedTPEGHeight"
    /// <summary>
    /// Perceived by supplier as being of an unknown level.
    /// Unknow mobility of the describe element of a situation.
    /// Driving conditions are unknown.
    /// Accident cause is unknown.
    /// Direction is unknown.
    /// The trend of traffic conditions is currently unknown.
    /// Unknown height reference.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#unknown"></see></summary>
    let unknown = _prefix "unknown"
    /// <summary>
    /// Do not use stud tyres.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#doNoUseStudTyres"></see></summary>
    let doNoUseStudTyres = _prefix "doNoUseStudTyres"
    /// <summary>
    /// Use snow chains.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#useSnowChains"></see></summary>
    let useSnowChains = _prefix "useSnowChains"
    /// <summary>
    /// Use snow chains or snow tyres.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#useSnowChainsOrTyres"></see></summary>
    let useSnowChainsOrTyres = _prefix "useSnowChainsOrTyres"
    /// <summary>
    /// Use snow tyres.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#useSnowTyres"></see></summary>
    let useSnowTyres = _prefix "useSnowTyres"
    /// <summary>
    /// The carrying of winter equipment (snow chains and/or snow tyres) is required.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#winterEquipmentOnBoardRequired"></see></summary>
    let winterEquipmentOnBoardRequired = _prefix "winterEquipmentOnBoardRequired"
    /// <summary>
    /// Indicates that both directions of traffic flow are affected by the situation or relate to the traffic data.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#both"></see></summary>
    let both = _prefix "both"
    /// <summary>
    /// On the left side of the road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#left"></see></summary>
    let left = _prefix "left"
    /// <summary>
    /// On road or unknown
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onRoadOrUnknown"></see></summary>
    let onRoadOrUnknown = _prefix "onRoadOrUnknown"
    /// <summary>
    /// On the right side of the road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#right"></see></summary>
    let right = _prefix "right"
    /// <summary>
    /// Ferry service.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ferry"></see></summary>
    let ferry = _prefix "ferry"
    /// <summary>
    /// Name of a road network junction where two or more roads join.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#junctionName"></see></summary>
    let junctionName = _prefix "junctionName"
    /// <summary>
    /// The described event, action or item is currently active regardless of the definition of the validity time specification.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#active"></see></summary>
    let active = _prefix "active"
    /// <summary>
    /// The validity status of the described event, action or item is in accordance with the definition of the validity time specification.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#definedByValidityTimeSpec"></see></summary>
    let definedByValidityTimeSpec = _prefix "definedByValidityTimeSpec"
    /// <summary>
    /// The described event, action or item is currently planned regardless of the definition of the validity time specification.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#planned"></see></summary>
    let planned = _prefix "planned"
    /// <summary>
    /// The described event, action or item is currently suspended, that is inactive, regardless of the definition of the validity time specification.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#suspended"></see></summary>
    let suspended = _prefix "suspended"
    /// <summary>
    /// Abnormal traffic information.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#abnormalLoad"></see></summary>
    let abnormalLoad = _prefix "abnormalLoad"
    /// <summary>
    /// Broken down heavy lorry/lorries on the carriageway which may cause traffic disruption.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#brokenDownHeavyLorry"></see></summary>
    let brokenDownHeavyLorry = _prefix "brokenDownHeavyLorry"
    /// <summary>
    /// Broken down vehicle(s) on the carriageway which may cause traffic disruption.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#brokenDownVehicle"></see></summary>
    let brokenDownVehicle = _prefix "brokenDownVehicle"
    /// <summary>
    /// A group of vehicles moving together in formation which may cause traffic disruption.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#convoy"></see></summary>
    let convoy = _prefix "convoy"
    /// <summary>
    /// Damaged vehicle(s) on the carriageway which may cause traffic disruption.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#damagedVehicle"></see></summary>
    let damagedVehicle = _prefix "damagedVehicle"
    /// <summary>
    /// A vehicle of length greater than that normally allowed which may cause traffic disruption.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#longLoad"></see></summary>
    let longLoad = _prefix "longLoad"
    /// <summary>
    /// A group of military vehicles moving together in formation which may cause traffic disruption.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#militaryConvoy"></see></summary>
    let militaryConvoy = _prefix "militaryConvoy"
    /// <summary>
    /// A vehicle travelling at well below normal highway speeds which may cause traffic disruption.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#slowVehicle"></see></summary>
    let slowVehicle = _prefix "slowVehicle"
    /// <summary>
    /// A vehicle is or has been on fire and may cause traffic disruption.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#vehicleOnFire"></see></summary>
    let vehicleOnFire = _prefix "vehicleOnFire"
    /// <summary>
    /// A vehicle is travelling the wrong way along a divided highway (i.e. on the wrong side).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#vehicleOnWrongCarriageway"></see></summary>
    let vehicleOnWrongCarriageway = _prefix "vehicleOnWrongCarriageway"
    /// <summary>
    /// One or more vehicles are stuck (i.e. unable to move) due to environmental conditions such as a snow drift or severe icy road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#vehicleStuck"></see></summary>
    let vehicleStuck = _prefix "vehicleStuck"
    /// <summary>
    /// A vehicle of width greater than that normally allowed which may cause traffic disruption.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#vehicleWithOverwideLoad"></see></summary>
    let vehicleWithOverwideLoad = _prefix "vehicleWithOverwideLoad"
    /// <summary>
    /// The carriageway is totally obstructed in the specified direction due to an unplanned event.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#carriagewayBlocked"></see></summary>
    let carriagewayBlocked = _prefix "carriagewayBlocked"
    /// <summary>
    /// The carriageway is partially obstructed in the specified direction due to an unplanned event.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#carriagewayPartiallyObstructed"></see></summary>
    let carriagewayPartiallyObstructed = _prefix "carriagewayPartiallyObstructed"
    /// <summary>
    /// One or more lanes is totally obstructed in the specified direction due to an unplanned event.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#lanesBlocked"></see></summary>
    let lanesBlocked = _prefix "lanesBlocked"
    /// <summary>
    /// One or more lanes is partially obstructed in the specified direction due to an unplanned event.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#lanesPartiallyObstructed"></see></summary>
    let lanesPartiallyObstructed = _prefix "lanesPartiallyObstructed"
    /// <summary>
    /// The road is totally obstructed, for all vehicles in both directions, due to an unplanned event.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadBlocked"></see></summary>
    let roadBlocked = _prefix "roadBlocked"
    /// <summary>
    /// The road is partially obstructed in both directions due to an unplanned event.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadPartiallyObstructed"></see></summary>
    let roadPartiallyObstructed = _prefix "roadPartiallyObstructed"

    /// <summary>
    /// Arithmetic average of sample values based on a fixed number of samples.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#arithmeticAverageOfSamplesBasedOnAFixedNumberOfSamples"></see></summary>
    let arithmeticAverageOfSamplesBasedOnAFixedNumberOfSamples =
        _prefix "arithmeticAverageOfSamplesBasedOnAFixedNumberOfSamples"

    /// <summary>
    /// Arithmetic average of sample values in a time period.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#arithmeticAverageOfSamplesInATimePeriod"></see></summary>
    let arithmeticAverageOfSamplesInATimePeriod =
        _prefix "arithmeticAverageOfSamplesInATimePeriod"

    /// <summary>
    /// Harmonic average of sample values in a time period.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#harmonicAverageOfSamplesInATimePeriod"></see></summary>
    let harmonicAverageOfSamplesInATimePeriod =
        _prefix "harmonicAverageOfSamplesInATimePeriod"

    /// <summary>
    /// Median of sample values taken over a time period.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#medianOfSamplesInATimePeriod"></see></summary>
    let medianOfSamplesInATimePeriod = _prefix "medianOfSamplesInATimePeriod"
    /// <summary>
    /// Moving average of sample values.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#movingAverageOfSamples"></see></summary>
    let movingAverageOfSamples = _prefix "movingAverageOfSamples"
    /// <summary>
    /// Broken down vehicle (i.e. it is immobile due to mechanical breakdown).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#brokenDown"></see></summary>
    let brokenDown = _prefix "brokenDown"
    /// <summary>
    /// Burnt out vehicle, but fire is extinguished.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#burntOut"></see></summary>
    let burntOut = _prefix "burntOut"
    /// <summary>
    /// Vehicle is damaged following an incident or collision. It may be able or not to move by itself.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#damaged"></see></summary>
    let damaged = _prefix "damaged"
    /// <summary>
    /// Vehicle is damaged following an incident or collision. It is immobilized and therefore needs assistance to be moved.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#damagedAndImmobililized"></see></summary>
    let damagedAndImmobililized = _prefix "damagedAndImmobililized"
    /// <summary>
    /// The pulling vehicle is in a jackknifed position with its trailer
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#jacknifed"></see></summary>
    let jacknifed = _prefix "jacknifed"
    /// <summary>
    /// Vehicle is on fire.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onFire"></see></summary>
    let onFire = _prefix "onFire"
    /// <summary>
    /// Vehicle is on its side or upside down
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#overturned"></see></summary>
    let overturned = _prefix "overturned"
    /// <summary>
    /// Vehicle has come to rest not facing its intended line of travel.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#spunAround"></see></summary>
    let spunAround = _prefix "spunAround"
    /// <summary>
    /// The road surface has sunken or collapsed in places due to burst pipes.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#burstPipe"></see></summary>
    let burstPipe = _prefix "burstPipe"
    /// <summary>
    /// Traffic may be disrupted due to local flooding and/or subsidence because of a broken water main.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#burstWaterMain"></see></summary>
    let burstWaterMain = _prefix "burstWaterMain"
    /// <summary>
    /// The road surface has sunken or collapsed in places due to sewer failure.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#collapsedSewer"></see></summary>
    let collapsedSewer = _prefix "collapsedSewer"
    /// <summary>
    /// Damage to a bridge that may cause traffic disruption.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#damagedBridge"></see></summary>
    let damagedBridge = _prefix "damagedBridge"
    /// <summary>
    /// Damage to a crash barrier that may cause traffic disruption.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#damagedCrashBarrier"></see></summary>
    let damagedCrashBarrier = _prefix "damagedCrashBarrier"
    /// <summary>
    /// Damage to an elevated section of the carriageway over another carriageway that may cause traffic disruption.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#damagedFlyover"></see></summary>
    let damagedFlyover = _prefix "damagedFlyover"
    /// <summary>
    /// Damage to a gallery that may cause traffic disruption.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#damagedGallery"></see></summary>
    let damagedGallery = _prefix "damagedGallery"
    /// <summary>
    /// Damage to a gantry above the roadway that may cause traffic disruption.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#damagedGantry"></see></summary>
    let damagedGantry = _prefix "damagedGantry"
    /// <summary>
    /// Damage to the road surface that may cause traffic disruption.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#damagedRoadSurface"></see></summary>
    let damagedRoadSurface = _prefix "damagedRoadSurface"
    /// <summary>
    /// Damage to a tunnel that may cause traffic disruption.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#damagedTunnel"></see></summary>
    let damagedTunnel = _prefix "damagedTunnel"
    /// <summary>
    /// Damage to a viaduct that may cause traffic disruption.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#damagedViaduct"></see></summary>
    let damagedViaduct = _prefix "damagedViaduct"
    /// <summary>
    /// The road is obstructed or partially obstructed by one or more fallen power cables.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#fallenPowerCables"></see></summary>
    let fallenPowerCables = _prefix "fallenPowerCables"
    /// <summary>
    /// Traffic may be disrupted due to an explosion hazard from gas escaping in or near the roadway.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#gasLeak"></see></summary>
    let gasLeak = _prefix "gasLeak"
    /// <summary>
    /// Weak bridge capable of carrying a reduced load, typically with a reduced weight limit restriction imposed.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#weakBridge"></see></summary>
    let weakBridge = _prefix "weakBridge"
    /// <summary>
    /// Main road, highest importanceMain road, highest importance
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#frc0"></see></summary>
    let frc0 = _prefix "frc0"
    /// <summary>
    /// First class road
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#frc1"></see></summary>
    let frc1 = _prefix "frc1"
    /// <summary>
    /// Second class road
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#frc2"></see></summary>
    let frc2 = _prefix "frc2"
    /// <summary>
    /// Third class road
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#frc3"></see></summary>
    let frc3 = _prefix "frc3"
    /// <summary>
    /// Fourth class road
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#frc4"></see></summary>
    let frc4 = _prefix "frc4"
    /// <summary>
    /// Fifth class road
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#frc5"></see></summary>
    let frc5 = _prefix "frc5"
    /// <summary>
    /// Sixth class road
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#frc6"></see></summary>
    let frc6 = _prefix "frc6"
    /// <summary>
    /// Other class road, lowest importance
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#frc7"></see></summary>
    let frc7 = _prefix "frc7"
    /// <summary>
    /// The roadworks are likely to cause major traffic disruption.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#major"></see></summary>
    let major = _prefix "major"
    /// <summary>
    /// The roadworks are likely to cause a medium level of traffic disruption.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#mediumRoadworksScale"></see></summary>
    let mediumRoadworksScale = _prefix "mediumRoadworksScale"
    /// <summary>
    /// The roadworks are likely to cause minor traffic disruption.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#minor"></see></summary>
    let minor = _prefix "minor"
    /// <summary>
    /// Perceived by supplier as being of a high level.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#high"></see></summary>
    let high = _prefix "high"
    /// <summary>
    /// Perceived by supplier as being of the highest level.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#highest"></see></summary>
    let highest = _prefix "highest"
    /// <summary>
    /// Perceived by supplier as being of a low level.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#low"></see></summary>
    let low = _prefix "low"
    /// <summary>
    /// Perceived by supplier as being of the lowest discernible level.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#lowest"></see></summary>
    let lowest = _prefix "lowest"
    /// <summary>
    /// Perceived by supplier as being of a medium level.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#medium"></see></summary>
    let medium = _prefix "medium"
    /// <summary>
    /// Perceived by supplier as having a severity rating of none.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#none"></see></summary>
    let none = _prefix "none"
    /// <summary>
    /// Administrative atoll
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#administrativeAtoll"></see></summary>
    let administrativeAtoll = _prefix "administrativeAtoll"
    /// <summary>
    /// Administrative region
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#administrativeRegion"></see></summary>
    let administrativeRegion = _prefix "administrativeRegion"
    /// <summary>
    /// Administrative territory
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#administrativeTerritory"></see></summary>
    let administrativeTerritory = _prefix "administrativeTerritory"
    /// <summary>
    /// Arctic region
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#arcticRegion"></see></summary>
    let arcticRegion = _prefix "arcticRegion"
    /// <summary>
    /// Autonomous city
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#autonomousCity"></see></summary>
    let autonomousCity = _prefix "autonomousCity"
    /// <summary>
    /// Autonomous city in North Africa
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#autonomousCityInNorthAfrica"></see></summary>
    let autonomousCityInNorthAfrica = _prefix "autonomousCityInNorthAfrica"
    /// <summary>
    /// Autonomous community
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#autonomousCommunity"></see></summary>
    let autonomousCommunity = _prefix "autonomousCommunity"
    /// <summary>
    /// Autonomous district
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#autonomousDistrict"></see></summary>
    let autonomousDistrict = _prefix "autonomousDistrict"
    /// <summary>
    /// Autonomous province
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#autonomousProvince"></see></summary>
    let autonomousProvince = _prefix "autonomousProvince"
    /// <summary>
    /// Autonomous region
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#autonomousRegion"></see></summary>
    let autonomousRegion = _prefix "autonomousRegion"
    /// <summary>
    /// Canton
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#canton"></see></summary>
    let canton = _prefix "canton"
    /// <summary>
    /// Capital city
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#capitalCity"></see></summary>
    let capitalCity = _prefix "capitalCity"
    /// <summary>
    /// City
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#city"></see></summary>
    let city = _prefix "city"
    /// <summary>
    /// City municipality
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#cityMunicipality"></see></summary>
    let cityMunicipality = _prefix "cityMunicipality"
    /// <summary>
    /// City of county right
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#cityOfCountyRight"></see></summary>
    let cityOfCountyRight = _prefix "cityOfCountyRight"
    /// <summary>
    /// Commune
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#commune"></see></summary>
    let commune = _prefix "commune"
    /// <summary>
    /// Council area
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#councilArea"></see></summary>
    let councilArea = _prefix "councilArea"
    /// <summary>
    /// EN ISO 3166-1 two-character country code.
    /// Country
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#country"></see></summary>
    let country = _prefix "country"
    /// <summary>
    /// County
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#county"></see></summary>
    let county = _prefix "county"
    /// <summary>
    /// Department
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#department"></see></summary>
    let department = _prefix "department"
    /// <summary>
    /// Dependency
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#dependency"></see></summary>
    let dependency = _prefix "dependency"
    /// <summary>
    /// District
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#district"></see></summary>
    let district = _prefix "district"
    /// <summary>
    /// District municipality
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#districtMunicipality"></see></summary>
    let districtMunicipality = _prefix "districtMunicipality"
    /// <summary>
    /// District with special status
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#districtWithSpecialStatus"></see></summary>
    let districtWithSpecialStatus = _prefix "districtWithSpecialStatus"
    /// <summary>
    /// Entity
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#entity"></see></summary>
    let entity = _prefix "entity"
    /// <summary>
    /// Geographical entity
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#geographicalEntity"></see></summary>
    let geographicalEntity = _prefix "geographicalEntity"
    /// <summary>
    /// Governorate
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#governorate"></see></summary>
    let governorate = _prefix "governorate"
    /// <summary>
    /// Länder
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#laender"></see></summary>
    let laender = _prefix "laender"
    /// <summary>
    /// Local Council
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#localCouncil"></see></summary>
    let localCouncil = _prefix "localCouncil"
    /// <summary>
    /// London borough
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#londonBorough"></see></summary>
    let londonBorough = _prefix "londonBorough"
    /// <summary>
    /// Metropolitan area
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#metropolitanArea"></see></summary>
    let metropolitanArea = _prefix "metropolitanArea"
    /// <summary>
    /// Metropolitan department
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#metropolitanDepartment"></see></summary>
    let metropolitanDepartment = _prefix "metropolitanDepartment"
    /// <summary>
    /// Metropolitan district
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#metropolitanDistrict"></see></summary>
    let metropolitanDistrict = _prefix "metropolitanDistrict"
    /// <summary>
    /// Metropolitan region
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#metropolitanRegion"></see></summary>
    let metropolitanRegion = _prefix "metropolitanRegion"
    /// <summary>
    /// Municipality
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#municipality"></see></summary>
    let municipality = _prefix "municipality"
    /// <summary>
    /// Overseas department
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#overseasDepartment"></see></summary>
    let overseasDepartment = _prefix "overseasDepartment"
    /// <summary>
    /// Overseas region
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#overseasRegion"></see></summary>
    let overseasRegion = _prefix "overseasRegion"
    /// <summary>
    /// Overseas territorial collectivity
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#overseasTerritorialCollectivity"></see></summary>
    let overseasTerritorialCollectivity = _prefix "overseasTerritorialCollectivity"
    /// <summary>
    /// Parish
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#parish"></see></summary>
    let parish = _prefix "parish"
    /// <summary>
    /// Province
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#province"></see></summary>
    let province = _prefix "province"
    /// <summary>
    /// Quarter
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#quarter"></see></summary>
    let quarter = _prefix "quarter"
    /// <summary>
    /// Region
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#region"></see></summary>
    let region = _prefix "region"
    /// <summary>
    /// Republic
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#republic"></see></summary>
    let republic = _prefix "republic"
    /// <summary>
    /// Republic city
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#republicanCity"></see></summary>
    let republicanCity = _prefix "republicanCity"
    /// <summary>
    /// Self-governed part
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#selfGovernedPart"></see></summary>
    let selfGovernedPart = _prefix "selfGovernedPart"
    /// <summary>
    /// Special Municipality
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#specialMunicipality"></see></summary>
    let specialMunicipality = _prefix "specialMunicipality"
    /// <summary>
    /// State
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#state"></see></summary>
    let state = _prefix "state"
    /// <summary>
    /// Territorial unit
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#territorialUnit"></see></summary>
    let territorialUnit = _prefix "territorialUnit"
    /// <summary>
    /// Territory
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#territory"></see></summary>
    let territory = _prefix "territory"
    /// <summary>
    /// Two tier country
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#twoTierCounty"></see></summary>
    let twoTierCounty = _prefix "twoTierCounty"
    /// <summary>
    /// Unitary Authority
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#unitaryAuthority"></see></summary>
    let unitaryAuthority = _prefix "unitaryAuthority"
    /// <summary>
    /// Ward
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ward"></see></summary>
    let ward = _prefix "ward"
    /// <summary>
    /// Around a bend in the road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#aroundABendInRoad"></see></summary>
    let aroundABendInRoad = _prefix "aroundABendInRoad"
    /// <summary>
    /// On border crossing.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onBorder"></see></summary>
    let onBorder = _prefix "onBorder"
    /// <summary>
    /// On mountain pass.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onPass"></see></summary>
    let onPass = _prefix "onPass"
    /// <summary>
    /// Over the crest of a hill.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#overCrestOfHill"></see></summary>
    let overCrestOfHill = _prefix "overCrestOfHill"
    /// <summary>
    /// Agricultural show or event which could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#agriculturalShow"></see></summary>
    let agriculturalShow = _prefix "agriculturalShow"
    /// <summary>
    /// Air show or other aeronautical event which could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#airShow"></see></summary>
    let airShow = _prefix "airShow"
    /// <summary>
    /// Athletics event that could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#athleticsMeeting"></see></summary>
    let athleticsMeeting = _prefix "athleticsMeeting"
    /// <summary>
    /// Ball game event that could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ballGame"></see></summary>
    let ballGame = _prefix "ballGame"
    /// <summary>
    /// Baseball game event that could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#baseballGame"></see></summary>
    let baseballGame = _prefix "baseballGame"
    /// <summary>
    /// Basketball game event that could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#basketballGame"></see></summary>
    let basketballGame = _prefix "basketballGame"
    /// <summary>
    /// Bicycle race that could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#bicycleRace"></see></summary>
    let bicycleRace = _prefix "bicycleRace"
    /// <summary>
    /// Regatta (boat race event of sailing, powerboat or rowing) that could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#boatRace"></see></summary>
    let boatRace = _prefix "boatRace"
    /// <summary>
    /// Boat show which could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#boatShow"></see></summary>
    let boatShow = _prefix "boatShow"
    /// <summary>
    /// Boxing event that could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#boxingTournament"></see></summary>
    let boxingTournament = _prefix "boxingTournament"
    /// <summary>
    /// Bull fighting event that could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#bullFight"></see></summary>
    let bullFight = _prefix "bullFight"
    /// <summary>
    /// Formal or religious act, rite or ceremony that could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ceremonialEvent"></see></summary>
    let ceremonialEvent = _prefix "ceremonialEvent"
    /// <summary>
    /// Commercial event which could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#commercialEvent"></see></summary>
    let commercialEvent = _prefix "commercialEvent"
    /// <summary>
    /// Concert event that could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#concert"></see></summary>
    let concert = _prefix "concert"
    /// <summary>
    /// Cricket match that could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#cricketMatch"></see></summary>
    let cricketMatch = _prefix "cricketMatch"
    /// <summary>
    /// Cultural event which could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#culturalEvent"></see></summary>
    let culturalEvent = _prefix "culturalEvent"
    /// <summary>
    /// Major display or trade show which could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#exhibition"></see></summary>
    let exhibition = _prefix "exhibition"
    /// <summary>
    /// Periodic (e.g. annual), often traditional, gathering for entertainment or trade promotion, which could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#fair"></see></summary>
    let fair = _prefix "fair"
    /// <summary>
    /// Celebratory event or series of events which could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#festival"></see></summary>
    let festival = _prefix "festival"
    /// <summary>
    /// Film or TV making event which could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#filmTVMaking"></see></summary>
    let filmTVMaking = _prefix "filmTVMaking"
    /// <summary>
    /// Football match that could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#footballMatch"></see></summary>
    let footballMatch = _prefix "footballMatch"
    /// <summary>
    /// Periodic (e.g. annual), often traditional, gathering for entertainment, which could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#funfair"></see></summary>
    let funfair = _prefix "funfair"
    /// <summary>
    /// Gardening and/or flower show or event which could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#gardeningOrFlowerShow"></see></summary>
    let gardeningOrFlowerShow = _prefix "gardeningOrFlowerShow"
    /// <summary>
    /// Golf tournament event that could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#golfTournament"></see></summary>
    let golfTournament = _prefix "golfTournament"
    /// <summary>
    /// Hockey game event that could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hockeyGame"></see></summary>
    let hockeyGame = _prefix "hockeyGame"
    /// <summary>
    /// Horse race meeting that could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#horseRaceMeeting"></see></summary>
    let horseRaceMeeting = _prefix "horseRaceMeeting"
    /// <summary>
    /// Large sporting event of an international nature that could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#internationalSportsMeeting"></see></summary>
    let internationalSportsMeeting = _prefix "internationalSportsMeeting"
    /// <summary>
    /// Significant organised event either on or near the roadway which could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#majorEvent"></see></summary>
    let majorEvent = _prefix "majorEvent"
    /// <summary>
    /// Marathon, cross-country or road running event that could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#marathon"></see></summary>
    let marathon = _prefix "marathon"
    /// <summary>
    /// Periodic (e.g. weekly) gathering for buying and selling, which could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#market"></see></summary>
    let market = _prefix "market"
    /// <summary>
    /// Sports match of unspecified type that could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#match"></see></summary>
    let match_ = _prefix "match"
    /// <summary>
    /// Motor show which could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#motorShow"></see></summary>
    let motorShow = _prefix "motorShow"
    /// <summary>
    /// Motor sport race meeting that could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#motorSportRaceMeeting"></see></summary>
    let motorSportRaceMeeting = _prefix "motorSportRaceMeeting"
    /// <summary>
    /// Formal display or organized procession which could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#parade"></see></summary>
    let parade = _prefix "parade"
    /// <summary>
    /// An organised procession which could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#procession"></see></summary>
    let procession = _prefix "procession"
    /// <summary>
    /// Race meeting (other than horse or motor sport) that could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#raceMeeting"></see></summary>
    let raceMeeting = _prefix "raceMeeting"
    /// <summary>
    /// Rugby match that could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#rugbyMatch"></see></summary>
    let rugbyMatch = _prefix "rugbyMatch"
    /// <summary>
    /// A series of significant organised events either on or near the roadway which could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#severalMajorEvents"></see></summary>
    let severalMajorEvents = _prefix "severalMajorEvents"
    /// <summary>
    /// Entertainment event that could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#show"></see></summary>
    let show = _prefix "show"
    /// <summary>
    /// Horse showing jumping and tournament event that could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#showJumping"></see></summary>
    let showJumping = _prefix "showJumping"
    /// <summary>
    /// Sports event of unspecified type that could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#sportsMeeting"></see></summary>
    let sportsMeeting = _prefix "sportsMeeting"
    /// <summary>
    /// Public ceremony or visit of national or international significance which could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#stateOccasion"></see></summary>
    let stateOccasion = _prefix "stateOccasion"
    /// <summary>
    /// Tennis tournament that could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tennisTournament"></see></summary>
    let tennisTournament = _prefix "tennisTournament"
    /// <summary>
    /// Sporting event or series of events of unspecified type lasting more than one day which could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tournament"></see></summary>
    let tournament = _prefix "tournament"
    /// <summary>
    /// A periodic (e.g. annual), often traditional, gathering for trade promotion, which could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tradeFair"></see></summary>
    let tradeFair = _prefix "tradeFair"
    /// <summary>
    /// Water sports meeting that could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#waterSportsMeeting"></see></summary>
    let waterSportsMeeting = _prefix "waterSportsMeeting"
    /// <summary>
    /// Winter sports meeting or event (e.g. skiing, ski jumping, skating) that could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#winterSportsMeeting"></see></summary>
    let winterSportsMeeting = _prefix "winterSportsMeeting"
    /// <summary>
    /// Driving conditions are hazardous due to environmental conditions.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hazardous"></see></summary>
    let hazardous = _prefix "hazardous"
    /// <summary>
    /// Current conditions are making driving impossible.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#impossible"></see></summary>
    let impossible = _prefix "impossible"
    /// <summary>
    /// Driving conditions are normal.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#normal"></see></summary>
    let normal = _prefix "normal"
    /// <summary>
    /// The roadway is passable to vehicles with driver care.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#passableWithCare"></see></summary>
    let passableWithCare = _prefix "passableWithCare"
    /// <summary>
    /// Driving conditions are very hazardous due to environmental conditions.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#veryHazardous"></see></summary>
    let veryHazardous = _prefix "veryHazardous"
    /// <summary>
    /// Driving conditions are consistent with those expected in winter.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#winterConditions"></see></summary>
    let winterConditions = _prefix "winterConditions"
    /// <summary>
    /// Traffic is heavy at the specified location (i.e. average speed is between 75% and 90% of its free-flow level).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#heavyTraffic"></see></summary>
    let heavyTraffic = _prefix "heavyTraffic"
    /// <summary>
    /// Traffic is queuing at the specified location, although there is still some traffic movement (i.e. average speed is between 10% and 25% of its free-flow level).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#queuingTraffic"></see></summary>
    let queuingTraffic = _prefix "queuingTraffic"
    /// <summary>
    /// Traffic is slow moving at the specified location, but not yet forming queues (i.e. average speed is between 25% and 75% of its free-flow level).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#slowTraffic"></see></summary>
    let slowTraffic = _prefix "slowTraffic"
    /// <summary>
    /// Traffic is stationary, or very near stationary, at the specified location (i.e. average speed is less than 10% of its free-flow level).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#stationaryTraffic"></see></summary>
    let stationaryTraffic = _prefix "stationaryTraffic"
    /// <summary>
    /// There are abnormal traffic conditions of an unspecified nature at the specified location.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#unspecifiedAbnormalTraffic"></see></summary>
    let unspecifiedAbnormalTraffic = _prefix "unspecifiedAbnormalTraffic"
    /// <summary>
    /// Blasting or quarrying work at the specified location.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#blastingWork"></see></summary>
    let blastingWork = _prefix "blastingWork"
    /// <summary>
    /// Construction work of a general nature at the specified location.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#constructionWork"></see></summary>
    let constructionWork = _prefix "constructionWork"
    /// <summary>
    /// The described element of a situation is moving.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#mobile"></see></summary>
    let mobile = _prefix "mobile"
    /// <summary>
    /// The described element of a situation is stationary.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#stationary"></see></summary>
    let stationary = _prefix "stationary"
    /// <summary>
    /// Avoidance of obstacles on the roadway.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#avoidanceOfObstacles"></see></summary>
    let avoidanceOfObstacles = _prefix "avoidanceOfObstacles"
    /// <summary>
    /// Driver distraction.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#driverDistraction"></see></summary>
    let driverDistraction = _prefix "driverDistraction"
    /// <summary>
    /// Driver under the influence of drugs.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#driverDrugAbuse"></see></summary>
    let driverDrugAbuse = _prefix "driverDrugAbuse"
    /// <summary>
    /// Driver illness.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#driverIllness"></see></summary>
    let driverIllness = _prefix "driverIllness"
    /// <summary>
    /// Loss of vehicle control due to excessive vehicle speed.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#exceedingSpeedsLimits"></see></summary>
    let exceedingSpeedsLimits = _prefix "exceedingSpeedsLimits"
    /// <summary>
    /// Driver abilities reduced due to driving under the influence of alcohol. Alcohol levels above nationally accepted limit.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#excessAlcohol"></see></summary>
    let excessAlcohol = _prefix "excessAlcohol"
    /// <summary>
    /// Excessive tiredness of the driver.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#excessiveDriverTiredness"></see></summary>
    let excessiveDriverTiredness = _prefix "excessiveDriverTiredness"
    /// <summary>
    /// A driving manoeuvre which was not permitted.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#impermissibleManoeuvre"></see></summary>
    let impermissibleManoeuvre = _prefix "impermissibleManoeuvre"
    /// <summary>
    /// Limited or impaired visibility.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#limitedVisibility"></see></summary>
    let limitedVisibility = _prefix "limitedVisibility"
    /// <summary>
    /// Not keeping a safe distance from the vehicle in front.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#notKeepingASafeDistance"></see></summary>
    let notKeepingASafeDistance = _prefix "notKeepingASafeDistance"
    /// <summary>
    /// Driving on the wrong side of the road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onTheWrongSideOfTheRoad"></see></summary>
    let onTheWrongSideOfTheRoad = _prefix "onTheWrongSideOfTheRoad"
    /// <summary>
    /// Pedestrian in the roadway.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#pedestrianInRoad"></see></summary>
    let pedestrianInRoad = _prefix "pedestrianInRoad"
    /// <summary>
    /// Not keeping to lane.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#poorLaneAdherence"></see></summary>
    let poorLaneAdherence = _prefix "poorLaneAdherence"
    /// <summary>
    /// Poor judgement when merging at an entry or exit point of a carriageway or junction.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#poorMergeEntryOrExitJudgement"></see></summary>
    let poorMergeEntryOrExitJudgement = _prefix "poorMergeEntryOrExitJudgement"
    /// <summary>
    /// Poor road surface condition.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#poorRoadSurfaceCondition"></see></summary>
    let poorRoadSurfaceCondition = _prefix "poorRoadSurfaceCondition"
    /// <summary>
    /// Poor road surface adherence.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#poorSurfaceAdherence"></see></summary>
    let poorSurfaceAdherence = _prefix "poorSurfaceAdherence"
    /// <summary>
    /// Undisclosed cause.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#undisclosed"></see></summary>
    let undisclosed = _prefix "undisclosed"
    /// <summary>
    /// Malfunction or failure of vehicle function.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#vehicleFailure"></see></summary>
    let vehicleFailure = _prefix "vehicleFailure"
    /// <summary>
    /// Adult.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#adult"></see></summary>
    let adult = _prefix "adult"
    /// <summary>
    /// Child (age 4 to 17).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#child"></see></summary>
    let child = _prefix "child"
    /// <summary>
    /// A member of the emergency services, other than the police.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#emergencyServicesPerson"></see></summary>
    let emergencyServicesPerson = _prefix "emergencyServicesPerson"
    /// <summary>
    /// A member of the fire service.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#fireman"></see></summary>
    let fireman = _prefix "fireman"
    /// <summary>
    /// Infant (age 0 to 3).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#infant"></see></summary>
    let infant = _prefix "infant"
    /// <summary>
    /// A member of the medical service.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#medicalStaff"></see></summary>
    let medicalStaff = _prefix "medicalStaff"
    /// <summary>
    /// A member of the general public.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#memberOfThePublic"></see></summary>
    let memberOfThePublic = _prefix "memberOfThePublic"
    /// <summary>
    /// A member of the police force.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#policeman"></see></summary>
    let policeman = _prefix "policeman"
    /// <summary>
    /// A politician.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#politician"></see></summary>
    let politician = _prefix "politician"
    /// <summary>
    /// A passenger on or from a public transport vehicle.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#publicTransportPassenger"></see></summary>
    let publicTransportPassenger = _prefix "publicTransportPassenger"
    /// <summary>
    /// A sick person.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#sickPerson"></see></summary>
    let sickPerson = _prefix "sickPerson"
    /// <summary>
    /// A traffic patrol officer of the road authority.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#trafficOfficer"></see></summary>
    let trafficOfficer = _prefix "trafficOfficer"
    /// <summary>
    /// A member of the local traffic warden service.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#trafficWarden"></see></summary>
    let trafficWarden = _prefix "trafficWarden"
    /// <summary>
    /// A very important person.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#veryImportantPerson"></see></summary>
    let veryImportantPerson = _prefix "veryImportantPerson"
    /// <summary>
    /// A segment (or link) of the road network corresponding to the way in which the road operator has segmented the network.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#segment"></see></summary>
    let segment = _prefix "segment"
    /// <summary>
    /// Severe skid risk due to black ice (i.e. clear ice, which is impossible or very difficult to see).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#blackIce"></see></summary>
    let blackIce = _prefix "blackIce"
    /// <summary>
    /// Increased skid risk due to ice (of any kind).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ice"></see></summary>
    let ice = _prefix "ice"
    /// <summary>
    /// Severe skid risk due to icy patches (i.e. intermittent ice on roadway).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#icyPatches"></see></summary>
    let icyPatches = _prefix "icyPatches"
    /// <summary>
    /// Snow drifting is in progress or patches of deep snow are present due to earlier drifting.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#snowDrifts"></see></summary>
    let snowDrifts = _prefix "snowDrifts"
    /// <summary>
    /// Water is resting on the roadway which provides an increased hazard to vehicles.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#surfaceWater"></see></summary>
    let surfaceWater = _prefix "surfaceWater"
    /// <summary>
    /// Indicates if the altitude accuracy is equal to or less than 100 metres
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#equalToOrLessThan100Metres"></see></summary>
    let equalToOrLessThan100Metres = _prefix "equalToOrLessThan100Metres"
    /// <summary>
    /// Indicates if the altitude accuracy is equal to or less than 10 centimetres
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#equalToOrLessThan10Centimetres"></see></summary>
    let equalToOrLessThan10Centimetres = _prefix "equalToOrLessThan10Centimetres"
    /// <summary>
    /// Indicates if the altitude accuracy is equal to or less than 10 metres
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#equalToOrLessThan10Metres"></see></summary>
    let equalToOrLessThan10Metres = _prefix "equalToOrLessThan10Metres"
    /// <summary>
    /// Indicates if the altitude accuracy is equal to or less than 1 centimetre
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#equalToOrLessThan1Centimetre"></see></summary>
    let equalToOrLessThan1Centimetre = _prefix "equalToOrLessThan1Centimetre"
    /// <summary>
    /// Indicates if the altitude accuracy is equal to or less than 1 metre
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#equalToOrLessThan1Metre"></see></summary>
    let equalToOrLessThan1Metre = _prefix "equalToOrLessThan1Metre"
    /// <summary>
    /// Indicates if the altitude accuracy is equal to or less than 200 metres
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#equalToOrLessThan200Metres"></see></summary>
    let equalToOrLessThan200Metres = _prefix "equalToOrLessThan200Metres"
    /// <summary>
    /// Indicates if the altitude accuracy is equal to or less than 20 centimetres
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#equalToOrLessThan20Centimetres"></see></summary>
    let equalToOrLessThan20Centimetres = _prefix "equalToOrLessThan20Centimetres"
    /// <summary>
    /// Indicates if the altitude accuracy is equal to or less than 20 metres
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#equalToOrLessThan20Metres"></see></summary>
    let equalToOrLessThan20Metres = _prefix "equalToOrLessThan20Metres"
    /// <summary>
    /// Indicates if the altitude accuracy is equal to or less than 2 centimetres
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#equalToOrLessThan2Centimetres"></see></summary>
    let equalToOrLessThan2Centimetres = _prefix "equalToOrLessThan2Centimetres"
    /// <summary>
    /// Indicates if the altitude accuracy is equal to or less than 2 metres
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#equalToOrLessThan2Metres"></see></summary>
    let equalToOrLessThan2Metres = _prefix "equalToOrLessThan2Metres"
    /// <summary>
    /// Indicates if the altitude accuracy is equal to or less than 50 centimetres
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#equalToOrLessThan50Centimetres"></see></summary>
    let equalToOrLessThan50Centimetres = _prefix "equalToOrLessThan50Centimetres"
    /// <summary>
    /// Indicates if the altitude accuracy is equal to or less than 50 metres
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#equalToOrLessThan50Metres"></see></summary>
    let equalToOrLessThan50Metres = _prefix "equalToOrLessThan50Metres"
    /// <summary>
    /// Indicates if the altitude accuracy is equal to or less than 5 centimetres
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#equalToOrLessThan5Centimetres"></see></summary>
    let equalToOrLessThan5Centimetres = _prefix "equalToOrLessThan5Centimetres"
    /// <summary>
    /// Indicates if the altitude accuracy is equal to or less than 5 metres
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#equalToOrLessThan5Metres"></see></summary>
    let equalToOrLessThan5Metres = _prefix "equalToOrLessThan5Metres"
    /// <summary>
    /// In the centre of the roadway.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#inTheCentre"></see></summary>
    let inTheCentre = _prefix "inTheCentre"
    /// <summary>
    /// On the left of the roadway.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onTheLeft"></see></summary>
    let onTheLeft = _prefix "onTheLeft"
    /// <summary>
    /// On the right of the roadway.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onTheRight"></see></summary>
    let onTheRight = _prefix "onTheRight"
    /// <summary>
    /// The bridge at the specified location has swung or lifted and is therefore temporarily closed to traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#bridgeSwingInOperation"></see></summary>
    let bridgeSwingInOperation = _prefix "bridgeSwingInOperation"
    /// <summary>
    /// A convoy service is in operation.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#convoyService"></see></summary>
    let convoyService = _prefix "convoyService"
    /// <summary>
    /// Signs are being put out before or around an obstacle to protect drivers.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#obstacleSignalling"></see></summary>
    let obstacleSignalling = _prefix "obstacleSignalling"
    /// <summary>
    /// Ramp metering is now active at the specified location.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#rampMeteringInOperation"></see></summary>
    let rampMeteringInOperation = _prefix "rampMeteringInOperation"
    /// <summary>
    /// Traffic is being controlled by temporary traffic lights (red-yellow-green or red-green).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#temporaryTrafficLights"></see></summary>
    let temporaryTrafficLights = _prefix "temporaryTrafficLights"
    /// <summary>
    /// Toll gates are open with no fee collection at the specified location.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tollGatesOpen"></see></summary>
    let tollGatesOpen = _prefix "tollGatesOpen"
    /// <summary>
    /// Traffic is being manually directed.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#trafficBeingManuallyDirected"></see></summary>
    let trafficBeingManuallyDirected = _prefix "trafficBeingManuallyDirected"
    /// <summary>
    /// Traffic in the specified direction is temporarily held up due to an unplanned event (e.g. for clearance of wreckage following an accident).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#trafficHeld"></see></summary>
    let trafficHeld = _prefix "trafficHeld"
    /// <summary>
    /// Name of an administrative area.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#administrativeAreaName"></see></summary>
    let administrativeAreaName = _prefix "administrativeAreaName"
    /// <summary>
    /// Reference name by which administrative area is known.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#administrativeReferenceName"></see></summary>
    let administrativeReferenceName = _prefix "administrativeReferenceName"
    /// <summary>
    /// Name of an airport.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#airportName"></see></summary>
    let airportName = _prefix "airportName"
    /// <summary>
    ///   <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#areaName"></see>
    /// </summary>
    let areaName = _prefix "areaName"
    /// <summary>
    /// Name of a building.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#buildingName"></see></summary>
    let buildingName = _prefix "buildingName"
    /// <summary>
    /// Identifier of a bus stop on the road network.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#busStopIdentifier"></see></summary>
    let busStopIdentifier = _prefix "busStopIdentifier"
    /// <summary>
    /// Name of a bus stop on the road network.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#busStopName"></see></summary>
    let busStopName = _prefix "busStopName"
    /// <summary>
    /// Name of a canal.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#canalName"></see></summary>
    let canalName = _prefix "canalName"
    /// <summary>
    /// Name of a county (administrative sub-division).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#countyName"></see></summary>
    let countyName = _prefix "countyName"
    /// <summary>
    /// Name of a ferry port.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ferryPortName"></see></summary>
    let ferryPortName = _prefix "ferryPortName"
    /// <summary>
    /// Name of a road network intersection.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#intersectionName"></see></summary>
    let intersectionName = _prefix "intersectionName"
    /// <summary>
    /// Name of a lake.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#lakeName"></see></summary>
    let lakeName = _prefix "lakeName"
    /// <summary>
    /// Name of a road link.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#linkName"></see></summary>
    let linkName = _prefix "linkName"
    /// <summary>
    /// Local name of a road link.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#localLinkName"></see></summary>
    let localLinkName = _prefix "localLinkName"
    /// <summary>
    /// Name of a metro/underground station.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#metroStationName"></see></summary>
    let metroStationName = _prefix "metroStationName"
    /// <summary>
    /// Name of a nation (e.g. Wales) which is a sub-division of a ISO recognised country.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#nationName"></see></summary>
    let nationName = _prefix "nationName"
    /// <summary>
    /// Name of a point on the road network which is not at a junction or intersection.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#nonLinkedPointName"></see></summary>
    let nonLinkedPointName = _prefix "nonLinkedPointName"
    /// <summary>
    /// Name of a parking facility.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#parkingFacilityName"></see></summary>
    let parkingFacilityName = _prefix "parkingFacilityName"
    /// <summary>
    /// Name of a specific point.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#pointName"></see></summary>
    let pointName = _prefix "pointName"
    /// <summary>
    /// Name of a general point of interest.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#pointOfInterestName"></see></summary>
    let pointOfInterestName = _prefix "pointOfInterestName"
    /// <summary>
    /// Name of a railway station.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#railwayStation"></see></summary>
    let railwayStation = _prefix "railwayStation"
    /// <summary>
    /// Name of a geographic region.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#regionName"></see></summary>
    let regionName = _prefix "regionName"
    /// <summary>
    /// Name of a river.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#riverName"></see></summary>
    let riverName = _prefix "riverName"
    /// <summary>
    /// Name of a sea.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#seaName"></see></summary>
    let seaName = _prefix "seaName"
    /// <summary>
    /// Name of a service area on a road network.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#serviceAreaName"></see></summary>
    let serviceAreaName = _prefix "serviceAreaName"
    /// <summary>
    /// Name of a river which is of a tidal nature.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tidalRiverName"></see></summary>
    let tidalRiverName = _prefix "tidalRiverName"
    /// <summary>
    /// Name of a town.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#townName"></see></summary>
    let townName = _prefix "townName"
    /// <summary>
    /// A boundary between two jurisdictional or administrative areas. These may be legal boundaries such as between counties or countries, maintenance responsibility boundaries or control boundaries.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#boundary"></see></summary>
    let boundary = _prefix "boundary"
    /// <summary>
    /// A crossing of two or more roads where the precise point of intersection is defined according to specific business rules.
    ///
    /// An point on the road network at which one or more roads intersect.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#intersection"></see></summary>
    let intersection = _prefix "intersection"
    /// <summary>
    /// A visible identifiable physical landmark either alongside or close to the linear object.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#landmark"></see></summary>
    let landmark = _prefix "landmark"
    /// <summary>
    /// A marker which is usually but not necessarily physical that is one of a sequence which are spaced out along the linear object (road) to provide a location reference. The spacing of markers is not necessarily even.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#referenceMarker"></see></summary>
    let referenceMarker = _prefix "referenceMarker"
    /// <summary>
    /// A topological node defined on a road network. Such nodes may delineate the segmentation of the road network according to defined business rules or may constitute a purely topological representation of a road network.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadNode"></see></summary>
    let roadNode = _prefix "roadNode"
    /// <summary>
    /// A point on the road network which is not at a junction or intersection.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#nonLinkedPoint"></see></summary>
    let nonLinkedPoint = _prefix "nonLinkedPoint"
    /// <summary>
    /// Observe speed limit.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#observeSpeedLimits"></see></summary>
    let observeSpeedLimits = _prefix "observeSpeedLimits"
    /// <summary>
    /// Police speed checks are in operation.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#policeSpeedChecksInOperation"></see></summary>
    let policeSpeedChecksInOperation = _prefix "policeSpeedChecksInOperation"
    /// <summary>
    /// Reduce your speed.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#reduceYourSpeed"></see></summary>
    let reduceYourSpeed = _prefix "reduceYourSpeed"
    /// <summary>
    /// Same direction as the normal direction of flow at this point on the road network.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#aligned"></see></summary>
    let aligned = _prefix "aligned"
    /// <summary>
    /// All directions (where more than two are applicable) at this point on the road network.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#allDirections"></see></summary>
    let allDirections = _prefix "allDirections"
    /// <summary>
    /// Anti-clockwise.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#anticlockwise"></see></summary>
    let anticlockwise = _prefix "anticlockwise"
    /// <summary>
    /// Both directions that are applicable at this point on the road network.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#bothWays"></see></summary>
    let bothWays = _prefix "bothWays"
    /// <summary>
    /// Clockwise.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#clockwise"></see></summary>
    let clockwise = _prefix "clockwise"
    /// <summary>
    /// East bound general direction.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#eastBound"></see></summary>
    let eastBound = _prefix "eastBound"
    /// <summary>
    /// Heading towards town centre direction of travel.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#inboundTowardsTown"></see></summary>
    let inboundTowardsTown = _prefix "inboundTowardsTown"
    /// <summary>
    /// Inner ring direction.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#innerRing"></see></summary>
    let innerRing = _prefix "innerRing"
    /// <summary>
    /// North bound general direction.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#northBound"></see></summary>
    let northBound = _prefix "northBound"
    /// <summary>
    /// North east bound general direction.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#northEastBound"></see></summary>
    let northEastBound = _prefix "northEastBound"
    /// <summary>
    /// North west bound general direction.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#northWestBound"></see></summary>
    let northWestBound = _prefix "northWestBound"
    /// <summary>
    /// Indicates that the direction of traffic flow affected by the situation or related to the traffic data is in the opposite sense to the direction in which the linear element is defined.
    /// Opposite direction to the normal direction of flow at this point on the road network.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#opposite"></see></summary>
    let opposite = _prefix "opposite"
    /// <summary>
    /// Heading out of or away from the town centre direction of travel.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#outboundFromTown"></see></summary>
    let outboundFromTown = _prefix "outboundFromTown"
    /// <summary>
    /// Outer ring direction.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#outerRing"></see></summary>
    let outerRing = _prefix "outerRing"
    /// <summary>
    /// South bound general direction.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#southBound"></see></summary>
    let southBound = _prefix "southBound"
    /// <summary>
    /// South east bound general direction.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#southEastBound"></see></summary>
    let southEastBound = _prefix "southEastBound"
    /// <summary>
    /// South west bound general direction.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#southWestBound"></see></summary>
    let southWestBound = _prefix "southWestBound"
    /// <summary>
    /// West bound general direction.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#westBound"></see></summary>
    let westBound = _prefix "westBound"

    /// <summary>
    /// Maintenance vehicles are merging into the traffic flow creating a potential hazard for road users.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#maintenanceVehiclesMergingIntoTrafficFlow"></see></summary>
    let maintenanceVehiclesMergingIntoTrafficFlow =
        _prefix "maintenanceVehiclesMergingIntoTrafficFlow"

    /// <summary>
    /// Maintenance vehicle(s) are spreading salt and/or grit.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#saltAndGritSpreading"></see></summary>
    let saltAndGritSpreading = _prefix "saltAndGritSpreading"
    /// <summary>
    /// Maintenance vehicles are slow moving.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#slowMoving"></see></summary>
    let slowMoving = _prefix "slowMoving"
    /// <summary>
    /// Maintenance vehicle(s) are involved in the clearance of snow.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#snowClearing"></see></summary>
    let snowClearing = _prefix "snowClearing"
    /// <summary>
    /// Maintenance vehicles are stopping to service equipments on or next to the roadway.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#stoppingToServiceEquipments"></see></summary>
    let stoppingToServiceEquipments = _prefix "stoppingToServiceEquipments"
    /// <summary>
    /// The direction of navigation in an ALERT-C table that corresponds to the negative offset usage to go from the secondary location to the primary location within the ALERT-C location table.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#negative"></see></summary>
    let negative = _prefix "negative"
    /// <summary>
    /// The direction of navigation in an ALERT-C table that corresponds to the negative offset usage to go from the secondary location to the primary location within the ALERT-C location table.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#positive"></see></summary>
    let positive = _prefix "positive"
    /// <summary>
    /// Accidents are situations in which one or more vehicles lose control and do not recover.  They include collisions between vehicle(s) or other road user(s), between vehicle(s) and fixed obstacle(s), or they result from a vehicle running off the road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#accident"></see></summary>
    let accident = _prefix "accident"

    /// <summary>
    /// Includes all accidents involving at least one vehicle believed to be carrying materials, which could present an additional hazard to road users.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#accidentInvolvingHazardousMaterials"></see></summary>
    let accidentInvolvingHazardousMaterials =
        _prefix "accidentInvolvingHazardousMaterials"

    /// <summary>
    /// Includes all accidents involving at least one heavy goods vehicle.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#accidentInvolvingHeavyLorries"></see></summary>
    let accidentInvolvingHeavyLorries = _prefix "accidentInvolvingHeavyLorries"
    /// <summary>
    /// Collision of vehicle with another object of unspecified type.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#collision"></see></summary>
    let collision = _prefix "collision"
    /// <summary>
    /// Includes all accidents involving three or more vehicles.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#multipleVehicleAccident"></see></summary>
    let multipleVehicleAccident = _prefix "multipleVehicleAccident"
    /// <summary>
    /// A descriptor indicating the most significant factor causing an accident.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#accidentCause"></see></summary>
    let accidentCause = _prefix "accidentCause"
    /// <summary>
    /// Traffic congestion.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#congestion"></see></summary>
    let congestion = _prefix "congestion"
    /// <summary>
    /// Equipment  which is faulty, malfunctioning or not in a fully operational state that may be of interest or concern to road operators and road users.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#equipmentFailure"></see></summary>
    let equipmentFailure = _prefix "equipmentFailure"
    /// <summary>
    /// Failure of road infrastructure.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#infrastructureFailure"></see></summary>
    let infrastructureFailure = _prefix "infrastructureFailure"
    /// <summary>
    /// Obstruction (of unspecified type) on the roadway.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#obstruction"></see></summary>
    let obstruction = _prefix "obstruction"
    /// <summary>
    /// Poor weather conditions.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#poorWeather"></see></summary>
    let poorWeather = _prefix "poorWeather"
    /// <summary>
    /// Problems at the border crossing.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#problemsAtBorderPost"></see></summary>
    let problemsAtBorderPost = _prefix "problemsAtBorderPost"
    /// <summary>
    /// Problems at the customs post on the border.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#problemsAtCustomPost"></see></summary>
    let problemsAtCustomPost = _prefix "problemsAtCustomPost"
    /// <summary>
    /// Problems (of an unspecified nature) on the local roads.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#problemsOnLocalRoads"></see></summary>
    let problemsOnLocalRoads = _prefix "problemsOnLocalRoads"
    /// <summary>
    /// A roadside event (of unspecified nature) whether planned or not.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadsideEvent"></see></summary>
    let roadsideEvent = _prefix "roadsideEvent"
    /// <summary>
    /// A security incident.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#securityIncident"></see></summary>
    let securityIncident = _prefix "securityIncident"
    /// <summary>
    /// A terrorist incident.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#terrorism"></see></summary>
    let terrorism = _prefix "terrorism"
    /// <summary>
    /// A vandalism incident.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#vandalism"></see></summary>
    let vandalism = _prefix "vandalism"
    /// <summary>
    /// Bridge on, over or under the highway.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#bridge"></see></summary>
    let bridge = _prefix "bridge"
    /// <summary>
    /// Buried cables under or along the highway.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#buriedCables"></see></summary>
    let buriedCables = _prefix "buriedCables"
    /// <summary>
    /// Unspecified buried services on, under or along the highway.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#buriedServices"></see></summary>
    let buriedServices = _prefix "buriedServices"
    /// <summary>
    /// Crash barrier.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#crashBarrier"></see></summary>
    let crashBarrier = _prefix "crashBarrier"
    /// <summary>
    /// Gallery.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#gallery"></see></summary>
    let gallery = _prefix "gallery"
    /// <summary>
    /// Gantry over or above the roadway.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#gantry"></see></summary>
    let gantry = _prefix "gantry"
    /// <summary>
    /// Gas mains.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#gasMainWork"></see></summary>
    let gasMainWork = _prefix "gasMainWork"
    /// <summary>
    /// Motorway or major road interchange.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#interchange"></see></summary>
    let interchange = _prefix "interchange"
    /// <summary>
    /// Motorway or major road junction.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#junction"></see></summary>
    let junction = _prefix "junction"
    /// <summary>
    /// Level-crossing or associated equipment.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#levelCrossing"></see></summary>
    let levelCrossing = _prefix "levelCrossing"
    /// <summary>
    /// Road lighting system.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#lightingSystem"></see></summary>
    let lightingSystem = _prefix "lightingSystem"
    /// <summary>
    /// Equipment used for determining traffic measurements.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#measurementEquipment"></see></summary>
    let measurementEquipment = _prefix "measurementEquipment"
    /// <summary>
    /// Installations along the roadway designed to reduce road noise in the surrounding environment.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#noiseProtection"></see></summary>
    let noiseProtection = _prefix "noiseProtection"
    /// <summary>
    /// road
    /// The nature of the linear element is a road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#road"></see></summary>
    let road = _prefix "road"
    /// <summary>
    /// Road signs.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadSigns"></see></summary>
    let roadSigns = _prefix "roadSigns"
    /// <summary>
    /// Roadside drains.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadsideDrains"></see></summary>
    let roadsideDrains = _prefix "roadsideDrains"
    /// <summary>
    /// Roadside embankment.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadsideEmbankment"></see></summary>
    let roadsideEmbankment = _prefix "roadsideEmbankment"
    /// <summary>
    /// Roadside equipment.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadsideEquipment"></see></summary>
    let roadsideEquipment = _prefix "roadsideEquipment"
    /// <summary>
    /// Toll gate.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tollGate"></see></summary>
    let tollGate = _prefix "tollGate"
    /// <summary>
    /// Road tunnel.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tunnel"></see></summary>
    let tunnel = _prefix "tunnel"
    /// <summary>
    /// Water main under or along the highway.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#waterMain"></see></summary>
    let waterMain = _prefix "waterMain"
    /// <summary>
    /// On the both sides of the roads.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#bothSides"></see></summary>
    let bothSides = _prefix "bothSides"
    /// <summary>
    /// For internal use only of the recipient organisation.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#internalUse"></see></summary>
    let internalUse = _prefix "internalUse"
    /// <summary>
    /// No restriction on usage.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#noRestriction"></see></summary>
    let noRestriction = _prefix "noRestriction"
    /// <summary>
    /// Restricted for use only by authorities.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#restrictedToAuthorities"></see></summary>
    let restrictedToAuthorities = _prefix "restrictedToAuthorities"

    /// <summary>
    /// Restricted for use only by authorities and traffic operators.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#restrictedToAuthoritiesAndTrafficOperators"></see></summary>
    let restrictedToAuthoritiesAndTrafficOperators =
        _prefix "restrictedToAuthoritiesAndTrafficOperators"

    /// <summary>
    /// Restricted for use only by authorities, traffic operators and publishers (service providers).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#restrictedToAuthoritiesTrafficOperatorsAndPublishers"></see></summary>
    let restrictedToAuthoritiesTrafficOperatorsAndPublishers =
        _prefix "restrictedToAuthoritiesTrafficOperatorsAndPublishers"

    /// <summary>
    /// Restricted for use only by authorities, traffic operators, publishers (service providers) and variable message signs.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#restrictedToAuthoritiesTrafficOperatorsAndVms"></see></summary>
    let restrictedToAuthoritiesTrafficOperatorsAndVms =
        _prefix "restrictedToAuthoritiesTrafficOperatorsAndVms"

    /// <summary>
    /// On the connecting carriageway.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#connectingCarriageway"></see></summary>
    let connectingCarriageway = _prefix "connectingCarriageway"
    /// <summary>
    /// Independent road or part of a road designated for cycles, signposted as such. A cycle track is separated from other roads or other parts of the same road by structural means.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#cycleTrack"></see></summary>
    let cycleTrack = _prefix "cycleTrack"
    /// <summary>
    /// On the entry slip road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#entrySlipRoad"></see></summary>
    let entrySlipRoad = _prefix "entrySlipRoad"
    /// <summary>
    /// On the exit slip road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#exitSlipRoad"></see></summary>
    let exitSlipRoad = _prefix "exitSlipRoad"
    /// <summary>
    /// On the flyover, i.e. the section of road passing over another.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#flyover"></see></summary>
    let flyover = _prefix "flyover"
    /// <summary>
    /// On the footpath
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#footpath"></see></summary>
    let footpath = _prefix "footpath"
    /// <summary>
    /// On the left hand feeder road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#leftHandFeederRoad"></see></summary>
    let leftHandFeederRoad = _prefix "leftHandFeederRoad"
    /// <summary>
    /// On the left hand parallel carriageway.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#leftHandParallelCarriageway"></see></summary>
    let leftHandParallelCarriageway = _prefix "leftHandParallelCarriageway"
    /// <summary>
    /// On the main carriageway.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#mainCarriageway"></see></summary>
    let mainCarriageway = _prefix "mainCarriageway"
    /// <summary>
    /// On the opposite carriageway.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#oppositeCarriageway"></see></summary>
    let oppositeCarriageway = _prefix "oppositeCarriageway"
    /// <summary>
    /// On the adjacent external parallel carriageway.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#parallelCarriageway"></see></summary>
    let parallelCarriageway = _prefix "parallelCarriageway"
    /// <summary>
    /// On the right hand feeder road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#rightHandFeederRoad"></see></summary>
    let rightHandFeederRoad = _prefix "rightHandFeederRoad"
    /// <summary>
    /// On the right hand parallel carriageway.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#rightHandParallelCarriageway"></see></summary>
    let rightHandParallelCarriageway = _prefix "rightHandParallelCarriageway"
    /// <summary>
    /// On the adjacent service road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#serviceRoad"></see></summary>
    let serviceRoad = _prefix "serviceRoad"
    /// <summary>
    /// On the slip roads.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#slipRoads"></see></summary>
    let slipRoads = _prefix "slipRoads"
    /// <summary>
    /// On the underpass, i.e. the section of road passing under another.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#underpass"></see></summary>
    let underpass = _prefix "underpass"
    /// <summary>
    /// On an unspecified carriageway
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#unspecifiedCarriageway"></see></summary>
    let unspecifiedCarriageway = _prefix "unspecifiedCarriageway"
    /// <summary>
    /// Vehicle normally used for agricultural purposes, e.g. tractor, combined harvester etc.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#agriculturalVehicle"></see></summary>
    let agriculturalVehicle = _prefix "agriculturalVehicle"
    /// <summary>
    /// Vehicle of any type.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#anyVehicle"></see></summary>
    let anyVehicle = _prefix "anyVehicle"
    /// <summary>
    /// Articulated vehicle.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#articulatedVehicle"></see></summary>
    let articulatedVehicle = _prefix "articulatedVehicle"
    /// <summary>
    /// Bicycle.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#bicycle"></see></summary>
    let bicycle = _prefix "bicycle"
    /// <summary>
    /// Bus.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#bus"></see></summary>
    let bus = _prefix "bus"
    /// <summary>
    /// Car.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#car"></see></summary>
    let car = _prefix "car"
    /// <summary>
    /// Car or light vehicle.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#carOrLightVehicle"></see></summary>
    let carOrLightVehicle = _prefix "carOrLightVehicle"
    /// <summary>
    /// Car towing a caravan.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#carWithCaravan"></see></summary>
    let carWithCaravan = _prefix "carWithCaravan"
    /// <summary>
    /// Car towing a trailer.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#carWithTrailer"></see></summary>
    let carWithTrailer = _prefix "carWithTrailer"
    /// <summary>
    /// Caravan.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#caravan"></see></summary>
    let caravan = _prefix "caravan"
    /// <summary>
    /// Vehicle normally used for construction or maintenance purposes, e.g. digger, excavator, bulldozer, lorry mounted crane etc.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#constructionOrMaintenanceVehicle"></see></summary>
    let constructionOrMaintenanceVehicle = _prefix "constructionOrMaintenanceVehicle"
    /// <summary>
    /// Four wheel drive vehicle.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#fourWheelDrive"></see></summary>
    let fourWheelDrive = _prefix "fourWheelDrive"
    /// <summary>
    /// High sided vehicle.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#highSidedVehicle"></see></summary>
    let highSidedVehicle = _prefix "highSidedVehicle"
    /// <summary>
    /// A heavy lorry that is longer than normal.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#longHeavyLorry"></see></summary>
    let longHeavyLorry = _prefix "longHeavyLorry"
    /// <summary>
    /// Lorry of any type.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#lorry"></see></summary>
    let lorry = _prefix "lorry"
    /// <summary>
    /// Moped (a two wheeled motor vehicle characterized by a small engine typically less than 50cc and by normally having pedals).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#moped"></see></summary>
    let moped = _prefix "moped"
    /// <summary>
    /// Motorcycle.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#motorcycle"></see></summary>
    let motorcycle = _prefix "motorcycle"
    /// <summary>
    /// Three wheeled vehicle comprising a motorcycle with an attached side car.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#motorcycleWithSideCar"></see></summary>
    let motorcycleWithSideCar = _prefix "motorcycleWithSideCar"
    /// <summary>
    /// Motorscooter (a two wheeled motor vehicle characterized by a step-through frame and small diameter wheels).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#motorscooter"></see></summary>
    let motorscooter = _prefix "motorscooter"
    /// <summary>
    /// Vehicle with large tank for carrying bulk liquids.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tanker"></see></summary>
    let tanker = _prefix "tanker"
    /// <summary>
    /// Three wheeled vehicle of unspecified type.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#threeWheeledVehicle"></see></summary>
    let threeWheeledVehicle = _prefix "threeWheeledVehicle"
    /// <summary>
    /// Trailer.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#trailer"></see></summary>
    let trailer = _prefix "trailer"
    /// <summary>
    /// Tram.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tram"></see></summary>
    let tram = _prefix "tram"
    /// <summary>
    /// Two wheeled vehicle of unspecified type.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#twoWheeledVehicle"></see></summary>
    let twoWheeledVehicle = _prefix "twoWheeledVehicle"
    /// <summary>
    /// Van.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#van"></see></summary>
    let van = _prefix "van"
    /// <summary>
    /// Vehicle (of unspecified type) towing a caravan.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#vehicleWithCaravan"></see></summary>
    let vehicleWithCaravan = _prefix "vehicleWithCaravan"
    /// <summary>
    /// Vehicle with catalytic converter.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#vehicleWithCatalyticConverter"></see></summary>
    let vehicleWithCatalyticConverter = _prefix "vehicleWithCatalyticConverter"
    /// <summary>
    /// Vehicle (of unspecified type) towing a trailer.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#vehicleWithTrailer"></see></summary>
    let vehicleWithTrailer = _prefix "vehicleWithTrailer"
    /// <summary>
    /// Vehicle without catalytic converter.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#vehicleWithoutCatalyticConverter"></see></summary>
    let vehicleWithoutCatalyticConverter = _prefix "vehicleWithoutCatalyticConverter"

    /// <summary>
    /// Vehicle with even numbered registration plate.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#withEvenNumberedRegistrationPlates"></see></summary>
    let withEvenNumberedRegistrationPlates =
        _prefix "withEvenNumberedRegistrationPlates"

    /// <summary>
    /// Vehicle with odd numbered registration plate.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#withOddNumberedRegistrationPlates"></see></summary>
    let withOddNumberedRegistrationPlates = _prefix "withOddNumberedRegistrationPlates"
    /// <summary>
    /// LAU 1 code
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#lau1Code"></see></summary>
    let lau1Code = _prefix "lau1Code"
    /// <summary>
    /// LAU 2 code
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#lau2Code"></see></summary>
    let lau2Code = _prefix "lau2Code"
    /// <summary>
    /// NUTS 1 code
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#nuts1Code"></see></summary>
    let nuts1Code = _prefix "nuts1Code"
    /// <summary>
    /// NUTS 2 code
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#nuts2Code"></see></summary>
    let nuts2Code = _prefix "nuts2Code"
    /// <summary>
    /// NUTS 3 code
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#nuts3Code"></see></summary>
    let nuts3Code = _prefix "nuts3Code"
    /// <summary>
    /// The nature of the linear element is a section of a road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadSection"></see></summary>
    let roadSection = _prefix "roadSection"
    /// <summary>
    /// Air ambulance assistance.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#airAmbulance"></see></summary>
    let airAmbulance = _prefix "airAmbulance"
    /// <summary>
    /// Bus passenger assistance.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#busPassengerAssistance"></see></summary>
    let busPassengerAssistance = _prefix "busPassengerAssistance"
    /// <summary>
    /// Emergency services assistance.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#emergencyServices"></see></summary>
    let emergencyServices = _prefix "emergencyServices"
    /// <summary>
    /// First aid assistance.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#firstAid"></see></summary>
    let firstAid = _prefix "firstAid"
    /// <summary>
    /// Food delivery.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#foodDelivery"></see></summary>
    let foodDelivery = _prefix "foodDelivery"
    /// <summary>
    /// Helicopter rescue.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#helicopterRescue"></see></summary>
    let helicopterRescue = _prefix "helicopterRescue"
    /// <summary>
    /// Vehicle recovery.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#vehicleRecovery"></see></summary>
    let vehicleRecovery = _prefix "vehicleRecovery"
    /// <summary>
    /// Vehicle repair assistance.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#vehicleRepair"></see></summary>
    let vehicleRepair = _prefix "vehicleRepair"
    /// <summary>
    /// At a motorway interchange.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#atMotorwayInterchange"></see></summary>
    let atMotorwayInterchange = _prefix "atMotorwayInterchange"
    /// <summary>
    /// At rest area off the carriageway.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#atRestArea"></see></summary>
    let atRestArea = _prefix "atRestArea"
    /// <summary>
    /// At service area.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#atServiceArea"></see></summary>
    let atServiceArea = _prefix "atServiceArea"
    /// <summary>
    /// At toll plaza.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#atTollPlaza"></see></summary>
    let atTollPlaza = _prefix "atTollPlaza"
    /// <summary>
    /// At entry or exit of tunnel.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#atTunnelEntryOrExit"></see></summary>
    let atTunnelEntryOrExit = _prefix "atTunnelEntryOrExit"
    /// <summary>
    /// In gallery.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#inGallery"></see></summary>
    let inGallery = _prefix "inGallery"
    /// <summary>
    /// In tunnel.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#inTunnel"></see></summary>
    let inTunnel = _prefix "inTunnel"
    /// <summary>
    /// On bridge
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onBridge"></see></summary>
    let onBridge = _prefix "onBridge"
    /// <summary>
    /// On connecting carriageway between two different roads or road sections.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onConnector"></see></summary>
    let onConnector = _prefix "onConnector"
    /// <summary>
    /// On elevated section of road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onElevatedSection"></see></summary>
    let onElevatedSection = _prefix "onElevatedSection"
    /// <summary>
    /// On flyover, i.e. on section of road over another road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onFlyover"></see></summary>
    let onFlyover = _prefix "onFlyover"
    /// <summary>
    /// On ice road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onIceRoad"></see></summary>
    let onIceRoad = _prefix "onIceRoad"
    /// <summary>
    /// On level-crossing.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onLevelCrossing"></see></summary>
    let onLevelCrossing = _prefix "onLevelCrossing"
    /// <summary>
    /// On road section linking two different roads.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onLinkRoad"></see></summary>
    let onLinkRoad = _prefix "onLinkRoad"
    /// <summary>
    /// On roundabout.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onRoundabout"></see></summary>
    let onRoundabout = _prefix "onRoundabout"
    /// <summary>
    /// On the roadway.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onTheRoadway"></see></summary>
    let onTheRoadway = _prefix "onTheRoadway"
    /// <summary>
    /// On underground section of road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onUndergroundSection"></see></summary>
    let onUndergroundSection = _prefix "onUndergroundSection"
    /// <summary>
    /// On underpass, i.e. section of road which passes under another road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onUnderpass"></see></summary>
    let onUnderpass = _prefix "onUnderpass"
    /// <summary>
    /// On the main carriageway within a junction between exit slip road and entry slip road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#withinJunction"></see></summary>
    let withinJunction = _prefix "withinJunction"
    /// <summary>
    /// Indicates the accuracy is out of range, i.e. greater than 4 093 cm for horizontal position.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#outOfRange"></see></summary>
    let outOfRange = _prefix "outOfRange"
    /// <summary>
    /// Indicates the accuracy information is unavailable.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#unavailable"></see></summary>
    let unavailable = _prefix "unavailable"
    /// <summary>
    /// Delays on the road network as a result of any situation which causes hold-ups.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#delays"></see></summary>
    let delays = _prefix "delays"
    /// <summary>
    /// Delays on the road network whose predicted duration cannot be estimated.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#delaysOfUncertainDuration"></see></summary>
    let delaysOfUncertainDuration = _prefix "delaysOfUncertainDuration"
    /// <summary>
    /// Delays on the road network of unusual severity.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#longDelays"></see></summary>
    let longDelays = _prefix "longDelays"
    /// <summary>
    /// Delays on the road network of abnormally unusual severity.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#veryLongDelays"></see></summary>
    let veryLongDelays = _prefix "veryLongDelays"
    /// <summary>
    /// The road may be obstructed or partially obstructed due to snow slides.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#avalanches"></see></summary>
    let avalanches = _prefix "avalanches"
    /// <summary>
    /// The road is obstructed or partially obstructed by one or more fallen trees.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#fallenTrees"></see></summary>
    let fallenTrees = _prefix "fallenTrees"
    /// <summary>
    /// The road is obstructed or partially obstructed by flood water.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#flooding"></see></summary>
    let flooding = _prefix "flooding"
    /// <summary>
    /// The road may be obstructed or partially obstructed due to landslides.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#landslips"></see></summary>
    let landslips = _prefix "landslips"
    /// <summary>
    /// The road may be obstructed or partially obstructed due to fallen rocks.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#rockfalls"></see></summary>
    let rockfalls = _prefix "rockfalls"
    /// <summary>
    /// The road surface has sunken or collapsed in places.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#subsidence"></see></summary>
    let subsidence = _prefix "subsidence"
    /// <summary>
    /// A point on the road network framed by two other points on the same road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#framedPoint"></see></summary>
    let framedPoint = _prefix "framedPoint"
    /// <summary>
    /// Dedicated car pool lane(s) are in operation for vehicles carrying at least the specified number of occupants.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#carPoolLaneInOperation"></see></summary>
    let carPoolLaneInOperation = _prefix "carPoolLaneInOperation"
    /// <summary>
    /// Carriageway closures are in operation at the specified location.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#carriagewayClosures"></see></summary>
    let carriagewayClosures = _prefix "carriagewayClosures"
    /// <summary>
    /// Clear a lane for emergency vehicles.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#clearALaneForEmergencyVehicles"></see></summary>
    let clearALaneForEmergencyVehicles = _prefix "clearALaneForEmergencyVehicles"

    /// <summary>
    /// Clear a lane for snow ploughs and gritting vehicles.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#clearALaneForSnowploughsAndGrittingVehicles"></see></summary>
    let clearALaneForSnowploughsAndGrittingVehicles =
        _prefix "clearALaneForSnowploughsAndGrittingVehicles"

    /// <summary>
    /// The road is closed to vehicles with the specified characteristics or all, if none defined, for the duration of the winter.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#closedPermanentlyForTheWinter"></see></summary>
    let closedPermanentlyForTheWinter = _prefix "closedPermanentlyForTheWinter"
    /// <summary>
    /// Two-way traffic is temporarily sharing a single carriageway.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#contraflow"></see></summary>
    let contraflow = _prefix "contraflow"

    /// <summary>
    /// Do not use the specified lane(s) or carriageway(s).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#doNotUseSpecifiedLanesOrCarriageways"></see></summary>
    let doNotUseSpecifiedLanesOrCarriageways =
        _prefix "doNotUseSpecifiedLanesOrCarriageways"

    /// <summary>
    /// The hard shoulder is open as an operational lane.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hardShoulderRunningInOperation"></see></summary>
    let hardShoulderRunningInOperation = _prefix "hardShoulderRunningInOperation"
    /// <summary>
    /// A height restriction is in operation.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#heightRestrictionInOperation"></see></summary>
    let heightRestrictionInOperation = _prefix "heightRestrictionInOperation"
    /// <summary>
    /// Road closures occur intermittently on the specified road in the specified direction for short durations.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#intermittentShortTermClosures"></see></summary>
    let intermittentShortTermClosures = _prefix "intermittentShortTermClosures"
    /// <summary>
    /// Keep to the left.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#keepToTheLeft"></see></summary>
    let keepToTheLeft = _prefix "keepToTheLeft"
    /// <summary>
    /// Keep to the right.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#keepToTheRight"></see></summary>
    let keepToTheRight = _prefix "keepToTheRight"
    /// <summary>
    /// Lane closures are in operation at the specified location for vehicles with the specified characteristics or all, if none defined, in the specified direction.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#laneClosures"></see></summary>
    let laneClosures = _prefix "laneClosures"
    /// <summary>
    /// Lane closures are in operation at the specified location for vehicles with the specified characteristics or all, if none defined, in the specified direction.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#lanesDeviated"></see></summary>
    let lanesDeviated = _prefix "lanesDeviated"
    /// <summary>
    /// Normal lane widths are temporarily reduced.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#narrowLanes"></see></summary>
    let narrowLanes = _prefix "narrowLanes"
    /// <summary>
    /// A new layout of lanes/carriageway has been implemented associated with roadworks.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#newRoadworksLayout"></see></summary>
    let newRoadworksLayout = _prefix "newRoadworksLayout"
    /// <summary>
    /// Every night the road is closed to vehicles with the specified characteristics or all, if none defined, in the specified direction by decision of the appropriate authorities.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#overnightClosures"></see></summary>
    let overnightClosures = _prefix "overnightClosures"
    /// <summary>
    /// The road has been cleared of earlier reported problems.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadCleared"></see></summary>
    let roadCleared = _prefix "roadCleared"
    /// <summary>
    /// The road is closed to vehicles with the specified characteristics or all, if none defined, in the specified direction.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadClosed"></see></summary>
    let roadClosed = _prefix "roadClosed"
    /// <summary>
    /// Traffic officers or police are driving slowly in front of a queue of traffic to create a gap in the traffic to allow for clearance activities to take place in safety on the road ahead.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#rollingRoadBlock"></see></summary>
    let rollingRoadBlock = _prefix "rollingRoadBlock"
    /// <summary>
    /// Dedicated rush (peak) hour lane(s) are in operation.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#rushHourLaneInOperation"></see></summary>
    let rushHourLaneInOperation = _prefix "rushHourLaneInOperation"
    /// <summary>
    /// Traffic is being controlled to move in alternate single lines. This control may be undertaken by traffic lights or flagman.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#singleAlternateLineTraffic"></see></summary>
    let singleAlternateLineTraffic = _prefix "singleAlternateLineTraffic"
    /// <summary>
    /// Dedicated tidal flow lane(s) are in operation in the specified direction.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tidalFlowLaneInOperation"></see></summary>
    let tidalFlowLaneInOperation = _prefix "tidalFlowLaneInOperation"
    /// <summary>
    /// Traffic is being directed back down the opposite carriageway, possibly requiring the temporary removal of the central crash barrier.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#turnAroundInOperation"></see></summary>
    let turnAroundInOperation = _prefix "turnAroundInOperation"

    /// <summary>
    /// The specified lane(s) or carriageway(s) may be used. The normal lane(s) or carriageway(s) restrictions are not currently in force.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#useOfSpecifiedLanesOrCarriagewaysAllowed"></see></summary>
    let useOfSpecifiedLanesOrCarriagewaysAllowed =
        _prefix "useOfSpecifiedLanesOrCarriagewaysAllowed"

    /// <summary>
    /// Use the specified lane(s) or carriageway(s).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#useSpecifiedLanesOrCarriageways"></see></summary>
    let useSpecifiedLanesOrCarriageways = _prefix "useSpecifiedLanesOrCarriageways"
    /// <summary>
    /// Vehicles are being stored on the roadway and/or at a rest area or service area at the specified location.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#vehicleStorageInOperation"></see></summary>
    let vehicleStorageInOperation = _prefix "vehicleStorageInOperation"
    /// <summary>
    /// A weight restriction is in operation.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#weightRestrictionInOperation"></see></summary>
    let weightRestrictionInOperation = _prefix "weightRestrictionInOperation"
    /// <summary>
    /// Traffic conditions are changing from free-flow to heavy or slow service levels.  Queues may also be expected.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#trafficBuildingUp"></see></summary>
    let trafficBuildingUp = _prefix "trafficBuildingUp"
    /// <summary>
    /// Traffic conditions are changing from heavy or slow service levels to free-flow.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#trafficEasing"></see></summary>
    let trafficEasing = _prefix "trafficEasing"
    /// <summary>
    /// Traffic conditions are currently stable.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#trafficStable"></see></summary>
    let trafficStable = _prefix "trafficStable"
    /// <summary>
    /// The roadworks are expected to last for a long term ( duration &gt; 6 months)
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#longTerm"></see></summary>
    let longTerm = _prefix "longTerm"
    /// <summary>
    /// The roadworks are expected to last for a medium term (1 month &lt; duration &lt; = 6 months).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#mediumTerm"></see></summary>
    let mediumTerm = _prefix "mediumTerm"
    /// <summary>
    /// The roadworks are expected to last for a short term ( duration &lt; = 1 month)
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#shortTerm"></see></summary>
    let shortTerm = _prefix "shortTerm"
    /// <summary>
    /// The source is completely certain of the occurrence of the situation record version content.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#certain"></see></summary>
    let certain = _prefix "certain"
    /// <summary>
    /// The source has a reasonably low level of confidence of the occurrence of the situation record version content.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#improbable"></see></summary>
    let improbable = _prefix "improbable"
    /// <summary>
    /// The source has a reasonably high level of confidence of the occurrence of the situation record version content.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#probable"></see></summary>
    let probable = _prefix "probable"
    /// <summary>
    /// The source has a moderate level of confidence of the occurrence of the situation record version content.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#riskOf"></see></summary>
    let riskOf = _prefix "riskOf"
    /// <summary>
    /// Increased skid risk due to leaves on road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#leavesOnRoad"></see></summary>
    let leavesOnRoad = _prefix "leavesOnRoad"
    /// <summary>
    /// Increased skid risk and injury risk due to loose chippings on road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#looseChippings"></see></summary>
    let looseChippings = _prefix "looseChippings"
    /// <summary>
    /// Increased skid risk due to loose sand on road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#looseSandOnRoad"></see></summary>
    let looseSandOnRoad = _prefix "looseSandOnRoad"
    /// <summary>
    /// Increased skid risk due to mud on road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#mudOnRoad"></see></summary>
    let mudOnRoad = _prefix "mudOnRoad"
    /// <summary>
    /// Increased skid risk due to oil on road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#oilOnRoad"></see></summary>
    let oilOnRoad = _prefix "oilOnRoad"
    /// <summary>
    /// Increased skid risk due to petrol on road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#petrolOnRoad"></see></summary>
    let petrolOnRoad = _prefix "petrolOnRoad"
    /// <summary>
    /// The road surface is damaged, severely rutted or potholed (i.e. it is in a poor state of repair).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadSurfaceInPoorCondition"></see></summary>
    let roadSurfaceInPoorCondition = _prefix "roadSurfaceInPoorCondition"
    /// <summary>
    /// The road surface is slippery due to an unspecified non-weather related cause.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#slipperyRoad"></see></summary>
    let slipperyRoad = _prefix "slipperyRoad"
    /// <summary>
    /// Traffic may be disrupted due to animals on the roadway.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#animalsOnTheRoad"></see></summary>
    let animalsOnTheRoad = _prefix "animalsOnTheRoad"
    /// <summary>
    /// Traffic may be disrupted due to a herd of animals on the roadway.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#herdOfAnimalsOnTheRoad"></see></summary>
    let herdOfAnimalsOnTheRoad = _prefix "herdOfAnimalsOnTheRoad"
    /// <summary>
    /// Traffic may be disrupted due to large animals on the roadway.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#largeAnimalsOnTheRoad"></see></summary>
    let largeAnimalsOnTheRoad = _prefix "largeAnimalsOnTheRoad"
    /// <summary>
    /// Name of a police force control area.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#policeForceControlAreaName"></see></summary>
    let policeForceControlAreaName = _prefix "policeForceControlAreaName"
    /// <summary>
    /// Traffic flow is of an irregular nature, subject to sudden changes in rates.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#erraticFlow"></see></summary>
    let erraticFlow = _prefix "erraticFlow"
    /// <summary>
    /// Traffic flow is smooth.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#smoothFlow"></see></summary>
    let smoothFlow = _prefix "smoothFlow"
    /// <summary>
    /// Traffic flow is of a stop and go nature with queues forming and ending continuously on the specified section of road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#stopAndGo"></see></summary>
    let stopAndGo = _prefix "stopAndGo"
    /// <summary>
    /// Traffic is blocked at the specified location and in the specified direction due to an unplanned event.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#trafficBlocked"></see></summary>
    let trafficBlocked = _prefix "trafficBlocked"
    /// <summary>
    /// Includes any general delivery channel such as broadcast channels (e.g. radio, tv, RDS-TMC, TPEG services, etc.) or web publishing available to public or to specific users, depending on Service Provider policies.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#anyGeneralDeliveryService"></see></summary>
    let anyGeneralDeliveryService = _prefix "anyGeneralDeliveryService"
    /// <summary>
    /// Specific services which deliver warning alerts to end users to enhance safety via any specific application available to drivers, including C-ITS services.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#safetyServices"></see></summary>
    let safetyServices = _prefix "safetyServices"
    /// <summary>
    /// Variable Message Signs or any other visual roadside devices which information are accessible to drivers which aim to affect driving style improving safety and road network LoS.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#vms"></see></summary>
    let vms = _prefix "vms"
    /// <summary>
    /// The name of the road on which the junction point is located.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tpegIlcName1"></see></summary>
    let tpegIlcName1 = _prefix "tpegIlcName1"
    /// <summary>
    /// The name of the first intersecting road at the junction.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tpegIlcName2"></see></summary>
    let tpegIlcName2 = _prefix "tpegIlcName2"
    /// <summary>
    /// The name of the second intersecting road (if one exists) at the junction.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tpegIlcName3"></see></summary>
    let tpegIlcName3 = _prefix "tpegIlcName3"
    /// <summary>
    /// Delay between one hour and three hours.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#betweenOneHourAndThreeHours"></see></summary>
    let betweenOneHourAndThreeHours = _prefix "betweenOneHourAndThreeHours"
    /// <summary>
    /// Delay between ten minutes and thirty minutes.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#betweenTenMinutesAndThirtyMinutes"></see></summary>
    let betweenTenMinutesAndThirtyMinutes = _prefix "betweenTenMinutesAndThirtyMinutes"
    /// <summary>
    /// Delay between thirty minutes and one hour.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#betweenThirtyMinutesAndOneHour"></see></summary>
    let betweenThirtyMinutesAndOneHour = _prefix "betweenThirtyMinutesAndOneHour"
    /// <summary>
    /// Delay between three hours and six hours.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#betweenThreeHoursAndSixHours"></see></summary>
    let betweenThreeHoursAndSixHours = _prefix "betweenThreeHoursAndSixHours"
    /// <summary>
    /// Delay longer than six hours.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#longerThanSixHours"></see></summary>
    let longerThanSixHours = _prefix "longerThanSixHours"
    /// <summary>
    /// Negligible delay.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#negligible"></see></summary>
    let negligible = _prefix "negligible"
    /// <summary>
    /// Delay up to ten minutes.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#upToTenMinutes"></see></summary>
    let upToTenMinutes = _prefix "upToTenMinutes"
    /// <summary>
    /// A geographic or geometric large area.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#largeArea"></see></summary>
    let largeArea = _prefix "largeArea"
    /// <summary>
    /// Above or over the normal road grade elevation.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#aboveGrade"></see></summary>
    let aboveGrade = _prefix "aboveGrade"
    /// <summary>
    /// At the normal road grade elevation.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#atGrade"></see></summary>
    let atGrade = _prefix "atGrade"
    /// <summary>
    /// Below or under the normal road grade elevation.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#belowGrade"></see></summary>
    let belowGrade = _prefix "belowGrade"
    /// <summary>
    /// On the carriageway or lane which is inbound towards the centre of the town or city.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#inbound"></see></summary>
    let inbound = _prefix "inbound"
    /// <summary>
    /// On the carriageway or lane which is outbound from the centre of the town or city.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#outbound"></see></summary>
    let outbound = _prefix "outbound"
    /// <summary>
    /// Do not follow diversion signs.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#doNotFollowDiversionSigns"></see></summary>
    let doNotFollowDiversionSigns = _prefix "doNotFollowDiversionSigns"
    /// <summary>
    /// Rerouted traffic is not to use the specified entry onto the identified road to commence the alternative route.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#doNotUseEntry"></see></summary>
    let doNotUseEntry = _prefix "doNotUseEntry"
    /// <summary>
    /// Rerouted traffic is not to use the specified exit from the identified road to commence the alternative route.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#doNotUseExit"></see></summary>
    let doNotUseExit = _prefix "doNotUseExit"
    /// <summary>
    /// Rerouted traffic is not to use the specified intersection or junction.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#doNotUseIntersectionOrJunction"></see></summary>
    let doNotUseIntersectionOrJunction = _prefix "doNotUseIntersectionOrJunction"
    /// <summary>
    /// Rerouted traffic is to follow the diversion signs.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#followDiversionSigns"></see></summary>
    let followDiversionSigns = _prefix "followDiversionSigns"
    /// <summary>
    /// Rerouted traffic is to follow local diversion.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#followLocalDiversion"></see></summary>
    let followLocalDiversion = _prefix "followLocalDiversion"
    /// <summary>
    /// Rerouted traffic is to follow the special diversion markers.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#followSpecialMarkers"></see></summary>
    let followSpecialMarkers = _prefix "followSpecialMarkers"
    /// <summary>
    /// Rerouted traffic is to use the specified entry onto the identified road to commence the alternative route.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#useEntry"></see></summary>
    let useEntry = _prefix "useEntry"
    /// <summary>
    /// Rerouted traffic is to use the specified exit from the identified road to commence the alternative route.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#useExit"></see></summary>
    let useExit = _prefix "useExit"
    /// <summary>
    /// Rerouted traffic is to use the specified intersection or junction to commence the alternative route.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#useIntersectionOrJunction"></see></summary>
    let useIntersectionOrJunction = _prefix "useIntersectionOrJunction"
    /// <summary>
    /// Traffic flow normal
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#trafficFlowNormal"></see></summary>
    let trafficFlowNormal = _prefix "trafficFlowNormal"
    /// <summary>
    /// Traffic heavier than normal
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#trafficHeavierThanNormal"></see></summary>
    let trafficHeavierThanNormal = _prefix "trafficHeavierThanNormal"
    /// <summary>
    /// Traffic lighter than normal
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#trafficLighterThanNormal"></see></summary>
    let trafficLighterThanNormal = _prefix "trafficLighterThanNormal"
    /// <summary>
    /// Traffic very much heavier than normal
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#trafficVeryMuchHeavierThanNormal"></see></summary>
    let trafficVeryMuchHeavierThanNormal = _prefix "trafficVeryMuchHeavierThanNormal"
    /// <summary>
    /// Traffic very much lighter than normal
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#trafficVeryMuchLighterThanNormal"></see></summary>
    let trafficVeryMuchLighterThanNormal = _prefix "trafficVeryMuchLighterThanNormal"
    /// <summary>
    /// In all lanes of the carriageway.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#allLanesCompleteCarriageway"></see></summary>
    let allLanesCompleteCarriageway = _prefix "allLanesCompleteCarriageway"
    /// <summary>
    /// In the bus lane.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#busLane"></see></summary>
    let busLane = _prefix "busLane"
    /// <summary>
    /// In the bus stop lane.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#busStop"></see></summary>
    let busStop = _prefix "busStop"
    /// <summary>
    /// In the carpool lane.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#carPoolLane"></see></summary>
    let carPoolLane = _prefix "carPoolLane"
    /// <summary>
    /// On the central reservation separating the two directional carriageways of the highway.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#centralReservation"></see></summary>
    let centralReservation = _prefix "centralReservation"
    /// <summary>
    /// In the crawler lane - a lane that should be used by slower vehicles.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#crawlerLane"></see></summary>
    let crawlerLane = _prefix "crawlerLane"
    /// <summary>
    /// Part of a carriageway designated for cycles. A cycle lane is distinguished from the rest of the carriageway by longitudinal road markings.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#cycleLane"></see></summary>
    let cycleLane = _prefix "cycleLane"
    /// <summary>
    /// In the emergency lane.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#emergencyLane"></see></summary>
    let emergencyLane = _prefix "emergencyLane"
    /// <summary>
    /// In the escape lane.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#escapeLane"></see></summary>
    let escapeLane = _prefix "escapeLane"
    /// <summary>
    /// In the express lane.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#expressLane"></see></summary>
    let expressLane = _prefix "expressLane"
    /// <summary>
    /// On the hard shoulder.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hardShoulder"></see></summary>
    let hardShoulder = _prefix "hardShoulder"
    /// <summary>
    /// In the heavy vehicle lane.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#heavyVehicleLane"></see></summary>
    let heavyVehicleLane = _prefix "heavyVehicleLane"
    /// <summary>
    /// In a lay-by.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#layBy"></see></summary>
    let layBy = _prefix "layBy"
    /// <summary>
    /// In the left hand turning lane.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#leftHandTurningLane"></see></summary>
    let leftHandTurningLane = _prefix "leftHandTurningLane"
    /// <summary>
    /// In the left lane.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#leftLane"></see></summary>
    let leftLane = _prefix "leftLane"
    /// <summary>
    /// In the local traffic lane.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#localTrafficLane"></see></summary>
    let localTrafficLane = _prefix "localTrafficLane"
    /// <summary>
    /// In the middle lane.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#middleLane"></see></summary>
    let middleLane = _prefix "middleLane"
    /// <summary>
    /// In the overtaking lane.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#overtakingLane"></see></summary>
    let overtakingLane = _prefix "overtakingLane"
    /// <summary>
    /// In the right hand turning lane.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#rightHandTurningLane"></see></summary>
    let rightHandTurningLane = _prefix "rightHandTurningLane"
    /// <summary>
    /// In the right lane.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#rightLane"></see></summary>
    let rightLane = _prefix "rightLane"
    /// <summary>
    /// In the lane dedicated for use during the rush (peak) hour.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#rushHourLane"></see></summary>
    let rushHourLane = _prefix "rushHourLane"
    /// <summary>
    /// In the area/lane reserved for passenger pick-up or set-down.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#setDownArea"></see></summary>
    let setDownArea = _prefix "setDownArea"
    /// <summary>
    /// In a lane dedicated to vehicles that are not permitted to exceed a fixed slow speed.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#slowVehicleLane"></see></summary>
    let slowVehicleLane = _prefix "slowVehicleLane"
    /// <summary>
    /// In the through traffic lane.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#throughTrafficLane"></see></summary>
    let throughTrafficLane = _prefix "throughTrafficLane"
    /// <summary>
    /// In the lane dedicated for use as a tidal flow lane.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tidalFlowLane"></see></summary>
    let tidalFlowLane = _prefix "tidalFlowLane"
    /// <summary>
    /// In the turning lane.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#turningLane"></see></summary>
    let turningLane = _prefix "turningLane"
    /// <summary>
    /// On the verge.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#verge"></see></summary>
    let verge = _prefix "verge"

    /// <summary>
    /// Accident involving radioactive material.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#accidentInvolvingRadioactiveMaterial"></see></summary>
    let accidentInvolvingRadioactiveMaterial =
        _prefix "accidentInvolvingRadioactiveMaterial"

    /// <summary>
    /// Application region
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#applicationRegion"></see></summary>
    let applicationRegion = _prefix "applicationRegion"
    /// <summary>
    /// Car park area
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#carParkArea"></see></summary>
    let carParkArea = _prefix "carParkArea"
    /// <summary>
    /// Carpool area
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#carpoolArea"></see></summary>
    let carpoolArea = _prefix "carpoolArea"
    /// <summary>
    /// Continent
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#continent"></see></summary>
    let continent = _prefix "continent"
    /// <summary>
    /// Group of countries.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#countryGroup"></see></summary>
    let countryGroup = _prefix "countryGroup"
    /// <summary>
    /// Fuzzy area
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#fuzzyArea"></see></summary>
    let fuzzyArea = _prefix "fuzzyArea"
    /// <summary>
    /// Industrial area
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#industrialArea"></see></summary>
    let industrialArea = _prefix "industrialArea"
    /// <summary>
    /// Lake
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#lake"></see></summary>
    let lake = _prefix "lake"
    /// <summary>
    /// Meteorological area
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#meteorologicalArea"></see></summary>
    let meteorologicalArea = _prefix "meteorologicalArea"
    /// <summary>
    /// Order 1 administrative area
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#order1AdministrativeArea"></see></summary>
    let order1AdministrativeArea = _prefix "order1AdministrativeArea"
    /// <summary>
    /// Order 2 administrative area
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#order2AdministrativeArea"></see></summary>
    let order2AdministrativeArea = _prefix "order2AdministrativeArea"
    /// <summary>
    /// Order 3 administrative area
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#order3AdministrativeArea"></see></summary>
    let order3AdministrativeArea = _prefix "order3AdministrativeArea"
    /// <summary>
    /// Order 4 administrative area
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#order4AdministrativeArea"></see></summary>
    let order4AdministrativeArea = _prefix "order4AdministrativeArea"
    /// <summary>
    /// Order 5 administrative area
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#order5AdministrativeArea"></see></summary>
    let order5AdministrativeArea = _prefix "order5AdministrativeArea"
    /// <summary>
    /// A park and ride site
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#parkAndRideSite"></see></summary>
    let parkAndRideSite = _prefix "parkAndRideSite"
    /// <summary>
    /// Police force control area
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#policeForceControlArea"></see></summary>
    let policeForceControlArea = _prefix "policeForceControlArea"
    /// <summary>
    /// Road operator control area
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadOperatorControlArea"></see></summary>
    let roadOperatorControlArea = _prefix "roadOperatorControlArea"
    /// <summary>
    /// Rural county
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ruralCounty"></see></summary>
    let ruralCounty = _prefix "ruralCounty"
    /// <summary>
    /// Sea
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#sea"></see></summary>
    let sea = _prefix "sea"
    /// <summary>
    /// Tourist area
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#touristArea"></see></summary>
    let touristArea = _prefix "touristArea"
    /// <summary>
    /// Traffic area
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#trafficArea"></see></summary>
    let trafficArea = _prefix "trafficArea"
    /// <summary>
    /// Urban county
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#urbanCounty"></see></summary>
    let urbanCounty = _prefix "urbanCounty"
    /// <summary>
    /// Water area
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#waterArea"></see></summary>
    let waterArea = _prefix "waterArea"
    /// <summary>
    /// Adverse weather conditions are affecting driving conditions.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#badWeather"></see></summary>
    let badWeather = _prefix "badWeather"
    /// <summary>
    /// Dust blowing across the roadway causing significantly reduced visibility.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#blowingDust"></see></summary>
    let blowingDust = _prefix "blowingDust"
    /// <summary>
    /// Fallen snow moving due to the forces of wind.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#blowingSnow"></see></summary>
    let blowingSnow = _prefix "blowingSnow"
    /// <summary>
    /// Strong cross winds across the direction of the roadway (e.g. on a ridge or bridge).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#crosswinds"></see></summary>
    let crosswinds = _prefix "crosswinds"
    /// <summary>
    /// Abnormally low temperatures.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#extremeCold"></see></summary>
    let extremeCold = _prefix "extremeCold"
    /// <summary>
    /// Abnormally high expected maximum temperature.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#extremeHeat"></see></summary>
    let extremeHeat = _prefix "extremeHeat"
    /// <summary>
    /// Fog, visibility more than 50m.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#fog"></see></summary>
    let fog = _prefix "fog"
    /// <summary>
    /// Frost can be expected.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#frost"></see></summary>
    let frost = _prefix "frost"
    /// <summary>
    /// Small balls of ice and compacted snow.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hail"></see></summary>
    let hail = _prefix "hail"
    /// <summary>
    /// Rain, visibility more than 50m.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#rain"></see></summary>
    let rain = _prefix "rain"
    /// <summary>
    /// Sand blowing across the roadway causing significantly reduced visibility.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#sandStorms"></see></summary>
    let sandStorms = _prefix "sandStorms"
    /// <summary>
    /// Smoke drifting across the roadway causing significantly reduced visibility.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#smokeHazard"></see></summary>
    let smokeHazard = _prefix "smokeHazard"
    /// <summary>
    /// Falling snow, visibility more than 50m.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#snowFall"></see></summary>
    let snowFall = _prefix "snowFall"
    /// <summary>
    /// Winds between 90 km/h and 120 km/h.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#stormForceWinds"></see></summary>
    let stormForceWinds = _prefix "stormForceWinds"
    /// <summary>
    /// Constantly varying winds, strong at times.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#strongGustsOfWinds"></see></summary>
    let strongGustsOfWinds = _prefix "strongGustsOfWinds"
    /// <summary>
    /// Winds between 40 km/h and 60 km/h.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#strongWinds"></see></summary>
    let strongWinds = _prefix "strongWinds"
    /// <summary>
    /// Large numbers of insects which create a hazard for road users through reduced visibility.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#swarmOfInsects"></see></summary>
    let swarmOfInsects = _prefix "swarmOfInsects"
    /// <summary>
    /// Environmental conditions causing reduced visibility.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#visibilityReduced"></see></summary>
    let visibilityReduced = _prefix "visibilityReduced"
    /// <summary>
    /// A traffic condition which is not normal.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AbnormalTraffic"></see></summary>
    let AbnormalTraffic = _prefix "AbnormalTraffic"
    /// <summary>
    /// The number of vehicles waiting in a queue.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#numberOfVehiclesWaiting"></see></summary>
    let numberOfVehiclesWaiting = _prefix "numberOfVehiclesWaiting"
    /// <summary>
    /// A measure of distance defined in metres in a non negative integer format.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#MetresAsNonNegativeIntegerValue"></see></summary>
    let MetresAsNonNegativeIntegerValue = _prefix "MetresAsNonNegativeIntegerValue"
    /// <summary>
    /// The length of a queue or the average length of queues in separate lanes due to a situation.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#queueLength"></see></summary>
    let queueLength = _prefix "queueLength"
    /// <summary>
    /// A characterization of the trend in the traffic conditions at the specified location and direction.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TrafficTrendTypeEnum"></see></summary>
    let TrafficTrendTypeEnum = _prefix "TrafficTrendTypeEnum"
    /// <summary>
    /// A characterization of the trend in the traffic conditions at the specified location and direction.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasTrafficTrendTypeEnum"></see></summary>
    let hasTrafficTrendTypeEnum = _prefix "hasTrafficTrendTypeEnum"
    /// <summary>
    /// The consistency (steadiness) of the traffic flow.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TrafficFlowCharateristicsEnum"></see></summary>
    let TrafficFlowCharateristicsEnum = _prefix "TrafficFlowCharateristicsEnum"
    /// <summary>
    /// The consistency (steadiness) of the traffic flow.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasTrafficFlowCharacteristicsEnum"></see></summary>
    let hasTrafficFlowCharacteristicsEnum = _prefix "hasTrafficFlowCharacteristicsEnum"
    /// <summary>
    /// Assessment of the traffic flow conditions relative to normally expected conditions at this date/time.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#RelativeTrafficFlowEnum"></see></summary>
    let RelativeTrafficFlowEnum = _prefix "RelativeTrafficFlowEnum"
    /// <summary>
    /// Assessment of the traffic flow conditions relative to normally expected conditions at this date/time.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasRelativeTrafficFlowEnum"></see></summary>
    let hasRelativeTrafficFlowEnum = _prefix "hasRelativeTrafficFlowEnum"
    /// <summary>
    /// Descriptive terms for abnormal traffic conditions specifically relating to the nature of the traffic movement, implying levels of service.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AbnormalTrafficTypeEnum"></see></summary>
    let AbnormalTrafficTypeEnum = _prefix "AbnormalTrafficTypeEnum"
    /// <summary>
    /// A characterization of the nature of abnormal traffic flow, i.e. specifically relating to the nature of the traffic movement, implying a level of service.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAbnormalTrafficType"></see></summary>
    let hasAbnormalTrafficType = _prefix "hasAbnormalTrafficType"
    /// <summary>
    /// An event which is not planned by the traffic operator, which is affecting, or has the potential to affect traffic flow.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TrafficElement"></see></summary>
    let TrafficElement = _prefix "TrafficElement"
    /// <summary>
    /// Collects the added non-SRTI enumerations. Only for organizational purposes
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Non-SRTI_Enum"></see></summary>
    let ``Non-SRTI_Enum`` = _prefix "Non-SRTI_Enum"
    /// <summary>
    /// Accidents are events where one or more vehicles are involved in collisions or in leaving the roadway. These include collisions between vehicles or with other road users or obstacles.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Accident"></see></summary>
    let Accident = _prefix "Accident"
    /// <summary>
    /// Collection of descriptive terms for types of accidents.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AccidentTypeEnum"></see></summary>
    let AccidentTypeEnum = _prefix "AccidentTypeEnum"
    /// <summary>
    /// A characterization of the nature of the accident.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAccidentType"></see></summary>
    let hasAccidentType = _prefix "hasAccidentType"
    /// <summary>
    /// Any stationary or moving obstacle of a physical nature (e.g. obstacles or vehicles from an earlier accident, shed loads on carriageway, rock fall, abnormal or dangerous loads, or animals etc.) which could disrupt or endanger traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Obstruction"></see></summary>
    let Obstruction = _prefix "Obstruction"
    /// <summary>
    /// Any conditions which have the potential to degrade normal driving conditions.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Conditions"></see></summary>
    let Conditions = _prefix "Conditions"
    /// <summary>
    /// Collection of descriptive terms for causes of accidents.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AccidentCauseEnum"></see></summary>
    let AccidentCauseEnum = _prefix "AccidentCauseEnum"
    /// <summary>
    /// Only for organizational purposes
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#SituationEnumerations"></see></summary>
    let SituationEnumerations = _prefix "SituationEnumerations"
    /// <summary>
    /// A collection of information relating to human activities external to the traffic stream or roadway which could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Activity"></see></summary>
    let Activity = _prefix "Activity"
    /// <summary>
    /// An indication of whether the associated instance of a SituationRecord is mobile (e.g. a march or parade moving along a road) or stationary.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Mobility"></see></summary>
    let Mobility = _prefix "Mobility"
    /// <summary>
    /// Specifies the mobility of activity
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasMobilityOfActivity"></see></summary>
    let hasMobilityOfActivity = _prefix "hasMobilityOfActivity"
    /// <summary>
    /// Alert C location
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertC"></see></summary>
    let AlertC = _prefix "AlertC"
    /// <summary>
    /// Only for organizational purposes
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#LocationObjects"></see></summary>
    let LocationObjects = _prefix "LocationObjects"
    /// <summary>
    /// An area defined by reference to a predefined ALERT-C location table.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertCArea"></see></summary>
    let AlertCArea = _prefix "AlertCArea"
    /// <summary>
    /// Version number associated with an ALERT-C table reference.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#alertCLocationTableVersion"></see></summary>
    let alertCLocationTableVersion = _prefix "alertCLocationTableVersion"
    /// <summary>
    /// Number allocated to an ALERT-C table in a country. Ref. EN ISO 14819-3 for the allocation of a location table number.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#alertCLocationTableNumber"></see></summary>
    let alertCLocationTableNumber = _prefix "alertCLocationTableNumber"
    /// <summary>
    /// ALERT-C country code as defined in IEC 62106.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#alertCLocationCountryCode"></see></summary>
    let alertCLocationCountryCode = _prefix "alertCLocationCountryCode"
    /// <summary>
    /// Identification of a specific point, linear or area location in an ALERT-C location table.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertCLocation"></see></summary>
    let AlertCLocation = _prefix "AlertCLocation"
    /// <summary>
    /// Identification of a specific point, linear or area location in an ALERT-C location table.
    /// ALERT-C location
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAlertCLocation"></see></summary>
    let hasAlertCLocation = _prefix "hasAlertCLocation"
    /// <summary>
    /// The direction of traffic flow along the road to which the information relates.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertCDirection"></see></summary>
    let AlertCDirection = _prefix "AlertCDirection"
    /// <summary>
    /// Direction used to reach the primary location from the secondary location in ALERT-C location table, as defined in CEN ISO 14819-1
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertCDirectionEnum"></see></summary>
    let AlertCDirectionEnum = _prefix "AlertCDirectionEnum"
    /// <summary>
    /// Direction of navigation with respect to secondary to primary location (RDS direction)
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAlertCDirectionCoded"></see></summary>
    let hasAlertCDirectionCoded = _prefix "hasAlertCDirectionCoded"
    /// <summary>
    /// Directions of traffic flow relative to the direction in which the linear element is defined.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#LinearDirectionEnum"></see></summary>
    let LinearDirectionEnum = _prefix "LinearDirectionEnum"
    /// <summary>
    /// The direction(s) of traffic flow to which the situation, traffic data or information is related.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAlertCAffectedDirection"></see></summary>
    let hasAlertCAffectedDirection = _prefix "hasAlertCAffectedDirection"
    /// <summary>
    /// Only for organizational purposes
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#LocationReferencingEnumerations"></see></summary>
    let LocationReferencingEnumerations = _prefix "LocationReferencingEnumerations"
    /// <summary>
    /// A linear section along a road defined between two points on the road by reference to a pre-defined ALERT-C location table. When there are multiple instances of AlertCLinear they should represent the same location using different location tables.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertCLinear"></see></summary>
    let AlertCLinear = _prefix "AlertCLinear"
    /// <summary>
    /// A linear section along a road defined by reference to a linear section in a pre-defined ALERT-C location table.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertCLinearByCode"></see></summary>
    let AlertCLinearByCode = _prefix "AlertCLinearByCode"
    /// <summary>
    /// Specific location. Unique code within the ALERT-C location table which identifies the specific point, linear or area location.Unique code within the ALERT-C location table which identifies the specific point, linear or area location.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasLocationCodeForLinearLocation"></see></summary>
    let hasLocationCodeForLinearLocation = _prefix "hasLocationCodeForLinearLocation"
    /// <summary>
    /// The direction of traffic flow along the road to which the information relates.
    /// ALERT-C direction
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAlertCDirection"></see></summary>
    let hasAlertCDirection = _prefix "hasAlertCDirection"
    /// <summary>
    /// A linear section along a road between two points, primary and secondary, which are pre-defined in an ALERT-C location table. Direction is FROM the secondary point TO the primary point, i.e. the primary point is downstream of the secondary point.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertCMethod2Linear"></see></summary>
    let AlertCMethod2Linear = _prefix "AlertCMethod2Linear"

    /// <summary>
    /// The point (called Secondary point) which is at the upstream end of a linear road section. The point is specified by a reference to a point in a pre-defined ALERT-C location table.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertCMethod2SecondaryPointLocation"></see></summary>
    let AlertCMethod2SecondaryPointLocation =
        _prefix "AlertCMethod2SecondaryPointLocation"

    /// <summary>
    /// The point (called Secondary point) which is at the upstream end of a linear road section. The point is specified by a reference to a point in a pre-defined ALERT-C location table.
    /// ALERT-C method2 secondary point location
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAlertCMethod2SecondaryPointLocation"></see></summary>
    let hasAlertCMethod2SecondaryPointLocation =
        _prefix "hasAlertCMethod2SecondaryPointLocation"

    /// <summary>
    /// The point (called Primary point) which is either a single point or at the downstream end of a linear road section. The point is specified by a reference to a point in a pre-defined ALERT-C location table.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertCMethod2PrimaryPointLocation"></see></summary>
    let AlertCMethod2PrimaryPointLocation = _prefix "AlertCMethod2PrimaryPointLocation"

    /// <summary>
    /// The point (called Primary point) which is either a single point or at the downstream end of a linear road section. The point is specified by a reference to a point in a pre-defined ALERT-C location table.
    /// ALERT-C method2 primary point location
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAlertCMethod2PrimaryPointLocation"></see></summary>
    let hasAlertCMethod2PrimaryPointLocation =
        _prefix "hasAlertCMethod2PrimaryPointLocation"

    /// <summary>
    /// A single point on the road network defined by reference to a point in a pre-defined ALERT-C location table and which has an associated direction of traffic flow.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertCMethod2Point"></see></summary>
    let AlertCMethod2Point = _prefix "AlertCMethod2Point"
    /// <summary>
    /// A single point on the road network defined by reference to a pre-defined ALERT-C location table and which has an associated direction of traffic flow.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertCPoint"></see></summary>
    let AlertCPoint = _prefix "AlertCPoint"
    /// <summary>
    /// A linear section along a road between two points, primary and secondary, which are pre-defined ALERT-C locations plus offset distance. Direction is FROM the secondary point TO the primary point, i.e. the primary point is downstream of the secondary point.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertCMethod4Linear"></see></summary>
    let AlertCMethod4Linear = _prefix "AlertCMethod4Linear"

    /// <summary>
    /// The point (called Secondary point) which is at the upstream end of a linear road section. The point is specified by a reference to a point in a pre-defined Alert-C location table plus a non-negative offset distance.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertCMethod4SecondaryPointLocation"></see></summary>
    let AlertCMethod4SecondaryPointLocation =
        _prefix "AlertCMethod4SecondaryPointLocation"

    /// <summary>
    /// The point (called Secondary point) which is at the upstream end of a linear road section. The point is specified by a reference to a point in a pre-defined Alert-C location table plus a non-negative offset distance.
    /// ALERT-C method4 secondary point location
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAlertCMethod4SecondaryPointLocation"></see></summary>
    let hasAlertCMethod4SecondaryPointLocation =
        _prefix "hasAlertCMethod4SecondaryPointLocation"

    /// <summary>
    /// The point (called Primary point) which is either a single point or at the downstream end of a linear road section. The point is specified by a reference to a point in a pre-defined ALERT-C location table plus a non-negative offset distance.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertCMethod4PrimaryPointLocation"></see></summary>
    let AlertCMethod4PrimaryPointLocation = _prefix "AlertCMethod4PrimaryPointLocation"

    /// <summary>
    /// The point (called Primary point) which is either a single point or at the downstream end of a linear road section. The point is specified by a reference to a point in a pre-defined ALERT-C location table plus a non-negative offset distance.
    /// ALERT-C method4 primary point location
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAlertCMethod4PrimaryPointLocation"></see></summary>
    let hasAlertCMethod4PrimaryPointLocation =
        _prefix "hasAlertCMethod4PrimaryPointLocation"

    /// <summary>
    /// A single point on the road network defined by reference to a point in a pre-defined ALERT-C location table plus an offset distance and which has an associated direction of traffic flow.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertCMethod4Point"></see></summary>
    let AlertCMethod4Point = _prefix "AlertCMethod4Point"
    /// <summary>
    /// The non-negative offset distance from the ALERT-C referenced point to the actual point.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OffsetDistance"></see></summary>
    let OffsetDistance = _prefix "OffsetDistance"
    /// <summary>
    /// The non-negative offset distance from the ALERT-C referenced point to the actual point.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOffsetDistance"></see></summary>
    let hasOffsetDistance = _prefix "hasOffsetDistance"
    /// <summary>
    /// A point on the road network which is either a junction point or a non junction point.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegPoint"></see></summary>
    let TpegPoint = _prefix "TpegPoint"
    /// <summary>
    /// Coded level of vertical accuracy
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AltitudeAccuracyEnum"></see></summary>
    let AltitudeAccuracyEnum = _prefix "AltitudeAccuracyEnum"
    /// <summary>
    /// Evaluation of the altitude confidence assessed according to ETSI ISO 102894-2
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AltitudeConfidence"></see></summary>
    let AltitudeConfidence = _prefix "AltitudeConfidence"
    /// <summary>
    /// Error code for horizontal or vertical position confidence
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PositionConfidenceCodedErrorEnum"></see></summary>
    let PositionConfidenceCodedErrorEnum = _prefix "PositionConfidenceCodedErrorEnum"

    /// <summary>
    /// Error code in case the altitude confidence is out of range or cannot be determined
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasPositionConfidenceCodedErrorEnum"></see></summary>
    let hasPositionConfidenceCodedErrorEnum =
        _prefix "hasPositionConfidenceCodedErrorEnum"

    /// <summary>
    /// Absolute accuracy of reported value of a geographical point for a confidence level expressed by a coded scale.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAltitudeAccuracyCodedValue"></see></summary>
    let hasAltitudeAccuracyCodedValue = _prefix "hasAltitudeAccuracyCodedValue"
    /// <summary>
    /// Third coordinate for points defined geodetically
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#HeightCoordinateAssociationFrom"></see></summary>
    let HeightCoordinateAssociationFrom = _prefix "HeightCoordinateAssociationFrom"
    /// <summary>
    /// A measured or  value of Angles. An integer number representing an angle in whole degrees between 0 and 359.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AngleInDegreesValue"></see></summary>
    let AngleInDegreesValue = _prefix "AngleInDegreesValue"
    /// <summary>
    /// An obstruction on the road resulting from the presence of animals.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AnimalPresenceObstruction"></see></summary>
    let AnimalPresenceObstruction = _prefix "AnimalPresenceObstruction"
    /// <summary>
    /// Types of animal presence.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AnimalPresenceTypeEmum"></see></summary>
    let AnimalPresenceTypeEmum = _prefix "AnimalPresenceTypeEmum"
    /// <summary>
    /// Indicates the nature of animals present on or near the roadway.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAnimalPresenceTypeEnum"></see></summary>
    let hasAnimalPresenceTypeEnum = _prefix "hasAnimalPresenceTypeEnum"
    /// <summary>
    /// An obstruction on the road caused by one or more vehicles.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#VehicleObstruction"></see></summary>
    let VehicleObstruction = _prefix "VehicleObstruction"
    /// <summary>
    /// Any stationary or moving obstacle of a physical nature, other than of an animal, vehicle, environmental, or damaged equipment nature.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#GeneralObstruction"></see></summary>
    let GeneralObstruction = _prefix "GeneralObstruction"
    /// <summary>
    /// An obstruction on the road resulting from an environmental cause.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#EnvironmentalObstruction"></see></summary>
    let EnvironmentalObstruction = _prefix "EnvironmentalObstruction"
    /// <summary>
    /// Location representing a geographic or geometric defined area which may be qualified by height information to provide additional geospatial discrimination (e.g. for snow in an area but only above a certain altitude). Associations:
    /// 0..*	AlertCArea
    /// 0..1	TpegAreaLocation
    /// 0..1	NamedArea
    /// 0..1	GmlMultiPolygon
    /// 0..1	OpenlrAreaLocationReference
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AreaLocation"></see></summary>
    let AreaLocation = _prefix "AreaLocation"
    /// <summary>
    /// A geographic or geometric area defined by a TPEG-Loc structure which may include height information for additional geospatial discrimination
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegAreaLocation"></see></summary>
    let TpegAreaLocation = _prefix "TpegAreaLocation"
    /// <summary>
    /// A geographic or geometric area defined by a TPEG-Loc structure which may include height information for additional geospatial discrimination.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasTpegAreaLocation"></see></summary>
    let hasTpegAreaLocation = _prefix "hasTpegAreaLocation"
    /// <summary>
    /// A two-dimensional part of the surface of the earth which is bounded by a closed curve. An area location may cover parts of the road network but does not necessarily need to. It is represented according to the OpenLR standard for Area Locations
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrAreaLocationReference"></see></summary>
    let OpenlrAreaLocationReference = _prefix "OpenlrAreaLocationReference"
    /// <summary>
    /// A two-dimensional part of the surface of the earth which is bounded by a closed curve. An area location may cover parts of the road network but does not necessarily need to. It is represented according to the OpenLR standard for Area Locations
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrAreaLocationReference"></see></summary>
    let hasOpenlrAreaLocationReference = _prefix "hasOpenlrAreaLocationReference"
    /// <summary>
    /// An area defined by a name and/or in terms of known boundaries, such as country or county boundaries or allocated control area of particular authority. The attributes do not form a union; instead, the smallest intersection forms the resulting area.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#NamedArea"></see></summary>
    let NamedArea = _prefix "NamedArea"
    /// <summary>
    /// An area defined by a name and/or in terms of known boundaries, such as country or county boundaries or allocated control area of particular authority. The attributes do not form a union; instead, the smallest intersection forms the resulting area.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasNamedArea"></see></summary>
    let hasNamedArea = _prefix "hasNamedArea"
    /// <summary>
    /// An area defined by a set of polygons acording to GML (EN ISO 19136).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#GmlMultiPolygon"></see></summary>
    let GmlMultiPolygon = _prefix "GmlMultiPolygon"
    /// <summary>
    /// An area defined by a set of polygons acording to GML (EN ISO 19136).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasGmlMultiPolygon"></see></summary>
    let hasGmlMultiPolygon = _prefix "hasGmlMultiPolygon"
    /// <summary>
    /// Type of area place(s)
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AreaPlacesEnum"></see></summary>
    let AreaPlacesEnum = _prefix "AreaPlacesEnum"
    /// <summary>
    /// Places, in generic terms, at which the corresponding information applies.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAreaPlacesEnum"></see></summary>
    let hasAreaPlacesEnum = _prefix "hasAreaPlacesEnum"
    /// <summary>
    /// The specification of a location either on a network (as a point or a linear location) or as an area. This may be provided in one or more referencing systems. Association: 0..1PointCoordinates. In SRTI is not included LocationByReference.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Location"></see></summary>
    let Location = _prefix "Location"
    /// <summary>
    /// Supplementary positional information which details carriageway and lane locations. Several instances may exist where the element being described extends over more than one carriageway.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Carriageway"></see></summary>
    let Carriageway = _prefix "Carriageway"
    /// <summary>
    /// Normal number of lanes, potentially available for moving traffic, before reduction due to situations. Hard shoulder should not be counted unless it is sometimes used operationally for moving traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#originalNumberOfLanes"></see></summary>
    let originalNumberOfLanes = _prefix "originalNumberOfLanes"
    /// <summary>
    /// List of descriptors identifying specific carriageway details.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#CarriagewayEnum"></see></summary>
    let CarriagewayEnum = _prefix "CarriagewayEnum"
    /// <summary>
    /// Indicates the section of carriageway to which the location relates.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasCarriagewayEnum"></see></summary>
    let hasCarriagewayEnum = _prefix "hasCarriagewayEnum"
    /// <summary>
    /// Supplementary positional information
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#SupplementaryPositionalPack"></see></summary>
    let SupplementaryPositionalPack = _prefix "SupplementaryPositionalPack"
    /// <summary>
    /// Types of causes of situations which are not managed or are off network.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#CauseTypeEnum"></see></summary>
    let CauseTypeEnum = _prefix "CauseTypeEnum"
    /// <summary>
    /// Common classes
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#CommonClasses"></see></summary>
    let CommonClasses = _prefix "CommonClasses"
    /// <summary>
    /// Types of computational methods used in deriving data values for data sets.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ComputationMethodEnum"></see></summary>
    let ComputationMethodEnum = _prefix "ComputationMethodEnum"
    /// <summary>
    /// Only for organizational purposes
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PayLoadEnumerations"></see></summary>
    let PayLoadEnumerations = _prefix "PayLoadEnumerations"
    /// <summary>
    /// Types of the perceived driving conditions.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#DrivingConditionTypeEnum"></see></summary>
    let DrivingConditionTypeEnum = _prefix "DrivingConditionTypeEnum"
    /// <summary>
    /// Types of the perceived driving conditions.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasDrivingConditionTypeEnum"></see></summary>
    let hasDrivingConditionTypeEnum = _prefix "hasDrivingConditionTypeEnum"
    /// <summary>
    /// &lt;&lt;enumeration&gt;&gt; Values of confidentiality.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ConfidentialityValueEnum"></see></summary>
    let ConfidentialityValueEnum = _prefix "ConfidentialityValueEnum"
    /// <summary>
    /// Types of works relating to construction.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ConstructionWorkTypeEnum"></see></summary>
    let ConstructionWorkTypeEnum = _prefix "ConstructionWorkTypeEnum"
    /// <summary>
    /// Roadworks involving the construction of new infrastructure.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ConstructionWorks"></see></summary>
    let ConstructionWorks = _prefix "ConstructionWorks"
    /// <summary>
    /// The type of construction work being performed.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasConstructionWorkType"></see></summary>
    let hasConstructionWorkType = _prefix "hasConstructionWorkType"
    /// <summary>
    /// Highway maintenance, installation and construction activities that may potentially affect traffic operations.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#RoadWorks"></see></summary>
    let RoadWorks = _prefix "RoadWorks"
    /// <summary>
    /// A data value of something that can be measured or calculated. Any provided meta-data values specified in the attributes override any specified generic characteristics such as defined for a specific measurement in the MeasurementSiteTable.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#DataValue"></see></summary>
    let DataValue = _prefix "DataValue"
    /// <summary>
    /// The number of input values used in the sampling or measurement period to determine the data value.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#numberOfInputValuesUsed"></see></summary>
    let numberOfInputValuesUsed = _prefix "numberOfInputValuesUsed"
    /// <summary>
    /// The reason why the value is deemed to be erroneous by the supplier.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#reasonForDataError"></see></summary>
    let reasonForDataError = _prefix "reasonForDataError"
    /// <summary>
    /// The number of inputs detected but not completed during the sampling or measurement period; e.g. vehicles detected entering but not exiting the detection zone.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#numberOfIncompleteInputs"></see></summary>
    let numberOfIncompleteInputs = _prefix "numberOfIncompleteInputs"
    /// <summary>
    /// The standard deviation of the sample of input values from which this value was derived, measured in the units of the data value.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#standardDeviation"></see></summary>
    let standardDeviation = _prefix "standardDeviation"
    /// <summary>
    /// Indication of whether the value is deemed to be erroneous by the supplier (true = erroneous). If not present, the data value is assumed to be ok. This may be used when automatic fault detection information relating to sensors is available.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#dataError"></see></summary>
    let dataError = _prefix "dataError"
    /// <summary>
    /// A measure of data quality assigned to the value by the supplier. 100% equates to ideal/perfect quality. The method of calculation is supplier specific and needs to be agreed between supplier and client.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#supplierCalculatedDataQuality"></see></summary>
    let supplierCalculatedDataQuality = _prefix "supplierCalculatedDataQuality"
    /// <summary>
    /// Method of computation which has been used to compute this data value.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasComputationMethodEnum"></see></summary>
    let hasComputationMethodEnum = _prefix "hasComputationMethodEnum"
    /// <summary>
    /// The extent to which the value is expected to be free from error, measured as a percentage of the data value. 100% means fully accurate.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#accuracy"></see></summary>
    let accuracy = _prefix "accuracy"
    /// <summary>
    /// Coefficient required when a moving average is computed to give specific weights to the former average and the new data. A typical formula is, F being the smoothing factor: New average = (old average) F + (new data) (1 - F).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#smoothingFactor"></see></summary>
    let smoothingFactor = _prefix "smoothingFactor"
    /// <summary>
    /// The time band within which the additional travel time due to adverse travel conditions of any kind falls, when compared to "normal conditions".
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#DelayBandEnum"></see></summary>
    let DelayBandEnum = _prefix "DelayBandEnum"
    /// <summary>
    /// The details of the delays being caused by the situation element defined in the situation record. It is recommended to only use one of the optional attributes to avoid confusion.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Delays"></see></summary>
    let Delays = _prefix "Delays"
    /// <summary>
    /// The value of the additional travel time due to adverse travel conditions of any kind, when compared to "normal conditions", given in seconds.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#delayTimeValue"></see></summary>
    let delayTimeValue = _prefix "delayTimeValue"
    /// <summary>
    /// Coarse classification of the delay.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#DelaysTypeEnum"></see></summary>
    let DelaysTypeEnum = _prefix "DelaysTypeEnum"
    /// <summary>
    /// Coarse classification of the delay.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#delaysType"></see></summary>
    let delaysType = _prefix "delaysType"
    /// <summary>
    /// The time band within which the additional travel time due to adverse travel conditions of any kind falls, when compared to "normal conditions".
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#delayBand"></see></summary>
    let delayBand = _prefix "delayBand"
    /// <summary>
    /// List of directions of travel.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#DirectionEnum"></see></summary>
    let DirectionEnum = _prefix "DirectionEnum"
    /// <summary>
    /// Main purpose of a direction of a road
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#DirectionPurposeEnum"></see></summary>
    let DirectionPurposeEnum = _prefix "DirectionPurposeEnum"
    /// <summary>
    /// Distance of a point along a linear element either measured from the start node or a defined referent on that linear element, where the start node is relative to the element definition rather than the direction of traffic flow.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#DistanceAlongLinearElement"></see></summary>
    let DistanceAlongLinearElement = _prefix "DistanceAlongLinearElement"
    /// <summary>
    /// Only for organizational purposes.Package LinearReferencing
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#LinearReferencing"></see></summary>
    let LinearReferencing = _prefix "LinearReferencing"
    /// <summary>
    /// Distance of a point along a linear element measured from a "from referent" on the linear element, in the sense relative to the linear element definition rather than the direction of traffic flow or optionally towards a "towards referent".
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#DistanceFromLinearElementReferent"></see></summary>
    let DistanceFromLinearElementReferent = _prefix "DistanceFromLinearElementReferent"
    /// <summary>
    /// A referent on a linear object that has a known location such as a node, a reference marker (e.g. a marker-post), an intersection etc.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Referent"></see></summary>
    let Referent = _prefix "Referent"
    /// <summary>
    /// A known location along the linear element towards which the distanceAlong is measured, termed the "towardsReferent" in EN ISO 19148.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasReferentTowards"></see></summary>
    let hasReferentTowards = _prefix "hasReferentTowards"
    /// <summary>
    /// A known location along the linear element from which the distanceAlong is measured, termed the "fromReferent" in EN ISO 19148.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasReferentFrom"></see></summary>
    let hasReferentFrom = _prefix "hasReferentFrom"
    /// <summary>
    /// A measure of distance defined in metres in a floating point format.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#MetresAsFloatValue"></see></summary>
    let MetresAsFloatValue = _prefix "MetresAsFloatValue"
    /// <summary>
    /// A measure of distance along a linear element.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#distanceAlong"></see></summary>
    let distanceAlong = _prefix "distanceAlong"
    /// <summary>
    /// Distance of a point along a linear element measured from the start node of the linear element, where start node is relative to the element definition rather than the direction of traffic flow.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#DistanceFromLinearElementStart"></see></summary>
    let DistanceFromLinearElementStart = _prefix "DistanceFromLinearElementStart"
    /// <summary>
    /// Deliberate human action of either a public disorder nature or of a situation alert type which could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#DisturbanceActivity"></see></summary>
    let DisturbanceActivity = _prefix "DisturbanceActivity"
    /// <summary>
    /// Types of disturbance activities.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#DisturbanceActivityTypeEnum"></see></summary>
    let DisturbanceActivityTypeEnum = _prefix "DisturbanceActivityTypeEnum"
    /// <summary>
    /// Data Dictionary.This clause contains the definitions of all enumerations which are used.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Enums"></see></summary>
    let Enums = _prefix "Enums"
    /// <summary>
    /// Types of environmental obstructions.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#EnvironmentalObstructionTypeEnum"></see></summary>
    let EnvironmentalObstructionTypeEnum = _prefix "EnvironmentalObstructionTypeEnum"

    /// <summary>
    /// Characterization of an obstruction on the road resulting from an environmental cause.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasEnvironmentalObstructionTypeEnum"></see></summary>
    let hasEnvironmentalObstructionTypeEnum =
        _prefix "hasEnvironmentalObstructionTypeEnum"

    /// <summary>
    /// General instruction and/or message that is issued by the network/road operator which is applicable to drivers and sometimes passengers.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#GeneralInstructionOrMessageToRoadUsers"></see></summary>
    let GeneralInstructionOrMessageToRoadUsers =
        _prefix "GeneralInstructionOrMessageToRoadUsers"

    /// <summary>
    /// General message that is issued by the network/road operator which is applicable to drivers and sometimes passengers, e.g. details about an amber alert (missing or abducted child alert).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#generalMessageToRoadUsers"></see></summary>
    let generalMessageToRoadUsers = _prefix "generalMessageToRoadUsers"

    /// <summary>
    /// General instructions that may be issued to road users (specifically drivers and sometimes passengers) by an operator or operational system in support of network management activities or emergency situations.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#GeneralInstructionOrMessageToRoadUsersTypeEnum"></see></summary>
    let GeneralInstructionOrMessageToRoadUsersTypeEnum =
        _prefix "GeneralInstructionOrMessageToRoadUsersTypeEnum"

    /// <summary>
    /// General instruction that is issued by the network/road operator which is applicable to drivers and sometimes passengers.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasGeneralInstructionOrMessageToRoadUsersType"></see></summary>
    let hasGeneralInstructionOrMessageToRoadUsersType =
        _prefix "hasGeneralInstructionOrMessageToRoadUsersType"

    /// <summary>
    /// Restrictions on road usage, whether by legal order or by operational decisions. It includes road and lane closures, weight and dimensional limits, banned turns, contraflows and alternate traffic operations.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#NetworkManagement"></see></summary>
    let NetworkManagement = _prefix "NetworkManagement"
    /// <summary>
    /// Network management action which is applicable to the road network and its users. "trafficManuallyDirectedBy" is only valid if "hasGeneralNetworkManagementTypeEnum" is set to "trafficBeingManuallyDirected".
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#GeneralNetworkManagement"></see></summary>
    let GeneralNetworkManagement = _prefix "GeneralNetworkManagement"
    /// <summary>
    /// Categories of person.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PersonCategoryEnum"></see></summary>
    let PersonCategoryEnum = _prefix "PersonCategoryEnum"
    /// <summary>
    /// Type of person that is manually directing traffic (applicable if generalNetworkManagementType is set to "trafficBeingManuallyDirected").
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#trafficManuallyDirectedBy"></see></summary>
    let trafficManuallyDirectedBy = _prefix "trafficManuallyDirectedBy"
    /// <summary>
    /// Types of network management actions.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#GeneralNetworkManagementTypeEnum"></see></summary>
    let GeneralNetworkManagementTypeEnum = _prefix "GeneralNetworkManagementTypeEnum"
    /// <summary>
    /// The type of traffic management action instigated by the network/road operator.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasGeneralNetworkManagementType"></see></summary>
    let hasGeneralNetworkManagementType = _prefix "hasGeneralNetworkManagementType"
    /// <summary>
    /// Types of obstructions on the roadway.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ObstructionTypeEnum"></see></summary>
    let ObstructionTypeEnum = _prefix "ObstructionTypeEnum"
    /// <summary>
    /// Characterization of the type of general obstruction.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasObstructionTypeEnum"></see></summary>
    let hasObstructionTypeEnum = _prefix "hasObstructionTypeEnum"
    /// <summary>
    /// The OGC GeoSPARQL standard supports representing and querying geospatial data on the Semantic Web. GeoSPARQL defines a vocabulary for representing geospatial data in RDF, and it defines an extension to the SPARQL query language for processing geospatial data.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#GeoSparqlClasses"></see></summary>
    let GeoSparqlClasses = _prefix "GeoSparqlClasses"
    /// <summary>
    /// Only for organizational purposes
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ImportedClasses"></see></summary>
    let ImportedClasses = _prefix "ImportedClasses"
    /// <summary>
    /// Geo WGS84 vocabulary
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Geo_WGS84"></see></summary>
    let Geo_WGS84 = _prefix "Geo_WGS84"
    /// <summary>
    /// Descriptor to help to identify a specific location.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#GeographicCharacteristicEnum"></see></summary>
    let GeographicCharacteristicEnum = _prefix "GeographicCharacteristicEnum"
    /// <summary>
    /// GML location
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Gml"></see></summary>
    let Gml = _prefix "Gml"
    /// <summary>
    /// Line string based on GML (EN ISO 19136) definition: a curve defined by a series of two or more coordinate tuples. Unlike GML may be self-intersecting. If srsName attribute is not present, posList is assumed to use "ETRS89-LatLonh" reference system.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#GmlLineString"></see></summary>
    let GmlLineString = _prefix "GmlLineString"
    /// <summary>
    /// Specifies the Coordinate Reference System (CRS) used to interpret the coordinates in this GmlLineString
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#srsName"></see></summary>
    let srsName = _prefix "srsName"
    /// <summary>
    /// Provides the size of the tuple of coordinates of each point. This number is 2 or 3. By default when omitted the dimension shall be interpreted as 2.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#srsDimension"></see></summary>
    let srsDimension = _prefix "srsDimension"
    /// <summary>
    /// List of coordinate Tuples define the geometry of this GmlLineString. There must be at least 2 Tuples of coordinates.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#gmlPosList"></see></summary>
    let gmlPosList = _prefix "gmlPosList"
    /// <summary>
    /// Closed line string not self-intersecting (i.e. having as last point the first point)
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#GmlLinearRing"></see></summary>
    let GmlLinearRing = _prefix "GmlLinearRing"
    /// <summary>
    /// Name of the multi-polygon area
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#gmlAreaName"></see></summary>
    let gmlAreaName = _prefix "gmlAreaName"
    /// <summary>
    /// Planar surface defined by 1 exterior boundary and 0 or more interior boundaries
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#GmlPolygon"></see></summary>
    let GmlPolygon = _prefix "GmlPolygon"
    /// <summary>
    /// Planar surface defined by 1 exterior boundary and 0 or more interior boundaries
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasGmlPolygon"></see></summary>
    let hasGmlPolygon = _prefix "hasGmlPolygon"
    /// <summary>
    /// A boundary of a polygonal surface consisting of a ring i.e. in the normal 2D case, a closed polygonal line distinguished as exterior. Such a polygonal line has at least 4 pairs of coordinates
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasGmlExteriorLinearRing"></see></summary>
    let hasGmlExteriorLinearRing = _prefix "hasGmlExteriorLinearRing"
    /// <summary>
    /// Management information relating to the data contained within a publication.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#HeaderInformation"></see></summary>
    let HeaderInformation = _prefix "HeaderInformation"
    /// <summary>
    /// Status of the related information (i.e. real, test or exercise).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#InformationStatusEnum"></see></summary>
    let InformationStatusEnum = _prefix "InformationStatusEnum"
    /// <summary>
    /// The status of the related information (real, test, exercise ....).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasInformationStatus"></see></summary>
    let hasInformationStatus = _prefix "hasInformationStatus"
    /// <summary>
    /// The extent to which the related information may be circulated, according to the recipient type. Recipients must comply with this confidentiality statement.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasConfidentiality"></see></summary>
    let hasConfidentiality = _prefix "hasConfidentiality"
    /// <summary>
    /// Third coordinate for points defined geodetically
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#HeightCoordinate"></see></summary>
    let HeightCoordinate = _prefix "HeightCoordinate"
    /// <summary>
    /// Value in metres for the height measured vertically at to the planar coordinates the point corresponding.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#heightValue"></see></summary>
    let heightValue = _prefix "heightValue"
    /// <summary>
    /// Horizontal position accuracy parameters defined according to EN 16803-1
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PositionAccuracy"></see></summary>
    let PositionAccuracy = _prefix "PositionAccuracy"
    /// <summary>
    /// Defines the horizontal position accuracy according EN 16803-1
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasVerticalPositionAccuracy"></see></summary>
    let hasVerticalPositionAccuracy = _prefix "hasVerticalPositionAccuracy"
    /// <summary>
    /// Coded value for type of height
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#HeightTypeEnum"></see></summary>
    let HeightTypeEnum = _prefix "HeightTypeEnum"
    /// <summary>
    /// Type of measured height.When it is omitted it is supposed to be the ellipsoidal height.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasHeightTypeEnum"></see></summary>
    let hasHeightTypeEnum = _prefix "hasHeightTypeEnum"
    /// <summary>
    /// Evaluation of the altitude confidence assessed according to ETSI ISO 102894-2
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAltitudeConfidence"></see></summary>
    let hasAltitudeConfidence = _prefix "hasAltitudeConfidence"
    /// <summary>
    /// Only for organizational purposes.Package PointCoordinates.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PointCoordinatesAssociationsFrom"></see></summary>
    let PointCoordinatesAssociationsFrom = _prefix "PointCoordinatesAssociationsFrom"
    /// <summary>
    /// Only for organizational purposes.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#LocationReferencing"></see></summary>
    let LocationReferencing = _prefix "LocationReferencing"
    /// <summary>
    /// List of height or vertical gradings of road sections.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#HeightGradeEnum"></see></summary>
    let HeightGradeEnum = _prefix "HeightGradeEnum"
    /// <summary>
    /// An assessment of the impact that an event or operator action defined by the situation record has on the driving conditions.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Impact"></see></summary>
    let Impact = _prefix "Impact"
    /// <summary>
    /// The number of usable lanes in the specified direction which remain fully operational (this may include the hard shoulder if it is being used as an operational lane).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#numberOfOperationalLanes"></see></summary>
    let numberOfOperationalLanes = _prefix "numberOfOperationalLanes"
    /// <summary>
    /// The number of normally usable lanes on the carriageway which are now restricted either fully or partially (this may include the hard shoulder if it is normally available for operational use, e.g. in hard shoulder running schemes).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#numberOfLanesRestricted"></see></summary>
    let numberOfLanesRestricted = _prefix "numberOfLanesRestricted"
    /// <summary>
    /// The ratio of current capacity to the normal (free flow) road capacity in the defined direction, expressed as a percentage. Capacity is the maximum number of vehicles that can pass a specified point on the road, in unit time given the specified conditions.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#capacityRemaining"></see></summary>
    let capacityRemaining = _prefix "capacityRemaining"
    /// <summary>
    /// The total width of the combined operational lanes in the specified direction.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#residualRoadWidth"></see></summary>
    let residualRoadWidth = _prefix "residualRoadWidth"
    /// <summary>
    /// The width of lanes after any lane narrowing
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#residualLaneWidth"></see></summary>
    let residualLaneWidth = _prefix "residualLaneWidth"
    /// <summary>
    /// The details of the delays being caused by the situation element defined in the situation record. It is recommended to only use one of the optional attributes to avoid confusion.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasDelays"></see></summary>
    let hasDelays = _prefix "hasDelays"
    /// <summary>
    ///   <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#InformationDeliveryServicesEnum"></see>
    /// </summary>
    let InformationDeliveryServicesEnum = _prefix "InformationDeliveryServicesEnum"
    /// <summary>
    /// An obstruction on the road caused by one Infrastructure Damage
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#InfrastructureDamageObstruction"></see></summary>
    let InfrastructureDamageObstruction = _prefix "InfrastructureDamageObstruction"
    /// <summary>
    /// Types of infrastructure damage which may have an effect on the road network.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#InfrastructureDamageTypeEnum"></see></summary>
    let InfrastructureDamageTypeEnum = _prefix "InfrastructureDamageTypeEnum"
    /// <summary>
    /// Types of infrastructure damage which may have an effect on the road network.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasInfrastructureDamageType"></see></summary>
    let hasInfrastructureDamageType = _prefix "hasInfrastructureDamageType"
    /// <summary>
    /// Descriptor identifying infrastructure to help to identify a specific location.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#InfrastructureDescriptorEnum"></see></summary>
    let InfrastructureDescriptorEnum = _prefix "InfrastructureDescriptorEnum"
    /// <summary>
    /// An identifier/name whose range is specific to the particular country.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#InternationalIdentifier"></see></summary>
    let InternationalIdentifier = _prefix "InternationalIdentifier"
    /// <summary>
    /// Identifier or name unique within the specified country.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#nationalIdentifier"></see></summary>
    let nationalIdentifier = _prefix "nationalIdentifier"
    /// <summary>
    /// Iso named area	The ISO 3166-2 representation for the named area.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#IsoNamedArea"></see></summary>
    let IsoNamedArea = _prefix "IsoNamedArea"
    /// <summary>
    /// ISO 3166-2 subdivison types.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#SubdivisionTypeEnum"></see></summary>
    let SubdivisionTypeEnum = _prefix "SubdivisionTypeEnum"
    /// <summary>
    /// The ISO 3166-2 subdivison type for the named area.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasSubdivisionTypeEnum"></see></summary>
    let hasSubdivisionTypeEnum = _prefix "hasSubdivisionTypeEnum"
    /// <summary>
    /// The ISO 3166-2 subdivision code for the named area.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasCountrySubdivision"></see></summary>
    let hasCountrySubdivision = _prefix "hasCountrySubdivision"
    /// <summary>
    /// Multiple (i.e. more than one) physically separate locations arranged as an ordered set that defines an itinerary or route. In SRTI is not included ItineraryByReference
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Itinerary"></see></summary>
    let Itinerary = _prefix "Itinerary"
    /// <summary>
    /// Represents one or more physically separate locations. Multiple locations may be related, as in an itinerary or route, or may be unrelated. One LocationReference should not use multiple Location objects to represent the same physical location. In SRTI is not included LocationGroup
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#LocationReference"></see></summary>
    let LocationReference = _prefix "LocationReference"
    /// <summary>
    /// Multiple physically separate locations arranged as an ordered set that defines an itinerary or route. The index qualifier indicates the order.
    /// Association: 1..1 Location
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ItineraryByIndexedLocations"></see></summary>
    let ItineraryByIndexedLocations = _prefix "ItineraryByIndexedLocations"
    /// <summary>
    /// A location contained in an itinerary (i.e. an ordered set of locations defining a route or itinerary).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasLocationContainedInItinerary"></see></summary>
    let hasLocationContainedInItinerary = _prefix "hasLocationContainedInItinerary"
    /// <summary>
    /// Country Representation ontology provides a reference model to support the first two parts of ISO 3166, along with the other coding systems:
    ///  - ISO 3166-1 (Country codes) establishes codes that represent the current names of countries, dependencies, and other areas of particular geopolitical interest, on the basis of lists of country names obtained from the United Nations.
    ///  - ISO 3166-2 (Country subdivision code) establishes a code that represents the names of the principal administrative divisions, or similar areas, of the countries, etc. included in the ISO 3166-1.
    ///  - ISO 3166-3 (Code for formerly used names of countries) establishes a code that represents non-current country names, i.e., the country names deleted from ISO 3166 since its first publication in 1974.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#LCC_CountryRepresentation"></see></summary>
    let LCC_CountryRepresentation = _prefix "LCC_CountryRepresentation"
    /// <summary>
    /// Indicates a specific lane or group of lanes.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Lane"></see></summary>
    let Lane = _prefix "Lane"
    /// <summary>
    /// The number of the lane, where 1 is nearest the hard shoulder/verge and the numbers increase towards the central reservation/road axis.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#laneNumber"></see></summary>
    let laneNumber = _prefix "laneNumber"
    /// <summary>
    /// List of descriptors identifying specific lanes.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#LaneEnum"></see></summary>
    let LaneEnum = _prefix "LaneEnum"
    /// <summary>
    /// Indicates the specific lane to which the location relates.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasLaneEnum"></see></summary>
    let hasLaneEnum = _prefix "hasLaneEnum"
    /// <summary>
    /// A linear element along a single linear object, consistent with EN ISO 19148 definitions.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#LinearElement"></see></summary>
    let LinearElement = _prefix "LinearElement"
    /// <summary>
    /// Name of the road
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadName"></see></summary>
    let roadName = _prefix "roadName"

    /// <summary>
    /// The version of the identified road network reference model.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#linearElementReferenceModelVersion"></see></summary>
    let linearElementReferenceModelVersion =
        _prefix "linearElementReferenceModelVersion"

    /// <summary>
    /// The identifier of a road network reference model which segments the road network according to specific business rules.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#linearElementReferenceModel"></see></summary>
    let linearElementReferenceModel = _prefix "linearElementReferenceModel"
    /// <summary>
    /// Identifier/number of the road. The road number designated by the road authority
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasRoadNumber"></see></summary>
    let hasRoadNumber = _prefix "hasRoadNumber"
    /// <summary>
    /// List of indicative natures of linear elements.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#LinearElementNatureEnum"></see></summary>
    let LinearElementNatureEnum = _prefix "LinearElementNatureEnum"
    /// <summary>
    /// An indication of the nature of the linear element.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasLinearElementNature"></see></summary>
    let hasLinearElementNature = _prefix "hasLinearElementNature"
    /// <summary>
    /// A linear element along a single linear object defined by its identifier or code in a road network reference model (specified in LinearElement class) which segments the road network according to specific business rules.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#LinearElementByCode"></see></summary>
    let LinearElementByCode = _prefix "LinearElementByCode"
    /// <summary>
    /// An identifier or code of a linear element (or link) in the road network reference model that is specified in the LinearElement class.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#linearElementIdentifier"></see></summary>
    let linearElementIdentifier = _prefix "linearElementIdentifier"
    /// <summary>
    /// A linear element defined by a line string (class GmlLineString).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#LinearElementByLineString"></see></summary>
    let LinearElementByLineString = _prefix "LinearElementByLineString"
    /// <summary>
    /// Line string based on GML (EN ISO 19136) definition: a curve defined by a series of two or more coordinate tuples. Unlike GML may be self-intersecting. If srsName attribute is not present, posList is assumed to use "ETRS89-LatLonh" reference system.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasGmlLineString"></see></summary>
    let hasGmlLineString = _prefix "hasGmlLineString"
    /// <summary>
    /// A linear element along a single linear object defined by its start and end points.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#LinearElementByPoints"></see></summary>
    let LinearElementByPoints = _prefix "LinearElementByPoints"
    /// <summary>
    /// The referent at a known location on the linear object which defines the end of the linear element.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasReferentEndPointLinearElement"></see></summary>
    let hasReferentEndPointLinearElement = _prefix "hasReferentEndPointLinearElement"

    /// <summary>
    /// A referent at a known location on the linear object which is neither the start or end of the linear element.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasReferentIntermediatePointLinearElement"></see></summary>
    let hasReferentIntermediatePointLinearElement =
        _prefix "hasReferentIntermediatePointLinearElement"

    /// <summary>
    /// The referent at a known location on the linear object which defines the start of the linear element.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasReferentStartPointLinearElement"></see></summary>
    let hasReferentStartPointLinearElement =
        _prefix "hasReferentStartPointLinearElement"

    /// <summary>
    /// Location representing a linear section with optional directionality defined between two points. Any LinearLocation must have an instance of at least one of these classes. If using multiple instances, producers must take care to ensure they represent the same location.
    /// Associations:
    /// 0..1	OpenlrLinear
    /// 0..1	GmlLineString
    /// 0..1	SupplementaryPositionalDescription
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#LinearLocation"></see></summary>
    let LinearLocation = _prefix "LinearLocation"

    /// <summary>
    /// A collection of supplementary positional information which improves the precision of the location.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#SupplementaryPositionalDescription"></see></summary>
    let SupplementaryPositionalDescription =
        _prefix "SupplementaryPositionalDescription"

    /// <summary>
    /// Supplementary description that applies to the secondary end of the linear location. Use when properties change along the Linear. For a one-way linear the secondary end should be the destination end.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasSecondarySupplementaryDescription"></see></summary>
    let hasSecondarySupplementaryDescription =
        _prefix "hasSecondarySupplementaryDescription"

    /// <summary>
    /// OpenLR line location reference
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrLinear"></see></summary>
    let OpenlrLinear = _prefix "OpenlrLinear"
    /// <summary>
    /// OpenLR line location reference
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrLinear"></see></summary>
    let hasOpenlrLinear = _prefix "hasOpenlrLinear"
    /// <summary>
    /// The specification of a location on a network (as a point or a linear location).Association: 0..1 SupplementaryPositionalDescription
    ///
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#NetworkLocation"></see></summary>
    let NetworkLocation = _prefix "NetworkLocation"
    /// <summary>
    /// A linear section along a linear element where the linear element is either a part of or the whole of a linear object (i.e. a road), consistent with ISO 19148 definitions.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#LinearWithinLinearElement"></see></summary>
    let LinearWithinLinearElement = _prefix "LinearWithinLinearElement"
    /// <summary>
    /// The direction of traffic flow on the linear section in terms of general destination direction.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#directionOnLinearSection"></see></summary>
    let directionOnLinearSection = _prefix "directionOnLinearSection"
    /// <summary>
    /// Specifies a linear element along a single linear object, consistent with EN ISO 19148 definitions.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasLinearElement"></see></summary>
    let hasLinearElement = _prefix "hasLinearElement"
    /// <summary>
    /// A point on the linear element that defines the end node of the linear section.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasDistanceAlongLinearElementTo"></see></summary>
    let hasDistanceAlongLinearElementTo = _prefix "hasDistanceAlongLinearElementTo"
    /// <summary>
    /// A point on the linear element that defines the start node of the linear section.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasDistanceAlongLinearElementFrom"></see></summary>
    let hasDistanceAlongLinearElementFrom = _prefix "hasDistanceAlongLinearElementFrom"
    /// <summary>
    /// Identification of whether the linear section that is part of the linear element is at, above or below the normal elevation of a linear element of that type (e.g. road or road section) at that location, typically used to indicate "grade" separation.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasHeightGradeOfLinearSection"></see></summary>
    let hasHeightGradeOfLinearSection = _prefix "hasHeightGradeOfLinearSection"

    /// <summary>
    /// Identification of the road administration area which contains the specified linear section.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAdministrativeAreaOfLinearSection"></see></summary>
    let hasAdministrativeAreaOfLinearSection =
        _prefix "hasAdministrativeAreaOfLinearSection"

    /// <summary>
    /// The direction of traffic flow on the linear section relative to the direction in which the linear element is defined.
    ///
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#directionRelativeOnLinearSection"></see></summary>
    let directionRelativeOnLinearSection = _prefix "directionRelativeOnLinearSection"
    /// <summary>
    /// In Datex II definition, a pair of planar coordinates defining the geodetic position of a single point using the European Terrestrial Reference System 1989 (ETRS89).
    ///
    /// Note: At the moment, in Spain it is used the WGS84 and so, the 2 references are possible ( geo/wgs84_pos (lat, long) / geo_core (xETRS89,yETRS89) ).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PointCoordinates"></see></summary>
    let PointCoordinates = _prefix "PointCoordinates"
    /// <summary>
    /// Coordinates that may be used by clients for visual display on user interfaces.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasPointCoordinates"></see></summary>
    let hasPointCoordinates = _prefix "hasPointCoordinates"
    /// <summary>
    /// Only for organizational purposes. Package PayloadPublication
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PayLoadPublishing"></see></summary>
    let PayLoadPublishing = _prefix "PayLoadPublishing"
    /// <summary>
    /// Types of maintenance vehicle actions associated with roadworks.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#MaintenanceVehicleActionsEnum"></see></summary>
    let MaintenanceVehicleActionsEnum = _prefix "MaintenanceVehicleActionsEnum"
    /// <summary>
    /// Details of the maintenance vehicles involved in the roadworks activity.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#MaintenanceVehicles"></see></summary>
    let MaintenanceVehicles = _prefix "MaintenanceVehicles"
    /// <summary>
    /// The number of maintenance vehicles associated with the roadworks activities at the specified location.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#numberOfMaintenanceVehicles"></see></summary>
    let numberOfMaintenanceVehicles = _prefix "numberOfMaintenanceVehicles"
    /// <summary>
    /// Roadworks involving the maintenance or installation of infrastructure.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#MaintenanceWorks"></see></summary>
    let MaintenanceWorks = _prefix "MaintenanceWorks"
    /// <summary>
    /// Types of road maintenance.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#RoadMaintenanceTypeEnum"></see></summary>
    let RoadMaintenanceTypeEnum = _prefix "RoadMaintenanceTypeEnum"
    /// <summary>
    /// The type of road maintenance or installation work at the specified location.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasRoadMaintenanceType"></see></summary>
    let hasRoadMaintenanceType = _prefix "hasRoadMaintenanceType"
    /// <summary>
    /// A measured or calculated value of speed.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#SpeedValue"></see></summary>
    let SpeedValue = _prefix "SpeedValue"
    /// <summary>
    /// Speed of the mobile entity.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#speed"></see></summary>
    let speed = _prefix "speed"
    /// <summary>
    /// An indication of whether the associated instance of a SituationRecord is mobile (e.g. a march or parade moving along a road) or stationary.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#MobilityTypeEnum"></see></summary>
    let MobilityTypeEnum = _prefix "MobilityTypeEnum"
    /// <summary>
    /// Types of mobility relating to a situation element defined by a SituationReord.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasMobilityType"></see></summary>
    let hasMobilityType = _prefix "hasMobilityType"
    /// <summary>
    /// The name of the area.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#areaNameProperty"></see></summary>
    let areaNameProperty = _prefix "areaNameProperty"
    /// <summary>
    /// Types of areas.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#NamedAreaTypeEnum"></see></summary>
    let NamedAreaTypeEnum = _prefix "NamedAreaTypeEnum"
    /// <summary>
    /// The type of the area.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasNamedAreaTypeEnum"></see></summary>
    let hasNamedAreaTypeEnum = _prefix "hasNamedAreaTypeEnum"

    /// <summary>
    /// A collection of supplementary positional information which improves the precision of the location.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasSupplementaryPositionalDescription"></see></summary>
    let hasSupplementaryPositionalDescription =
        _prefix "hasSupplementaryPositionalDescription"

    /// <summary>
    /// Actions that a traffic operator can decide to implement to prevent or help correct dangerous or poor driving conditions, including maintenance of the road infrastructure.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OperatorAction"></see></summary>
    let OperatorAction = _prefix "OperatorAction"

    /// <summary>
    /// Types of road surface conditions which are not related to the weather.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#NonWeatherRelatedRoadConditionTypeEnum"></see></summary>
    let NonWeatherRelatedRoadConditionTypeEnum =
        _prefix "NonWeatherRelatedRoadConditionTypeEnum"

    /// <summary>
    /// Road surface conditions that are not related to the weather but which may affect driving conditions.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#NonWeatherRelatedRoadConditions"></see></summary>
    let NonWeatherRelatedRoadConditions = _prefix "NonWeatherRelatedRoadConditions"

    /// <summary>
    /// The type of road conditions which are not related to the weather.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasNonWeatherRelatedRoadConditionTypeEnum"></see></summary>
    let hasNonWeatherRelatedRoadConditionTypeEnum =
        _prefix "hasNonWeatherRelatedRoadConditionTypeEnum"

    /// <summary>
    /// Road surface conditions that are related to the weather which may affect the driving conditions, such as ice, snow or water.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#WeatherRelatedRoadConditions"></see></summary>
    let WeatherRelatedRoadConditions = _prefix "WeatherRelatedRoadConditions"
    /// <summary>
    /// Conditions of the road surface which may affect driving conditions. These may be related to the weather (e.g. ice, snow etc.) or to other conditions (e.g. oil, mud, leaves etc. on the road)
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#RoadSurfaceConditions"></see></summary>
    let RoadSurfaceConditions = _prefix "RoadSurfaceConditions"
    /// <summary>
    /// Types of NUTS codes (Nomenclature of territorial units for statistics) including LAU codes (Local Administrative Units).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#NutsCodeTypeEnum"></see></summary>
    let NutsCodeTypeEnum = _prefix "NutsCodeTypeEnum"
    /// <summary>
    /// The NUTS-Code representation for the named area (Nomenclature of territorial units for statistics) or its LAU code representation (Local Administrative Unit).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#NutsNamedArea"></see></summary>
    let NutsNamedArea = _prefix "NutsNamedArea"
    /// <summary>
    /// The NUTS code for the named area.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#nutsCode"></see></summary>
    let nutsCode = _prefix "nutsCode"
    /// <summary>
    /// The NUTS code type for the named area.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasNutsCodeTypeEnum"></see></summary>
    let hasNutsCodeTypeEnum = _prefix "hasNutsCodeTypeEnum"
    /// <summary>
    /// Number of Obstructions. Not in SRTI profile
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#numberOfObstructions"></see></summary>
    let numberOfObstructions = _prefix "numberOfObstructions"
    /// <summary>
    /// Specifies the mobility of a obstruction
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasMobilityOfObstruction"></see></summary>
    let hasMobilityOfObstruction = _prefix "hasMobilityOfObstruction"
    /// <summary>
    /// The non-negative offset distance from the ALERT-C referenced point to the actual point. The ALERT-C locations in the primary and secondary locations must always encompass the linear section being specified, thus offset distance is towards the other point.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#offsetDistance"></see></summary>
    let offsetDistance = _prefix "offsetDistance"
    /// <summary>
    /// OpenLR location
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenLR"></see></summary>
    let OpenLR = _prefix "OpenLR"
    /// <summary>
    /// Holds common data that are used both in OpenlrPointAccessPoint and OpenlrPointAlongLine.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrBasePointLocation"></see></summary>
    let OpenlrBasePointLocation = _prefix "OpenlrBasePointLocation"
    /// <summary>
    /// Offsets are used to locate the start and end of a location more precisely than bounding to the nodes in a network.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrOffsets"></see></summary>
    let OpenlrOffsets = _prefix "OpenlrOffsets"
    /// <summary>
    /// Allows for adding offsets to the line location path defined by nodes when the starting (respectively ending) point does not coincide with a node.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrOffsets"></see></summary>
    let hasOpenlrOffsets = _prefix "hasOpenlrOffsets"
    /// <summary>
    /// Enumeration of side of road
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrSideOfRoadEnum"></see></summary>
    let OpenlrSideOfRoadEnum = _prefix "OpenlrSideOfRoadEnum"
    /// <summary>
    /// Provides the of road where the corresponding point lies.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrSideOfRoad"></see></summary>
    let hasOpenlrSideOfRoad = _prefix "hasOpenlrSideOfRoad"
    /// <summary>
    /// Enumeration of side of road
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrOrientationEnum"></see></summary>
    let OpenlrOrientationEnum = _prefix "OpenlrOrientationEnum"
    /// <summary>
    /// Orientation of the driving direction in relation with the direction of the underlying linear
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrOrientation"></see></summary>
    let hasOpenlrOrientation = _prefix "hasOpenlrOrientation"
    /// <summary>
    /// The basis of a location reference is a sequence of location reference points (LRPs).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrLocationReferencePoint"></see></summary>
    let OpenlrLocationReferencePoint = _prefix "OpenlrLocationReferencePoint"
    /// <summary>
    /// Allows defining the first point of the OpenLR path
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrLocationReferencePoint"></see></summary>
    let hasOpenlrLocationReferencePoint = _prefix "hasOpenlrLocationReferencePoint"
    /// <summary>
    /// The sequence of location reference points is terminated by a last location reference point.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrLastLocationReferencePoint"></see></summary>
    let OpenlrLastLocationReferencePoint = _prefix "OpenlrLastLocationReferencePoint"

    /// <summary>
    /// Allows defining the last point of the OpenLR path
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrLastLocationReferencePoint"></see></summary>
    let hasOpenlrLastLocationReferencePoint =
        _prefix "hasOpenlrLastLocationReferencePoint"

    /// <summary>
    /// A point location is a zero-dimensional element in a map that specifies a geometric location.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrPointLocationReference"></see></summary>
    let OpenlrPointLocationReference = _prefix "OpenlrPointLocationReference"
    /// <summary>
    /// Base class used to hold data about a reference point.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrBaseReferencePoint"></see></summary>
    let OpenlrBaseReferencePoint = _prefix "OpenlrBaseReferencePoint"
    /// <summary>
    /// Line attributes are part of a location reference point and consists of functional road class (FRC),form of way (FOW) and bearing (BEAR) data.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrLineAttributes"></see></summary>
    let OpenlrLineAttributes = _prefix "OpenlrLineAttributes"
    /// <summary>
    /// Properties of the line towards the topologically adjacent OpenLR location referencing point, on the shortest path to that point.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrLineAttributes"></see></summary>
    let hasOpenlrLineAttributes = _prefix "hasOpenlrLineAttributes"
    /// <summary>
    /// The OpenLR method of area definition by providing a center position and a radius
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrCircleLocationReference"></see></summary>
    let OpenlrCircleLocationReference = _prefix "OpenlrCircleLocationReference"
    /// <summary>
    /// The radius of the corresponding circular area.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#openlrRadius"></see></summary>
    let openlrRadius = _prefix "openlrRadius"
    /// <summary>
    /// A geo-coordinate pair is a position in a map defined by its longitude and latitude coordinate values.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrGeoCoordinate"></see></summary>
    let OpenlrGeoCoordinate = _prefix "OpenlrGeoCoordinate"
    /// <summary>
    /// A geo-coordinate pair is a position in a map defined by its longitude and latitude coordinate values.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrGeoCoordinate"></see></summary>
    let hasOpenlrGeoCoordinate = _prefix "hasOpenlrGeoCoordinate"
    /// <summary>
    /// The OpenLR method of area definition by providing a closed path (i.e. a circuit) in the road network.
    /// The boundary always consists of road segments
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrClosedLineLocationReference"></see></summary>
    let OpenlrClosedLineLocationReference = _prefix "OpenlrClosedLineLocationReference"
    /// <summary>
    /// Only for organizational purposes
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrEnumerations"></see></summary>
    let OpenlrEnumerations = _prefix "OpenlrEnumerations"
    /// <summary>
    /// Enumeration of form of way
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrFormOfWayEnum"></see></summary>
    let OpenlrFormOfWayEnum = _prefix "OpenlrFormOfWayEnum"
    /// <summary>
    /// Enumuration of functional road class
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrFunctionalRoadClassEnum"></see></summary>
    let OpenlrFunctionalRoadClassEnum = _prefix "OpenlrFunctionalRoadClassEnum"
    /// <summary>
    /// Corresponding coordinates of an OpenLR point defined by its only coordinates.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrCoordinates"></see></summary>
    let hasOpenlrCoordinates = _prefix "hasOpenlrCoordinates"
    /// <summary>
    /// Area defined using an OpenLR™ method consisting in defining it by a tessellation of rectangles
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrGridLocationReference"></see></summary>
    let OpenlrGridLocationReference = _prefix "OpenlrGridLocationReference"
    /// <summary>
    /// The number that the base rectangle should be multiplied in the north direction
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#openlrNumRows"></see></summary>
    let openlrNumRows = _prefix "openlrNumRows"
    /// <summary>
    /// The number that the base rectangle should be multiplied in the east direction
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#openlrNumColumns"></see></summary>
    let openlrNumColumns = _prefix "openlrNumColumns"
    /// <summary>
    /// Area delimited by a rectangle defined by the geodetic co-ordinates of the two ends of its diagonal from south-west to north-east (the rectangle having two sides that are parallel to lines of latitude)
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrRectangle"></see></summary>
    let OpenlrRectangle = _prefix "OpenlrRectangle"
    /// <summary>
    /// Area delimited by a rectangle defined by the geodetic co-ordinates of the two ends of its diagonal from south-west to north-east (the rectangle having two sides that are parallel to lines of latitude)
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrRectangle"></see></summary>
    let hasOpenlrRectangle = _prefix "hasOpenlrRectangle"
    /// <summary>
    /// Only for organizational purposes.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrLine"></see></summary>
    let OpenlrLine = _prefix "OpenlrLine"
    /// <summary>
    /// Defines the bearing field as an integer value between 0 and 359
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#openlrBearing"></see></summary>
    let openlrBearing = _prefix "openlrBearing"
    /// <summary>
    /// The lowest FRC to the next point indicates the lowest functional road class used in the location reference path to the next LR-point.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrLowestFrcToNextLRPoint"></see></summary>
    let hasOpenlrLowestFrcToNextLRPoint = _prefix "hasOpenlrLowestFrcToNextLRPoint"
    /// <summary>
    /// A classification based on the importance of the role that the Road Element (or Ferry Connection) performs in the connectivity of the total road network. (EN ISO 14825 § 7.2.88)
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrFormOfWayEnum"></see></summary>
    let hasOpenlrFormOfWayEnum = _prefix "hasOpenlrFormOfWayEnum"
    /// <summary>
    /// A line location reference is defined by an ordered sequence of location reference points and a terminating last location reference point.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrLineLocationReference"></see></summary>
    let OpenlrLineLocationReference = _prefix "OpenlrLineLocationReference"
    /// <summary>
    /// If both direction, this is the reference in the opposite direction against firstDirection.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrOppositeDirection"></see></summary>
    let hasOpenlrOppositeDirection = _prefix "hasOpenlrOppositeDirection"
    /// <summary>
    /// First OpenLR reference in first/main direction.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrFirstDirection"></see></summary>
    let hasOpenlrFirstDirection = _prefix "hasOpenlrFirstDirection"
    /// <summary>
    /// Properties of the path from the associated location reference point to the next location reference point, which are specified to assist correct identification of the point in an external map data source.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrPathAttributes"></see></summary>
    let OpenlrPathAttributes = _prefix "OpenlrPathAttributes"
    /// <summary>
    /// Properties of the path from the associated location reference point to the next location reference point, which are specified to assist correct identification of the point in an external map data source.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrPathAttributes"></see></summary>
    let hasOpenlrPathAttributes = _prefix "hasOpenlrPathAttributes"
    /// <summary>
    /// The positive offset along the line of the location measured along the line reference path between the start point of the location reference and the starting node of the line reference path.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#openlrPositiveOffset"></see></summary>
    let openlrPositiveOffset = _prefix "openlrPositiveOffset"
    /// <summary>
    /// The negative offset along the line of the location measured along the line reference path between the end point of the location reference and the ending node of the line reference path.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#openlrNegativeOffset"></see></summary>
    let openlrNegativeOffset = _prefix "openlrNegativeOffset"
    /// <summary>
    /// The DNP attribute measures the distance in meters between two consecutive location reference-points along the location reference path described in the corresponding enumeration
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#openlrDistanceToNextLRPoint"></see></summary>
    let openlrDistanceToNextLRPoint = _prefix "openlrDistanceToNextLRPoint"
    /// <summary>
    /// A point of interest (POI) along a line with access is a point location which is defined by a linear reference path, an offset value (defining the access point) from the starting node of this path and a coordinate pair that defines the POI itself.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrPoiWithAccessPoint"></see></summary>
    let OpenlrPoiWithAccessPoint = _prefix "OpenlrPoiWithAccessPoint"
    /// <summary>
    /// Point along a line
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrPointAlongLine"></see></summary>
    let OpenlrPointAlongLine = _prefix "OpenlrPointAlongLine"
    /// <summary>
    /// A geodetic coordinate Tuple that defines the vertices of the underlying geometrical polygon.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrPolygonCorners"></see></summary>
    let OpenlrPolygonCorners = _prefix "OpenlrPolygonCorners"
    /// <summary>
    /// The OpenLR method of area definition by providing points that bound the area
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrPolygonLocationReference"></see></summary>
    let OpenlrPolygonLocationReference = _prefix "OpenlrPolygonLocationReference"
    /// <summary>
    /// A geodetic coordinate Tuple that defines the vertices of the underlying geometrical polygon.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrPolygonCorners"></see></summary>
    let hasOpenlrPolygonCorners = _prefix "hasOpenlrPolygonCorners"
    /// <summary>
    /// The upper right corner of the rectangle.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrUpperRight"></see></summary>
    let hasOpenlrUpperRight = _prefix "hasOpenlrUpperRight"
    /// <summary>
    /// The lower left corner of the rectangle.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrLowerLeft"></see></summary>
    let hasOpenlrLowerLeft = _prefix "hasOpenlrLowerLeft"
    /// <summary>
    /// The openLR method of area definition by providing a rectangular shape defined by two geo-coordinate pairs
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrRectangleLocationReference"></see></summary>
    let OpenlrRectangleLocationReference = _prefix "OpenlrRectangleLocationReference"
    /// <summary>
    /// Any situation record. An identifiable versioned instance of a single record/element within a situation.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#SituationRecord"></see></summary>
    let SituationRecord = _prefix "SituationRecord"
    /// <summary>
    /// A continuous or discontinuous period of validity defined by overall bounding start and end times and the possible intersection of valid periods (potentially recurring) with the complement of exception periods (also potentially recurring).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OverallPeriod"></see></summary>
    let OverallPeriod = _prefix "OverallPeriod"
    /// <summary>
    /// A payload publication of traffic related information or associated management information created at a specific point in time that can be exchanged via a DATEX II interface.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PayloadPublication"></see></summary>
    let PayloadPublication = _prefix "PayloadPublication"
    /// <summary>
    /// A classification of the information which is to be found in the publications originating from the particular feed.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#feedType"></see></summary>
    let feedType = _prefix "feedType"
    /// <summary>
    /// A description of the information which is to be found in the publications originating from the particular feed (URL).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#feedDescription"></see></summary>
    let feedDescription = _prefix "feedDescription"
    /// <summary>
    /// Date/time at which the payload publication was created.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#publicationTime"></see></summary>
    let publicationTime = _prefix "publicationTime"
    /// <summary>
    /// Specifies the publication creator using an international identifier
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#publicationCreator"></see></summary>
    let publicationCreator = _prefix "publicationCreator"
    /// <summary>
    /// The default language used throughout the payload publication
    /// Specifies the language by an ISO 639-1 2-alpha code
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#defaultLanguage"></see></summary>
    let defaultLanguage = _prefix "defaultLanguage"

    /// <summary>
    /// Distance of a point along a linear element measured from the start node expressed as a percentage of the whole length of the linear element, where start node is relative to the element definition rather than the direction of traffic flow.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PercentageDistanceAlongLinearElement"></see></summary>
    let PercentageDistanceAlongLinearElement =
        _prefix "PercentageDistanceAlongLinearElement"

    /// <summary>
    /// A measure of distance along a linear element from the start of the element expressed as a percentage of the total length of the linear object.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#percentageDistanceAlong"></see></summary>
    let percentageDistanceAlong = _prefix "percentageDistanceAlong"
    /// <summary>
    /// A point on a linear element where the linear element is either a part of or the whole of a linear object (i.e. a road), consistent with EN ISO 19148 definitions.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PointAlongLinearElement"></see></summary>
    let PointAlongLinearElement = _prefix "PointAlongLinearElement"
    /// <summary>
    /// Identification of whether the point on the linear element is at, above or below the normal elevation of a linear element of that type (e.g. road or road section) at that location, typically used to indicate "grade" separation.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasHeightGradeOfPoint"></see></summary>
    let hasHeightGradeOfPoint = _prefix "hasHeightGradeOfPoint"
    /// <summary>
    /// Identification of the road administration area which contains the specified point.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAdministrativeAreaOfPoint"></see></summary>
    let hasAdministrativeAreaOfPoint = _prefix "hasAdministrativeAreaOfPoint"
    /// <summary>
    /// The direction of traffic flow at the specified point relative to the direction in which the linear element is defined.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#directionRelativeAtPoint"></see></summary>
    let directionRelativeAtPoint = _prefix "directionRelativeAtPoint"
    /// <summary>
    /// The direction of traffic flow at the specified point in terms of general destination direction.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#directionAtPoint"></see></summary>
    let directionAtPoint = _prefix "directionAtPoint"
    /// <summary>
    /// Distance of a point along a linear element either measured from the start node or a defined referent on that linear element, where the start node is relative to the element definition rather than the direction of traffic flow.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasDistanceAlongLinearElement"></see></summary>
    let hasDistanceAlongLinearElement = _prefix "hasDistanceAlongLinearElement"
    /// <summary>
    /// A single point defined only by a coordinate set with an optional bearing direction.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PointByCoordinates"></see></summary>
    let PointByCoordinates = _prefix "PointByCoordinates"
    /// <summary>
    /// Accuracy defined by the 95th percentile of the cumulative distribution of position errors
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#bearing"></see></summary>
    let bearing = _prefix "bearing"
    /// <summary>
    /// A pair of planar coordinates defining the geodetic position of a single point using the European Terrestrial Reference System 1989 (ETRS89).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PointCoordinatesAssociationsTo"></see></summary>
    let PointCoordinatesAssociationsTo = _prefix "PointCoordinatesAssociationsTo"
    /// <summary>
    /// Defines the horizontal position accuracy according EN 16803-1
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasHorizontalPositionAccuracy"></see></summary>
    let hasHorizontalPositionAccuracy = _prefix "hasHorizontalPositionAccuracy"
    /// <summary>
    /// Confidence ellipse position defined in a shape of ellipse with a predefined confidence level (e.g. 95 %). The centre of the ellipse shape corresponds to the reference position point for which the position accuracy is evaluated.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PositionConfidenceEllipse"></see></summary>
    let PositionConfidenceEllipse = _prefix "PositionConfidenceEllipse"
    /// <summary>
    /// Confidence ellipse position defined in a shape of ellipse with a predefined confidence level (e.g. 95 %). The centre of the ellipse shape corresponds to the reference position point for which the position accuracy is evaluated.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasPositionConfidenceEllipse"></see></summary>
    let hasPositionConfidenceEllipse = _prefix "hasPositionConfidenceEllipse"
    /// <summary>
    /// Third coordinate for points defined geodetically
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasHeightCoordinate"></see></summary>
    let hasHeightCoordinate = _prefix "hasHeightCoordinate"
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
    let PointLocation = _prefix "PointLocation"
    /// <summary>
    /// A single point on the road network defined by a TPEG-Loc structure and which has an associated direction of traffic flow.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegPointLocation"></see></summary>
    let TpegPointLocation = _prefix "TpegPointLocation"
    /// <summary>
    /// PointLocation is associated to TpegPointLocation with cardinality 0..1
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasTpegPointLocation"></see></summary>
    let hasTpegPointLocation = _prefix "hasTpegPointLocation"
    /// <summary>
    /// PointLocation is associated to PointByCoordinates with cardinality 0..1
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasPointByCoordinates"></see></summary>
    let hasPointByCoordinates = _prefix "hasPointByCoordinates"
    /// <summary>
    /// PointLocation is associated to OpenlrPointLocationReference with cardinality 0..1
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrPointLocationReference"></see></summary>
    let hasOpenlrPointLocationReference = _prefix "hasOpenlrPointLocationReference"
    /// <summary>
    /// Any environmental conditions which may be affecting the driving conditions on the road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PoorEnvironmentConditions"></see></summary>
    let PoorEnvironmentConditions = _prefix "PoorEnvironmentConditions"
    /// <summary>
    /// Types of poor environmental conditions.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PoorEnvironmentTypeEnum"></see></summary>
    let PoorEnvironmentTypeEnum = _prefix "PoorEnvironmentTypeEnum"
    /// <summary>
    /// Any environmental conditions which may be affecting the driving conditions on the road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasPoorEnvironmentTypeEnum"></see></summary>
    let hasPoorEnvironmentTypeEnum = _prefix "hasPoorEnvironmentTypeEnum"
    /// <summary>
    /// Accuracy defined by the 95th percentile of the cumulative distribution of position errors
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#accuracyPercentile95"></see></summary>
    let accuracyPercentile95 = _prefix "accuracyPercentile95"
    /// <summary>
    /// Accuracy defined by the 75th percentile of the cumulative distribution of position errors
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#accuracyPercentile75"></see></summary>
    let accuracyPercentile75 = _prefix "accuracyPercentile75"
    /// <summary>
    /// Accuracy defined by the 50th percentile of the cumulative distribution of position errors.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#accuracyPercentile50"></see></summary>
    let accuracyPercentile50 = _prefix "accuracyPercentile50"
    /// <summary>
    /// Indicates whether the ellipse orientation is unavailable (True) or not (False)
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#semiMajorAxisOrientationError"></see></summary>
    let semiMajorAxisOrientationError = _prefix "semiMajorAxisOrientationError"
    /// <summary>
    /// Half of length of the minor axis, i.e. distance between the centre point and minor axis point of the position accuracy ellipse
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#semiMinorAxisLength"></see></summary>
    let semiMinorAxisLength = _prefix "semiMinorAxisLength"
    /// <summary>
    /// Orientation direction of the ellipse major axis of the position accuracy ellipse with regards to the geographic north.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#semiMajorAxisOrientation"></see></summary>
    let semiMajorAxisOrientation = _prefix "semiMajorAxisOrientation"
    /// <summary>
    /// Half of length of the major axis, i.e. distance between the centre point and major axis point of the position accuracy ellipse.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#semiMajorAxisLength"></see></summary>
    let semiMajorAxisLength = _prefix "semiMajorAxisLength"
    /// <summary>
    /// Provides a coded error in case the semi-minor axis length is not defined
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasSemiMinorAxisLengthCodedError"></see></summary>
    let hasSemiMinorAxisLengthCodedError = _prefix "hasSemiMinorAxisLengthCodedError"
    /// <summary>
    /// Provides a coded error in case the semi-major axis length is not defined
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasSemiMajorAxisLengthCodedError"></see></summary>
    let hasSemiMajorAxisLengthCodedError = _prefix "hasSemiMajorAxisLengthCodedError"
    /// <summary>
    /// Levels of confidence that the sender has in the information, ordered {certain, probable, risk of}.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ProbabilityOfOccurrenceEnum"></see></summary>
    let ProbabilityOfOccurrenceEnum = _prefix "ProbabilityOfOccurrenceEnum"
    /// <summary>
    /// Public event
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PublicEvent"></see></summary>
    let PublicEvent = _prefix "PublicEvent"
    /// <summary>
    /// Name of the venue at which the public event is being held
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#venueName"></see></summary>
    let venueName = _prefix "venueName"
    /// <summary>
    /// Types of public events.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PublicEventTypeEnum"></see></summary>
    let PublicEventTypeEnum = _prefix "PublicEventTypeEnum"
    /// <summary>
    /// RAMON geographic ontology describes countries, NUTS, and Local Administrative Units (LAU) related concepts and properties
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Ramon_geoClasses"></see></summary>
    let Ramon_geoClasses = _prefix "Ramon_geoClasses"
    /// <summary>
    /// The name of the referent, e.g. a junction or intersection name.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#referentName"></see></summary>
    let referentName = _prefix "referentName"
    /// <summary>
    /// Description of the referent.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#referentDescription"></see></summary>
    let referentDescription = _prefix "referentDescription"
    /// <summary>
    /// The identifier of the referent, unique on the specified linear element (i.e. road or part of).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#referentIdentifier"></see></summary>
    let referentIdentifier = _prefix "referentIdentifier"
    /// <summary>
    /// A set of types of known points along a linear object such as a road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ReferentTypeEnum"></see></summary>
    let ReferentTypeEnum = _prefix "ReferentTypeEnum"
    /// <summary>
    /// The type of the referent.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasReferentTypeEnum"></see></summary>
    let hasReferentTypeEnum = _prefix "hasReferentTypeEnum"
    /// <summary>
    /// Identifies a relative position across a carriageway
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#RelativePositionOnCarriagewayEnum"></see></summary>
    let RelativePositionOnCarriagewayEnum = _prefix "RelativePositionOnCarriagewayEnum"
    /// <summary>
    /// Rerouting management action that is issued by the network/road operator.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ReroutingManagement"></see></summary>
    let ReroutingManagement = _prefix "ReroutingManagement"
    /// <summary>
    /// Management actions relating to rerouting.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ReroutingManagementTypeEnum"></see></summary>
    let ReroutingManagementTypeEnum = _prefix "ReroutingManagementTypeEnum"
    /// <summary>
    /// Management actions relating to rerouting.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasReroutingManagementType"></see></summary>
    let hasReroutingManagementType = _prefix "hasReroutingManagementType"
    /// <summary>
    /// Information on a road
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#RoadInformation"></see></summary>
    let RoadInformation = _prefix "RoadInformation"
    /// <summary>
    /// A destination associated with this road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadDestination"></see></summary>
    let roadDestination = _prefix "roadDestination"
    /// <summary>
    /// Road, carriageway or lane management action that is instigated by the network/road operator.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#RoadOrCarriagewayOrLaneManagement"></see></summary>
    let RoadOrCarriagewayOrLaneManagement = _prefix "RoadOrCarriagewayOrLaneManagement"
    /// <summary>
    /// The minimum number of persons required in a vehicle in order for it to be allowed to transit the specified road section.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#minimumCarOccupancy"></see></summary>
    let minimumCarOccupancy = _prefix "minimumCarOccupancy"

    /// <summary>
    /// Management actions relating to road, carriageway or lane usage.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#RoadOrCarriagewayOrLaneManagementTypeEnum"></see></summary>
    let RoadOrCarriagewayOrLaneManagementTypeEnum =
        _prefix "RoadOrCarriagewayOrLaneManagementTypeEnum"

    /// <summary>
    /// Indicates that the road section where the roadworks are located is under traffic or not under traffic. 'True' indicates the road is under traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#underTraffic"></see></summary>
    let underTraffic = _prefix "underTraffic"
    /// <summary>
    /// Grade of complexity of the roadworks according to the responsible road operator. For example determined by size, duration and/or traffic disruption.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#RoadworksScaleEnum"></see></summary>
    let RoadworksScaleEnum = _prefix "RoadworksScaleEnum"
    /// <summary>
    /// Grade of complexity of the roadworks according to the responsible road operator. For example determined by size, duration and/or traffic disruption.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasRoadworksScaleEnum"></see></summary>
    let hasRoadworksScaleEnum = _prefix "hasRoadworksScaleEnum"
    /// <summary>
    /// An external identifier for the roadworks
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadworksIdentifier"></see></summary>
    let roadworksIdentifier = _prefix "roadworksIdentifier"
    /// <summary>
    /// Details of the maintenance vehicles involved in the roadworks activity.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasMaintenanceVehicles"></see></summary>
    let hasMaintenanceVehicles = _prefix "hasMaintenanceVehicles"
    /// <summary>
    /// The subjects with which the roadworks are associated.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Subjects"></see></summary>
    let Subjects = _prefix "Subjects"
    /// <summary>
    ///   <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasSubject"></see>
    /// </summary>
    let hasSubject = _prefix "hasSubject"
    /// <summary>
    /// An indication of whether the associated instance of a SituationRecord is mobile (e.g. a march or parade moving along a road) or stationary.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasMobility"></see></summary>
    let hasMobility = _prefix "hasMobility"
    /// <summary>
    /// Expected durations of roadworks in general terms.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#RoadworksDurationEnum"></see></summary>
    let RoadworksDurationEnum = _prefix "RoadworksDurationEnum"
    /// <summary>
    /// Indicates in general terms the expected duration of the roadworks.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasRoadworksDuration"></see></summary>
    let hasRoadworksDuration = _prefix "hasRoadworksDuration"
    /// <summary>
    /// Indication of whether the roadworks are considered to be urgent whereby emergency work is being, or needs to be, undertaken to mitigate safety concerns. 'True' indicates they are urgent.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#urgentRoadworks"></see></summary>
    let urgentRoadworks = _prefix "urgentRoadworks"
    /// <summary>
    /// Describes an available public transport alternative to the normal route
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#publicTransportAlternative"></see></summary>
    let publicTransportAlternative = _prefix "publicTransportAlternative"
    /// <summary>
    /// Details of road side assistance required or being given.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#RoadsideAssistance"></see></summary>
    let RoadsideAssistance = _prefix "RoadsideAssistance"
    /// <summary>
    /// Indicates the nature of the road side assistance that will be, is or has been provided.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#RoadsideAssistanceTypeEnum"></see></summary>
    let RoadsideAssistanceTypeEnum = _prefix "RoadsideAssistanceTypeEnum"
    /// <summary>
    /// Indicates the nature of the road side assistance that will be, is or has been provided.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasRoadsideAssistenceTypeEnum"></see></summary>
    let hasRoadsideAssistenceTypeEnum = _prefix "hasRoadsideAssistenceTypeEnum"
    /// <summary>
    /// Levels of severity of a situation as whole assessed by the impact that the situation may have on traffic flow as perceived by the supplier.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#SeverityEnum"></see></summary>
    let SeverityEnum = _prefix "SeverityEnum"
    /// <summary>
    /// Location representing a linear section along a single road with optional directionality defined between two points on the same road. No matter the kind of linear reference it uses, the constraint of using only a single road must be preserved. Associations:
    /// 0..1	TpegLinearLocation
    /// 0..*	AlertCLinear
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#SingleRoadLinearLocation"></see></summary>
    let SingleRoadLinearLocation = _prefix "SingleRoadLinearLocation"
    /// <summary>
    /// A linear section along a single road defined between two points on the same road by a TPEG-Loc structure.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegLinearLocation"></see></summary>
    let TpegLinearLocation = _prefix "TpegLinearLocation"
    /// <summary>
    /// A linear section along a single road defined between two points on the same road by a TPEG-Loc structure.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasTpegLinearLocation"></see></summary>
    let hasTpegLinearLocation = _prefix "hasTpegLinearLocation"
    /// <summary>
    /// An identifiable instance of a traffic/travel situation comprising one or more traffic/travel circumstances which are linked by one or more causal relationships. Each traffic/travel circumstance is represented by a Situation Record.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Situation"></see></summary>
    let Situation = _prefix "Situation"
    /// <summary>
    /// Management information relating to the data contained within a publication.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasHeaderInformation"></see></summary>
    let hasHeaderInformation = _prefix "hasHeaderInformation"
    /// <summary>
    /// Details of the Situation
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasSituationRecord"></see></summary>
    let hasSituationRecord = _prefix "hasSituationRecord"
    /// <summary>
    /// A publication containing zero or more traffic/travel situations.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#SituationPublication"></see></summary>
    let SituationPublication = _prefix "SituationPublication"
    /// <summary>
    /// Version of Situation Record
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#situationRecordVersion"></see></summary>
    let situationRecordVersion = _prefix "situationRecordVersion"
    /// <summary>
    /// Specification of validity, either explicitly or by a validity time period specification which may be discontinuous.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Validity"></see></summary>
    let Validity = _prefix "Validity"
    /// <summary>
    /// Specification of validity, either explicitly or by a validity time period specification which may be discontinuous.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasValidity"></see></summary>
    let hasValidity = _prefix "hasValidity"
    /// <summary>
    /// An assessment of the impact that an event or operator action defined by the situation record has on the driving conditions.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasImpact"></see></summary>
    let hasImpact = _prefix "hasImpact"
    /// <summary>
    ///   <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#situationRecordObservationTime"></see>
    /// </summary>
    let situationRecordObservationTime = _prefix "situationRecordObservationTime"
    /// <summary>
    /// The extent to which the related information may be circulated, according to the recipient type. Recipients must comply with this confidentiality statement. This overrides any confidentiality defined for the situation as a whole in the header information.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#confidentialityOverride"></see></summary>
    let confidentialityOverride = _prefix "confidentialityOverride"
    /// <summary>
    /// An assessment of the degree of likelihood that the reported event will occur.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasProbabilityOfOccurrence"></see></summary>
    let hasProbabilityOfOccurrence = _prefix "hasProbabilityOfOccurrence"
    /// <summary>
    /// The date/time that the SituationRecord object (the first version of the record) was created by the original supplier.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#situationRecordCreationTime"></see></summary>
    let situationRecordCreationTime = _prefix "situationRecordCreationTime"
    /// <summary>
    /// Details of the source from which the information was obtained.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Source"></see></summary>
    let Source = _prefix "Source"
    /// <summary>
    ///   <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasSource"></see>
    /// </summary>
    let hasSource = _prefix "hasSource"
    /// <summary>
    /// Indicates, whether this SituationRecord specifies a safety related message according to Commission Delegated Regulation (EU) No 886/2013.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#safetyRelatedMessage"></see></summary>
    let safetyRelatedMessage = _prefix "safetyRelatedMessage"
    /// <summary>
    /// A unique alphanumeric reference (e.g. an external reference or a UUID) of the SituationRecord object (the first version of the record) that was created by the original supplier.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#situationRecordCreationReference"></see></summary>
    let situationRecordCreationReference = _prefix "situationRecordCreationReference"

    /// <summary>
    /// The date/time that the current version of the Situation Record was written into the database of the original supplier in the supply chain.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#situationRecordFirstSupplierVersionTime"></see></summary>
    let situationRecordFirstSupplierVersionTime =
        _prefix "situationRecordFirstSupplierVersionTime"

    /// <summary>
    /// Has a location reference
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasLocationReference"></see></summary>
    let hasLocationReference = _prefix "hasLocationReference"
    /// <summary>
    /// Levels of severity of a situation as whole assessed by the impact that the situation may have on traffic flow as perceived by the supplier.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasSeverityEnum"></see></summary>
    let hasSeverityEnum = _prefix "hasSeverityEnum"
    /// <summary>
    /// An assessment of the impact that an event or operator action defined by the situation record has on the driving conditions, but on opposite direction.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasImpactOnOppositeDirection"></see></summary>
    let hasImpactOnOppositeDirection = _prefix "hasImpactOnOppositeDirection"
    /// <summary>
    /// The date/time that this current version of the SituationRecord within the situation was written into the database of the supplier which is involved in the data exchange. Identity and version of record are defined by the class stereotype implementation.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#situationRecordVersionTime"></see></summary>
    let situationRecordVersionTime = _prefix "situationRecordVersionTime"
    /// <summary>
    /// Skos Vocabulary
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#SkosClasses"></see></summary>
    let SkosClasses = _prefix "SkosClasses"
    /// <summary>
    /// The name of the organisation which has produced the information relating to this version of the information.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#sourceName"></see></summary>
    let sourceName = _prefix "sourceName"
    /// <summary>
    /// Language independent textual code or identifier for the organisation or the equipment that has produced the information.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#sourceIdentification"></see></summary>
    let sourceIdentification = _prefix "sourceIdentification"
    /// <summary>
    /// An indication as to whether the source deems the associated information to be reliable/correct. "True" indicates it is deemed reliable.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#reliable"></see></summary>
    let reliable = _prefix "reliable"
    /// <summary>
    /// Information about the technology used for measuring the data or the method used for obtaining qualitative descriptions relating to this version of the information.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#SourceTypeEnum"></see></summary>
    let SourceTypeEnum = _prefix "SourceTypeEnum"
    /// <summary>
    /// Information about the technology used for measuring the data or the method used for obtaining qualitative descriptions relating to this version of the information.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#sourceType"></see></summary>
    let sourceType = _prefix "sourceType"
    /// <summary>
    /// EN ISO 3166-1 two-character country code of the source of the information.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#sourceCountry"></see></summary>
    let sourceCountry = _prefix "sourceCountry"
    /// <summary>
    /// Speed management action that is instigated by the network/road operator.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#SpeedManagement"></see></summary>
    let SpeedManagement = _prefix "SpeedManagement"
    /// <summary>
    /// Temporary limit defining the maximum advisory or mandatory speed of vehicles.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#temporarySpeedLimit"></see></summary>
    let temporarySpeedLimit = _prefix "temporarySpeedLimit"
    /// <summary>
    /// Management actions relating to speed.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#SpeedManagementTypeEnum"></see></summary>
    let SpeedManagementTypeEnum = _prefix "SpeedManagementTypeEnum"
    /// <summary>
    /// Type of speed management action instigated by operator.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasSpeedManagementType"></see></summary>
    let hasSpeedManagementType = _prefix "hasSpeedManagementType"
    /// <summary>
    /// The subjects with which the roadworks are associated.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#SubjectTypeOfWorksEnum"></see></summary>
    let SubjectTypeOfWorksEnum = _prefix "SubjectTypeOfWorksEnum"
    /// <summary>
    /// The number of subjects on which the roadworks (construction or maintenance) are being performed.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#numberOfSubjects"></see></summary>
    let numberOfSubjects = _prefix "numberOfSubjects"
    /// <summary>
    /// The subject type of the roadworks (i.e. on what the construction or maintenance work is being performed).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasSubjectTypeOfWorks"></see></summary>
    let hasSubjectTypeOfWorks = _prefix "hasSubjectTypeOfWorks"
    /// <summary>
    /// Indicates that the location is given with a precision which is better than the stated value in metres.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#locationPrecision"></see></summary>
    let locationPrecision = _prefix "locationPrecision"
    /// <summary>
    /// Descriptor which identifies infrastructure to help identify the specific location.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasInfrastructureDescriptor"></see></summary>
    let hasInfrastructureDescriptor = _prefix "hasInfrastructureDescriptor"
    /// <summary>
    /// The sequential number of an exit/entrance ramp from a given location in a given direction (normally used to indicate a specific exit/entrance in a complex junction/intersection).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#sequentialRampNumber"></see></summary>
    let sequentialRampNumber = _prefix "sequentialRampNumber"
    /// <summary>
    /// Supplementary human-readable description of the location
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#locationDescription"></see></summary>
    let locationDescription = _prefix "locationDescription"
    /// <summary>
    /// Identifies the main purpose of the road at the location
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasDirectionPurpose"></see></summary>
    let hasDirectionPurpose = _prefix "hasDirectionPurpose"
    /// <summary>
    /// Descriptor which identifies a geographic characteristic to help identify the specific location
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasGeographicDescriptor"></see></summary>
    let hasGeographicDescriptor = _prefix "hasGeographicDescriptor"
    /// <summary>
    /// This indicates the length (measured in metres) of carriageway (and lanes) affected by the associated traffic element.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#lengthAffected"></see></summary>
    let lengthAffected = _prefix "lengthAffected"
    /// <summary>
    /// Relative position across carriageway
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasPositionOnCarriageway"></see></summary>
    let hasPositionOnCarriageway = _prefix "hasPositionOnCarriageway"

    /// <summary>
    /// Types of linear location.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TPEGLoc01LinearLocationSubtypeEnum"></see></summary>
    let TPEGLoc01LinearLocationSubtypeEnum =
        _prefix "TPEGLoc01LinearLocationSubtypeEnum"

    /// <summary>
    /// Only for organizational purposes
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegEnumerations"></see></summary>
    let TpegEnumerations = _prefix "TpegEnumerations"
    /// <summary>
    /// OWL-Time is an ontology of temporal concepts, for describing the temporal properties of resources. The vocabulary provided expresses facts about relations among instants and intervals, as well as durations. Time positions and durations may be expressed using either the conventional (Gregorian) calendar and clock, or using another temporal reference system such as Unix-time, geologic time, or different calendars.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TimeClasses"></see></summary>
    let TimeClasses = _prefix "TimeClasses"
    /// <summary>
    /// A descriptor for describing an area location.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegAreaDescriptor"></see></summary>
    let TpegAreaDescriptor = _prefix "TpegAreaDescriptor"

    /// <summary>
    /// Descriptors for describing area locations.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegLoc03AreaDescriptorSubtypeEnum"></see></summary>
    let TpegLoc03AreaDescriptorSubtypeEnum =
        _prefix "TpegLoc03AreaDescriptorSubtypeEnum"

    /// <summary>
    /// The nature of the descriptor used to define the location under consideration (derived from the TPEG Loc table 03).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tpegAreaDescriptorType"></see></summary>
    let tpegAreaDescriptorType = _prefix "tpegAreaDescriptorType"
    /// <summary>
    /// A collection of information providing descriptive references to locations using the TPEG-Loc location referencing approach.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegDescriptor"></see></summary>
    let TpegDescriptor = _prefix "TpegDescriptor"
    /// <summary>
    /// Height information which provides additional discrimination for the applicable area.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegHeight"></see></summary>
    let TpegHeight = _prefix "TpegHeight"
    /// <summary>
    /// Height information which provides additional discrimination for the applicable area.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasTpegHeight"></see></summary>
    let hasTpegHeight = _prefix "hasTpegHeight"
    /// <summary>
    /// Types of area.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegLoc01AreaLocationSubtypeEnum"></see></summary>
    let TpegLoc01AreaLocationSubtypeEnum = _prefix "TpegLoc01AreaLocationSubtypeEnum"
    /// <summary>
    /// The type of TPEG location.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tpegAreaLocationType"></see></summary>
    let tpegAreaLocationType = _prefix "tpegAreaLocationType"
    /// <summary>
    /// Tpeg location
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegLoc"></see></summary>
    let TpegLoc = _prefix "TpegLoc"
    /// <summary>
    /// A text string which describes or elaborates the location. Here is used for values distinct to RoadNumbers or AdministrativeUnit.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#descriptorString"></see></summary>
    let descriptorString = _prefix "descriptorString"
    /// <summary>
    /// Describes or elaborates the location. Here is used for values from RoadNumber or AdministrativeUnit.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#descriptor"></see></summary>
    let descriptor = _prefix "descriptor"
    /// <summary>
    /// A point on the road network which is framed between two other points on the same road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegFramedPoint"></see></summary>
    let TpegFramedPoint = _prefix "TpegFramedPoint"

    /// <summary>
    /// Types of points on the road network framed by two other points on the same road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegLoc01FramedPointLocationSubtypeEnum"></see></summary>
    let TpegLoc01FramedPointLocationSubtypeEnum =
        _prefix "TpegLoc01FramedPointLocationSubtypeEnum"

    /// <summary>
    /// The type of TPEG location.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tpegFramedPointLocationType"></see></summary>
    let tpegFramedPointLocationType = _prefix "tpegFramedPointLocationType"
    /// <summary>
    /// The location at the down stream end of the linear section of road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasTpegPointTo"></see></summary>
    let hasTpegPointTo = _prefix "hasTpegPointTo"
    /// <summary>
    /// The location at the up stream end of the linear section of road.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasTpegPointFrom"></see></summary>
    let hasTpegPointFrom = _prefix "hasTpegPointFrom"
    /// <summary>
    /// A point on the road network which is not a road junction point.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegNonJunctionPoint"></see></summary>
    let TpegNonJunctionPoint = _prefix "TpegNonJunctionPoint"
    /// <summary>
    /// A single non-junction point on the road network which is framed between two other specified points on the road network.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasTpegFramedPoint"></see></summary>
    let hasTpegFramedPoint = _prefix "hasTpegFramedPoint"
    /// <summary>
    /// A geometric area defined by a centre point and a radius.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegGeometricArea"></see></summary>
    let TpegGeometricArea = _prefix "TpegGeometricArea"
    /// <summary>
    /// Name of area.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasTpegAreaDescriptor"></see></summary>
    let hasTpegAreaDescriptor = _prefix "hasTpegAreaDescriptor"
    /// <summary>
    /// The radius of the corresponding circular area
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#radius"></see></summary>
    let radius = _prefix "radius"
    /// <summary>
    /// Centre point of a circular geometric area.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasCentrePoint"></see></summary>
    let hasCentrePoint = _prefix "hasCentrePoint"
    /// <summary>
    /// A measurement of height in metres
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#height"></see></summary>
    let height = _prefix "height"
    /// <summary>
    /// Types of height.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegLoc04HeightTypeEnum"></see></summary>
    let TpegLoc04HeightTypeEnum = _prefix "TpegLoc04HeightTypeEnum"
    /// <summary>
    /// A descriptive identification of relative height using TPEG-Loc location referencing.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tpegHeightType"></see></summary>
    let tpegHeightType = _prefix "tpegHeightType"
    /// <summary>
    /// A descriptor for describing a junction by defining the intersecting roads.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegIlcPointDescriptor"></see></summary>
    let TpegIlcPointDescriptor = _prefix "TpegIlcPointDescriptor"

    /// <summary>
    /// Descriptors for describing a junction by identifying the intersecting roads at a road junction.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegLoc03IlcPointDescriptorSubtypeEnum"></see></summary>
    let TpegLoc03IlcPointDescriptorSubtypeEnum =
        _prefix "TpegLoc03IlcPointDescriptorSubtypeEnum"

    /// <summary>
    /// The nature of the descriptor used to define the location under consideration (derived from the TPEG Loc table 03).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tpegIlcPointDescriptorType"></see></summary>
    let tpegIlcPointDescriptorType = _prefix "tpegIlcPointDescriptorType"
    /// <summary>
    /// A descriptor for describing a point location.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegPointDescriptor"></see></summary>
    let TpegPointDescriptor = _prefix "TpegPointDescriptor"
    /// <summary>
    /// A point on the road network which is a road junction point.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegJunction"></see></summary>
    let TpegJunction = _prefix "TpegJunction"
    /// <summary>
    /// A descriptor for describing a point at a junction on a road network.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegJunctionPointDescriptor"></see></summary>
    let TpegJunctionPointDescriptor = _prefix "TpegJunctionPointDescriptor"
    /// <summary>
    /// A name which identifies a junction point on the road network
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasTpegJunctionPointDescriptor"></see></summary>
    let hasTpegJunctionPointDescriptor = _prefix "hasTpegJunctionPointDescriptor"
    /// <summary>
    /// A descriptor for describing a junction by identifying the intersecting roads at a road junction.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasTpegIlcPointDescriptor"></see></summary>
    let hasTpegIlcPointDescriptor = _prefix "hasTpegIlcPointDescriptor"

    /// <summary>
    /// Descriptors for describing a point at a road junction.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegLoc03JunctionPointDescriptorSubtypeEnum"></see></summary>
    let TpegLoc03JunctionPointDescriptorSubtypeEnum =
        _prefix "TpegLoc03JunctionPointDescriptorSubtypeEnum"

    /// <summary>
    /// The nature of the descriptor used to define the location under consideration (derived from the TPEG Loc table 03).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tpegJunctionPointDescriptorType"></see></summary>
    let tpegJunctionPointDescriptorType = _prefix "tpegJunctionPointDescriptorType"
    /// <summary>
    /// The type of TPEG location.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tpegLinearLocationType"></see></summary>
    let tpegLinearLocationType = _prefix "tpegLinearLocationType"
    /// <summary>
    /// The direction of traffic flow.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tpegDirection"></see></summary>
    let tpegDirection = _prefix "tpegDirection"

    /// <summary>
    /// Types of simple point.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegLoc01SimplePointLocationSubtypeEnum"></see></summary>
    let TpegLoc01SimplePointLocationSubtypeEnum =
        _prefix "TpegLoc01SimplePointLocationSubtypeEnum"

    /// <summary>
    /// Descriptors other than junction names and road descriptors which can help to identify the location of points on the road network.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegLoc03OtherPointDescriptorSubtypeEnum"></see></summary>
    let TpegLoc03OtherPointDescriptorSubtypeEnum =
        _prefix "TpegLoc03OtherPointDescriptorSubtypeEnum"

    /// <summary>
    /// An area defined by a well-known name.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegNamedOnlyArea"></see></summary>
    let TpegNamedOnlyArea = _prefix "TpegNamedOnlyArea"
    /// <summary>
    /// General descriptor for describing a point.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegOtherPointDescriptor"></see></summary>
    let TpegOtherPointDescriptor = _prefix "TpegOtherPointDescriptor"
    /// <summary>
    /// A descriptive name which helps to identify the non-junction point. At least one descriptor must identify the road on which the point is located, i.e. must be of type 'linkName' or 'localLinkName'.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasTpegOtherPointDescriptor"></see></summary>
    let hasTpegOtherPointDescriptor = _prefix "hasTpegOtherPointDescriptor"
    /// <summary>
    /// The nature of the descriptor used to define the location under consideration (derived from the TPEG Loc table 03).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tpegOtherPointDescriptorType"></see></summary>
    let tpegOtherPointDescriptorType = _prefix "tpegOtherPointDescriptorType"
    /// <summary>
    /// A point on the road network which is not bounded by any other points on the road network.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegSimplePoint"></see></summary>
    let TpegSimplePoint = _prefix "TpegSimplePoint"
    /// <summary>
    /// The type of TPEG location.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tpegSimplePointLocationType"></see></summary>
    let tpegSimplePointLocationType = _prefix "tpegSimplePointLocationType"
    /// <summary>
    /// A single point defined by a coordinate set and TPEG descriptors.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasTpegPoint"></see></summary>
    let hasTpegPoint = _prefix "hasTpegPoint"
    /// <summary>
    /// Types of constriction to which traffic is subjected as a result of an event.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TrafficConstrictionTypeEnum"></see></summary>
    let TrafficConstrictionTypeEnum = _prefix "TrafficConstrictionTypeEnum"
    /// <summary>
    /// Types of the constriction to which traffic is subjected as a result of an event.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasTrafficConstrictionTypeEnum"></see></summary>
    let hasTrafficConstrictionTypeEnum = _prefix "hasTrafficConstrictionTypeEnum"
    /// <summary>
    /// Types of public transport information.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TransitServiceInformationEnum"></see></summary>
    let TransitServiceInformationEnum = _prefix "TransitServiceInformationEnum"
    /// <summary>
    /// A specification of periods of validity defined by overall bounding start and end times and the possible intersection of valid periods with exception periods (exception periods overriding valid periods).
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#validityTimeSpecification"></see></summary>
    let validityTimeSpecification = _prefix "validityTimeSpecification"
    /// <summary>
    /// Values of validity status that can be assigned to a described event, action or item
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ValidityStatusEnum"></see></summary>
    let ValidityStatusEnum = _prefix "ValidityStatusEnum"
    /// <summary>
    /// Specification of validity, either explicitly overriding the validity time specification or confirming it.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasValidityStatus"></see></summary>
    let hasValidityStatus = _prefix "hasValidityStatus"
    /// <summary>
    ///   <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Vehicle"></see>
    /// </summary>
    let Vehicle = _prefix "Vehicle"
    /// <summary>
    /// The status of a vehicle.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#VehicleStatusEnum"></see></summary>
    let VehicleStatusEnum = _prefix "VehicleStatusEnum"
    /// <summary>
    /// Vehicle status.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasVehicleStatus"></see></summary>
    let hasVehicleStatus = _prefix "hasVehicleStatus"
    /// <summary>
    /// The characteristics of a vehicle, e.g. lorry of gross weight greater than 30 tonnes.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#VehicleCharacteristics"></see></summary>
    let VehicleCharacteristics = _prefix "VehicleCharacteristics"
    /// <summary>
    /// The characteristics of a vehicle, e.g. lorry of gross weight greater than 30 tonnes.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasVehicleCharacteristics"></see></summary>
    let hasVehicleCharacteristics = _prefix "hasVehicleCharacteristics"
    /// <summary>
    /// A measured or calculated value of the flow rate of vehicles.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#VehicleFlowValue"></see></summary>
    let VehicleFlowValue = _prefix "VehicleFlowValue"
    /// <summary>
    /// A value of vehicle flow rate expressed in vehicles per hour.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#vehicleFlowRate"></see></summary>
    let vehicleFlowRate = _prefix "vehicleFlowRate"
    /// <summary>
    /// Types of vehicle.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#VehicleTypeEnum"></see></summary>
    let VehicleTypeEnum = _prefix "VehicleTypeEnum"
    /// <summary>
    /// Vehicle type.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasVehicleTypeEnum"></see></summary>
    let hasVehicleTypeEnum = _prefix "hasVehicleTypeEnum"
    /// <summary>
    /// Types of obstructions involving vehicles.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#VehicleObstructionTypeEnum"></see></summary>
    let VehicleObstructionTypeEnum = _prefix "VehicleObstructionTypeEnum"
    /// <summary>
    /// Characterization of an obstruction on the road caused by one or more vehicles.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasVehicleObstructionTypeEnum"></see></summary>
    let hasVehicleObstructionTypeEnum = _prefix "hasVehicleObstructionTypeEnum"
    /// <summary>
    /// Types of road surface conditions which are related to the weather.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#WeatherRelatedRoadConditionType"></see></summary>
    let WeatherRelatedRoadConditionType = _prefix "WeatherRelatedRoadConditionType"

    /// <summary>
    /// The type of road surface condition that is related to the weather which is affecting the driving conditions.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasWeatherRelatedRoadConditionTypeEnum"></see></summary>
    let hasWeatherRelatedRoadConditionTypeEnum =
        _prefix "hasWeatherRelatedRoadConditionTypeEnum"

    /// <summary>
    /// Winter driving management action that is instigated by the network/road operator.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#WinterDrivingManagement"></see></summary>
    let WinterDrivingManagement = _prefix "WinterDrivingManagement"
    /// <summary>
    /// Type of winter equipment management action instigated by operator.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#WinterEquipmentManagementTypeEnum"></see></summary>
    let WinterEquipmentManagementTypeEnum = _prefix "WinterEquipmentManagementTypeEnum"
    /// <summary>
    /// ALERT-C name of a direction e.g. Brussels -&gt; Lille.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#alertCDirectionNamed"></see></summary>
    let alertCDirectionNamed = _prefix "alertCDirectionNamed"
    /// <summary>
    /// Name of ALERT-C location.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#alertCLocationName"></see></summary>
    let alertCLocationName = _prefix "alertCLocationName"
    /// <summary>
    /// The allowed delivery channel.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#allowedDeliveryChannel"></see></summary>
    let allowedDeliveryChannel = _prefix "allowedDeliveryChannel"
    /// <summary>
    /// For organizational purposes
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#geoSparqlDataProperties"></see></summary>
    let geoSparqlDataProperties = _prefix "geoSparqlDataProperties"
    /// <summary>
    /// For organizational purposes
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#importedDataProperties"></see></summary>
    let importedDataProperties = _prefix "importedDataProperties"
    /// <summary>
    /// Only for organizational purposes. GeoSparql object properties
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#geoSparqlObjectProperties"></see></summary>
    let geoSparqlObjectProperties = _prefix "geoSparqlObjectProperties"
    /// <summary>
    /// Only for organizational purposes. Imported object properties
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#importedObjectProperties"></see></summary>
    let importedObjectProperties = _prefix "importedObjectProperties"
    /// <summary>
    /// For organizational purposes. Properties of the WGS84 Geo Positioning by World Wide Web Consortium (W3C). A vocabulary for representing latitude, longitude and altitude information in the WGS84 geodetic reference datum. WGS stands for the World Geodetic Survey.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#geo_WGS84"></see></summary>
    let geo_WGS84 = _prefix "geo_WGS84"
    /// <summary>
    /// For organizational purposes. Properties of the ontology for the representation of Geographical Objects https://datos.ign.es/def/geo_core
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#geo_core"></see></summary>
    let geo_core = _prefix "geo_core"
    /// <summary>
    /// ALERT-C Area
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAlertCArea"></see></summary>
    let hasAlertCArea = _prefix "hasAlertCArea"
    /// <summary>
    /// The linear location expressed using AlertC. Multiple instances of AlertCLinear shall represent the same real-world geographic feature.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAlertCLinear"></see></summary>
    let hasAlertCLinear = _prefix "hasAlertCLinear"
    /// <summary>
    /// The point location expressed using AlertC. Multiple instances of AlertCPoint shall represent the same real-world geographic feature.They should represent the same point using different location tables.
    /// PointLocation is associated to AlertCPoint with cardinality 0..*
    /// ALERT-C point
    /// A single point on the road network defined by reference to a pre-defined ALERT-C location table and which has an associated direction of traffic flow.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAlertCPoint"></see></summary>
    let hasAlertCPoint = _prefix "hasAlertCPoint"
    /// <summary>
    /// Supplementary positional information which details carriageway and lane locations. Several instances may exist where the element being described extends over more than one carriageway.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasCarriageway"></see></summary>
    let hasCarriageway = _prefix "hasCarriageway"
    /// <summary>
    /// Deliberate human action of either a public disorder nature or of a situation alert type which could disrupt traffic.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasDisturbanceActivityTypeEnum"></see></summary>
    let hasDisturbanceActivityTypeEnum = _prefix "hasDisturbanceActivityTypeEnum"
    /// <summary>
    /// A boundary of internal patches of a polygonal surface consisting of a ring feature
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasGmlInteriorLinearRing"></see></summary>
    let hasGmlInteriorLinearRing = _prefix "hasGmlInteriorLinearRing"
    /// <summary>
    /// Indicates a specific lane or group of lanes.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasLane"></see></summary>
    let hasLane = _prefix "hasLane"
    /// <summary>
    /// Specifies a linear section along a linear element where the linear element is either a part of or the whole of a linear object (i.e. a road), consistent with ISO 19148 definitions.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasLinearWithinLinearElement"></see></summary>
    let hasLinearWithinLinearElement = _prefix "hasLinearWithinLinearElement"
    /// <summary>
    /// It is location reference of ...
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#isLocationReferenceOf"></see></summary>
    let isLocationReferenceOf = _prefix "isLocationReferenceOf"
    /// <summary>
    /// The actions of the maintenance vehicles associated with the roadworks activities.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasMaintenanceVehicleActions"></see></summary>
    let hasMaintenanceVehicleActions = _prefix "hasMaintenanceVehicleActions"
    /// <summary>
    ///   <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOverallEndTime"></see>
    /// </summary>
    let hasOverallEndTime = _prefix "hasOverallEndTime"
    /// <summary>
    ///   <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOverallStartTime"></see>
    /// </summary>
    let hasOverallStartTime = _prefix "hasOverallStartTime"
    /// <summary>
    /// PointLocation is associated to PointAlongLinearElement with cardinality 0..*
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasPointAlongLinearElement"></see></summary>
    let hasPointAlongLinearElement = _prefix "hasPointAlongLinearElement"
    /// <summary>
    /// Specifies types of public events.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasPublicEventType"></see></summary>
    let hasPublicEventType = _prefix "hasPublicEventType"
    /// <summary>
    /// Specifies a referent on a linear object that has a known location such as a node, a reference marker (e.g. a marker-post), an intersection etc.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasReferent"></see></summary>
    let hasReferent = _prefix "hasReferent"
    /// <summary>
    /// Information on a set of one or more roads. The location could correspond to a part of the road identified, the whole stretch of road identified, or a combination of multiple road sections.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasRoadInformation"></see></summary>
    let hasRoadInformation = _prefix "hasRoadInformation"

    /// <summary>
    /// Management actions relating to road, carriageway or lane usage.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasRoadOrCarriagewayOrLaneManagementType"></see></summary>
    let hasRoadOrCarriagewayOrLaneManagementType =
        _prefix "hasRoadOrCarriagewayOrLaneManagementType"

    /// <summary>
    /// traffic/travel situations.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasSituation"></see></summary>
    let hasSituation = _prefix "hasSituation"
    /// <summary>
    /// The vehicle involved in the accident.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasVehiclesInvolved"></see></summary>
    let hasVehiclesInvolved = _prefix "hasVehiclesInvolved"
    /// <summary>
    /// Type of winter equipment management action instigated by operator.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasWinterEquipmentManagementType"></see></summary>
    let hasWinterEquipmentManagementType = _prefix "hasWinterEquipmentManagementType"
    /// <summary>
    /// Only for organizational purposes. Qudt object properties
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#qudtObjectProperties"></see></summary>
    let qudtObjectProperties = _prefix "qudtObjectProperties"
    /// <summary>
    /// For organizational purposes
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#skosDataProperties"></see></summary>
    let skosDataProperties = _prefix "skosDataProperties"
    /// <summary>
    /// Only for organizational purposes. Skos object properties
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#skosObjectProperties"></see></summary>
    let skosObjectProperties = _prefix "skosObjectProperties"
    /// <summary>
    /// Unique code within the ALERT-C location table which identifies the specific point, linear or area location.
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#specificLocation"></see></summary>
    let specificLocation = _prefix "specificLocation"
    /// <summary>
    /// For organizational purposes
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#timeDataProperties"></see></summary>
    let timeDataProperties = _prefix "timeDataProperties"
    /// <summary>
    /// Only for organizational purposes. Time object properties
    /// <see href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#timeObjectProperties"></see></summary>
    let timeObjectProperties = _prefix "timeObjectProperties"
