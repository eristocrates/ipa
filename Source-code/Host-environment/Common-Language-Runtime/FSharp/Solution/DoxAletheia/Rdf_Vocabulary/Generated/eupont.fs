namespace http.elite.polito.it.ontologies.eupont.owl.hash

open DoxAletheia.Rdf_Vocabulary

module eupont =
    let _namespace_name = "http://elite.polito.it/ontologies/eupont.owl#"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#CloseNotification"></see>
    /// </summary>
    let CloseNotification =
        Namespaced_IRI.parse _namespace_name "CloseNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ConnectNotification"></see>
    /// </summary>
    let ConnectNotification =
        Namespaced_IRI.parse _namespace_name "ConnectNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeleteNotification"></see>
    /// </summary>
    let DeleteNotification =
        Namespaced_IRI.parse _namespace_name "DeleteNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DisableNotification"></see>
    /// </summary>
    let DisableNotification =
        Namespaced_IRI.parse _namespace_name "DisableNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DisconnectNotification"></see>
    /// </summary>
    let DisconnectNotification =
        Namespaced_IRI.parse _namespace_name "DisconnectNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EnableNotification"></see>
    /// </summary>
    let EnableNotification =
        Namespaced_IRI.parse _namespace_name "EnableNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EnterNotification"></see>
    /// </summary>
    let EnterNotification =
        Namespaced_IRI.parse _namespace_name "EnterNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ExitNotification"></see>
    /// </summary>
    let ExitNotification =
        Namespaced_IRI.parse _namespace_name "ExitNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#MeasureAboveThresholdNotification"></see>
    /// </summary>
    let MeasureAboveThresholdNotification =
        Namespaced_IRI.parse _namespace_name "MeasureAboveThresholdNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#MeasureAvailableNotification"></see>
    /// </summary>
    let MeasureAvailableNotification =
        Namespaced_IRI.parse _namespace_name "MeasureAvailableNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#MeasureBelowThresholdNotification"></see>
    /// </summary>
    let MeasureBelowThresholdNotification =
        Namespaced_IRI.parse _namespace_name "MeasureBelowThresholdNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#NewNotification"></see>
    /// </summary>
    let NewNotification =
        Namespaced_IRI.parse _namespace_name "NewNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#OpenNotification"></see>
    /// </summary>
    let OpenNotification =
        Namespaced_IRI.parse _namespace_name "OpenNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#PresenceDetectedNotification"></see>
    /// </summary>
    let PresenceDetectedNotification =
        Namespaced_IRI.parse _namespace_name "PresenceDetectedNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#PresenceNoLongerDetectedNotification"></see>
    /// </summary>
    let PresenceNoLongerDetectedNotification =
        Namespaced_IRI.parse _namespace_name "PresenceNoLongerDetectedNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ReceiveNotification"></see>
    /// </summary>
    let ReceiveNotification =
        Namespaced_IRI.parse _namespace_name "ReceiveNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#RecordNotification"></see>
    /// </summary>
    let RecordNotification =
        Namespaced_IRI.parse _namespace_name "RecordNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SaveNotification"></see>
    /// </summary>
    let SaveNotification =
        Namespaced_IRI.parse _namespace_name "SaveNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SendNotification"></see>
    /// </summary>
    let SendNotification =
        Namespaced_IRI.parse _namespace_name "SendNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SetToNotification"></see>
    /// </summary>
    let SetToNotification =
        Namespaced_IRI.parse _namespace_name "SetToNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ShareNotification"></see>
    /// </summary>
    let ShareNotification =
        Namespaced_IRI.parse _namespace_name "ShareNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartNotification"></see>
    /// </summary>
    let StartNotification =
        Namespaced_IRI.parse _namespace_name "StartNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StopNotification"></see>
    /// </summary>
    let StopNotification =
        Namespaced_IRI.parse _namespace_name "StopNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#TurnOffNotification"></see>
    /// </summary>
    let TurnOffNotification =
        Namespaced_IRI.parse _namespace_name "TurnOffNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#TurnOnNotification"></see>
    /// </summary>
    let TurnOnNotification =
        Namespaced_IRI.parse _namespace_name "TurnOnNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#CloseCommand"></see>
    /// </summary>
    let CloseCommand =
        Namespaced_IRI.parse _namespace_name "CloseCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ConnectCommand"></see>
    /// </summary>
    let ConnectCommand =
        Namespaced_IRI.parse _namespace_name "ConnectCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeleteCommand"></see>
    /// </summary>
    let DeleteCommand =
        Namespaced_IRI.parse _namespace_name "DeleteCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DisableCommand"></see>
    /// </summary>
    let DisableCommand =
        Namespaced_IRI.parse _namespace_name "DisableCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DisconnectCommand"></see>
    /// </summary>
    let DisconnectCommand =
        Namespaced_IRI.parse _namespace_name "DisconnectCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EnableCommand"></see>
    /// </summary>
    let EnableCommand =
        Namespaced_IRI.parse _namespace_name "EnableCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#NewCommand"></see>
    /// </summary>
    let NewCommand = Namespaced_IRI.parse _namespace_name "NewCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#OpenCommand"></see>
    /// </summary>
    let OpenCommand =
        Namespaced_IRI.parse _namespace_name "OpenCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#RecordCommand"></see>
    /// </summary>
    let RecordCommand =
        Namespaced_IRI.parse _namespace_name "RecordCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SaveCommand"></see>
    /// </summary>
    let SaveCommand =
        Namespaced_IRI.parse _namespace_name "SaveCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SendCommand"></see>
    /// </summary>
    let SendCommand =
        Namespaced_IRI.parse _namespace_name "SendCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SetToCommand"></see>
    /// </summary>
    let SetToCommand =
        Namespaced_IRI.parse _namespace_name "SetToCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ShareCommand"></see>
    /// </summary>
    let ShareCommand =
        Namespaced_IRI.parse _namespace_name "ShareCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartCommand"></see>
    /// </summary>
    let StartCommand =
        Namespaced_IRI.parse _namespace_name "StartCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StopCommand"></see>
    /// </summary>
    let StopCommand =
        Namespaced_IRI.parse _namespace_name "StopCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ToggleCommand"></see>
    /// </summary>
    let ToggleCommand =
        Namespaced_IRI.parse _namespace_name "ToggleCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#TurnOffCommand"></see>
    /// </summary>
    let TurnOffCommand =
        Namespaced_IRI.parse _namespace_name "TurnOffCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#TurnOnCommand"></see>
    /// </summary>
    let TurnOnCommand =
        Namespaced_IRI.parse _namespace_name "TurnOnCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#AcceptCommunicationAction"></see>
    /// </summary>
    let AcceptCommunicationAction =
        Namespaced_IRI.parse _namespace_name "AcceptCommunicationAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#GetAction"></see>
    /// </summary>
    let GetAction = Namespaced_IRI.parse _namespace_name "GetAction" |> NamespacedName
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Action"></see>
    /// </summary>
    let Action = Namespaced_IRI.parse _namespace_name "Action" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#RuleNominalAxiom"></see>
    /// </summary>
    let RuleNominalAxiom =
        Namespaced_IRI.parse _namespace_name "RuleNominalAxiom" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ActivateEnvironmentSceneAction"></see>
    /// </summary>
    let ActivateEnvironmentSceneAction =
        Namespaced_IRI.parse _namespace_name "ActivateEnvironmentSceneAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SetEnvironmentComfortAction"></see>
    /// </summary>
    let SetEnvironmentComfortAction =
        Namespaced_IRI.parse _namespace_name "SetEnvironmentComfortAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ActivityAction"></see>
    /// </summary>
    let ActivityAction =
        Namespaced_IRI.parse _namespace_name "ActivityAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ActivityTrigger"></see>
    /// </summary>
    let ActivityTrigger =
        Namespaced_IRI.parse _namespace_name "ActivityTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Trigger"></see>
    /// </summary>
    let Trigger = Namespaced_IRI.parse _namespace_name "Trigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#AddAlarmAction"></see>
    /// </summary>
    let AddAlarmAction =
        Namespaced_IRI.parse _namespace_name "AddAlarmAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#AddRemindAction"></see>
    /// </summary>
    let AddRemindAction =
        Namespaced_IRI.parse _namespace_name "AddRemindAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#AddCalendarItemAction"></see>
    /// </summary>
    let AddCalendarItemAction =
        Namespaced_IRI.parse _namespace_name "AddCalendarItemAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SaveAction"></see>
    /// </summary>
    let SaveAction = Namespaced_IRI.parse _namespace_name "SaveAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#AddReminderAction"></see>
    /// </summary>
    let AddReminderAction =
        Namespaced_IRI.parse _namespace_name "AddReminderAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#AddTimerAction"></see>
    /// </summary>
    let AddTimerAction =
        Namespaced_IRI.parse _namespace_name "AddTimerAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#AddedAlarmTrigger"></see>
    /// </summary>
    let AddedAlarmTrigger =
        Namespaced_IRI.parse _namespace_name "AddedAlarmTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#AddedRemindTrigger"></see>
    /// </summary>
    let AddedRemindTrigger =
        Namespaced_IRI.parse _namespace_name "AddedRemindTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#AddedCalendarItemTrigger"></see>
    /// </summary>
    let AddedCalendarItemTrigger =
        Namespaced_IRI.parse _namespace_name "AddedCalendarItemTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SavedTrigger"></see>
    /// </summary>
    let SavedTrigger =
        Namespaced_IRI.parse _namespace_name "SavedTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#AddedReminderTrigger"></see>
    /// </summary>
    let AddedReminderTrigger =
        Namespaced_IRI.parse _namespace_name "AddedReminderTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#AddedTimerTrigger"></see>
    /// </summary>
    let AddedTimerTrigger =
        Namespaced_IRI.parse _namespace_name "AddedTimerTrigger" |> NamespacedName

    /// <summary>
    /// An agent (eg. person, group, software or physical artifact).
    /// <see href="http://elite.polito.it/ontologies/eupont.owl#Agent"></see></summary>
    let Agent = Namespaced_IRI.parse _namespace_name "Agent" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#AirConditioner"></see>
    /// </summary>
    let AirConditioner =
        Namespaced_IRI.parse _namespace_name "AirConditioner" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SmartEnvironmentSystem"></see>
    /// </summary>
    let SmartEnvironmentSystem =
        Namespaced_IRI.parse _namespace_name "SmartEnvironmentSystem" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#AirMonitor"></see>
    /// </summary>
    let AirMonitor = Namespaced_IRI.parse _namespace_name "AirMonitor" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#AirPressureService"></see>
    /// </summary>
    let AirPressureService =
        Namespaced_IRI.parse _namespace_name "AirPressureService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SmartEnvironmentService"></see>
    /// </summary>
    let SmartEnvironmentService =
        Namespaced_IRI.parse _namespace_name "SmartEnvironmentService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#AirPurifier"></see>
    /// </summary>
    let AirPurifier =
        Namespaced_IRI.parse _namespace_name "AirPurifier" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#AirPurifierDisabledTrigger"></see>
    /// </summary>
    let AirPurifierDisabledTrigger =
        Namespaced_IRI.parse _namespace_name "AirPurifierDisabledTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DecreasedAirQualityTrigger"></see>
    /// </summary>
    let DecreasedAirQualityTrigger =
        Namespaced_IRI.parse _namespace_name "DecreasedAirQualityTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#AirPurifierEnabledTrigger"></see>
    /// </summary>
    let AirPurifierEnabledTrigger =
        Namespaced_IRI.parse _namespace_name "AirPurifierEnabledTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#IncreasedAirQualityTrigger"></see>
    /// </summary>
    let IncreasedAirQualityTrigger =
        Namespaced_IRI.parse _namespace_name "IncreasedAirQualityTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#AirPurifierService"></see>
    /// </summary>
    let AirPurifierService =
        Namespaced_IRI.parse _namespace_name "AirPurifierService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#AlarmClockService"></see>
    /// </summary>
    let AlarmClockService =
        Namespaced_IRI.parse _namespace_name "AlarmClockService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#TimeService"></see>
    /// </summary>
    let TimeService =
        Namespaced_IRI.parse _namespace_name "TimeService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#AnswerCallAction"></see>
    /// </summary>
    let AnswerCallAction =
        Namespaced_IRI.parse _namespace_name "AnswerCallAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#AntiIntrusionSystem"></see>
    /// </summary>
    let AntiIntrusionSystem =
        Namespaced_IRI.parse _namespace_name "AntiIntrusionSystem" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Appliance"></see>
    /// </summary>
    let Appliance = Namespaced_IRI.parse _namespace_name "Appliance" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#PhysicalObject"></see>
    /// </summary>
    let PhysicalObject =
        Namespaced_IRI.parse _namespace_name "PhysicalObject" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ApplianceService"></see>
    /// </summary>
    let ApplianceService =
        Namespaced_IRI.parse _namespace_name "ApplianceService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Service"></see>
    /// </summary>
    let Service = Namespaced_IRI.parse _namespace_name "Service" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ArriveOnVehicleTrigger"></see>
    /// </summary>
    let ArriveOnVehicleTrigger =
        Namespaced_IRI.parse _namespace_name "ArriveOnVehicleTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EnterTrigger"></see>
    /// </summary>
    let EnterTrigger =
        Namespaced_IRI.parse _namespace_name "EnterTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#AttachementService"></see>
    /// </summary>
    let AttachementService =
        Namespaced_IRI.parse _namespace_name "AttachementService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#InformationService"></see>
    /// </summary>
    let InformationService =
        Namespaced_IRI.parse _namespace_name "InformationService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#CommunicationService"></see>
    /// </summary>
    let CommunicationService =
        Namespaced_IRI.parse _namespace_name "CommunicationService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#AudioRecordingService"></see>
    /// </summary>
    let AudioRecordingService =
        Namespaced_IRI.parse _namespace_name "AudioRecordingService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#RecordingService"></see>
    /// </summary>
    let RecordingService =
        Namespaced_IRI.parse _namespace_name "RecordingService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#AudioService"></see>
    /// </summary>
    let AudioService =
        Namespaced_IRI.parse _namespace_name "AudioService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#OutputService"></see>
    /// </summary>
    let OutputService =
        Namespaced_IRI.parse _namespace_name "OutputService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#BatteryService"></see>
    /// </summary>
    let BatteryService =
        Namespaced_IRI.parse _namespace_name "BatteryService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeviceService"></see>
    /// </summary>
    let DeviceService =
        Namespaced_IRI.parse _namespace_name "DeviceService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Beacon"></see>
    /// </summary>
    let Beacon = Namespaced_IRI.parse _namespace_name "Beacon" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#BikeTrackingService"></see>
    /// </summary>
    let BikeTrackingService =
        Namespaced_IRI.parse _namespace_name "BikeTrackingService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#TrackingService"></see>
    /// </summary>
    let TrackingService =
        Namespaced_IRI.parse _namespace_name "TrackingService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#BlockCallAction"></see>
    /// </summary>
    let BlockCallAction =
        Namespaced_IRI.parse _namespace_name "BlockCallAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DecreaseUserConnectivityAction"></see>
    /// </summary>
    let DecreaseUserConnectivityAction =
        Namespaced_IRI.parse _namespace_name "DecreaseUserConnectivityAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Blog"></see>
    /// </summary>
    let Blog = Namespaced_IRI.parse _namespace_name "Blog" |> NamespacedName
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#NewsTool"></see>
    /// </summary>
    let NewsTool = Namespaced_IRI.parse _namespace_name "NewsTool" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#BluetoothService"></see>
    /// </summary>
    let BluetoothService =
        Namespaced_IRI.parse _namespace_name "BluetoothService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#NetworkService"></see>
    /// </summary>
    let NetworkService =
        Namespaced_IRI.parse _namespace_name "NetworkService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#BrightnessDecreasedTrigger"></see>
    /// </summary>
    let BrightnessDecreasedTrigger =
        Namespaced_IRI.parse _namespace_name "BrightnessDecreasedTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ImprovedLightingConditionTrigger"></see>
    /// </summary>
    let ImprovedLightingConditionTrigger =
        Namespaced_IRI.parse _namespace_name "ImprovedLightingConditionTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#BrightnessIncreasedTrigger"></see>
    /// </summary>
    let BrightnessIncreasedTrigger =
        Namespaced_IRI.parse _namespace_name "BrightnessIncreasedTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Building"></see>
    /// </summary>
    let Building = Namespaced_IRI.parse _namespace_name "Building" |> NamespacedName
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Location"></see>
    /// </summary>
    let Location = Namespaced_IRI.parse _namespace_name "Location" |> NamespacedName
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#BuyCommand"></see>
    /// </summary>
    let BuyCommand = Namespaced_IRI.parse _namespace_name "BuyCommand" |> NamespacedName
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Command"></see>
    /// </summary>
    let Command = Namespaced_IRI.parse _namespace_name "Command" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#CalendarService"></see>
    /// </summary>
    let CalendarService =
        Namespaced_IRI.parse _namespace_name "CalendarService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#CalendarTool"></see>
    /// </summary>
    let CalendarTool =
        Namespaced_IRI.parse _namespace_name "CalendarTool" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#OrganizerTool"></see>
    /// </summary>
    let OrganizerTool =
        Namespaced_IRI.parse _namespace_name "OrganizerTool" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#CallService"></see>
    /// </summary>
    let CallService =
        Namespaced_IRI.parse _namespace_name "CallService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#CallTool"></see>
    /// </summary>
    let CallTool = Namespaced_IRI.parse _namespace_name "CallTool" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#CommunicationTool"></see>
    /// </summary>
    let CommunicationTool =
        Namespaced_IRI.parse _namespace_name "CommunicationTool" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Camera"></see>
    /// </summary>
    let Camera = Namespaced_IRI.parse _namespace_name "Camera" |> NamespacedName
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Category"></see>
    /// </summary>
    let Category = Namespaced_IRI.parse _namespace_name "Category" |> NamespacedName
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Channel"></see>
    /// </summary>
    let Channel = Namespaced_IRI.parse _namespace_name "Channel" |> NamespacedName
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ChatTool"></see>
    /// </summary>
    let ChatTool = Namespaced_IRI.parse _namespace_name "ChatTool" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Notification"></see>
    /// </summary>
    let Notification =
        Namespaced_IRI.parse _namespace_name "Notification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#CloseSafetyValveAction"></see>
    /// </summary>
    let CloseSafetyValveAction =
        Namespaced_IRI.parse _namespace_name "CloseSafetyValveAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#IncreaseSecurityAction"></see>
    /// </summary>
    let IncreaseSecurityAction =
        Namespaced_IRI.parse _namespace_name "IncreaseSecurityAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#CloseWindowFrameAction"></see>
    /// </summary>
    let CloseWindowFrameAction =
        Namespaced_IRI.parse _namespace_name "CloseWindowFrameAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#IncreaseTemperatureAction"></see>
    /// </summary>
    let IncreaseTemperatureAction =
        Namespaced_IRI.parse _namespace_name "IncreaseTemperatureAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DecreaseLightingAction"></see>
    /// </summary>
    let DecreaseLightingAction =
        Namespaced_IRI.parse _namespace_name "DecreaseLightingAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#CloudPlatform"></see>
    /// </summary>
    let CloudPlatform =
        Namespaced_IRI.parse _namespace_name "CloudPlatform" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StoragePlatform"></see>
    /// </summary>
    let StoragePlatform =
        Namespaced_IRI.parse _namespace_name "StoragePlatform" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#CodeHostingPlatform"></see>
    /// </summary>
    let CodeHostingPlatform =
        Namespaced_IRI.parse _namespace_name "CodeHostingPlatform" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeveloperTool"></see>
    /// </summary>
    let DeveloperTool =
        Namespaced_IRI.parse _namespace_name "DeveloperTool" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#CoffeeMaker"></see>
    /// </summary>
    let CoffeeMaker =
        Namespaced_IRI.parse _namespace_name "CoffeeMaker" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#CoffeeService"></see>
    /// </summary>
    let CoffeeService =
        Namespaced_IRI.parse _namespace_name "CoffeeService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Colleague"></see>
    /// </summary>
    let Colleague = Namespaced_IRI.parse _namespace_name "Colleague" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#CommentService"></see>
    /// </summary>
    let CommentService =
        Namespaced_IRI.parse _namespace_name "CommentService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#VirtualObject"></see>
    /// </summary>
    let VirtualObject =
        Namespaced_IRI.parse _namespace_name "VirtualObject" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ConnectDeviceAction"></see>
    /// </summary>
    let ConnectDeviceAction =
        Namespaced_IRI.parse _namespace_name "ConnectDeviceAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#IncreaseConnectivityAction"></see>
    /// </summary>
    let IncreaseConnectivityAction =
        Namespaced_IRI.parse _namespace_name "IncreaseConnectivityAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ConnectToDeviceAction"></see>
    /// </summary>
    let ConnectToDeviceAction =
        Namespaced_IRI.parse _namespace_name "ConnectToDeviceAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ConnectToNetworkAction"></see>
    /// </summary>
    let ConnectToNetworkAction =
        Namespaced_IRI.parse _namespace_name "ConnectToNetworkAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ConnectToWebServiceAction"></see>
    /// </summary>
    let ConnectToWebServiceAction =
        Namespaced_IRI.parse _namespace_name "ConnectToWebServiceAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ConnectedVehicle"></see>
    /// </summary>
    let ConnectedVehicle =
        Namespaced_IRI.parse _namespace_name "ConnectedVehicle" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SmartCitySystem"></see>
    /// </summary>
    let SmartCitySystem =
        Namespaced_IRI.parse _namespace_name "SmartCitySystem" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ConnectionToDeviceTrigger"></see>
    /// </summary>
    let ConnectionToDeviceTrigger =
        Namespaced_IRI.parse _namespace_name "ConnectionToDeviceTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeviceConnectedTrigger"></see>
    /// </summary>
    let DeviceConnectedTrigger =
        Namespaced_IRI.parse _namespace_name "DeviceConnectedTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ConnectionToNetworkTrigger"></see>
    /// </summary>
    let ConnectionToNetworkTrigger =
        Namespaced_IRI.parse _namespace_name "ConnectionToNetworkTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ConnectivityAction"></see>
    /// </summary>
    let ConnectivityAction =
        Namespaced_IRI.parse _namespace_name "ConnectivityAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ConnectivityTrigger"></see>
    /// </summary>
    let ConnectivityTrigger =
        Namespaced_IRI.parse _namespace_name "ConnectivityTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Console"></see>
    /// </summary>
    let Console = Namespaced_IRI.parse _namespace_name "Console" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ContactService"></see>
    /// </summary>
    let ContactService =
        Namespaced_IRI.parse _namespace_name "ContactService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Cooker"></see>
    /// </summary>
    let Cooker = Namespaced_IRI.parse _namespace_name "Cooker" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#CoolingService"></see>
    /// </summary>
    let CoolingService =
        Namespaced_IRI.parse _namespace_name "CoolingService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#CoolingSystemDisabledTrigger"></see>
    /// </summary>
    let CoolingSystemDisabledTrigger =
        Namespaced_IRI.parse _namespace_name "CoolingSystemDisabledTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#IncreasedTemperatureTrigger"></see>
    /// </summary>
    let IncreasedTemperatureTrigger =
        Namespaced_IRI.parse _namespace_name "IncreasedTemperatureTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#CoolingSystemEnabledTrigger"></see>
    /// </summary>
    let CoolingSystemEnabledTrigger =
        Namespaced_IRI.parse _namespace_name "CoolingSystemEnabledTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DecreasedTemperatureTrigger"></see>
    /// </summary>
    let DecreasedTemperatureTrigger =
        Namespaced_IRI.parse _namespace_name "DecreasedTemperatureTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DIYElectronic"></see>
    /// </summary>
    let DIYElectronic =
        Namespaced_IRI.parse _namespace_name "DIYElectronic" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DangerousActivityDetectedTrigger"></see>
    /// </summary>
    let DangerousActivityDetectedTrigger =
        Namespaced_IRI.parse _namespace_name "DangerousActivityDetectedTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#UnhealthyActivityTrigger"></see>
    /// </summary>
    let UnhealthyActivityTrigger =
        Namespaced_IRI.parse _namespace_name "UnhealthyActivityTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DangerousActivityTrackingService"></see>
    /// </summary>
    let DangerousActivityTrackingService =
        Namespaced_IRI.parse _namespace_name "DangerousActivityTrackingService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DecreaseAirQualityAction"></see>
    /// </summary>
    let DecreaseAirQualityAction =
        Namespaced_IRI.parse _namespace_name "DecreaseAirQualityAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DecreaseEnvironmentConditionAction"></see>
    /// </summary>
    let DecreaseEnvironmentConditionAction =
        Namespaced_IRI.parse _namespace_name "DecreaseEnvironmentConditionAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DecreaseConnectivityAction"></see>
    /// </summary>
    let DecreaseConnectivityAction =
        Namespaced_IRI.parse _namespace_name "DecreaseConnectivityAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EnvironmentAction"></see>
    /// </summary>
    let EnvironmentAction =
        Namespaced_IRI.parse _namespace_name "EnvironmentAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DecreaseHumidityAction"></see>
    /// </summary>
    let DecreaseHumidityAction =
        Namespaced_IRI.parse _namespace_name "DecreaseHumidityAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DecreaseNoiseAction"></see>
    /// </summary>
    let DecreaseNoiseAction =
        Namespaced_IRI.parse _namespace_name "DecreaseNoiseAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DecreaseSecurityAction"></see>
    /// </summary>
    let DecreaseSecurityAction =
        Namespaced_IRI.parse _namespace_name "DecreaseSecurityAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DecreaseTemperatureAction"></see>
    /// </summary>
    let DecreaseTemperatureAction =
        Namespaced_IRI.parse _namespace_name "DecreaseTemperatureAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DecreaseVolumeAction"></see>
    /// </summary>
    let DecreaseVolumeAction =
        Namespaced_IRI.parse _namespace_name "DecreaseVolumeAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DecreasedAirPressureTrigger"></see>
    /// </summary>
    let DecreasedAirPressureTrigger =
        Namespaced_IRI.parse _namespace_name "DecreasedAirPressureTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EnvironmentConditionDecreasedTrigger"></see>
    /// </summary>
    let EnvironmentConditionDecreasedTrigger =
        Namespaced_IRI.parse _namespace_name "EnvironmentConditionDecreasedTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DecreasedConnectivityTrigger"></see>
    /// </summary>
    let DecreasedConnectivityTrigger =
        Namespaced_IRI.parse _namespace_name "DecreasedConnectivityTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DecreasedHealthConditionTrigger"></see>
    /// </summary>
    let DecreasedHealthConditionTrigger =
        Namespaced_IRI.parse _namespace_name "DecreasedHealthConditionTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#HealthTrigger"></see>
    /// </summary>
    let HealthTrigger =
        Namespaced_IRI.parse _namespace_name "HealthTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DecreasedHumidityTrigger"></see>
    /// </summary>
    let DecreasedHumidityTrigger =
        Namespaced_IRI.parse _namespace_name "DecreasedHumidityTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DecreasedLightingTrigger"></see>
    /// </summary>
    let DecreasedLightingTrigger =
        Namespaced_IRI.parse _namespace_name "DecreasedLightingTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DecreasedNoiseLevelTrigger"></see>
    /// </summary>
    let DecreasedNoiseLevelTrigger =
        Namespaced_IRI.parse _namespace_name "DecreasedNoiseLevelTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DecreasedSecurityTrigger"></see>
    /// </summary>
    let DecreasedSecurityTrigger =
        Namespaced_IRI.parse _namespace_name "DecreasedSecurityTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DecreasedWeatherConditionsTrigger"></see>
    /// </summary>
    let DecreasedWeatherConditionsTrigger =
        Namespaced_IRI.parse _namespace_name "DecreasedWeatherConditionsTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Dehumidifier"></see>
    /// </summary>
    let Dehumidifier =
        Namespaced_IRI.parse _namespace_name "Dehumidifier" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DehumidifierService"></see>
    /// </summary>
    let DehumidifierService =
        Namespaced_IRI.parse _namespace_name "DehumidifierService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DehumidifierSystemDisabledTrigger"></see>
    /// </summary>
    let DehumidifierSystemDisabledTrigger =
        Namespaced_IRI.parse _namespace_name "DehumidifierSystemDisabledTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#IncreasedHumidityTrigger"></see>
    /// </summary>
    let IncreasedHumidityTrigger =
        Namespaced_IRI.parse _namespace_name "IncreasedHumidityTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DehumidifierSystemEnabledTrigger"></see>
    /// </summary>
    let DehumidifierSystemEnabledTrigger =
        Namespaced_IRI.parse _namespace_name "DehumidifierSystemEnabledTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeleteAction"></see>
    /// </summary>
    let DeleteAction =
        Namespaced_IRI.parse _namespace_name "DeleteAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#InformationAction"></see>
    /// </summary>
    let InformationAction =
        Namespaced_IRI.parse _namespace_name "InformationAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeleteAlarmAction"></see>
    /// </summary>
    let DeleteAlarmAction =
        Namespaced_IRI.parse _namespace_name "DeleteAlarmAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeleteRemindAction"></see>
    /// </summary>
    let DeleteRemindAction =
        Namespaced_IRI.parse _namespace_name "DeleteRemindAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeleteCalendarItemAction"></see>
    /// </summary>
    let DeleteCalendarItemAction =
        Namespaced_IRI.parse _namespace_name "DeleteCalendarItemAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeleteContactAction"></see>
    /// </summary>
    let DeleteContactAction =
        Namespaced_IRI.parse _namespace_name "DeleteContactAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeleteFromStorageAction"></see>
    /// </summary>
    let DeleteFromStorageAction =
        Namespaced_IRI.parse _namespace_name "DeleteFromStorageAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeleteFileAction"></see>
    /// </summary>
    let DeleteFileAction =
        Namespaced_IRI.parse _namespace_name "DeleteFileAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeleteHealthInformationAction"></see>
    /// </summary>
    let DeleteHealthInformationAction =
        Namespaced_IRI.parse _namespace_name "DeleteHealthInformationAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeleteMediaInformationAction"></see>
    /// </summary>
    let DeleteMediaInformationAction =
        Namespaced_IRI.parse _namespace_name "DeleteMediaInformationAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeleteReminderAction"></see>
    /// </summary>
    let DeleteReminderAction =
        Namespaced_IRI.parse _namespace_name "DeleteReminderAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeleteTimerAction"></see>
    /// </summary>
    let DeleteTimerAction =
        Namespaced_IRI.parse _namespace_name "DeleteTimerAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeleteWebBookmarkAction"></see>
    /// </summary>
    let DeleteWebBookmarkAction =
        Namespaced_IRI.parse _namespace_name "DeleteWebBookmarkAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeletedAlarmTrigger"></see>
    /// </summary>
    let DeletedAlarmTrigger =
        Namespaced_IRI.parse _namespace_name "DeletedAlarmTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeletedRemindTrigger"></see>
    /// </summary>
    let DeletedRemindTrigger =
        Namespaced_IRI.parse _namespace_name "DeletedRemindTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeletedAppTrigger"></see>
    /// </summary>
    let DeletedAppTrigger =
        Namespaced_IRI.parse _namespace_name "DeletedAppTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeletedFromStorageTrigger"></see>
    /// </summary>
    let DeletedFromStorageTrigger =
        Namespaced_IRI.parse _namespace_name "DeletedFromStorageTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeletedCalendarItemTrigger"></see>
    /// </summary>
    let DeletedCalendarItemTrigger =
        Namespaced_IRI.parse _namespace_name "DeletedCalendarItemTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeletedContactTrigger"></see>
    /// </summary>
    let DeletedContactTrigger =
        Namespaced_IRI.parse _namespace_name "DeletedContactTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeletedFileTrigger"></see>
    /// </summary>
    let DeletedFileTrigger =
        Namespaced_IRI.parse _namespace_name "DeletedFileTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeletedTrigger"></see>
    /// </summary>
    let DeletedTrigger =
        Namespaced_IRI.parse _namespace_name "DeletedTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeletedHealthInformationTrigger"></see>
    /// </summary>
    let DeletedHealthInformationTrigger =
        Namespaced_IRI.parse _namespace_name "DeletedHealthInformationTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeletedMediaInformationTrigger"></see>
    /// </summary>
    let DeletedMediaInformationTrigger =
        Namespaced_IRI.parse _namespace_name "DeletedMediaInformationTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeletedReminderTrigger"></see>
    /// </summary>
    let DeletedReminderTrigger =
        Namespaced_IRI.parse _namespace_name "DeletedReminderTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeletedTimerTrigger"></see>
    /// </summary>
    let DeletedTimerTrigger =
        Namespaced_IRI.parse _namespace_name "DeletedTimerTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#InformationTrigger"></see>
    /// </summary>
    let InformationTrigger =
        Namespaced_IRI.parse _namespace_name "InformationTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeletedWebBookmarkTrigger"></see>
    /// </summary>
    let DeletedWebBookmarkTrigger =
        Namespaced_IRI.parse _namespace_name "DeletedWebBookmarkTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Detail"></see>
    /// </summary>
    let Detail = Namespaced_IRI.parse _namespace_name "Detail" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeviceAction"></see>
    /// </summary>
    let DeviceAction =
        Namespaced_IRI.parse _namespace_name "DeviceAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EnhancedConnectivityTrigger"></see>
    /// </summary>
    let EnhancedConnectivityTrigger =
        Namespaced_IRI.parse _namespace_name "EnhancedConnectivityTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeviceConnectivityDisabledTrigger"></see>
    /// </summary>
    let DeviceConnectivityDisabledTrigger =
        Namespaced_IRI.parse _namespace_name "DeviceConnectivityDisabledTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeviceConnectivityEnabledTrigger"></see>
    /// </summary>
    let DeviceConnectivityEnabledTrigger =
        Namespaced_IRI.parse _namespace_name "DeviceConnectivityEnabledTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeviceDisconnectedTrigger"></see>
    /// </summary>
    let DeviceDisconnectedTrigger =
        Namespaced_IRI.parse _namespace_name "DeviceDisconnectedTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeviceFailureTrigger"></see>
    /// </summary>
    let DeviceFailureTrigger =
        Namespaced_IRI.parse _namespace_name "DeviceFailureTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#WorseFunctionalityTrigger"></see>
    /// </summary>
    let WorseFunctionalityTrigger =
        Namespaced_IRI.parse _namespace_name "WorseFunctionalityTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeviceLeakTrigger"></see>
    /// </summary>
    let DeviceLeakTrigger =
        Namespaced_IRI.parse _namespace_name "DeviceLeakTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DevicePluggedTrigger"></see>
    /// </summary>
    let DevicePluggedTrigger =
        Namespaced_IRI.parse _namespace_name "DevicePluggedTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ImprovedConsumptionConditionTrigger"></see>
    /// </summary>
    let ImprovedConsumptionConditionTrigger =
        Namespaced_IRI.parse _namespace_name "ImprovedConsumptionConditionTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeviceSavingModeDisabledTrigger"></see>
    /// </summary>
    let DeviceSavingModeDisabledTrigger =
        Namespaced_IRI.parse _namespace_name "DeviceSavingModeDisabledTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeviceSavingModeEnabledTrigger"></see>
    /// </summary>
    let DeviceSavingModeEnabledTrigger =
        Namespaced_IRI.parse _namespace_name "DeviceSavingModeEnabledTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#WorseConsumptionConditionTrigger"></see>
    /// </summary>
    let WorseConsumptionConditionTrigger =
        Namespaced_IRI.parse _namespace_name "WorseConsumptionConditionTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeviceTrigger"></see>
    /// </summary>
    let DeviceTrigger =
        Namespaced_IRI.parse _namespace_name "DeviceTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeviceTurnedOffTrigger"></see>
    /// </summary>
    let DeviceTurnedOffTrigger =
        Namespaced_IRI.parse _namespace_name "DeviceTurnedOffTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#UserConnectivityDecreasedTrigger"></see>
    /// </summary>
    let UserConnectivityDecreasedTrigger =
        Namespaced_IRI.parse _namespace_name "UserConnectivityDecreasedTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeviceTurnedOnTrigger"></see>
    /// </summary>
    let DeviceTurnedOnTrigger =
        Namespaced_IRI.parse _namespace_name "DeviceTurnedOnTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#UserConnectivityIncreasedTrigger"></see>
    /// </summary>
    let UserConnectivityIncreasedTrigger =
        Namespaced_IRI.parse _namespace_name "UserConnectivityIncreasedTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeviceUnpluggedTrigger"></see>
    /// </summary>
    let DeviceUnpluggedTrigger =
        Namespaced_IRI.parse _namespace_name "DeviceUnpluggedTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeviceUsageWarningTrigger"></see>
    /// </summary>
    let DeviceUsageWarningTrigger =
        Namespaced_IRI.parse _namespace_name "DeviceUsageWarningTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DisableAirPurifierSystemAction"></see>
    /// </summary>
    let DisableAirPurifierSystemAction =
        Namespaced_IRI.parse _namespace_name "DisableAirPurifierSystemAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DisableAirplaneModeAction"></see>
    /// </summary>
    let DisableAirplaneModeAction =
        Namespaced_IRI.parse _namespace_name "DisableAirplaneModeAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EnableDeviceConnectivityAction"></see>
    /// </summary>
    let EnableDeviceConnectivityAction =
        Namespaced_IRI.parse _namespace_name "EnableDeviceConnectivityAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DisableBluetoothConnectivityAction"></see>
    /// </summary>
    let DisableBluetoothConnectivityAction =
        Namespaced_IRI.parse _namespace_name "DisableBluetoothConnectivityAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DisableDeviceConnectivityAction"></see>
    /// </summary>
    let DisableDeviceConnectivityAction =
        Namespaced_IRI.parse _namespace_name "DisableDeviceConnectivityAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DisableCoolingSystemAction"></see>
    /// </summary>
    let DisableCoolingSystemAction =
        Namespaced_IRI.parse _namespace_name "DisableCoolingSystemAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DisableDehumidifierSystemAction"></see>
    /// </summary>
    let DisableDehumidifierSystemAction =
        Namespaced_IRI.parse _namespace_name "DisableDehumidifierSystemAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#IncreaseHumidityAction"></see>
    /// </summary>
    let IncreaseHumidityAction =
        Namespaced_IRI.parse _namespace_name "IncreaseHumidityAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DisableDeviceSavingModeAction"></see>
    /// </summary>
    let DisableDeviceSavingModeAction =
        Namespaced_IRI.parse _namespace_name "DisableDeviceSavingModeAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#WorseConsumptionConditionAction"></see>
    /// </summary>
    let WorseConsumptionConditionAction =
        Namespaced_IRI.parse _namespace_name "WorseConsumptionConditionAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DisableGPSAction"></see>
    /// </summary>
    let DisableGPSAction =
        Namespaced_IRI.parse _namespace_name "DisableGPSAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DisableHeatingSystemAction"></see>
    /// </summary>
    let DisableHeatingSystemAction =
        Namespaced_IRI.parse _namespace_name "DisableHeatingSystemAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DisableHumidifierSystemAction"></see>
    /// </summary>
    let DisableHumidifierSystemAction =
        Namespaced_IRI.parse _namespace_name "DisableHumidifierSystemAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DisableInternetConnectivityAction"></see>
    /// </summary>
    let DisableInternetConnectivityAction =
        Namespaced_IRI.parse _namespace_name "DisableInternetConnectivityAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DisableLightingSystemAction"></see>
    /// </summary>
    let DisableLightingSystemAction =
        Namespaced_IRI.parse _namespace_name "DisableLightingSystemAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DisableNFCConnectivityAction"></see>
    /// </summary>
    let DisableNFCConnectivityAction =
        Namespaced_IRI.parse _namespace_name "DisableNFCConnectivityAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DisableNightModeAction"></see>
    /// </summary>
    let DisableNightModeAction =
        Namespaced_IRI.parse _namespace_name "DisableNightModeAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ImproveLightingConditionAction"></see>
    /// </summary>
    let ImproveLightingConditionAction =
        Namespaced_IRI.parse _namespace_name "ImproveLightingConditionAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DisableNotificationsAction"></see>
    /// </summary>
    let DisableNotificationsAction =
        Namespaced_IRI.parse _namespace_name "DisableNotificationsAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DisableScreenRotationAction"></see>
    /// </summary>
    let DisableScreenRotationAction =
        Namespaced_IRI.parse _namespace_name "DisableScreenRotationAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#WorseUsabilityConditionAction"></see>
    /// </summary>
    let WorseUsabilityConditionAction =
        Namespaced_IRI.parse _namespace_name "WorseUsabilityConditionAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DisableSecuritySystemAction"></see>
    /// </summary>
    let DisableSecuritySystemAction =
        Namespaced_IRI.parse _namespace_name "DisableSecuritySystemAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DisableWateringSystemAction"></see>
    /// </summary>
    let DisableWateringSystemAction =
        Namespaced_IRI.parse _namespace_name "DisableWateringSystemAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DisabledAirplaneModeTrigger"></see>
    /// </summary>
    let DisabledAirplaneModeTrigger =
        Namespaced_IRI.parse _namespace_name "DisabledAirplaneModeTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DisabledBluetoothConnectivityTrigger"></see>
    /// </summary>
    let DisabledBluetoothConnectivityTrigger =
        Namespaced_IRI.parse _namespace_name "DisabledBluetoothConnectivityTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DisabledGPSTrigger"></see>
    /// </summary>
    let DisabledGPSTrigger =
        Namespaced_IRI.parse _namespace_name "DisabledGPSTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DisabledInternetConnectivityTrigger"></see>
    /// </summary>
    let DisabledInternetConnectivityTrigger =
        Namespaced_IRI.parse _namespace_name "DisabledInternetConnectivityTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DisabledNFCConnectivityTrigger"></see>
    /// </summary>
    let DisabledNFCConnectivityTrigger =
        Namespaced_IRI.parse _namespace_name "DisabledNFCConnectivityTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DisconnectDeviceAction"></see>
    /// </summary>
    let DisconnectDeviceAction =
        Namespaced_IRI.parse _namespace_name "DisconnectDeviceAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DisconnectFromDeviceAction"></see>
    /// </summary>
    let DisconnectFromDeviceAction =
        Namespaced_IRI.parse _namespace_name "DisconnectFromDeviceAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DisconnectFromNetworkAction"></see>
    /// </summary>
    let DisconnectFromNetworkAction =
        Namespaced_IRI.parse _namespace_name "DisconnectFromNetworkAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DisconnectedFromDeviceTrigger"></see>
    /// </summary>
    let DisconnectedFromDeviceTrigger =
        Namespaced_IRI.parse _namespace_name "DisconnectedFromDeviceTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DisconnectedFromNetworkTrigger"></see>
    /// </summary>
    let DisconnectedFromNetworkTrigger =
        Namespaced_IRI.parse _namespace_name "DisconnectedFromNetworkTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Dishwasher"></see>
    /// </summary>
    let Dishwasher = Namespaced_IRI.parse _namespace_name "Dishwasher" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DisplaySerivce"></see>
    /// </summary>
    let DisplaySerivce =
        Namespaced_IRI.parse _namespace_name "DisplaySerivce" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DisplyService"></see>
    /// </summary>
    let DisplyService =
        Namespaced_IRI.parse _namespace_name "DisplyService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DiswashingService"></see>
    /// </summary>
    let DiswashingService =
        Namespaced_IRI.parse _namespace_name "DiswashingService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Dryer"></see>
    /// </summary>
    let Dryer = Namespaced_IRI.parse _namespace_name "Dryer" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DryingService"></see>
    /// </summary>
    let DryingService =
        Namespaced_IRI.parse _namespace_name "DryingService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DvdPlayer"></see>
    /// </summary>
    let DvdPlayer = Namespaced_IRI.parse _namespace_name "DvdPlayer" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EUDPlatform"></see>
    /// </summary>
    let EUDPlatform =
        Namespaced_IRI.parse _namespace_name "EUDPlatform" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EcommerceService"></see>
    /// </summary>
    let EcommerceService =
        Namespaced_IRI.parse _namespace_name "EcommerceService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EcommerceWebSite"></see>
    /// </summary>
    let EcommerceWebSite =
        Namespaced_IRI.parse _namespace_name "EcommerceWebSite" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ShoppingTool"></see>
    /// </summary>
    let ShoppingTool =
        Namespaced_IRI.parse _namespace_name "ShoppingTool" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EmailTool"></see>
    /// </summary>
    let EmailTool = Namespaced_IRI.parse _namespace_name "EmailTool" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EnableAirPurifierSystemAction"></see>
    /// </summary>
    let EnableAirPurifierSystemAction =
        Namespaced_IRI.parse _namespace_name "EnableAirPurifierSystemAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#IncreaseAirQualityAction"></see>
    /// </summary>
    let IncreaseAirQualityAction =
        Namespaced_IRI.parse _namespace_name "IncreaseAirQualityAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EnableAirplaneModeAction"></see>
    /// </summary>
    let EnableAirplaneModeAction =
        Namespaced_IRI.parse _namespace_name "EnableAirplaneModeAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EnableBluetoothConnectivityAction"></see>
    /// </summary>
    let EnableBluetoothConnectivityAction =
        Namespaced_IRI.parse _namespace_name "EnableBluetoothConnectivityAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EnableCoolingSystemAction"></see>
    /// </summary>
    let EnableCoolingSystemAction =
        Namespaced_IRI.parse _namespace_name "EnableCoolingSystemAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EnableDehumidifierSystemAction"></see>
    /// </summary>
    let EnableDehumidifierSystemAction =
        Namespaced_IRI.parse _namespace_name "EnableDehumidifierSystemAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EnableDeviceSavingModeAction"></see>
    /// </summary>
    let EnableDeviceSavingModeAction =
        Namespaced_IRI.parse _namespace_name "EnableDeviceSavingModeAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ImproveConsumptionConditionAction"></see>
    /// </summary>
    let ImproveConsumptionConditionAction =
        Namespaced_IRI.parse _namespace_name "ImproveConsumptionConditionAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EnableGPSAction"></see>
    /// </summary>
    let EnableGPSAction =
        Namespaced_IRI.parse _namespace_name "EnableGPSAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EnableHeatingSystemAction"></see>
    /// </summary>
    let EnableHeatingSystemAction =
        Namespaced_IRI.parse _namespace_name "EnableHeatingSystemAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EnableHumidifierSystemAction"></see>
    /// </summary>
    let EnableHumidifierSystemAction =
        Namespaced_IRI.parse _namespace_name "EnableHumidifierSystemAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EnableInternetConnectivityAction"></see>
    /// </summary>
    let EnableInternetConnectivityAction =
        Namespaced_IRI.parse _namespace_name "EnableInternetConnectivityAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EnableLightingSystemAction"></see>
    /// </summary>
    let EnableLightingSystemAction =
        Namespaced_IRI.parse _namespace_name "EnableLightingSystemAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#IncreaseLightingAction"></see>
    /// </summary>
    let IncreaseLightingAction =
        Namespaced_IRI.parse _namespace_name "IncreaseLightingAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EnableNFCConnctivityAction"></see>
    /// </summary>
    let EnableNFCConnctivityAction =
        Namespaced_IRI.parse _namespace_name "EnableNFCConnctivityAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EnableNightModeAction"></see>
    /// </summary>
    let EnableNightModeAction =
        Namespaced_IRI.parse _namespace_name "EnableNightModeAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EnableNotificationsAction"></see>
    /// </summary>
    let EnableNotificationsAction =
        Namespaced_IRI.parse _namespace_name "EnableNotificationsAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#IncreaseUserConnectivityAction"></see>
    /// </summary>
    let IncreaseUserConnectivityAction =
        Namespaced_IRI.parse _namespace_name "IncreaseUserConnectivityAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EnableScreenRotationAction"></see>
    /// </summary>
    let EnableScreenRotationAction =
        Namespaced_IRI.parse _namespace_name "EnableScreenRotationAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ImproveUsabilityConditionAction"></see>
    /// </summary>
    let ImproveUsabilityConditionAction =
        Namespaced_IRI.parse _namespace_name "ImproveUsabilityConditionAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EnableSecuritySystemAction"></see>
    /// </summary>
    let EnableSecuritySystemAction =
        Namespaced_IRI.parse _namespace_name "EnableSecuritySystemAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EnableSpeakerphoneAction"></see>
    /// </summary>
    let EnableSpeakerphoneAction =
        Namespaced_IRI.parse _namespace_name "EnableSpeakerphoneAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EnableWateringSystemAction"></see>
    /// </summary>
    let EnableWateringSystemAction =
        Namespaced_IRI.parse _namespace_name "EnableWateringSystemAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EnabledAirplaneModeTrigger"></see>
    /// </summary>
    let EnabledAirplaneModeTrigger =
        Namespaced_IRI.parse _namespace_name "EnabledAirplaneModeTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EnabledBluetoothConnectivityTrigger"></see>
    /// </summary>
    let EnabledBluetoothConnectivityTrigger =
        Namespaced_IRI.parse _namespace_name "EnabledBluetoothConnectivityTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EnabledGPSTrigger"></see>
    /// </summary>
    let EnabledGPSTrigger =
        Namespaced_IRI.parse _namespace_name "EnabledGPSTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EnabledInternetConnectivityTrigger"></see>
    /// </summary>
    let EnabledInternetConnectivityTrigger =
        Namespaced_IRI.parse _namespace_name "EnabledInternetConnectivityTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EnabledNFCConnectivityTrigger"></see>
    /// </summary>
    let EnabledNFCConnectivityTrigger =
        Namespaced_IRI.parse _namespace_name "EnabledNFCConnectivityTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EndCallAction"></see>
    /// </summary>
    let EndCallAction =
        Namespaced_IRI.parse _namespace_name "EndCallAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#MovingTrigger"></see>
    /// </summary>
    let MovingTrigger =
        Namespaced_IRI.parse _namespace_name "MovingTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EnvironmentTrigger"></see>
    /// </summary>
    let EnvironmentTrigger =
        Namespaced_IRI.parse _namespace_name "EnvironmentTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EnvironmentConditionIncreasedTrigger"></see>
    /// </summary>
    let EnvironmentConditionIncreasedTrigger =
        Namespaced_IRI.parse _namespace_name "EnvironmentConditionIncreasedTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EveryDayTrigger"></see>
    /// </summary>
    let EveryDayTrigger =
        Namespaced_IRI.parse _namespace_name "EveryDayTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EveryTimeTrigger"></see>
    /// </summary>
    let EveryTimeTrigger =
        Namespaced_IRI.parse _namespace_name "EveryTimeTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EveryHourTrigger"></see>
    /// </summary>
    let EveryHourTrigger =
        Namespaced_IRI.parse _namespace_name "EveryHourTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EveryMonthTrigger"></see>
    /// </summary>
    let EveryMonthTrigger =
        Namespaced_IRI.parse _namespace_name "EveryMonthTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#TimeTrigger"></see>
    /// </summary>
    let TimeTrigger =
        Namespaced_IRI.parse _namespace_name "TimeTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EveryWeekTrigger"></see>
    /// </summary>
    let EveryWeekTrigger =
        Namespaced_IRI.parse _namespace_name "EveryWeekTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EveryYearTrigger"></see>
    /// </summary>
    let EveryYearTrigger =
        Namespaced_IRI.parse _namespace_name "EveryYearTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ExitTrigger"></see>
    /// </summary>
    let ExitTrigger =
        Namespaced_IRI.parse _namespace_name "ExitTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#FailureDetectionService"></see>
    /// </summary>
    let FailureDetectionService =
        Namespaced_IRI.parse _namespace_name "FailureDetectionService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Family"></see>
    /// </summary>
    let Family = Namespaced_IRI.parse _namespace_name "Family" |> NamespacedName
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Fax"></see>
    /// </summary>
    let Fax = Namespaced_IRI.parse _namespace_name "Fax" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#FileService"></see>
    /// </summary>
    let FileService =
        Namespaced_IRI.parse _namespace_name "FileService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#FocusTrackingService"></see>
    /// </summary>
    let FocusTrackingService =
        Namespaced_IRI.parse _namespace_name "FocusTrackingService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#FrameService"></see>
    /// </summary>
    let FrameService =
        Namespaced_IRI.parse _namespace_name "FrameService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Fridge"></see>
    /// </summary>
    let Fridge = Namespaced_IRI.parse _namespace_name "Fridge" |> NamespacedName
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Friend"></see>
    /// </summary>
    let Friend = Namespaced_IRI.parse _namespace_name "Friend" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#GPSEnterAreaTrigger"></see>
    /// </summary>
    let GPSEnterAreaTrigger =
        Namespaced_IRI.parse _namespace_name "GPSEnterAreaTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#GPSExitAreaTrigger"></see>
    /// </summary>
    let GPSExitAreaTrigger =
        Namespaced_IRI.parse _namespace_name "GPSExitAreaTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#GPSService"></see>
    /// </summary>
    let GPSService = Namespaced_IRI.parse _namespace_name "GPSService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#PostioningService"></see>
    /// </summary>
    let PostioningService =
        Namespaced_IRI.parse _namespace_name "PostioningService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#GameService"></see>
    /// </summary>
    let GameService =
        Namespaced_IRI.parse _namespace_name "GameService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#MediaService"></see>
    /// </summary>
    let MediaService =
        Namespaced_IRI.parse _namespace_name "MediaService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#GeographicalArea"></see>
    /// </summary>
    let GeographicalArea =
        Namespaced_IRI.parse _namespace_name "GeographicalArea" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#GroceryShoppingService"></see>
    /// </summary>
    let GroceryShoppingService =
        Namespaced_IRI.parse _namespace_name "GroceryShoppingService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#HealthInformationService"></see>
    /// </summary>
    let HealthInformationService =
        Namespaced_IRI.parse _namespace_name "HealthInformationService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#HealthyActivityTrigger"></see>
    /// </summary>
    let HealthyActivityTrigger =
        Namespaced_IRI.parse _namespace_name "HealthyActivityTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#IncreasedHealthConditionTrigger"></see>
    /// </summary>
    let IncreasedHealthConditionTrigger =
        Namespaced_IRI.parse _namespace_name "IncreasedHealthConditionTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#HealthyGoalNotReachedTrigger"></see>
    /// </summary>
    let HealthyGoalNotReachedTrigger =
        Namespaced_IRI.parse _namespace_name "HealthyGoalNotReachedTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#HealthyGoalReachedTrigger"></see>
    /// </summary>
    let HealthyGoalReachedTrigger =
        Namespaced_IRI.parse _namespace_name "HealthyGoalReachedTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Heater"></see>
    /// </summary>
    let Heater = Namespaced_IRI.parse _namespace_name "Heater" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#HeatingService"></see>
    /// </summary>
    let HeatingService =
        Namespaced_IRI.parse _namespace_name "HeatingService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#HeatingSystemDisabledTrigger"></see>
    /// </summary>
    let HeatingSystemDisabledTrigger =
        Namespaced_IRI.parse _namespace_name "HeatingSystemDisabledTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#HeatingSystemEnabledTrigger"></see>
    /// </summary>
    let HeatingSystemEnabledTrigger =
        Namespaced_IRI.parse _namespace_name "HeatingSystemEnabledTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#HiFi"></see>
    /// </summary>
    let HiFi = Namespaced_IRI.parse _namespace_name "HiFi" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#HighSensedDeviceConsumptionTrigger"></see>
    /// </summary>
    let HighSensedDeviceConsumptionTrigger =
        Namespaced_IRI.parse _namespace_name "HighSensedDeviceConsumptionTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Hub"></see>
    /// </summary>
    let Hub = Namespaced_IRI.parse _namespace_name "Hub" |> NamespacedName
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Humidifier"></see>
    /// </summary>
    let Humidifier = Namespaced_IRI.parse _namespace_name "Humidifier" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#HumidifierService"></see>
    /// </summary>
    let HumidifierService =
        Namespaced_IRI.parse _namespace_name "HumidifierService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#HumiditySetToTrigger"></see>
    /// </summary>
    let HumiditySetToTrigger =
        Namespaced_IRI.parse _namespace_name "HumiditySetToTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ImproveDeviceConditionAction"></see>
    /// </summary>
    let ImproveDeviceConditionAction =
        Namespaced_IRI.parse _namespace_name "ImproveDeviceConditionAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ImprovedDeviceConditionTrigger"></see>
    /// </summary>
    let ImprovedDeviceConditionTrigger =
        Namespaced_IRI.parse _namespace_name "ImprovedDeviceConditionTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ImprovedHealthyParameterTrigger"></see>
    /// </summary>
    let ImprovedHealthyParameterTrigger =
        Namespaced_IRI.parse _namespace_name "ImprovedHealthyParameterTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ImprovedUsabilityConditionTrigger"></see>
    /// </summary>
    let ImprovedUsabilityConditionTrigger =
        Namespaced_IRI.parse _namespace_name "ImprovedUsabilityConditionTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#IncreaseEnvironmentConditionAction"></see>
    /// </summary>
    let IncreaseEnvironmentConditionAction =
        Namespaced_IRI.parse _namespace_name "IncreaseEnvironmentConditionAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#IncreaseVolumeAction"></see>
    /// </summary>
    let IncreaseVolumeAction =
        Namespaced_IRI.parse _namespace_name "IncreaseVolumeAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#IncreasedAirPressureTrigger"></see>
    /// </summary>
    let IncreasedAirPressureTrigger =
        Namespaced_IRI.parse _namespace_name "IncreasedAirPressureTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#IncreasedLightingTrigger"></see>
    /// </summary>
    let IncreasedLightingTrigger =
        Namespaced_IRI.parse _namespace_name "IncreasedLightingTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#IncreasedNoiseLevelTrigger"></see>
    /// </summary>
    let IncreasedNoiseLevelTrigger =
        Namespaced_IRI.parse _namespace_name "IncreasedNoiseLevelTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#IncreasedSecurityTrigger"></see>
    /// </summary>
    let IncreasedSecurityTrigger =
        Namespaced_IRI.parse _namespace_name "IncreasedSecurityTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#IncreasedWeatherConditionTrigger"></see>
    /// </summary>
    let IncreasedWeatherConditionTrigger =
        Namespaced_IRI.parse _namespace_name "IncreasedWeatherConditionTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#InformationWebSite"></see>
    /// </summary>
    let InformationWebSite =
        Namespaced_IRI.parse _namespace_name "InformationWebSite" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#InstantiatedAction"></see>
    /// </summary>
    let InstantiatedAction =
        Namespaced_IRI.parse _namespace_name "InstantiatedAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#nominalAction"></see>
    /// </summary>
    let nominalAction =
        Namespaced_IRI.parse _namespace_name "nominalAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#RuleInstantiatedAxiom"></see>
    /// </summary>
    let RuleInstantiatedAxiom =
        Namespaced_IRI.parse _namespace_name "RuleInstantiatedAxiom" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#InstantiatedDetail"></see>
    /// </summary>
    let InstantiatedDetail =
        Namespaced_IRI.parse _namespace_name "InstantiatedDetail" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#InstantiatedTrigger"></see>
    /// </summary>
    let InstantiatedTrigger =
        Namespaced_IRI.parse _namespace_name "InstantiatedTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#nominalTrigger"></see>
    /// </summary>
    let nominalTrigger =
        Namespaced_IRI.parse _namespace_name "nominalTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#InteractionService"></see>
    /// </summary>
    let InteractionService =
        Namespaced_IRI.parse _namespace_name "InteractionService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#IoTEntity"></see>
    /// </summary>
    let IoTEntity = Namespaced_IRI.parse _namespace_name "IoTEntity" |> NamespacedName
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#hasService"></see>
    /// </summary>
    let hasService = Namespaced_IRI.parse _namespace_name "hasService" |> NamespacedName
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Lamp"></see>
    /// </summary>
    let Lamp = Namespaced_IRI.parse _namespace_name "Lamp" |> NamespacedName
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Laptop"></see>
    /// </summary>
    let Laptop = Namespaced_IRI.parse _namespace_name "Laptop" |> NamespacedName
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#UserDevice"></see>
    /// </summary>
    let UserDevice = Namespaced_IRI.parse _namespace_name "UserDevice" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#LeakDetectionService"></see>
    /// </summary>
    let LeakDetectionService =
        Namespaced_IRI.parse _namespace_name "LeakDetectionService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#LightingService"></see>
    /// </summary>
    let LightingService =
        Namespaced_IRI.parse _namespace_name "LightingService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#LightingSystemDisabledTrigger"></see>
    /// </summary>
    let LightingSystemDisabledTrigger =
        Namespaced_IRI.parse _namespace_name "LightingSystemDisabledTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#LightingSystemEnabledTrigger"></see>
    /// </summary>
    let LightingSystemEnabledTrigger =
        Namespaced_IRI.parse _namespace_name "LightingSystemEnabledTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#LikeService"></see>
    /// </summary>
    let LikeService =
        Namespaced_IRI.parse _namespace_name "LikeService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#LowPowerTrigger"></see>
    /// </summary>
    let LowPowerTrigger =
        Namespaced_IRI.parse _namespace_name "LowPowerTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#MediaInformationService"></see>
    /// </summary>
    let MediaInformationService =
        Namespaced_IRI.parse _namespace_name "MediaInformationService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#MediaTool"></see>
    /// </summary>
    let MediaTool = Namespaced_IRI.parse _namespace_name "MediaTool" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#MessageService"></see>
    /// </summary>
    let MessageService =
        Namespaced_IRI.parse _namespace_name "MessageService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#MobileDevice"></see>
    /// </summary>
    let MobileDevice =
        Namespaced_IRI.parse _namespace_name "MobileDevice" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#MoveAppAction"></see>
    /// </summary>
    let MoveAppAction =
        Namespaced_IRI.parse _namespace_name "MoveAppAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StoreAction"></see>
    /// </summary>
    let StoreAction =
        Namespaced_IRI.parse _namespace_name "StoreAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#MoveOnVehicleTrigger"></see>
    /// </summary>
    let MoveOnVehicleTrigger =
        Namespaced_IRI.parse _namespace_name "MoveOnVehicleTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#PlacesTrigger"></see>
    /// </summary>
    let PlacesTrigger =
        Namespaced_IRI.parse _namespace_name "PlacesTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#MusicPlatform"></see>
    /// </summary>
    let MusicPlatform =
        Namespaced_IRI.parse _namespace_name "MusicPlatform" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#MusicService"></see>
    /// </summary>
    let MusicService =
        Namespaced_IRI.parse _namespace_name "MusicService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#MuteCallAction"></see>
    /// </summary>
    let MuteCallAction =
        Namespaced_IRI.parse _namespace_name "MuteCallAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#NFCService"></see>
    /// </summary>
    let NFCService = Namespaced_IRI.parse _namespace_name "NFCService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#NewsService"></see>
    /// </summary>
    let NewsService =
        Namespaced_IRI.parse _namespace_name "NewsService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#NewsWebSite"></see>
    /// </summary>
    let NewsWebSite =
        Namespaced_IRI.parse _namespace_name "NewsWebSite" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#NightModeDisabledTrigger"></see>
    /// </summary>
    let NightModeDisabledTrigger =
        Namespaced_IRI.parse _namespace_name "NightModeDisabledTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#NightModeEnabledTrigger"></see>
    /// </summary>
    let NightModeEnabledTrigger =
        Namespaced_IRI.parse _namespace_name "NightModeEnabledTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#NoiseService"></see>
    /// </summary>
    let NoiseService =
        Namespaced_IRI.parse _namespace_name "NoiseService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#NoteTool"></see>
    /// </summary>
    let NoteTool = Namespaced_IRI.parse _namespace_name "NoteTool" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#NotificationProfileSetToTrigger"></see>
    /// </summary>
    let NotificationProfileSetToTrigger =
        Namespaced_IRI.parse _namespace_name "NotificationProfileSetToTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#NotificationService"></see>
    /// </summary>
    let NotificationService =
        Namespaced_IRI.parse _namespace_name "NotificationService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#NotificationTool"></see>
    /// </summary>
    let NotificationTool =
        Namespaced_IRI.parse _namespace_name "NotificationTool" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#NotificationsDisabledTrigger"></see>
    /// </summary>
    let NotificationsDisabledTrigger =
        Namespaced_IRI.parse _namespace_name "NotificationsDisabledTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#NotificationsEnabledTrigger"></see>
    /// </summary>
    let NotificationsEnabledTrigger =
        Namespaced_IRI.parse _namespace_name "NotificationsEnabledTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#OpenWindowFrameAction"></see>
    /// </summary>
    let OpenWindowFrameAction =
        Namespaced_IRI.parse _namespace_name "OpenWindowFrameAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Oven"></see>
    /// </summary>
    let Oven = Namespaced_IRI.parse _namespace_name "Oven" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#OvenService"></see>
    /// </summary>
    let OvenService =
        Namespaced_IRI.parse _namespace_name "OvenService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#PC"></see>
    /// </summary>
    let PC = Namespaced_IRI.parse _namespace_name "PC" |> NamespacedName
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Phone"></see>
    /// </summary>
    let Phone = Namespaced_IRI.parse _namespace_name "Phone" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#PhoneCallMutedTrigger"></see>
    /// </summary>
    let PhoneCallMutedTrigger =
        Namespaced_IRI.parse _namespace_name "PhoneCallMutedTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#PhoneCallRejectedTrigger"></see>
    /// </summary>
    let PhoneCallRejectedTrigger =
        Namespaced_IRI.parse _namespace_name "PhoneCallRejectedTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#PhotoPlatform"></see>
    /// </summary>
    let PhotoPlatform =
        Namespaced_IRI.parse _namespace_name "PhotoPlatform" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#PhotoRecordingService"></see>
    /// </summary>
    let PhotoRecordingService =
        Namespaced_IRI.parse _namespace_name "PhotoRecordingService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#PositionRegistrationService"></see>
    /// </summary>
    let PositionRegistrationService =
        Namespaced_IRI.parse _namespace_name "PositionRegistrationService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#PositionRegistrationTrigger"></see>
    /// </summary>
    let PositionRegistrationTrigger =
        Namespaced_IRI.parse _namespace_name "PositionRegistrationTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#PostService"></see>
    /// </summary>
    let PostService =
        Namespaced_IRI.parse _namespace_name "PostService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#PowerService"></see>
    /// </summary>
    let PowerService =
        Namespaced_IRI.parse _namespace_name "PowerService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#PrintService"></see>
    /// </summary>
    let PrintService =
        Namespaced_IRI.parse _namespace_name "PrintService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Printer"></see>
    /// </summary>
    let Printer = Namespaced_IRI.parse _namespace_name "Printer" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ProfileUpdateService"></see>
    /// </summary>
    let ProfileUpdateService =
        Namespaced_IRI.parse _namespace_name "ProfileUpdateService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#QuestionService"></see>
    /// </summary>
    let QuestionService =
        Namespaced_IRI.parse _namespace_name "QuestionService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Radio"></see>
    /// </summary>
    let Radio = Namespaced_IRI.parse _namespace_name "Radio" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#RainfallMeasurementAvailableTrigger"></see>
    /// </summary>
    let RainfallMeasurementAvailableTrigger =
        Namespaced_IRI.parse _namespace_name "RainfallMeasurementAvailableTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ReceivedAnswerTrigger"></see>
    /// </summary>
    let ReceivedAnswerTrigger =
        Namespaced_IRI.parse _namespace_name "ReceivedAnswerTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ReceivedPrivateInformationTrigger"></see>
    /// </summary>
    let ReceivedPrivateInformationTrigger =
        Namespaced_IRI.parse _namespace_name "ReceivedPrivateInformationTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ReceivedAppNotificationTrigger"></see>
    /// </summary>
    let ReceivedAppNotificationTrigger =
        Namespaced_IRI.parse _namespace_name "ReceivedAppNotificationTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ReceivedNotificationTrigger"></see>
    /// </summary>
    let ReceivedNotificationTrigger =
        Namespaced_IRI.parse _namespace_name "ReceivedNotificationTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ReceivedAttachmentTrigger"></see>
    /// </summary>
    let ReceivedAttachmentTrigger =
        Namespaced_IRI.parse _namespace_name "ReceivedAttachmentTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ReceivedBreakingNewsTrigger"></see>
    /// </summary>
    let ReceivedBreakingNewsTrigger =
        Namespaced_IRI.parse _namespace_name "ReceivedBreakingNewsTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ReceivedNewsTrigger"></see>
    /// </summary>
    let ReceivedNewsTrigger =
        Namespaced_IRI.parse _namespace_name "ReceivedNewsTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ReceivedCommentTrigger"></see>
    /// </summary>
    let ReceivedCommentTrigger =
        Namespaced_IRI.parse _namespace_name "ReceivedCommentTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ReceivedContactNotificationTrigger"></see>
    /// </summary>
    let ReceivedContactNotificationTrigger =
        Namespaced_IRI.parse _namespace_name "ReceivedContactNotificationTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ReceivedDocumentInfoNotificationTrigger"></see>
    /// </summary>
    let ReceivedDocumentInfoNotificationTrigger =
        Namespaced_IRI.parse _namespace_name "ReceivedDocumentInfoNotificationTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ReceivedFromDeviceTrigger"></see>
    /// </summary>
    let ReceivedFromDeviceTrigger =
        Namespaced_IRI.parse _namespace_name "ReceivedFromDeviceTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ReceivedTrigger"></see>
    /// </summary>
    let ReceivedTrigger =
        Namespaced_IRI.parse _namespace_name "ReceivedTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ReceivedFromDiyTrigger"></see>
    /// </summary>
    let ReceivedFromDiyTrigger =
        Namespaced_IRI.parse _namespace_name "ReceivedFromDiyTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ReceivedIncomingCallTrigger"></see>
    /// </summary>
    let ReceivedIncomingCallTrigger =
        Namespaced_IRI.parse _namespace_name "ReceivedIncomingCallTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ReceivedLikeTrigger"></see>
    /// </summary>
    let ReceivedLikeTrigger =
        Namespaced_IRI.parse _namespace_name "ReceivedLikeTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ReceivedMessageTrigger"></see>
    /// </summary>
    let ReceivedMessageTrigger =
        Namespaced_IRI.parse _namespace_name "ReceivedMessageTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ReceivedMissedCallNotificationTrigger"></see>
    /// </summary>
    let ReceivedMissedCallNotificationTrigger =
        Namespaced_IRI.parse _namespace_name "ReceivedMissedCallNotificationTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ReceivedPaymentNotificationTrigger"></see>
    /// </summary>
    let ReceivedPaymentNotificationTrigger =
        Namespaced_IRI.parse _namespace_name "ReceivedPaymentNotificationTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ReceivedPostTrigger"></see>
    /// </summary>
    let ReceivedPostTrigger =
        Namespaced_IRI.parse _namespace_name "ReceivedPostTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ReceivedRecommendationNotificationTrigger"></see>
    /// </summary>
    let ReceivedRecommendationNotificationTrigger =
        Namespaced_IRI.parse _namespace_name "ReceivedRecommendationNotificationTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ReceivedRemindNotificationTrigger"></see>
    /// </summary>
    let ReceivedRemindNotificationTrigger =
        Namespaced_IRI.parse _namespace_name "ReceivedRemindNotificationTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ReceivedShippingNotificationTrigger"></see>
    /// </summary>
    let ReceivedShippingNotificationTrigger =
        Namespaced_IRI.parse _namespace_name "ReceivedShippingNotificationTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ReceivedTagTrigger"></see>
    /// </summary>
    let ReceivedTagTrigger =
        Namespaced_IRI.parse _namespace_name "ReceivedTagTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ReceivedUnlikeTrigger"></see>
    /// </summary>
    let ReceivedUnlikeTrigger =
        Namespaced_IRI.parse _namespace_name "ReceivedUnlikeTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#RejectCallAction"></see>
    /// </summary>
    let RejectCallAction =
        Namespaced_IRI.parse _namespace_name "RejectCallAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ReminderService"></see>
    /// </summary>
    let ReminderService =
        Namespaced_IRI.parse _namespace_name "ReminderService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Room"></see>
    /// </summary>
    let Room = Namespaced_IRI.parse _namespace_name "Room" |> NamespacedName
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Rule"></see>
    /// </summary>
    let Rule = Namespaced_IRI.parse _namespace_name "Rule" |> NamespacedName
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#hasTrigger"></see>
    /// </summary>
    let hasTrigger = Namespaced_IRI.parse _namespace_name "hasTrigger" |> NamespacedName
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#hasAction"></see>
    /// </summary>
    let hasAction = Namespaced_IRI.parse _namespace_name "hasAction" |> NamespacedName
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#RuleAxiom"></see>
    /// </summary>
    let RuleAxiom = Namespaced_IRI.parse _namespace_name "RuleAxiom" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#RunTrackingService"></see>
    /// </summary>
    let RunTrackingService =
        Namespaced_IRI.parse _namespace_name "RunTrackingService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SMSTool"></see>
    /// </summary>
    let SMSTool = Namespaced_IRI.parse _namespace_name "SMSTool" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SaveContactAction"></see>
    /// </summary>
    let SaveContactAction =
        Namespaced_IRI.parse _namespace_name "SaveContactAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SaveFileAction"></see>
    /// </summary>
    let SaveFileAction =
        Namespaced_IRI.parse _namespace_name "SaveFileAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SaveHealthInformationAction"></see>
    /// </summary>
    let SaveHealthInformationAction =
        Namespaced_IRI.parse _namespace_name "SaveHealthInformationAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SaveMediaInformationAction"></see>
    /// </summary>
    let SaveMediaInformationAction =
        Namespaced_IRI.parse _namespace_name "SaveMediaInformationAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SaveWebBookmarkAction"></see>
    /// </summary>
    let SaveWebBookmarkAction =
        Namespaced_IRI.parse _namespace_name "SaveWebBookmarkAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ScanBluetoothTrigger"></see>
    /// </summary>
    let ScanBluetoothTrigger =
        Namespaced_IRI.parse _namespace_name "ScanBluetoothTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ScanWifiTrigger"></see>
    /// </summary>
    let ScanWifiTrigger =
        Namespaced_IRI.parse _namespace_name "ScanWifiTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ScreenRotationDisabledTrigger"></see>
    /// </summary>
    let ScreenRotationDisabledTrigger =
        Namespaced_IRI.parse _namespace_name "ScreenRotationDisabledTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#WorseUsabilityConditionTrigger"></see>
    /// </summary>
    let WorseUsabilityConditionTrigger =
        Namespaced_IRI.parse _namespace_name "WorseUsabilityConditionTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ScreenRotationEnabledTrigger"></see>
    /// </summary>
    let ScreenRotationEnabledTrigger =
        Namespaced_IRI.parse _namespace_name "ScreenRotationEnabledTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SecurityService"></see>
    /// </summary>
    let SecurityService =
        Namespaced_IRI.parse _namespace_name "SecurityService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SecurityShutdownAction"></see>
    /// </summary>
    let SecurityShutdownAction =
        Namespaced_IRI.parse _namespace_name "SecurityShutdownAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SecuritySystemDisabledTrigger"></see>
    /// </summary>
    let SecuritySystemDisabledTrigger =
        Namespaced_IRI.parse _namespace_name "SecuritySystemDisabledTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SecuritySystemEnabledTrigger"></see>
    /// </summary>
    let SecuritySystemEnabledTrigger =
        Namespaced_IRI.parse _namespace_name "SecuritySystemEnabledTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SendAction"></see>
    /// </summary>
    let SendAction = Namespaced_IRI.parse _namespace_name "SendAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SendAttachmentAction"></see>
    /// </summary>
    let SendAttachmentAction =
        Namespaced_IRI.parse _namespace_name "SendAttachmentAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SendToPersonAction"></see>
    /// </summary>
    let SendToPersonAction =
        Namespaced_IRI.parse _namespace_name "SendToPersonAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SendCallAction"></see>
    /// </summary>
    let SendCallAction =
        Namespaced_IRI.parse _namespace_name "SendCallAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SendMessageAction"></see>
    /// </summary>
    let SendMessageAction =
        Namespaced_IRI.parse _namespace_name "SendMessageAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SendQuestionAction"></see>
    /// </summary>
    let SendQuestionAction =
        Namespaced_IRI.parse _namespace_name "SendQuestionAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SendRequestAction"></see>
    /// </summary>
    let SendRequestAction =
        Namespaced_IRI.parse _namespace_name "SendRequestAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SendToDeviceAction"></see>
    /// </summary>
    let SendToDeviceAction =
        Namespaced_IRI.parse _namespace_name "SendToDeviceAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SendToDisplayAction"></see>
    /// </summary>
    let SendToDisplayAction =
        Namespaced_IRI.parse _namespace_name "SendToDisplayAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SendToDiyAction"></see>
    /// </summary>
    let SendToDiyAction =
        Namespaced_IRI.parse _namespace_name "SendToDiyAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SendToPrintAction"></see>
    /// </summary>
    let SendToPrintAction =
        Namespaced_IRI.parse _namespace_name "SendToPrintAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SendToSpeakerAction"></see>
    /// </summary>
    let SendToSpeakerAction =
        Namespaced_IRI.parse _namespace_name "SendToSpeakerAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SendWebRequestAction"></see>
    /// </summary>
    let SendWebRequestAction =
        Namespaced_IRI.parse _namespace_name "SendWebRequestAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SensedAirPressureDecreasedTrigger"></see>
    /// </summary>
    let SensedAirPressureDecreasedTrigger =
        Namespaced_IRI.parse _namespace_name "SensedAirPressureDecreasedTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SensedAirPressureIncreasedTrigger"></see>
    /// </summary>
    let SensedAirPressureIncreasedTrigger =
        Namespaced_IRI.parse _namespace_name "SensedAirPressureIncreasedTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SensedAirQualityDecreasedTrigger"></see>
    /// </summary>
    let SensedAirQualityDecreasedTrigger =
        Namespaced_IRI.parse _namespace_name "SensedAirQualityDecreasedTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SensedAirQualityIncreasedTrigger"></see>
    /// </summary>
    let SensedAirQualityIncreasedTrigger =
        Namespaced_IRI.parse _namespace_name "SensedAirQualityIncreasedTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SensedHealthyParameterTrigger"></see>
    /// </summary>
    let SensedHealthyParameterTrigger =
        Namespaced_IRI.parse _namespace_name "SensedHealthyParameterTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#WorsenedHealthyParameterTrigger"></see>
    /// </summary>
    let WorsenedHealthyParameterTrigger =
        Namespaced_IRI.parse _namespace_name "WorsenedHealthyParameterTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SensedHumididtyDecreasedTrigger"></see>
    /// </summary>
    let SensedHumididtyDecreasedTrigger =
        Namespaced_IRI.parse _namespace_name "SensedHumididtyDecreasedTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SensedHumidityIncreasedTrigger"></see>
    /// </summary>
    let SensedHumidityIncreasedTrigger =
        Namespaced_IRI.parse _namespace_name "SensedHumidityIncreasedTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SensedLightingDecreasedTrigger"></see>
    /// </summary>
    let SensedLightingDecreasedTrigger =
        Namespaced_IRI.parse _namespace_name "SensedLightingDecreasedTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SensedLightingIncreasedTrigger"></see>
    /// </summary>
    let SensedLightingIncreasedTrigger =
        Namespaced_IRI.parse _namespace_name "SensedLightingIncreasedTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SensedNoiseLevelDecreasedTrigger"></see>
    /// </summary>
    let SensedNoiseLevelDecreasedTrigger =
        Namespaced_IRI.parse _namespace_name "SensedNoiseLevelDecreasedTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SensedNoiseLevelIncreasedTrigger"></see>
    /// </summary>
    let SensedNoiseLevelIncreasedTrigger =
        Namespaced_IRI.parse _namespace_name "SensedNoiseLevelIncreasedTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SensedRainDetectedTrigger"></see>
    /// </summary>
    let SensedRainDetectedTrigger =
        Namespaced_IRI.parse _namespace_name "SensedRainDetectedTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SensedRainNoLongerDetectedTrigger"></see>
    /// </summary>
    let SensedRainNoLongerDetectedTrigger =
        Namespaced_IRI.parse _namespace_name "SensedRainNoLongerDetectedTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SensedTemperatureDecreasedTrigger"></see>
    /// </summary>
    let SensedTemperatureDecreasedTrigger =
        Namespaced_IRI.parse _namespace_name "SensedTemperatureDecreasedTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SensedTemperatureIncreasedTrigger"></see>
    /// </summary>
    let SensedTemperatureIncreasedTrigger =
        Namespaced_IRI.parse _namespace_name "SensedTemperatureIncreasedTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SensedWindDecreasedTrigger"></see>
    /// </summary>
    let SensedWindDecreasedTrigger =
        Namespaced_IRI.parse _namespace_name "SensedWindDecreasedTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SensedWindIncreasedTrigger"></see>
    /// </summary>
    let SensedWindIncreasedTrigger =
        Namespaced_IRI.parse _namespace_name "SensedWindIncreasedTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SensorPresenceDetectedTrigger"></see>
    /// </summary>
    let SensorPresenceDetectedTrigger =
        Namespaced_IRI.parse _namespace_name "SensorPresenceDetectedTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SensorPresenceNoLongerDetectedTrigger"></see>
    /// </summary>
    let SensorPresenceNoLongerDetectedTrigger =
        Namespaced_IRI.parse _namespace_name "SensorPresenceNoLongerDetectedTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SentMessageTrigger"></see>
    /// </summary>
    let SentMessageTrigger =
        Namespaced_IRI.parse _namespace_name "SentMessageTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SentPrivateInformationTrigger"></see>
    /// </summary>
    let SentPrivateInformationTrigger =
        Namespaced_IRI.parse _namespace_name "SentPrivateInformationTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SentOutcomingCallTrigger"></see>
    /// </summary>
    let SentOutcomingCallTrigger =
        Namespaced_IRI.parse _namespace_name "SentOutcomingCallTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SentTrigger"></see>
    /// </summary>
    let SentTrigger =
        Namespaced_IRI.parse _namespace_name "SentTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SentPullTrigger"></see>
    /// </summary>
    let SentPullTrigger =
        Namespaced_IRI.parse _namespace_name "SentPullTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SentRequestTrigger"></see>
    /// </summary>
    let SentRequestTrigger =
        Namespaced_IRI.parse _namespace_name "SentRequestTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SentQuestionTrigger"></see>
    /// </summary>
    let SentQuestionTrigger =
        Namespaced_IRI.parse _namespace_name "SentQuestionTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SentSharedInformationTrigger"></see>
    /// </summary>
    let SentSharedInformationTrigger =
        Namespaced_IRI.parse _namespace_name "SentSharedInformationTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SentSubscriptionTrigger"></see>
    /// </summary>
    let SentSubscriptionTrigger =
        Namespaced_IRI.parse _namespace_name "SentSubscriptionTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#hasNotification"></see>
    /// </summary>
    let hasNotification =
        Namespaced_IRI.parse _namespace_name "hasNotification" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#hasCommand"></see>
    /// </summary>
    let hasCommand = Namespaced_IRI.parse _namespace_name "hasCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SetBrightnessAction"></see>
    /// </summary>
    let SetBrightnessAction =
        Namespaced_IRI.parse _namespace_name "SetBrightnessAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SetHumidityAction"></see>
    /// </summary>
    let SetHumidityAction =
        Namespaced_IRI.parse _namespace_name "SetHumidityAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SetLightingAction"></see>
    /// </summary>
    let SetLightingAction =
        Namespaced_IRI.parse _namespace_name "SetLightingAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SetTemperatureAction"></see>
    /// </summary>
    let SetTemperatureAction =
        Namespaced_IRI.parse _namespace_name "SetTemperatureAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ShareAction"></see>
    /// </summary>
    let ShareAction =
        Namespaced_IRI.parse _namespace_name "ShareAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ShareCommentAction"></see>
    /// </summary>
    let ShareCommentAction =
        Namespaced_IRI.parse _namespace_name "ShareCommentAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ShareFileAction"></see>
    /// </summary>
    let ShareFileAction =
        Namespaced_IRI.parse _namespace_name "ShareFileAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ShareLikeAction"></see>
    /// </summary>
    let ShareLikeAction =
        Namespaced_IRI.parse _namespace_name "ShareLikeAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SharePostAction"></see>
    /// </summary>
    let SharePostAction =
        Namespaced_IRI.parse _namespace_name "SharePostAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ShareProfileUpdateAction"></see>
    /// </summary>
    let ShareProfileUpdateAction =
        Namespaced_IRI.parse _namespace_name "ShareProfileUpdateAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ShareTagAction"></see>
    /// </summary>
    let ShareTagAction =
        Namespaced_IRI.parse _namespace_name "ShareTagAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ShareUnlikeAction"></see>
    /// </summary>
    let ShareUnlikeAction =
        Namespaced_IRI.parse _namespace_name "ShareUnlikeAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SharedCommentTrigger"></see>
    /// </summary>
    let SharedCommentTrigger =
        Namespaced_IRI.parse _namespace_name "SharedCommentTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SharedLikeTrigger"></see>
    /// </summary>
    let SharedLikeTrigger =
        Namespaced_IRI.parse _namespace_name "SharedLikeTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SharedPostTrigger"></see>
    /// </summary>
    let SharedPostTrigger =
        Namespaced_IRI.parse _namespace_name "SharedPostTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SharedProfileUpdateTrigger"></see>
    /// </summary>
    let SharedProfileUpdateTrigger =
        Namespaced_IRI.parse _namespace_name "SharedProfileUpdateTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SharedTagTrigger"></see>
    /// </summary>
    let SharedTagTrigger =
        Namespaced_IRI.parse _namespace_name "SharedTagTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SharedUnlikeTrigger"></see>
    /// </summary>
    let SharedUnlikeTrigger =
        Namespaced_IRI.parse _namespace_name "SharedUnlikeTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ShipmentTrackingTool"></see>
    /// </summary>
    let ShipmentTrackingTool =
        Namespaced_IRI.parse _namespace_name "ShipmentTrackingTool" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SleepTrackingService"></see>
    /// </summary>
    let SleepTrackingService =
        Namespaced_IRI.parse _namespace_name "SleepTrackingService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SmartBlind"></see>
    /// </summary>
    let SmartBlind = Namespaced_IRI.parse _namespace_name "SmartBlind" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SmartBracelet"></see>
    /// </summary>
    let SmartBracelet =
        Namespaced_IRI.parse _namespace_name "SmartBracelet" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SmartDoor"></see>
    /// </summary>
    let SmartDoor = Namespaced_IRI.parse _namespace_name "SmartDoor" |> NamespacedName
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SmartWatch"></see>
    /// </summary>
    let SmartWatch = Namespaced_IRI.parse _namespace_name "SmartWatch" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SmartWindow"></see>
    /// </summary>
    let SmartWindow =
        Namespaced_IRI.parse _namespace_name "SmartWindow" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Smartphone"></see>
    /// </summary>
    let Smartphone = Namespaced_IRI.parse _namespace_name "Smartphone" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SocialNetwork"></see>
    /// </summary>
    let SocialNetwork =
        Namespaced_IRI.parse _namespace_name "SocialNetwork" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SpeakerPhoneActivatedTrigger"></see>
    /// </summary>
    let SpeakerPhoneActivatedTrigger =
        Namespaced_IRI.parse _namespace_name "SpeakerPhoneActivatedTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Sprinkler"></see>
    /// </summary>
    let Sprinkler = Namespaced_IRI.parse _namespace_name "Sprinkler" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartActivityAction"></see>
    /// </summary>
    let StartActivityAction =
        Namespaced_IRI.parse _namespace_name "StartActivityAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartAppAction"></see>
    /// </summary>
    let StartAppAction =
        Namespaced_IRI.parse _namespace_name "StartAppAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartEntertainementAction"></see>
    /// </summary>
    let StartEntertainementAction =
        Namespaced_IRI.parse _namespace_name "StartEntertainementAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartBrewingCoffeeAction"></see>
    /// </summary>
    let StartBrewingCoffeeAction =
        Namespaced_IRI.parse _namespace_name "StartBrewingCoffeeAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartCookingAction"></see>
    /// </summary>
    let StartCookingAction =
        Namespaced_IRI.parse _namespace_name "StartCookingAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartBuyingAction"></see>
    /// </summary>
    let StartBuyingAction =
        Namespaced_IRI.parse _namespace_name "StartBuyingAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartCleaningAction"></see>
    /// </summary>
    let StartCleaningAction =
        Namespaced_IRI.parse _namespace_name "StartCleaningAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartDiswashingAction"></see>
    /// </summary>
    let StartDiswashingAction =
        Namespaced_IRI.parse _namespace_name "StartDiswashingAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartWashingAction"></see>
    /// </summary>
    let StartWashingAction =
        Namespaced_IRI.parse _namespace_name "StartWashingAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartDryingAction"></see>
    /// </summary>
    let StartDryingAction =
        Namespaced_IRI.parse _namespace_name "StartDryingAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartFocusingAction"></see>
    /// </summary>
    let StartFocusingAction =
        Namespaced_IRI.parse _namespace_name "StartFocusingAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartFocusingSessionAction"></see>
    /// </summary>
    let StartFocusingSessionAction =
        Namespaced_IRI.parse _namespace_name "StartFocusingSessionAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartListeningMusicAction"></see>
    /// </summary>
    let StartListeningMusicAction =
        Namespaced_IRI.parse _namespace_name "StartListeningMusicAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartOvenCookingAction"></see>
    /// </summary>
    let StartOvenCookingAction =
        Namespaced_IRI.parse _namespace_name "StartOvenCookingAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartPlayingAction"></see>
    /// </summary>
    let StartPlayingAction =
        Namespaced_IRI.parse _namespace_name "StartPlayingAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartStudyingSessionAction"></see>
    /// </summary>
    let StartStudyingSessionAction =
        Namespaced_IRI.parse _namespace_name "StartStudyingSessionAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartSuperMarketBuyingAction"></see>
    /// </summary>
    let StartSuperMarketBuyingAction =
        Namespaced_IRI.parse _namespace_name "StartSuperMarketBuyingAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartUsingSmartphoneAction"></see>
    /// </summary>
    let StartUsingSmartphoneAction =
        Namespaced_IRI.parse _namespace_name "StartUsingSmartphoneAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartVacuumAction"></see>
    /// </summary>
    let StartVacuumAction =
        Namespaced_IRI.parse _namespace_name "StartVacuumAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartWashingClothesAction"></see>
    /// </summary>
    let StartWashingClothesAction =
        Namespaced_IRI.parse _namespace_name "StartWashingClothesAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartWatchingTvAction"></see>
    /// </summary>
    let StartWatchingTvAction =
        Namespaced_IRI.parse _namespace_name "StartWatchingTvAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartedActivityTrigger"></see>
    /// </summary>
    let StartedActivityTrigger =
        Namespaced_IRI.parse _namespace_name "StartedActivityTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartedAppTrigger"></see>
    /// </summary>
    let StartedAppTrigger =
        Namespaced_IRI.parse _namespace_name "StartedAppTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartedEntertainementTrigger"></see>
    /// </summary>
    let StartedEntertainementTrigger =
        Namespaced_IRI.parse _namespace_name "StartedEntertainementTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartedBikeSessionTrigger"></see>
    /// </summary>
    let StartedBikeSessionTrigger =
        Namespaced_IRI.parse _namespace_name "StartedBikeSessionTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartedPhysicalActivityTrigger"></see>
    /// </summary>
    let StartedPhysicalActivityTrigger =
        Namespaced_IRI.parse _namespace_name "StartedPhysicalActivityTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartedBrewingCoffeeTrigger"></see>
    /// </summary>
    let StartedBrewingCoffeeTrigger =
        Namespaced_IRI.parse _namespace_name "StartedBrewingCoffeeTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartedCookingTrigger"></see>
    /// </summary>
    let StartedCookingTrigger =
        Namespaced_IRI.parse _namespace_name "StartedCookingTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartedCleaningTrigger"></see>
    /// </summary>
    let StartedCleaningTrigger =
        Namespaced_IRI.parse _namespace_name "StartedCleaningTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartedDiswashingTrigger"></see>
    /// </summary>
    let StartedDiswashingTrigger =
        Namespaced_IRI.parse _namespace_name "StartedDiswashingTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartedWashingTrigger"></see>
    /// </summary>
    let StartedWashingTrigger =
        Namespaced_IRI.parse _namespace_name "StartedWashingTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartedDryingTrigger"></see>
    /// </summary>
    let StartedDryingTrigger =
        Namespaced_IRI.parse _namespace_name "StartedDryingTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartedFocusingSessionTrigger"></see>
    /// </summary>
    let StartedFocusingSessionTrigger =
        Namespaced_IRI.parse _namespace_name "StartedFocusingSessionTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartedFocusingTrigger"></see>
    /// </summary>
    let StartedFocusingTrigger =
        Namespaced_IRI.parse _namespace_name "StartedFocusingTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartedInteractionTrigger"></see>
    /// </summary>
    let StartedInteractionTrigger =
        Namespaced_IRI.parse _namespace_name "StartedInteractionTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartedListeningMusicTrigger"></see>
    /// </summary>
    let StartedListeningMusicTrigger =
        Namespaced_IRI.parse _namespace_name "StartedListeningMusicTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartedOvenCookingTrigger"></see>
    /// </summary>
    let StartedOvenCookingTrigger =
        Namespaced_IRI.parse _namespace_name "StartedOvenCookingTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartedPlayingTrigger"></see>
    /// </summary>
    let StartedPlayingTrigger =
        Namespaced_IRI.parse _namespace_name "StartedPlayingTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartedRelaxingTrigger"></see>
    /// </summary>
    let StartedRelaxingTrigger =
        Namespaced_IRI.parse _namespace_name "StartedRelaxingTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartedRunSessionTrigger"></see>
    /// </summary>
    let StartedRunSessionTrigger =
        Namespaced_IRI.parse _namespace_name "StartedRunSessionTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartedSleepingTrigger"></see>
    /// </summary>
    let StartedSleepingTrigger =
        Namespaced_IRI.parse _namespace_name "StartedSleepingTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartedStudyingSessionTrigger"></see>
    /// </summary>
    let StartedStudyingSessionTrigger =
        Namespaced_IRI.parse _namespace_name "StartedStudyingSessionTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartedUsingSmartphoneTrigger"></see>
    /// </summary>
    let StartedUsingSmartphoneTrigger =
        Namespaced_IRI.parse _namespace_name "StartedUsingSmartphoneTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartedVacuumTrigger"></see>
    /// </summary>
    let StartedVacuumTrigger =
        Namespaced_IRI.parse _namespace_name "StartedVacuumTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartedWalkingSessionTrigger"></see>
    /// </summary>
    let StartedWalkingSessionTrigger =
        Namespaced_IRI.parse _namespace_name "StartedWalkingSessionTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartedWatchingTvTrigger"></see>
    /// </summary>
    let StartedWatchingTvTrigger =
        Namespaced_IRI.parse _namespace_name "StartedWatchingTvTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartingWashingClothesTrigger"></see>
    /// </summary>
    let StartingWashingClothesTrigger =
        Namespaced_IRI.parse _namespace_name "StartingWashingClothesTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StopActivityAction"></see>
    /// </summary>
    let StopActivityAction =
        Namespaced_IRI.parse _namespace_name "StopActivityAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StopAppAction"></see>
    /// </summary>
    let StopAppAction =
        Namespaced_IRI.parse _namespace_name "StopAppAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StopEntertainementAction"></see>
    /// </summary>
    let StopEntertainementAction =
        Namespaced_IRI.parse _namespace_name "StopEntertainementAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StopBrewingCoffeeAction"></see>
    /// </summary>
    let StopBrewingCoffeeAction =
        Namespaced_IRI.parse _namespace_name "StopBrewingCoffeeAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StopCookingAction"></see>
    /// </summary>
    let StopCookingAction =
        Namespaced_IRI.parse _namespace_name "StopCookingAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StopCleaningAction"></see>
    /// </summary>
    let StopCleaningAction =
        Namespaced_IRI.parse _namespace_name "StopCleaningAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StopDiswashingAction"></see>
    /// </summary>
    let StopDiswashingAction =
        Namespaced_IRI.parse _namespace_name "StopDiswashingAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StopWashingAction"></see>
    /// </summary>
    let StopWashingAction =
        Namespaced_IRI.parse _namespace_name "StopWashingAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StopDryingAction"></see>
    /// </summary>
    let StopDryingAction =
        Namespaced_IRI.parse _namespace_name "StopDryingAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StopFocusingAction"></see>
    /// </summary>
    let StopFocusingAction =
        Namespaced_IRI.parse _namespace_name "StopFocusingAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StopFocusingSessionAction"></see>
    /// </summary>
    let StopFocusingSessionAction =
        Namespaced_IRI.parse _namespace_name "StopFocusingSessionAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StopListeningMusicAction"></see>
    /// </summary>
    let StopListeningMusicAction =
        Namespaced_IRI.parse _namespace_name "StopListeningMusicAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StopOvenCookingAction"></see>
    /// </summary>
    let StopOvenCookingAction =
        Namespaced_IRI.parse _namespace_name "StopOvenCookingAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StopPlayingAction"></see>
    /// </summary>
    let StopPlayingAction =
        Namespaced_IRI.parse _namespace_name "StopPlayingAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StopStudyingSessionAction"></see>
    /// </summary>
    let StopStudyingSessionAction =
        Namespaced_IRI.parse _namespace_name "StopStudyingSessionAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StopUsingSmartphoneAction"></see>
    /// </summary>
    let StopUsingSmartphoneAction =
        Namespaced_IRI.parse _namespace_name "StopUsingSmartphoneAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StopVacuumAction"></see>
    /// </summary>
    let StopVacuumAction =
        Namespaced_IRI.parse _namespace_name "StopVacuumAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StopWashingClothesAction"></see>
    /// </summary>
    let StopWashingClothesAction =
        Namespaced_IRI.parse _namespace_name "StopWashingClothesAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StopWatchingTvAction"></see>
    /// </summary>
    let StopWatchingTvAction =
        Namespaced_IRI.parse _namespace_name "StopWatchingTvAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StoppedActivityTrigger"></see>
    /// </summary>
    let StoppedActivityTrigger =
        Namespaced_IRI.parse _namespace_name "StoppedActivityTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StoppedAppTrigger"></see>
    /// </summary>
    let StoppedAppTrigger =
        Namespaced_IRI.parse _namespace_name "StoppedAppTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StoppedEntertainementTrigger"></see>
    /// </summary>
    let StoppedEntertainementTrigger =
        Namespaced_IRI.parse _namespace_name "StoppedEntertainementTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StoppedBikeSessionTrigger"></see>
    /// </summary>
    let StoppedBikeSessionTrigger =
        Namespaced_IRI.parse _namespace_name "StoppedBikeSessionTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StoppedPhysicalActivityTrigger"></see>
    /// </summary>
    let StoppedPhysicalActivityTrigger =
        Namespaced_IRI.parse _namespace_name "StoppedPhysicalActivityTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StoppedBrewingCoffeeTrigger"></see>
    /// </summary>
    let StoppedBrewingCoffeeTrigger =
        Namespaced_IRI.parse _namespace_name "StoppedBrewingCoffeeTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StoppedCookingTrigger"></see>
    /// </summary>
    let StoppedCookingTrigger =
        Namespaced_IRI.parse _namespace_name "StoppedCookingTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StoppedDiswashingTrigger"></see>
    /// </summary>
    let StoppedDiswashingTrigger =
        Namespaced_IRI.parse _namespace_name "StoppedDiswashingTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StoppedWashingTrigger"></see>
    /// </summary>
    let StoppedWashingTrigger =
        Namespaced_IRI.parse _namespace_name "StoppedWashingTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StoppedDryingTrigger"></see>
    /// </summary>
    let StoppedDryingTrigger =
        Namespaced_IRI.parse _namespace_name "StoppedDryingTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StoppedFocusingSessionTrigger"></see>
    /// </summary>
    let StoppedFocusingSessionTrigger =
        Namespaced_IRI.parse _namespace_name "StoppedFocusingSessionTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StoppedFocusingTrigger"></see>
    /// </summary>
    let StoppedFocusingTrigger =
        Namespaced_IRI.parse _namespace_name "StoppedFocusingTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StoppedListeningMusicTrigger"></see>
    /// </summary>
    let StoppedListeningMusicTrigger =
        Namespaced_IRI.parse _namespace_name "StoppedListeningMusicTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StoppedOvenCookingTrigger"></see>
    /// </summary>
    let StoppedOvenCookingTrigger =
        Namespaced_IRI.parse _namespace_name "StoppedOvenCookingTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StoppedPlayingTrigger"></see>
    /// </summary>
    let StoppedPlayingTrigger =
        Namespaced_IRI.parse _namespace_name "StoppedPlayingTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StoppedRelaxingTrigger"></see>
    /// </summary>
    let StoppedRelaxingTrigger =
        Namespaced_IRI.parse _namespace_name "StoppedRelaxingTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StoppedRunSessionTrigger"></see>
    /// </summary>
    let StoppedRunSessionTrigger =
        Namespaced_IRI.parse _namespace_name "StoppedRunSessionTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StoppedSleepingTrigger"></see>
    /// </summary>
    let StoppedSleepingTrigger =
        Namespaced_IRI.parse _namespace_name "StoppedSleepingTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StoppedStudyingSessionTrigger"></see>
    /// </summary>
    let StoppedStudyingSessionTrigger =
        Namespaced_IRI.parse _namespace_name "StoppedStudyingSessionTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StoppedUsingSmartphoneTrigger"></see>
    /// </summary>
    let StoppedUsingSmartphoneTrigger =
        Namespaced_IRI.parse _namespace_name "StoppedUsingSmartphoneTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StoppedWalkingSessionTrigger"></see>
    /// </summary>
    let StoppedWalkingSessionTrigger =
        Namespaced_IRI.parse _namespace_name "StoppedWalkingSessionTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StoppedWashingClothesTrigger"></see>
    /// </summary>
    let StoppedWashingClothesTrigger =
        Namespaced_IRI.parse _namespace_name "StoppedWashingClothesTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StoppedWatchingTvTrigger"></see>
    /// </summary>
    let StoppedWatchingTvTrigger =
        Namespaced_IRI.parse _namespace_name "StoppedWatchingTvTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StoredAppTrigger"></see>
    /// </summary>
    let StoredAppTrigger =
        Namespaced_IRI.parse _namespace_name "StoredAppTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StoredTrigger"></see>
    /// </summary>
    let StoredTrigger =
        Namespaced_IRI.parse _namespace_name "StoredTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StoredBackupTrigger"></see>
    /// </summary>
    let StoredBackupTrigger =
        Namespaced_IRI.parse _namespace_name "StoredBackupTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StoredContactTrigger"></see>
    /// </summary>
    let StoredContactTrigger =
        Namespaced_IRI.parse _namespace_name "StoredContactTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StoredFileTrigger"></see>
    /// </summary>
    let StoredFileTrigger =
        Namespaced_IRI.parse _namespace_name "StoredFileTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StoredHealthInformationTrigger"></see>
    /// </summary>
    let StoredHealthInformationTrigger =
        Namespaced_IRI.parse _namespace_name "StoredHealthInformationTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StoredMediaInformationTrigger"></see>
    /// </summary>
    let StoredMediaInformationTrigger =
        Namespaced_IRI.parse _namespace_name "StoredMediaInformationTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StoredWebBookmarkTrigger"></see>
    /// </summary>
    let StoredWebBookmarkTrigger =
        Namespaced_IRI.parse _namespace_name "StoredWebBookmarkTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StudyingTrackingService"></see>
    /// </summary>
    let StudyingTrackingService =
        Namespaced_IRI.parse _namespace_name "StudyingTrackingService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#TVService"></see>
    /// </summary>
    let TVService = Namespaced_IRI.parse _namespace_name "TVService" |> NamespacedName
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Tablet"></see>
    /// </summary>
    let Tablet = Namespaced_IRI.parse _namespace_name "Tablet" |> NamespacedName
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#TagService"></see>
    /// </summary>
    let TagService = Namespaced_IRI.parse _namespace_name "TagService" |> NamespacedName
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#TakeAction"></see>
    /// </summary>
    let TakeAction = Namespaced_IRI.parse _namespace_name "TakeAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#TakeAudioAction"></see>
    /// </summary>
    let TakeAudioAction =
        Namespaced_IRI.parse _namespace_name "TakeAudioAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#TakePhotoAction"></see>
    /// </summary>
    let TakePhotoAction =
        Namespaced_IRI.parse _namespace_name "TakePhotoAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#TakeVideoAction"></see>
    /// </summary>
    let TakeVideoAction =
        Namespaced_IRI.parse _namespace_name "TakeVideoAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#TakenAudioTrigger"></see>
    /// </summary>
    let TakenAudioTrigger =
        Namespaced_IRI.parse _namespace_name "TakenAudioTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#TakenTrigger"></see>
    /// </summary>
    let TakenTrigger =
        Namespaced_IRI.parse _namespace_name "TakenTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#TakenImageTrigger"></see>
    /// </summary>
    let TakenImageTrigger =
        Namespaced_IRI.parse _namespace_name "TakenImageTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#TakenVideoTrigger"></see>
    /// </summary>
    let TakenVideoTrigger =
        Namespaced_IRI.parse _namespace_name "TakenVideoTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#TapButtonActivityTrigger"></see>
    /// </summary>
    let TapButtonActivityTrigger =
        Namespaced_IRI.parse _namespace_name "TapButtonActivityTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#TemperatureSetToTrigger"></see>
    /// </summary>
    let TemperatureSetToTrigger =
        Namespaced_IRI.parse _namespace_name "TemperatureSetToTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#TemporalTrigger"></see>
    /// </summary>
    let TemporalTrigger =
        Namespaced_IRI.parse _namespace_name "TemporalTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Thermostat"></see>
    /// </summary>
    let Thermostat = Namespaced_IRI.parse _namespace_name "Thermostat" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#TimeManagementTool"></see>
    /// </summary>
    let TimeManagementTool =
        Namespaced_IRI.parse _namespace_name "TimeManagementTool" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#TimerService"></see>
    /// </summary>
    let TimerService =
        Namespaced_IRI.parse _namespace_name "TimerService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ToDoTool"></see>
    /// </summary>
    let ToDoTool = Namespaced_IRI.parse _namespace_name "ToDoTool" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ToggleSwitchTrigger"></see>
    /// </summary>
    let ToggleSwitchTrigger =
        Namespaced_IRI.parse _namespace_name "ToggleSwitchTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#TurnAlarmOffAction"></see>
    /// </summary>
    let TurnAlarmOffAction =
        Namespaced_IRI.parse _namespace_name "TurnAlarmOffAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#TurnDeviceOffAction"></see>
    /// </summary>
    let TurnDeviceOffAction =
        Namespaced_IRI.parse _namespace_name "TurnDeviceOffAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#TurnDeviceOnAction"></see>
    /// </summary>
    let TurnDeviceOnAction =
        Namespaced_IRI.parse _namespace_name "TurnDeviceOnAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Tv"></see>
    /// </summary>
    let Tv = Namespaced_IRI.parse _namespace_name "Tv" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#UnlikeService"></see>
    /// </summary>
    let UnlikeService =
        Namespaced_IRI.parse _namespace_name "UnlikeService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#UpdatedWallpaperTrigger"></see>
    /// </summary>
    let UpdatedWallpaperTrigger =
        Namespaced_IRI.parse _namespace_name "UpdatedWallpaperTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#VacuumService"></see>
    /// </summary>
    let VacuumService =
        Namespaced_IRI.parse _namespace_name "VacuumService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#VehicleTrackingService"></see>
    /// </summary>
    let VehicleTrackingService =
        Namespaced_IRI.parse _namespace_name "VehicleTrackingService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Ventilator"></see>
    /// </summary>
    let Ventilator = Namespaced_IRI.parse _namespace_name "Ventilator" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#VideoPlatform"></see>
    /// </summary>
    let VideoPlatform =
        Namespaced_IRI.parse _namespace_name "VideoPlatform" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#VideoRecordingService"></see>
    /// </summary>
    let VideoRecordingService =
        Namespaced_IRI.parse _namespace_name "VideoRecordingService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#VideoService"></see>
    /// </summary>
    let VideoService =
        Namespaced_IRI.parse _namespace_name "VideoService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#VoiceAssistant"></see>
    /// </summary>
    let VoiceAssistant =
        Namespaced_IRI.parse _namespace_name "VoiceAssistant" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#VolumeDecreasedTrigger"></see>
    /// </summary>
    let VolumeDecreasedTrigger =
        Namespaced_IRI.parse _namespace_name "VolumeDecreasedTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#VolumeIncreasedTrigger"></see>
    /// </summary>
    let VolumeIncreasedTrigger =
        Namespaced_IRI.parse _namespace_name "VolumeIncreasedTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#VolumeService"></see>
    /// </summary>
    let VolumeService =
        Namespaced_IRI.parse _namespace_name "VolumeService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#WalkTrackingService"></see>
    /// </summary>
    let WalkTrackingService =
        Namespaced_IRI.parse _namespace_name "WalkTrackingService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#WashingMachine"></see>
    /// </summary>
    let WashingMachine =
        Namespaced_IRI.parse _namespace_name "WashingMachine" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#WashingService"></see>
    /// </summary>
    let WashingService =
        Namespaced_IRI.parse _namespace_name "WashingService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#WaterTemperatureSystemDisabledTrigger"></see>
    /// </summary>
    let WaterTemperatureSystemDisabledTrigger =
        Namespaced_IRI.parse _namespace_name "WaterTemperatureSystemDisabledTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#WaterTemperatureSystemEnabledTrigger"></see>
    /// </summary>
    let WaterTemperatureSystemEnabledTrigger =
        Namespaced_IRI.parse _namespace_name "WaterTemperatureSystemEnabledTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#WateringService"></see>
    /// </summary>
    let WateringService =
        Namespaced_IRI.parse _namespace_name "WateringService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#WateringSystemDisabledTrigger"></see>
    /// </summary>
    let WateringSystemDisabledTrigger =
        Namespaced_IRI.parse _namespace_name "WateringSystemDisabledTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#WateringSystemEnabledTrigger"></see>
    /// </summary>
    let WateringSystemEnabledTrigger =
        Namespaced_IRI.parse _namespace_name "WateringSystemEnabledTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#WeatherService"></see>
    /// </summary>
    let WeatherService =
        Namespaced_IRI.parse _namespace_name "WeatherService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#WeatherStation"></see>
    /// </summary>
    let WeatherStation =
        Namespaced_IRI.parse _namespace_name "WeatherStation" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#WeatherWebSite"></see>
    /// </summary>
    let WeatherWebSite =
        Namespaced_IRI.parse _namespace_name "WeatherWebSite" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#WebBookmarkService"></see>
    /// </summary>
    let WebBookmarkService =
        Namespaced_IRI.parse _namespace_name "WebBookmarkService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#WebBookmarkTool"></see>
    /// </summary>
    let WebBookmarkTool =
        Namespaced_IRI.parse _namespace_name "WebBookmarkTool" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#WebRequestService"></see>
    /// </summary>
    let WebRequestService =
        Namespaced_IRI.parse _namespace_name "WebRequestService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#WifiService"></see>
    /// </summary>
    let WifiService =
        Namespaced_IRI.parse _namespace_name "WifiService" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#WindowFrameClosedTrigger"></see>
    /// </summary>
    let WindowFrameClosedTrigger =
        Namespaced_IRI.parse _namespace_name "WindowFrameClosedTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#WindowFrameOpenedTrigger"></see>
    /// </summary>
    let WindowFrameOpenedTrigger =
        Namespaced_IRI.parse _namespace_name "WindowFrameOpenedTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#WorseDeviceConditionAction"></see>
    /// </summary>
    let WorseDeviceConditionAction =
        Namespaced_IRI.parse _namespace_name "WorseDeviceConditionAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#WorseDeviceConditionTrigger"></see>
    /// </summary>
    let WorseDeviceConditionTrigger =
        Namespaced_IRI.parse _namespace_name "WorseDeviceConditionTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#allowTo"></see>
    /// </summary>
    let allowTo = Namespaced_IRI.parse _namespace_name "allowTo" |> NamespacedName
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#canControl"></see>
    /// </summary>
    let canControl = Namespaced_IRI.parse _namespace_name "canControl" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#channelOffer"></see>
    /// </summary>
    let channelOffer =
        Namespaced_IRI.parse _namespace_name "channelOffer" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#isOfChannel"></see>
    /// </summary>
    let isOfChannel =
        Namespaced_IRI.parse _namespace_name "isOfChannel" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#commandAllowTo"></see>
    /// </summary>
    let commandAllowTo =
        Namespaced_IRI.parse _namespace_name "commandAllowTo" |> NamespacedName

    /// <summary>
    /// description
    /// <see href="http://elite.polito.it/ontologies/eupont.owl#description"></see></summary>
    let description =
        Namespaced_IRI.parse _namespace_name "description" |> NamespacedName

    /// <summary>
    /// detail
    /// <see href="http://elite.polito.it/ontologies/eupont.owl#detail"></see></summary>
    let detail = Namespaced_IRI.parse _namespace_name "detail" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#hasCategory"></see>
    /// </summary>
    let hasCategory =
        Namespaced_IRI.parse _namespace_name "hasCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#hasDetail"></see>
    /// </summary>
    let hasDetail = Namespaced_IRI.parse _namespace_name "hasDetail" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#hasRegisteredEntity"></see>
    /// </summary>
    let hasRegisteredEntity =
        Namespaced_IRI.parse _namespace_name "hasRegisteredEntity" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#hasTechnology"></see>
    /// </summary>
    let hasTechnology =
        Namespaced_IRI.parse _namespace_name "hasTechnology" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#location"></see>
    /// </summary>
    let location = Namespaced_IRI.parse _namespace_name "location" |> NamespacedName
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#nominal"></see>
    /// </summary>
    let nominal = Namespaced_IRI.parse _namespace_name "nominal" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#nominalDetail"></see>
    /// </summary>
    let nominalDetail =
        Namespaced_IRI.parse _namespace_name "nominalDetail" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#notificationAllowTo"></see>
    /// </summary>
    let notificationAllowTo =
        Namespaced_IRI.parse _namespace_name "notificationAllowTo" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#offerAction"></see>
    /// </summary>
    let offerAction =
        Namespaced_IRI.parse _namespace_name "offerAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#offerDetail"></see>
    /// </summary>
    let offerDetail =
        Namespaced_IRI.parse _namespace_name "offerDetail" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#offerTrigger"></see>
    /// </summary>
    let offerTrigger =
        Namespaced_IRI.parse _namespace_name "offerTrigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#triggers"></see>
    /// </summary>
    let triggers = Namespaced_IRI.parse _namespace_name "triggers" |> NamespacedName
    /// <summary>
    /// type
    /// <see href="http://elite.polito.it/ontologies/eupont.owl#type"></see></summary>
    let type_ = Namespaced_IRI.parse _namespace_name "type" |> NamespacedName
    /// <summary>
    /// value
    /// <see href="http://elite.polito.it/ontologies/eupont.owl#value"></see></summary>
    let value = Namespaced_IRI.parse _namespace_name "value" |> NamespacedName
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#where"></see>
    /// </summary>
    let where = Namespaced_IRI.parse _namespace_name "where" |> NamespacedName
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#which"></see>
    /// </summary>
    let which = Namespaced_IRI.parse _namespace_name "which" |> NamespacedName
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#who"></see>
    /// </summary>
    let who = Namespaced_IRI.parse _namespace_name "who" |> NamespacedName
