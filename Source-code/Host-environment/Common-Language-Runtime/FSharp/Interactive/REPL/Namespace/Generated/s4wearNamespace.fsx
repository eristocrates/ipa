#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module s4wear =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://saref.etsi.org/saref4wear/" "s4wear"

    let _namespaceIri = _prefixId.prefix ""
    let AcousticEmission = _prefixId.prefix "AcousticEmission"
    let AirQuality = _prefixId.prefix "AirQuality"
    let BatteryRemainingTime = _prefixId.prefix "BatteryRemainingTime"
    /// <summary>
    ///   <para>rdfs:label : Biometric property</para>
    ///   <para>rdfs:comment : Class to group those properties related to the biometric characteristics of wearers.</para>
    ///   <a href="https://saref.etsi.org/saref4wear/BiometricProperty">s4wear:BiometricProperty</a>
    /// </summary>
    let BiometricProperty = _prefixId.prefix "BiometricProperty"
    /// <summary>
    ///   <para>rdfs:label : Communicating function</para>
    ///   <para>rdfs:comment : A function that allows a device to communicate with another device.</para>
    ///   <a href="https://saref.etsi.org/saref4wear/CommunicatingFunction">s4wear:CommunicatingFunction</a>
    /// </summary>
    let CommunicatingFunction = _prefixId.prefix "CommunicatingFunction"
    /// <summary>
    ///   <para>rdfs:label : Controlling function</para>
    ///   <para>rdfs:comment : A function that allows to control a device from another device.</para>
    ///   <a href="https://saref.etsi.org/saref4wear/ControllingFunction">s4wear:ControllingFunction</a>
    /// </summary>
    let ControllingFunction = _prefixId.prefix "ControllingFunction"
    /// <summary>
    ///   <para>rdfs:label : Crowd property</para>
    ///   <para>rdfs:comment : Class to group those properties related to crowds.</para>
    ///   <a href="https://saref.etsi.org/saref4wear/CrowdProperty">s4wear:CrowdProperty</a>
    /// </summary>
    let CrowdProperty = _prefixId.prefix "CrowdProperty"
    let CrowdSize = _prefixId.prefix "CrowdSize"
    /// <summary>
    ///   <para>rdfs:label : Electrical property</para>
    ///   <para>rdfs:comment : Class to group those electrical properties related to wearables.</para>
    ///   <a href="https://saref.etsi.org/saref4wear/ElectricalProperty">s4wear:ElectricalProperty</a>
    /// </summary>
    let ElectricalProperty = _prefixId.prefix "ElectricalProperty"
    /// <summary>
    ///   <para>rdfs:label : Electrical safety property</para>
    ///   <para>rdfs:comment : Class to group those electrical safety properties related to wearables.</para>
    ///   <a href="https://saref.etsi.org/saref4wear/ElectricalSafetyProperty">s4wear:ElectricalSafetyProperty</a>
    /// </summary>
    let ElectricalSafetyProperty = _prefixId.prefix "ElectricalSafetyProperty"
    /// <summary>
    ///   <para>rdfs:label : Emission property</para>
    ///   <para>rdfs:comment : Class to group those emission properties related to wearables.</para>
    ///   <a href="https://saref.etsi.org/saref4wear/EmissionProperty">s4wear:EmissionProperty</a>
    /// </summary>
    let EmissionProperty = _prefixId.prefix "EmissionProperty"
    /// <summary>
    ///   <para>rdfs:label : Environmental property</para>
    ///   <para>rdfs:comment : Class to group those properties related to the environment of a wearer.</para>
    ///   <a href="https://saref.etsi.org/saref4wear/EnvironmentalProperty">s4wear:EnvironmentalProperty</a>
    /// </summary>
    let EnvironmentalProperty = _prefixId.prefix "EnvironmentalProperty"
    /// <summary>
    ///   <para>rdfs:label : Fabric wearable</para>
    ///   <para>rdfs:comment : A fabric wearable is a fabric integrating the sensors directly into its fibers.</para>
    ///   <a href="https://saref.etsi.org/saref4wear/FabricWearable">s4wear:FabricWearable</a>
    /// </summary>
    let FabricWearable = _prefixId.prefix "FabricWearable"
    let HeartRate = _prefixId.prefix "HeartRate"
    let HeatEmission = _prefixId.prefix "HeatEmission"
    /// <summary>
    ///   <para>rdfs:label : In-body wearable</para>
    ///   <para>rdfs:comment : An in-body wearable is a wearable located inside a physical body.</para>
    ///   <a href="https://saref.etsi.org/saref4wear/InBodyWearable">s4wear:InBodyWearable</a>
    /// </summary>
    let InBodyWearable = _prefixId.prefix "InBodyWearable"
    /// <summary>
    ///   <para>rdfs:label : Interface</para>
    ///   <para>rdfs:comment : An interface is the mechanism with which a device can receive or transmit data to another device.</para>
    ///   <a href="https://saref.etsi.org/saref4wear/Interface">s4wear:Interface</a>
    /// </summary>
    let Interface = _prefixId.prefix "Interface"
    /// <summary>
    ///   <para>rdfs:label : Living organism</para>
    ///   <para>rdfs:comment : A living organism is any entity composed of cells.</para>
    ///   <a href="https://saref.etsi.org/saref4wear/LivingOrganism">s4wear:LivingOrganism</a>
    /// </summary>
    let LivingOrganism = _prefixId.prefix "LivingOrganism"
    /// <summary>
    ///   <para>rdfs:label : Memory storage</para>
    ///   <para>rdfs:comment : A memory storage is an hardware component intended to store data within the device.</para>
    ///   <a href="https://saref.etsi.org/saref4wear/MemoryStorage">s4wear:MemoryStorage</a>
    /// </summary>
    let MemoryStorage = _prefixId.prefix "MemoryStorage"
    /// <summary>
    ///   <para>rdfs:label : Navigating function</para>
    ///   <para>rdfs:comment : A function that allows a device to provide navigation information.</para>
    ///   <a href="https://saref.etsi.org/saref4wear/NavigatingFunction">s4wear:NavigatingFunction</a>
    /// </summary>
    let NavigatingFunction = _prefixId.prefix "NavigatingFunction"
    /// <summary>
    ///   <para>rdfs:label : Near-body wearable</para>
    ///   <para>rdfs:comment : A near-body wearable is a wearable located near a physical body.</para>
    ///   <a href="https://saref.etsi.org/saref4wear/NearBodyWearable">s4wear:NearBodyWearable</a>
    /// </summary>
    let NearBodyWearable = _prefixId.prefix "NearBodyWearable"
    /// <summary>
    ///   <para>rdfs:label : Occurrence</para>
    ///   <para>rdfs:comment : An occurrence is the fact of something existing or being found in a place.</para>
    ///   <a href="https://saref.etsi.org/saref4wear/Occurrence">s4wear:Occurrence</a>
    /// </summary>
    let Occurrence = _prefixId.prefix "Occurrence"
    /// <summary>
    ///   <para>rdfs:label : On-body wearable</para>
    ///   <para>rdfs:comment : An on-body wearable is a wearable having a direct contact with a physical body.</para>
    ///   <a href="https://saref.etsi.org/saref4wear/OnBodyWearable">s4wear:OnBodyWearable</a>
    /// </summary>
    let OnBodyWearable = _prefixId.prefix "OnBodyWearable"
    /// <summary>
    ///   <para>rdfs:label : Policy</para>
    ///   <para>rdfs:comment : A policy is a set of guidelines adopted during the wearable building process and defining how a wearables operates.</para>
    ///   <a href="https://saref.etsi.org/saref4wear/Policy">s4wear:Policy</a>
    /// </summary>
    let Policy = _prefixId.prefix "Policy"
    /// <summary>
    ///   <para>rdfs:label : Power supply</para>
    ///   <para>rdfs:comment : A power supply is an hardware component intended to plug a device to a power grid.</para>
    ///   <a href="https://saref.etsi.org/saref4wear/PowerSupply">s4wear:PowerSupply</a>
    /// </summary>
    let PowerSupply = _prefixId.prefix "PowerSupply"
    let QueueSize = _prefixId.prefix "QueueSize"
    let RadioFrequencyEmission = _prefixId.prefix "RadioFrequencyEmission"
    /// <summary>
    ///   <para>rdfs:label : Software</para>
    ///   <para>rdfs:comment : A software is a computer program.</para>
    ///   <a href="https://saref.etsi.org/saref4wear/Software">s4wear:Software</a>
    /// </summary>
    let Software = _prefixId.prefix "Software"
    let SoundLevel = _prefixId.prefix "SoundLevel"
    let Temperature = _prefixId.prefix "Temperature"
    /// <summary>
    ///   <para>rdfs:label : Textile-based sensor</para>
    ///   <para>rdfs:comment : A textile-based sensor is a sensor directly integrated into a textile artifact.</para>
    ///   <a href="https://saref.etsi.org/saref4wear/TextileBasedSensor">s4wear:TextileBasedSensor</a>
    /// </summary>
    let TextileBasedSensor = _prefixId.prefix "TextileBasedSensor"
    /// <summary>
    ///   <para>rdfs:label : Textile-based wearable</para>
    ///   <para>rdfs:comment : A textile-based wearable is a wearable directly integrated into a textile artifact.</para>
    ///   <a href="https://saref.etsi.org/saref4wear/TextileBasedWearable">s4wear:TextileBasedWearable</a>
    /// </summary>
    let TextileBasedWearable = _prefixId.prefix "TextileBasedWearable"
    /// <summary>
    ///   <para>rdfs:label : User</para>
    ///   <para>rdfs:comment : A user is an entity using a wearable.</para>
    ///   <a href="https://saref.etsi.org/saref4wear/User">s4wear:User</a>
    /// </summary>
    let User = _prefixId.prefix "User"
    /// <summary>
    ///   <para>rdfs:label : Wearable device</para>
    ///   <para>rdfs:comment : A wearable device is a device that is intended to be located near, on or in an organism.</para>
    ///   <a href="https://saref.etsi.org/saref4wear/Wearable">s4wear:Wearable</a>
    /// </summary>
    let Wearable = _prefixId.prefix "Wearable"
    /// <summary>
    ///   <para>rdfs:label : Wearable property</para>
    ///   <para>rdfs:comment : Class to group those properties related to wearables.</para>
    ///   <a href="https://saref.etsi.org/saref4wear/WearableProperty">s4wear:WearableProperty</a>
    /// </summary>
    let WearableProperty = _prefixId.prefix "WearableProperty"
    /// <summary>
    ///   <para>rdfs:label : Wearer</para>
    ///   <para>rdfs:comment : A wearer is any living organism that is sensed by a wearable.</para>
    ///   <a href="https://saref.etsi.org/saref4wear/Wearer">s4wear:Wearer</a>
    /// </summary>
    let Wearer = _prefixId.prefix "Wearer"
    /// <summary>
    ///   <para>rdfs:label : Wearer property</para>
    ///   <para>rdfs:comment : Class to group those properties related to wearers.</para>
    ///   <a href="https://saref.etsi.org/saref4wear/WearerProperty">s4wear:WearerProperty</a>
    /// </summary>
    let WearerProperty = _prefixId.prefix "WearerProperty"
    let WearerTemperature = _prefixId.prefix "WearerTemperature"
    /// <summary>
    ///   <para>rdfs:label : controls feature</para>
    ///   <para>rdfs:comment : A relationship specifying the features of interest that are controlled by a device.</para>
    ///   <a href="https://saref.etsi.org/saref4wear/controlsFeature">s4wear:controlsFeature</a>
    /// </summary>
    let controlsFeature = _prefixId.prefix "controlsFeature"
    /// <summary>
    ///   <para>rdfs:label : feature is controlled by device</para>
    ///   <para>rdfs:comment : A relationship specifying the devices that control a feature of interest.</para>
    ///   <a href="https://saref.etsi.org/saref4wear/featureIsControlledByDevice">s4wear:featureIsControlledByDevice</a>
    /// </summary>
    let featureIsControlledByDevice = _prefixId.prefix "featureIsControlledByDevice"
    /// <summary>
    ///   <para>rdfs:label : feature is measured by device</para>
    ///   <para>rdfs:comment : A relationship specifying the devices that measure a feature of interest.</para>
    ///   <a href="https://saref.etsi.org/saref4wear/featureIsMeasuredByDevice">s4wear:featureIsMeasuredByDevice</a>
    /// </summary>
    let featureIsMeasuredByDevice = _prefixId.prefix "featureIsMeasuredByDevice"
    /// <summary>
    ///   <para>rdfs:label : follows policy</para>
    ///   <para>rdfs:comment : A relationship specifying the policy followed by a wearable device.</para>
    ///   <a href="https://saref.etsi.org/saref4wear/followsPolicy">s4wear:followsPolicy</a>
    /// </summary>
    let followsPolicy = _prefixId.prefix "followsPolicy"
    /// <summary>
    ///   <para>rdfs:label : has capacity</para>
    ///   <para>rdfs:comment : A relationship defining the capacity of a facility.</para>
    ///   <a href="https://saref.etsi.org/saref4wear/hasCapacity">s4wear:hasCapacity</a>
    /// </summary>
    let hasCapacity = _prefixId.prefix "hasCapacity"
    /// <summary>
    ///   <para>rdfs:label : has command</para>
    ///   <para>rdfs:comment : A relationship defining a command triggered by an actuating function.</para>
    ///   <a href="https://saref.etsi.org/saref4wear/hasCommand">s4wear:hasCommand</a>
    /// </summary>
    let hasCommand = _prefixId.prefix "hasCommand"
    /// <summary>
    ///   <para>rdfs:label : has data transmission rate</para>
    ///   <para>rdfs:comment : A relationship defining the data transmission rate of a wearable.</para>
    ///   <a href="https://saref.etsi.org/saref4wear/hasDataTransmissionRate">s4wear:hasDataTransmissionRate</a>
    /// </summary>
    let hasDataTransmissionRate = _prefixId.prefix "hasDataTransmissionRate"
    /// <summary>
    ///   <para>rdfs:label : has height</para>
    ///   <para>rdfs:comment : A relationship defining the height dimension of a wearable.</para>
    ///   <a href="https://saref.etsi.org/saref4wear/hasHeight">s4wear:hasHeight</a>
    /// </summary>
    let hasHeight = _prefixId.prefix "hasHeight"
    /// <summary>
    ///   <para>rdfs:label : has interface</para>
    ///   <para>rdfs:comment : A relationship specifying the interface with which a device is equipped.</para>
    ///   <a href="https://saref.etsi.org/saref4wear/hasInterface">s4wear:hasInterface</a>
    /// </summary>
    let hasInterface = _prefixId.prefix "hasInterface"
    /// <summary>
    ///   <para>rdfs:label : has length</para>
    ///   <para>rdfs:comment : A relationship defining the length dimension of a wearable.</para>
    ///   <a href="https://saref.etsi.org/saref4wear/hasLength">s4wear:hasLength</a>
    /// </summary>
    let hasLength = _prefixId.prefix "hasLength"
    /// <summary>
    ///   <para>rdfs:label : has power supply</para>
    ///   <para>rdfs:comment : A relationship specifying the type of power supply equipping a device.</para>
    ///   <a href="https://saref.etsi.org/saref4wear/hasPowerSupply">s4wear:hasPowerSupply</a>
    /// </summary>
    let hasPowerSupply = _prefixId.prefix "hasPowerSupply"
    /// <summary>
    ///   <para>rdfs:label : has sensor</para>
    ///   <para>rdfs:comment : A relationship specifying a sensor integrated into a device.</para>
    ///   <a href="https://saref.etsi.org/saref4wear/hasSensor">s4wear:hasSensor</a>
    /// </summary>
    let hasSensor = _prefixId.prefix "hasSensor"
    /// <summary>
    ///   <para>rdfs:label : has storage</para>
    ///   <para>rdfs:comment : A relationship defining the storage capacity of a wearable.</para>
    ///   <a href="https://saref.etsi.org/saref4wear/hasStorage">s4wear:hasStorage</a>
    /// </summary>
    let hasStorage = _prefixId.prefix "hasStorage"
    /// <summary>
    ///   <para>rdfs:label : has weight</para>
    ///   <para>rdfs:comment : A relationship defining the weight of a wearable device.</para>
    ///   <a href="https://saref.etsi.org/saref4wear/hasWeight">s4wear:hasWeight</a>
    /// </summary>
    let hasWeight = _prefixId.prefix "hasWeight"
    /// <summary>
    ///   <para>rdfs:label : has width</para>
    ///   <para>rdfs:comment : A relationship defining the width dimention of a wearable.</para>
    ///   <a href="https://saref.etsi.org/saref4wear/hasWidth">s4wear:hasWidth</a>
    /// </summary>
    let hasWidth = _prefixId.prefix "hasWidth"
    /// <summary>
    ///   <para>rdfs:label : installs</para>
    ///   <para>rdfs:comment : A relationship specifying in which facility a device has been installed.</para>
    ///   <a href="https://saref.etsi.org/saref4wear/installs">s4wear:installs</a>
    /// </summary>
    let installs = _prefixId.prefix "installs"
    /// <summary>
    ///   <para>rdfs:label : interacts with</para>
    ///   <para>rdfs:comment : A relationship specifying the interaction between a user and a device.</para>
    ///   <a href="https://saref.etsi.org/saref4wear/interactsWith">s4wear:interactsWith</a>
    /// </summary>
    let interactsWith = _prefixId.prefix "interactsWith"
    /// <summary>
    ///   <para>rdfs:label : is detected by</para>
    ///   <para>rdfs:comment : Defines the relationship between an occurrence and the device detecting it.^^xsd:string</para>
    ///   <a href="https://saref.etsi.org/saref4wear/isDetectedBy">s4wear:isDetectedBy</a>
    /// </summary>
    let isDetectedBy = _prefixId.prefix "isDetectedBy"
    /// <summary>
    ///   <para>rdfs:label : is located</para>
    ///   <para>rdfs:comment : A relationship specifying the location of a wearer with respect to a wearable.</para>
    ///   <a href="https://saref.etsi.org/saref4wear/isLocated">s4wear:isLocated</a>
    /// </summary>
    let isLocated = _prefixId.prefix "isLocated"
    /// <summary>
    ///   <para>rdfs:label : is located in</para>
    ///   <para>rdfs:comment : A relationship specifying the location of a wearer with respect to an in-body wearable.</para>
    ///   <a href="https://saref.etsi.org/saref4wear/isLocatedIn">s4wear:isLocatedIn</a>
    /// </summary>
    let isLocatedIn = _prefixId.prefix "isLocatedIn"
    /// <summary>
    ///   <para>rdfs:label : is located near</para>
    ///   <para>rdfs:comment : A relationship specifying the location of a wearer with respect to an near-body wearable.</para>
    ///   <a href="https://saref.etsi.org/saref4wear/isLocatedNear">s4wear:isLocatedNear</a>
    /// </summary>
    let isLocatedNear = _prefixId.prefix "isLocatedNear"
    /// <summary>
    ///   <para>rdfs:label : is located on</para>
    ///   <para>rdfs:comment : A relationship specifying the location of a wearer with respect to an on-body wearable.</para>
    ///   <a href="https://saref.etsi.org/saref4wear/isLocatedOn">s4wear:isLocatedOn</a>
    /// </summary>
    let isLocatedOn = _prefixId.prefix "isLocatedOn"
    /// <summary>
    ///   <para>rdfs:label : is triggered by</para>
    ///   <para>rdfs:comment : A relationship specifying the function actuating the work of a device.</para>
    ///   <a href="https://saref.etsi.org/saref4wear/isTriggeredBy">s4wear:isTriggeredBy</a>
    /// </summary>
    let isTriggeredBy = _prefixId.prefix "isTriggeredBy"
    /// <summary>
    ///   <para>rdfs:label : means of transport</para>
    ///   <para>rdfs:comment : A relationship stating the means of transport on which the wearable is operating.</para>
    ///   <a href="https://saref.etsi.org/saref4wear/meansOfTransport">s4wear:meansOfTransport</a>
    /// </summary>
    let meansOfTransport = _prefixId.prefix "meansOfTransport"
    /// <summary>
    ///   <para>rdfs:label : measures feature</para>
    ///   <para>rdfs:comment : A relationship specifying the features of interest that are measured by a device.</para>
    ///   <a href="https://saref.etsi.org/saref4wear/measuresFeature">s4wear:measuresFeature</a>
    /// </summary>
    let measuresFeature = _prefixId.prefix "measuresFeature"
    /// <summary>
    ///   <para>rdfs:label : monitors</para>
    ///   <para>rdfs:comment : A relationship specifying the monitoring activity of a device on another device.</para>
    ///   <a href="https://saref.etsi.org/saref4wear/monitors">s4wear:monitors</a>
    /// </summary>
    let monitors = _prefixId.prefix "monitors"
    /// <summary>
    ///   <para>rdfs:label : sends information to</para>
    ///   <para>rdfs:comment : A relationship specifying the sending information operation between two wearables.</para>
    ///   <a href="https://saref.etsi.org/saref4wear/sendsInformationTo">s4wear:sendsInformationTo</a>
    /// </summary>
    let sendsInformationTo = _prefixId.prefix "sendsInformationTo"
    /// <summary>
    ///   <para>rdfs:label : sends notifications to</para>
    ///   <para>rdfs:comment : A relationship specifying the sending notification operation between two wearables.</para>
    ///   <a href="https://saref.etsi.org/saref4wear/sendsNotificationsTo">s4wear:sendsNotificationsTo</a>
    /// </summary>
    let sendsNotificationsTo = _prefixId.prefix "sendsNotificationsTo"
    /// <summary>
    ///   <para>rdfs:label : takes place at</para>
    ///   <para>rdfs:comment : The place where an occurrence takes place.</para>
    ///   <a href="https://saref.etsi.org/saref4wear/takesPlaceAt">s4wear:takesPlaceAt</a>
    /// </summary>
    let takesPlaceAt = _prefixId.prefix "takesPlaceAt"
    /// <summary>
    ///   <para>rdfs:label : triggers</para>
    ///   <para>rdfs:comment : A relationship specifying the function actuating the work of a device.</para>
    ///   <a href="https://saref.etsi.org/saref4wear/triggers">s4wear:triggers</a>
    /// </summary>
    let triggers = _prefixId.prefix "triggers"
    /// <summary>
    ///   <para>rdfs:label : wearer age range</para>
    ///   <para>rdfs:comment : A relationship stating the age range of a wearer.</para>
    ///   <a href="https://saref.etsi.org/saref4wear/wearerAgeRange">s4wear:wearerAgeRange</a>
    /// </summary>
    let wearerAgeRange = _prefixId.prefix "wearerAgeRange"
    /// <summary>
    ///   <para>rdfs:label : wearer status</para>
    ///   <para>rdfs:comment : A relationship defining the status of a wearer.</para>
    ///   <a href="https://saref.etsi.org/saref4wear/wearerStatus">s4wear:wearerStatus</a>
    /// </summary>
    let wearerStatus = _prefixId.prefix "wearerStatus"
