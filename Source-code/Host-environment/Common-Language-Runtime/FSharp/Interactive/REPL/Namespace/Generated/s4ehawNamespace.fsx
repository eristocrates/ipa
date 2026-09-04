#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module s4ehaw =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://saref.etsi.org/saref4ehaw/" "s4ehaw"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Activity</para>
    ///   <para>rdfs:comment : The activity of a patient/user, i.e. daily and nocturnal activities.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/Activity">s4ehaw:Activity</a>
    /// </summary>
    let Activity = _prefixId.prefix "Activity"
    /// <summary>
    ///   <para>rdfs:label : Age category</para>
    ///   <para>rdfs:comment : The age group of a health actor, e.g. old or young.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/AgeCategory">s4ehaw:AgeCategory</a>
    /// </summary>
    let AgeCategory = _prefixId.prefix "AgeCategory"
    /// <summary>
    ///   <para>rdfs:label : Alarm command</para>
    ///   <para>rdfs:comment : A command corresponding to alarm sending.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/AlarmCommand">s4ehaw:AlarmCommand</a>
    /// </summary>
    let AlarmCommand = _prefixId.prefix "AlarmCommand"
    let AlcoholDrinking = _prefixId.prefix "AlcoholDrinking"
    let ArmpitLocation = _prefixId.prefix "ArmpitLocation"
    let AssistedLiving = _prefixId.prefix "AssistedLiving"
    let Asthma = _prefixId.prefix "Asthma"
    let AuralImpairment = _prefixId.prefix "AuralImpairment"
    /// <summary>
    ///   <para>rdfs:label : BAN</para>
    ///   <para>rdfs:comment : Body Area Network.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/Ban">s4ehaw:Ban</a>
    /// </summary>
    let Ban = _prefixId.prefix "Ban"
    /// <summary>
    ///   <para>rdfs:label : BAN application domain</para>
    ///   <para>rdfs:comment : The BAN application domain, e.g. healthcare, telemedicine, assisted living, sport training, safety and emergency...</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/BanApplicationDomain">s4ehaw:BanApplicationDomain</a>
    /// </summary>
    let BanApplicationDomain = _prefixId.prefix "BanApplicationDomain"
    /// <summary>
    ///   <para>rdfs:label : BAN Communication type</para>
    ///   <para>rdfs:comment : The BAN communication function type, i.e. periodic, event driven or on request.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/BanCommunicationType">s4ehaw:BanCommunicationType</a>
    /// </summary>
    let BanCommunicationType = _prefixId.prefix "BanCommunicationType"
    /// <summary>
    ///   <para>rdfs:label : BAN hub</para>
    ///   <para>rdfs:comment : Hub of the BAN, mainly playing the role of both a data concentrator and a network gateway.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/BanHub">s4ehaw:BanHub</a>
    /// </summary>
    let BanHub = _prefixId.prefix "BanHub"
    /// <summary>
    ///   <para>rdfs:label : Body surface location</para>
    ///   <para>rdfs:comment : Defines a health device location in terms of a body surface position (i.e. on body health device).</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/BodySurfaceLocation">s4ehaw:BodySurfaceLocation</a>
    /// </summary>
    let BodySurfaceLocation = _prefixId.prefix "BodySurfaceLocation"
    /// <summary>
    ///   <para>rdfs:label : Caregiver</para>
    ///   <para>rdfs:comment : For caregivers modelling.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/Caregiver">s4ehaw:Caregiver</a>
    /// </summary>
    let Caregiver = _prefixId.prefix "Caregiver"
    /// <summary>
    ///   <para>rdfs:label : Chronic disease</para>
    ///   <para>rdfs:comment : For chronic disease modelling, e.g. diabetes, asthma...</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/ChronicDisease">s4ehaw:ChronicDisease</a>
    /// </summary>
    let ChronicDisease = _prefixId.prefix "ChronicDisease"
    /// <summary>
    ///   <para>rdfs:label : Communication protocol</para>
    ///   <para>rdfs:comment : The communication protocol, e.g. BLE, serial, Ethernet...</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/CommunicationProtocol">s4ehaw:CommunicationProtocol</a>
    /// </summary>
    let CommunicationProtocol = _prefixId.prefix "CommunicationProtocol"
    /// <summary>
    ///   <para>rdfs:label : Computing power</para>
    ///   <para>rdfs:comment : The computing power capabilities of a Health device.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/ComputingPower">s4ehaw:ComputingPower</a>
    /// </summary>
    let ComputingPower = _prefixId.prefix "ComputingPower"
    /// <summary>
    ///   <para>rdfs:label : Contact</para>
    ///   <para>rdfs:comment : A BAN has one or multiple contacts, i.e. some health actors, e.g. the patient or user that is monitored through this BAN, the caregiver that is using this BAN for monitoring purposes...</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/Contact">s4ehaw:Contact</a>
    /// </summary>
    let Contact = _prefixId.prefix "Contact"
    /// <summary>
    ///   <para>rdfs:label : Daily activity</para>
    ///   <para>rdfs:comment : The patient/user activities that occur during daytime.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/DailyActivity">s4ehaw:DailyActivity</a>
    /// </summary>
    let DailyActivity = _prefixId.prefix "DailyActivity"
    /// <summary>
    ///   <para>rdfs:label : Data</para>
    ///   <para>rdfs:comment : A function has one or many data, for example a tracking function shall include latitude, longitude and speed data.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/Data">s4ehaw:Data</a>
    /// </summary>
    let Data = _prefixId.prefix "Data"
    /// <summary>
    ///   <para>rdfs:label : Data constraint</para>
    ///   <para>rdfs:comment : The Data constraints, e.g. validity, legal...</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/DataConstraint">s4ehaw:DataConstraint</a>
    /// </summary>
    let DataConstraint = _prefixId.prefix "DataConstraint"
    /// <summary>
    ///   <para>rdfs:label : Device characteristic</para>
    ///   <para>rdfs:comment : A health device has device characteristic describing the physical characteristics of the health device.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/DeviceCharacteristic">s4ehaw:DeviceCharacteristic</a>
    /// </summary>
    let DeviceCharacteristic = _prefixId.prefix "DeviceCharacteristic"
    let Diabetes = _prefixId.prefix "Diabetes"
    let Emergency = _prefixId.prefix "Emergency"

    /// <summary>
    ///   <para>rdfs:label : Event driven BAN communication type</para>
    ///   <para>rdfs:comment : BAN communication function way of working of the type event driven.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/EventDrivenBanCommunicationType">s4ehaw:EventDrivenBanCommunicationType</a>
    /// </summary>
    let EventDrivenBanCommunicationType =
        _prefixId.prefix "EventDrivenBanCommunicationType"

    let Exercising = _prefixId.prefix "Exercising"
    /// <summary>
    ///   <para>rdfs:label : Functional device</para>
    ///   <para>rdfs:comment : Functional Devices are non-purely eHealth/ageing-well devices that can be used for modelling/detecting activities or behaviours of patients/users, like for example beacons that can detect indoor positioning of a patient in a house.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/FunctionalDevice">s4ehaw:FunctionalDevice</a>
    /// </summary>
    let FunctionalDevice = _prefixId.prefix "FunctionalDevice"
    /// <summary>
    ///   <para>rdfs:label : Habit</para>
    ///   <para>rdfs:comment : Defined for users (that can in particular be patients) habits modelling, e.g. smoking, alcohol drinking, overeating, undereating...</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/Habit">s4ehaw:Habit</a>
    /// </summary>
    let Habit = _prefixId.prefix "Habit"
    /// <summary>
    ///   <para>rdfs:label : Health actor</para>
    ///   <para>rdfs:comment : The eHealth actors like e.g. caregivers, patients, users, helpers...</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/HealthActor">s4ehaw:HealthActor</a>
    /// </summary>
    let HealthActor = _prefixId.prefix "HealthActor"
    /// <summary>
    ///   <para>rdfs:label : Health actuator</para>
    ///   <para>rdfs:comment : Health-related Actuator, equivalent to SAREF Actuator.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/HealthActuator">s4ehaw:HealthActuator</a>
    /// </summary>
    let HealthActuator = _prefixId.prefix "HealthActuator"
    /// <summary>
    ///   <para>rdfs:label : Health Device</para>
    ///   <para>rdfs:comment : Health devices, e.g. BAN hub, health sensor/actuator/Wereable.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/HealthDevice">s4ehaw:HealthDevice</a>
    /// </summary>
    let HealthDevice = _prefixId.prefix "HealthDevice"
    /// <summary>
    ///   <para>rdfs:label : Health sensor</para>
    ///   <para>rdfs:comment : Health-related Sensor, equivalent to SAREF Sensor.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/HealthSensor">s4ehaw:HealthSensor</a>
    /// </summary>
    let HealthSensor = _prefixId.prefix "HealthSensor"
    /// <summary>
    ///   <para>rdfs:label : Health wereable</para>
    ///   <para>rdfs:comment : Health-related Wearable, equivalent to SAREF4WEAR Wearable.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/HealthWearable">s4ehaw:HealthWearable</a>
    /// </summary>
    let HealthWearable = _prefixId.prefix "HealthWearable"
    let Healthcare = _prefixId.prefix "Healthcare"
    /// <summary>
    ///   <para>rdfs:label : Helper</para>
    ///   <para>rdfs:comment : Helper of patients/users, e.g. a patient's relative.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/Helper">s4ehaw:Helper</a>
    /// </summary>
    let Helper = _prefixId.prefix "Helper"
    /// <summary>
    ///   <para>rdfs:label : Impairment</para>
    ///   <para>rdfs:comment : Defined for users (that can in particular be patients) impairments modelling, e.g. aural impairment, skeletal impairment, ocular impairment, mobility impairment, intellectual impairment. Those non exhaustive impairments are compatible with the World Health Organization classification.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/Impairment">s4ehaw:Impairment</a>
    /// </summary>
    let Impairment = _prefixId.prefix "Impairment"
    /// <summary>
    ///   <para>rdfs:label : Implant location</para>
    ///   <para>rdfs:comment : Implant Device (i.e. in body health device) position.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/ImplantLocation">s4ehaw:ImplantLocation</a>
    /// </summary>
    let ImplantLocation = _prefixId.prefix "ImplantLocation"
    let IntellectualImpairment = _prefixId.prefix "IntellectualImpairment"
    /// <summary>
    ///   <para>rdfs:label : Interface</para>
    ///   <para>rdfs:comment : Used for modelling the interfaces of a health device (e.g. Bluetooth, UWB, IEEE 802.15.6, serial interface...).</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/Interface">s4ehaw:Interface</a>
    /// </summary>
    let Interface = _prefixId.prefix "Interface"
    /// <summary>
    ///   <para>rdfs:label : Legal constraint</para>
    ///   <para>rdfs:comment : An empty container for describing the legal constraints a data can be submitted to, like e.g. anonymization.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/LegalConstraint">s4ehaw:LegalConstraint</a>
    /// </summary>
    let LegalConstraint = _prefixId.prefix "LegalConstraint"
    /// <summary>
    ///   <para>rdfs:label : Location</para>
    ///   <para>rdfs:comment : The location, i.e. a position against the body (on - body surface – or in the body – implant –) and a physical location (i.e. a postal address and/or a current geolocation when available).</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/Location">s4ehaw:Location</a>
    /// </summary>
    let Location = _prefixId.prefix "Location"
    let Lying = _prefixId.prefix "Lying"
    /// <summary>
    ///   <para>rdfs:label : Measurement collection session</para>
    ///   <para>rdfs:comment : Task in which a health actor (mainly a patient or a user) is subject of measurement collection (recording) by both some measurement-related health Device (e.g. Sensor, Wearable, ECG Device...) and a health actor (mainly a caregiver).</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/MeasurementCollectionSession">s4ehaw:MeasurementCollectionSession</a>
    /// </summary>
    let MeasurementCollectionSession = _prefixId.prefix "MeasurementCollectionSession"
    /// <summary>
    ///   <para>rdfs:label : Measurement function</para>
    ///   <para>rdfs:comment : The functionality necessary to accomplish the measurement task for which a measurement-related health Device (e.g. Sensor, Wearable, ECG Device...) is designed for, e.g. a heart rate measurement function.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/MeasurementFunction">s4ehaw:MeasurementFunction</a>
    /// </summary>
    let MeasurementFunction = _prefixId.prefix "MeasurementFunction"
    let MobilityImpairment = _prefixId.prefix "MobilityImpairment"
    /// <summary>
    ///   <para>rdfs:label : Mode</para>
    ///   <para>rdfs:comment : The dynamic characteristics of a eHealth Device that vary during its lifetime or its BAN lifetime.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/Mode">s4ehaw:Mode</a>
    /// </summary>
    let Mode = _prefixId.prefix "Mode"
    /// <summary>
    ///   <para>rdfs:label : Nocturnal activity</para>
    ///   <para>rdfs:comment : The patient/user activities that occur during the night.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/NocturnalActivity">s4ehaw:NocturnalActivity</a>
    /// </summary>
    let NocturnalActivity = _prefixId.prefix "NocturnalActivity"
    let OcularImpairment = _prefixId.prefix "OcularImpairment"
    let Old = _prefixId.prefix "Old"
    /// <summary>
    ///   <para>rdfs:label : On request BAN communication type</para>
    ///   <para>rdfs:comment : BAN communication function way of working of the type on request.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/OnRequestBanCommunicationType">s4ehaw:OnRequestBanCommunicationType</a>
    /// </summary>
    let OnRequestBanCommunicationType = _prefixId.prefix "OnRequestBanCommunicationType"
    /// <summary>
    ///   <para>rdfs:label : Operating constraint</para>
    ///   <para>rdfs:comment : An empty container for describing the operating constraints of a device, e.g. recommended humidity and temperature range...</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/OperatingConstraint">s4ehaw:OperatingConstraint</a>
    /// </summary>
    let OperatingConstraint = _prefixId.prefix "OperatingConstraint"
    let Overeating = _prefixId.prefix "Overeating"
    /// <summary>
    ///   <para>rdfs:label : Patient</para>
    ///   <para>rdfs:comment : A user of the type patient, i.e. a cared-for person by one or multiple caregivers.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/Patient">s4ehaw:Patient</a>
    /// </summary>
    let Patient = _prefixId.prefix "Patient"
    /// <summary>
    ///   <para>rdfs:label : Periodic BAN communication type</para>
    ///   <para>rdfs:comment : BAN communication function way of working of the type periodic.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/PeriodicBanCommunicationType">s4ehaw:PeriodicBanCommunicationType</a>
    /// </summary>
    let PeriodicBanCommunicationType = _prefixId.prefix "PeriodicBanCommunicationType"
    let PervasiveComputing = _prefixId.prefix "PervasiveComputing"
    /// <summary>
    ///   <para>rdfs:label : Physical location</para>
    ///   <para>rdfs:comment : The physical location, i.e. a postal address and a geolocation when available.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/PhysicalLocation">s4ehaw:PhysicalLocation</a>
    /// </summary>
    let PhysicalLocation = _prefixId.prefix "PhysicalLocation"
    /// <summary>
    ///   <para>rdfs:label : Posture</para>
    ///   <para>rdfs:comment : The posture of a health actor (mainly a patient or a user), e.g. exercising, lying, running, sitting, walking...</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/Posture">s4ehaw:Posture</a>
    /// </summary>
    let Posture = _prefixId.prefix "Posture"
    /// <summary>
    ///   <para>rdfs:label : Power source</para>
    ///   <para>rdfs:comment : The power sources of a health device, mainly describing energy source and battery related capabilities of the health device (number of power source, source type, rechargeable or not...).</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/PowerSource">s4ehaw:PowerSource</a>
    /// </summary>
    let PowerSource = _prefixId.prefix "PowerSource"
    let Prevention = _prefixId.prefix "Prevention"
    /// <summary>
    ///   <para>rdfs:label : Reminder command</para>
    ///   <para>rdfs:comment : Command used for sending reminder notifications to health actors, e.g. patients, users or Caregivers.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/ReminderCommand">s4ehaw:ReminderCommand</a>
    /// </summary>
    let ReminderCommand = _prefixId.prefix "ReminderCommand"
    /// <summary>
    ///   <para>rdfs:label : Responsible party</para>
    ///   <para>rdfs:comment : The legal entity responsible for a BAN, i.e. to contact in case of problem.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/ResponsibleParty">s4ehaw:ResponsibleParty</a>
    /// </summary>
    let ResponsibleParty = _prefixId.prefix "ResponsibleParty"
    let Running = _prefixId.prefix "Running"
    let Safety = _prefixId.prefix "Safety"
    /// <summary>
    ///   <para>rdfs:label : Service grounding</para>
    ///   <para>rdfs:comment : How to access the service.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/ServiceGrounding">s4ehaw:ServiceGrounding</a>
    /// </summary>
    let ServiceGrounding = _prefixId.prefix "ServiceGrounding"
    /// <summary>
    ///   <para>rdfs:label : Service process</para>
    ///   <para>rdfs:comment : How the service works.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/ServiceProcess">s4ehaw:ServiceProcess</a>
    /// </summary>
    let ServiceProcess = _prefixId.prefix "ServiceProcess"
    /// <summary>
    ///   <para>rdfs:label : Service profile</para>
    ///   <para>rdfs:comment : What the service does.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/ServiceProfile">s4ehaw:ServiceProfile</a>
    /// </summary>
    let ServiceProfile = _prefixId.prefix "ServiceProfile"
    let Sitting = _prefixId.prefix "Sitting"
    let SkeletalImpairment = _prefixId.prefix "SkeletalImpairment"
    let Smoking = _prefixId.prefix "Smoking"
    let SportTraining = _prefixId.prefix "SportTraining"
    let Telemedicine = _prefixId.prefix "Telemedicine"
    /// <summary>
    ///   <para>rdfs:label : Time series measurement</para>
    ///   <para>rdfs:comment : A sequence of data in a successive equally spaced points in time. The O&amp;M ontology (ISO 19156) defines Time Series Observation  as an “observation whose result is a time-series”, while both Hl7 aECG and DICOM standards define the Series element as a sequence of data sharing a common frame of reference. In SAREF4health this concept is termed as Time Series Measurements since this sequence of data refers to time series measured by a health device.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/TimeSeriesMeasurement">s4ehaw:TimeSeriesMeasurement</a>
    /// </summary>
    let TimeSeriesMeasurement = _prefixId.prefix "TimeSeriesMeasurement"
    let Undereating = _prefixId.prefix "Undereating"
    /// <summary>
    ///   <para>rdfs:label : User</para>
    ///   <para>rdfs:comment : A health actor (patient included) that can be equiped with BANs or health devices for monitoring, control, care (specific case of patients) or support purposes.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/User">s4ehaw:User</a>
    /// </summary>
    let User = _prefixId.prefix "User"
    /// <summary>
    ///   <para>rdfs:label : Validity constraint</para>
    ///   <para>rdfs:comment : Data may have validity constraint such as allowable value range.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/ValidityConstraint">s4ehaw:ValidityConstraint</a>
    /// </summary>
    let ValidityConstraint = _prefixId.prefix "ValidityConstraint"
    let Walking = _prefixId.prefix "Walking"
    let WristLocation = _prefixId.prefix "WristLocation"
    let Young = _prefixId.prefix "Young"
    /// <summary>
    ///   <para>rdfs:label : activity duration</para>
    ///   <para>rdfs:comment : The duration of an activity, in second.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/activityDuration">s4ehaw:activityDuration</a>
    /// </summary>
    let activityDuration = _prefixId.prefix "activityDuration"
    /// <summary>
    ///   <para>rdfs:label : activity kind</para>
    ///   <para>rdfs:comment : The kind of atcivities that a patient or a user can have, i.e. e.g. sleeping in bed, sitting on a chair, using the shower, etc.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/activityKind">s4ehaw:activityKind</a>
    /// </summary>
    let activityKind = _prefixId.prefix "activityKind"
    /// <summary>
    ///   <para>rdfs:label : available flash</para>
    ///   <para>rdfs:comment : The available flash memory (in byte) of a health device. It is a dynamic attribute.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/availableFlash">s4ehaw:availableFlash</a>
    /// </summary>
    let availableFlash = _prefixId.prefix "availableFlash"
    /// <summary>
    ///   <para>rdfs:label : available ram</para>
    ///   <para>rdfs:comment : Indicates the available volatile memory space (in byte) of a health device. It is a dynamic attribute.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/availableRam">s4ehaw:availableRam</a>
    /// </summary>
    let availableRam = _prefixId.prefix "availableRam"
    /// <summary>
    ///   <para>rdfs:label : BAN density</para>
    ///   <para>rdfs:comment : The BAN density, i.e. its number of node.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/banDensity">s4ehaw:banDensity</a>
    /// </summary>
    let banDensity = _prefixId.prefix "banDensity"
    /// <summary>
    ///   <para>rdfs:label : BAN geolocation</para>
    ///   <para>rdfs:comment : The geolocation of the BAN, when available and needed, shall be given relatively to the current location - geolocation as standardized ISO 6709, e.g. +40.75-074.00/  - of the patient wearing the BAN.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/banGeolocation">s4ehaw:banGeolocation</a>
    /// </summary>
    let banGeolocation = _prefixId.prefix "banGeolocation"
    /// <summary>
    ///   <para>rdfs:label : BAN topology</para>
    ///   <para>rdfs:comment : The BAN physical topology type, i.e Adhoc or Star or Mesh or Others.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/banTopology">s4ehaw:banTopology</a>
    /// </summary>
    let banTopology = _prefixId.prefix "banTopology"
    /// <summary>
    ///   <para>rdfs:label : contains</para>
    ///   <para>rdfs:comment : A Body Area Network or BAN contains one or multiple health devices</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/contains">s4ehaw:contains</a>
    /// </summary>
    let contains = _prefixId.prefix "contains"
    /// <summary>
    ///   <para>rdfs:label : data size</para>
    ///   <para>rdfs:comment : The data size represents the size of the data in bytes</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/dataSize">s4ehaw:dataSize</a>
    /// </summary>
    let dataSize = _prefixId.prefix "dataSize"
    /// <summary>
    ///   <para>rdfs:label : device characteristic name</para>
    ///   <para>rdfs:comment : The commercial name of a device.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/deviceCharacteristicName">s4ehaw:deviceCharacteristicName</a>
    /// </summary>
    let deviceCharacteristicName = _prefixId.prefix "deviceCharacteristicName"
    /// <summary>
    ///   <para>rdfs:label : dimension</para>
    ///   <para>rdfs:comment : The dimension of the device i.e. height*weight*length string.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/dimension">s4ehaw:dimension</a>
    /// </summary>
    let dimension = _prefixId.prefix "dimension"
    /// <summary>
    ///   <para>rdfs:label : date of birth</para>
    ///   <para>rdfs:comment : The date of birth of a health actor.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/dob">s4ehaw:dob</a>
    /// </summary>
    let dob = _prefixId.prefix "dob"
    /// <summary>
    ///   <para>rdfs:label : duty cycle</para>
    ///   <para>rdfs:comment : The duty cycle for each health device embedded processor, in percent.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/dutyCycle">s4ehaw:dutyCycle</a>
    /// </summary>
    let dutyCycle = _prefixId.prefix "dutyCycle"
    /// <summary>
    ///   <para>rdfs:label : fault tolerence</para>
    ///   <para>rdfs:comment : Defines the error rate tolerated for a measurement function.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/faultTolerence">s4ehaw:faultTolerence</a>
    /// </summary>
    let faultTolerence = _prefixId.prefix "faultTolerence"
    /// <summary>
    ///   <para>rdfs:label : first name</para>
    ///   <para>rdfs:comment : The first name of a health actor.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/firstName">s4ehaw:firstName</a>
    /// </summary>
    let firstName = _prefixId.prefix "firstName"
    /// <summary>
    ///   <para>rdfs:label : follows user</para>
    ///   <para>rdfs:comment : A helper may follow one or multiple users that can in particular be patients.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/followsUser">s4ehaw:followsUser</a>
    /// </summary>
    let followsUser = _prefixId.prefix "followsUser"
    /// <summary>
    ///   <para>rdfs:label : format</para>
    ///   <para>rdfs:comment : The format is a URI for a standard format like e.g. integer.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/format">s4ehaw:format</a>
    /// </summary>
    let format = _prefixId.prefix "format"
    /// <summary>
    ///   <para>rdfs:label : frequency</para>
    ///   <para>rdfs:comment : The frequency is the number of instructions an embedded processor - within a health device - can perform per second (MIPS).</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/frequency">s4ehaw:frequency</a>
    /// </summary>
    let frequency = _prefixId.prefix "frequency"
    /// <summary>
    ///   <para>rdfs:label : geolocation</para>
    ///   <para>rdfs:comment : The geolocation, when available, shall be given relatively to the current location - geolocation as standardized ISO 6709, e.g. +40.75-074.00/ -.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/geolocation">s4ehaw:geolocation</a>
    /// </summary>
    let geolocation = _prefixId.prefix "geolocation"
    /// <summary>
    ///   <para>rdfs:label : grounding protocol</para>
    ///   <para>rdfs:comment : The grounding protocol is the protocol used to transmit the message by the service, e.g. BLE.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/groundingProtocol">s4ehaw:groundingProtocol</a>
    /// </summary>
    let groundingProtocol = _prefixId.prefix "groundingProtocol"
    /// <summary>
    ///   <para>rdfs:label : has activity</para>
    ///   <para>rdfs:comment : A health actor may have one or multiple activities.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/hasActivity">s4ehaw:hasActivity</a>
    /// </summary>
    let hasActivity = _prefixId.prefix "hasActivity"
    /// <summary>
    ///   <para>rdfs:label : has age category</para>
    ///   <para>rdfs:comment : The age group of a health actor, e.g. old or young.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/hasAgeCategory">s4ehaw:hasAgeCategory</a>
    /// </summary>
    let hasAgeCategory = _prefixId.prefix "hasAgeCategory"
    /// <summary>
    ///   <para>rdfs:label : has BAN application domain</para>
    ///   <para>rdfs:comment : The BAN application domain - healthcare, telemedicine, assisted living, sport training, pervasive computing, safety and emergency... -.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/hasBanApplicationDomain">s4ehaw:hasBanApplicationDomain</a>
    /// </summary>
    let hasBanApplicationDomain = _prefixId.prefix "hasBanApplicationDomain"
    /// <summary>
    ///   <para>rdfs:label : has BAN communication type</para>
    ///   <para>rdfs:comment : A BAN has a BAN communication type that is the type of communication carried out between BAN devices and BAN Hub.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/hasBanCommunicationType">s4ehaw:hasBanCommunicationType</a>
    /// </summary>
    let hasBanCommunicationType = _prefixId.prefix "hasBanCommunicationType"
    /// <summary>
    ///   <para>rdfs:label : has calculation method</para>
    ///   <para>rdfs:comment : The service process has a calculation method to get the output or result, e.g. the calculation formula to determine the posture of a patient.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/hasCalculationMethod">s4ehaw:hasCalculationMethod</a>
    /// </summary>
    let hasCalculationMethod = _prefixId.prefix "hasCalculationMethod"
    /// <summary>
    ///   <para>rdfs:label : has chronic disease</para>
    ///   <para>rdfs:comment : A patient can suffer from one or more chronic disease like Diabetes, azma, etc.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/hasChronicDisease">s4ehaw:hasChronicDisease</a>
    /// </summary>
    let hasChronicDisease = _prefixId.prefix "hasChronicDisease"
    /// <summary>
    ///   <para>rdfs:label : has computing power</para>
    ///   <para>rdfs:comment : A health device characteristic describing the processing power or capabilities of the device (e.g. processor ID and manufacturer, duty cycle, available flash/RM memory, maximum flash/RAM memory...).</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/hasComputingPower">s4ehaw:hasComputingPower</a>
    /// </summary>
    let hasComputingPower = _prefixId.prefix "hasComputingPower"
    /// <summary>
    ///   <para>rdfs:label : has contact</para>
    ///   <para>rdfs:comment : A BAN has one or multiple contacts (e.g. the patient or user that is monitored through this BAN, the caregiver that is using this BAN for monitoring purposes).</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/hasContact">s4ehaw:hasContact</a>
    /// </summary>
    let hasContact = _prefixId.prefix "hasContact"
    /// <summary>
    ///   <para>rdfs:label : has data</para>
    ///   <para>rdfs:comment : A function has one or many data, for example a tracking function shall include latitude, longitude and speed data.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/hasData">s4ehaw:hasData</a>
    /// </summary>
    let hasData = _prefixId.prefix "hasData"
    /// <summary>
    ///   <para>rdfs:label : has data constraint</para>
    ///   <para>rdfs:comment : Data has data constraints (validity, legal...).</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/hasDataConstraint">s4ehaw:hasDataConstraint</a>
    /// </summary>
    let hasDataConstraint = _prefixId.prefix "hasDataConstraint"
    /// <summary>
    ///   <para>rdfs:label : has device characteristic</para>
    ///   <para>rdfs:comment : A health device has device characteristic describing the physical characteristics of the health device, e.g. its dimensions.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/hasDeviceCharacteristic">s4ehaw:hasDeviceCharacteristic</a>
    /// </summary>
    let hasDeviceCharacteristic = _prefixId.prefix "hasDeviceCharacteristic"
    /// <summary>
    ///   <para>rdfs:label : has effect</para>
    ///   <para>rdfs:comment : The effect of a service can be an alert, nothing, an activation of another process...</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/hasEffect">s4ehaw:hasEffect</a>
    /// </summary>
    let hasEffect = _prefixId.prefix "hasEffect"
    /// <summary>
    ///   <para>rdfs:label : has gender</para>
    ///   <para>rdfs:comment : The gender of a health actor.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/hasGender">s4ehaw:hasGender</a>
    /// </summary>
    let hasGender = _prefixId.prefix "hasGender"
    /// <summary>
    ///   <para>rdfs:label : has habit</para>
    ///   <para>rdfs:comment : The habits of a user and a patient (as sub-class of user it also inherits habit), e.g. smoking or overeating.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/hasHabit">s4ehaw:hasHabit</a>
    /// </summary>
    let hasHabit = _prefixId.prefix "hasHabit"
    /// <summary>
    ///   <para>rdfs:label : has hub</para>
    ///   <para>rdfs:comment : A Body Area Network or BAN elects one hub that mainly plays the role of both a data concentrator and a network gateway.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/hasHub">s4ehaw:hasHub</a>
    /// </summary>
    let hasHub = _prefixId.prefix "hasHub"
    /// <summary>
    ///   <para>rdfs:label : has impairment</para>
    ///   <para>rdfs:comment : The impairment type of a user and a patient (as sub-class of user it also inherits impairment), e.g. aural, skeletal, ocular, mobility, intellectual...</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/hasImpairment">s4ehaw:hasImpairment</a>
    /// </summary>
    let hasImpairment = _prefixId.prefix "hasImpairment"
    /// <summary>
    ///   <para>rdfs:label : has input</para>
    ///   <para>rdfs:comment : The service process has data input like e.g. the patient ID, the timestamp, the read value from a sensor...</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/hasInput">s4ehaw:hasInput</a>
    /// </summary>
    let hasInput = _prefixId.prefix "hasInput"
    /// <summary>
    ///   <para>rdfs:label : has interface</para>
    ///   <para>rdfs:comment : A health device has one or multiple interfaces (Bluetooth, UWB, IEEE 802.15.6, serial interface...).</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/hasInterface">s4ehaw:hasInterface</a>
    /// </summary>
    let hasInterface = _prefixId.prefix "hasInterface"
    /// <summary>
    ///   <para>rdfs:label : has location</para>
    ///   <para>rdfs:comment : The location of an eHealth device, i.e. its position against the body (on body surface or in the body - implant -) and its physical location (i.e. its postal address and/or its current geolocation geolocation when available).</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/hasLocation">s4ehaw:hasLocation</a>
    /// </summary>
    let hasLocation = _prefixId.prefix "hasLocation"
    /// <summary>
    ///   <para>rdfs:label : has mbox</para>
    ///   <para>rdfs:comment : An email address (or mail box) of an health actor: a URI with the 'mailto' scheme as defined by RFC 6068.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/hasMbox">s4ehaw:hasMbox</a>
    /// </summary>
    let hasMbox = _prefixId.prefix "hasMbox"
    /// <summary>
    ///   <para>rdfs:label : has measurement</para>
    ///   <para>rdfs:comment : Defines the relationship between data that has measurement.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/hasMeasurement">s4ehaw:hasMeasurement</a>
    /// </summary>
    let hasMeasurement = _prefixId.prefix "hasMeasurement"
    /// <summary>
    ///   <para>rdfs:label : has mode</para>
    ///   <para>rdfs:comment : Each device has modes of operations that model its dynamic characteristic varying during its lifetime, e.g. active, hold, beacon...</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/hasMode">s4ehaw:hasMode</a>
    /// </summary>
    let hasMode = _prefixId.prefix "hasMode"
    /// <summary>
    ///   <para>rdfs:label : has operating constraint</para>
    ///   <para>rdfs:comment : The operating constraints of a health device, e.g. recommended humidity and temperature range...</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/hasOperatingConstraint">s4ehaw:hasOperatingConstraint</a>
    /// </summary>
    let hasOperatingConstraint = _prefixId.prefix "hasOperatingConstraint"
    /// <summary>
    ///   <para>rdfs:label : has output</para>
    ///   <para>rdfs:comment : The output is e.g. the calculated value returned by the process, e.g the posture of a patient.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/hasOutput">s4ehaw:hasOutput</a>
    /// </summary>
    let hasOutput = _prefixId.prefix "hasOutput"
    /// <summary>
    ///   <para>rdfs:label : has participant</para>
    ///   <para>rdfs:comment : A measurement session has health actors as participants (caregiver controling the session, patient monitored during the session).</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/hasParticipant">s4ehaw:hasParticipant</a>
    /// </summary>
    let hasParticipant = _prefixId.prefix "hasParticipant"
    /// <summary>
    ///   <para>rdfs:label : has patient</para>
    ///   <para>rdfs:comment : A caregiver may have one or multiple patients.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/hasPatient">s4ehaw:hasPatient</a>
    /// </summary>
    let hasPatient = _prefixId.prefix "hasPatient"
    /// <summary>
    ///   <para>rdfs:label : has physical location</para>
    ///   <para>rdfs:comment : Defines the physical location of the patient, i.e. its postal address and/or its geolocation (when available).</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/hasPhysicalLocation">s4ehaw:hasPhysicalLocation</a>
    /// </summary>
    let hasPhysicalLocation = _prefixId.prefix "hasPhysicalLocation"
    /// <summary>
    ///   <para>rdfs:label : has posture</para>
    ///   <para>rdfs:comment : The posture of a user and a patient (as sub-class of user it also inherits habit), e.g. exercising, lying, running, sitting, walking...</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/hasPosture">s4ehaw:hasPosture</a>
    /// </summary>
    let hasPosture = _prefixId.prefix "hasPosture"
    /// <summary>
    ///   <para>rdfs:label : has power source</para>
    ///   <para>rdfs:comment : A health device characteristic is its  power sources, mainly describing energy source and battery related capabilities of the health device (number of power source, source type, rechargeable or not, available power level...).</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/hasPowerSource">s4ehaw:hasPowerSource</a>
    /// </summary>
    let hasPowerSource = _prefixId.prefix "hasPowerSource"
    /// <summary>
    ///   <para>rdfs:label : has precondition</para>
    ///   <para>rdfs:comment : The conditions that are imposed over the inputs of the process and the process must hold to be successufully invoked.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/hasPrecondition">s4ehaw:hasPrecondition</a>
    /// </summary>
    let hasPrecondition = _prefixId.prefix "hasPrecondition"
    /// <summary>
    ///   <para>rdfs:label : has responsible party</para>
    ///   <para>rdfs:comment : A BAN that has a responsible party which plays the role of the legal entity responsible for this BAN (e.g. to contact in case of problem). It should be an organization or a person.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/hasResponsibleParty">s4ehaw:hasResponsibleParty</a>
    /// </summary>
    let hasResponsibleParty = _prefixId.prefix "hasResponsibleParty"
    /// <summary>
    ///   <para>rdfs:label : has result</para>
    ///   <para>rdfs:comment : The process can have many results for the same output. Those results may include a message that should be displayed, an alert...</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/hasResult">s4ehaw:hasResult</a>
    /// </summary>
    let hasResult = _prefixId.prefix "hasResult"
    /// <summary>
    ///   <para>rdfs:label : has time series measurement</para>
    ///   <para>rdfs:comment : Data has time series measurements, a sequence taken at successive equally spaced points in time.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/hasTimeSeriesMesurement">s4ehaw:hasTimeSeriesMesurement</a>
    /// </summary>
    let hasTimeSeriesMesurement = _prefixId.prefix "hasTimeSeriesMesurement"
    /// <summary>
    ///   <para>rdfs:label : has values</para>
    ///   <para>rdfs:comment : A relationship defining the set of values (an ordered array of numbers) of a certain property, e.g., heart rate. Attention: to assure ordering in the serialization format, it is necessary to use either rdf:Seq (RDF/XML) or @list (JSON-LD).</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/hasValues">s4ehaw:hasValues</a>
    /// </summary>
    let hasValues = _prefixId.prefix "hasValues"
    /// <summary>
    ///   <para>rdfs:label : in current mode</para>
    ///   <para>rdfs:comment : Each eHealth device has modes of operations that model its dynamic characteristic varying during its lifetime, e.g. active, hold, beacon...</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/inCurrentMode">s4ehaw:inCurrentMode</a>
    /// </summary>
    let inCurrentMode = _prefixId.prefix "inCurrentMode"
    /// <summary>
    ///   <para>rdfs:label : interface address</para>
    ///   <para>rdfs:comment : The interface address. The interface may have many addresses like MAC address, IP address or others.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/interfaceAddress">s4ehaw:interfaceAddress</a>
    /// </summary>
    let interfaceAddress = _prefixId.prefix "interfaceAddress"
    /// <summary>
    ///   <para>rdfs:label : interface description</para>
    ///   <para>rdfs:comment : The interface type description.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/interfaceDescription">s4ehaw:interfaceDescription</a>
    /// </summary>
    let interfaceDescription = _prefixId.prefix "interfaceDescription"
    /// <summary>
    ///   <para>rdfs:label : interface protocol</para>
    ///   <para>rdfs:comment : The interface communication protocol can be e.g. BLE, serial, Ethernet...</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/interfaceProtocol">s4ehaw:interfaceProtocol</a>
    /// </summary>
    let interfaceProtocol = _prefixId.prefix "interfaceProtocol"
    /// <summary>
    ///   <para>rdfs:label : is attached to</para>
    ///   <para>rdfs:comment : A health Device is attached to a health actor such as a patient, a user and or a caregiver.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/isAttachedTo">s4ehaw:isAttachedTo</a>
    /// </summary>
    let isAttachedTo = _prefixId.prefix "isAttachedTo"
    /// <summary>
    ///   <para>rdfs:label : is derived data</para>
    ///   <para>rdfs:comment : Is derived data is a Boolean property to indicate if the data is a row data or a calculated/derived data from other one.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/isDerivedData">s4ehaw:isDerivedData</a>
    /// </summary>
    let isDerivedData = _prefixId.prefix "isDerivedData"
    /// <summary>
    ///   <para>rdfs:label : is described by</para>
    ///   <para>rdfs:comment : A service is described by a service process (how the service works).</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/isDescribedBy">s4ehaw:isDescribedBy</a>
    /// </summary>
    let isDescribedBy = _prefixId.prefix "isDescribedBy"
    /// <summary>
    ///   <para>rdfs:label : is gateway</para>
    ///   <para>rdfs:comment : This boolean variable indicates if the interface is a gateway or not.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/isGateway">s4ehaw:isGateway</a>
    /// </summary>
    let isGateway = _prefixId.prefix "isGateway"
    /// <summary>
    ///   <para>rdfs:label : last name</para>
    ///   <para>rdfs:comment : The familly name of a health actor.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/lastName">s4ehaw:lastName</a>
    /// </summary>
    let lastName = _prefixId.prefix "lastName"
    /// <summary>
    ///   <para>rdfs:label : latency</para>
    ///   <para>rdfs:comment : The latency is the time interval between the stimulation and response of a measurement function (in ms).</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/latency">s4ehaw:latency</a>
    /// </summary>
    let latency = _prefixId.prefix "latency"
    /// <summary>
    ///   <para>rdfs:label : lifetime</para>
    ///   <para>rdfs:comment : The BAN lifetime (in month), e.g. BAN for entertainment purposes should have a lifetime of weeks or few years whereas BAN dedicated for assisted living or anomaly monitoring should last for many years.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/lifetime">s4ehaw:lifetime</a>
    /// </summary>
    let lifetime = _prefixId.prefix "lifetime"
    /// <summary>
    ///   <para>rdfs:label : maximum flash</para>
    ///   <para>rdfs:comment : Indicates the maximum flash memory space (in byte) of a health device.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/maximumFlash">s4ehaw:maximumFlash</a>
    /// </summary>
    let maximumFlash = _prefixId.prefix "maximumFlash"
    /// <summary>
    ///   <para>rdfs:label : maximum ram</para>
    ///   <para>rdfs:comment : Indicates the maximum volatile memory space (in byte) of a health device.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/maximumRam">s4ehaw:maximumRam</a>
    /// </summary>
    let maximumRam = _prefixId.prefix "maximumRam"
    /// <summary>
    ///   <para>rdfs:label : maximum value</para>
    ///   <para>rdfs:comment : The maximum allowable value of a measurement.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/maximumValue">s4ehaw:maximumValue</a>
    /// </summary>
    let maximumValue = _prefixId.prefix "maximumValue"
    /// <summary>
    ///   <para>rdfs:label : minimum value</para>
    ///   <para>rdfs:comment : The minimum allowable value  of a measurement.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/minimumValue">s4ehaw:minimumValue</a>
    /// </summary>
    let minimumValue = _prefixId.prefix "minimumValue"
    /// <summary>
    ///   <para>rdfs:label : mode name</para>
    ///   <para>rdfs:comment : The mode name of a device, e.g. sleeping.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/modeName">s4ehaw:modeName</a>
    /// </summary>
    let modeName = _prefixId.prefix "modeName"
    /// <summary>
    ///   <para>rdfs:label : phenomena</para>
    ///   <para>rdfs:comment : The BAN monitors a specific phenomenon (burned calories during exercises, glucose level...).</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/phenomena">s4ehaw:phenomena</a>
    /// </summary>
    let phenomena = _prefixId.prefix "phenomena"
    /// <summary>
    ///   <para>rdfs:label : phone</para>
    ///   <para>rdfs:comment : The phone number of a health actor, in international format.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/phone">s4ehaw:phone</a>
    /// </summary>
    let phone = _prefixId.prefix "phone"
    /// <summary>
    ///   <para>rdfs:label : port number</para>
    ///   <para>rdfs:comment : The port number used to offer the service.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/portNumber">s4ehaw:portNumber</a>
    /// </summary>
    let portNumber = _prefixId.prefix "portNumber"
    /// <summary>
    ///   <para>rdfs:label : postal address</para>
    ///   <para>rdfs:comment : Defines the postal address.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/postalAddress">s4ehaw:postalAddress</a>
    /// </summary>
    let postalAddress = _prefixId.prefix "postalAddress"
    /// <summary>
    ///   <para>rdfs:label : power source type</para>
    ///   <para>rdfs:comment : The type of power source of a health device. It can be solar, battery, electricity...</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/powerSourceType">s4ehaw:powerSourceType</a>
    /// </summary>
    let powerSourceType = _prefixId.prefix "powerSourceType"
    /// <summary>
    ///   <para>rdfs:label : precision</para>
    ///   <para>rdfs:comment : Precision refers to the degree of reproducibility of a measured quantity (when the same quantity is measured several times how close are the measurements from each other).</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/precision">s4ehaw:precision</a>
    /// </summary>
    let precision = _prefixId.prefix "precision"
    /// <summary>
    ///   <para>rdfs:label : presents</para>
    ///   <para>rdfs:comment : A service presents a service profile (what the service does).</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/presents">s4ehaw:presents</a>
    /// </summary>
    let presents = _prefixId.prefix "presents"
    /// <summary>
    ///   <para>rdfs:label : rechargeable</para>
    ///   <para>rdfs:comment : This boolean variable indicates if the power source is rechargeable or not, e.g. a rechargeable battery.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/rechargeable">s4ehaw:rechargeable</a>
    /// </summary>
    let rechargeable = _prefixId.prefix "rechargeable"
    /// <summary>
    ///   <para>rdfs:label : remaining battery level</para>
    ///   <para>rdfs:comment : The level of remaining battery (if any : in percent) for a health device. It is a dynamic attribute.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/remainingBatteryLevel">s4ehaw:remainingBatteryLevel</a>
    /// </summary>
    let remainingBatteryLevel = _prefixId.prefix "remainingBatteryLevel"
    /// <summary>
    ///   <para>rdfs:label : sample time</para>
    ///   <para>rdfs:comment : The sample time of a measurement function (a discrete integer).</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/sampleTime">s4ehaw:sampleTime</a>
    /// </summary>
    let sampleTime = _prefixId.prefix "sampleTime"
    /// <summary>
    ///   <para>rdfs:label : sending frequency</para>
    ///   <para>rdfs:comment : Defines the sending frequency (in ms), at an health device level, in case of pariodic BAN communication type.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/sendingFrequency">s4ehaw:sendingFrequency</a>
    /// </summary>
    let sendingFrequency = _prefixId.prefix "sendingFrequency"
    /// <summary>
    ///   <para>rdfs:label : serial number</para>
    ///   <para>rdfs:comment : The serial number of a health device.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/serialNb">s4ehaw:serialNb</a>
    /// </summary>
    let serialNb = _prefixId.prefix "serialNb"
    /// <summary>
    ///   <para>rdfs:label : service description</para>
    ///   <para>rdfs:comment : The service description should describe the offered service like e.g. heart rate measurement.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/serviceDescription">s4ehaw:serviceDescription</a>
    /// </summary>
    let serviceDescription = _prefixId.prefix "serviceDescription"
    /// <summary>
    ///   <para>rdfs:label : service name</para>
    ///   <para>rdfs:comment : The service name identify the offered service, e.g heart rate.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/serviceName">s4ehaw:serviceName</a>
    /// </summary>
    let serviceName = _prefixId.prefix "serviceName"
    /// <summary>
    ///   <para>rdfs:label : supports</para>
    ///   <para>rdfs:comment : A service supports a service grounding (how to access the service).^^xsd:string</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/supports">s4ehaw:supports</a>
    /// </summary>
    let supports = _prefixId.prefix "supports"
    /// <summary>
    ///   <para>rdfs:label : transmission rate</para>
    ///   <para>rdfs:comment : The transmission rate of the interface, i.e. the number of bits transmitted per second (usually expressed in kbps or Mbps).</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/transmissionRate">s4ehaw:transmissionRate</a>
    /// </summary>
    let transmissionRate = _prefixId.prefix "transmissionRate"
    /// <summary>
    ///   <para>rdfs:label : unit of measurement</para>
    ///   <para>rdfs:comment : Defines the unit of measure of a measurement function.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/uom">s4ehaw:uom</a>
    /// </summary>
    let uom = _prefixId.prefix "uom"
    /// <summary>
    ///   <para>rdfs:label : uses ban</para>
    ///   <para>rdfs:comment : A health actor (e.g. a caregiver, a patient or a helper) uses a BAN for collecting, aggregating and relaying vital parameters.</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/usesBan">s4ehaw:usesBan</a>
    /// </summary>
    let usesBan = _prefixId.prefix "usesBan"
    /// <summary>
    ///   <para>rdfs:label : velocity</para>
    ///   <para>rdfs:comment : The velocity of a moving device (in m/s).</para>
    ///   <a href="https://saref.etsi.org/saref4ehaw/velocity">s4ehaw:velocity</a>
    /// </summary>
    let velocity = _prefixId.prefix "velocity"
