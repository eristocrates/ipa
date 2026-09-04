#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module eupont =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://elite.polito.it/ontologies/eupont.owl#" "eupont"

    /// <summary>
    ///   <para>rdfs:label : AcceptCommunicationAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#AcceptCommunicationAction">eupont:AcceptCommunicationAction</a>
    /// </summary>
    let AcceptCommunicationAction = _prefixId.prefix "AcceptCommunicationAction"
    /// <summary>
    ///   <para>rdfs:label : Action</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#Action">eupont:Action</a>
    /// </summary>
    let Action = _prefixId.prefix "Action"

    /// <summary>
    ///   <para>rdfs:label : ActivateEnvironmentSceneAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#ActivateEnvironmentSceneAction">eupont:ActivateEnvironmentSceneAction</a>
    /// </summary>
    let ActivateEnvironmentSceneAction =
        _prefixId.prefix "ActivateEnvironmentSceneAction"

    /// <summary>
    ///   <para>rdfs:label : ActivityAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#ActivityAction">eupont:ActivityAction</a>
    /// </summary>
    let ActivityAction = _prefixId.prefix "ActivityAction"
    /// <summary>
    ///   <para>rdfs:label : ActivityTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#ActivityTrigger">eupont:ActivityTrigger</a>
    /// </summary>
    let ActivityTrigger = _prefixId.prefix "ActivityTrigger"
    /// <summary>
    ///   <para>rdfs:label : AddAlarmAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#AddAlarmAction">eupont:AddAlarmAction</a>
    /// </summary>
    let AddAlarmAction = _prefixId.prefix "AddAlarmAction"
    /// <summary>
    ///   <para>rdfs:label : AddCalendarItemAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#AddCalendarItemAction">eupont:AddCalendarItemAction</a>
    /// </summary>
    let AddCalendarItemAction = _prefixId.prefix "AddCalendarItemAction"
    /// <summary>
    ///   <para>rdfs:label : AddRemindAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#AddRemindAction">eupont:AddRemindAction</a>
    /// </summary>
    let AddRemindAction = _prefixId.prefix "AddRemindAction"
    /// <summary>
    ///   <para>rdfs:label : AddReminderAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#AddReminderAction">eupont:AddReminderAction</a>
    /// </summary>
    let AddReminderAction = _prefixId.prefix "AddReminderAction"
    /// <summary>
    ///   <para>rdfs:label : AddTimerAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#AddTimerAction">eupont:AddTimerAction</a>
    /// </summary>
    let AddTimerAction = _prefixId.prefix "AddTimerAction"
    /// <summary>
    ///   <para>rdfs:label : AddedAlarmTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#AddedAlarmTrigger">eupont:AddedAlarmTrigger</a>
    /// </summary>
    let AddedAlarmTrigger = _prefixId.prefix "AddedAlarmTrigger"
    /// <summary>
    ///   <para>rdfs:label : AddedCalendarItemTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#AddedCalendarItemTrigger">eupont:AddedCalendarItemTrigger</a>
    /// </summary>
    let AddedCalendarItemTrigger = _prefixId.prefix "AddedCalendarItemTrigger"
    /// <summary>
    ///   <para>rdfs:label : AddedRemindTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#AddedRemindTrigger">eupont:AddedRemindTrigger</a>
    /// </summary>
    let AddedRemindTrigger = _prefixId.prefix "AddedRemindTrigger"
    /// <summary>
    ///   <para>rdfs:label : AddedReminderTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#AddedReminderTrigger">eupont:AddedReminderTrigger</a>
    /// </summary>
    let AddedReminderTrigger = _prefixId.prefix "AddedReminderTrigger"
    /// <summary>
    ///   <para>rdfs:label : AddedTimerTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#AddedTimerTrigger">eupont:AddedTimerTrigger</a>
    /// </summary>
    let AddedTimerTrigger = _prefixId.prefix "AddedTimerTrigger"
    /// <summary>
    ///   <para>rdfs:label : Agent</para>
    ///   <para>rdfs:comment : An agent (eg. person, group, software or physical artifact).</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#Agent">eupont:Agent</a>
    /// </summary>
    let Agent = _prefixId.prefix "Agent"
    /// <summary>
    ///   <para>rdfs:label : AirConditioner</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#AirConditioner">eupont:AirConditioner</a>
    /// </summary>
    let AirConditioner = _prefixId.prefix "AirConditioner"
    /// <summary>
    ///   <para>rdfs:label : AirMonitor</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#AirMonitor">eupont:AirMonitor</a>
    /// </summary>
    let AirMonitor = _prefixId.prefix "AirMonitor"
    /// <summary>
    ///   <para>rdfs:label : AirPressureService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#AirPressureService">eupont:AirPressureService</a>
    /// </summary>
    let AirPressureService = _prefixId.prefix "AirPressureService"
    /// <summary>
    ///   <para>rdfs:label : AirPurifier</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#AirPurifier">eupont:AirPurifier</a>
    /// </summary>
    let AirPurifier = _prefixId.prefix "AirPurifier"
    /// <summary>
    ///   <para>rdfs:label : AirPurifierDisabledTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#AirPurifierDisabledTrigger">eupont:AirPurifierDisabledTrigger</a>
    /// </summary>
    let AirPurifierDisabledTrigger = _prefixId.prefix "AirPurifierDisabledTrigger"
    /// <summary>
    ///   <para>rdfs:label : AirPurifierEnabledTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#AirPurifierEnabledTrigger">eupont:AirPurifierEnabledTrigger</a>
    /// </summary>
    let AirPurifierEnabledTrigger = _prefixId.prefix "AirPurifierEnabledTrigger"
    /// <summary>
    ///   <para>rdfs:label : AirPurifierService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#AirPurifierService">eupont:AirPurifierService</a>
    /// </summary>
    let AirPurifierService = _prefixId.prefix "AirPurifierService"
    /// <summary>
    ///   <para>rdfs:label : AlarmClockService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#AlarmClockService">eupont:AlarmClockService</a>
    /// </summary>
    let AlarmClockService = _prefixId.prefix "AlarmClockService"
    /// <summary>
    ///   <para>rdfs:label : AnswerCallAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#AnswerCallAction">eupont:AnswerCallAction</a>
    /// </summary>
    let AnswerCallAction = _prefixId.prefix "AnswerCallAction"
    /// <summary>
    ///   <para>rdfs:label : AntiIntrusionSystem</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#AntiIntrusionSystem">eupont:AntiIntrusionSystem</a>
    /// </summary>
    let AntiIntrusionSystem = _prefixId.prefix "AntiIntrusionSystem"
    /// <summary>
    ///   <para>rdfs:label : Appliance</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#Appliance">eupont:Appliance</a>
    /// </summary>
    let Appliance = _prefixId.prefix "Appliance"
    /// <summary>
    ///   <para>rdfs:label : ApplianceService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#ApplianceService">eupont:ApplianceService</a>
    /// </summary>
    let ApplianceService = _prefixId.prefix "ApplianceService"
    /// <summary>
    ///   <para>rdfs:label : ArriveOnVehicleTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#ArriveOnVehicleTrigger">eupont:ArriveOnVehicleTrigger</a>
    /// </summary>
    let ArriveOnVehicleTrigger = _prefixId.prefix "ArriveOnVehicleTrigger"
    /// <summary>
    ///   <para>rdfs:label : AttachementService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#AttachementService">eupont:AttachementService</a>
    /// </summary>
    let AttachementService = _prefixId.prefix "AttachementService"
    /// <summary>
    ///   <para>rdfs:label : AudioRecordingService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#AudioRecordingService">eupont:AudioRecordingService</a>
    /// </summary>
    let AudioRecordingService = _prefixId.prefix "AudioRecordingService"
    /// <summary>
    ///   <para>rdfs:label : AudioService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#AudioService">eupont:AudioService</a>
    /// </summary>
    let AudioService = _prefixId.prefix "AudioService"
    /// <summary>
    ///   <para>rdfs:label : BatteryService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#BatteryService">eupont:BatteryService</a>
    /// </summary>
    let BatteryService = _prefixId.prefix "BatteryService"
    /// <summary>
    ///   <para>rdfs:label : Beacon</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#Beacon">eupont:Beacon</a>
    /// </summary>
    let Beacon = _prefixId.prefix "Beacon"
    /// <summary>
    ///   <para>rdfs:label : BikeTrackingService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#BikeTrackingService">eupont:BikeTrackingService</a>
    /// </summary>
    let BikeTrackingService = _prefixId.prefix "BikeTrackingService"
    /// <summary>
    ///   <para>rdfs:label : BlockCallAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#BlockCallAction">eupont:BlockCallAction</a>
    /// </summary>
    let BlockCallAction = _prefixId.prefix "BlockCallAction"
    /// <summary>
    ///   <para>rdfs:label : Blog</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#Blog">eupont:Blog</a>
    /// </summary>
    let Blog = _prefixId.prefix "Blog"
    /// <summary>
    ///   <para>rdfs:label : BluetoothService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#BluetoothService">eupont:BluetoothService</a>
    /// </summary>
    let BluetoothService = _prefixId.prefix "BluetoothService"
    /// <summary>
    ///   <para>rdfs:label : BrightnessDecreasedTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#BrightnessDecreasedTrigger">eupont:BrightnessDecreasedTrigger</a>
    /// </summary>
    let BrightnessDecreasedTrigger = _prefixId.prefix "BrightnessDecreasedTrigger"
    /// <summary>
    ///   <para>rdfs:label : BrightnessIncreasedTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#BrightnessIncreasedTrigger">eupont:BrightnessIncreasedTrigger</a>
    /// </summary>
    let BrightnessIncreasedTrigger = _prefixId.prefix "BrightnessIncreasedTrigger"
    /// <summary>
    ///   <para>rdfs:label : Building</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#Building">eupont:Building</a>
    /// </summary>
    let Building = _prefixId.prefix "Building"
    /// <summary>
    ///   <para>rdfs:label : BuyCommand</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#BuyCommand">eupont:BuyCommand</a>
    /// </summary>
    let BuyCommand = _prefixId.prefix "BuyCommand"
    /// <summary>
    ///   <para>rdfs:label : CalendarService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#CalendarService">eupont:CalendarService</a>
    /// </summary>
    let CalendarService = _prefixId.prefix "CalendarService"
    /// <summary>
    ///   <para>rdfs:label : Calendar</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#CalendarTool">eupont:CalendarTool</a>
    /// </summary>
    let CalendarTool = _prefixId.prefix "CalendarTool"
    /// <summary>
    ///   <para>rdfs:label : CallService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#CallService">eupont:CallService</a>
    /// </summary>
    let CallService = _prefixId.prefix "CallService"
    /// <summary>
    ///   <para>rdfs:label : Call</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#CallTool">eupont:CallTool</a>
    /// </summary>
    let CallTool = _prefixId.prefix "CallTool"
    /// <summary>
    ///   <para>rdfs:label : Camera</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#Camera">eupont:Camera</a>
    /// </summary>
    let Camera = _prefixId.prefix "Camera"
    /// <summary>
    ///   <para>rdfs:label : Category</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#Category">eupont:Category</a>
    /// </summary>
    let Category = _prefixId.prefix "Category"
    /// <summary>
    ///   <para>rdfs:label : Channel</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#Channel">eupont:Channel</a>
    /// </summary>
    let Channel = _prefixId.prefix "Channel"
    /// <summary>
    ///   <para>rdfs:label : Chat</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#ChatTool">eupont:ChatTool</a>
    /// </summary>
    let ChatTool = _prefixId.prefix "ChatTool"
    /// <summary>
    ///   <para>rdfs:label : CloseCommand</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#CloseCommand">eupont:CloseCommand</a>
    /// </summary>
    let CloseCommand = _prefixId.prefix "CloseCommand"
    /// <summary>
    ///   <para>rdfs:label : CloseNotification</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#CloseNotification">eupont:CloseNotification</a>
    /// </summary>
    let CloseNotification = _prefixId.prefix "CloseNotification"
    /// <summary>
    ///   <para>rdfs:label : CloseSafetyValveAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#CloseSafetyValveAction">eupont:CloseSafetyValveAction</a>
    /// </summary>
    let CloseSafetyValveAction = _prefixId.prefix "CloseSafetyValveAction"
    /// <summary>
    ///   <para>rdfs:label : CloseWindowFrameAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#CloseWindowFrameAction">eupont:CloseWindowFrameAction</a>
    /// </summary>
    let CloseWindowFrameAction = _prefixId.prefix "CloseWindowFrameAction"
    /// <summary>
    ///   <para>rdfs:label : CloudPlatform</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#CloudPlatform">eupont:CloudPlatform</a>
    /// </summary>
    let CloudPlatform = _prefixId.prefix "CloudPlatform"
    /// <summary>
    ///   <para>rdfs:label : CodeHostingPlatform</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#CodeHostingPlatform">eupont:CodeHostingPlatform</a>
    /// </summary>
    let CodeHostingPlatform = _prefixId.prefix "CodeHostingPlatform"
    /// <summary>
    ///   <para>rdfs:label : CoffeeMaker</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#CoffeeMaker">eupont:CoffeeMaker</a>
    /// </summary>
    let CoffeeMaker = _prefixId.prefix "CoffeeMaker"
    /// <summary>
    ///   <para>rdfs:label : CoffeeService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#CoffeeService">eupont:CoffeeService</a>
    /// </summary>
    let CoffeeService = _prefixId.prefix "CoffeeService"
    /// <summary>
    ///   <para>rdfs:label : Colleague</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#Colleague">eupont:Colleague</a>
    /// </summary>
    let Colleague = _prefixId.prefix "Colleague"
    /// <summary>
    ///   <para>rdfs:label : Command</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#Command">eupont:Command</a>
    /// </summary>
    let Command = _prefixId.prefix "Command"
    /// <summary>
    ///   <para>rdfs:label : CommentService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#CommentService">eupont:CommentService</a>
    /// </summary>
    let CommentService = _prefixId.prefix "CommentService"
    /// <summary>
    ///   <para>rdfs:label : CommunicationService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#CommunicationService">eupont:CommunicationService</a>
    /// </summary>
    let CommunicationService = _prefixId.prefix "CommunicationService"
    /// <summary>
    ///   <para>rdfs:label : CommunicationTool</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#CommunicationTool">eupont:CommunicationTool</a>
    /// </summary>
    let CommunicationTool = _prefixId.prefix "CommunicationTool"
    /// <summary>
    ///   <para>rdfs:label : ConnectCommand</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#ConnectCommand">eupont:ConnectCommand</a>
    /// </summary>
    let ConnectCommand = _prefixId.prefix "ConnectCommand"
    /// <summary>
    ///   <para>rdfs:label : ConnectDeviceAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#ConnectDeviceAction">eupont:ConnectDeviceAction</a>
    /// </summary>
    let ConnectDeviceAction = _prefixId.prefix "ConnectDeviceAction"
    /// <summary>
    ///   <para>rdfs:label : ConnectNotification</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#ConnectNotification">eupont:ConnectNotification</a>
    /// </summary>
    let ConnectNotification = _prefixId.prefix "ConnectNotification"
    /// <summary>
    ///   <para>rdfs:label : ConnectToDeviceAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#ConnectToDeviceAction">eupont:ConnectToDeviceAction</a>
    /// </summary>
    let ConnectToDeviceAction = _prefixId.prefix "ConnectToDeviceAction"
    /// <summary>
    ///   <para>rdfs:label : ConnectToNetworkAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#ConnectToNetworkAction">eupont:ConnectToNetworkAction</a>
    /// </summary>
    let ConnectToNetworkAction = _prefixId.prefix "ConnectToNetworkAction"
    /// <summary>
    ///   <para>rdfs:label : ConnectToWebServiceAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#ConnectToWebServiceAction">eupont:ConnectToWebServiceAction</a>
    /// </summary>
    let ConnectToWebServiceAction = _prefixId.prefix "ConnectToWebServiceAction"
    /// <summary>
    ///   <para>rdfs:label : ConnectedVehicle</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#ConnectedVehicle">eupont:ConnectedVehicle</a>
    /// </summary>
    let ConnectedVehicle = _prefixId.prefix "ConnectedVehicle"
    /// <summary>
    ///   <para>rdfs:label : ConnectionToDeviceTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#ConnectionToDeviceTrigger">eupont:ConnectionToDeviceTrigger</a>
    /// </summary>
    let ConnectionToDeviceTrigger = _prefixId.prefix "ConnectionToDeviceTrigger"
    /// <summary>
    ///   <para>rdfs:label : ConnectionToNetworkTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#ConnectionToNetworkTrigger">eupont:ConnectionToNetworkTrigger</a>
    /// </summary>
    let ConnectionToNetworkTrigger = _prefixId.prefix "ConnectionToNetworkTrigger"
    /// <summary>
    ///   <para>rdfs:label : ConnectivityAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#ConnectivityAction">eupont:ConnectivityAction</a>
    /// </summary>
    let ConnectivityAction = _prefixId.prefix "ConnectivityAction"
    /// <summary>
    ///   <para>rdfs:label : ConnectivityTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#ConnectivityTrigger">eupont:ConnectivityTrigger</a>
    /// </summary>
    let ConnectivityTrigger = _prefixId.prefix "ConnectivityTrigger"
    /// <summary>
    ///   <para>rdfs:label : Console</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#Console">eupont:Console</a>
    /// </summary>
    let Console = _prefixId.prefix "Console"
    /// <summary>
    ///   <para>rdfs:label : ContactService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#ContactService">eupont:ContactService</a>
    /// </summary>
    let ContactService = _prefixId.prefix "ContactService"
    /// <summary>
    ///   <para>rdfs:label : Cooker</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#Cooker">eupont:Cooker</a>
    /// </summary>
    let Cooker = _prefixId.prefix "Cooker"
    /// <summary>
    ///   <para>rdfs:label : CoolingService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#CoolingService">eupont:CoolingService</a>
    /// </summary>
    let CoolingService = _prefixId.prefix "CoolingService"
    /// <summary>
    ///   <para>rdfs:label : CoolingSystemDisabledTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#CoolingSystemDisabledTrigger">eupont:CoolingSystemDisabledTrigger</a>
    /// </summary>
    let CoolingSystemDisabledTrigger = _prefixId.prefix "CoolingSystemDisabledTrigger"
    /// <summary>
    ///   <para>rdfs:label : CoolingSystemEnabledTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#CoolingSystemEnabledTrigger">eupont:CoolingSystemEnabledTrigger</a>
    /// </summary>
    let CoolingSystemEnabledTrigger = _prefixId.prefix "CoolingSystemEnabledTrigger"
    /// <summary>
    ///   <para>rdfs:label : DIYElectronic</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DIYElectronic">eupont:DIYElectronic</a>
    /// </summary>
    let DIYElectronic = _prefixId.prefix "DIYElectronic"

    /// <summary>
    ///   <para>rdfs:label : DangerousActivityDetectedTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DangerousActivityDetectedTrigger">eupont:DangerousActivityDetectedTrigger</a>
    /// </summary>
    let DangerousActivityDetectedTrigger =
        _prefixId.prefix "DangerousActivityDetectedTrigger"

    /// <summary>
    ///   <para>rdfs:label : DangerousActivityTrackingService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DangerousActivityTrackingService">eupont:DangerousActivityTrackingService</a>
    /// </summary>
    let DangerousActivityTrackingService =
        _prefixId.prefix "DangerousActivityTrackingService"

    /// <summary>
    ///   <para>rdfs:label : DecreaseAirQualityAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DecreaseAirQualityAction">eupont:DecreaseAirQualityAction</a>
    /// </summary>
    let DecreaseAirQualityAction = _prefixId.prefix "DecreaseAirQualityAction"
    /// <summary>
    ///   <para>rdfs:label : DecreaseConnectivityAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DecreaseConnectivityAction">eupont:DecreaseConnectivityAction</a>
    /// </summary>
    let DecreaseConnectivityAction = _prefixId.prefix "DecreaseConnectivityAction"

    /// <summary>
    ///   <para>rdfs:label : DecreaseEnvironmentConditionAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DecreaseEnvironmentConditionAction">eupont:DecreaseEnvironmentConditionAction</a>
    /// </summary>
    let DecreaseEnvironmentConditionAction =
        _prefixId.prefix "DecreaseEnvironmentConditionAction"

    /// <summary>
    ///   <para>rdfs:label : DecreaseHumidityAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DecreaseHumidityAction">eupont:DecreaseHumidityAction</a>
    /// </summary>
    let DecreaseHumidityAction = _prefixId.prefix "DecreaseHumidityAction"
    /// <summary>
    ///   <para>rdfs:label : DecreaseLightingAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DecreaseLightingAction">eupont:DecreaseLightingAction</a>
    /// </summary>
    let DecreaseLightingAction = _prefixId.prefix "DecreaseLightingAction"
    /// <summary>
    ///   <para>rdfs:label : DecreaseNoiseAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DecreaseNoiseAction">eupont:DecreaseNoiseAction</a>
    /// </summary>
    let DecreaseNoiseAction = _prefixId.prefix "DecreaseNoiseAction"
    /// <summary>
    ///   <para>rdfs:label : DecreaseSecurityAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DecreaseSecurityAction">eupont:DecreaseSecurityAction</a>
    /// </summary>
    let DecreaseSecurityAction = _prefixId.prefix "DecreaseSecurityAction"
    /// <summary>
    ///   <para>rdfs:label : DecreaseTemperatureAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DecreaseTemperatureAction">eupont:DecreaseTemperatureAction</a>
    /// </summary>
    let DecreaseTemperatureAction = _prefixId.prefix "DecreaseTemperatureAction"

    /// <summary>
    ///   <para>rdfs:label : DecreaseUserConnectivityAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DecreaseUserConnectivityAction">eupont:DecreaseUserConnectivityAction</a>
    /// </summary>
    let DecreaseUserConnectivityAction =
        _prefixId.prefix "DecreaseUserConnectivityAction"

    /// <summary>
    ///   <para>rdfs:label : DecreaseVolumeAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DecreaseVolumeAction">eupont:DecreaseVolumeAction</a>
    /// </summary>
    let DecreaseVolumeAction = _prefixId.prefix "DecreaseVolumeAction"
    /// <summary>
    ///   <para>rdfs:label : DecreasedAirPressureTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DecreasedAirPressureTrigger">eupont:DecreasedAirPressureTrigger</a>
    /// </summary>
    let DecreasedAirPressureTrigger = _prefixId.prefix "DecreasedAirPressureTrigger"
    /// <summary>
    ///   <para>rdfs:label : DecreasedAirQualityTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DecreasedAirQualityTrigger">eupont:DecreasedAirQualityTrigger</a>
    /// </summary>
    let DecreasedAirQualityTrigger = _prefixId.prefix "DecreasedAirQualityTrigger"
    /// <summary>
    ///   <para>rdfs:label : DecreasedConnectivityTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DecreasedConnectivityTrigger">eupont:DecreasedConnectivityTrigger</a>
    /// </summary>
    let DecreasedConnectivityTrigger = _prefixId.prefix "DecreasedConnectivityTrigger"

    /// <summary>
    ///   <para>rdfs:label : DecreasedHealthConditionTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DecreasedHealthConditionTrigger">eupont:DecreasedHealthConditionTrigger</a>
    /// </summary>
    let DecreasedHealthConditionTrigger =
        _prefixId.prefix "DecreasedHealthConditionTrigger"

    /// <summary>
    ///   <para>rdfs:label : DecreasedHumidityTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DecreasedHumidityTrigger">eupont:DecreasedHumidityTrigger</a>
    /// </summary>
    let DecreasedHumidityTrigger = _prefixId.prefix "DecreasedHumidityTrigger"
    /// <summary>
    ///   <para>rdfs:label : DecreasedLightingTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DecreasedLightingTrigger">eupont:DecreasedLightingTrigger</a>
    /// </summary>
    let DecreasedLightingTrigger = _prefixId.prefix "DecreasedLightingTrigger"
    /// <summary>
    ///   <para>rdfs:label : DecreasedNoiseLevelTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DecreasedNoiseLevelTrigger">eupont:DecreasedNoiseLevelTrigger</a>
    /// </summary>
    let DecreasedNoiseLevelTrigger = _prefixId.prefix "DecreasedNoiseLevelTrigger"
    /// <summary>
    ///   <para>rdfs:label : DecreasedSecurityTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DecreasedSecurityTrigger">eupont:DecreasedSecurityTrigger</a>
    /// </summary>
    let DecreasedSecurityTrigger = _prefixId.prefix "DecreasedSecurityTrigger"
    /// <summary>
    ///   <para>rdfs:label : DecreasedTemperatureTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DecreasedTemperatureTrigger">eupont:DecreasedTemperatureTrigger</a>
    /// </summary>
    let DecreasedTemperatureTrigger = _prefixId.prefix "DecreasedTemperatureTrigger"

    /// <summary>
    ///   <para>rdfs:label : DecreasedWeatherConditionsTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DecreasedWeatherConditionsTrigger">eupont:DecreasedWeatherConditionsTrigger</a>
    /// </summary>
    let DecreasedWeatherConditionsTrigger =
        _prefixId.prefix "DecreasedWeatherConditionsTrigger"

    /// <summary>
    ///   <para>rdfs:label : Dehumidifier</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#Dehumidifier">eupont:Dehumidifier</a>
    /// </summary>
    let Dehumidifier = _prefixId.prefix "Dehumidifier"
    /// <summary>
    ///   <para>rdfs:label : DehumidifierService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DehumidifierService">eupont:DehumidifierService</a>
    /// </summary>
    let DehumidifierService = _prefixId.prefix "DehumidifierService"

    /// <summary>
    ///   <para>rdfs:label : DehumidifierSystemDisabledTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DehumidifierSystemDisabledTrigger">eupont:DehumidifierSystemDisabledTrigger</a>
    /// </summary>
    let DehumidifierSystemDisabledTrigger =
        _prefixId.prefix "DehumidifierSystemDisabledTrigger"

    /// <summary>
    ///   <para>rdfs:label : DehumidifierSystemEnabledTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DehumidifierSystemEnabledTrigger">eupont:DehumidifierSystemEnabledTrigger</a>
    /// </summary>
    let DehumidifierSystemEnabledTrigger =
        _prefixId.prefix "DehumidifierSystemEnabledTrigger"

    /// <summary>
    ///   <para>rdfs:label : DeleteAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DeleteAction">eupont:DeleteAction</a>
    /// </summary>
    let DeleteAction = _prefixId.prefix "DeleteAction"
    /// <summary>
    ///   <para>rdfs:label : DeleteAlarmAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DeleteAlarmAction">eupont:DeleteAlarmAction</a>
    /// </summary>
    let DeleteAlarmAction = _prefixId.prefix "DeleteAlarmAction"
    /// <summary>
    ///   <para>rdfs:label : DeleteCalendarItemAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DeleteCalendarItemAction">eupont:DeleteCalendarItemAction</a>
    /// </summary>
    let DeleteCalendarItemAction = _prefixId.prefix "DeleteCalendarItemAction"
    /// <summary>
    ///   <para>rdfs:label : DeleteCommand</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DeleteCommand">eupont:DeleteCommand</a>
    /// </summary>
    let DeleteCommand = _prefixId.prefix "DeleteCommand"
    /// <summary>
    ///   <para>rdfs:label : DeleteContactAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DeleteContactAction">eupont:DeleteContactAction</a>
    /// </summary>
    let DeleteContactAction = _prefixId.prefix "DeleteContactAction"
    /// <summary>
    ///   <para>rdfs:label : DeleteFileAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DeleteFileAction">eupont:DeleteFileAction</a>
    /// </summary>
    let DeleteFileAction = _prefixId.prefix "DeleteFileAction"
    /// <summary>
    ///   <para>rdfs:label : DeleteFromStorageAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DeleteFromStorageAction">eupont:DeleteFromStorageAction</a>
    /// </summary>
    let DeleteFromStorageAction = _prefixId.prefix "DeleteFromStorageAction"
    /// <summary>
    ///   <para>rdfs:label : DeleteHealthInformationAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DeleteHealthInformationAction">eupont:DeleteHealthInformationAction</a>
    /// </summary>
    let DeleteHealthInformationAction = _prefixId.prefix "DeleteHealthInformationAction"
    /// <summary>
    ///   <para>rdfs:label : DeleteMediaInformationAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DeleteMediaInformationAction">eupont:DeleteMediaInformationAction</a>
    /// </summary>
    let DeleteMediaInformationAction = _prefixId.prefix "DeleteMediaInformationAction"
    /// <summary>
    ///   <para>rdfs:label : DeleteNotification</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DeleteNotification">eupont:DeleteNotification</a>
    /// </summary>
    let DeleteNotification = _prefixId.prefix "DeleteNotification"
    /// <summary>
    ///   <para>rdfs:label : DeleteRemindAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DeleteRemindAction">eupont:DeleteRemindAction</a>
    /// </summary>
    let DeleteRemindAction = _prefixId.prefix "DeleteRemindAction"
    /// <summary>
    ///   <para>rdfs:label : DeleteReminderAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DeleteReminderAction">eupont:DeleteReminderAction</a>
    /// </summary>
    let DeleteReminderAction = _prefixId.prefix "DeleteReminderAction"
    /// <summary>
    ///   <para>rdfs:label : DeleteTimerAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DeleteTimerAction">eupont:DeleteTimerAction</a>
    /// </summary>
    let DeleteTimerAction = _prefixId.prefix "DeleteTimerAction"
    /// <summary>
    ///   <para>rdfs:label : DeleteWebBookmarkAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DeleteWebBookmarkAction">eupont:DeleteWebBookmarkAction</a>
    /// </summary>
    let DeleteWebBookmarkAction = _prefixId.prefix "DeleteWebBookmarkAction"
    /// <summary>
    ///   <para>rdfs:label : DeletedAlarmTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DeletedAlarmTrigger">eupont:DeletedAlarmTrigger</a>
    /// </summary>
    let DeletedAlarmTrigger = _prefixId.prefix "DeletedAlarmTrigger"
    /// <summary>
    ///   <para>rdfs:label : DeletedAppTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DeletedAppTrigger">eupont:DeletedAppTrigger</a>
    /// </summary>
    let DeletedAppTrigger = _prefixId.prefix "DeletedAppTrigger"
    /// <summary>
    ///   <para>rdfs:label : DeletedCalendarItemTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DeletedCalendarItemTrigger">eupont:DeletedCalendarItemTrigger</a>
    /// </summary>
    let DeletedCalendarItemTrigger = _prefixId.prefix "DeletedCalendarItemTrigger"
    /// <summary>
    ///   <para>rdfs:label : DeletedContactTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DeletedContactTrigger">eupont:DeletedContactTrigger</a>
    /// </summary>
    let DeletedContactTrigger = _prefixId.prefix "DeletedContactTrigger"
    /// <summary>
    ///   <para>rdfs:label : DeletedFileTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DeletedFileTrigger">eupont:DeletedFileTrigger</a>
    /// </summary>
    let DeletedFileTrigger = _prefixId.prefix "DeletedFileTrigger"
    /// <summary>
    ///   <para>rdfs:label : DeletedFromStorageTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DeletedFromStorageTrigger">eupont:DeletedFromStorageTrigger</a>
    /// </summary>
    let DeletedFromStorageTrigger = _prefixId.prefix "DeletedFromStorageTrigger"

    /// <summary>
    ///   <para>rdfs:label : DeletedHealthInformationTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DeletedHealthInformationTrigger">eupont:DeletedHealthInformationTrigger</a>
    /// </summary>
    let DeletedHealthInformationTrigger =
        _prefixId.prefix "DeletedHealthInformationTrigger"

    /// <summary>
    ///   <para>rdfs:label : DeletedMediaInformationTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DeletedMediaInformationTrigger">eupont:DeletedMediaInformationTrigger</a>
    /// </summary>
    let DeletedMediaInformationTrigger =
        _prefixId.prefix "DeletedMediaInformationTrigger"

    /// <summary>
    ///   <para>rdfs:label : DeletedRemindTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DeletedRemindTrigger">eupont:DeletedRemindTrigger</a>
    /// </summary>
    let DeletedRemindTrigger = _prefixId.prefix "DeletedRemindTrigger"
    /// <summary>
    ///   <para>rdfs:label : DeletedReminderTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DeletedReminderTrigger">eupont:DeletedReminderTrigger</a>
    /// </summary>
    let DeletedReminderTrigger = _prefixId.prefix "DeletedReminderTrigger"
    /// <summary>
    ///   <para>rdfs:label : DeletedTimerTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DeletedTimerTrigger">eupont:DeletedTimerTrigger</a>
    /// </summary>
    let DeletedTimerTrigger = _prefixId.prefix "DeletedTimerTrigger"
    /// <summary>
    ///   <para>rdfs:label : DeletedTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DeletedTrigger">eupont:DeletedTrigger</a>
    /// </summary>
    let DeletedTrigger = _prefixId.prefix "DeletedTrigger"
    /// <summary>
    ///   <para>rdfs:label : DeletedWebBookmarkTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DeletedWebBookmarkTrigger">eupont:DeletedWebBookmarkTrigger</a>
    /// </summary>
    let DeletedWebBookmarkTrigger = _prefixId.prefix "DeletedWebBookmarkTrigger"
    /// <summary>
    ///   <para>rdfs:label : Detail</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#Detail">eupont:Detail</a>
    /// </summary>
    let Detail = _prefixId.prefix "Detail"
    /// <summary>
    ///   <para>rdfs:label : DeveloperTool</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DeveloperTool">eupont:DeveloperTool</a>
    /// </summary>
    let DeveloperTool = _prefixId.prefix "DeveloperTool"
    /// <summary>
    ///   <para>rdfs:label : DeviceAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DeviceAction">eupont:DeviceAction</a>
    /// </summary>
    let DeviceAction = _prefixId.prefix "DeviceAction"
    /// <summary>
    ///   <para>rdfs:label : DeviceConnectedTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DeviceConnectedTrigger">eupont:DeviceConnectedTrigger</a>
    /// </summary>
    let DeviceConnectedTrigger = _prefixId.prefix "DeviceConnectedTrigger"

    /// <summary>
    ///   <para>rdfs:label : DeviceConnectivityDisabledTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DeviceConnectivityDisabledTrigger">eupont:DeviceConnectivityDisabledTrigger</a>
    /// </summary>
    let DeviceConnectivityDisabledTrigger =
        _prefixId.prefix "DeviceConnectivityDisabledTrigger"

    /// <summary>
    ///   <para>rdfs:label : DeviceConnectivityEnabledTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DeviceConnectivityEnabledTrigger">eupont:DeviceConnectivityEnabledTrigger</a>
    /// </summary>
    let DeviceConnectivityEnabledTrigger =
        _prefixId.prefix "DeviceConnectivityEnabledTrigger"

    /// <summary>
    ///   <para>rdfs:label : DeviceDisconnectedTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DeviceDisconnectedTrigger">eupont:DeviceDisconnectedTrigger</a>
    /// </summary>
    let DeviceDisconnectedTrigger = _prefixId.prefix "DeviceDisconnectedTrigger"
    /// <summary>
    ///   <para>rdfs:label : DeviceFailureTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DeviceFailureTrigger">eupont:DeviceFailureTrigger</a>
    /// </summary>
    let DeviceFailureTrigger = _prefixId.prefix "DeviceFailureTrigger"
    /// <summary>
    ///   <para>rdfs:label : DeviceLeakTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DeviceLeakTrigger">eupont:DeviceLeakTrigger</a>
    /// </summary>
    let DeviceLeakTrigger = _prefixId.prefix "DeviceLeakTrigger"
    /// <summary>
    ///   <para>rdfs:label : DevicePluggedTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DevicePluggedTrigger">eupont:DevicePluggedTrigger</a>
    /// </summary>
    let DevicePluggedTrigger = _prefixId.prefix "DevicePluggedTrigger"

    /// <summary>
    ///   <para>rdfs:label : DeviceSavingModeDisabledTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DeviceSavingModeDisabledTrigger">eupont:DeviceSavingModeDisabledTrigger</a>
    /// </summary>
    let DeviceSavingModeDisabledTrigger =
        _prefixId.prefix "DeviceSavingModeDisabledTrigger"

    /// <summary>
    ///   <para>rdfs:label : DeviceSavingModeEnabledTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DeviceSavingModeEnabledTrigger">eupont:DeviceSavingModeEnabledTrigger</a>
    /// </summary>
    let DeviceSavingModeEnabledTrigger =
        _prefixId.prefix "DeviceSavingModeEnabledTrigger"

    /// <summary>
    ///   <para>rdfs:label : DeviceService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DeviceService">eupont:DeviceService</a>
    /// </summary>
    let DeviceService = _prefixId.prefix "DeviceService"
    /// <summary>
    ///   <para>rdfs:label : DeviceTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DeviceTrigger">eupont:DeviceTrigger</a>
    /// </summary>
    let DeviceTrigger = _prefixId.prefix "DeviceTrigger"
    /// <summary>
    ///   <para>rdfs:label : DeviceTurnedOffTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DeviceTurnedOffTrigger">eupont:DeviceTurnedOffTrigger</a>
    /// </summary>
    let DeviceTurnedOffTrigger = _prefixId.prefix "DeviceTurnedOffTrigger"
    /// <summary>
    ///   <para>rdfs:label : DeviceTurnedOnTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DeviceTurnedOnTrigger">eupont:DeviceTurnedOnTrigger</a>
    /// </summary>
    let DeviceTurnedOnTrigger = _prefixId.prefix "DeviceTurnedOnTrigger"
    /// <summary>
    ///   <para>rdfs:label : DeviceUnpluggedTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DeviceUnpluggedTrigger">eupont:DeviceUnpluggedTrigger</a>
    /// </summary>
    let DeviceUnpluggedTrigger = _prefixId.prefix "DeviceUnpluggedTrigger"
    /// <summary>
    ///   <para>rdfs:label : DeviceUsageWarningTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DeviceUsageWarningTrigger">eupont:DeviceUsageWarningTrigger</a>
    /// </summary>
    let DeviceUsageWarningTrigger = _prefixId.prefix "DeviceUsageWarningTrigger"

    /// <summary>
    ///   <para>rdfs:label : DisableAirPurifierSystemAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DisableAirPurifierSystemAction">eupont:DisableAirPurifierSystemAction</a>
    /// </summary>
    let DisableAirPurifierSystemAction =
        _prefixId.prefix "DisableAirPurifierSystemAction"

    /// <summary>
    ///   <para>rdfs:label : DisableAirplaneModeAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DisableAirplaneModeAction">eupont:DisableAirplaneModeAction</a>
    /// </summary>
    let DisableAirplaneModeAction = _prefixId.prefix "DisableAirplaneModeAction"

    /// <summary>
    ///   <para>rdfs:label : DisableBluetoothConnectivityAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DisableBluetoothConnectivityAction">eupont:DisableBluetoothConnectivityAction</a>
    /// </summary>
    let DisableBluetoothConnectivityAction =
        _prefixId.prefix "DisableBluetoothConnectivityAction"

    /// <summary>
    ///   <para>rdfs:label : DisableCommand</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DisableCommand">eupont:DisableCommand</a>
    /// </summary>
    let DisableCommand = _prefixId.prefix "DisableCommand"
    /// <summary>
    ///   <para>rdfs:label : DisableCoolingSystemAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DisableCoolingSystemAction">eupont:DisableCoolingSystemAction</a>
    /// </summary>
    let DisableCoolingSystemAction = _prefixId.prefix "DisableCoolingSystemAction"

    /// <summary>
    ///   <para>rdfs:label : DisableDehumidifierSystemAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DisableDehumidifierSystemAction">eupont:DisableDehumidifierSystemAction</a>
    /// </summary>
    let DisableDehumidifierSystemAction =
        _prefixId.prefix "DisableDehumidifierSystemAction"

    /// <summary>
    ///   <para>rdfs:label : DisableDeviceConnectivityAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DisableDeviceConnectivityAction">eupont:DisableDeviceConnectivityAction</a>
    /// </summary>
    let DisableDeviceConnectivityAction =
        _prefixId.prefix "DisableDeviceConnectivityAction"

    /// <summary>
    ///   <para>rdfs:label : DisableDeviceSavingModeAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DisableDeviceSavingModeAction">eupont:DisableDeviceSavingModeAction</a>
    /// </summary>
    let DisableDeviceSavingModeAction = _prefixId.prefix "DisableDeviceSavingModeAction"
    /// <summary>
    ///   <para>rdfs:label : DisableGPSAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DisableGPSAction">eupont:DisableGPSAction</a>
    /// </summary>
    let DisableGPSAction = _prefixId.prefix "DisableGPSAction"
    /// <summary>
    ///   <para>rdfs:label : DisableHeatingSystemAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DisableHeatingSystemAction">eupont:DisableHeatingSystemAction</a>
    /// </summary>
    let DisableHeatingSystemAction = _prefixId.prefix "DisableHeatingSystemAction"
    /// <summary>
    ///   <para>rdfs:label : DisableHumidifierSystemAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DisableHumidifierSystemAction">eupont:DisableHumidifierSystemAction</a>
    /// </summary>
    let DisableHumidifierSystemAction = _prefixId.prefix "DisableHumidifierSystemAction"

    /// <summary>
    ///   <para>rdfs:label : DisableInternetConnectivityAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DisableInternetConnectivityAction">eupont:DisableInternetConnectivityAction</a>
    /// </summary>
    let DisableInternetConnectivityAction =
        _prefixId.prefix "DisableInternetConnectivityAction"

    /// <summary>
    ///   <para>rdfs:label : DisableLightingSystemAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DisableLightingSystemAction">eupont:DisableLightingSystemAction</a>
    /// </summary>
    let DisableLightingSystemAction = _prefixId.prefix "DisableLightingSystemAction"
    /// <summary>
    ///   <para>rdfs:label : DisableNFCConnectivityAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DisableNFCConnectivityAction">eupont:DisableNFCConnectivityAction</a>
    /// </summary>
    let DisableNFCConnectivityAction = _prefixId.prefix "DisableNFCConnectivityAction"
    /// <summary>
    ///   <para>rdfs:label : DisableNightModeAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DisableNightModeAction">eupont:DisableNightModeAction</a>
    /// </summary>
    let DisableNightModeAction = _prefixId.prefix "DisableNightModeAction"
    /// <summary>
    ///   <para>rdfs:label : DisableNotification</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DisableNotification">eupont:DisableNotification</a>
    /// </summary>
    let DisableNotification = _prefixId.prefix "DisableNotification"
    /// <summary>
    ///   <para>rdfs:label : DisableNotificationsAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DisableNotificationsAction">eupont:DisableNotificationsAction</a>
    /// </summary>
    let DisableNotificationsAction = _prefixId.prefix "DisableNotificationsAction"
    /// <summary>
    ///   <para>rdfs:label : DisableScreenRotationAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DisableScreenRotationAction">eupont:DisableScreenRotationAction</a>
    /// </summary>
    let DisableScreenRotationAction = _prefixId.prefix "DisableScreenRotationAction"
    /// <summary>
    ///   <para>rdfs:label : DisableSecuritySystemAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DisableSecuritySystemAction">eupont:DisableSecuritySystemAction</a>
    /// </summary>
    let DisableSecuritySystemAction = _prefixId.prefix "DisableSecuritySystemAction"
    /// <summary>
    ///   <para>rdfs:label : DisableWateringSystemAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DisableWateringSystemAction">eupont:DisableWateringSystemAction</a>
    /// </summary>
    let DisableWateringSystemAction = _prefixId.prefix "DisableWateringSystemAction"
    /// <summary>
    ///   <para>rdfs:label : DisabledAirplaneModeTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DisabledAirplaneModeTrigger">eupont:DisabledAirplaneModeTrigger</a>
    /// </summary>
    let DisabledAirplaneModeTrigger = _prefixId.prefix "DisabledAirplaneModeTrigger"

    /// <summary>
    ///   <para>rdfs:label : DisabledBluetoothConnectivityTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DisabledBluetoothConnectivityTrigger">eupont:DisabledBluetoothConnectivityTrigger</a>
    /// </summary>
    let DisabledBluetoothConnectivityTrigger =
        _prefixId.prefix "DisabledBluetoothConnectivityTrigger"

    /// <summary>
    ///   <para>rdfs:label : DisabledGPSTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DisabledGPSTrigger">eupont:DisabledGPSTrigger</a>
    /// </summary>
    let DisabledGPSTrigger = _prefixId.prefix "DisabledGPSTrigger"

    /// <summary>
    ///   <para>rdfs:label : DisabledInternetConnectivityTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DisabledInternetConnectivityTrigger">eupont:DisabledInternetConnectivityTrigger</a>
    /// </summary>
    let DisabledInternetConnectivityTrigger =
        _prefixId.prefix "DisabledInternetConnectivityTrigger"

    /// <summary>
    ///   <para>rdfs:label : DisabledNFCConnectivityTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DisabledNFCConnectivityTrigger">eupont:DisabledNFCConnectivityTrigger</a>
    /// </summary>
    let DisabledNFCConnectivityTrigger =
        _prefixId.prefix "DisabledNFCConnectivityTrigger"

    /// <summary>
    ///   <para>rdfs:label : DisconnectCommand</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DisconnectCommand">eupont:DisconnectCommand</a>
    /// </summary>
    let DisconnectCommand = _prefixId.prefix "DisconnectCommand"
    /// <summary>
    ///   <para>rdfs:label : DisconnectDeviceAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DisconnectDeviceAction">eupont:DisconnectDeviceAction</a>
    /// </summary>
    let DisconnectDeviceAction = _prefixId.prefix "DisconnectDeviceAction"
    /// <summary>
    ///   <para>rdfs:label : DisconnectFromDeviceAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DisconnectFromDeviceAction">eupont:DisconnectFromDeviceAction</a>
    /// </summary>
    let DisconnectFromDeviceAction = _prefixId.prefix "DisconnectFromDeviceAction"
    /// <summary>
    ///   <para>rdfs:label : DisconnectFromNetworkAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DisconnectFromNetworkAction">eupont:DisconnectFromNetworkAction</a>
    /// </summary>
    let DisconnectFromNetworkAction = _prefixId.prefix "DisconnectFromNetworkAction"
    /// <summary>
    ///   <para>rdfs:label : DisconnectNotification</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DisconnectNotification">eupont:DisconnectNotification</a>
    /// </summary>
    let DisconnectNotification = _prefixId.prefix "DisconnectNotification"
    /// <summary>
    ///   <para>rdfs:label : DisconnectedFromDeviceTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DisconnectedFromDeviceTrigger">eupont:DisconnectedFromDeviceTrigger</a>
    /// </summary>
    let DisconnectedFromDeviceTrigger = _prefixId.prefix "DisconnectedFromDeviceTrigger"

    /// <summary>
    ///   <para>rdfs:label : DisconnectedFromNetworkTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DisconnectedFromNetworkTrigger">eupont:DisconnectedFromNetworkTrigger</a>
    /// </summary>
    let DisconnectedFromNetworkTrigger =
        _prefixId.prefix "DisconnectedFromNetworkTrigger"

    /// <summary>
    ///   <para>rdfs:label : Dishwasher</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#Dishwasher">eupont:Dishwasher</a>
    /// </summary>
    let Dishwasher = _prefixId.prefix "Dishwasher"
    /// <summary>
    ///   <para>rdfs:label : DisplayService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DisplaySerivce">eupont:DisplaySerivce</a>
    /// </summary>
    let DisplaySerivce = _prefixId.prefix "DisplaySerivce"
    /// <summary>
    ///   <para>rdfs:label : DisplayService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DisplyService">eupont:DisplyService</a>
    /// </summary>
    let DisplyService = _prefixId.prefix "DisplyService"
    /// <summary>
    ///   <para>rdfs:label : DiswashingService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DiswashingService">eupont:DiswashingService</a>
    /// </summary>
    let DiswashingService = _prefixId.prefix "DiswashingService"
    /// <summary>
    ///   <para>rdfs:label : Dryer</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#Dryer">eupont:Dryer</a>
    /// </summary>
    let Dryer = _prefixId.prefix "Dryer"
    /// <summary>
    ///   <para>rdfs:label : DryingService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DryingService">eupont:DryingService</a>
    /// </summary>
    let DryingService = _prefixId.prefix "DryingService"
    /// <summary>
    ///   <para>rdfs:label : DVDPlayer</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#DvdPlayer">eupont:DvdPlayer</a>
    /// </summary>
    let DvdPlayer = _prefixId.prefix "DvdPlayer"
    /// <summary>
    ///   <para>rdfs:label : EUDPlatform</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#EUDPlatform">eupont:EUDPlatform</a>
    /// </summary>
    let EUDPlatform = _prefixId.prefix "EUDPlatform"
    /// <summary>
    ///   <para>rdfs:label : EcommerceService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#EcommerceService">eupont:EcommerceService</a>
    /// </summary>
    let EcommerceService = _prefixId.prefix "EcommerceService"
    /// <summary>
    ///   <para>rdfs:label : ECommerceWebsite</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#EcommerceWebSite">eupont:EcommerceWebSite</a>
    /// </summary>
    let EcommerceWebSite = _prefixId.prefix "EcommerceWebSite"
    /// <summary>
    ///   <para>rdfs:label : EMail</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#EmailTool">eupont:EmailTool</a>
    /// </summary>
    let EmailTool = _prefixId.prefix "EmailTool"
    /// <summary>
    ///   <para>rdfs:label : EnableAirPurifierSystemAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#EnableAirPurifierSystemAction">eupont:EnableAirPurifierSystemAction</a>
    /// </summary>
    let EnableAirPurifierSystemAction = _prefixId.prefix "EnableAirPurifierSystemAction"
    /// <summary>
    ///   <para>rdfs:label : EnableAirplaneModeAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#EnableAirplaneModeAction">eupont:EnableAirplaneModeAction</a>
    /// </summary>
    let EnableAirplaneModeAction = _prefixId.prefix "EnableAirplaneModeAction"

    /// <summary>
    ///   <para>rdfs:label : EnableBluetoothConnectivityAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#EnableBluetoothConnectivityAction">eupont:EnableBluetoothConnectivityAction</a>
    /// </summary>
    let EnableBluetoothConnectivityAction =
        _prefixId.prefix "EnableBluetoothConnectivityAction"

    /// <summary>
    ///   <para>rdfs:label : EnableCommand</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#EnableCommand">eupont:EnableCommand</a>
    /// </summary>
    let EnableCommand = _prefixId.prefix "EnableCommand"
    /// <summary>
    ///   <para>rdfs:label : EnableCoolingSystemAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#EnableCoolingSystemAction">eupont:EnableCoolingSystemAction</a>
    /// </summary>
    let EnableCoolingSystemAction = _prefixId.prefix "EnableCoolingSystemAction"

    /// <summary>
    ///   <para>rdfs:label : EnableDehumidifierSystemAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#EnableDehumidifierSystemAction">eupont:EnableDehumidifierSystemAction</a>
    /// </summary>
    let EnableDehumidifierSystemAction =
        _prefixId.prefix "EnableDehumidifierSystemAction"

    /// <summary>
    ///   <para>rdfs:label : EnableDeviceConnectivityAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#EnableDeviceConnectivityAction">eupont:EnableDeviceConnectivityAction</a>
    /// </summary>
    let EnableDeviceConnectivityAction =
        _prefixId.prefix "EnableDeviceConnectivityAction"

    /// <summary>
    ///   <para>rdfs:label : EnableDeviceSavingModeAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#EnableDeviceSavingModeAction">eupont:EnableDeviceSavingModeAction</a>
    /// </summary>
    let EnableDeviceSavingModeAction = _prefixId.prefix "EnableDeviceSavingModeAction"
    /// <summary>
    ///   <para>rdfs:label : EnableGPSAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#EnableGPSAction">eupont:EnableGPSAction</a>
    /// </summary>
    let EnableGPSAction = _prefixId.prefix "EnableGPSAction"
    /// <summary>
    ///   <para>rdfs:label : EnableHeatingSystemAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#EnableHeatingSystemAction">eupont:EnableHeatingSystemAction</a>
    /// </summary>
    let EnableHeatingSystemAction = _prefixId.prefix "EnableHeatingSystemAction"
    /// <summary>
    ///   <para>rdfs:label : EnableHumidifierSystemAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#EnableHumidifierSystemAction">eupont:EnableHumidifierSystemAction</a>
    /// </summary>
    let EnableHumidifierSystemAction = _prefixId.prefix "EnableHumidifierSystemAction"

    /// <summary>
    ///   <para>rdfs:label : EnableInternetConnectivityAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#EnableInternetConnectivityAction">eupont:EnableInternetConnectivityAction</a>
    /// </summary>
    let EnableInternetConnectivityAction =
        _prefixId.prefix "EnableInternetConnectivityAction"

    /// <summary>
    ///   <para>rdfs:label : EnableLightingSystemAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#EnableLightingSystemAction">eupont:EnableLightingSystemAction</a>
    /// </summary>
    let EnableLightingSystemAction = _prefixId.prefix "EnableLightingSystemAction"
    /// <summary>
    ///   <para>rdfs:label : EnableNGFCConnectivityAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#EnableNFCConnctivityAction">eupont:EnableNFCConnctivityAction</a>
    /// </summary>
    let EnableNFCConnctivityAction = _prefixId.prefix "EnableNFCConnctivityAction"
    /// <summary>
    ///   <para>rdfs:label : EnableNightModeAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#EnableNightModeAction">eupont:EnableNightModeAction</a>
    /// </summary>
    let EnableNightModeAction = _prefixId.prefix "EnableNightModeAction"
    /// <summary>
    ///   <para>rdfs:label : EnableNotification</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#EnableNotification">eupont:EnableNotification</a>
    /// </summary>
    let EnableNotification = _prefixId.prefix "EnableNotification"
    /// <summary>
    ///   <para>rdfs:label : EnableNotificationsAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#EnableNotificationsAction">eupont:EnableNotificationsAction</a>
    /// </summary>
    let EnableNotificationsAction = _prefixId.prefix "EnableNotificationsAction"
    /// <summary>
    ///   <para>rdfs:label : EnableScreenRotationAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#EnableScreenRotationAction">eupont:EnableScreenRotationAction</a>
    /// </summary>
    let EnableScreenRotationAction = _prefixId.prefix "EnableScreenRotationAction"
    /// <summary>
    ///   <para>rdfs:label : EnableSecuritySystemAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#EnableSecuritySystemAction">eupont:EnableSecuritySystemAction</a>
    /// </summary>
    let EnableSecuritySystemAction = _prefixId.prefix "EnableSecuritySystemAction"
    /// <summary>
    ///   <para>rdfs:label : EnableSpeakerphoneAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#EnableSpeakerphoneAction">eupont:EnableSpeakerphoneAction</a>
    /// </summary>
    let EnableSpeakerphoneAction = _prefixId.prefix "EnableSpeakerphoneAction"
    /// <summary>
    ///   <para>rdfs:label : EnableWateringSystemAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#EnableWateringSystemAction">eupont:EnableWateringSystemAction</a>
    /// </summary>
    let EnableWateringSystemAction = _prefixId.prefix "EnableWateringSystemAction"
    /// <summary>
    ///   <para>rdfs:label : EnabledAirplaneModeTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#EnabledAirplaneModeTrigger">eupont:EnabledAirplaneModeTrigger</a>
    /// </summary>
    let EnabledAirplaneModeTrigger = _prefixId.prefix "EnabledAirplaneModeTrigger"

    /// <summary>
    ///   <para>rdfs:label : EnabledBluetoothConnectivityTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#EnabledBluetoothConnectivityTrigger">eupont:EnabledBluetoothConnectivityTrigger</a>
    /// </summary>
    let EnabledBluetoothConnectivityTrigger =
        _prefixId.prefix "EnabledBluetoothConnectivityTrigger"

    /// <summary>
    ///   <para>rdfs:label : EnabledGPSTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#EnabledGPSTrigger">eupont:EnabledGPSTrigger</a>
    /// </summary>
    let EnabledGPSTrigger = _prefixId.prefix "EnabledGPSTrigger"

    /// <summary>
    ///   <para>rdfs:label : EnabledInternetConnectivityTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#EnabledInternetConnectivityTrigger">eupont:EnabledInternetConnectivityTrigger</a>
    /// </summary>
    let EnabledInternetConnectivityTrigger =
        _prefixId.prefix "EnabledInternetConnectivityTrigger"

    /// <summary>
    ///   <para>rdfs:label : EnabledNFCConnectivityTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#EnabledNFCConnectivityTrigger">eupont:EnabledNFCConnectivityTrigger</a>
    /// </summary>
    let EnabledNFCConnectivityTrigger = _prefixId.prefix "EnabledNFCConnectivityTrigger"
    /// <summary>
    ///   <para>rdfs:label : EndCallAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#EndCallAction">eupont:EndCallAction</a>
    /// </summary>
    let EndCallAction = _prefixId.prefix "EndCallAction"
    /// <summary>
    ///   <para>rdfs:label : EnhancedConnectivityTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#EnhancedConnectivityTrigger">eupont:EnhancedConnectivityTrigger</a>
    /// </summary>
    let EnhancedConnectivityTrigger = _prefixId.prefix "EnhancedConnectivityTrigger"
    /// <summary>
    ///   <para>rdfs:label : EnterNotification</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#EnterNotification">eupont:EnterNotification</a>
    /// </summary>
    let EnterNotification = _prefixId.prefix "EnterNotification"
    /// <summary>
    ///   <para>rdfs:label : EnterTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#EnterTrigger">eupont:EnterTrigger</a>
    /// </summary>
    let EnterTrigger = _prefixId.prefix "EnterTrigger"
    /// <summary>
    ///   <para>rdfs:label : EnvironmentAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#EnvironmentAction">eupont:EnvironmentAction</a>
    /// </summary>
    let EnvironmentAction = _prefixId.prefix "EnvironmentAction"

    /// <summary>
    ///   <para>rdfs:label : EnvironmentConditionDecreasedTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#EnvironmentConditionDecreasedTrigger">eupont:EnvironmentConditionDecreasedTrigger</a>
    /// </summary>
    let EnvironmentConditionDecreasedTrigger =
        _prefixId.prefix "EnvironmentConditionDecreasedTrigger"

    /// <summary>
    ///   <para>rdfs:label : EnvironmentConditionIncreasedTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#EnvironmentConditionIncreasedTrigger">eupont:EnvironmentConditionIncreasedTrigger</a>
    /// </summary>
    let EnvironmentConditionIncreasedTrigger =
        _prefixId.prefix "EnvironmentConditionIncreasedTrigger"

    /// <summary>
    ///   <para>rdfs:label : EnvironmentTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#EnvironmentTrigger">eupont:EnvironmentTrigger</a>
    /// </summary>
    let EnvironmentTrigger = _prefixId.prefix "EnvironmentTrigger"
    /// <summary>
    ///   <para>rdfs:label : EveryDayTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#EveryDayTrigger">eupont:EveryDayTrigger</a>
    /// </summary>
    let EveryDayTrigger = _prefixId.prefix "EveryDayTrigger"
    /// <summary>
    ///   <para>rdfs:label : EveryHourTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#EveryHourTrigger">eupont:EveryHourTrigger</a>
    /// </summary>
    let EveryHourTrigger = _prefixId.prefix "EveryHourTrigger"
    /// <summary>
    ///   <para>rdfs:label : EveryMonthTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#EveryMonthTrigger">eupont:EveryMonthTrigger</a>
    /// </summary>
    let EveryMonthTrigger = _prefixId.prefix "EveryMonthTrigger"
    /// <summary>
    ///   <para>rdfs:label : EveryTimeTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#EveryTimeTrigger">eupont:EveryTimeTrigger</a>
    /// </summary>
    let EveryTimeTrigger = _prefixId.prefix "EveryTimeTrigger"
    /// <summary>
    ///   <para>rdfs:label : EveryWeekTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#EveryWeekTrigger">eupont:EveryWeekTrigger</a>
    /// </summary>
    let EveryWeekTrigger = _prefixId.prefix "EveryWeekTrigger"
    /// <summary>
    ///   <para>rdfs:label : EveryYearTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#EveryYearTrigger">eupont:EveryYearTrigger</a>
    /// </summary>
    let EveryYearTrigger = _prefixId.prefix "EveryYearTrigger"
    /// <summary>
    ///   <para>rdfs:label : ExitNotification</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#ExitNotification">eupont:ExitNotification</a>
    /// </summary>
    let ExitNotification = _prefixId.prefix "ExitNotification"
    /// <summary>
    ///   <para>rdfs:label : ExitTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#ExitTrigger">eupont:ExitTrigger</a>
    /// </summary>
    let ExitTrigger = _prefixId.prefix "ExitTrigger"
    /// <summary>
    ///   <para>rdfs:label : FailureDetectionService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#FailureDetectionService">eupont:FailureDetectionService</a>
    /// </summary>
    let FailureDetectionService = _prefixId.prefix "FailureDetectionService"
    /// <summary>
    ///   <para>rdfs:label : Family</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#Family">eupont:Family</a>
    /// </summary>
    let Family = _prefixId.prefix "Family"
    /// <summary>
    ///   <para>rdfs:label : Fax</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#Fax">eupont:Fax</a>
    /// </summary>
    let Fax = _prefixId.prefix "Fax"
    /// <summary>
    ///   <para>rdfs:label : FileService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#FileService">eupont:FileService</a>
    /// </summary>
    let FileService = _prefixId.prefix "FileService"
    /// <summary>
    ///   <para>rdfs:label : FocusTrackingService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#FocusTrackingService">eupont:FocusTrackingService</a>
    /// </summary>
    let FocusTrackingService = _prefixId.prefix "FocusTrackingService"
    /// <summary>
    ///   <para>rdfs:label : FrameService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#FrameService">eupont:FrameService</a>
    /// </summary>
    let FrameService = _prefixId.prefix "FrameService"
    /// <summary>
    ///   <para>rdfs:label : Fridge</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#Fridge">eupont:Fridge</a>
    /// </summary>
    let Fridge = _prefixId.prefix "Fridge"
    /// <summary>
    ///   <para>rdfs:label : Friend</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#Friend">eupont:Friend</a>
    /// </summary>
    let Friend = _prefixId.prefix "Friend"
    /// <summary>
    ///   <para>rdfs:label : GPSEnterAreaTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#GPSEnterAreaTrigger">eupont:GPSEnterAreaTrigger</a>
    /// </summary>
    let GPSEnterAreaTrigger = _prefixId.prefix "GPSEnterAreaTrigger"
    /// <summary>
    ///   <para>rdfs:label : GPSExitAreaTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#GPSExitAreaTrigger">eupont:GPSExitAreaTrigger</a>
    /// </summary>
    let GPSExitAreaTrigger = _prefixId.prefix "GPSExitAreaTrigger"
    /// <summary>
    ///   <para>rdfs:label : GPSService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#GPSService">eupont:GPSService</a>
    /// </summary>
    let GPSService = _prefixId.prefix "GPSService"
    /// <summary>
    ///   <para>rdfs:label : GameService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#GameService">eupont:GameService</a>
    /// </summary>
    let GameService = _prefixId.prefix "GameService"
    /// <summary>
    ///   <para>rdfs:label : GeographicalArea</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#GeographicalArea">eupont:GeographicalArea</a>
    /// </summary>
    let GeographicalArea = _prefixId.prefix "GeographicalArea"
    /// <summary>
    ///   <para>rdfs:label : GetAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#GetAction">eupont:GetAction</a>
    /// </summary>
    let GetAction = _prefixId.prefix "GetAction"
    /// <summary>
    ///   <para>rdfs:label : GroceryShoppingService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#GroceryShoppingService">eupont:GroceryShoppingService</a>
    /// </summary>
    let GroceryShoppingService = _prefixId.prefix "GroceryShoppingService"
    /// <summary>
    ///   <para>rdfs:label : HealthInformationService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#HealthInformationService">eupont:HealthInformationService</a>
    /// </summary>
    let HealthInformationService = _prefixId.prefix "HealthInformationService"
    /// <summary>
    ///   <para>rdfs:label : HealthTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#HealthTrigger">eupont:HealthTrigger</a>
    /// </summary>
    let HealthTrigger = _prefixId.prefix "HealthTrigger"
    /// <summary>
    ///   <para>rdfs:label : HealthyActivityTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#HealthyActivityTrigger">eupont:HealthyActivityTrigger</a>
    /// </summary>
    let HealthyActivityTrigger = _prefixId.prefix "HealthyActivityTrigger"
    /// <summary>
    ///   <para>rdfs:label : HealthyGoalNotReachedTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#HealthyGoalNotReachedTrigger">eupont:HealthyGoalNotReachedTrigger</a>
    /// </summary>
    let HealthyGoalNotReachedTrigger = _prefixId.prefix "HealthyGoalNotReachedTrigger"
    /// <summary>
    ///   <para>rdfs:label : HealthyGoalReachedTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#HealthyGoalReachedTrigger">eupont:HealthyGoalReachedTrigger</a>
    /// </summary>
    let HealthyGoalReachedTrigger = _prefixId.prefix "HealthyGoalReachedTrigger"
    /// <summary>
    ///   <para>rdfs:label : Heater</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#Heater">eupont:Heater</a>
    /// </summary>
    let Heater = _prefixId.prefix "Heater"
    /// <summary>
    ///   <para>rdfs:label : HeatingService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#HeatingService">eupont:HeatingService</a>
    /// </summary>
    let HeatingService = _prefixId.prefix "HeatingService"
    /// <summary>
    ///   <para>rdfs:label : HeatingSystemDisabledTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#HeatingSystemDisabledTrigger">eupont:HeatingSystemDisabledTrigger</a>
    /// </summary>
    let HeatingSystemDisabledTrigger = _prefixId.prefix "HeatingSystemDisabledTrigger"
    /// <summary>
    ///   <para>rdfs:label : HeatingSystemEnabledTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#HeatingSystemEnabledTrigger">eupont:HeatingSystemEnabledTrigger</a>
    /// </summary>
    let HeatingSystemEnabledTrigger = _prefixId.prefix "HeatingSystemEnabledTrigger"
    /// <summary>
    ///   <para>rdfs:label : HiFi</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#HiFi">eupont:HiFi</a>
    /// </summary>
    let HiFi = _prefixId.prefix "HiFi"

    /// <summary>
    ///   <para>rdfs:label : HighSensedDeviceConsumptionTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#HighSensedDeviceConsumptionTrigger">eupont:HighSensedDeviceConsumptionTrigger</a>
    /// </summary>
    let HighSensedDeviceConsumptionTrigger =
        _prefixId.prefix "HighSensedDeviceConsumptionTrigger"

    /// <summary>
    ///   <para>rdfs:label : Hub</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#Hub">eupont:Hub</a>
    /// </summary>
    let Hub = _prefixId.prefix "Hub"
    /// <summary>
    ///   <para>rdfs:label : Humidifier</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#Humidifier">eupont:Humidifier</a>
    /// </summary>
    let Humidifier = _prefixId.prefix "Humidifier"
    /// <summary>
    ///   <para>rdfs:label : HumidifierService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#HumidifierService">eupont:HumidifierService</a>
    /// </summary>
    let HumidifierService = _prefixId.prefix "HumidifierService"
    /// <summary>
    ///   <para>rdfs:label : HumiditySetToTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#HumiditySetToTrigger">eupont:HumiditySetToTrigger</a>
    /// </summary>
    let HumiditySetToTrigger = _prefixId.prefix "HumiditySetToTrigger"

    /// <summary>
    ///   <para>rdfs:label : ImproveConsumptionConditionAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#ImproveConsumptionConditionAction">eupont:ImproveConsumptionConditionAction</a>
    /// </summary>
    let ImproveConsumptionConditionAction =
        _prefixId.prefix "ImproveConsumptionConditionAction"

    /// <summary>
    ///   <para>rdfs:label : ImproveDeviceConditionAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#ImproveDeviceConditionAction">eupont:ImproveDeviceConditionAction</a>
    /// </summary>
    let ImproveDeviceConditionAction = _prefixId.prefix "ImproveDeviceConditionAction"

    /// <summary>
    ///   <para>rdfs:label : ImproveLightingConditionAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#ImproveLightingConditionAction">eupont:ImproveLightingConditionAction</a>
    /// </summary>
    let ImproveLightingConditionAction =
        _prefixId.prefix "ImproveLightingConditionAction"

    /// <summary>
    ///   <para>rdfs:label : ImproveUsabilityConditionAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#ImproveUsabilityConditionAction">eupont:ImproveUsabilityConditionAction</a>
    /// </summary>
    let ImproveUsabilityConditionAction =
        _prefixId.prefix "ImproveUsabilityConditionAction"

    /// <summary>
    ///   <para>rdfs:label : ImprovedConsumptionConditionTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#ImprovedConsumptionConditionTrigger">eupont:ImprovedConsumptionConditionTrigger</a>
    /// </summary>
    let ImprovedConsumptionConditionTrigger =
        _prefixId.prefix "ImprovedConsumptionConditionTrigger"

    /// <summary>
    ///   <para>rdfs:label : ImprovedDeviceConditionTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#ImprovedDeviceConditionTrigger">eupont:ImprovedDeviceConditionTrigger</a>
    /// </summary>
    let ImprovedDeviceConditionTrigger =
        _prefixId.prefix "ImprovedDeviceConditionTrigger"

    /// <summary>
    ///   <para>rdfs:label : ImprovedHealthyParameterTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#ImprovedHealthyParameterTrigger">eupont:ImprovedHealthyParameterTrigger</a>
    /// </summary>
    let ImprovedHealthyParameterTrigger =
        _prefixId.prefix "ImprovedHealthyParameterTrigger"

    /// <summary>
    ///   <para>rdfs:label : ImprovedLightingConditionTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#ImprovedLightingConditionTrigger">eupont:ImprovedLightingConditionTrigger</a>
    /// </summary>
    let ImprovedLightingConditionTrigger =
        _prefixId.prefix "ImprovedLightingConditionTrigger"

    /// <summary>
    ///   <para>rdfs:label : ImprovedUsabilityConditionTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#ImprovedUsabilityConditionTrigger">eupont:ImprovedUsabilityConditionTrigger</a>
    /// </summary>
    let ImprovedUsabilityConditionTrigger =
        _prefixId.prefix "ImprovedUsabilityConditionTrigger"

    /// <summary>
    ///   <para>rdfs:label : IncreaseAirQualityAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#IncreaseAirQualityAction">eupont:IncreaseAirQualityAction</a>
    /// </summary>
    let IncreaseAirQualityAction = _prefixId.prefix "IncreaseAirQualityAction"
    /// <summary>
    ///   <para>rdfs:label : IncreaseConnectivityAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#IncreaseConnectivityAction">eupont:IncreaseConnectivityAction</a>
    /// </summary>
    let IncreaseConnectivityAction = _prefixId.prefix "IncreaseConnectivityAction"

    /// <summary>
    ///   <para>rdfs:label : IncreaseEnvironmentConditionAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#IncreaseEnvironmentConditionAction">eupont:IncreaseEnvironmentConditionAction</a>
    /// </summary>
    let IncreaseEnvironmentConditionAction =
        _prefixId.prefix "IncreaseEnvironmentConditionAction"

    /// <summary>
    ///   <para>rdfs:label : IncreaseHumidityAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#IncreaseHumidityAction">eupont:IncreaseHumidityAction</a>
    /// </summary>
    let IncreaseHumidityAction = _prefixId.prefix "IncreaseHumidityAction"
    /// <summary>
    ///   <para>rdfs:label : IncreaseLightingAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#IncreaseLightingAction">eupont:IncreaseLightingAction</a>
    /// </summary>
    let IncreaseLightingAction = _prefixId.prefix "IncreaseLightingAction"
    /// <summary>
    ///   <para>rdfs:label : IncreaseSecurityAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#IncreaseSecurityAction">eupont:IncreaseSecurityAction</a>
    /// </summary>
    let IncreaseSecurityAction = _prefixId.prefix "IncreaseSecurityAction"
    /// <summary>
    ///   <para>rdfs:label : IncreaseTemperatureAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#IncreaseTemperatureAction">eupont:IncreaseTemperatureAction</a>
    /// </summary>
    let IncreaseTemperatureAction = _prefixId.prefix "IncreaseTemperatureAction"

    /// <summary>
    ///   <para>rdfs:label : IncreaseUserConnectivityAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#IncreaseUserConnectivityAction">eupont:IncreaseUserConnectivityAction</a>
    /// </summary>
    let IncreaseUserConnectivityAction =
        _prefixId.prefix "IncreaseUserConnectivityAction"

    /// <summary>
    ///   <para>rdfs:label : IncreaseVolumeAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#IncreaseVolumeAction">eupont:IncreaseVolumeAction</a>
    /// </summary>
    let IncreaseVolumeAction = _prefixId.prefix "IncreaseVolumeAction"
    /// <summary>
    ///   <para>rdfs:label : IncreasedAirPressureTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#IncreasedAirPressureTrigger">eupont:IncreasedAirPressureTrigger</a>
    /// </summary>
    let IncreasedAirPressureTrigger = _prefixId.prefix "IncreasedAirPressureTrigger"
    /// <summary>
    ///   <para>rdfs:label : IncreasedAirQualityTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#IncreasedAirQualityTrigger">eupont:IncreasedAirQualityTrigger</a>
    /// </summary>
    let IncreasedAirQualityTrigger = _prefixId.prefix "IncreasedAirQualityTrigger"

    /// <summary>
    ///   <para>rdfs:label : IncreasedHealthConditionTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#IncreasedHealthConditionTrigger">eupont:IncreasedHealthConditionTrigger</a>
    /// </summary>
    let IncreasedHealthConditionTrigger =
        _prefixId.prefix "IncreasedHealthConditionTrigger"

    /// <summary>
    ///   <para>rdfs:label : IncreasedHumidityTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#IncreasedHumidityTrigger">eupont:IncreasedHumidityTrigger</a>
    /// </summary>
    let IncreasedHumidityTrigger = _prefixId.prefix "IncreasedHumidityTrigger"
    /// <summary>
    ///   <para>rdfs:label : IncreasedLightingTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#IncreasedLightingTrigger">eupont:IncreasedLightingTrigger</a>
    /// </summary>
    let IncreasedLightingTrigger = _prefixId.prefix "IncreasedLightingTrigger"
    /// <summary>
    ///   <para>rdfs:label : IncreasedNoiseLevelTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#IncreasedNoiseLevelTrigger">eupont:IncreasedNoiseLevelTrigger</a>
    /// </summary>
    let IncreasedNoiseLevelTrigger = _prefixId.prefix "IncreasedNoiseLevelTrigger"
    /// <summary>
    ///   <para>rdfs:label : IncreasedSecurityTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#IncreasedSecurityTrigger">eupont:IncreasedSecurityTrigger</a>
    /// </summary>
    let IncreasedSecurityTrigger = _prefixId.prefix "IncreasedSecurityTrigger"
    /// <summary>
    ///   <para>rdfs:label : IncreasedTemperatureTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#IncreasedTemperatureTrigger">eupont:IncreasedTemperatureTrigger</a>
    /// </summary>
    let IncreasedTemperatureTrigger = _prefixId.prefix "IncreasedTemperatureTrigger"

    /// <summary>
    ///   <para>rdfs:label : IncreasedWeatherConditionTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#IncreasedWeatherConditionTrigger">eupont:IncreasedWeatherConditionTrigger</a>
    /// </summary>
    let IncreasedWeatherConditionTrigger =
        _prefixId.prefix "IncreasedWeatherConditionTrigger"

    /// <summary>
    ///   <para>rdfs:label : InformationAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#InformationAction">eupont:InformationAction</a>
    /// </summary>
    let InformationAction = _prefixId.prefix "InformationAction"
    /// <summary>
    ///   <para>rdfs:label : InformationService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#InformationService">eupont:InformationService</a>
    /// </summary>
    let InformationService = _prefixId.prefix "InformationService"
    /// <summary>
    ///   <para>rdfs:label : InformationTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#InformationTrigger">eupont:InformationTrigger</a>
    /// </summary>
    let InformationTrigger = _prefixId.prefix "InformationTrigger"
    /// <summary>
    ///   <para>rdfs:label : InformationWebsite</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#InformationWebSite">eupont:InformationWebSite</a>
    /// </summary>
    let InformationWebSite = _prefixId.prefix "InformationWebSite"
    /// <summary>
    ///   <para>rdfs:label : InstantiatedAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#InstantiatedAction">eupont:InstantiatedAction</a>
    /// </summary>
    let InstantiatedAction = _prefixId.prefix "InstantiatedAction"
    /// <summary>
    ///   <para>rdfs:label : InstantiatedDetail</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#InstantiatedDetail">eupont:InstantiatedDetail</a>
    /// </summary>
    let InstantiatedDetail = _prefixId.prefix "InstantiatedDetail"
    /// <summary>
    ///   <para>rdfs:label : InstantiatedTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#InstantiatedTrigger">eupont:InstantiatedTrigger</a>
    /// </summary>
    let InstantiatedTrigger = _prefixId.prefix "InstantiatedTrigger"
    /// <summary>
    ///   <para>rdfs:label : InteractionService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#InteractionService">eupont:InteractionService</a>
    /// </summary>
    let InteractionService = _prefixId.prefix "InteractionService"
    /// <summary>
    ///   <para>rdfs:label : IoTEntity</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#IoTEntity">eupont:IoTEntity</a>
    /// </summary>
    let IoTEntity = _prefixId.prefix "IoTEntity"
    /// <summary>
    ///   <para>rdfs:label : Lamp</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#Lamp">eupont:Lamp</a>
    /// </summary>
    let Lamp = _prefixId.prefix "Lamp"
    /// <summary>
    ///   <para>rdfs:label : Laptop</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#Laptop">eupont:Laptop</a>
    /// </summary>
    let Laptop = _prefixId.prefix "Laptop"
    /// <summary>
    ///   <para>rdfs:label : LeakDetectionService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#LeakDetectionService">eupont:LeakDetectionService</a>
    /// </summary>
    let LeakDetectionService = _prefixId.prefix "LeakDetectionService"
    /// <summary>
    ///   <para>rdfs:label : LightingService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#LightingService">eupont:LightingService</a>
    /// </summary>
    let LightingService = _prefixId.prefix "LightingService"
    /// <summary>
    ///   <para>rdfs:label : LightingSystemDisabledTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#LightingSystemDisabledTrigger">eupont:LightingSystemDisabledTrigger</a>
    /// </summary>
    let LightingSystemDisabledTrigger = _prefixId.prefix "LightingSystemDisabledTrigger"
    /// <summary>
    ///   <para>rdfs:label : LightingSystemEnabledTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#LightingSystemEnabledTrigger">eupont:LightingSystemEnabledTrigger</a>
    /// </summary>
    let LightingSystemEnabledTrigger = _prefixId.prefix "LightingSystemEnabledTrigger"
    /// <summary>
    ///   <para>rdfs:label : LikeService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#LikeService">eupont:LikeService</a>
    /// </summary>
    let LikeService = _prefixId.prefix "LikeService"
    /// <summary>
    ///   <para>rdfs:label : Location</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#Location">eupont:Location</a>
    /// </summary>
    let Location = _prefixId.prefix "Location"
    /// <summary>
    ///   <para>rdfs:label : LowPowerTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#LowPowerTrigger">eupont:LowPowerTrigger</a>
    /// </summary>
    let LowPowerTrigger = _prefixId.prefix "LowPowerTrigger"

    /// <summary>
    ///   <para>rdfs:label : MeasureAboveThresholdNotification</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#MeasureAboveThresholdNotification">eupont:MeasureAboveThresholdNotification</a>
    /// </summary>
    let MeasureAboveThresholdNotification =
        _prefixId.prefix "MeasureAboveThresholdNotification"

    /// <summary>
    ///   <para>rdfs:label : MeasureAvailableNotification</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#MeasureAvailableNotification">eupont:MeasureAvailableNotification</a>
    /// </summary>
    let MeasureAvailableNotification = _prefixId.prefix "MeasureAvailableNotification"

    /// <summary>
    ///   <para>rdfs:label : MeasureBelowThresholdNotification</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#MeasureBelowThresholdNotification">eupont:MeasureBelowThresholdNotification</a>
    /// </summary>
    let MeasureBelowThresholdNotification =
        _prefixId.prefix "MeasureBelowThresholdNotification"

    /// <summary>
    ///   <para>rdfs:label : MediaInformationService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#MediaInformationService">eupont:MediaInformationService</a>
    /// </summary>
    let MediaInformationService = _prefixId.prefix "MediaInformationService"
    /// <summary>
    ///   <para>rdfs:label : MediaService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#MediaService">eupont:MediaService</a>
    /// </summary>
    let MediaService = _prefixId.prefix "MediaService"
    /// <summary>
    ///   <para>rdfs:label : MediaTool</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#MediaTool">eupont:MediaTool</a>
    /// </summary>
    let MediaTool = _prefixId.prefix "MediaTool"
    /// <summary>
    ///   <para>rdfs:label : MessageService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#MessageService">eupont:MessageService</a>
    /// </summary>
    let MessageService = _prefixId.prefix "MessageService"
    /// <summary>
    ///   <para>rdfs:label : MobileDevice</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#MobileDevice">eupont:MobileDevice</a>
    /// </summary>
    let MobileDevice = _prefixId.prefix "MobileDevice"
    /// <summary>
    ///   <para>rdfs:label : MoveAppAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#MoveAppAction">eupont:MoveAppAction</a>
    /// </summary>
    let MoveAppAction = _prefixId.prefix "MoveAppAction"
    /// <summary>
    ///   <para>rdfs:label : MoveOnVehicleTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#MoveOnVehicleTrigger">eupont:MoveOnVehicleTrigger</a>
    /// </summary>
    let MoveOnVehicleTrigger = _prefixId.prefix "MoveOnVehicleTrigger"
    /// <summary>
    ///   <para>rdfs:label : MovingTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#MovingTrigger">eupont:MovingTrigger</a>
    /// </summary>
    let MovingTrigger = _prefixId.prefix "MovingTrigger"
    /// <summary>
    ///   <para>rdfs:label : MusicPlatform</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#MusicPlatform">eupont:MusicPlatform</a>
    /// </summary>
    let MusicPlatform = _prefixId.prefix "MusicPlatform"
    /// <summary>
    ///   <para>rdfs:label : MusicService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#MusicService">eupont:MusicService</a>
    /// </summary>
    let MusicService = _prefixId.prefix "MusicService"
    /// <summary>
    ///   <para>rdfs:label : MuteCallAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#MuteCallAction">eupont:MuteCallAction</a>
    /// </summary>
    let MuteCallAction = _prefixId.prefix "MuteCallAction"
    /// <summary>
    ///   <para>rdfs:label : NFCService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#NFCService">eupont:NFCService</a>
    /// </summary>
    let NFCService = _prefixId.prefix "NFCService"
    /// <summary>
    ///   <para>rdfs:label : NetworkService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#NetworkService">eupont:NetworkService</a>
    /// </summary>
    let NetworkService = _prefixId.prefix "NetworkService"
    /// <summary>
    ///   <para>rdfs:label : NewCommand</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#NewCommand">eupont:NewCommand</a>
    /// </summary>
    let NewCommand = _prefixId.prefix "NewCommand"
    /// <summary>
    ///   <para>rdfs:label : NewNotification</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#NewNotification">eupont:NewNotification</a>
    /// </summary>
    let NewNotification = _prefixId.prefix "NewNotification"
    /// <summary>
    ///   <para>rdfs:label : NewsService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#NewsService">eupont:NewsService</a>
    /// </summary>
    let NewsService = _prefixId.prefix "NewsService"
    /// <summary>
    ///   <para>rdfs:label : NewsTool</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#NewsTool">eupont:NewsTool</a>
    /// </summary>
    let NewsTool = _prefixId.prefix "NewsTool"
    /// <summary>
    ///   <para>rdfs:label : NewsWebsite</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#NewsWebSite">eupont:NewsWebSite</a>
    /// </summary>
    let NewsWebSite = _prefixId.prefix "NewsWebSite"
    /// <summary>
    ///   <para>rdfs:label : NightModeDisabledTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#NightModeDisabledTrigger">eupont:NightModeDisabledTrigger</a>
    /// </summary>
    let NightModeDisabledTrigger = _prefixId.prefix "NightModeDisabledTrigger"
    /// <summary>
    ///   <para>rdfs:label : NightModeEnabledTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#NightModeEnabledTrigger">eupont:NightModeEnabledTrigger</a>
    /// </summary>
    let NightModeEnabledTrigger = _prefixId.prefix "NightModeEnabledTrigger"
    /// <summary>
    ///   <para>rdfs:label : NoiseService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#NoiseService">eupont:NoiseService</a>
    /// </summary>
    let NoiseService = _prefixId.prefix "NoiseService"
    /// <summary>
    ///   <para>rdfs:label : Notes</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#NoteTool">eupont:NoteTool</a>
    /// </summary>
    let NoteTool = _prefixId.prefix "NoteTool"
    /// <summary>
    ///   <para>rdfs:label : Notification</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#Notification">eupont:Notification</a>
    /// </summary>
    let Notification = _prefixId.prefix "Notification"

    /// <summary>
    ///   <para>rdfs:label : NotificationProfileSetToTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#NotificationProfileSetToTrigger">eupont:NotificationProfileSetToTrigger</a>
    /// </summary>
    let NotificationProfileSetToTrigger =
        _prefixId.prefix "NotificationProfileSetToTrigger"

    /// <summary>
    ///   <para>rdfs:label : NotificationService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#NotificationService">eupont:NotificationService</a>
    /// </summary>
    let NotificationService = _prefixId.prefix "NotificationService"
    /// <summary>
    ///   <para>rdfs:label : Notification</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#NotificationTool">eupont:NotificationTool</a>
    /// </summary>
    let NotificationTool = _prefixId.prefix "NotificationTool"
    /// <summary>
    ///   <para>rdfs:label : NotificationsDisabledTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#NotificationsDisabledTrigger">eupont:NotificationsDisabledTrigger</a>
    /// </summary>
    let NotificationsDisabledTrigger = _prefixId.prefix "NotificationsDisabledTrigger"
    /// <summary>
    ///   <para>rdfs:label : NotificationsEnabledTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#NotificationsEnabledTrigger">eupont:NotificationsEnabledTrigger</a>
    /// </summary>
    let NotificationsEnabledTrigger = _prefixId.prefix "NotificationsEnabledTrigger"
    /// <summary>
    ///   <para>rdfs:label : OpenCommand</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#OpenCommand">eupont:OpenCommand</a>
    /// </summary>
    let OpenCommand = _prefixId.prefix "OpenCommand"
    /// <summary>
    ///   <para>rdfs:label : OpenNotification</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#OpenNotification">eupont:OpenNotification</a>
    /// </summary>
    let OpenNotification = _prefixId.prefix "OpenNotification"
    /// <summary>
    ///   <para>rdfs:label : OpenWindowFrameAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#OpenWindowFrameAction">eupont:OpenWindowFrameAction</a>
    /// </summary>
    let OpenWindowFrameAction = _prefixId.prefix "OpenWindowFrameAction"
    /// <summary>
    ///   <para>rdfs:label : OrganizerTool</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#OrganizerTool">eupont:OrganizerTool</a>
    /// </summary>
    let OrganizerTool = _prefixId.prefix "OrganizerTool"
    /// <summary>
    ///   <para>rdfs:label : OutputService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#OutputService">eupont:OutputService</a>
    /// </summary>
    let OutputService = _prefixId.prefix "OutputService"
    /// <summary>
    ///   <para>rdfs:label : Oven</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#Oven">eupont:Oven</a>
    /// </summary>
    let Oven = _prefixId.prefix "Oven"
    /// <summary>
    ///   <para>rdfs:label : OvenService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#OvenService">eupont:OvenService</a>
    /// </summary>
    let OvenService = _prefixId.prefix "OvenService"
    /// <summary>
    ///   <para>rdfs:label : PC</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#PC">eupont:PC</a>
    /// </summary>
    let PC = _prefixId.prefix "PC"
    /// <summary>
    ///   <para>rdfs:label : Phone</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#Phone">eupont:Phone</a>
    /// </summary>
    let Phone = _prefixId.prefix "Phone"
    /// <summary>
    ///   <para>rdfs:label : PhoneCallMutedTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#PhoneCallMutedTrigger">eupont:PhoneCallMutedTrigger</a>
    /// </summary>
    let PhoneCallMutedTrigger = _prefixId.prefix "PhoneCallMutedTrigger"
    /// <summary>
    ///   <para>rdfs:label : PhoneCallRejectedTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#PhoneCallRejectedTrigger">eupont:PhoneCallRejectedTrigger</a>
    /// </summary>
    let PhoneCallRejectedTrigger = _prefixId.prefix "PhoneCallRejectedTrigger"
    /// <summary>
    ///   <para>rdfs:label : PhotoPlatform</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#PhotoPlatform">eupont:PhotoPlatform</a>
    /// </summary>
    let PhotoPlatform = _prefixId.prefix "PhotoPlatform"
    /// <summary>
    ///   <para>rdfs:label : PhotoRecordingService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#PhotoRecordingService">eupont:PhotoRecordingService</a>
    /// </summary>
    let PhotoRecordingService = _prefixId.prefix "PhotoRecordingService"
    /// <summary>
    ///   <para>rdfs:label : PhysicalObject</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#PhysicalObject">eupont:PhysicalObject</a>
    /// </summary>
    let PhysicalObject = _prefixId.prefix "PhysicalObject"
    /// <summary>
    ///   <para>rdfs:label : PlacesTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#PlacesTrigger">eupont:PlacesTrigger</a>
    /// </summary>
    let PlacesTrigger = _prefixId.prefix "PlacesTrigger"
    /// <summary>
    ///   <para>rdfs:label : PositionRegistrationService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#PositionRegistrationService">eupont:PositionRegistrationService</a>
    /// </summary>
    let PositionRegistrationService = _prefixId.prefix "PositionRegistrationService"
    /// <summary>
    ///   <para>rdfs:label : PositionRegistrationTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#PositionRegistrationTrigger">eupont:PositionRegistrationTrigger</a>
    /// </summary>
    let PositionRegistrationTrigger = _prefixId.prefix "PositionRegistrationTrigger"
    /// <summary>
    ///   <para>rdfs:label : PostService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#PostService">eupont:PostService</a>
    /// </summary>
    let PostService = _prefixId.prefix "PostService"
    /// <summary>
    ///   <para>rdfs:label : PositioningService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#PostioningService">eupont:PostioningService</a>
    /// </summary>
    let PostioningService = _prefixId.prefix "PostioningService"
    /// <summary>
    ///   <para>rdfs:label : PowerService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#PowerService">eupont:PowerService</a>
    /// </summary>
    let PowerService = _prefixId.prefix "PowerService"
    /// <summary>
    ///   <para>rdfs:label : PresenceDetectedNotification</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#PresenceDetectedNotification">eupont:PresenceDetectedNotification</a>
    /// </summary>
    let PresenceDetectedNotification = _prefixId.prefix "PresenceDetectedNotification"

    /// <summary>
    ///   <para>rdfs:label : PresenceNoLongerDetectedNotification</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#PresenceNoLongerDetectedNotification">eupont:PresenceNoLongerDetectedNotification</a>
    /// </summary>
    let PresenceNoLongerDetectedNotification =
        _prefixId.prefix "PresenceNoLongerDetectedNotification"

    /// <summary>
    ///   <para>rdfs:label : PrintService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#PrintService">eupont:PrintService</a>
    /// </summary>
    let PrintService = _prefixId.prefix "PrintService"
    /// <summary>
    ///   <para>rdfs:label : Printer</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#Printer">eupont:Printer</a>
    /// </summary>
    let Printer = _prefixId.prefix "Printer"
    /// <summary>
    ///   <para>rdfs:label : ProfileUpdateService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#ProfileUpdateService">eupont:ProfileUpdateService</a>
    /// </summary>
    let ProfileUpdateService = _prefixId.prefix "ProfileUpdateService"
    /// <summary>
    ///   <para>rdfs:label : QuestionService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#QuestionService">eupont:QuestionService</a>
    /// </summary>
    let QuestionService = _prefixId.prefix "QuestionService"
    /// <summary>
    ///   <para>rdfs:label : Radio</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#Radio">eupont:Radio</a>
    /// </summary>
    let Radio = _prefixId.prefix "Radio"

    /// <summary>
    ///   <para>rdfs:label : RainfallMeasurementAvailableTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#RainfallMeasurementAvailableTrigger">eupont:RainfallMeasurementAvailableTrigger</a>
    /// </summary>
    let RainfallMeasurementAvailableTrigger =
        _prefixId.prefix "RainfallMeasurementAvailableTrigger"

    /// <summary>
    ///   <para>rdfs:label : ReceiveNotification</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#ReceiveNotification">eupont:ReceiveNotification</a>
    /// </summary>
    let ReceiveNotification = _prefixId.prefix "ReceiveNotification"
    /// <summary>
    ///   <para>rdfs:label : ReceivedAnswerTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#ReceivedAnswerTrigger">eupont:ReceivedAnswerTrigger</a>
    /// </summary>
    let ReceivedAnswerTrigger = _prefixId.prefix "ReceivedAnswerTrigger"

    /// <summary>
    ///   <para>rdfs:label : ReceivedAppNotificationTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#ReceivedAppNotificationTrigger">eupont:ReceivedAppNotificationTrigger</a>
    /// </summary>
    let ReceivedAppNotificationTrigger =
        _prefixId.prefix "ReceivedAppNotificationTrigger"

    /// <summary>
    ///   <para>rdfs:label : ReceivedAttachmentTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#ReceivedAttachmentTrigger">eupont:ReceivedAttachmentTrigger</a>
    /// </summary>
    let ReceivedAttachmentTrigger = _prefixId.prefix "ReceivedAttachmentTrigger"
    /// <summary>
    ///   <para>rdfs:label : ReceivedBreakingNewsTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#ReceivedBreakingNewsTrigger">eupont:ReceivedBreakingNewsTrigger</a>
    /// </summary>
    let ReceivedBreakingNewsTrigger = _prefixId.prefix "ReceivedBreakingNewsTrigger"
    /// <summary>
    ///   <para>rdfs:label : ReceivedCommentTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#ReceivedCommentTrigger">eupont:ReceivedCommentTrigger</a>
    /// </summary>
    let ReceivedCommentTrigger = _prefixId.prefix "ReceivedCommentTrigger"

    /// <summary>
    ///   <para>rdfs:label : ReceivedContactNotificationTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#ReceivedContactNotificationTrigger">eupont:ReceivedContactNotificationTrigger</a>
    /// </summary>
    let ReceivedContactNotificationTrigger =
        _prefixId.prefix "ReceivedContactNotificationTrigger"

    /// <summary>
    ///   <para>rdfs:label : ReceivedDocumentInfoNotificationTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#ReceivedDocumentInfoNotificationTrigger">eupont:ReceivedDocumentInfoNotificationTrigger</a>
    /// </summary>
    let ReceivedDocumentInfoNotificationTrigger =
        _prefixId.prefix "ReceivedDocumentInfoNotificationTrigger"

    /// <summary>
    ///   <para>rdfs:label : ReceivedFromDeviceTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#ReceivedFromDeviceTrigger">eupont:ReceivedFromDeviceTrigger</a>
    /// </summary>
    let ReceivedFromDeviceTrigger = _prefixId.prefix "ReceivedFromDeviceTrigger"
    /// <summary>
    ///   <para>rdfs:label : ReceivedFromDiyTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#ReceivedFromDiyTrigger">eupont:ReceivedFromDiyTrigger</a>
    /// </summary>
    let ReceivedFromDiyTrigger = _prefixId.prefix "ReceivedFromDiyTrigger"
    /// <summary>
    ///   <para>rdfs:label : ReceivedIncomingCallTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#ReceivedIncomingCallTrigger">eupont:ReceivedIncomingCallTrigger</a>
    /// </summary>
    let ReceivedIncomingCallTrigger = _prefixId.prefix "ReceivedIncomingCallTrigger"
    /// <summary>
    ///   <para>rdfs:label : ReceivedLikeTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#ReceivedLikeTrigger">eupont:ReceivedLikeTrigger</a>
    /// </summary>
    let ReceivedLikeTrigger = _prefixId.prefix "ReceivedLikeTrigger"
    /// <summary>
    ///   <para>rdfs:label : ReceivedMessageTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#ReceivedMessageTrigger">eupont:ReceivedMessageTrigger</a>
    /// </summary>
    let ReceivedMessageTrigger = _prefixId.prefix "ReceivedMessageTrigger"

    /// <summary>
    ///   <para>rdfs:label : ReceivedMissedCallNotificationTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#ReceivedMissedCallNotificationTrigger">eupont:ReceivedMissedCallNotificationTrigger</a>
    /// </summary>
    let ReceivedMissedCallNotificationTrigger =
        _prefixId.prefix "ReceivedMissedCallNotificationTrigger"

    /// <summary>
    ///   <para>rdfs:label : ReceivedNewsTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#ReceivedNewsTrigger">eupont:ReceivedNewsTrigger</a>
    /// </summary>
    let ReceivedNewsTrigger = _prefixId.prefix "ReceivedNewsTrigger"
    /// <summary>
    ///   <para>rdfs:label : ReceivedNotificationTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#ReceivedNotificationTrigger">eupont:ReceivedNotificationTrigger</a>
    /// </summary>
    let ReceivedNotificationTrigger = _prefixId.prefix "ReceivedNotificationTrigger"

    /// <summary>
    ///   <para>rdfs:label : ReceivedPaymentNotificationTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#ReceivedPaymentNotificationTrigger">eupont:ReceivedPaymentNotificationTrigger</a>
    /// </summary>
    let ReceivedPaymentNotificationTrigger =
        _prefixId.prefix "ReceivedPaymentNotificationTrigger"

    /// <summary>
    ///   <para>rdfs:label : ReceivedPostTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#ReceivedPostTrigger">eupont:ReceivedPostTrigger</a>
    /// </summary>
    let ReceivedPostTrigger = _prefixId.prefix "ReceivedPostTrigger"

    /// <summary>
    ///   <para>rdfs:label : ReceivedPrivateInformationTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#ReceivedPrivateInformationTrigger">eupont:ReceivedPrivateInformationTrigger</a>
    /// </summary>
    let ReceivedPrivateInformationTrigger =
        _prefixId.prefix "ReceivedPrivateInformationTrigger"

    /// <summary>
    ///   <para>rdfs:label : ReceivedRecommendationNotificationTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#ReceivedRecommendationNotificationTrigger">eupont:ReceivedRecommendationNotificationTrigger</a>
    /// </summary>
    let ReceivedRecommendationNotificationTrigger =
        _prefixId.prefix "ReceivedRecommendationNotificationTrigger"

    /// <summary>
    ///   <para>rdfs:label : ReceivedRemindNotificationTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#ReceivedRemindNotificationTrigger">eupont:ReceivedRemindNotificationTrigger</a>
    /// </summary>
    let ReceivedRemindNotificationTrigger =
        _prefixId.prefix "ReceivedRemindNotificationTrigger"

    /// <summary>
    ///   <para>rdfs:label : ReceivedShippingNotificationTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#ReceivedShippingNotificationTrigger">eupont:ReceivedShippingNotificationTrigger</a>
    /// </summary>
    let ReceivedShippingNotificationTrigger =
        _prefixId.prefix "ReceivedShippingNotificationTrigger"

    /// <summary>
    ///   <para>rdfs:label : ReceivedTagTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#ReceivedTagTrigger">eupont:ReceivedTagTrigger</a>
    /// </summary>
    let ReceivedTagTrigger = _prefixId.prefix "ReceivedTagTrigger"
    /// <summary>
    ///   <para>rdfs:label : ReceivedTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#ReceivedTrigger">eupont:ReceivedTrigger</a>
    /// </summary>
    let ReceivedTrigger = _prefixId.prefix "ReceivedTrigger"
    /// <summary>
    ///   <para>rdfs:label : ReceivedUnlikeTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#ReceivedUnlikeTrigger">eupont:ReceivedUnlikeTrigger</a>
    /// </summary>
    let ReceivedUnlikeTrigger = _prefixId.prefix "ReceivedUnlikeTrigger"
    /// <summary>
    ///   <para>rdfs:label : RecordCommand</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#RecordCommand">eupont:RecordCommand</a>
    /// </summary>
    let RecordCommand = _prefixId.prefix "RecordCommand"
    /// <summary>
    ///   <para>rdfs:label : RecordNotification</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#RecordNotification">eupont:RecordNotification</a>
    /// </summary>
    let RecordNotification = _prefixId.prefix "RecordNotification"
    /// <summary>
    ///   <para>rdfs:label : RecordingService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#RecordingService">eupont:RecordingService</a>
    /// </summary>
    let RecordingService = _prefixId.prefix "RecordingService"
    /// <summary>
    ///   <para>rdfs:label : RejectCallAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#RejectCallAction">eupont:RejectCallAction</a>
    /// </summary>
    let RejectCallAction = _prefixId.prefix "RejectCallAction"
    /// <summary>
    ///   <para>rdfs:label : ReminderService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#ReminderService">eupont:ReminderService</a>
    /// </summary>
    let ReminderService = _prefixId.prefix "ReminderService"
    /// <summary>
    ///   <para>rdfs:label : Room</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#Room">eupont:Room</a>
    /// </summary>
    let Room = _prefixId.prefix "Room"
    /// <summary>
    ///   <para>rdfs:label : Rule</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#Rule">eupont:Rule</a>
    /// </summary>
    let Rule = _prefixId.prefix "Rule"
    /// <summary>
    ///   <para>rdfs:label : RuleAxiom</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#RuleAxiom">eupont:RuleAxiom</a>
    /// </summary>
    let RuleAxiom = _prefixId.prefix "RuleAxiom"
    /// <summary>
    ///   <para>rdfs:label : RuleInstantiatedAxiom</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#RuleInstantiatedAxiom">eupont:RuleInstantiatedAxiom</a>
    /// </summary>
    let RuleInstantiatedAxiom = _prefixId.prefix "RuleInstantiatedAxiom"
    /// <summary>
    ///   <para>rdfs:label : RuleNominalAxiom</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#RuleNominalAxiom">eupont:RuleNominalAxiom</a>
    /// </summary>
    let RuleNominalAxiom = _prefixId.prefix "RuleNominalAxiom"
    /// <summary>
    ///   <para>rdfs:label : RunTrackingService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#RunTrackingService">eupont:RunTrackingService</a>
    /// </summary>
    let RunTrackingService = _prefixId.prefix "RunTrackingService"
    /// <summary>
    ///   <para>rdfs:label : SMS</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SMSTool">eupont:SMSTool</a>
    /// </summary>
    let SMSTool = _prefixId.prefix "SMSTool"
    /// <summary>
    ///   <para>rdfs:label : SaveAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SaveAction">eupont:SaveAction</a>
    /// </summary>
    let SaveAction = _prefixId.prefix "SaveAction"
    /// <summary>
    ///   <para>rdfs:label : SaveCommand</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SaveCommand">eupont:SaveCommand</a>
    /// </summary>
    let SaveCommand = _prefixId.prefix "SaveCommand"
    /// <summary>
    ///   <para>rdfs:label : SaveContactAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SaveContactAction">eupont:SaveContactAction</a>
    /// </summary>
    let SaveContactAction = _prefixId.prefix "SaveContactAction"
    /// <summary>
    ///   <para>rdfs:label : SaveFileAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SaveFileAction">eupont:SaveFileAction</a>
    /// </summary>
    let SaveFileAction = _prefixId.prefix "SaveFileAction"
    /// <summary>
    ///   <para>rdfs:label : SaveHealthInformationAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SaveHealthInformationAction">eupont:SaveHealthInformationAction</a>
    /// </summary>
    let SaveHealthInformationAction = _prefixId.prefix "SaveHealthInformationAction"
    /// <summary>
    ///   <para>rdfs:label : SaveMediaInformationAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SaveMediaInformationAction">eupont:SaveMediaInformationAction</a>
    /// </summary>
    let SaveMediaInformationAction = _prefixId.prefix "SaveMediaInformationAction"
    /// <summary>
    ///   <para>rdfs:label : SaveNotification</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SaveNotification">eupont:SaveNotification</a>
    /// </summary>
    let SaveNotification = _prefixId.prefix "SaveNotification"
    /// <summary>
    ///   <para>rdfs:label : SaveWebBookmarkAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SaveWebBookmarkAction">eupont:SaveWebBookmarkAction</a>
    /// </summary>
    let SaveWebBookmarkAction = _prefixId.prefix "SaveWebBookmarkAction"
    /// <summary>
    ///   <para>rdfs:label : SavedTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SavedTrigger">eupont:SavedTrigger</a>
    /// </summary>
    let SavedTrigger = _prefixId.prefix "SavedTrigger"
    /// <summary>
    ///   <para>rdfs:label : ScanBluetoothTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#ScanBluetoothTrigger">eupont:ScanBluetoothTrigger</a>
    /// </summary>
    let ScanBluetoothTrigger = _prefixId.prefix "ScanBluetoothTrigger"
    /// <summary>
    ///   <para>rdfs:label : ScanWifiTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#ScanWifiTrigger">eupont:ScanWifiTrigger</a>
    /// </summary>
    let ScanWifiTrigger = _prefixId.prefix "ScanWifiTrigger"
    /// <summary>
    ///   <para>rdfs:label : ScreenRotationDisabledTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#ScreenRotationDisabledTrigger">eupont:ScreenRotationDisabledTrigger</a>
    /// </summary>
    let ScreenRotationDisabledTrigger = _prefixId.prefix "ScreenRotationDisabledTrigger"
    /// <summary>
    ///   <para>rdfs:label : ScreenRotationEnabledTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#ScreenRotationEnabledTrigger">eupont:ScreenRotationEnabledTrigger</a>
    /// </summary>
    let ScreenRotationEnabledTrigger = _prefixId.prefix "ScreenRotationEnabledTrigger"
    /// <summary>
    ///   <para>rdfs:label : SecurityService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SecurityService">eupont:SecurityService</a>
    /// </summary>
    let SecurityService = _prefixId.prefix "SecurityService"
    /// <summary>
    ///   <para>rdfs:label : SecurityShutdownAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SecurityShutdownAction">eupont:SecurityShutdownAction</a>
    /// </summary>
    let SecurityShutdownAction = _prefixId.prefix "SecurityShutdownAction"
    /// <summary>
    ///   <para>rdfs:label : SecuritySystemDisabledTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SecuritySystemDisabledTrigger">eupont:SecuritySystemDisabledTrigger</a>
    /// </summary>
    let SecuritySystemDisabledTrigger = _prefixId.prefix "SecuritySystemDisabledTrigger"
    /// <summary>
    ///   <para>rdfs:label : StartedListeningMusicTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SecuritySystemEnabledTrigger">eupont:SecuritySystemEnabledTrigger</a>
    /// </summary>
    let SecuritySystemEnabledTrigger = _prefixId.prefix "SecuritySystemEnabledTrigger"
    /// <summary>
    ///   <para>rdfs:label : SendAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SendAction">eupont:SendAction</a>
    /// </summary>
    let SendAction = _prefixId.prefix "SendAction"
    /// <summary>
    ///   <para>rdfs:label : SendAttachmentAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SendAttachmentAction">eupont:SendAttachmentAction</a>
    /// </summary>
    let SendAttachmentAction = _prefixId.prefix "SendAttachmentAction"
    /// <summary>
    ///   <para>rdfs:label : SendCallAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SendCallAction">eupont:SendCallAction</a>
    /// </summary>
    let SendCallAction = _prefixId.prefix "SendCallAction"
    /// <summary>
    ///   <para>rdfs:label : SendCommand</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SendCommand">eupont:SendCommand</a>
    /// </summary>
    let SendCommand = _prefixId.prefix "SendCommand"
    /// <summary>
    ///   <para>rdfs:label : SendMessageAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SendMessageAction">eupont:SendMessageAction</a>
    /// </summary>
    let SendMessageAction = _prefixId.prefix "SendMessageAction"
    /// <summary>
    ///   <para>rdfs:label : SendNotification</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SendNotification">eupont:SendNotification</a>
    /// </summary>
    let SendNotification = _prefixId.prefix "SendNotification"
    /// <summary>
    ///   <para>rdfs:label : SendQuestionAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SendQuestionAction">eupont:SendQuestionAction</a>
    /// </summary>
    let SendQuestionAction = _prefixId.prefix "SendQuestionAction"
    /// <summary>
    ///   <para>rdfs:label : SendRequestAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SendRequestAction">eupont:SendRequestAction</a>
    /// </summary>
    let SendRequestAction = _prefixId.prefix "SendRequestAction"
    /// <summary>
    ///   <para>rdfs:label : SendToDeviceAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SendToDeviceAction">eupont:SendToDeviceAction</a>
    /// </summary>
    let SendToDeviceAction = _prefixId.prefix "SendToDeviceAction"
    /// <summary>
    ///   <para>rdfs:label : SendToDisplayAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SendToDisplayAction">eupont:SendToDisplayAction</a>
    /// </summary>
    let SendToDisplayAction = _prefixId.prefix "SendToDisplayAction"
    /// <summary>
    ///   <para>rdfs:label : SendToDiyAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SendToDiyAction">eupont:SendToDiyAction</a>
    /// </summary>
    let SendToDiyAction = _prefixId.prefix "SendToDiyAction"
    /// <summary>
    ///   <para>rdfs:label : SendToPersonAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SendToPersonAction">eupont:SendToPersonAction</a>
    /// </summary>
    let SendToPersonAction = _prefixId.prefix "SendToPersonAction"
    /// <summary>
    ///   <para>rdfs:label : SendToPrintAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SendToPrintAction">eupont:SendToPrintAction</a>
    /// </summary>
    let SendToPrintAction = _prefixId.prefix "SendToPrintAction"
    /// <summary>
    ///   <para>rdfs:label : SendToSpeakerAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SendToSpeakerAction">eupont:SendToSpeakerAction</a>
    /// </summary>
    let SendToSpeakerAction = _prefixId.prefix "SendToSpeakerAction"
    /// <summary>
    ///   <para>rdfs:label : SendWebRequestAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SendWebRequestAction">eupont:SendWebRequestAction</a>
    /// </summary>
    let SendWebRequestAction = _prefixId.prefix "SendWebRequestAction"

    /// <summary>
    ///   <para>rdfs:label : SensedAirPressureDecreasedTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SensedAirPressureDecreasedTrigger">eupont:SensedAirPressureDecreasedTrigger</a>
    /// </summary>
    let SensedAirPressureDecreasedTrigger =
        _prefixId.prefix "SensedAirPressureDecreasedTrigger"

    /// <summary>
    ///   <para>rdfs:label : SensedAirPressureIncreasedTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SensedAirPressureIncreasedTrigger">eupont:SensedAirPressureIncreasedTrigger</a>
    /// </summary>
    let SensedAirPressureIncreasedTrigger =
        _prefixId.prefix "SensedAirPressureIncreasedTrigger"

    /// <summary>
    ///   <para>rdfs:label : SensedAirQualityDecreasedTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SensedAirQualityDecreasedTrigger">eupont:SensedAirQualityDecreasedTrigger</a>
    /// </summary>
    let SensedAirQualityDecreasedTrigger =
        _prefixId.prefix "SensedAirQualityDecreasedTrigger"

    /// <summary>
    ///   <para>rdfs:label : SensedAirQualityIncreasedTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SensedAirQualityIncreasedTrigger">eupont:SensedAirQualityIncreasedTrigger</a>
    /// </summary>
    let SensedAirQualityIncreasedTrigger =
        _prefixId.prefix "SensedAirQualityIncreasedTrigger"

    /// <summary>
    ///   <para>rdfs:label : SensedHealthyParameterTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SensedHealthyParameterTrigger">eupont:SensedHealthyParameterTrigger</a>
    /// </summary>
    let SensedHealthyParameterTrigger = _prefixId.prefix "SensedHealthyParameterTrigger"

    /// <summary>
    ///   <para>rdfs:label : SensedHumididtyDecreasedTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SensedHumididtyDecreasedTrigger">eupont:SensedHumididtyDecreasedTrigger</a>
    /// </summary>
    let SensedHumididtyDecreasedTrigger =
        _prefixId.prefix "SensedHumididtyDecreasedTrigger"

    /// <summary>
    ///   <para>rdfs:label : SensedHumidityIncreasedTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SensedHumidityIncreasedTrigger">eupont:SensedHumidityIncreasedTrigger</a>
    /// </summary>
    let SensedHumidityIncreasedTrigger =
        _prefixId.prefix "SensedHumidityIncreasedTrigger"

    /// <summary>
    ///   <para>rdfs:label : SensedLightingDecreasedTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SensedLightingDecreasedTrigger">eupont:SensedLightingDecreasedTrigger</a>
    /// </summary>
    let SensedLightingDecreasedTrigger =
        _prefixId.prefix "SensedLightingDecreasedTrigger"

    /// <summary>
    ///   <para>rdfs:label : SensedLightingIncreasedTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SensedLightingIncreasedTrigger">eupont:SensedLightingIncreasedTrigger</a>
    /// </summary>
    let SensedLightingIncreasedTrigger =
        _prefixId.prefix "SensedLightingIncreasedTrigger"

    /// <summary>
    ///   <para>rdfs:label : SensedNoiseLevelDecreasedTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SensedNoiseLevelDecreasedTrigger">eupont:SensedNoiseLevelDecreasedTrigger</a>
    /// </summary>
    let SensedNoiseLevelDecreasedTrigger =
        _prefixId.prefix "SensedNoiseLevelDecreasedTrigger"

    /// <summary>
    ///   <para>rdfs:label : SensedNoiseLevelIncreasedTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SensedNoiseLevelIncreasedTrigger">eupont:SensedNoiseLevelIncreasedTrigger</a>
    /// </summary>
    let SensedNoiseLevelIncreasedTrigger =
        _prefixId.prefix "SensedNoiseLevelIncreasedTrigger"

    /// <summary>
    ///   <para>rdfs:label : SensedRainDetectedTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SensedRainDetectedTrigger">eupont:SensedRainDetectedTrigger</a>
    /// </summary>
    let SensedRainDetectedTrigger = _prefixId.prefix "SensedRainDetectedTrigger"

    /// <summary>
    ///   <para>rdfs:label : SensedRainNoLongerDetectedTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SensedRainNoLongerDetectedTrigger">eupont:SensedRainNoLongerDetectedTrigger</a>
    /// </summary>
    let SensedRainNoLongerDetectedTrigger =
        _prefixId.prefix "SensedRainNoLongerDetectedTrigger"

    /// <summary>
    ///   <para>rdfs:label : SensedTemperatureDecreasedTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SensedTemperatureDecreasedTrigger">eupont:SensedTemperatureDecreasedTrigger</a>
    /// </summary>
    let SensedTemperatureDecreasedTrigger =
        _prefixId.prefix "SensedTemperatureDecreasedTrigger"

    /// <summary>
    ///   <para>rdfs:label : SensedTemperatureIncreasedTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SensedTemperatureIncreasedTrigger">eupont:SensedTemperatureIncreasedTrigger</a>
    /// </summary>
    let SensedTemperatureIncreasedTrigger =
        _prefixId.prefix "SensedTemperatureIncreasedTrigger"

    /// <summary>
    ///   <para>rdfs:label : SensedWindDecreasedTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SensedWindDecreasedTrigger">eupont:SensedWindDecreasedTrigger</a>
    /// </summary>
    let SensedWindDecreasedTrigger = _prefixId.prefix "SensedWindDecreasedTrigger"
    /// <summary>
    ///   <para>rdfs:label : SensedWindIncreasedTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SensedWindIncreasedTrigger">eupont:SensedWindIncreasedTrigger</a>
    /// </summary>
    let SensedWindIncreasedTrigger = _prefixId.prefix "SensedWindIncreasedTrigger"
    /// <summary>
    ///   <para>rdfs:label : SensorPresenceDetectedTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SensorPresenceDetectedTrigger">eupont:SensorPresenceDetectedTrigger</a>
    /// </summary>
    let SensorPresenceDetectedTrigger = _prefixId.prefix "SensorPresenceDetectedTrigger"

    /// <summary>
    ///   <para>rdfs:label : SensorPresenceNoLongerDetectedTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SensorPresenceNoLongerDetectedTrigger">eupont:SensorPresenceNoLongerDetectedTrigger</a>
    /// </summary>
    let SensorPresenceNoLongerDetectedTrigger =
        _prefixId.prefix "SensorPresenceNoLongerDetectedTrigger"

    /// <summary>
    ///   <para>rdfs:label : SentMessageTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SentMessageTrigger">eupont:SentMessageTrigger</a>
    /// </summary>
    let SentMessageTrigger = _prefixId.prefix "SentMessageTrigger"
    /// <summary>
    ///   <para>rdfs:label : SentOutcomingCallTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SentOutcomingCallTrigger">eupont:SentOutcomingCallTrigger</a>
    /// </summary>
    let SentOutcomingCallTrigger = _prefixId.prefix "SentOutcomingCallTrigger"
    /// <summary>
    ///   <para>rdfs:label : SentPrivateInformationTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SentPrivateInformationTrigger">eupont:SentPrivateInformationTrigger</a>
    /// </summary>
    let SentPrivateInformationTrigger = _prefixId.prefix "SentPrivateInformationTrigger"
    /// <summary>
    ///   <para>rdfs:label : SentPullTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SentPullTrigger">eupont:SentPullTrigger</a>
    /// </summary>
    let SentPullTrigger = _prefixId.prefix "SentPullTrigger"
    /// <summary>
    ///   <para>rdfs:label : SentQuestionTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SentQuestionTrigger">eupont:SentQuestionTrigger</a>
    /// </summary>
    let SentQuestionTrigger = _prefixId.prefix "SentQuestionTrigger"
    /// <summary>
    ///   <para>rdfs:label : SentRequestTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SentRequestTrigger">eupont:SentRequestTrigger</a>
    /// </summary>
    let SentRequestTrigger = _prefixId.prefix "SentRequestTrigger"
    /// <summary>
    ///   <para>rdfs:label : SentSharedInformationTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SentSharedInformationTrigger">eupont:SentSharedInformationTrigger</a>
    /// </summary>
    let SentSharedInformationTrigger = _prefixId.prefix "SentSharedInformationTrigger"
    /// <summary>
    ///   <para>rdfs:label : SentSubscriptionTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SentSubscriptionTrigger">eupont:SentSubscriptionTrigger</a>
    /// </summary>
    let SentSubscriptionTrigger = _prefixId.prefix "SentSubscriptionTrigger"
    /// <summary>
    ///   <para>rdfs:label : SentTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SentTrigger">eupont:SentTrigger</a>
    /// </summary>
    let SentTrigger = _prefixId.prefix "SentTrigger"
    /// <summary>
    ///   <para>rdfs:label : Service</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#Service">eupont:Service</a>
    /// </summary>
    let Service = _prefixId.prefix "Service"
    /// <summary>
    ///   <para>rdfs:label : SetBrightnessAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SetBrightnessAction">eupont:SetBrightnessAction</a>
    /// </summary>
    let SetBrightnessAction = _prefixId.prefix "SetBrightnessAction"
    /// <summary>
    ///   <para>rdfs:label : SetEnvironmentComfortAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SetEnvironmentComfortAction">eupont:SetEnvironmentComfortAction</a>
    /// </summary>
    let SetEnvironmentComfortAction = _prefixId.prefix "SetEnvironmentComfortAction"
    /// <summary>
    ///   <para>rdfs:label : SetHumidityAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SetHumidityAction">eupont:SetHumidityAction</a>
    /// </summary>
    let SetHumidityAction = _prefixId.prefix "SetHumidityAction"
    /// <summary>
    ///   <para>rdfs:label : SetLightingAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SetLightingAction">eupont:SetLightingAction</a>
    /// </summary>
    let SetLightingAction = _prefixId.prefix "SetLightingAction"
    /// <summary>
    ///   <para>rdfs:label : SetTemperatureAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SetTemperatureAction">eupont:SetTemperatureAction</a>
    /// </summary>
    let SetTemperatureAction = _prefixId.prefix "SetTemperatureAction"
    /// <summary>
    ///   <para>rdfs:label : SetToCommand</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SetToCommand">eupont:SetToCommand</a>
    /// </summary>
    let SetToCommand = _prefixId.prefix "SetToCommand"
    /// <summary>
    ///   <para>rdfs:label : SetToNotification</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SetToNotification">eupont:SetToNotification</a>
    /// </summary>
    let SetToNotification = _prefixId.prefix "SetToNotification"
    /// <summary>
    ///   <para>rdfs:label : ShareAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#ShareAction">eupont:ShareAction</a>
    /// </summary>
    let ShareAction = _prefixId.prefix "ShareAction"
    /// <summary>
    ///   <para>rdfs:label : ShareCommand</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#ShareCommand">eupont:ShareCommand</a>
    /// </summary>
    let ShareCommand = _prefixId.prefix "ShareCommand"
    /// <summary>
    ///   <para>rdfs:label : ShareCommentAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#ShareCommentAction">eupont:ShareCommentAction</a>
    /// </summary>
    let ShareCommentAction = _prefixId.prefix "ShareCommentAction"
    /// <summary>
    ///   <para>rdfs:label : ShareFileAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#ShareFileAction">eupont:ShareFileAction</a>
    /// </summary>
    let ShareFileAction = _prefixId.prefix "ShareFileAction"
    /// <summary>
    ///   <para>rdfs:label : ShareLikeAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#ShareLikeAction">eupont:ShareLikeAction</a>
    /// </summary>
    let ShareLikeAction = _prefixId.prefix "ShareLikeAction"
    /// <summary>
    ///   <para>rdfs:label : ShareNotification</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#ShareNotification">eupont:ShareNotification</a>
    /// </summary>
    let ShareNotification = _prefixId.prefix "ShareNotification"
    /// <summary>
    ///   <para>rdfs:label : SharePostAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SharePostAction">eupont:SharePostAction</a>
    /// </summary>
    let SharePostAction = _prefixId.prefix "SharePostAction"
    /// <summary>
    ///   <para>rdfs:label : ShareProfileUpdateAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#ShareProfileUpdateAction">eupont:ShareProfileUpdateAction</a>
    /// </summary>
    let ShareProfileUpdateAction = _prefixId.prefix "ShareProfileUpdateAction"
    /// <summary>
    ///   <para>rdfs:label : ShareTagAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#ShareTagAction">eupont:ShareTagAction</a>
    /// </summary>
    let ShareTagAction = _prefixId.prefix "ShareTagAction"
    /// <summary>
    ///   <para>rdfs:label : ShareUnlikeAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#ShareUnlikeAction">eupont:ShareUnlikeAction</a>
    /// </summary>
    let ShareUnlikeAction = _prefixId.prefix "ShareUnlikeAction"
    /// <summary>
    ///   <para>rdfs:label : SharedCommentTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SharedCommentTrigger">eupont:SharedCommentTrigger</a>
    /// </summary>
    let SharedCommentTrigger = _prefixId.prefix "SharedCommentTrigger"
    /// <summary>
    ///   <para>rdfs:label : SharedLikeTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SharedLikeTrigger">eupont:SharedLikeTrigger</a>
    /// </summary>
    let SharedLikeTrigger = _prefixId.prefix "SharedLikeTrigger"
    /// <summary>
    ///   <para>rdfs:label : SharedPostTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SharedPostTrigger">eupont:SharedPostTrigger</a>
    /// </summary>
    let SharedPostTrigger = _prefixId.prefix "SharedPostTrigger"
    /// <summary>
    ///   <para>rdfs:label : SharedProfileUpdateTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SharedProfileUpdateTrigger">eupont:SharedProfileUpdateTrigger</a>
    /// </summary>
    let SharedProfileUpdateTrigger = _prefixId.prefix "SharedProfileUpdateTrigger"
    /// <summary>
    ///   <para>rdfs:label : SharedTagTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SharedTagTrigger">eupont:SharedTagTrigger</a>
    /// </summary>
    let SharedTagTrigger = _prefixId.prefix "SharedTagTrigger"
    /// <summary>
    ///   <para>rdfs:label : SharedUnlikeTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SharedUnlikeTrigger">eupont:SharedUnlikeTrigger</a>
    /// </summary>
    let SharedUnlikeTrigger = _prefixId.prefix "SharedUnlikeTrigger"
    /// <summary>
    ///   <para>rdfs:label : ShipmentTrackingTool</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#ShipmentTrackingTool">eupont:ShipmentTrackingTool</a>
    /// </summary>
    let ShipmentTrackingTool = _prefixId.prefix "ShipmentTrackingTool"
    /// <summary>
    ///   <para>rdfs:label : ShoppingTool</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#ShoppingTool">eupont:ShoppingTool</a>
    /// </summary>
    let ShoppingTool = _prefixId.prefix "ShoppingTool"
    /// <summary>
    ///   <para>rdfs:label : SleepTrackingService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SleepTrackingService">eupont:SleepTrackingService</a>
    /// </summary>
    let SleepTrackingService = _prefixId.prefix "SleepTrackingService"
    /// <summary>
    ///   <para>rdfs:label : Blind</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SmartBlind">eupont:SmartBlind</a>
    /// </summary>
    let SmartBlind = _prefixId.prefix "SmartBlind"
    /// <summary>
    ///   <para>rdfs:label : SmartBracelet</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SmartBracelet">eupont:SmartBracelet</a>
    /// </summary>
    let SmartBracelet = _prefixId.prefix "SmartBracelet"
    /// <summary>
    ///   <para>rdfs:label : SmartCitySystem</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SmartCitySystem">eupont:SmartCitySystem</a>
    /// </summary>
    let SmartCitySystem = _prefixId.prefix "SmartCitySystem"
    /// <summary>
    ///   <para>rdfs:label : Door</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SmartDoor">eupont:SmartDoor</a>
    /// </summary>
    let SmartDoor = _prefixId.prefix "SmartDoor"
    /// <summary>
    ///   <para>rdfs:label : SmartEnvironmentService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SmartEnvironmentService">eupont:SmartEnvironmentService</a>
    /// </summary>
    let SmartEnvironmentService = _prefixId.prefix "SmartEnvironmentService"
    /// <summary>
    ///   <para>rdfs:label : SmartEnvironmentSystem</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SmartEnvironmentSystem">eupont:SmartEnvironmentSystem</a>
    /// </summary>
    let SmartEnvironmentSystem = _prefixId.prefix "SmartEnvironmentSystem"
    /// <summary>
    ///   <para>rdfs:label : SmartWatch</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SmartWatch">eupont:SmartWatch</a>
    /// </summary>
    let SmartWatch = _prefixId.prefix "SmartWatch"
    /// <summary>
    ///   <para>rdfs:label : Window</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SmartWindow">eupont:SmartWindow</a>
    /// </summary>
    let SmartWindow = _prefixId.prefix "SmartWindow"
    /// <summary>
    ///   <para>rdfs:label : Smartphone</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#Smartphone">eupont:Smartphone</a>
    /// </summary>
    let Smartphone = _prefixId.prefix "Smartphone"
    /// <summary>
    ///   <para>rdfs:label : SocialNetwork</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SocialNetwork">eupont:SocialNetwork</a>
    /// </summary>
    let SocialNetwork = _prefixId.prefix "SocialNetwork"
    /// <summary>
    ///   <para>rdfs:label : SpeakerPhoneActivatedTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#SpeakerPhoneActivatedTrigger">eupont:SpeakerPhoneActivatedTrigger</a>
    /// </summary>
    let SpeakerPhoneActivatedTrigger = _prefixId.prefix "SpeakerPhoneActivatedTrigger"
    /// <summary>
    ///   <para>rdfs:label : Sprinkler</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#Sprinkler">eupont:Sprinkler</a>
    /// </summary>
    let Sprinkler = _prefixId.prefix "Sprinkler"
    /// <summary>
    ///   <para>rdfs:label : StartActivityAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StartActivityAction">eupont:StartActivityAction</a>
    /// </summary>
    let StartActivityAction = _prefixId.prefix "StartActivityAction"
    /// <summary>
    ///   <para>rdfs:label : StartAppAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StartAppAction">eupont:StartAppAction</a>
    /// </summary>
    let StartAppAction = _prefixId.prefix "StartAppAction"
    /// <summary>
    ///   <para>rdfs:label : StartBrewingCoffeeAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StartBrewingCoffeeAction">eupont:StartBrewingCoffeeAction</a>
    /// </summary>
    let StartBrewingCoffeeAction = _prefixId.prefix "StartBrewingCoffeeAction"
    /// <summary>
    ///   <para>rdfs:label : StartBuyingAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StartBuyingAction">eupont:StartBuyingAction</a>
    /// </summary>
    let StartBuyingAction = _prefixId.prefix "StartBuyingAction"
    /// <summary>
    ///   <para>rdfs:label : StartCleaningAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StartCleaningAction">eupont:StartCleaningAction</a>
    /// </summary>
    let StartCleaningAction = _prefixId.prefix "StartCleaningAction"
    /// <summary>
    ///   <para>rdfs:label : StartCommand</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StartCommand">eupont:StartCommand</a>
    /// </summary>
    let StartCommand = _prefixId.prefix "StartCommand"
    /// <summary>
    ///   <para>rdfs:label : StartCookingAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StartCookingAction">eupont:StartCookingAction</a>
    /// </summary>
    let StartCookingAction = _prefixId.prefix "StartCookingAction"
    /// <summary>
    ///   <para>rdfs:label : StartDishwashingAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StartDiswashingAction">eupont:StartDiswashingAction</a>
    /// </summary>
    let StartDiswashingAction = _prefixId.prefix "StartDiswashingAction"
    /// <summary>
    ///   <para>rdfs:label : StartDryingAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StartDryingAction">eupont:StartDryingAction</a>
    /// </summary>
    let StartDryingAction = _prefixId.prefix "StartDryingAction"
    /// <summary>
    ///   <para>rdfs:label : StartEntertainmentAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StartEntertainementAction">eupont:StartEntertainementAction</a>
    /// </summary>
    let StartEntertainementAction = _prefixId.prefix "StartEntertainementAction"
    /// <summary>
    ///   <para>rdfs:label : StartFocusingAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StartFocusingAction">eupont:StartFocusingAction</a>
    /// </summary>
    let StartFocusingAction = _prefixId.prefix "StartFocusingAction"
    /// <summary>
    ///   <para>rdfs:label : StartFocusingSessionAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StartFocusingSessionAction">eupont:StartFocusingSessionAction</a>
    /// </summary>
    let StartFocusingSessionAction = _prefixId.prefix "StartFocusingSessionAction"
    /// <summary>
    ///   <para>rdfs:label : StartListeningMusicAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StartListeningMusicAction">eupont:StartListeningMusicAction</a>
    /// </summary>
    let StartListeningMusicAction = _prefixId.prefix "StartListeningMusicAction"
    /// <summary>
    ///   <para>rdfs:label : StartNotification</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StartNotification">eupont:StartNotification</a>
    /// </summary>
    let StartNotification = _prefixId.prefix "StartNotification"
    /// <summary>
    ///   <para>rdfs:label : StartOvenCookingAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StartOvenCookingAction">eupont:StartOvenCookingAction</a>
    /// </summary>
    let StartOvenCookingAction = _prefixId.prefix "StartOvenCookingAction"
    /// <summary>
    ///   <para>rdfs:label : StartPlayingAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StartPlayingAction">eupont:StartPlayingAction</a>
    /// </summary>
    let StartPlayingAction = _prefixId.prefix "StartPlayingAction"
    /// <summary>
    ///   <para>rdfs:label : StartStudyingSessionAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StartStudyingSessionAction">eupont:StartStudyingSessionAction</a>
    /// </summary>
    let StartStudyingSessionAction = _prefixId.prefix "StartStudyingSessionAction"
    /// <summary>
    ///   <para>rdfs:label : StartSuperMarketBuyingAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StartSuperMarketBuyingAction">eupont:StartSuperMarketBuyingAction</a>
    /// </summary>
    let StartSuperMarketBuyingAction = _prefixId.prefix "StartSuperMarketBuyingAction"
    /// <summary>
    ///   <para>rdfs:label : StartUsingSmartphoneAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StartUsingSmartphoneAction">eupont:StartUsingSmartphoneAction</a>
    /// </summary>
    let StartUsingSmartphoneAction = _prefixId.prefix "StartUsingSmartphoneAction"
    /// <summary>
    ///   <para>rdfs:label : StartVacuumAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StartVacuumAction">eupont:StartVacuumAction</a>
    /// </summary>
    let StartVacuumAction = _prefixId.prefix "StartVacuumAction"
    /// <summary>
    ///   <para>rdfs:label : StartWashingAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StartWashingAction">eupont:StartWashingAction</a>
    /// </summary>
    let StartWashingAction = _prefixId.prefix "StartWashingAction"
    /// <summary>
    ///   <para>rdfs:label : StartWashingClothesAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StartWashingClothesAction">eupont:StartWashingClothesAction</a>
    /// </summary>
    let StartWashingClothesAction = _prefixId.prefix "StartWashingClothesAction"
    /// <summary>
    ///   <para>rdfs:label : StartWatchingTvAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StartWatchingTvAction">eupont:StartWatchingTvAction</a>
    /// </summary>
    let StartWatchingTvAction = _prefixId.prefix "StartWatchingTvAction"
    /// <summary>
    ///   <para>rdfs:label : StartedActivityTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StartedActivityTrigger">eupont:StartedActivityTrigger</a>
    /// </summary>
    let StartedActivityTrigger = _prefixId.prefix "StartedActivityTrigger"
    /// <summary>
    ///   <para>rdfs:label : StartedAppTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StartedAppTrigger">eupont:StartedAppTrigger</a>
    /// </summary>
    let StartedAppTrigger = _prefixId.prefix "StartedAppTrigger"
    /// <summary>
    ///   <para>rdfs:label : StartedBikeSessionTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StartedBikeSessionTrigger">eupont:StartedBikeSessionTrigger</a>
    /// </summary>
    let StartedBikeSessionTrigger = _prefixId.prefix "StartedBikeSessionTrigger"
    /// <summary>
    ///   <para>rdfs:label : StartedBrewingCoffeeTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StartedBrewingCoffeeTrigger">eupont:StartedBrewingCoffeeTrigger</a>
    /// </summary>
    let StartedBrewingCoffeeTrigger = _prefixId.prefix "StartedBrewingCoffeeTrigger"
    /// <summary>
    ///   <para>rdfs:label : StartedCleaningTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StartedCleaningTrigger">eupont:StartedCleaningTrigger</a>
    /// </summary>
    let StartedCleaningTrigger = _prefixId.prefix "StartedCleaningTrigger"
    /// <summary>
    ///   <para>rdfs:label : StartedCookingTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StartedCookingTrigger">eupont:StartedCookingTrigger</a>
    /// </summary>
    let StartedCookingTrigger = _prefixId.prefix "StartedCookingTrigger"
    /// <summary>
    ///   <para>rdfs:label : StartedDiswashingTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StartedDiswashingTrigger">eupont:StartedDiswashingTrigger</a>
    /// </summary>
    let StartedDiswashingTrigger = _prefixId.prefix "StartedDiswashingTrigger"
    /// <summary>
    ///   <para>rdfs:label : StartedDryingTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StartedDryingTrigger">eupont:StartedDryingTrigger</a>
    /// </summary>
    let StartedDryingTrigger = _prefixId.prefix "StartedDryingTrigger"
    /// <summary>
    ///   <para>rdfs:label : StartedEntertainementTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StartedEntertainementTrigger">eupont:StartedEntertainementTrigger</a>
    /// </summary>
    let StartedEntertainementTrigger = _prefixId.prefix "StartedEntertainementTrigger"
    /// <summary>
    ///   <para>rdfs:label : StartedFocusingSessionTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StartedFocusingSessionTrigger">eupont:StartedFocusingSessionTrigger</a>
    /// </summary>
    let StartedFocusingSessionTrigger = _prefixId.prefix "StartedFocusingSessionTrigger"
    /// <summary>
    ///   <para>rdfs:label : StartedFocusingTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StartedFocusingTrigger">eupont:StartedFocusingTrigger</a>
    /// </summary>
    let StartedFocusingTrigger = _prefixId.prefix "StartedFocusingTrigger"
    /// <summary>
    ///   <para>rdfs:label : StartedInteractionTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StartedInteractionTrigger">eupont:StartedInteractionTrigger</a>
    /// </summary>
    let StartedInteractionTrigger = _prefixId.prefix "StartedInteractionTrigger"
    /// <summary>
    ///   <para>rdfs:label : StartedListeningMusicTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StartedListeningMusicTrigger">eupont:StartedListeningMusicTrigger</a>
    /// </summary>
    let StartedListeningMusicTrigger = _prefixId.prefix "StartedListeningMusicTrigger"
    /// <summary>
    ///   <para>rdfs:label : StartedOvenCookingTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StartedOvenCookingTrigger">eupont:StartedOvenCookingTrigger</a>
    /// </summary>
    let StartedOvenCookingTrigger = _prefixId.prefix "StartedOvenCookingTrigger"

    /// <summary>
    ///   <para>rdfs:label : StartedPhysicalActivityTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StartedPhysicalActivityTrigger">eupont:StartedPhysicalActivityTrigger</a>
    /// </summary>
    let StartedPhysicalActivityTrigger =
        _prefixId.prefix "StartedPhysicalActivityTrigger"

    /// <summary>
    ///   <para>rdfs:label : StartedPlayingTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StartedPlayingTrigger">eupont:StartedPlayingTrigger</a>
    /// </summary>
    let StartedPlayingTrigger = _prefixId.prefix "StartedPlayingTrigger"
    /// <summary>
    ///   <para>rdfs:label : StartedRelaxingTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StartedRelaxingTrigger">eupont:StartedRelaxingTrigger</a>
    /// </summary>
    let StartedRelaxingTrigger = _prefixId.prefix "StartedRelaxingTrigger"
    /// <summary>
    ///   <para>rdfs:label : StartedRunSessionTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StartedRunSessionTrigger">eupont:StartedRunSessionTrigger</a>
    /// </summary>
    let StartedRunSessionTrigger = _prefixId.prefix "StartedRunSessionTrigger"
    /// <summary>
    ///   <para>rdfs:label : StartedSleepingTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StartedSleepingTrigger">eupont:StartedSleepingTrigger</a>
    /// </summary>
    let StartedSleepingTrigger = _prefixId.prefix "StartedSleepingTrigger"
    /// <summary>
    ///   <para>rdfs:label : StartedStudyingSessionTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StartedStudyingSessionTrigger">eupont:StartedStudyingSessionTrigger</a>
    /// </summary>
    let StartedStudyingSessionTrigger = _prefixId.prefix "StartedStudyingSessionTrigger"
    /// <summary>
    ///   <para>rdfs:label : StartedUsingSmartphoneTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StartedUsingSmartphoneTrigger">eupont:StartedUsingSmartphoneTrigger</a>
    /// </summary>
    let StartedUsingSmartphoneTrigger = _prefixId.prefix "StartedUsingSmartphoneTrigger"
    /// <summary>
    ///   <para>rdfs:label : StartedVacuumTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StartedVacuumTrigger">eupont:StartedVacuumTrigger</a>
    /// </summary>
    let StartedVacuumTrigger = _prefixId.prefix "StartedVacuumTrigger"
    /// <summary>
    ///   <para>rdfs:label : StartedWalkingSessionTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StartedWalkingSessionTrigger">eupont:StartedWalkingSessionTrigger</a>
    /// </summary>
    let StartedWalkingSessionTrigger = _prefixId.prefix "StartedWalkingSessionTrigger"
    /// <summary>
    ///   <para>rdfs:label : StartedWashingTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StartedWashingTrigger">eupont:StartedWashingTrigger</a>
    /// </summary>
    let StartedWashingTrigger = _prefixId.prefix "StartedWashingTrigger"
    /// <summary>
    ///   <para>rdfs:label : StartedWatchingTvTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StartedWatchingTvTrigger">eupont:StartedWatchingTvTrigger</a>
    /// </summary>
    let StartedWatchingTvTrigger = _prefixId.prefix "StartedWatchingTvTrigger"
    /// <summary>
    ///   <para>rdfs:label : StartingWashingClothesTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StartingWashingClothesTrigger">eupont:StartingWashingClothesTrigger</a>
    /// </summary>
    let StartingWashingClothesTrigger = _prefixId.prefix "StartingWashingClothesTrigger"
    /// <summary>
    ///   <para>rdfs:label : StopActivityAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StopActivityAction">eupont:StopActivityAction</a>
    /// </summary>
    let StopActivityAction = _prefixId.prefix "StopActivityAction"
    /// <summary>
    ///   <para>rdfs:label : StopAppAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StopAppAction">eupont:StopAppAction</a>
    /// </summary>
    let StopAppAction = _prefixId.prefix "StopAppAction"
    /// <summary>
    ///   <para>rdfs:label : StopBrewingCoffeeAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StopBrewingCoffeeAction">eupont:StopBrewingCoffeeAction</a>
    /// </summary>
    let StopBrewingCoffeeAction = _prefixId.prefix "StopBrewingCoffeeAction"
    /// <summary>
    ///   <para>rdfs:label : StopCleaningAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StopCleaningAction">eupont:StopCleaningAction</a>
    /// </summary>
    let StopCleaningAction = _prefixId.prefix "StopCleaningAction"
    /// <summary>
    ///   <para>rdfs:label : StopCommand</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StopCommand">eupont:StopCommand</a>
    /// </summary>
    let StopCommand = _prefixId.prefix "StopCommand"
    /// <summary>
    ///   <para>rdfs:label : StopCookingAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StopCookingAction">eupont:StopCookingAction</a>
    /// </summary>
    let StopCookingAction = _prefixId.prefix "StopCookingAction"
    /// <summary>
    ///   <para>rdfs:label : StopDishwashingAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StopDiswashingAction">eupont:StopDiswashingAction</a>
    /// </summary>
    let StopDiswashingAction = _prefixId.prefix "StopDiswashingAction"
    /// <summary>
    ///   <para>rdfs:label : StopDryingAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StopDryingAction">eupont:StopDryingAction</a>
    /// </summary>
    let StopDryingAction = _prefixId.prefix "StopDryingAction"
    /// <summary>
    ///   <para>rdfs:label : StopEntertainmentAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StopEntertainementAction">eupont:StopEntertainementAction</a>
    /// </summary>
    let StopEntertainementAction = _prefixId.prefix "StopEntertainementAction"
    /// <summary>
    ///   <para>rdfs:label : StopFocusingAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StopFocusingAction">eupont:StopFocusingAction</a>
    /// </summary>
    let StopFocusingAction = _prefixId.prefix "StopFocusingAction"
    /// <summary>
    ///   <para>rdfs:label : StopFocusingSessionAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StopFocusingSessionAction">eupont:StopFocusingSessionAction</a>
    /// </summary>
    let StopFocusingSessionAction = _prefixId.prefix "StopFocusingSessionAction"
    /// <summary>
    ///   <para>rdfs:label : StopListeningMusicAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StopListeningMusicAction">eupont:StopListeningMusicAction</a>
    /// </summary>
    let StopListeningMusicAction = _prefixId.prefix "StopListeningMusicAction"
    /// <summary>
    ///   <para>rdfs:label : StopNotification</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StopNotification">eupont:StopNotification</a>
    /// </summary>
    let StopNotification = _prefixId.prefix "StopNotification"
    /// <summary>
    ///   <para>rdfs:label : StopOvenCookingAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StopOvenCookingAction">eupont:StopOvenCookingAction</a>
    /// </summary>
    let StopOvenCookingAction = _prefixId.prefix "StopOvenCookingAction"
    /// <summary>
    ///   <para>rdfs:label : StopPlayingAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StopPlayingAction">eupont:StopPlayingAction</a>
    /// </summary>
    let StopPlayingAction = _prefixId.prefix "StopPlayingAction"
    /// <summary>
    ///   <para>rdfs:label : StopStudyingSessionAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StopStudyingSessionAction">eupont:StopStudyingSessionAction</a>
    /// </summary>
    let StopStudyingSessionAction = _prefixId.prefix "StopStudyingSessionAction"
    /// <summary>
    ///   <para>rdfs:label : StopUsingSmartphoneAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StopUsingSmartphoneAction">eupont:StopUsingSmartphoneAction</a>
    /// </summary>
    let StopUsingSmartphoneAction = _prefixId.prefix "StopUsingSmartphoneAction"
    /// <summary>
    ///   <para>rdfs:label : StopVacuumAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StopVacuumAction">eupont:StopVacuumAction</a>
    /// </summary>
    let StopVacuumAction = _prefixId.prefix "StopVacuumAction"
    /// <summary>
    ///   <para>rdfs:label : StopWashingAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StopWashingAction">eupont:StopWashingAction</a>
    /// </summary>
    let StopWashingAction = _prefixId.prefix "StopWashingAction"
    /// <summary>
    ///   <para>rdfs:label : StopWashingClothesAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StopWashingClothesAction">eupont:StopWashingClothesAction</a>
    /// </summary>
    let StopWashingClothesAction = _prefixId.prefix "StopWashingClothesAction"
    /// <summary>
    ///   <para>rdfs:label : StopWatchingTvAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StopWatchingTvAction">eupont:StopWatchingTvAction</a>
    /// </summary>
    let StopWatchingTvAction = _prefixId.prefix "StopWatchingTvAction"
    /// <summary>
    ///   <para>rdfs:label : StoppedActivityTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StoppedActivityTrigger">eupont:StoppedActivityTrigger</a>
    /// </summary>
    let StoppedActivityTrigger = _prefixId.prefix "StoppedActivityTrigger"
    /// <summary>
    ///   <para>rdfs:label : StoppedAppTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StoppedAppTrigger">eupont:StoppedAppTrigger</a>
    /// </summary>
    let StoppedAppTrigger = _prefixId.prefix "StoppedAppTrigger"
    /// <summary>
    ///   <para>rdfs:label : StoppedBikeSessionTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StoppedBikeSessionTrigger">eupont:StoppedBikeSessionTrigger</a>
    /// </summary>
    let StoppedBikeSessionTrigger = _prefixId.prefix "StoppedBikeSessionTrigger"
    /// <summary>
    ///   <para>rdfs:label : StoppedBrewingCoffeeTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StoppedBrewingCoffeeTrigger">eupont:StoppedBrewingCoffeeTrigger</a>
    /// </summary>
    let StoppedBrewingCoffeeTrigger = _prefixId.prefix "StoppedBrewingCoffeeTrigger"
    /// <summary>
    ///   <para>rdfs:label : StoppedCookingTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StoppedCookingTrigger">eupont:StoppedCookingTrigger</a>
    /// </summary>
    let StoppedCookingTrigger = _prefixId.prefix "StoppedCookingTrigger"
    /// <summary>
    ///   <para>rdfs:label : StoppedDiswashingTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StoppedDiswashingTrigger">eupont:StoppedDiswashingTrigger</a>
    /// </summary>
    let StoppedDiswashingTrigger = _prefixId.prefix "StoppedDiswashingTrigger"
    /// <summary>
    ///   <para>rdfs:label : StoppedDryingTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StoppedDryingTrigger">eupont:StoppedDryingTrigger</a>
    /// </summary>
    let StoppedDryingTrigger = _prefixId.prefix "StoppedDryingTrigger"
    /// <summary>
    ///   <para>rdfs:label : StoppedEntertainementTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StoppedEntertainementTrigger">eupont:StoppedEntertainementTrigger</a>
    /// </summary>
    let StoppedEntertainementTrigger = _prefixId.prefix "StoppedEntertainementTrigger"
    /// <summary>
    ///   <para>rdfs:label : StoppedFocusingSessionTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StoppedFocusingSessionTrigger">eupont:StoppedFocusingSessionTrigger</a>
    /// </summary>
    let StoppedFocusingSessionTrigger = _prefixId.prefix "StoppedFocusingSessionTrigger"
    /// <summary>
    ///   <para>rdfs:label : StoppedFocusingTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StoppedFocusingTrigger">eupont:StoppedFocusingTrigger</a>
    /// </summary>
    let StoppedFocusingTrigger = _prefixId.prefix "StoppedFocusingTrigger"
    /// <summary>
    ///   <para>rdfs:label : StoppedListeningMusicTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StoppedListeningMusicTrigger">eupont:StoppedListeningMusicTrigger</a>
    /// </summary>
    let StoppedListeningMusicTrigger = _prefixId.prefix "StoppedListeningMusicTrigger"
    /// <summary>
    ///   <para>rdfs:label : StoppedOvenCookingTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StoppedOvenCookingTrigger">eupont:StoppedOvenCookingTrigger</a>
    /// </summary>
    let StoppedOvenCookingTrigger = _prefixId.prefix "StoppedOvenCookingTrigger"

    /// <summary>
    ///   <para>rdfs:label : StoppedPhysicalActivityTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StoppedPhysicalActivityTrigger">eupont:StoppedPhysicalActivityTrigger</a>
    /// </summary>
    let StoppedPhysicalActivityTrigger =
        _prefixId.prefix "StoppedPhysicalActivityTrigger"

    /// <summary>
    ///   <para>rdfs:label : StoppedPlayingTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StoppedPlayingTrigger">eupont:StoppedPlayingTrigger</a>
    /// </summary>
    let StoppedPlayingTrigger = _prefixId.prefix "StoppedPlayingTrigger"
    /// <summary>
    ///   <para>rdfs:label : StoppedRelaxingTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StoppedRelaxingTrigger">eupont:StoppedRelaxingTrigger</a>
    /// </summary>
    let StoppedRelaxingTrigger = _prefixId.prefix "StoppedRelaxingTrigger"
    /// <summary>
    ///   <para>rdfs:label : StoppedRunSessionTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StoppedRunSessionTrigger">eupont:StoppedRunSessionTrigger</a>
    /// </summary>
    let StoppedRunSessionTrigger = _prefixId.prefix "StoppedRunSessionTrigger"
    /// <summary>
    ///   <para>rdfs:label : StoppedSleepingTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StoppedSleepingTrigger">eupont:StoppedSleepingTrigger</a>
    /// </summary>
    let StoppedSleepingTrigger = _prefixId.prefix "StoppedSleepingTrigger"
    /// <summary>
    ///   <para>rdfs:label : StoppedStudyingSessionTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StoppedStudyingSessionTrigger">eupont:StoppedStudyingSessionTrigger</a>
    /// </summary>
    let StoppedStudyingSessionTrigger = _prefixId.prefix "StoppedStudyingSessionTrigger"
    /// <summary>
    ///   <para>rdfs:label : StoppedUsingSmartphoneTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StoppedUsingSmartphoneTrigger">eupont:StoppedUsingSmartphoneTrigger</a>
    /// </summary>
    let StoppedUsingSmartphoneTrigger = _prefixId.prefix "StoppedUsingSmartphoneTrigger"
    /// <summary>
    ///   <para>rdfs:label : StoppedWalkingSessionTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StoppedWalkingSessionTrigger">eupont:StoppedWalkingSessionTrigger</a>
    /// </summary>
    let StoppedWalkingSessionTrigger = _prefixId.prefix "StoppedWalkingSessionTrigger"
    /// <summary>
    ///   <para>rdfs:label : StoppedWashingClothesTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StoppedWashingClothesTrigger">eupont:StoppedWashingClothesTrigger</a>
    /// </summary>
    let StoppedWashingClothesTrigger = _prefixId.prefix "StoppedWashingClothesTrigger"
    /// <summary>
    ///   <para>rdfs:label : StoppedWashingTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StoppedWashingTrigger">eupont:StoppedWashingTrigger</a>
    /// </summary>
    let StoppedWashingTrigger = _prefixId.prefix "StoppedWashingTrigger"
    /// <summary>
    ///   <para>rdfs:label : StoppedWatchingTvTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StoppedWatchingTvTrigger">eupont:StoppedWatchingTvTrigger</a>
    /// </summary>
    let StoppedWatchingTvTrigger = _prefixId.prefix "StoppedWatchingTvTrigger"
    /// <summary>
    ///   <para>rdfs:label : StoragePlatform</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StoragePlatform">eupont:StoragePlatform</a>
    /// </summary>
    let StoragePlatform = _prefixId.prefix "StoragePlatform"
    /// <summary>
    ///   <para>rdfs:label : StoreAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StoreAction">eupont:StoreAction</a>
    /// </summary>
    let StoreAction = _prefixId.prefix "StoreAction"
    /// <summary>
    ///   <para>rdfs:label : StoredAppTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StoredAppTrigger">eupont:StoredAppTrigger</a>
    /// </summary>
    let StoredAppTrigger = _prefixId.prefix "StoredAppTrigger"
    /// <summary>
    ///   <para>rdfs:label : StoredBackupTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StoredBackupTrigger">eupont:StoredBackupTrigger</a>
    /// </summary>
    let StoredBackupTrigger = _prefixId.prefix "StoredBackupTrigger"
    /// <summary>
    ///   <para>rdfs:label : StoredContactTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StoredContactTrigger">eupont:StoredContactTrigger</a>
    /// </summary>
    let StoredContactTrigger = _prefixId.prefix "StoredContactTrigger"
    /// <summary>
    ///   <para>rdfs:label : StoredFileTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StoredFileTrigger">eupont:StoredFileTrigger</a>
    /// </summary>
    let StoredFileTrigger = _prefixId.prefix "StoredFileTrigger"

    /// <summary>
    ///   <para>rdfs:label : StoredHealthInformationTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StoredHealthInformationTrigger">eupont:StoredHealthInformationTrigger</a>
    /// </summary>
    let StoredHealthInformationTrigger =
        _prefixId.prefix "StoredHealthInformationTrigger"

    /// <summary>
    ///   <para>rdfs:label : StoredMediaInformationTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StoredMediaInformationTrigger">eupont:StoredMediaInformationTrigger</a>
    /// </summary>
    let StoredMediaInformationTrigger = _prefixId.prefix "StoredMediaInformationTrigger"
    /// <summary>
    ///   <para>rdfs:label : StoredTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StoredTrigger">eupont:StoredTrigger</a>
    /// </summary>
    let StoredTrigger = _prefixId.prefix "StoredTrigger"
    /// <summary>
    ///   <para>rdfs:label : StoredWebBookmarkTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StoredWebBookmarkTrigger">eupont:StoredWebBookmarkTrigger</a>
    /// </summary>
    let StoredWebBookmarkTrigger = _prefixId.prefix "StoredWebBookmarkTrigger"
    /// <summary>
    ///   <para>rdfs:label : StudyingTrackingService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#StudyingTrackingService">eupont:StudyingTrackingService</a>
    /// </summary>
    let StudyingTrackingService = _prefixId.prefix "StudyingTrackingService"
    /// <summary>
    ///   <para>rdfs:label : TVService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#TVService">eupont:TVService</a>
    /// </summary>
    let TVService = _prefixId.prefix "TVService"
    /// <summary>
    ///   <para>rdfs:label : Tablet</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#Tablet">eupont:Tablet</a>
    /// </summary>
    let Tablet = _prefixId.prefix "Tablet"
    /// <summary>
    ///   <para>rdfs:label : TagService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#TagService">eupont:TagService</a>
    /// </summary>
    let TagService = _prefixId.prefix "TagService"
    /// <summary>
    ///   <para>rdfs:label : TakeAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#TakeAction">eupont:TakeAction</a>
    /// </summary>
    let TakeAction = _prefixId.prefix "TakeAction"
    /// <summary>
    ///   <para>rdfs:label : TakeAudioAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#TakeAudioAction">eupont:TakeAudioAction</a>
    /// </summary>
    let TakeAudioAction = _prefixId.prefix "TakeAudioAction"
    /// <summary>
    ///   <para>rdfs:label : TakePhotoAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#TakePhotoAction">eupont:TakePhotoAction</a>
    /// </summary>
    let TakePhotoAction = _prefixId.prefix "TakePhotoAction"
    /// <summary>
    ///   <para>rdfs:label : TakeVideoAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#TakeVideoAction">eupont:TakeVideoAction</a>
    /// </summary>
    let TakeVideoAction = _prefixId.prefix "TakeVideoAction"
    /// <summary>
    ///   <para>rdfs:label : TakenAudioTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#TakenAudioTrigger">eupont:TakenAudioTrigger</a>
    /// </summary>
    let TakenAudioTrigger = _prefixId.prefix "TakenAudioTrigger"
    /// <summary>
    ///   <para>rdfs:label : TakenImageTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#TakenImageTrigger">eupont:TakenImageTrigger</a>
    /// </summary>
    let TakenImageTrigger = _prefixId.prefix "TakenImageTrigger"
    /// <summary>
    ///   <para>rdfs:label : TakenTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#TakenTrigger">eupont:TakenTrigger</a>
    /// </summary>
    let TakenTrigger = _prefixId.prefix "TakenTrigger"
    /// <summary>
    ///   <para>rdfs:label : TakenVideoTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#TakenVideoTrigger">eupont:TakenVideoTrigger</a>
    /// </summary>
    let TakenVideoTrigger = _prefixId.prefix "TakenVideoTrigger"
    /// <summary>
    ///   <para>rdfs:label : TapButtonActivityTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#TapButtonActivityTrigger">eupont:TapButtonActivityTrigger</a>
    /// </summary>
    let TapButtonActivityTrigger = _prefixId.prefix "TapButtonActivityTrigger"
    /// <summary>
    ///   <para>rdfs:label : TemperatureSetToTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#TemperatureSetToTrigger">eupont:TemperatureSetToTrigger</a>
    /// </summary>
    let TemperatureSetToTrigger = _prefixId.prefix "TemperatureSetToTrigger"
    /// <summary>
    ///   <para>rdfs:label : TemporalTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#TemporalTrigger">eupont:TemporalTrigger</a>
    /// </summary>
    let TemporalTrigger = _prefixId.prefix "TemporalTrigger"
    /// <summary>
    ///   <para>rdfs:label : Thermostat</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#Thermostat">eupont:Thermostat</a>
    /// </summary>
    let Thermostat = _prefixId.prefix "Thermostat"
    /// <summary>
    ///   <para>rdfs:label : TimeManagement</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#TimeManagementTool">eupont:TimeManagementTool</a>
    /// </summary>
    let TimeManagementTool = _prefixId.prefix "TimeManagementTool"
    /// <summary>
    ///   <para>rdfs:label : TimeService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#TimeService">eupont:TimeService</a>
    /// </summary>
    let TimeService = _prefixId.prefix "TimeService"
    /// <summary>
    ///   <para>rdfs:label : TimeTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#TimeTrigger">eupont:TimeTrigger</a>
    /// </summary>
    let TimeTrigger = _prefixId.prefix "TimeTrigger"
    /// <summary>
    ///   <para>rdfs:label : TimerService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#TimerService">eupont:TimerService</a>
    /// </summary>
    let TimerService = _prefixId.prefix "TimerService"
    /// <summary>
    ///   <para>rdfs:label : ToDo</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#ToDoTool">eupont:ToDoTool</a>
    /// </summary>
    let ToDoTool = _prefixId.prefix "ToDoTool"
    /// <summary>
    ///   <para>rdfs:label : ToggleCommand</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#ToggleCommand">eupont:ToggleCommand</a>
    /// </summary>
    let ToggleCommand = _prefixId.prefix "ToggleCommand"
    /// <summary>
    ///   <para>rdfs:label : ToggleSwitchTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#ToggleSwitchTrigger">eupont:ToggleSwitchTrigger</a>
    /// </summary>
    let ToggleSwitchTrigger = _prefixId.prefix "ToggleSwitchTrigger"
    /// <summary>
    ///   <para>rdfs:label : TrackingService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#TrackingService">eupont:TrackingService</a>
    /// </summary>
    let TrackingService = _prefixId.prefix "TrackingService"
    /// <summary>
    ///   <para>rdfs:label : Trigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#Trigger">eupont:Trigger</a>
    /// </summary>
    let Trigger = _prefixId.prefix "Trigger"
    /// <summary>
    ///   <para>rdfs:label : TurnAlarmOffAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#TurnAlarmOffAction">eupont:TurnAlarmOffAction</a>
    /// </summary>
    let TurnAlarmOffAction = _prefixId.prefix "TurnAlarmOffAction"
    /// <summary>
    ///   <para>rdfs:label : TurnDeviceOffAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#TurnDeviceOffAction">eupont:TurnDeviceOffAction</a>
    /// </summary>
    let TurnDeviceOffAction = _prefixId.prefix "TurnDeviceOffAction"
    /// <summary>
    ///   <para>rdfs:label : TurnDeviceOnAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#TurnDeviceOnAction">eupont:TurnDeviceOnAction</a>
    /// </summary>
    let TurnDeviceOnAction = _prefixId.prefix "TurnDeviceOnAction"
    /// <summary>
    ///   <para>rdfs:label : TurnOffCommand</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#TurnOffCommand">eupont:TurnOffCommand</a>
    /// </summary>
    let TurnOffCommand = _prefixId.prefix "TurnOffCommand"
    /// <summary>
    ///   <para>rdfs:label : TurnOffNotification</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#TurnOffNotification">eupont:TurnOffNotification</a>
    /// </summary>
    let TurnOffNotification = _prefixId.prefix "TurnOffNotification"
    /// <summary>
    ///   <para>rdfs:label : TurnOnCommand</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#TurnOnCommand">eupont:TurnOnCommand</a>
    /// </summary>
    let TurnOnCommand = _prefixId.prefix "TurnOnCommand"
    /// <summary>
    ///   <para>rdfs:label : TurnOnNotification</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#TurnOnNotification">eupont:TurnOnNotification</a>
    /// </summary>
    let TurnOnNotification = _prefixId.prefix "TurnOnNotification"
    /// <summary>
    ///   <para>rdfs:label : TV</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#Tv">eupont:Tv</a>
    /// </summary>
    let Tv = _prefixId.prefix "Tv"
    /// <summary>
    ///   <para>rdfs:label : UnhealthyActivityTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#UnhealthyActivityTrigger">eupont:UnhealthyActivityTrigger</a>
    /// </summary>
    let UnhealthyActivityTrigger = _prefixId.prefix "UnhealthyActivityTrigger"
    /// <summary>
    ///   <para>rdfs:label : UnlikeService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#UnlikeService">eupont:UnlikeService</a>
    /// </summary>
    let UnlikeService = _prefixId.prefix "UnlikeService"
    /// <summary>
    ///   <para>rdfs:label : UpdatedWallpaperTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#UpdatedWallpaperTrigger">eupont:UpdatedWallpaperTrigger</a>
    /// </summary>
    let UpdatedWallpaperTrigger = _prefixId.prefix "UpdatedWallpaperTrigger"

    /// <summary>
    ///   <para>rdfs:label : UserConnectivityDecreasedTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#UserConnectivityDecreasedTrigger">eupont:UserConnectivityDecreasedTrigger</a>
    /// </summary>
    let UserConnectivityDecreasedTrigger =
        _prefixId.prefix "UserConnectivityDecreasedTrigger"

    /// <summary>
    ///   <para>rdfs:label : UserConnectivityIncreasedTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#UserConnectivityIncreasedTrigger">eupont:UserConnectivityIncreasedTrigger</a>
    /// </summary>
    let UserConnectivityIncreasedTrigger =
        _prefixId.prefix "UserConnectivityIncreasedTrigger"

    /// <summary>
    ///   <para>rdfs:label : UserDevice</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#UserDevice">eupont:UserDevice</a>
    /// </summary>
    let UserDevice = _prefixId.prefix "UserDevice"
    /// <summary>
    ///   <para>rdfs:label : VacuumService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#VacuumService">eupont:VacuumService</a>
    /// </summary>
    let VacuumService = _prefixId.prefix "VacuumService"
    /// <summary>
    ///   <para>rdfs:label : VehicleTrackingService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#VehicleTrackingService">eupont:VehicleTrackingService</a>
    /// </summary>
    let VehicleTrackingService = _prefixId.prefix "VehicleTrackingService"
    /// <summary>
    ///   <para>rdfs:label : Ventilator</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#Ventilator">eupont:Ventilator</a>
    /// </summary>
    let Ventilator = _prefixId.prefix "Ventilator"
    /// <summary>
    ///   <para>rdfs:label : VideoPlatform</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#VideoPlatform">eupont:VideoPlatform</a>
    /// </summary>
    let VideoPlatform = _prefixId.prefix "VideoPlatform"
    /// <summary>
    ///   <para>rdfs:label : VideoRecordingService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#VideoRecordingService">eupont:VideoRecordingService</a>
    /// </summary>
    let VideoRecordingService = _prefixId.prefix "VideoRecordingService"
    /// <summary>
    ///   <para>rdfs:label : VideoService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#VideoService">eupont:VideoService</a>
    /// </summary>
    let VideoService = _prefixId.prefix "VideoService"
    /// <summary>
    ///   <para>rdfs:label : VirtualObject</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#VirtualObject">eupont:VirtualObject</a>
    /// </summary>
    let VirtualObject = _prefixId.prefix "VirtualObject"
    /// <summary>
    ///   <para>rdfs:label : VoiceAssistant</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#VoiceAssistant">eupont:VoiceAssistant</a>
    /// </summary>
    let VoiceAssistant = _prefixId.prefix "VoiceAssistant"
    /// <summary>
    ///   <para>rdfs:label : VolumeDecreasedTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#VolumeDecreasedTrigger">eupont:VolumeDecreasedTrigger</a>
    /// </summary>
    let VolumeDecreasedTrigger = _prefixId.prefix "VolumeDecreasedTrigger"
    /// <summary>
    ///   <para>rdfs:label : VolumeIncreasedTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#VolumeIncreasedTrigger">eupont:VolumeIncreasedTrigger</a>
    /// </summary>
    let VolumeIncreasedTrigger = _prefixId.prefix "VolumeIncreasedTrigger"
    /// <summary>
    ///   <para>rdfs:label : VolumeService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#VolumeService">eupont:VolumeService</a>
    /// </summary>
    let VolumeService = _prefixId.prefix "VolumeService"
    /// <summary>
    ///   <para>rdfs:label : WalkTrackingService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#WalkTrackingService">eupont:WalkTrackingService</a>
    /// </summary>
    let WalkTrackingService = _prefixId.prefix "WalkTrackingService"
    /// <summary>
    ///   <para>rdfs:label : WashingMachine</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#WashingMachine">eupont:WashingMachine</a>
    /// </summary>
    let WashingMachine = _prefixId.prefix "WashingMachine"
    /// <summary>
    ///   <para>rdfs:label : WashingService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#WashingService">eupont:WashingService</a>
    /// </summary>
    let WashingService = _prefixId.prefix "WashingService"

    /// <summary>
    ///   <para>rdfs:label : WaterTemperatureSystemDisabledTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#WaterTemperatureSystemDisabledTrigger">eupont:WaterTemperatureSystemDisabledTrigger</a>
    /// </summary>
    let WaterTemperatureSystemDisabledTrigger =
        _prefixId.prefix "WaterTemperatureSystemDisabledTrigger"

    /// <summary>
    ///   <para>rdfs:label : WaterTemperatureSystemEnabledTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#WaterTemperatureSystemEnabledTrigger">eupont:WaterTemperatureSystemEnabledTrigger</a>
    /// </summary>
    let WaterTemperatureSystemEnabledTrigger =
        _prefixId.prefix "WaterTemperatureSystemEnabledTrigger"

    /// <summary>
    ///   <para>rdfs:label : WateringService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#WateringService">eupont:WateringService</a>
    /// </summary>
    let WateringService = _prefixId.prefix "WateringService"
    /// <summary>
    ///   <para>rdfs:label : WateringSystemDisabledTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#WateringSystemDisabledTrigger">eupont:WateringSystemDisabledTrigger</a>
    /// </summary>
    let WateringSystemDisabledTrigger = _prefixId.prefix "WateringSystemDisabledTrigger"
    /// <summary>
    ///   <para>rdfs:label : WateringSystemEnabledTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#WateringSystemEnabledTrigger">eupont:WateringSystemEnabledTrigger</a>
    /// </summary>
    let WateringSystemEnabledTrigger = _prefixId.prefix "WateringSystemEnabledTrigger"
    /// <summary>
    ///   <para>rdfs:label : WeatherService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#WeatherService">eupont:WeatherService</a>
    /// </summary>
    let WeatherService = _prefixId.prefix "WeatherService"
    /// <summary>
    ///   <para>rdfs:label : WeatherStation</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#WeatherStation">eupont:WeatherStation</a>
    /// </summary>
    let WeatherStation = _prefixId.prefix "WeatherStation"
    /// <summary>
    ///   <para>rdfs:label : WeatherWebsite</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#WeatherWebSite">eupont:WeatherWebSite</a>
    /// </summary>
    let WeatherWebSite = _prefixId.prefix "WeatherWebSite"
    /// <summary>
    ///   <para>rdfs:label : WebBookmarkService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#WebBookmarkService">eupont:WebBookmarkService</a>
    /// </summary>
    let WebBookmarkService = _prefixId.prefix "WebBookmarkService"
    /// <summary>
    ///   <para>rdfs:label : WebBookmarkTool</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#WebBookmarkTool">eupont:WebBookmarkTool</a>
    /// </summary>
    let WebBookmarkTool = _prefixId.prefix "WebBookmarkTool"
    /// <summary>
    ///   <para>rdfs:label : WebRequestService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#WebRequestService">eupont:WebRequestService</a>
    /// </summary>
    let WebRequestService = _prefixId.prefix "WebRequestService"
    /// <summary>
    ///   <para>rdfs:label : WifiService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#WifiService">eupont:WifiService</a>
    /// </summary>
    let WifiService = _prefixId.prefix "WifiService"
    /// <summary>
    ///   <para>rdfs:label : WindowFrameClosedTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#WindowFrameClosedTrigger">eupont:WindowFrameClosedTrigger</a>
    /// </summary>
    let WindowFrameClosedTrigger = _prefixId.prefix "WindowFrameClosedTrigger"
    /// <summary>
    ///   <para>rdfs:label : WindowFrameOpenedTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#WindowFrameOpenedTrigger">eupont:WindowFrameOpenedTrigger</a>
    /// </summary>
    let WindowFrameOpenedTrigger = _prefixId.prefix "WindowFrameOpenedTrigger"

    /// <summary>
    ///   <para>rdfs:label : WorseConsumptionConditionAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#WorseConsumptionConditionAction">eupont:WorseConsumptionConditionAction</a>
    /// </summary>
    let WorseConsumptionConditionAction =
        _prefixId.prefix "WorseConsumptionConditionAction"

    /// <summary>
    ///   <para>rdfs:label : WorseConsumptionConditionTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#WorseConsumptionConditionTrigger">eupont:WorseConsumptionConditionTrigger</a>
    /// </summary>
    let WorseConsumptionConditionTrigger =
        _prefixId.prefix "WorseConsumptionConditionTrigger"

    /// <summary>
    ///   <para>rdfs:label : WorseDeviceConditionAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#WorseDeviceConditionAction">eupont:WorseDeviceConditionAction</a>
    /// </summary>
    let WorseDeviceConditionAction = _prefixId.prefix "WorseDeviceConditionAction"
    /// <summary>
    ///   <para>rdfs:label : WorseDeviceConditionTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#WorseDeviceConditionTrigger">eupont:WorseDeviceConditionTrigger</a>
    /// </summary>
    let WorseDeviceConditionTrigger = _prefixId.prefix "WorseDeviceConditionTrigger"
    /// <summary>
    ///   <para>rdfs:label : WorseFunctionalityTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#WorseFunctionalityTrigger">eupont:WorseFunctionalityTrigger</a>
    /// </summary>
    let WorseFunctionalityTrigger = _prefixId.prefix "WorseFunctionalityTrigger"
    /// <summary>
    ///   <para>rdfs:label : WorseUsabilityConditionAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#WorseUsabilityConditionAction">eupont:WorseUsabilityConditionAction</a>
    /// </summary>
    let WorseUsabilityConditionAction = _prefixId.prefix "WorseUsabilityConditionAction"

    /// <summary>
    ///   <para>rdfs:label : WorseUsabilityConditionTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#WorseUsabilityConditionTrigger">eupont:WorseUsabilityConditionTrigger</a>
    /// </summary>
    let WorseUsabilityConditionTrigger =
        _prefixId.prefix "WorseUsabilityConditionTrigger"

    /// <summary>
    ///   <para>rdfs:label : WorsenedHealthyParameterTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#WorsenedHealthyParameterTrigger">eupont:WorsenedHealthyParameterTrigger</a>
    /// </summary>
    let WorsenedHealthyParameterTrigger =
        _prefixId.prefix "WorsenedHealthyParameterTrigger"

    /// <summary>
    ///   <para>rdfs:label : allowTo</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#allowTo">eupont:allowTo</a>
    /// </summary>
    let allowTo = _prefixId.prefix "allowTo"
    /// <summary>
    ///   <para>rdfs:label : canControl</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#canControl">eupont:canControl</a>
    /// </summary>
    let canControl = _prefixId.prefix "canControl"
    /// <summary>
    ///   <para>rdfs:label : channelOffer</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#channelOffer">eupont:channelOffer</a>
    /// </summary>
    let channelOffer = _prefixId.prefix "channelOffer"
    /// <summary>
    ///   <para>rdfs:label : commandAllowTo</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#commandAllowTo">eupont:commandAllowTo</a>
    /// </summary>
    let commandAllowTo = _prefixId.prefix "commandAllowTo"
    /// <summary>
    ///   <para>rdfs:comment : description^^xsd:string</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#description">eupont:description</a>
    /// </summary>
    let description = _prefixId.prefix "description"
    /// <summary>
    ///   <para>rdfs:comment : detail^^xsd:string</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#detail">eupont:detail</a>
    /// </summary>
    let detail = _prefixId.prefix "detail"
    /// <summary>
    ///   <para>rdfs:label : hasAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#hasAction">eupont:hasAction</a>
    /// </summary>
    let hasAction = _prefixId.prefix "hasAction"
    /// <summary>
    ///   <para>rdfs:label : hasCategory</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#hasCategory">eupont:hasCategory</a>
    /// </summary>
    let hasCategory = _prefixId.prefix "hasCategory"
    /// <summary>
    ///   <para>rdfs:label : hasCommand</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#hasCommand">eupont:hasCommand</a>
    /// </summary>
    let hasCommand = _prefixId.prefix "hasCommand"
    /// <summary>
    ///   <para>rdfs:label : hasDetail</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#hasDetail">eupont:hasDetail</a>
    /// </summary>
    let hasDetail = _prefixId.prefix "hasDetail"
    /// <summary>
    ///   <para>rdfs:label : hasNotification</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#hasNotification">eupont:hasNotification</a>
    /// </summary>
    let hasNotification = _prefixId.prefix "hasNotification"
    /// <summary>
    ///   <para>rdfs:label : hasRegisteredEntity</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#hasRegisteredEntity">eupont:hasRegisteredEntity</a>
    /// </summary>
    let hasRegisteredEntity = _prefixId.prefix "hasRegisteredEntity"
    /// <summary>
    ///   <para>rdfs:label : hasService</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#hasService">eupont:hasService</a>
    /// </summary>
    let hasService = _prefixId.prefix "hasService"
    /// <summary>
    ///   <para>rdfs:label : hasTechnology</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#hasTechnology">eupont:hasTechnology</a>
    /// </summary>
    let hasTechnology = _prefixId.prefix "hasTechnology"
    /// <summary>
    ///   <para>rdfs:label : hasTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#hasTrigger">eupont:hasTrigger</a>
    /// </summary>
    let hasTrigger = _prefixId.prefix "hasTrigger"
    /// <summary>
    ///   <para>rdfs:label : isOfChannel</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#isOfChannel">eupont:isOfChannel</a>
    /// </summary>
    let isOfChannel = _prefixId.prefix "isOfChannel"
    /// <summary>
    ///   <para>rdfs:label : location</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#location">eupont:location</a>
    /// </summary>
    let location = _prefixId.prefix "location"
    /// <summary>
    ///   <para>rdfs:label : nominal</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#nominal">eupont:nominal</a>
    /// </summary>
    let nominal = _prefixId.prefix "nominal"
    /// <summary>
    ///   <para>rdfs:label : nominalAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#nominalAction">eupont:nominalAction</a>
    /// </summary>
    let nominalAction = _prefixId.prefix "nominalAction"
    /// <summary>
    ///   <para>rdfs:label : nominalDetail</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#nominalDetail">eupont:nominalDetail</a>
    /// </summary>
    let nominalDetail = _prefixId.prefix "nominalDetail"
    /// <summary>
    ///   <para>rdfs:label : nominalTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#nominalTrigger">eupont:nominalTrigger</a>
    /// </summary>
    let nominalTrigger = _prefixId.prefix "nominalTrigger"
    /// <summary>
    ///   <para>rdfs:label : notificationAllowTo</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#notificationAllowTo">eupont:notificationAllowTo</a>
    /// </summary>
    let notificationAllowTo = _prefixId.prefix "notificationAllowTo"
    /// <summary>
    ///   <para>rdfs:label : offerAction</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#offerAction">eupont:offerAction</a>
    /// </summary>
    let offerAction = _prefixId.prefix "offerAction"
    /// <summary>
    ///   <para>rdfs:label : offerDetail</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#offerDetail">eupont:offerDetail</a>
    /// </summary>
    let offerDetail = _prefixId.prefix "offerDetail"
    /// <summary>
    ///   <para>rdfs:label : offerTrigger</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#offerTrigger">eupont:offerTrigger</a>
    /// </summary>
    let offerTrigger = _prefixId.prefix "offerTrigger"
    /// <summary>
    ///   <para>rdfs:label : triggers</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#triggers">eupont:triggers</a>
    /// </summary>
    let triggers = _prefixId.prefix "triggers"
    /// <summary>
    ///   <para>rdfs:comment : type^^xsd:string</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#type">eupont:type</a>
    /// </summary>
    let type_ = _prefixId.prefix "type"
    /// <summary>
    ///   <para>rdfs:comment : value^^xsd:string</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#value">eupont:value</a>
    /// </summary>
    let value = _prefixId.prefix "value"
    /// <summary>
    ///   <para>rdfs:label : where</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#where">eupont:where</a>
    /// </summary>
    let where = _prefixId.prefix "where"
    /// <summary>
    ///   <para>rdfs:label : which</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#which">eupont:which</a>
    /// </summary>
    let which = _prefixId.prefix "which"
    /// <summary>
    ///   <para>rdfs:label : who</para>
    ///   <a href="http://elite.polito.it/ontologies/eupont.owl#who">eupont:who</a>
    /// </summary>
    let who = _prefixId.prefix "who"
