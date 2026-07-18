namespace https.saref.etsi.org.saref4wear.slash

open DoxAletheia.Rdf_Vocabulary

module s4wear =
    let _namespace_name = "https://saref.etsi.org/saref4wear/"
    /// <summary>
    /// A wearable device is a device that is intended to be located near, on or in an organism.
    /// <see href="https://saref.etsi.org/saref4wear/Wearable"></see></summary>
    let Wearable = Namespaced_IRI.parse _namespace_name "Wearable" |> NamespacedName
    /// <summary>
    /// An occurrence is the fact of something existing or being found in a place.
    /// <see href="https://saref.etsi.org/saref4wear/Occurrence"></see></summary>
    let Occurrence = Namespaced_IRI.parse _namespace_name "Occurrence" |> NamespacedName
    /// <summary>
    ///   <see href="https://saref.etsi.org/saref4wear/v1.1.1/"></see>
    /// </summary>
    let ``v1.1.1/`` = Namespaced_IRI.parse _namespace_name "v1.1.1/" |> NamespacedName

    /// <summary>
    /// The acoustic emission of the wearable.
    /// <see href="https://saref.etsi.org/saref4wear/AcousticEmission"></see></summary>
    let AcousticEmission =
        Namespaced_IRI.parse _namespace_name "AcousticEmission" |> NamespacedName

    /// <summary>
    /// Class to group those emission properties related to wearables.
    /// <see href="https://saref.etsi.org/saref4wear/EmissionProperty"></see></summary>
    let EmissionProperty =
        Namespaced_IRI.parse _namespace_name "EmissionProperty" |> NamespacedName

    /// <summary>
    /// The quality of air in the environment.
    /// <see href="https://saref.etsi.org/saref4wear/AirQuality"></see></summary>
    let AirQuality = Namespaced_IRI.parse _namespace_name "AirQuality" |> NamespacedName

    /// <summary>
    /// Class to group those properties related to the environment of a wearer.
    /// <see href="https://saref.etsi.org/saref4wear/EnvironmentalProperty"></see></summary>
    let EnvironmentalProperty =
        Namespaced_IRI.parse _namespace_name "EnvironmentalProperty" |> NamespacedName

    /// <summary>
    /// The time until the battery of the wearable is discharged.
    /// <see href="https://saref.etsi.org/saref4wear/BatteryRemainingTime"></see></summary>
    let BatteryRemainingTime =
        Namespaced_IRI.parse _namespace_name "BatteryRemainingTime" |> NamespacedName

    /// <summary>
    /// Class to group those electrical properties related to wearables.
    /// <see href="https://saref.etsi.org/saref4wear/ElectricalProperty"></see></summary>
    let ElectricalProperty =
        Namespaced_IRI.parse _namespace_name "ElectricalProperty" |> NamespacedName

    /// <summary>
    /// Class to group those properties related to the biometric characteristics of wearers.
    /// <see href="https://saref.etsi.org/saref4wear/BiometricProperty"></see></summary>
    let BiometricProperty =
        Namespaced_IRI.parse _namespace_name "BiometricProperty" |> NamespacedName

    /// <summary>
    /// Class to group those properties related to wearers.
    /// <see href="https://saref.etsi.org/saref4wear/WearerProperty"></see></summary>
    let WearerProperty =
        Namespaced_IRI.parse _namespace_name "WearerProperty" |> NamespacedName

    /// <summary>
    /// A function that allows a device to communicate with another device.
    /// <see href="https://saref.etsi.org/saref4wear/CommunicatingFunction"></see></summary>
    let CommunicatingFunction =
        Namespaced_IRI.parse _namespace_name "CommunicatingFunction" |> NamespacedName

    /// <summary>
    /// A function that allows to control a device from another device.
    /// <see href="https://saref.etsi.org/saref4wear/ControllingFunction"></see></summary>
    let ControllingFunction =
        Namespaced_IRI.parse _namespace_name "ControllingFunction" |> NamespacedName

    /// <summary>
    /// Class to group those properties related to crowds.
    /// <see href="https://saref.etsi.org/saref4wear/CrowdProperty"></see></summary>
    let CrowdProperty =
        Namespaced_IRI.parse _namespace_name "CrowdProperty" |> NamespacedName

    /// <summary>
    /// The size of a crowd.
    /// <see href="https://saref.etsi.org/saref4wear/CrowdSize"></see></summary>
    let CrowdSize = Namespaced_IRI.parse _namespace_name "CrowdSize" |> NamespacedName

    /// <summary>
    /// Class to group those properties related to wearables.
    /// <see href="https://saref.etsi.org/saref4wear/WearableProperty"></see></summary>
    let WearableProperty =
        Namespaced_IRI.parse _namespace_name "WearableProperty" |> NamespacedName

    /// <summary>
    /// Class to group those electrical safety properties related to wearables.
    /// <see href="https://saref.etsi.org/saref4wear/ElectricalSafetyProperty"></see></summary>
    let ElectricalSafetyProperty =
        Namespaced_IRI.parse _namespace_name "ElectricalSafetyProperty" |> NamespacedName

    /// <summary>
    /// A fabric wearable is a fabric integrating the sensors directly into its fibers.
    /// <see href="https://saref.etsi.org/saref4wear/FabricWearable"></see></summary>
    let FabricWearable =
        Namespaced_IRI.parse _namespace_name "FabricWearable" |> NamespacedName

    /// <summary>
    /// A textile-based wearable is a wearable directly integrated into a textile artifact.
    /// <see href="https://saref.etsi.org/saref4wear/TextileBasedWearable"></see></summary>
    let TextileBasedWearable =
        Namespaced_IRI.parse _namespace_name "TextileBasedWearable" |> NamespacedName

    /// <summary>
    /// The heart rate of the wearer.
    /// <see href="https://saref.etsi.org/saref4wear/HeartRate"></see></summary>
    let HeartRate = Namespaced_IRI.parse _namespace_name "HeartRate" |> NamespacedName

    /// <summary>
    /// The heat emission of the wearable.
    /// <see href="https://saref.etsi.org/saref4wear/HeatEmission"></see></summary>
    let HeatEmission =
        Namespaced_IRI.parse _namespace_name "HeatEmission" |> NamespacedName

    /// <summary>
    /// An in-body wearable is a wearable located inside a physical body.
    /// <see href="https://saref.etsi.org/saref4wear/InBodyWearable"></see></summary>
    let InBodyWearable =
        Namespaced_IRI.parse _namespace_name "InBodyWearable" |> NamespacedName

    /// <summary>
    /// A wearer is any living organism that is sensed by a wearable.
    /// <see href="https://saref.etsi.org/saref4wear/Wearer"></see></summary>
    let Wearer = Namespaced_IRI.parse _namespace_name "Wearer" |> NamespacedName

    /// <summary>
    /// A relationship specifying the location of a wearer with respect to an in-body wearable.
    /// <see href="https://saref.etsi.org/saref4wear/isLocatedIn"></see></summary>
    let isLocatedIn =
        Namespaced_IRI.parse _namespace_name "isLocatedIn" |> NamespacedName

    /// <summary>
    /// An interface is the mechanism with which a device can receive or transmit data to another device.
    /// <see href="https://saref.etsi.org/saref4wear/Interface"></see></summary>
    let Interface = Namespaced_IRI.parse _namespace_name "Interface" |> NamespacedName

    /// <summary>
    /// A living organism is any entity composed of cells.
    /// <see href="https://saref.etsi.org/saref4wear/LivingOrganism"></see></summary>
    let LivingOrganism =
        Namespaced_IRI.parse _namespace_name "LivingOrganism" |> NamespacedName

    /// <summary>
    /// A memory storage is an hardware component intended to store data within the device.
    /// <see href="https://saref.etsi.org/saref4wear/MemoryStorage"></see></summary>
    let MemoryStorage =
        Namespaced_IRI.parse _namespace_name "MemoryStorage" |> NamespacedName

    /// <summary>
    /// A function that allows a device to provide navigation information.
    /// <see href="https://saref.etsi.org/saref4wear/NavigatingFunction"></see></summary>
    let NavigatingFunction =
        Namespaced_IRI.parse _namespace_name "NavigatingFunction" |> NamespacedName

    /// <summary>
    /// A near-body wearable is a wearable located near a physical body.
    /// <see href="https://saref.etsi.org/saref4wear/NearBodyWearable"></see></summary>
    let NearBodyWearable =
        Namespaced_IRI.parse _namespace_name "NearBodyWearable" |> NamespacedName

    /// <summary>
    /// A relationship specifying the location of a wearer with respect to an near-body wearable.
    /// <see href="https://saref.etsi.org/saref4wear/isLocatedNear"></see></summary>
    let isLocatedNear =
        Namespaced_IRI.parse _namespace_name "isLocatedNear" |> NamespacedName

    /// <summary>
    /// The place where an occurrence takes place.
    /// <see href="https://saref.etsi.org/saref4wear/takesPlaceAt"></see></summary>
    let takesPlaceAt =
        Namespaced_IRI.parse _namespace_name "takesPlaceAt" |> NamespacedName

    /// <summary>
    /// An on-body wearable is a wearable having a direct contact with a physical body.
    /// <see href="https://saref.etsi.org/saref4wear/OnBodyWearable"></see></summary>
    let OnBodyWearable =
        Namespaced_IRI.parse _namespace_name "OnBodyWearable" |> NamespacedName

    /// <summary>
    /// A relationship specifying the location of a wearer with respect to an on-body wearable.
    /// <see href="https://saref.etsi.org/saref4wear/isLocatedOn"></see></summary>
    let isLocatedOn =
        Namespaced_IRI.parse _namespace_name "isLocatedOn" |> NamespacedName

    /// <summary>
    /// A policy is a set of guidelines adopted during the wearable building process and defining how a wearables operates.
    /// <see href="https://saref.etsi.org/saref4wear/Policy"></see></summary>
    let Policy = Namespaced_IRI.parse _namespace_name "Policy" |> NamespacedName

    /// <summary>
    /// A power supply is an hardware component intended to plug a device to a power grid.
    /// <see href="https://saref.etsi.org/saref4wear/PowerSupply"></see></summary>
    let PowerSupply =
        Namespaced_IRI.parse _namespace_name "PowerSupply" |> NamespacedName

    /// <summary>
    /// The size of a queue.
    /// <see href="https://saref.etsi.org/saref4wear/QueueSize"></see></summary>
    let QueueSize = Namespaced_IRI.parse _namespace_name "QueueSize" |> NamespacedName

    /// <summary>
    /// The radio frequency emission of the wearable.
    /// <see href="https://saref.etsi.org/saref4wear/RadioFrequencyEmission"></see></summary>
    let RadioFrequencyEmission =
        Namespaced_IRI.parse _namespace_name "RadioFrequencyEmission" |> NamespacedName

    /// <summary>
    /// A software is a computer program.
    /// <see href="https://saref.etsi.org/saref4wear/Software"></see></summary>
    let Software = Namespaced_IRI.parse _namespace_name "Software" |> NamespacedName
    /// <summary>
    /// The level of sound in the environment.
    /// <see href="https://saref.etsi.org/saref4wear/SoundLevel"></see></summary>
    let SoundLevel = Namespaced_IRI.parse _namespace_name "SoundLevel" |> NamespacedName

    /// <summary>
    /// The temperature of the environment.
    /// <see href="https://saref.etsi.org/saref4wear/Temperature"></see></summary>
    let Temperature =
        Namespaced_IRI.parse _namespace_name "Temperature" |> NamespacedName

    /// <summary>
    /// A textile-based sensor is a sensor directly integrated into a textile artifact.
    /// <see href="https://saref.etsi.org/saref4wear/TextileBasedSensor"></see></summary>
    let TextileBasedSensor =
        Namespaced_IRI.parse _namespace_name "TextileBasedSensor" |> NamespacedName

    /// <summary>
    /// A user is an entity using a wearable.
    /// <see href="https://saref.etsi.org/saref4wear/User"></see></summary>
    let User = Namespaced_IRI.parse _namespace_name "User" |> NamespacedName

    /// <summary>
    /// A relationship specifying the devices that measure a feature of interest.
    /// <see href="https://saref.etsi.org/saref4wear/featureIsMeasuredByDevice"></see></summary>
    let featureIsMeasuredByDevice =
        Namespaced_IRI.parse _namespace_name "featureIsMeasuredByDevice" |> NamespacedName

    /// <summary>
    /// The temperature of the wearer.
    /// <see href="https://saref.etsi.org/saref4wear/WearerTemperature"></see></summary>
    let WearerTemperature =
        Namespaced_IRI.parse _namespace_name "WearerTemperature" |> NamespacedName

    /// <summary>
    /// A relationship specifying the features of interest that are controlled by a device.
    /// <see href="https://saref.etsi.org/saref4wear/controlsFeature"></see></summary>
    let controlsFeature =
        Namespaced_IRI.parse _namespace_name "controlsFeature" |> NamespacedName

    /// <summary>
    /// A relationship specifying the devices that control a feature of interest.
    /// <see href="https://saref.etsi.org/saref4wear/featureIsControlledByDevice"></see></summary>
    let featureIsControlledByDevice =
        Namespaced_IRI.parse _namespace_name "featureIsControlledByDevice" |> NamespacedName

    /// <summary>
    /// A relationship specifying the policy followed by a wearable device.
    /// <see href="https://saref.etsi.org/saref4wear/followsPolicy"></see></summary>
    let followsPolicy =
        Namespaced_IRI.parse _namespace_name "followsPolicy" |> NamespacedName

    /// <summary>
    /// A relationship defining the capacity of a facility.
    /// <see href="https://saref.etsi.org/saref4wear/hasCapacity"></see></summary>
    let hasCapacity =
        Namespaced_IRI.parse _namespace_name "hasCapacity" |> NamespacedName

    /// <summary>
    /// A relationship defining a command triggered by an actuating function.
    /// <see href="https://saref.etsi.org/saref4wear/hasCommand"></see></summary>
    let hasCommand = Namespaced_IRI.parse _namespace_name "hasCommand" |> NamespacedName

    /// <summary>
    /// A relationship defining the data transmission rate of a wearable.
    /// <see href="https://saref.etsi.org/saref4wear/hasDataTransmissionRate"></see></summary>
    let hasDataTransmissionRate =
        Namespaced_IRI.parse _namespace_name "hasDataTransmissionRate" |> NamespacedName

    /// <summary>
    /// A relationship defining the height dimension of a wearable.
    /// <see href="https://saref.etsi.org/saref4wear/hasHeight"></see></summary>
    let hasHeight = Namespaced_IRI.parse _namespace_name "hasHeight" |> NamespacedName

    /// <summary>
    /// A relationship specifying the interface with which a device is equipped.
    /// <see href="https://saref.etsi.org/saref4wear/hasInterface"></see></summary>
    let hasInterface =
        Namespaced_IRI.parse _namespace_name "hasInterface" |> NamespacedName

    /// <summary>
    /// A relationship defining the length dimension of a wearable.
    /// <see href="https://saref.etsi.org/saref4wear/hasLength"></see></summary>
    let hasLength = Namespaced_IRI.parse _namespace_name "hasLength" |> NamespacedName

    /// <summary>
    /// A relationship specifying the type of power supply equipping a device.
    /// <see href="https://saref.etsi.org/saref4wear/hasPowerSupply"></see></summary>
    let hasPowerSupply =
        Namespaced_IRI.parse _namespace_name "hasPowerSupply" |> NamespacedName

    /// <summary>
    /// A relationship specifying a sensor integrated into a device.
    /// <see href="https://saref.etsi.org/saref4wear/hasSensor"></see></summary>
    let hasSensor = Namespaced_IRI.parse _namespace_name "hasSensor" |> NamespacedName
    /// <summary>
    /// A relationship defining the storage capacity of a wearable.
    /// <see href="https://saref.etsi.org/saref4wear/hasStorage"></see></summary>
    let hasStorage = Namespaced_IRI.parse _namespace_name "hasStorage" |> NamespacedName
    /// <summary>
    /// A relationship defining the weight of a wearable device.
    /// <see href="https://saref.etsi.org/saref4wear/hasWeight"></see></summary>
    let hasWeight = Namespaced_IRI.parse _namespace_name "hasWeight" |> NamespacedName
    /// <summary>
    /// A relationship defining the width dimention of a wearable.
    /// <see href="https://saref.etsi.org/saref4wear/hasWidth"></see></summary>
    let hasWidth = Namespaced_IRI.parse _namespace_name "hasWidth" |> NamespacedName
    /// <summary>
    /// A relationship specifying in which facility a device has been installed.
    /// <see href="https://saref.etsi.org/saref4wear/installs"></see></summary>
    let installs = Namespaced_IRI.parse _namespace_name "installs" |> NamespacedName

    /// <summary>
    /// A relationship specifying the interaction between a user and a device.
    /// <see href="https://saref.etsi.org/saref4wear/interactsWith"></see></summary>
    let interactsWith =
        Namespaced_IRI.parse _namespace_name "interactsWith" |> NamespacedName

    /// <summary>
    /// Defines the relationship between an occurrence and the device detecting it.
    /// <see href="https://saref.etsi.org/saref4wear/isDetectedBy"></see></summary>
    let isDetectedBy =
        Namespaced_IRI.parse _namespace_name "isDetectedBy" |> NamespacedName

    /// <summary>
    /// A relationship specifying the location of a wearer with respect to a wearable.
    /// <see href="https://saref.etsi.org/saref4wear/isLocated"></see></summary>
    let isLocated = Namespaced_IRI.parse _namespace_name "isLocated" |> NamespacedName

    /// <summary>
    /// A relationship specifying the function actuating the work of a device.
    /// <see href="https://saref.etsi.org/saref4wear/isTriggeredBy"></see></summary>
    let isTriggeredBy =
        Namespaced_IRI.parse _namespace_name "isTriggeredBy" |> NamespacedName

    /// <summary>
    /// A relationship specifying the function actuating the work of a device.
    /// <see href="https://saref.etsi.org/saref4wear/triggers"></see></summary>
    let triggers = Namespaced_IRI.parse _namespace_name "triggers" |> NamespacedName

    /// <summary>
    /// A relationship stating the means of transport on which the wearable is operating.
    /// <see href="https://saref.etsi.org/saref4wear/meansOfTransport"></see></summary>
    let meansOfTransport =
        Namespaced_IRI.parse _namespace_name "meansOfTransport" |> NamespacedName

    /// <summary>
    /// A relationship specifying the features of interest that are measured by a device.
    /// <see href="https://saref.etsi.org/saref4wear/measuresFeature"></see></summary>
    let measuresFeature =
        Namespaced_IRI.parse _namespace_name "measuresFeature" |> NamespacedName

    /// <summary>
    /// A relationship specifying the monitoring activity of a device on another device.
    /// <see href="https://saref.etsi.org/saref4wear/monitors"></see></summary>
    let monitors = Namespaced_IRI.parse _namespace_name "monitors" |> NamespacedName

    /// <summary>
    /// A relationship specifying the sending information operation between two wearables.
    /// <see href="https://saref.etsi.org/saref4wear/sendsInformationTo"></see></summary>
    let sendsInformationTo =
        Namespaced_IRI.parse _namespace_name "sendsInformationTo" |> NamespacedName

    /// <summary>
    /// A relationship specifying the sending notification operation between two wearables.
    /// <see href="https://saref.etsi.org/saref4wear/sendsNotificationsTo"></see></summary>
    let sendsNotificationsTo =
        Namespaced_IRI.parse _namespace_name "sendsNotificationsTo" |> NamespacedName

    /// <summary>
    /// A relationship stating the age range of a wearer.
    /// <see href="https://saref.etsi.org/saref4wear/wearerAgeRange"></see></summary>
    let wearerAgeRange =
        Namespaced_IRI.parse _namespace_name "wearerAgeRange" |> NamespacedName

    /// <summary>
    /// A relationship defining the status of a wearer.
    /// <see href="https://saref.etsi.org/saref4wear/wearerStatus"></see></summary>
    let wearerStatus =
        Namespaced_IRI.parse _namespace_name "wearerStatus" |> NamespacedName
