namespace http.elite.polito.it.ontologies.eupont.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module eupont =
    let _namespace_iri = Namespace_Iri eupont |> NamespaceIRI

    /// <summary>
    ///   <para>eupont:AcceptCommunicationAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"AcceptCommunicationAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#AcceptCommunicationAction">http://elite.polito.it/ontologies/eupont.owl#AcceptCommunicationAction</seealso>
    let AcceptCommunicationAction =
        Prefixed_Name(eupont, "AcceptCommunicationAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:Action</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Action"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#Action">http://elite.polito.it/ontologies/eupont.owl#Action</seealso>
    let Action = Prefixed_Name(eupont, "Action") |> PrefixedName

    /// <summary>
    ///   <para>eupont:ActivateEnvironmentSceneAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ActivateEnvironmentSceneAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#ActivateEnvironmentSceneAction">http://elite.polito.it/ontologies/eupont.owl#ActivateEnvironmentSceneAction</seealso>
    let ActivateEnvironmentSceneAction =
        Prefixed_Name(eupont, "ActivateEnvironmentSceneAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:ActivityAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ActivityAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#ActivityAction">http://elite.polito.it/ontologies/eupont.owl#ActivityAction</seealso>
    let ActivityAction = Prefixed_Name(eupont, "ActivityAction") |> PrefixedName
    /// <summary>
    ///   <para>eupont:ActivityTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ActivityTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#ActivityTrigger">http://elite.polito.it/ontologies/eupont.owl#ActivityTrigger</seealso>
    let ActivityTrigger = Prefixed_Name(eupont, "ActivityTrigger") |> PrefixedName
    /// <summary>
    ///   <para>eupont:AddAlarmAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"AddAlarmAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#AddAlarmAction">http://elite.polito.it/ontologies/eupont.owl#AddAlarmAction</seealso>
    let AddAlarmAction = Prefixed_Name(eupont, "AddAlarmAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:AddCalendarItemAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"AddCalendarItemAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#AddCalendarItemAction">http://elite.polito.it/ontologies/eupont.owl#AddCalendarItemAction</seealso>
    let AddCalendarItemAction =
        Prefixed_Name(eupont, "AddCalendarItemAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:AddRemindAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"AddRemindAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#AddRemindAction">http://elite.polito.it/ontologies/eupont.owl#AddRemindAction</seealso>
    let AddRemindAction = Prefixed_Name(eupont, "AddRemindAction") |> PrefixedName
    /// <summary>
    ///   <para>eupont:AddReminderAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"AddReminderAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#AddReminderAction">http://elite.polito.it/ontologies/eupont.owl#AddReminderAction</seealso>
    let AddReminderAction = Prefixed_Name(eupont, "AddReminderAction") |> PrefixedName
    /// <summary>
    ///   <para>eupont:AddTimerAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"AddTimerAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#AddTimerAction">http://elite.polito.it/ontologies/eupont.owl#AddTimerAction</seealso>
    let AddTimerAction = Prefixed_Name(eupont, "AddTimerAction") |> PrefixedName
    /// <summary>
    ///   <para>eupont:AddedAlarmTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"AddedAlarmTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#AddedAlarmTrigger">http://elite.polito.it/ontologies/eupont.owl#AddedAlarmTrigger</seealso>
    let AddedAlarmTrigger = Prefixed_Name(eupont, "AddedAlarmTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:AddedCalendarItemTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"AddedCalendarItemTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#AddedCalendarItemTrigger">http://elite.polito.it/ontologies/eupont.owl#AddedCalendarItemTrigger</seealso>
    let AddedCalendarItemTrigger =
        Prefixed_Name(eupont, "AddedCalendarItemTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:AddedRemindTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"AddedRemindTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#AddedRemindTrigger">http://elite.polito.it/ontologies/eupont.owl#AddedRemindTrigger</seealso>
    let AddedRemindTrigger = Prefixed_Name(eupont, "AddedRemindTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:AddedReminderTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"AddedReminderTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#AddedReminderTrigger">http://elite.polito.it/ontologies/eupont.owl#AddedReminderTrigger</seealso>
    let AddedReminderTrigger =
        Prefixed_Name(eupont, "AddedReminderTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:AddedTimerTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"AddedTimerTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#AddedTimerTrigger">http://elite.polito.it/ontologies/eupont.owl#AddedTimerTrigger</seealso>
    let AddedTimerTrigger = Prefixed_Name(eupont, "AddedTimerTrigger") |> PrefixedName
    /// <summary>
    ///   <para>eupont:Agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An agent (eg. person, group, software or physical artifact)."</para>
    /// labels<para>"Agent"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#Agent">http://elite.polito.it/ontologies/eupont.owl#Agent</seealso>
    let Agent = Prefixed_Name(eupont, "Agent") |> PrefixedName
    /// <summary>
    ///   <para>eupont:AirConditioner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"AirConditioner"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#AirConditioner">http://elite.polito.it/ontologies/eupont.owl#AirConditioner</seealso>
    let AirConditioner = Prefixed_Name(eupont, "AirConditioner") |> PrefixedName
    /// <summary>
    ///   <para>eupont:AirMonitor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"AirMonitor"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#AirMonitor">http://elite.polito.it/ontologies/eupont.owl#AirMonitor</seealso>
    let AirMonitor = Prefixed_Name(eupont, "AirMonitor") |> PrefixedName
    /// <summary>
    ///   <para>eupont:AirPressureService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"AirPressureService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#AirPressureService">http://elite.polito.it/ontologies/eupont.owl#AirPressureService</seealso>
    let AirPressureService = Prefixed_Name(eupont, "AirPressureService") |> PrefixedName
    /// <summary>
    ///   <para>eupont:AirPurifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"AirPurifier"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#AirPurifier">http://elite.polito.it/ontologies/eupont.owl#AirPurifier</seealso>
    let AirPurifier = Prefixed_Name(eupont, "AirPurifier") |> PrefixedName

    /// <summary>
    ///   <para>eupont:AirPurifierDisabledTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"AirPurifierDisabledTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#AirPurifierDisabledTrigger">http://elite.polito.it/ontologies/eupont.owl#AirPurifierDisabledTrigger</seealso>
    let AirPurifierDisabledTrigger =
        Prefixed_Name(eupont, "AirPurifierDisabledTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:AirPurifierEnabledTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"AirPurifierEnabledTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#AirPurifierEnabledTrigger">http://elite.polito.it/ontologies/eupont.owl#AirPurifierEnabledTrigger</seealso>
    let AirPurifierEnabledTrigger =
        Prefixed_Name(eupont, "AirPurifierEnabledTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:AirPurifierService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"AirPurifierService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#AirPurifierService">http://elite.polito.it/ontologies/eupont.owl#AirPurifierService</seealso>
    let AirPurifierService = Prefixed_Name(eupont, "AirPurifierService") |> PrefixedName
    /// <summary>
    ///   <para>eupont:AlarmClockService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"AlarmClockService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#AlarmClockService">http://elite.polito.it/ontologies/eupont.owl#AlarmClockService</seealso>
    let AlarmClockService = Prefixed_Name(eupont, "AlarmClockService") |> PrefixedName
    /// <summary>
    ///   <para>eupont:AnswerCallAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"AnswerCallAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#AnswerCallAction">http://elite.polito.it/ontologies/eupont.owl#AnswerCallAction</seealso>
    let AnswerCallAction = Prefixed_Name(eupont, "AnswerCallAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:AntiIntrusionSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"AntiIntrusionSystem"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#AntiIntrusionSystem">http://elite.polito.it/ontologies/eupont.owl#AntiIntrusionSystem</seealso>
    let AntiIntrusionSystem =
        Prefixed_Name(eupont, "AntiIntrusionSystem") |> PrefixedName

    /// <summary>
    ///   <para>eupont:Appliance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Appliance"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#Appliance">http://elite.polito.it/ontologies/eupont.owl#Appliance</seealso>
    let Appliance = Prefixed_Name(eupont, "Appliance") |> PrefixedName
    /// <summary>
    ///   <para>eupont:ApplianceService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ApplianceService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#ApplianceService">http://elite.polito.it/ontologies/eupont.owl#ApplianceService</seealso>
    let ApplianceService = Prefixed_Name(eupont, "ApplianceService") |> PrefixedName

    /// <summary>
    ///   <para>eupont:ArriveOnVehicleTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ArriveOnVehicleTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#ArriveOnVehicleTrigger">http://elite.polito.it/ontologies/eupont.owl#ArriveOnVehicleTrigger</seealso>
    let ArriveOnVehicleTrigger =
        Prefixed_Name(eupont, "ArriveOnVehicleTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:AttachementService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"AttachementService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#AttachementService">http://elite.polito.it/ontologies/eupont.owl#AttachementService</seealso>
    let AttachementService = Prefixed_Name(eupont, "AttachementService") |> PrefixedName

    /// <summary>
    ///   <para>eupont:AudioRecordingService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"AudioRecordingService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#AudioRecordingService">http://elite.polito.it/ontologies/eupont.owl#AudioRecordingService</seealso>
    let AudioRecordingService =
        Prefixed_Name(eupont, "AudioRecordingService") |> PrefixedName

    /// <summary>
    ///   <para>eupont:AudioService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"AudioService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#AudioService">http://elite.polito.it/ontologies/eupont.owl#AudioService</seealso>
    let AudioService = Prefixed_Name(eupont, "AudioService") |> PrefixedName
    /// <summary>
    ///   <para>eupont:BatteryService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"BatteryService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#BatteryService">http://elite.polito.it/ontologies/eupont.owl#BatteryService</seealso>
    let BatteryService = Prefixed_Name(eupont, "BatteryService") |> PrefixedName
    /// <summary>
    ///   <para>eupont:Beacon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Beacon"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#Beacon">http://elite.polito.it/ontologies/eupont.owl#Beacon</seealso>
    let Beacon = Prefixed_Name(eupont, "Beacon") |> PrefixedName

    /// <summary>
    ///   <para>eupont:BikeTrackingService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"BikeTrackingService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#BikeTrackingService">http://elite.polito.it/ontologies/eupont.owl#BikeTrackingService</seealso>
    let BikeTrackingService =
        Prefixed_Name(eupont, "BikeTrackingService") |> PrefixedName

    /// <summary>
    ///   <para>eupont:BlockCallAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"BlockCallAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#BlockCallAction">http://elite.polito.it/ontologies/eupont.owl#BlockCallAction</seealso>
    let BlockCallAction = Prefixed_Name(eupont, "BlockCallAction") |> PrefixedName
    /// <summary>
    ///   <para>eupont:Blog</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Blog"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#Blog">http://elite.polito.it/ontologies/eupont.owl#Blog</seealso>
    let Blog = Prefixed_Name(eupont, "Blog") |> PrefixedName
    /// <summary>
    ///   <para>eupont:BluetoothService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"BluetoothService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#BluetoothService">http://elite.polito.it/ontologies/eupont.owl#BluetoothService</seealso>
    let BluetoothService = Prefixed_Name(eupont, "BluetoothService") |> PrefixedName

    /// <summary>
    ///   <para>eupont:BrightnessDecreasedTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"BrightnessDecreasedTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#BrightnessDecreasedTrigger">http://elite.polito.it/ontologies/eupont.owl#BrightnessDecreasedTrigger</seealso>
    let BrightnessDecreasedTrigger =
        Prefixed_Name(eupont, "BrightnessDecreasedTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:BrightnessIncreasedTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"BrightnessIncreasedTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#BrightnessIncreasedTrigger">http://elite.polito.it/ontologies/eupont.owl#BrightnessIncreasedTrigger</seealso>
    let BrightnessIncreasedTrigger =
        Prefixed_Name(eupont, "BrightnessIncreasedTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:Building</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Building"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#Building">http://elite.polito.it/ontologies/eupont.owl#Building</seealso>
    let Building = Prefixed_Name(eupont, "Building") |> PrefixedName
    /// <summary>
    ///   <para>eupont:BuyCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"BuyCommand"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#BuyCommand">http://elite.polito.it/ontologies/eupont.owl#BuyCommand</seealso>
    let BuyCommand = Prefixed_Name(eupont, "BuyCommand") |> PrefixedName
    /// <summary>
    ///   <para>eupont:CalendarService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"CalendarService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#CalendarService">http://elite.polito.it/ontologies/eupont.owl#CalendarService</seealso>
    let CalendarService = Prefixed_Name(eupont, "CalendarService") |> PrefixedName
    /// <summary>
    ///   <para>eupont:CalendarTool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Calendar"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#CalendarTool">http://elite.polito.it/ontologies/eupont.owl#CalendarTool</seealso>
    let CalendarTool = Prefixed_Name(eupont, "CalendarTool") |> PrefixedName
    /// <summary>
    ///   <para>eupont:CallService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"CallService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#CallService">http://elite.polito.it/ontologies/eupont.owl#CallService</seealso>
    let CallService = Prefixed_Name(eupont, "CallService") |> PrefixedName
    /// <summary>
    ///   <para>eupont:CallTool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Call"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#CallTool">http://elite.polito.it/ontologies/eupont.owl#CallTool</seealso>
    let CallTool = Prefixed_Name(eupont, "CallTool") |> PrefixedName
    /// <summary>
    ///   <para>eupont:Camera</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Camera"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#Camera">http://elite.polito.it/ontologies/eupont.owl#Camera</seealso>
    let Camera = Prefixed_Name(eupont, "Camera") |> PrefixedName
    /// <summary>
    ///   <para>eupont:Category</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Category"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#Category">http://elite.polito.it/ontologies/eupont.owl#Category</seealso>
    let Category = Prefixed_Name(eupont, "Category") |> PrefixedName
    /// <summary>
    ///   <para>eupont:Channel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Channel"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#Channel">http://elite.polito.it/ontologies/eupont.owl#Channel</seealso>
    let Channel = Prefixed_Name(eupont, "Channel") |> PrefixedName
    /// <summary>
    ///   <para>eupont:ChatTool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Chat"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#ChatTool">http://elite.polito.it/ontologies/eupont.owl#ChatTool</seealso>
    let ChatTool = Prefixed_Name(eupont, "ChatTool") |> PrefixedName
    /// <summary>
    ///   <para>eupont:CloseCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"CloseCommand"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#CloseCommand">http://elite.polito.it/ontologies/eupont.owl#CloseCommand</seealso>
    let CloseCommand = Prefixed_Name(eupont, "CloseCommand") |> PrefixedName
    /// <summary>
    ///   <para>eupont:CloseNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"CloseNotification"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#CloseNotification">http://elite.polito.it/ontologies/eupont.owl#CloseNotification</seealso>
    let CloseNotification = Prefixed_Name(eupont, "CloseNotification") |> PrefixedName

    /// <summary>
    ///   <para>eupont:CloseSafetyValveAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"CloseSafetyValveAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#CloseSafetyValveAction">http://elite.polito.it/ontologies/eupont.owl#CloseSafetyValveAction</seealso>
    let CloseSafetyValveAction =
        Prefixed_Name(eupont, "CloseSafetyValveAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:CloseWindowFrameAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"CloseWindowFrameAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#CloseWindowFrameAction">http://elite.polito.it/ontologies/eupont.owl#CloseWindowFrameAction</seealso>
    let CloseWindowFrameAction =
        Prefixed_Name(eupont, "CloseWindowFrameAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:CloudPlatform</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"CloudPlatform"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#CloudPlatform">http://elite.polito.it/ontologies/eupont.owl#CloudPlatform</seealso>
    let CloudPlatform = Prefixed_Name(eupont, "CloudPlatform") |> PrefixedName

    /// <summary>
    ///   <para>eupont:CodeHostingPlatform</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"CodeHostingPlatform"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#CodeHostingPlatform">http://elite.polito.it/ontologies/eupont.owl#CodeHostingPlatform</seealso>
    let CodeHostingPlatform =
        Prefixed_Name(eupont, "CodeHostingPlatform") |> PrefixedName

    /// <summary>
    ///   <para>eupont:CoffeeMaker</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"CoffeeMaker"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#CoffeeMaker">http://elite.polito.it/ontologies/eupont.owl#CoffeeMaker</seealso>
    let CoffeeMaker = Prefixed_Name(eupont, "CoffeeMaker") |> PrefixedName
    /// <summary>
    ///   <para>eupont:CoffeeService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"CoffeeService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#CoffeeService">http://elite.polito.it/ontologies/eupont.owl#CoffeeService</seealso>
    let CoffeeService = Prefixed_Name(eupont, "CoffeeService") |> PrefixedName
    /// <summary>
    ///   <para>eupont:Colleague</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Colleague"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#Colleague">http://elite.polito.it/ontologies/eupont.owl#Colleague</seealso>
    let Colleague = Prefixed_Name(eupont, "Colleague") |> PrefixedName
    /// <summary>
    ///   <para>eupont:Command</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Command"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#Command">http://elite.polito.it/ontologies/eupont.owl#Command</seealso>
    let Command = Prefixed_Name(eupont, "Command") |> PrefixedName
    /// <summary>
    ///   <para>eupont:CommentService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"CommentService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#CommentService">http://elite.polito.it/ontologies/eupont.owl#CommentService</seealso>
    let CommentService = Prefixed_Name(eupont, "CommentService") |> PrefixedName

    /// <summary>
    ///   <para>eupont:CommunicationService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"CommunicationService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#CommunicationService">http://elite.polito.it/ontologies/eupont.owl#CommunicationService</seealso>
    let CommunicationService =
        Prefixed_Name(eupont, "CommunicationService") |> PrefixedName

    /// <summary>
    ///   <para>eupont:CommunicationTool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"CommunicationTool"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#CommunicationTool">http://elite.polito.it/ontologies/eupont.owl#CommunicationTool</seealso>
    let CommunicationTool = Prefixed_Name(eupont, "CommunicationTool") |> PrefixedName
    /// <summary>
    ///   <para>eupont:ConnectCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ConnectCommand"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#ConnectCommand">http://elite.polito.it/ontologies/eupont.owl#ConnectCommand</seealso>
    let ConnectCommand = Prefixed_Name(eupont, "ConnectCommand") |> PrefixedName

    /// <summary>
    ///   <para>eupont:ConnectDeviceAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ConnectDeviceAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#ConnectDeviceAction">http://elite.polito.it/ontologies/eupont.owl#ConnectDeviceAction</seealso>
    let ConnectDeviceAction =
        Prefixed_Name(eupont, "ConnectDeviceAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:ConnectNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ConnectNotification"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#ConnectNotification">http://elite.polito.it/ontologies/eupont.owl#ConnectNotification</seealso>
    let ConnectNotification =
        Prefixed_Name(eupont, "ConnectNotification") |> PrefixedName

    /// <summary>
    ///   <para>eupont:ConnectToDeviceAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ConnectToDeviceAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#ConnectToDeviceAction">http://elite.polito.it/ontologies/eupont.owl#ConnectToDeviceAction</seealso>
    let ConnectToDeviceAction =
        Prefixed_Name(eupont, "ConnectToDeviceAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:ConnectToNetworkAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ConnectToNetworkAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#ConnectToNetworkAction">http://elite.polito.it/ontologies/eupont.owl#ConnectToNetworkAction</seealso>
    let ConnectToNetworkAction =
        Prefixed_Name(eupont, "ConnectToNetworkAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:ConnectToWebServiceAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ConnectToWebServiceAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#ConnectToWebServiceAction">http://elite.polito.it/ontologies/eupont.owl#ConnectToWebServiceAction</seealso>
    let ConnectToWebServiceAction =
        Prefixed_Name(eupont, "ConnectToWebServiceAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:ConnectedVehicle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ConnectedVehicle"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#ConnectedVehicle">http://elite.polito.it/ontologies/eupont.owl#ConnectedVehicle</seealso>
    let ConnectedVehicle = Prefixed_Name(eupont, "ConnectedVehicle") |> PrefixedName

    /// <summary>
    ///   <para>eupont:ConnectionToDeviceTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ConnectionToDeviceTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#ConnectionToDeviceTrigger">http://elite.polito.it/ontologies/eupont.owl#ConnectionToDeviceTrigger</seealso>
    let ConnectionToDeviceTrigger =
        Prefixed_Name(eupont, "ConnectionToDeviceTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:ConnectionToNetworkTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ConnectionToNetworkTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#ConnectionToNetworkTrigger">http://elite.polito.it/ontologies/eupont.owl#ConnectionToNetworkTrigger</seealso>
    let ConnectionToNetworkTrigger =
        Prefixed_Name(eupont, "ConnectionToNetworkTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:ConnectivityAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ConnectivityAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#ConnectivityAction">http://elite.polito.it/ontologies/eupont.owl#ConnectivityAction</seealso>
    let ConnectivityAction = Prefixed_Name(eupont, "ConnectivityAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:ConnectivityTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ConnectivityTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#ConnectivityTrigger">http://elite.polito.it/ontologies/eupont.owl#ConnectivityTrigger</seealso>
    let ConnectivityTrigger =
        Prefixed_Name(eupont, "ConnectivityTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:Console</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Console"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#Console">http://elite.polito.it/ontologies/eupont.owl#Console</seealso>
    let Console = Prefixed_Name(eupont, "Console") |> PrefixedName
    /// <summary>
    ///   <para>eupont:ContactService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ContactService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#ContactService">http://elite.polito.it/ontologies/eupont.owl#ContactService</seealso>
    let ContactService = Prefixed_Name(eupont, "ContactService") |> PrefixedName
    /// <summary>
    ///   <para>eupont:Cooker</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Cooker"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#Cooker">http://elite.polito.it/ontologies/eupont.owl#Cooker</seealso>
    let Cooker = Prefixed_Name(eupont, "Cooker") |> PrefixedName
    /// <summary>
    ///   <para>eupont:CoolingService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"CoolingService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#CoolingService">http://elite.polito.it/ontologies/eupont.owl#CoolingService</seealso>
    let CoolingService = Prefixed_Name(eupont, "CoolingService") |> PrefixedName

    /// <summary>
    ///   <para>eupont:CoolingSystemDisabledTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"CoolingSystemDisabledTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#CoolingSystemDisabledTrigger">http://elite.polito.it/ontologies/eupont.owl#CoolingSystemDisabledTrigger</seealso>
    let CoolingSystemDisabledTrigger =
        Prefixed_Name(eupont, "CoolingSystemDisabledTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:CoolingSystemEnabledTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"CoolingSystemEnabledTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#CoolingSystemEnabledTrigger">http://elite.polito.it/ontologies/eupont.owl#CoolingSystemEnabledTrigger</seealso>
    let CoolingSystemEnabledTrigger =
        Prefixed_Name(eupont, "CoolingSystemEnabledTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DIYElectronic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DIYElectronic"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DIYElectronic">http://elite.polito.it/ontologies/eupont.owl#DIYElectronic</seealso>
    let DIYElectronic = Prefixed_Name(eupont, "DIYElectronic") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DangerousActivityDetectedTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DangerousActivityDetectedTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DangerousActivityDetectedTrigger">http://elite.polito.it/ontologies/eupont.owl#DangerousActivityDetectedTrigger</seealso>
    let DangerousActivityDetectedTrigger =
        Prefixed_Name(eupont, "DangerousActivityDetectedTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DangerousActivityTrackingService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DangerousActivityTrackingService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DangerousActivityTrackingService">http://elite.polito.it/ontologies/eupont.owl#DangerousActivityTrackingService</seealso>
    let DangerousActivityTrackingService =
        Prefixed_Name(eupont, "DangerousActivityTrackingService") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DecreaseAirQualityAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DecreaseAirQualityAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DecreaseAirQualityAction">http://elite.polito.it/ontologies/eupont.owl#DecreaseAirQualityAction</seealso>
    let DecreaseAirQualityAction =
        Prefixed_Name(eupont, "DecreaseAirQualityAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DecreaseConnectivityAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DecreaseConnectivityAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DecreaseConnectivityAction">http://elite.polito.it/ontologies/eupont.owl#DecreaseConnectivityAction</seealso>
    let DecreaseConnectivityAction =
        Prefixed_Name(eupont, "DecreaseConnectivityAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DecreaseEnvironmentConditionAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DecreaseEnvironmentConditionAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DecreaseEnvironmentConditionAction">http://elite.polito.it/ontologies/eupont.owl#DecreaseEnvironmentConditionAction</seealso>
    let DecreaseEnvironmentConditionAction =
        Prefixed_Name(eupont, "DecreaseEnvironmentConditionAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DecreaseHumidityAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DecreaseHumidityAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DecreaseHumidityAction">http://elite.polito.it/ontologies/eupont.owl#DecreaseHumidityAction</seealso>
    let DecreaseHumidityAction =
        Prefixed_Name(eupont, "DecreaseHumidityAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DecreaseLightingAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DecreaseLightingAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DecreaseLightingAction">http://elite.polito.it/ontologies/eupont.owl#DecreaseLightingAction</seealso>
    let DecreaseLightingAction =
        Prefixed_Name(eupont, "DecreaseLightingAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DecreaseNoiseAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DecreaseNoiseAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DecreaseNoiseAction">http://elite.polito.it/ontologies/eupont.owl#DecreaseNoiseAction</seealso>
    let DecreaseNoiseAction =
        Prefixed_Name(eupont, "DecreaseNoiseAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DecreaseSecurityAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DecreaseSecurityAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DecreaseSecurityAction">http://elite.polito.it/ontologies/eupont.owl#DecreaseSecurityAction</seealso>
    let DecreaseSecurityAction =
        Prefixed_Name(eupont, "DecreaseSecurityAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DecreaseTemperatureAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DecreaseTemperatureAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DecreaseTemperatureAction">http://elite.polito.it/ontologies/eupont.owl#DecreaseTemperatureAction</seealso>
    let DecreaseTemperatureAction =
        Prefixed_Name(eupont, "DecreaseTemperatureAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DecreaseUserConnectivityAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DecreaseUserConnectivityAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DecreaseUserConnectivityAction">http://elite.polito.it/ontologies/eupont.owl#DecreaseUserConnectivityAction</seealso>
    let DecreaseUserConnectivityAction =
        Prefixed_Name(eupont, "DecreaseUserConnectivityAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DecreaseVolumeAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DecreaseVolumeAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DecreaseVolumeAction">http://elite.polito.it/ontologies/eupont.owl#DecreaseVolumeAction</seealso>
    let DecreaseVolumeAction =
        Prefixed_Name(eupont, "DecreaseVolumeAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DecreasedAirPressureTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DecreasedAirPressureTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DecreasedAirPressureTrigger">http://elite.polito.it/ontologies/eupont.owl#DecreasedAirPressureTrigger</seealso>
    let DecreasedAirPressureTrigger =
        Prefixed_Name(eupont, "DecreasedAirPressureTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DecreasedAirQualityTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DecreasedAirQualityTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DecreasedAirQualityTrigger">http://elite.polito.it/ontologies/eupont.owl#DecreasedAirQualityTrigger</seealso>
    let DecreasedAirQualityTrigger =
        Prefixed_Name(eupont, "DecreasedAirQualityTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DecreasedConnectivityTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DecreasedConnectivityTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DecreasedConnectivityTrigger">http://elite.polito.it/ontologies/eupont.owl#DecreasedConnectivityTrigger</seealso>
    let DecreasedConnectivityTrigger =
        Prefixed_Name(eupont, "DecreasedConnectivityTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DecreasedHealthConditionTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DecreasedHealthConditionTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DecreasedHealthConditionTrigger">http://elite.polito.it/ontologies/eupont.owl#DecreasedHealthConditionTrigger</seealso>
    let DecreasedHealthConditionTrigger =
        Prefixed_Name(eupont, "DecreasedHealthConditionTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DecreasedHumidityTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DecreasedHumidityTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DecreasedHumidityTrigger">http://elite.polito.it/ontologies/eupont.owl#DecreasedHumidityTrigger</seealso>
    let DecreasedHumidityTrigger =
        Prefixed_Name(eupont, "DecreasedHumidityTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DecreasedLightingTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DecreasedLightingTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DecreasedLightingTrigger">http://elite.polito.it/ontologies/eupont.owl#DecreasedLightingTrigger</seealso>
    let DecreasedLightingTrigger =
        Prefixed_Name(eupont, "DecreasedLightingTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DecreasedNoiseLevelTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DecreasedNoiseLevelTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DecreasedNoiseLevelTrigger">http://elite.polito.it/ontologies/eupont.owl#DecreasedNoiseLevelTrigger</seealso>
    let DecreasedNoiseLevelTrigger =
        Prefixed_Name(eupont, "DecreasedNoiseLevelTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DecreasedSecurityTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DecreasedSecurityTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DecreasedSecurityTrigger">http://elite.polito.it/ontologies/eupont.owl#DecreasedSecurityTrigger</seealso>
    let DecreasedSecurityTrigger =
        Prefixed_Name(eupont, "DecreasedSecurityTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DecreasedTemperatureTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DecreasedTemperatureTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DecreasedTemperatureTrigger">http://elite.polito.it/ontologies/eupont.owl#DecreasedTemperatureTrigger</seealso>
    let DecreasedTemperatureTrigger =
        Prefixed_Name(eupont, "DecreasedTemperatureTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DecreasedWeatherConditionsTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DecreasedWeatherConditionsTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DecreasedWeatherConditionsTrigger">http://elite.polito.it/ontologies/eupont.owl#DecreasedWeatherConditionsTrigger</seealso>
    let DecreasedWeatherConditionsTrigger =
        Prefixed_Name(eupont, "DecreasedWeatherConditionsTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:Dehumidifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Dehumidifier"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#Dehumidifier">http://elite.polito.it/ontologies/eupont.owl#Dehumidifier</seealso>
    let Dehumidifier = Prefixed_Name(eupont, "Dehumidifier") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DehumidifierService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DehumidifierService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DehumidifierService">http://elite.polito.it/ontologies/eupont.owl#DehumidifierService</seealso>
    let DehumidifierService =
        Prefixed_Name(eupont, "DehumidifierService") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DehumidifierSystemDisabledTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DehumidifierSystemDisabledTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DehumidifierSystemDisabledTrigger">http://elite.polito.it/ontologies/eupont.owl#DehumidifierSystemDisabledTrigger</seealso>
    let DehumidifierSystemDisabledTrigger =
        Prefixed_Name(eupont, "DehumidifierSystemDisabledTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DehumidifierSystemEnabledTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DehumidifierSystemEnabledTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DehumidifierSystemEnabledTrigger">http://elite.polito.it/ontologies/eupont.owl#DehumidifierSystemEnabledTrigger</seealso>
    let DehumidifierSystemEnabledTrigger =
        Prefixed_Name(eupont, "DehumidifierSystemEnabledTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DeleteAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DeleteAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DeleteAction">http://elite.polito.it/ontologies/eupont.owl#DeleteAction</seealso>
    let DeleteAction = Prefixed_Name(eupont, "DeleteAction") |> PrefixedName
    /// <summary>
    ///   <para>eupont:DeleteAlarmAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DeleteAlarmAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DeleteAlarmAction">http://elite.polito.it/ontologies/eupont.owl#DeleteAlarmAction</seealso>
    let DeleteAlarmAction = Prefixed_Name(eupont, "DeleteAlarmAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DeleteCalendarItemAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DeleteCalendarItemAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DeleteCalendarItemAction">http://elite.polito.it/ontologies/eupont.owl#DeleteCalendarItemAction</seealso>
    let DeleteCalendarItemAction =
        Prefixed_Name(eupont, "DeleteCalendarItemAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DeleteCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DeleteCommand"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DeleteCommand">http://elite.polito.it/ontologies/eupont.owl#DeleteCommand</seealso>
    let DeleteCommand = Prefixed_Name(eupont, "DeleteCommand") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DeleteContactAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DeleteContactAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DeleteContactAction">http://elite.polito.it/ontologies/eupont.owl#DeleteContactAction</seealso>
    let DeleteContactAction =
        Prefixed_Name(eupont, "DeleteContactAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DeleteFileAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DeleteFileAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DeleteFileAction">http://elite.polito.it/ontologies/eupont.owl#DeleteFileAction</seealso>
    let DeleteFileAction = Prefixed_Name(eupont, "DeleteFileAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DeleteFromStorageAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DeleteFromStorageAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DeleteFromStorageAction">http://elite.polito.it/ontologies/eupont.owl#DeleteFromStorageAction</seealso>
    let DeleteFromStorageAction =
        Prefixed_Name(eupont, "DeleteFromStorageAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DeleteHealthInformationAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DeleteHealthInformationAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DeleteHealthInformationAction">http://elite.polito.it/ontologies/eupont.owl#DeleteHealthInformationAction</seealso>
    let DeleteHealthInformationAction =
        Prefixed_Name(eupont, "DeleteHealthInformationAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DeleteMediaInformationAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DeleteMediaInformationAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DeleteMediaInformationAction">http://elite.polito.it/ontologies/eupont.owl#DeleteMediaInformationAction</seealso>
    let DeleteMediaInformationAction =
        Prefixed_Name(eupont, "DeleteMediaInformationAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DeleteNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DeleteNotification"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DeleteNotification">http://elite.polito.it/ontologies/eupont.owl#DeleteNotification</seealso>
    let DeleteNotification = Prefixed_Name(eupont, "DeleteNotification") |> PrefixedName
    /// <summary>
    ///   <para>eupont:DeleteRemindAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DeleteRemindAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DeleteRemindAction">http://elite.polito.it/ontologies/eupont.owl#DeleteRemindAction</seealso>
    let DeleteRemindAction = Prefixed_Name(eupont, "DeleteRemindAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DeleteReminderAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DeleteReminderAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DeleteReminderAction">http://elite.polito.it/ontologies/eupont.owl#DeleteReminderAction</seealso>
    let DeleteReminderAction =
        Prefixed_Name(eupont, "DeleteReminderAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DeleteTimerAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DeleteTimerAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DeleteTimerAction">http://elite.polito.it/ontologies/eupont.owl#DeleteTimerAction</seealso>
    let DeleteTimerAction = Prefixed_Name(eupont, "DeleteTimerAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DeleteWebBookmarkAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DeleteWebBookmarkAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DeleteWebBookmarkAction">http://elite.polito.it/ontologies/eupont.owl#DeleteWebBookmarkAction</seealso>
    let DeleteWebBookmarkAction =
        Prefixed_Name(eupont, "DeleteWebBookmarkAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DeletedAlarmTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DeletedAlarmTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DeletedAlarmTrigger">http://elite.polito.it/ontologies/eupont.owl#DeletedAlarmTrigger</seealso>
    let DeletedAlarmTrigger =
        Prefixed_Name(eupont, "DeletedAlarmTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DeletedAppTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DeletedAppTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DeletedAppTrigger">http://elite.polito.it/ontologies/eupont.owl#DeletedAppTrigger</seealso>
    let DeletedAppTrigger = Prefixed_Name(eupont, "DeletedAppTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DeletedCalendarItemTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DeletedCalendarItemTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DeletedCalendarItemTrigger">http://elite.polito.it/ontologies/eupont.owl#DeletedCalendarItemTrigger</seealso>
    let DeletedCalendarItemTrigger =
        Prefixed_Name(eupont, "DeletedCalendarItemTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DeletedContactTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DeletedContactTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DeletedContactTrigger">http://elite.polito.it/ontologies/eupont.owl#DeletedContactTrigger</seealso>
    let DeletedContactTrigger =
        Prefixed_Name(eupont, "DeletedContactTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DeletedFileTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DeletedFileTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DeletedFileTrigger">http://elite.polito.it/ontologies/eupont.owl#DeletedFileTrigger</seealso>
    let DeletedFileTrigger = Prefixed_Name(eupont, "DeletedFileTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DeletedFromStorageTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DeletedFromStorageTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DeletedFromStorageTrigger">http://elite.polito.it/ontologies/eupont.owl#DeletedFromStorageTrigger</seealso>
    let DeletedFromStorageTrigger =
        Prefixed_Name(eupont, "DeletedFromStorageTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DeletedHealthInformationTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DeletedHealthInformationTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DeletedHealthInformationTrigger">http://elite.polito.it/ontologies/eupont.owl#DeletedHealthInformationTrigger</seealso>
    let DeletedHealthInformationTrigger =
        Prefixed_Name(eupont, "DeletedHealthInformationTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DeletedMediaInformationTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DeletedMediaInformationTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DeletedMediaInformationTrigger">http://elite.polito.it/ontologies/eupont.owl#DeletedMediaInformationTrigger</seealso>
    let DeletedMediaInformationTrigger =
        Prefixed_Name(eupont, "DeletedMediaInformationTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DeletedRemindTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DeletedRemindTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DeletedRemindTrigger">http://elite.polito.it/ontologies/eupont.owl#DeletedRemindTrigger</seealso>
    let DeletedRemindTrigger =
        Prefixed_Name(eupont, "DeletedRemindTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DeletedReminderTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DeletedReminderTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DeletedReminderTrigger">http://elite.polito.it/ontologies/eupont.owl#DeletedReminderTrigger</seealso>
    let DeletedReminderTrigger =
        Prefixed_Name(eupont, "DeletedReminderTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DeletedTimerTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DeletedTimerTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DeletedTimerTrigger">http://elite.polito.it/ontologies/eupont.owl#DeletedTimerTrigger</seealso>
    let DeletedTimerTrigger =
        Prefixed_Name(eupont, "DeletedTimerTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DeletedTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DeletedTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DeletedTrigger">http://elite.polito.it/ontologies/eupont.owl#DeletedTrigger</seealso>
    let DeletedTrigger = Prefixed_Name(eupont, "DeletedTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DeletedWebBookmarkTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DeletedWebBookmarkTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DeletedWebBookmarkTrigger">http://elite.polito.it/ontologies/eupont.owl#DeletedWebBookmarkTrigger</seealso>
    let DeletedWebBookmarkTrigger =
        Prefixed_Name(eupont, "DeletedWebBookmarkTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:Detail</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Detail"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#Detail">http://elite.polito.it/ontologies/eupont.owl#Detail</seealso>
    let Detail = Prefixed_Name(eupont, "Detail") |> PrefixedName
    /// <summary>
    ///   <para>eupont:DeveloperTool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DeveloperTool"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DeveloperTool">http://elite.polito.it/ontologies/eupont.owl#DeveloperTool</seealso>
    let DeveloperTool = Prefixed_Name(eupont, "DeveloperTool") |> PrefixedName
    /// <summary>
    ///   <para>eupont:DeviceAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DeviceAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DeviceAction">http://elite.polito.it/ontologies/eupont.owl#DeviceAction</seealso>
    let DeviceAction = Prefixed_Name(eupont, "DeviceAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DeviceConnectedTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DeviceConnectedTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DeviceConnectedTrigger">http://elite.polito.it/ontologies/eupont.owl#DeviceConnectedTrigger</seealso>
    let DeviceConnectedTrigger =
        Prefixed_Name(eupont, "DeviceConnectedTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DeviceConnectivityDisabledTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DeviceConnectivityDisabledTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DeviceConnectivityDisabledTrigger">http://elite.polito.it/ontologies/eupont.owl#DeviceConnectivityDisabledTrigger</seealso>
    let DeviceConnectivityDisabledTrigger =
        Prefixed_Name(eupont, "DeviceConnectivityDisabledTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DeviceConnectivityEnabledTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DeviceConnectivityEnabledTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DeviceConnectivityEnabledTrigger">http://elite.polito.it/ontologies/eupont.owl#DeviceConnectivityEnabledTrigger</seealso>
    let DeviceConnectivityEnabledTrigger =
        Prefixed_Name(eupont, "DeviceConnectivityEnabledTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DeviceDisconnectedTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DeviceDisconnectedTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DeviceDisconnectedTrigger">http://elite.polito.it/ontologies/eupont.owl#DeviceDisconnectedTrigger</seealso>
    let DeviceDisconnectedTrigger =
        Prefixed_Name(eupont, "DeviceDisconnectedTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DeviceFailureTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DeviceFailureTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DeviceFailureTrigger">http://elite.polito.it/ontologies/eupont.owl#DeviceFailureTrigger</seealso>
    let DeviceFailureTrigger =
        Prefixed_Name(eupont, "DeviceFailureTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DeviceLeakTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DeviceLeakTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DeviceLeakTrigger">http://elite.polito.it/ontologies/eupont.owl#DeviceLeakTrigger</seealso>
    let DeviceLeakTrigger = Prefixed_Name(eupont, "DeviceLeakTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DevicePluggedTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DevicePluggedTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DevicePluggedTrigger">http://elite.polito.it/ontologies/eupont.owl#DevicePluggedTrigger</seealso>
    let DevicePluggedTrigger =
        Prefixed_Name(eupont, "DevicePluggedTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DeviceSavingModeDisabledTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DeviceSavingModeDisabledTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DeviceSavingModeDisabledTrigger">http://elite.polito.it/ontologies/eupont.owl#DeviceSavingModeDisabledTrigger</seealso>
    let DeviceSavingModeDisabledTrigger =
        Prefixed_Name(eupont, "DeviceSavingModeDisabledTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DeviceSavingModeEnabledTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DeviceSavingModeEnabledTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DeviceSavingModeEnabledTrigger">http://elite.polito.it/ontologies/eupont.owl#DeviceSavingModeEnabledTrigger</seealso>
    let DeviceSavingModeEnabledTrigger =
        Prefixed_Name(eupont, "DeviceSavingModeEnabledTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DeviceService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DeviceService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DeviceService">http://elite.polito.it/ontologies/eupont.owl#DeviceService</seealso>
    let DeviceService = Prefixed_Name(eupont, "DeviceService") |> PrefixedName
    /// <summary>
    ///   <para>eupont:DeviceTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DeviceTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DeviceTrigger">http://elite.polito.it/ontologies/eupont.owl#DeviceTrigger</seealso>
    let DeviceTrigger = Prefixed_Name(eupont, "DeviceTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DeviceTurnedOffTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DeviceTurnedOffTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DeviceTurnedOffTrigger">http://elite.polito.it/ontologies/eupont.owl#DeviceTurnedOffTrigger</seealso>
    let DeviceTurnedOffTrigger =
        Prefixed_Name(eupont, "DeviceTurnedOffTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DeviceTurnedOnTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DeviceTurnedOnTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DeviceTurnedOnTrigger">http://elite.polito.it/ontologies/eupont.owl#DeviceTurnedOnTrigger</seealso>
    let DeviceTurnedOnTrigger =
        Prefixed_Name(eupont, "DeviceTurnedOnTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DeviceUnpluggedTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DeviceUnpluggedTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DeviceUnpluggedTrigger">http://elite.polito.it/ontologies/eupont.owl#DeviceUnpluggedTrigger</seealso>
    let DeviceUnpluggedTrigger =
        Prefixed_Name(eupont, "DeviceUnpluggedTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DeviceUsageWarningTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DeviceUsageWarningTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DeviceUsageWarningTrigger">http://elite.polito.it/ontologies/eupont.owl#DeviceUsageWarningTrigger</seealso>
    let DeviceUsageWarningTrigger =
        Prefixed_Name(eupont, "DeviceUsageWarningTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DisableAirPurifierSystemAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DisableAirPurifierSystemAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DisableAirPurifierSystemAction">http://elite.polito.it/ontologies/eupont.owl#DisableAirPurifierSystemAction</seealso>
    let DisableAirPurifierSystemAction =
        Prefixed_Name(eupont, "DisableAirPurifierSystemAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DisableAirplaneModeAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DisableAirplaneModeAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DisableAirplaneModeAction">http://elite.polito.it/ontologies/eupont.owl#DisableAirplaneModeAction</seealso>
    let DisableAirplaneModeAction =
        Prefixed_Name(eupont, "DisableAirplaneModeAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DisableBluetoothConnectivityAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DisableBluetoothConnectivityAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DisableBluetoothConnectivityAction">http://elite.polito.it/ontologies/eupont.owl#DisableBluetoothConnectivityAction</seealso>
    let DisableBluetoothConnectivityAction =
        Prefixed_Name(eupont, "DisableBluetoothConnectivityAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DisableCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DisableCommand"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DisableCommand">http://elite.polito.it/ontologies/eupont.owl#DisableCommand</seealso>
    let DisableCommand = Prefixed_Name(eupont, "DisableCommand") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DisableCoolingSystemAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DisableCoolingSystemAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DisableCoolingSystemAction">http://elite.polito.it/ontologies/eupont.owl#DisableCoolingSystemAction</seealso>
    let DisableCoolingSystemAction =
        Prefixed_Name(eupont, "DisableCoolingSystemAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DisableDehumidifierSystemAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DisableDehumidifierSystemAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DisableDehumidifierSystemAction">http://elite.polito.it/ontologies/eupont.owl#DisableDehumidifierSystemAction</seealso>
    let DisableDehumidifierSystemAction =
        Prefixed_Name(eupont, "DisableDehumidifierSystemAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DisableDeviceConnectivityAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DisableDeviceConnectivityAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DisableDeviceConnectivityAction">http://elite.polito.it/ontologies/eupont.owl#DisableDeviceConnectivityAction</seealso>
    let DisableDeviceConnectivityAction =
        Prefixed_Name(eupont, "DisableDeviceConnectivityAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DisableDeviceSavingModeAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DisableDeviceSavingModeAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DisableDeviceSavingModeAction">http://elite.polito.it/ontologies/eupont.owl#DisableDeviceSavingModeAction</seealso>
    let DisableDeviceSavingModeAction =
        Prefixed_Name(eupont, "DisableDeviceSavingModeAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DisableGPSAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DisableGPSAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DisableGPSAction">http://elite.polito.it/ontologies/eupont.owl#DisableGPSAction</seealso>
    let DisableGPSAction = Prefixed_Name(eupont, "DisableGPSAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DisableHeatingSystemAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DisableHeatingSystemAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DisableHeatingSystemAction">http://elite.polito.it/ontologies/eupont.owl#DisableHeatingSystemAction</seealso>
    let DisableHeatingSystemAction =
        Prefixed_Name(eupont, "DisableHeatingSystemAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DisableHumidifierSystemAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DisableHumidifierSystemAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DisableHumidifierSystemAction">http://elite.polito.it/ontologies/eupont.owl#DisableHumidifierSystemAction</seealso>
    let DisableHumidifierSystemAction =
        Prefixed_Name(eupont, "DisableHumidifierSystemAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DisableInternetConnectivityAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DisableInternetConnectivityAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DisableInternetConnectivityAction">http://elite.polito.it/ontologies/eupont.owl#DisableInternetConnectivityAction</seealso>
    let DisableInternetConnectivityAction =
        Prefixed_Name(eupont, "DisableInternetConnectivityAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DisableLightingSystemAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DisableLightingSystemAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DisableLightingSystemAction">http://elite.polito.it/ontologies/eupont.owl#DisableLightingSystemAction</seealso>
    let DisableLightingSystemAction =
        Prefixed_Name(eupont, "DisableLightingSystemAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DisableNFCConnectivityAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DisableNFCConnectivityAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DisableNFCConnectivityAction">http://elite.polito.it/ontologies/eupont.owl#DisableNFCConnectivityAction</seealso>
    let DisableNFCConnectivityAction =
        Prefixed_Name(eupont, "DisableNFCConnectivityAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DisableNightModeAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DisableNightModeAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DisableNightModeAction">http://elite.polito.it/ontologies/eupont.owl#DisableNightModeAction</seealso>
    let DisableNightModeAction =
        Prefixed_Name(eupont, "DisableNightModeAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DisableNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DisableNotification"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DisableNotification">http://elite.polito.it/ontologies/eupont.owl#DisableNotification</seealso>
    let DisableNotification =
        Prefixed_Name(eupont, "DisableNotification") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DisableNotificationsAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DisableNotificationsAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DisableNotificationsAction">http://elite.polito.it/ontologies/eupont.owl#DisableNotificationsAction</seealso>
    let DisableNotificationsAction =
        Prefixed_Name(eupont, "DisableNotificationsAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DisableScreenRotationAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DisableScreenRotationAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DisableScreenRotationAction">http://elite.polito.it/ontologies/eupont.owl#DisableScreenRotationAction</seealso>
    let DisableScreenRotationAction =
        Prefixed_Name(eupont, "DisableScreenRotationAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DisableSecuritySystemAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DisableSecuritySystemAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DisableSecuritySystemAction">http://elite.polito.it/ontologies/eupont.owl#DisableSecuritySystemAction</seealso>
    let DisableSecuritySystemAction =
        Prefixed_Name(eupont, "DisableSecuritySystemAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DisableWateringSystemAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DisableWateringSystemAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DisableWateringSystemAction">http://elite.polito.it/ontologies/eupont.owl#DisableWateringSystemAction</seealso>
    let DisableWateringSystemAction =
        Prefixed_Name(eupont, "DisableWateringSystemAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DisabledAirplaneModeTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DisabledAirplaneModeTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DisabledAirplaneModeTrigger">http://elite.polito.it/ontologies/eupont.owl#DisabledAirplaneModeTrigger</seealso>
    let DisabledAirplaneModeTrigger =
        Prefixed_Name(eupont, "DisabledAirplaneModeTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DisabledBluetoothConnectivityTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DisabledBluetoothConnectivityTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DisabledBluetoothConnectivityTrigger">http://elite.polito.it/ontologies/eupont.owl#DisabledBluetoothConnectivityTrigger</seealso>
    let DisabledBluetoothConnectivityTrigger =
        Prefixed_Name(eupont, "DisabledBluetoothConnectivityTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DisabledGPSTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DisabledGPSTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DisabledGPSTrigger">http://elite.polito.it/ontologies/eupont.owl#DisabledGPSTrigger</seealso>
    let DisabledGPSTrigger = Prefixed_Name(eupont, "DisabledGPSTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DisabledInternetConnectivityTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DisabledInternetConnectivityTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DisabledInternetConnectivityTrigger">http://elite.polito.it/ontologies/eupont.owl#DisabledInternetConnectivityTrigger</seealso>
    let DisabledInternetConnectivityTrigger =
        Prefixed_Name(eupont, "DisabledInternetConnectivityTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DisabledNFCConnectivityTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DisabledNFCConnectivityTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DisabledNFCConnectivityTrigger">http://elite.polito.it/ontologies/eupont.owl#DisabledNFCConnectivityTrigger</seealso>
    let DisabledNFCConnectivityTrigger =
        Prefixed_Name(eupont, "DisabledNFCConnectivityTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DisconnectCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DisconnectCommand"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DisconnectCommand">http://elite.polito.it/ontologies/eupont.owl#DisconnectCommand</seealso>
    let DisconnectCommand = Prefixed_Name(eupont, "DisconnectCommand") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DisconnectDeviceAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DisconnectDeviceAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DisconnectDeviceAction">http://elite.polito.it/ontologies/eupont.owl#DisconnectDeviceAction</seealso>
    let DisconnectDeviceAction =
        Prefixed_Name(eupont, "DisconnectDeviceAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DisconnectFromDeviceAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DisconnectFromDeviceAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DisconnectFromDeviceAction">http://elite.polito.it/ontologies/eupont.owl#DisconnectFromDeviceAction</seealso>
    let DisconnectFromDeviceAction =
        Prefixed_Name(eupont, "DisconnectFromDeviceAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DisconnectFromNetworkAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DisconnectFromNetworkAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DisconnectFromNetworkAction">http://elite.polito.it/ontologies/eupont.owl#DisconnectFromNetworkAction</seealso>
    let DisconnectFromNetworkAction =
        Prefixed_Name(eupont, "DisconnectFromNetworkAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DisconnectNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DisconnectNotification"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DisconnectNotification">http://elite.polito.it/ontologies/eupont.owl#DisconnectNotification</seealso>
    let DisconnectNotification =
        Prefixed_Name(eupont, "DisconnectNotification") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DisconnectedFromDeviceTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DisconnectedFromDeviceTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DisconnectedFromDeviceTrigger">http://elite.polito.it/ontologies/eupont.owl#DisconnectedFromDeviceTrigger</seealso>
    let DisconnectedFromDeviceTrigger =
        Prefixed_Name(eupont, "DisconnectedFromDeviceTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:DisconnectedFromNetworkTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DisconnectedFromNetworkTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DisconnectedFromNetworkTrigger">http://elite.polito.it/ontologies/eupont.owl#DisconnectedFromNetworkTrigger</seealso>
    let DisconnectedFromNetworkTrigger =
        Prefixed_Name(eupont, "DisconnectedFromNetworkTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:Dishwasher</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Dishwasher"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#Dishwasher">http://elite.polito.it/ontologies/eupont.owl#Dishwasher</seealso>
    let Dishwasher = Prefixed_Name(eupont, "Dishwasher") |> PrefixedName
    /// <summary>
    ///   <para>eupont:DisplaySerivce</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DisplayService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DisplaySerivce">http://elite.polito.it/ontologies/eupont.owl#DisplaySerivce</seealso>
    let DisplaySerivce = Prefixed_Name(eupont, "DisplaySerivce") |> PrefixedName
    /// <summary>
    ///   <para>eupont:DisplyService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DisplayService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DisplyService">http://elite.polito.it/ontologies/eupont.owl#DisplyService</seealso>
    let DisplyService = Prefixed_Name(eupont, "DisplyService") |> PrefixedName
    /// <summary>
    ///   <para>eupont:DiswashingService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DiswashingService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DiswashingService">http://elite.polito.it/ontologies/eupont.owl#DiswashingService</seealso>
    let DiswashingService = Prefixed_Name(eupont, "DiswashingService") |> PrefixedName
    /// <summary>
    ///   <para>eupont:Dryer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Dryer"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#Dryer">http://elite.polito.it/ontologies/eupont.owl#Dryer</seealso>
    let Dryer = Prefixed_Name(eupont, "Dryer") |> PrefixedName
    /// <summary>
    ///   <para>eupont:DryingService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DryingService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DryingService">http://elite.polito.it/ontologies/eupont.owl#DryingService</seealso>
    let DryingService = Prefixed_Name(eupont, "DryingService") |> PrefixedName
    /// <summary>
    ///   <para>eupont:DvdPlayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DVDPlayer"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#DvdPlayer">http://elite.polito.it/ontologies/eupont.owl#DvdPlayer</seealso>
    let DvdPlayer = Prefixed_Name(eupont, "DvdPlayer") |> PrefixedName
    /// <summary>
    ///   <para>eupont:EUDPlatform</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"EUDPlatform"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#EUDPlatform">http://elite.polito.it/ontologies/eupont.owl#EUDPlatform</seealso>
    let EUDPlatform = Prefixed_Name(eupont, "EUDPlatform") |> PrefixedName
    /// <summary>
    ///   <para>eupont:EcommerceService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"EcommerceService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#EcommerceService">http://elite.polito.it/ontologies/eupont.owl#EcommerceService</seealso>
    let EcommerceService = Prefixed_Name(eupont, "EcommerceService") |> PrefixedName
    /// <summary>
    ///   <para>eupont:EcommerceWebSite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ECommerceWebsite"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#EcommerceWebSite">http://elite.polito.it/ontologies/eupont.owl#EcommerceWebSite</seealso>
    let EcommerceWebSite = Prefixed_Name(eupont, "EcommerceWebSite") |> PrefixedName
    /// <summary>
    ///   <para>eupont:EmailTool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"EMail"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#EmailTool">http://elite.polito.it/ontologies/eupont.owl#EmailTool</seealso>
    let EmailTool = Prefixed_Name(eupont, "EmailTool") |> PrefixedName

    /// <summary>
    ///   <para>eupont:EnableAirPurifierSystemAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"EnableAirPurifierSystemAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#EnableAirPurifierSystemAction">http://elite.polito.it/ontologies/eupont.owl#EnableAirPurifierSystemAction</seealso>
    let EnableAirPurifierSystemAction =
        Prefixed_Name(eupont, "EnableAirPurifierSystemAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:EnableAirplaneModeAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"EnableAirplaneModeAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#EnableAirplaneModeAction">http://elite.polito.it/ontologies/eupont.owl#EnableAirplaneModeAction</seealso>
    let EnableAirplaneModeAction =
        Prefixed_Name(eupont, "EnableAirplaneModeAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:EnableBluetoothConnectivityAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"EnableBluetoothConnectivityAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#EnableBluetoothConnectivityAction">http://elite.polito.it/ontologies/eupont.owl#EnableBluetoothConnectivityAction</seealso>
    let EnableBluetoothConnectivityAction =
        Prefixed_Name(eupont, "EnableBluetoothConnectivityAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:EnableCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"EnableCommand"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#EnableCommand">http://elite.polito.it/ontologies/eupont.owl#EnableCommand</seealso>
    let EnableCommand = Prefixed_Name(eupont, "EnableCommand") |> PrefixedName

    /// <summary>
    ///   <para>eupont:EnableCoolingSystemAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"EnableCoolingSystemAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#EnableCoolingSystemAction">http://elite.polito.it/ontologies/eupont.owl#EnableCoolingSystemAction</seealso>
    let EnableCoolingSystemAction =
        Prefixed_Name(eupont, "EnableCoolingSystemAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:EnableDehumidifierSystemAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"EnableDehumidifierSystemAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#EnableDehumidifierSystemAction">http://elite.polito.it/ontologies/eupont.owl#EnableDehumidifierSystemAction</seealso>
    let EnableDehumidifierSystemAction =
        Prefixed_Name(eupont, "EnableDehumidifierSystemAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:EnableDeviceConnectivityAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"EnableDeviceConnectivityAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#EnableDeviceConnectivityAction">http://elite.polito.it/ontologies/eupont.owl#EnableDeviceConnectivityAction</seealso>
    let EnableDeviceConnectivityAction =
        Prefixed_Name(eupont, "EnableDeviceConnectivityAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:EnableDeviceSavingModeAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"EnableDeviceSavingModeAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#EnableDeviceSavingModeAction">http://elite.polito.it/ontologies/eupont.owl#EnableDeviceSavingModeAction</seealso>
    let EnableDeviceSavingModeAction =
        Prefixed_Name(eupont, "EnableDeviceSavingModeAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:EnableGPSAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"EnableGPSAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#EnableGPSAction">http://elite.polito.it/ontologies/eupont.owl#EnableGPSAction</seealso>
    let EnableGPSAction = Prefixed_Name(eupont, "EnableGPSAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:EnableHeatingSystemAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"EnableHeatingSystemAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#EnableHeatingSystemAction">http://elite.polito.it/ontologies/eupont.owl#EnableHeatingSystemAction</seealso>
    let EnableHeatingSystemAction =
        Prefixed_Name(eupont, "EnableHeatingSystemAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:EnableHumidifierSystemAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"EnableHumidifierSystemAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#EnableHumidifierSystemAction">http://elite.polito.it/ontologies/eupont.owl#EnableHumidifierSystemAction</seealso>
    let EnableHumidifierSystemAction =
        Prefixed_Name(eupont, "EnableHumidifierSystemAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:EnableInternetConnectivityAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"EnableInternetConnectivityAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#EnableInternetConnectivityAction">http://elite.polito.it/ontologies/eupont.owl#EnableInternetConnectivityAction</seealso>
    let EnableInternetConnectivityAction =
        Prefixed_Name(eupont, "EnableInternetConnectivityAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:EnableLightingSystemAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"EnableLightingSystemAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#EnableLightingSystemAction">http://elite.polito.it/ontologies/eupont.owl#EnableLightingSystemAction</seealso>
    let EnableLightingSystemAction =
        Prefixed_Name(eupont, "EnableLightingSystemAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:EnableNFCConnctivityAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"EnableNGFCConnectivityAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#EnableNFCConnctivityAction">http://elite.polito.it/ontologies/eupont.owl#EnableNFCConnctivityAction</seealso>
    let EnableNFCConnctivityAction =
        Prefixed_Name(eupont, "EnableNFCConnctivityAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:EnableNightModeAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"EnableNightModeAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#EnableNightModeAction">http://elite.polito.it/ontologies/eupont.owl#EnableNightModeAction</seealso>
    let EnableNightModeAction =
        Prefixed_Name(eupont, "EnableNightModeAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:EnableNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"EnableNotification"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#EnableNotification">http://elite.polito.it/ontologies/eupont.owl#EnableNotification</seealso>
    let EnableNotification = Prefixed_Name(eupont, "EnableNotification") |> PrefixedName

    /// <summary>
    ///   <para>eupont:EnableNotificationsAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"EnableNotificationsAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#EnableNotificationsAction">http://elite.polito.it/ontologies/eupont.owl#EnableNotificationsAction</seealso>
    let EnableNotificationsAction =
        Prefixed_Name(eupont, "EnableNotificationsAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:EnableScreenRotationAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"EnableScreenRotationAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#EnableScreenRotationAction">http://elite.polito.it/ontologies/eupont.owl#EnableScreenRotationAction</seealso>
    let EnableScreenRotationAction =
        Prefixed_Name(eupont, "EnableScreenRotationAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:EnableSecuritySystemAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"EnableSecuritySystemAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#EnableSecuritySystemAction">http://elite.polito.it/ontologies/eupont.owl#EnableSecuritySystemAction</seealso>
    let EnableSecuritySystemAction =
        Prefixed_Name(eupont, "EnableSecuritySystemAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:EnableSpeakerphoneAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"EnableSpeakerphoneAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#EnableSpeakerphoneAction">http://elite.polito.it/ontologies/eupont.owl#EnableSpeakerphoneAction</seealso>
    let EnableSpeakerphoneAction =
        Prefixed_Name(eupont, "EnableSpeakerphoneAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:EnableWateringSystemAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"EnableWateringSystemAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#EnableWateringSystemAction">http://elite.polito.it/ontologies/eupont.owl#EnableWateringSystemAction</seealso>
    let EnableWateringSystemAction =
        Prefixed_Name(eupont, "EnableWateringSystemAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:EnabledAirplaneModeTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"EnabledAirplaneModeTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#EnabledAirplaneModeTrigger">http://elite.polito.it/ontologies/eupont.owl#EnabledAirplaneModeTrigger</seealso>
    let EnabledAirplaneModeTrigger =
        Prefixed_Name(eupont, "EnabledAirplaneModeTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:EnabledBluetoothConnectivityTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"EnabledBluetoothConnectivityTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#EnabledBluetoothConnectivityTrigger">http://elite.polito.it/ontologies/eupont.owl#EnabledBluetoothConnectivityTrigger</seealso>
    let EnabledBluetoothConnectivityTrigger =
        Prefixed_Name(eupont, "EnabledBluetoothConnectivityTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:EnabledGPSTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"EnabledGPSTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#EnabledGPSTrigger">http://elite.polito.it/ontologies/eupont.owl#EnabledGPSTrigger</seealso>
    let EnabledGPSTrigger = Prefixed_Name(eupont, "EnabledGPSTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:EnabledInternetConnectivityTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"EnabledInternetConnectivityTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#EnabledInternetConnectivityTrigger">http://elite.polito.it/ontologies/eupont.owl#EnabledInternetConnectivityTrigger</seealso>
    let EnabledInternetConnectivityTrigger =
        Prefixed_Name(eupont, "EnabledInternetConnectivityTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:EnabledNFCConnectivityTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"EnabledNFCConnectivityTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#EnabledNFCConnectivityTrigger">http://elite.polito.it/ontologies/eupont.owl#EnabledNFCConnectivityTrigger</seealso>
    let EnabledNFCConnectivityTrigger =
        Prefixed_Name(eupont, "EnabledNFCConnectivityTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:EndCallAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"EndCallAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#EndCallAction">http://elite.polito.it/ontologies/eupont.owl#EndCallAction</seealso>
    let EndCallAction = Prefixed_Name(eupont, "EndCallAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:EnhancedConnectivityTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"EnhancedConnectivityTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#EnhancedConnectivityTrigger">http://elite.polito.it/ontologies/eupont.owl#EnhancedConnectivityTrigger</seealso>
    let EnhancedConnectivityTrigger =
        Prefixed_Name(eupont, "EnhancedConnectivityTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:EnterNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"EnterNotification"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#EnterNotification">http://elite.polito.it/ontologies/eupont.owl#EnterNotification</seealso>
    let EnterNotification = Prefixed_Name(eupont, "EnterNotification") |> PrefixedName
    /// <summary>
    ///   <para>eupont:EnterTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"EnterTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#EnterTrigger">http://elite.polito.it/ontologies/eupont.owl#EnterTrigger</seealso>
    let EnterTrigger = Prefixed_Name(eupont, "EnterTrigger") |> PrefixedName
    /// <summary>
    ///   <para>eupont:EnvironmentAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"EnvironmentAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#EnvironmentAction">http://elite.polito.it/ontologies/eupont.owl#EnvironmentAction</seealso>
    let EnvironmentAction = Prefixed_Name(eupont, "EnvironmentAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:EnvironmentConditionDecreasedTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"EnvironmentConditionDecreasedTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#EnvironmentConditionDecreasedTrigger">http://elite.polito.it/ontologies/eupont.owl#EnvironmentConditionDecreasedTrigger</seealso>
    let EnvironmentConditionDecreasedTrigger =
        Prefixed_Name(eupont, "EnvironmentConditionDecreasedTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:EnvironmentConditionIncreasedTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"EnvironmentConditionIncreasedTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#EnvironmentConditionIncreasedTrigger">http://elite.polito.it/ontologies/eupont.owl#EnvironmentConditionIncreasedTrigger</seealso>
    let EnvironmentConditionIncreasedTrigger =
        Prefixed_Name(eupont, "EnvironmentConditionIncreasedTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:EnvironmentTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"EnvironmentTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#EnvironmentTrigger">http://elite.polito.it/ontologies/eupont.owl#EnvironmentTrigger</seealso>
    let EnvironmentTrigger = Prefixed_Name(eupont, "EnvironmentTrigger") |> PrefixedName
    /// <summary>
    ///   <para>eupont:EveryDayTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"EveryDayTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#EveryDayTrigger">http://elite.polito.it/ontologies/eupont.owl#EveryDayTrigger</seealso>
    let EveryDayTrigger = Prefixed_Name(eupont, "EveryDayTrigger") |> PrefixedName
    /// <summary>
    ///   <para>eupont:EveryHourTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"EveryHourTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#EveryHourTrigger">http://elite.polito.it/ontologies/eupont.owl#EveryHourTrigger</seealso>
    let EveryHourTrigger = Prefixed_Name(eupont, "EveryHourTrigger") |> PrefixedName
    /// <summary>
    ///   <para>eupont:EveryMonthTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"EveryMonthTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#EveryMonthTrigger">http://elite.polito.it/ontologies/eupont.owl#EveryMonthTrigger</seealso>
    let EveryMonthTrigger = Prefixed_Name(eupont, "EveryMonthTrigger") |> PrefixedName
    /// <summary>
    ///   <para>eupont:EveryTimeTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"EveryTimeTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#EveryTimeTrigger">http://elite.polito.it/ontologies/eupont.owl#EveryTimeTrigger</seealso>
    let EveryTimeTrigger = Prefixed_Name(eupont, "EveryTimeTrigger") |> PrefixedName
    /// <summary>
    ///   <para>eupont:EveryWeekTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"EveryWeekTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#EveryWeekTrigger">http://elite.polito.it/ontologies/eupont.owl#EveryWeekTrigger</seealso>
    let EveryWeekTrigger = Prefixed_Name(eupont, "EveryWeekTrigger") |> PrefixedName
    /// <summary>
    ///   <para>eupont:EveryYearTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"EveryYearTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#EveryYearTrigger">http://elite.polito.it/ontologies/eupont.owl#EveryYearTrigger</seealso>
    let EveryYearTrigger = Prefixed_Name(eupont, "EveryYearTrigger") |> PrefixedName
    /// <summary>
    ///   <para>eupont:ExitNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ExitNotification"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#ExitNotification">http://elite.polito.it/ontologies/eupont.owl#ExitNotification</seealso>
    let ExitNotification = Prefixed_Name(eupont, "ExitNotification") |> PrefixedName
    /// <summary>
    ///   <para>eupont:ExitTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ExitTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#ExitTrigger">http://elite.polito.it/ontologies/eupont.owl#ExitTrigger</seealso>
    let ExitTrigger = Prefixed_Name(eupont, "ExitTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:FailureDetectionService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"FailureDetectionService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#FailureDetectionService">http://elite.polito.it/ontologies/eupont.owl#FailureDetectionService</seealso>
    let FailureDetectionService =
        Prefixed_Name(eupont, "FailureDetectionService") |> PrefixedName

    /// <summary>
    ///   <para>eupont:Family</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Family"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#Family">http://elite.polito.it/ontologies/eupont.owl#Family</seealso>
    let Family = Prefixed_Name(eupont, "Family") |> PrefixedName
    /// <summary>
    ///   <para>eupont:Fax</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Fax"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#Fax">http://elite.polito.it/ontologies/eupont.owl#Fax</seealso>
    let Fax = Prefixed_Name(eupont, "Fax") |> PrefixedName
    /// <summary>
    ///   <para>eupont:FileService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"FileService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#FileService">http://elite.polito.it/ontologies/eupont.owl#FileService</seealso>
    let FileService = Prefixed_Name(eupont, "FileService") |> PrefixedName

    /// <summary>
    ///   <para>eupont:FocusTrackingService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"FocusTrackingService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#FocusTrackingService">http://elite.polito.it/ontologies/eupont.owl#FocusTrackingService</seealso>
    let FocusTrackingService =
        Prefixed_Name(eupont, "FocusTrackingService") |> PrefixedName

    /// <summary>
    ///   <para>eupont:FrameService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"FrameService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#FrameService">http://elite.polito.it/ontologies/eupont.owl#FrameService</seealso>
    let FrameService = Prefixed_Name(eupont, "FrameService") |> PrefixedName
    /// <summary>
    ///   <para>eupont:Fridge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Fridge"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#Fridge">http://elite.polito.it/ontologies/eupont.owl#Fridge</seealso>
    let Fridge = Prefixed_Name(eupont, "Fridge") |> PrefixedName
    /// <summary>
    ///   <para>eupont:Friend</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Friend"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#Friend">http://elite.polito.it/ontologies/eupont.owl#Friend</seealso>
    let Friend = Prefixed_Name(eupont, "Friend") |> PrefixedName

    /// <summary>
    ///   <para>eupont:GPSEnterAreaTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"GPSEnterAreaTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#GPSEnterAreaTrigger">http://elite.polito.it/ontologies/eupont.owl#GPSEnterAreaTrigger</seealso>
    let GPSEnterAreaTrigger =
        Prefixed_Name(eupont, "GPSEnterAreaTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:GPSExitAreaTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"GPSExitAreaTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#GPSExitAreaTrigger">http://elite.polito.it/ontologies/eupont.owl#GPSExitAreaTrigger</seealso>
    let GPSExitAreaTrigger = Prefixed_Name(eupont, "GPSExitAreaTrigger") |> PrefixedName
    /// <summary>
    ///   <para>eupont:GPSService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"GPSService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#GPSService">http://elite.polito.it/ontologies/eupont.owl#GPSService</seealso>
    let GPSService = Prefixed_Name(eupont, "GPSService") |> PrefixedName
    /// <summary>
    ///   <para>eupont:GameService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"GameService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#GameService">http://elite.polito.it/ontologies/eupont.owl#GameService</seealso>
    let GameService = Prefixed_Name(eupont, "GameService") |> PrefixedName
    /// <summary>
    ///   <para>eupont:GeographicalArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"GeographicalArea"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#GeographicalArea">http://elite.polito.it/ontologies/eupont.owl#GeographicalArea</seealso>
    let GeographicalArea = Prefixed_Name(eupont, "GeographicalArea") |> PrefixedName
    /// <summary>
    ///   <para>eupont:GetAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"GetAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#GetAction">http://elite.polito.it/ontologies/eupont.owl#GetAction</seealso>
    let GetAction = Prefixed_Name(eupont, "GetAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:GroceryShoppingService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"GroceryShoppingService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#GroceryShoppingService">http://elite.polito.it/ontologies/eupont.owl#GroceryShoppingService</seealso>
    let GroceryShoppingService =
        Prefixed_Name(eupont, "GroceryShoppingService") |> PrefixedName

    /// <summary>
    ///   <para>eupont:HealthInformationService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"HealthInformationService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#HealthInformationService">http://elite.polito.it/ontologies/eupont.owl#HealthInformationService</seealso>
    let HealthInformationService =
        Prefixed_Name(eupont, "HealthInformationService") |> PrefixedName

    /// <summary>
    ///   <para>eupont:HealthTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"HealthTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#HealthTrigger">http://elite.polito.it/ontologies/eupont.owl#HealthTrigger</seealso>
    let HealthTrigger = Prefixed_Name(eupont, "HealthTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:HealthyActivityTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"HealthyActivityTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#HealthyActivityTrigger">http://elite.polito.it/ontologies/eupont.owl#HealthyActivityTrigger</seealso>
    let HealthyActivityTrigger =
        Prefixed_Name(eupont, "HealthyActivityTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:HealthyGoalNotReachedTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"HealthyGoalNotReachedTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#HealthyGoalNotReachedTrigger">http://elite.polito.it/ontologies/eupont.owl#HealthyGoalNotReachedTrigger</seealso>
    let HealthyGoalNotReachedTrigger =
        Prefixed_Name(eupont, "HealthyGoalNotReachedTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:HealthyGoalReachedTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"HealthyGoalReachedTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#HealthyGoalReachedTrigger">http://elite.polito.it/ontologies/eupont.owl#HealthyGoalReachedTrigger</seealso>
    let HealthyGoalReachedTrigger =
        Prefixed_Name(eupont, "HealthyGoalReachedTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:Heater</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Heater"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#Heater">http://elite.polito.it/ontologies/eupont.owl#Heater</seealso>
    let Heater = Prefixed_Name(eupont, "Heater") |> PrefixedName
    /// <summary>
    ///   <para>eupont:HeatingService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"HeatingService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#HeatingService">http://elite.polito.it/ontologies/eupont.owl#HeatingService</seealso>
    let HeatingService = Prefixed_Name(eupont, "HeatingService") |> PrefixedName

    /// <summary>
    ///   <para>eupont:HeatingSystemDisabledTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"HeatingSystemDisabledTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#HeatingSystemDisabledTrigger">http://elite.polito.it/ontologies/eupont.owl#HeatingSystemDisabledTrigger</seealso>
    let HeatingSystemDisabledTrigger =
        Prefixed_Name(eupont, "HeatingSystemDisabledTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:HeatingSystemEnabledTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"HeatingSystemEnabledTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#HeatingSystemEnabledTrigger">http://elite.polito.it/ontologies/eupont.owl#HeatingSystemEnabledTrigger</seealso>
    let HeatingSystemEnabledTrigger =
        Prefixed_Name(eupont, "HeatingSystemEnabledTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:HiFi</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"HiFi"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#HiFi">http://elite.polito.it/ontologies/eupont.owl#HiFi</seealso>
    let HiFi = Prefixed_Name(eupont, "HiFi") |> PrefixedName

    /// <summary>
    ///   <para>eupont:HighSensedDeviceConsumptionTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"HighSensedDeviceConsumptionTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#HighSensedDeviceConsumptionTrigger">http://elite.polito.it/ontologies/eupont.owl#HighSensedDeviceConsumptionTrigger</seealso>
    let HighSensedDeviceConsumptionTrigger =
        Prefixed_Name(eupont, "HighSensedDeviceConsumptionTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:Hub</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Hub"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#Hub">http://elite.polito.it/ontologies/eupont.owl#Hub</seealso>
    let Hub = Prefixed_Name(eupont, "Hub") |> PrefixedName
    /// <summary>
    ///   <para>eupont:Humidifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Humidifier"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#Humidifier">http://elite.polito.it/ontologies/eupont.owl#Humidifier</seealso>
    let Humidifier = Prefixed_Name(eupont, "Humidifier") |> PrefixedName
    /// <summary>
    ///   <para>eupont:HumidifierService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"HumidifierService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#HumidifierService">http://elite.polito.it/ontologies/eupont.owl#HumidifierService</seealso>
    let HumidifierService = Prefixed_Name(eupont, "HumidifierService") |> PrefixedName

    /// <summary>
    ///   <para>eupont:HumiditySetToTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"HumiditySetToTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#HumiditySetToTrigger">http://elite.polito.it/ontologies/eupont.owl#HumiditySetToTrigger</seealso>
    let HumiditySetToTrigger =
        Prefixed_Name(eupont, "HumiditySetToTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:ImproveConsumptionConditionAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ImproveConsumptionConditionAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#ImproveConsumptionConditionAction">http://elite.polito.it/ontologies/eupont.owl#ImproveConsumptionConditionAction</seealso>
    let ImproveConsumptionConditionAction =
        Prefixed_Name(eupont, "ImproveConsumptionConditionAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:ImproveDeviceConditionAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ImproveDeviceConditionAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#ImproveDeviceConditionAction">http://elite.polito.it/ontologies/eupont.owl#ImproveDeviceConditionAction</seealso>
    let ImproveDeviceConditionAction =
        Prefixed_Name(eupont, "ImproveDeviceConditionAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:ImproveLightingConditionAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ImproveLightingConditionAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#ImproveLightingConditionAction">http://elite.polito.it/ontologies/eupont.owl#ImproveLightingConditionAction</seealso>
    let ImproveLightingConditionAction =
        Prefixed_Name(eupont, "ImproveLightingConditionAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:ImproveUsabilityConditionAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ImproveUsabilityConditionAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#ImproveUsabilityConditionAction">http://elite.polito.it/ontologies/eupont.owl#ImproveUsabilityConditionAction</seealso>
    let ImproveUsabilityConditionAction =
        Prefixed_Name(eupont, "ImproveUsabilityConditionAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:ImprovedConsumptionConditionTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ImprovedConsumptionConditionTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#ImprovedConsumptionConditionTrigger">http://elite.polito.it/ontologies/eupont.owl#ImprovedConsumptionConditionTrigger</seealso>
    let ImprovedConsumptionConditionTrigger =
        Prefixed_Name(eupont, "ImprovedConsumptionConditionTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:ImprovedDeviceConditionTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ImprovedDeviceConditionTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#ImprovedDeviceConditionTrigger">http://elite.polito.it/ontologies/eupont.owl#ImprovedDeviceConditionTrigger</seealso>
    let ImprovedDeviceConditionTrigger =
        Prefixed_Name(eupont, "ImprovedDeviceConditionTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:ImprovedHealthyParameterTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ImprovedHealthyParameterTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#ImprovedHealthyParameterTrigger">http://elite.polito.it/ontologies/eupont.owl#ImprovedHealthyParameterTrigger</seealso>
    let ImprovedHealthyParameterTrigger =
        Prefixed_Name(eupont, "ImprovedHealthyParameterTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:ImprovedLightingConditionTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ImprovedLightingConditionTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#ImprovedLightingConditionTrigger">http://elite.polito.it/ontologies/eupont.owl#ImprovedLightingConditionTrigger</seealso>
    let ImprovedLightingConditionTrigger =
        Prefixed_Name(eupont, "ImprovedLightingConditionTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:ImprovedUsabilityConditionTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ImprovedUsabilityConditionTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#ImprovedUsabilityConditionTrigger">http://elite.polito.it/ontologies/eupont.owl#ImprovedUsabilityConditionTrigger</seealso>
    let ImprovedUsabilityConditionTrigger =
        Prefixed_Name(eupont, "ImprovedUsabilityConditionTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:IncreaseAirQualityAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"IncreaseAirQualityAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#IncreaseAirQualityAction">http://elite.polito.it/ontologies/eupont.owl#IncreaseAirQualityAction</seealso>
    let IncreaseAirQualityAction =
        Prefixed_Name(eupont, "IncreaseAirQualityAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:IncreaseConnectivityAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"IncreaseConnectivityAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#IncreaseConnectivityAction">http://elite.polito.it/ontologies/eupont.owl#IncreaseConnectivityAction</seealso>
    let IncreaseConnectivityAction =
        Prefixed_Name(eupont, "IncreaseConnectivityAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:IncreaseEnvironmentConditionAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"IncreaseEnvironmentConditionAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#IncreaseEnvironmentConditionAction">http://elite.polito.it/ontologies/eupont.owl#IncreaseEnvironmentConditionAction</seealso>
    let IncreaseEnvironmentConditionAction =
        Prefixed_Name(eupont, "IncreaseEnvironmentConditionAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:IncreaseHumidityAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"IncreaseHumidityAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#IncreaseHumidityAction">http://elite.polito.it/ontologies/eupont.owl#IncreaseHumidityAction</seealso>
    let IncreaseHumidityAction =
        Prefixed_Name(eupont, "IncreaseHumidityAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:IncreaseLightingAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"IncreaseLightingAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#IncreaseLightingAction">http://elite.polito.it/ontologies/eupont.owl#IncreaseLightingAction</seealso>
    let IncreaseLightingAction =
        Prefixed_Name(eupont, "IncreaseLightingAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:IncreaseSecurityAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"IncreaseSecurityAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#IncreaseSecurityAction">http://elite.polito.it/ontologies/eupont.owl#IncreaseSecurityAction</seealso>
    let IncreaseSecurityAction =
        Prefixed_Name(eupont, "IncreaseSecurityAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:IncreaseTemperatureAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"IncreaseTemperatureAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#IncreaseTemperatureAction">http://elite.polito.it/ontologies/eupont.owl#IncreaseTemperatureAction</seealso>
    let IncreaseTemperatureAction =
        Prefixed_Name(eupont, "IncreaseTemperatureAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:IncreaseUserConnectivityAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"IncreaseUserConnectivityAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#IncreaseUserConnectivityAction">http://elite.polito.it/ontologies/eupont.owl#IncreaseUserConnectivityAction</seealso>
    let IncreaseUserConnectivityAction =
        Prefixed_Name(eupont, "IncreaseUserConnectivityAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:IncreaseVolumeAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"IncreaseVolumeAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#IncreaseVolumeAction">http://elite.polito.it/ontologies/eupont.owl#IncreaseVolumeAction</seealso>
    let IncreaseVolumeAction =
        Prefixed_Name(eupont, "IncreaseVolumeAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:IncreasedAirPressureTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"IncreasedAirPressureTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#IncreasedAirPressureTrigger">http://elite.polito.it/ontologies/eupont.owl#IncreasedAirPressureTrigger</seealso>
    let IncreasedAirPressureTrigger =
        Prefixed_Name(eupont, "IncreasedAirPressureTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:IncreasedAirQualityTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"IncreasedAirQualityTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#IncreasedAirQualityTrigger">http://elite.polito.it/ontologies/eupont.owl#IncreasedAirQualityTrigger</seealso>
    let IncreasedAirQualityTrigger =
        Prefixed_Name(eupont, "IncreasedAirQualityTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:IncreasedHealthConditionTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"IncreasedHealthConditionTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#IncreasedHealthConditionTrigger">http://elite.polito.it/ontologies/eupont.owl#IncreasedHealthConditionTrigger</seealso>
    let IncreasedHealthConditionTrigger =
        Prefixed_Name(eupont, "IncreasedHealthConditionTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:IncreasedHumidityTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"IncreasedHumidityTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#IncreasedHumidityTrigger">http://elite.polito.it/ontologies/eupont.owl#IncreasedHumidityTrigger</seealso>
    let IncreasedHumidityTrigger =
        Prefixed_Name(eupont, "IncreasedHumidityTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:IncreasedLightingTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"IncreasedLightingTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#IncreasedLightingTrigger">http://elite.polito.it/ontologies/eupont.owl#IncreasedLightingTrigger</seealso>
    let IncreasedLightingTrigger =
        Prefixed_Name(eupont, "IncreasedLightingTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:IncreasedNoiseLevelTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"IncreasedNoiseLevelTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#IncreasedNoiseLevelTrigger">http://elite.polito.it/ontologies/eupont.owl#IncreasedNoiseLevelTrigger</seealso>
    let IncreasedNoiseLevelTrigger =
        Prefixed_Name(eupont, "IncreasedNoiseLevelTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:IncreasedSecurityTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"IncreasedSecurityTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#IncreasedSecurityTrigger">http://elite.polito.it/ontologies/eupont.owl#IncreasedSecurityTrigger</seealso>
    let IncreasedSecurityTrigger =
        Prefixed_Name(eupont, "IncreasedSecurityTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:IncreasedTemperatureTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"IncreasedTemperatureTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#IncreasedTemperatureTrigger">http://elite.polito.it/ontologies/eupont.owl#IncreasedTemperatureTrigger</seealso>
    let IncreasedTemperatureTrigger =
        Prefixed_Name(eupont, "IncreasedTemperatureTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:IncreasedWeatherConditionTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"IncreasedWeatherConditionTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#IncreasedWeatherConditionTrigger">http://elite.polito.it/ontologies/eupont.owl#IncreasedWeatherConditionTrigger</seealso>
    let IncreasedWeatherConditionTrigger =
        Prefixed_Name(eupont, "IncreasedWeatherConditionTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:InformationAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"InformationAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#InformationAction">http://elite.polito.it/ontologies/eupont.owl#InformationAction</seealso>
    let InformationAction = Prefixed_Name(eupont, "InformationAction") |> PrefixedName
    /// <summary>
    ///   <para>eupont:InformationService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"InformationService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#InformationService">http://elite.polito.it/ontologies/eupont.owl#InformationService</seealso>
    let InformationService = Prefixed_Name(eupont, "InformationService") |> PrefixedName
    /// <summary>
    ///   <para>eupont:InformationTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"InformationTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#InformationTrigger">http://elite.polito.it/ontologies/eupont.owl#InformationTrigger</seealso>
    let InformationTrigger = Prefixed_Name(eupont, "InformationTrigger") |> PrefixedName
    /// <summary>
    ///   <para>eupont:InformationWebSite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"InformationWebsite"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#InformationWebSite">http://elite.polito.it/ontologies/eupont.owl#InformationWebSite</seealso>
    let InformationWebSite = Prefixed_Name(eupont, "InformationWebSite") |> PrefixedName
    /// <summary>
    ///   <para>eupont:InstantiatedAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"InstantiatedAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#InstantiatedAction">http://elite.polito.it/ontologies/eupont.owl#InstantiatedAction</seealso>
    let InstantiatedAction = Prefixed_Name(eupont, "InstantiatedAction") |> PrefixedName
    /// <summary>
    ///   <para>eupont:InstantiatedDetail</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"InstantiatedDetail"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#InstantiatedDetail">http://elite.polito.it/ontologies/eupont.owl#InstantiatedDetail</seealso>
    let InstantiatedDetail = Prefixed_Name(eupont, "InstantiatedDetail") |> PrefixedName

    /// <summary>
    ///   <para>eupont:InstantiatedTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"InstantiatedTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#InstantiatedTrigger">http://elite.polito.it/ontologies/eupont.owl#InstantiatedTrigger</seealso>
    let InstantiatedTrigger =
        Prefixed_Name(eupont, "InstantiatedTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:InteractionService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"InteractionService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#InteractionService">http://elite.polito.it/ontologies/eupont.owl#InteractionService</seealso>
    let InteractionService = Prefixed_Name(eupont, "InteractionService") |> PrefixedName
    /// <summary>
    ///   <para>eupont:IoTEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"IoTEntity"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#IoTEntity">http://elite.polito.it/ontologies/eupont.owl#IoTEntity</seealso>
    let IoTEntity = Prefixed_Name(eupont, "IoTEntity") |> PrefixedName
    /// <summary>
    ///   <para>eupont:Lamp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Lamp"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#Lamp">http://elite.polito.it/ontologies/eupont.owl#Lamp</seealso>
    let Lamp = Prefixed_Name(eupont, "Lamp") |> PrefixedName
    /// <summary>
    ///   <para>eupont:Laptop</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Laptop"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#Laptop">http://elite.polito.it/ontologies/eupont.owl#Laptop</seealso>
    let Laptop = Prefixed_Name(eupont, "Laptop") |> PrefixedName

    /// <summary>
    ///   <para>eupont:LeakDetectionService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"LeakDetectionService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#LeakDetectionService">http://elite.polito.it/ontologies/eupont.owl#LeakDetectionService</seealso>
    let LeakDetectionService =
        Prefixed_Name(eupont, "LeakDetectionService") |> PrefixedName

    /// <summary>
    ///   <para>eupont:LightingService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"LightingService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#LightingService">http://elite.polito.it/ontologies/eupont.owl#LightingService</seealso>
    let LightingService = Prefixed_Name(eupont, "LightingService") |> PrefixedName

    /// <summary>
    ///   <para>eupont:LightingSystemDisabledTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"LightingSystemDisabledTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#LightingSystemDisabledTrigger">http://elite.polito.it/ontologies/eupont.owl#LightingSystemDisabledTrigger</seealso>
    let LightingSystemDisabledTrigger =
        Prefixed_Name(eupont, "LightingSystemDisabledTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:LightingSystemEnabledTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"LightingSystemEnabledTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#LightingSystemEnabledTrigger">http://elite.polito.it/ontologies/eupont.owl#LightingSystemEnabledTrigger</seealso>
    let LightingSystemEnabledTrigger =
        Prefixed_Name(eupont, "LightingSystemEnabledTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:LikeService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"LikeService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#LikeService">http://elite.polito.it/ontologies/eupont.owl#LikeService</seealso>
    let LikeService = Prefixed_Name(eupont, "LikeService") |> PrefixedName
    /// <summary>
    ///   <para>eupont:Location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Location"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#Location">http://elite.polito.it/ontologies/eupont.owl#Location</seealso>
    let Location = Prefixed_Name(eupont, "Location") |> PrefixedName
    /// <summary>
    ///   <para>eupont:LowPowerTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"LowPowerTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#LowPowerTrigger">http://elite.polito.it/ontologies/eupont.owl#LowPowerTrigger</seealso>
    let LowPowerTrigger = Prefixed_Name(eupont, "LowPowerTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:MeasureAboveThresholdNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"MeasureAboveThresholdNotification"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#MeasureAboveThresholdNotification">http://elite.polito.it/ontologies/eupont.owl#MeasureAboveThresholdNotification</seealso>
    let MeasureAboveThresholdNotification =
        Prefixed_Name(eupont, "MeasureAboveThresholdNotification") |> PrefixedName

    /// <summary>
    ///   <para>eupont:MeasureAvailableNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"MeasureAvailableNotification"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#MeasureAvailableNotification">http://elite.polito.it/ontologies/eupont.owl#MeasureAvailableNotification</seealso>
    let MeasureAvailableNotification =
        Prefixed_Name(eupont, "MeasureAvailableNotification") |> PrefixedName

    /// <summary>
    ///   <para>eupont:MeasureBelowThresholdNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"MeasureBelowThresholdNotification"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#MeasureBelowThresholdNotification">http://elite.polito.it/ontologies/eupont.owl#MeasureBelowThresholdNotification</seealso>
    let MeasureBelowThresholdNotification =
        Prefixed_Name(eupont, "MeasureBelowThresholdNotification") |> PrefixedName

    /// <summary>
    ///   <para>eupont:MediaInformationService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"MediaInformationService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#MediaInformationService">http://elite.polito.it/ontologies/eupont.owl#MediaInformationService</seealso>
    let MediaInformationService =
        Prefixed_Name(eupont, "MediaInformationService") |> PrefixedName

    /// <summary>
    ///   <para>eupont:MediaService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"MediaService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#MediaService">http://elite.polito.it/ontologies/eupont.owl#MediaService</seealso>
    let MediaService = Prefixed_Name(eupont, "MediaService") |> PrefixedName
    /// <summary>
    ///   <para>eupont:MediaTool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"MediaTool"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#MediaTool">http://elite.polito.it/ontologies/eupont.owl#MediaTool</seealso>
    let MediaTool = Prefixed_Name(eupont, "MediaTool") |> PrefixedName
    /// <summary>
    ///   <para>eupont:MessageService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"MessageService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#MessageService">http://elite.polito.it/ontologies/eupont.owl#MessageService</seealso>
    let MessageService = Prefixed_Name(eupont, "MessageService") |> PrefixedName
    /// <summary>
    ///   <para>eupont:MobileDevice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"MobileDevice"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#MobileDevice">http://elite.polito.it/ontologies/eupont.owl#MobileDevice</seealso>
    let MobileDevice = Prefixed_Name(eupont, "MobileDevice") |> PrefixedName
    /// <summary>
    ///   <para>eupont:MoveAppAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"MoveAppAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#MoveAppAction">http://elite.polito.it/ontologies/eupont.owl#MoveAppAction</seealso>
    let MoveAppAction = Prefixed_Name(eupont, "MoveAppAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:MoveOnVehicleTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"MoveOnVehicleTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#MoveOnVehicleTrigger">http://elite.polito.it/ontologies/eupont.owl#MoveOnVehicleTrigger</seealso>
    let MoveOnVehicleTrigger =
        Prefixed_Name(eupont, "MoveOnVehicleTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:MovingTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"MovingTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#MovingTrigger">http://elite.polito.it/ontologies/eupont.owl#MovingTrigger</seealso>
    let MovingTrigger = Prefixed_Name(eupont, "MovingTrigger") |> PrefixedName
    /// <summary>
    ///   <para>eupont:MusicPlatform</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"MusicPlatform"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#MusicPlatform">http://elite.polito.it/ontologies/eupont.owl#MusicPlatform</seealso>
    let MusicPlatform = Prefixed_Name(eupont, "MusicPlatform") |> PrefixedName
    /// <summary>
    ///   <para>eupont:MusicService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"MusicService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#MusicService">http://elite.polito.it/ontologies/eupont.owl#MusicService</seealso>
    let MusicService = Prefixed_Name(eupont, "MusicService") |> PrefixedName
    /// <summary>
    ///   <para>eupont:MuteCallAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"MuteCallAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#MuteCallAction">http://elite.polito.it/ontologies/eupont.owl#MuteCallAction</seealso>
    let MuteCallAction = Prefixed_Name(eupont, "MuteCallAction") |> PrefixedName
    /// <summary>
    ///   <para>eupont:NFCService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"NFCService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#NFCService">http://elite.polito.it/ontologies/eupont.owl#NFCService</seealso>
    let NFCService = Prefixed_Name(eupont, "NFCService") |> PrefixedName
    /// <summary>
    ///   <para>eupont:NetworkService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"NetworkService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#NetworkService">http://elite.polito.it/ontologies/eupont.owl#NetworkService</seealso>
    let NetworkService = Prefixed_Name(eupont, "NetworkService") |> PrefixedName
    /// <summary>
    ///   <para>eupont:NewCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"NewCommand"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#NewCommand">http://elite.polito.it/ontologies/eupont.owl#NewCommand</seealso>
    let NewCommand = Prefixed_Name(eupont, "NewCommand") |> PrefixedName
    /// <summary>
    ///   <para>eupont:NewNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"NewNotification"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#NewNotification">http://elite.polito.it/ontologies/eupont.owl#NewNotification</seealso>
    let NewNotification = Prefixed_Name(eupont, "NewNotification") |> PrefixedName
    /// <summary>
    ///   <para>eupont:NewsService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"NewsService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#NewsService">http://elite.polito.it/ontologies/eupont.owl#NewsService</seealso>
    let NewsService = Prefixed_Name(eupont, "NewsService") |> PrefixedName
    /// <summary>
    ///   <para>eupont:NewsTool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"NewsTool"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#NewsTool">http://elite.polito.it/ontologies/eupont.owl#NewsTool</seealso>
    let NewsTool = Prefixed_Name(eupont, "NewsTool") |> PrefixedName
    /// <summary>
    ///   <para>eupont:NewsWebSite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"NewsWebsite"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#NewsWebSite">http://elite.polito.it/ontologies/eupont.owl#NewsWebSite</seealso>
    let NewsWebSite = Prefixed_Name(eupont, "NewsWebSite") |> PrefixedName

    /// <summary>
    ///   <para>eupont:NightModeDisabledTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"NightModeDisabledTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#NightModeDisabledTrigger">http://elite.polito.it/ontologies/eupont.owl#NightModeDisabledTrigger</seealso>
    let NightModeDisabledTrigger =
        Prefixed_Name(eupont, "NightModeDisabledTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:NightModeEnabledTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"NightModeEnabledTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#NightModeEnabledTrigger">http://elite.polito.it/ontologies/eupont.owl#NightModeEnabledTrigger</seealso>
    let NightModeEnabledTrigger =
        Prefixed_Name(eupont, "NightModeEnabledTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:NoiseService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"NoiseService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#NoiseService">http://elite.polito.it/ontologies/eupont.owl#NoiseService</seealso>
    let NoiseService = Prefixed_Name(eupont, "NoiseService") |> PrefixedName
    /// <summary>
    ///   <para>eupont:NoteTool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Notes"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#NoteTool">http://elite.polito.it/ontologies/eupont.owl#NoteTool</seealso>
    let NoteTool = Prefixed_Name(eupont, "NoteTool") |> PrefixedName
    /// <summary>
    ///   <para>eupont:Notification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Notification"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#Notification">http://elite.polito.it/ontologies/eupont.owl#Notification</seealso>
    let Notification = Prefixed_Name(eupont, "Notification") |> PrefixedName

    /// <summary>
    ///   <para>eupont:NotificationProfileSetToTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"NotificationProfileSetToTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#NotificationProfileSetToTrigger">http://elite.polito.it/ontologies/eupont.owl#NotificationProfileSetToTrigger</seealso>
    let NotificationProfileSetToTrigger =
        Prefixed_Name(eupont, "NotificationProfileSetToTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:NotificationService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"NotificationService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#NotificationService">http://elite.polito.it/ontologies/eupont.owl#NotificationService</seealso>
    let NotificationService =
        Prefixed_Name(eupont, "NotificationService") |> PrefixedName

    /// <summary>
    ///   <para>eupont:NotificationTool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Notification"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#NotificationTool">http://elite.polito.it/ontologies/eupont.owl#NotificationTool</seealso>
    let NotificationTool = Prefixed_Name(eupont, "NotificationTool") |> PrefixedName

    /// <summary>
    ///   <para>eupont:NotificationsDisabledTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"NotificationsDisabledTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#NotificationsDisabledTrigger">http://elite.polito.it/ontologies/eupont.owl#NotificationsDisabledTrigger</seealso>
    let NotificationsDisabledTrigger =
        Prefixed_Name(eupont, "NotificationsDisabledTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:NotificationsEnabledTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"NotificationsEnabledTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#NotificationsEnabledTrigger">http://elite.polito.it/ontologies/eupont.owl#NotificationsEnabledTrigger</seealso>
    let NotificationsEnabledTrigger =
        Prefixed_Name(eupont, "NotificationsEnabledTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:OpenCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"OpenCommand"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#OpenCommand">http://elite.polito.it/ontologies/eupont.owl#OpenCommand</seealso>
    let OpenCommand = Prefixed_Name(eupont, "OpenCommand") |> PrefixedName
    /// <summary>
    ///   <para>eupont:OpenNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"OpenNotification"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#OpenNotification">http://elite.polito.it/ontologies/eupont.owl#OpenNotification</seealso>
    let OpenNotification = Prefixed_Name(eupont, "OpenNotification") |> PrefixedName

    /// <summary>
    ///   <para>eupont:OpenWindowFrameAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"OpenWindowFrameAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#OpenWindowFrameAction">http://elite.polito.it/ontologies/eupont.owl#OpenWindowFrameAction</seealso>
    let OpenWindowFrameAction =
        Prefixed_Name(eupont, "OpenWindowFrameAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:OrganizerTool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"OrganizerTool"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#OrganizerTool">http://elite.polito.it/ontologies/eupont.owl#OrganizerTool</seealso>
    let OrganizerTool = Prefixed_Name(eupont, "OrganizerTool") |> PrefixedName
    /// <summary>
    ///   <para>eupont:OutputService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"OutputService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#OutputService">http://elite.polito.it/ontologies/eupont.owl#OutputService</seealso>
    let OutputService = Prefixed_Name(eupont, "OutputService") |> PrefixedName
    /// <summary>
    ///   <para>eupont:Oven</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Oven"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#Oven">http://elite.polito.it/ontologies/eupont.owl#Oven</seealso>
    let Oven = Prefixed_Name(eupont, "Oven") |> PrefixedName
    /// <summary>
    ///   <para>eupont:OvenService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"OvenService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#OvenService">http://elite.polito.it/ontologies/eupont.owl#OvenService</seealso>
    let OvenService = Prefixed_Name(eupont, "OvenService") |> PrefixedName
    /// <summary>
    ///   <para>eupont:PC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"PC"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#PC">http://elite.polito.it/ontologies/eupont.owl#PC</seealso>
    let PC = Prefixed_Name(eupont, "PC") |> PrefixedName
    /// <summary>
    ///   <para>eupont:Phone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Phone"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#Phone">http://elite.polito.it/ontologies/eupont.owl#Phone</seealso>
    let Phone = Prefixed_Name(eupont, "Phone") |> PrefixedName

    /// <summary>
    ///   <para>eupont:PhoneCallMutedTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"PhoneCallMutedTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#PhoneCallMutedTrigger">http://elite.polito.it/ontologies/eupont.owl#PhoneCallMutedTrigger</seealso>
    let PhoneCallMutedTrigger =
        Prefixed_Name(eupont, "PhoneCallMutedTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:PhoneCallRejectedTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"PhoneCallRejectedTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#PhoneCallRejectedTrigger">http://elite.polito.it/ontologies/eupont.owl#PhoneCallRejectedTrigger</seealso>
    let PhoneCallRejectedTrigger =
        Prefixed_Name(eupont, "PhoneCallRejectedTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:PhotoPlatform</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"PhotoPlatform"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#PhotoPlatform">http://elite.polito.it/ontologies/eupont.owl#PhotoPlatform</seealso>
    let PhotoPlatform = Prefixed_Name(eupont, "PhotoPlatform") |> PrefixedName

    /// <summary>
    ///   <para>eupont:PhotoRecordingService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"PhotoRecordingService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#PhotoRecordingService">http://elite.polito.it/ontologies/eupont.owl#PhotoRecordingService</seealso>
    let PhotoRecordingService =
        Prefixed_Name(eupont, "PhotoRecordingService") |> PrefixedName

    /// <summary>
    ///   <para>eupont:PhysicalObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"PhysicalObject"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#PhysicalObject">http://elite.polito.it/ontologies/eupont.owl#PhysicalObject</seealso>
    let PhysicalObject = Prefixed_Name(eupont, "PhysicalObject") |> PrefixedName
    /// <summary>
    ///   <para>eupont:PlacesTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"PlacesTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#PlacesTrigger">http://elite.polito.it/ontologies/eupont.owl#PlacesTrigger</seealso>
    let PlacesTrigger = Prefixed_Name(eupont, "PlacesTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:PositionRegistrationService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"PositionRegistrationService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#PositionRegistrationService">http://elite.polito.it/ontologies/eupont.owl#PositionRegistrationService</seealso>
    let PositionRegistrationService =
        Prefixed_Name(eupont, "PositionRegistrationService") |> PrefixedName

    /// <summary>
    ///   <para>eupont:PositionRegistrationTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"PositionRegistrationTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#PositionRegistrationTrigger">http://elite.polito.it/ontologies/eupont.owl#PositionRegistrationTrigger</seealso>
    let PositionRegistrationTrigger =
        Prefixed_Name(eupont, "PositionRegistrationTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:PostService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"PostService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#PostService">http://elite.polito.it/ontologies/eupont.owl#PostService</seealso>
    let PostService = Prefixed_Name(eupont, "PostService") |> PrefixedName
    /// <summary>
    ///   <para>eupont:PostioningService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"PositioningService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#PostioningService">http://elite.polito.it/ontologies/eupont.owl#PostioningService</seealso>
    let PostioningService = Prefixed_Name(eupont, "PostioningService") |> PrefixedName
    /// <summary>
    ///   <para>eupont:PowerService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"PowerService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#PowerService">http://elite.polito.it/ontologies/eupont.owl#PowerService</seealso>
    let PowerService = Prefixed_Name(eupont, "PowerService") |> PrefixedName

    /// <summary>
    ///   <para>eupont:PresenceDetectedNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"PresenceDetectedNotification"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#PresenceDetectedNotification">http://elite.polito.it/ontologies/eupont.owl#PresenceDetectedNotification</seealso>
    let PresenceDetectedNotification =
        Prefixed_Name(eupont, "PresenceDetectedNotification") |> PrefixedName

    /// <summary>
    ///   <para>eupont:PresenceNoLongerDetectedNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"PresenceNoLongerDetectedNotification"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#PresenceNoLongerDetectedNotification">http://elite.polito.it/ontologies/eupont.owl#PresenceNoLongerDetectedNotification</seealso>
    let PresenceNoLongerDetectedNotification =
        Prefixed_Name(eupont, "PresenceNoLongerDetectedNotification") |> PrefixedName

    /// <summary>
    ///   <para>eupont:PrintService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"PrintService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#PrintService">http://elite.polito.it/ontologies/eupont.owl#PrintService</seealso>
    let PrintService = Prefixed_Name(eupont, "PrintService") |> PrefixedName
    /// <summary>
    ///   <para>eupont:Printer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Printer"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#Printer">http://elite.polito.it/ontologies/eupont.owl#Printer</seealso>
    let Printer = Prefixed_Name(eupont, "Printer") |> PrefixedName

    /// <summary>
    ///   <para>eupont:ProfileUpdateService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ProfileUpdateService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#ProfileUpdateService">http://elite.polito.it/ontologies/eupont.owl#ProfileUpdateService</seealso>
    let ProfileUpdateService =
        Prefixed_Name(eupont, "ProfileUpdateService") |> PrefixedName

    /// <summary>
    ///   <para>eupont:QuestionService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"QuestionService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#QuestionService">http://elite.polito.it/ontologies/eupont.owl#QuestionService</seealso>
    let QuestionService = Prefixed_Name(eupont, "QuestionService") |> PrefixedName
    /// <summary>
    ///   <para>eupont:Radio</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Radio"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#Radio">http://elite.polito.it/ontologies/eupont.owl#Radio</seealso>
    let Radio = Prefixed_Name(eupont, "Radio") |> PrefixedName

    /// <summary>
    ///   <para>eupont:RainfallMeasurementAvailableTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"RainfallMeasurementAvailableTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#RainfallMeasurementAvailableTrigger">http://elite.polito.it/ontologies/eupont.owl#RainfallMeasurementAvailableTrigger</seealso>
    let RainfallMeasurementAvailableTrigger =
        Prefixed_Name(eupont, "RainfallMeasurementAvailableTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:ReceiveNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ReceiveNotification"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#ReceiveNotification">http://elite.polito.it/ontologies/eupont.owl#ReceiveNotification</seealso>
    let ReceiveNotification =
        Prefixed_Name(eupont, "ReceiveNotification") |> PrefixedName

    /// <summary>
    ///   <para>eupont:ReceivedAnswerTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ReceivedAnswerTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#ReceivedAnswerTrigger">http://elite.polito.it/ontologies/eupont.owl#ReceivedAnswerTrigger</seealso>
    let ReceivedAnswerTrigger =
        Prefixed_Name(eupont, "ReceivedAnswerTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:ReceivedAppNotificationTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ReceivedAppNotificationTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#ReceivedAppNotificationTrigger">http://elite.polito.it/ontologies/eupont.owl#ReceivedAppNotificationTrigger</seealso>
    let ReceivedAppNotificationTrigger =
        Prefixed_Name(eupont, "ReceivedAppNotificationTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:ReceivedAttachmentTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ReceivedAttachmentTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#ReceivedAttachmentTrigger">http://elite.polito.it/ontologies/eupont.owl#ReceivedAttachmentTrigger</seealso>
    let ReceivedAttachmentTrigger =
        Prefixed_Name(eupont, "ReceivedAttachmentTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:ReceivedBreakingNewsTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ReceivedBreakingNewsTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#ReceivedBreakingNewsTrigger">http://elite.polito.it/ontologies/eupont.owl#ReceivedBreakingNewsTrigger</seealso>
    let ReceivedBreakingNewsTrigger =
        Prefixed_Name(eupont, "ReceivedBreakingNewsTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:ReceivedCommentTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ReceivedCommentTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#ReceivedCommentTrigger">http://elite.polito.it/ontologies/eupont.owl#ReceivedCommentTrigger</seealso>
    let ReceivedCommentTrigger =
        Prefixed_Name(eupont, "ReceivedCommentTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:ReceivedContactNotificationTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ReceivedContactNotificationTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#ReceivedContactNotificationTrigger">http://elite.polito.it/ontologies/eupont.owl#ReceivedContactNotificationTrigger</seealso>
    let ReceivedContactNotificationTrigger =
        Prefixed_Name(eupont, "ReceivedContactNotificationTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:ReceivedDocumentInfoNotificationTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ReceivedDocumentInfoNotificationTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#ReceivedDocumentInfoNotificationTrigger">http://elite.polito.it/ontologies/eupont.owl#ReceivedDocumentInfoNotificationTrigger</seealso>
    let ReceivedDocumentInfoNotificationTrigger =
        Prefixed_Name(eupont, "ReceivedDocumentInfoNotificationTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:ReceivedFromDeviceTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ReceivedFromDeviceTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#ReceivedFromDeviceTrigger">http://elite.polito.it/ontologies/eupont.owl#ReceivedFromDeviceTrigger</seealso>
    let ReceivedFromDeviceTrigger =
        Prefixed_Name(eupont, "ReceivedFromDeviceTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:ReceivedFromDiyTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ReceivedFromDiyTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#ReceivedFromDiyTrigger">http://elite.polito.it/ontologies/eupont.owl#ReceivedFromDiyTrigger</seealso>
    let ReceivedFromDiyTrigger =
        Prefixed_Name(eupont, "ReceivedFromDiyTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:ReceivedIncomingCallTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ReceivedIncomingCallTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#ReceivedIncomingCallTrigger">http://elite.polito.it/ontologies/eupont.owl#ReceivedIncomingCallTrigger</seealso>
    let ReceivedIncomingCallTrigger =
        Prefixed_Name(eupont, "ReceivedIncomingCallTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:ReceivedLikeTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ReceivedLikeTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#ReceivedLikeTrigger">http://elite.polito.it/ontologies/eupont.owl#ReceivedLikeTrigger</seealso>
    let ReceivedLikeTrigger =
        Prefixed_Name(eupont, "ReceivedLikeTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:ReceivedMessageTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ReceivedMessageTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#ReceivedMessageTrigger">http://elite.polito.it/ontologies/eupont.owl#ReceivedMessageTrigger</seealso>
    let ReceivedMessageTrigger =
        Prefixed_Name(eupont, "ReceivedMessageTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:ReceivedMissedCallNotificationTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ReceivedMissedCallNotificationTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#ReceivedMissedCallNotificationTrigger">http://elite.polito.it/ontologies/eupont.owl#ReceivedMissedCallNotificationTrigger</seealso>
    let ReceivedMissedCallNotificationTrigger =
        Prefixed_Name(eupont, "ReceivedMissedCallNotificationTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:ReceivedNewsTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ReceivedNewsTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#ReceivedNewsTrigger">http://elite.polito.it/ontologies/eupont.owl#ReceivedNewsTrigger</seealso>
    let ReceivedNewsTrigger =
        Prefixed_Name(eupont, "ReceivedNewsTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:ReceivedNotificationTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ReceivedNotificationTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#ReceivedNotificationTrigger">http://elite.polito.it/ontologies/eupont.owl#ReceivedNotificationTrigger</seealso>
    let ReceivedNotificationTrigger =
        Prefixed_Name(eupont, "ReceivedNotificationTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:ReceivedPaymentNotificationTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ReceivedPaymentNotificationTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#ReceivedPaymentNotificationTrigger">http://elite.polito.it/ontologies/eupont.owl#ReceivedPaymentNotificationTrigger</seealso>
    let ReceivedPaymentNotificationTrigger =
        Prefixed_Name(eupont, "ReceivedPaymentNotificationTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:ReceivedPostTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ReceivedPostTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#ReceivedPostTrigger">http://elite.polito.it/ontologies/eupont.owl#ReceivedPostTrigger</seealso>
    let ReceivedPostTrigger =
        Prefixed_Name(eupont, "ReceivedPostTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:ReceivedPrivateInformationTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ReceivedPrivateInformationTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#ReceivedPrivateInformationTrigger">http://elite.polito.it/ontologies/eupont.owl#ReceivedPrivateInformationTrigger</seealso>
    let ReceivedPrivateInformationTrigger =
        Prefixed_Name(eupont, "ReceivedPrivateInformationTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:ReceivedRecommendationNotificationTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ReceivedRecommendationNotificationTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#ReceivedRecommendationNotificationTrigger">http://elite.polito.it/ontologies/eupont.owl#ReceivedRecommendationNotificationTrigger</seealso>
    let ReceivedRecommendationNotificationTrigger =
        Prefixed_Name(eupont, "ReceivedRecommendationNotificationTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:ReceivedRemindNotificationTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ReceivedRemindNotificationTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#ReceivedRemindNotificationTrigger">http://elite.polito.it/ontologies/eupont.owl#ReceivedRemindNotificationTrigger</seealso>
    let ReceivedRemindNotificationTrigger =
        Prefixed_Name(eupont, "ReceivedRemindNotificationTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:ReceivedShippingNotificationTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ReceivedShippingNotificationTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#ReceivedShippingNotificationTrigger">http://elite.polito.it/ontologies/eupont.owl#ReceivedShippingNotificationTrigger</seealso>
    let ReceivedShippingNotificationTrigger =
        Prefixed_Name(eupont, "ReceivedShippingNotificationTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:ReceivedTagTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ReceivedTagTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#ReceivedTagTrigger">http://elite.polito.it/ontologies/eupont.owl#ReceivedTagTrigger</seealso>
    let ReceivedTagTrigger = Prefixed_Name(eupont, "ReceivedTagTrigger") |> PrefixedName
    /// <summary>
    ///   <para>eupont:ReceivedTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ReceivedTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#ReceivedTrigger">http://elite.polito.it/ontologies/eupont.owl#ReceivedTrigger</seealso>
    let ReceivedTrigger = Prefixed_Name(eupont, "ReceivedTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:ReceivedUnlikeTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ReceivedUnlikeTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#ReceivedUnlikeTrigger">http://elite.polito.it/ontologies/eupont.owl#ReceivedUnlikeTrigger</seealso>
    let ReceivedUnlikeTrigger =
        Prefixed_Name(eupont, "ReceivedUnlikeTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:RecordCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"RecordCommand"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#RecordCommand">http://elite.polito.it/ontologies/eupont.owl#RecordCommand</seealso>
    let RecordCommand = Prefixed_Name(eupont, "RecordCommand") |> PrefixedName
    /// <summary>
    ///   <para>eupont:RecordNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"RecordNotification"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#RecordNotification">http://elite.polito.it/ontologies/eupont.owl#RecordNotification</seealso>
    let RecordNotification = Prefixed_Name(eupont, "RecordNotification") |> PrefixedName
    /// <summary>
    ///   <para>eupont:RecordingService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"RecordingService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#RecordingService">http://elite.polito.it/ontologies/eupont.owl#RecordingService</seealso>
    let RecordingService = Prefixed_Name(eupont, "RecordingService") |> PrefixedName
    /// <summary>
    ///   <para>eupont:RejectCallAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"RejectCallAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#RejectCallAction">http://elite.polito.it/ontologies/eupont.owl#RejectCallAction</seealso>
    let RejectCallAction = Prefixed_Name(eupont, "RejectCallAction") |> PrefixedName
    /// <summary>
    ///   <para>eupont:ReminderService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ReminderService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#ReminderService">http://elite.polito.it/ontologies/eupont.owl#ReminderService</seealso>
    let ReminderService = Prefixed_Name(eupont, "ReminderService") |> PrefixedName
    /// <summary>
    ///   <para>eupont:Room</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Room"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#Room">http://elite.polito.it/ontologies/eupont.owl#Room</seealso>
    let Room = Prefixed_Name(eupont, "Room") |> PrefixedName
    /// <summary>
    ///   <para>eupont:Rule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Rule"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#Rule">http://elite.polito.it/ontologies/eupont.owl#Rule</seealso>
    let Rule = Prefixed_Name(eupont, "Rule") |> PrefixedName
    /// <summary>
    ///   <para>eupont:RuleAxiom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"RuleAxiom"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#RuleAxiom">http://elite.polito.it/ontologies/eupont.owl#RuleAxiom</seealso>
    let RuleAxiom = Prefixed_Name(eupont, "RuleAxiom") |> PrefixedName

    /// <summary>
    ///   <para>eupont:RuleInstantiatedAxiom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"RuleInstantiatedAxiom"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#RuleInstantiatedAxiom">http://elite.polito.it/ontologies/eupont.owl#RuleInstantiatedAxiom</seealso>
    let RuleInstantiatedAxiom =
        Prefixed_Name(eupont, "RuleInstantiatedAxiom") |> PrefixedName

    /// <summary>
    ///   <para>eupont:RuleNominalAxiom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"RuleNominalAxiom"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#RuleNominalAxiom">http://elite.polito.it/ontologies/eupont.owl#RuleNominalAxiom</seealso>
    let RuleNominalAxiom = Prefixed_Name(eupont, "RuleNominalAxiom") |> PrefixedName
    /// <summary>
    ///   <para>eupont:RunTrackingService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"RunTrackingService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#RunTrackingService">http://elite.polito.it/ontologies/eupont.owl#RunTrackingService</seealso>
    let RunTrackingService = Prefixed_Name(eupont, "RunTrackingService") |> PrefixedName
    /// <summary>
    ///   <para>eupont:SMSTool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SMS"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SMSTool">http://elite.polito.it/ontologies/eupont.owl#SMSTool</seealso>
    let SMSTool = Prefixed_Name(eupont, "SMSTool") |> PrefixedName
    /// <summary>
    ///   <para>eupont:SaveAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SaveAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SaveAction">http://elite.polito.it/ontologies/eupont.owl#SaveAction</seealso>
    let SaveAction = Prefixed_Name(eupont, "SaveAction") |> PrefixedName
    /// <summary>
    ///   <para>eupont:SaveCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SaveCommand"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SaveCommand">http://elite.polito.it/ontologies/eupont.owl#SaveCommand</seealso>
    let SaveCommand = Prefixed_Name(eupont, "SaveCommand") |> PrefixedName
    /// <summary>
    ///   <para>eupont:SaveContactAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SaveContactAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SaveContactAction">http://elite.polito.it/ontologies/eupont.owl#SaveContactAction</seealso>
    let SaveContactAction = Prefixed_Name(eupont, "SaveContactAction") |> PrefixedName
    /// <summary>
    ///   <para>eupont:SaveFileAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SaveFileAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SaveFileAction">http://elite.polito.it/ontologies/eupont.owl#SaveFileAction</seealso>
    let SaveFileAction = Prefixed_Name(eupont, "SaveFileAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:SaveHealthInformationAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SaveHealthInformationAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SaveHealthInformationAction">http://elite.polito.it/ontologies/eupont.owl#SaveHealthInformationAction</seealso>
    let SaveHealthInformationAction =
        Prefixed_Name(eupont, "SaveHealthInformationAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:SaveMediaInformationAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SaveMediaInformationAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SaveMediaInformationAction">http://elite.polito.it/ontologies/eupont.owl#SaveMediaInformationAction</seealso>
    let SaveMediaInformationAction =
        Prefixed_Name(eupont, "SaveMediaInformationAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:SaveNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SaveNotification"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SaveNotification">http://elite.polito.it/ontologies/eupont.owl#SaveNotification</seealso>
    let SaveNotification = Prefixed_Name(eupont, "SaveNotification") |> PrefixedName

    /// <summary>
    ///   <para>eupont:SaveWebBookmarkAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SaveWebBookmarkAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SaveWebBookmarkAction">http://elite.polito.it/ontologies/eupont.owl#SaveWebBookmarkAction</seealso>
    let SaveWebBookmarkAction =
        Prefixed_Name(eupont, "SaveWebBookmarkAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:SavedTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SavedTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SavedTrigger">http://elite.polito.it/ontologies/eupont.owl#SavedTrigger</seealso>
    let SavedTrigger = Prefixed_Name(eupont, "SavedTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:ScanBluetoothTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ScanBluetoothTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#ScanBluetoothTrigger">http://elite.polito.it/ontologies/eupont.owl#ScanBluetoothTrigger</seealso>
    let ScanBluetoothTrigger =
        Prefixed_Name(eupont, "ScanBluetoothTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:ScanWifiTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ScanWifiTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#ScanWifiTrigger">http://elite.polito.it/ontologies/eupont.owl#ScanWifiTrigger</seealso>
    let ScanWifiTrigger = Prefixed_Name(eupont, "ScanWifiTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:ScreenRotationDisabledTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ScreenRotationDisabledTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#ScreenRotationDisabledTrigger">http://elite.polito.it/ontologies/eupont.owl#ScreenRotationDisabledTrigger</seealso>
    let ScreenRotationDisabledTrigger =
        Prefixed_Name(eupont, "ScreenRotationDisabledTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:ScreenRotationEnabledTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ScreenRotationEnabledTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#ScreenRotationEnabledTrigger">http://elite.polito.it/ontologies/eupont.owl#ScreenRotationEnabledTrigger</seealso>
    let ScreenRotationEnabledTrigger =
        Prefixed_Name(eupont, "ScreenRotationEnabledTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:SecurityService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SecurityService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SecurityService">http://elite.polito.it/ontologies/eupont.owl#SecurityService</seealso>
    let SecurityService = Prefixed_Name(eupont, "SecurityService") |> PrefixedName

    /// <summary>
    ///   <para>eupont:SecurityShutdownAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SecurityShutdownAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SecurityShutdownAction">http://elite.polito.it/ontologies/eupont.owl#SecurityShutdownAction</seealso>
    let SecurityShutdownAction =
        Prefixed_Name(eupont, "SecurityShutdownAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:SecuritySystemDisabledTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SecuritySystemDisabledTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SecuritySystemDisabledTrigger">http://elite.polito.it/ontologies/eupont.owl#SecuritySystemDisabledTrigger</seealso>
    let SecuritySystemDisabledTrigger =
        Prefixed_Name(eupont, "SecuritySystemDisabledTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:SecuritySystemEnabledTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StartedListeningMusicTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SecuritySystemEnabledTrigger">http://elite.polito.it/ontologies/eupont.owl#SecuritySystemEnabledTrigger</seealso>
    let SecuritySystemEnabledTrigger =
        Prefixed_Name(eupont, "SecuritySystemEnabledTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:SendAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SendAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SendAction">http://elite.polito.it/ontologies/eupont.owl#SendAction</seealso>
    let SendAction = Prefixed_Name(eupont, "SendAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:SendAttachmentAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SendAttachmentAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SendAttachmentAction">http://elite.polito.it/ontologies/eupont.owl#SendAttachmentAction</seealso>
    let SendAttachmentAction =
        Prefixed_Name(eupont, "SendAttachmentAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:SendCallAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SendCallAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SendCallAction">http://elite.polito.it/ontologies/eupont.owl#SendCallAction</seealso>
    let SendCallAction = Prefixed_Name(eupont, "SendCallAction") |> PrefixedName
    /// <summary>
    ///   <para>eupont:SendCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SendCommand"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SendCommand">http://elite.polito.it/ontologies/eupont.owl#SendCommand</seealso>
    let SendCommand = Prefixed_Name(eupont, "SendCommand") |> PrefixedName
    /// <summary>
    ///   <para>eupont:SendMessageAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SendMessageAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SendMessageAction">http://elite.polito.it/ontologies/eupont.owl#SendMessageAction</seealso>
    let SendMessageAction = Prefixed_Name(eupont, "SendMessageAction") |> PrefixedName
    /// <summary>
    ///   <para>eupont:SendNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SendNotification"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SendNotification">http://elite.polito.it/ontologies/eupont.owl#SendNotification</seealso>
    let SendNotification = Prefixed_Name(eupont, "SendNotification") |> PrefixedName
    /// <summary>
    ///   <para>eupont:SendQuestionAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SendQuestionAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SendQuestionAction">http://elite.polito.it/ontologies/eupont.owl#SendQuestionAction</seealso>
    let SendQuestionAction = Prefixed_Name(eupont, "SendQuestionAction") |> PrefixedName
    /// <summary>
    ///   <para>eupont:SendRequestAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SendRequestAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SendRequestAction">http://elite.polito.it/ontologies/eupont.owl#SendRequestAction</seealso>
    let SendRequestAction = Prefixed_Name(eupont, "SendRequestAction") |> PrefixedName
    /// <summary>
    ///   <para>eupont:SendToDeviceAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SendToDeviceAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SendToDeviceAction">http://elite.polito.it/ontologies/eupont.owl#SendToDeviceAction</seealso>
    let SendToDeviceAction = Prefixed_Name(eupont, "SendToDeviceAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:SendToDisplayAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SendToDisplayAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SendToDisplayAction">http://elite.polito.it/ontologies/eupont.owl#SendToDisplayAction</seealso>
    let SendToDisplayAction =
        Prefixed_Name(eupont, "SendToDisplayAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:SendToDiyAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SendToDiyAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SendToDiyAction">http://elite.polito.it/ontologies/eupont.owl#SendToDiyAction</seealso>
    let SendToDiyAction = Prefixed_Name(eupont, "SendToDiyAction") |> PrefixedName
    /// <summary>
    ///   <para>eupont:SendToPersonAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SendToPersonAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SendToPersonAction">http://elite.polito.it/ontologies/eupont.owl#SendToPersonAction</seealso>
    let SendToPersonAction = Prefixed_Name(eupont, "SendToPersonAction") |> PrefixedName
    /// <summary>
    ///   <para>eupont:SendToPrintAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SendToPrintAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SendToPrintAction">http://elite.polito.it/ontologies/eupont.owl#SendToPrintAction</seealso>
    let SendToPrintAction = Prefixed_Name(eupont, "SendToPrintAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:SendToSpeakerAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SendToSpeakerAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SendToSpeakerAction">http://elite.polito.it/ontologies/eupont.owl#SendToSpeakerAction</seealso>
    let SendToSpeakerAction =
        Prefixed_Name(eupont, "SendToSpeakerAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:SendWebRequestAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SendWebRequestAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SendWebRequestAction">http://elite.polito.it/ontologies/eupont.owl#SendWebRequestAction</seealso>
    let SendWebRequestAction =
        Prefixed_Name(eupont, "SendWebRequestAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:SensedAirPressureDecreasedTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SensedAirPressureDecreasedTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SensedAirPressureDecreasedTrigger">http://elite.polito.it/ontologies/eupont.owl#SensedAirPressureDecreasedTrigger</seealso>
    let SensedAirPressureDecreasedTrigger =
        Prefixed_Name(eupont, "SensedAirPressureDecreasedTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:SensedAirPressureIncreasedTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SensedAirPressureIncreasedTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SensedAirPressureIncreasedTrigger">http://elite.polito.it/ontologies/eupont.owl#SensedAirPressureIncreasedTrigger</seealso>
    let SensedAirPressureIncreasedTrigger =
        Prefixed_Name(eupont, "SensedAirPressureIncreasedTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:SensedAirQualityDecreasedTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SensedAirQualityDecreasedTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SensedAirQualityDecreasedTrigger">http://elite.polito.it/ontologies/eupont.owl#SensedAirQualityDecreasedTrigger</seealso>
    let SensedAirQualityDecreasedTrigger =
        Prefixed_Name(eupont, "SensedAirQualityDecreasedTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:SensedAirQualityIncreasedTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SensedAirQualityIncreasedTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SensedAirQualityIncreasedTrigger">http://elite.polito.it/ontologies/eupont.owl#SensedAirQualityIncreasedTrigger</seealso>
    let SensedAirQualityIncreasedTrigger =
        Prefixed_Name(eupont, "SensedAirQualityIncreasedTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:SensedHealthyParameterTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SensedHealthyParameterTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SensedHealthyParameterTrigger">http://elite.polito.it/ontologies/eupont.owl#SensedHealthyParameterTrigger</seealso>
    let SensedHealthyParameterTrigger =
        Prefixed_Name(eupont, "SensedHealthyParameterTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:SensedHumididtyDecreasedTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SensedHumididtyDecreasedTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SensedHumididtyDecreasedTrigger">http://elite.polito.it/ontologies/eupont.owl#SensedHumididtyDecreasedTrigger</seealso>
    let SensedHumididtyDecreasedTrigger =
        Prefixed_Name(eupont, "SensedHumididtyDecreasedTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:SensedHumidityIncreasedTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SensedHumidityIncreasedTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SensedHumidityIncreasedTrigger">http://elite.polito.it/ontologies/eupont.owl#SensedHumidityIncreasedTrigger</seealso>
    let SensedHumidityIncreasedTrigger =
        Prefixed_Name(eupont, "SensedHumidityIncreasedTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:SensedLightingDecreasedTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SensedLightingDecreasedTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SensedLightingDecreasedTrigger">http://elite.polito.it/ontologies/eupont.owl#SensedLightingDecreasedTrigger</seealso>
    let SensedLightingDecreasedTrigger =
        Prefixed_Name(eupont, "SensedLightingDecreasedTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:SensedLightingIncreasedTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SensedLightingIncreasedTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SensedLightingIncreasedTrigger">http://elite.polito.it/ontologies/eupont.owl#SensedLightingIncreasedTrigger</seealso>
    let SensedLightingIncreasedTrigger =
        Prefixed_Name(eupont, "SensedLightingIncreasedTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:SensedNoiseLevelDecreasedTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SensedNoiseLevelDecreasedTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SensedNoiseLevelDecreasedTrigger">http://elite.polito.it/ontologies/eupont.owl#SensedNoiseLevelDecreasedTrigger</seealso>
    let SensedNoiseLevelDecreasedTrigger =
        Prefixed_Name(eupont, "SensedNoiseLevelDecreasedTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:SensedNoiseLevelIncreasedTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SensedNoiseLevelIncreasedTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SensedNoiseLevelIncreasedTrigger">http://elite.polito.it/ontologies/eupont.owl#SensedNoiseLevelIncreasedTrigger</seealso>
    let SensedNoiseLevelIncreasedTrigger =
        Prefixed_Name(eupont, "SensedNoiseLevelIncreasedTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:SensedRainDetectedTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SensedRainDetectedTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SensedRainDetectedTrigger">http://elite.polito.it/ontologies/eupont.owl#SensedRainDetectedTrigger</seealso>
    let SensedRainDetectedTrigger =
        Prefixed_Name(eupont, "SensedRainDetectedTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:SensedRainNoLongerDetectedTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SensedRainNoLongerDetectedTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SensedRainNoLongerDetectedTrigger">http://elite.polito.it/ontologies/eupont.owl#SensedRainNoLongerDetectedTrigger</seealso>
    let SensedRainNoLongerDetectedTrigger =
        Prefixed_Name(eupont, "SensedRainNoLongerDetectedTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:SensedTemperatureDecreasedTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SensedTemperatureDecreasedTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SensedTemperatureDecreasedTrigger">http://elite.polito.it/ontologies/eupont.owl#SensedTemperatureDecreasedTrigger</seealso>
    let SensedTemperatureDecreasedTrigger =
        Prefixed_Name(eupont, "SensedTemperatureDecreasedTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:SensedTemperatureIncreasedTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SensedTemperatureIncreasedTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SensedTemperatureIncreasedTrigger">http://elite.polito.it/ontologies/eupont.owl#SensedTemperatureIncreasedTrigger</seealso>
    let SensedTemperatureIncreasedTrigger =
        Prefixed_Name(eupont, "SensedTemperatureIncreasedTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:SensedWindDecreasedTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SensedWindDecreasedTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SensedWindDecreasedTrigger">http://elite.polito.it/ontologies/eupont.owl#SensedWindDecreasedTrigger</seealso>
    let SensedWindDecreasedTrigger =
        Prefixed_Name(eupont, "SensedWindDecreasedTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:SensedWindIncreasedTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SensedWindIncreasedTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SensedWindIncreasedTrigger">http://elite.polito.it/ontologies/eupont.owl#SensedWindIncreasedTrigger</seealso>
    let SensedWindIncreasedTrigger =
        Prefixed_Name(eupont, "SensedWindIncreasedTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:SensorPresenceDetectedTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SensorPresenceDetectedTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SensorPresenceDetectedTrigger">http://elite.polito.it/ontologies/eupont.owl#SensorPresenceDetectedTrigger</seealso>
    let SensorPresenceDetectedTrigger =
        Prefixed_Name(eupont, "SensorPresenceDetectedTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:SensorPresenceNoLongerDetectedTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SensorPresenceNoLongerDetectedTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SensorPresenceNoLongerDetectedTrigger">http://elite.polito.it/ontologies/eupont.owl#SensorPresenceNoLongerDetectedTrigger</seealso>
    let SensorPresenceNoLongerDetectedTrigger =
        Prefixed_Name(eupont, "SensorPresenceNoLongerDetectedTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:SentMessageTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SentMessageTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SentMessageTrigger">http://elite.polito.it/ontologies/eupont.owl#SentMessageTrigger</seealso>
    let SentMessageTrigger = Prefixed_Name(eupont, "SentMessageTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:SentOutcomingCallTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SentOutcomingCallTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SentOutcomingCallTrigger">http://elite.polito.it/ontologies/eupont.owl#SentOutcomingCallTrigger</seealso>
    let SentOutcomingCallTrigger =
        Prefixed_Name(eupont, "SentOutcomingCallTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:SentPrivateInformationTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SentPrivateInformationTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SentPrivateInformationTrigger">http://elite.polito.it/ontologies/eupont.owl#SentPrivateInformationTrigger</seealso>
    let SentPrivateInformationTrigger =
        Prefixed_Name(eupont, "SentPrivateInformationTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:SentPullTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SentPullTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SentPullTrigger">http://elite.polito.it/ontologies/eupont.owl#SentPullTrigger</seealso>
    let SentPullTrigger = Prefixed_Name(eupont, "SentPullTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:SentQuestionTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SentQuestionTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SentQuestionTrigger">http://elite.polito.it/ontologies/eupont.owl#SentQuestionTrigger</seealso>
    let SentQuestionTrigger =
        Prefixed_Name(eupont, "SentQuestionTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:SentRequestTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SentRequestTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SentRequestTrigger">http://elite.polito.it/ontologies/eupont.owl#SentRequestTrigger</seealso>
    let SentRequestTrigger = Prefixed_Name(eupont, "SentRequestTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:SentSharedInformationTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SentSharedInformationTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SentSharedInformationTrigger">http://elite.polito.it/ontologies/eupont.owl#SentSharedInformationTrigger</seealso>
    let SentSharedInformationTrigger =
        Prefixed_Name(eupont, "SentSharedInformationTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:SentSubscriptionTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SentSubscriptionTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SentSubscriptionTrigger">http://elite.polito.it/ontologies/eupont.owl#SentSubscriptionTrigger</seealso>
    let SentSubscriptionTrigger =
        Prefixed_Name(eupont, "SentSubscriptionTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:SentTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SentTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SentTrigger">http://elite.polito.it/ontologies/eupont.owl#SentTrigger</seealso>
    let SentTrigger = Prefixed_Name(eupont, "SentTrigger") |> PrefixedName
    /// <summary>
    ///   <para>eupont:Service</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Service"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#Service">http://elite.polito.it/ontologies/eupont.owl#Service</seealso>
    let Service = Prefixed_Name(eupont, "Service") |> PrefixedName

    /// <summary>
    ///   <para>eupont:SetBrightnessAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SetBrightnessAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SetBrightnessAction">http://elite.polito.it/ontologies/eupont.owl#SetBrightnessAction</seealso>
    let SetBrightnessAction =
        Prefixed_Name(eupont, "SetBrightnessAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:SetEnvironmentComfortAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SetEnvironmentComfortAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SetEnvironmentComfortAction">http://elite.polito.it/ontologies/eupont.owl#SetEnvironmentComfortAction</seealso>
    let SetEnvironmentComfortAction =
        Prefixed_Name(eupont, "SetEnvironmentComfortAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:SetHumidityAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SetHumidityAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SetHumidityAction">http://elite.polito.it/ontologies/eupont.owl#SetHumidityAction</seealso>
    let SetHumidityAction = Prefixed_Name(eupont, "SetHumidityAction") |> PrefixedName
    /// <summary>
    ///   <para>eupont:SetLightingAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SetLightingAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SetLightingAction">http://elite.polito.it/ontologies/eupont.owl#SetLightingAction</seealso>
    let SetLightingAction = Prefixed_Name(eupont, "SetLightingAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:SetTemperatureAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SetTemperatureAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SetTemperatureAction">http://elite.polito.it/ontologies/eupont.owl#SetTemperatureAction</seealso>
    let SetTemperatureAction =
        Prefixed_Name(eupont, "SetTemperatureAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:SetToCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SetToCommand"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SetToCommand">http://elite.polito.it/ontologies/eupont.owl#SetToCommand</seealso>
    let SetToCommand = Prefixed_Name(eupont, "SetToCommand") |> PrefixedName
    /// <summary>
    ///   <para>eupont:SetToNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SetToNotification"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SetToNotification">http://elite.polito.it/ontologies/eupont.owl#SetToNotification</seealso>
    let SetToNotification = Prefixed_Name(eupont, "SetToNotification") |> PrefixedName
    /// <summary>
    ///   <para>eupont:ShareAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ShareAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#ShareAction">http://elite.polito.it/ontologies/eupont.owl#ShareAction</seealso>
    let ShareAction = Prefixed_Name(eupont, "ShareAction") |> PrefixedName
    /// <summary>
    ///   <para>eupont:ShareCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ShareCommand"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#ShareCommand">http://elite.polito.it/ontologies/eupont.owl#ShareCommand</seealso>
    let ShareCommand = Prefixed_Name(eupont, "ShareCommand") |> PrefixedName
    /// <summary>
    ///   <para>eupont:ShareCommentAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ShareCommentAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#ShareCommentAction">http://elite.polito.it/ontologies/eupont.owl#ShareCommentAction</seealso>
    let ShareCommentAction = Prefixed_Name(eupont, "ShareCommentAction") |> PrefixedName
    /// <summary>
    ///   <para>eupont:ShareFileAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ShareFileAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#ShareFileAction">http://elite.polito.it/ontologies/eupont.owl#ShareFileAction</seealso>
    let ShareFileAction = Prefixed_Name(eupont, "ShareFileAction") |> PrefixedName
    /// <summary>
    ///   <para>eupont:ShareLikeAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ShareLikeAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#ShareLikeAction">http://elite.polito.it/ontologies/eupont.owl#ShareLikeAction</seealso>
    let ShareLikeAction = Prefixed_Name(eupont, "ShareLikeAction") |> PrefixedName
    /// <summary>
    ///   <para>eupont:ShareNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ShareNotification"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#ShareNotification">http://elite.polito.it/ontologies/eupont.owl#ShareNotification</seealso>
    let ShareNotification = Prefixed_Name(eupont, "ShareNotification") |> PrefixedName
    /// <summary>
    ///   <para>eupont:SharePostAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SharePostAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SharePostAction">http://elite.polito.it/ontologies/eupont.owl#SharePostAction</seealso>
    let SharePostAction = Prefixed_Name(eupont, "SharePostAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:ShareProfileUpdateAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ShareProfileUpdateAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#ShareProfileUpdateAction">http://elite.polito.it/ontologies/eupont.owl#ShareProfileUpdateAction</seealso>
    let ShareProfileUpdateAction =
        Prefixed_Name(eupont, "ShareProfileUpdateAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:ShareTagAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ShareTagAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#ShareTagAction">http://elite.polito.it/ontologies/eupont.owl#ShareTagAction</seealso>
    let ShareTagAction = Prefixed_Name(eupont, "ShareTagAction") |> PrefixedName
    /// <summary>
    ///   <para>eupont:ShareUnlikeAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ShareUnlikeAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#ShareUnlikeAction">http://elite.polito.it/ontologies/eupont.owl#ShareUnlikeAction</seealso>
    let ShareUnlikeAction = Prefixed_Name(eupont, "ShareUnlikeAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:SharedCommentTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SharedCommentTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SharedCommentTrigger">http://elite.polito.it/ontologies/eupont.owl#SharedCommentTrigger</seealso>
    let SharedCommentTrigger =
        Prefixed_Name(eupont, "SharedCommentTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:SharedLikeTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SharedLikeTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SharedLikeTrigger">http://elite.polito.it/ontologies/eupont.owl#SharedLikeTrigger</seealso>
    let SharedLikeTrigger = Prefixed_Name(eupont, "SharedLikeTrigger") |> PrefixedName
    /// <summary>
    ///   <para>eupont:SharedPostTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SharedPostTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SharedPostTrigger">http://elite.polito.it/ontologies/eupont.owl#SharedPostTrigger</seealso>
    let SharedPostTrigger = Prefixed_Name(eupont, "SharedPostTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:SharedProfileUpdateTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SharedProfileUpdateTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SharedProfileUpdateTrigger">http://elite.polito.it/ontologies/eupont.owl#SharedProfileUpdateTrigger</seealso>
    let SharedProfileUpdateTrigger =
        Prefixed_Name(eupont, "SharedProfileUpdateTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:SharedTagTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SharedTagTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SharedTagTrigger">http://elite.polito.it/ontologies/eupont.owl#SharedTagTrigger</seealso>
    let SharedTagTrigger = Prefixed_Name(eupont, "SharedTagTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:SharedUnlikeTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SharedUnlikeTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SharedUnlikeTrigger">http://elite.polito.it/ontologies/eupont.owl#SharedUnlikeTrigger</seealso>
    let SharedUnlikeTrigger =
        Prefixed_Name(eupont, "SharedUnlikeTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:ShipmentTrackingTool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ShipmentTrackingTool"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#ShipmentTrackingTool">http://elite.polito.it/ontologies/eupont.owl#ShipmentTrackingTool</seealso>
    let ShipmentTrackingTool =
        Prefixed_Name(eupont, "ShipmentTrackingTool") |> PrefixedName

    /// <summary>
    ///   <para>eupont:ShoppingTool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ShoppingTool"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#ShoppingTool">http://elite.polito.it/ontologies/eupont.owl#ShoppingTool</seealso>
    let ShoppingTool = Prefixed_Name(eupont, "ShoppingTool") |> PrefixedName

    /// <summary>
    ///   <para>eupont:SleepTrackingService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SleepTrackingService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SleepTrackingService">http://elite.polito.it/ontologies/eupont.owl#SleepTrackingService</seealso>
    let SleepTrackingService =
        Prefixed_Name(eupont, "SleepTrackingService") |> PrefixedName

    /// <summary>
    ///   <para>eupont:SmartBlind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Blind"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SmartBlind">http://elite.polito.it/ontologies/eupont.owl#SmartBlind</seealso>
    let SmartBlind = Prefixed_Name(eupont, "SmartBlind") |> PrefixedName
    /// <summary>
    ///   <para>eupont:SmartBracelet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SmartBracelet"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SmartBracelet">http://elite.polito.it/ontologies/eupont.owl#SmartBracelet</seealso>
    let SmartBracelet = Prefixed_Name(eupont, "SmartBracelet") |> PrefixedName
    /// <summary>
    ///   <para>eupont:SmartCitySystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SmartCitySystem"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SmartCitySystem">http://elite.polito.it/ontologies/eupont.owl#SmartCitySystem</seealso>
    let SmartCitySystem = Prefixed_Name(eupont, "SmartCitySystem") |> PrefixedName
    /// <summary>
    ///   <para>eupont:SmartDoor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Door"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SmartDoor">http://elite.polito.it/ontologies/eupont.owl#SmartDoor</seealso>
    let SmartDoor = Prefixed_Name(eupont, "SmartDoor") |> PrefixedName

    /// <summary>
    ///   <para>eupont:SmartEnvironmentService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SmartEnvironmentService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SmartEnvironmentService">http://elite.polito.it/ontologies/eupont.owl#SmartEnvironmentService</seealso>
    let SmartEnvironmentService =
        Prefixed_Name(eupont, "SmartEnvironmentService") |> PrefixedName

    /// <summary>
    ///   <para>eupont:SmartEnvironmentSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SmartEnvironmentSystem"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SmartEnvironmentSystem">http://elite.polito.it/ontologies/eupont.owl#SmartEnvironmentSystem</seealso>
    let SmartEnvironmentSystem =
        Prefixed_Name(eupont, "SmartEnvironmentSystem") |> PrefixedName

    /// <summary>
    ///   <para>eupont:SmartWatch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SmartWatch"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SmartWatch">http://elite.polito.it/ontologies/eupont.owl#SmartWatch</seealso>
    let SmartWatch = Prefixed_Name(eupont, "SmartWatch") |> PrefixedName
    /// <summary>
    ///   <para>eupont:SmartWindow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Window"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SmartWindow">http://elite.polito.it/ontologies/eupont.owl#SmartWindow</seealso>
    let SmartWindow = Prefixed_Name(eupont, "SmartWindow") |> PrefixedName
    /// <summary>
    ///   <para>eupont:Smartphone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Smartphone"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#Smartphone">http://elite.polito.it/ontologies/eupont.owl#Smartphone</seealso>
    let Smartphone = Prefixed_Name(eupont, "Smartphone") |> PrefixedName
    /// <summary>
    ///   <para>eupont:SocialNetwork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SocialNetwork"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SocialNetwork">http://elite.polito.it/ontologies/eupont.owl#SocialNetwork</seealso>
    let SocialNetwork = Prefixed_Name(eupont, "SocialNetwork") |> PrefixedName

    /// <summary>
    ///   <para>eupont:SpeakerPhoneActivatedTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SpeakerPhoneActivatedTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#SpeakerPhoneActivatedTrigger">http://elite.polito.it/ontologies/eupont.owl#SpeakerPhoneActivatedTrigger</seealso>
    let SpeakerPhoneActivatedTrigger =
        Prefixed_Name(eupont, "SpeakerPhoneActivatedTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:Sprinkler</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Sprinkler"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#Sprinkler">http://elite.polito.it/ontologies/eupont.owl#Sprinkler</seealso>
    let Sprinkler = Prefixed_Name(eupont, "Sprinkler") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StartActivityAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StartActivityAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StartActivityAction">http://elite.polito.it/ontologies/eupont.owl#StartActivityAction</seealso>
    let StartActivityAction =
        Prefixed_Name(eupont, "StartActivityAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StartAppAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StartAppAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StartAppAction">http://elite.polito.it/ontologies/eupont.owl#StartAppAction</seealso>
    let StartAppAction = Prefixed_Name(eupont, "StartAppAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StartBrewingCoffeeAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StartBrewingCoffeeAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StartBrewingCoffeeAction">http://elite.polito.it/ontologies/eupont.owl#StartBrewingCoffeeAction</seealso>
    let StartBrewingCoffeeAction =
        Prefixed_Name(eupont, "StartBrewingCoffeeAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StartBuyingAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StartBuyingAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StartBuyingAction">http://elite.polito.it/ontologies/eupont.owl#StartBuyingAction</seealso>
    let StartBuyingAction = Prefixed_Name(eupont, "StartBuyingAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StartCleaningAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StartCleaningAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StartCleaningAction">http://elite.polito.it/ontologies/eupont.owl#StartCleaningAction</seealso>
    let StartCleaningAction =
        Prefixed_Name(eupont, "StartCleaningAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StartCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StartCommand"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StartCommand">http://elite.polito.it/ontologies/eupont.owl#StartCommand</seealso>
    let StartCommand = Prefixed_Name(eupont, "StartCommand") |> PrefixedName
    /// <summary>
    ///   <para>eupont:StartCookingAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StartCookingAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StartCookingAction">http://elite.polito.it/ontologies/eupont.owl#StartCookingAction</seealso>
    let StartCookingAction = Prefixed_Name(eupont, "StartCookingAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StartDiswashingAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StartDishwashingAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StartDiswashingAction">http://elite.polito.it/ontologies/eupont.owl#StartDiswashingAction</seealso>
    let StartDiswashingAction =
        Prefixed_Name(eupont, "StartDiswashingAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StartDryingAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StartDryingAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StartDryingAction">http://elite.polito.it/ontologies/eupont.owl#StartDryingAction</seealso>
    let StartDryingAction = Prefixed_Name(eupont, "StartDryingAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StartEntertainementAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StartEntertainmentAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StartEntertainementAction">http://elite.polito.it/ontologies/eupont.owl#StartEntertainementAction</seealso>
    let StartEntertainementAction =
        Prefixed_Name(eupont, "StartEntertainementAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StartFocusingAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StartFocusingAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StartFocusingAction">http://elite.polito.it/ontologies/eupont.owl#StartFocusingAction</seealso>
    let StartFocusingAction =
        Prefixed_Name(eupont, "StartFocusingAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StartFocusingSessionAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StartFocusingSessionAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StartFocusingSessionAction">http://elite.polito.it/ontologies/eupont.owl#StartFocusingSessionAction</seealso>
    let StartFocusingSessionAction =
        Prefixed_Name(eupont, "StartFocusingSessionAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StartListeningMusicAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StartListeningMusicAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StartListeningMusicAction">http://elite.polito.it/ontologies/eupont.owl#StartListeningMusicAction</seealso>
    let StartListeningMusicAction =
        Prefixed_Name(eupont, "StartListeningMusicAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StartNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StartNotification"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StartNotification">http://elite.polito.it/ontologies/eupont.owl#StartNotification</seealso>
    let StartNotification = Prefixed_Name(eupont, "StartNotification") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StartOvenCookingAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StartOvenCookingAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StartOvenCookingAction">http://elite.polito.it/ontologies/eupont.owl#StartOvenCookingAction</seealso>
    let StartOvenCookingAction =
        Prefixed_Name(eupont, "StartOvenCookingAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StartPlayingAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StartPlayingAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StartPlayingAction">http://elite.polito.it/ontologies/eupont.owl#StartPlayingAction</seealso>
    let StartPlayingAction = Prefixed_Name(eupont, "StartPlayingAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StartStudyingSessionAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StartStudyingSessionAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StartStudyingSessionAction">http://elite.polito.it/ontologies/eupont.owl#StartStudyingSessionAction</seealso>
    let StartStudyingSessionAction =
        Prefixed_Name(eupont, "StartStudyingSessionAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StartSuperMarketBuyingAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StartSuperMarketBuyingAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StartSuperMarketBuyingAction">http://elite.polito.it/ontologies/eupont.owl#StartSuperMarketBuyingAction</seealso>
    let StartSuperMarketBuyingAction =
        Prefixed_Name(eupont, "StartSuperMarketBuyingAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StartUsingSmartphoneAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StartUsingSmartphoneAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StartUsingSmartphoneAction">http://elite.polito.it/ontologies/eupont.owl#StartUsingSmartphoneAction</seealso>
    let StartUsingSmartphoneAction =
        Prefixed_Name(eupont, "StartUsingSmartphoneAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StartVacuumAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StartVacuumAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StartVacuumAction">http://elite.polito.it/ontologies/eupont.owl#StartVacuumAction</seealso>
    let StartVacuumAction = Prefixed_Name(eupont, "StartVacuumAction") |> PrefixedName
    /// <summary>
    ///   <para>eupont:StartWashingAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StartWashingAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StartWashingAction">http://elite.polito.it/ontologies/eupont.owl#StartWashingAction</seealso>
    let StartWashingAction = Prefixed_Name(eupont, "StartWashingAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StartWashingClothesAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StartWashingClothesAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StartWashingClothesAction">http://elite.polito.it/ontologies/eupont.owl#StartWashingClothesAction</seealso>
    let StartWashingClothesAction =
        Prefixed_Name(eupont, "StartWashingClothesAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StartWatchingTvAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StartWatchingTvAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StartWatchingTvAction">http://elite.polito.it/ontologies/eupont.owl#StartWatchingTvAction</seealso>
    let StartWatchingTvAction =
        Prefixed_Name(eupont, "StartWatchingTvAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StartedActivityTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StartedActivityTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StartedActivityTrigger">http://elite.polito.it/ontologies/eupont.owl#StartedActivityTrigger</seealso>
    let StartedActivityTrigger =
        Prefixed_Name(eupont, "StartedActivityTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StartedAppTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StartedAppTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StartedAppTrigger">http://elite.polito.it/ontologies/eupont.owl#StartedAppTrigger</seealso>
    let StartedAppTrigger = Prefixed_Name(eupont, "StartedAppTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StartedBikeSessionTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StartedBikeSessionTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StartedBikeSessionTrigger">http://elite.polito.it/ontologies/eupont.owl#StartedBikeSessionTrigger</seealso>
    let StartedBikeSessionTrigger =
        Prefixed_Name(eupont, "StartedBikeSessionTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StartedBrewingCoffeeTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StartedBrewingCoffeeTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StartedBrewingCoffeeTrigger">http://elite.polito.it/ontologies/eupont.owl#StartedBrewingCoffeeTrigger</seealso>
    let StartedBrewingCoffeeTrigger =
        Prefixed_Name(eupont, "StartedBrewingCoffeeTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StartedCleaningTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StartedCleaningTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StartedCleaningTrigger">http://elite.polito.it/ontologies/eupont.owl#StartedCleaningTrigger</seealso>
    let StartedCleaningTrigger =
        Prefixed_Name(eupont, "StartedCleaningTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StartedCookingTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StartedCookingTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StartedCookingTrigger">http://elite.polito.it/ontologies/eupont.owl#StartedCookingTrigger</seealso>
    let StartedCookingTrigger =
        Prefixed_Name(eupont, "StartedCookingTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StartedDiswashingTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StartedDiswashingTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StartedDiswashingTrigger">http://elite.polito.it/ontologies/eupont.owl#StartedDiswashingTrigger</seealso>
    let StartedDiswashingTrigger =
        Prefixed_Name(eupont, "StartedDiswashingTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StartedDryingTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StartedDryingTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StartedDryingTrigger">http://elite.polito.it/ontologies/eupont.owl#StartedDryingTrigger</seealso>
    let StartedDryingTrigger =
        Prefixed_Name(eupont, "StartedDryingTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StartedEntertainementTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StartedEntertainementTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StartedEntertainementTrigger">http://elite.polito.it/ontologies/eupont.owl#StartedEntertainementTrigger</seealso>
    let StartedEntertainementTrigger =
        Prefixed_Name(eupont, "StartedEntertainementTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StartedFocusingSessionTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StartedFocusingSessionTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StartedFocusingSessionTrigger">http://elite.polito.it/ontologies/eupont.owl#StartedFocusingSessionTrigger</seealso>
    let StartedFocusingSessionTrigger =
        Prefixed_Name(eupont, "StartedFocusingSessionTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StartedFocusingTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StartedFocusingTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StartedFocusingTrigger">http://elite.polito.it/ontologies/eupont.owl#StartedFocusingTrigger</seealso>
    let StartedFocusingTrigger =
        Prefixed_Name(eupont, "StartedFocusingTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StartedInteractionTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StartedInteractionTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StartedInteractionTrigger">http://elite.polito.it/ontologies/eupont.owl#StartedInteractionTrigger</seealso>
    let StartedInteractionTrigger =
        Prefixed_Name(eupont, "StartedInteractionTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StartedListeningMusicTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StartedListeningMusicTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StartedListeningMusicTrigger">http://elite.polito.it/ontologies/eupont.owl#StartedListeningMusicTrigger</seealso>
    let StartedListeningMusicTrigger =
        Prefixed_Name(eupont, "StartedListeningMusicTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StartedOvenCookingTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StartedOvenCookingTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StartedOvenCookingTrigger">http://elite.polito.it/ontologies/eupont.owl#StartedOvenCookingTrigger</seealso>
    let StartedOvenCookingTrigger =
        Prefixed_Name(eupont, "StartedOvenCookingTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StartedPhysicalActivityTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StartedPhysicalActivityTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StartedPhysicalActivityTrigger">http://elite.polito.it/ontologies/eupont.owl#StartedPhysicalActivityTrigger</seealso>
    let StartedPhysicalActivityTrigger =
        Prefixed_Name(eupont, "StartedPhysicalActivityTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StartedPlayingTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StartedPlayingTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StartedPlayingTrigger">http://elite.polito.it/ontologies/eupont.owl#StartedPlayingTrigger</seealso>
    let StartedPlayingTrigger =
        Prefixed_Name(eupont, "StartedPlayingTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StartedRelaxingTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StartedRelaxingTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StartedRelaxingTrigger">http://elite.polito.it/ontologies/eupont.owl#StartedRelaxingTrigger</seealso>
    let StartedRelaxingTrigger =
        Prefixed_Name(eupont, "StartedRelaxingTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StartedRunSessionTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StartedRunSessionTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StartedRunSessionTrigger">http://elite.polito.it/ontologies/eupont.owl#StartedRunSessionTrigger</seealso>
    let StartedRunSessionTrigger =
        Prefixed_Name(eupont, "StartedRunSessionTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StartedSleepingTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StartedSleepingTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StartedSleepingTrigger">http://elite.polito.it/ontologies/eupont.owl#StartedSleepingTrigger</seealso>
    let StartedSleepingTrigger =
        Prefixed_Name(eupont, "StartedSleepingTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StartedStudyingSessionTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StartedStudyingSessionTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StartedStudyingSessionTrigger">http://elite.polito.it/ontologies/eupont.owl#StartedStudyingSessionTrigger</seealso>
    let StartedStudyingSessionTrigger =
        Prefixed_Name(eupont, "StartedStudyingSessionTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StartedUsingSmartphoneTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StartedUsingSmartphoneTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StartedUsingSmartphoneTrigger">http://elite.polito.it/ontologies/eupont.owl#StartedUsingSmartphoneTrigger</seealso>
    let StartedUsingSmartphoneTrigger =
        Prefixed_Name(eupont, "StartedUsingSmartphoneTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StartedVacuumTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StartedVacuumTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StartedVacuumTrigger">http://elite.polito.it/ontologies/eupont.owl#StartedVacuumTrigger</seealso>
    let StartedVacuumTrigger =
        Prefixed_Name(eupont, "StartedVacuumTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StartedWalkingSessionTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StartedWalkingSessionTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StartedWalkingSessionTrigger">http://elite.polito.it/ontologies/eupont.owl#StartedWalkingSessionTrigger</seealso>
    let StartedWalkingSessionTrigger =
        Prefixed_Name(eupont, "StartedWalkingSessionTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StartedWashingTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StartedWashingTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StartedWashingTrigger">http://elite.polito.it/ontologies/eupont.owl#StartedWashingTrigger</seealso>
    let StartedWashingTrigger =
        Prefixed_Name(eupont, "StartedWashingTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StartedWatchingTvTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StartedWatchingTvTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StartedWatchingTvTrigger">http://elite.polito.it/ontologies/eupont.owl#StartedWatchingTvTrigger</seealso>
    let StartedWatchingTvTrigger =
        Prefixed_Name(eupont, "StartedWatchingTvTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StartingWashingClothesTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StartingWashingClothesTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StartingWashingClothesTrigger">http://elite.polito.it/ontologies/eupont.owl#StartingWashingClothesTrigger</seealso>
    let StartingWashingClothesTrigger =
        Prefixed_Name(eupont, "StartingWashingClothesTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StopActivityAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StopActivityAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StopActivityAction">http://elite.polito.it/ontologies/eupont.owl#StopActivityAction</seealso>
    let StopActivityAction = Prefixed_Name(eupont, "StopActivityAction") |> PrefixedName
    /// <summary>
    ///   <para>eupont:StopAppAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StopAppAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StopAppAction">http://elite.polito.it/ontologies/eupont.owl#StopAppAction</seealso>
    let StopAppAction = Prefixed_Name(eupont, "StopAppAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StopBrewingCoffeeAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StopBrewingCoffeeAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StopBrewingCoffeeAction">http://elite.polito.it/ontologies/eupont.owl#StopBrewingCoffeeAction</seealso>
    let StopBrewingCoffeeAction =
        Prefixed_Name(eupont, "StopBrewingCoffeeAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StopCleaningAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StopCleaningAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StopCleaningAction">http://elite.polito.it/ontologies/eupont.owl#StopCleaningAction</seealso>
    let StopCleaningAction = Prefixed_Name(eupont, "StopCleaningAction") |> PrefixedName
    /// <summary>
    ///   <para>eupont:StopCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StopCommand"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StopCommand">http://elite.polito.it/ontologies/eupont.owl#StopCommand</seealso>
    let StopCommand = Prefixed_Name(eupont, "StopCommand") |> PrefixedName
    /// <summary>
    ///   <para>eupont:StopCookingAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StopCookingAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StopCookingAction">http://elite.polito.it/ontologies/eupont.owl#StopCookingAction</seealso>
    let StopCookingAction = Prefixed_Name(eupont, "StopCookingAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StopDiswashingAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StopDishwashingAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StopDiswashingAction">http://elite.polito.it/ontologies/eupont.owl#StopDiswashingAction</seealso>
    let StopDiswashingAction =
        Prefixed_Name(eupont, "StopDiswashingAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StopDryingAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StopDryingAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StopDryingAction">http://elite.polito.it/ontologies/eupont.owl#StopDryingAction</seealso>
    let StopDryingAction = Prefixed_Name(eupont, "StopDryingAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StopEntertainementAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StopEntertainmentAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StopEntertainementAction">http://elite.polito.it/ontologies/eupont.owl#StopEntertainementAction</seealso>
    let StopEntertainementAction =
        Prefixed_Name(eupont, "StopEntertainementAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StopFocusingAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StopFocusingAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StopFocusingAction">http://elite.polito.it/ontologies/eupont.owl#StopFocusingAction</seealso>
    let StopFocusingAction = Prefixed_Name(eupont, "StopFocusingAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StopFocusingSessionAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StopFocusingSessionAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StopFocusingSessionAction">http://elite.polito.it/ontologies/eupont.owl#StopFocusingSessionAction</seealso>
    let StopFocusingSessionAction =
        Prefixed_Name(eupont, "StopFocusingSessionAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StopListeningMusicAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StopListeningMusicAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StopListeningMusicAction">http://elite.polito.it/ontologies/eupont.owl#StopListeningMusicAction</seealso>
    let StopListeningMusicAction =
        Prefixed_Name(eupont, "StopListeningMusicAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StopNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StopNotification"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StopNotification">http://elite.polito.it/ontologies/eupont.owl#StopNotification</seealso>
    let StopNotification = Prefixed_Name(eupont, "StopNotification") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StopOvenCookingAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StopOvenCookingAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StopOvenCookingAction">http://elite.polito.it/ontologies/eupont.owl#StopOvenCookingAction</seealso>
    let StopOvenCookingAction =
        Prefixed_Name(eupont, "StopOvenCookingAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StopPlayingAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StopPlayingAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StopPlayingAction">http://elite.polito.it/ontologies/eupont.owl#StopPlayingAction</seealso>
    let StopPlayingAction = Prefixed_Name(eupont, "StopPlayingAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StopStudyingSessionAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StopStudyingSessionAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StopStudyingSessionAction">http://elite.polito.it/ontologies/eupont.owl#StopStudyingSessionAction</seealso>
    let StopStudyingSessionAction =
        Prefixed_Name(eupont, "StopStudyingSessionAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StopUsingSmartphoneAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StopUsingSmartphoneAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StopUsingSmartphoneAction">http://elite.polito.it/ontologies/eupont.owl#StopUsingSmartphoneAction</seealso>
    let StopUsingSmartphoneAction =
        Prefixed_Name(eupont, "StopUsingSmartphoneAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StopVacuumAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StopVacuumAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StopVacuumAction">http://elite.polito.it/ontologies/eupont.owl#StopVacuumAction</seealso>
    let StopVacuumAction = Prefixed_Name(eupont, "StopVacuumAction") |> PrefixedName
    /// <summary>
    ///   <para>eupont:StopWashingAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StopWashingAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StopWashingAction">http://elite.polito.it/ontologies/eupont.owl#StopWashingAction</seealso>
    let StopWashingAction = Prefixed_Name(eupont, "StopWashingAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StopWashingClothesAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StopWashingClothesAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StopWashingClothesAction">http://elite.polito.it/ontologies/eupont.owl#StopWashingClothesAction</seealso>
    let StopWashingClothesAction =
        Prefixed_Name(eupont, "StopWashingClothesAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StopWatchingTvAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StopWatchingTvAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StopWatchingTvAction">http://elite.polito.it/ontologies/eupont.owl#StopWatchingTvAction</seealso>
    let StopWatchingTvAction =
        Prefixed_Name(eupont, "StopWatchingTvAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StoppedActivityTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StoppedActivityTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StoppedActivityTrigger">http://elite.polito.it/ontologies/eupont.owl#StoppedActivityTrigger</seealso>
    let StoppedActivityTrigger =
        Prefixed_Name(eupont, "StoppedActivityTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StoppedAppTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StoppedAppTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StoppedAppTrigger">http://elite.polito.it/ontologies/eupont.owl#StoppedAppTrigger</seealso>
    let StoppedAppTrigger = Prefixed_Name(eupont, "StoppedAppTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StoppedBikeSessionTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StoppedBikeSessionTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StoppedBikeSessionTrigger">http://elite.polito.it/ontologies/eupont.owl#StoppedBikeSessionTrigger</seealso>
    let StoppedBikeSessionTrigger =
        Prefixed_Name(eupont, "StoppedBikeSessionTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StoppedBrewingCoffeeTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StoppedBrewingCoffeeTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StoppedBrewingCoffeeTrigger">http://elite.polito.it/ontologies/eupont.owl#StoppedBrewingCoffeeTrigger</seealso>
    let StoppedBrewingCoffeeTrigger =
        Prefixed_Name(eupont, "StoppedBrewingCoffeeTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StoppedCookingTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StoppedCookingTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StoppedCookingTrigger">http://elite.polito.it/ontologies/eupont.owl#StoppedCookingTrigger</seealso>
    let StoppedCookingTrigger =
        Prefixed_Name(eupont, "StoppedCookingTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StoppedDiswashingTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StoppedDiswashingTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StoppedDiswashingTrigger">http://elite.polito.it/ontologies/eupont.owl#StoppedDiswashingTrigger</seealso>
    let StoppedDiswashingTrigger =
        Prefixed_Name(eupont, "StoppedDiswashingTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StoppedDryingTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StoppedDryingTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StoppedDryingTrigger">http://elite.polito.it/ontologies/eupont.owl#StoppedDryingTrigger</seealso>
    let StoppedDryingTrigger =
        Prefixed_Name(eupont, "StoppedDryingTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StoppedEntertainementTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StoppedEntertainementTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StoppedEntertainementTrigger">http://elite.polito.it/ontologies/eupont.owl#StoppedEntertainementTrigger</seealso>
    let StoppedEntertainementTrigger =
        Prefixed_Name(eupont, "StoppedEntertainementTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StoppedFocusingSessionTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StoppedFocusingSessionTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StoppedFocusingSessionTrigger">http://elite.polito.it/ontologies/eupont.owl#StoppedFocusingSessionTrigger</seealso>
    let StoppedFocusingSessionTrigger =
        Prefixed_Name(eupont, "StoppedFocusingSessionTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StoppedFocusingTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StoppedFocusingTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StoppedFocusingTrigger">http://elite.polito.it/ontologies/eupont.owl#StoppedFocusingTrigger</seealso>
    let StoppedFocusingTrigger =
        Prefixed_Name(eupont, "StoppedFocusingTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StoppedListeningMusicTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StoppedListeningMusicTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StoppedListeningMusicTrigger">http://elite.polito.it/ontologies/eupont.owl#StoppedListeningMusicTrigger</seealso>
    let StoppedListeningMusicTrigger =
        Prefixed_Name(eupont, "StoppedListeningMusicTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StoppedOvenCookingTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StoppedOvenCookingTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StoppedOvenCookingTrigger">http://elite.polito.it/ontologies/eupont.owl#StoppedOvenCookingTrigger</seealso>
    let StoppedOvenCookingTrigger =
        Prefixed_Name(eupont, "StoppedOvenCookingTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StoppedPhysicalActivityTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StoppedPhysicalActivityTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StoppedPhysicalActivityTrigger">http://elite.polito.it/ontologies/eupont.owl#StoppedPhysicalActivityTrigger</seealso>
    let StoppedPhysicalActivityTrigger =
        Prefixed_Name(eupont, "StoppedPhysicalActivityTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StoppedPlayingTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StoppedPlayingTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StoppedPlayingTrigger">http://elite.polito.it/ontologies/eupont.owl#StoppedPlayingTrigger</seealso>
    let StoppedPlayingTrigger =
        Prefixed_Name(eupont, "StoppedPlayingTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StoppedRelaxingTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StoppedRelaxingTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StoppedRelaxingTrigger">http://elite.polito.it/ontologies/eupont.owl#StoppedRelaxingTrigger</seealso>
    let StoppedRelaxingTrigger =
        Prefixed_Name(eupont, "StoppedRelaxingTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StoppedRunSessionTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StoppedRunSessionTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StoppedRunSessionTrigger">http://elite.polito.it/ontologies/eupont.owl#StoppedRunSessionTrigger</seealso>
    let StoppedRunSessionTrigger =
        Prefixed_Name(eupont, "StoppedRunSessionTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StoppedSleepingTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StoppedSleepingTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StoppedSleepingTrigger">http://elite.polito.it/ontologies/eupont.owl#StoppedSleepingTrigger</seealso>
    let StoppedSleepingTrigger =
        Prefixed_Name(eupont, "StoppedSleepingTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StoppedStudyingSessionTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StoppedStudyingSessionTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StoppedStudyingSessionTrigger">http://elite.polito.it/ontologies/eupont.owl#StoppedStudyingSessionTrigger</seealso>
    let StoppedStudyingSessionTrigger =
        Prefixed_Name(eupont, "StoppedStudyingSessionTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StoppedUsingSmartphoneTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StoppedUsingSmartphoneTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StoppedUsingSmartphoneTrigger">http://elite.polito.it/ontologies/eupont.owl#StoppedUsingSmartphoneTrigger</seealso>
    let StoppedUsingSmartphoneTrigger =
        Prefixed_Name(eupont, "StoppedUsingSmartphoneTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StoppedWalkingSessionTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StoppedWalkingSessionTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StoppedWalkingSessionTrigger">http://elite.polito.it/ontologies/eupont.owl#StoppedWalkingSessionTrigger</seealso>
    let StoppedWalkingSessionTrigger =
        Prefixed_Name(eupont, "StoppedWalkingSessionTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StoppedWashingClothesTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StoppedWashingClothesTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StoppedWashingClothesTrigger">http://elite.polito.it/ontologies/eupont.owl#StoppedWashingClothesTrigger</seealso>
    let StoppedWashingClothesTrigger =
        Prefixed_Name(eupont, "StoppedWashingClothesTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StoppedWashingTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StoppedWashingTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StoppedWashingTrigger">http://elite.polito.it/ontologies/eupont.owl#StoppedWashingTrigger</seealso>
    let StoppedWashingTrigger =
        Prefixed_Name(eupont, "StoppedWashingTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StoppedWatchingTvTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StoppedWatchingTvTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StoppedWatchingTvTrigger">http://elite.polito.it/ontologies/eupont.owl#StoppedWatchingTvTrigger</seealso>
    let StoppedWatchingTvTrigger =
        Prefixed_Name(eupont, "StoppedWatchingTvTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StoragePlatform</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StoragePlatform"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StoragePlatform">http://elite.polito.it/ontologies/eupont.owl#StoragePlatform</seealso>
    let StoragePlatform = Prefixed_Name(eupont, "StoragePlatform") |> PrefixedName
    /// <summary>
    ///   <para>eupont:StoreAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StoreAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StoreAction">http://elite.polito.it/ontologies/eupont.owl#StoreAction</seealso>
    let StoreAction = Prefixed_Name(eupont, "StoreAction") |> PrefixedName
    /// <summary>
    ///   <para>eupont:StoredAppTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StoredAppTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StoredAppTrigger">http://elite.polito.it/ontologies/eupont.owl#StoredAppTrigger</seealso>
    let StoredAppTrigger = Prefixed_Name(eupont, "StoredAppTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StoredBackupTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StoredBackupTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StoredBackupTrigger">http://elite.polito.it/ontologies/eupont.owl#StoredBackupTrigger</seealso>
    let StoredBackupTrigger =
        Prefixed_Name(eupont, "StoredBackupTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StoredContactTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StoredContactTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StoredContactTrigger">http://elite.polito.it/ontologies/eupont.owl#StoredContactTrigger</seealso>
    let StoredContactTrigger =
        Prefixed_Name(eupont, "StoredContactTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StoredFileTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StoredFileTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StoredFileTrigger">http://elite.polito.it/ontologies/eupont.owl#StoredFileTrigger</seealso>
    let StoredFileTrigger = Prefixed_Name(eupont, "StoredFileTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StoredHealthInformationTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StoredHealthInformationTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StoredHealthInformationTrigger">http://elite.polito.it/ontologies/eupont.owl#StoredHealthInformationTrigger</seealso>
    let StoredHealthInformationTrigger =
        Prefixed_Name(eupont, "StoredHealthInformationTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StoredMediaInformationTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StoredMediaInformationTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StoredMediaInformationTrigger">http://elite.polito.it/ontologies/eupont.owl#StoredMediaInformationTrigger</seealso>
    let StoredMediaInformationTrigger =
        Prefixed_Name(eupont, "StoredMediaInformationTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StoredTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StoredTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StoredTrigger">http://elite.polito.it/ontologies/eupont.owl#StoredTrigger</seealso>
    let StoredTrigger = Prefixed_Name(eupont, "StoredTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StoredWebBookmarkTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StoredWebBookmarkTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StoredWebBookmarkTrigger">http://elite.polito.it/ontologies/eupont.owl#StoredWebBookmarkTrigger</seealso>
    let StoredWebBookmarkTrigger =
        Prefixed_Name(eupont, "StoredWebBookmarkTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:StudyingTrackingService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"StudyingTrackingService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#StudyingTrackingService">http://elite.polito.it/ontologies/eupont.owl#StudyingTrackingService</seealso>
    let StudyingTrackingService =
        Prefixed_Name(eupont, "StudyingTrackingService") |> PrefixedName

    /// <summary>
    ///   <para>eupont:TVService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"TVService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#TVService">http://elite.polito.it/ontologies/eupont.owl#TVService</seealso>
    let TVService = Prefixed_Name(eupont, "TVService") |> PrefixedName
    /// <summary>
    ///   <para>eupont:Tablet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Tablet"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#Tablet">http://elite.polito.it/ontologies/eupont.owl#Tablet</seealso>
    let Tablet = Prefixed_Name(eupont, "Tablet") |> PrefixedName
    /// <summary>
    ///   <para>eupont:TagService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"TagService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#TagService">http://elite.polito.it/ontologies/eupont.owl#TagService</seealso>
    let TagService = Prefixed_Name(eupont, "TagService") |> PrefixedName
    /// <summary>
    ///   <para>eupont:TakeAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"TakeAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#TakeAction">http://elite.polito.it/ontologies/eupont.owl#TakeAction</seealso>
    let TakeAction = Prefixed_Name(eupont, "TakeAction") |> PrefixedName
    /// <summary>
    ///   <para>eupont:TakeAudioAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"TakeAudioAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#TakeAudioAction">http://elite.polito.it/ontologies/eupont.owl#TakeAudioAction</seealso>
    let TakeAudioAction = Prefixed_Name(eupont, "TakeAudioAction") |> PrefixedName
    /// <summary>
    ///   <para>eupont:TakePhotoAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"TakePhotoAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#TakePhotoAction">http://elite.polito.it/ontologies/eupont.owl#TakePhotoAction</seealso>
    let TakePhotoAction = Prefixed_Name(eupont, "TakePhotoAction") |> PrefixedName
    /// <summary>
    ///   <para>eupont:TakeVideoAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"TakeVideoAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#TakeVideoAction">http://elite.polito.it/ontologies/eupont.owl#TakeVideoAction</seealso>
    let TakeVideoAction = Prefixed_Name(eupont, "TakeVideoAction") |> PrefixedName
    /// <summary>
    ///   <para>eupont:TakenAudioTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"TakenAudioTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#TakenAudioTrigger">http://elite.polito.it/ontologies/eupont.owl#TakenAudioTrigger</seealso>
    let TakenAudioTrigger = Prefixed_Name(eupont, "TakenAudioTrigger") |> PrefixedName
    /// <summary>
    ///   <para>eupont:TakenImageTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"TakenImageTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#TakenImageTrigger">http://elite.polito.it/ontologies/eupont.owl#TakenImageTrigger</seealso>
    let TakenImageTrigger = Prefixed_Name(eupont, "TakenImageTrigger") |> PrefixedName
    /// <summary>
    ///   <para>eupont:TakenTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"TakenTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#TakenTrigger">http://elite.polito.it/ontologies/eupont.owl#TakenTrigger</seealso>
    let TakenTrigger = Prefixed_Name(eupont, "TakenTrigger") |> PrefixedName
    /// <summary>
    ///   <para>eupont:TakenVideoTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"TakenVideoTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#TakenVideoTrigger">http://elite.polito.it/ontologies/eupont.owl#TakenVideoTrigger</seealso>
    let TakenVideoTrigger = Prefixed_Name(eupont, "TakenVideoTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:TapButtonActivityTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"TapButtonActivityTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#TapButtonActivityTrigger">http://elite.polito.it/ontologies/eupont.owl#TapButtonActivityTrigger</seealso>
    let TapButtonActivityTrigger =
        Prefixed_Name(eupont, "TapButtonActivityTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:TemperatureSetToTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"TemperatureSetToTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#TemperatureSetToTrigger">http://elite.polito.it/ontologies/eupont.owl#TemperatureSetToTrigger</seealso>
    let TemperatureSetToTrigger =
        Prefixed_Name(eupont, "TemperatureSetToTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:TemporalTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"TemporalTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#TemporalTrigger">http://elite.polito.it/ontologies/eupont.owl#TemporalTrigger</seealso>
    let TemporalTrigger = Prefixed_Name(eupont, "TemporalTrigger") |> PrefixedName
    /// <summary>
    ///   <para>eupont:Thermostat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Thermostat"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#Thermostat">http://elite.polito.it/ontologies/eupont.owl#Thermostat</seealso>
    let Thermostat = Prefixed_Name(eupont, "Thermostat") |> PrefixedName
    /// <summary>
    ///   <para>eupont:TimeManagementTool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"TimeManagement"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#TimeManagementTool">http://elite.polito.it/ontologies/eupont.owl#TimeManagementTool</seealso>
    let TimeManagementTool = Prefixed_Name(eupont, "TimeManagementTool") |> PrefixedName
    /// <summary>
    ///   <para>eupont:TimeService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"TimeService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#TimeService">http://elite.polito.it/ontologies/eupont.owl#TimeService</seealso>
    let TimeService = Prefixed_Name(eupont, "TimeService") |> PrefixedName
    /// <summary>
    ///   <para>eupont:TimeTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"TimeTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#TimeTrigger">http://elite.polito.it/ontologies/eupont.owl#TimeTrigger</seealso>
    let TimeTrigger = Prefixed_Name(eupont, "TimeTrigger") |> PrefixedName
    /// <summary>
    ///   <para>eupont:TimerService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"TimerService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#TimerService">http://elite.polito.it/ontologies/eupont.owl#TimerService</seealso>
    let TimerService = Prefixed_Name(eupont, "TimerService") |> PrefixedName
    /// <summary>
    ///   <para>eupont:ToDoTool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ToDo"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#ToDoTool">http://elite.polito.it/ontologies/eupont.owl#ToDoTool</seealso>
    let ToDoTool = Prefixed_Name(eupont, "ToDoTool") |> PrefixedName
    /// <summary>
    ///   <para>eupont:ToggleCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ToggleCommand"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#ToggleCommand">http://elite.polito.it/ontologies/eupont.owl#ToggleCommand</seealso>
    let ToggleCommand = Prefixed_Name(eupont, "ToggleCommand") |> PrefixedName

    /// <summary>
    ///   <para>eupont:ToggleSwitchTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ToggleSwitchTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#ToggleSwitchTrigger">http://elite.polito.it/ontologies/eupont.owl#ToggleSwitchTrigger</seealso>
    let ToggleSwitchTrigger =
        Prefixed_Name(eupont, "ToggleSwitchTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:TrackingService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"TrackingService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#TrackingService">http://elite.polito.it/ontologies/eupont.owl#TrackingService</seealso>
    let TrackingService = Prefixed_Name(eupont, "TrackingService") |> PrefixedName
    /// <summary>
    ///   <para>eupont:Trigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Trigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#Trigger">http://elite.polito.it/ontologies/eupont.owl#Trigger</seealso>
    let Trigger = Prefixed_Name(eupont, "Trigger") |> PrefixedName
    /// <summary>
    ///   <para>eupont:TurnAlarmOffAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"TurnAlarmOffAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#TurnAlarmOffAction">http://elite.polito.it/ontologies/eupont.owl#TurnAlarmOffAction</seealso>
    let TurnAlarmOffAction = Prefixed_Name(eupont, "TurnAlarmOffAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:TurnDeviceOffAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"TurnDeviceOffAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#TurnDeviceOffAction">http://elite.polito.it/ontologies/eupont.owl#TurnDeviceOffAction</seealso>
    let TurnDeviceOffAction =
        Prefixed_Name(eupont, "TurnDeviceOffAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:TurnDeviceOnAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"TurnDeviceOnAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#TurnDeviceOnAction">http://elite.polito.it/ontologies/eupont.owl#TurnDeviceOnAction</seealso>
    let TurnDeviceOnAction = Prefixed_Name(eupont, "TurnDeviceOnAction") |> PrefixedName
    /// <summary>
    ///   <para>eupont:TurnOffCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"TurnOffCommand"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#TurnOffCommand">http://elite.polito.it/ontologies/eupont.owl#TurnOffCommand</seealso>
    let TurnOffCommand = Prefixed_Name(eupont, "TurnOffCommand") |> PrefixedName

    /// <summary>
    ///   <para>eupont:TurnOffNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"TurnOffNotification"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#TurnOffNotification">http://elite.polito.it/ontologies/eupont.owl#TurnOffNotification</seealso>
    let TurnOffNotification =
        Prefixed_Name(eupont, "TurnOffNotification") |> PrefixedName

    /// <summary>
    ///   <para>eupont:TurnOnCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"TurnOnCommand"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#TurnOnCommand">http://elite.polito.it/ontologies/eupont.owl#TurnOnCommand</seealso>
    let TurnOnCommand = Prefixed_Name(eupont, "TurnOnCommand") |> PrefixedName
    /// <summary>
    ///   <para>eupont:TurnOnNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"TurnOnNotification"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#TurnOnNotification">http://elite.polito.it/ontologies/eupont.owl#TurnOnNotification</seealso>
    let TurnOnNotification = Prefixed_Name(eupont, "TurnOnNotification") |> PrefixedName
    /// <summary>
    ///   <para>eupont:Tv</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"TV"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#Tv">http://elite.polito.it/ontologies/eupont.owl#Tv</seealso>
    let Tv = Prefixed_Name(eupont, "Tv") |> PrefixedName

    /// <summary>
    ///   <para>eupont:UnhealthyActivityTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"UnhealthyActivityTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#UnhealthyActivityTrigger">http://elite.polito.it/ontologies/eupont.owl#UnhealthyActivityTrigger</seealso>
    let UnhealthyActivityTrigger =
        Prefixed_Name(eupont, "UnhealthyActivityTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:UnlikeService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"UnlikeService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#UnlikeService">http://elite.polito.it/ontologies/eupont.owl#UnlikeService</seealso>
    let UnlikeService = Prefixed_Name(eupont, "UnlikeService") |> PrefixedName

    /// <summary>
    ///   <para>eupont:UpdatedWallpaperTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"UpdatedWallpaperTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#UpdatedWallpaperTrigger">http://elite.polito.it/ontologies/eupont.owl#UpdatedWallpaperTrigger</seealso>
    let UpdatedWallpaperTrigger =
        Prefixed_Name(eupont, "UpdatedWallpaperTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:UserConnectivityDecreasedTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"UserConnectivityDecreasedTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#UserConnectivityDecreasedTrigger">http://elite.polito.it/ontologies/eupont.owl#UserConnectivityDecreasedTrigger</seealso>
    let UserConnectivityDecreasedTrigger =
        Prefixed_Name(eupont, "UserConnectivityDecreasedTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:UserConnectivityIncreasedTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"UserConnectivityIncreasedTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#UserConnectivityIncreasedTrigger">http://elite.polito.it/ontologies/eupont.owl#UserConnectivityIncreasedTrigger</seealso>
    let UserConnectivityIncreasedTrigger =
        Prefixed_Name(eupont, "UserConnectivityIncreasedTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:UserDevice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"UserDevice"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#UserDevice">http://elite.polito.it/ontologies/eupont.owl#UserDevice</seealso>
    let UserDevice = Prefixed_Name(eupont, "UserDevice") |> PrefixedName
    /// <summary>
    ///   <para>eupont:VacuumService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"VacuumService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#VacuumService">http://elite.polito.it/ontologies/eupont.owl#VacuumService</seealso>
    let VacuumService = Prefixed_Name(eupont, "VacuumService") |> PrefixedName

    /// <summary>
    ///   <para>eupont:VehicleTrackingService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"VehicleTrackingService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#VehicleTrackingService">http://elite.polito.it/ontologies/eupont.owl#VehicleTrackingService</seealso>
    let VehicleTrackingService =
        Prefixed_Name(eupont, "VehicleTrackingService") |> PrefixedName

    /// <summary>
    ///   <para>eupont:Ventilator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Ventilator"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#Ventilator">http://elite.polito.it/ontologies/eupont.owl#Ventilator</seealso>
    let Ventilator = Prefixed_Name(eupont, "Ventilator") |> PrefixedName
    /// <summary>
    ///   <para>eupont:VideoPlatform</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"VideoPlatform"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#VideoPlatform">http://elite.polito.it/ontologies/eupont.owl#VideoPlatform</seealso>
    let VideoPlatform = Prefixed_Name(eupont, "VideoPlatform") |> PrefixedName

    /// <summary>
    ///   <para>eupont:VideoRecordingService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"VideoRecordingService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#VideoRecordingService">http://elite.polito.it/ontologies/eupont.owl#VideoRecordingService</seealso>
    let VideoRecordingService =
        Prefixed_Name(eupont, "VideoRecordingService") |> PrefixedName

    /// <summary>
    ///   <para>eupont:VideoService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"VideoService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#VideoService">http://elite.polito.it/ontologies/eupont.owl#VideoService</seealso>
    let VideoService = Prefixed_Name(eupont, "VideoService") |> PrefixedName
    /// <summary>
    ///   <para>eupont:VirtualObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"VirtualObject"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#VirtualObject">http://elite.polito.it/ontologies/eupont.owl#VirtualObject</seealso>
    let VirtualObject = Prefixed_Name(eupont, "VirtualObject") |> PrefixedName
    /// <summary>
    ///   <para>eupont:VoiceAssistant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"VoiceAssistant"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#VoiceAssistant">http://elite.polito.it/ontologies/eupont.owl#VoiceAssistant</seealso>
    let VoiceAssistant = Prefixed_Name(eupont, "VoiceAssistant") |> PrefixedName

    /// <summary>
    ///   <para>eupont:VolumeDecreasedTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"VolumeDecreasedTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#VolumeDecreasedTrigger">http://elite.polito.it/ontologies/eupont.owl#VolumeDecreasedTrigger</seealso>
    let VolumeDecreasedTrigger =
        Prefixed_Name(eupont, "VolumeDecreasedTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:VolumeIncreasedTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"VolumeIncreasedTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#VolumeIncreasedTrigger">http://elite.polito.it/ontologies/eupont.owl#VolumeIncreasedTrigger</seealso>
    let VolumeIncreasedTrigger =
        Prefixed_Name(eupont, "VolumeIncreasedTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:VolumeService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"VolumeService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#VolumeService">http://elite.polito.it/ontologies/eupont.owl#VolumeService</seealso>
    let VolumeService = Prefixed_Name(eupont, "VolumeService") |> PrefixedName

    /// <summary>
    ///   <para>eupont:WalkTrackingService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"WalkTrackingService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#WalkTrackingService">http://elite.polito.it/ontologies/eupont.owl#WalkTrackingService</seealso>
    let WalkTrackingService =
        Prefixed_Name(eupont, "WalkTrackingService") |> PrefixedName

    /// <summary>
    ///   <para>eupont:WashingMachine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"WashingMachine"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#WashingMachine">http://elite.polito.it/ontologies/eupont.owl#WashingMachine</seealso>
    let WashingMachine = Prefixed_Name(eupont, "WashingMachine") |> PrefixedName
    /// <summary>
    ///   <para>eupont:WashingService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"WashingService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#WashingService">http://elite.polito.it/ontologies/eupont.owl#WashingService</seealso>
    let WashingService = Prefixed_Name(eupont, "WashingService") |> PrefixedName

    /// <summary>
    ///   <para>eupont:WaterTemperatureSystemDisabledTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"WaterTemperatureSystemDisabledTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#WaterTemperatureSystemDisabledTrigger">http://elite.polito.it/ontologies/eupont.owl#WaterTemperatureSystemDisabledTrigger</seealso>
    let WaterTemperatureSystemDisabledTrigger =
        Prefixed_Name(eupont, "WaterTemperatureSystemDisabledTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:WaterTemperatureSystemEnabledTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"WaterTemperatureSystemEnabledTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#WaterTemperatureSystemEnabledTrigger">http://elite.polito.it/ontologies/eupont.owl#WaterTemperatureSystemEnabledTrigger</seealso>
    let WaterTemperatureSystemEnabledTrigger =
        Prefixed_Name(eupont, "WaterTemperatureSystemEnabledTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:WateringService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"WateringService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#WateringService">http://elite.polito.it/ontologies/eupont.owl#WateringService</seealso>
    let WateringService = Prefixed_Name(eupont, "WateringService") |> PrefixedName

    /// <summary>
    ///   <para>eupont:WateringSystemDisabledTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"WateringSystemDisabledTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#WateringSystemDisabledTrigger">http://elite.polito.it/ontologies/eupont.owl#WateringSystemDisabledTrigger</seealso>
    let WateringSystemDisabledTrigger =
        Prefixed_Name(eupont, "WateringSystemDisabledTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:WateringSystemEnabledTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"WateringSystemEnabledTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#WateringSystemEnabledTrigger">http://elite.polito.it/ontologies/eupont.owl#WateringSystemEnabledTrigger</seealso>
    let WateringSystemEnabledTrigger =
        Prefixed_Name(eupont, "WateringSystemEnabledTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:WeatherService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"WeatherService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#WeatherService">http://elite.polito.it/ontologies/eupont.owl#WeatherService</seealso>
    let WeatherService = Prefixed_Name(eupont, "WeatherService") |> PrefixedName
    /// <summary>
    ///   <para>eupont:WeatherStation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"WeatherStation"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#WeatherStation">http://elite.polito.it/ontologies/eupont.owl#WeatherStation</seealso>
    let WeatherStation = Prefixed_Name(eupont, "WeatherStation") |> PrefixedName
    /// <summary>
    ///   <para>eupont:WeatherWebSite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"WeatherWebsite"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#WeatherWebSite">http://elite.polito.it/ontologies/eupont.owl#WeatherWebSite</seealso>
    let WeatherWebSite = Prefixed_Name(eupont, "WeatherWebSite") |> PrefixedName
    /// <summary>
    ///   <para>eupont:WebBookmarkService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"WebBookmarkService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#WebBookmarkService">http://elite.polito.it/ontologies/eupont.owl#WebBookmarkService</seealso>
    let WebBookmarkService = Prefixed_Name(eupont, "WebBookmarkService") |> PrefixedName
    /// <summary>
    ///   <para>eupont:WebBookmarkTool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"WebBookmarkTool"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#WebBookmarkTool">http://elite.polito.it/ontologies/eupont.owl#WebBookmarkTool</seealso>
    let WebBookmarkTool = Prefixed_Name(eupont, "WebBookmarkTool") |> PrefixedName
    /// <summary>
    ///   <para>eupont:WebRequestService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"WebRequestService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#WebRequestService">http://elite.polito.it/ontologies/eupont.owl#WebRequestService</seealso>
    let WebRequestService = Prefixed_Name(eupont, "WebRequestService") |> PrefixedName
    /// <summary>
    ///   <para>eupont:WifiService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"WifiService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#WifiService">http://elite.polito.it/ontologies/eupont.owl#WifiService</seealso>
    let WifiService = Prefixed_Name(eupont, "WifiService") |> PrefixedName

    /// <summary>
    ///   <para>eupont:WindowFrameClosedTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"WindowFrameClosedTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#WindowFrameClosedTrigger">http://elite.polito.it/ontologies/eupont.owl#WindowFrameClosedTrigger</seealso>
    let WindowFrameClosedTrigger =
        Prefixed_Name(eupont, "WindowFrameClosedTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:WindowFrameOpenedTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"WindowFrameOpenedTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#WindowFrameOpenedTrigger">http://elite.polito.it/ontologies/eupont.owl#WindowFrameOpenedTrigger</seealso>
    let WindowFrameOpenedTrigger =
        Prefixed_Name(eupont, "WindowFrameOpenedTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:WorseConsumptionConditionAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"WorseConsumptionConditionAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#WorseConsumptionConditionAction">http://elite.polito.it/ontologies/eupont.owl#WorseConsumptionConditionAction</seealso>
    let WorseConsumptionConditionAction =
        Prefixed_Name(eupont, "WorseConsumptionConditionAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:WorseConsumptionConditionTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"WorseConsumptionConditionTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#WorseConsumptionConditionTrigger">http://elite.polito.it/ontologies/eupont.owl#WorseConsumptionConditionTrigger</seealso>
    let WorseConsumptionConditionTrigger =
        Prefixed_Name(eupont, "WorseConsumptionConditionTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:WorseDeviceConditionAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"WorseDeviceConditionAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#WorseDeviceConditionAction">http://elite.polito.it/ontologies/eupont.owl#WorseDeviceConditionAction</seealso>
    let WorseDeviceConditionAction =
        Prefixed_Name(eupont, "WorseDeviceConditionAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:WorseDeviceConditionTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"WorseDeviceConditionTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#WorseDeviceConditionTrigger">http://elite.polito.it/ontologies/eupont.owl#WorseDeviceConditionTrigger</seealso>
    let WorseDeviceConditionTrigger =
        Prefixed_Name(eupont, "WorseDeviceConditionTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:WorseFunctionalityTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"WorseFunctionalityTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#WorseFunctionalityTrigger">http://elite.polito.it/ontologies/eupont.owl#WorseFunctionalityTrigger</seealso>
    let WorseFunctionalityTrigger =
        Prefixed_Name(eupont, "WorseFunctionalityTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:WorseUsabilityConditionAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"WorseUsabilityConditionAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#WorseUsabilityConditionAction">http://elite.polito.it/ontologies/eupont.owl#WorseUsabilityConditionAction</seealso>
    let WorseUsabilityConditionAction =
        Prefixed_Name(eupont, "WorseUsabilityConditionAction") |> PrefixedName

    /// <summary>
    ///   <para>eupont:WorseUsabilityConditionTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"WorseUsabilityConditionTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#WorseUsabilityConditionTrigger">http://elite.polito.it/ontologies/eupont.owl#WorseUsabilityConditionTrigger</seealso>
    let WorseUsabilityConditionTrigger =
        Prefixed_Name(eupont, "WorseUsabilityConditionTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:WorsenedHealthyParameterTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"WorsenedHealthyParameterTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#WorsenedHealthyParameterTrigger">http://elite.polito.it/ontologies/eupont.owl#WorsenedHealthyParameterTrigger</seealso>
    let WorsenedHealthyParameterTrigger =
        Prefixed_Name(eupont, "WorsenedHealthyParameterTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:allowTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"allowTo"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#allowTo">http://elite.polito.it/ontologies/eupont.owl#allowTo</seealso>
    let allowTo = Prefixed_Name(eupont, "allowTo") |> PrefixedName
    /// <summary>
    ///   <para>eupont:canControl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"canControl"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#canControl">http://elite.polito.it/ontologies/eupont.owl#canControl</seealso>
    let canControl = Prefixed_Name(eupont, "canControl") |> PrefixedName
    /// <summary>
    ///   <para>eupont:channelOffer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"channelOffer"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#channelOffer">http://elite.polito.it/ontologies/eupont.owl#channelOffer</seealso>
    let channelOffer = Prefixed_Name(eupont, "channelOffer") |> PrefixedName
    /// <summary>
    ///   <para>eupont:commandAllowTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"commandAllowTo"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#commandAllowTo">http://elite.polito.it/ontologies/eupont.owl#commandAllowTo</seealso>
    let commandAllowTo = Prefixed_Name(eupont, "commandAllowTo") |> PrefixedName
    /// <summary>
    ///   <para>eupont:description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"description"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#description">http://elite.polito.it/ontologies/eupont.owl#description</seealso>
    let description = Prefixed_Name(eupont, "description") |> PrefixedName
    /// <summary>
    ///   <para>eupont:detail</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"detail"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#detail">http://elite.polito.it/ontologies/eupont.owl#detail</seealso>
    let detail = Prefixed_Name(eupont, "detail") |> PrefixedName
    /// <summary>
    ///   <para>eupont:hasAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#hasAction">http://elite.polito.it/ontologies/eupont.owl#hasAction</seealso>
    let hasAction = Prefixed_Name(eupont, "hasAction") |> PrefixedName
    /// <summary>
    ///   <para>eupont:hasCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasCategory"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#hasCategory">http://elite.polito.it/ontologies/eupont.owl#hasCategory</seealso>
    let hasCategory = Prefixed_Name(eupont, "hasCategory") |> PrefixedName
    /// <summary>
    ///   <para>eupont:hasCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasCommand"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#hasCommand">http://elite.polito.it/ontologies/eupont.owl#hasCommand</seealso>
    let hasCommand = Prefixed_Name(eupont, "hasCommand") |> PrefixedName
    /// <summary>
    ///   <para>eupont:hasDetail</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasDetail"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#hasDetail">http://elite.polito.it/ontologies/eupont.owl#hasDetail</seealso>
    let hasDetail = Prefixed_Name(eupont, "hasDetail") |> PrefixedName
    /// <summary>
    ///   <para>eupont:hasNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasNotification"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#hasNotification">http://elite.polito.it/ontologies/eupont.owl#hasNotification</seealso>
    let hasNotification = Prefixed_Name(eupont, "hasNotification") |> PrefixedName

    /// <summary>
    ///   <para>eupont:hasRegisteredEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasRegisteredEntity"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#hasRegisteredEntity">http://elite.polito.it/ontologies/eupont.owl#hasRegisteredEntity</seealso>
    let hasRegisteredEntity =
        Prefixed_Name(eupont, "hasRegisteredEntity") |> PrefixedName

    /// <summary>
    ///   <para>eupont:hasService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasService"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#hasService">http://elite.polito.it/ontologies/eupont.owl#hasService</seealso>
    let hasService = Prefixed_Name(eupont, "hasService") |> PrefixedName
    /// <summary>
    ///   <para>eupont:hasTechnology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasTechnology"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#hasTechnology">http://elite.polito.it/ontologies/eupont.owl#hasTechnology</seealso>
    let hasTechnology = Prefixed_Name(eupont, "hasTechnology") |> PrefixedName
    /// <summary>
    ///   <para>eupont:hasTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#hasTrigger">http://elite.polito.it/ontologies/eupont.owl#hasTrigger</seealso>
    let hasTrigger = Prefixed_Name(eupont, "hasTrigger") |> PrefixedName
    /// <summary>
    ///   <para>eupont:isOfChannel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isOfChannel"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#isOfChannel">http://elite.polito.it/ontologies/eupont.owl#isOfChannel</seealso>
    let isOfChannel = Prefixed_Name(eupont, "isOfChannel") |> PrefixedName
    /// <summary>
    ///   <para>eupont:location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"location"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#location">http://elite.polito.it/ontologies/eupont.owl#location</seealso>
    let location = Prefixed_Name(eupont, "location") |> PrefixedName
    /// <summary>
    ///   <para>eupont:nominal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"nominal"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#nominal">http://elite.polito.it/ontologies/eupont.owl#nominal</seealso>
    let nominal = Prefixed_Name(eupont, "nominal") |> PrefixedName
    /// <summary>
    ///   <para>eupont:nominalAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"nominalAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#nominalAction">http://elite.polito.it/ontologies/eupont.owl#nominalAction</seealso>
    let nominalAction = Prefixed_Name(eupont, "nominalAction") |> PrefixedName
    /// <summary>
    ///   <para>eupont:nominalDetail</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"nominalDetail"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#nominalDetail">http://elite.polito.it/ontologies/eupont.owl#nominalDetail</seealso>
    let nominalDetail = Prefixed_Name(eupont, "nominalDetail") |> PrefixedName
    /// <summary>
    ///   <para>eupont:nominalTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"nominalTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#nominalTrigger">http://elite.polito.it/ontologies/eupont.owl#nominalTrigger</seealso>
    let nominalTrigger = Prefixed_Name(eupont, "nominalTrigger") |> PrefixedName

    /// <summary>
    ///   <para>eupont:notificationAllowTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"notificationAllowTo"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#notificationAllowTo">http://elite.polito.it/ontologies/eupont.owl#notificationAllowTo</seealso>
    let notificationAllowTo =
        Prefixed_Name(eupont, "notificationAllowTo") |> PrefixedName

    /// <summary>
    ///   <para>eupont:offerAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"offerAction"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#offerAction">http://elite.polito.it/ontologies/eupont.owl#offerAction</seealso>
    let offerAction = Prefixed_Name(eupont, "offerAction") |> PrefixedName
    /// <summary>
    ///   <para>eupont:offerDetail</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"offerDetail"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#offerDetail">http://elite.polito.it/ontologies/eupont.owl#offerDetail</seealso>
    let offerDetail = Prefixed_Name(eupont, "offerDetail") |> PrefixedName
    /// <summary>
    ///   <para>eupont:offerTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"offerTrigger"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#offerTrigger">http://elite.polito.it/ontologies/eupont.owl#offerTrigger</seealso>
    let offerTrigger = Prefixed_Name(eupont, "offerTrigger") |> PrefixedName
    /// <summary>
    ///   <para>eupont:triggers</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"triggers"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#triggers">http://elite.polito.it/ontologies/eupont.owl#triggers</seealso>
    let triggers = Prefixed_Name(eupont, "triggers") |> PrefixedName
    /// <summary>
    ///   <para>eupont:type</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#type">http://elite.polito.it/ontologies/eupont.owl#type</seealso>
    let type_ = Prefixed_Name(eupont, "type") |> PrefixedName
    /// <summary>
    ///   <para>eupont:value</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#value">http://elite.polito.it/ontologies/eupont.owl#value</seealso>
    let value = Prefixed_Name(eupont, "value") |> PrefixedName
    /// <summary>
    ///   <para>eupont:where</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"where"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#where">http://elite.polito.it/ontologies/eupont.owl#where</seealso>
    let where = Prefixed_Name(eupont, "where") |> PrefixedName
    /// <summary>
    ///   <para>eupont:which</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"which"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#which">http://elite.polito.it/ontologies/eupont.owl#which</seealso>
    let which = Prefixed_Name(eupont, "which") |> PrefixedName
    /// <summary>
    ///   <para>eupont:who</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"who"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/eupont.owl#who">http://elite.polito.it/ontologies/eupont.owl#who</seealso>
    let who = Prefixed_Name(eupont, "who") |> PrefixedName
