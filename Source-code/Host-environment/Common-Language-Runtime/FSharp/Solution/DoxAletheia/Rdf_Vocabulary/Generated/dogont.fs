namespace http.elite.polito.it.ontologies.dogont.bare

open DoxAletheia

module dogont =
    let _namespace_name = "http://elite.polito.it/ontologies/dogont"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#BTicinoProperty"></see>
    /// </summary>
    let ``_.owl#BTicinoProperty`` = _prefix ".owl#BTicinoProperty"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#EchelonProperty"></see>
    /// </summary>
    let ``_.owl#EchelonProperty`` = _prefix ".owl#EchelonProperty"
    /// <summary>
    /// The IP address of the gateway
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#IPAddress"></see></summary>
    let ``_.owl#IPAddress`` = _prefix ".owl#IPAddress"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#KonnexProperty"></see>
    /// </summary>
    let ``_.owl#KonnexProperty`` = _prefix ".owl#KonnexProperty"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ModBusProperty"></see>
    /// </summary>
    let ``_.owl#ModBusProperty`` = _prefix ".owl#ModBusProperty"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ZWaveProperty"></see>
    /// </summary>
    let ``_.owl#ZWaveProperty`` = _prefix ".owl#ZWaveProperty"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#commandParamName"></see>
    /// </summary>
    let ``_.owl#commandParamName`` = _prefix ".owl#commandParamName"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#commandParamValue"></see>
    /// </summary>
    let ``_.owl#commandParamValue`` = _prefix ".owl#commandParamValue"
    /// <summary>
    /// The time before the connection expires
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#connectionTimeOut"></see></summary>
    let ``_.owl#connectionTimeOut`` = _prefix ".owl#connectionTimeOut"
    /// <summary>
    /// Number of connection trials before failure
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#connectionTrials"></see></summary>
    let ``_.owl#connectionTrials`` = _prefix ".owl#connectionTrials"
    /// <summary>
    /// The flashing period duration in seconds
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#flashingTime"></see></summary>
    let ``_.owl#flashingTime`` = _prefix ".owl#flashingTime"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#levelFromGround"></see>
    /// </summary>
    let ``_.owl#levelFromGround`` = _prefix ".owl#levelFromGround"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#nParams"></see>
    /// </summary>
    let ``_.owl#nParams`` = _prefix ".owl#nParams"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#notificationName"></see>
    /// </summary>
    let ``_.owl#notificationName`` = _prefix ".owl#notificationName"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#notificationParamName"></see>
    /// </summary>
    let ``_.owl#notificationParamName`` = _prefix ".owl#notificationParamName"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#phaseID"></see>
    /// </summary>
    let ``_.owl#phaseID`` = _prefix ".owl#phaseID"
    /// <summary>
    /// The interval between subsequent polls
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#pollingInterval"></see></summary>
    let ``_.owl#pollingInterval`` = _prefix ".owl#pollingInterval"
    /// <summary>
    /// The port of the gateway
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#port"></see></summary>
    let ``_.owl#port`` = _prefix ".owl#port"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#probeID"></see>
    /// </summary>
    let ``_.owl#probeID`` = _prefix ".owl#probeID"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#realCommandName"></see>
    /// </summary>
    let ``_.owl#realCommandName`` = _prefix ".owl#realCommandName"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#realStateValue"></see>
    /// </summary>
    let ``_.owl#realStateValue`` = _prefix ".owl#realStateValue"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#returnType"></see>
    /// </summary>
    let ``_.owl#returnType`` = _prefix ".owl#returnType"
    /// <summary>
    /// The time between connection trials
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#sleepTime"></see></summary>
    let ``_.owl#sleepTime`` = _prefix ".owl#sleepTime"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#stepValue"></see>
    /// </summary>
    let ``_.owl#stepValue`` = _prefix ".owl#stepValue"
    /// <summary>
    /// A property holding the svg footprint for the given building environment object
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#svgFootprint"></see></summary>
    let ``_.owl#svgFootprint`` = _prefix ".owl#svgFootprint"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#tariffID"></see>
    /// </summary>
    let ``_.owl#tariffID`` = _prefix ".owl#tariffID"
    /// <summary>
    /// The time in seconds during which the object is turned on
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#timeToOff"></see></summary>
    let ``_.owl#timeToOff`` = _prefix ".owl#timeToOff"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#weekDay"></see>
    /// </summary>
    let ``_.owl#weekDay`` = _prefix ".owl#weekDay"
    /// <summary>
    /// A room containing a bath or shower and usually a washbasin and toilet
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Bathroom"></see></summary>
    let ``_.owl#Bathroom`` = _prefix ".owl#Bathroom"
    /// <summary>
    /// A room used primarily for sleeping
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Bedroom"></see></summary>
    let ``_.owl#Bedroom`` = _prefix ".owl#Bedroom"
    /// <summary>
    /// A room used for dining
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#DiningRoom"></see></summary>
    let ``_.owl#DiningRoom`` = _prefix ".owl#DiningRoom"
    /// <summary>
    /// A room equipped for preparing meals
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Kitchen"></see></summary>
    let ``_.owl#Kitchen`` = _prefix ".owl#Kitchen"
    /// <summary>
    /// A room where people can sit and talk and relax
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#LivingRoom"></see></summary>
    let ``_.owl#LivingRoom`` = _prefix ".owl#LivingRoom"
    /// <summary>
    /// A large entrance
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Lobby"></see></summary>
    let ``_.owl#Lobby`` = _prefix ".owl#Lobby"
    /// <summary>
    /// Little Room for storage of things in the house
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#StorageRoom"></see></summary>
    let ``_.owl#StorageRoom`` = _prefix ".owl#StorageRoom"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ApplianceRunNotification"></see>
    /// </summary>
    let ``_.owl#ApplianceRunNotification`` = _prefix ".owl#ApplianceRunNotification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#CloseNotification"></see>
    /// </summary>
    let ``_.owl#CloseNotification`` = _prefix ".owl#CloseNotification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#CoolNotification"></see>
    /// </summary>
    let ``_.owl#CoolNotification`` = _prefix ".owl#CoolNotification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#DetectedNotification"></see>
    /// </summary>
    let ``_.owl#DetectedNotification`` = _prefix ".owl#DetectedNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#EmittingMicrowavesNotification"></see>
    /// </summary>
    let ``_.owl#EmittingMicrowavesNotification`` =
        _prefix ".owl#EmittingMicrowavesNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#FiringUpNotification"></see>
    /// </summary>
    let ``_.owl#FiringUpNotification`` = _prefix ".owl#FiringUpNotification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#HeatNotification"></see>
    /// </summary>
    let ``_.owl#HeatNotification`` = _prefix ".owl#HeatNotification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#IdentifyNotification"></see>
    /// </summary>
    let ``_.owl#IdentifyNotification`` = _prefix ".owl#IdentifyNotification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#IsPresentNotification"></see>
    /// </summary>
    let ``_.owl#IsPresentNotification`` = _prefix ".owl#IsPresentNotification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MovementNotification"></see>
    /// </summary>
    let ``_.owl#MovementNotification`` = _prefix ".owl#MovementNotification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#NoMovementNotification"></see>
    /// </summary>
    let ``_.owl#NoMovementNotification`` = _prefix ".owl#NoMovementNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#NonParametricLevelNotification"></see>
    /// </summary>
    let ``_.owl#NonParametricLevelNotification`` =
        _prefix ".owl#NonParametricLevelNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#NotDetectedNotification"></see>
    /// </summary>
    let ``_.owl#NotDetectedNotification`` = _prefix ".owl#NotDetectedNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#NotEmittingMicrowavesNotification"></see>
    /// </summary>
    let ``_.owl#NotEmittingMicrowavesNotification`` =
        _prefix ".owl#NotEmittingMicrowavesNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#NotPresentNotification"></see>
    /// </summary>
    let ``_.owl#NotPresentNotification`` = _prefix ".owl#NotPresentNotification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#OffNotification"></see>
    /// </summary>
    let ``_.owl#OffNotification`` = _prefix ".owl#OffNotification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#OnNotification"></see>
    /// </summary>
    let ``_.owl#OnNotification`` = _prefix ".owl#OnNotification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#OpenNotification"></see>
    /// </summary>
    let ``_.owl#OpenNotification`` = _prefix ".owl#OpenNotification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PlaybackNotification"></see>
    /// </summary>
    let ``_.owl#PlaybackNotification`` = _prefix ".owl#PlaybackNotification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PressedDownNotification"></see>
    /// </summary>
    let ``_.owl#PressedDownNotification`` = _prefix ".owl#PressedDownNotification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PressedNotification"></see>
    /// </summary>
    let ``_.owl#PressedNotification`` = _prefix ".owl#PressedNotification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PressedUpNotification"></see>
    /// </summary>
    let ``_.owl#PressedUpNotification`` = _prefix ".owl#PressedUpNotification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ReleasedNotification"></see>
    /// </summary>
    let ``_.owl#ReleasedNotification`` = _prefix ".owl#ReleasedNotification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StandByNotification"></see>
    /// </summary>
    let ``_.owl#StandByNotification`` = _prefix ".owl#StandByNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StopHeatingCoolingNotification"></see>
    /// </summary>
    let ``_.owl#StopHeatingCoolingNotification`` =
        _prefix ".owl#StopHeatingCoolingNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SuperCoolingNotification"></see>
    /// </summary>
    let ``_.owl#SuperCoolingNotification`` = _prefix ".owl#SuperCoolingNotification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SuperFreezingNotification"></see>
    /// </summary>
    let ``_.owl#SuperFreezingNotification`` = _prefix ".owl#SuperFreezingNotification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SuperHeatingNotification"></see>
    /// </summary>
    let ``_.owl#SuperHeatingNotification`` = _prefix ".owl#SuperHeatingNotification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#WashingNotification"></see>
    /// </summary>
    let ``_.owl#WashingNotification`` = _prefix ".owl#WashingNotification"
    /// <summary>
    /// The address of the group of the component
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#groupAddress"></see></summary>
    let ``_.owl#groupAddress`` = _prefix ".owl#groupAddress"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#hexValue"></see>
    /// </summary>
    let ``_.owl#hexValue`` = _prefix ".owl#hexValue"
    /// <summary>
    /// The individual address of the component
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#individualAddress"></see></summary>
    let ``_.owl#individualAddress`` = _prefix ".owl#individualAddress"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#registerAddress"></see>
    /// </summary>
    let ``_.owl#registerAddress`` = _prefix ".owl#registerAddress"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#registerType"></see>
    /// </summary>
    let ``_.owl#registerType`` = _prefix ".owl#registerType"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#scaleFactor"></see>
    /// </summary>
    let ``_.owl#scaleFactor`` = _prefix ".owl#scaleFactor"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#slaveId"></see>
    /// </summary>
    let ``_.owl#slaveId`` = _prefix ".owl#slaveId"
    /// <summary>
    /// The ILON id of a given datapoint associated to the command or notification of a given echelon-managed device
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#datapoinId"></see></summary>
    let ``_.owl#datapoinId`` = _prefix ".owl#datapoinId"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#datapointAlias"></see>
    /// </summary>
    let ``_.owl#datapointAlias`` = _prefix ".owl#datapointAlias"
    /// <summary>
    /// The address (URL) of the web service endpoint at which the ILON100 server having this property offers data reading and writing services
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#endpointAddress"></see></summary>
    let ``_.owl#endpointAddress`` = _prefix ".owl#endpointAddress"
    /// <summary>
    /// The multicast address of the gateway
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#multicastIP"></see></summary>
    let ``_.owl#multicastIP`` = _prefix ".owl#multicastIP"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ActiveDiscoveryStateValue"></see>
    /// </summary>
    let ``_.owl#ActiveDiscoveryStateValue`` = _prefix ".owl#ActiveDiscoveryStateValue"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ActivePushLinkAuthenticationStateValue"></see>
    /// </summary>
    let ``_.owl#ActivePushLinkAuthenticationStateValue`` =
        _prefix ".owl#ActivePushLinkAuthenticationStateValue"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#AssociatingStateValue"></see>
    /// </summary>
    let ``_.owl#AssociatingStateValue`` = _prefix ".owl#AssociatingStateValue"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#AuthenticatedStateValue"></see>
    /// </summary>
    let ``_.owl#AuthenticatedStateValue`` = _prefix ".owl#AuthenticatedStateValue"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#AutoRegulationStateValue"></see>
    /// </summary>
    let ``_.owl#AutoRegulationStateValue`` = _prefix ".owl#AutoRegulationStateValue"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#AuxStateValue"></see>
    /// </summary>
    let ``_.owl#AuxStateValue`` = _prefix ".owl#AuxStateValue"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#CDStateValue"></see>
    /// </summary>
    let ``_.owl#CDStateValue`` = _prefix ".owl#CDStateValue"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ClimateScheduleStateValue"></see>
    /// </summary>
    let ``_.owl#ClimateScheduleStateValue`` = _prefix ".owl#ClimateScheduleStateValue"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#CloseStateValue"></see>
    /// </summary>
    let ``_.owl#CloseStateValue`` = _prefix ".owl#CloseStateValue"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ConnectedStateValue"></see>
    /// </summary>
    let ``_.owl#ConnectedStateValue`` = _prefix ".owl#ConnectedStateValue"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#CoolingStateValue"></see>
    /// </summary>
    let ``_.owl#CoolingStateValue`` = _prefix ".owl#CoolingStateValue"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#DetectedStateValue"></see>
    /// </summary>
    let ``_.owl#DetectedStateValue`` = _prefix ".owl#DetectedStateValue"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#DisassociatingStateValue"></see>
    /// </summary>
    let ``_.owl#DisassociatingStateValue`` = _prefix ".owl#DisassociatingStateValue"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#DisconnectedStateValue"></see>
    /// </summary>
    let ``_.owl#DisconnectedStateValue`` = _prefix ".owl#DisconnectedStateValue"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#DownTripleStateValue"></see>
    /// </summary>
    let ``_.owl#DownTripleStateValue`` = _prefix ".owl#DownTripleStateValue"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#EmittingMicrowavesStateValue"></see>
    /// </summary>
    let ``_.owl#EmittingMicrowavesStateValue`` =
        _prefix ".owl#EmittingMicrowavesStateValue"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#EndProgrammedStateValue"></see>
    /// </summary>
    let ``_.owl#EndProgrammedStateValue`` = _prefix ".owl#EndProgrammedStateValue"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#FailureStateValue"></see>
    /// </summary>
    let ``_.owl#FailureStateValue`` = _prefix ".owl#FailureStateValue"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#FireUpStateValue"></see>
    /// </summary>
    let ``_.owl#FireUpStateValue`` = _prefix ".owl#FireUpStateValue"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ForwardStateValue"></see>
    /// </summary>
    let ``_.owl#ForwardStateValue`` = _prefix ".owl#ForwardStateValue"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#FreeStateValue"></see>
    /// </summary>
    let ``_.owl#FreeStateValue`` = _prefix ".owl#FreeStateValue"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#HeatingStateValue"></see>
    /// </summary>
    let ``_.owl#HeatingStateValue`` = _prefix ".owl#HeatingStateValue"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#IdleStateValue"></see>
    /// </summary>
    let ``_.owl#IdleStateValue`` = _prefix ".owl#IdleStateValue"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MovingStateValue"></see>
    /// </summary>
    let ``_.owl#MovingStateValue`` = _prefix ".owl#MovingStateValue"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#NeedingAuthenticationStateValue"></see>
    /// </summary>
    let ``_.owl#NeedingAuthenticationStateValue`` =
        _prefix ".owl#NeedingAuthenticationStateValue"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#NoFailureStateValue"></see>
    /// </summary>
    let ``_.owl#NoFailureStateValue`` = _prefix ".owl#NoFailureStateValue"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#NotDetectedStateValue"></see>
    /// </summary>
    let ``_.owl#NotDetectedStateValue`` = _prefix ".owl#NotDetectedStateValue"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#NotEmittingMicrowavesStateValue"></see>
    /// </summary>
    let ``_.owl#NotEmittingMicrowavesStateValue`` =
        _prefix ".owl#NotEmittingMicrowavesStateValue"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#NotMovingStateValue"></see>
    /// </summary>
    let ``_.owl#NotMovingStateValue`` = _prefix ".owl#NotMovingStateValue"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#NotPresentState"></see>
    /// </summary>
    let ``_.owl#NotPresentState`` = _prefix ".owl#NotPresentState"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#NotProgrammedStateValue"></see>
    /// </summary>
    let ``_.owl#NotProgrammedStateValue`` = _prefix ".owl#NotProgrammedStateValue"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#OccupiedStateValue"></see>
    /// </summary>
    let ``_.owl#OccupiedStateValue`` = _prefix ".owl#OccupiedStateValue"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#OffStateValue"></see>
    /// </summary>
    let ``_.owl#OffStateValue`` = _prefix ".owl#OffStateValue"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#OnStateValue"></see>
    /// </summary>
    let ``_.owl#OnStateValue`` = _prefix ".owl#OnStateValue"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#OpenStateValue"></see>
    /// </summary>
    let ``_.owl#OpenStateValue`` = _prefix ".owl#OpenStateValue"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PauseStateValue"></see>
    /// </summary>
    let ``_.owl#PauseStateValue`` = _prefix ".owl#PauseStateValue"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PhonoStateValue"></see>
    /// </summary>
    let ``_.owl#PhonoStateValue`` = _prefix ".owl#PhonoStateValue"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PlayStateValue"></see>
    /// </summary>
    let ``_.owl#PlayStateValue`` = _prefix ".owl#PlayStateValue"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PresentStateValue"></see>
    /// </summary>
    let ``_.owl#PresentStateValue`` = _prefix ".owl#PresentStateValue"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ProgramInterruptedStateValue"></see>
    /// </summary>
    let ``_.owl#ProgramInterruptedStateValue`` =
        _prefix ".owl#ProgramInterruptedStateValue"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ProgrammedAndWaitingToStartStateValue"></see>
    /// </summary>
    let ``_.owl#ProgrammedAndWaitingToStartStateValue`` =
        _prefix ".owl#ProgrammedAndWaitingToStartStateValue"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ProgrammedStateValue"></see>
    /// </summary>
    let ``_.owl#ProgrammedStateValue`` = _prefix ".owl#ProgrammedStateValue"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#RestTripleStateValue"></see>
    /// </summary>
    let ``_.owl#RestTripleStateValue`` = _prefix ".owl#RestTripleStateValue"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#RewindStateValue"></see>
    /// </summary>
    let ``_.owl#RewindStateValue`` = _prefix ".owl#RewindStateValue"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#RinseHoldStateValue"></see>
    /// </summary>
    let ``_.owl#RinseHoldStateValue`` = _prefix ".owl#RinseHoldStateValue"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#RunningStateValue"></see>
    /// </summary>
    let ``_.owl#RunningStateValue`` = _prefix ".owl#RunningStateValue"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StandByStateValue"></see>
    /// </summary>
    let ``_.owl#StandByStateValue`` = _prefix ".owl#StandByStateValue"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StopStateValue"></see>
    /// </summary>
    let ``_.owl#StopStateValue`` = _prefix ".owl#StopStateValue"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SuperCoolingStateValue"></see>
    /// </summary>
    let ``_.owl#SuperCoolingStateValue`` = _prefix ".owl#SuperCoolingStateValue"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SuperFreezingStateValue"></see>
    /// </summary>
    let ``_.owl#SuperFreezingStateValue`` = _prefix ".owl#SuperFreezingStateValue"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SuperHeatingStateValue"></see>
    /// </summary>
    let ``_.owl#SuperHeatingStateValue`` = _prefix ".owl#SuperHeatingStateValue"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#Tape1StateValue"></see>
    /// </summary>
    let ``_.owl#Tape1StateValue`` = _prefix ".owl#Tape1StateValue"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#Tape2StateValue"></see>
    /// </summary>
    let ``_.owl#Tape2StateValue`` = _prefix ".owl#Tape2StateValue"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#TunerStateValue"></see>
    /// </summary>
    let ``_.owl#TunerStateValue`` = _prefix ".owl#TunerStateValue"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#UpTripleStateValue"></see>
    /// </summary>
    let ``_.owl#UpTripleStateValue`` = _prefix ".owl#UpTripleStateValue"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl"></see>
    /// </summary>
    let ``_.owl`` = _prefix ".owl"
    /// <summary>
    /// System that provides security about access
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#AccessControlSystem"></see></summary>
    let ``_.owl#AccessControlSystem`` = _prefix ".owl#AccessControlSystem"
    /// <summary>
    /// Security system for detecting dangerous situation and intrusion
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#SecuritySystem"></see></summary>
    let ``_.owl#SecuritySystem`` = _prefix ".owl#SecuritySystem"
    /// <summary>
    /// System that detects the presence of fire
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#FireSystem"></see></summary>
    let ``_.owl#FireSystem`` = _prefix ".owl#FireSystem"
    /// <summary>
    /// System that detects the presence of flood
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#FloodSystem"></see></summary>
    let ``_.owl#FloodSystem`` = _prefix ".owl#FloodSystem"
    /// <summary>
    /// System that detects the presence of gas
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#GasSystem"></see></summary>
    let ``_.owl#GasSystem`` = _prefix ".owl#GasSystem"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#Acoustic"></see>
    /// </summary>
    let ``_.owl#Acoustic`` = _prefix ".owl#Acoustic"
    /// <summary>
    /// Indicates in which building environment is contained an object, e.g. the lamp5 isIn Kitchen
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#isIn"></see></summary>
    let ``_.owl#isIn`` = _prefix ".owl#isIn"
    /// <summary>
    /// Utility that provides electricity
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#ElectricalSystem"></see></summary>
    let ``_.owl#ElectricalSystem`` = _prefix ".owl#ElectricalSystem"
    /// <summary>
    /// A mechanism that puts something into automatic action
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Actuator"></see></summary>
    let ``_.owl#Actuator`` = _prefix ".owl#Actuator"
    /// <summary>
    /// A mechanism that controls the interaction with the electrical system
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Control"></see></summary>
    let ``_.owl#Control`` = _prefix ".owl#Control"
    /// <summary>
    /// System that provides artificial light
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Lighting"></see></summary>
    let ``_.owl#Lighting`` = _prefix ".owl#Lighting"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PowerDelivery"></see>
    /// </summary>
    let ``_.owl#PowerDelivery`` = _prefix ".owl#PowerDelivery"
    /// <summary>
    /// Class for grouping all electrically powered sensors
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Sensor"></see></summary>
    let ``_.owl#Sensor`` = _prefix ".owl#Sensor"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#DiscreteValue"></see>
    /// </summary>
    let ``_.owl#DiscreteValue`` = _prefix ".owl#DiscreteValue"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ActiveEnergyMeasurementFunctionality"></see>
    /// </summary>
    let ``_.owl#ActiveEnergyMeasurementFunctionality`` =
        _prefix ".owl#ActiveEnergyMeasurementFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#EnergyMeasurementFunctionality"></see>
    /// </summary>
    let ``_.owl#EnergyMeasurementFunctionality`` =
        _prefix ".owl#EnergyMeasurementFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ActiveEnergyMeasurementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#ActiveEnergyMeasurementNotificationFunctionality`` =
        _prefix ".owl#ActiveEnergyMeasurementNotificationFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#EnergyMeasurementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#EnergyMeasurementNotificationFunctionality`` =
        _prefix ".owl#EnergyMeasurementNotificationFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ActiveEnergyStateValue"></see>
    /// </summary>
    let ``_.owl#ActiveEnergyStateValue`` = _prefix ".owl#ActiveEnergyStateValue"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ContinuousValue"></see>
    /// </summary>
    let ``_.owl#ContinuousValue`` = _prefix ".owl#ContinuousValue"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ChannelStateValue"></see>
    /// </summary>
    let ``_.owl#ChannelStateValue`` = _prefix ".owl#ChannelStateValue"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PressureStateValue"></see>
    /// </summary>
    let ``_.owl#PressureStateValue`` = _prefix ".owl#PressureStateValue"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#TemperatureStateValue"></see>
    /// </summary>
    let ``_.owl#TemperatureStateValue`` = _prefix ".owl#TemperatureStateValue"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#FlowRateStateValue"></see>
    /// </summary>
    let ``_.owl#FlowRateStateValue`` = _prefix ".owl#FlowRateStateValue"
    /// <summary>
    /// Value for the Shade position state, the shade position can be expressed as position=closedLimitx(255-level)/255, where with level 0 the shade is closed and with level 255 the shade is completely open. Derives from ZigBee HA specifications.
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#ShadeStateValue"></see></summary>
    let ``_.owl#ShadeStateValue`` = _prefix ".owl#ShadeStateValue"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#HumidityStateValue"></see>
    /// </summary>
    let ``_.owl#HumidityStateValue`` = _prefix ".owl#HumidityStateValue"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#CurrentStateValue"></see>
    /// </summary>
    let ``_.owl#CurrentStateValue`` = _prefix ".owl#CurrentStateValue"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#LevelStateValue"></see>
    /// </summary>
    let ``_.owl#LevelStateValue`` = _prefix ".owl#LevelStateValue"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ReactiveEnergyStateValue"></see>
    /// </summary>
    let ``_.owl#ReactiveEnergyStateValue`` = _prefix ".owl#ReactiveEnergyStateValue"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ActivePowerMeasurementFunctionality"></see>
    /// </summary>
    let ``_.owl#ActivePowerMeasurementFunctionality`` =
        _prefix ".owl#ActivePowerMeasurementFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PowerMeasurementFunctionality"></see>
    /// </summary>
    let ``_.owl#PowerMeasurementFunctionality`` =
        _prefix ".owl#PowerMeasurementFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ActivePowerMeasurementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#ActivePowerMeasurementNotificationFunctionality`` =
        _prefix ".owl#ActivePowerMeasurementNotificationFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ElectricPowerMeasurementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#ElectricPowerMeasurementNotificationFunctionality`` =
        _prefix ".owl#ElectricPowerMeasurementNotificationFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ActivePowerMeasurementState"></see>
    /// </summary>
    let ``_.owl#ActivePowerMeasurementState`` =
        _prefix ".owl#ActivePowerMeasurementState"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ElectricPowerMeasurementState"></see>
    /// </summary>
    let ``_.owl#ElectricPowerMeasurementState`` =
        _prefix ".owl#ElectricPowerMeasurementState"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ActivePowerMeter"></see>
    /// </summary>
    let ``_.owl#ActivePowerMeter`` = _prefix ".owl#ActivePowerMeter"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PowerMeter"></see>
    /// </summary>
    let ``_.owl#PowerMeter`` = _prefix ".owl#PowerMeter"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ActivePowerStateValue"></see>
    /// </summary>
    let ``_.owl#ActivePowerStateValue`` = _prefix ".owl#ActivePowerStateValue"
    /// <summary>
    /// A system that keeps air cool and dry
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#AirConditioningSystem"></see></summary>
    let ``_.owl#AirConditioningSystem`` = _prefix ".owl#AirConditioningSystem"

    /// <summary>
    /// The thermostat request notification, requires a device having the thermostat control functionality to increase, set or decrease the current temperature. Derives from ZigBee HA (slightly modified...)
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#ThermostatNotificationFunctionality"></see></summary>
    let ``_.owl#ThermostatNotificationFunctionality`` =
        _prefix ".owl#ThermostatNotificationFunctionality"

    /// <summary>
    /// Provide functionalities to controllable things
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#hasFunctionality"></see></summary>
    let ``_.owl#hasFunctionality`` = _prefix ".owl#hasFunctionality"
    /// <summary>
    /// Functionality: turn on - turn off
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#OnOffFunctionality"></see></summary>
    let ``_.owl#OnOffFunctionality`` = _prefix ".owl#OnOffFunctionality"
    /// <summary>
    /// Heating Ventilating and Air Conditioning system
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#HVACSystem"></see></summary>
    let ``_.owl#HVACSystem`` = _prefix ".owl#HVACSystem"
    /// <summary>
    /// State: on - off
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#OnOffState"></see></summary>
    let ``_.owl#OnOffState`` = _prefix ".owl#OnOffState"
    /// <summary>
    /// Provide the actual state to controllable things
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#hasState"></see></summary>
    let ``_.owl#hasState`` = _prefix ".owl#hasState"

    /// <summary>
    /// Notification: on - off
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#OnOffNotificationFunctionality"></see></summary>
    let ``_.owl#OnOffNotificationFunctionality`` =
        _prefix ".owl#OnOffNotificationFunctionality"

    /// <summary>
    /// Functionalities for the regulation of temperature
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#ThermostatControlFunctionality"></see></summary>
    let ``_.owl#ThermostatControlFunctionality`` =
        _prefix ".owl#ThermostatControlFunctionality"

    /// <summary>
    /// The Pressure Sensor device measures and periodically reports the pressure of a liquid (typically water)
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#PressureSensor"></see></summary>
    let ``_.owl#PressureSensor`` = _prefix ".owl#PressureSensor"
    /// <summary>
    /// The Pump device is a pump that may have variable speed. It may have optional built-in sensors and a regulation mechanism. It is typically used for pumping water. Derives from ZigBee HA specifications.
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Pump"></see></summary>
    let ``_.owl#Pump`` = _prefix ".owl#Pump"
    /// <summary>
    /// The Pump device controller can control a Pump device
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#PumpController"></see></summary>
    let ``_.owl#PumpController`` = _prefix ".owl#PumpController"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#VentilatingSystem"></see>
    /// </summary>
    let ``_.owl#VentilatingSystem`` = _prefix ".owl#VentilatingSystem"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#Thermostat"></see>
    /// </summary>
    let ``_.owl#Thermostat`` = _prefix ".owl#Thermostat"
    /// <summary>
    /// Utility to warm a building
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#HeatingSystem"></see></summary>
    let ``_.owl#HeatingSystem`` = _prefix ".owl#HeatingSystem"
    /// <summary>
    /// The Flow  Sensor device measures and periodically reports the flow rate of a liquid (typically water)
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#SingleFlowSensor"></see></summary>
    let ``_.owl#SingleFlowSensor`` = _prefix ".owl#SingleFlowSensor"
    /// <summary>
    /// The Heating and Cooling Unit device can heat or cool a space in a house. It is not mandatory to provide both functionalities. It may be an indoor air handler. Derives from ZigBee HA specifications
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#HeatingAndCoolingUnit"></see></summary>
    let ``_.owl#HeatingAndCoolingUnit`` = _prefix ".owl#HeatingAndCoolingUnit"
    /// <summary>
    /// A clock that wakes sleeper at preset time
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#AlarmClock"></see></summary>
    let ``_.owl#AlarmClock`` = _prefix ".owl#AlarmClock"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#Clock"></see>
    /// </summary>
    let ``_.owl#Clock`` = _prefix ".owl#Clock"
    /// <summary>
    /// A machine for performing calculations automatically, work and play
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Computer"></see></summary>
    let ``_.owl#Computer`` = _prefix ".owl#Computer"
    /// <summary>
    /// A diversion that holds the attention
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Entertainment"></see></summary>
    let ``_.owl#Entertainment`` = _prefix ".owl#Entertainment"
    /// <summary>
    /// Appliances for communicate
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Communication"></see></summary>
    let ``_.owl#Communication`` = _prefix ".owl#Communication"
    /// <summary>
    /// A device for creating a current of air
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Fan"></see></summary>
    let ``_.owl#Fan`` = _prefix ".owl#Fan"
    /// <summary>
    /// Output device that prints
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Printer"></see></summary>
    let ``_.owl#Printer`` = _prefix ".owl#Printer"
    /// <summary>
    /// A kitchen appliance for brewing coffee automatically
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#CoffeeMaker"></see></summary>
    let ``_.owl#CoffeeMaker`` = _prefix ".owl#CoffeeMaker"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#AlertNotification"></see>
    /// </summary>
    let ``_.owl#AlertNotification`` = _prefix ".owl#AlertNotification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ParametricNotification"></see>
    /// </summary>
    let ``_.owl#ParametricNotification`` = _prefix ".owl#ParametricNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#AlertNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#AlertNotificationFunctionality`` =
        _prefix ".owl#AlertNotificationFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#hasNotification"></see>
    /// </summary>
    let ``_.owl#hasNotification`` = _prefix ".owl#hasNotification"

    /// <summary>
    /// Discrete notification with exactly one values
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#SingleValuedNotificationFunctionality"></see></summary>
    let ``_.owl#SingleValuedNotificationFunctionality`` =
        _prefix ".owl#SingleValuedNotificationFunctionality"

    /// <summary>
    /// Electronic device that answers the telephone and records messages
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#AnsweringMachine"></see></summary>
    let ``_.owl#AnsweringMachine`` = _prefix ".owl#AnsweringMachine"
    /// <summary>
    /// Appliance that send text and document
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Fax"></see></summary>
    let ``_.owl#Fax`` = _prefix ".owl#Fax"
    /// <summary>
    /// A telephonic intercommunication system linking different rooms in a building
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Interphone"></see></summary>
    let ``_.owl#Interphone`` = _prefix ".owl#Interphone"
    /// <summary>
    /// Appliance to comunicate with other person
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Phone"></see></summary>
    let ``_.owl#Phone`` = _prefix ".owl#Phone"
    /// <summary>
    /// System that provides security about intrusion
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#AntiIntrusionSystem"></see></summary>
    let ``_.owl#AntiIntrusionSystem`` = _prefix ".owl#AntiIntrusionSystem"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ApparentPowerMeasurementFunctionality"></see>
    /// </summary>
    let ``_.owl#ApparentPowerMeasurementFunctionality`` =
        _prefix ".owl#ApparentPowerMeasurementFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ApparentPowerMeasurementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#ApparentPowerMeasurementNotificationFunctionality`` =
        _prefix ".owl#ApparentPowerMeasurementNotificationFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ApparentPowerMeasurementState"></see>
    /// </summary>
    let ``_.owl#ApparentPowerMeasurementState`` =
        _prefix ".owl#ApparentPowerMeasurementState"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ApparentPowerMeter"></see>
    /// </summary>
    let ``_.owl#ApparentPowerMeter`` = _prefix ".owl#ApparentPowerMeter"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ApparentPowerStateValue"></see>
    /// </summary>
    let ``_.owl#ApparentPowerStateValue`` = _prefix ".owl#ApparentPowerStateValue"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ApplianceCycleTimingNotification"></see>
    /// </summary>
    let ``_.owl#ApplianceCycleTimingNotification`` =
        _prefix ".owl#ApplianceCycleTimingNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#EndTimeChangedNotification"></see>
    /// </summary>
    let ``_.owl#EndTimeChangedNotification`` = _prefix ".owl#EndTimeChangedNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#RemainingTimeChangedNotification"></see>
    /// </summary>
    let ``_.owl#RemainingTimeChangedNotification`` =
        _prefix ".owl#RemainingTimeChangedNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StartTimeChangedNotification"></see>
    /// </summary>
    let ``_.owl#StartTimeChangedNotification`` =
        _prefix ".owl#StartTimeChangedNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ApplianceManagementFunctionality"></see>
    /// </summary>
    let ``_.owl#ApplianceManagementFunctionality`` =
        _prefix ".owl#ApplianceManagementFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#DeleteApplianceCommand"></see>
    /// </summary>
    let ``_.owl#DeleteApplianceCommand`` = _prefix ".owl#DeleteApplianceCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#hasCommand"></see>
    /// </summary>
    let ``_.owl#hasCommand`` = _prefix ".owl#hasCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#InstallApplianceCommand"></see>
    /// </summary>
    let ``_.owl#InstallApplianceCommand`` = _prefix ".owl#InstallApplianceCommand"
    /// <summary>
    /// Derives from the general cluster functionalities defined in ZigBee HA specifications
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#NetworkFunctionality"></see></summary>
    let ``_.owl#NetworkFunctionality`` = _prefix ".owl#NetworkFunctionality"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#NonParametricNotification"></see>
    /// </summary>
    let ``_.owl#NonParametricNotification`` = _prefix ".owl#NonParametricNotification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PauseApplianceNotification"></see>
    /// </summary>
    let ``_.owl#PauseApplianceNotification`` = _prefix ".owl#PauseApplianceNotification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StartApplianceNotification"></see>
    /// </summary>
    let ``_.owl#StartApplianceNotification`` = _prefix ".owl#StartApplianceNotification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StopApplianceNotification"></see>
    /// </summary>
    let ``_.owl#StopApplianceNotification`` = _prefix ".owl#StopApplianceNotification"
    /// <summary>
    /// Durable goods for home or office use
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Appliances"></see></summary>
    let ``_.owl#Appliances`` = _prefix ".owl#Appliances"
    /// <summary>
    /// All building things that can be controlled by domotic system
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Controllable"></see></summary>
    let ``_.owl#Controllable`` = _prefix ".owl#Controllable"
    /// <summary>
    /// All plants of the house, e.g. Electrical system, Hydraulic system
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#HousePlants"></see></summary>
    let ``_.owl#HousePlants`` = _prefix ".owl#HousePlants"
    /// <summary>
    /// All the architectural elements that compose the environment
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Architectural"></see></summary>
    let ``_.owl#Architectural`` = _prefix ".owl#Architectural"
    /// <summary>
    /// All building things that can't be controlled by domotic system
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#UnControllable"></see></summary>
    let ``_.owl#UnControllable`` = _prefix ".owl#UnControllable"
    /// <summary>
    /// Furnishings that make a room or other area ready for occupancy
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Furniture"></see></summary>
    let ``_.owl#Furniture`` = _prefix ".owl#Furniture"
    /// <summary>
    /// Chair with a support on each side for arms
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Armchair"></see></summary>
    let ``_.owl#Armchair`` = _prefix ".owl#Armchair"
    /// <summary>
    /// A canopy made of canvas to shelter people or things from rain or sun.
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Awning"></see></summary>
    let ``_.owl#Awning`` = _prefix ".owl#Awning"
    /// <summary>
    /// A tall piece of furniture that provides storage space for clothes
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Wardrobe"></see></summary>
    let ``_.owl#Wardrobe`` = _prefix ".owl#Wardrobe"
    /// <summary>
    /// Confine to a small space.
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Closet"></see></summary>
    let ``_.owl#Closet`` = _prefix ".owl#Closet"
    /// <summary>
    /// An upholstered seat for more than one person
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Sofa"></see></summary>
    let ``_.owl#Sofa`` = _prefix ".owl#Sofa"
    /// <summary>
    /// A small room (or recess) or cabinet used for storage space
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Cupboard"></see></summary>
    let ``_.owl#Cupboard`` = _prefix ".owl#Cupboard"
    /// <summary>
    /// Shade object, the name includes an underscore sign only for distinguishing the name from the shade actuator, whose name is directly mapped from ZigBee
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Shade"></see></summary>
    let ``_.owl#Shade`` = _prefix ".owl#Shade"
    /// <summary>
    /// A seat for one person, with a support for the back.
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Chair"></see></summary>
    let ``_.owl#Chair`` = _prefix ".owl#Chair"
    /// <summary>
    /// Piece of furniture that provides a place to sleep.
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Bed"></see></summary>
    let ``_.owl#Bed`` = _prefix ".owl#Bed"
    /// <summary>
    /// A small table or stand placed at a bedside.
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Nightstand"></see></summary>
    let ``_.owl#Nightstand`` = _prefix ".owl#Nightstand"
    /// <summary>
    /// A hinged cover or screen for a window, usually fitted with louvers.
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Shutter"></see></summary>
    let ``_.owl#Shutter`` = _prefix ".owl#Shutter"
    /// <summary>
    /// A piece of furniture with a writing surface and usually drawers or other compartments
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Desk"></see></summary>
    let ``_.owl#Desk`` = _prefix ".owl#Desk"
    /// <summary>
    /// All the fixtures of a bathroom
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#SanitaryFixtures"></see></summary>
    let ``_.owl#SanitaryFixtures`` = _prefix ".owl#SanitaryFixtures"
    /// <summary>
    /// A boxlike container in a piece of furniture; made so as to slide in and out
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Drawer"></see></summary>
    let ``_.owl#Drawer`` = _prefix ".owl#Drawer"
    /// <summary>
    /// A piece of furniture having a smooth flat top that is usually supported by one or more vertical legs
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Table"></see></summary>
    let ``_.owl#Table`` = _prefix ".owl#Table"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#AssociateCommand"></see>
    /// </summary>
    let ``_.owl#AssociateCommand`` = _prefix ".owl#AssociateCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#NonParametricCommand"></see>
    /// </summary>
    let ``_.owl#NonParametricCommand`` = _prefix ".owl#NonParametricCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#VoidCommand"></see>
    /// </summary>
    let ``_.owl#VoidCommand`` = _prefix ".owl#VoidCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#AssociateFunctionality"></see>
    /// </summary>
    let ``_.owl#AssociateFunctionality`` = _prefix ".owl#AssociateFunctionality"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#DisassociateCommand"></see>
    /// </summary>
    let ``_.owl#DisassociateCommand`` = _prefix ".owl#DisassociateCommand"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#AssociatingDeviceNotification"></see>
    /// </summary>
    let ``_.owl#AssociatingDeviceNotification`` =
        _prefix ".owl#AssociatingDeviceNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ZWaveNotification"></see>
    /// </summary>
    let ``_.owl#ZWaveNotification`` = _prefix ".owl#ZWaveNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#AssociationNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#AssociationNotificationFunctionality`` =
        _prefix ".owl#AssociationNotificationFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#DisassociatingDeviceNotification"></see>
    /// </summary>
    let ``_.owl#DisassociatingDeviceNotification`` =
        _prefix ".owl#DisassociatingDeviceNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#IdleNotification"></see>
    /// </summary>
    let ``_.owl#IdleNotification`` = _prefix ".owl#IdleNotification"

    /// <summary>
    /// Derives from the general cluster functionalities defined in ZigBee HA specifications
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#NetworkNotificationFunctionality"></see></summary>
    let ``_.owl#NetworkNotificationFunctionality`` =
        _prefix ".owl#NetworkNotificationFunctionality"

    /// <summary>
    /// Association between a mobile uncontrollable object and its actuator
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#hasActuator"></see></summary>
    let ``_.owl#hasActuator`` = _prefix ".owl#hasActuator"
    /// <summary>
    /// A mechanism that allow automatic control about awning
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#AwningActuator"></see></summary>
    let ``_.owl#AwningActuator`` = _prefix ".owl#AwningActuator"
    /// <summary>
    /// Functionality: open - close
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#OpenCloseFunctionality"></see></summary>
    let ``_.owl#OpenCloseFunctionality`` = _prefix ".owl#OpenCloseFunctionality"
    /// <summary>
    /// State: open - close
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#OpenCloseState"></see></summary>
    let ``_.owl#OpenCloseState`` = _prefix ".owl#OpenCloseState"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MovementState"></see>
    /// </summary>
    let ``_.owl#MovementState`` = _prefix ".owl#MovementState"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#actuatorOf"></see>
    /// </summary>
    let ``_.owl#actuatorOf`` = _prefix ".owl#actuatorOf"

    /// <summary>
    /// Notification: open - close
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#OpenCloseNotificationFunctionality"></see></summary>
    let ``_.owl#OpenCloseNotificationFunctionality`` =
        _prefix ".owl#OpenCloseNotificationFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MovementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#MovementNotificationFunctionality`` =
        _prefix ".owl#MovementNotificationFunctionality"

    /// <summary>
    /// A mechanism that allow automatic opening and closing about window
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#WindowActuator"></see></summary>
    let ``_.owl#WindowActuator`` = _prefix ".owl#WindowActuator"
    /// <summary>
    /// A mechanism that allow automatic opening and closing about door
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#DoorActuator"></see></summary>
    let ``_.owl#DoorActuator`` = _prefix ".owl#DoorActuator"
    /// <summary>
    /// A mechanism that allow automatic opening and closing about gate
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#GateActuator"></see></summary>
    let ``_.owl#GateActuator`` = _prefix ".owl#GateActuator"
    /// <summary>
    /// The Shade Actuator device provides the ability to open or close window coverings, including setting partially open or partially closed states. This device type includes roller shades, drapes and tilt-only blinds actuators. Derives from ZigBee HA specifications (Shade device)
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#ShadeActuator"></see></summary>
    let ``_.owl#ShadeActuator`` = _prefix ".owl#ShadeActuator"
    /// <summary>
    /// A mechanism that allow automatic control about shutter
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#ShutterActuator"></see></summary>
    let ``_.owl#ShutterActuator`` = _prefix ".owl#ShutterActuator"
    /// <summary>
    /// Components manufactured by Bticino
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#BTicinoComponent"></see></summary>
    let ``_.owl#BTicinoComponent`` = _prefix ".owl#BTicinoComponent"
    /// <summary>
    /// The address of the component
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#physicalAddress"></see></summary>
    let ``_.owl#physicalAddress`` = _prefix ".owl#physicalAddress"
    /// <summary>
    /// The category of the component
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#physicalType"></see></summary>
    let ``_.owl#physicalType`` = _prefix ".owl#physicalType"
    /// <summary>
    /// The manufacturers of the domotic component
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#NetworkComponent"></see></summary>
    let ``_.owl#NetworkComponent`` = _prefix ".owl#NetworkComponent"
    /// <summary>
    /// Emulated component
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#EliteComponent"></see></summary>
    let ``_.owl#EliteComponent`` = _prefix ".owl#EliteComponent"
    /// <summary>
    /// Components manufactured by Konnex
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#KonnexComponent"></see></summary>
    let ``_.owl#KonnexComponent`` = _prefix ".owl#KonnexComponent"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ZigBeeComponent"></see>
    /// </summary>
    let ``_.owl#ZigBeeComponent`` = _prefix ".owl#ZigBeeComponent"
    /// <summary>
    /// A BTIcino Gateway
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#BTicinoGateway"></see></summary>
    let ``_.owl#BTicinoGateway`` = _prefix ".owl#BTicinoGateway"
    /// <summary>
    /// A Konnex Gateway
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#KonnexGateway"></see></summary>
    let ``_.owl#KonnexGateway`` = _prefix ".owl#KonnexGateway"
    /// <summary>
    /// A software emulator of a network level to be used for simulating devices not available in the real world
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#EliteGateway"></see></summary>
    let ``_.owl#EliteGateway`` = _prefix ".owl#EliteGateway"
    /// <summary>
    /// A platform projecting from the wall of a building and surrounded by a balustrade or railing or parapet
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Balcony"></see></summary>
    let ``_.owl#Balcony`` = _prefix ".owl#Balcony"
    /// <summary>
    /// The horizontal architectural component of a building
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Horizontal"></see></summary>
    let ``_.owl#Horizontal`` = _prefix ".owl#Horizontal"
    /// <summary>
    /// The overhead upper surface of a room
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Ceiling"></see></summary>
    let ``_.owl#Ceiling`` = _prefix ".owl#Ceiling"
    /// <summary>
    /// The inside lower horizontal surface of a room
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Floor"></see></summary>
    let ``_.owl#Floor`` = _prefix ".owl#Floor"
    /// <summary>
    /// Outdoor area adjoining a residence
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Terrace"></see></summary>
    let ``_.owl#Terrace`` = _prefix ".owl#Terrace"
    /// <summary>
    /// A room of the building
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Room"></see></summary>
    let ``_.owl#Room`` = _prefix ".owl#Room"
    /// <summary>
    /// A relatively large open container that you fill with water and use to wash the body
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Bathtub"></see></summary>
    let ``_.owl#Bathtub`` = _prefix ".owl#Bathtub"
    /// <summary>
    /// A basin for washing genitals and anal area
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Bidet"></see></summary>
    let ``_.owl#Bidet`` = _prefix ".owl#Bidet"
    /// <summary>
    /// A plumbing fixture that sprays water over you
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Shower"></see></summary>
    let ``_.owl#Shower`` = _prefix ".owl#Shower"
    /// <summary>
    /// A basin for washing the hands
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Washbasin"></see></summary>
    let ``_.owl#Washbasin`` = _prefix ".owl#Washbasin"
    /// <summary>
    /// A plumbing fixture for defecation and urination
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#WaterCloset"></see></summary>
    let ``_.owl#WaterCloset`` = _prefix ".owl#WaterCloset"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#BatteryLevelNotification"></see>
    /// </summary>
    let ``_.owl#BatteryLevelNotification`` = _prefix ".owl#BatteryLevelNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#BatteryLevelNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#BatteryLevelNotificationFunctionality`` =
        _prefix ".owl#BatteryLevelNotificationFunctionality"

    /// <summary>
    /// Notification of continuous values
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#ContinuousNotificationFunctionality"></see></summary>
    let ``_.owl#ContinuousNotificationFunctionality`` =
        _prefix ".owl#ContinuousNotificationFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#BlueStateValue"></see>
    /// </summary>
    let ``_.owl#BlueStateValue`` = _prefix ".owl#BlueStateValue"
    /// <summary>
    /// Sealed vessel where water is warm up
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Boiler"></see></summary>
    let ``_.owl#Boiler`` = _prefix ".owl#Boiler"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#HeatingApplianceState"></see>
    /// </summary>
    let ``_.owl#HeatingApplianceState`` = _prefix ".owl#HeatingApplianceState"
    /// <summary>
    /// Major household appliances.
    ///
    /// It mus be noticed that the functionality modeling uses existential quantifiers for functionalities that can be optional, this is only for the sake of easier interpretation and should be improved in future releases
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#WhiteGoods"></see></summary>
    let ``_.owl#WhiteGoods`` = _prefix ".owl#WhiteGoods"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SuperHeatingNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#SuperHeatingNotificationFunctionality`` =
        _prefix ".owl#SuperHeatingNotificationFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SuperHeatingFunctionality"></see>
    /// </summary>
    let ``_.owl#SuperHeatingFunctionality`` = _prefix ".owl#SuperHeatingFunctionality"
    /// <summary>
    /// A utensil for cooking
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Cooker"></see></summary>
    let ``_.owl#Cooker`` = _prefix ".owl#Cooker"
    /// <summary>
    /// Electric refrigerator in which food is frozen and stored for long periods of time
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#DeepFreezer"></see></summary>
    let ``_.owl#DeepFreezer`` = _prefix ".owl#DeepFreezer"
    /// <summary>
    /// A home appliance for washing clothes and linens automatically
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#WashingMachine"></see></summary>
    let ``_.owl#WashingMachine`` = _prefix ".owl#WashingMachine"
    /// <summary>
    /// Kitchen appliance used for baking or roasting
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Oven"></see></summary>
    let ``_.owl#Oven`` = _prefix ".owl#Oven"
    /// <summary>
    /// A refrigerator in which the coolant is pumped around by an electric motor
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Fridge"></see></summary>
    let ``_.owl#Fridge`` = _prefix ".owl#Fridge"
    /// <summary>
    /// A machine for washing dishes
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Dishwasher"></see></summary>
    let ``_.owl#Dishwasher`` = _prefix ".owl#Dishwasher"
    /// <summary>
    /// Heating apparatus
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Stove"></see></summary>
    let ``_.owl#Stove`` = _prefix ".owl#Stove"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#BrightnessStateValue"></see>
    /// </summary>
    let ``_.owl#BrightnessStateValue`` = _prefix ".owl#BrightnessStateValue"
    /// <summary>
    /// Small household electrical entertainment appliances
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#BrownGoods"></see></summary>
    let ``_.owl#BrownGoods`` = _prefix ".owl#BrownGoods"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#Building"></see>
    /// </summary>
    let ``_.owl#Building`` = _prefix ".owl#Building"
    /// <summary>
    /// Indicates which object are contained in a building environment, e.g. the kitchen contains Lamp1,Lamp2...
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#contains"></see></summary>
    let ``_.owl#contains`` = _prefix ".owl#contains"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#Flat"></see>
    /// </summary>
    let ``_.owl#Flat`` = _prefix ".owl#Flat"
    /// <summary>
    /// A physical environment in which people lives, e.g. kitchen, bathroom
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#BuildingEnvironment"></see></summary>
    let ``_.owl#BuildingEnvironment`` = _prefix ".owl#BuildingEnvironment"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#Storey"></see>
    /// </summary>
    let ``_.owl#Storey`` = _prefix ".owl#Storey"
    /// <summary>
    /// The garden of the building
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Garden"></see></summary>
    let ``_.owl#Garden`` = _prefix ".owl#Garden"
    /// <summary>
    /// The garage of the buinding
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Garage"></see></summary>
    let ``_.owl#Garage`` = _prefix ".owl#Garage"
    /// <summary>
    /// All things that creates a Building, it is intended as root of all building components
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#BuildingThing"></see></summary>
    let ``_.owl#BuildingThing`` = _prefix ".owl#BuildingThing"
    /// <summary>
    /// A monostable electrical switch operated by pressing a button
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Button"></see></summary>
    let ``_.owl#Button`` = _prefix ".owl#Button"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ButtonNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#ButtonNotificationFunctionality`` =
        _prefix ".owl#ButtonNotificationFunctionality"

    /// <summary>
    /// The Scene Selector device is capable of setting up and selecting scenes on other devices, including group of devices. It derives from ZigBee HA specifications.
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#SceneSelector"></see></summary>
    let ``_.owl#SceneSelector`` = _prefix ".owl#SceneSelector"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SingleScenarioControl"></see>
    /// </summary>
    let ``_.owl#SingleScenarioControl`` = _prefix ".owl#SingleScenarioControl"
    /// <summary>
    /// A round handle used to adjust continuous amplitude, e.g. volume
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Knob"></see></summary>
    let ``_.owl#Knob`` = _prefix ".owl#Knob"
    /// <summary>
    /// The Shade Controller device can control the level of a shade, derives from ZigBee HA specifications
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#ShadeController"></see></summary>
    let ``_.owl#ShadeController`` = _prefix ".owl#ShadeController"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ToggleRelay"></see>
    /// </summary>
    let ``_.owl#ToggleRelay`` = _prefix ".owl#ToggleRelay"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#RemoteControl"></see>
    /// </summary>
    let ``_.owl#RemoteControl`` = _prefix ".owl#RemoteControl"
    /// <summary>
    /// Bi-stable control consisting of a mechanical or electrical or electronic device for making or breaking or changing the connections in a circuit
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Switch"></see></summary>
    let ``_.owl#Switch`` = _prefix ".owl#Switch"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ButtonMNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#ButtonMNotificationFunctionality`` =
        _prefix ".owl#ButtonMNotificationFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ReleasedMNotification"></see>
    /// </summary>
    let ``_.owl#ReleasedMNotification`` = _prefix ".owl#ReleasedMNotification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PressedMNotification"></see>
    /// </summary>
    let ``_.owl#PressedMNotification`` = _prefix ".owl#PressedMNotification"

    /// <summary>
    /// Discrete notification with exactly two values
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#DoubleValuedNotificationFunctionality"></see></summary>
    let ``_.owl#DoubleValuedNotificationFunctionality`` =
        _prefix ".owl#DoubleValuedNotificationFunctionality"

    /// <summary>
    /// An electric signaling device, such as a doorbell, that makes a buzzing sound.
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Buzzer"></see></summary>
    let ``_.owl#Buzzer`` = _prefix ".owl#Buzzer"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#CameraPictureImageControlFunctionality"></see>
    /// </summary>
    let ``_.owl#CameraPictureImageControlFunctionality`` =
        _prefix ".owl#CameraPictureImageControlFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#IncreaseColorCommand"></see>
    /// </summary>
    let ``_.owl#IncreaseColorCommand`` = _prefix ".owl#IncreaseColorCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#IncreaseContrastCommand"></see>
    /// </summary>
    let ``_.owl#IncreaseContrastCommand`` = _prefix ".owl#IncreaseContrastCommand"

    /// <summary>
    /// Functionalities continuous in time or space
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#ContinuousControlFunctionality"></see></summary>
    let ``_.owl#ContinuousControlFunctionality`` =
        _prefix ".owl#ContinuousControlFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#DecreaseLuminosityCommand"></see>
    /// </summary>
    let ``_.owl#DecreaseLuminosityCommand`` = _prefix ".owl#DecreaseLuminosityCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#IncreaseLuminosityCommand"></see>
    /// </summary>
    let ``_.owl#IncreaseLuminosityCommand`` = _prefix ".owl#IncreaseLuminosityCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#DecreaseContrastCommand"></see>
    /// </summary>
    let ``_.owl#DecreaseContrastCommand`` = _prefix ".owl#DecreaseContrastCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#DecreaseColorCommand"></see>
    /// </summary>
    let ``_.owl#DecreaseColorCommand`` = _prefix ".owl#DecreaseColorCommand"

    /// <summary>
    /// Functionalities for the regulation of timer
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#TimeRegulationFunctionality"></see></summary>
    let ``_.owl#TimeRegulationFunctionality`` =
        _prefix ".owl#TimeRegulationFunctionality"

    /// <summary>
    /// Models the capability of controlling the speed of a cooling/heating fan. Derives from ZigBee HA
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#FanControlFunctionality"></see></summary>
    let ``_.owl#FanControlFunctionality`` = _prefix ".owl#FanControlFunctionality"
    /// <summary>
    /// Level control functionality, used for allowing devices to be controlled in a continuous manner, derives from ZigBee Home Automation specifications
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#LevelControlFunctionality"></see></summary>
    let ``_.owl#LevelControlFunctionality`` = _prefix ".owl#LevelControlFunctionality"

    /// <summary>
    /// Functionalities for the regulation of shutter
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#ShutterRegulationFunctionality"></see></summary>
    let ``_.owl#ShutterRegulationFunctionality`` =
        _prefix ".owl#ShutterRegulationFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#CameraPictureQualityControlFunctionality"></see>
    /// </summary>
    let ``_.owl#CameraPictureQualityControlFunctionality`` =
        _prefix ".owl#CameraPictureQualityControlFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ColorControlFunctionality"></see>
    /// </summary>
    let ``_.owl#ColorControlFunctionality`` = _prefix ".owl#ColorControlFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#CameraPictureZoomPanControlFunctionality"></see>
    /// </summary>
    let ``_.owl#CameraPictureZoomPanControlFunctionality`` =
        _prefix ".owl#CameraPictureZoomPanControlFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#TunerFunctionality"></see>
    /// </summary>
    let ``_.owl#TunerFunctionality`` = _prefix ".owl#TunerFunctionality"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#IncreaseQualityCommand"></see>
    /// </summary>
    let ``_.owl#IncreaseQualityCommand`` = _prefix ".owl#IncreaseQualityCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#DecreaseQualityCommand"></see>
    /// </summary>
    let ``_.owl#DecreaseQualityCommand`` = _prefix ".owl#DecreaseQualityCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PanRightCommand"></see>
    /// </summary>
    let ``_.owl#PanRightCommand`` = _prefix ".owl#PanRightCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PanDownCommand"></see>
    /// </summary>
    let ``_.owl#PanDownCommand`` = _prefix ".owl#PanDownCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PanLeftCommand"></see>
    /// </summary>
    let ``_.owl#PanLeftCommand`` = _prefix ".owl#PanLeftCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ZoomOutCommand"></see>
    /// </summary>
    let ``_.owl#ZoomOutCommand`` = _prefix ".owl#ZoomOutCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ZoomInCommand"></see>
    /// </summary>
    let ``_.owl#ZoomInCommand`` = _prefix ".owl#ZoomInCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PanUpCommand"></see>
    /// </summary>
    let ``_.owl#PanUpCommand`` = _prefix ".owl#PanUpCommand"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ChangedDesiredTemperatureNotification"></see>
    /// </summary>
    let ``_.owl#ChangedDesiredTemperatureNotification`` =
        _prefix ".owl#ChangedDesiredTemperatureNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#DeleteSceneNotification"></see>
    /// </summary>
    let ``_.owl#DeleteSceneNotification`` = _prefix ".owl#DeleteSceneNotification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StoreSceneNotification"></see>
    /// </summary>
    let ``_.owl#StoreSceneNotification`` = _prefix ".owl#StoreSceneNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PressureMeasurementMNotification"></see>
    /// </summary>
    let ``_.owl#PressureMeasurementMNotification`` =
        _prefix ".owl#PressureMeasurementMNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#HumidityMeasurementMNotification"></see>
    /// </summary>
    let ``_.owl#HumidityMeasurementMNotification`` =
        _prefix ".owl#HumidityMeasurementMNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#LeaveGroupNotification"></see>
    /// </summary>
    let ``_.owl#LeaveGroupNotification`` = _prefix ".owl#LeaveGroupNotification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#JoinGroupNotification"></see>
    /// </summary>
    let ``_.owl#JoinGroupNotification`` = _prefix ".owl#JoinGroupNotification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#LevelControlNotification"></see>
    /// </summary>
    let ``_.owl#LevelControlNotification`` = _prefix ".owl#LevelControlNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#TemperatureMeasurementMNotification"></see>
    /// </summary>
    let ``_.owl#TemperatureMeasurementMNotification`` =
        _prefix ".owl#TemperatureMeasurementMNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#FlowRateMeasurementMNotification"></see>
    /// </summary>
    let ``_.owl#FlowRateMeasurementMNotification`` =
        _prefix ".owl#FlowRateMeasurementMNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ChannelControlNotification"></see>
    /// </summary>
    let ``_.owl#ChannelControlNotification`` = _prefix ".owl#ChannelControlNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ParametricLevelNotification"></see>
    /// </summary>
    let ``_.owl#ParametricLevelNotification`` =
        _prefix ".owl#ParametricLevelNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ClimateScheduleFunctionality"></see>
    /// </summary>
    let ``_.owl#ClimateScheduleFunctionality`` =
        _prefix ".owl#ClimateScheduleFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SetDailyClimateScheduleCommand"></see>
    /// </summary>
    let ``_.owl#SetDailyClimateScheduleCommand`` =
        _prefix ".owl#SetDailyClimateScheduleCommand"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SetClimateScheduleCommand"></see>
    /// </summary>
    let ``_.owl#SetClimateScheduleCommand`` = _prefix ".owl#SetClimateScheduleCommand"
    /// <summary>
    /// Discrete functionalities with exactly two values
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#DoubleValuedFunctionality"></see></summary>
    let ``_.owl#DoubleValuedFunctionality`` = _prefix ".owl#DoubleValuedFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ClimateScheduleNotification"></see>
    /// </summary>
    let ``_.owl#ClimateScheduleNotification`` =
        _prefix ".owl#ClimateScheduleNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ClimateScheduleNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#ClimateScheduleNotificationFunctionality`` =
        _prefix ".owl#ClimateScheduleNotificationFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#WeeklyClimateScheduleNotification"></see>
    /// </summary>
    let ``_.owl#WeeklyClimateScheduleNotification`` =
        _prefix ".owl#WeeklyClimateScheduleNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#DailyClimateScheduleNotification"></see>
    /// </summary>
    let ``_.owl#DailyClimateScheduleNotification`` =
        _prefix ".owl#DailyClimateScheduleNotification"

    /// <summary>
    /// Notification of fixed values
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#DiscreteNotificationFunctionality"></see></summary>
    let ``_.owl#DiscreteNotificationFunctionality`` =
        _prefix ".owl#DiscreteNotificationFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ClimateScheduleQueryFunctionality"></see>
    /// </summary>
    let ``_.owl#ClimateScheduleQueryFunctionality`` =
        _prefix ".owl#ClimateScheduleQueryFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#GetClimateScheduleCommand"></see>
    /// </summary>
    let ``_.owl#GetClimateScheduleCommand`` = _prefix ".owl#GetClimateScheduleCommand"
    /// <summary>
    /// Capability of a controllable building thing that must reply to an interrogation about its state
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#QueryFunctionality"></see></summary>
    let ``_.owl#QueryFunctionality`` = _prefix ".owl#QueryFunctionality"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ClimateScheduleState"></see>
    /// </summary>
    let ``_.owl#ClimateScheduleState`` = _prefix ".owl#ClimateScheduleState"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#hasStateValue"></see>
    /// </summary>
    let ``_.owl#hasStateValue`` = _prefix ".owl#hasStateValue"
    /// <summary>
    /// States not continuous, with fixed values
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#DiscreteState"></see></summary>
    let ``_.owl#DiscreteState`` = _prefix ".owl#DiscreteState"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#CloseCommand"></see>
    /// </summary>
    let ``_.owl#CloseCommand`` = _prefix ".owl#CloseCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StopHeatingCoolingCommand"></see>
    /// </summary>
    let ``_.owl#StopHeatingCoolingCommand`` = _prefix ".owl#StopHeatingCoolingCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#GetCommand"></see>
    /// </summary>
    let ``_.owl#GetCommand`` = _prefix ".owl#GetCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#DeleteGroupCommand"></see>
    /// </summary>
    let ``_.owl#DeleteGroupCommand`` = _prefix ".owl#DeleteGroupCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PreviousTrackCommand"></see>
    /// </summary>
    let ``_.owl#PreviousTrackCommand`` = _prefix ".owl#PreviousTrackCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SetHourCommand"></see>
    /// </summary>
    let ``_.owl#SetHourCommand`` = _prefix ".owl#SetHourCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StandBy"></see>
    /// </summary>
    let ``_.owl#StandBy`` = _prefix ".owl#StandBy"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#OffCommand"></see>
    /// </summary>
    let ``_.owl#OffCommand`` = _prefix ".owl#OffCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SetTimeoutCommand"></see>
    /// </summary>
    let ``_.owl#SetTimeoutCommand`` = _prefix ".owl#SetTimeoutCommand"
    /// <summary>
    /// the command for getting the occupancy state of a given room/environment
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#GetOccupancyCommand"></see></summary>
    let ``_.owl#GetOccupancyCommand`` = _prefix ".owl#GetOccupancyCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#RewindCommand"></see>
    /// </summary>
    let ``_.owl#RewindCommand`` = _prefix ".owl#RewindCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PlayCommand"></see>
    /// </summary>
    let ``_.owl#PlayCommand`` = _prefix ".owl#PlayCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#NextTrackCommand"></see>
    /// </summary>
    let ``_.owl#NextTrackCommand`` = _prefix ".owl#NextTrackCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#GoToTrackCommand"></see>
    /// </summary>
    let ``_.owl#GoToTrackCommand`` = _prefix ".owl#GoToTrackCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ForwardCommand"></see>
    /// </summary>
    let ``_.owl#ForwardCommand`` = _prefix ".owl#ForwardCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StoreSceneCommand"></see>
    /// </summary>
    let ``_.owl#StoreSceneCommand`` = _prefix ".owl#StoreSceneCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#OnFlashingCommand"></see>
    /// </summary>
    let ``_.owl#OnFlashingCommand`` = _prefix ".owl#OnFlashingCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#UpCommand"></see>
    /// </summary>
    let ``_.owl#UpCommand`` = _prefix ".owl#UpCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#GetPressureCommand"></see>
    /// </summary>
    let ``_.owl#GetPressureCommand`` = _prefix ".owl#GetPressureCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#OnCommand"></see>
    /// </summary>
    let ``_.owl#OnCommand`` = _prefix ".owl#OnCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StopPlayingCommand"></see>
    /// </summary>
    let ``_.owl#StopPlayingCommand`` = _prefix ".owl#StopPlayingCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#GetFlowRateCommand"></see>
    /// </summary>
    let ``_.owl#GetFlowRateCommand`` = _prefix ".owl#GetFlowRateCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SetChannelCommand"></see>
    /// </summary>
    let ``_.owl#SetChannelCommand`` = _prefix ".owl#SetChannelCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#DownCommand"></see>
    /// </summary>
    let ``_.owl#DownCommand`` = _prefix ".owl#DownCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#RestCommand"></see>
    /// </summary>
    let ``_.owl#RestCommand`` = _prefix ".owl#RestCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SetCommand"></see>
    /// </summary>
    let ``_.owl#SetCommand`` = _prefix ".owl#SetCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StoreGroupCommand"></see>
    /// </summary>
    let ``_.owl#StoreGroupCommand`` = _prefix ".owl#StoreGroupCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#HeatCommand"></see>
    /// </summary>
    let ``_.owl#HeatCommand`` = _prefix ".owl#HeatCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SetMinutesCommand"></see>
    /// </summary>
    let ``_.owl#SetMinutesCommand`` = _prefix ".owl#SetMinutesCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#GetRelativeHumidityCommand"></see>
    /// </summary>
    let ``_.owl#GetRelativeHumidityCommand`` = _prefix ".owl#GetRelativeHumidityCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SetDesiredTemperature"></see>
    /// </summary>
    let ``_.owl#SetDesiredTemperature`` = _prefix ".owl#SetDesiredTemperature"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#GrabPictureCommand"></see>
    /// </summary>
    let ``_.owl#GrabPictureCommand`` = _prefix ".owl#GrabPictureCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SetSpeedCommand"></see>
    /// </summary>
    let ``_.owl#SetSpeedCommand`` = _prefix ".owl#SetSpeedCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#CoolCommand"></see>
    /// </summary>
    let ``_.owl#CoolCommand`` = _prefix ".owl#CoolCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StepDownCommand"></see>
    /// </summary>
    let ``_.owl#StepDownCommand`` = _prefix ".owl#StepDownCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SetSecondsCommand"></see>
    /// </summary>
    let ``_.owl#SetSecondsCommand`` = _prefix ".owl#SetSecondsCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StepUpCommand"></see>
    /// </summary>
    let ``_.owl#StepUpCommand`` = _prefix ".owl#StepUpCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PauseCommand"></see>
    /// </summary>
    let ``_.owl#PauseCommand`` = _prefix ".owl#PauseCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SetVolumeCommand"></see>
    /// </summary>
    let ``_.owl#SetVolumeCommand`` = _prefix ".owl#SetVolumeCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#TimedOnCommand"></see>
    /// </summary>
    let ``_.owl#TimedOnCommand`` = _prefix ".owl#TimedOnCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SpeedDownCommand"></see>
    /// </summary>
    let ``_.owl#SpeedDownCommand`` = _prefix ".owl#SpeedDownCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ToggleCommand"></see>
    /// </summary>
    let ``_.owl#ToggleCommand`` = _prefix ".owl#ToggleCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#OpenCommand"></see>
    /// </summary>
    let ``_.owl#OpenCommand`` = _prefix ".owl#OpenCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#GetTemperatureCommand"></see>
    /// </summary>
    let ``_.owl#GetTemperatureCommand`` = _prefix ".owl#GetTemperatureCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#OffFlashingCommand"></see>
    /// </summary>
    let ``_.owl#OffFlashingCommand`` = _prefix ".owl#OffFlashingCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#DeleteSceneCommand"></see>
    /// </summary>
    let ``_.owl#DeleteSceneCommand`` = _prefix ".owl#DeleteSceneCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SpeedUpCommand"></see>
    /// </summary>
    let ``_.owl#SpeedUpCommand`` = _prefix ".owl#SpeedUpCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#CloseNetworkCommand"></see>
    /// </summary>
    let ``_.owl#CloseNetworkCommand`` = _prefix ".owl#CloseNetworkCommand"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#Co2MeasurementFunctionality"></see>
    /// </summary>
    let ``_.owl#Co2MeasurementFunctionality`` =
        _prefix ".owl#Co2MeasurementFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#GetCo2ConcentrationCommand"></see>
    /// </summary>
    let ``_.owl#GetCo2ConcentrationCommand`` = _prefix ".owl#GetCo2ConcentrationCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#Co2MeasurementNotification"></see>
    /// </summary>
    let ``_.owl#Co2MeasurementNotification`` = _prefix ".owl#Co2MeasurementNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#Co2MeasurementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#Co2MeasurementNotificationFunctionality`` =
        _prefix ".owl#Co2MeasurementNotificationFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#Co2MeasurementState"></see>
    /// </summary>
    let ``_.owl#Co2MeasurementState`` = _prefix ".owl#Co2MeasurementState"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#Co2MeasurementStateValue"></see>
    /// </summary>
    let ``_.owl#Co2MeasurementStateValue`` = _prefix ".owl#Co2MeasurementStateValue"
    /// <summary>
    /// States continuous in time or space
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#ContinuousState"></see></summary>
    let ``_.owl#ContinuousState`` = _prefix ".owl#ContinuousState"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#Co2Sensor"></see>
    /// </summary>
    let ``_.owl#Co2Sensor`` = _prefix ".owl#Co2Sensor"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ColdWaterM3MeasurementNotification"></see>
    /// </summary>
    let ``_.owl#ColdWaterM3MeasurementNotification`` =
        _prefix ".owl#ColdWaterM3MeasurementNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SetColorRGBCommand"></see>
    /// </summary>
    let ``_.owl#SetColorRGBCommand`` = _prefix ".owl#SetColorRGBCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SetColorHSBCommand"></see>
    /// </summary>
    let ``_.owl#SetColorHSBCommand`` = _prefix ".owl#SetColorHSBCommand"
    /// <summary>
    /// The Color Dimmable Light device can be switched on and off, and its luminance, hue and saturation levels may be controlled, derives from ZigBee HA specifications
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#ColorDimmableLight"></see></summary>
    let ``_.owl#ColorDimmableLight`` = _prefix ".owl#ColorDimmableLight"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ColorNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#ColorNotificationFunctionality`` =
        _prefix ".owl#ColorNotificationFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ColorState"></see>
    /// </summary>
    let ``_.owl#ColorState`` = _prefix ".owl#ColorState"
    /// <summary>
    /// The Dimmable Light device is a light that can be switched on and off, and whose luminance level may be controlled, derives from ZigBee HA specifications
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#DimmableLight"></see></summary>
    let ``_.owl#DimmableLight`` = _prefix ".owl#DimmableLight"
    /// <summary>
    /// The Color Dimmer Switch device can turn a light on and off, and control the luminance, hue and saturation levels of a multicolor light, derives from ZigBee HA specifications
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#ColorDimmerSwitch"></see></summary>
    let ``_.owl#ColorDimmerSwitch`` = _prefix ".owl#ColorDimmerSwitch"
    /// <summary>
    /// Association between a controller and the controlled object
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#controlledObject"></see></summary>
    let ``_.owl#controlledObject`` = _prefix ".owl#controlledObject"
    /// <summary>
    /// Switch for controlling dimmable lights, derives from ZigBee HA specifications
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#DimmerSwitch"></see></summary>
    let ``_.owl#DimmerSwitch`` = _prefix ".owl#DimmerSwitch"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ColorHSBNotification"></see>
    /// </summary>
    let ``_.owl#ColorHSBNotification`` = _prefix ".owl#ColorHSBNotification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ColorRGBNotification"></see>
    /// </summary>
    let ``_.owl#ColorRGBNotification`` = _prefix ".owl#ColorRGBNotification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ColorStateHSB"></see>
    /// </summary>
    let ``_.owl#ColorStateHSB`` = _prefix ".owl#ColorStateHSB"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#HueStateValue"></see>
    /// </summary>
    let ``_.owl#HueStateValue`` = _prefix ".owl#HueStateValue"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SaturationStateValue"></see>
    /// </summary>
    let ``_.owl#SaturationStateValue`` = _prefix ".owl#SaturationStateValue"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ColorStateRGB"></see>
    /// </summary>
    let ``_.owl#ColorStateRGB`` = _prefix ".owl#ColorStateRGB"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#GreenStateValue"></see>
    /// </summary>
    let ``_.owl#GreenStateValue`` = _prefix ".owl#GreenStateValue"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#RedStateValue"></see>
    /// </summary>
    let ``_.owl#RedStateValue`` = _prefix ".owl#RedStateValue"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#Command"></see>
    /// </summary>
    let ``_.owl#Command`` = _prefix ".owl#Command"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ConfigurationFunctionality"></see>
    /// </summary>
    let ``_.owl#ConfigurationFunctionality`` = _prefix ".owl#ConfigurationFunctionality"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#GetConfigurationCommand"></see>
    /// </summary>
    let ``_.owl#GetConfigurationCommand`` = _prefix ".owl#GetConfigurationCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ConnectionState"></see>
    /// </summary>
    let ``_.owl#ConnectionState`` = _prefix ".owl#ConnectionState"
    /// <summary>
    /// Discrete states with exactly two values
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#DoubleValuedState"></see></summary>
    let ``_.owl#DoubleValuedState`` = _prefix ".owl#DoubleValuedState"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ConsumedWaterStateValue"></see>
    /// </summary>
    let ``_.owl#ConsumedWaterStateValue`` = _prefix ".owl#ConsumedWaterStateValue"
    /// <summary>
    /// Capability of a controllable building thing that can receive commands
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#ControlFunctionality"></see></summary>
    let ``_.owl#ControlFunctionality`` = _prefix ".owl#ControlFunctionality"

    /// <summary>
    /// Functionalities not continuous, with fixed values
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#DiscreteControlFunctionality"></see></summary>
    let ``_.owl#DiscreteControlFunctionality`` =
        _prefix ".owl#DiscreteControlFunctionality"

    /// <summary>
    /// Capability of a controllable building thing that notifies information,e.g.door sensor notifies "open"-"close"
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#NotificationFunctionality"></see></summary>
    let ``_.owl#NotificationFunctionality`` = _prefix ".owl#NotificationFunctionality"
    /// <summary>
    /// Models the states of the controllable objects
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#State"></see></summary>
    let ``_.owl#State`` = _prefix ".owl#State"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#unitOfMeasure"></see>
    /// </summary>
    let ``_.owl#unitOfMeasure`` = _prefix ".owl#unitOfMeasure"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StateValue"></see>
    /// </summary>
    let ``_.owl#StateValue`` = _prefix ".owl#StateValue"
    /// <summary>
    /// Capability of a controllable building thing
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Functionality"></see></summary>
    let ``_.owl#Functionality`` = _prefix ".owl#Functionality"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#CoolingApplianceState"></see>
    /// </summary>
    let ``_.owl#CoolingApplianceState`` = _prefix ".owl#CoolingApplianceState"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#GenericApplianceState"></see>
    /// </summary>
    let ``_.owl#GenericApplianceState`` = _prefix ".owl#GenericApplianceState"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#CurrentMeasurementFunctionality"></see>
    /// </summary>
    let ``_.owl#CurrentMeasurementFunctionality`` =
        _prefix ".owl#CurrentMeasurementFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#CurrentMeasurementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#CurrentMeasurementNotificationFunctionality`` =
        _prefix ".owl#CurrentMeasurementNotificationFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#CurrentMeasurementState"></see>
    /// </summary>
    let ``_.owl#CurrentMeasurementState`` = _prefix ".owl#CurrentMeasurementState"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#CurrentMeter"></see>
    /// </summary>
    let ``_.owl#CurrentMeter`` = _prefix ".owl#CurrentMeter"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ElectricityMeter"></see>
    /// </summary>
    let ``_.owl#ElectricityMeter`` = _prefix ".owl#ElectricityMeter"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#CycleTimingControlFunctionality"></see>
    /// </summary>
    let ``_.owl#CycleTimingControlFunctionality`` =
        _prefix ".owl#CycleTimingControlFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SetEndTimeCommand"></see>
    /// </summary>
    let ``_.owl#SetEndTimeCommand`` = _prefix ".owl#SetEndTimeCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SetStartTimeCommand"></see>
    /// </summary>
    let ``_.owl#SetStartTimeCommand`` = _prefix ".owl#SetStartTimeCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SetRemainingTimeCommand"></see>
    /// </summary>
    let ``_.owl#SetRemainingTimeCommand`` = _prefix ".owl#SetRemainingTimeCommand"
    /// <summary>
    /// Discrete functionalities with exactly three values
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#TripleValuedFunctionality"></see></summary>
    let ``_.owl#TripleValuedFunctionality`` = _prefix ".owl#TripleValuedFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#CycleTimingNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#CycleTimingNotificationFunctionality`` =
        _prefix ".owl#CycleTimingNotificationFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#TripleValuedNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#TripleValuedNotificationFunctionality`` =
        _prefix ".owl#TripleValuedNotificationFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#CycleTimingQueryFunctionality"></see>
    /// </summary>
    let ``_.owl#CycleTimingQueryFunctionality`` =
        _prefix ".owl#CycleTimingQueryFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#GetEndTimeCommand"></see>
    /// </summary>
    let ``_.owl#GetEndTimeCommand`` = _prefix ".owl#GetEndTimeCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#GetRemainingTimeCommand"></see>
    /// </summary>
    let ``_.owl#GetRemainingTimeCommand`` = _prefix ".owl#GetRemainingTimeCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#GetStartTimeCommand"></see>
    /// </summary>
    let ``_.owl#GetStartTimeCommand`` = _prefix ".owl#GetStartTimeCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#DecreaseVolumeCommand"></see>
    /// </summary>
    let ``_.owl#DecreaseVolumeCommand`` = _prefix ".owl#DecreaseVolumeCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#FreezingApplianceState"></see>
    /// </summary>
    let ``_.owl#FreezingApplianceState`` = _prefix ".owl#FreezingApplianceState"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SuperFreezingNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#SuperFreezingNotificationFunctionality`` =
        _prefix ".owl#SuperFreezingNotificationFunctionality"

    /// <summary>
    /// Describes the ability of a device to start/stop a super freezing cycle, tipically defined for fridges, refrigerators and freezers. Derives from the energy@home zigbee extension and from the EN50523 standard
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#SuperFreezingFunctionality"></see></summary>
    let ``_.owl#SuperFreezingFunctionality`` = _prefix ".owl#SuperFreezingFunctionality"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ParametricCommand"></see>
    /// </summary>
    let ``_.owl#ParametricCommand`` = _prefix ".owl#ParametricCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SelectSourceCommand"></see>
    /// </summary>
    let ``_.owl#SelectSourceCommand`` = _prefix ".owl#SelectSourceCommand"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#GetRelativeHumidityMCommand"></see>
    /// </summary>
    let ``_.owl#GetRelativeHumidityMCommand`` =
        _prefix ".owl#GetRelativeHumidityMCommand"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#GetPressureMCommand"></see>
    /// </summary>
    let ``_.owl#GetPressureMCommand`` = _prefix ".owl#GetPressureMCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#GetLuminanceCommand"></see>
    /// </summary>
    let ``_.owl#GetLuminanceCommand`` = _prefix ".owl#GetLuminanceCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#GetTemperatureMCommand"></see>
    /// </summary>
    let ``_.owl#GetTemperatureMCommand`` = _prefix ".owl#GetTemperatureMCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#GetFlowRateMCommand"></see>
    /// </summary>
    let ``_.owl#GetFlowRateMCommand`` = _prefix ".owl#GetFlowRateMCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#NetworkNotification"></see>
    /// </summary>
    let ``_.owl#NetworkNotification`` = _prefix ".owl#NetworkNotification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#DeviceAssociationState"></see>
    /// </summary>
    let ``_.owl#DeviceAssociationState`` = _prefix ".owl#DeviceAssociationState"
    /// <summary>
    /// Discrete states with exactly three values
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#TripleValuedState"></see></summary>
    let ``_.owl#TripleValuedState`` = _prefix ".owl#TripleValuedState"

    /// <summary>
    /// Derives from the general cluster functionalities defined in ZigBee HA specifications
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#SceneNotificationFunctionality"></see></summary>
    let ``_.owl#SceneNotificationFunctionality`` =
        _prefix ".owl#SceneNotificationFunctionality"

    /// <summary>
    /// Derives from the general cluster functionalities defined in ZigBee HA specifications
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#SceneFunctionality"></see></summary>
    let ``_.owl#SceneFunctionality`` = _prefix ".owl#SceneFunctionality"

    /// <summary>
    /// Derives from the general cluster functionalities defined in ZigBee HA specifications
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#GroupNotificationFunctionality"></see></summary>
    let ``_.owl#GroupNotificationFunctionality`` =
        _prefix ".owl#GroupNotificationFunctionality"

    /// <summary>
    /// Derives from the general cluster functionalities defined in ZigBee HA specifications
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#GroupFunctionality"></see></summary>
    let ``_.owl#GroupFunctionality`` = _prefix ".owl#GroupFunctionality"
    /// <summary>
    /// Lamp that varies the level of illumination
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#DimmerLamp"></see></summary>
    let ``_.owl#DimmerLamp`` = _prefix ".owl#DimmerLamp"

    /// <summary>
    /// Functionalities for the regulation of ligth
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#LightRegulationFunctionality"></see></summary>
    let ``_.owl#LightRegulationFunctionality`` =
        _prefix ".owl#LightRegulationFunctionality"

    /// <summary>
    /// An artificial source of visible illumination
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Lamp"></see></summary>
    let ``_.owl#Lamp`` = _prefix ".owl#Lamp"
    /// <summary>
    /// Models the state of the object that illuminates
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#LightIntensityState"></see></summary>
    let ``_.owl#LightIntensityState`` = _prefix ".owl#LightIntensityState"

    /// <summary>
    /// Notification functionality for controlling continuously adjustable device, e.g. dimmers, derives from ZigBee Home Automation specifications
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#SimpleLevelNotificationFunctionality"></see></summary>
    let ``_.owl#SimpleLevelNotificationFunctionality`` =
        _prefix ".owl#SimpleLevelNotificationFunctionality"

    /// <summary>
    /// Simple lamp that can be just turn on or turn off
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#SimpleLamp"></see></summary>
    let ``_.owl#SimpleLamp`` = _prefix ".owl#SimpleLamp"
    /// <summary>
    /// Level control switch, derives from the ZigBee Home Automation specification
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#LevelControlSwitch"></see></summary>
    let ``_.owl#LevelControlSwitch`` = _prefix ".owl#LevelControlSwitch"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#DisableGasCommand"></see>
    /// </summary>
    let ``_.owl#DisableGasCommand`` = _prefix ".owl#DisableGasCommand"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#DiscoveryActiveNotification"></see>
    /// </summary>
    let ``_.owl#DiscoveryActiveNotification`` =
        _prefix ".owl#DiscoveryActiveNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#HueNotification"></see>
    /// </summary>
    let ``_.owl#HueNotification`` = _prefix ".owl#HueNotification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#DiscoveryFunctionality"></see>
    /// </summary>
    let ``_.owl#DiscoveryFunctionality`` = _prefix ".owl#DiscoveryFunctionality"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StartDiscoveryCommand"></see>
    /// </summary>
    let ``_.owl#StartDiscoveryCommand`` = _prefix ".owl#StartDiscoveryCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StopDiscoveryCommand"></see>
    /// </summary>
    let ``_.owl#StopDiscoveryCommand`` = _prefix ".owl#StopDiscoveryCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#DiscoveryIdleNotification"></see>
    /// </summary>
    let ``_.owl#DiscoveryIdleNotification`` = _prefix ".owl#DiscoveryIdleNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#DiscoveryNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#DiscoveryNotificationFunctionality`` =
        _prefix ".owl#DiscoveryNotificationFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#DiscoveryState"></see>
    /// </summary>
    let ``_.owl#DiscoveryState`` = _prefix ".owl#DiscoveryState"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#DiscreteOutputFunctionality"></see>
    /// </summary>
    let ``_.owl#DiscreteOutputFunctionality`` =
        _prefix ".owl#DiscreteOutputFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StartStopPauseNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#StartStopPauseNotificationFunctionality`` =
        _prefix ".owl#StartStopPauseNotificationFunctionality"

    /// <summary>
    /// A functionality describing the ability of a device, tipically an appliance, to start, stop or pause its current cycle.
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#StartStopPauseFunctionality"></see></summary>
    let ``_.owl#StartStopPauseFunctionality`` =
        _prefix ".owl#StartStopPauseFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#DisplayCommand"></see>
    /// </summary>
    let ``_.owl#DisplayCommand`` = _prefix ".owl#DisplayCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#DisplayFunctionality"></see>
    /// </summary>
    let ``_.owl#DisplayFunctionality`` = _prefix ".owl#DisplayFunctionality"
    /// <summary>
    /// A swinging or sliding barrier that will close the entrance to a room or building.
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Door"></see></summary>
    let ``_.owl#Door`` = _prefix ".owl#Door"
    /// <summary>
    /// Association between an object and its sensor
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#hasSensor"></see></summary>
    let ``_.owl#hasSensor`` = _prefix ".owl#hasSensor"
    /// <summary>
    /// Sensor that controls if a door is closed
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#DoorSensor"></see></summary>
    let ``_.owl#DoorSensor`` = _prefix ".owl#DoorSensor"
    /// <summary>
    /// An opening in a Wall
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#WallOpening"></see></summary>
    let ``_.owl#WallOpening`` = _prefix ".owl#WallOpening"
    /// <summary>
    /// A framework that contains a glass windowpane and is built into a wall or roof to admit light or air
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Window"></see></summary>
    let ``_.owl#Window`` = _prefix ".owl#Window"
    /// <summary>
    /// Association between a sensor and its sensed object
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#sensorOf"></see></summary>
    let ``_.owl#sensorOf`` = _prefix ".owl#sensorOf"
    /// <summary>
    /// Sensor that controls if a window is closed
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#WindowSensor"></see></summary>
    let ``_.owl#WindowSensor`` = _prefix ".owl#WindowSensor"
    /// <summary>
    /// Sensor that detects the presence of a living entity in the sensor's range
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#InfraredSensor"></see></summary>
    let ``_.owl#InfraredSensor`` = _prefix ".owl#InfraredSensor"
    /// <summary>
    /// Sensor that detects the presence of smoke
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#SmokeSensor"></see></summary>
    let ``_.owl#SmokeSensor`` = _prefix ".owl#SmokeSensor"
    /// <summary>
    /// Sensor that detects the presence of flood
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#FloodSensor"></see></summary>
    let ``_.owl#FloodSensor`` = _prefix ".owl#FloodSensor"
    /// <summary>
    /// The Occupancy Sensor device reports the occupancy state of an area. Derives from ZigBee HA specifications
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#OccupancySensor"></see></summary>
    let ``_.owl#OccupancySensor`` = _prefix ".owl#OccupancySensor"
    /// <summary>
    /// Camera of video surveillance
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#SurveillanceCamera"></see></summary>
    let ``_.owl#SurveillanceCamera`` = _prefix ".owl#SurveillanceCamera"
    /// <summary>
    /// Sensor that detects the presence of gas
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#GasSensor"></see></summary>
    let ``_.owl#GasSensor`` = _prefix ".owl#GasSensor"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#DoubleBed"></see>
    /// </summary>
    let ``_.owl#DoubleBed`` = _prefix ".owl#DoubleBed"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SingleBed"></see>
    /// </summary>
    let ``_.owl#SingleBed`` = _prefix ".owl#SingleBed"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PlayFunctionality"></see>
    /// </summary>
    let ``_.owl#PlayFunctionality`` = _prefix ".owl#PlayFunctionality"
    /// <summary>
    /// Discrete functionalities with exactly one value
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#SingleValuedFunctionality"></see></summary>
    let ``_.owl#SingleValuedFunctionality`` = _prefix ".owl#SingleValuedFunctionality"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#Notification"></see>
    /// </summary>
    let ``_.owl#Notification`` = _prefix ".owl#Notification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#HeatingAndCoolingUnitState"></see>
    /// </summary>
    let ``_.owl#HeatingAndCoolingUnitState`` = _prefix ".owl#HeatingAndCoolingUnitState"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PlayState"></see>
    /// </summary>
    let ``_.owl#PlayState`` = _prefix ".owl#PlayState"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SourceSelectionState"></see>
    /// </summary>
    let ``_.owl#SourceSelectionState`` = _prefix ".owl#SourceSelectionState"
    /// <summary>
    /// Appliance thar read dvd
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Dvd"></see></summary>
    let ``_.owl#Dvd`` = _prefix ".owl#Dvd"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#OnOffStandbyNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#OnOffStandbyNotificationFunctionality`` =
        _prefix ".owl#OnOffStandbyNotificationFunctionality"

    /// <summary>
    /// Models the volume value
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#VolumeLevelState"></see></summary>
    let ``_.owl#VolumeLevelState`` = _prefix ".owl#VolumeLevelState"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StandByOnOffState"></see>
    /// </summary>
    let ``_.owl#StandByOnOffState`` = _prefix ".owl#StandByOnOffState"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#OnOffStandByFunctionality"></see>
    /// </summary>
    let ``_.owl#OnOffStandByFunctionality`` = _prefix ".owl#OnOffStandByFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PlayNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#PlayNotificationFunctionality`` =
        _prefix ".owl#PlayNotificationFunctionality"

    /// <summary>
    /// Functionalities for the regulation of volume
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#VolumeRegulationFunctionality"></see></summary>
    let ``_.owl#VolumeRegulationFunctionality`` =
        _prefix ".owl#VolumeRegulationFunctionality"

    /// <summary>
    /// A communication system based on broadcasting electromagnetic waves
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Radio"></see></summary>
    let ``_.owl#Radio`` = _prefix ".owl#Radio"
    /// <summary>
    /// Equipment for the reproduction of sound with high fidelity
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#HiFi"></see></summary>
    let ``_.owl#HiFi`` = _prefix ".owl#HiFi"
    /// <summary>
    /// A receiver that displays television images
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Tv"></see></summary>
    let ``_.owl#Tv`` = _prefix ".owl#Tv"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#EchelonCommand"></see>
    /// </summary>
    let ``_.owl#EchelonCommand`` = _prefix ".owl#EchelonCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#NetworkSpecificCommand"></see>
    /// </summary>
    let ``_.owl#NetworkSpecificCommand`` = _prefix ".owl#NetworkSpecificCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#EchelonIlon100Gateway"></see>
    /// </summary>
    let ``_.owl#EchelonIlon100Gateway`` = _prefix ".owl#EchelonIlon100Gateway"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#EchelonNetworkComponent"></see>
    /// </summary>
    let ``_.owl#EchelonNetworkComponent`` = _prefix ".owl#EchelonNetworkComponent"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#EchelonIlon100Property"></see>
    /// </summary>
    let ``_.owl#EchelonIlon100Property`` = _prefix ".owl#EchelonIlon100Property"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#EchelonNotification"></see>
    /// </summary>
    let ``_.owl#EchelonNotification`` = _prefix ".owl#EchelonNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#NetworkSpecificNotification"></see>
    /// </summary>
    let ``_.owl#NetworkSpecificNotification`` =
        _prefix ".owl#NetworkSpecificNotification"

    /// <summary>
    /// Electrical Cooker
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#ElectricalCooker"></see></summary>
    let ``_.owl#ElectricalCooker`` = _prefix ".owl#ElectricalCooker"
    /// <summary>
    /// Gas Cooker
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#GasCooker"></see></summary>
    let ``_.owl#GasCooker`` = _prefix ".owl#GasCooker"
    /// <summary>
    /// A portable electric appliance for heating or cooking or keeping food warm
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Hotplate"></see></summary>
    let ``_.owl#Hotplate`` = _prefix ".owl#Hotplate"
    /// <summary>
    /// Electrical oven
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#ElectricalOven"></see></summary>
    let ``_.owl#ElectricalOven`` = _prefix ".owl#ElectricalOven"
    /// <summary>
    /// Microwave oven
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#MicrowaveOven"></see></summary>
    let ``_.owl#MicrowaveOven`` = _prefix ".owl#MicrowaveOven"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#Meter"></see>
    /// </summary>
    let ``_.owl#Meter`` = _prefix ".owl#Meter"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#EnableDisableGasFunctionality"></see>
    /// </summary>
    let ``_.owl#EnableDisableGasFunctionality`` =
        _prefix ".owl#EnableDisableGasFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#EnableGasCommand"></see>
    /// </summary>
    let ``_.owl#EnableGasCommand`` = _prefix ".owl#EnableGasCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#EnergyAndPowerMeter"></see>
    /// </summary>
    let ``_.owl#EnergyAndPowerMeter`` = _prefix ".owl#EnergyAndPowerMeter"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseActivePowerMeter"></see>
    /// </summary>
    let ``_.owl#SinglePhaseActivePowerMeter`` =
        _prefix ".owl#SinglePhaseActivePowerMeter"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseEnergyMeter"></see>
    /// </summary>
    let ``_.owl#SinglePhaseEnergyMeter`` = _prefix ".owl#SinglePhaseEnergyMeter"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#EnergyAndPowerMeteringLevelControllableOutput"></see>
    /// </summary>
    let ``_.owl#EnergyAndPowerMeteringLevelControllableOutput`` =
        _prefix ".owl#EnergyAndPowerMeteringLevelControllableOutput"

    /// <summary>
    /// Output device whose output level can be controlled continuously, by means of a level-control command (notification), derives from ZigBee HA specifications
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#LevelControllableOutput"></see></summary>
    let ``_.owl#LevelControllableOutput`` = _prefix ".owl#LevelControllableOutput"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseActiveEnergyMeter"></see>
    /// </summary>
    let ``_.owl#SinglePhaseActiveEnergyMeter`` =
        _prefix ".owl#SinglePhaseActiveEnergyMeter"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#EnergyMeasurementState"></see>
    /// </summary>
    let ``_.owl#EnergyMeasurementState`` = _prefix ".owl#EnergyMeasurementState"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#EnergyMeter"></see>
    /// </summary>
    let ``_.owl#EnergyMeter`` = _prefix ".owl#EnergyMeter"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#EnergyMeteringPowerOutlet"></see>
    /// </summary>
    let ``_.owl#EnergyMeteringPowerOutlet`` = _prefix ".owl#EnergyMeteringPowerOutlet"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MainsPowerOutlet"></see>
    /// </summary>
    let ``_.owl#MainsPowerOutlet`` = _prefix ".owl#MainsPowerOutlet"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#Entrance"></see>
    /// </summary>
    let ``_.owl#Entrance`` = _prefix ".owl#Entrance"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#EventNotification"></see>
    /// </summary>
    let ``_.owl#EventNotification`` = _prefix ".owl#EventNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#EventNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#EventNotificationFunctionality`` =
        _prefix ".owl#EventNotificationFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#EventsAndAlertsNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#EventsAndAlertsNotificationFunctionality`` =
        _prefix ".owl#EventsAndAlertsNotificationFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MultipleAlertNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#MultipleAlertNotificationFunctionality`` =
        _prefix ".owl#MultipleAlertNotificationFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MultipleEventNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#MultipleEventNotificationFunctionality`` =
        _prefix ".owl#MultipleEventNotificationFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#EventsAndAlertsQueryFunctionality"></see>
    /// </summary>
    let ``_.owl#EventsAndAlertsQueryFunctionality`` =
        _prefix ".owl#EventsAndAlertsQueryFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#GetEventsAndAlertsCommand"></see>
    /// </summary>
    let ``_.owl#GetEventsAndAlertsCommand`` = _prefix ".owl#GetEventsAndAlertsCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#FaultState"></see>
    /// </summary>
    let ``_.owl#FaultState`` = _prefix ".owl#FaultState"
    /// <summary>
    /// A barrier that serves to enclose an area
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Fence"></see></summary>
    let ``_.owl#Fence`` = _prefix ".owl#Fence"
    /// <summary>
    /// The vertical architectural component of a building
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Vertical"></see></summary>
    let ``_.owl#Vertical`` = _prefix ".owl#Vertical"
    /// <summary>
    /// An opening in a Fence
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#FenceOpening"></see></summary>
    let ``_.owl#FenceOpening`` = _prefix ".owl#FenceOpening"
    /// <summary>
    /// An architectural partition used to divide or enclose an area or to support another structure.
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Wall"></see></summary>
    let ``_.owl#Wall`` = _prefix ".owl#Wall"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#FireHeatCoolNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#FireHeatCoolNotificationFunctionality`` =
        _prefix ".owl#FireHeatCoolNotificationFunctionality"

    /// <summary>
    /// Lamp that emits light in sudden short or intermittent bursts
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#FlashingLamp"></see></summary>
    let ``_.owl#FlashingLamp`` = _prefix ".owl#FlashingLamp"
    /// <summary>
    /// Functionality to switch on and off an object with a given switching period
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#OnOffFlashingFunctionality"></see></summary>
    let ``_.owl#OnOffFlashingFunctionality`` = _prefix ".owl#OnOffFlashingFunctionality"
    /// <summary>
    /// Simple lamp that can be just turn on or turn off
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#OnOffLight"></see></summary>
    let ``_.owl#OnOffLight`` = _prefix ".owl#OnOffLight"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SensingState"></see>
    /// </summary>
    let ``_.owl#SensingState`` = _prefix ".owl#SensingState"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#FlowMeasurementFunctionality"></see>
    /// </summary>
    let ``_.owl#FlowMeasurementFunctionality`` =
        _prefix ".owl#FlowMeasurementFunctionality"

    /// <summary>
    /// The capability of measuring the humidity of a room
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#HumidityMeasurementFunctionality"></see></summary>
    let ``_.owl#HumidityMeasurementFunctionality`` =
        _prefix ".owl#HumidityMeasurementFunctionality"

    /// <summary>
    /// The capability of sensing the luminance of the environment in which a device is located accepts only the get command, with 1 parameter, i.e. the luminance value. Derives from ZigBee specifications
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#LightSensingFunctionality"></see></summary>
    let ``_.owl#LightSensingFunctionality`` = _prefix ".owl#LightSensingFunctionality"

    /// <summary>
    /// Functionality for getting the occupancy state of a given room
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#OccupancySensingFunctionality"></see></summary>
    let ``_.owl#OccupancySensingFunctionality`` =
        _prefix ".owl#OccupancySensingFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PictureGrabFunctionality"></see>
    /// </summary>
    let ``_.owl#PictureGrabFunctionality`` = _prefix ".owl#PictureGrabFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PressureMeasurementFunctionality"></see>
    /// </summary>
    let ``_.owl#PressureMeasurementFunctionality`` =
        _prefix ".owl#PressureMeasurementFunctionality"

    /// <summary>
    /// The capability of measuring temperatures
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#TemperatureMeasurementFunctionality"></see></summary>
    let ``_.owl#TemperatureMeasurementFunctionality`` =
        _prefix ".owl#TemperatureMeasurementFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#FlowMeasurementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#FlowMeasurementNotificationFunctionality`` =
        _prefix ".owl#FlowMeasurementNotificationFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#FlowRateMeasurementNotification"></see>
    /// </summary>
    let ``_.owl#FlowRateMeasurementNotification`` =
        _prefix ".owl#FlowRateMeasurementNotification"

    /// <summary>
    /// The notification for requesting humidity measurment...
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#HumidityMeasurementNotificationFunctionality"></see></summary>
    let ``_.owl#HumidityMeasurementNotificationFunctionality`` =
        _prefix ".owl#HumidityMeasurementNotificationFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PressureMeasurementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#PressureMeasurementNotificationFunctionality`` =
        _prefix ".owl#PressureMeasurementNotificationFunctionality"

    /// <summary>
    /// Notifies the measurment of a temperature, through a proper temperature sensor
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#TemperatureMeasurementNotificationFunctionality"></see></summary>
    let ``_.owl#TemperatureMeasurementNotificationFunctionality`` =
        _prefix ".owl#TemperatureMeasurementNotificationFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SimpleMovementNotification"></see>
    /// </summary>
    let ``_.owl#SimpleMovementNotification`` = _prefix ".owl#SimpleMovementNotification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#LevelStepUpNotification"></see>
    /// </summary>
    let ``_.owl#LevelStepUpNotification`` = _prefix ".owl#LevelStepUpNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#HumidityMeasurementNotification"></see>
    /// </summary>
    let ``_.owl#HumidityMeasurementNotification`` =
        _prefix ".owl#HumidityMeasurementNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#LevelStepDownNotification"></see>
    /// </summary>
    let ``_.owl#LevelStepDownNotification`` = _prefix ".owl#LevelStepDownNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#TemperatureMeasurementNotification"></see>
    /// </summary>
    let ``_.owl#TemperatureMeasurementNotification`` =
        _prefix ".owl#TemperatureMeasurementNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PressureMeasurementNotification"></see>
    /// </summary>
    let ``_.owl#PressureMeasurementNotification`` =
        _prefix ".owl#PressureMeasurementNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SimpleNoMovementNotification"></see>
    /// </summary>
    let ``_.owl#SimpleNoMovementNotification`` =
        _prefix ".owl#SimpleNoMovementNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#FlowRateState"></see>
    /// </summary>
    let ``_.owl#FlowRateState`` = _prefix ".owl#FlowRateState"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#HumidityMeasurementState"></see>
    /// </summary>
    let ``_.owl#HumidityMeasurementState`` = _prefix ".owl#HumidityMeasurementState"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#LevelState"></see>
    /// </summary>
    let ``_.owl#LevelState`` = _prefix ".owl#LevelState"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PressureState"></see>
    /// </summary>
    let ``_.owl#PressureState`` = _prefix ".owl#PressureState"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ShadeState"></see>
    /// </summary>
    let ``_.owl#ShadeState`` = _prefix ".owl#ShadeState"
    /// <summary>
    /// Models the temperature value
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#TemperatureState"></see></summary>
    let ``_.owl#TemperatureState`` = _prefix ".owl#TemperatureState"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#TunerState"></see>
    /// </summary>
    let ``_.owl#TunerState`` = _prefix ".owl#TunerState"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#FlowSensor"></see>
    /// </summary>
    let ``_.owl#FlowSensor`` = _prefix ".owl#FlowSensor"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ForwardNotification"></see>
    /// </summary>
    let ``_.owl#ForwardNotification`` = _prefix ".owl#ForwardNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#FrequencyMeasurementFunctionality"></see>
    /// </summary>
    let ``_.owl#FrequencyMeasurementFunctionality`` =
        _prefix ".owl#FrequencyMeasurementFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#GetFrequencyCommand"></see>
    /// </summary>
    let ``_.owl#GetFrequencyCommand`` = _prefix ".owl#GetFrequencyCommand"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#FrequencyMeasurementNotification"></see>
    /// </summary>
    let ``_.owl#FrequencyMeasurementNotification`` =
        _prefix ".owl#FrequencyMeasurementNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#FrequencyMeasurementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#FrequencyMeasurementNotificationFunctionality`` =
        _prefix ".owl#FrequencyMeasurementNotificationFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#FrequencyMeasurementState"></see>
    /// </summary>
    let ``_.owl#FrequencyMeasurementState`` = _prefix ".owl#FrequencyMeasurementState"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#FrequencyStateValue"></see>
    /// </summary>
    let ``_.owl#FrequencyStateValue`` = _prefix ".owl#FrequencyStateValue"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#FrequencyMeter"></see>
    /// </summary>
    let ``_.owl#FrequencyMeter`` = _prefix ".owl#FrequencyMeter"
    /// <summary>
    /// A functionality describing the ability of the device to start/stop a super cooling cycle (typical of fridges, freezers and refrigerators). This functionality is defined in the energy@home zigbee extension and in the EN50523 specification.
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#SuperCoolingFunctionality"></see></summary>
    let ``_.owl#SuperCoolingFunctionality`` = _prefix ".owl#SuperCoolingFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SuperCoolingNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#SuperCoolingNotificationFunctionality`` =
        _prefix ".owl#SuperCoolingNotificationFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#hasFloor"></see>
    /// </summary>
    let ``_.owl#hasFloor`` = _prefix ".owl#hasFloor"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#hasCeiling"></see>
    /// </summary>
    let ``_.owl#hasCeiling`` = _prefix ".owl#hasCeiling"
    /// <summary>
    /// Heater that combusts gas
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#GasHeater"></see></summary>
    let ``_.owl#GasHeater`` = _prefix ".owl#GasHeater"
    /// <summary>
    /// Device that heats water or supplies warmth
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Heater"></see></summary>
    let ``_.owl#Heater`` = _prefix ".owl#Heater"
    /// <summary>
    /// Heater that combusts gasoil
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#GasoilHeater"></see></summary>
    let ``_.owl#GasoilHeater`` = _prefix ".owl#GasoilHeater"
    /// <summary>
    /// Heater that combusts wood-pellet
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#PelletHeater"></see></summary>
    let ``_.owl#PelletHeater`` = _prefix ".owl#PelletHeater"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#GasM3MeasurementNotification"></see>
    /// </summary>
    let ``_.owl#GasM3MeasurementNotification`` =
        _prefix ".owl#GasM3MeasurementNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#GasMeasurementFunctionality"></see>
    /// </summary>
    let ``_.owl#GasMeasurementFunctionality`` =
        _prefix ".owl#GasMeasurementFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#GetConsumedM3Gas"></see>
    /// </summary>
    let ``_.owl#GetConsumedM3Gas`` = _prefix ".owl#GetConsumedM3Gas"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#GasMeasurementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#GasMeasurementNotificationFunctionality`` =
        _prefix ".owl#GasMeasurementNotificationFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#GasMeasurementState"></see>
    /// </summary>
    let ``_.owl#GasMeasurementState`` = _prefix ".owl#GasMeasurementState"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#GasStateValue"></see>
    /// </summary>
    let ``_.owl#GasStateValue`` = _prefix ".owl#GasStateValue"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#GasMeter"></see>
    /// </summary>
    let ``_.owl#GasMeter`` = _prefix ".owl#GasMeter"
    /// <summary>
    /// A door-like movable barrier in a fence
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Gate"></see></summary>
    let ``_.owl#Gate`` = _prefix ".owl#Gate"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#Get1PhaseActiveEnergyCommand"></see>
    /// </summary>
    let ``_.owl#Get1PhaseActiveEnergyCommand`` =
        _prefix ".owl#Get1PhaseActiveEnergyCommand"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#NonVoidCommand"></see>
    /// </summary>
    let ``_.owl#NonVoidCommand`` = _prefix ".owl#NonVoidCommand"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#Get1PhaseActivePowerCommand"></see>
    /// </summary>
    let ``_.owl#Get1PhaseActivePowerCommand`` =
        _prefix ".owl#Get1PhaseActivePowerCommand"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#Get1PhaseApparentPowerCommand"></see>
    /// </summary>
    let ``_.owl#Get1PhaseApparentPowerCommand`` =
        _prefix ".owl#Get1PhaseApparentPowerCommand"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#Get1PhaseCurrentCommand"></see>
    /// </summary>
    let ``_.owl#Get1PhaseCurrentCommand`` = _prefix ".owl#Get1PhaseCurrentCommand"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#Get1PhaseReactiveEnergyCommand"></see>
    /// </summary>
    let ``_.owl#Get1PhaseReactiveEnergyCommand`` =
        _prefix ".owl#Get1PhaseReactiveEnergyCommand"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#Get1PhaseReactivePowerCommand"></see>
    /// </summary>
    let ``_.owl#Get1PhaseReactivePowerCommand`` =
        _prefix ".owl#Get1PhaseReactivePowerCommand"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#Get1PhaseVoltageCommand"></see>
    /// </summary>
    let ``_.owl#Get1PhaseVoltageCommand`` = _prefix ".owl#Get1PhaseVoltageCommand"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#Get3PhaseActiveEnergyCommand"></see>
    /// </summary>
    let ``_.owl#Get3PhaseActiveEnergyCommand`` =
        _prefix ".owl#Get3PhaseActiveEnergyCommand"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#Get3PhaseActivePowerCommand"></see>
    /// </summary>
    let ``_.owl#Get3PhaseActivePowerCommand`` =
        _prefix ".owl#Get3PhaseActivePowerCommand"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#Get3PhaseApparentPowerCommand"></see>
    /// </summary>
    let ``_.owl#Get3PhaseApparentPowerCommand`` =
        _prefix ".owl#Get3PhaseApparentPowerCommand"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#Get3PhaseCurrentCommand"></see>
    /// </summary>
    let ``_.owl#Get3PhaseCurrentCommand`` = _prefix ".owl#Get3PhaseCurrentCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#Get3PhaseLLVoltageCommand"></see>
    /// </summary>
    let ``_.owl#Get3PhaseLLVoltageCommand`` = _prefix ".owl#Get3PhaseLLVoltageCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#Get3PhaseLNVoltageCommand"></see>
    /// </summary>
    let ``_.owl#Get3PhaseLNVoltageCommand`` = _prefix ".owl#Get3PhaseLNVoltageCommand"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#Get3PhaseReactiveEnergyCommand"></see>
    /// </summary>
    let ``_.owl#Get3PhaseReactiveEnergyCommand`` =
        _prefix ".owl#Get3PhaseReactiveEnergyCommand"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#Get3PhaseReactivePowerCommand"></see>
    /// </summary>
    let ``_.owl#Get3PhaseReactivePowerCommand`` =
        _prefix ".owl#Get3PhaseReactivePowerCommand"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#GetColdWaterM3Command"></see>
    /// </summary>
    let ``_.owl#GetColdWaterM3Command`` = _prefix ".owl#GetColdWaterM3Command"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#GetHeatingEnergyCommand"></see>
    /// </summary>
    let ``_.owl#GetHeatingEnergyCommand`` = _prefix ".owl#GetHeatingEnergyCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#GetHotWaterM3Command"></see>
    /// </summary>
    let ``_.owl#GetHotWaterM3Command`` = _prefix ".owl#GetHotWaterM3Command"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#GetMultiTariff1PhaseActiveEnergyCommand"></see>
    /// </summary>
    let ``_.owl#GetMultiTariff1PhaseActiveEnergyCommand`` =
        _prefix ".owl#GetMultiTariff1PhaseActiveEnergyCommand"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#GetMultiTariff1PhaseReactiveEnergyCommand"></see>
    /// </summary>
    let ``_.owl#GetMultiTariff1PhaseReactiveEnergyCommand`` =
        _prefix ".owl#GetMultiTariff1PhaseReactiveEnergyCommand"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#GetMultiTariff3PhaseActiveEnergyCommand"></see>
    /// </summary>
    let ``_.owl#GetMultiTariff3PhaseActiveEnergyCommand`` =
        _prefix ".owl#GetMultiTariff3PhaseActiveEnergyCommand"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#GetMultiTariff3PhaseReactiveEnergyCommand"></see>
    /// </summary>
    let ``_.owl#GetMultiTariff3PhaseReactiveEnergyCommand`` =
        _prefix ".owl#GetMultiTariff3PhaseReactiveEnergyCommand"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#GetPowerFactorCommand"></see>
    /// </summary>
    let ``_.owl#GetPowerFactorCommand`` = _prefix ".owl#GetPowerFactorCommand"

    /// <summary>
    /// Derives from the general cluster functionalities defined in ZigBee HA specifications
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#IdentificationFunctionality"></see></summary>
    let ``_.owl#IdentificationFunctionality`` =
        _prefix ".owl#IdentificationFunctionality"

    /// <summary>
    /// Derives from the general cluster functionalities defined in ZigBee HA specifications
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#IdentificationNotificationFunctionality"></see></summary>
    let ``_.owl#IdentificationNotificationFunctionality`` =
        _prefix ".owl#IdentificationNotificationFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#HeaterState"></see>
    /// </summary>
    let ``_.owl#HeaterState`` = _prefix ".owl#HeaterState"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#LevelControlNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#LevelControlNotificationFunctionality`` =
        _prefix ".owl#LevelControlNotificationFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SpeedNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#SpeedNotificationFunctionality`` =
        _prefix ".owl#SpeedNotificationFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#HeatingCycleNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#HeatingCycleNotificationFunctionality`` =
        _prefix ".owl#HeatingCycleNotificationFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StartedHeatingCycleNotification"></see>
    /// </summary>
    let ``_.owl#StartedHeatingCycleNotification`` =
        _prefix ".owl#StartedHeatingCycleNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StoppedHeatingCycleNotification"></see>
    /// </summary>
    let ``_.owl#StoppedHeatingCycleNotification`` =
        _prefix ".owl#StoppedHeatingCycleNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#HeatingEnergyMeasurementFunctionality"></see>
    /// </summary>
    let ``_.owl#HeatingEnergyMeasurementFunctionality`` =
        _prefix ".owl#HeatingEnergyMeasurementFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#HeatingEnergyMeasurementNotification"></see>
    /// </summary>
    let ``_.owl#HeatingEnergyMeasurementNotification`` =
        _prefix ".owl#HeatingEnergyMeasurementNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#HeatingEnergyMeasurementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#HeatingEnergyMeasurementNotificationFunctionality`` =
        _prefix ".owl#HeatingEnergyMeasurementNotificationFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#HeatingEnergyMeasurementState"></see>
    /// </summary>
    let ``_.owl#HeatingEnergyMeasurementState`` =
        _prefix ".owl#HeatingEnergyMeasurementState"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#HeatingEnergyStateValue"></see>
    /// </summary>
    let ``_.owl#HeatingEnergyStateValue`` = _prefix ".owl#HeatingEnergyStateValue"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#HeatingEnergyMeter"></see>
    /// </summary>
    let ``_.owl#HeatingEnergyMeter`` = _prefix ".owl#HeatingEnergyMeter"
    /// <summary>
    /// Functionality to switch on an object for a given period of time
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#TimedOnFunctionality"></see></summary>
    let ``_.owl#TimedOnFunctionality`` = _prefix ".owl#TimedOnFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SourceSelectionFunctionality"></see>
    /// </summary>
    let ``_.owl#SourceSelectionFunctionality`` =
        _prefix ".owl#SourceSelectionFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SourceSelectionNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#SourceSelectionNotificationFunctionality`` =
        _prefix ".owl#SourceSelectionNotificationFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#TunerNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#TunerNotificationFunctionality`` =
        _prefix ".owl#TunerNotificationFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#HotWaterM3MeasurementNotification"></see>
    /// </summary>
    let ``_.owl#HotWaterM3MeasurementNotification`` =
        _prefix ".owl#HotWaterM3MeasurementNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#HueBridge"></see>
    /// </summary>
    let ``_.owl#HueBridge`` = _prefix ".owl#HueBridge"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PushLinkFunctionality"></see>
    /// </summary>
    let ``_.owl#PushLinkFunctionality`` = _prefix ".owl#PushLinkFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PushLinkAuthenticationState"></see>
    /// </summary>
    let ``_.owl#PushLinkAuthenticationState`` =
        _prefix ".owl#PushLinkAuthenticationState"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PushLinkNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#PushLinkNotificationFunctionality`` =
        _prefix ".owl#PushLinkNotificationFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#HueComponent"></see>
    /// </summary>
    let ``_.owl#HueComponent`` = _prefix ".owl#HueComponent"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#HueManager"></see>
    /// </summary>
    let ``_.owl#HueManager`` = _prefix ".owl#HueManager"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#HumiditySensor"></see>
    /// </summary>
    let ``_.owl#HumiditySensor`` = _prefix ".owl#HumiditySensor"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#KNXNetIPGateway"></see>
    /// </summary>
    let ``_.owl#KNXNetIPGateway`` = _prefix ".owl#KNXNetIPGateway"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ModbusGateway"></see>
    /// </summary>
    let ``_.owl#ModbusGateway`` = _prefix ".owl#ModbusGateway"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#IncreaseVolumeCommand"></see>
    /// </summary>
    let ``_.owl#IncreaseVolumeCommand`` = _prefix ".owl#IncreaseVolumeCommand"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SensingNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#SensingNotificationFunctionality`` =
        _prefix ".owl#SensingNotificationFunctionality"

    /// <summary>
    /// A large whirlpool bathtub with underwater jets that massage the body
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Jacuzzi"></see></summary>
    let ``_.owl#Jacuzzi`` = _prefix ".owl#Jacuzzi"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#KNXNetIPComponent"></see>
    /// </summary>
    let ``_.owl#KNXNetIPComponent`` = _prefix ".owl#KNXNetIPComponent"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#KonnexCommand"></see>
    /// </summary>
    let ``_.owl#KonnexCommand`` = _prefix ".owl#KonnexCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#KonnexNotification"></see>
    /// </summary>
    let ``_.owl#KonnexNotification`` = _prefix ".owl#KonnexNotification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#LampHolder"></see>
    /// </summary>
    let ``_.owl#LampHolder`` = _prefix ".owl#LampHolder"
    /// <summary>
    /// Models a binary output which can be only in on or off state (OnOffState), compatible with the ZigBee HA specifications
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#OnOffOutput"></see></summary>
    let ``_.owl#OnOffOutput`` = _prefix ".owl#OnOffOutput"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#LevelNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#LevelNotificationFunctionality`` =
        _prefix ".owl#LevelNotificationFunctionality"

    /// <summary>
    /// The Light Sensor device reports the illuminance of an area
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#LightSensor"></see></summary>
    let ``_.owl#LightSensor`` = _prefix ".owl#LightSensor"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#LuminosityNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#LuminosityNotificationFunctionality`` =
        _prefix ".owl#LuminosityNotificationFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#LoweringStateValue"></see>
    /// </summary>
    let ``_.owl#LoweringStateValue`` = _prefix ".owl#LoweringStateValue"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#LuminosityMeasurementNotification"></see>
    /// </summary>
    let ``_.owl#LuminosityMeasurementNotification`` =
        _prefix ".owl#LuminosityMeasurementNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MeteringPowerOutlet"></see>
    /// </summary>
    let ``_.owl#MeteringPowerOutlet`` = _prefix ".owl#MeteringPowerOutlet"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PowerFactorMeter"></see>
    /// </summary>
    let ``_.owl#PowerFactorMeter`` = _prefix ".owl#PowerFactorMeter"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PowerMeteringPowerOutlet"></see>
    /// </summary>
    let ``_.owl#PowerMeteringPowerOutlet`` = _prefix ".owl#PowerMeteringPowerOutlet"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MicrowaveEmissionNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#MicrowaveEmissionNotificationFunctionality`` =
        _prefix ".owl#MicrowaveEmissionNotificationFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MicrowaveEmissionState"></see>
    /// </summary>
    let ``_.owl#MicrowaveEmissionState`` = _prefix ".owl#MicrowaveEmissionState"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ModBusStateValue"></see>
    /// </summary>
    let ``_.owl#ModBusStateValue`` = _prefix ".owl#ModBusStateValue"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ModbusCommand"></see>
    /// </summary>
    let ``_.owl#ModbusCommand`` = _prefix ".owl#ModbusCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ModbusComponent"></see>
    /// </summary>
    let ``_.owl#ModbusComponent`` = _prefix ".owl#ModbusComponent"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ModbusNotification"></see>
    /// </summary>
    let ``_.owl#ModbusNotification`` = _prefix ".owl#ModbusNotification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#NetworkSpecificStateValue"></see>
    /// </summary>
    let ``_.owl#NetworkSpecificStateValue`` = _prefix ".owl#NetworkSpecificStateValue"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MovementAndTemperatureSensor"></see>
    /// </summary>
    let ``_.owl#MovementAndTemperatureSensor`` =
        _prefix ".owl#MovementAndTemperatureSensor"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MovementSensor"></see>
    /// </summary>
    let ``_.owl#MovementSensor`` = _prefix ".owl#MovementSensor"
    /// <summary>
    /// Sensor that detects the temperature of the atmosphere
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#SingleTemperatureSensor"></see></summary>
    let ``_.owl#SingleTemperatureSensor`` = _prefix ".owl#SingleTemperatureSensor"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MovingDownNotification"></see>
    /// </summary>
    let ``_.owl#MovingDownNotification`` = _prefix ".owl#MovingDownNotification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MovingUpNotification"></see>
    /// </summary>
    let ``_.owl#MovingUpNotification`` = _prefix ".owl#MovingUpNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PresenceNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#PresenceNotificationFunctionality`` =
        _prefix ".owl#PresenceNotificationFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#UpDownNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#UpDownNotificationFunctionality`` =
        _prefix ".owl#UpDownNotificationFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#OccupancyState"></see>
    /// </summary>
    let ``_.owl#OccupancyState`` = _prefix ".owl#OccupancyState"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PresenceState"></see>
    /// </summary>
    let ``_.owl#PresenceState`` = _prefix ".owl#PresenceState"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MovingUpDownState"></see>
    /// </summary>
    let ``_.owl#MovingUpDownState`` = _prefix ".owl#MovingUpDownState"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#RaisingStateValue"></see>
    /// </summary>
    let ``_.owl#RaisingStateValue`` = _prefix ".owl#RaisingStateValue"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffActiveEnergyStateValue"></see>
    /// </summary>
    let ``_.owl#MultiTariffActiveEnergyStateValue`` =
        _prefix ".owl#MultiTariffActiveEnergyStateValue"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffEnergyMeter"></see>
    /// </summary>
    let ``_.owl#MultiTariffEnergyMeter`` = _prefix ".owl#MultiTariffEnergyMeter"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffReactiveEnergyStateValue"></see>
    /// </summary>
    let ``_.owl#MultiTariffReactiveEnergyStateValue`` =
        _prefix ".owl#MultiTariffReactiveEnergyStateValue"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffSinglePhaseActiveEnergyMeasurementFunctionality"></see>
    /// </summary>
    let ``_.owl#MultiTariffSinglePhaseActiveEnergyMeasurementFunctionality`` =
        _prefix ".owl#MultiTariffSinglePhaseActiveEnergyMeasurementFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffSinglePhaseActiveEnergyMeasurementNotification"></see>
    /// </summary>
    let ``_.owl#MultiTariffSinglePhaseActiveEnergyMeasurementNotification`` =
        _prefix ".owl#MultiTariffSinglePhaseActiveEnergyMeasurementNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffSinglePhaseActiveEnergyMeasurementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#MultiTariffSinglePhaseActiveEnergyMeasurementNotificationFunctionality`` =
        _prefix ".owl#MultiTariffSinglePhaseActiveEnergyMeasurementNotificationFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffSinglePhaseActiveEnergyState"></see>
    /// </summary>
    let ``_.owl#MultiTariffSinglePhaseActiveEnergyState`` =
        _prefix ".owl#MultiTariffSinglePhaseActiveEnergyState"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffSinglePhaseEnergyMeter"></see>
    /// </summary>
    let ``_.owl#MultiTariffSinglePhaseEnergyMeter`` =
        _prefix ".owl#MultiTariffSinglePhaseEnergyMeter"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffSinglePhaseReactiveEnergyMeasurementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#MultiTariffSinglePhaseReactiveEnergyMeasurementNotificationFunctionality`` =
        _prefix ".owl#MultiTariffSinglePhaseReactiveEnergyMeasurementNotificationFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffSinglePhaseReactiveEnergyState"></see>
    /// </summary>
    let ``_.owl#MultiTariffSinglePhaseReactiveEnergyState`` =
        _prefix ".owl#MultiTariffSinglePhaseReactiveEnergyState"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffSinglePhaseReactiveEnergyMeasurementFunctionality"></see>
    /// </summary>
    let ``_.owl#MultiTariffSinglePhaseReactiveEnergyMeasurementFunctionality`` =
        _prefix ".owl#MultiTariffSinglePhaseReactiveEnergyMeasurementFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ReactiveEnergyMeasurementFunctionality"></see>
    /// </summary>
    let ``_.owl#ReactiveEnergyMeasurementFunctionality`` =
        _prefix ".owl#ReactiveEnergyMeasurementFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffSinglePhaseReactiveEnergyMeasurementNotification"></see>
    /// </summary>
    let ``_.owl#MultiTariffSinglePhaseReactiveEnergyMeasurementNotification`` =
        _prefix ".owl#MultiTariffSinglePhaseReactiveEnergyMeasurementNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ReactiveEnergyMeasurementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#ReactiveEnergyMeasurementNotificationFunctionality`` =
        _prefix ".owl#ReactiveEnergyMeasurementNotificationFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffThreePhaseActiveEnergyMeasurementFunctionality"></see>
    /// </summary>
    let ``_.owl#MultiTariffThreePhaseActiveEnergyMeasurementFunctionality`` =
        _prefix ".owl#MultiTariffThreePhaseActiveEnergyMeasurementFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffThreePhaseActiveEnergyMeasurementNotification"></see>
    /// </summary>
    let ``_.owl#MultiTariffThreePhaseActiveEnergyMeasurementNotification`` =
        _prefix ".owl#MultiTariffThreePhaseActiveEnergyMeasurementNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffThreePhaseActiveEnergyMeasurementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#MultiTariffThreePhaseActiveEnergyMeasurementNotificationFunctionality`` =
        _prefix ".owl#MultiTariffThreePhaseActiveEnergyMeasurementNotificationFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffThreePhaseActiveEnergyState"></see>
    /// </summary>
    let ``_.owl#MultiTariffThreePhaseActiveEnergyState`` =
        _prefix ".owl#MultiTariffThreePhaseActiveEnergyState"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffThreePhaseEnergyMeter"></see>
    /// </summary>
    let ``_.owl#MultiTariffThreePhaseEnergyMeter`` =
        _prefix ".owl#MultiTariffThreePhaseEnergyMeter"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffThreePhaseReactiveEnergyMeasurementFunctionality"></see>
    /// </summary>
    let ``_.owl#MultiTariffThreePhaseReactiveEnergyMeasurementFunctionality`` =
        _prefix ".owl#MultiTariffThreePhaseReactiveEnergyMeasurementFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffThreePhaseReactiveEnergyMeasurementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#MultiTariffThreePhaseReactiveEnergyMeasurementNotificationFunctionality`` =
        _prefix ".owl#MultiTariffThreePhaseReactiveEnergyMeasurementNotificationFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffThreePhaseReactiveEnergyState"></see>
    /// </summary>
    let ``_.owl#MultiTariffThreePhaseReactiveEnergyState`` =
        _prefix ".owl#MultiTariffThreePhaseReactiveEnergyState"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffThreePhaseReactiveEnergyMeasurementNotification"></see>
    /// </summary>
    let ``_.owl#MultiTariffThreePhaseReactiveEnergyMeasurementNotification`` =
        _prefix ".owl#MultiTariffThreePhaseReactiveEnergyMeasurementNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MultipleAlertNotification"></see>
    /// </summary>
    let ``_.owl#MultipleAlertNotification`` = _prefix ".owl#MultipleAlertNotification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MultipleEventNotification"></see>
    /// </summary>
    let ``_.owl#MultipleEventNotification`` = _prefix ".owl#MultipleEventNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MultipleFlowMeasurementFunctionality"></see>
    /// </summary>
    let ``_.owl#MultipleFlowMeasurementFunctionality`` =
        _prefix ".owl#MultipleFlowMeasurementFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MultipleFlowMeasurementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#MultipleFlowMeasurementNotificationFunctionality`` =
        _prefix ".owl#MultipleFlowMeasurementNotificationFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MultipleFlowRateState"></see>
    /// </summary>
    let ``_.owl#MultipleFlowRateState`` = _prefix ".owl#MultipleFlowRateState"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MultipleFlowRateStateValue"></see>
    /// </summary>
    let ``_.owl#MultipleFlowRateStateValue`` = _prefix ".owl#MultipleFlowRateStateValue"
    /// <summary>
    /// The Flow  Sensor device measures and periodically reports the flow rate of a liquid (typically water)
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#MultipleFlowSensor"></see></summary>
    let ``_.owl#MultipleFlowSensor`` = _prefix ".owl#MultipleFlowSensor"

    /// <summary>
    /// The capability of measuring the humidity of a room
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#MultipleHumidityMeasurementFunctionality"></see></summary>
    let ``_.owl#MultipleHumidityMeasurementFunctionality`` =
        _prefix ".owl#MultipleHumidityMeasurementFunctionality"

    /// <summary>
    /// The notification for requesting humidity measurment...
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#MultipleHumidityMeasurementNotificationFunctionality"></see></summary>
    let ``_.owl#MultipleHumidityMeasurementNotificationFunctionality`` =
        _prefix ".owl#MultipleHumidityMeasurementNotificationFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MultiplePressureMeasurementFunctionality"></see>
    /// </summary>
    let ``_.owl#MultiplePressureMeasurementFunctionality`` =
        _prefix ".owl#MultiplePressureMeasurementFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MultiplePressureMeasurementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#MultiplePressureMeasurementNotificationFunctionality`` =
        _prefix ".owl#MultiplePressureMeasurementNotificationFunctionality"

    /// <summary>
    /// The Pressure Sensor device measures and periodically reports the pressure of a liquid (typically water)
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#MultiplePressureSensor"></see></summary>
    let ``_.owl#MultiplePressureSensor`` = _prefix ".owl#MultiplePressureSensor"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MultiplePressureState"></see>
    /// </summary>
    let ``_.owl#MultiplePressureState`` = _prefix ".owl#MultiplePressureState"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MultiplePressureStateValue"></see>
    /// </summary>
    let ``_.owl#MultiplePressureStateValue`` = _prefix ".owl#MultiplePressureStateValue"

    /// <summary>
    /// The capability of measuring temperatures
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#MultipleTemperatureMeasurementFunctionality"></see></summary>
    let ``_.owl#MultipleTemperatureMeasurementFunctionality`` =
        _prefix ".owl#MultipleTemperatureMeasurementFunctionality"

    /// <summary>
    /// Notifies the measurment of a temperature, through a proper temperature sensor
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#MultipleTemperatureMeasurementNotificationFunctionality"></see></summary>
    let ``_.owl#MultipleTemperatureMeasurementNotificationFunctionality`` =
        _prefix ".owl#MultipleTemperatureMeasurementNotificationFunctionality"

    /// <summary>
    /// Sensor that detects the temperature of the atmosphere
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#MultipleTemperatureSensor"></see></summary>
    let ``_.owl#MultipleTemperatureSensor`` = _prefix ".owl#MultipleTemperatureSensor"
    /// <summary>
    /// Models the temperature value
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#MultipleTemperatureState"></see></summary>
    let ``_.owl#MultipleTemperatureState`` = _prefix ".owl#MultipleTemperatureState"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#TemperatureSensor"></see>
    /// </summary>
    let ``_.owl#TemperatureSensor`` = _prefix ".owl#TemperatureSensor"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MultipleTemperatureStateValue"></see>
    /// </summary>
    let ``_.owl#MultipleTemperatureStateValue`` =
        _prefix ".owl#MultipleTemperatureStateValue"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#NetworkClosedNotification"></see>
    /// </summary>
    let ``_.owl#NetworkClosedNotification`` = _prefix ".owl#NetworkClosedNotification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ZigBeeNotification"></see>
    /// </summary>
    let ``_.owl#ZigBeeNotification`` = _prefix ".owl#ZigBeeNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#NetworkManagementFunctionality"></see>
    /// </summary>
    let ``_.owl#NetworkManagementFunctionality`` =
        _prefix ".owl#NetworkManagementFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#OpenNetworkCommand"></see>
    /// </summary>
    let ``_.owl#OpenNetworkCommand`` = _prefix ".owl#OpenNetworkCommand"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#NetworkManagementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#NetworkManagementNotificationFunctionality`` =
        _prefix ".owl#NetworkManagementNotificationFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#NetworkOpenedNotification"></see>
    /// </summary>
    let ``_.owl#NetworkOpenedNotification`` = _prefix ".owl#NetworkOpenedNotification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#NetworkManagementState"></see>
    /// </summary>
    let ``_.owl#NetworkManagementState`` = _prefix ".owl#NetworkManagementState"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#RestDownNotification"></see>
    /// </summary>
    let ``_.owl#RestDownNotification`` = _prefix ".owl#RestDownNotification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#RestNotification"></see>
    /// </summary>
    let ``_.owl#RestNotification`` = _prefix ".owl#RestNotification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#RestUpNotification"></see>
    /// </summary>
    let ``_.owl#RestUpNotification`` = _prefix ".owl#RestUpNotification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SpeedStepDownNotification"></see>
    /// </summary>
    let ``_.owl#SpeedStepDownNotification`` = _prefix ".owl#SpeedStepDownNotification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SpeedStepUpNotification"></see>
    /// </summary>
    let ``_.owl#SpeedStepUpNotification`` = _prefix ".owl#SpeedStepUpNotification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#TuningStepDownNotification"></see>
    /// </summary>
    let ``_.owl#TuningStepDownNotification`` = _prefix ".owl#TuningStepDownNotification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#TuningStepUpNotification"></see>
    /// </summary>
    let ``_.owl#TuningStepUpNotification`` = _prefix ".owl#TuningStepUpNotification"
    /// <summary>
    /// Functionality: up - down
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#UpDownFunctionality"></see></summary>
    let ``_.owl#UpDownFunctionality`` = _prefix ".owl#UpDownFunctionality"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StepFunctionality"></see>
    /// </summary>
    let ``_.owl#StepFunctionality`` = _prefix ".owl#StepFunctionality"
    /// <summary>
    /// OnOffSwitch for Lights only, derives from ZigBee HA specifications
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#OnOffLightSwitch"></see></summary>
    let ``_.owl#OnOffLightSwitch`` = _prefix ".owl#OnOffLightSwitch"
    /// <summary>
    /// Generic OnOff switch, derives from the ZigBee Home Automation specification
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#OnOffSwitch"></see></summary>
    let ``_.owl#OnOffSwitch`` = _prefix ".owl#OnOffSwitch"
    /// <summary>
    /// Functionality: up - down - rest
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#UpDownRestFunctionality"></see></summary>
    let ``_.owl#UpDownRestFunctionality`` = _prefix ".owl#UpDownRestFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#OverloadControlFunctionality"></see>
    /// </summary>
    let ``_.owl#OverloadControlFunctionality`` =
        _prefix ".owl#OverloadControlFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#OverloadWarningCommand"></see>
    /// </summary>
    let ``_.owl#OverloadWarningCommand`` = _prefix ".owl#OverloadWarningCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#OverloadPauseResumeCommand"></see>
    /// </summary>
    let ``_.owl#OverloadPauseResumeCommand`` = _prefix ".owl#OverloadPauseResumeCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#OverloadPauseCommand"></see>
    /// </summary>
    let ``_.owl#OverloadPauseCommand`` = _prefix ".owl#OverloadPauseCommand"
    /// <summary>
    /// A vertical structure that divides or separates
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Partition"></see></summary>
    let ``_.owl#Partition`` = _prefix ".owl#Partition"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PausePlaybackNotification"></see>
    /// </summary>
    let ``_.owl#PausePlaybackNotification`` = _prefix ".owl#PausePlaybackNotification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PlayNotification"></see>
    /// </summary>
    let ``_.owl#PlayNotification`` = _prefix ".owl#PlayNotification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#RewindNotification"></see>
    /// </summary>
    let ``_.owl#RewindNotification`` = _prefix ".owl#RewindNotification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StopPlaybackNotification"></see>
    /// </summary>
    let ``_.owl#StopPlaybackNotification`` = _prefix ".owl#StopPlaybackNotification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#TrackControlNotification"></see>
    /// </summary>
    let ``_.owl#TrackControlNotification`` = _prefix ".owl#TrackControlNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PowerFactorMeasurementFunctionality"></see>
    /// </summary>
    let ``_.owl#PowerFactorMeasurementFunctionality`` =
        _prefix ".owl#PowerFactorMeasurementFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PowerFactorMeasurementNotification"></see>
    /// </summary>
    let ``_.owl#PowerFactorMeasurementNotification`` =
        _prefix ".owl#PowerFactorMeasurementNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PowerFactorMeasurementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#PowerFactorMeasurementNotificationFunctionality`` =
        _prefix ".owl#PowerFactorMeasurementNotificationFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PowerFactorMeasurementState"></see>
    /// </summary>
    let ``_.owl#PowerFactorMeasurementState`` =
        _prefix ".owl#PowerFactorMeasurementState"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PowerFactorStateValue"></see>
    /// </summary>
    let ``_.owl#PowerFactorStateValue`` = _prefix ".owl#PowerFactorStateValue"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PowerMeteringLevelControllableOutput"></see>
    /// </summary>
    let ``_.owl#PowerMeteringLevelControllableOutput`` =
        _prefix ".owl#PowerMeteringLevelControllableOutput"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PresenceAndMovementSensor"></see>
    /// </summary>
    let ``_.owl#PresenceAndMovementSensor`` = _prefix ".owl#PresenceAndMovementSensor"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PresenceSensor"></see>
    /// </summary>
    let ``_.owl#PresenceSensor`` = _prefix ".owl#PresenceSensor"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ProgramState"></see>
    /// </summary>
    let ``_.owl#ProgramState`` = _prefix ".owl#ProgramState"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PushLinkAuthenticationActiveNotification"></see>
    /// </summary>
    let ``_.owl#PushLinkAuthenticationActiveNotification`` =
        _prefix ".owl#PushLinkAuthenticationActiveNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PushLinkAuthenticationIdleNotification"></see>
    /// </summary>
    let ``_.owl#PushLinkAuthenticationIdleNotification`` =
        _prefix ".owl#PushLinkAuthenticationIdleNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StopPushLinkAuthenticationCommand"></see>
    /// </summary>
    let ``_.owl#StopPushLinkAuthenticationCommand`` =
        _prefix ".owl#StopPushLinkAuthenticationCommand"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StartPushLinkAuthenticationCommand"></see>
    /// </summary>
    let ``_.owl#StartPushLinkAuthenticationCommand`` =
        _prefix ".owl#StartPushLinkAuthenticationCommand"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#QuadSensor"></see>
    /// </summary>
    let ``_.owl#QuadSensor`` = _prefix ".owl#QuadSensor"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ReactivePowerMeasurementFunctionality"></see>
    /// </summary>
    let ``_.owl#ReactivePowerMeasurementFunctionality`` =
        _prefix ".owl#ReactivePowerMeasurementFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ReactivePowerMeasurementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#ReactivePowerMeasurementNotificationFunctionality`` =
        _prefix ".owl#ReactivePowerMeasurementNotificationFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ReactivePowerMeasurementState"></see>
    /// </summary>
    let ``_.owl#ReactivePowerMeasurementState`` =
        _prefix ".owl#ReactivePowerMeasurementState"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ReactivePowerMeter"></see>
    /// </summary>
    let ``_.owl#ReactivePowerMeter`` = _prefix ".owl#ReactivePowerMeter"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ReactivePowerStateValue"></see>
    /// </summary>
    let ``_.owl#ReactivePowerStateValue`` = _prefix ".owl#ReactivePowerStateValue"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#RunState"></see>
    /// </summary>
    let ``_.owl#RunState`` = _prefix ".owl#RunState"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SelfClosingDoorActuator"></see>
    /// </summary>
    let ``_.owl#SelfClosingDoorActuator`` = _prefix ".owl#SelfClosingDoorActuator"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#VerticalNoMovementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#VerticalNoMovementNotificationFunctionality`` =
        _prefix ".owl#VerticalNoMovementNotificationFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#VerticalMovementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#VerticalMovementNotificationFunctionality`` =
        _prefix ".owl#VerticalMovementNotificationFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ShutterState"></see>
    /// </summary>
    let ``_.owl#ShutterState`` = _prefix ".owl#ShutterState"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ShutterButton"></see>
    /// </summary>
    let ``_.owl#ShutterButton`` = _prefix ".owl#ShutterButton"
    /// <summary>
    /// State: up - down - rest
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#UpDownRestState"></see></summary>
    let ``_.owl#UpDownRestState`` = _prefix ".owl#UpDownRestState"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseActiveEnergyMeasurementFunctionality"></see>
    /// </summary>
    let ``_.owl#SinglePhaseActiveEnergyMeasurementFunctionality`` =
        _prefix ".owl#SinglePhaseActiveEnergyMeasurementFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseActiveEnergyMeasurementNotification"></see>
    /// </summary>
    let ``_.owl#SinglePhaseActiveEnergyMeasurementNotification`` =
        _prefix ".owl#SinglePhaseActiveEnergyMeasurementNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseActiveEnergyMeasurementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#SinglePhaseActiveEnergyMeasurementNotificationFunctionality`` =
        _prefix ".owl#SinglePhaseActiveEnergyMeasurementNotificationFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseActiveEnergyState"></see>
    /// </summary>
    let ``_.owl#SinglePhaseActiveEnergyState`` =
        _prefix ".owl#SinglePhaseActiveEnergyState"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SingleTariffEnergyMeter"></see>
    /// </summary>
    let ``_.owl#SingleTariffEnergyMeter`` = _prefix ".owl#SingleTariffEnergyMeter"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseActivePowerMeasurementFunctionality"></see>
    /// </summary>
    let ``_.owl#SinglePhaseActivePowerMeasurementFunctionality`` =
        _prefix ".owl#SinglePhaseActivePowerMeasurementFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseActivePowerMeasurementNotification"></see>
    /// </summary>
    let ``_.owl#SinglePhaseActivePowerMeasurementNotification`` =
        _prefix ".owl#SinglePhaseActivePowerMeasurementNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseActivePowerMeasurementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#SinglePhaseActivePowerMeasurementNotificationFunctionality`` =
        _prefix ".owl#SinglePhaseActivePowerMeasurementNotificationFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseActivePowerMeasurementState"></see>
    /// </summary>
    let ``_.owl#SinglePhaseActivePowerMeasurementState`` =
        _prefix ".owl#SinglePhaseActivePowerMeasurementState"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseApparentPowerMeasurementFunctionality"></see>
    /// </summary>
    let ``_.owl#SinglePhaseApparentPowerMeasurementFunctionality`` =
        _prefix ".owl#SinglePhaseApparentPowerMeasurementFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseApparentPowerMeasurementNotification"></see>
    /// </summary>
    let ``_.owl#SinglePhaseApparentPowerMeasurementNotification`` =
        _prefix ".owl#SinglePhaseApparentPowerMeasurementNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseApparentPowerMeasurementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#SinglePhaseApparentPowerMeasurementNotificationFunctionality`` =
        _prefix ".owl#SinglePhaseApparentPowerMeasurementNotificationFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseApparentPowerMeasurementState"></see>
    /// </summary>
    let ``_.owl#SinglePhaseApparentPowerMeasurementState`` =
        _prefix ".owl#SinglePhaseApparentPowerMeasurementState"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseApparentPowerMeter"></see>
    /// </summary>
    let ``_.owl#SinglePhaseApparentPowerMeter`` =
        _prefix ".owl#SinglePhaseApparentPowerMeter"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseCurrentMeasurementFunctionality"></see>
    /// </summary>
    let ``_.owl#SinglePhaseCurrentMeasurementFunctionality`` =
        _prefix ".owl#SinglePhaseCurrentMeasurementFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseCurrentMeasurementNotification"></see>
    /// </summary>
    let ``_.owl#SinglePhaseCurrentMeasurementNotification`` =
        _prefix ".owl#SinglePhaseCurrentMeasurementNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseCurrentMeasurementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#SinglePhaseCurrentMeasurementNotificationFunctionality`` =
        _prefix ".owl#SinglePhaseCurrentMeasurementNotificationFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseCurrentMeter"></see>
    /// </summary>
    let ``_.owl#SinglePhaseCurrentMeter`` = _prefix ".owl#SinglePhaseCurrentMeter"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseCurrentState"></see>
    /// </summary>
    let ``_.owl#SinglePhaseCurrentState`` = _prefix ".owl#SinglePhaseCurrentState"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseElectricityMeter"></see>
    /// </summary>
    let ``_.owl#SinglePhaseElectricityMeter`` =
        _prefix ".owl#SinglePhaseElectricityMeter"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseReactivePowerMeter"></see>
    /// </summary>
    let ``_.owl#SinglePhaseReactivePowerMeter`` =
        _prefix ".owl#SinglePhaseReactivePowerMeter"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseVoltageMeter"></see>
    /// </summary>
    let ``_.owl#SinglePhaseVoltageMeter`` = _prefix ".owl#SinglePhaseVoltageMeter"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseReactiveEnergyMeasurementFunctionality"></see>
    /// </summary>
    let ``_.owl#SinglePhaseReactiveEnergyMeasurementFunctionality`` =
        _prefix ".owl#SinglePhaseReactiveEnergyMeasurementFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseReactiveEnergyState"></see>
    /// </summary>
    let ``_.owl#SinglePhaseReactiveEnergyState`` =
        _prefix ".owl#SinglePhaseReactiveEnergyState"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseReactiveEnergyMeasurementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#SinglePhaseReactiveEnergyMeasurementNotificationFunctionality`` =
        _prefix ".owl#SinglePhaseReactiveEnergyMeasurementNotificationFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseReactiveEnergyMeasurementNotification"></see>
    /// </summary>
    let ``_.owl#SinglePhaseReactiveEnergyMeasurementNotification`` =
        _prefix ".owl#SinglePhaseReactiveEnergyMeasurementNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseReactivePowerMeasurementFunctionality"></see>
    /// </summary>
    let ``_.owl#SinglePhaseReactivePowerMeasurementFunctionality`` =
        _prefix ".owl#SinglePhaseReactivePowerMeasurementFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseReactivePowerMeasurementNotification"></see>
    /// </summary>
    let ``_.owl#SinglePhaseReactivePowerMeasurementNotification`` =
        _prefix ".owl#SinglePhaseReactivePowerMeasurementNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseReactivePowerMeasurementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#SinglePhaseReactivePowerMeasurementNotificationFunctionality`` =
        _prefix ".owl#SinglePhaseReactivePowerMeasurementNotificationFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseReactivePowerMeasurementState"></see>
    /// </summary>
    let ``_.owl#SinglePhaseReactivePowerMeasurementState`` =
        _prefix ".owl#SinglePhaseReactivePowerMeasurementState"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseVoltageMeasurementFunctionality"></see>
    /// </summary>
    let ``_.owl#SinglePhaseVoltageMeasurementFunctionality`` =
        _prefix ".owl#SinglePhaseVoltageMeasurementFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#VoltageMeasurementFunctionality"></see>
    /// </summary>
    let ``_.owl#VoltageMeasurementFunctionality`` =
        _prefix ".owl#VoltageMeasurementFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseVoltageMeasurementNotification"></see>
    /// </summary>
    let ``_.owl#SinglePhaseVoltageMeasurementNotification`` =
        _prefix ".owl#SinglePhaseVoltageMeasurementNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseVoltageMeasurementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#SinglePhaseVoltageMeasurementNotificationFunctionality`` =
        _prefix ".owl#SinglePhaseVoltageMeasurementNotificationFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#VoltageMeasurementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#VoltageMeasurementNotificationFunctionality`` =
        _prefix ".owl#VoltageMeasurementNotificationFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseVoltageState"></see>
    /// </summary>
    let ``_.owl#SinglePhaseVoltageState`` = _prefix ".owl#SinglePhaseVoltageState"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#VoltageMeter"></see>
    /// </summary>
    let ``_.owl#VoltageMeter`` = _prefix ".owl#VoltageMeter"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#VoltageStateValue"></see>
    /// </summary>
    let ``_.owl#VoltageStateValue`` = _prefix ".owl#VoltageStateValue"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#VoltageMeasurementState"></see>
    /// </summary>
    let ``_.owl#VoltageMeasurementState`` = _prefix ".owl#VoltageMeasurementState"
    /// <summary>
    /// A device in which compressed air or steam is driven against a rotating perforated disk to create a loud, often wailing sound as a signal or warning.
    ///
    /// An electronic device producing a similar sound as a signal or warning: a police car siren.
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Siren"></see></summary>
    let ``_.owl#Siren`` = _prefix ".owl#Siren"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SnapshotCamera"></see>
    /// </summary>
    let ``_.owl#SnapshotCamera`` = _prefix ".owl#SnapshotCamera"
    /// <summary>
    /// Plays a Sound (default, or selected through a goTotrack, or...)
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#SoundFunctionality"></see></summary>
    let ``_.owl#SoundFunctionality`` = _prefix ".owl#SoundFunctionality"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ToggleFunctionality"></see>
    /// </summary>
    let ``_.owl#ToggleFunctionality`` = _prefix ".owl#ToggleFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SourceSelectionNotification"></see>
    /// </summary>
    let ``_.owl#SourceSelectionNotification`` =
        _prefix ".owl#SourceSelectionNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SpeedControlNotification"></see>
    /// </summary>
    let ``_.owl#SpeedControlNotification`` = _prefix ".owl#SpeedControlNotification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StartCommand"></see>
    /// </summary>
    let ``_.owl#StartCommand`` = _prefix ".owl#StartCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StopCommand"></see>
    /// </summary>
    let ``_.owl#StopCommand`` = _prefix ".owl#StopCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StartSuperFreezingCommand"></see>
    /// </summary>
    let ``_.owl#StartSuperFreezingCommand`` = _prefix ".owl#StartSuperFreezingCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StartSuperHeatingCommand"></see>
    /// </summary>
    let ``_.owl#StartSuperHeatingCommand`` = _prefix ".owl#StartSuperHeatingCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StartSupercoolingCommand"></see>
    /// </summary>
    let ``_.owl#StartSupercoolingCommand`` = _prefix ".owl#StartSupercoolingCommand"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StartedSuperCoolingNotification"></see>
    /// </summary>
    let ``_.owl#StartedSuperCoolingNotification`` =
        _prefix ".owl#StartedSuperCoolingNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StartedSuperFreezingNotification"></see>
    /// </summary>
    let ``_.owl#StartedSuperFreezingNotification`` =
        _prefix ".owl#StartedSuperFreezingNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StartedSuperHeatingNotification"></see>
    /// </summary>
    let ``_.owl#StartedSuperHeatingNotification`` =
        _prefix ".owl#StartedSuperHeatingNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StartedWashingNotification"></see>
    /// </summary>
    let ``_.owl#StartedWashingNotification`` = _prefix ".owl#StartedWashingNotification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StepShutterActuator"></see>
    /// </summary>
    let ``_.owl#StepShutterActuator`` = _prefix ".owl#StepShutterActuator"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StopSuperFreezingCommand"></see>
    /// </summary>
    let ``_.owl#StopSuperFreezingCommand`` = _prefix ".owl#StopSuperFreezingCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StopSuperHeatingCommand"></see>
    /// </summary>
    let ``_.owl#StopSuperHeatingCommand`` = _prefix ".owl#StopSuperHeatingCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StopSupercoolingCommand"></see>
    /// </summary>
    let ``_.owl#StopSupercoolingCommand`` = _prefix ".owl#StopSupercoolingCommand"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StoppedSuperCoolingNotification"></see>
    /// </summary>
    let ``_.owl#StoppedSuperCoolingNotification`` =
        _prefix ".owl#StoppedSuperCoolingNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StoppedSuperFreezingNotification"></see>
    /// </summary>
    let ``_.owl#StoppedSuperFreezingNotification`` =
        _prefix ".owl#StoppedSuperFreezingNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StoppedSuperHeatingNotification"></see>
    /// </summary>
    let ``_.owl#StoppedSuperHeatingNotification`` =
        _prefix ".owl#StoppedSuperHeatingNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StoppedWashingNotification"></see>
    /// </summary>
    let ``_.owl#StoppedWashingNotification`` = _prefix ".owl#StoppedWashingNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#TemperatureAndHumiditySensor"></see>
    /// </summary>
    let ``_.owl#TemperatureAndHumiditySensor`` =
        _prefix ".owl#TemperatureAndHumiditySensor"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#TexasInstrumentsComponent"></see>
    /// </summary>
    let ``_.owl#TexasInstrumentsComponent`` = _prefix ".owl#TexasInstrumentsComponent"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#TexasInstrumentsGateway"></see>
    /// </summary>
    let ``_.owl#TexasInstrumentsGateway`` = _prefix ".owl#TexasInstrumentsGateway"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThermostatQueryFunctionality"></see>
    /// </summary>
    let ``_.owl#ThermostatQueryFunctionality`` =
        _prefix ".owl#ThermostatQueryFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThermostaticRadiatorValve"></see>
    /// </summary>
    let ``_.owl#ThermostaticRadiatorValve`` = _prefix ".owl#ThermostaticRadiatorValve"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseActiveEnergyMeasurementFunctionality"></see>
    /// </summary>
    let ``_.owl#ThreePhaseActiveEnergyMeasurementFunctionality`` =
        _prefix ".owl#ThreePhaseActiveEnergyMeasurementFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseActiveEnergyMeasurementNotification"></see>
    /// </summary>
    let ``_.owl#ThreePhaseActiveEnergyMeasurementNotification`` =
        _prefix ".owl#ThreePhaseActiveEnergyMeasurementNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseActiveEnergyMeasurementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#ThreePhaseActiveEnergyMeasurementNotificationFunctionality`` =
        _prefix ".owl#ThreePhaseActiveEnergyMeasurementNotificationFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseActiveEnergyState"></see>
    /// </summary>
    let ``_.owl#ThreePhaseActiveEnergyState`` =
        _prefix ".owl#ThreePhaseActiveEnergyState"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseActivePowerMeasurementFunctionality"></see>
    /// </summary>
    let ``_.owl#ThreePhaseActivePowerMeasurementFunctionality`` =
        _prefix ".owl#ThreePhaseActivePowerMeasurementFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseActivePowerMeasurementNotification"></see>
    /// </summary>
    let ``_.owl#ThreePhaseActivePowerMeasurementNotification`` =
        _prefix ".owl#ThreePhaseActivePowerMeasurementNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseActivePowerMeasurementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#ThreePhaseActivePowerMeasurementNotificationFunctionality`` =
        _prefix ".owl#ThreePhaseActivePowerMeasurementNotificationFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseActivePowerMeasurementState"></see>
    /// </summary>
    let ``_.owl#ThreePhaseActivePowerMeasurementState`` =
        _prefix ".owl#ThreePhaseActivePowerMeasurementState"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseActivePowerMeter"></see>
    /// </summary>
    let ``_.owl#ThreePhaseActivePowerMeter`` = _prefix ".owl#ThreePhaseActivePowerMeter"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseApparentPowerMeasurementFunctionality"></see>
    /// </summary>
    let ``_.owl#ThreePhaseApparentPowerMeasurementFunctionality`` =
        _prefix ".owl#ThreePhaseApparentPowerMeasurementFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseApparentPowerMeasurementNotification"></see>
    /// </summary>
    let ``_.owl#ThreePhaseApparentPowerMeasurementNotification`` =
        _prefix ".owl#ThreePhaseApparentPowerMeasurementNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseApparentPowerMeasurementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#ThreePhaseApparentPowerMeasurementNotificationFunctionality`` =
        _prefix ".owl#ThreePhaseApparentPowerMeasurementNotificationFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseApparentPowerMeasurementState"></see>
    /// </summary>
    let ``_.owl#ThreePhaseApparentPowerMeasurementState`` =
        _prefix ".owl#ThreePhaseApparentPowerMeasurementState"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseApparentPowerMeter"></see>
    /// </summary>
    let ``_.owl#ThreePhaseApparentPowerMeter`` =
        _prefix ".owl#ThreePhaseApparentPowerMeter"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseCurrentMeasurementFunctionality"></see>
    /// </summary>
    let ``_.owl#ThreePhaseCurrentMeasurementFunctionality`` =
        _prefix ".owl#ThreePhaseCurrentMeasurementFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseCurrentMeasurementNotification"></see>
    /// </summary>
    let ``_.owl#ThreePhaseCurrentMeasurementNotification`` =
        _prefix ".owl#ThreePhaseCurrentMeasurementNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseCurrentMeasurementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#ThreePhaseCurrentMeasurementNotificationFunctionality`` =
        _prefix ".owl#ThreePhaseCurrentMeasurementNotificationFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseCurrentMeter"></see>
    /// </summary>
    let ``_.owl#ThreePhaseCurrentMeter`` = _prefix ".owl#ThreePhaseCurrentMeter"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseCurrentState"></see>
    /// </summary>
    let ``_.owl#ThreePhaseCurrentState`` = _prefix ".owl#ThreePhaseCurrentState"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseElectricityMeter"></see>
    /// </summary>
    let ``_.owl#ThreePhaseElectricityMeter`` = _prefix ".owl#ThreePhaseElectricityMeter"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseReactivePowerMeter"></see>
    /// </summary>
    let ``_.owl#ThreePhaseReactivePowerMeter`` =
        _prefix ".owl#ThreePhaseReactivePowerMeter"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseVoltageMeter"></see>
    /// </summary>
    let ``_.owl#ThreePhaseVoltageMeter`` = _prefix ".owl#ThreePhaseVoltageMeter"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseEnergyMeter"></see>
    /// </summary>
    let ``_.owl#ThreePhaseEnergyMeter`` = _prefix ".owl#ThreePhaseEnergyMeter"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseReactiveEnergyState"></see>
    /// </summary>
    let ``_.owl#ThreePhaseReactiveEnergyState`` =
        _prefix ".owl#ThreePhaseReactiveEnergyState"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseReactiveEnergyMeasurementFunctionality"></see>
    /// </summary>
    let ``_.owl#ThreePhaseReactiveEnergyMeasurementFunctionality`` =
        _prefix ".owl#ThreePhaseReactiveEnergyMeasurementFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseReactiveEnergyMeasurementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#ThreePhaseReactiveEnergyMeasurementNotificationFunctionality`` =
        _prefix ".owl#ThreePhaseReactiveEnergyMeasurementNotificationFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseLLVoltageMeasurementNotification"></see>
    /// </summary>
    let ``_.owl#ThreePhaseLLVoltageMeasurementNotification`` =
        _prefix ".owl#ThreePhaseLLVoltageMeasurementNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseLNVoltageMeasurementNotification"></see>
    /// </summary>
    let ``_.owl#ThreePhaseLNVoltageMeasurementNotification`` =
        _prefix ".owl#ThreePhaseLNVoltageMeasurementNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseReactiveEnergyMeasurementNotification"></see>
    /// </summary>
    let ``_.owl#ThreePhaseReactiveEnergyMeasurementNotification`` =
        _prefix ".owl#ThreePhaseReactiveEnergyMeasurementNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseReactivePowerMeasurementFunctionality"></see>
    /// </summary>
    let ``_.owl#ThreePhaseReactivePowerMeasurementFunctionality`` =
        _prefix ".owl#ThreePhaseReactivePowerMeasurementFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseReactivePowerMeasurementNotification"></see>
    /// </summary>
    let ``_.owl#ThreePhaseReactivePowerMeasurementNotification`` =
        _prefix ".owl#ThreePhaseReactivePowerMeasurementNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseReactivePowerMeasurementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#ThreePhaseReactivePowerMeasurementNotificationFunctionality`` =
        _prefix ".owl#ThreePhaseReactivePowerMeasurementNotificationFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseReactivePowerMeasurementState"></see>
    /// </summary>
    let ``_.owl#ThreePhaseReactivePowerMeasurementState`` =
        _prefix ".owl#ThreePhaseReactivePowerMeasurementState"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseVoltageMeasurementFunctionality"></see>
    /// </summary>
    let ``_.owl#ThreePhaseVoltageMeasurementFunctionality`` =
        _prefix ".owl#ThreePhaseVoltageMeasurementFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseVoltageMeasurementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#ThreePhaseVoltageMeasurementNotificationFunctionality`` =
        _prefix ".owl#ThreePhaseVoltageMeasurementNotificationFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseVoltageState"></see>
    /// </summary>
    let ``_.owl#ThreePhaseVoltageState`` = _prefix ".owl#ThreePhaseVoltageState"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#TridimensionalAccelerationNotification"></see>
    /// </summary>
    let ``_.owl#TridimensionalAccelerationNotification`` =
        _prefix ".owl#TridimensionalAccelerationNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#TridimensionalAccelerationNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#TridimensionalAccelerationNotificationFunctionality`` =
        _prefix ".owl#TridimensionalAccelerationNotificationFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#TripleSensor"></see>
    /// </summary>
    let ``_.owl#TripleSensor`` = _prefix ".owl#TripleSensor"
    /// <summary>
    /// A device that circulates fresh air and expels stale or foul air.
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Ventilator"></see></summary>
    let ``_.owl#Ventilator`` = _prefix ".owl#Ventilator"
    /// <summary>
    /// Association between a wallopening(door or window) and the wall opening where it is
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#isInWall"></see></summary>
    let ``_.owl#isInWall`` = _prefix ".owl#isInWall"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#WashRinseStateValue"></see>
    /// </summary>
    let ``_.owl#WashRinseStateValue`` = _prefix ".owl#WashRinseStateValue"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#WashingApplianceState"></see>
    /// </summary>
    let ``_.owl#WashingApplianceState`` = _prefix ".owl#WashingApplianceState"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#WashingCycleNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#WashingCycleNotificationFunctionality`` =
        _prefix ".owl#WashingCycleNotificationFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#WaterMeasurementFuctionality"></see>
    /// </summary>
    let ``_.owl#WaterMeasurementFuctionality`` =
        _prefix ".owl#WaterMeasurementFuctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#WaterMeasurementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#WaterMeasurementNotificationFunctionality`` =
        _prefix ".owl#WaterMeasurementNotificationFunctionality"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#WaterMeasurementState"></see>
    /// </summary>
    let ``_.owl#WaterMeasurementState`` = _prefix ".owl#WaterMeasurementState"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#WaterMeter"></see>
    /// </summary>
    let ``_.owl#WaterMeter`` = _prefix ".owl#WaterMeter"
    /// <summary>
    /// Phone with no wire
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#WirelessPhone"></see></summary>
    let ``_.owl#WirelessPhone`` = _prefix ".owl#WirelessPhone"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ZWaveComponent"></see>
    /// </summary>
    let ``_.owl#ZWaveComponent`` = _prefix ".owl#ZWaveComponent"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ZWaveGateway"></see>
    /// </summary>
    let ``_.owl#ZWaveGateway`` = _prefix ".owl#ZWaveGateway"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ZigBeeGateway"></see>
    /// </summary>
    let ``_.owl#ZigBeeGateway`` = _prefix ".owl#ZigBeeGateway"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ceilingOf"></see>
    /// </summary>
    let ``_.owl#ceilingOf`` = _prefix ".owl#ceilingOf"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#commandOf"></see>
    /// </summary>
    let ``_.owl#commandOf`` = _prefix ".owl#commandOf"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#eZ430Chronos"></see>
    /// </summary>
    let ``_.owl#eZ430Chronos`` = _prefix ".owl#eZ430Chronos"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#floorOf"></see>
    /// </summary>
    let ``_.owl#floorOf`` = _prefix ".owl#floorOf"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#generateCommand"></see>
    /// </summary>
    let ``_.owl#generateCommand`` = _prefix ".owl#generateCommand"
    /// <summary>
    /// Association between an object and its controller,e.g.switch,button,knob
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#hasControl"></see></summary>
    let ``_.owl#hasControl`` = _prefix ".owl#hasControl"
    /// <summary>
    /// Relates a given domotic component with the network level gateway used to control it
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#hasGateway"></see></summary>
    let ``_.owl#hasGateway`` = _prefix ".owl#hasGateway"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#hasMeter"></see>
    /// </summary>
    let ``_.owl#hasMeter`` = _prefix ".owl#hasMeter"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#meterOf"></see>
    /// </summary>
    let ``_.owl#meterOf`` = _prefix ".owl#meterOf"
    /// <summary>
    /// Association between a room and its walls
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#hasWall"></see></summary>
    let ``_.owl#hasWall`` = _prefix ".owl#hasWall"
    /// <summary>
    /// Association between a wall and its opening like door,window
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#hasWallOpening"></see></summary>
    let ``_.owl#hasWallOpening`` = _prefix ".owl#hasWallOpening"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#instanceId"></see>
    /// </summary>
    let ``_.owl#instanceId`` = _prefix ".owl#instanceId"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#nodeId"></see>
    /// </summary>
    let ``_.owl#nodeId`` = _prefix ".owl#nodeId"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#notificationOf"></see>
    /// </summary>
    let ``_.owl#notificationOf`` = _prefix ".owl#notificationOf"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#plugOf"></see>
    /// </summary>
    let ``_.owl#plugOf`` = _prefix ".owl#plugOf"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#pluggedIn"></see>
    /// </summary>
    let ``_.owl#pluggedIn`` = _prefix ".owl#pluggedIn"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#statevalueOf"></see>
    /// </summary>
    let ``_.owl#statevalueOf`` = _prefix ".owl#statevalueOf"
