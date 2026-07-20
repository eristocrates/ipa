namespace https.saref.etsi.org.saref4ehaw.slash

open DoxAletheia

module s4ehaw =
    let _namespace_name = "https://saref.etsi.org/saref4ehaw/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://saref.etsi.org/saref4ehaw/v1.1.1/"></see>
    /// </summary>
    let ``v1.1.1/`` = _prefix "v1.1.1/"
    /// <summary>
    /// The activity of a patient/user, i.e. daily and nocturnal activities.
    /// <see href="https://saref.etsi.org/saref4ehaw/Activity"></see></summary>
    let Activity = _prefix "Activity"
    /// <summary>
    /// The age group of a health actor, e.g. old or young.
    /// <see href="https://saref.etsi.org/saref4ehaw/AgeCategory"></see></summary>
    let AgeCategory = _prefix "AgeCategory"
    /// <summary>
    /// A command corresponding to alarm sending.
    /// <see href="https://saref.etsi.org/saref4ehaw/AlarmCommand"></see></summary>
    let AlarmCommand = _prefix "AlarmCommand"
    /// <summary>
    /// Alcohol drinking habit (User level).
    /// <see href="https://saref.etsi.org/saref4ehaw/AlcoholDrinking"></see></summary>
    let AlcoholDrinking = _prefix "AlcoholDrinking"
    /// <summary>
    /// Defined for users (that can in particular be patients) habits modelling, e.g. smoking, alcohol drinking, overeating, undereating...
    /// <see href="https://saref.etsi.org/saref4ehaw/Habit"></see></summary>
    let Habit = _prefix "Habit"
    /// <summary>
    /// Armpit location, a user body surface location.
    /// <see href="https://saref.etsi.org/saref4ehaw/ArmpitLocation"></see></summary>
    let ArmpitLocation = _prefix "ArmpitLocation"
    /// <summary>
    /// Defines a health device location in terms of a body surface position (i.e. on body health device).
    /// <see href="https://saref.etsi.org/saref4ehaw/BodySurfaceLocation"></see></summary>
    let BodySurfaceLocation = _prefix "BodySurfaceLocation"
    /// <summary>
    /// Assisted living sub-domain for BAN application.
    /// <see href="https://saref.etsi.org/saref4ehaw/AssistedLiving"></see></summary>
    let AssistedLiving = _prefix "AssistedLiving"
    /// <summary>
    /// The BAN application domain, e.g. healthcare, telemedicine, assisted living, sport training, safety and emergency...
    /// <see href="https://saref.etsi.org/saref4ehaw/BanApplicationDomain"></see></summary>
    let BanApplicationDomain = _prefix "BanApplicationDomain"
    /// <summary>
    /// Asthma, a chronical disease that some users can have.
    /// <see href="https://saref.etsi.org/saref4ehaw/Asthma"></see></summary>
    let Asthma = _prefix "Asthma"
    /// <summary>
    /// For chronic disease modelling, e.g. diabetes, asthma...
    /// <see href="https://saref.etsi.org/saref4ehaw/ChronicDisease"></see></summary>
    let ChronicDisease = _prefix "ChronicDisease"
    /// <summary>
    /// Aural impairment (User level), i.e. impairments of auditory sensitivity.
    /// <see href="https://saref.etsi.org/saref4ehaw/AuralImpairment"></see></summary>
    let AuralImpairment = _prefix "AuralImpairment"
    /// <summary>
    /// Defined for users (that can in particular be patients) impairments modelling, e.g. aural impairment, skeletal impairment, ocular impairment, mobility impairment, intellectual impairment. Those non exhaustive impairments are compatible with the World Health Organization classification.
    /// <see href="https://saref.etsi.org/saref4ehaw/Impairment"></see></summary>
    let Impairment = _prefix "Impairment"
    /// <summary>
    /// Body Area Network.
    /// <see href="https://saref.etsi.org/saref4ehaw/Ban"></see></summary>
    let Ban = _prefix "Ban"
    /// <summary>
    /// The BAN communication function type, i.e. periodic, event driven or on request.
    /// <see href="https://saref.etsi.org/saref4ehaw/BanCommunicationType"></see></summary>
    let BanCommunicationType = _prefix "BanCommunicationType"
    /// <summary>
    /// Hub of the BAN, mainly playing the role of both a data concentrator and a network gateway.
    /// <see href="https://saref.etsi.org/saref4ehaw/BanHub"></see></summary>
    let BanHub = _prefix "BanHub"
    /// <summary>
    /// Health devices, e.g. BAN hub, health sensor/actuator/Wereable.
    /// <see href="https://saref.etsi.org/saref4ehaw/HealthDevice"></see></summary>
    let HealthDevice = _prefix "HealthDevice"
    /// <summary>
    /// The location, i.e. a position against the body (on - body surface – or in the body – implant –) and a physical location (i.e. a postal address and/or a current geolocation when available).
    /// <see href="https://saref.etsi.org/saref4ehaw/Location"></see></summary>
    let Location = _prefix "Location"
    /// <summary>
    /// For caregivers modelling.
    /// <see href="https://saref.etsi.org/saref4ehaw/Caregiver"></see></summary>
    let Caregiver = _prefix "Caregiver"
    /// <summary>
    /// The eHealth actors like e.g. caregivers, patients, users, helpers...
    /// <see href="https://saref.etsi.org/saref4ehaw/HealthActor"></see></summary>
    let HealthActor = _prefix "HealthActor"
    /// <summary>
    /// The communication protocol, e.g. BLE, serial, Ethernet...
    /// <see href="https://saref.etsi.org/saref4ehaw/CommunicationProtocol"></see></summary>
    let CommunicationProtocol = _prefix "CommunicationProtocol"
    /// <summary>
    /// The computing power capabilities of a Health device.
    /// <see href="https://saref.etsi.org/saref4ehaw/ComputingPower"></see></summary>
    let ComputingPower = _prefix "ComputingPower"
    /// <summary>
    /// A BAN has one or multiple contacts, i.e. some health actors, e.g. the patient or user that is monitored through this BAN, the caregiver that is using this BAN for monitoring purposes...
    /// <see href="https://saref.etsi.org/saref4ehaw/Contact"></see></summary>
    let Contact = _prefix "Contact"
    /// <summary>
    /// The patient/user activities that occur during daytime.
    /// <see href="https://saref.etsi.org/saref4ehaw/DailyActivity"></see></summary>
    let DailyActivity = _prefix "DailyActivity"
    /// <summary>
    /// A function has one or many data, for example a tracking function shall include latitude, longitude and speed data.
    /// <see href="https://saref.etsi.org/saref4ehaw/Data"></see></summary>
    let Data = _prefix "Data"
    /// <summary>
    /// The Data constraints, e.g. validity, legal...
    /// <see href="https://saref.etsi.org/saref4ehaw/DataConstraint"></see></summary>
    let DataConstraint = _prefix "DataConstraint"
    /// <summary>
    /// A health device has device characteristic describing the physical characteristics of the health device.
    /// <see href="https://saref.etsi.org/saref4ehaw/DeviceCharacteristic"></see></summary>
    let DeviceCharacteristic = _prefix "DeviceCharacteristic"
    /// <summary>
    /// Diabetes, a chronical disease that some users can have.
    /// <see href="https://saref.etsi.org/saref4ehaw/Diabetes"></see></summary>
    let Diabetes = _prefix "Diabetes"
    /// <summary>
    /// Emergency sub-domain for BAN application.
    /// <see href="https://saref.etsi.org/saref4ehaw/Emergency"></see></summary>
    let Emergency = _prefix "Emergency"
    /// <summary>
    /// BAN communication function way of working of the type event driven.
    /// <see href="https://saref.etsi.org/saref4ehaw/EventDrivenBanCommunicationType"></see></summary>
    let EventDrivenBanCommunicationType = _prefix "EventDrivenBanCommunicationType"
    /// <summary>
    /// Posture of user doing exercises.
    /// <see href="https://saref.etsi.org/saref4ehaw/Exercising"></see></summary>
    let Exercising = _prefix "Exercising"
    /// <summary>
    /// The posture of a health actor (mainly a patient or a user), e.g. exercising, lying, running, sitting, walking...
    /// <see href="https://saref.etsi.org/saref4ehaw/Posture"></see></summary>
    let Posture = _prefix "Posture"
    /// <summary>
    /// Functional Devices are non-purely eHealth/ageing-well devices that can be used for modelling/detecting activities or behaviours of patients/users, like for example beacons that can detect indoor positioning of a patient in a house.
    /// <see href="https://saref.etsi.org/saref4ehaw/FunctionalDevice"></see></summary>
    let FunctionalDevice = _prefix "FunctionalDevice"
    /// <summary>
    /// Health-related Actuator, equivalent to SAREF Actuator.
    /// <see href="https://saref.etsi.org/saref4ehaw/HealthActuator"></see></summary>
    let HealthActuator = _prefix "HealthActuator"
    /// <summary>
    /// Health-related Sensor, equivalent to SAREF Sensor.
    /// <see href="https://saref.etsi.org/saref4ehaw/HealthSensor"></see></summary>
    let HealthSensor = _prefix "HealthSensor"
    /// <summary>
    /// Health-related Wearable, equivalent to SAREF4WEAR Wearable.
    /// <see href="https://saref.etsi.org/saref4ehaw/HealthWearable"></see></summary>
    let HealthWearable = _prefix "HealthWearable"
    /// <summary>
    /// Healthcare domain for BAN application.
    /// <see href="https://saref.etsi.org/saref4ehaw/Healthcare"></see></summary>
    let Healthcare = _prefix "Healthcare"
    /// <summary>
    /// Helper of patients/users, e.g. a patient's relative.
    /// <see href="https://saref.etsi.org/saref4ehaw/Helper"></see></summary>
    let Helper = _prefix "Helper"
    /// <summary>
    /// Implant Device (i.e. in body health device) position.
    /// <see href="https://saref.etsi.org/saref4ehaw/ImplantLocation"></see></summary>
    let ImplantLocation = _prefix "ImplantLocation"
    /// <summary>
    /// Skeletal impairment (User level), e.g. ...
    /// <see href="https://saref.etsi.org/saref4ehaw/IntellectualImpairment"></see></summary>
    let IntellectualImpairment = _prefix "IntellectualImpairment"
    /// <summary>
    /// Used for modelling the interfaces of a health device (e.g. Bluetooth, UWB, IEEE 802.15.6, serial interface...).
    /// <see href="https://saref.etsi.org/saref4ehaw/Interface"></see></summary>
    let Interface = _prefix "Interface"
    /// <summary>
    /// An empty container for describing the legal constraints a data can be submitted to, like e.g. anonymization.
    /// <see href="https://saref.etsi.org/saref4ehaw/LegalConstraint"></see></summary>
    let LegalConstraint = _prefix "LegalConstraint"
    /// <summary>
    /// Posture of a lying user.
    /// <see href="https://saref.etsi.org/saref4ehaw/Lying"></see></summary>
    let Lying = _prefix "Lying"
    /// <summary>
    /// Task in which a health actor (mainly a patient or a user) is subject of measurement collection (recording) by both some measurement-related health Device (e.g. Sensor, Wearable, ECG Device...) and a health actor (mainly a caregiver).
    /// <see href="https://saref.etsi.org/saref4ehaw/MeasurementCollectionSession"></see></summary>
    let MeasurementCollectionSession = _prefix "MeasurementCollectionSession"
    /// <summary>
    /// The functionality necessary to accomplish the measurement task for which a measurement-related health Device (e.g. Sensor, Wearable, ECG Device...) is designed for, e.g. a heart rate measurement function.
    /// <see href="https://saref.etsi.org/saref4ehaw/MeasurementFunction"></see></summary>
    let MeasurementFunction = _prefix "MeasurementFunction"
    /// <summary>
    /// Mobility impairment (User level).
    /// <see href="https://saref.etsi.org/saref4ehaw/MobilityImpairment"></see></summary>
    let MobilityImpairment = _prefix "MobilityImpairment"
    /// <summary>
    /// The dynamic characteristics of a eHealth Device that vary during its lifetime or its BAN lifetime.
    /// <see href="https://saref.etsi.org/saref4ehaw/Mode"></see></summary>
    let Mode = _prefix "Mode"
    /// <summary>
    /// The patient/user activities that occur during the night.
    /// <see href="https://saref.etsi.org/saref4ehaw/NocturnalActivity"></see></summary>
    let NocturnalActivity = _prefix "NocturnalActivity"
    /// <summary>
    /// Ocular impairment (User level), i.e. impamnents of visual acuity.
    /// Ocular impairment (User level).
    /// <see href="https://saref.etsi.org/saref4ehaw/OcularImpairment"></see></summary>
    let OcularImpairment = _prefix "OcularImpairment"
    /// <summary>
    /// Old, one user age category.
    /// <see href="https://saref.etsi.org/saref4ehaw/Old"></see></summary>
    let Old = _prefix "Old"
    /// <summary>
    /// BAN communication function way of working of the type on request.
    /// <see href="https://saref.etsi.org/saref4ehaw/OnRequestBanCommunicationType"></see></summary>
    let OnRequestBanCommunicationType = _prefix "OnRequestBanCommunicationType"
    /// <summary>
    /// An empty container for describing the operating constraints of a device, e.g. recommended humidity and temperature range...
    /// <see href="https://saref.etsi.org/saref4ehaw/OperatingConstraint"></see></summary>
    let OperatingConstraint = _prefix "OperatingConstraint"
    /// <summary>
    /// Overeating habit (User level).
    /// <see href="https://saref.etsi.org/saref4ehaw/Overeating"></see></summary>
    let Overeating = _prefix "Overeating"
    /// <summary>
    /// A user of the type patient, i.e. a cared-for person by one or multiple caregivers.
    /// <see href="https://saref.etsi.org/saref4ehaw/Patient"></see></summary>
    let Patient = _prefix "Patient"
    /// <summary>
    /// A health actor (patient included) that can be equiped with BANs or health devices for monitoring, control, care (specific case of patients) or support purposes.
    /// <see href="https://saref.etsi.org/saref4ehaw/User"></see></summary>
    let User = _prefix "User"
    /// <summary>
    /// BAN communication function way of working of the type periodic.
    /// <see href="https://saref.etsi.org/saref4ehaw/PeriodicBanCommunicationType"></see></summary>
    let PeriodicBanCommunicationType = _prefix "PeriodicBanCommunicationType"
    /// <summary>
    /// Pervasive computing sub-domain for BAN application.
    /// <see href="https://saref.etsi.org/saref4ehaw/PervasiveComputing"></see></summary>
    let PervasiveComputing = _prefix "PervasiveComputing"
    /// <summary>
    /// The physical location, i.e. a postal address and a geolocation when available.
    /// <see href="https://saref.etsi.org/saref4ehaw/PhysicalLocation"></see></summary>
    let PhysicalLocation = _prefix "PhysicalLocation"
    /// <summary>
    /// The power sources of a health device, mainly describing energy source and battery related capabilities of the health device (number of power source, source type, rechargeable or not...).
    /// <see href="https://saref.etsi.org/saref4ehaw/PowerSource"></see></summary>
    let PowerSource = _prefix "PowerSource"
    /// <summary>
    /// Prevention sub-domain (e.g. preventive health) for BAN application.
    /// <see href="https://saref.etsi.org/saref4ehaw/Prevention"></see></summary>
    let Prevention = _prefix "Prevention"
    /// <summary>
    /// Command used for sending reminder notifications to health actors, e.g. patients, users or Caregivers.
    /// <see href="https://saref.etsi.org/saref4ehaw/ReminderCommand"></see></summary>
    let ReminderCommand = _prefix "ReminderCommand"
    /// <summary>
    /// The legal entity responsible for a BAN, i.e. to contact in case of problem.
    /// <see href="https://saref.etsi.org/saref4ehaw/ResponsibleParty"></see></summary>
    let ResponsibleParty = _prefix "ResponsibleParty"
    /// <summary>
    /// Posture of a running user.
    /// <see href="https://saref.etsi.org/saref4ehaw/Running"></see></summary>
    let Running = _prefix "Running"
    /// <summary>
    /// Safety sub-domain for BAN application.
    /// <see href="https://saref.etsi.org/saref4ehaw/Safety"></see></summary>
    let Safety = _prefix "Safety"
    /// <summary>
    /// How to access the service.
    /// <see href="https://saref.etsi.org/saref4ehaw/ServiceGrounding"></see></summary>
    let ServiceGrounding = _prefix "ServiceGrounding"
    /// <summary>
    /// How the service works.
    /// <see href="https://saref.etsi.org/saref4ehaw/ServiceProcess"></see></summary>
    let ServiceProcess = _prefix "ServiceProcess"
    /// <summary>
    /// What the service does.
    /// <see href="https://saref.etsi.org/saref4ehaw/ServiceProfile"></see></summary>
    let ServiceProfile = _prefix "ServiceProfile"
    /// <summary>
    /// Posture of a sitting user.
    /// <see href="https://saref.etsi.org/saref4ehaw/Sitting"></see></summary>
    let Sitting = _prefix "Sitting"
    /// <summary>
    /// Skeletal impairment (User level), e.g. of head and trunk regions, limbs...
    /// <see href="https://saref.etsi.org/saref4ehaw/SkeletalImpairment"></see></summary>
    let SkeletalImpairment = _prefix "SkeletalImpairment"
    /// <summary>
    /// Smoking habit (User level).
    /// <see href="https://saref.etsi.org/saref4ehaw/Smoking"></see></summary>
    let Smoking = _prefix "Smoking"
    /// <summary>
    /// Sport training sub-domain for BAN application.
    /// <see href="https://saref.etsi.org/saref4ehaw/SportTraining"></see></summary>
    let SportTraining = _prefix "SportTraining"
    /// <summary>
    /// Telemedicine sub-domain for BAN application.
    /// <see href="https://saref.etsi.org/saref4ehaw/Telemedicine"></see></summary>
    let Telemedicine = _prefix "Telemedicine"
    /// <summary>
    /// A sequence of data in a successive equally spaced points in time. The O&amp;M ontology (ISO 19156) defines Time Series Observation  as an “observation whose result is a time-series”, while both Hl7 aECG and DICOM standards define the Series element as a sequence of data sharing a common frame of reference. In SAREF4health this concept is termed as Time Series Measurements since this sequence of data refers to time series measured by a health device.
    /// <see href="https://saref.etsi.org/saref4ehaw/TimeSeriesMeasurement"></see></summary>
    let TimeSeriesMeasurement = _prefix "TimeSeriesMeasurement"
    /// <summary>
    /// A relationship defining the set of values (an ordered array of numbers) of a certain property, e.g., heart rate. Attention: to assure ordering in the serialization format, it is necessary to use either rdf:Seq (RDF/XML) or @list (JSON-LD).
    /// <see href="https://saref.etsi.org/saref4ehaw/hasValues"></see></summary>
    let hasValues = _prefix "hasValues"
    /// <summary>
    /// Undereating habit (User level).
    /// <see href="https://saref.etsi.org/saref4ehaw/Undereating"></see></summary>
    let Undereating = _prefix "Undereating"
    /// <summary>
    /// Data may have validity constraint such as allowable value range.
    /// <see href="https://saref.etsi.org/saref4ehaw/ValidityConstraint"></see></summary>
    let ValidityConstraint = _prefix "ValidityConstraint"
    /// <summary>
    /// Posture of a walking user.
    /// <see href="https://saref.etsi.org/saref4ehaw/Walking"></see></summary>
    let Walking = _prefix "Walking"
    /// <summary>
    /// Wrist, a user body surface location.
    /// <see href="https://saref.etsi.org/saref4ehaw/WristLocation"></see></summary>
    let WristLocation = _prefix "WristLocation"
    /// <summary>
    /// Young, one user age category.
    /// <see href="https://saref.etsi.org/saref4ehaw/Young"></see></summary>
    let Young = _prefix "Young"
    /// <summary>
    /// The duration of an activity, in second.
    /// <see href="https://saref.etsi.org/saref4ehaw/activityDuration"></see></summary>
    let activityDuration = _prefix "activityDuration"
    /// <summary>
    /// The kind of atcivities that a patient or a user can have, i.e. e.g. sleeping in bed, sitting on a chair, using the shower, etc.
    /// <see href="https://saref.etsi.org/saref4ehaw/activityKind"></see></summary>
    let activityKind = _prefix "activityKind"
    /// <summary>
    /// The available flash memory (in byte) of a health device. It is a dynamic attribute.
    /// <see href="https://saref.etsi.org/saref4ehaw/availableFlash"></see></summary>
    let availableFlash = _prefix "availableFlash"
    /// <summary>
    /// Indicates the available volatile memory space (in byte) of a health device. It is a dynamic attribute.
    /// <see href="https://saref.etsi.org/saref4ehaw/availableRam"></see></summary>
    let availableRam = _prefix "availableRam"
    /// <summary>
    /// The BAN density, i.e. its number of node.
    /// <see href="https://saref.etsi.org/saref4ehaw/banDensity"></see></summary>
    let banDensity = _prefix "banDensity"
    /// <summary>
    /// The geolocation of the BAN, when available and needed, shall be given relatively to the current location - geolocation as standardized ISO 6709, e.g. +40.75-074.00/  - of the patient wearing the BAN.
    /// <see href="https://saref.etsi.org/saref4ehaw/banGeolocation"></see></summary>
    let banGeolocation = _prefix "banGeolocation"
    /// <summary>
    ///   <see href="https://saref.etsi.org/saref4ehaw/banTopology"></see>
    /// </summary>
    let banTopology = _prefix "banTopology"
    /// <summary>
    /// A Body Area Network or BAN contains one or multiple health devices
    /// <see href="https://saref.etsi.org/saref4ehaw/contains"></see></summary>
    let contains = _prefix "contains"
    /// <summary>
    /// The data size represents the size of the data in bytes
    /// <see href="https://saref.etsi.org/saref4ehaw/dataSize"></see></summary>
    let dataSize = _prefix "dataSize"
    /// <summary>
    /// The commercial name of a device.
    /// <see href="https://saref.etsi.org/saref4ehaw/deviceCharacteristicName"></see></summary>
    let deviceCharacteristicName = _prefix "deviceCharacteristicName"
    /// <summary>
    /// The dimension of the device i.e. height*weight*length string.
    /// <see href="https://saref.etsi.org/saref4ehaw/dimension"></see></summary>
    let dimension = _prefix "dimension"
    /// <summary>
    /// The date of birth of a health actor.
    /// <see href="https://saref.etsi.org/saref4ehaw/dob"></see></summary>
    let dob = _prefix "dob"
    /// <summary>
    /// The duty cycle for each health device embedded processor, in percent.
    /// <see href="https://saref.etsi.org/saref4ehaw/dutyCycle"></see></summary>
    let dutyCycle = _prefix "dutyCycle"
    /// <summary>
    /// Defines the error rate tolerated for a measurement function.
    /// <see href="https://saref.etsi.org/saref4ehaw/faultTolerence"></see></summary>
    let faultTolerence = _prefix "faultTolerence"
    /// <summary>
    /// The first name of a health actor.
    /// <see href="https://saref.etsi.org/saref4ehaw/firstName"></see></summary>
    let firstName = _prefix "firstName"
    /// <summary>
    /// A helper may follow one or multiple users that can in particular be patients.
    /// <see href="https://saref.etsi.org/saref4ehaw/followsUser"></see></summary>
    let followsUser = _prefix "followsUser"
    /// <summary>
    /// The format is a URI for a standard format like e.g. integer.
    /// <see href="https://saref.etsi.org/saref4ehaw/format"></see></summary>
    let format = _prefix "format"
    /// <summary>
    /// The frequency is the number of instructions an embedded processor - within a health device - can perform per second (MIPS).
    /// <see href="https://saref.etsi.org/saref4ehaw/frequency"></see></summary>
    let frequency = _prefix "frequency"
    /// <summary>
    /// The geolocation, when available, shall be given relatively to the current location - geolocation as standardized ISO 6709, e.g. +40.75-074.00/ -.
    /// <see href="https://saref.etsi.org/saref4ehaw/geolocation"></see></summary>
    let geolocation = _prefix "geolocation"
    /// <summary>
    /// The grounding protocol is the protocol used to transmit the message by the service, e.g. BLE.
    /// <see href="https://saref.etsi.org/saref4ehaw/groundingProtocol"></see></summary>
    let groundingProtocol = _prefix "groundingProtocol"
    /// <summary>
    /// A health actor may have one or multiple activities.
    /// <see href="https://saref.etsi.org/saref4ehaw/hasActivity"></see></summary>
    let hasActivity = _prefix "hasActivity"
    /// <summary>
    /// The age group of a health actor, e.g. old or young.
    /// <see href="https://saref.etsi.org/saref4ehaw/hasAgeCategory"></see></summary>
    let hasAgeCategory = _prefix "hasAgeCategory"
    /// <summary>
    /// The BAN application domain - healthcare, telemedicine, assisted living, sport training, pervasive computing, safety and emergency... -.
    /// <see href="https://saref.etsi.org/saref4ehaw/hasBanApplicationDomain"></see></summary>
    let hasBanApplicationDomain = _prefix "hasBanApplicationDomain"
    /// <summary>
    /// A BAN has a BAN communication type that is the type of communication carried out between BAN devices and BAN Hub.
    /// <see href="https://saref.etsi.org/saref4ehaw/hasBanCommunicationType"></see></summary>
    let hasBanCommunicationType = _prefix "hasBanCommunicationType"
    /// <summary>
    /// The service process has a calculation method to get the output or result, e.g. the calculation formula to determine the posture of a patient.
    /// <see href="https://saref.etsi.org/saref4ehaw/hasCalculationMethod"></see></summary>
    let hasCalculationMethod = _prefix "hasCalculationMethod"
    /// <summary>
    /// A patient can suffer from one or more chronic disease like Diabetes, azma, etc.
    /// <see href="https://saref.etsi.org/saref4ehaw/hasChronicDisease"></see></summary>
    let hasChronicDisease = _prefix "hasChronicDisease"
    /// <summary>
    /// A health device characteristic describing the processing power or capabilities of the device (e.g. processor ID and manufacturer, duty cycle, available flash/RM memory, maximum flash/RAM memory...).
    /// <see href="https://saref.etsi.org/saref4ehaw/hasComputingPower"></see></summary>
    let hasComputingPower = _prefix "hasComputingPower"
    /// <summary>
    /// A BAN has one or multiple contacts (e.g. the patient or user that is monitored through this BAN, the caregiver that is using this BAN for monitoring purposes).
    /// <see href="https://saref.etsi.org/saref4ehaw/hasContact"></see></summary>
    let hasContact = _prefix "hasContact"
    /// <summary>
    /// A function has one or many data, for example a tracking function shall include latitude, longitude and speed data.
    /// <see href="https://saref.etsi.org/saref4ehaw/hasData"></see></summary>
    let hasData = _prefix "hasData"
    /// <summary>
    /// Data has data constraints (validity, legal...).
    /// <see href="https://saref.etsi.org/saref4ehaw/hasDataConstraint"></see></summary>
    let hasDataConstraint = _prefix "hasDataConstraint"
    /// <summary>
    /// A health device has device characteristic describing the physical characteristics of the health device, e.g. its dimensions.
    /// <see href="https://saref.etsi.org/saref4ehaw/hasDeviceCharacteristic"></see></summary>
    let hasDeviceCharacteristic = _prefix "hasDeviceCharacteristic"
    /// <summary>
    /// The effect of a service can be an alert, nothing, an activation of another process...
    /// <see href="https://saref.etsi.org/saref4ehaw/hasEffect"></see></summary>
    let hasEffect = _prefix "hasEffect"
    /// <summary>
    /// The gender of a health actor.
    /// <see href="https://saref.etsi.org/saref4ehaw/hasGender"></see></summary>
    let hasGender = _prefix "hasGender"
    /// <summary>
    /// The habits of a user and a patient (as sub-class of user it also inherits habit), e.g. smoking or overeating.
    /// <see href="https://saref.etsi.org/saref4ehaw/hasHabit"></see></summary>
    let hasHabit = _prefix "hasHabit"
    /// <summary>
    /// A Body Area Network or BAN elects one hub that mainly plays the role of both a data concentrator and a network gateway.
    /// <see href="https://saref.etsi.org/saref4ehaw/hasHub"></see></summary>
    let hasHub = _prefix "hasHub"
    /// <summary>
    /// The impairment type of a user and a patient (as sub-class of user it also inherits impairment), e.g. aural, skeletal, ocular, mobility, intellectual...
    /// <see href="https://saref.etsi.org/saref4ehaw/hasImpairment"></see></summary>
    let hasImpairment = _prefix "hasImpairment"
    /// <summary>
    /// The service process has data input like e.g. the patient ID, the timestamp, the read value from a sensor...
    /// <see href="https://saref.etsi.org/saref4ehaw/hasInput"></see></summary>
    let hasInput = _prefix "hasInput"
    /// <summary>
    /// A health device has one or multiple interfaces (Bluetooth, UWB, IEEE 802.15.6, serial interface...).
    /// <see href="https://saref.etsi.org/saref4ehaw/hasInterface"></see></summary>
    let hasInterface = _prefix "hasInterface"
    /// <summary>
    /// The location of an eHealth device, i.e. its position against the body (on body surface or in the body - implant -) and its physical location (i.e. its postal address and/or its current geolocation geolocation when available).
    /// <see href="https://saref.etsi.org/saref4ehaw/hasLocation"></see></summary>
    let hasLocation = _prefix "hasLocation"
    /// <summary>
    /// An email address (or mail box) of an health actor: a URI with the 'mailto' scheme as defined by RFC 6068.
    /// <see href="https://saref.etsi.org/saref4ehaw/hasMbox"></see></summary>
    let hasMbox = _prefix "hasMbox"
    /// <summary>
    /// Defines the relationship between data that has measurement.
    /// <see href="https://saref.etsi.org/saref4ehaw/hasMeasurement"></see></summary>
    let hasMeasurement = _prefix "hasMeasurement"
    /// <summary>
    /// Each device has modes of operations that model its dynamic characteristic varying during its lifetime, e.g. active, hold, beacon...
    /// <see href="https://saref.etsi.org/saref4ehaw/hasMode"></see></summary>
    let hasMode = _prefix "hasMode"
    /// <summary>
    /// The operating constraints of a health device, e.g. recommended humidity and temperature range...
    /// <see href="https://saref.etsi.org/saref4ehaw/hasOperatingConstraint"></see></summary>
    let hasOperatingConstraint = _prefix "hasOperatingConstraint"
    /// <summary>
    /// The output is e.g. the calculated value returned by the process, e.g the posture of a patient.
    /// <see href="https://saref.etsi.org/saref4ehaw/hasOutput"></see></summary>
    let hasOutput = _prefix "hasOutput"
    /// <summary>
    /// A measurement session has health actors as participants (caregiver controling the session, patient monitored during the session).
    /// <see href="https://saref.etsi.org/saref4ehaw/hasParticipant"></see></summary>
    let hasParticipant = _prefix "hasParticipant"
    /// <summary>
    /// A caregiver may have one or multiple patients.
    /// <see href="https://saref.etsi.org/saref4ehaw/hasPatient"></see></summary>
    let hasPatient = _prefix "hasPatient"
    /// <summary>
    /// Defines the physical location of the patient, i.e. its postal address and/or its geolocation (when available).
    /// <see href="https://saref.etsi.org/saref4ehaw/hasPhysicalLocation"></see></summary>
    let hasPhysicalLocation = _prefix "hasPhysicalLocation"
    /// <summary>
    /// The posture of a user and a patient (as sub-class of user it also inherits habit), e.g. exercising, lying, running, sitting, walking...
    /// <see href="https://saref.etsi.org/saref4ehaw/hasPosture"></see></summary>
    let hasPosture = _prefix "hasPosture"
    /// <summary>
    /// A health device characteristic is its  power sources, mainly describing energy source and battery related capabilities of the health device (number of power source, source type, rechargeable or not, available power level...).
    /// <see href="https://saref.etsi.org/saref4ehaw/hasPowerSource"></see></summary>
    let hasPowerSource = _prefix "hasPowerSource"
    /// <summary>
    /// The conditions that are imposed over the inputs of the process and the process must hold to be successufully invoked.
    /// <see href="https://saref.etsi.org/saref4ehaw/hasPrecondition"></see></summary>
    let hasPrecondition = _prefix "hasPrecondition"
    /// <summary>
    /// A BAN that has a responsible party which plays the role of the legal entity responsible for this BAN (e.g. to contact in case of problem). It should be an organization or a person.
    /// <see href="https://saref.etsi.org/saref4ehaw/hasResponsibleParty"></see></summary>
    let hasResponsibleParty = _prefix "hasResponsibleParty"
    /// <summary>
    /// The process can have many results for the same output. Those results may include a message that should be displayed, an alert...
    /// <see href="https://saref.etsi.org/saref4ehaw/hasResult"></see></summary>
    let hasResult = _prefix "hasResult"
    /// <summary>
    /// Data has time series measurements, a sequence taken at successive equally spaced points in time.
    /// <see href="https://saref.etsi.org/saref4ehaw/hasTimeSeriesMesurement"></see></summary>
    let hasTimeSeriesMesurement = _prefix "hasTimeSeriesMesurement"
    /// <summary>
    /// Each eHealth device has modes of operations that model its dynamic characteristic varying during its lifetime, e.g. active, hold, beacon...
    /// <see href="https://saref.etsi.org/saref4ehaw/inCurrentMode"></see></summary>
    let inCurrentMode = _prefix "inCurrentMode"
    /// <summary>
    /// The interface address. The interface may have many addresses like MAC address, IP address or others.
    /// <see href="https://saref.etsi.org/saref4ehaw/interfaceAddress"></see></summary>
    let interfaceAddress = _prefix "interfaceAddress"
    /// <summary>
    /// The interface type description.
    /// <see href="https://saref.etsi.org/saref4ehaw/interfaceDescription"></see></summary>
    let interfaceDescription = _prefix "interfaceDescription"
    /// <summary>
    /// The interface communication protocol can be e.g. BLE, serial, Ethernet...
    /// <see href="https://saref.etsi.org/saref4ehaw/interfaceProtocol"></see></summary>
    let interfaceProtocol = _prefix "interfaceProtocol"
    /// <summary>
    /// A health Device is attached to a health actor such as a patient, a user and or a caregiver.
    /// <see href="https://saref.etsi.org/saref4ehaw/isAttachedTo"></see></summary>
    let isAttachedTo = _prefix "isAttachedTo"
    /// <summary>
    /// Is derived data is a Boolean property to indicate if the data is a row data or a calculated/derived data from other one.
    /// <see href="https://saref.etsi.org/saref4ehaw/isDerivedData"></see></summary>
    let isDerivedData = _prefix "isDerivedData"
    /// <summary>
    /// A service is described by a service process (how the service works).
    /// <see href="https://saref.etsi.org/saref4ehaw/isDescribedBy"></see></summary>
    let isDescribedBy = _prefix "isDescribedBy"
    /// <summary>
    /// This boolean variable indicates if the interface is a gateway or not.
    /// <see href="https://saref.etsi.org/saref4ehaw/isGateway"></see></summary>
    let isGateway = _prefix "isGateway"
    /// <summary>
    /// The familly name of a health actor.
    /// <see href="https://saref.etsi.org/saref4ehaw/lastName"></see></summary>
    let lastName = _prefix "lastName"
    /// <summary>
    /// The latency is the time interval between the stimulation and response of a measurement function (in ms).
    /// <see href="https://saref.etsi.org/saref4ehaw/latency"></see></summary>
    let latency = _prefix "latency"
    /// <summary>
    /// The BAN lifetime (in month), e.g. BAN for entertainment purposes should have a lifetime of weeks or few years whereas BAN dedicated for assisted living or anomaly monitoring should last for many years.
    /// <see href="https://saref.etsi.org/saref4ehaw/lifetime"></see></summary>
    let lifetime = _prefix "lifetime"
    /// <summary>
    /// Indicates the maximum flash memory space (in byte) of a health device.
    /// <see href="https://saref.etsi.org/saref4ehaw/maximumFlash"></see></summary>
    let maximumFlash = _prefix "maximumFlash"
    /// <summary>
    /// Indicates the maximum volatile memory space (in byte) of a health device.
    /// <see href="https://saref.etsi.org/saref4ehaw/maximumRam"></see></summary>
    let maximumRam = _prefix "maximumRam"
    /// <summary>
    /// The maximum allowable value of a measurement.
    /// <see href="https://saref.etsi.org/saref4ehaw/maximumValue"></see></summary>
    let maximumValue = _prefix "maximumValue"
    /// <summary>
    /// The minimum allowable value  of a measurement.
    /// <see href="https://saref.etsi.org/saref4ehaw/minimumValue"></see></summary>
    let minimumValue = _prefix "minimumValue"
    /// <summary>
    /// The mode name of a device, e.g. sleeping.
    /// <see href="https://saref.etsi.org/saref4ehaw/modeName"></see></summary>
    let modeName = _prefix "modeName"
    /// <summary>
    /// The BAN monitors a specific phenomenon (burned calories during exercises, glucose level...).
    /// <see href="https://saref.etsi.org/saref4ehaw/phenomena"></see></summary>
    let phenomena = _prefix "phenomena"
    /// <summary>
    /// The phone number of a health actor, in international format.
    /// <see href="https://saref.etsi.org/saref4ehaw/phone"></see></summary>
    let phone = _prefix "phone"
    /// <summary>
    /// The port number used to offer the service.
    /// <see href="https://saref.etsi.org/saref4ehaw/portNumber"></see></summary>
    let portNumber = _prefix "portNumber"
    /// <summary>
    /// Defines the postal address.
    /// <see href="https://saref.etsi.org/saref4ehaw/postalAddress"></see></summary>
    let postalAddress = _prefix "postalAddress"
    /// <summary>
    /// The type of power source of a health device. It can be solar, battery, electricity...
    /// <see href="https://saref.etsi.org/saref4ehaw/powerSourceType"></see></summary>
    let powerSourceType = _prefix "powerSourceType"
    /// <summary>
    /// Precision refers to the degree of reproducibility of a measured quantity (when the same quantity is measured several times how close are the measurements from each other).
    /// <see href="https://saref.etsi.org/saref4ehaw/precision"></see></summary>
    let precision = _prefix "precision"
    /// <summary>
    /// A service presents a service profile (what the service does).
    /// <see href="https://saref.etsi.org/saref4ehaw/presents"></see></summary>
    let presents = _prefix "presents"
    /// <summary>
    /// This boolean variable indicates if the power source is rechargeable or not, e.g. a rechargeable battery.
    /// <see href="https://saref.etsi.org/saref4ehaw/rechargeable"></see></summary>
    let rechargeable = _prefix "rechargeable"
    /// <summary>
    /// The level of remaining battery (if any : in percent) for a health device. It is a dynamic attribute.
    /// <see href="https://saref.etsi.org/saref4ehaw/remainingBatteryLevel"></see></summary>
    let remainingBatteryLevel = _prefix "remainingBatteryLevel"
    /// <summary>
    /// The sample time of a measurement function (a discrete integer).
    /// <see href="https://saref.etsi.org/saref4ehaw/sampleTime"></see></summary>
    let sampleTime = _prefix "sampleTime"
    /// <summary>
    /// Defines the sending frequency (in ms), at an health device level, in case of pariodic BAN communication type.
    /// <see href="https://saref.etsi.org/saref4ehaw/sendingFrequency"></see></summary>
    let sendingFrequency = _prefix "sendingFrequency"
    /// <summary>
    /// The serial number of a health device.
    /// <see href="https://saref.etsi.org/saref4ehaw/serialNb"></see></summary>
    let serialNb = _prefix "serialNb"
    /// <summary>
    /// The service description should describe the offered service like e.g. heart rate measurement.
    /// <see href="https://saref.etsi.org/saref4ehaw/serviceDescription"></see></summary>
    let serviceDescription = _prefix "serviceDescription"
    /// <summary>
    /// The service name identify the offered service, e.g heart rate.
    /// <see href="https://saref.etsi.org/saref4ehaw/serviceName"></see></summary>
    let serviceName = _prefix "serviceName"
    /// <summary>
    /// A service supports a service grounding (how to access the service).
    /// <see href="https://saref.etsi.org/saref4ehaw/supports"></see></summary>
    let supports = _prefix "supports"
    /// <summary>
    /// The transmission rate of the interface, i.e. the number of bits transmitted per second (usually expressed in kbps or Mbps).
    /// <see href="https://saref.etsi.org/saref4ehaw/transmissionRate"></see></summary>
    let transmissionRate = _prefix "transmissionRate"
    /// <summary>
    /// Defines the unit of measure of a measurement function.
    /// <see href="https://saref.etsi.org/saref4ehaw/uom"></see></summary>
    let uom = _prefix "uom"
    /// <summary>
    /// A health actor (e.g. a caregiver, a patient or a helper) uses a BAN for collecting, aggregating and relaying vital parameters.
    /// <see href="https://saref.etsi.org/saref4ehaw/usesBan"></see></summary>
    let usesBan = _prefix "usesBan"
    /// <summary>
    /// The velocity of a moving device (in m/s).
    /// <see href="https://saref.etsi.org/saref4ehaw/velocity"></see></summary>
    let velocity = _prefix "velocity"
