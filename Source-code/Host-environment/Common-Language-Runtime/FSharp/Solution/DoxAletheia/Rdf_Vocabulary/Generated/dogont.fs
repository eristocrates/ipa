namespace http.elite.polito.it.ontologies.dogont.bare

open DoxAletheia.Rdf_Vocabulary

module dogont =
    let _namespace_name = "http://elite.polito.it/ontologies/dogont"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#BTicinoProperty"></see>
    /// </summary>
    let ``_.owl#BTicinoProperty`` =
        Namespaced_IRI.parse _namespace_name ".owl#BTicinoProperty" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#EchelonProperty"></see>
    /// </summary>
    let ``_.owl#EchelonProperty`` =
        Namespaced_IRI.parse _namespace_name ".owl#EchelonProperty" |> NamespacedName

    /// <summary>
    /// The IP address of the gateway
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#IPAddress"></see></summary>
    let ``_.owl#IPAddress`` =
        Namespaced_IRI.parse _namespace_name ".owl#IPAddress" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#KonnexProperty"></see>
    /// </summary>
    let ``_.owl#KonnexProperty`` =
        Namespaced_IRI.parse _namespace_name ".owl#KonnexProperty" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ModBusProperty"></see>
    /// </summary>
    let ``_.owl#ModBusProperty`` =
        Namespaced_IRI.parse _namespace_name ".owl#ModBusProperty" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ZWaveProperty"></see>
    /// </summary>
    let ``_.owl#ZWaveProperty`` =
        Namespaced_IRI.parse _namespace_name ".owl#ZWaveProperty" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#commandParamName"></see>
    /// </summary>
    let ``_.owl#commandParamName`` =
        Namespaced_IRI.parse _namespace_name ".owl#commandParamName" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#commandParamValue"></see>
    /// </summary>
    let ``_.owl#commandParamValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#commandParamValue" |> NamespacedName

    /// <summary>
    /// The time before the connection expires
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#connectionTimeOut"></see></summary>
    let ``_.owl#connectionTimeOut`` =
        Namespaced_IRI.parse _namespace_name ".owl#connectionTimeOut" |> NamespacedName

    /// <summary>
    /// Number of connection trials before failure
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#connectionTrials"></see></summary>
    let ``_.owl#connectionTrials`` =
        Namespaced_IRI.parse _namespace_name ".owl#connectionTrials" |> NamespacedName

    /// <summary>
    /// The flashing period duration in seconds
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#flashingTime"></see></summary>
    let ``_.owl#flashingTime`` =
        Namespaced_IRI.parse _namespace_name ".owl#flashingTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#levelFromGround"></see>
    /// </summary>
    let ``_.owl#levelFromGround`` =
        Namespaced_IRI.parse _namespace_name ".owl#levelFromGround" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#nParams"></see>
    /// </summary>
    let ``_.owl#nParams`` =
        Namespaced_IRI.parse _namespace_name ".owl#nParams" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#notificationName"></see>
    /// </summary>
    let ``_.owl#notificationName`` =
        Namespaced_IRI.parse _namespace_name ".owl#notificationName" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#notificationParamName"></see>
    /// </summary>
    let ``_.owl#notificationParamName`` =
        Namespaced_IRI.parse _namespace_name ".owl#notificationParamName" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#phaseID"></see>
    /// </summary>
    let ``_.owl#phaseID`` =
        Namespaced_IRI.parse _namespace_name ".owl#phaseID" |> NamespacedName

    /// <summary>
    /// The interval between subsequent polls
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#pollingInterval"></see></summary>
    let ``_.owl#pollingInterval`` =
        Namespaced_IRI.parse _namespace_name ".owl#pollingInterval" |> NamespacedName

    /// <summary>
    /// The port of the gateway
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#port"></see></summary>
    let ``_.owl#port`` =
        Namespaced_IRI.parse _namespace_name ".owl#port" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#probeID"></see>
    /// </summary>
    let ``_.owl#probeID`` =
        Namespaced_IRI.parse _namespace_name ".owl#probeID" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#realCommandName"></see>
    /// </summary>
    let ``_.owl#realCommandName`` =
        Namespaced_IRI.parse _namespace_name ".owl#realCommandName" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#realStateValue"></see>
    /// </summary>
    let ``_.owl#realStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#realStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#returnType"></see>
    /// </summary>
    let ``_.owl#returnType`` =
        Namespaced_IRI.parse _namespace_name ".owl#returnType" |> NamespacedName

    /// <summary>
    /// The time between connection trials
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#sleepTime"></see></summary>
    let ``_.owl#sleepTime`` =
        Namespaced_IRI.parse _namespace_name ".owl#sleepTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#stepValue"></see>
    /// </summary>
    let ``_.owl#stepValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#stepValue" |> NamespacedName

    /// <summary>
    /// A property holding the svg footprint for the given building environment object
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#svgFootprint"></see></summary>
    let ``_.owl#svgFootprint`` =
        Namespaced_IRI.parse _namespace_name ".owl#svgFootprint" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#tariffID"></see>
    /// </summary>
    let ``_.owl#tariffID`` =
        Namespaced_IRI.parse _namespace_name ".owl#tariffID" |> NamespacedName

    /// <summary>
    /// The time in seconds during which the object is turned on
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#timeToOff"></see></summary>
    let ``_.owl#timeToOff`` =
        Namespaced_IRI.parse _namespace_name ".owl#timeToOff" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#weekDay"></see>
    /// </summary>
    let ``_.owl#weekDay`` =
        Namespaced_IRI.parse _namespace_name ".owl#weekDay" |> NamespacedName

    /// <summary>
    /// A room containing a bath or shower and usually a washbasin and toilet
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Bathroom"></see></summary>
    let ``_.owl#Bathroom`` =
        Namespaced_IRI.parse _namespace_name ".owl#Bathroom" |> NamespacedName

    /// <summary>
    /// A room used primarily for sleeping
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Bedroom"></see></summary>
    let ``_.owl#Bedroom`` =
        Namespaced_IRI.parse _namespace_name ".owl#Bedroom" |> NamespacedName

    /// <summary>
    /// A room used for dining
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#DiningRoom"></see></summary>
    let ``_.owl#DiningRoom`` =
        Namespaced_IRI.parse _namespace_name ".owl#DiningRoom" |> NamespacedName

    /// <summary>
    /// A room equipped for preparing meals
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Kitchen"></see></summary>
    let ``_.owl#Kitchen`` =
        Namespaced_IRI.parse _namespace_name ".owl#Kitchen" |> NamespacedName

    /// <summary>
    /// A room where people can sit and talk and relax
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#LivingRoom"></see></summary>
    let ``_.owl#LivingRoom`` =
        Namespaced_IRI.parse _namespace_name ".owl#LivingRoom" |> NamespacedName

    /// <summary>
    /// A large entrance
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Lobby"></see></summary>
    let ``_.owl#Lobby`` =
        Namespaced_IRI.parse _namespace_name ".owl#Lobby" |> NamespacedName

    /// <summary>
    /// Little Room for storage of things in the house
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#StorageRoom"></see></summary>
    let ``_.owl#StorageRoom`` =
        Namespaced_IRI.parse _namespace_name ".owl#StorageRoom" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ApplianceRunNotification"></see>
    /// </summary>
    let ``_.owl#ApplianceRunNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#ApplianceRunNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#CloseNotification"></see>
    /// </summary>
    let ``_.owl#CloseNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#CloseNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#CoolNotification"></see>
    /// </summary>
    let ``_.owl#CoolNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#CoolNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#DetectedNotification"></see>
    /// </summary>
    let ``_.owl#DetectedNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#DetectedNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#EmittingMicrowavesNotification"></see>
    /// </summary>
    let ``_.owl#EmittingMicrowavesNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#EmittingMicrowavesNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#FiringUpNotification"></see>
    /// </summary>
    let ``_.owl#FiringUpNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#FiringUpNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#HeatNotification"></see>
    /// </summary>
    let ``_.owl#HeatNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#HeatNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#IdentifyNotification"></see>
    /// </summary>
    let ``_.owl#IdentifyNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#IdentifyNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#IsPresentNotification"></see>
    /// </summary>
    let ``_.owl#IsPresentNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#IsPresentNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MovementNotification"></see>
    /// </summary>
    let ``_.owl#MovementNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#MovementNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#NoMovementNotification"></see>
    /// </summary>
    let ``_.owl#NoMovementNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#NoMovementNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#NonParametricLevelNotification"></see>
    /// </summary>
    let ``_.owl#NonParametricLevelNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#NonParametricLevelNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#NotDetectedNotification"></see>
    /// </summary>
    let ``_.owl#NotDetectedNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#NotDetectedNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#NotEmittingMicrowavesNotification"></see>
    /// </summary>
    let ``_.owl#NotEmittingMicrowavesNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#NotEmittingMicrowavesNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#NotPresentNotification"></see>
    /// </summary>
    let ``_.owl#NotPresentNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#NotPresentNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#OffNotification"></see>
    /// </summary>
    let ``_.owl#OffNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#OffNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#OnNotification"></see>
    /// </summary>
    let ``_.owl#OnNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#OnNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#OpenNotification"></see>
    /// </summary>
    let ``_.owl#OpenNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#OpenNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PlaybackNotification"></see>
    /// </summary>
    let ``_.owl#PlaybackNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#PlaybackNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PressedDownNotification"></see>
    /// </summary>
    let ``_.owl#PressedDownNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#PressedDownNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PressedNotification"></see>
    /// </summary>
    let ``_.owl#PressedNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#PressedNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PressedUpNotification"></see>
    /// </summary>
    let ``_.owl#PressedUpNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#PressedUpNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ReleasedNotification"></see>
    /// </summary>
    let ``_.owl#ReleasedNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#ReleasedNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StandByNotification"></see>
    /// </summary>
    let ``_.owl#StandByNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#StandByNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StopHeatingCoolingNotification"></see>
    /// </summary>
    let ``_.owl#StopHeatingCoolingNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#StopHeatingCoolingNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SuperCoolingNotification"></see>
    /// </summary>
    let ``_.owl#SuperCoolingNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#SuperCoolingNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SuperFreezingNotification"></see>
    /// </summary>
    let ``_.owl#SuperFreezingNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#SuperFreezingNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SuperHeatingNotification"></see>
    /// </summary>
    let ``_.owl#SuperHeatingNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#SuperHeatingNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#WashingNotification"></see>
    /// </summary>
    let ``_.owl#WashingNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#WashingNotification" |> NamespacedName

    /// <summary>
    /// The address of the group of the component
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#groupAddress"></see></summary>
    let ``_.owl#groupAddress`` =
        Namespaced_IRI.parse _namespace_name ".owl#groupAddress" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#hexValue"></see>
    /// </summary>
    let ``_.owl#hexValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#hexValue" |> NamespacedName

    /// <summary>
    /// The individual address of the component
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#individualAddress"></see></summary>
    let ``_.owl#individualAddress`` =
        Namespaced_IRI.parse _namespace_name ".owl#individualAddress" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#registerAddress"></see>
    /// </summary>
    let ``_.owl#registerAddress`` =
        Namespaced_IRI.parse _namespace_name ".owl#registerAddress" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#registerType"></see>
    /// </summary>
    let ``_.owl#registerType`` =
        Namespaced_IRI.parse _namespace_name ".owl#registerType" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#scaleFactor"></see>
    /// </summary>
    let ``_.owl#scaleFactor`` =
        Namespaced_IRI.parse _namespace_name ".owl#scaleFactor" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#slaveId"></see>
    /// </summary>
    let ``_.owl#slaveId`` =
        Namespaced_IRI.parse _namespace_name ".owl#slaveId" |> NamespacedName

    /// <summary>
    /// The ILON id of a given datapoint associated to the command or notification of a given echelon-managed device
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#datapoinId"></see></summary>
    let ``_.owl#datapoinId`` =
        Namespaced_IRI.parse _namespace_name ".owl#datapoinId" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#datapointAlias"></see>
    /// </summary>
    let ``_.owl#datapointAlias`` =
        Namespaced_IRI.parse _namespace_name ".owl#datapointAlias" |> NamespacedName

    /// <summary>
    /// The address (URL) of the web service endpoint at which the ILON100 server having this property offers data reading and writing services
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#endpointAddress"></see></summary>
    let ``_.owl#endpointAddress`` =
        Namespaced_IRI.parse _namespace_name ".owl#endpointAddress" |> NamespacedName

    /// <summary>
    /// The multicast address of the gateway
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#multicastIP"></see></summary>
    let ``_.owl#multicastIP`` =
        Namespaced_IRI.parse _namespace_name ".owl#multicastIP" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ActiveDiscoveryStateValue"></see>
    /// </summary>
    let ``_.owl#ActiveDiscoveryStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#ActiveDiscoveryStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ActivePushLinkAuthenticationStateValue"></see>
    /// </summary>
    let ``_.owl#ActivePushLinkAuthenticationStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#ActivePushLinkAuthenticationStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#AssociatingStateValue"></see>
    /// </summary>
    let ``_.owl#AssociatingStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#AssociatingStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#AuthenticatedStateValue"></see>
    /// </summary>
    let ``_.owl#AuthenticatedStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#AuthenticatedStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#AutoRegulationStateValue"></see>
    /// </summary>
    let ``_.owl#AutoRegulationStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#AutoRegulationStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#AuxStateValue"></see>
    /// </summary>
    let ``_.owl#AuxStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#AuxStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#CDStateValue"></see>
    /// </summary>
    let ``_.owl#CDStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#CDStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ClimateScheduleStateValue"></see>
    /// </summary>
    let ``_.owl#ClimateScheduleStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#ClimateScheduleStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#CloseStateValue"></see>
    /// </summary>
    let ``_.owl#CloseStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#CloseStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ConnectedStateValue"></see>
    /// </summary>
    let ``_.owl#ConnectedStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#ConnectedStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#CoolingStateValue"></see>
    /// </summary>
    let ``_.owl#CoolingStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#CoolingStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#DetectedStateValue"></see>
    /// </summary>
    let ``_.owl#DetectedStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#DetectedStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#DisassociatingStateValue"></see>
    /// </summary>
    let ``_.owl#DisassociatingStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#DisassociatingStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#DisconnectedStateValue"></see>
    /// </summary>
    let ``_.owl#DisconnectedStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#DisconnectedStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#DownTripleStateValue"></see>
    /// </summary>
    let ``_.owl#DownTripleStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#DownTripleStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#EmittingMicrowavesStateValue"></see>
    /// </summary>
    let ``_.owl#EmittingMicrowavesStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#EmittingMicrowavesStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#EndProgrammedStateValue"></see>
    /// </summary>
    let ``_.owl#EndProgrammedStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#EndProgrammedStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#FailureStateValue"></see>
    /// </summary>
    let ``_.owl#FailureStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#FailureStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#FireUpStateValue"></see>
    /// </summary>
    let ``_.owl#FireUpStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#FireUpStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ForwardStateValue"></see>
    /// </summary>
    let ``_.owl#ForwardStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#ForwardStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#FreeStateValue"></see>
    /// </summary>
    let ``_.owl#FreeStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#FreeStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#HeatingStateValue"></see>
    /// </summary>
    let ``_.owl#HeatingStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#HeatingStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#IdleStateValue"></see>
    /// </summary>
    let ``_.owl#IdleStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#IdleStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MovingStateValue"></see>
    /// </summary>
    let ``_.owl#MovingStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#MovingStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#NeedingAuthenticationStateValue"></see>
    /// </summary>
    let ``_.owl#NeedingAuthenticationStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#NeedingAuthenticationStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#NoFailureStateValue"></see>
    /// </summary>
    let ``_.owl#NoFailureStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#NoFailureStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#NotDetectedStateValue"></see>
    /// </summary>
    let ``_.owl#NotDetectedStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#NotDetectedStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#NotEmittingMicrowavesStateValue"></see>
    /// </summary>
    let ``_.owl#NotEmittingMicrowavesStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#NotEmittingMicrowavesStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#NotMovingStateValue"></see>
    /// </summary>
    let ``_.owl#NotMovingStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#NotMovingStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#NotPresentState"></see>
    /// </summary>
    let ``_.owl#NotPresentState`` =
        Namespaced_IRI.parse _namespace_name ".owl#NotPresentState" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#NotProgrammedStateValue"></see>
    /// </summary>
    let ``_.owl#NotProgrammedStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#NotProgrammedStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#OccupiedStateValue"></see>
    /// </summary>
    let ``_.owl#OccupiedStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#OccupiedStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#OffStateValue"></see>
    /// </summary>
    let ``_.owl#OffStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#OffStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#OnStateValue"></see>
    /// </summary>
    let ``_.owl#OnStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#OnStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#OpenStateValue"></see>
    /// </summary>
    let ``_.owl#OpenStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#OpenStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PauseStateValue"></see>
    /// </summary>
    let ``_.owl#PauseStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#PauseStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PhonoStateValue"></see>
    /// </summary>
    let ``_.owl#PhonoStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#PhonoStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PlayStateValue"></see>
    /// </summary>
    let ``_.owl#PlayStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#PlayStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PresentStateValue"></see>
    /// </summary>
    let ``_.owl#PresentStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#PresentStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ProgramInterruptedStateValue"></see>
    /// </summary>
    let ``_.owl#ProgramInterruptedStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#ProgramInterruptedStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ProgrammedAndWaitingToStartStateValue"></see>
    /// </summary>
    let ``_.owl#ProgrammedAndWaitingToStartStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#ProgrammedAndWaitingToStartStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ProgrammedStateValue"></see>
    /// </summary>
    let ``_.owl#ProgrammedStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#ProgrammedStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#RestTripleStateValue"></see>
    /// </summary>
    let ``_.owl#RestTripleStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#RestTripleStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#RewindStateValue"></see>
    /// </summary>
    let ``_.owl#RewindStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#RewindStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#RinseHoldStateValue"></see>
    /// </summary>
    let ``_.owl#RinseHoldStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#RinseHoldStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#RunningStateValue"></see>
    /// </summary>
    let ``_.owl#RunningStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#RunningStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StandByStateValue"></see>
    /// </summary>
    let ``_.owl#StandByStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#StandByStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StopStateValue"></see>
    /// </summary>
    let ``_.owl#StopStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#StopStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SuperCoolingStateValue"></see>
    /// </summary>
    let ``_.owl#SuperCoolingStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#SuperCoolingStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SuperFreezingStateValue"></see>
    /// </summary>
    let ``_.owl#SuperFreezingStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#SuperFreezingStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SuperHeatingStateValue"></see>
    /// </summary>
    let ``_.owl#SuperHeatingStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#SuperHeatingStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#Tape1StateValue"></see>
    /// </summary>
    let ``_.owl#Tape1StateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#Tape1StateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#Tape2StateValue"></see>
    /// </summary>
    let ``_.owl#Tape2StateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#Tape2StateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#TunerStateValue"></see>
    /// </summary>
    let ``_.owl#TunerStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#TunerStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#UpTripleStateValue"></see>
    /// </summary>
    let ``_.owl#UpTripleStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#UpTripleStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl"></see>
    /// </summary>
    let ``_.owl`` = Namespaced_IRI.parse _namespace_name ".owl" |> NamespacedName

    /// <summary>
    /// System that provides security about access
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#AccessControlSystem"></see></summary>
    let ``_.owl#AccessControlSystem`` =
        Namespaced_IRI.parse _namespace_name ".owl#AccessControlSystem" |> NamespacedName

    /// <summary>
    /// Security system for detecting dangerous situation and intrusion
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#SecuritySystem"></see></summary>
    let ``_.owl#SecuritySystem`` =
        Namespaced_IRI.parse _namespace_name ".owl#SecuritySystem" |> NamespacedName

    /// <summary>
    /// System that detects the presence of fire
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#FireSystem"></see></summary>
    let ``_.owl#FireSystem`` =
        Namespaced_IRI.parse _namespace_name ".owl#FireSystem" |> NamespacedName

    /// <summary>
    /// System that detects the presence of flood
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#FloodSystem"></see></summary>
    let ``_.owl#FloodSystem`` =
        Namespaced_IRI.parse _namespace_name ".owl#FloodSystem" |> NamespacedName

    /// <summary>
    /// System that detects the presence of gas
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#GasSystem"></see></summary>
    let ``_.owl#GasSystem`` =
        Namespaced_IRI.parse _namespace_name ".owl#GasSystem" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#Acoustic"></see>
    /// </summary>
    let ``_.owl#Acoustic`` =
        Namespaced_IRI.parse _namespace_name ".owl#Acoustic" |> NamespacedName

    /// <summary>
    /// Indicates in which building environment is contained an object, e.g. the lamp5 isIn Kitchen
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#isIn"></see></summary>
    let ``_.owl#isIn`` =
        Namespaced_IRI.parse _namespace_name ".owl#isIn" |> NamespacedName

    /// <summary>
    /// Utility that provides electricity
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#ElectricalSystem"></see></summary>
    let ``_.owl#ElectricalSystem`` =
        Namespaced_IRI.parse _namespace_name ".owl#ElectricalSystem" |> NamespacedName

    /// <summary>
    /// A mechanism that puts something into automatic action
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Actuator"></see></summary>
    let ``_.owl#Actuator`` =
        Namespaced_IRI.parse _namespace_name ".owl#Actuator" |> NamespacedName

    /// <summary>
    /// A mechanism that controls the interaction with the electrical system
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Control"></see></summary>
    let ``_.owl#Control`` =
        Namespaced_IRI.parse _namespace_name ".owl#Control" |> NamespacedName

    /// <summary>
    /// System that provides artificial light
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Lighting"></see></summary>
    let ``_.owl#Lighting`` =
        Namespaced_IRI.parse _namespace_name ".owl#Lighting" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PowerDelivery"></see>
    /// </summary>
    let ``_.owl#PowerDelivery`` =
        Namespaced_IRI.parse _namespace_name ".owl#PowerDelivery" |> NamespacedName

    /// <summary>
    /// Class for grouping all electrically powered sensors
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Sensor"></see></summary>
    let ``_.owl#Sensor`` =
        Namespaced_IRI.parse _namespace_name ".owl#Sensor" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#DiscreteValue"></see>
    /// </summary>
    let ``_.owl#DiscreteValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#DiscreteValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ActiveEnergyMeasurementFunctionality"></see>
    /// </summary>
    let ``_.owl#ActiveEnergyMeasurementFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#ActiveEnergyMeasurementFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#EnergyMeasurementFunctionality"></see>
    /// </summary>
    let ``_.owl#EnergyMeasurementFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#EnergyMeasurementFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ActiveEnergyMeasurementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#ActiveEnergyMeasurementNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#ActiveEnergyMeasurementNotificationFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#EnergyMeasurementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#EnergyMeasurementNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#EnergyMeasurementNotificationFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ActiveEnergyStateValue"></see>
    /// </summary>
    let ``_.owl#ActiveEnergyStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#ActiveEnergyStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ContinuousValue"></see>
    /// </summary>
    let ``_.owl#ContinuousValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#ContinuousValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ChannelStateValue"></see>
    /// </summary>
    let ``_.owl#ChannelStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#ChannelStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PressureStateValue"></see>
    /// </summary>
    let ``_.owl#PressureStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#PressureStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#TemperatureStateValue"></see>
    /// </summary>
    let ``_.owl#TemperatureStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#TemperatureStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#FlowRateStateValue"></see>
    /// </summary>
    let ``_.owl#FlowRateStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#FlowRateStateValue" |> NamespacedName

    /// <summary>
    /// Value for the Shade position state, the shade position can be expressed as position=closedLimitx(255-level)/255, where with level 0 the shade is closed and with level 255 the shade is completely open. Derives from ZigBee HA specifications.
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#ShadeStateValue"></see></summary>
    let ``_.owl#ShadeStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#ShadeStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#HumidityStateValue"></see>
    /// </summary>
    let ``_.owl#HumidityStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#HumidityStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#CurrentStateValue"></see>
    /// </summary>
    let ``_.owl#CurrentStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#CurrentStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#LevelStateValue"></see>
    /// </summary>
    let ``_.owl#LevelStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#LevelStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ReactiveEnergyStateValue"></see>
    /// </summary>
    let ``_.owl#ReactiveEnergyStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#ReactiveEnergyStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ActivePowerMeasurementFunctionality"></see>
    /// </summary>
    let ``_.owl#ActivePowerMeasurementFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#ActivePowerMeasurementFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PowerMeasurementFunctionality"></see>
    /// </summary>
    let ``_.owl#PowerMeasurementFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#PowerMeasurementFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ActivePowerMeasurementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#ActivePowerMeasurementNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#ActivePowerMeasurementNotificationFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ElectricPowerMeasurementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#ElectricPowerMeasurementNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#ElectricPowerMeasurementNotificationFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ActivePowerMeasurementState"></see>
    /// </summary>
    let ``_.owl#ActivePowerMeasurementState`` =
        Namespaced_IRI.parse _namespace_name ".owl#ActivePowerMeasurementState" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ElectricPowerMeasurementState"></see>
    /// </summary>
    let ``_.owl#ElectricPowerMeasurementState`` =
        Namespaced_IRI.parse _namespace_name ".owl#ElectricPowerMeasurementState" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ActivePowerMeter"></see>
    /// </summary>
    let ``_.owl#ActivePowerMeter`` =
        Namespaced_IRI.parse _namespace_name ".owl#ActivePowerMeter" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PowerMeter"></see>
    /// </summary>
    let ``_.owl#PowerMeter`` =
        Namespaced_IRI.parse _namespace_name ".owl#PowerMeter" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ActivePowerStateValue"></see>
    /// </summary>
    let ``_.owl#ActivePowerStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#ActivePowerStateValue" |> NamespacedName

    /// <summary>
    /// A system that keeps air cool and dry
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#AirConditioningSystem"></see></summary>
    let ``_.owl#AirConditioningSystem`` =
        Namespaced_IRI.parse _namespace_name ".owl#AirConditioningSystem" |> NamespacedName

    /// <summary>
    /// The thermostat request notification, requires a device having the thermostat control functionality to increase, set or decrease the current temperature. Derives from ZigBee HA (slightly modified...)
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#ThermostatNotificationFunctionality"></see></summary>
    let ``_.owl#ThermostatNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#ThermostatNotificationFunctionality" |> NamespacedName

    /// <summary>
    /// Provide functionalities to controllable things
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#hasFunctionality"></see></summary>
    let ``_.owl#hasFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#hasFunctionality" |> NamespacedName

    /// <summary>
    /// Functionality: turn on - turn off
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#OnOffFunctionality"></see></summary>
    let ``_.owl#OnOffFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#OnOffFunctionality" |> NamespacedName

    /// <summary>
    /// Heating Ventilating and Air Conditioning system
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#HVACSystem"></see></summary>
    let ``_.owl#HVACSystem`` =
        Namespaced_IRI.parse _namespace_name ".owl#HVACSystem" |> NamespacedName

    /// <summary>
    /// State: on - off
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#OnOffState"></see></summary>
    let ``_.owl#OnOffState`` =
        Namespaced_IRI.parse _namespace_name ".owl#OnOffState" |> NamespacedName

    /// <summary>
    /// Provide the actual state to controllable things
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#hasState"></see></summary>
    let ``_.owl#hasState`` =
        Namespaced_IRI.parse _namespace_name ".owl#hasState" |> NamespacedName

    /// <summary>
    /// Notification: on - off
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#OnOffNotificationFunctionality"></see></summary>
    let ``_.owl#OnOffNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#OnOffNotificationFunctionality" |> NamespacedName

    /// <summary>
    /// Functionalities for the regulation of temperature
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#ThermostatControlFunctionality"></see></summary>
    let ``_.owl#ThermostatControlFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#ThermostatControlFunctionality" |> NamespacedName

    /// <summary>
    /// The Pressure Sensor device measures and periodically reports the pressure of a liquid (typically water)
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#PressureSensor"></see></summary>
    let ``_.owl#PressureSensor`` =
        Namespaced_IRI.parse _namespace_name ".owl#PressureSensor" |> NamespacedName

    /// <summary>
    /// The Pump device is a pump that may have variable speed. It may have optional built-in sensors and a regulation mechanism. It is typically used for pumping water. Derives from ZigBee HA specifications.
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Pump"></see></summary>
    let ``_.owl#Pump`` =
        Namespaced_IRI.parse _namespace_name ".owl#Pump" |> NamespacedName

    /// <summary>
    /// The Pump device controller can control a Pump device
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#PumpController"></see></summary>
    let ``_.owl#PumpController`` =
        Namespaced_IRI.parse _namespace_name ".owl#PumpController" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#VentilatingSystem"></see>
    /// </summary>
    let ``_.owl#VentilatingSystem`` =
        Namespaced_IRI.parse _namespace_name ".owl#VentilatingSystem" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#Thermostat"></see>
    /// </summary>
    let ``_.owl#Thermostat`` =
        Namespaced_IRI.parse _namespace_name ".owl#Thermostat" |> NamespacedName

    /// <summary>
    /// Utility to warm a building
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#HeatingSystem"></see></summary>
    let ``_.owl#HeatingSystem`` =
        Namespaced_IRI.parse _namespace_name ".owl#HeatingSystem" |> NamespacedName

    /// <summary>
    /// The Flow  Sensor device measures and periodically reports the flow rate of a liquid (typically water)
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#SingleFlowSensor"></see></summary>
    let ``_.owl#SingleFlowSensor`` =
        Namespaced_IRI.parse _namespace_name ".owl#SingleFlowSensor" |> NamespacedName

    /// <summary>
    /// The Heating and Cooling Unit device can heat or cool a space in a house. It is not mandatory to provide both functionalities. It may be an indoor air handler. Derives from ZigBee HA specifications
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#HeatingAndCoolingUnit"></see></summary>
    let ``_.owl#HeatingAndCoolingUnit`` =
        Namespaced_IRI.parse _namespace_name ".owl#HeatingAndCoolingUnit" |> NamespacedName

    /// <summary>
    /// A clock that wakes sleeper at preset time
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#AlarmClock"></see></summary>
    let ``_.owl#AlarmClock`` =
        Namespaced_IRI.parse _namespace_name ".owl#AlarmClock" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#Clock"></see>
    /// </summary>
    let ``_.owl#Clock`` =
        Namespaced_IRI.parse _namespace_name ".owl#Clock" |> NamespacedName

    /// <summary>
    /// A machine for performing calculations automatically, work and play
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Computer"></see></summary>
    let ``_.owl#Computer`` =
        Namespaced_IRI.parse _namespace_name ".owl#Computer" |> NamespacedName

    /// <summary>
    /// A diversion that holds the attention
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Entertainment"></see></summary>
    let ``_.owl#Entertainment`` =
        Namespaced_IRI.parse _namespace_name ".owl#Entertainment" |> NamespacedName

    /// <summary>
    /// Appliances for communicate
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Communication"></see></summary>
    let ``_.owl#Communication`` =
        Namespaced_IRI.parse _namespace_name ".owl#Communication" |> NamespacedName

    /// <summary>
    /// A device for creating a current of air
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Fan"></see></summary>
    let ``_.owl#Fan`` =
        Namespaced_IRI.parse _namespace_name ".owl#Fan" |> NamespacedName

    /// <summary>
    /// Output device that prints
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Printer"></see></summary>
    let ``_.owl#Printer`` =
        Namespaced_IRI.parse _namespace_name ".owl#Printer" |> NamespacedName

    /// <summary>
    /// A kitchen appliance for brewing coffee automatically
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#CoffeeMaker"></see></summary>
    let ``_.owl#CoffeeMaker`` =
        Namespaced_IRI.parse _namespace_name ".owl#CoffeeMaker" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#AlertNotification"></see>
    /// </summary>
    let ``_.owl#AlertNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#AlertNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ParametricNotification"></see>
    /// </summary>
    let ``_.owl#ParametricNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#ParametricNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#AlertNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#AlertNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#AlertNotificationFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#hasNotification"></see>
    /// </summary>
    let ``_.owl#hasNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#hasNotification" |> NamespacedName

    /// <summary>
    /// Discrete notification with exactly one values
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#SingleValuedNotificationFunctionality"></see></summary>
    let ``_.owl#SingleValuedNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#SingleValuedNotificationFunctionality" |> NamespacedName

    /// <summary>
    /// Electronic device that answers the telephone and records messages
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#AnsweringMachine"></see></summary>
    let ``_.owl#AnsweringMachine`` =
        Namespaced_IRI.parse _namespace_name ".owl#AnsweringMachine" |> NamespacedName

    /// <summary>
    /// Appliance that send text and document
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Fax"></see></summary>
    let ``_.owl#Fax`` =
        Namespaced_IRI.parse _namespace_name ".owl#Fax" |> NamespacedName

    /// <summary>
    /// A telephonic intercommunication system linking different rooms in a building
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Interphone"></see></summary>
    let ``_.owl#Interphone`` =
        Namespaced_IRI.parse _namespace_name ".owl#Interphone" |> NamespacedName

    /// <summary>
    /// Appliance to comunicate with other person
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Phone"></see></summary>
    let ``_.owl#Phone`` =
        Namespaced_IRI.parse _namespace_name ".owl#Phone" |> NamespacedName

    /// <summary>
    /// System that provides security about intrusion
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#AntiIntrusionSystem"></see></summary>
    let ``_.owl#AntiIntrusionSystem`` =
        Namespaced_IRI.parse _namespace_name ".owl#AntiIntrusionSystem" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ApparentPowerMeasurementFunctionality"></see>
    /// </summary>
    let ``_.owl#ApparentPowerMeasurementFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#ApparentPowerMeasurementFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ApparentPowerMeasurementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#ApparentPowerMeasurementNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#ApparentPowerMeasurementNotificationFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ApparentPowerMeasurementState"></see>
    /// </summary>
    let ``_.owl#ApparentPowerMeasurementState`` =
        Namespaced_IRI.parse _namespace_name ".owl#ApparentPowerMeasurementState" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ApparentPowerMeter"></see>
    /// </summary>
    let ``_.owl#ApparentPowerMeter`` =
        Namespaced_IRI.parse _namespace_name ".owl#ApparentPowerMeter" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ApparentPowerStateValue"></see>
    /// </summary>
    let ``_.owl#ApparentPowerStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#ApparentPowerStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ApplianceCycleTimingNotification"></see>
    /// </summary>
    let ``_.owl#ApplianceCycleTimingNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#ApplianceCycleTimingNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#EndTimeChangedNotification"></see>
    /// </summary>
    let ``_.owl#EndTimeChangedNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#EndTimeChangedNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#RemainingTimeChangedNotification"></see>
    /// </summary>
    let ``_.owl#RemainingTimeChangedNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#RemainingTimeChangedNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StartTimeChangedNotification"></see>
    /// </summary>
    let ``_.owl#StartTimeChangedNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#StartTimeChangedNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ApplianceManagementFunctionality"></see>
    /// </summary>
    let ``_.owl#ApplianceManagementFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#ApplianceManagementFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#DeleteApplianceCommand"></see>
    /// </summary>
    let ``_.owl#DeleteApplianceCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#DeleteApplianceCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#hasCommand"></see>
    /// </summary>
    let ``_.owl#hasCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#hasCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#InstallApplianceCommand"></see>
    /// </summary>
    let ``_.owl#InstallApplianceCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#InstallApplianceCommand" |> NamespacedName

    /// <summary>
    /// Derives from the general cluster functionalities defined in ZigBee HA specifications
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#NetworkFunctionality"></see></summary>
    let ``_.owl#NetworkFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#NetworkFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#NonParametricNotification"></see>
    /// </summary>
    let ``_.owl#NonParametricNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#NonParametricNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PauseApplianceNotification"></see>
    /// </summary>
    let ``_.owl#PauseApplianceNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#PauseApplianceNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StartApplianceNotification"></see>
    /// </summary>
    let ``_.owl#StartApplianceNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#StartApplianceNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StopApplianceNotification"></see>
    /// </summary>
    let ``_.owl#StopApplianceNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#StopApplianceNotification" |> NamespacedName

    /// <summary>
    /// Durable goods for home or office use
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Appliances"></see></summary>
    let ``_.owl#Appliances`` =
        Namespaced_IRI.parse _namespace_name ".owl#Appliances" |> NamespacedName

    /// <summary>
    /// All building things that can be controlled by domotic system
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Controllable"></see></summary>
    let ``_.owl#Controllable`` =
        Namespaced_IRI.parse _namespace_name ".owl#Controllable" |> NamespacedName

    /// <summary>
    /// All plants of the house, e.g. Electrical system, Hydraulic system
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#HousePlants"></see></summary>
    let ``_.owl#HousePlants`` =
        Namespaced_IRI.parse _namespace_name ".owl#HousePlants" |> NamespacedName

    /// <summary>
    /// All the architectural elements that compose the environment
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Architectural"></see></summary>
    let ``_.owl#Architectural`` =
        Namespaced_IRI.parse _namespace_name ".owl#Architectural" |> NamespacedName

    /// <summary>
    /// All building things that can't be controlled by domotic system
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#UnControllable"></see></summary>
    let ``_.owl#UnControllable`` =
        Namespaced_IRI.parse _namespace_name ".owl#UnControllable" |> NamespacedName

    /// <summary>
    /// Furnishings that make a room or other area ready for occupancy
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Furniture"></see></summary>
    let ``_.owl#Furniture`` =
        Namespaced_IRI.parse _namespace_name ".owl#Furniture" |> NamespacedName

    /// <summary>
    /// Chair with a support on each side for arms
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Armchair"></see></summary>
    let ``_.owl#Armchair`` =
        Namespaced_IRI.parse _namespace_name ".owl#Armchair" |> NamespacedName

    /// <summary>
    /// A canopy made of canvas to shelter people or things from rain or sun.
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Awning"></see></summary>
    let ``_.owl#Awning`` =
        Namespaced_IRI.parse _namespace_name ".owl#Awning" |> NamespacedName

    /// <summary>
    /// A tall piece of furniture that provides storage space for clothes
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Wardrobe"></see></summary>
    let ``_.owl#Wardrobe`` =
        Namespaced_IRI.parse _namespace_name ".owl#Wardrobe" |> NamespacedName

    /// <summary>
    /// Confine to a small space.
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Closet"></see></summary>
    let ``_.owl#Closet`` =
        Namespaced_IRI.parse _namespace_name ".owl#Closet" |> NamespacedName

    /// <summary>
    /// An upholstered seat for more than one person
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Sofa"></see></summary>
    let ``_.owl#Sofa`` =
        Namespaced_IRI.parse _namespace_name ".owl#Sofa" |> NamespacedName

    /// <summary>
    /// A small room (or recess) or cabinet used for storage space
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Cupboard"></see></summary>
    let ``_.owl#Cupboard`` =
        Namespaced_IRI.parse _namespace_name ".owl#Cupboard" |> NamespacedName

    /// <summary>
    /// Shade object, the name includes an underscore sign only for distinguishing the name from the shade actuator, whose name is directly mapped from ZigBee
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Shade"></see></summary>
    let ``_.owl#Shade`` =
        Namespaced_IRI.parse _namespace_name ".owl#Shade" |> NamespacedName

    /// <summary>
    /// A seat for one person, with a support for the back.
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Chair"></see></summary>
    let ``_.owl#Chair`` =
        Namespaced_IRI.parse _namespace_name ".owl#Chair" |> NamespacedName

    /// <summary>
    /// Piece of furniture that provides a place to sleep.
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Bed"></see></summary>
    let ``_.owl#Bed`` =
        Namespaced_IRI.parse _namespace_name ".owl#Bed" |> NamespacedName

    /// <summary>
    /// A small table or stand placed at a bedside.
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Nightstand"></see></summary>
    let ``_.owl#Nightstand`` =
        Namespaced_IRI.parse _namespace_name ".owl#Nightstand" |> NamespacedName

    /// <summary>
    /// A hinged cover or screen for a window, usually fitted with louvers.
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Shutter"></see></summary>
    let ``_.owl#Shutter`` =
        Namespaced_IRI.parse _namespace_name ".owl#Shutter" |> NamespacedName

    /// <summary>
    /// A piece of furniture with a writing surface and usually drawers or other compartments
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Desk"></see></summary>
    let ``_.owl#Desk`` =
        Namespaced_IRI.parse _namespace_name ".owl#Desk" |> NamespacedName

    /// <summary>
    /// All the fixtures of a bathroom
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#SanitaryFixtures"></see></summary>
    let ``_.owl#SanitaryFixtures`` =
        Namespaced_IRI.parse _namespace_name ".owl#SanitaryFixtures" |> NamespacedName

    /// <summary>
    /// A boxlike container in a piece of furniture; made so as to slide in and out
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Drawer"></see></summary>
    let ``_.owl#Drawer`` =
        Namespaced_IRI.parse _namespace_name ".owl#Drawer" |> NamespacedName

    /// <summary>
    /// A piece of furniture having a smooth flat top that is usually supported by one or more vertical legs
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Table"></see></summary>
    let ``_.owl#Table`` =
        Namespaced_IRI.parse _namespace_name ".owl#Table" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#AssociateCommand"></see>
    /// </summary>
    let ``_.owl#AssociateCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#AssociateCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#NonParametricCommand"></see>
    /// </summary>
    let ``_.owl#NonParametricCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#NonParametricCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#VoidCommand"></see>
    /// </summary>
    let ``_.owl#VoidCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#VoidCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#AssociateFunctionality"></see>
    /// </summary>
    let ``_.owl#AssociateFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#AssociateFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#DisassociateCommand"></see>
    /// </summary>
    let ``_.owl#DisassociateCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#DisassociateCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#AssociatingDeviceNotification"></see>
    /// </summary>
    let ``_.owl#AssociatingDeviceNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#AssociatingDeviceNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ZWaveNotification"></see>
    /// </summary>
    let ``_.owl#ZWaveNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#ZWaveNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#AssociationNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#AssociationNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#AssociationNotificationFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#DisassociatingDeviceNotification"></see>
    /// </summary>
    let ``_.owl#DisassociatingDeviceNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#DisassociatingDeviceNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#IdleNotification"></see>
    /// </summary>
    let ``_.owl#IdleNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#IdleNotification" |> NamespacedName

    /// <summary>
    /// Derives from the general cluster functionalities defined in ZigBee HA specifications
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#NetworkNotificationFunctionality"></see></summary>
    let ``_.owl#NetworkNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#NetworkNotificationFunctionality" |> NamespacedName

    /// <summary>
    /// Association between a mobile uncontrollable object and its actuator
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#hasActuator"></see></summary>
    let ``_.owl#hasActuator`` =
        Namespaced_IRI.parse _namespace_name ".owl#hasActuator" |> NamespacedName

    /// <summary>
    /// A mechanism that allow automatic control about awning
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#AwningActuator"></see></summary>
    let ``_.owl#AwningActuator`` =
        Namespaced_IRI.parse _namespace_name ".owl#AwningActuator" |> NamespacedName

    /// <summary>
    /// Functionality: open - close
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#OpenCloseFunctionality"></see></summary>
    let ``_.owl#OpenCloseFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#OpenCloseFunctionality" |> NamespacedName

    /// <summary>
    /// State: open - close
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#OpenCloseState"></see></summary>
    let ``_.owl#OpenCloseState`` =
        Namespaced_IRI.parse _namespace_name ".owl#OpenCloseState" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MovementState"></see>
    /// </summary>
    let ``_.owl#MovementState`` =
        Namespaced_IRI.parse _namespace_name ".owl#MovementState" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#actuatorOf"></see>
    /// </summary>
    let ``_.owl#actuatorOf`` =
        Namespaced_IRI.parse _namespace_name ".owl#actuatorOf" |> NamespacedName

    /// <summary>
    /// Notification: open - close
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#OpenCloseNotificationFunctionality"></see></summary>
    let ``_.owl#OpenCloseNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#OpenCloseNotificationFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MovementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#MovementNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#MovementNotificationFunctionality" |> NamespacedName

    /// <summary>
    /// A mechanism that allow automatic opening and closing about window
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#WindowActuator"></see></summary>
    let ``_.owl#WindowActuator`` =
        Namespaced_IRI.parse _namespace_name ".owl#WindowActuator" |> NamespacedName

    /// <summary>
    /// A mechanism that allow automatic opening and closing about door
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#DoorActuator"></see></summary>
    let ``_.owl#DoorActuator`` =
        Namespaced_IRI.parse _namespace_name ".owl#DoorActuator" |> NamespacedName

    /// <summary>
    /// A mechanism that allow automatic opening and closing about gate
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#GateActuator"></see></summary>
    let ``_.owl#GateActuator`` =
        Namespaced_IRI.parse _namespace_name ".owl#GateActuator" |> NamespacedName

    /// <summary>
    /// The Shade Actuator device provides the ability to open or close window coverings, including setting partially open or partially closed states. This device type includes roller shades, drapes and tilt-only blinds actuators. Derives from ZigBee HA specifications (Shade device)
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#ShadeActuator"></see></summary>
    let ``_.owl#ShadeActuator`` =
        Namespaced_IRI.parse _namespace_name ".owl#ShadeActuator" |> NamespacedName

    /// <summary>
    /// A mechanism that allow automatic control about shutter
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#ShutterActuator"></see></summary>
    let ``_.owl#ShutterActuator`` =
        Namespaced_IRI.parse _namespace_name ".owl#ShutterActuator" |> NamespacedName

    /// <summary>
    /// Components manufactured by Bticino
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#BTicinoComponent"></see></summary>
    let ``_.owl#BTicinoComponent`` =
        Namespaced_IRI.parse _namespace_name ".owl#BTicinoComponent" |> NamespacedName

    /// <summary>
    /// The address of the component
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#physicalAddress"></see></summary>
    let ``_.owl#physicalAddress`` =
        Namespaced_IRI.parse _namespace_name ".owl#physicalAddress" |> NamespacedName

    /// <summary>
    /// The category of the component
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#physicalType"></see></summary>
    let ``_.owl#physicalType`` =
        Namespaced_IRI.parse _namespace_name ".owl#physicalType" |> NamespacedName

    /// <summary>
    /// The manufacturers of the domotic component
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#NetworkComponent"></see></summary>
    let ``_.owl#NetworkComponent`` =
        Namespaced_IRI.parse _namespace_name ".owl#NetworkComponent" |> NamespacedName

    /// <summary>
    /// Emulated component
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#EliteComponent"></see></summary>
    let ``_.owl#EliteComponent`` =
        Namespaced_IRI.parse _namespace_name ".owl#EliteComponent" |> NamespacedName

    /// <summary>
    /// Components manufactured by Konnex
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#KonnexComponent"></see></summary>
    let ``_.owl#KonnexComponent`` =
        Namespaced_IRI.parse _namespace_name ".owl#KonnexComponent" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ZigBeeComponent"></see>
    /// </summary>
    let ``_.owl#ZigBeeComponent`` =
        Namespaced_IRI.parse _namespace_name ".owl#ZigBeeComponent" |> NamespacedName

    /// <summary>
    /// A BTIcino Gateway
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#BTicinoGateway"></see></summary>
    let ``_.owl#BTicinoGateway`` =
        Namespaced_IRI.parse _namespace_name ".owl#BTicinoGateway" |> NamespacedName

    /// <summary>
    /// A Konnex Gateway
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#KonnexGateway"></see></summary>
    let ``_.owl#KonnexGateway`` =
        Namespaced_IRI.parse _namespace_name ".owl#KonnexGateway" |> NamespacedName

    /// <summary>
    /// A software emulator of a network level to be used for simulating devices not available in the real world
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#EliteGateway"></see></summary>
    let ``_.owl#EliteGateway`` =
        Namespaced_IRI.parse _namespace_name ".owl#EliteGateway" |> NamespacedName

    /// <summary>
    /// A platform projecting from the wall of a building and surrounded by a balustrade or railing or parapet
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Balcony"></see></summary>
    let ``_.owl#Balcony`` =
        Namespaced_IRI.parse _namespace_name ".owl#Balcony" |> NamespacedName

    /// <summary>
    /// The horizontal architectural component of a building
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Horizontal"></see></summary>
    let ``_.owl#Horizontal`` =
        Namespaced_IRI.parse _namespace_name ".owl#Horizontal" |> NamespacedName

    /// <summary>
    /// The overhead upper surface of a room
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Ceiling"></see></summary>
    let ``_.owl#Ceiling`` =
        Namespaced_IRI.parse _namespace_name ".owl#Ceiling" |> NamespacedName

    /// <summary>
    /// The inside lower horizontal surface of a room
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Floor"></see></summary>
    let ``_.owl#Floor`` =
        Namespaced_IRI.parse _namespace_name ".owl#Floor" |> NamespacedName

    /// <summary>
    /// Outdoor area adjoining a residence
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Terrace"></see></summary>
    let ``_.owl#Terrace`` =
        Namespaced_IRI.parse _namespace_name ".owl#Terrace" |> NamespacedName

    /// <summary>
    /// A room of the building
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Room"></see></summary>
    let ``_.owl#Room`` =
        Namespaced_IRI.parse _namespace_name ".owl#Room" |> NamespacedName

    /// <summary>
    /// A relatively large open container that you fill with water and use to wash the body
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Bathtub"></see></summary>
    let ``_.owl#Bathtub`` =
        Namespaced_IRI.parse _namespace_name ".owl#Bathtub" |> NamespacedName

    /// <summary>
    /// A basin for washing genitals and anal area
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Bidet"></see></summary>
    let ``_.owl#Bidet`` =
        Namespaced_IRI.parse _namespace_name ".owl#Bidet" |> NamespacedName

    /// <summary>
    /// A plumbing fixture that sprays water over you
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Shower"></see></summary>
    let ``_.owl#Shower`` =
        Namespaced_IRI.parse _namespace_name ".owl#Shower" |> NamespacedName

    /// <summary>
    /// A basin for washing the hands
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Washbasin"></see></summary>
    let ``_.owl#Washbasin`` =
        Namespaced_IRI.parse _namespace_name ".owl#Washbasin" |> NamespacedName

    /// <summary>
    /// A plumbing fixture for defecation and urination
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#WaterCloset"></see></summary>
    let ``_.owl#WaterCloset`` =
        Namespaced_IRI.parse _namespace_name ".owl#WaterCloset" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#BatteryLevelNotification"></see>
    /// </summary>
    let ``_.owl#BatteryLevelNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#BatteryLevelNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#BatteryLevelNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#BatteryLevelNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#BatteryLevelNotificationFunctionality" |> NamespacedName

    /// <summary>
    /// Notification of continuous values
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#ContinuousNotificationFunctionality"></see></summary>
    let ``_.owl#ContinuousNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#ContinuousNotificationFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#BlueStateValue"></see>
    /// </summary>
    let ``_.owl#BlueStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#BlueStateValue" |> NamespacedName

    /// <summary>
    /// Sealed vessel where water is warm up
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Boiler"></see></summary>
    let ``_.owl#Boiler`` =
        Namespaced_IRI.parse _namespace_name ".owl#Boiler" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#HeatingApplianceState"></see>
    /// </summary>
    let ``_.owl#HeatingApplianceState`` =
        Namespaced_IRI.parse _namespace_name ".owl#HeatingApplianceState" |> NamespacedName

    /// <summary>
    /// Major household appliances.
    ///
    /// It mus be noticed that the functionality modeling uses existential quantifiers for functionalities that can be optional, this is only for the sake of easier interpretation and should be improved in future releases
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#WhiteGoods"></see></summary>
    let ``_.owl#WhiteGoods`` =
        Namespaced_IRI.parse _namespace_name ".owl#WhiteGoods" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SuperHeatingNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#SuperHeatingNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#SuperHeatingNotificationFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SuperHeatingFunctionality"></see>
    /// </summary>
    let ``_.owl#SuperHeatingFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#SuperHeatingFunctionality" |> NamespacedName

    /// <summary>
    /// A utensil for cooking
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Cooker"></see></summary>
    let ``_.owl#Cooker`` =
        Namespaced_IRI.parse _namespace_name ".owl#Cooker" |> NamespacedName

    /// <summary>
    /// Electric refrigerator in which food is frozen and stored for long periods of time
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#DeepFreezer"></see></summary>
    let ``_.owl#DeepFreezer`` =
        Namespaced_IRI.parse _namespace_name ".owl#DeepFreezer" |> NamespacedName

    /// <summary>
    /// A home appliance for washing clothes and linens automatically
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#WashingMachine"></see></summary>
    let ``_.owl#WashingMachine`` =
        Namespaced_IRI.parse _namespace_name ".owl#WashingMachine" |> NamespacedName

    /// <summary>
    /// Kitchen appliance used for baking or roasting
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Oven"></see></summary>
    let ``_.owl#Oven`` =
        Namespaced_IRI.parse _namespace_name ".owl#Oven" |> NamespacedName

    /// <summary>
    /// A refrigerator in which the coolant is pumped around by an electric motor
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Fridge"></see></summary>
    let ``_.owl#Fridge`` =
        Namespaced_IRI.parse _namespace_name ".owl#Fridge" |> NamespacedName

    /// <summary>
    /// A machine for washing dishes
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Dishwasher"></see></summary>
    let ``_.owl#Dishwasher`` =
        Namespaced_IRI.parse _namespace_name ".owl#Dishwasher" |> NamespacedName

    /// <summary>
    /// Heating apparatus
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Stove"></see></summary>
    let ``_.owl#Stove`` =
        Namespaced_IRI.parse _namespace_name ".owl#Stove" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#BrightnessStateValue"></see>
    /// </summary>
    let ``_.owl#BrightnessStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#BrightnessStateValue" |> NamespacedName

    /// <summary>
    /// Small household electrical entertainment appliances
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#BrownGoods"></see></summary>
    let ``_.owl#BrownGoods`` =
        Namespaced_IRI.parse _namespace_name ".owl#BrownGoods" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#Building"></see>
    /// </summary>
    let ``_.owl#Building`` =
        Namespaced_IRI.parse _namespace_name ".owl#Building" |> NamespacedName

    /// <summary>
    /// Indicates which object are contained in a building environment, e.g. the kitchen contains Lamp1,Lamp2...
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#contains"></see></summary>
    let ``_.owl#contains`` =
        Namespaced_IRI.parse _namespace_name ".owl#contains" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#Flat"></see>
    /// </summary>
    let ``_.owl#Flat`` =
        Namespaced_IRI.parse _namespace_name ".owl#Flat" |> NamespacedName

    /// <summary>
    /// A physical environment in which people lives, e.g. kitchen, bathroom
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#BuildingEnvironment"></see></summary>
    let ``_.owl#BuildingEnvironment`` =
        Namespaced_IRI.parse _namespace_name ".owl#BuildingEnvironment" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#Storey"></see>
    /// </summary>
    let ``_.owl#Storey`` =
        Namespaced_IRI.parse _namespace_name ".owl#Storey" |> NamespacedName

    /// <summary>
    /// The garden of the building
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Garden"></see></summary>
    let ``_.owl#Garden`` =
        Namespaced_IRI.parse _namespace_name ".owl#Garden" |> NamespacedName

    /// <summary>
    /// The garage of the buinding
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Garage"></see></summary>
    let ``_.owl#Garage`` =
        Namespaced_IRI.parse _namespace_name ".owl#Garage" |> NamespacedName

    /// <summary>
    /// All things that creates a Building, it is intended as root of all building components
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#BuildingThing"></see></summary>
    let ``_.owl#BuildingThing`` =
        Namespaced_IRI.parse _namespace_name ".owl#BuildingThing" |> NamespacedName

    /// <summary>
    /// A monostable electrical switch operated by pressing a button
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Button"></see></summary>
    let ``_.owl#Button`` =
        Namespaced_IRI.parse _namespace_name ".owl#Button" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ButtonNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#ButtonNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#ButtonNotificationFunctionality" |> NamespacedName

    /// <summary>
    /// The Scene Selector device is capable of setting up and selecting scenes on other devices, including group of devices. It derives from ZigBee HA specifications.
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#SceneSelector"></see></summary>
    let ``_.owl#SceneSelector`` =
        Namespaced_IRI.parse _namespace_name ".owl#SceneSelector" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SingleScenarioControl"></see>
    /// </summary>
    let ``_.owl#SingleScenarioControl`` =
        Namespaced_IRI.parse _namespace_name ".owl#SingleScenarioControl" |> NamespacedName

    /// <summary>
    /// A round handle used to adjust continuous amplitude, e.g. volume
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Knob"></see></summary>
    let ``_.owl#Knob`` =
        Namespaced_IRI.parse _namespace_name ".owl#Knob" |> NamespacedName

    /// <summary>
    /// The Shade Controller device can control the level of a shade, derives from ZigBee HA specifications
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#ShadeController"></see></summary>
    let ``_.owl#ShadeController`` =
        Namespaced_IRI.parse _namespace_name ".owl#ShadeController" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ToggleRelay"></see>
    /// </summary>
    let ``_.owl#ToggleRelay`` =
        Namespaced_IRI.parse _namespace_name ".owl#ToggleRelay" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#RemoteControl"></see>
    /// </summary>
    let ``_.owl#RemoteControl`` =
        Namespaced_IRI.parse _namespace_name ".owl#RemoteControl" |> NamespacedName

    /// <summary>
    /// Bi-stable control consisting of a mechanical or electrical or electronic device for making or breaking or changing the connections in a circuit
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Switch"></see></summary>
    let ``_.owl#Switch`` =
        Namespaced_IRI.parse _namespace_name ".owl#Switch" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ButtonMNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#ButtonMNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#ButtonMNotificationFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ReleasedMNotification"></see>
    /// </summary>
    let ``_.owl#ReleasedMNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#ReleasedMNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PressedMNotification"></see>
    /// </summary>
    let ``_.owl#PressedMNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#PressedMNotification" |> NamespacedName

    /// <summary>
    /// Discrete notification with exactly two values
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#DoubleValuedNotificationFunctionality"></see></summary>
    let ``_.owl#DoubleValuedNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#DoubleValuedNotificationFunctionality" |> NamespacedName

    /// <summary>
    /// An electric signaling device, such as a doorbell, that makes a buzzing sound.
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Buzzer"></see></summary>
    let ``_.owl#Buzzer`` =
        Namespaced_IRI.parse _namespace_name ".owl#Buzzer" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#CameraPictureImageControlFunctionality"></see>
    /// </summary>
    let ``_.owl#CameraPictureImageControlFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#CameraPictureImageControlFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#IncreaseColorCommand"></see>
    /// </summary>
    let ``_.owl#IncreaseColorCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#IncreaseColorCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#IncreaseContrastCommand"></see>
    /// </summary>
    let ``_.owl#IncreaseContrastCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#IncreaseContrastCommand" |> NamespacedName

    /// <summary>
    /// Functionalities continuous in time or space
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#ContinuousControlFunctionality"></see></summary>
    let ``_.owl#ContinuousControlFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#ContinuousControlFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#DecreaseLuminosityCommand"></see>
    /// </summary>
    let ``_.owl#DecreaseLuminosityCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#DecreaseLuminosityCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#IncreaseLuminosityCommand"></see>
    /// </summary>
    let ``_.owl#IncreaseLuminosityCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#IncreaseLuminosityCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#DecreaseContrastCommand"></see>
    /// </summary>
    let ``_.owl#DecreaseContrastCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#DecreaseContrastCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#DecreaseColorCommand"></see>
    /// </summary>
    let ``_.owl#DecreaseColorCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#DecreaseColorCommand" |> NamespacedName

    /// <summary>
    /// Functionalities for the regulation of timer
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#TimeRegulationFunctionality"></see></summary>
    let ``_.owl#TimeRegulationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#TimeRegulationFunctionality" |> NamespacedName

    /// <summary>
    /// Models the capability of controlling the speed of a cooling/heating fan. Derives from ZigBee HA
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#FanControlFunctionality"></see></summary>
    let ``_.owl#FanControlFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#FanControlFunctionality" |> NamespacedName

    /// <summary>
    /// Level control functionality, used for allowing devices to be controlled in a continuous manner, derives from ZigBee Home Automation specifications
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#LevelControlFunctionality"></see></summary>
    let ``_.owl#LevelControlFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#LevelControlFunctionality" |> NamespacedName

    /// <summary>
    /// Functionalities for the regulation of shutter
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#ShutterRegulationFunctionality"></see></summary>
    let ``_.owl#ShutterRegulationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#ShutterRegulationFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#CameraPictureQualityControlFunctionality"></see>
    /// </summary>
    let ``_.owl#CameraPictureQualityControlFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#CameraPictureQualityControlFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ColorControlFunctionality"></see>
    /// </summary>
    let ``_.owl#ColorControlFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#ColorControlFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#CameraPictureZoomPanControlFunctionality"></see>
    /// </summary>
    let ``_.owl#CameraPictureZoomPanControlFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#CameraPictureZoomPanControlFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#TunerFunctionality"></see>
    /// </summary>
    let ``_.owl#TunerFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#TunerFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#IncreaseQualityCommand"></see>
    /// </summary>
    let ``_.owl#IncreaseQualityCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#IncreaseQualityCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#DecreaseQualityCommand"></see>
    /// </summary>
    let ``_.owl#DecreaseQualityCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#DecreaseQualityCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PanRightCommand"></see>
    /// </summary>
    let ``_.owl#PanRightCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#PanRightCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PanDownCommand"></see>
    /// </summary>
    let ``_.owl#PanDownCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#PanDownCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PanLeftCommand"></see>
    /// </summary>
    let ``_.owl#PanLeftCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#PanLeftCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ZoomOutCommand"></see>
    /// </summary>
    let ``_.owl#ZoomOutCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#ZoomOutCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ZoomInCommand"></see>
    /// </summary>
    let ``_.owl#ZoomInCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#ZoomInCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PanUpCommand"></see>
    /// </summary>
    let ``_.owl#PanUpCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#PanUpCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ChangedDesiredTemperatureNotification"></see>
    /// </summary>
    let ``_.owl#ChangedDesiredTemperatureNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#ChangedDesiredTemperatureNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#DeleteSceneNotification"></see>
    /// </summary>
    let ``_.owl#DeleteSceneNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#DeleteSceneNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StoreSceneNotification"></see>
    /// </summary>
    let ``_.owl#StoreSceneNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#StoreSceneNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PressureMeasurementMNotification"></see>
    /// </summary>
    let ``_.owl#PressureMeasurementMNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#PressureMeasurementMNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#HumidityMeasurementMNotification"></see>
    /// </summary>
    let ``_.owl#HumidityMeasurementMNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#HumidityMeasurementMNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#LeaveGroupNotification"></see>
    /// </summary>
    let ``_.owl#LeaveGroupNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#LeaveGroupNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#JoinGroupNotification"></see>
    /// </summary>
    let ``_.owl#JoinGroupNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#JoinGroupNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#LevelControlNotification"></see>
    /// </summary>
    let ``_.owl#LevelControlNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#LevelControlNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#TemperatureMeasurementMNotification"></see>
    /// </summary>
    let ``_.owl#TemperatureMeasurementMNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#TemperatureMeasurementMNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#FlowRateMeasurementMNotification"></see>
    /// </summary>
    let ``_.owl#FlowRateMeasurementMNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#FlowRateMeasurementMNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ChannelControlNotification"></see>
    /// </summary>
    let ``_.owl#ChannelControlNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#ChannelControlNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ParametricLevelNotification"></see>
    /// </summary>
    let ``_.owl#ParametricLevelNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#ParametricLevelNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ClimateScheduleFunctionality"></see>
    /// </summary>
    let ``_.owl#ClimateScheduleFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#ClimateScheduleFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SetDailyClimateScheduleCommand"></see>
    /// </summary>
    let ``_.owl#SetDailyClimateScheduleCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#SetDailyClimateScheduleCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SetClimateScheduleCommand"></see>
    /// </summary>
    let ``_.owl#SetClimateScheduleCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#SetClimateScheduleCommand" |> NamespacedName

    /// <summary>
    /// Discrete functionalities with exactly two values
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#DoubleValuedFunctionality"></see></summary>
    let ``_.owl#DoubleValuedFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#DoubleValuedFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ClimateScheduleNotification"></see>
    /// </summary>
    let ``_.owl#ClimateScheduleNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#ClimateScheduleNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ClimateScheduleNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#ClimateScheduleNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#ClimateScheduleNotificationFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#WeeklyClimateScheduleNotification"></see>
    /// </summary>
    let ``_.owl#WeeklyClimateScheduleNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#WeeklyClimateScheduleNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#DailyClimateScheduleNotification"></see>
    /// </summary>
    let ``_.owl#DailyClimateScheduleNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#DailyClimateScheduleNotification" |> NamespacedName

    /// <summary>
    /// Notification of fixed values
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#DiscreteNotificationFunctionality"></see></summary>
    let ``_.owl#DiscreteNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#DiscreteNotificationFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ClimateScheduleQueryFunctionality"></see>
    /// </summary>
    let ``_.owl#ClimateScheduleQueryFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#ClimateScheduleQueryFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#GetClimateScheduleCommand"></see>
    /// </summary>
    let ``_.owl#GetClimateScheduleCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#GetClimateScheduleCommand" |> NamespacedName

    /// <summary>
    /// Capability of a controllable building thing that must reply to an interrogation about its state
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#QueryFunctionality"></see></summary>
    let ``_.owl#QueryFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#QueryFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ClimateScheduleState"></see>
    /// </summary>
    let ``_.owl#ClimateScheduleState`` =
        Namespaced_IRI.parse _namespace_name ".owl#ClimateScheduleState" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#hasStateValue"></see>
    /// </summary>
    let ``_.owl#hasStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#hasStateValue" |> NamespacedName

    /// <summary>
    /// States not continuous, with fixed values
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#DiscreteState"></see></summary>
    let ``_.owl#DiscreteState`` =
        Namespaced_IRI.parse _namespace_name ".owl#DiscreteState" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#CloseCommand"></see>
    /// </summary>
    let ``_.owl#CloseCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#CloseCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StopHeatingCoolingCommand"></see>
    /// </summary>
    let ``_.owl#StopHeatingCoolingCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#StopHeatingCoolingCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#GetCommand"></see>
    /// </summary>
    let ``_.owl#GetCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#GetCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#DeleteGroupCommand"></see>
    /// </summary>
    let ``_.owl#DeleteGroupCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#DeleteGroupCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PreviousTrackCommand"></see>
    /// </summary>
    let ``_.owl#PreviousTrackCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#PreviousTrackCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SetHourCommand"></see>
    /// </summary>
    let ``_.owl#SetHourCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#SetHourCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StandBy"></see>
    /// </summary>
    let ``_.owl#StandBy`` =
        Namespaced_IRI.parse _namespace_name ".owl#StandBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#OffCommand"></see>
    /// </summary>
    let ``_.owl#OffCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#OffCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SetTimeoutCommand"></see>
    /// </summary>
    let ``_.owl#SetTimeoutCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#SetTimeoutCommand" |> NamespacedName

    /// <summary>
    /// the command for getting the occupancy state of a given room/environment
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#GetOccupancyCommand"></see></summary>
    let ``_.owl#GetOccupancyCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#GetOccupancyCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#RewindCommand"></see>
    /// </summary>
    let ``_.owl#RewindCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#RewindCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PlayCommand"></see>
    /// </summary>
    let ``_.owl#PlayCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#PlayCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#NextTrackCommand"></see>
    /// </summary>
    let ``_.owl#NextTrackCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#NextTrackCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#GoToTrackCommand"></see>
    /// </summary>
    let ``_.owl#GoToTrackCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#GoToTrackCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ForwardCommand"></see>
    /// </summary>
    let ``_.owl#ForwardCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#ForwardCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StoreSceneCommand"></see>
    /// </summary>
    let ``_.owl#StoreSceneCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#StoreSceneCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#OnFlashingCommand"></see>
    /// </summary>
    let ``_.owl#OnFlashingCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#OnFlashingCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#UpCommand"></see>
    /// </summary>
    let ``_.owl#UpCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#UpCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#GetPressureCommand"></see>
    /// </summary>
    let ``_.owl#GetPressureCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#GetPressureCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#OnCommand"></see>
    /// </summary>
    let ``_.owl#OnCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#OnCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StopPlayingCommand"></see>
    /// </summary>
    let ``_.owl#StopPlayingCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#StopPlayingCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#GetFlowRateCommand"></see>
    /// </summary>
    let ``_.owl#GetFlowRateCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#GetFlowRateCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SetChannelCommand"></see>
    /// </summary>
    let ``_.owl#SetChannelCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#SetChannelCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#DownCommand"></see>
    /// </summary>
    let ``_.owl#DownCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#DownCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#RestCommand"></see>
    /// </summary>
    let ``_.owl#RestCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#RestCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SetCommand"></see>
    /// </summary>
    let ``_.owl#SetCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#SetCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StoreGroupCommand"></see>
    /// </summary>
    let ``_.owl#StoreGroupCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#StoreGroupCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#HeatCommand"></see>
    /// </summary>
    let ``_.owl#HeatCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#HeatCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SetMinutesCommand"></see>
    /// </summary>
    let ``_.owl#SetMinutesCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#SetMinutesCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#GetRelativeHumidityCommand"></see>
    /// </summary>
    let ``_.owl#GetRelativeHumidityCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#GetRelativeHumidityCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SetDesiredTemperature"></see>
    /// </summary>
    let ``_.owl#SetDesiredTemperature`` =
        Namespaced_IRI.parse _namespace_name ".owl#SetDesiredTemperature" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#GrabPictureCommand"></see>
    /// </summary>
    let ``_.owl#GrabPictureCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#GrabPictureCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SetSpeedCommand"></see>
    /// </summary>
    let ``_.owl#SetSpeedCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#SetSpeedCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#CoolCommand"></see>
    /// </summary>
    let ``_.owl#CoolCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#CoolCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StepDownCommand"></see>
    /// </summary>
    let ``_.owl#StepDownCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#StepDownCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SetSecondsCommand"></see>
    /// </summary>
    let ``_.owl#SetSecondsCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#SetSecondsCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StepUpCommand"></see>
    /// </summary>
    let ``_.owl#StepUpCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#StepUpCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PauseCommand"></see>
    /// </summary>
    let ``_.owl#PauseCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#PauseCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SetVolumeCommand"></see>
    /// </summary>
    let ``_.owl#SetVolumeCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#SetVolumeCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#TimedOnCommand"></see>
    /// </summary>
    let ``_.owl#TimedOnCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#TimedOnCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SpeedDownCommand"></see>
    /// </summary>
    let ``_.owl#SpeedDownCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#SpeedDownCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ToggleCommand"></see>
    /// </summary>
    let ``_.owl#ToggleCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#ToggleCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#OpenCommand"></see>
    /// </summary>
    let ``_.owl#OpenCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#OpenCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#GetTemperatureCommand"></see>
    /// </summary>
    let ``_.owl#GetTemperatureCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#GetTemperatureCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#OffFlashingCommand"></see>
    /// </summary>
    let ``_.owl#OffFlashingCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#OffFlashingCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#DeleteSceneCommand"></see>
    /// </summary>
    let ``_.owl#DeleteSceneCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#DeleteSceneCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SpeedUpCommand"></see>
    /// </summary>
    let ``_.owl#SpeedUpCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#SpeedUpCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#CloseNetworkCommand"></see>
    /// </summary>
    let ``_.owl#CloseNetworkCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#CloseNetworkCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#Co2MeasurementFunctionality"></see>
    /// </summary>
    let ``_.owl#Co2MeasurementFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#Co2MeasurementFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#GetCo2ConcentrationCommand"></see>
    /// </summary>
    let ``_.owl#GetCo2ConcentrationCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#GetCo2ConcentrationCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#Co2MeasurementNotification"></see>
    /// </summary>
    let ``_.owl#Co2MeasurementNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#Co2MeasurementNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#Co2MeasurementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#Co2MeasurementNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#Co2MeasurementNotificationFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#Co2MeasurementState"></see>
    /// </summary>
    let ``_.owl#Co2MeasurementState`` =
        Namespaced_IRI.parse _namespace_name ".owl#Co2MeasurementState" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#Co2MeasurementStateValue"></see>
    /// </summary>
    let ``_.owl#Co2MeasurementStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#Co2MeasurementStateValue" |> NamespacedName

    /// <summary>
    /// States continuous in time or space
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#ContinuousState"></see></summary>
    let ``_.owl#ContinuousState`` =
        Namespaced_IRI.parse _namespace_name ".owl#ContinuousState" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#Co2Sensor"></see>
    /// </summary>
    let ``_.owl#Co2Sensor`` =
        Namespaced_IRI.parse _namespace_name ".owl#Co2Sensor" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ColdWaterM3MeasurementNotification"></see>
    /// </summary>
    let ``_.owl#ColdWaterM3MeasurementNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#ColdWaterM3MeasurementNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SetColorRGBCommand"></see>
    /// </summary>
    let ``_.owl#SetColorRGBCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#SetColorRGBCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SetColorHSBCommand"></see>
    /// </summary>
    let ``_.owl#SetColorHSBCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#SetColorHSBCommand" |> NamespacedName

    /// <summary>
    /// The Color Dimmable Light device can be switched on and off, and its luminance, hue and saturation levels may be controlled, derives from ZigBee HA specifications
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#ColorDimmableLight"></see></summary>
    let ``_.owl#ColorDimmableLight`` =
        Namespaced_IRI.parse _namespace_name ".owl#ColorDimmableLight" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ColorNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#ColorNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#ColorNotificationFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ColorState"></see>
    /// </summary>
    let ``_.owl#ColorState`` =
        Namespaced_IRI.parse _namespace_name ".owl#ColorState" |> NamespacedName

    /// <summary>
    /// The Dimmable Light device is a light that can be switched on and off, and whose luminance level may be controlled, derives from ZigBee HA specifications
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#DimmableLight"></see></summary>
    let ``_.owl#DimmableLight`` =
        Namespaced_IRI.parse _namespace_name ".owl#DimmableLight" |> NamespacedName

    /// <summary>
    /// The Color Dimmer Switch device can turn a light on and off, and control the luminance, hue and saturation levels of a multicolor light, derives from ZigBee HA specifications
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#ColorDimmerSwitch"></see></summary>
    let ``_.owl#ColorDimmerSwitch`` =
        Namespaced_IRI.parse _namespace_name ".owl#ColorDimmerSwitch" |> NamespacedName

    /// <summary>
    /// Association between a controller and the controlled object
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#controlledObject"></see></summary>
    let ``_.owl#controlledObject`` =
        Namespaced_IRI.parse _namespace_name ".owl#controlledObject" |> NamespacedName

    /// <summary>
    /// Switch for controlling dimmable lights, derives from ZigBee HA specifications
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#DimmerSwitch"></see></summary>
    let ``_.owl#DimmerSwitch`` =
        Namespaced_IRI.parse _namespace_name ".owl#DimmerSwitch" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ColorHSBNotification"></see>
    /// </summary>
    let ``_.owl#ColorHSBNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#ColorHSBNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ColorRGBNotification"></see>
    /// </summary>
    let ``_.owl#ColorRGBNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#ColorRGBNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ColorStateHSB"></see>
    /// </summary>
    let ``_.owl#ColorStateHSB`` =
        Namespaced_IRI.parse _namespace_name ".owl#ColorStateHSB" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#HueStateValue"></see>
    /// </summary>
    let ``_.owl#HueStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#HueStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SaturationStateValue"></see>
    /// </summary>
    let ``_.owl#SaturationStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#SaturationStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ColorStateRGB"></see>
    /// </summary>
    let ``_.owl#ColorStateRGB`` =
        Namespaced_IRI.parse _namespace_name ".owl#ColorStateRGB" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#GreenStateValue"></see>
    /// </summary>
    let ``_.owl#GreenStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#GreenStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#RedStateValue"></see>
    /// </summary>
    let ``_.owl#RedStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#RedStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#Command"></see>
    /// </summary>
    let ``_.owl#Command`` =
        Namespaced_IRI.parse _namespace_name ".owl#Command" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ConfigurationFunctionality"></see>
    /// </summary>
    let ``_.owl#ConfigurationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#ConfigurationFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#GetConfigurationCommand"></see>
    /// </summary>
    let ``_.owl#GetConfigurationCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#GetConfigurationCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ConnectionState"></see>
    /// </summary>
    let ``_.owl#ConnectionState`` =
        Namespaced_IRI.parse _namespace_name ".owl#ConnectionState" |> NamespacedName

    /// <summary>
    /// Discrete states with exactly two values
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#DoubleValuedState"></see></summary>
    let ``_.owl#DoubleValuedState`` =
        Namespaced_IRI.parse _namespace_name ".owl#DoubleValuedState" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ConsumedWaterStateValue"></see>
    /// </summary>
    let ``_.owl#ConsumedWaterStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#ConsumedWaterStateValue" |> NamespacedName

    /// <summary>
    /// Capability of a controllable building thing that can receive commands
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#ControlFunctionality"></see></summary>
    let ``_.owl#ControlFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#ControlFunctionality" |> NamespacedName

    /// <summary>
    /// Functionalities not continuous, with fixed values
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#DiscreteControlFunctionality"></see></summary>
    let ``_.owl#DiscreteControlFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#DiscreteControlFunctionality" |> NamespacedName

    /// <summary>
    /// Capability of a controllable building thing that notifies information,e.g.door sensor notifies "open"-"close"
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#NotificationFunctionality"></see></summary>
    let ``_.owl#NotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#NotificationFunctionality" |> NamespacedName

    /// <summary>
    /// Models the states of the controllable objects
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#State"></see></summary>
    let ``_.owl#State`` =
        Namespaced_IRI.parse _namespace_name ".owl#State" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#unitOfMeasure"></see>
    /// </summary>
    let ``_.owl#unitOfMeasure`` =
        Namespaced_IRI.parse _namespace_name ".owl#unitOfMeasure" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StateValue"></see>
    /// </summary>
    let ``_.owl#StateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#StateValue" |> NamespacedName

    /// <summary>
    /// Capability of a controllable building thing
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Functionality"></see></summary>
    let ``_.owl#Functionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#Functionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#CoolingApplianceState"></see>
    /// </summary>
    let ``_.owl#CoolingApplianceState`` =
        Namespaced_IRI.parse _namespace_name ".owl#CoolingApplianceState" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#GenericApplianceState"></see>
    /// </summary>
    let ``_.owl#GenericApplianceState`` =
        Namespaced_IRI.parse _namespace_name ".owl#GenericApplianceState" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#CurrentMeasurementFunctionality"></see>
    /// </summary>
    let ``_.owl#CurrentMeasurementFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#CurrentMeasurementFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#CurrentMeasurementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#CurrentMeasurementNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#CurrentMeasurementNotificationFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#CurrentMeasurementState"></see>
    /// </summary>
    let ``_.owl#CurrentMeasurementState`` =
        Namespaced_IRI.parse _namespace_name ".owl#CurrentMeasurementState" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#CurrentMeter"></see>
    /// </summary>
    let ``_.owl#CurrentMeter`` =
        Namespaced_IRI.parse _namespace_name ".owl#CurrentMeter" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ElectricityMeter"></see>
    /// </summary>
    let ``_.owl#ElectricityMeter`` =
        Namespaced_IRI.parse _namespace_name ".owl#ElectricityMeter" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#CycleTimingControlFunctionality"></see>
    /// </summary>
    let ``_.owl#CycleTimingControlFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#CycleTimingControlFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SetEndTimeCommand"></see>
    /// </summary>
    let ``_.owl#SetEndTimeCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#SetEndTimeCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SetStartTimeCommand"></see>
    /// </summary>
    let ``_.owl#SetStartTimeCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#SetStartTimeCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SetRemainingTimeCommand"></see>
    /// </summary>
    let ``_.owl#SetRemainingTimeCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#SetRemainingTimeCommand" |> NamespacedName

    /// <summary>
    /// Discrete functionalities with exactly three values
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#TripleValuedFunctionality"></see></summary>
    let ``_.owl#TripleValuedFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#TripleValuedFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#CycleTimingNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#CycleTimingNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#CycleTimingNotificationFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#TripleValuedNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#TripleValuedNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#TripleValuedNotificationFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#CycleTimingQueryFunctionality"></see>
    /// </summary>
    let ``_.owl#CycleTimingQueryFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#CycleTimingQueryFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#GetEndTimeCommand"></see>
    /// </summary>
    let ``_.owl#GetEndTimeCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#GetEndTimeCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#GetRemainingTimeCommand"></see>
    /// </summary>
    let ``_.owl#GetRemainingTimeCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#GetRemainingTimeCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#GetStartTimeCommand"></see>
    /// </summary>
    let ``_.owl#GetStartTimeCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#GetStartTimeCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#DecreaseVolumeCommand"></see>
    /// </summary>
    let ``_.owl#DecreaseVolumeCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#DecreaseVolumeCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#FreezingApplianceState"></see>
    /// </summary>
    let ``_.owl#FreezingApplianceState`` =
        Namespaced_IRI.parse _namespace_name ".owl#FreezingApplianceState" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SuperFreezingNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#SuperFreezingNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#SuperFreezingNotificationFunctionality" |> NamespacedName

    /// <summary>
    /// Describes the ability of a device to start/stop a super freezing cycle, tipically defined for fridges, refrigerators and freezers. Derives from the energy@home zigbee extension and from the EN50523 standard
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#SuperFreezingFunctionality"></see></summary>
    let ``_.owl#SuperFreezingFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#SuperFreezingFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ParametricCommand"></see>
    /// </summary>
    let ``_.owl#ParametricCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#ParametricCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SelectSourceCommand"></see>
    /// </summary>
    let ``_.owl#SelectSourceCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#SelectSourceCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#GetRelativeHumidityMCommand"></see>
    /// </summary>
    let ``_.owl#GetRelativeHumidityMCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#GetRelativeHumidityMCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#GetPressureMCommand"></see>
    /// </summary>
    let ``_.owl#GetPressureMCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#GetPressureMCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#GetLuminanceCommand"></see>
    /// </summary>
    let ``_.owl#GetLuminanceCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#GetLuminanceCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#GetTemperatureMCommand"></see>
    /// </summary>
    let ``_.owl#GetTemperatureMCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#GetTemperatureMCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#GetFlowRateMCommand"></see>
    /// </summary>
    let ``_.owl#GetFlowRateMCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#GetFlowRateMCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#NetworkNotification"></see>
    /// </summary>
    let ``_.owl#NetworkNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#NetworkNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#DeviceAssociationState"></see>
    /// </summary>
    let ``_.owl#DeviceAssociationState`` =
        Namespaced_IRI.parse _namespace_name ".owl#DeviceAssociationState" |> NamespacedName

    /// <summary>
    /// Discrete states with exactly three values
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#TripleValuedState"></see></summary>
    let ``_.owl#TripleValuedState`` =
        Namespaced_IRI.parse _namespace_name ".owl#TripleValuedState" |> NamespacedName

    /// <summary>
    /// Derives from the general cluster functionalities defined in ZigBee HA specifications
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#SceneNotificationFunctionality"></see></summary>
    let ``_.owl#SceneNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#SceneNotificationFunctionality" |> NamespacedName

    /// <summary>
    /// Derives from the general cluster functionalities defined in ZigBee HA specifications
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#SceneFunctionality"></see></summary>
    let ``_.owl#SceneFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#SceneFunctionality" |> NamespacedName

    /// <summary>
    /// Derives from the general cluster functionalities defined in ZigBee HA specifications
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#GroupNotificationFunctionality"></see></summary>
    let ``_.owl#GroupNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#GroupNotificationFunctionality" |> NamespacedName

    /// <summary>
    /// Derives from the general cluster functionalities defined in ZigBee HA specifications
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#GroupFunctionality"></see></summary>
    let ``_.owl#GroupFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#GroupFunctionality" |> NamespacedName

    /// <summary>
    /// Lamp that varies the level of illumination
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#DimmerLamp"></see></summary>
    let ``_.owl#DimmerLamp`` =
        Namespaced_IRI.parse _namespace_name ".owl#DimmerLamp" |> NamespacedName

    /// <summary>
    /// Functionalities for the regulation of ligth
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#LightRegulationFunctionality"></see></summary>
    let ``_.owl#LightRegulationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#LightRegulationFunctionality" |> NamespacedName

    /// <summary>
    /// An artificial source of visible illumination
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Lamp"></see></summary>
    let ``_.owl#Lamp`` =
        Namespaced_IRI.parse _namespace_name ".owl#Lamp" |> NamespacedName

    /// <summary>
    /// Models the state of the object that illuminates
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#LightIntensityState"></see></summary>
    let ``_.owl#LightIntensityState`` =
        Namespaced_IRI.parse _namespace_name ".owl#LightIntensityState" |> NamespacedName

    /// <summary>
    /// Notification functionality for controlling continuously adjustable device, e.g. dimmers, derives from ZigBee Home Automation specifications
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#SimpleLevelNotificationFunctionality"></see></summary>
    let ``_.owl#SimpleLevelNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#SimpleLevelNotificationFunctionality" |> NamespacedName

    /// <summary>
    /// Simple lamp that can be just turn on or turn off
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#SimpleLamp"></see></summary>
    let ``_.owl#SimpleLamp`` =
        Namespaced_IRI.parse _namespace_name ".owl#SimpleLamp" |> NamespacedName

    /// <summary>
    /// Level control switch, derives from the ZigBee Home Automation specification
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#LevelControlSwitch"></see></summary>
    let ``_.owl#LevelControlSwitch`` =
        Namespaced_IRI.parse _namespace_name ".owl#LevelControlSwitch" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#DisableGasCommand"></see>
    /// </summary>
    let ``_.owl#DisableGasCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#DisableGasCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#DiscoveryActiveNotification"></see>
    /// </summary>
    let ``_.owl#DiscoveryActiveNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#DiscoveryActiveNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#HueNotification"></see>
    /// </summary>
    let ``_.owl#HueNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#HueNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#DiscoveryFunctionality"></see>
    /// </summary>
    let ``_.owl#DiscoveryFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#DiscoveryFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StartDiscoveryCommand"></see>
    /// </summary>
    let ``_.owl#StartDiscoveryCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#StartDiscoveryCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StopDiscoveryCommand"></see>
    /// </summary>
    let ``_.owl#StopDiscoveryCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#StopDiscoveryCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#DiscoveryIdleNotification"></see>
    /// </summary>
    let ``_.owl#DiscoveryIdleNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#DiscoveryIdleNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#DiscoveryNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#DiscoveryNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#DiscoveryNotificationFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#DiscoveryState"></see>
    /// </summary>
    let ``_.owl#DiscoveryState`` =
        Namespaced_IRI.parse _namespace_name ".owl#DiscoveryState" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#DiscreteOutputFunctionality"></see>
    /// </summary>
    let ``_.owl#DiscreteOutputFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#DiscreteOutputFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StartStopPauseNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#StartStopPauseNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#StartStopPauseNotificationFunctionality" |> NamespacedName

    /// <summary>
    /// A functionality describing the ability of a device, tipically an appliance, to start, stop or pause its current cycle.
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#StartStopPauseFunctionality"></see></summary>
    let ``_.owl#StartStopPauseFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#StartStopPauseFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#DisplayCommand"></see>
    /// </summary>
    let ``_.owl#DisplayCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#DisplayCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#DisplayFunctionality"></see>
    /// </summary>
    let ``_.owl#DisplayFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#DisplayFunctionality" |> NamespacedName

    /// <summary>
    /// A swinging or sliding barrier that will close the entrance to a room or building.
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Door"></see></summary>
    let ``_.owl#Door`` =
        Namespaced_IRI.parse _namespace_name ".owl#Door" |> NamespacedName

    /// <summary>
    /// Association between an object and its sensor
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#hasSensor"></see></summary>
    let ``_.owl#hasSensor`` =
        Namespaced_IRI.parse _namespace_name ".owl#hasSensor" |> NamespacedName

    /// <summary>
    /// Sensor that controls if a door is closed
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#DoorSensor"></see></summary>
    let ``_.owl#DoorSensor`` =
        Namespaced_IRI.parse _namespace_name ".owl#DoorSensor" |> NamespacedName

    /// <summary>
    /// An opening in a Wall
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#WallOpening"></see></summary>
    let ``_.owl#WallOpening`` =
        Namespaced_IRI.parse _namespace_name ".owl#WallOpening" |> NamespacedName

    /// <summary>
    /// A framework that contains a glass windowpane and is built into a wall or roof to admit light or air
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Window"></see></summary>
    let ``_.owl#Window`` =
        Namespaced_IRI.parse _namespace_name ".owl#Window" |> NamespacedName

    /// <summary>
    /// Association between a sensor and its sensed object
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#sensorOf"></see></summary>
    let ``_.owl#sensorOf`` =
        Namespaced_IRI.parse _namespace_name ".owl#sensorOf" |> NamespacedName

    /// <summary>
    /// Sensor that controls if a window is closed
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#WindowSensor"></see></summary>
    let ``_.owl#WindowSensor`` =
        Namespaced_IRI.parse _namespace_name ".owl#WindowSensor" |> NamespacedName

    /// <summary>
    /// Sensor that detects the presence of a living entity in the sensor's range
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#InfraredSensor"></see></summary>
    let ``_.owl#InfraredSensor`` =
        Namespaced_IRI.parse _namespace_name ".owl#InfraredSensor" |> NamespacedName

    /// <summary>
    /// Sensor that detects the presence of smoke
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#SmokeSensor"></see></summary>
    let ``_.owl#SmokeSensor`` =
        Namespaced_IRI.parse _namespace_name ".owl#SmokeSensor" |> NamespacedName

    /// <summary>
    /// Sensor that detects the presence of flood
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#FloodSensor"></see></summary>
    let ``_.owl#FloodSensor`` =
        Namespaced_IRI.parse _namespace_name ".owl#FloodSensor" |> NamespacedName

    /// <summary>
    /// The Occupancy Sensor device reports the occupancy state of an area. Derives from ZigBee HA specifications
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#OccupancySensor"></see></summary>
    let ``_.owl#OccupancySensor`` =
        Namespaced_IRI.parse _namespace_name ".owl#OccupancySensor" |> NamespacedName

    /// <summary>
    /// Camera of video surveillance
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#SurveillanceCamera"></see></summary>
    let ``_.owl#SurveillanceCamera`` =
        Namespaced_IRI.parse _namespace_name ".owl#SurveillanceCamera" |> NamespacedName

    /// <summary>
    /// Sensor that detects the presence of gas
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#GasSensor"></see></summary>
    let ``_.owl#GasSensor`` =
        Namespaced_IRI.parse _namespace_name ".owl#GasSensor" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#DoubleBed"></see>
    /// </summary>
    let ``_.owl#DoubleBed`` =
        Namespaced_IRI.parse _namespace_name ".owl#DoubleBed" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SingleBed"></see>
    /// </summary>
    let ``_.owl#SingleBed`` =
        Namespaced_IRI.parse _namespace_name ".owl#SingleBed" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PlayFunctionality"></see>
    /// </summary>
    let ``_.owl#PlayFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#PlayFunctionality" |> NamespacedName

    /// <summary>
    /// Discrete functionalities with exactly one value
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#SingleValuedFunctionality"></see></summary>
    let ``_.owl#SingleValuedFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#SingleValuedFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#Notification"></see>
    /// </summary>
    let ``_.owl#Notification`` =
        Namespaced_IRI.parse _namespace_name ".owl#Notification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#HeatingAndCoolingUnitState"></see>
    /// </summary>
    let ``_.owl#HeatingAndCoolingUnitState`` =
        Namespaced_IRI.parse _namespace_name ".owl#HeatingAndCoolingUnitState" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PlayState"></see>
    /// </summary>
    let ``_.owl#PlayState`` =
        Namespaced_IRI.parse _namespace_name ".owl#PlayState" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SourceSelectionState"></see>
    /// </summary>
    let ``_.owl#SourceSelectionState`` =
        Namespaced_IRI.parse _namespace_name ".owl#SourceSelectionState" |> NamespacedName

    /// <summary>
    /// Appliance thar read dvd
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Dvd"></see></summary>
    let ``_.owl#Dvd`` =
        Namespaced_IRI.parse _namespace_name ".owl#Dvd" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#OnOffStandbyNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#OnOffStandbyNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#OnOffStandbyNotificationFunctionality" |> NamespacedName

    /// <summary>
    /// Models the volume value
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#VolumeLevelState"></see></summary>
    let ``_.owl#VolumeLevelState`` =
        Namespaced_IRI.parse _namespace_name ".owl#VolumeLevelState" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StandByOnOffState"></see>
    /// </summary>
    let ``_.owl#StandByOnOffState`` =
        Namespaced_IRI.parse _namespace_name ".owl#StandByOnOffState" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#OnOffStandByFunctionality"></see>
    /// </summary>
    let ``_.owl#OnOffStandByFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#OnOffStandByFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PlayNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#PlayNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#PlayNotificationFunctionality" |> NamespacedName

    /// <summary>
    /// Functionalities for the regulation of volume
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#VolumeRegulationFunctionality"></see></summary>
    let ``_.owl#VolumeRegulationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#VolumeRegulationFunctionality" |> NamespacedName

    /// <summary>
    /// A communication system based on broadcasting electromagnetic waves
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Radio"></see></summary>
    let ``_.owl#Radio`` =
        Namespaced_IRI.parse _namespace_name ".owl#Radio" |> NamespacedName

    /// <summary>
    /// Equipment for the reproduction of sound with high fidelity
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#HiFi"></see></summary>
    let ``_.owl#HiFi`` =
        Namespaced_IRI.parse _namespace_name ".owl#HiFi" |> NamespacedName

    /// <summary>
    /// A receiver that displays television images
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Tv"></see></summary>
    let ``_.owl#Tv`` = Namespaced_IRI.parse _namespace_name ".owl#Tv" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#EchelonCommand"></see>
    /// </summary>
    let ``_.owl#EchelonCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#EchelonCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#NetworkSpecificCommand"></see>
    /// </summary>
    let ``_.owl#NetworkSpecificCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#NetworkSpecificCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#EchelonIlon100Gateway"></see>
    /// </summary>
    let ``_.owl#EchelonIlon100Gateway`` =
        Namespaced_IRI.parse _namespace_name ".owl#EchelonIlon100Gateway" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#EchelonNetworkComponent"></see>
    /// </summary>
    let ``_.owl#EchelonNetworkComponent`` =
        Namespaced_IRI.parse _namespace_name ".owl#EchelonNetworkComponent" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#EchelonIlon100Property"></see>
    /// </summary>
    let ``_.owl#EchelonIlon100Property`` =
        Namespaced_IRI.parse _namespace_name ".owl#EchelonIlon100Property" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#EchelonNotification"></see>
    /// </summary>
    let ``_.owl#EchelonNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#EchelonNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#NetworkSpecificNotification"></see>
    /// </summary>
    let ``_.owl#NetworkSpecificNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#NetworkSpecificNotification" |> NamespacedName

    /// <summary>
    /// Electrical Cooker
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#ElectricalCooker"></see></summary>
    let ``_.owl#ElectricalCooker`` =
        Namespaced_IRI.parse _namespace_name ".owl#ElectricalCooker" |> NamespacedName

    /// <summary>
    /// Gas Cooker
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#GasCooker"></see></summary>
    let ``_.owl#GasCooker`` =
        Namespaced_IRI.parse _namespace_name ".owl#GasCooker" |> NamespacedName

    /// <summary>
    /// A portable electric appliance for heating or cooking or keeping food warm
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Hotplate"></see></summary>
    let ``_.owl#Hotplate`` =
        Namespaced_IRI.parse _namespace_name ".owl#Hotplate" |> NamespacedName

    /// <summary>
    /// Electrical oven
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#ElectricalOven"></see></summary>
    let ``_.owl#ElectricalOven`` =
        Namespaced_IRI.parse _namespace_name ".owl#ElectricalOven" |> NamespacedName

    /// <summary>
    /// Microwave oven
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#MicrowaveOven"></see></summary>
    let ``_.owl#MicrowaveOven`` =
        Namespaced_IRI.parse _namespace_name ".owl#MicrowaveOven" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#Meter"></see>
    /// </summary>
    let ``_.owl#Meter`` =
        Namespaced_IRI.parse _namespace_name ".owl#Meter" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#EnableDisableGasFunctionality"></see>
    /// </summary>
    let ``_.owl#EnableDisableGasFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#EnableDisableGasFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#EnableGasCommand"></see>
    /// </summary>
    let ``_.owl#EnableGasCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#EnableGasCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#EnergyAndPowerMeter"></see>
    /// </summary>
    let ``_.owl#EnergyAndPowerMeter`` =
        Namespaced_IRI.parse _namespace_name ".owl#EnergyAndPowerMeter" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseActivePowerMeter"></see>
    /// </summary>
    let ``_.owl#SinglePhaseActivePowerMeter`` =
        Namespaced_IRI.parse _namespace_name ".owl#SinglePhaseActivePowerMeter" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseEnergyMeter"></see>
    /// </summary>
    let ``_.owl#SinglePhaseEnergyMeter`` =
        Namespaced_IRI.parse _namespace_name ".owl#SinglePhaseEnergyMeter" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#EnergyAndPowerMeteringLevelControllableOutput"></see>
    /// </summary>
    let ``_.owl#EnergyAndPowerMeteringLevelControllableOutput`` =
        Namespaced_IRI.parse _namespace_name ".owl#EnergyAndPowerMeteringLevelControllableOutput" |> NamespacedName

    /// <summary>
    /// Output device whose output level can be controlled continuously, by means of a level-control command (notification), derives from ZigBee HA specifications
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#LevelControllableOutput"></see></summary>
    let ``_.owl#LevelControllableOutput`` =
        Namespaced_IRI.parse _namespace_name ".owl#LevelControllableOutput" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseActiveEnergyMeter"></see>
    /// </summary>
    let ``_.owl#SinglePhaseActiveEnergyMeter`` =
        Namespaced_IRI.parse _namespace_name ".owl#SinglePhaseActiveEnergyMeter" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#EnergyMeasurementState"></see>
    /// </summary>
    let ``_.owl#EnergyMeasurementState`` =
        Namespaced_IRI.parse _namespace_name ".owl#EnergyMeasurementState" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#EnergyMeter"></see>
    /// </summary>
    let ``_.owl#EnergyMeter`` =
        Namespaced_IRI.parse _namespace_name ".owl#EnergyMeter" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#EnergyMeteringPowerOutlet"></see>
    /// </summary>
    let ``_.owl#EnergyMeteringPowerOutlet`` =
        Namespaced_IRI.parse _namespace_name ".owl#EnergyMeteringPowerOutlet" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MainsPowerOutlet"></see>
    /// </summary>
    let ``_.owl#MainsPowerOutlet`` =
        Namespaced_IRI.parse _namespace_name ".owl#MainsPowerOutlet" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#Entrance"></see>
    /// </summary>
    let ``_.owl#Entrance`` =
        Namespaced_IRI.parse _namespace_name ".owl#Entrance" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#EventNotification"></see>
    /// </summary>
    let ``_.owl#EventNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#EventNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#EventNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#EventNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#EventNotificationFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#EventsAndAlertsNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#EventsAndAlertsNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#EventsAndAlertsNotificationFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MultipleAlertNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#MultipleAlertNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#MultipleAlertNotificationFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MultipleEventNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#MultipleEventNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#MultipleEventNotificationFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#EventsAndAlertsQueryFunctionality"></see>
    /// </summary>
    let ``_.owl#EventsAndAlertsQueryFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#EventsAndAlertsQueryFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#GetEventsAndAlertsCommand"></see>
    /// </summary>
    let ``_.owl#GetEventsAndAlertsCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#GetEventsAndAlertsCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#FaultState"></see>
    /// </summary>
    let ``_.owl#FaultState`` =
        Namespaced_IRI.parse _namespace_name ".owl#FaultState" |> NamespacedName

    /// <summary>
    /// A barrier that serves to enclose an area
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Fence"></see></summary>
    let ``_.owl#Fence`` =
        Namespaced_IRI.parse _namespace_name ".owl#Fence" |> NamespacedName

    /// <summary>
    /// The vertical architectural component of a building
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Vertical"></see></summary>
    let ``_.owl#Vertical`` =
        Namespaced_IRI.parse _namespace_name ".owl#Vertical" |> NamespacedName

    /// <summary>
    /// An opening in a Fence
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#FenceOpening"></see></summary>
    let ``_.owl#FenceOpening`` =
        Namespaced_IRI.parse _namespace_name ".owl#FenceOpening" |> NamespacedName

    /// <summary>
    /// An architectural partition used to divide or enclose an area or to support another structure.
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Wall"></see></summary>
    let ``_.owl#Wall`` =
        Namespaced_IRI.parse _namespace_name ".owl#Wall" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#FireHeatCoolNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#FireHeatCoolNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#FireHeatCoolNotificationFunctionality" |> NamespacedName

    /// <summary>
    /// Lamp that emits light in sudden short or intermittent bursts
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#FlashingLamp"></see></summary>
    let ``_.owl#FlashingLamp`` =
        Namespaced_IRI.parse _namespace_name ".owl#FlashingLamp" |> NamespacedName

    /// <summary>
    /// Functionality to switch on and off an object with a given switching period
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#OnOffFlashingFunctionality"></see></summary>
    let ``_.owl#OnOffFlashingFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#OnOffFlashingFunctionality" |> NamespacedName

    /// <summary>
    /// Simple lamp that can be just turn on or turn off
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#OnOffLight"></see></summary>
    let ``_.owl#OnOffLight`` =
        Namespaced_IRI.parse _namespace_name ".owl#OnOffLight" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SensingState"></see>
    /// </summary>
    let ``_.owl#SensingState`` =
        Namespaced_IRI.parse _namespace_name ".owl#SensingState" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#FlowMeasurementFunctionality"></see>
    /// </summary>
    let ``_.owl#FlowMeasurementFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#FlowMeasurementFunctionality" |> NamespacedName

    /// <summary>
    /// The capability of measuring the humidity of a room
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#HumidityMeasurementFunctionality"></see></summary>
    let ``_.owl#HumidityMeasurementFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#HumidityMeasurementFunctionality" |> NamespacedName

    /// <summary>
    /// The capability of sensing the luminance of the environment in which a device is located accepts only the get command, with 1 parameter, i.e. the luminance value. Derives from ZigBee specifications
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#LightSensingFunctionality"></see></summary>
    let ``_.owl#LightSensingFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#LightSensingFunctionality" |> NamespacedName

    /// <summary>
    /// Functionality for getting the occupancy state of a given room
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#OccupancySensingFunctionality"></see></summary>
    let ``_.owl#OccupancySensingFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#OccupancySensingFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PictureGrabFunctionality"></see>
    /// </summary>
    let ``_.owl#PictureGrabFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#PictureGrabFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PressureMeasurementFunctionality"></see>
    /// </summary>
    let ``_.owl#PressureMeasurementFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#PressureMeasurementFunctionality" |> NamespacedName

    /// <summary>
    /// The capability of measuring temperatures
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#TemperatureMeasurementFunctionality"></see></summary>
    let ``_.owl#TemperatureMeasurementFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#TemperatureMeasurementFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#FlowMeasurementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#FlowMeasurementNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#FlowMeasurementNotificationFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#FlowRateMeasurementNotification"></see>
    /// </summary>
    let ``_.owl#FlowRateMeasurementNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#FlowRateMeasurementNotification" |> NamespacedName

    /// <summary>
    /// The notification for requesting humidity measurment...
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#HumidityMeasurementNotificationFunctionality"></see></summary>
    let ``_.owl#HumidityMeasurementNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#HumidityMeasurementNotificationFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PressureMeasurementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#PressureMeasurementNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#PressureMeasurementNotificationFunctionality" |> NamespacedName

    /// <summary>
    /// Notifies the measurment of a temperature, through a proper temperature sensor
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#TemperatureMeasurementNotificationFunctionality"></see></summary>
    let ``_.owl#TemperatureMeasurementNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#TemperatureMeasurementNotificationFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SimpleMovementNotification"></see>
    /// </summary>
    let ``_.owl#SimpleMovementNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#SimpleMovementNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#LevelStepUpNotification"></see>
    /// </summary>
    let ``_.owl#LevelStepUpNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#LevelStepUpNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#HumidityMeasurementNotification"></see>
    /// </summary>
    let ``_.owl#HumidityMeasurementNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#HumidityMeasurementNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#LevelStepDownNotification"></see>
    /// </summary>
    let ``_.owl#LevelStepDownNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#LevelStepDownNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#TemperatureMeasurementNotification"></see>
    /// </summary>
    let ``_.owl#TemperatureMeasurementNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#TemperatureMeasurementNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PressureMeasurementNotification"></see>
    /// </summary>
    let ``_.owl#PressureMeasurementNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#PressureMeasurementNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SimpleNoMovementNotification"></see>
    /// </summary>
    let ``_.owl#SimpleNoMovementNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#SimpleNoMovementNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#FlowRateState"></see>
    /// </summary>
    let ``_.owl#FlowRateState`` =
        Namespaced_IRI.parse _namespace_name ".owl#FlowRateState" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#HumidityMeasurementState"></see>
    /// </summary>
    let ``_.owl#HumidityMeasurementState`` =
        Namespaced_IRI.parse _namespace_name ".owl#HumidityMeasurementState" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#LevelState"></see>
    /// </summary>
    let ``_.owl#LevelState`` =
        Namespaced_IRI.parse _namespace_name ".owl#LevelState" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PressureState"></see>
    /// </summary>
    let ``_.owl#PressureState`` =
        Namespaced_IRI.parse _namespace_name ".owl#PressureState" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ShadeState"></see>
    /// </summary>
    let ``_.owl#ShadeState`` =
        Namespaced_IRI.parse _namespace_name ".owl#ShadeState" |> NamespacedName

    /// <summary>
    /// Models the temperature value
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#TemperatureState"></see></summary>
    let ``_.owl#TemperatureState`` =
        Namespaced_IRI.parse _namespace_name ".owl#TemperatureState" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#TunerState"></see>
    /// </summary>
    let ``_.owl#TunerState`` =
        Namespaced_IRI.parse _namespace_name ".owl#TunerState" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#FlowSensor"></see>
    /// </summary>
    let ``_.owl#FlowSensor`` =
        Namespaced_IRI.parse _namespace_name ".owl#FlowSensor" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ForwardNotification"></see>
    /// </summary>
    let ``_.owl#ForwardNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#ForwardNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#FrequencyMeasurementFunctionality"></see>
    /// </summary>
    let ``_.owl#FrequencyMeasurementFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#FrequencyMeasurementFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#GetFrequencyCommand"></see>
    /// </summary>
    let ``_.owl#GetFrequencyCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#GetFrequencyCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#FrequencyMeasurementNotification"></see>
    /// </summary>
    let ``_.owl#FrequencyMeasurementNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#FrequencyMeasurementNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#FrequencyMeasurementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#FrequencyMeasurementNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#FrequencyMeasurementNotificationFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#FrequencyMeasurementState"></see>
    /// </summary>
    let ``_.owl#FrequencyMeasurementState`` =
        Namespaced_IRI.parse _namespace_name ".owl#FrequencyMeasurementState" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#FrequencyStateValue"></see>
    /// </summary>
    let ``_.owl#FrequencyStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#FrequencyStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#FrequencyMeter"></see>
    /// </summary>
    let ``_.owl#FrequencyMeter`` =
        Namespaced_IRI.parse _namespace_name ".owl#FrequencyMeter" |> NamespacedName

    /// <summary>
    /// A functionality describing the ability of the device to start/stop a super cooling cycle (typical of fridges, freezers and refrigerators). This functionality is defined in the energy@home zigbee extension and in the EN50523 specification.
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#SuperCoolingFunctionality"></see></summary>
    let ``_.owl#SuperCoolingFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#SuperCoolingFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SuperCoolingNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#SuperCoolingNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#SuperCoolingNotificationFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#hasFloor"></see>
    /// </summary>
    let ``_.owl#hasFloor`` =
        Namespaced_IRI.parse _namespace_name ".owl#hasFloor" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#hasCeiling"></see>
    /// </summary>
    let ``_.owl#hasCeiling`` =
        Namespaced_IRI.parse _namespace_name ".owl#hasCeiling" |> NamespacedName

    /// <summary>
    /// Heater that combusts gas
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#GasHeater"></see></summary>
    let ``_.owl#GasHeater`` =
        Namespaced_IRI.parse _namespace_name ".owl#GasHeater" |> NamespacedName

    /// <summary>
    /// Device that heats water or supplies warmth
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Heater"></see></summary>
    let ``_.owl#Heater`` =
        Namespaced_IRI.parse _namespace_name ".owl#Heater" |> NamespacedName

    /// <summary>
    /// Heater that combusts gasoil
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#GasoilHeater"></see></summary>
    let ``_.owl#GasoilHeater`` =
        Namespaced_IRI.parse _namespace_name ".owl#GasoilHeater" |> NamespacedName

    /// <summary>
    /// Heater that combusts wood-pellet
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#PelletHeater"></see></summary>
    let ``_.owl#PelletHeater`` =
        Namespaced_IRI.parse _namespace_name ".owl#PelletHeater" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#GasM3MeasurementNotification"></see>
    /// </summary>
    let ``_.owl#GasM3MeasurementNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#GasM3MeasurementNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#GasMeasurementFunctionality"></see>
    /// </summary>
    let ``_.owl#GasMeasurementFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#GasMeasurementFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#GetConsumedM3Gas"></see>
    /// </summary>
    let ``_.owl#GetConsumedM3Gas`` =
        Namespaced_IRI.parse _namespace_name ".owl#GetConsumedM3Gas" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#GasMeasurementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#GasMeasurementNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#GasMeasurementNotificationFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#GasMeasurementState"></see>
    /// </summary>
    let ``_.owl#GasMeasurementState`` =
        Namespaced_IRI.parse _namespace_name ".owl#GasMeasurementState" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#GasStateValue"></see>
    /// </summary>
    let ``_.owl#GasStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#GasStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#GasMeter"></see>
    /// </summary>
    let ``_.owl#GasMeter`` =
        Namespaced_IRI.parse _namespace_name ".owl#GasMeter" |> NamespacedName

    /// <summary>
    /// A door-like movable barrier in a fence
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Gate"></see></summary>
    let ``_.owl#Gate`` =
        Namespaced_IRI.parse _namespace_name ".owl#Gate" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#Get1PhaseActiveEnergyCommand"></see>
    /// </summary>
    let ``_.owl#Get1PhaseActiveEnergyCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#Get1PhaseActiveEnergyCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#NonVoidCommand"></see>
    /// </summary>
    let ``_.owl#NonVoidCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#NonVoidCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#Get1PhaseActivePowerCommand"></see>
    /// </summary>
    let ``_.owl#Get1PhaseActivePowerCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#Get1PhaseActivePowerCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#Get1PhaseApparentPowerCommand"></see>
    /// </summary>
    let ``_.owl#Get1PhaseApparentPowerCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#Get1PhaseApparentPowerCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#Get1PhaseCurrentCommand"></see>
    /// </summary>
    let ``_.owl#Get1PhaseCurrentCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#Get1PhaseCurrentCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#Get1PhaseReactiveEnergyCommand"></see>
    /// </summary>
    let ``_.owl#Get1PhaseReactiveEnergyCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#Get1PhaseReactiveEnergyCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#Get1PhaseReactivePowerCommand"></see>
    /// </summary>
    let ``_.owl#Get1PhaseReactivePowerCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#Get1PhaseReactivePowerCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#Get1PhaseVoltageCommand"></see>
    /// </summary>
    let ``_.owl#Get1PhaseVoltageCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#Get1PhaseVoltageCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#Get3PhaseActiveEnergyCommand"></see>
    /// </summary>
    let ``_.owl#Get3PhaseActiveEnergyCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#Get3PhaseActiveEnergyCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#Get3PhaseActivePowerCommand"></see>
    /// </summary>
    let ``_.owl#Get3PhaseActivePowerCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#Get3PhaseActivePowerCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#Get3PhaseApparentPowerCommand"></see>
    /// </summary>
    let ``_.owl#Get3PhaseApparentPowerCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#Get3PhaseApparentPowerCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#Get3PhaseCurrentCommand"></see>
    /// </summary>
    let ``_.owl#Get3PhaseCurrentCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#Get3PhaseCurrentCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#Get3PhaseLLVoltageCommand"></see>
    /// </summary>
    let ``_.owl#Get3PhaseLLVoltageCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#Get3PhaseLLVoltageCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#Get3PhaseLNVoltageCommand"></see>
    /// </summary>
    let ``_.owl#Get3PhaseLNVoltageCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#Get3PhaseLNVoltageCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#Get3PhaseReactiveEnergyCommand"></see>
    /// </summary>
    let ``_.owl#Get3PhaseReactiveEnergyCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#Get3PhaseReactiveEnergyCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#Get3PhaseReactivePowerCommand"></see>
    /// </summary>
    let ``_.owl#Get3PhaseReactivePowerCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#Get3PhaseReactivePowerCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#GetColdWaterM3Command"></see>
    /// </summary>
    let ``_.owl#GetColdWaterM3Command`` =
        Namespaced_IRI.parse _namespace_name ".owl#GetColdWaterM3Command" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#GetHeatingEnergyCommand"></see>
    /// </summary>
    let ``_.owl#GetHeatingEnergyCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#GetHeatingEnergyCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#GetHotWaterM3Command"></see>
    /// </summary>
    let ``_.owl#GetHotWaterM3Command`` =
        Namespaced_IRI.parse _namespace_name ".owl#GetHotWaterM3Command" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#GetMultiTariff1PhaseActiveEnergyCommand"></see>
    /// </summary>
    let ``_.owl#GetMultiTariff1PhaseActiveEnergyCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#GetMultiTariff1PhaseActiveEnergyCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#GetMultiTariff1PhaseReactiveEnergyCommand"></see>
    /// </summary>
    let ``_.owl#GetMultiTariff1PhaseReactiveEnergyCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#GetMultiTariff1PhaseReactiveEnergyCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#GetMultiTariff3PhaseActiveEnergyCommand"></see>
    /// </summary>
    let ``_.owl#GetMultiTariff3PhaseActiveEnergyCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#GetMultiTariff3PhaseActiveEnergyCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#GetMultiTariff3PhaseReactiveEnergyCommand"></see>
    /// </summary>
    let ``_.owl#GetMultiTariff3PhaseReactiveEnergyCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#GetMultiTariff3PhaseReactiveEnergyCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#GetPowerFactorCommand"></see>
    /// </summary>
    let ``_.owl#GetPowerFactorCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#GetPowerFactorCommand" |> NamespacedName

    /// <summary>
    /// Derives from the general cluster functionalities defined in ZigBee HA specifications
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#IdentificationFunctionality"></see></summary>
    let ``_.owl#IdentificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#IdentificationFunctionality" |> NamespacedName

    /// <summary>
    /// Derives from the general cluster functionalities defined in ZigBee HA specifications
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#IdentificationNotificationFunctionality"></see></summary>
    let ``_.owl#IdentificationNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#IdentificationNotificationFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#HeaterState"></see>
    /// </summary>
    let ``_.owl#HeaterState`` =
        Namespaced_IRI.parse _namespace_name ".owl#HeaterState" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#LevelControlNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#LevelControlNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#LevelControlNotificationFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SpeedNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#SpeedNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#SpeedNotificationFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#HeatingCycleNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#HeatingCycleNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#HeatingCycleNotificationFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StartedHeatingCycleNotification"></see>
    /// </summary>
    let ``_.owl#StartedHeatingCycleNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#StartedHeatingCycleNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StoppedHeatingCycleNotification"></see>
    /// </summary>
    let ``_.owl#StoppedHeatingCycleNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#StoppedHeatingCycleNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#HeatingEnergyMeasurementFunctionality"></see>
    /// </summary>
    let ``_.owl#HeatingEnergyMeasurementFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#HeatingEnergyMeasurementFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#HeatingEnergyMeasurementNotification"></see>
    /// </summary>
    let ``_.owl#HeatingEnergyMeasurementNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#HeatingEnergyMeasurementNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#HeatingEnergyMeasurementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#HeatingEnergyMeasurementNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#HeatingEnergyMeasurementNotificationFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#HeatingEnergyMeasurementState"></see>
    /// </summary>
    let ``_.owl#HeatingEnergyMeasurementState`` =
        Namespaced_IRI.parse _namespace_name ".owl#HeatingEnergyMeasurementState" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#HeatingEnergyStateValue"></see>
    /// </summary>
    let ``_.owl#HeatingEnergyStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#HeatingEnergyStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#HeatingEnergyMeter"></see>
    /// </summary>
    let ``_.owl#HeatingEnergyMeter`` =
        Namespaced_IRI.parse _namespace_name ".owl#HeatingEnergyMeter" |> NamespacedName

    /// <summary>
    /// Functionality to switch on an object for a given period of time
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#TimedOnFunctionality"></see></summary>
    let ``_.owl#TimedOnFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#TimedOnFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SourceSelectionFunctionality"></see>
    /// </summary>
    let ``_.owl#SourceSelectionFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#SourceSelectionFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SourceSelectionNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#SourceSelectionNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#SourceSelectionNotificationFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#TunerNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#TunerNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#TunerNotificationFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#HotWaterM3MeasurementNotification"></see>
    /// </summary>
    let ``_.owl#HotWaterM3MeasurementNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#HotWaterM3MeasurementNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#HueBridge"></see>
    /// </summary>
    let ``_.owl#HueBridge`` =
        Namespaced_IRI.parse _namespace_name ".owl#HueBridge" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PushLinkFunctionality"></see>
    /// </summary>
    let ``_.owl#PushLinkFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#PushLinkFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PushLinkAuthenticationState"></see>
    /// </summary>
    let ``_.owl#PushLinkAuthenticationState`` =
        Namespaced_IRI.parse _namespace_name ".owl#PushLinkAuthenticationState" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PushLinkNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#PushLinkNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#PushLinkNotificationFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#HueComponent"></see>
    /// </summary>
    let ``_.owl#HueComponent`` =
        Namespaced_IRI.parse _namespace_name ".owl#HueComponent" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#HueManager"></see>
    /// </summary>
    let ``_.owl#HueManager`` =
        Namespaced_IRI.parse _namespace_name ".owl#HueManager" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#HumiditySensor"></see>
    /// </summary>
    let ``_.owl#HumiditySensor`` =
        Namespaced_IRI.parse _namespace_name ".owl#HumiditySensor" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#KNXNetIPGateway"></see>
    /// </summary>
    let ``_.owl#KNXNetIPGateway`` =
        Namespaced_IRI.parse _namespace_name ".owl#KNXNetIPGateway" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ModbusGateway"></see>
    /// </summary>
    let ``_.owl#ModbusGateway`` =
        Namespaced_IRI.parse _namespace_name ".owl#ModbusGateway" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#IncreaseVolumeCommand"></see>
    /// </summary>
    let ``_.owl#IncreaseVolumeCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#IncreaseVolumeCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SensingNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#SensingNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#SensingNotificationFunctionality" |> NamespacedName

    /// <summary>
    /// A large whirlpool bathtub with underwater jets that massage the body
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Jacuzzi"></see></summary>
    let ``_.owl#Jacuzzi`` =
        Namespaced_IRI.parse _namespace_name ".owl#Jacuzzi" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#KNXNetIPComponent"></see>
    /// </summary>
    let ``_.owl#KNXNetIPComponent`` =
        Namespaced_IRI.parse _namespace_name ".owl#KNXNetIPComponent" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#KonnexCommand"></see>
    /// </summary>
    let ``_.owl#KonnexCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#KonnexCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#KonnexNotification"></see>
    /// </summary>
    let ``_.owl#KonnexNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#KonnexNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#LampHolder"></see>
    /// </summary>
    let ``_.owl#LampHolder`` =
        Namespaced_IRI.parse _namespace_name ".owl#LampHolder" |> NamespacedName

    /// <summary>
    /// Models a binary output which can be only in on or off state (OnOffState), compatible with the ZigBee HA specifications
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#OnOffOutput"></see></summary>
    let ``_.owl#OnOffOutput`` =
        Namespaced_IRI.parse _namespace_name ".owl#OnOffOutput" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#LevelNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#LevelNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#LevelNotificationFunctionality" |> NamespacedName

    /// <summary>
    /// The Light Sensor device reports the illuminance of an area
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#LightSensor"></see></summary>
    let ``_.owl#LightSensor`` =
        Namespaced_IRI.parse _namespace_name ".owl#LightSensor" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#LuminosityNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#LuminosityNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#LuminosityNotificationFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#LoweringStateValue"></see>
    /// </summary>
    let ``_.owl#LoweringStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#LoweringStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#LuminosityMeasurementNotification"></see>
    /// </summary>
    let ``_.owl#LuminosityMeasurementNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#LuminosityMeasurementNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MeteringPowerOutlet"></see>
    /// </summary>
    let ``_.owl#MeteringPowerOutlet`` =
        Namespaced_IRI.parse _namespace_name ".owl#MeteringPowerOutlet" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PowerFactorMeter"></see>
    /// </summary>
    let ``_.owl#PowerFactorMeter`` =
        Namespaced_IRI.parse _namespace_name ".owl#PowerFactorMeter" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PowerMeteringPowerOutlet"></see>
    /// </summary>
    let ``_.owl#PowerMeteringPowerOutlet`` =
        Namespaced_IRI.parse _namespace_name ".owl#PowerMeteringPowerOutlet" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MicrowaveEmissionNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#MicrowaveEmissionNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#MicrowaveEmissionNotificationFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MicrowaveEmissionState"></see>
    /// </summary>
    let ``_.owl#MicrowaveEmissionState`` =
        Namespaced_IRI.parse _namespace_name ".owl#MicrowaveEmissionState" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ModBusStateValue"></see>
    /// </summary>
    let ``_.owl#ModBusStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#ModBusStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ModbusCommand"></see>
    /// </summary>
    let ``_.owl#ModbusCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#ModbusCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ModbusComponent"></see>
    /// </summary>
    let ``_.owl#ModbusComponent`` =
        Namespaced_IRI.parse _namespace_name ".owl#ModbusComponent" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ModbusNotification"></see>
    /// </summary>
    let ``_.owl#ModbusNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#ModbusNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#NetworkSpecificStateValue"></see>
    /// </summary>
    let ``_.owl#NetworkSpecificStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#NetworkSpecificStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MovementAndTemperatureSensor"></see>
    /// </summary>
    let ``_.owl#MovementAndTemperatureSensor`` =
        Namespaced_IRI.parse _namespace_name ".owl#MovementAndTemperatureSensor" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MovementSensor"></see>
    /// </summary>
    let ``_.owl#MovementSensor`` =
        Namespaced_IRI.parse _namespace_name ".owl#MovementSensor" |> NamespacedName

    /// <summary>
    /// Sensor that detects the temperature of the atmosphere
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#SingleTemperatureSensor"></see></summary>
    let ``_.owl#SingleTemperatureSensor`` =
        Namespaced_IRI.parse _namespace_name ".owl#SingleTemperatureSensor" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MovingDownNotification"></see>
    /// </summary>
    let ``_.owl#MovingDownNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#MovingDownNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MovingUpNotification"></see>
    /// </summary>
    let ``_.owl#MovingUpNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#MovingUpNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PresenceNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#PresenceNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#PresenceNotificationFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#UpDownNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#UpDownNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#UpDownNotificationFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#OccupancyState"></see>
    /// </summary>
    let ``_.owl#OccupancyState`` =
        Namespaced_IRI.parse _namespace_name ".owl#OccupancyState" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PresenceState"></see>
    /// </summary>
    let ``_.owl#PresenceState`` =
        Namespaced_IRI.parse _namespace_name ".owl#PresenceState" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MovingUpDownState"></see>
    /// </summary>
    let ``_.owl#MovingUpDownState`` =
        Namespaced_IRI.parse _namespace_name ".owl#MovingUpDownState" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#RaisingStateValue"></see>
    /// </summary>
    let ``_.owl#RaisingStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#RaisingStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffActiveEnergyStateValue"></see>
    /// </summary>
    let ``_.owl#MultiTariffActiveEnergyStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#MultiTariffActiveEnergyStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffEnergyMeter"></see>
    /// </summary>
    let ``_.owl#MultiTariffEnergyMeter`` =
        Namespaced_IRI.parse _namespace_name ".owl#MultiTariffEnergyMeter" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffReactiveEnergyStateValue"></see>
    /// </summary>
    let ``_.owl#MultiTariffReactiveEnergyStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#MultiTariffReactiveEnergyStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffSinglePhaseActiveEnergyMeasurementFunctionality"></see>
    /// </summary>
    let ``_.owl#MultiTariffSinglePhaseActiveEnergyMeasurementFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#MultiTariffSinglePhaseActiveEnergyMeasurementFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffSinglePhaseActiveEnergyMeasurementNotification"></see>
    /// </summary>
    let ``_.owl#MultiTariffSinglePhaseActiveEnergyMeasurementNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#MultiTariffSinglePhaseActiveEnergyMeasurementNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffSinglePhaseActiveEnergyMeasurementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#MultiTariffSinglePhaseActiveEnergyMeasurementNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#MultiTariffSinglePhaseActiveEnergyMeasurementNotificationFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffSinglePhaseActiveEnergyState"></see>
    /// </summary>
    let ``_.owl#MultiTariffSinglePhaseActiveEnergyState`` =
        Namespaced_IRI.parse _namespace_name ".owl#MultiTariffSinglePhaseActiveEnergyState" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffSinglePhaseEnergyMeter"></see>
    /// </summary>
    let ``_.owl#MultiTariffSinglePhaseEnergyMeter`` =
        Namespaced_IRI.parse _namespace_name ".owl#MultiTariffSinglePhaseEnergyMeter" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffSinglePhaseReactiveEnergyMeasurementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#MultiTariffSinglePhaseReactiveEnergyMeasurementNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#MultiTariffSinglePhaseReactiveEnergyMeasurementNotificationFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffSinglePhaseReactiveEnergyState"></see>
    /// </summary>
    let ``_.owl#MultiTariffSinglePhaseReactiveEnergyState`` =
        Namespaced_IRI.parse _namespace_name ".owl#MultiTariffSinglePhaseReactiveEnergyState" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffSinglePhaseReactiveEnergyMeasurementFunctionality"></see>
    /// </summary>
    let ``_.owl#MultiTariffSinglePhaseReactiveEnergyMeasurementFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#MultiTariffSinglePhaseReactiveEnergyMeasurementFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ReactiveEnergyMeasurementFunctionality"></see>
    /// </summary>
    let ``_.owl#ReactiveEnergyMeasurementFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#ReactiveEnergyMeasurementFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffSinglePhaseReactiveEnergyMeasurementNotification"></see>
    /// </summary>
    let ``_.owl#MultiTariffSinglePhaseReactiveEnergyMeasurementNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#MultiTariffSinglePhaseReactiveEnergyMeasurementNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ReactiveEnergyMeasurementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#ReactiveEnergyMeasurementNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#ReactiveEnergyMeasurementNotificationFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffThreePhaseActiveEnergyMeasurementFunctionality"></see>
    /// </summary>
    let ``_.owl#MultiTariffThreePhaseActiveEnergyMeasurementFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#MultiTariffThreePhaseActiveEnergyMeasurementFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffThreePhaseActiveEnergyMeasurementNotification"></see>
    /// </summary>
    let ``_.owl#MultiTariffThreePhaseActiveEnergyMeasurementNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#MultiTariffThreePhaseActiveEnergyMeasurementNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffThreePhaseActiveEnergyMeasurementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#MultiTariffThreePhaseActiveEnergyMeasurementNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#MultiTariffThreePhaseActiveEnergyMeasurementNotificationFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffThreePhaseActiveEnergyState"></see>
    /// </summary>
    let ``_.owl#MultiTariffThreePhaseActiveEnergyState`` =
        Namespaced_IRI.parse _namespace_name ".owl#MultiTariffThreePhaseActiveEnergyState" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffThreePhaseEnergyMeter"></see>
    /// </summary>
    let ``_.owl#MultiTariffThreePhaseEnergyMeter`` =
        Namespaced_IRI.parse _namespace_name ".owl#MultiTariffThreePhaseEnergyMeter" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffThreePhaseReactiveEnergyMeasurementFunctionality"></see>
    /// </summary>
    let ``_.owl#MultiTariffThreePhaseReactiveEnergyMeasurementFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#MultiTariffThreePhaseReactiveEnergyMeasurementFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffThreePhaseReactiveEnergyMeasurementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#MultiTariffThreePhaseReactiveEnergyMeasurementNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#MultiTariffThreePhaseReactiveEnergyMeasurementNotificationFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffThreePhaseReactiveEnergyState"></see>
    /// </summary>
    let ``_.owl#MultiTariffThreePhaseReactiveEnergyState`` =
        Namespaced_IRI.parse _namespace_name ".owl#MultiTariffThreePhaseReactiveEnergyState" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffThreePhaseReactiveEnergyMeasurementNotification"></see>
    /// </summary>
    let ``_.owl#MultiTariffThreePhaseReactiveEnergyMeasurementNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#MultiTariffThreePhaseReactiveEnergyMeasurementNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MultipleAlertNotification"></see>
    /// </summary>
    let ``_.owl#MultipleAlertNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#MultipleAlertNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MultipleEventNotification"></see>
    /// </summary>
    let ``_.owl#MultipleEventNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#MultipleEventNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MultipleFlowMeasurementFunctionality"></see>
    /// </summary>
    let ``_.owl#MultipleFlowMeasurementFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#MultipleFlowMeasurementFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MultipleFlowMeasurementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#MultipleFlowMeasurementNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#MultipleFlowMeasurementNotificationFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MultipleFlowRateState"></see>
    /// </summary>
    let ``_.owl#MultipleFlowRateState`` =
        Namespaced_IRI.parse _namespace_name ".owl#MultipleFlowRateState" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MultipleFlowRateStateValue"></see>
    /// </summary>
    let ``_.owl#MultipleFlowRateStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#MultipleFlowRateStateValue" |> NamespacedName

    /// <summary>
    /// The Flow  Sensor device measures and periodically reports the flow rate of a liquid (typically water)
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#MultipleFlowSensor"></see></summary>
    let ``_.owl#MultipleFlowSensor`` =
        Namespaced_IRI.parse _namespace_name ".owl#MultipleFlowSensor" |> NamespacedName

    /// <summary>
    /// The capability of measuring the humidity of a room
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#MultipleHumidityMeasurementFunctionality"></see></summary>
    let ``_.owl#MultipleHumidityMeasurementFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#MultipleHumidityMeasurementFunctionality" |> NamespacedName

    /// <summary>
    /// The notification for requesting humidity measurment...
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#MultipleHumidityMeasurementNotificationFunctionality"></see></summary>
    let ``_.owl#MultipleHumidityMeasurementNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#MultipleHumidityMeasurementNotificationFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MultiplePressureMeasurementFunctionality"></see>
    /// </summary>
    let ``_.owl#MultiplePressureMeasurementFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#MultiplePressureMeasurementFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MultiplePressureMeasurementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#MultiplePressureMeasurementNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#MultiplePressureMeasurementNotificationFunctionality" |> NamespacedName

    /// <summary>
    /// The Pressure Sensor device measures and periodically reports the pressure of a liquid (typically water)
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#MultiplePressureSensor"></see></summary>
    let ``_.owl#MultiplePressureSensor`` =
        Namespaced_IRI.parse _namespace_name ".owl#MultiplePressureSensor" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MultiplePressureState"></see>
    /// </summary>
    let ``_.owl#MultiplePressureState`` =
        Namespaced_IRI.parse _namespace_name ".owl#MultiplePressureState" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MultiplePressureStateValue"></see>
    /// </summary>
    let ``_.owl#MultiplePressureStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#MultiplePressureStateValue" |> NamespacedName

    /// <summary>
    /// The capability of measuring temperatures
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#MultipleTemperatureMeasurementFunctionality"></see></summary>
    let ``_.owl#MultipleTemperatureMeasurementFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#MultipleTemperatureMeasurementFunctionality" |> NamespacedName

    /// <summary>
    /// Notifies the measurment of a temperature, through a proper temperature sensor
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#MultipleTemperatureMeasurementNotificationFunctionality"></see></summary>
    let ``_.owl#MultipleTemperatureMeasurementNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#MultipleTemperatureMeasurementNotificationFunctionality" |> NamespacedName

    /// <summary>
    /// Sensor that detects the temperature of the atmosphere
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#MultipleTemperatureSensor"></see></summary>
    let ``_.owl#MultipleTemperatureSensor`` =
        Namespaced_IRI.parse _namespace_name ".owl#MultipleTemperatureSensor" |> NamespacedName

    /// <summary>
    /// Models the temperature value
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#MultipleTemperatureState"></see></summary>
    let ``_.owl#MultipleTemperatureState`` =
        Namespaced_IRI.parse _namespace_name ".owl#MultipleTemperatureState" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#TemperatureSensor"></see>
    /// </summary>
    let ``_.owl#TemperatureSensor`` =
        Namespaced_IRI.parse _namespace_name ".owl#TemperatureSensor" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#MultipleTemperatureStateValue"></see>
    /// </summary>
    let ``_.owl#MultipleTemperatureStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#MultipleTemperatureStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#NetworkClosedNotification"></see>
    /// </summary>
    let ``_.owl#NetworkClosedNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#NetworkClosedNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ZigBeeNotification"></see>
    /// </summary>
    let ``_.owl#ZigBeeNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#ZigBeeNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#NetworkManagementFunctionality"></see>
    /// </summary>
    let ``_.owl#NetworkManagementFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#NetworkManagementFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#OpenNetworkCommand"></see>
    /// </summary>
    let ``_.owl#OpenNetworkCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#OpenNetworkCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#NetworkManagementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#NetworkManagementNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#NetworkManagementNotificationFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#NetworkOpenedNotification"></see>
    /// </summary>
    let ``_.owl#NetworkOpenedNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#NetworkOpenedNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#NetworkManagementState"></see>
    /// </summary>
    let ``_.owl#NetworkManagementState`` =
        Namespaced_IRI.parse _namespace_name ".owl#NetworkManagementState" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#RestDownNotification"></see>
    /// </summary>
    let ``_.owl#RestDownNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#RestDownNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#RestNotification"></see>
    /// </summary>
    let ``_.owl#RestNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#RestNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#RestUpNotification"></see>
    /// </summary>
    let ``_.owl#RestUpNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#RestUpNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SpeedStepDownNotification"></see>
    /// </summary>
    let ``_.owl#SpeedStepDownNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#SpeedStepDownNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SpeedStepUpNotification"></see>
    /// </summary>
    let ``_.owl#SpeedStepUpNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#SpeedStepUpNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#TuningStepDownNotification"></see>
    /// </summary>
    let ``_.owl#TuningStepDownNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#TuningStepDownNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#TuningStepUpNotification"></see>
    /// </summary>
    let ``_.owl#TuningStepUpNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#TuningStepUpNotification" |> NamespacedName

    /// <summary>
    /// Functionality: up - down
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#UpDownFunctionality"></see></summary>
    let ``_.owl#UpDownFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#UpDownFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StepFunctionality"></see>
    /// </summary>
    let ``_.owl#StepFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#StepFunctionality" |> NamespacedName

    /// <summary>
    /// OnOffSwitch for Lights only, derives from ZigBee HA specifications
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#OnOffLightSwitch"></see></summary>
    let ``_.owl#OnOffLightSwitch`` =
        Namespaced_IRI.parse _namespace_name ".owl#OnOffLightSwitch" |> NamespacedName

    /// <summary>
    /// Generic OnOff switch, derives from the ZigBee Home Automation specification
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#OnOffSwitch"></see></summary>
    let ``_.owl#OnOffSwitch`` =
        Namespaced_IRI.parse _namespace_name ".owl#OnOffSwitch" |> NamespacedName

    /// <summary>
    /// Functionality: up - down - rest
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#UpDownRestFunctionality"></see></summary>
    let ``_.owl#UpDownRestFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#UpDownRestFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#OverloadControlFunctionality"></see>
    /// </summary>
    let ``_.owl#OverloadControlFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#OverloadControlFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#OverloadWarningCommand"></see>
    /// </summary>
    let ``_.owl#OverloadWarningCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#OverloadWarningCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#OverloadPauseResumeCommand"></see>
    /// </summary>
    let ``_.owl#OverloadPauseResumeCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#OverloadPauseResumeCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#OverloadPauseCommand"></see>
    /// </summary>
    let ``_.owl#OverloadPauseCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#OverloadPauseCommand" |> NamespacedName

    /// <summary>
    /// A vertical structure that divides or separates
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Partition"></see></summary>
    let ``_.owl#Partition`` =
        Namespaced_IRI.parse _namespace_name ".owl#Partition" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PausePlaybackNotification"></see>
    /// </summary>
    let ``_.owl#PausePlaybackNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#PausePlaybackNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PlayNotification"></see>
    /// </summary>
    let ``_.owl#PlayNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#PlayNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#RewindNotification"></see>
    /// </summary>
    let ``_.owl#RewindNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#RewindNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StopPlaybackNotification"></see>
    /// </summary>
    let ``_.owl#StopPlaybackNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#StopPlaybackNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#TrackControlNotification"></see>
    /// </summary>
    let ``_.owl#TrackControlNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#TrackControlNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PowerFactorMeasurementFunctionality"></see>
    /// </summary>
    let ``_.owl#PowerFactorMeasurementFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#PowerFactorMeasurementFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PowerFactorMeasurementNotification"></see>
    /// </summary>
    let ``_.owl#PowerFactorMeasurementNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#PowerFactorMeasurementNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PowerFactorMeasurementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#PowerFactorMeasurementNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#PowerFactorMeasurementNotificationFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PowerFactorMeasurementState"></see>
    /// </summary>
    let ``_.owl#PowerFactorMeasurementState`` =
        Namespaced_IRI.parse _namespace_name ".owl#PowerFactorMeasurementState" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PowerFactorStateValue"></see>
    /// </summary>
    let ``_.owl#PowerFactorStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#PowerFactorStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PowerMeteringLevelControllableOutput"></see>
    /// </summary>
    let ``_.owl#PowerMeteringLevelControllableOutput`` =
        Namespaced_IRI.parse _namespace_name ".owl#PowerMeteringLevelControllableOutput" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PresenceAndMovementSensor"></see>
    /// </summary>
    let ``_.owl#PresenceAndMovementSensor`` =
        Namespaced_IRI.parse _namespace_name ".owl#PresenceAndMovementSensor" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PresenceSensor"></see>
    /// </summary>
    let ``_.owl#PresenceSensor`` =
        Namespaced_IRI.parse _namespace_name ".owl#PresenceSensor" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ProgramState"></see>
    /// </summary>
    let ``_.owl#ProgramState`` =
        Namespaced_IRI.parse _namespace_name ".owl#ProgramState" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PushLinkAuthenticationActiveNotification"></see>
    /// </summary>
    let ``_.owl#PushLinkAuthenticationActiveNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#PushLinkAuthenticationActiveNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#PushLinkAuthenticationIdleNotification"></see>
    /// </summary>
    let ``_.owl#PushLinkAuthenticationIdleNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#PushLinkAuthenticationIdleNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StopPushLinkAuthenticationCommand"></see>
    /// </summary>
    let ``_.owl#StopPushLinkAuthenticationCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#StopPushLinkAuthenticationCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StartPushLinkAuthenticationCommand"></see>
    /// </summary>
    let ``_.owl#StartPushLinkAuthenticationCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#StartPushLinkAuthenticationCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#QuadSensor"></see>
    /// </summary>
    let ``_.owl#QuadSensor`` =
        Namespaced_IRI.parse _namespace_name ".owl#QuadSensor" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ReactivePowerMeasurementFunctionality"></see>
    /// </summary>
    let ``_.owl#ReactivePowerMeasurementFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#ReactivePowerMeasurementFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ReactivePowerMeasurementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#ReactivePowerMeasurementNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#ReactivePowerMeasurementNotificationFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ReactivePowerMeasurementState"></see>
    /// </summary>
    let ``_.owl#ReactivePowerMeasurementState`` =
        Namespaced_IRI.parse _namespace_name ".owl#ReactivePowerMeasurementState" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ReactivePowerMeter"></see>
    /// </summary>
    let ``_.owl#ReactivePowerMeter`` =
        Namespaced_IRI.parse _namespace_name ".owl#ReactivePowerMeter" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ReactivePowerStateValue"></see>
    /// </summary>
    let ``_.owl#ReactivePowerStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#ReactivePowerStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#RunState"></see>
    /// </summary>
    let ``_.owl#RunState`` =
        Namespaced_IRI.parse _namespace_name ".owl#RunState" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SelfClosingDoorActuator"></see>
    /// </summary>
    let ``_.owl#SelfClosingDoorActuator`` =
        Namespaced_IRI.parse _namespace_name ".owl#SelfClosingDoorActuator" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#VerticalNoMovementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#VerticalNoMovementNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#VerticalNoMovementNotificationFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#VerticalMovementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#VerticalMovementNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#VerticalMovementNotificationFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ShutterState"></see>
    /// </summary>
    let ``_.owl#ShutterState`` =
        Namespaced_IRI.parse _namespace_name ".owl#ShutterState" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ShutterButton"></see>
    /// </summary>
    let ``_.owl#ShutterButton`` =
        Namespaced_IRI.parse _namespace_name ".owl#ShutterButton" |> NamespacedName

    /// <summary>
    /// State: up - down - rest
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#UpDownRestState"></see></summary>
    let ``_.owl#UpDownRestState`` =
        Namespaced_IRI.parse _namespace_name ".owl#UpDownRestState" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseActiveEnergyMeasurementFunctionality"></see>
    /// </summary>
    let ``_.owl#SinglePhaseActiveEnergyMeasurementFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#SinglePhaseActiveEnergyMeasurementFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseActiveEnergyMeasurementNotification"></see>
    /// </summary>
    let ``_.owl#SinglePhaseActiveEnergyMeasurementNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#SinglePhaseActiveEnergyMeasurementNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseActiveEnergyMeasurementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#SinglePhaseActiveEnergyMeasurementNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#SinglePhaseActiveEnergyMeasurementNotificationFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseActiveEnergyState"></see>
    /// </summary>
    let ``_.owl#SinglePhaseActiveEnergyState`` =
        Namespaced_IRI.parse _namespace_name ".owl#SinglePhaseActiveEnergyState" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SingleTariffEnergyMeter"></see>
    /// </summary>
    let ``_.owl#SingleTariffEnergyMeter`` =
        Namespaced_IRI.parse _namespace_name ".owl#SingleTariffEnergyMeter" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseActivePowerMeasurementFunctionality"></see>
    /// </summary>
    let ``_.owl#SinglePhaseActivePowerMeasurementFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#SinglePhaseActivePowerMeasurementFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseActivePowerMeasurementNotification"></see>
    /// </summary>
    let ``_.owl#SinglePhaseActivePowerMeasurementNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#SinglePhaseActivePowerMeasurementNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseActivePowerMeasurementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#SinglePhaseActivePowerMeasurementNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#SinglePhaseActivePowerMeasurementNotificationFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseActivePowerMeasurementState"></see>
    /// </summary>
    let ``_.owl#SinglePhaseActivePowerMeasurementState`` =
        Namespaced_IRI.parse _namespace_name ".owl#SinglePhaseActivePowerMeasurementState" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseApparentPowerMeasurementFunctionality"></see>
    /// </summary>
    let ``_.owl#SinglePhaseApparentPowerMeasurementFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#SinglePhaseApparentPowerMeasurementFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseApparentPowerMeasurementNotification"></see>
    /// </summary>
    let ``_.owl#SinglePhaseApparentPowerMeasurementNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#SinglePhaseApparentPowerMeasurementNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseApparentPowerMeasurementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#SinglePhaseApparentPowerMeasurementNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#SinglePhaseApparentPowerMeasurementNotificationFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseApparentPowerMeasurementState"></see>
    /// </summary>
    let ``_.owl#SinglePhaseApparentPowerMeasurementState`` =
        Namespaced_IRI.parse _namespace_name ".owl#SinglePhaseApparentPowerMeasurementState" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseApparentPowerMeter"></see>
    /// </summary>
    let ``_.owl#SinglePhaseApparentPowerMeter`` =
        Namespaced_IRI.parse _namespace_name ".owl#SinglePhaseApparentPowerMeter" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseCurrentMeasurementFunctionality"></see>
    /// </summary>
    let ``_.owl#SinglePhaseCurrentMeasurementFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#SinglePhaseCurrentMeasurementFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseCurrentMeasurementNotification"></see>
    /// </summary>
    let ``_.owl#SinglePhaseCurrentMeasurementNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#SinglePhaseCurrentMeasurementNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseCurrentMeasurementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#SinglePhaseCurrentMeasurementNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#SinglePhaseCurrentMeasurementNotificationFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseCurrentMeter"></see>
    /// </summary>
    let ``_.owl#SinglePhaseCurrentMeter`` =
        Namespaced_IRI.parse _namespace_name ".owl#SinglePhaseCurrentMeter" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseCurrentState"></see>
    /// </summary>
    let ``_.owl#SinglePhaseCurrentState`` =
        Namespaced_IRI.parse _namespace_name ".owl#SinglePhaseCurrentState" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseElectricityMeter"></see>
    /// </summary>
    let ``_.owl#SinglePhaseElectricityMeter`` =
        Namespaced_IRI.parse _namespace_name ".owl#SinglePhaseElectricityMeter" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseReactivePowerMeter"></see>
    /// </summary>
    let ``_.owl#SinglePhaseReactivePowerMeter`` =
        Namespaced_IRI.parse _namespace_name ".owl#SinglePhaseReactivePowerMeter" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseVoltageMeter"></see>
    /// </summary>
    let ``_.owl#SinglePhaseVoltageMeter`` =
        Namespaced_IRI.parse _namespace_name ".owl#SinglePhaseVoltageMeter" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseReactiveEnergyMeasurementFunctionality"></see>
    /// </summary>
    let ``_.owl#SinglePhaseReactiveEnergyMeasurementFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#SinglePhaseReactiveEnergyMeasurementFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseReactiveEnergyState"></see>
    /// </summary>
    let ``_.owl#SinglePhaseReactiveEnergyState`` =
        Namespaced_IRI.parse _namespace_name ".owl#SinglePhaseReactiveEnergyState" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseReactiveEnergyMeasurementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#SinglePhaseReactiveEnergyMeasurementNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#SinglePhaseReactiveEnergyMeasurementNotificationFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseReactiveEnergyMeasurementNotification"></see>
    /// </summary>
    let ``_.owl#SinglePhaseReactiveEnergyMeasurementNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#SinglePhaseReactiveEnergyMeasurementNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseReactivePowerMeasurementFunctionality"></see>
    /// </summary>
    let ``_.owl#SinglePhaseReactivePowerMeasurementFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#SinglePhaseReactivePowerMeasurementFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseReactivePowerMeasurementNotification"></see>
    /// </summary>
    let ``_.owl#SinglePhaseReactivePowerMeasurementNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#SinglePhaseReactivePowerMeasurementNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseReactivePowerMeasurementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#SinglePhaseReactivePowerMeasurementNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#SinglePhaseReactivePowerMeasurementNotificationFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseReactivePowerMeasurementState"></see>
    /// </summary>
    let ``_.owl#SinglePhaseReactivePowerMeasurementState`` =
        Namespaced_IRI.parse _namespace_name ".owl#SinglePhaseReactivePowerMeasurementState" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseVoltageMeasurementFunctionality"></see>
    /// </summary>
    let ``_.owl#SinglePhaseVoltageMeasurementFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#SinglePhaseVoltageMeasurementFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#VoltageMeasurementFunctionality"></see>
    /// </summary>
    let ``_.owl#VoltageMeasurementFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#VoltageMeasurementFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseVoltageMeasurementNotification"></see>
    /// </summary>
    let ``_.owl#SinglePhaseVoltageMeasurementNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#SinglePhaseVoltageMeasurementNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseVoltageMeasurementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#SinglePhaseVoltageMeasurementNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#SinglePhaseVoltageMeasurementNotificationFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#VoltageMeasurementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#VoltageMeasurementNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#VoltageMeasurementNotificationFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseVoltageState"></see>
    /// </summary>
    let ``_.owl#SinglePhaseVoltageState`` =
        Namespaced_IRI.parse _namespace_name ".owl#SinglePhaseVoltageState" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#VoltageMeter"></see>
    /// </summary>
    let ``_.owl#VoltageMeter`` =
        Namespaced_IRI.parse _namespace_name ".owl#VoltageMeter" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#VoltageStateValue"></see>
    /// </summary>
    let ``_.owl#VoltageStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#VoltageStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#VoltageMeasurementState"></see>
    /// </summary>
    let ``_.owl#VoltageMeasurementState`` =
        Namespaced_IRI.parse _namespace_name ".owl#VoltageMeasurementState" |> NamespacedName

    /// <summary>
    /// A device in which compressed air or steam is driven against a rotating perforated disk to create a loud, often wailing sound as a signal or warning.
    ///
    /// An electronic device producing a similar sound as a signal or warning: a police car siren.
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Siren"></see></summary>
    let ``_.owl#Siren`` =
        Namespaced_IRI.parse _namespace_name ".owl#Siren" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SnapshotCamera"></see>
    /// </summary>
    let ``_.owl#SnapshotCamera`` =
        Namespaced_IRI.parse _namespace_name ".owl#SnapshotCamera" |> NamespacedName

    /// <summary>
    /// Plays a Sound (default, or selected through a goTotrack, or...)
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#SoundFunctionality"></see></summary>
    let ``_.owl#SoundFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#SoundFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ToggleFunctionality"></see>
    /// </summary>
    let ``_.owl#ToggleFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#ToggleFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SourceSelectionNotification"></see>
    /// </summary>
    let ``_.owl#SourceSelectionNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#SourceSelectionNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#SpeedControlNotification"></see>
    /// </summary>
    let ``_.owl#SpeedControlNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#SpeedControlNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StartCommand"></see>
    /// </summary>
    let ``_.owl#StartCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#StartCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StopCommand"></see>
    /// </summary>
    let ``_.owl#StopCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#StopCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StartSuperFreezingCommand"></see>
    /// </summary>
    let ``_.owl#StartSuperFreezingCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#StartSuperFreezingCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StartSuperHeatingCommand"></see>
    /// </summary>
    let ``_.owl#StartSuperHeatingCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#StartSuperHeatingCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StartSupercoolingCommand"></see>
    /// </summary>
    let ``_.owl#StartSupercoolingCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#StartSupercoolingCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StartedSuperCoolingNotification"></see>
    /// </summary>
    let ``_.owl#StartedSuperCoolingNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#StartedSuperCoolingNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StartedSuperFreezingNotification"></see>
    /// </summary>
    let ``_.owl#StartedSuperFreezingNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#StartedSuperFreezingNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StartedSuperHeatingNotification"></see>
    /// </summary>
    let ``_.owl#StartedSuperHeatingNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#StartedSuperHeatingNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StartedWashingNotification"></see>
    /// </summary>
    let ``_.owl#StartedWashingNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#StartedWashingNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StepShutterActuator"></see>
    /// </summary>
    let ``_.owl#StepShutterActuator`` =
        Namespaced_IRI.parse _namespace_name ".owl#StepShutterActuator" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StopSuperFreezingCommand"></see>
    /// </summary>
    let ``_.owl#StopSuperFreezingCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#StopSuperFreezingCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StopSuperHeatingCommand"></see>
    /// </summary>
    let ``_.owl#StopSuperHeatingCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#StopSuperHeatingCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StopSupercoolingCommand"></see>
    /// </summary>
    let ``_.owl#StopSupercoolingCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#StopSupercoolingCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StoppedSuperCoolingNotification"></see>
    /// </summary>
    let ``_.owl#StoppedSuperCoolingNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#StoppedSuperCoolingNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StoppedSuperFreezingNotification"></see>
    /// </summary>
    let ``_.owl#StoppedSuperFreezingNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#StoppedSuperFreezingNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StoppedSuperHeatingNotification"></see>
    /// </summary>
    let ``_.owl#StoppedSuperHeatingNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#StoppedSuperHeatingNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#StoppedWashingNotification"></see>
    /// </summary>
    let ``_.owl#StoppedWashingNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#StoppedWashingNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#TemperatureAndHumiditySensor"></see>
    /// </summary>
    let ``_.owl#TemperatureAndHumiditySensor`` =
        Namespaced_IRI.parse _namespace_name ".owl#TemperatureAndHumiditySensor" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#TexasInstrumentsComponent"></see>
    /// </summary>
    let ``_.owl#TexasInstrumentsComponent`` =
        Namespaced_IRI.parse _namespace_name ".owl#TexasInstrumentsComponent" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#TexasInstrumentsGateway"></see>
    /// </summary>
    let ``_.owl#TexasInstrumentsGateway`` =
        Namespaced_IRI.parse _namespace_name ".owl#TexasInstrumentsGateway" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThermostatQueryFunctionality"></see>
    /// </summary>
    let ``_.owl#ThermostatQueryFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#ThermostatQueryFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThermostaticRadiatorValve"></see>
    /// </summary>
    let ``_.owl#ThermostaticRadiatorValve`` =
        Namespaced_IRI.parse _namespace_name ".owl#ThermostaticRadiatorValve" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseActiveEnergyMeasurementFunctionality"></see>
    /// </summary>
    let ``_.owl#ThreePhaseActiveEnergyMeasurementFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#ThreePhaseActiveEnergyMeasurementFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseActiveEnergyMeasurementNotification"></see>
    /// </summary>
    let ``_.owl#ThreePhaseActiveEnergyMeasurementNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#ThreePhaseActiveEnergyMeasurementNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseActiveEnergyMeasurementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#ThreePhaseActiveEnergyMeasurementNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#ThreePhaseActiveEnergyMeasurementNotificationFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseActiveEnergyState"></see>
    /// </summary>
    let ``_.owl#ThreePhaseActiveEnergyState`` =
        Namespaced_IRI.parse _namespace_name ".owl#ThreePhaseActiveEnergyState" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseActivePowerMeasurementFunctionality"></see>
    /// </summary>
    let ``_.owl#ThreePhaseActivePowerMeasurementFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#ThreePhaseActivePowerMeasurementFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseActivePowerMeasurementNotification"></see>
    /// </summary>
    let ``_.owl#ThreePhaseActivePowerMeasurementNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#ThreePhaseActivePowerMeasurementNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseActivePowerMeasurementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#ThreePhaseActivePowerMeasurementNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#ThreePhaseActivePowerMeasurementNotificationFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseActivePowerMeasurementState"></see>
    /// </summary>
    let ``_.owl#ThreePhaseActivePowerMeasurementState`` =
        Namespaced_IRI.parse _namespace_name ".owl#ThreePhaseActivePowerMeasurementState" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseActivePowerMeter"></see>
    /// </summary>
    let ``_.owl#ThreePhaseActivePowerMeter`` =
        Namespaced_IRI.parse _namespace_name ".owl#ThreePhaseActivePowerMeter" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseApparentPowerMeasurementFunctionality"></see>
    /// </summary>
    let ``_.owl#ThreePhaseApparentPowerMeasurementFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#ThreePhaseApparentPowerMeasurementFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseApparentPowerMeasurementNotification"></see>
    /// </summary>
    let ``_.owl#ThreePhaseApparentPowerMeasurementNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#ThreePhaseApparentPowerMeasurementNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseApparentPowerMeasurementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#ThreePhaseApparentPowerMeasurementNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#ThreePhaseApparentPowerMeasurementNotificationFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseApparentPowerMeasurementState"></see>
    /// </summary>
    let ``_.owl#ThreePhaseApparentPowerMeasurementState`` =
        Namespaced_IRI.parse _namespace_name ".owl#ThreePhaseApparentPowerMeasurementState" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseApparentPowerMeter"></see>
    /// </summary>
    let ``_.owl#ThreePhaseApparentPowerMeter`` =
        Namespaced_IRI.parse _namespace_name ".owl#ThreePhaseApparentPowerMeter" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseCurrentMeasurementFunctionality"></see>
    /// </summary>
    let ``_.owl#ThreePhaseCurrentMeasurementFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#ThreePhaseCurrentMeasurementFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseCurrentMeasurementNotification"></see>
    /// </summary>
    let ``_.owl#ThreePhaseCurrentMeasurementNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#ThreePhaseCurrentMeasurementNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseCurrentMeasurementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#ThreePhaseCurrentMeasurementNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#ThreePhaseCurrentMeasurementNotificationFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseCurrentMeter"></see>
    /// </summary>
    let ``_.owl#ThreePhaseCurrentMeter`` =
        Namespaced_IRI.parse _namespace_name ".owl#ThreePhaseCurrentMeter" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseCurrentState"></see>
    /// </summary>
    let ``_.owl#ThreePhaseCurrentState`` =
        Namespaced_IRI.parse _namespace_name ".owl#ThreePhaseCurrentState" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseElectricityMeter"></see>
    /// </summary>
    let ``_.owl#ThreePhaseElectricityMeter`` =
        Namespaced_IRI.parse _namespace_name ".owl#ThreePhaseElectricityMeter" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseReactivePowerMeter"></see>
    /// </summary>
    let ``_.owl#ThreePhaseReactivePowerMeter`` =
        Namespaced_IRI.parse _namespace_name ".owl#ThreePhaseReactivePowerMeter" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseVoltageMeter"></see>
    /// </summary>
    let ``_.owl#ThreePhaseVoltageMeter`` =
        Namespaced_IRI.parse _namespace_name ".owl#ThreePhaseVoltageMeter" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseEnergyMeter"></see>
    /// </summary>
    let ``_.owl#ThreePhaseEnergyMeter`` =
        Namespaced_IRI.parse _namespace_name ".owl#ThreePhaseEnergyMeter" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseReactiveEnergyState"></see>
    /// </summary>
    let ``_.owl#ThreePhaseReactiveEnergyState`` =
        Namespaced_IRI.parse _namespace_name ".owl#ThreePhaseReactiveEnergyState" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseReactiveEnergyMeasurementFunctionality"></see>
    /// </summary>
    let ``_.owl#ThreePhaseReactiveEnergyMeasurementFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#ThreePhaseReactiveEnergyMeasurementFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseReactiveEnergyMeasurementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#ThreePhaseReactiveEnergyMeasurementNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#ThreePhaseReactiveEnergyMeasurementNotificationFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseLLVoltageMeasurementNotification"></see>
    /// </summary>
    let ``_.owl#ThreePhaseLLVoltageMeasurementNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#ThreePhaseLLVoltageMeasurementNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseLNVoltageMeasurementNotification"></see>
    /// </summary>
    let ``_.owl#ThreePhaseLNVoltageMeasurementNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#ThreePhaseLNVoltageMeasurementNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseReactiveEnergyMeasurementNotification"></see>
    /// </summary>
    let ``_.owl#ThreePhaseReactiveEnergyMeasurementNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#ThreePhaseReactiveEnergyMeasurementNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseReactivePowerMeasurementFunctionality"></see>
    /// </summary>
    let ``_.owl#ThreePhaseReactivePowerMeasurementFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#ThreePhaseReactivePowerMeasurementFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseReactivePowerMeasurementNotification"></see>
    /// </summary>
    let ``_.owl#ThreePhaseReactivePowerMeasurementNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#ThreePhaseReactivePowerMeasurementNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseReactivePowerMeasurementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#ThreePhaseReactivePowerMeasurementNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#ThreePhaseReactivePowerMeasurementNotificationFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseReactivePowerMeasurementState"></see>
    /// </summary>
    let ``_.owl#ThreePhaseReactivePowerMeasurementState`` =
        Namespaced_IRI.parse _namespace_name ".owl#ThreePhaseReactivePowerMeasurementState" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseVoltageMeasurementFunctionality"></see>
    /// </summary>
    let ``_.owl#ThreePhaseVoltageMeasurementFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#ThreePhaseVoltageMeasurementFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseVoltageMeasurementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#ThreePhaseVoltageMeasurementNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#ThreePhaseVoltageMeasurementNotificationFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseVoltageState"></see>
    /// </summary>
    let ``_.owl#ThreePhaseVoltageState`` =
        Namespaced_IRI.parse _namespace_name ".owl#ThreePhaseVoltageState" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#TridimensionalAccelerationNotification"></see>
    /// </summary>
    let ``_.owl#TridimensionalAccelerationNotification`` =
        Namespaced_IRI.parse _namespace_name ".owl#TridimensionalAccelerationNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#TridimensionalAccelerationNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#TridimensionalAccelerationNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#TridimensionalAccelerationNotificationFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#TripleSensor"></see>
    /// </summary>
    let ``_.owl#TripleSensor`` =
        Namespaced_IRI.parse _namespace_name ".owl#TripleSensor" |> NamespacedName

    /// <summary>
    /// A device that circulates fresh air and expels stale or foul air.
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#Ventilator"></see></summary>
    let ``_.owl#Ventilator`` =
        Namespaced_IRI.parse _namespace_name ".owl#Ventilator" |> NamespacedName

    /// <summary>
    /// Association between a wallopening(door or window) and the wall opening where it is
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#isInWall"></see></summary>
    let ``_.owl#isInWall`` =
        Namespaced_IRI.parse _namespace_name ".owl#isInWall" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#WashRinseStateValue"></see>
    /// </summary>
    let ``_.owl#WashRinseStateValue`` =
        Namespaced_IRI.parse _namespace_name ".owl#WashRinseStateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#WashingApplianceState"></see>
    /// </summary>
    let ``_.owl#WashingApplianceState`` =
        Namespaced_IRI.parse _namespace_name ".owl#WashingApplianceState" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#WashingCycleNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#WashingCycleNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#WashingCycleNotificationFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#WaterMeasurementFuctionality"></see>
    /// </summary>
    let ``_.owl#WaterMeasurementFuctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#WaterMeasurementFuctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#WaterMeasurementNotificationFunctionality"></see>
    /// </summary>
    let ``_.owl#WaterMeasurementNotificationFunctionality`` =
        Namespaced_IRI.parse _namespace_name ".owl#WaterMeasurementNotificationFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#WaterMeasurementState"></see>
    /// </summary>
    let ``_.owl#WaterMeasurementState`` =
        Namespaced_IRI.parse _namespace_name ".owl#WaterMeasurementState" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#WaterMeter"></see>
    /// </summary>
    let ``_.owl#WaterMeter`` =
        Namespaced_IRI.parse _namespace_name ".owl#WaterMeter" |> NamespacedName

    /// <summary>
    /// Phone with no wire
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#WirelessPhone"></see></summary>
    let ``_.owl#WirelessPhone`` =
        Namespaced_IRI.parse _namespace_name ".owl#WirelessPhone" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ZWaveComponent"></see>
    /// </summary>
    let ``_.owl#ZWaveComponent`` =
        Namespaced_IRI.parse _namespace_name ".owl#ZWaveComponent" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ZWaveGateway"></see>
    /// </summary>
    let ``_.owl#ZWaveGateway`` =
        Namespaced_IRI.parse _namespace_name ".owl#ZWaveGateway" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ZigBeeGateway"></see>
    /// </summary>
    let ``_.owl#ZigBeeGateway`` =
        Namespaced_IRI.parse _namespace_name ".owl#ZigBeeGateway" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#ceilingOf"></see>
    /// </summary>
    let ``_.owl#ceilingOf`` =
        Namespaced_IRI.parse _namespace_name ".owl#ceilingOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#commandOf"></see>
    /// </summary>
    let ``_.owl#commandOf`` =
        Namespaced_IRI.parse _namespace_name ".owl#commandOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#eZ430Chronos"></see>
    /// </summary>
    let ``_.owl#eZ430Chronos`` =
        Namespaced_IRI.parse _namespace_name ".owl#eZ430Chronos" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#floorOf"></see>
    /// </summary>
    let ``_.owl#floorOf`` =
        Namespaced_IRI.parse _namespace_name ".owl#floorOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#generateCommand"></see>
    /// </summary>
    let ``_.owl#generateCommand`` =
        Namespaced_IRI.parse _namespace_name ".owl#generateCommand" |> NamespacedName

    /// <summary>
    /// Association between an object and its controller,e.g.switch,button,knob
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#hasControl"></see></summary>
    let ``_.owl#hasControl`` =
        Namespaced_IRI.parse _namespace_name ".owl#hasControl" |> NamespacedName

    /// <summary>
    /// Relates a given domotic component with the network level gateway used to control it
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#hasGateway"></see></summary>
    let ``_.owl#hasGateway`` =
        Namespaced_IRI.parse _namespace_name ".owl#hasGateway" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#hasMeter"></see>
    /// </summary>
    let ``_.owl#hasMeter`` =
        Namespaced_IRI.parse _namespace_name ".owl#hasMeter" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#meterOf"></see>
    /// </summary>
    let ``_.owl#meterOf`` =
        Namespaced_IRI.parse _namespace_name ".owl#meterOf" |> NamespacedName

    /// <summary>
    /// Association between a room and its walls
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#hasWall"></see></summary>
    let ``_.owl#hasWall`` =
        Namespaced_IRI.parse _namespace_name ".owl#hasWall" |> NamespacedName

    /// <summary>
    /// Association between a wall and its opening like door,window
    /// <see href="http://elite.polito.it/ontologies/dogont.owl#hasWallOpening"></see></summary>
    let ``_.owl#hasWallOpening`` =
        Namespaced_IRI.parse _namespace_name ".owl#hasWallOpening" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#instanceId"></see>
    /// </summary>
    let ``_.owl#instanceId`` =
        Namespaced_IRI.parse _namespace_name ".owl#instanceId" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#nodeId"></see>
    /// </summary>
    let ``_.owl#nodeId`` =
        Namespaced_IRI.parse _namespace_name ".owl#nodeId" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#notificationOf"></see>
    /// </summary>
    let ``_.owl#notificationOf`` =
        Namespaced_IRI.parse _namespace_name ".owl#notificationOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#plugOf"></see>
    /// </summary>
    let ``_.owl#plugOf`` =
        Namespaced_IRI.parse _namespace_name ".owl#plugOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#pluggedIn"></see>
    /// </summary>
    let ``_.owl#pluggedIn`` =
        Namespaced_IRI.parse _namespace_name ".owl#pluggedIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/dogont.owl#statevalueOf"></see>
    /// </summary>
    let ``_.owl#statevalueOf`` =
        Namespaced_IRI.parse _namespace_name ".owl#statevalueOf" |> NamespacedName
