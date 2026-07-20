namespace http.elite.polito.it.ontologies.eupont.owl.hash

open DoxAletheia

module eupont =
    let _namespace_name = "http://elite.polito.it/ontologies/eupont.owl#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#CloseNotification"></see>
    /// </summary>
    let CloseNotification = _prefix "CloseNotification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ConnectNotification"></see>
    /// </summary>
    let ConnectNotification = _prefix "ConnectNotification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeleteNotification"></see>
    /// </summary>
    let DeleteNotification = _prefix "DeleteNotification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DisableNotification"></see>
    /// </summary>
    let DisableNotification = _prefix "DisableNotification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DisconnectNotification"></see>
    /// </summary>
    let DisconnectNotification = _prefix "DisconnectNotification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EnableNotification"></see>
    /// </summary>
    let EnableNotification = _prefix "EnableNotification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EnterNotification"></see>
    /// </summary>
    let EnterNotification = _prefix "EnterNotification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ExitNotification"></see>
    /// </summary>
    let ExitNotification = _prefix "ExitNotification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#MeasureAboveThresholdNotification"></see>
    /// </summary>
    let MeasureAboveThresholdNotification = _prefix "MeasureAboveThresholdNotification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#MeasureAvailableNotification"></see>
    /// </summary>
    let MeasureAvailableNotification = _prefix "MeasureAvailableNotification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#MeasureBelowThresholdNotification"></see>
    /// </summary>
    let MeasureBelowThresholdNotification = _prefix "MeasureBelowThresholdNotification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#NewNotification"></see>
    /// </summary>
    let NewNotification = _prefix "NewNotification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#OpenNotification"></see>
    /// </summary>
    let OpenNotification = _prefix "OpenNotification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#PresenceDetectedNotification"></see>
    /// </summary>
    let PresenceDetectedNotification = _prefix "PresenceDetectedNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#PresenceNoLongerDetectedNotification"></see>
    /// </summary>
    let PresenceNoLongerDetectedNotification =
        _prefix "PresenceNoLongerDetectedNotification"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ReceiveNotification"></see>
    /// </summary>
    let ReceiveNotification = _prefix "ReceiveNotification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#RecordNotification"></see>
    /// </summary>
    let RecordNotification = _prefix "RecordNotification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SaveNotification"></see>
    /// </summary>
    let SaveNotification = _prefix "SaveNotification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SendNotification"></see>
    /// </summary>
    let SendNotification = _prefix "SendNotification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SetToNotification"></see>
    /// </summary>
    let SetToNotification = _prefix "SetToNotification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ShareNotification"></see>
    /// </summary>
    let ShareNotification = _prefix "ShareNotification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartNotification"></see>
    /// </summary>
    let StartNotification = _prefix "StartNotification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StopNotification"></see>
    /// </summary>
    let StopNotification = _prefix "StopNotification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#TurnOffNotification"></see>
    /// </summary>
    let TurnOffNotification = _prefix "TurnOffNotification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#TurnOnNotification"></see>
    /// </summary>
    let TurnOnNotification = _prefix "TurnOnNotification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#CloseCommand"></see>
    /// </summary>
    let CloseCommand = _prefix "CloseCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ConnectCommand"></see>
    /// </summary>
    let ConnectCommand = _prefix "ConnectCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeleteCommand"></see>
    /// </summary>
    let DeleteCommand = _prefix "DeleteCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DisableCommand"></see>
    /// </summary>
    let DisableCommand = _prefix "DisableCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DisconnectCommand"></see>
    /// </summary>
    let DisconnectCommand = _prefix "DisconnectCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EnableCommand"></see>
    /// </summary>
    let EnableCommand = _prefix "EnableCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#NewCommand"></see>
    /// </summary>
    let NewCommand = _prefix "NewCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#OpenCommand"></see>
    /// </summary>
    let OpenCommand = _prefix "OpenCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#RecordCommand"></see>
    /// </summary>
    let RecordCommand = _prefix "RecordCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SaveCommand"></see>
    /// </summary>
    let SaveCommand = _prefix "SaveCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SendCommand"></see>
    /// </summary>
    let SendCommand = _prefix "SendCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SetToCommand"></see>
    /// </summary>
    let SetToCommand = _prefix "SetToCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ShareCommand"></see>
    /// </summary>
    let ShareCommand = _prefix "ShareCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartCommand"></see>
    /// </summary>
    let StartCommand = _prefix "StartCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StopCommand"></see>
    /// </summary>
    let StopCommand = _prefix "StopCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ToggleCommand"></see>
    /// </summary>
    let ToggleCommand = _prefix "ToggleCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#TurnOffCommand"></see>
    /// </summary>
    let TurnOffCommand = _prefix "TurnOffCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#TurnOnCommand"></see>
    /// </summary>
    let TurnOnCommand = _prefix "TurnOnCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#AcceptCommunicationAction"></see>
    /// </summary>
    let AcceptCommunicationAction = _prefix "AcceptCommunicationAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#GetAction"></see>
    /// </summary>
    let GetAction = _prefix "GetAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Action"></see>
    /// </summary>
    let Action = _prefix "Action"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#RuleNominalAxiom"></see>
    /// </summary>
    let RuleNominalAxiom = _prefix "RuleNominalAxiom"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ActivateEnvironmentSceneAction"></see>
    /// </summary>
    let ActivateEnvironmentSceneAction = _prefix "ActivateEnvironmentSceneAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SetEnvironmentComfortAction"></see>
    /// </summary>
    let SetEnvironmentComfortAction = _prefix "SetEnvironmentComfortAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ActivityAction"></see>
    /// </summary>
    let ActivityAction = _prefix "ActivityAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ActivityTrigger"></see>
    /// </summary>
    let ActivityTrigger = _prefix "ActivityTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Trigger"></see>
    /// </summary>
    let Trigger = _prefix "Trigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#AddAlarmAction"></see>
    /// </summary>
    let AddAlarmAction = _prefix "AddAlarmAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#AddRemindAction"></see>
    /// </summary>
    let AddRemindAction = _prefix "AddRemindAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#AddCalendarItemAction"></see>
    /// </summary>
    let AddCalendarItemAction = _prefix "AddCalendarItemAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SaveAction"></see>
    /// </summary>
    let SaveAction = _prefix "SaveAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#AddReminderAction"></see>
    /// </summary>
    let AddReminderAction = _prefix "AddReminderAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#AddTimerAction"></see>
    /// </summary>
    let AddTimerAction = _prefix "AddTimerAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#AddedAlarmTrigger"></see>
    /// </summary>
    let AddedAlarmTrigger = _prefix "AddedAlarmTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#AddedRemindTrigger"></see>
    /// </summary>
    let AddedRemindTrigger = _prefix "AddedRemindTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#AddedCalendarItemTrigger"></see>
    /// </summary>
    let AddedCalendarItemTrigger = _prefix "AddedCalendarItemTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SavedTrigger"></see>
    /// </summary>
    let SavedTrigger = _prefix "SavedTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#AddedReminderTrigger"></see>
    /// </summary>
    let AddedReminderTrigger = _prefix "AddedReminderTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#AddedTimerTrigger"></see>
    /// </summary>
    let AddedTimerTrigger = _prefix "AddedTimerTrigger"
    /// <summary>
    /// An agent (eg. person, group, software or physical artifact).
    /// <see href="http://elite.polito.it/ontologies/eupont.owl#Agent"></see></summary>
    let Agent = _prefix "Agent"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#AirConditioner"></see>
    /// </summary>
    let AirConditioner = _prefix "AirConditioner"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SmartEnvironmentSystem"></see>
    /// </summary>
    let SmartEnvironmentSystem = _prefix "SmartEnvironmentSystem"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#AirMonitor"></see>
    /// </summary>
    let AirMonitor = _prefix "AirMonitor"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#AirPressureService"></see>
    /// </summary>
    let AirPressureService = _prefix "AirPressureService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SmartEnvironmentService"></see>
    /// </summary>
    let SmartEnvironmentService = _prefix "SmartEnvironmentService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#AirPurifier"></see>
    /// </summary>
    let AirPurifier = _prefix "AirPurifier"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#AirPurifierDisabledTrigger"></see>
    /// </summary>
    let AirPurifierDisabledTrigger = _prefix "AirPurifierDisabledTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DecreasedAirQualityTrigger"></see>
    /// </summary>
    let DecreasedAirQualityTrigger = _prefix "DecreasedAirQualityTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#AirPurifierEnabledTrigger"></see>
    /// </summary>
    let AirPurifierEnabledTrigger = _prefix "AirPurifierEnabledTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#IncreasedAirQualityTrigger"></see>
    /// </summary>
    let IncreasedAirQualityTrigger = _prefix "IncreasedAirQualityTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#AirPurifierService"></see>
    /// </summary>
    let AirPurifierService = _prefix "AirPurifierService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#AlarmClockService"></see>
    /// </summary>
    let AlarmClockService = _prefix "AlarmClockService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#TimeService"></see>
    /// </summary>
    let TimeService = _prefix "TimeService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#AnswerCallAction"></see>
    /// </summary>
    let AnswerCallAction = _prefix "AnswerCallAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#AntiIntrusionSystem"></see>
    /// </summary>
    let AntiIntrusionSystem = _prefix "AntiIntrusionSystem"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Appliance"></see>
    /// </summary>
    let Appliance = _prefix "Appliance"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#PhysicalObject"></see>
    /// </summary>
    let PhysicalObject = _prefix "PhysicalObject"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ApplianceService"></see>
    /// </summary>
    let ApplianceService = _prefix "ApplianceService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Service"></see>
    /// </summary>
    let Service = _prefix "Service"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ArriveOnVehicleTrigger"></see>
    /// </summary>
    let ArriveOnVehicleTrigger = _prefix "ArriveOnVehicleTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EnterTrigger"></see>
    /// </summary>
    let EnterTrigger = _prefix "EnterTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#AttachementService"></see>
    /// </summary>
    let AttachementService = _prefix "AttachementService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#InformationService"></see>
    /// </summary>
    let InformationService = _prefix "InformationService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#CommunicationService"></see>
    /// </summary>
    let CommunicationService = _prefix "CommunicationService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#AudioRecordingService"></see>
    /// </summary>
    let AudioRecordingService = _prefix "AudioRecordingService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#RecordingService"></see>
    /// </summary>
    let RecordingService = _prefix "RecordingService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#AudioService"></see>
    /// </summary>
    let AudioService = _prefix "AudioService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#OutputService"></see>
    /// </summary>
    let OutputService = _prefix "OutputService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#BatteryService"></see>
    /// </summary>
    let BatteryService = _prefix "BatteryService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeviceService"></see>
    /// </summary>
    let DeviceService = _prefix "DeviceService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Beacon"></see>
    /// </summary>
    let Beacon = _prefix "Beacon"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#BikeTrackingService"></see>
    /// </summary>
    let BikeTrackingService = _prefix "BikeTrackingService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#TrackingService"></see>
    /// </summary>
    let TrackingService = _prefix "TrackingService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#BlockCallAction"></see>
    /// </summary>
    let BlockCallAction = _prefix "BlockCallAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DecreaseUserConnectivityAction"></see>
    /// </summary>
    let DecreaseUserConnectivityAction = _prefix "DecreaseUserConnectivityAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Blog"></see>
    /// </summary>
    let Blog = _prefix "Blog"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#NewsTool"></see>
    /// </summary>
    let NewsTool = _prefix "NewsTool"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#BluetoothService"></see>
    /// </summary>
    let BluetoothService = _prefix "BluetoothService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#NetworkService"></see>
    /// </summary>
    let NetworkService = _prefix "NetworkService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#BrightnessDecreasedTrigger"></see>
    /// </summary>
    let BrightnessDecreasedTrigger = _prefix "BrightnessDecreasedTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ImprovedLightingConditionTrigger"></see>
    /// </summary>
    let ImprovedLightingConditionTrigger = _prefix "ImprovedLightingConditionTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#BrightnessIncreasedTrigger"></see>
    /// </summary>
    let BrightnessIncreasedTrigger = _prefix "BrightnessIncreasedTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Building"></see>
    /// </summary>
    let Building = _prefix "Building"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Location"></see>
    /// </summary>
    let Location = _prefix "Location"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#BuyCommand"></see>
    /// </summary>
    let BuyCommand = _prefix "BuyCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Command"></see>
    /// </summary>
    let Command = _prefix "Command"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#CalendarService"></see>
    /// </summary>
    let CalendarService = _prefix "CalendarService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#CalendarTool"></see>
    /// </summary>
    let CalendarTool = _prefix "CalendarTool"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#OrganizerTool"></see>
    /// </summary>
    let OrganizerTool = _prefix "OrganizerTool"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#CallService"></see>
    /// </summary>
    let CallService = _prefix "CallService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#CallTool"></see>
    /// </summary>
    let CallTool = _prefix "CallTool"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#CommunicationTool"></see>
    /// </summary>
    let CommunicationTool = _prefix "CommunicationTool"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Camera"></see>
    /// </summary>
    let Camera = _prefix "Camera"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Category"></see>
    /// </summary>
    let Category = _prefix "Category"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Channel"></see>
    /// </summary>
    let Channel = _prefix "Channel"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ChatTool"></see>
    /// </summary>
    let ChatTool = _prefix "ChatTool"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Notification"></see>
    /// </summary>
    let Notification = _prefix "Notification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#CloseSafetyValveAction"></see>
    /// </summary>
    let CloseSafetyValveAction = _prefix "CloseSafetyValveAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#IncreaseSecurityAction"></see>
    /// </summary>
    let IncreaseSecurityAction = _prefix "IncreaseSecurityAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#CloseWindowFrameAction"></see>
    /// </summary>
    let CloseWindowFrameAction = _prefix "CloseWindowFrameAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#IncreaseTemperatureAction"></see>
    /// </summary>
    let IncreaseTemperatureAction = _prefix "IncreaseTemperatureAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DecreaseLightingAction"></see>
    /// </summary>
    let DecreaseLightingAction = _prefix "DecreaseLightingAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#CloudPlatform"></see>
    /// </summary>
    let CloudPlatform = _prefix "CloudPlatform"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StoragePlatform"></see>
    /// </summary>
    let StoragePlatform = _prefix "StoragePlatform"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#CodeHostingPlatform"></see>
    /// </summary>
    let CodeHostingPlatform = _prefix "CodeHostingPlatform"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeveloperTool"></see>
    /// </summary>
    let DeveloperTool = _prefix "DeveloperTool"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#CoffeeMaker"></see>
    /// </summary>
    let CoffeeMaker = _prefix "CoffeeMaker"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#CoffeeService"></see>
    /// </summary>
    let CoffeeService = _prefix "CoffeeService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Colleague"></see>
    /// </summary>
    let Colleague = _prefix "Colleague"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#CommentService"></see>
    /// </summary>
    let CommentService = _prefix "CommentService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#VirtualObject"></see>
    /// </summary>
    let VirtualObject = _prefix "VirtualObject"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ConnectDeviceAction"></see>
    /// </summary>
    let ConnectDeviceAction = _prefix "ConnectDeviceAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#IncreaseConnectivityAction"></see>
    /// </summary>
    let IncreaseConnectivityAction = _prefix "IncreaseConnectivityAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ConnectToDeviceAction"></see>
    /// </summary>
    let ConnectToDeviceAction = _prefix "ConnectToDeviceAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ConnectToNetworkAction"></see>
    /// </summary>
    let ConnectToNetworkAction = _prefix "ConnectToNetworkAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ConnectToWebServiceAction"></see>
    /// </summary>
    let ConnectToWebServiceAction = _prefix "ConnectToWebServiceAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ConnectedVehicle"></see>
    /// </summary>
    let ConnectedVehicle = _prefix "ConnectedVehicle"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SmartCitySystem"></see>
    /// </summary>
    let SmartCitySystem = _prefix "SmartCitySystem"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ConnectionToDeviceTrigger"></see>
    /// </summary>
    let ConnectionToDeviceTrigger = _prefix "ConnectionToDeviceTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeviceConnectedTrigger"></see>
    /// </summary>
    let DeviceConnectedTrigger = _prefix "DeviceConnectedTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ConnectionToNetworkTrigger"></see>
    /// </summary>
    let ConnectionToNetworkTrigger = _prefix "ConnectionToNetworkTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ConnectivityAction"></see>
    /// </summary>
    let ConnectivityAction = _prefix "ConnectivityAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ConnectivityTrigger"></see>
    /// </summary>
    let ConnectivityTrigger = _prefix "ConnectivityTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Console"></see>
    /// </summary>
    let Console = _prefix "Console"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ContactService"></see>
    /// </summary>
    let ContactService = _prefix "ContactService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Cooker"></see>
    /// </summary>
    let Cooker = _prefix "Cooker"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#CoolingService"></see>
    /// </summary>
    let CoolingService = _prefix "CoolingService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#CoolingSystemDisabledTrigger"></see>
    /// </summary>
    let CoolingSystemDisabledTrigger = _prefix "CoolingSystemDisabledTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#IncreasedTemperatureTrigger"></see>
    /// </summary>
    let IncreasedTemperatureTrigger = _prefix "IncreasedTemperatureTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#CoolingSystemEnabledTrigger"></see>
    /// </summary>
    let CoolingSystemEnabledTrigger = _prefix "CoolingSystemEnabledTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DecreasedTemperatureTrigger"></see>
    /// </summary>
    let DecreasedTemperatureTrigger = _prefix "DecreasedTemperatureTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DIYElectronic"></see>
    /// </summary>
    let DIYElectronic = _prefix "DIYElectronic"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DangerousActivityDetectedTrigger"></see>
    /// </summary>
    let DangerousActivityDetectedTrigger = _prefix "DangerousActivityDetectedTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#UnhealthyActivityTrigger"></see>
    /// </summary>
    let UnhealthyActivityTrigger = _prefix "UnhealthyActivityTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DangerousActivityTrackingService"></see>
    /// </summary>
    let DangerousActivityTrackingService = _prefix "DangerousActivityTrackingService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DecreaseAirQualityAction"></see>
    /// </summary>
    let DecreaseAirQualityAction = _prefix "DecreaseAirQualityAction"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DecreaseEnvironmentConditionAction"></see>
    /// </summary>
    let DecreaseEnvironmentConditionAction =
        _prefix "DecreaseEnvironmentConditionAction"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DecreaseConnectivityAction"></see>
    /// </summary>
    let DecreaseConnectivityAction = _prefix "DecreaseConnectivityAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EnvironmentAction"></see>
    /// </summary>
    let EnvironmentAction = _prefix "EnvironmentAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DecreaseHumidityAction"></see>
    /// </summary>
    let DecreaseHumidityAction = _prefix "DecreaseHumidityAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DecreaseNoiseAction"></see>
    /// </summary>
    let DecreaseNoiseAction = _prefix "DecreaseNoiseAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DecreaseSecurityAction"></see>
    /// </summary>
    let DecreaseSecurityAction = _prefix "DecreaseSecurityAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DecreaseTemperatureAction"></see>
    /// </summary>
    let DecreaseTemperatureAction = _prefix "DecreaseTemperatureAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DecreaseVolumeAction"></see>
    /// </summary>
    let DecreaseVolumeAction = _prefix "DecreaseVolumeAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DecreasedAirPressureTrigger"></see>
    /// </summary>
    let DecreasedAirPressureTrigger = _prefix "DecreasedAirPressureTrigger"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EnvironmentConditionDecreasedTrigger"></see>
    /// </summary>
    let EnvironmentConditionDecreasedTrigger =
        _prefix "EnvironmentConditionDecreasedTrigger"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DecreasedConnectivityTrigger"></see>
    /// </summary>
    let DecreasedConnectivityTrigger = _prefix "DecreasedConnectivityTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DecreasedHealthConditionTrigger"></see>
    /// </summary>
    let DecreasedHealthConditionTrigger = _prefix "DecreasedHealthConditionTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#HealthTrigger"></see>
    /// </summary>
    let HealthTrigger = _prefix "HealthTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DecreasedHumidityTrigger"></see>
    /// </summary>
    let DecreasedHumidityTrigger = _prefix "DecreasedHumidityTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DecreasedLightingTrigger"></see>
    /// </summary>
    let DecreasedLightingTrigger = _prefix "DecreasedLightingTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DecreasedNoiseLevelTrigger"></see>
    /// </summary>
    let DecreasedNoiseLevelTrigger = _prefix "DecreasedNoiseLevelTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DecreasedSecurityTrigger"></see>
    /// </summary>
    let DecreasedSecurityTrigger = _prefix "DecreasedSecurityTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DecreasedWeatherConditionsTrigger"></see>
    /// </summary>
    let DecreasedWeatherConditionsTrigger = _prefix "DecreasedWeatherConditionsTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Dehumidifier"></see>
    /// </summary>
    let Dehumidifier = _prefix "Dehumidifier"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DehumidifierService"></see>
    /// </summary>
    let DehumidifierService = _prefix "DehumidifierService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DehumidifierSystemDisabledTrigger"></see>
    /// </summary>
    let DehumidifierSystemDisabledTrigger = _prefix "DehumidifierSystemDisabledTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#IncreasedHumidityTrigger"></see>
    /// </summary>
    let IncreasedHumidityTrigger = _prefix "IncreasedHumidityTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DehumidifierSystemEnabledTrigger"></see>
    /// </summary>
    let DehumidifierSystemEnabledTrigger = _prefix "DehumidifierSystemEnabledTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeleteAction"></see>
    /// </summary>
    let DeleteAction = _prefix "DeleteAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#InformationAction"></see>
    /// </summary>
    let InformationAction = _prefix "InformationAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeleteAlarmAction"></see>
    /// </summary>
    let DeleteAlarmAction = _prefix "DeleteAlarmAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeleteRemindAction"></see>
    /// </summary>
    let DeleteRemindAction = _prefix "DeleteRemindAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeleteCalendarItemAction"></see>
    /// </summary>
    let DeleteCalendarItemAction = _prefix "DeleteCalendarItemAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeleteContactAction"></see>
    /// </summary>
    let DeleteContactAction = _prefix "DeleteContactAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeleteFromStorageAction"></see>
    /// </summary>
    let DeleteFromStorageAction = _prefix "DeleteFromStorageAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeleteFileAction"></see>
    /// </summary>
    let DeleteFileAction = _prefix "DeleteFileAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeleteHealthInformationAction"></see>
    /// </summary>
    let DeleteHealthInformationAction = _prefix "DeleteHealthInformationAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeleteMediaInformationAction"></see>
    /// </summary>
    let DeleteMediaInformationAction = _prefix "DeleteMediaInformationAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeleteReminderAction"></see>
    /// </summary>
    let DeleteReminderAction = _prefix "DeleteReminderAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeleteTimerAction"></see>
    /// </summary>
    let DeleteTimerAction = _prefix "DeleteTimerAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeleteWebBookmarkAction"></see>
    /// </summary>
    let DeleteWebBookmarkAction = _prefix "DeleteWebBookmarkAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeletedAlarmTrigger"></see>
    /// </summary>
    let DeletedAlarmTrigger = _prefix "DeletedAlarmTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeletedRemindTrigger"></see>
    /// </summary>
    let DeletedRemindTrigger = _prefix "DeletedRemindTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeletedAppTrigger"></see>
    /// </summary>
    let DeletedAppTrigger = _prefix "DeletedAppTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeletedFromStorageTrigger"></see>
    /// </summary>
    let DeletedFromStorageTrigger = _prefix "DeletedFromStorageTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeletedCalendarItemTrigger"></see>
    /// </summary>
    let DeletedCalendarItemTrigger = _prefix "DeletedCalendarItemTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeletedContactTrigger"></see>
    /// </summary>
    let DeletedContactTrigger = _prefix "DeletedContactTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeletedFileTrigger"></see>
    /// </summary>
    let DeletedFileTrigger = _prefix "DeletedFileTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeletedTrigger"></see>
    /// </summary>
    let DeletedTrigger = _prefix "DeletedTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeletedHealthInformationTrigger"></see>
    /// </summary>
    let DeletedHealthInformationTrigger = _prefix "DeletedHealthInformationTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeletedMediaInformationTrigger"></see>
    /// </summary>
    let DeletedMediaInformationTrigger = _prefix "DeletedMediaInformationTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeletedReminderTrigger"></see>
    /// </summary>
    let DeletedReminderTrigger = _prefix "DeletedReminderTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeletedTimerTrigger"></see>
    /// </summary>
    let DeletedTimerTrigger = _prefix "DeletedTimerTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#InformationTrigger"></see>
    /// </summary>
    let InformationTrigger = _prefix "InformationTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeletedWebBookmarkTrigger"></see>
    /// </summary>
    let DeletedWebBookmarkTrigger = _prefix "DeletedWebBookmarkTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Detail"></see>
    /// </summary>
    let Detail = _prefix "Detail"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeviceAction"></see>
    /// </summary>
    let DeviceAction = _prefix "DeviceAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EnhancedConnectivityTrigger"></see>
    /// </summary>
    let EnhancedConnectivityTrigger = _prefix "EnhancedConnectivityTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeviceConnectivityDisabledTrigger"></see>
    /// </summary>
    let DeviceConnectivityDisabledTrigger = _prefix "DeviceConnectivityDisabledTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeviceConnectivityEnabledTrigger"></see>
    /// </summary>
    let DeviceConnectivityEnabledTrigger = _prefix "DeviceConnectivityEnabledTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeviceDisconnectedTrigger"></see>
    /// </summary>
    let DeviceDisconnectedTrigger = _prefix "DeviceDisconnectedTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeviceFailureTrigger"></see>
    /// </summary>
    let DeviceFailureTrigger = _prefix "DeviceFailureTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#WorseFunctionalityTrigger"></see>
    /// </summary>
    let WorseFunctionalityTrigger = _prefix "WorseFunctionalityTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeviceLeakTrigger"></see>
    /// </summary>
    let DeviceLeakTrigger = _prefix "DeviceLeakTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DevicePluggedTrigger"></see>
    /// </summary>
    let DevicePluggedTrigger = _prefix "DevicePluggedTrigger"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ImprovedConsumptionConditionTrigger"></see>
    /// </summary>
    let ImprovedConsumptionConditionTrigger =
        _prefix "ImprovedConsumptionConditionTrigger"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeviceSavingModeDisabledTrigger"></see>
    /// </summary>
    let DeviceSavingModeDisabledTrigger = _prefix "DeviceSavingModeDisabledTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeviceSavingModeEnabledTrigger"></see>
    /// </summary>
    let DeviceSavingModeEnabledTrigger = _prefix "DeviceSavingModeEnabledTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#WorseConsumptionConditionTrigger"></see>
    /// </summary>
    let WorseConsumptionConditionTrigger = _prefix "WorseConsumptionConditionTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeviceTrigger"></see>
    /// </summary>
    let DeviceTrigger = _prefix "DeviceTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeviceTurnedOffTrigger"></see>
    /// </summary>
    let DeviceTurnedOffTrigger = _prefix "DeviceTurnedOffTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#UserConnectivityDecreasedTrigger"></see>
    /// </summary>
    let UserConnectivityDecreasedTrigger = _prefix "UserConnectivityDecreasedTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeviceTurnedOnTrigger"></see>
    /// </summary>
    let DeviceTurnedOnTrigger = _prefix "DeviceTurnedOnTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#UserConnectivityIncreasedTrigger"></see>
    /// </summary>
    let UserConnectivityIncreasedTrigger = _prefix "UserConnectivityIncreasedTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeviceUnpluggedTrigger"></see>
    /// </summary>
    let DeviceUnpluggedTrigger = _prefix "DeviceUnpluggedTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DeviceUsageWarningTrigger"></see>
    /// </summary>
    let DeviceUsageWarningTrigger = _prefix "DeviceUsageWarningTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DisableAirPurifierSystemAction"></see>
    /// </summary>
    let DisableAirPurifierSystemAction = _prefix "DisableAirPurifierSystemAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DisableAirplaneModeAction"></see>
    /// </summary>
    let DisableAirplaneModeAction = _prefix "DisableAirplaneModeAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EnableDeviceConnectivityAction"></see>
    /// </summary>
    let EnableDeviceConnectivityAction = _prefix "EnableDeviceConnectivityAction"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DisableBluetoothConnectivityAction"></see>
    /// </summary>
    let DisableBluetoothConnectivityAction =
        _prefix "DisableBluetoothConnectivityAction"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DisableDeviceConnectivityAction"></see>
    /// </summary>
    let DisableDeviceConnectivityAction = _prefix "DisableDeviceConnectivityAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DisableCoolingSystemAction"></see>
    /// </summary>
    let DisableCoolingSystemAction = _prefix "DisableCoolingSystemAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DisableDehumidifierSystemAction"></see>
    /// </summary>
    let DisableDehumidifierSystemAction = _prefix "DisableDehumidifierSystemAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#IncreaseHumidityAction"></see>
    /// </summary>
    let IncreaseHumidityAction = _prefix "IncreaseHumidityAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DisableDeviceSavingModeAction"></see>
    /// </summary>
    let DisableDeviceSavingModeAction = _prefix "DisableDeviceSavingModeAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#WorseConsumptionConditionAction"></see>
    /// </summary>
    let WorseConsumptionConditionAction = _prefix "WorseConsumptionConditionAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DisableGPSAction"></see>
    /// </summary>
    let DisableGPSAction = _prefix "DisableGPSAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DisableHeatingSystemAction"></see>
    /// </summary>
    let DisableHeatingSystemAction = _prefix "DisableHeatingSystemAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DisableHumidifierSystemAction"></see>
    /// </summary>
    let DisableHumidifierSystemAction = _prefix "DisableHumidifierSystemAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DisableInternetConnectivityAction"></see>
    /// </summary>
    let DisableInternetConnectivityAction = _prefix "DisableInternetConnectivityAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DisableLightingSystemAction"></see>
    /// </summary>
    let DisableLightingSystemAction = _prefix "DisableLightingSystemAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DisableNFCConnectivityAction"></see>
    /// </summary>
    let DisableNFCConnectivityAction = _prefix "DisableNFCConnectivityAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DisableNightModeAction"></see>
    /// </summary>
    let DisableNightModeAction = _prefix "DisableNightModeAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ImproveLightingConditionAction"></see>
    /// </summary>
    let ImproveLightingConditionAction = _prefix "ImproveLightingConditionAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DisableNotificationsAction"></see>
    /// </summary>
    let DisableNotificationsAction = _prefix "DisableNotificationsAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DisableScreenRotationAction"></see>
    /// </summary>
    let DisableScreenRotationAction = _prefix "DisableScreenRotationAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#WorseUsabilityConditionAction"></see>
    /// </summary>
    let WorseUsabilityConditionAction = _prefix "WorseUsabilityConditionAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DisableSecuritySystemAction"></see>
    /// </summary>
    let DisableSecuritySystemAction = _prefix "DisableSecuritySystemAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DisableWateringSystemAction"></see>
    /// </summary>
    let DisableWateringSystemAction = _prefix "DisableWateringSystemAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DisabledAirplaneModeTrigger"></see>
    /// </summary>
    let DisabledAirplaneModeTrigger = _prefix "DisabledAirplaneModeTrigger"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DisabledBluetoothConnectivityTrigger"></see>
    /// </summary>
    let DisabledBluetoothConnectivityTrigger =
        _prefix "DisabledBluetoothConnectivityTrigger"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DisabledGPSTrigger"></see>
    /// </summary>
    let DisabledGPSTrigger = _prefix "DisabledGPSTrigger"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DisabledInternetConnectivityTrigger"></see>
    /// </summary>
    let DisabledInternetConnectivityTrigger =
        _prefix "DisabledInternetConnectivityTrigger"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DisabledNFCConnectivityTrigger"></see>
    /// </summary>
    let DisabledNFCConnectivityTrigger = _prefix "DisabledNFCConnectivityTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DisconnectDeviceAction"></see>
    /// </summary>
    let DisconnectDeviceAction = _prefix "DisconnectDeviceAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DisconnectFromDeviceAction"></see>
    /// </summary>
    let DisconnectFromDeviceAction = _prefix "DisconnectFromDeviceAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DisconnectFromNetworkAction"></see>
    /// </summary>
    let DisconnectFromNetworkAction = _prefix "DisconnectFromNetworkAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DisconnectedFromDeviceTrigger"></see>
    /// </summary>
    let DisconnectedFromDeviceTrigger = _prefix "DisconnectedFromDeviceTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DisconnectedFromNetworkTrigger"></see>
    /// </summary>
    let DisconnectedFromNetworkTrigger = _prefix "DisconnectedFromNetworkTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Dishwasher"></see>
    /// </summary>
    let Dishwasher = _prefix "Dishwasher"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DisplaySerivce"></see>
    /// </summary>
    let DisplaySerivce = _prefix "DisplaySerivce"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DisplyService"></see>
    /// </summary>
    let DisplyService = _prefix "DisplyService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DiswashingService"></see>
    /// </summary>
    let DiswashingService = _prefix "DiswashingService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Dryer"></see>
    /// </summary>
    let Dryer = _prefix "Dryer"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DryingService"></see>
    /// </summary>
    let DryingService = _prefix "DryingService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#DvdPlayer"></see>
    /// </summary>
    let DvdPlayer = _prefix "DvdPlayer"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EUDPlatform"></see>
    /// </summary>
    let EUDPlatform = _prefix "EUDPlatform"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EcommerceService"></see>
    /// </summary>
    let EcommerceService = _prefix "EcommerceService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EcommerceWebSite"></see>
    /// </summary>
    let EcommerceWebSite = _prefix "EcommerceWebSite"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ShoppingTool"></see>
    /// </summary>
    let ShoppingTool = _prefix "ShoppingTool"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EmailTool"></see>
    /// </summary>
    let EmailTool = _prefix "EmailTool"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EnableAirPurifierSystemAction"></see>
    /// </summary>
    let EnableAirPurifierSystemAction = _prefix "EnableAirPurifierSystemAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#IncreaseAirQualityAction"></see>
    /// </summary>
    let IncreaseAirQualityAction = _prefix "IncreaseAirQualityAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EnableAirplaneModeAction"></see>
    /// </summary>
    let EnableAirplaneModeAction = _prefix "EnableAirplaneModeAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EnableBluetoothConnectivityAction"></see>
    /// </summary>
    let EnableBluetoothConnectivityAction = _prefix "EnableBluetoothConnectivityAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EnableCoolingSystemAction"></see>
    /// </summary>
    let EnableCoolingSystemAction = _prefix "EnableCoolingSystemAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EnableDehumidifierSystemAction"></see>
    /// </summary>
    let EnableDehumidifierSystemAction = _prefix "EnableDehumidifierSystemAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EnableDeviceSavingModeAction"></see>
    /// </summary>
    let EnableDeviceSavingModeAction = _prefix "EnableDeviceSavingModeAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ImproveConsumptionConditionAction"></see>
    /// </summary>
    let ImproveConsumptionConditionAction = _prefix "ImproveConsumptionConditionAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EnableGPSAction"></see>
    /// </summary>
    let EnableGPSAction = _prefix "EnableGPSAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EnableHeatingSystemAction"></see>
    /// </summary>
    let EnableHeatingSystemAction = _prefix "EnableHeatingSystemAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EnableHumidifierSystemAction"></see>
    /// </summary>
    let EnableHumidifierSystemAction = _prefix "EnableHumidifierSystemAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EnableInternetConnectivityAction"></see>
    /// </summary>
    let EnableInternetConnectivityAction = _prefix "EnableInternetConnectivityAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EnableLightingSystemAction"></see>
    /// </summary>
    let EnableLightingSystemAction = _prefix "EnableLightingSystemAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#IncreaseLightingAction"></see>
    /// </summary>
    let IncreaseLightingAction = _prefix "IncreaseLightingAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EnableNFCConnctivityAction"></see>
    /// </summary>
    let EnableNFCConnctivityAction = _prefix "EnableNFCConnctivityAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EnableNightModeAction"></see>
    /// </summary>
    let EnableNightModeAction = _prefix "EnableNightModeAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EnableNotificationsAction"></see>
    /// </summary>
    let EnableNotificationsAction = _prefix "EnableNotificationsAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#IncreaseUserConnectivityAction"></see>
    /// </summary>
    let IncreaseUserConnectivityAction = _prefix "IncreaseUserConnectivityAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EnableScreenRotationAction"></see>
    /// </summary>
    let EnableScreenRotationAction = _prefix "EnableScreenRotationAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ImproveUsabilityConditionAction"></see>
    /// </summary>
    let ImproveUsabilityConditionAction = _prefix "ImproveUsabilityConditionAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EnableSecuritySystemAction"></see>
    /// </summary>
    let EnableSecuritySystemAction = _prefix "EnableSecuritySystemAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EnableSpeakerphoneAction"></see>
    /// </summary>
    let EnableSpeakerphoneAction = _prefix "EnableSpeakerphoneAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EnableWateringSystemAction"></see>
    /// </summary>
    let EnableWateringSystemAction = _prefix "EnableWateringSystemAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EnabledAirplaneModeTrigger"></see>
    /// </summary>
    let EnabledAirplaneModeTrigger = _prefix "EnabledAirplaneModeTrigger"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EnabledBluetoothConnectivityTrigger"></see>
    /// </summary>
    let EnabledBluetoothConnectivityTrigger =
        _prefix "EnabledBluetoothConnectivityTrigger"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EnabledGPSTrigger"></see>
    /// </summary>
    let EnabledGPSTrigger = _prefix "EnabledGPSTrigger"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EnabledInternetConnectivityTrigger"></see>
    /// </summary>
    let EnabledInternetConnectivityTrigger =
        _prefix "EnabledInternetConnectivityTrigger"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EnabledNFCConnectivityTrigger"></see>
    /// </summary>
    let EnabledNFCConnectivityTrigger = _prefix "EnabledNFCConnectivityTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EndCallAction"></see>
    /// </summary>
    let EndCallAction = _prefix "EndCallAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#MovingTrigger"></see>
    /// </summary>
    let MovingTrigger = _prefix "MovingTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EnvironmentTrigger"></see>
    /// </summary>
    let EnvironmentTrigger = _prefix "EnvironmentTrigger"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EnvironmentConditionIncreasedTrigger"></see>
    /// </summary>
    let EnvironmentConditionIncreasedTrigger =
        _prefix "EnvironmentConditionIncreasedTrigger"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EveryDayTrigger"></see>
    /// </summary>
    let EveryDayTrigger = _prefix "EveryDayTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EveryTimeTrigger"></see>
    /// </summary>
    let EveryTimeTrigger = _prefix "EveryTimeTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EveryHourTrigger"></see>
    /// </summary>
    let EveryHourTrigger = _prefix "EveryHourTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EveryMonthTrigger"></see>
    /// </summary>
    let EveryMonthTrigger = _prefix "EveryMonthTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#TimeTrigger"></see>
    /// </summary>
    let TimeTrigger = _prefix "TimeTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EveryWeekTrigger"></see>
    /// </summary>
    let EveryWeekTrigger = _prefix "EveryWeekTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#EveryYearTrigger"></see>
    /// </summary>
    let EveryYearTrigger = _prefix "EveryYearTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ExitTrigger"></see>
    /// </summary>
    let ExitTrigger = _prefix "ExitTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#FailureDetectionService"></see>
    /// </summary>
    let FailureDetectionService = _prefix "FailureDetectionService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Family"></see>
    /// </summary>
    let Family = _prefix "Family"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Fax"></see>
    /// </summary>
    let Fax = _prefix "Fax"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#FileService"></see>
    /// </summary>
    let FileService = _prefix "FileService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#FocusTrackingService"></see>
    /// </summary>
    let FocusTrackingService = _prefix "FocusTrackingService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#FrameService"></see>
    /// </summary>
    let FrameService = _prefix "FrameService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Fridge"></see>
    /// </summary>
    let Fridge = _prefix "Fridge"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Friend"></see>
    /// </summary>
    let Friend = _prefix "Friend"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#GPSEnterAreaTrigger"></see>
    /// </summary>
    let GPSEnterAreaTrigger = _prefix "GPSEnterAreaTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#GPSExitAreaTrigger"></see>
    /// </summary>
    let GPSExitAreaTrigger = _prefix "GPSExitAreaTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#GPSService"></see>
    /// </summary>
    let GPSService = _prefix "GPSService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#PostioningService"></see>
    /// </summary>
    let PostioningService = _prefix "PostioningService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#GameService"></see>
    /// </summary>
    let GameService = _prefix "GameService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#MediaService"></see>
    /// </summary>
    let MediaService = _prefix "MediaService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#GeographicalArea"></see>
    /// </summary>
    let GeographicalArea = _prefix "GeographicalArea"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#GroceryShoppingService"></see>
    /// </summary>
    let GroceryShoppingService = _prefix "GroceryShoppingService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#HealthInformationService"></see>
    /// </summary>
    let HealthInformationService = _prefix "HealthInformationService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#HealthyActivityTrigger"></see>
    /// </summary>
    let HealthyActivityTrigger = _prefix "HealthyActivityTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#IncreasedHealthConditionTrigger"></see>
    /// </summary>
    let IncreasedHealthConditionTrigger = _prefix "IncreasedHealthConditionTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#HealthyGoalNotReachedTrigger"></see>
    /// </summary>
    let HealthyGoalNotReachedTrigger = _prefix "HealthyGoalNotReachedTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#HealthyGoalReachedTrigger"></see>
    /// </summary>
    let HealthyGoalReachedTrigger = _prefix "HealthyGoalReachedTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Heater"></see>
    /// </summary>
    let Heater = _prefix "Heater"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#HeatingService"></see>
    /// </summary>
    let HeatingService = _prefix "HeatingService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#HeatingSystemDisabledTrigger"></see>
    /// </summary>
    let HeatingSystemDisabledTrigger = _prefix "HeatingSystemDisabledTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#HeatingSystemEnabledTrigger"></see>
    /// </summary>
    let HeatingSystemEnabledTrigger = _prefix "HeatingSystemEnabledTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#HiFi"></see>
    /// </summary>
    let HiFi = _prefix "HiFi"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#HighSensedDeviceConsumptionTrigger"></see>
    /// </summary>
    let HighSensedDeviceConsumptionTrigger =
        _prefix "HighSensedDeviceConsumptionTrigger"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Hub"></see>
    /// </summary>
    let Hub = _prefix "Hub"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Humidifier"></see>
    /// </summary>
    let Humidifier = _prefix "Humidifier"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#HumidifierService"></see>
    /// </summary>
    let HumidifierService = _prefix "HumidifierService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#HumiditySetToTrigger"></see>
    /// </summary>
    let HumiditySetToTrigger = _prefix "HumiditySetToTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ImproveDeviceConditionAction"></see>
    /// </summary>
    let ImproveDeviceConditionAction = _prefix "ImproveDeviceConditionAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ImprovedDeviceConditionTrigger"></see>
    /// </summary>
    let ImprovedDeviceConditionTrigger = _prefix "ImprovedDeviceConditionTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ImprovedHealthyParameterTrigger"></see>
    /// </summary>
    let ImprovedHealthyParameterTrigger = _prefix "ImprovedHealthyParameterTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ImprovedUsabilityConditionTrigger"></see>
    /// </summary>
    let ImprovedUsabilityConditionTrigger = _prefix "ImprovedUsabilityConditionTrigger"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#IncreaseEnvironmentConditionAction"></see>
    /// </summary>
    let IncreaseEnvironmentConditionAction =
        _prefix "IncreaseEnvironmentConditionAction"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#IncreaseVolumeAction"></see>
    /// </summary>
    let IncreaseVolumeAction = _prefix "IncreaseVolumeAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#IncreasedAirPressureTrigger"></see>
    /// </summary>
    let IncreasedAirPressureTrigger = _prefix "IncreasedAirPressureTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#IncreasedLightingTrigger"></see>
    /// </summary>
    let IncreasedLightingTrigger = _prefix "IncreasedLightingTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#IncreasedNoiseLevelTrigger"></see>
    /// </summary>
    let IncreasedNoiseLevelTrigger = _prefix "IncreasedNoiseLevelTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#IncreasedSecurityTrigger"></see>
    /// </summary>
    let IncreasedSecurityTrigger = _prefix "IncreasedSecurityTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#IncreasedWeatherConditionTrigger"></see>
    /// </summary>
    let IncreasedWeatherConditionTrigger = _prefix "IncreasedWeatherConditionTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#InformationWebSite"></see>
    /// </summary>
    let InformationWebSite = _prefix "InformationWebSite"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#InstantiatedAction"></see>
    /// </summary>
    let InstantiatedAction = _prefix "InstantiatedAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#nominalAction"></see>
    /// </summary>
    let nominalAction = _prefix "nominalAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#RuleInstantiatedAxiom"></see>
    /// </summary>
    let RuleInstantiatedAxiom = _prefix "RuleInstantiatedAxiom"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#InstantiatedDetail"></see>
    /// </summary>
    let InstantiatedDetail = _prefix "InstantiatedDetail"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#InstantiatedTrigger"></see>
    /// </summary>
    let InstantiatedTrigger = _prefix "InstantiatedTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#nominalTrigger"></see>
    /// </summary>
    let nominalTrigger = _prefix "nominalTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#InteractionService"></see>
    /// </summary>
    let InteractionService = _prefix "InteractionService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#IoTEntity"></see>
    /// </summary>
    let IoTEntity = _prefix "IoTEntity"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#hasService"></see>
    /// </summary>
    let hasService = _prefix "hasService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Lamp"></see>
    /// </summary>
    let Lamp = _prefix "Lamp"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Laptop"></see>
    /// </summary>
    let Laptop = _prefix "Laptop"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#UserDevice"></see>
    /// </summary>
    let UserDevice = _prefix "UserDevice"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#LeakDetectionService"></see>
    /// </summary>
    let LeakDetectionService = _prefix "LeakDetectionService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#LightingService"></see>
    /// </summary>
    let LightingService = _prefix "LightingService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#LightingSystemDisabledTrigger"></see>
    /// </summary>
    let LightingSystemDisabledTrigger = _prefix "LightingSystemDisabledTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#LightingSystemEnabledTrigger"></see>
    /// </summary>
    let LightingSystemEnabledTrigger = _prefix "LightingSystemEnabledTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#LikeService"></see>
    /// </summary>
    let LikeService = _prefix "LikeService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#LowPowerTrigger"></see>
    /// </summary>
    let LowPowerTrigger = _prefix "LowPowerTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#MediaInformationService"></see>
    /// </summary>
    let MediaInformationService = _prefix "MediaInformationService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#MediaTool"></see>
    /// </summary>
    let MediaTool = _prefix "MediaTool"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#MessageService"></see>
    /// </summary>
    let MessageService = _prefix "MessageService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#MobileDevice"></see>
    /// </summary>
    let MobileDevice = _prefix "MobileDevice"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#MoveAppAction"></see>
    /// </summary>
    let MoveAppAction = _prefix "MoveAppAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StoreAction"></see>
    /// </summary>
    let StoreAction = _prefix "StoreAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#MoveOnVehicleTrigger"></see>
    /// </summary>
    let MoveOnVehicleTrigger = _prefix "MoveOnVehicleTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#PlacesTrigger"></see>
    /// </summary>
    let PlacesTrigger = _prefix "PlacesTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#MusicPlatform"></see>
    /// </summary>
    let MusicPlatform = _prefix "MusicPlatform"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#MusicService"></see>
    /// </summary>
    let MusicService = _prefix "MusicService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#MuteCallAction"></see>
    /// </summary>
    let MuteCallAction = _prefix "MuteCallAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#NFCService"></see>
    /// </summary>
    let NFCService = _prefix "NFCService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#NewsService"></see>
    /// </summary>
    let NewsService = _prefix "NewsService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#NewsWebSite"></see>
    /// </summary>
    let NewsWebSite = _prefix "NewsWebSite"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#NightModeDisabledTrigger"></see>
    /// </summary>
    let NightModeDisabledTrigger = _prefix "NightModeDisabledTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#NightModeEnabledTrigger"></see>
    /// </summary>
    let NightModeEnabledTrigger = _prefix "NightModeEnabledTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#NoiseService"></see>
    /// </summary>
    let NoiseService = _prefix "NoiseService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#NoteTool"></see>
    /// </summary>
    let NoteTool = _prefix "NoteTool"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#NotificationProfileSetToTrigger"></see>
    /// </summary>
    let NotificationProfileSetToTrigger = _prefix "NotificationProfileSetToTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#NotificationService"></see>
    /// </summary>
    let NotificationService = _prefix "NotificationService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#NotificationTool"></see>
    /// </summary>
    let NotificationTool = _prefix "NotificationTool"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#NotificationsDisabledTrigger"></see>
    /// </summary>
    let NotificationsDisabledTrigger = _prefix "NotificationsDisabledTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#NotificationsEnabledTrigger"></see>
    /// </summary>
    let NotificationsEnabledTrigger = _prefix "NotificationsEnabledTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#OpenWindowFrameAction"></see>
    /// </summary>
    let OpenWindowFrameAction = _prefix "OpenWindowFrameAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Oven"></see>
    /// </summary>
    let Oven = _prefix "Oven"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#OvenService"></see>
    /// </summary>
    let OvenService = _prefix "OvenService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#PC"></see>
    /// </summary>
    let PC = _prefix "PC"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Phone"></see>
    /// </summary>
    let Phone = _prefix "Phone"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#PhoneCallMutedTrigger"></see>
    /// </summary>
    let PhoneCallMutedTrigger = _prefix "PhoneCallMutedTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#PhoneCallRejectedTrigger"></see>
    /// </summary>
    let PhoneCallRejectedTrigger = _prefix "PhoneCallRejectedTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#PhotoPlatform"></see>
    /// </summary>
    let PhotoPlatform = _prefix "PhotoPlatform"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#PhotoRecordingService"></see>
    /// </summary>
    let PhotoRecordingService = _prefix "PhotoRecordingService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#PositionRegistrationService"></see>
    /// </summary>
    let PositionRegistrationService = _prefix "PositionRegistrationService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#PositionRegistrationTrigger"></see>
    /// </summary>
    let PositionRegistrationTrigger = _prefix "PositionRegistrationTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#PostService"></see>
    /// </summary>
    let PostService = _prefix "PostService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#PowerService"></see>
    /// </summary>
    let PowerService = _prefix "PowerService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#PrintService"></see>
    /// </summary>
    let PrintService = _prefix "PrintService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Printer"></see>
    /// </summary>
    let Printer = _prefix "Printer"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ProfileUpdateService"></see>
    /// </summary>
    let ProfileUpdateService = _prefix "ProfileUpdateService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#QuestionService"></see>
    /// </summary>
    let QuestionService = _prefix "QuestionService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Radio"></see>
    /// </summary>
    let Radio = _prefix "Radio"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#RainfallMeasurementAvailableTrigger"></see>
    /// </summary>
    let RainfallMeasurementAvailableTrigger =
        _prefix "RainfallMeasurementAvailableTrigger"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ReceivedAnswerTrigger"></see>
    /// </summary>
    let ReceivedAnswerTrigger = _prefix "ReceivedAnswerTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ReceivedPrivateInformationTrigger"></see>
    /// </summary>
    let ReceivedPrivateInformationTrigger = _prefix "ReceivedPrivateInformationTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ReceivedAppNotificationTrigger"></see>
    /// </summary>
    let ReceivedAppNotificationTrigger = _prefix "ReceivedAppNotificationTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ReceivedNotificationTrigger"></see>
    /// </summary>
    let ReceivedNotificationTrigger = _prefix "ReceivedNotificationTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ReceivedAttachmentTrigger"></see>
    /// </summary>
    let ReceivedAttachmentTrigger = _prefix "ReceivedAttachmentTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ReceivedBreakingNewsTrigger"></see>
    /// </summary>
    let ReceivedBreakingNewsTrigger = _prefix "ReceivedBreakingNewsTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ReceivedNewsTrigger"></see>
    /// </summary>
    let ReceivedNewsTrigger = _prefix "ReceivedNewsTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ReceivedCommentTrigger"></see>
    /// </summary>
    let ReceivedCommentTrigger = _prefix "ReceivedCommentTrigger"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ReceivedContactNotificationTrigger"></see>
    /// </summary>
    let ReceivedContactNotificationTrigger =
        _prefix "ReceivedContactNotificationTrigger"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ReceivedDocumentInfoNotificationTrigger"></see>
    /// </summary>
    let ReceivedDocumentInfoNotificationTrigger =
        _prefix "ReceivedDocumentInfoNotificationTrigger"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ReceivedFromDeviceTrigger"></see>
    /// </summary>
    let ReceivedFromDeviceTrigger = _prefix "ReceivedFromDeviceTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ReceivedTrigger"></see>
    /// </summary>
    let ReceivedTrigger = _prefix "ReceivedTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ReceivedFromDiyTrigger"></see>
    /// </summary>
    let ReceivedFromDiyTrigger = _prefix "ReceivedFromDiyTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ReceivedIncomingCallTrigger"></see>
    /// </summary>
    let ReceivedIncomingCallTrigger = _prefix "ReceivedIncomingCallTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ReceivedLikeTrigger"></see>
    /// </summary>
    let ReceivedLikeTrigger = _prefix "ReceivedLikeTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ReceivedMessageTrigger"></see>
    /// </summary>
    let ReceivedMessageTrigger = _prefix "ReceivedMessageTrigger"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ReceivedMissedCallNotificationTrigger"></see>
    /// </summary>
    let ReceivedMissedCallNotificationTrigger =
        _prefix "ReceivedMissedCallNotificationTrigger"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ReceivedPaymentNotificationTrigger"></see>
    /// </summary>
    let ReceivedPaymentNotificationTrigger =
        _prefix "ReceivedPaymentNotificationTrigger"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ReceivedPostTrigger"></see>
    /// </summary>
    let ReceivedPostTrigger = _prefix "ReceivedPostTrigger"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ReceivedRecommendationNotificationTrigger"></see>
    /// </summary>
    let ReceivedRecommendationNotificationTrigger =
        _prefix "ReceivedRecommendationNotificationTrigger"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ReceivedRemindNotificationTrigger"></see>
    /// </summary>
    let ReceivedRemindNotificationTrigger = _prefix "ReceivedRemindNotificationTrigger"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ReceivedShippingNotificationTrigger"></see>
    /// </summary>
    let ReceivedShippingNotificationTrigger =
        _prefix "ReceivedShippingNotificationTrigger"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ReceivedTagTrigger"></see>
    /// </summary>
    let ReceivedTagTrigger = _prefix "ReceivedTagTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ReceivedUnlikeTrigger"></see>
    /// </summary>
    let ReceivedUnlikeTrigger = _prefix "ReceivedUnlikeTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#RejectCallAction"></see>
    /// </summary>
    let RejectCallAction = _prefix "RejectCallAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ReminderService"></see>
    /// </summary>
    let ReminderService = _prefix "ReminderService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Room"></see>
    /// </summary>
    let Room = _prefix "Room"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Rule"></see>
    /// </summary>
    let Rule = _prefix "Rule"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#hasTrigger"></see>
    /// </summary>
    let hasTrigger = _prefix "hasTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#hasAction"></see>
    /// </summary>
    let hasAction = _prefix "hasAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#RuleAxiom"></see>
    /// </summary>
    let RuleAxiom = _prefix "RuleAxiom"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#RunTrackingService"></see>
    /// </summary>
    let RunTrackingService = _prefix "RunTrackingService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SMSTool"></see>
    /// </summary>
    let SMSTool = _prefix "SMSTool"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SaveContactAction"></see>
    /// </summary>
    let SaveContactAction = _prefix "SaveContactAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SaveFileAction"></see>
    /// </summary>
    let SaveFileAction = _prefix "SaveFileAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SaveHealthInformationAction"></see>
    /// </summary>
    let SaveHealthInformationAction = _prefix "SaveHealthInformationAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SaveMediaInformationAction"></see>
    /// </summary>
    let SaveMediaInformationAction = _prefix "SaveMediaInformationAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SaveWebBookmarkAction"></see>
    /// </summary>
    let SaveWebBookmarkAction = _prefix "SaveWebBookmarkAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ScanBluetoothTrigger"></see>
    /// </summary>
    let ScanBluetoothTrigger = _prefix "ScanBluetoothTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ScanWifiTrigger"></see>
    /// </summary>
    let ScanWifiTrigger = _prefix "ScanWifiTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ScreenRotationDisabledTrigger"></see>
    /// </summary>
    let ScreenRotationDisabledTrigger = _prefix "ScreenRotationDisabledTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#WorseUsabilityConditionTrigger"></see>
    /// </summary>
    let WorseUsabilityConditionTrigger = _prefix "WorseUsabilityConditionTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ScreenRotationEnabledTrigger"></see>
    /// </summary>
    let ScreenRotationEnabledTrigger = _prefix "ScreenRotationEnabledTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SecurityService"></see>
    /// </summary>
    let SecurityService = _prefix "SecurityService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SecurityShutdownAction"></see>
    /// </summary>
    let SecurityShutdownAction = _prefix "SecurityShutdownAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SecuritySystemDisabledTrigger"></see>
    /// </summary>
    let SecuritySystemDisabledTrigger = _prefix "SecuritySystemDisabledTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SecuritySystemEnabledTrigger"></see>
    /// </summary>
    let SecuritySystemEnabledTrigger = _prefix "SecuritySystemEnabledTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SendAction"></see>
    /// </summary>
    let SendAction = _prefix "SendAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SendAttachmentAction"></see>
    /// </summary>
    let SendAttachmentAction = _prefix "SendAttachmentAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SendToPersonAction"></see>
    /// </summary>
    let SendToPersonAction = _prefix "SendToPersonAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SendCallAction"></see>
    /// </summary>
    let SendCallAction = _prefix "SendCallAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SendMessageAction"></see>
    /// </summary>
    let SendMessageAction = _prefix "SendMessageAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SendQuestionAction"></see>
    /// </summary>
    let SendQuestionAction = _prefix "SendQuestionAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SendRequestAction"></see>
    /// </summary>
    let SendRequestAction = _prefix "SendRequestAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SendToDeviceAction"></see>
    /// </summary>
    let SendToDeviceAction = _prefix "SendToDeviceAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SendToDisplayAction"></see>
    /// </summary>
    let SendToDisplayAction = _prefix "SendToDisplayAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SendToDiyAction"></see>
    /// </summary>
    let SendToDiyAction = _prefix "SendToDiyAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SendToPrintAction"></see>
    /// </summary>
    let SendToPrintAction = _prefix "SendToPrintAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SendToSpeakerAction"></see>
    /// </summary>
    let SendToSpeakerAction = _prefix "SendToSpeakerAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SendWebRequestAction"></see>
    /// </summary>
    let SendWebRequestAction = _prefix "SendWebRequestAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SensedAirPressureDecreasedTrigger"></see>
    /// </summary>
    let SensedAirPressureDecreasedTrigger = _prefix "SensedAirPressureDecreasedTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SensedAirPressureIncreasedTrigger"></see>
    /// </summary>
    let SensedAirPressureIncreasedTrigger = _prefix "SensedAirPressureIncreasedTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SensedAirQualityDecreasedTrigger"></see>
    /// </summary>
    let SensedAirQualityDecreasedTrigger = _prefix "SensedAirQualityDecreasedTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SensedAirQualityIncreasedTrigger"></see>
    /// </summary>
    let SensedAirQualityIncreasedTrigger = _prefix "SensedAirQualityIncreasedTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SensedHealthyParameterTrigger"></see>
    /// </summary>
    let SensedHealthyParameterTrigger = _prefix "SensedHealthyParameterTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#WorsenedHealthyParameterTrigger"></see>
    /// </summary>
    let WorsenedHealthyParameterTrigger = _prefix "WorsenedHealthyParameterTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SensedHumididtyDecreasedTrigger"></see>
    /// </summary>
    let SensedHumididtyDecreasedTrigger = _prefix "SensedHumididtyDecreasedTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SensedHumidityIncreasedTrigger"></see>
    /// </summary>
    let SensedHumidityIncreasedTrigger = _prefix "SensedHumidityIncreasedTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SensedLightingDecreasedTrigger"></see>
    /// </summary>
    let SensedLightingDecreasedTrigger = _prefix "SensedLightingDecreasedTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SensedLightingIncreasedTrigger"></see>
    /// </summary>
    let SensedLightingIncreasedTrigger = _prefix "SensedLightingIncreasedTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SensedNoiseLevelDecreasedTrigger"></see>
    /// </summary>
    let SensedNoiseLevelDecreasedTrigger = _prefix "SensedNoiseLevelDecreasedTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SensedNoiseLevelIncreasedTrigger"></see>
    /// </summary>
    let SensedNoiseLevelIncreasedTrigger = _prefix "SensedNoiseLevelIncreasedTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SensedRainDetectedTrigger"></see>
    /// </summary>
    let SensedRainDetectedTrigger = _prefix "SensedRainDetectedTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SensedRainNoLongerDetectedTrigger"></see>
    /// </summary>
    let SensedRainNoLongerDetectedTrigger = _prefix "SensedRainNoLongerDetectedTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SensedTemperatureDecreasedTrigger"></see>
    /// </summary>
    let SensedTemperatureDecreasedTrigger = _prefix "SensedTemperatureDecreasedTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SensedTemperatureIncreasedTrigger"></see>
    /// </summary>
    let SensedTemperatureIncreasedTrigger = _prefix "SensedTemperatureIncreasedTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SensedWindDecreasedTrigger"></see>
    /// </summary>
    let SensedWindDecreasedTrigger = _prefix "SensedWindDecreasedTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SensedWindIncreasedTrigger"></see>
    /// </summary>
    let SensedWindIncreasedTrigger = _prefix "SensedWindIncreasedTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SensorPresenceDetectedTrigger"></see>
    /// </summary>
    let SensorPresenceDetectedTrigger = _prefix "SensorPresenceDetectedTrigger"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SensorPresenceNoLongerDetectedTrigger"></see>
    /// </summary>
    let SensorPresenceNoLongerDetectedTrigger =
        _prefix "SensorPresenceNoLongerDetectedTrigger"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SentMessageTrigger"></see>
    /// </summary>
    let SentMessageTrigger = _prefix "SentMessageTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SentPrivateInformationTrigger"></see>
    /// </summary>
    let SentPrivateInformationTrigger = _prefix "SentPrivateInformationTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SentOutcomingCallTrigger"></see>
    /// </summary>
    let SentOutcomingCallTrigger = _prefix "SentOutcomingCallTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SentTrigger"></see>
    /// </summary>
    let SentTrigger = _prefix "SentTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SentPullTrigger"></see>
    /// </summary>
    let SentPullTrigger = _prefix "SentPullTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SentRequestTrigger"></see>
    /// </summary>
    let SentRequestTrigger = _prefix "SentRequestTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SentQuestionTrigger"></see>
    /// </summary>
    let SentQuestionTrigger = _prefix "SentQuestionTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SentSharedInformationTrigger"></see>
    /// </summary>
    let SentSharedInformationTrigger = _prefix "SentSharedInformationTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SentSubscriptionTrigger"></see>
    /// </summary>
    let SentSubscriptionTrigger = _prefix "SentSubscriptionTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#hasNotification"></see>
    /// </summary>
    let hasNotification = _prefix "hasNotification"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#hasCommand"></see>
    /// </summary>
    let hasCommand = _prefix "hasCommand"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SetBrightnessAction"></see>
    /// </summary>
    let SetBrightnessAction = _prefix "SetBrightnessAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SetHumidityAction"></see>
    /// </summary>
    let SetHumidityAction = _prefix "SetHumidityAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SetLightingAction"></see>
    /// </summary>
    let SetLightingAction = _prefix "SetLightingAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SetTemperatureAction"></see>
    /// </summary>
    let SetTemperatureAction = _prefix "SetTemperatureAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ShareAction"></see>
    /// </summary>
    let ShareAction = _prefix "ShareAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ShareCommentAction"></see>
    /// </summary>
    let ShareCommentAction = _prefix "ShareCommentAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ShareFileAction"></see>
    /// </summary>
    let ShareFileAction = _prefix "ShareFileAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ShareLikeAction"></see>
    /// </summary>
    let ShareLikeAction = _prefix "ShareLikeAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SharePostAction"></see>
    /// </summary>
    let SharePostAction = _prefix "SharePostAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ShareProfileUpdateAction"></see>
    /// </summary>
    let ShareProfileUpdateAction = _prefix "ShareProfileUpdateAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ShareTagAction"></see>
    /// </summary>
    let ShareTagAction = _prefix "ShareTagAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ShareUnlikeAction"></see>
    /// </summary>
    let ShareUnlikeAction = _prefix "ShareUnlikeAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SharedCommentTrigger"></see>
    /// </summary>
    let SharedCommentTrigger = _prefix "SharedCommentTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SharedLikeTrigger"></see>
    /// </summary>
    let SharedLikeTrigger = _prefix "SharedLikeTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SharedPostTrigger"></see>
    /// </summary>
    let SharedPostTrigger = _prefix "SharedPostTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SharedProfileUpdateTrigger"></see>
    /// </summary>
    let SharedProfileUpdateTrigger = _prefix "SharedProfileUpdateTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SharedTagTrigger"></see>
    /// </summary>
    let SharedTagTrigger = _prefix "SharedTagTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SharedUnlikeTrigger"></see>
    /// </summary>
    let SharedUnlikeTrigger = _prefix "SharedUnlikeTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ShipmentTrackingTool"></see>
    /// </summary>
    let ShipmentTrackingTool = _prefix "ShipmentTrackingTool"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SleepTrackingService"></see>
    /// </summary>
    let SleepTrackingService = _prefix "SleepTrackingService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SmartBlind"></see>
    /// </summary>
    let SmartBlind = _prefix "SmartBlind"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SmartBracelet"></see>
    /// </summary>
    let SmartBracelet = _prefix "SmartBracelet"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SmartDoor"></see>
    /// </summary>
    let SmartDoor = _prefix "SmartDoor"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SmartWatch"></see>
    /// </summary>
    let SmartWatch = _prefix "SmartWatch"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SmartWindow"></see>
    /// </summary>
    let SmartWindow = _prefix "SmartWindow"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Smartphone"></see>
    /// </summary>
    let Smartphone = _prefix "Smartphone"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SocialNetwork"></see>
    /// </summary>
    let SocialNetwork = _prefix "SocialNetwork"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#SpeakerPhoneActivatedTrigger"></see>
    /// </summary>
    let SpeakerPhoneActivatedTrigger = _prefix "SpeakerPhoneActivatedTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Sprinkler"></see>
    /// </summary>
    let Sprinkler = _prefix "Sprinkler"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartActivityAction"></see>
    /// </summary>
    let StartActivityAction = _prefix "StartActivityAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartAppAction"></see>
    /// </summary>
    let StartAppAction = _prefix "StartAppAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartEntertainementAction"></see>
    /// </summary>
    let StartEntertainementAction = _prefix "StartEntertainementAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartBrewingCoffeeAction"></see>
    /// </summary>
    let StartBrewingCoffeeAction = _prefix "StartBrewingCoffeeAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartCookingAction"></see>
    /// </summary>
    let StartCookingAction = _prefix "StartCookingAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartBuyingAction"></see>
    /// </summary>
    let StartBuyingAction = _prefix "StartBuyingAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartCleaningAction"></see>
    /// </summary>
    let StartCleaningAction = _prefix "StartCleaningAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartDiswashingAction"></see>
    /// </summary>
    let StartDiswashingAction = _prefix "StartDiswashingAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartWashingAction"></see>
    /// </summary>
    let StartWashingAction = _prefix "StartWashingAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartDryingAction"></see>
    /// </summary>
    let StartDryingAction = _prefix "StartDryingAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartFocusingAction"></see>
    /// </summary>
    let StartFocusingAction = _prefix "StartFocusingAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartFocusingSessionAction"></see>
    /// </summary>
    let StartFocusingSessionAction = _prefix "StartFocusingSessionAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartListeningMusicAction"></see>
    /// </summary>
    let StartListeningMusicAction = _prefix "StartListeningMusicAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartOvenCookingAction"></see>
    /// </summary>
    let StartOvenCookingAction = _prefix "StartOvenCookingAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartPlayingAction"></see>
    /// </summary>
    let StartPlayingAction = _prefix "StartPlayingAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartStudyingSessionAction"></see>
    /// </summary>
    let StartStudyingSessionAction = _prefix "StartStudyingSessionAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartSuperMarketBuyingAction"></see>
    /// </summary>
    let StartSuperMarketBuyingAction = _prefix "StartSuperMarketBuyingAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartUsingSmartphoneAction"></see>
    /// </summary>
    let StartUsingSmartphoneAction = _prefix "StartUsingSmartphoneAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartVacuumAction"></see>
    /// </summary>
    let StartVacuumAction = _prefix "StartVacuumAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartWashingClothesAction"></see>
    /// </summary>
    let StartWashingClothesAction = _prefix "StartWashingClothesAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartWatchingTvAction"></see>
    /// </summary>
    let StartWatchingTvAction = _prefix "StartWatchingTvAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartedActivityTrigger"></see>
    /// </summary>
    let StartedActivityTrigger = _prefix "StartedActivityTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartedAppTrigger"></see>
    /// </summary>
    let StartedAppTrigger = _prefix "StartedAppTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartedEntertainementTrigger"></see>
    /// </summary>
    let StartedEntertainementTrigger = _prefix "StartedEntertainementTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartedBikeSessionTrigger"></see>
    /// </summary>
    let StartedBikeSessionTrigger = _prefix "StartedBikeSessionTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartedPhysicalActivityTrigger"></see>
    /// </summary>
    let StartedPhysicalActivityTrigger = _prefix "StartedPhysicalActivityTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartedBrewingCoffeeTrigger"></see>
    /// </summary>
    let StartedBrewingCoffeeTrigger = _prefix "StartedBrewingCoffeeTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartedCookingTrigger"></see>
    /// </summary>
    let StartedCookingTrigger = _prefix "StartedCookingTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartedCleaningTrigger"></see>
    /// </summary>
    let StartedCleaningTrigger = _prefix "StartedCleaningTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartedDiswashingTrigger"></see>
    /// </summary>
    let StartedDiswashingTrigger = _prefix "StartedDiswashingTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartedWashingTrigger"></see>
    /// </summary>
    let StartedWashingTrigger = _prefix "StartedWashingTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartedDryingTrigger"></see>
    /// </summary>
    let StartedDryingTrigger = _prefix "StartedDryingTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartedFocusingSessionTrigger"></see>
    /// </summary>
    let StartedFocusingSessionTrigger = _prefix "StartedFocusingSessionTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartedFocusingTrigger"></see>
    /// </summary>
    let StartedFocusingTrigger = _prefix "StartedFocusingTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartedInteractionTrigger"></see>
    /// </summary>
    let StartedInteractionTrigger = _prefix "StartedInteractionTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartedListeningMusicTrigger"></see>
    /// </summary>
    let StartedListeningMusicTrigger = _prefix "StartedListeningMusicTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartedOvenCookingTrigger"></see>
    /// </summary>
    let StartedOvenCookingTrigger = _prefix "StartedOvenCookingTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartedPlayingTrigger"></see>
    /// </summary>
    let StartedPlayingTrigger = _prefix "StartedPlayingTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartedRelaxingTrigger"></see>
    /// </summary>
    let StartedRelaxingTrigger = _prefix "StartedRelaxingTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartedRunSessionTrigger"></see>
    /// </summary>
    let StartedRunSessionTrigger = _prefix "StartedRunSessionTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartedSleepingTrigger"></see>
    /// </summary>
    let StartedSleepingTrigger = _prefix "StartedSleepingTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartedStudyingSessionTrigger"></see>
    /// </summary>
    let StartedStudyingSessionTrigger = _prefix "StartedStudyingSessionTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartedUsingSmartphoneTrigger"></see>
    /// </summary>
    let StartedUsingSmartphoneTrigger = _prefix "StartedUsingSmartphoneTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartedVacuumTrigger"></see>
    /// </summary>
    let StartedVacuumTrigger = _prefix "StartedVacuumTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartedWalkingSessionTrigger"></see>
    /// </summary>
    let StartedWalkingSessionTrigger = _prefix "StartedWalkingSessionTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartedWatchingTvTrigger"></see>
    /// </summary>
    let StartedWatchingTvTrigger = _prefix "StartedWatchingTvTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StartingWashingClothesTrigger"></see>
    /// </summary>
    let StartingWashingClothesTrigger = _prefix "StartingWashingClothesTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StopActivityAction"></see>
    /// </summary>
    let StopActivityAction = _prefix "StopActivityAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StopAppAction"></see>
    /// </summary>
    let StopAppAction = _prefix "StopAppAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StopEntertainementAction"></see>
    /// </summary>
    let StopEntertainementAction = _prefix "StopEntertainementAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StopBrewingCoffeeAction"></see>
    /// </summary>
    let StopBrewingCoffeeAction = _prefix "StopBrewingCoffeeAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StopCookingAction"></see>
    /// </summary>
    let StopCookingAction = _prefix "StopCookingAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StopCleaningAction"></see>
    /// </summary>
    let StopCleaningAction = _prefix "StopCleaningAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StopDiswashingAction"></see>
    /// </summary>
    let StopDiswashingAction = _prefix "StopDiswashingAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StopWashingAction"></see>
    /// </summary>
    let StopWashingAction = _prefix "StopWashingAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StopDryingAction"></see>
    /// </summary>
    let StopDryingAction = _prefix "StopDryingAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StopFocusingAction"></see>
    /// </summary>
    let StopFocusingAction = _prefix "StopFocusingAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StopFocusingSessionAction"></see>
    /// </summary>
    let StopFocusingSessionAction = _prefix "StopFocusingSessionAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StopListeningMusicAction"></see>
    /// </summary>
    let StopListeningMusicAction = _prefix "StopListeningMusicAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StopOvenCookingAction"></see>
    /// </summary>
    let StopOvenCookingAction = _prefix "StopOvenCookingAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StopPlayingAction"></see>
    /// </summary>
    let StopPlayingAction = _prefix "StopPlayingAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StopStudyingSessionAction"></see>
    /// </summary>
    let StopStudyingSessionAction = _prefix "StopStudyingSessionAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StopUsingSmartphoneAction"></see>
    /// </summary>
    let StopUsingSmartphoneAction = _prefix "StopUsingSmartphoneAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StopVacuumAction"></see>
    /// </summary>
    let StopVacuumAction = _prefix "StopVacuumAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StopWashingClothesAction"></see>
    /// </summary>
    let StopWashingClothesAction = _prefix "StopWashingClothesAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StopWatchingTvAction"></see>
    /// </summary>
    let StopWatchingTvAction = _prefix "StopWatchingTvAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StoppedActivityTrigger"></see>
    /// </summary>
    let StoppedActivityTrigger = _prefix "StoppedActivityTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StoppedAppTrigger"></see>
    /// </summary>
    let StoppedAppTrigger = _prefix "StoppedAppTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StoppedEntertainementTrigger"></see>
    /// </summary>
    let StoppedEntertainementTrigger = _prefix "StoppedEntertainementTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StoppedBikeSessionTrigger"></see>
    /// </summary>
    let StoppedBikeSessionTrigger = _prefix "StoppedBikeSessionTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StoppedPhysicalActivityTrigger"></see>
    /// </summary>
    let StoppedPhysicalActivityTrigger = _prefix "StoppedPhysicalActivityTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StoppedBrewingCoffeeTrigger"></see>
    /// </summary>
    let StoppedBrewingCoffeeTrigger = _prefix "StoppedBrewingCoffeeTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StoppedCookingTrigger"></see>
    /// </summary>
    let StoppedCookingTrigger = _prefix "StoppedCookingTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StoppedDiswashingTrigger"></see>
    /// </summary>
    let StoppedDiswashingTrigger = _prefix "StoppedDiswashingTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StoppedWashingTrigger"></see>
    /// </summary>
    let StoppedWashingTrigger = _prefix "StoppedWashingTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StoppedDryingTrigger"></see>
    /// </summary>
    let StoppedDryingTrigger = _prefix "StoppedDryingTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StoppedFocusingSessionTrigger"></see>
    /// </summary>
    let StoppedFocusingSessionTrigger = _prefix "StoppedFocusingSessionTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StoppedFocusingTrigger"></see>
    /// </summary>
    let StoppedFocusingTrigger = _prefix "StoppedFocusingTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StoppedListeningMusicTrigger"></see>
    /// </summary>
    let StoppedListeningMusicTrigger = _prefix "StoppedListeningMusicTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StoppedOvenCookingTrigger"></see>
    /// </summary>
    let StoppedOvenCookingTrigger = _prefix "StoppedOvenCookingTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StoppedPlayingTrigger"></see>
    /// </summary>
    let StoppedPlayingTrigger = _prefix "StoppedPlayingTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StoppedRelaxingTrigger"></see>
    /// </summary>
    let StoppedRelaxingTrigger = _prefix "StoppedRelaxingTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StoppedRunSessionTrigger"></see>
    /// </summary>
    let StoppedRunSessionTrigger = _prefix "StoppedRunSessionTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StoppedSleepingTrigger"></see>
    /// </summary>
    let StoppedSleepingTrigger = _prefix "StoppedSleepingTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StoppedStudyingSessionTrigger"></see>
    /// </summary>
    let StoppedStudyingSessionTrigger = _prefix "StoppedStudyingSessionTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StoppedUsingSmartphoneTrigger"></see>
    /// </summary>
    let StoppedUsingSmartphoneTrigger = _prefix "StoppedUsingSmartphoneTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StoppedWalkingSessionTrigger"></see>
    /// </summary>
    let StoppedWalkingSessionTrigger = _prefix "StoppedWalkingSessionTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StoppedWashingClothesTrigger"></see>
    /// </summary>
    let StoppedWashingClothesTrigger = _prefix "StoppedWashingClothesTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StoppedWatchingTvTrigger"></see>
    /// </summary>
    let StoppedWatchingTvTrigger = _prefix "StoppedWatchingTvTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StoredAppTrigger"></see>
    /// </summary>
    let StoredAppTrigger = _prefix "StoredAppTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StoredTrigger"></see>
    /// </summary>
    let StoredTrigger = _prefix "StoredTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StoredBackupTrigger"></see>
    /// </summary>
    let StoredBackupTrigger = _prefix "StoredBackupTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StoredContactTrigger"></see>
    /// </summary>
    let StoredContactTrigger = _prefix "StoredContactTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StoredFileTrigger"></see>
    /// </summary>
    let StoredFileTrigger = _prefix "StoredFileTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StoredHealthInformationTrigger"></see>
    /// </summary>
    let StoredHealthInformationTrigger = _prefix "StoredHealthInformationTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StoredMediaInformationTrigger"></see>
    /// </summary>
    let StoredMediaInformationTrigger = _prefix "StoredMediaInformationTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StoredWebBookmarkTrigger"></see>
    /// </summary>
    let StoredWebBookmarkTrigger = _prefix "StoredWebBookmarkTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#StudyingTrackingService"></see>
    /// </summary>
    let StudyingTrackingService = _prefix "StudyingTrackingService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#TVService"></see>
    /// </summary>
    let TVService = _prefix "TVService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Tablet"></see>
    /// </summary>
    let Tablet = _prefix "Tablet"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#TagService"></see>
    /// </summary>
    let TagService = _prefix "TagService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#TakeAction"></see>
    /// </summary>
    let TakeAction = _prefix "TakeAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#TakeAudioAction"></see>
    /// </summary>
    let TakeAudioAction = _prefix "TakeAudioAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#TakePhotoAction"></see>
    /// </summary>
    let TakePhotoAction = _prefix "TakePhotoAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#TakeVideoAction"></see>
    /// </summary>
    let TakeVideoAction = _prefix "TakeVideoAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#TakenAudioTrigger"></see>
    /// </summary>
    let TakenAudioTrigger = _prefix "TakenAudioTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#TakenTrigger"></see>
    /// </summary>
    let TakenTrigger = _prefix "TakenTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#TakenImageTrigger"></see>
    /// </summary>
    let TakenImageTrigger = _prefix "TakenImageTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#TakenVideoTrigger"></see>
    /// </summary>
    let TakenVideoTrigger = _prefix "TakenVideoTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#TapButtonActivityTrigger"></see>
    /// </summary>
    let TapButtonActivityTrigger = _prefix "TapButtonActivityTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#TemperatureSetToTrigger"></see>
    /// </summary>
    let TemperatureSetToTrigger = _prefix "TemperatureSetToTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#TemporalTrigger"></see>
    /// </summary>
    let TemporalTrigger = _prefix "TemporalTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Thermostat"></see>
    /// </summary>
    let Thermostat = _prefix "Thermostat"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#TimeManagementTool"></see>
    /// </summary>
    let TimeManagementTool = _prefix "TimeManagementTool"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#TimerService"></see>
    /// </summary>
    let TimerService = _prefix "TimerService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ToDoTool"></see>
    /// </summary>
    let ToDoTool = _prefix "ToDoTool"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#ToggleSwitchTrigger"></see>
    /// </summary>
    let ToggleSwitchTrigger = _prefix "ToggleSwitchTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#TurnAlarmOffAction"></see>
    /// </summary>
    let TurnAlarmOffAction = _prefix "TurnAlarmOffAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#TurnDeviceOffAction"></see>
    /// </summary>
    let TurnDeviceOffAction = _prefix "TurnDeviceOffAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#TurnDeviceOnAction"></see>
    /// </summary>
    let TurnDeviceOnAction = _prefix "TurnDeviceOnAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Tv"></see>
    /// </summary>
    let Tv = _prefix "Tv"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#UnlikeService"></see>
    /// </summary>
    let UnlikeService = _prefix "UnlikeService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#UpdatedWallpaperTrigger"></see>
    /// </summary>
    let UpdatedWallpaperTrigger = _prefix "UpdatedWallpaperTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#VacuumService"></see>
    /// </summary>
    let VacuumService = _prefix "VacuumService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#VehicleTrackingService"></see>
    /// </summary>
    let VehicleTrackingService = _prefix "VehicleTrackingService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#Ventilator"></see>
    /// </summary>
    let Ventilator = _prefix "Ventilator"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#VideoPlatform"></see>
    /// </summary>
    let VideoPlatform = _prefix "VideoPlatform"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#VideoRecordingService"></see>
    /// </summary>
    let VideoRecordingService = _prefix "VideoRecordingService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#VideoService"></see>
    /// </summary>
    let VideoService = _prefix "VideoService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#VoiceAssistant"></see>
    /// </summary>
    let VoiceAssistant = _prefix "VoiceAssistant"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#VolumeDecreasedTrigger"></see>
    /// </summary>
    let VolumeDecreasedTrigger = _prefix "VolumeDecreasedTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#VolumeIncreasedTrigger"></see>
    /// </summary>
    let VolumeIncreasedTrigger = _prefix "VolumeIncreasedTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#VolumeService"></see>
    /// </summary>
    let VolumeService = _prefix "VolumeService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#WalkTrackingService"></see>
    /// </summary>
    let WalkTrackingService = _prefix "WalkTrackingService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#WashingMachine"></see>
    /// </summary>
    let WashingMachine = _prefix "WashingMachine"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#WashingService"></see>
    /// </summary>
    let WashingService = _prefix "WashingService"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#WaterTemperatureSystemDisabledTrigger"></see>
    /// </summary>
    let WaterTemperatureSystemDisabledTrigger =
        _prefix "WaterTemperatureSystemDisabledTrigger"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#WaterTemperatureSystemEnabledTrigger"></see>
    /// </summary>
    let WaterTemperatureSystemEnabledTrigger =
        _prefix "WaterTemperatureSystemEnabledTrigger"

    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#WateringService"></see>
    /// </summary>
    let WateringService = _prefix "WateringService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#WateringSystemDisabledTrigger"></see>
    /// </summary>
    let WateringSystemDisabledTrigger = _prefix "WateringSystemDisabledTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#WateringSystemEnabledTrigger"></see>
    /// </summary>
    let WateringSystemEnabledTrigger = _prefix "WateringSystemEnabledTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#WeatherService"></see>
    /// </summary>
    let WeatherService = _prefix "WeatherService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#WeatherStation"></see>
    /// </summary>
    let WeatherStation = _prefix "WeatherStation"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#WeatherWebSite"></see>
    /// </summary>
    let WeatherWebSite = _prefix "WeatherWebSite"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#WebBookmarkService"></see>
    /// </summary>
    let WebBookmarkService = _prefix "WebBookmarkService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#WebBookmarkTool"></see>
    /// </summary>
    let WebBookmarkTool = _prefix "WebBookmarkTool"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#WebRequestService"></see>
    /// </summary>
    let WebRequestService = _prefix "WebRequestService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#WifiService"></see>
    /// </summary>
    let WifiService = _prefix "WifiService"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#WindowFrameClosedTrigger"></see>
    /// </summary>
    let WindowFrameClosedTrigger = _prefix "WindowFrameClosedTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#WindowFrameOpenedTrigger"></see>
    /// </summary>
    let WindowFrameOpenedTrigger = _prefix "WindowFrameOpenedTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#WorseDeviceConditionAction"></see>
    /// </summary>
    let WorseDeviceConditionAction = _prefix "WorseDeviceConditionAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#WorseDeviceConditionTrigger"></see>
    /// </summary>
    let WorseDeviceConditionTrigger = _prefix "WorseDeviceConditionTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#allowTo"></see>
    /// </summary>
    let allowTo = _prefix "allowTo"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#canControl"></see>
    /// </summary>
    let canControl = _prefix "canControl"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#channelOffer"></see>
    /// </summary>
    let channelOffer = _prefix "channelOffer"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#isOfChannel"></see>
    /// </summary>
    let isOfChannel = _prefix "isOfChannel"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#commandAllowTo"></see>
    /// </summary>
    let commandAllowTo = _prefix "commandAllowTo"
    /// <summary>
    /// description
    /// <see href="http://elite.polito.it/ontologies/eupont.owl#description"></see></summary>
    let description = _prefix "description"
    /// <summary>
    /// detail
    /// <see href="http://elite.polito.it/ontologies/eupont.owl#detail"></see></summary>
    let detail = _prefix "detail"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#hasCategory"></see>
    /// </summary>
    let hasCategory = _prefix "hasCategory"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#hasDetail"></see>
    /// </summary>
    let hasDetail = _prefix "hasDetail"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#hasRegisteredEntity"></see>
    /// </summary>
    let hasRegisteredEntity = _prefix "hasRegisteredEntity"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#hasTechnology"></see>
    /// </summary>
    let hasTechnology = _prefix "hasTechnology"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#location"></see>
    /// </summary>
    let location = _prefix "location"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#nominal"></see>
    /// </summary>
    let nominal = _prefix "nominal"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#nominalDetail"></see>
    /// </summary>
    let nominalDetail = _prefix "nominalDetail"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#notificationAllowTo"></see>
    /// </summary>
    let notificationAllowTo = _prefix "notificationAllowTo"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#offerAction"></see>
    /// </summary>
    let offerAction = _prefix "offerAction"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#offerDetail"></see>
    /// </summary>
    let offerDetail = _prefix "offerDetail"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#offerTrigger"></see>
    /// </summary>
    let offerTrigger = _prefix "offerTrigger"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#triggers"></see>
    /// </summary>
    let triggers = _prefix "triggers"
    /// <summary>
    /// type
    /// <see href="http://elite.polito.it/ontologies/eupont.owl#type"></see></summary>
    let type_ = _prefix "type"
    /// <summary>
    /// value
    /// <see href="http://elite.polito.it/ontologies/eupont.owl#value"></see></summary>
    let value = _prefix "value"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#where"></see>
    /// </summary>
    let where = _prefix "where"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#which"></see>
    /// </summary>
    let which = _prefix "which"
    /// <summary>
    ///   <see href="http://elite.polito.it/ontologies/eupont.owl#who"></see>
    /// </summary>
    let who = _prefix "who"
