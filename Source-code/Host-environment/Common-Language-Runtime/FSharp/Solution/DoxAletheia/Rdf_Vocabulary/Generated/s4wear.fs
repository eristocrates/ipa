namespace https.saref.etsi.org.saref4wear.slash

open DoxAletheia

module s4wear =
    let _namespace_name = "https://saref.etsi.org/saref4wear/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A wearable device is a device that is intended to be located near, on or in an organism.
    /// <see href="https://saref.etsi.org/saref4wear/Wearable"></see></summary>
    let Wearable = _prefix "Wearable"
    /// <summary>
    /// An occurrence is the fact of something existing or being found in a place.
    /// <see href="https://saref.etsi.org/saref4wear/Occurrence"></see></summary>
    let Occurrence = _prefix "Occurrence"
    /// <summary>
    ///   <see href="https://saref.etsi.org/saref4wear/v1.1.1/"></see>
    /// </summary>
    let ``v1.1.1/`` = _prefix "v1.1.1/"
    /// <summary>
    /// The acoustic emission of the wearable.
    /// <see href="https://saref.etsi.org/saref4wear/AcousticEmission"></see></summary>
    let AcousticEmission = _prefix "AcousticEmission"
    /// <summary>
    /// Class to group those emission properties related to wearables.
    /// <see href="https://saref.etsi.org/saref4wear/EmissionProperty"></see></summary>
    let EmissionProperty = _prefix "EmissionProperty"
    /// <summary>
    /// The quality of air in the environment.
    /// <see href="https://saref.etsi.org/saref4wear/AirQuality"></see></summary>
    let AirQuality = _prefix "AirQuality"
    /// <summary>
    /// Class to group those properties related to the environment of a wearer.
    /// <see href="https://saref.etsi.org/saref4wear/EnvironmentalProperty"></see></summary>
    let EnvironmentalProperty = _prefix "EnvironmentalProperty"
    /// <summary>
    /// The time until the battery of the wearable is discharged.
    /// <see href="https://saref.etsi.org/saref4wear/BatteryRemainingTime"></see></summary>
    let BatteryRemainingTime = _prefix "BatteryRemainingTime"
    /// <summary>
    /// Class to group those electrical properties related to wearables.
    /// <see href="https://saref.etsi.org/saref4wear/ElectricalProperty"></see></summary>
    let ElectricalProperty = _prefix "ElectricalProperty"
    /// <summary>
    /// Class to group those properties related to the biometric characteristics of wearers.
    /// <see href="https://saref.etsi.org/saref4wear/BiometricProperty"></see></summary>
    let BiometricProperty = _prefix "BiometricProperty"
    /// <summary>
    /// Class to group those properties related to wearers.
    /// <see href="https://saref.etsi.org/saref4wear/WearerProperty"></see></summary>
    let WearerProperty = _prefix "WearerProperty"
    /// <summary>
    /// A function that allows a device to communicate with another device.
    /// <see href="https://saref.etsi.org/saref4wear/CommunicatingFunction"></see></summary>
    let CommunicatingFunction = _prefix "CommunicatingFunction"
    /// <summary>
    /// A function that allows to control a device from another device.
    /// <see href="https://saref.etsi.org/saref4wear/ControllingFunction"></see></summary>
    let ControllingFunction = _prefix "ControllingFunction"
    /// <summary>
    /// Class to group those properties related to crowds.
    /// <see href="https://saref.etsi.org/saref4wear/CrowdProperty"></see></summary>
    let CrowdProperty = _prefix "CrowdProperty"
    /// <summary>
    /// The size of a crowd.
    /// <see href="https://saref.etsi.org/saref4wear/CrowdSize"></see></summary>
    let CrowdSize = _prefix "CrowdSize"
    /// <summary>
    /// Class to group those properties related to wearables.
    /// <see href="https://saref.etsi.org/saref4wear/WearableProperty"></see></summary>
    let WearableProperty = _prefix "WearableProperty"
    /// <summary>
    /// Class to group those electrical safety properties related to wearables.
    /// <see href="https://saref.etsi.org/saref4wear/ElectricalSafetyProperty"></see></summary>
    let ElectricalSafetyProperty = _prefix "ElectricalSafetyProperty"
    /// <summary>
    /// A fabric wearable is a fabric integrating the sensors directly into its fibers.
    /// <see href="https://saref.etsi.org/saref4wear/FabricWearable"></see></summary>
    let FabricWearable = _prefix "FabricWearable"
    /// <summary>
    /// A textile-based wearable is a wearable directly integrated into a textile artifact.
    /// <see href="https://saref.etsi.org/saref4wear/TextileBasedWearable"></see></summary>
    let TextileBasedWearable = _prefix "TextileBasedWearable"
    /// <summary>
    /// The heart rate of the wearer.
    /// <see href="https://saref.etsi.org/saref4wear/HeartRate"></see></summary>
    let HeartRate = _prefix "HeartRate"
    /// <summary>
    /// The heat emission of the wearable.
    /// <see href="https://saref.etsi.org/saref4wear/HeatEmission"></see></summary>
    let HeatEmission = _prefix "HeatEmission"
    /// <summary>
    /// An in-body wearable is a wearable located inside a physical body.
    /// <see href="https://saref.etsi.org/saref4wear/InBodyWearable"></see></summary>
    let InBodyWearable = _prefix "InBodyWearable"
    /// <summary>
    /// A wearer is any living organism that is sensed by a wearable.
    /// <see href="https://saref.etsi.org/saref4wear/Wearer"></see></summary>
    let Wearer = _prefix "Wearer"
    /// <summary>
    /// A relationship specifying the location of a wearer with respect to an in-body wearable.
    /// <see href="https://saref.etsi.org/saref4wear/isLocatedIn"></see></summary>
    let isLocatedIn = _prefix "isLocatedIn"
    /// <summary>
    /// An interface is the mechanism with which a device can receive or transmit data to another device.
    /// <see href="https://saref.etsi.org/saref4wear/Interface"></see></summary>
    let Interface = _prefix "Interface"
    /// <summary>
    /// A living organism is any entity composed of cells.
    /// <see href="https://saref.etsi.org/saref4wear/LivingOrganism"></see></summary>
    let LivingOrganism = _prefix "LivingOrganism"
    /// <summary>
    /// A memory storage is an hardware component intended to store data within the device.
    /// <see href="https://saref.etsi.org/saref4wear/MemoryStorage"></see></summary>
    let MemoryStorage = _prefix "MemoryStorage"
    /// <summary>
    /// A function that allows a device to provide navigation information.
    /// <see href="https://saref.etsi.org/saref4wear/NavigatingFunction"></see></summary>
    let NavigatingFunction = _prefix "NavigatingFunction"
    /// <summary>
    /// A near-body wearable is a wearable located near a physical body.
    /// <see href="https://saref.etsi.org/saref4wear/NearBodyWearable"></see></summary>
    let NearBodyWearable = _prefix "NearBodyWearable"
    /// <summary>
    /// A relationship specifying the location of a wearer with respect to an near-body wearable.
    /// <see href="https://saref.etsi.org/saref4wear/isLocatedNear"></see></summary>
    let isLocatedNear = _prefix "isLocatedNear"
    /// <summary>
    /// The place where an occurrence takes place.
    /// <see href="https://saref.etsi.org/saref4wear/takesPlaceAt"></see></summary>
    let takesPlaceAt = _prefix "takesPlaceAt"
    /// <summary>
    /// An on-body wearable is a wearable having a direct contact with a physical body.
    /// <see href="https://saref.etsi.org/saref4wear/OnBodyWearable"></see></summary>
    let OnBodyWearable = _prefix "OnBodyWearable"
    /// <summary>
    /// A relationship specifying the location of a wearer with respect to an on-body wearable.
    /// <see href="https://saref.etsi.org/saref4wear/isLocatedOn"></see></summary>
    let isLocatedOn = _prefix "isLocatedOn"
    /// <summary>
    /// A policy is a set of guidelines adopted during the wearable building process and defining how a wearables operates.
    /// <see href="https://saref.etsi.org/saref4wear/Policy"></see></summary>
    let Policy = _prefix "Policy"
    /// <summary>
    /// A power supply is an hardware component intended to plug a device to a power grid.
    /// <see href="https://saref.etsi.org/saref4wear/PowerSupply"></see></summary>
    let PowerSupply = _prefix "PowerSupply"
    /// <summary>
    /// The size of a queue.
    /// <see href="https://saref.etsi.org/saref4wear/QueueSize"></see></summary>
    let QueueSize = _prefix "QueueSize"
    /// <summary>
    /// The radio frequency emission of the wearable.
    /// <see href="https://saref.etsi.org/saref4wear/RadioFrequencyEmission"></see></summary>
    let RadioFrequencyEmission = _prefix "RadioFrequencyEmission"
    /// <summary>
    /// A software is a computer program.
    /// <see href="https://saref.etsi.org/saref4wear/Software"></see></summary>
    let Software = _prefix "Software"
    /// <summary>
    /// The level of sound in the environment.
    /// <see href="https://saref.etsi.org/saref4wear/SoundLevel"></see></summary>
    let SoundLevel = _prefix "SoundLevel"
    /// <summary>
    /// The temperature of the environment.
    /// <see href="https://saref.etsi.org/saref4wear/Temperature"></see></summary>
    let Temperature = _prefix "Temperature"
    /// <summary>
    /// A textile-based sensor is a sensor directly integrated into a textile artifact.
    /// <see href="https://saref.etsi.org/saref4wear/TextileBasedSensor"></see></summary>
    let TextileBasedSensor = _prefix "TextileBasedSensor"
    /// <summary>
    /// A user is an entity using a wearable.
    /// <see href="https://saref.etsi.org/saref4wear/User"></see></summary>
    let User = _prefix "User"
    /// <summary>
    /// A relationship specifying the devices that measure a feature of interest.
    /// <see href="https://saref.etsi.org/saref4wear/featureIsMeasuredByDevice"></see></summary>
    let featureIsMeasuredByDevice = _prefix "featureIsMeasuredByDevice"
    /// <summary>
    /// The temperature of the wearer.
    /// <see href="https://saref.etsi.org/saref4wear/WearerTemperature"></see></summary>
    let WearerTemperature = _prefix "WearerTemperature"
    /// <summary>
    /// A relationship specifying the features of interest that are controlled by a device.
    /// <see href="https://saref.etsi.org/saref4wear/controlsFeature"></see></summary>
    let controlsFeature = _prefix "controlsFeature"
    /// <summary>
    /// A relationship specifying the devices that control a feature of interest.
    /// <see href="https://saref.etsi.org/saref4wear/featureIsControlledByDevice"></see></summary>
    let featureIsControlledByDevice = _prefix "featureIsControlledByDevice"
    /// <summary>
    /// A relationship specifying the policy followed by a wearable device.
    /// <see href="https://saref.etsi.org/saref4wear/followsPolicy"></see></summary>
    let followsPolicy = _prefix "followsPolicy"
    /// <summary>
    /// A relationship defining the capacity of a facility.
    /// <see href="https://saref.etsi.org/saref4wear/hasCapacity"></see></summary>
    let hasCapacity = _prefix "hasCapacity"
    /// <summary>
    /// A relationship defining a command triggered by an actuating function.
    /// <see href="https://saref.etsi.org/saref4wear/hasCommand"></see></summary>
    let hasCommand = _prefix "hasCommand"
    /// <summary>
    /// A relationship defining the data transmission rate of a wearable.
    /// <see href="https://saref.etsi.org/saref4wear/hasDataTransmissionRate"></see></summary>
    let hasDataTransmissionRate = _prefix "hasDataTransmissionRate"
    /// <summary>
    /// A relationship defining the height dimension of a wearable.
    /// <see href="https://saref.etsi.org/saref4wear/hasHeight"></see></summary>
    let hasHeight = _prefix "hasHeight"
    /// <summary>
    /// A relationship specifying the interface with which a device is equipped.
    /// <see href="https://saref.etsi.org/saref4wear/hasInterface"></see></summary>
    let hasInterface = _prefix "hasInterface"
    /// <summary>
    /// A relationship defining the length dimension of a wearable.
    /// <see href="https://saref.etsi.org/saref4wear/hasLength"></see></summary>
    let hasLength = _prefix "hasLength"
    /// <summary>
    /// A relationship specifying the type of power supply equipping a device.
    /// <see href="https://saref.etsi.org/saref4wear/hasPowerSupply"></see></summary>
    let hasPowerSupply = _prefix "hasPowerSupply"
    /// <summary>
    /// A relationship specifying a sensor integrated into a device.
    /// <see href="https://saref.etsi.org/saref4wear/hasSensor"></see></summary>
    let hasSensor = _prefix "hasSensor"
    /// <summary>
    /// A relationship defining the storage capacity of a wearable.
    /// <see href="https://saref.etsi.org/saref4wear/hasStorage"></see></summary>
    let hasStorage = _prefix "hasStorage"
    /// <summary>
    /// A relationship defining the weight of a wearable device.
    /// <see href="https://saref.etsi.org/saref4wear/hasWeight"></see></summary>
    let hasWeight = _prefix "hasWeight"
    /// <summary>
    /// A relationship defining the width dimention of a wearable.
    /// <see href="https://saref.etsi.org/saref4wear/hasWidth"></see></summary>
    let hasWidth = _prefix "hasWidth"
    /// <summary>
    /// A relationship specifying in which facility a device has been installed.
    /// <see href="https://saref.etsi.org/saref4wear/installs"></see></summary>
    let installs = _prefix "installs"
    /// <summary>
    /// A relationship specifying the interaction between a user and a device.
    /// <see href="https://saref.etsi.org/saref4wear/interactsWith"></see></summary>
    let interactsWith = _prefix "interactsWith"
    /// <summary>
    /// Defines the relationship between an occurrence and the device detecting it.
    /// <see href="https://saref.etsi.org/saref4wear/isDetectedBy"></see></summary>
    let isDetectedBy = _prefix "isDetectedBy"
    /// <summary>
    /// A relationship specifying the location of a wearer with respect to a wearable.
    /// <see href="https://saref.etsi.org/saref4wear/isLocated"></see></summary>
    let isLocated = _prefix "isLocated"
    /// <summary>
    /// A relationship specifying the function actuating the work of a device.
    /// <see href="https://saref.etsi.org/saref4wear/isTriggeredBy"></see></summary>
    let isTriggeredBy = _prefix "isTriggeredBy"
    /// <summary>
    /// A relationship specifying the function actuating the work of a device.
    /// <see href="https://saref.etsi.org/saref4wear/triggers"></see></summary>
    let triggers = _prefix "triggers"
    /// <summary>
    /// A relationship stating the means of transport on which the wearable is operating.
    /// <see href="https://saref.etsi.org/saref4wear/meansOfTransport"></see></summary>
    let meansOfTransport = _prefix "meansOfTransport"
    /// <summary>
    /// A relationship specifying the features of interest that are measured by a device.
    /// <see href="https://saref.etsi.org/saref4wear/measuresFeature"></see></summary>
    let measuresFeature = _prefix "measuresFeature"
    /// <summary>
    /// A relationship specifying the monitoring activity of a device on another device.
    /// <see href="https://saref.etsi.org/saref4wear/monitors"></see></summary>
    let monitors = _prefix "monitors"
    /// <summary>
    /// A relationship specifying the sending information operation between two wearables.
    /// <see href="https://saref.etsi.org/saref4wear/sendsInformationTo"></see></summary>
    let sendsInformationTo = _prefix "sendsInformationTo"
    /// <summary>
    /// A relationship specifying the sending notification operation between two wearables.
    /// <see href="https://saref.etsi.org/saref4wear/sendsNotificationsTo"></see></summary>
    let sendsNotificationsTo = _prefix "sendsNotificationsTo"
    /// <summary>
    /// A relationship stating the age range of a wearer.
    /// <see href="https://saref.etsi.org/saref4wear/wearerAgeRange"></see></summary>
    let wearerAgeRange = _prefix "wearerAgeRange"
    /// <summary>
    /// A relationship defining the status of a wearer.
    /// <see href="https://saref.etsi.org/saref4wear/wearerStatus"></see></summary>
    let wearerStatus = _prefix "wearerStatus"
