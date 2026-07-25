namespace https.saref.etsi.org.saref4ehaw.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module s4ehaw =
    let _namespace_iri = Namespace_Iri s4ehaw |> NamespaceIRI
    /// <summary>
    ///   <para>s4ehaw:dutyCycle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The duty cycle for each health device embedded processor, in percent.</para>
    /// labels<para>duty cycle</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/dutyCycle">https://saref.etsi.org/saref4ehaw/dutyCycle</seealso>
    let dutyCycle = Prefixed_Name(s4ehaw, "dutyCycle") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:ReminderCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Command used for sending reminder notifications to health actors, e.g. patients, users or Caregivers.</para>
    /// labels<para>Reminder command</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/ReminderCommand">https://saref.etsi.org/saref4ehaw/ReminderCommand</seealso>
    let ReminderCommand = Prefixed_Name(s4ehaw, "ReminderCommand") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:ServiceProfile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>What the service does.</para>
    /// labels<para>Service profile</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/ServiceProfile">https://saref.etsi.org/saref4ehaw/ServiceProfile</seealso>
    let ServiceProfile = Prefixed_Name(s4ehaw, "ServiceProfile") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:Sitting</para>
    /// </summary>
    /// <remarks>
    ///   <para>s4ehaw:Posture</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Posture of a sitting user.</para>
    /// labels<para>Sitting</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/Sitting">https://saref.etsi.org/saref4ehaw/Sitting</seealso>
    let Sitting = Prefixed_Name(s4ehaw, "Sitting") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:Habit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Defined for users (that can in particular be patients) habits modelling, e.g. smoking, alcohol drinking, overeating, undereating...</para>
    /// labels<para>Habit</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/Habit">https://saref.etsi.org/saref4ehaw/Habit</seealso>
    let Habit = Prefixed_Name(s4ehaw, "Habit") |> PrefixedName

    /// <summary>
    ///   <para>s4ehaw:BodySurfaceLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Defines a health device location in terms of a body surface position (i.e. on body health device).</para>
    /// labels<para>Body surface location</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/BodySurfaceLocation">https://saref.etsi.org/saref4ehaw/BodySurfaceLocation</seealso>
    let BodySurfaceLocation =
        Prefixed_Name(s4ehaw, "BodySurfaceLocation") |> PrefixedName

    /// <summary>
    ///   <para>s4ehaw:AssistedLiving</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>s4ehaw:BanApplicationDomain</para>
    ///   <para>Assisted living sub-domain for BAN application.</para>
    /// labels<para>Assisted living</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/AssistedLiving">https://saref.etsi.org/saref4ehaw/AssistedLiving</seealso>
    let AssistedLiving = Prefixed_Name(s4ehaw, "AssistedLiving") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:AuralImpairment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>s4ehaw:Impairment</para>
    ///   <para>Aural impairment (User level), i.e. impairments of auditory sensitivity.</para>
    /// labels<para>Aural impairment</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/AuralImpairment">https://saref.etsi.org/saref4ehaw/AuralImpairment</seealso>
    let AuralImpairment = Prefixed_Name(s4ehaw, "AuralImpairment") |> PrefixedName

    /// <summary>
    ///   <para>s4ehaw:MeasurementFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The functionality necessary to accomplish the measurement task for which a measurement-related health Device (e.g. Sensor, Wearable, ECG Device...) is designed for, e.g. a heart rate measurement function.</para>
    /// labels<para>Measurement function</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/MeasurementFunction">https://saref.etsi.org/saref4ehaw/MeasurementFunction</seealso>
    let MeasurementFunction =
        Prefixed_Name(s4ehaw, "MeasurementFunction") |> PrefixedName

    /// <summary>
    ///   <para>s4ehaw:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/">https://saref.etsi.org/saref4ehaw/</seealso>
    let _prefix_iri = Prefixed_Name(s4ehaw, "") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:v1.1.1/</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/v1.1.1/">https://saref.etsi.org/saref4ehaw/v1.1.1/</seealso>
    let ``v1.1.1/`` = Prefixed_Name(s4ehaw, "v1.1.1/") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:AgeCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The age group of a health actor, e.g. old or young.</para>
    /// labels<para>Age category</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/AgeCategory">https://saref.etsi.org/saref4ehaw/AgeCategory</seealso>
    let AgeCategory = Prefixed_Name(s4ehaw, "AgeCategory") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:Activity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The activity of a patient/user, i.e. daily and nocturnal activities.</para>
    /// labels<para>Activity</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/Activity">https://saref.etsi.org/saref4ehaw/Activity</seealso>
    let Activity = Prefixed_Name(s4ehaw, "Activity") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:WristLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>s4ehaw:BodySurfaceLocation</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Wrist, a user body surface location.</para>
    /// labels<para>Wrist location</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/WristLocation">https://saref.etsi.org/saref4ehaw/WristLocation</seealso>
    let WristLocation = Prefixed_Name(s4ehaw, "WristLocation") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:AlarmCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A command corresponding to alarm sending.</para>
    /// labels<para>Alarm command</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/AlarmCommand">https://saref.etsi.org/saref4ehaw/AlarmCommand</seealso>
    let AlarmCommand = Prefixed_Name(s4ehaw, "AlarmCommand") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:AlcoholDrinking</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>s4ehaw:Habit</para>
    ///   <para>Alcohol drinking habit (User level).</para>
    /// labels<para>Alcohol drinking</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/AlcoholDrinking">https://saref.etsi.org/saref4ehaw/AlcoholDrinking</seealso>
    let AlcoholDrinking = Prefixed_Name(s4ehaw, "AlcoholDrinking") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:contains</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A Body Area Network or BAN contains one or multiple health devices</para>
    /// labels<para>contains</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/contains">https://saref.etsi.org/saref4ehaw/contains</seealso>
    let contains = Prefixed_Name(s4ehaw, "contains") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:ArmpitLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>s4ehaw:BodySurfaceLocation</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Armpit location, a user body surface location.</para>
    /// labels<para>Armpit location</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/ArmpitLocation">https://saref.etsi.org/saref4ehaw/ArmpitLocation</seealso>
    let ArmpitLocation = Prefixed_Name(s4ehaw, "ArmpitLocation") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:Asthma</para>
    /// </summary>
    /// <remarks>
    ///   <para>s4ehaw:ChronicDisease</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Asthma, a chronical disease that some users can have.</para>
    /// labels<para>Asthma</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/Asthma">https://saref.etsi.org/saref4ehaw/Asthma</seealso>
    let Asthma = Prefixed_Name(s4ehaw, "Asthma") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:BanHub</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Hub of the BAN, mainly playing the role of both a data concentrator and a network gateway.</para>
    /// labels<para>BAN hub</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/BanHub">https://saref.etsi.org/saref4ehaw/BanHub</seealso>
    let BanHub = Prefixed_Name(s4ehaw, "BanHub") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:Location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The location, i.e. a position against the body (on - body surface – or in the body – implant –) and a physical location (i.e. a postal address and/or a current geolocation when available).</para>
    /// labels<para>Location</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/Location">https://saref.etsi.org/saref4ehaw/Location</seealso>
    let Location = Prefixed_Name(s4ehaw, "Location") |> PrefixedName

    /// <summary>
    ///   <para>s4ehaw:CommunicationProtocol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The communication protocol, e.g. BLE, serial, Ethernet...</para>
    /// labels<para>Communication protocol</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/CommunicationProtocol">https://saref.etsi.org/saref4ehaw/CommunicationProtocol</seealso>
    let CommunicationProtocol =
        Prefixed_Name(s4ehaw, "CommunicationProtocol") |> PrefixedName

    /// <summary>
    ///   <para>s4ehaw:ComputingPower</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The computing power capabilities of a Health device.</para>
    /// labels<para>Computing power</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/ComputingPower">https://saref.etsi.org/saref4ehaw/ComputingPower</seealso>
    let ComputingPower = Prefixed_Name(s4ehaw, "ComputingPower") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:DailyActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The patient/user activities that occur during daytime.</para>
    /// labels<para>Daily activity</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/DailyActivity">https://saref.etsi.org/saref4ehaw/DailyActivity</seealso>
    let DailyActivity = Prefixed_Name(s4ehaw, "DailyActivity") |> PrefixedName

    /// <summary>
    ///   <para>s4ehaw:DeviceCharacteristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A health device has device characteristic describing the physical characteristics of the health device.</para>
    /// labels<para>Device characteristic</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/DeviceCharacteristic">https://saref.etsi.org/saref4ehaw/DeviceCharacteristic</seealso>
    let DeviceCharacteristic =
        Prefixed_Name(s4ehaw, "DeviceCharacteristic") |> PrefixedName

    /// <summary>
    ///   <para>s4ehaw:Emergency</para>
    /// </summary>
    /// <remarks>
    ///   <para>s4ehaw:BanApplicationDomain</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Emergency sub-domain for BAN application.</para>
    /// labels<para>Emergency</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/Emergency">https://saref.etsi.org/saref4ehaw/Emergency</seealso>
    let Emergency = Prefixed_Name(s4ehaw, "Emergency") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:portNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The port number used to offer the service.</para>
    /// labels<para>port number</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/portNumber">https://saref.etsi.org/saref4ehaw/portNumber</seealso>
    let portNumber = Prefixed_Name(s4ehaw, "portNumber") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:powerSourceType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The type of power source of a health device. It can be solar, battery, electricity...</para>
    /// labels<para>power source type</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/powerSourceType">https://saref.etsi.org/saref4ehaw/powerSourceType</seealso>
    let powerSourceType = Prefixed_Name(s4ehaw, "powerSourceType") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:ChronicDisease</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>For chronic disease modelling, e.g. diabetes, asthma...</para>
    /// labels<para>Chronic disease</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/ChronicDisease">https://saref.etsi.org/saref4ehaw/ChronicDisease</seealso>
    let ChronicDisease = Prefixed_Name(s4ehaw, "ChronicDisease") |> PrefixedName

    /// <summary>
    ///   <para>s4ehaw:hasOperatingConstraint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The operating constraints of a health device, e.g. recommended humidity and temperature range...</para>
    /// labels<para>has operating constraint</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/hasOperatingConstraint">https://saref.etsi.org/saref4ehaw/hasOperatingConstraint</seealso>
    let hasOperatingConstraint =
        Prefixed_Name(s4ehaw, "hasOperatingConstraint") |> PrefixedName

    /// <summary>
    ///   <para>s4ehaw:hasOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The output is e.g. the calculated value returned by the process, e.g the posture of a patient.</para>
    /// labels<para>has output</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/hasOutput">https://saref.etsi.org/saref4ehaw/hasOutput</seealso>
    let hasOutput = Prefixed_Name(s4ehaw, "hasOutput") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:hasPatient</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A caregiver may have one or multiple patients.</para>
    /// labels<para>has patient</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/hasPatient">https://saref.etsi.org/saref4ehaw/hasPatient</seealso>
    let hasPatient = Prefixed_Name(s4ehaw, "hasPatient") |> PrefixedName

    /// <summary>
    ///   <para>s4ehaw:BanApplicationDomain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The BAN application domain, e.g. healthcare, telemedicine, assisted living, sport training, safety and emergency...</para>
    /// labels<para>BAN application domain</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/BanApplicationDomain">https://saref.etsi.org/saref4ehaw/BanApplicationDomain</seealso>
    let BanApplicationDomain =
        Prefixed_Name(s4ehaw, "BanApplicationDomain") |> PrefixedName

    /// <summary>
    ///   <para>s4ehaw:hasDeviceCharacteristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A health device has device characteristic describing the physical characteristics of the health device, e.g. its dimensions.</para>
    /// labels<para>has device characteristic</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/hasDeviceCharacteristic">https://saref.etsi.org/saref4ehaw/hasDeviceCharacteristic</seealso>
    let hasDeviceCharacteristic =
        Prefixed_Name(s4ehaw, "hasDeviceCharacteristic") |> PrefixedName

    /// <summary>
    ///   <para>s4ehaw:hasEffect</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The effect of a service can be an alert, nothing, an activation of another process...</para>
    /// labels<para>has effect</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/hasEffect">https://saref.etsi.org/saref4ehaw/hasEffect</seealso>
    let hasEffect = Prefixed_Name(s4ehaw, "hasEffect") |> PrefixedName

    /// <summary>
    ///   <para>s4ehaw:BanCommunicationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The BAN communication function type, i.e. periodic, event driven or on request.</para>
    /// labels<para>BAN Communication type</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/BanCommunicationType">https://saref.etsi.org/saref4ehaw/BanCommunicationType</seealso>
    let BanCommunicationType =
        Prefixed_Name(s4ehaw, "BanCommunicationType") |> PrefixedName

    /// <summary>
    ///   <para>s4ehaw:Caregiver</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>For caregivers modelling.</para>
    /// labels<para>Caregiver</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/Caregiver">https://saref.etsi.org/saref4ehaw/Caregiver</seealso>
    let Caregiver = Prefixed_Name(s4ehaw, "Caregiver") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:hasPosture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The posture of a user and a patient (as sub-class of user it also inherits habit), e.g. exercising, lying, running, sitting, walking...</para>
    /// labels<para>has posture</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/hasPosture">https://saref.etsi.org/saref4ehaw/hasPosture</seealso>
    let hasPosture = Prefixed_Name(s4ehaw, "hasPosture") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:hasPrecondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The conditions that are imposed over the inputs of the process and the process must hold to be successufully invoked.</para>
    /// labels<para>has precondition</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/hasPrecondition">https://saref.etsi.org/saref4ehaw/hasPrecondition</seealso>
    let hasPrecondition = Prefixed_Name(s4ehaw, "hasPrecondition") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:hasResult</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The process can have many results for the same output. Those results may include a message that should be displayed, an alert...</para>
    /// labels<para>has result</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/hasResult">https://saref.etsi.org/saref4ehaw/hasResult</seealso>
    let hasResult = Prefixed_Name(s4ehaw, "hasResult") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:interfaceAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The interface address. The interface may have many addresses like MAC address, IP address or others.</para>
    /// labels<para>interface address</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/interfaceAddress">https://saref.etsi.org/saref4ehaw/interfaceAddress</seealso>
    let interfaceAddress = Prefixed_Name(s4ehaw, "interfaceAddress") |> PrefixedName

    /// <summary>
    ///   <para>s4ehaw:interfaceDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The interface type description.</para>
    /// labels<para>interface description</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/interfaceDescription">https://saref.etsi.org/saref4ehaw/interfaceDescription</seealso>
    let interfaceDescription =
        Prefixed_Name(s4ehaw, "interfaceDescription") |> PrefixedName

    /// <summary>
    ///   <para>s4ehaw:interfaceProtocol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The interface communication protocol can be e.g. BLE, serial, Ethernet...</para>
    /// labels<para>interface protocol</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/interfaceProtocol">https://saref.etsi.org/saref4ehaw/interfaceProtocol</seealso>
    let interfaceProtocol = Prefixed_Name(s4ehaw, "interfaceProtocol") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:isDerivedData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Is derived data is a Boolean property to indicate if the data is a row data or a calculated/derived data from other one.</para>
    /// labels<para>is derived data</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/isDerivedData">https://saref.etsi.org/saref4ehaw/isDerivedData</seealso>
    let isDerivedData = Prefixed_Name(s4ehaw, "isDerivedData") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:isDescribedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A service is described by a service process (how the service works).</para>
    /// labels<para>is described by</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/isDescribedBy">https://saref.etsi.org/saref4ehaw/isDescribedBy</seealso>
    let isDescribedBy = Prefixed_Name(s4ehaw, "isDescribedBy") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:isGateway</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This boolean variable indicates if the interface is a gateway or not.</para>
    /// labels<para>is gateway</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/isGateway">https://saref.etsi.org/saref4ehaw/isGateway</seealso>
    let isGateway = Prefixed_Name(s4ehaw, "isGateway") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:latency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The latency is the time interval between the stimulation and response of a measurement function (in ms).</para>
    /// labels<para>latency</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/latency">https://saref.etsi.org/saref4ehaw/latency</seealso>
    let latency = Prefixed_Name(s4ehaw, "latency") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:maximumFlash</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates the maximum flash memory space (in byte) of a health device.</para>
    /// labels<para>maximum flash</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/maximumFlash">https://saref.etsi.org/saref4ehaw/maximumFlash</seealso>
    let maximumFlash = Prefixed_Name(s4ehaw, "maximumFlash") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:maximumValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The maximum allowable value of a measurement.</para>
    /// labels<para>maximum value</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/maximumValue">https://saref.etsi.org/saref4ehaw/maximumValue</seealso>
    let maximumValue = Prefixed_Name(s4ehaw, "maximumValue") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:modeName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The mode name of a device, e.g. sleeping.</para>
    /// labels<para>mode name</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/modeName">https://saref.etsi.org/saref4ehaw/modeName</seealso>
    let modeName = Prefixed_Name(s4ehaw, "modeName") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:phone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The phone number of a health actor, in international format.</para>
    /// labels<para>phone</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/phone">https://saref.etsi.org/saref4ehaw/phone</seealso>
    let phone = Prefixed_Name(s4ehaw, "phone") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:postalAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Defines the postal address.</para>
    /// labels<para>postal address</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/postalAddress">https://saref.etsi.org/saref4ehaw/postalAddress</seealso>
    let postalAddress = Prefixed_Name(s4ehaw, "postalAddress") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:presents</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A service presents a service profile (what the service does).</para>
    /// labels<para>presents</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/presents">https://saref.etsi.org/saref4ehaw/presents</seealso>
    let presents = Prefixed_Name(s4ehaw, "presents") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:rechargeable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This boolean variable indicates if the power source is rechargeable or not, e.g. a rechargeable battery.</para>
    /// labels<para>rechargeable</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/rechargeable">https://saref.etsi.org/saref4ehaw/rechargeable</seealso>
    let rechargeable = Prefixed_Name(s4ehaw, "rechargeable") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:sampleTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The sample time of a measurement function (a discrete integer).</para>
    /// labels<para>sample time</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/sampleTime">https://saref.etsi.org/saref4ehaw/sampleTime</seealso>
    let sampleTime = Prefixed_Name(s4ehaw, "sampleTime") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:sendingFrequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Defines the sending frequency (in ms), at an health device level, in case of pariodic BAN communication type.</para>
    /// labels<para>sending frequency</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/sendingFrequency">https://saref.etsi.org/saref4ehaw/sendingFrequency</seealso>
    let sendingFrequency = Prefixed_Name(s4ehaw, "sendingFrequency") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:serviceDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The service description should describe the offered service like e.g. heart rate measurement.</para>
    /// labels<para>service description</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/serviceDescription">https://saref.etsi.org/saref4ehaw/serviceDescription</seealso>
    let serviceDescription = Prefixed_Name(s4ehaw, "serviceDescription") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:serviceName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The service name identify the offered service, e.g heart rate.</para>
    /// labels<para>service name</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/serviceName">https://saref.etsi.org/saref4ehaw/serviceName</seealso>
    let serviceName = Prefixed_Name(s4ehaw, "serviceName") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:transmissionRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The transmission rate of the interface, i.e. the number of bits transmitted per second (usually expressed in kbps or Mbps).</para>
    /// labels<para>transmission rate</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/transmissionRate">https://saref.etsi.org/saref4ehaw/transmissionRate</seealso>
    let transmissionRate = Prefixed_Name(s4ehaw, "transmissionRate") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:uom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Defines the unit of measure of a measurement function.</para>
    /// labels<para>unit of measurement</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/uom">https://saref.etsi.org/saref4ehaw/uom</seealso>
    let uom = Prefixed_Name(s4ehaw, "uom") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:velocity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The velocity of a moving device (in m/s).</para>
    /// labels<para>velocity</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/velocity">https://saref.etsi.org/saref4ehaw/velocity</seealso>
    let velocity = Prefixed_Name(s4ehaw, "velocity") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:hasParticipant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A measurement session has health actors as participants (caregiver controling the session, patient monitored during the session).</para>
    /// labels<para>has participant</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/hasParticipant">https://saref.etsi.org/saref4ehaw/hasParticipant</seealso>
    let hasParticipant = Prefixed_Name(s4ehaw, "hasParticipant") |> PrefixedName

    /// <summary>
    ///   <para>s4ehaw:hasPhysicalLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Defines the physical location of the patient, i.e. its postal address and/or its geolocation (when available).</para>
    /// labels<para>has physical location</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/hasPhysicalLocation">https://saref.etsi.org/saref4ehaw/hasPhysicalLocation</seealso>
    let hasPhysicalLocation =
        Prefixed_Name(s4ehaw, "hasPhysicalLocation") |> PrefixedName

    /// <summary>
    ///   <para>s4ehaw:hasPowerSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A health device characteristic is its  power sources, mainly describing energy source and battery related capabilities of the health device (number of power source, source type, rechargeable or not, available power level...).</para>
    /// labels<para>has power source</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/hasPowerSource">https://saref.etsi.org/saref4ehaw/hasPowerSource</seealso>
    let hasPowerSource = Prefixed_Name(s4ehaw, "hasPowerSource") |> PrefixedName

    /// <summary>
    ///   <para>s4ehaw:hasResponsibleParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A BAN that has a responsible party which plays the role of the legal entity responsible for this BAN (e.g. to contact in case of problem). It should be an organization or a person.</para>
    /// labels<para>has responsible party</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/hasResponsibleParty">https://saref.etsi.org/saref4ehaw/hasResponsibleParty</seealso>
    let hasResponsibleParty =
        Prefixed_Name(s4ehaw, "hasResponsibleParty") |> PrefixedName

    /// <summary>
    ///   <para>s4ehaw:hasTimeSeriesMesurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Data has time series measurements, a sequence taken at successive equally spaced points in time.</para>
    /// labels<para>has time series measurement</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/hasTimeSeriesMesurement">https://saref.etsi.org/saref4ehaw/hasTimeSeriesMesurement</seealso>
    let hasTimeSeriesMesurement =
        Prefixed_Name(s4ehaw, "hasTimeSeriesMesurement") |> PrefixedName

    /// <summary>
    ///   <para>s4ehaw:inCurrentMode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Each eHealth device has modes of operations that model its dynamic characteristic varying during its lifetime, e.g. active, hold, beacon...</para>
    /// labels<para>in current mode</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/inCurrentMode">https://saref.etsi.org/saref4ehaw/inCurrentMode</seealso>
    let inCurrentMode = Prefixed_Name(s4ehaw, "inCurrentMode") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:isAttachedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A health Device is attached to a health actor such as a patient, a user and or a caregiver.</para>
    /// labels<para>is attached to</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/isAttachedTo">https://saref.etsi.org/saref4ehaw/isAttachedTo</seealso>
    let isAttachedTo = Prefixed_Name(s4ehaw, "isAttachedTo") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:lastName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The familly name of a health actor.</para>
    /// labels<para>last name</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/lastName">https://saref.etsi.org/saref4ehaw/lastName</seealso>
    let lastName = Prefixed_Name(s4ehaw, "lastName") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:lifetime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The BAN lifetime (in month), e.g. BAN for entertainment purposes should have a lifetime of weeks or few years whereas BAN dedicated for assisted living or anomaly monitoring should last for many years.</para>
    /// labels<para>lifetime</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/lifetime">https://saref.etsi.org/saref4ehaw/lifetime</seealso>
    let lifetime = Prefixed_Name(s4ehaw, "lifetime") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:maximumRam</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates the maximum volatile memory space (in byte) of a health device.</para>
    /// labels<para>maximum ram</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/maximumRam">https://saref.etsi.org/saref4ehaw/maximumRam</seealso>
    let maximumRam = Prefixed_Name(s4ehaw, "maximumRam") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:DataConstraint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Data constraints, e.g. validity, legal...</para>
    /// labels<para>Data constraint</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/DataConstraint">https://saref.etsi.org/saref4ehaw/DataConstraint</seealso>
    let DataConstraint = Prefixed_Name(s4ehaw, "DataConstraint") |> PrefixedName

    /// <summary>
    ///   <para>s4ehaw:EventDrivenBanCommunicationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>BAN communication function way of working of the type event driven.</para>
    /// labels<para>Event driven BAN communication type</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/EventDrivenBanCommunicationType">https://saref.etsi.org/saref4ehaw/EventDrivenBanCommunicationType</seealso>
    let EventDrivenBanCommunicationType =
        Prefixed_Name(s4ehaw, "EventDrivenBanCommunicationType") |> PrefixedName

    /// <summary>
    ///   <para>s4ehaw:precision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Precision refers to the degree of reproducibility of a measured quantity (when the same quantity is measured several times how close are the measurements from each other).</para>
    /// labels<para>precision</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/precision">https://saref.etsi.org/saref4ehaw/precision</seealso>
    let precision = Prefixed_Name(s4ehaw, "precision") |> PrefixedName

    /// <summary>
    ///   <para>s4ehaw:remainingBatteryLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The level of remaining battery (if any : in percent) for a health device. It is a dynamic attribute.</para>
    /// labels<para>remaining battery level</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/remainingBatteryLevel">https://saref.etsi.org/saref4ehaw/remainingBatteryLevel</seealso>
    let remainingBatteryLevel =
        Prefixed_Name(s4ehaw, "remainingBatteryLevel") |> PrefixedName

    /// <summary>
    ///   <para>s4ehaw:minimumValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The minimum allowable value  of a measurement.</para>
    /// labels<para>minimum value</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/minimumValue">https://saref.etsi.org/saref4ehaw/minimumValue</seealso>
    let minimumValue = Prefixed_Name(s4ehaw, "minimumValue") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:phenomena</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The BAN monitors a specific phenomenon (burned calories during exercises, glucose level...).</para>
    /// labels<para>phenomena</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/phenomena">https://saref.etsi.org/saref4ehaw/phenomena</seealso>
    let phenomena = Prefixed_Name(s4ehaw, "phenomena") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:HealthActuator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Health-related Actuator, equivalent to SAREF Actuator.</para>
    /// labels<para>Health actuator</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/HealthActuator">https://saref.etsi.org/saref4ehaw/HealthActuator</seealso>
    let HealthActuator = Prefixed_Name(s4ehaw, "HealthActuator") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:serialNb</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The serial number of a health device.</para>
    /// labels<para>serial number</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/serialNb">https://saref.etsi.org/saref4ehaw/serialNb</seealso>
    let serialNb = Prefixed_Name(s4ehaw, "serialNb") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:supports</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A service supports a service grounding (how to access the service).</para>
    /// labels<para>supports</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/supports">https://saref.etsi.org/saref4ehaw/supports</seealso>
    let supports = Prefixed_Name(s4ehaw, "supports") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:usesBan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A health actor (e.g. a caregiver, a patient or a helper) uses a BAN for collecting, aggregating and relaying vital parameters.</para>
    /// labels<para>uses ban</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/usesBan">https://saref.etsi.org/saref4ehaw/usesBan</seealso>
    let usesBan = Prefixed_Name(s4ehaw, "usesBan") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:ImplantLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Implant Device (i.e. in body health device) position.</para>
    /// labels<para>Implant location</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/ImplantLocation">https://saref.etsi.org/saref4ehaw/ImplantLocation</seealso>
    let ImplantLocation = Prefixed_Name(s4ehaw, "ImplantLocation") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:NocturnalActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The patient/user activities that occur during the night.</para>
    /// labels<para>Nocturnal activity</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/NocturnalActivity">https://saref.etsi.org/saref4ehaw/NocturnalActivity</seealso>
    let NocturnalActivity = Prefixed_Name(s4ehaw, "NocturnalActivity") |> PrefixedName

    /// <summary>
    ///   <para>s4ehaw:OnRequestBanCommunicationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>BAN communication function way of working of the type on request.</para>
    /// labels<para>On request BAN communication type</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/OnRequestBanCommunicationType">https://saref.etsi.org/saref4ehaw/OnRequestBanCommunicationType</seealso>
    let OnRequestBanCommunicationType =
        Prefixed_Name(s4ehaw, "OnRequestBanCommunicationType") |> PrefixedName

    /// <summary>
    ///   <para>s4ehaw:OperatingConstraint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An empty container for describing the operating constraints of a device, e.g. recommended humidity and temperature range...</para>
    /// labels<para>Operating constraint</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/OperatingConstraint">https://saref.etsi.org/saref4ehaw/OperatingConstraint</seealso>
    let OperatingConstraint =
        Prefixed_Name(s4ehaw, "OperatingConstraint") |> PrefixedName

    /// <summary>
    ///   <para>s4ehaw:User</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A health actor (patient included) that can be equiped with BANs or health devices for monitoring, control, care (specific case of patients) or support purposes.</para>
    /// labels<para>User</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/User">https://saref.etsi.org/saref4ehaw/User</seealso>
    let User = Prefixed_Name(s4ehaw, "User") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:Impairment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Defined for users (that can in particular be patients) impairments modelling, e.g. aural impairment, skeletal impairment, ocular impairment, mobility impairment, intellectual impairment. Those non exhaustive impairments are compatible with the World Health Organization classification.</para>
    /// labels<para>Impairment</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/Impairment">https://saref.etsi.org/saref4ehaw/Impairment</seealso>
    let Impairment = Prefixed_Name(s4ehaw, "Impairment") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:Ban</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Body Area Network.</para>
    /// labels<para>BAN</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/Ban">https://saref.etsi.org/saref4ehaw/Ban</seealso>
    let Ban = Prefixed_Name(s4ehaw, "Ban") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:HealthDevice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Health devices, e.g. BAN hub, health sensor/actuator/Wereable.</para>
    /// labels<para>Health Device</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/HealthDevice">https://saref.etsi.org/saref4ehaw/HealthDevice</seealso>
    let HealthDevice = Prefixed_Name(s4ehaw, "HealthDevice") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:HealthActor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The eHealth actors like e.g. caregivers, patients, users, helpers...</para>
    /// labels<para>Health actor</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/HealthActor">https://saref.etsi.org/saref4ehaw/HealthActor</seealso>
    let HealthActor = Prefixed_Name(s4ehaw, "HealthActor") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:Contact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A BAN has one or multiple contacts, i.e. some health actors, e.g. the patient or user that is monitored through this BAN, the caregiver that is using this BAN for monitoring purposes...</para>
    /// labels<para>Contact</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/Contact">https://saref.etsi.org/saref4ehaw/Contact</seealso>
    let Contact = Prefixed_Name(s4ehaw, "Contact") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:Data</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A function has one or many data, for example a tracking function shall include latitude, longitude and speed data.</para>
    /// labels<para>Data</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/Data">https://saref.etsi.org/saref4ehaw/Data</seealso>
    let Data = Prefixed_Name(s4ehaw, "Data") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:Diabetes</para>
    /// </summary>
    /// <remarks>
    ///   <para>s4ehaw:ChronicDisease</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Diabetes, a chronical disease that some users can have.</para>
    /// labels<para>Diabetes</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/Diabetes">https://saref.etsi.org/saref4ehaw/Diabetes</seealso>
    let Diabetes = Prefixed_Name(s4ehaw, "Diabetes") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:Exercising</para>
    /// </summary>
    /// <remarks>
    ///   <para>s4ehaw:Posture</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Posture of user doing exercises.</para>
    /// labels<para>Exercising</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/Exercising">https://saref.etsi.org/saref4ehaw/Exercising</seealso>
    let Exercising = Prefixed_Name(s4ehaw, "Exercising") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:Posture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The posture of a health actor (mainly a patient or a user), e.g. exercising, lying, running, sitting, walking...</para>
    /// labels<para>Posture</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/Posture">https://saref.etsi.org/saref4ehaw/Posture</seealso>
    let Posture = Prefixed_Name(s4ehaw, "Posture") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:FunctionalDevice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Functional Devices are non-purely eHealth/ageing-well devices that can be used for modelling/detecting activities or behaviours of patients/users, like for example beacons that can detect indoor positioning of a patient in a house.</para>
    /// labels<para>Functional device</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/FunctionalDevice">https://saref.etsi.org/saref4ehaw/FunctionalDevice</seealso>
    let FunctionalDevice = Prefixed_Name(s4ehaw, "FunctionalDevice") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:HealthSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Health-related Sensor, equivalent to SAREF Sensor.</para>
    /// labels<para>Health sensor</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/HealthSensor">https://saref.etsi.org/saref4ehaw/HealthSensor</seealso>
    let HealthSensor = Prefixed_Name(s4ehaw, "HealthSensor") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:HealthWearable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Health-related Wearable, equivalent to SAREF4WEAR Wearable.</para>
    /// labels<para>Health wereable</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/HealthWearable">https://saref.etsi.org/saref4ehaw/HealthWearable</seealso>
    let HealthWearable = Prefixed_Name(s4ehaw, "HealthWearable") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:Healthcare</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>s4ehaw:BanApplicationDomain</para>
    ///   <para>Healthcare domain for BAN application.</para>
    /// labels<para>Healthcare</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/Healthcare">https://saref.etsi.org/saref4ehaw/Healthcare</seealso>
    let Healthcare = Prefixed_Name(s4ehaw, "Healthcare") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:Helper</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Helper of patients/users, e.g. a patient's relative.</para>
    /// labels<para>Helper</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/Helper">https://saref.etsi.org/saref4ehaw/Helper</seealso>
    let Helper = Prefixed_Name(s4ehaw, "Helper") |> PrefixedName

    /// <summary>
    ///   <para>s4ehaw:IntellectualImpairment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>s4ehaw:Impairment</para>
    ///   <para>Skeletal impairment (User level), e.g. ...</para>
    /// labels<para>Intellectual impairment</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/IntellectualImpairment">https://saref.etsi.org/saref4ehaw/IntellectualImpairment</seealso>
    let IntellectualImpairment =
        Prefixed_Name(s4ehaw, "IntellectualImpairment") |> PrefixedName

    /// <summary>
    ///   <para>s4ehaw:Interface</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Used for modelling the interfaces of a health device (e.g. Bluetooth, UWB, IEEE 802.15.6, serial interface...).</para>
    /// labels<para>Interface</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/Interface">https://saref.etsi.org/saref4ehaw/Interface</seealso>
    let Interface = Prefixed_Name(s4ehaw, "Interface") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:LegalConstraint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An empty container for describing the legal constraints a data can be submitted to, like e.g. anonymization.</para>
    /// labels<para>Legal constraint</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/LegalConstraint">https://saref.etsi.org/saref4ehaw/LegalConstraint</seealso>
    let LegalConstraint = Prefixed_Name(s4ehaw, "LegalConstraint") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:Lying</para>
    /// </summary>
    /// <remarks>
    ///   <para>s4ehaw:Posture</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Posture of a lying user.</para>
    /// labels<para>Lying</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/Lying">https://saref.etsi.org/saref4ehaw/Lying</seealso>
    let Lying = Prefixed_Name(s4ehaw, "Lying") |> PrefixedName

    /// <summary>
    ///   <para>s4ehaw:MeasurementCollectionSession</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Task in which a health actor (mainly a patient or a user) is subject of measurement collection (recording) by both some measurement-related health Device (e.g. Sensor, Wearable, ECG Device...) and a health actor (mainly a caregiver).</para>
    /// labels<para>Measurement collection session</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/MeasurementCollectionSession">https://saref.etsi.org/saref4ehaw/MeasurementCollectionSession</seealso>
    let MeasurementCollectionSession =
        Prefixed_Name(s4ehaw, "MeasurementCollectionSession") |> PrefixedName

    /// <summary>
    ///   <para>s4ehaw:MobilityImpairment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>s4ehaw:Impairment</para>
    ///   <para>Mobility impairment (User level).</para>
    /// labels<para>Mobility impairment</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/MobilityImpairment">https://saref.etsi.org/saref4ehaw/MobilityImpairment</seealso>
    let MobilityImpairment = Prefixed_Name(s4ehaw, "MobilityImpairment") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:Mode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The dynamic characteristics of a eHealth Device that vary during its lifetime or its BAN lifetime.</para>
    /// labels<para>Mode</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/Mode">https://saref.etsi.org/saref4ehaw/Mode</seealso>
    let Mode = Prefixed_Name(s4ehaw, "Mode") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:OcularImpairment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>s4ehaw:Impairment</para>
    ///   <para>Ocular impairment (User level).</para>
    ///   <para>Ocular impairment (User level), i.e. impamnents of visual acuity.</para>
    /// labels<para>Ocular impairment</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/OcularImpairment">https://saref.etsi.org/saref4ehaw/OcularImpairment</seealso>
    let OcularImpairment = Prefixed_Name(s4ehaw, "OcularImpairment") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:Old</para>
    /// </summary>
    /// <remarks>
    ///   <para>s4ehaw:AgeCategory</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Old, one user age category.</para>
    /// labels<para>Old</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/Old">https://saref.etsi.org/saref4ehaw/Old</seealso>
    let Old = Prefixed_Name(s4ehaw, "Old") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:Overeating</para>
    /// </summary>
    /// <remarks>
    ///   <para>s4ehaw:Habit</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Overeating habit (User level).</para>
    /// labels<para>Overeating</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/Overeating">https://saref.etsi.org/saref4ehaw/Overeating</seealso>
    let Overeating = Prefixed_Name(s4ehaw, "Overeating") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:Patient</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A user of the type patient, i.e. a cared-for person by one or multiple caregivers.</para>
    /// labels<para>Patient</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/Patient">https://saref.etsi.org/saref4ehaw/Patient</seealso>
    let Patient = Prefixed_Name(s4ehaw, "Patient") |> PrefixedName

    /// <summary>
    ///   <para>s4ehaw:PeriodicBanCommunicationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>BAN communication function way of working of the type periodic.</para>
    /// labels<para>Periodic BAN communication type</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/PeriodicBanCommunicationType">https://saref.etsi.org/saref4ehaw/PeriodicBanCommunicationType</seealso>
    let PeriodicBanCommunicationType =
        Prefixed_Name(s4ehaw, "PeriodicBanCommunicationType") |> PrefixedName

    /// <summary>
    ///   <para>s4ehaw:PervasiveComputing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>s4ehaw:BanApplicationDomain</para>
    ///   <para>Pervasive computing sub-domain for BAN application.</para>
    /// labels<para>Pervasive computing</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/PervasiveComputing">https://saref.etsi.org/saref4ehaw/PervasiveComputing</seealso>
    let PervasiveComputing = Prefixed_Name(s4ehaw, "PervasiveComputing") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:PhysicalLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The physical location, i.e. a postal address and a geolocation when available.</para>
    /// labels<para>Physical location</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/PhysicalLocation">https://saref.etsi.org/saref4ehaw/PhysicalLocation</seealso>
    let PhysicalLocation = Prefixed_Name(s4ehaw, "PhysicalLocation") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:PowerSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The power sources of a health device, mainly describing energy source and battery related capabilities of the health device (number of power source, source type, rechargeable or not...).</para>
    /// labels<para>Power source</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/PowerSource">https://saref.etsi.org/saref4ehaw/PowerSource</seealso>
    let PowerSource = Prefixed_Name(s4ehaw, "PowerSource") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:Prevention</para>
    /// </summary>
    /// <remarks>
    ///   <para>s4ehaw:BanApplicationDomain</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Prevention sub-domain (e.g. preventive health) for BAN application.</para>
    /// labels<para>Prevention</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/Prevention">https://saref.etsi.org/saref4ehaw/Prevention</seealso>
    let Prevention = Prefixed_Name(s4ehaw, "Prevention") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:ResponsibleParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The legal entity responsible for a BAN, i.e. to contact in case of problem.</para>
    /// labels<para>Responsible party</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/ResponsibleParty">https://saref.etsi.org/saref4ehaw/ResponsibleParty</seealso>
    let ResponsibleParty = Prefixed_Name(s4ehaw, "ResponsibleParty") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:Running</para>
    /// </summary>
    /// <remarks>
    ///   <para>s4ehaw:Posture</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Posture of a running user.</para>
    /// labels<para>Running</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/Running">https://saref.etsi.org/saref4ehaw/Running</seealso>
    let Running = Prefixed_Name(s4ehaw, "Running") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:Safety</para>
    /// </summary>
    /// <remarks>
    ///   <para>s4ehaw:BanApplicationDomain</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Safety sub-domain for BAN application.</para>
    /// labels<para>Safety</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/Safety">https://saref.etsi.org/saref4ehaw/Safety</seealso>
    let Safety = Prefixed_Name(s4ehaw, "Safety") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:ServiceGrounding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>How to access the service.</para>
    /// labels<para>Service grounding</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/ServiceGrounding">https://saref.etsi.org/saref4ehaw/ServiceGrounding</seealso>
    let ServiceGrounding = Prefixed_Name(s4ehaw, "ServiceGrounding") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:ServiceProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>How the service works.</para>
    /// labels<para>Service process</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/ServiceProcess">https://saref.etsi.org/saref4ehaw/ServiceProcess</seealso>
    let ServiceProcess = Prefixed_Name(s4ehaw, "ServiceProcess") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:SkeletalImpairment</para>
    /// </summary>
    /// <remarks>
    ///   <para>s4ehaw:Impairment</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Skeletal impairment (User level), e.g. of head and trunk regions, limbs...</para>
    /// labels<para>Skeletal impairment</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/SkeletalImpairment">https://saref.etsi.org/saref4ehaw/SkeletalImpairment</seealso>
    let SkeletalImpairment = Prefixed_Name(s4ehaw, "SkeletalImpairment") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:Smoking</para>
    /// </summary>
    /// <remarks>
    ///   <para>s4ehaw:Habit</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Smoking habit (User level).</para>
    /// labels<para>Smoking</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/Smoking">https://saref.etsi.org/saref4ehaw/Smoking</seealso>
    let Smoking = Prefixed_Name(s4ehaw, "Smoking") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:SportTraining</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>s4ehaw:BanApplicationDomain</para>
    ///   <para>Sport training sub-domain for BAN application.</para>
    /// labels<para>Sport Training</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/SportTraining">https://saref.etsi.org/saref4ehaw/SportTraining</seealso>
    let SportTraining = Prefixed_Name(s4ehaw, "SportTraining") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:Telemedicine</para>
    /// </summary>
    /// <remarks>
    ///   <para>s4ehaw:BanApplicationDomain</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Telemedicine sub-domain for BAN application.</para>
    /// labels<para>Telemedicine</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/Telemedicine">https://saref.etsi.org/saref4ehaw/Telemedicine</seealso>
    let Telemedicine = Prefixed_Name(s4ehaw, "Telemedicine") |> PrefixedName

    /// <summary>
    ///   <para>s4ehaw:TimeSeriesMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A sequence of data in a successive equally spaced points in time. The O&amp;M ontology (ISO 19156) defines Time Series Observation  as an “observation whose result is a time-series”, while both Hl7 aECG and DICOM standards define the Series element as a sequence of data sharing a common frame of reference. In SAREF4health this concept is termed as Time Series Measurements since this sequence of data refers to time series measured by a health device.</para>
    /// labels<para>Time series measurement</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/TimeSeriesMeasurement">https://saref.etsi.org/saref4ehaw/TimeSeriesMeasurement</seealso>
    let TimeSeriesMeasurement =
        Prefixed_Name(s4ehaw, "TimeSeriesMeasurement") |> PrefixedName

    /// <summary>
    ///   <para>s4ehaw:hasValues</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A relationship defining the set of values (an ordered array of numbers) of a certain property, e.g., heart rate. Attention: to assure ordering in the serialization format, it is necessary to use either rdf:Seq (RDF/XML) or @list (JSON-LD).</para>
    /// labels<para>has values</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/hasValues">https://saref.etsi.org/saref4ehaw/hasValues</seealso>
    let hasValues = Prefixed_Name(s4ehaw, "hasValues") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:Undereating</para>
    /// </summary>
    /// <remarks>
    ///   <para>s4ehaw:Habit</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Undereating habit (User level).</para>
    /// labels<para>Undereating</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/Undereating">https://saref.etsi.org/saref4ehaw/Undereating</seealso>
    let Undereating = Prefixed_Name(s4ehaw, "Undereating") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:ValidityConstraint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Data may have validity constraint such as allowable value range.</para>
    /// labels<para>Validity constraint</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/ValidityConstraint">https://saref.etsi.org/saref4ehaw/ValidityConstraint</seealso>
    let ValidityConstraint = Prefixed_Name(s4ehaw, "ValidityConstraint") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:Walking</para>
    /// </summary>
    /// <remarks>
    ///   <para>s4ehaw:Posture</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Posture of a walking user.</para>
    /// labels<para>Walking</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/Walking">https://saref.etsi.org/saref4ehaw/Walking</seealso>
    let Walking = Prefixed_Name(s4ehaw, "Walking") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:Young</para>
    /// </summary>
    /// <remarks>
    ///   <para>s4ehaw:AgeCategory</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Young, one user age category.</para>
    /// labels<para>Young</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/Young">https://saref.etsi.org/saref4ehaw/Young</seealso>
    let Young = Prefixed_Name(s4ehaw, "Young") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:activityDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The duration of an activity, in second.</para>
    /// labels<para>activity duration</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/activityDuration">https://saref.etsi.org/saref4ehaw/activityDuration</seealso>
    let activityDuration = Prefixed_Name(s4ehaw, "activityDuration") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:activityKind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The kind of atcivities that a patient or a user can have, i.e. e.g. sleeping in bed, sitting on a chair, using the shower, etc.</para>
    /// labels<para>activity kind</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/activityKind">https://saref.etsi.org/saref4ehaw/activityKind</seealso>
    let activityKind = Prefixed_Name(s4ehaw, "activityKind") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:availableFlash</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The available flash memory (in byte) of a health device. It is a dynamic attribute.</para>
    /// labels<para>available flash</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/availableFlash">https://saref.etsi.org/saref4ehaw/availableFlash</seealso>
    let availableFlash = Prefixed_Name(s4ehaw, "availableFlash") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:availableRam</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates the available volatile memory space (in byte) of a health device. It is a dynamic attribute.</para>
    /// labels<para>available ram</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/availableRam">https://saref.etsi.org/saref4ehaw/availableRam</seealso>
    let availableRam = Prefixed_Name(s4ehaw, "availableRam") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:banDensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The BAN density, i.e. its number of node.</para>
    /// labels<para>BAN density</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/banDensity">https://saref.etsi.org/saref4ehaw/banDensity</seealso>
    let banDensity = Prefixed_Name(s4ehaw, "banDensity") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:banGeolocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The geolocation of the BAN, when available and needed, shall be given relatively to the current location - geolocation as standardized ISO 6709, e.g. +40.75-074.00/  - of the patient wearing the BAN.</para>
    /// labels<para>BAN geolocation</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/banGeolocation">https://saref.etsi.org/saref4ehaw/banGeolocation</seealso>
    let banGeolocation = Prefixed_Name(s4ehaw, "banGeolocation") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:banTopology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The BAN physical topology type, i.e Adhoc or Star or Mesh or Others.</para>
    /// labels<para>BAN topology</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/banTopology">https://saref.etsi.org/saref4ehaw/banTopology</seealso>
    let banTopology = Prefixed_Name(s4ehaw, "banTopology") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:dataSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The data size represents the size of the data in bytes</para>
    /// labels<para>data size</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/dataSize">https://saref.etsi.org/saref4ehaw/dataSize</seealso>
    let dataSize = Prefixed_Name(s4ehaw, "dataSize") |> PrefixedName

    /// <summary>
    ///   <para>s4ehaw:deviceCharacteristicName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The commercial name of a device.</para>
    /// labels<para>device characteristic name</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/deviceCharacteristicName">https://saref.etsi.org/saref4ehaw/deviceCharacteristicName</seealso>
    let deviceCharacteristicName =
        Prefixed_Name(s4ehaw, "deviceCharacteristicName") |> PrefixedName

    /// <summary>
    ///   <para>s4ehaw:dimension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The dimension of the device i.e. height*weight*length string.</para>
    /// labels<para>dimension</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/dimension">https://saref.etsi.org/saref4ehaw/dimension</seealso>
    let dimension = Prefixed_Name(s4ehaw, "dimension") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:dob</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The date of birth of a health actor.</para>
    /// labels<para>date of birth</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/dob">https://saref.etsi.org/saref4ehaw/dob</seealso>
    let dob = Prefixed_Name(s4ehaw, "dob") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:faultTolerence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Defines the error rate tolerated for a measurement function.</para>
    /// labels<para>fault tolerence</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/faultTolerence">https://saref.etsi.org/saref4ehaw/faultTolerence</seealso>
    let faultTolerence = Prefixed_Name(s4ehaw, "faultTolerence") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:firstName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The first name of a health actor.</para>
    /// labels<para>first name</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/firstName">https://saref.etsi.org/saref4ehaw/firstName</seealso>
    let firstName = Prefixed_Name(s4ehaw, "firstName") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:followsUser</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A helper may follow one or multiple users that can in particular be patients.</para>
    /// labels<para>follows user</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/followsUser">https://saref.etsi.org/saref4ehaw/followsUser</seealso>
    let followsUser = Prefixed_Name(s4ehaw, "followsUser") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:format</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The format is a URI for a standard format like e.g. integer.</para>
    /// labels<para>format</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/format">https://saref.etsi.org/saref4ehaw/format</seealso>
    let format = Prefixed_Name(s4ehaw, "format") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:frequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The frequency is the number of instructions an embedded processor - within a health device - can perform per second (MIPS).</para>
    /// labels<para>frequency</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/frequency">https://saref.etsi.org/saref4ehaw/frequency</seealso>
    let frequency = Prefixed_Name(s4ehaw, "frequency") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:geolocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The geolocation, when available, shall be given relatively to the current location - geolocation as standardized ISO 6709, e.g. +40.75-074.00/ -.</para>
    /// labels<para>geolocation</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/geolocation">https://saref.etsi.org/saref4ehaw/geolocation</seealso>
    let geolocation = Prefixed_Name(s4ehaw, "geolocation") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:groundingProtocol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The grounding protocol is the protocol used to transmit the message by the service, e.g. BLE.</para>
    /// labels<para>grounding protocol</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/groundingProtocol">https://saref.etsi.org/saref4ehaw/groundingProtocol</seealso>
    let groundingProtocol = Prefixed_Name(s4ehaw, "groundingProtocol") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:hasActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A health actor may have one or multiple activities.</para>
    /// labels<para>has activity</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/hasActivity">https://saref.etsi.org/saref4ehaw/hasActivity</seealso>
    let hasActivity = Prefixed_Name(s4ehaw, "hasActivity") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:hasAgeCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The age group of a health actor, e.g. old or young.</para>
    /// labels<para>has age category</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/hasAgeCategory">https://saref.etsi.org/saref4ehaw/hasAgeCategory</seealso>
    let hasAgeCategory = Prefixed_Name(s4ehaw, "hasAgeCategory") |> PrefixedName

    /// <summary>
    ///   <para>s4ehaw:hasBanApplicationDomain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The BAN application domain - healthcare, telemedicine, assisted living, sport training, pervasive computing, safety and emergency... -.</para>
    /// labels<para>has BAN application domain</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/hasBanApplicationDomain">https://saref.etsi.org/saref4ehaw/hasBanApplicationDomain</seealso>
    let hasBanApplicationDomain =
        Prefixed_Name(s4ehaw, "hasBanApplicationDomain") |> PrefixedName

    /// <summary>
    ///   <para>s4ehaw:hasBanCommunicationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A BAN has a BAN communication type that is the type of communication carried out between BAN devices and BAN Hub.</para>
    /// labels<para>has BAN communication type</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/hasBanCommunicationType">https://saref.etsi.org/saref4ehaw/hasBanCommunicationType</seealso>
    let hasBanCommunicationType =
        Prefixed_Name(s4ehaw, "hasBanCommunicationType") |> PrefixedName

    /// <summary>
    ///   <para>s4ehaw:hasCalculationMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The service process has a calculation method to get the output or result, e.g. the calculation formula to determine the posture of a patient.</para>
    /// labels<para>has calculation method</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/hasCalculationMethod">https://saref.etsi.org/saref4ehaw/hasCalculationMethod</seealso>
    let hasCalculationMethod =
        Prefixed_Name(s4ehaw, "hasCalculationMethod") |> PrefixedName

    /// <summary>
    ///   <para>s4ehaw:hasChronicDisease</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A patient can suffer from one or more chronic disease like Diabetes, azma, etc.</para>
    /// labels<para>has chronic disease</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/hasChronicDisease">https://saref.etsi.org/saref4ehaw/hasChronicDisease</seealso>
    let hasChronicDisease = Prefixed_Name(s4ehaw, "hasChronicDisease") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:hasComputingPower</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A health device characteristic describing the processing power or capabilities of the device (e.g. processor ID and manufacturer, duty cycle, available flash/RM memory, maximum flash/RAM memory...).</para>
    /// labels<para>has computing power</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/hasComputingPower">https://saref.etsi.org/saref4ehaw/hasComputingPower</seealso>
    let hasComputingPower = Prefixed_Name(s4ehaw, "hasComputingPower") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:hasContact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A BAN has one or multiple contacts (e.g. the patient or user that is monitored through this BAN, the caregiver that is using this BAN for monitoring purposes).</para>
    /// labels<para>has contact</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/hasContact">https://saref.etsi.org/saref4ehaw/hasContact</seealso>
    let hasContact = Prefixed_Name(s4ehaw, "hasContact") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:hasData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A function has one or many data, for example a tracking function shall include latitude, longitude and speed data.</para>
    /// labels<para>has data</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/hasData">https://saref.etsi.org/saref4ehaw/hasData</seealso>
    let hasData = Prefixed_Name(s4ehaw, "hasData") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:hasDataConstraint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Data has data constraints (validity, legal...).</para>
    /// labels<para>has data constraint</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/hasDataConstraint">https://saref.etsi.org/saref4ehaw/hasDataConstraint</seealso>
    let hasDataConstraint = Prefixed_Name(s4ehaw, "hasDataConstraint") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:hasGender</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The gender of a health actor.</para>
    /// labels<para>has gender</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/hasGender">https://saref.etsi.org/saref4ehaw/hasGender</seealso>
    let hasGender = Prefixed_Name(s4ehaw, "hasGender") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:hasHabit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The habits of a user and a patient (as sub-class of user it also inherits habit), e.g. smoking or overeating.</para>
    /// labels<para>has habit</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/hasHabit">https://saref.etsi.org/saref4ehaw/hasHabit</seealso>
    let hasHabit = Prefixed_Name(s4ehaw, "hasHabit") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:hasHub</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A Body Area Network or BAN elects one hub that mainly plays the role of both a data concentrator and a network gateway.</para>
    /// labels<para>has hub</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/hasHub">https://saref.etsi.org/saref4ehaw/hasHub</seealso>
    let hasHub = Prefixed_Name(s4ehaw, "hasHub") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:hasImpairment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The impairment type of a user and a patient (as sub-class of user it also inherits impairment), e.g. aural, skeletal, ocular, mobility, intellectual...</para>
    /// labels<para>has impairment</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/hasImpairment">https://saref.etsi.org/saref4ehaw/hasImpairment</seealso>
    let hasImpairment = Prefixed_Name(s4ehaw, "hasImpairment") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:hasInput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The service process has data input like e.g. the patient ID, the timestamp, the read value from a sensor...</para>
    /// labels<para>has input</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/hasInput">https://saref.etsi.org/saref4ehaw/hasInput</seealso>
    let hasInput = Prefixed_Name(s4ehaw, "hasInput") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:hasInterface</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A health device has one or multiple interfaces (Bluetooth, UWB, IEEE 802.15.6, serial interface...).</para>
    /// labels<para>has interface</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/hasInterface">https://saref.etsi.org/saref4ehaw/hasInterface</seealso>
    let hasInterface = Prefixed_Name(s4ehaw, "hasInterface") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:hasLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The location of an eHealth device, i.e. its position against the body (on body surface or in the body - implant -) and its physical location (i.e. its postal address and/or its current geolocation geolocation when available).</para>
    /// labels<para>has location</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/hasLocation">https://saref.etsi.org/saref4ehaw/hasLocation</seealso>
    let hasLocation = Prefixed_Name(s4ehaw, "hasLocation") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:hasMbox</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>An email address (or mail box) of an health actor: a URI with the 'mailto' scheme as defined by RFC 6068.</para>
    /// labels<para>has mbox</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/hasMbox">https://saref.etsi.org/saref4ehaw/hasMbox</seealso>
    let hasMbox = Prefixed_Name(s4ehaw, "hasMbox") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:hasMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Defines the relationship between data that has measurement.</para>
    /// labels<para>has measurement</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/hasMeasurement">https://saref.etsi.org/saref4ehaw/hasMeasurement</seealso>
    let hasMeasurement = Prefixed_Name(s4ehaw, "hasMeasurement") |> PrefixedName
    /// <summary>
    ///   <para>s4ehaw:hasMode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Each device has modes of operations that model its dynamic characteristic varying during its lifetime, e.g. active, hold, beacon...</para>
    /// labels<para>has mode</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ehaw/hasMode">https://saref.etsi.org/saref4ehaw/hasMode</seealso>
    let hasMode = Prefixed_Name(s4ehaw, "hasMode") |> PrefixedName
