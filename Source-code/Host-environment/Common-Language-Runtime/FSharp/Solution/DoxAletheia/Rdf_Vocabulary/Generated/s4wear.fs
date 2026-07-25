namespace https.saref.etsi.org.saref4wear.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module s4wear =
    let _namespace_iri = Namespace_Iri s4wear |> NamespaceIRI
    /// <summary>
    ///   <para>s4wear:isTriggeredBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship specifying the function actuating the work of a device.</para>
    /// labels<para>is triggered by</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4wear/isTriggeredBy">https://saref.etsi.org/saref4wear/isTriggeredBy</seealso>
    let isTriggeredBy = Prefixed_Name(s4wear, "isTriggeredBy") |> PrefixedName
    /// <summary>
    ///   <para>s4wear:monitors</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship specifying the monitoring activity of a device on another device.</para>
    /// labels<para>monitors</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4wear/monitors">https://saref.etsi.org/saref4wear/monitors</seealso>
    let monitors = Prefixed_Name(s4wear, "monitors") |> PrefixedName
    /// <summary>
    ///   <para>s4wear:wearerAgeRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A relationship stating the age range of a wearer.</para>
    /// labels<para>wearer age range</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4wear/wearerAgeRange">https://saref.etsi.org/saref4wear/wearerAgeRange</seealso>
    let wearerAgeRange = Prefixed_Name(s4wear, "wearerAgeRange") |> PrefixedName
    /// <summary>
    ///   <para>s4wear:hasInterface</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship specifying the interface with which a device is equipped.</para>
    /// labels<para>has interface</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4wear/hasInterface">https://saref.etsi.org/saref4wear/hasInterface</seealso>
    let hasInterface = Prefixed_Name(s4wear, "hasInterface") |> PrefixedName
    /// <summary>
    ///   <para>s4wear:hasWeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A relationship defining the weight of a wearable device.</para>
    /// labels<para>has weight</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4wear/hasWeight">https://saref.etsi.org/saref4wear/hasWeight</seealso>
    let hasWeight = Prefixed_Name(s4wear, "hasWeight") |> PrefixedName
    /// <summary>
    ///   <para>s4wear:isLocated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship specifying the location of a wearer with respect to a wearable.</para>
    /// labels<para>is located</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4wear/isLocated">https://saref.etsi.org/saref4wear/isLocated</seealso>
    let isLocated = Prefixed_Name(s4wear, "isLocated") |> PrefixedName
    /// <summary>
    ///   <para>s4wear:Wearable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A wearable device is a device that is intended to be located near, on or in an organism.</para>
    /// labels<para>Wearable device</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4wear/Wearable">https://saref.etsi.org/saref4wear/Wearable</seealso>
    let Wearable = Prefixed_Name(s4wear, "Wearable") |> PrefixedName
    /// <summary>
    ///   <para>s4wear:Occurrence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An occurrence is the fact of something existing or being found in a place.</para>
    /// labels<para>Occurrence</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4wear/Occurrence">https://saref.etsi.org/saref4wear/Occurrence</seealso>
    let Occurrence = Prefixed_Name(s4wear, "Occurrence") |> PrefixedName
    /// <summary>
    ///   <para>s4wear:v1.1.1/</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://saref.etsi.org/saref4wear/v1.1.1/">https://saref.etsi.org/saref4wear/v1.1.1/</seealso>
    let ``v1.1.1/`` = Prefixed_Name(s4wear, "v1.1.1/") |> PrefixedName

    /// <summary>
    ///   <para>s4wear:EnvironmentalProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class to group those properties related to the environment of a wearer.</para>
    /// labels<para>Environmental property</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4wear/EnvironmentalProperty">https://saref.etsi.org/saref4wear/EnvironmentalProperty</seealso>
    let EnvironmentalProperty =
        Prefixed_Name(s4wear, "EnvironmentalProperty") |> PrefixedName

    /// <summary>
    ///   <para>s4wear:BatteryRemainingTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>s4wear:ElectricalProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The time until the battery of the wearable is discharged.</para>
    /// labels<para>Battery remaining time</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4wear/BatteryRemainingTime">https://saref.etsi.org/saref4wear/BatteryRemainingTime</seealso>
    let BatteryRemainingTime =
        Prefixed_Name(s4wear, "BatteryRemainingTime") |> PrefixedName

    /// <summary>
    ///   <para>s4wear:WearerProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class to group those properties related to wearers.</para>
    /// labels<para>Wearer property</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4wear/WearerProperty">https://saref.etsi.org/saref4wear/WearerProperty</seealso>
    let WearerProperty = Prefixed_Name(s4wear, "WearerProperty") |> PrefixedName

    /// <summary>
    ///   <para>s4wear:CommunicatingFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A function that allows a device to communicate with another device.</para>
    /// labels<para>Communicating function</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4wear/CommunicatingFunction">https://saref.etsi.org/saref4wear/CommunicatingFunction</seealso>
    let CommunicatingFunction =
        Prefixed_Name(s4wear, "CommunicatingFunction") |> PrefixedName

    /// <summary>
    ///   <para>s4wear:WearableProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class to group those properties related to wearables.</para>
    /// labels<para>Wearable property</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4wear/WearableProperty">https://saref.etsi.org/saref4wear/WearableProperty</seealso>
    let WearableProperty = Prefixed_Name(s4wear, "WearableProperty") |> PrefixedName
    /// <summary>
    ///   <para>s4wear:FabricWearable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A fabric wearable is a fabric integrating the sensors directly into its fibers.</para>
    /// labels<para>Fabric wearable</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4wear/FabricWearable">https://saref.etsi.org/saref4wear/FabricWearable</seealso>
    let FabricWearable = Prefixed_Name(s4wear, "FabricWearable") |> PrefixedName

    /// <summary>
    ///   <para>s4wear:TextileBasedWearable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A textile-based wearable is a wearable directly integrated into a textile artifact.</para>
    /// labels<para>Textile-based wearable</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4wear/TextileBasedWearable">https://saref.etsi.org/saref4wear/TextileBasedWearable</seealso>
    let TextileBasedWearable =
        Prefixed_Name(s4wear, "TextileBasedWearable") |> PrefixedName

    /// <summary>
    ///   <para>s4wear:HeartRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>s4wear:BiometricProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The heart rate of the wearer.</para>
    /// labels<para>Heart rate</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4wear/HeartRate">https://saref.etsi.org/saref4wear/HeartRate</seealso>
    let HeartRate = Prefixed_Name(s4wear, "HeartRate") |> PrefixedName
    /// <summary>
    ///   <para>s4wear:HeatEmission</para>
    /// </summary>
    /// <remarks>
    ///   <para>s4wear:EmissionProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The heat emission of the wearable.</para>
    /// labels<para>Heat emission</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4wear/HeatEmission">https://saref.etsi.org/saref4wear/HeatEmission</seealso>
    let HeatEmission = Prefixed_Name(s4wear, "HeatEmission") |> PrefixedName
    /// <summary>
    ///   <para>s4wear:Interface</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An interface is the mechanism with which a device can receive or transmit data to another device.</para>
    /// labels<para>Interface</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4wear/Interface">https://saref.etsi.org/saref4wear/Interface</seealso>
    let Interface = Prefixed_Name(s4wear, "Interface") |> PrefixedName
    /// <summary>
    ///   <para>s4wear:LivingOrganism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A living organism is any entity composed of cells.</para>
    /// labels<para>Living organism</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4wear/LivingOrganism">https://saref.etsi.org/saref4wear/LivingOrganism</seealso>
    let LivingOrganism = Prefixed_Name(s4wear, "LivingOrganism") |> PrefixedName
    /// <summary>
    ///   <para>s4wear:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="https://saref.etsi.org/saref4wear/">https://saref.etsi.org/saref4wear/</seealso>
    let _prefix_iri = Prefixed_Name(s4wear, "") |> PrefixedName
    /// <summary>
    ///   <para>s4wear:AcousticEmission</para>
    /// </summary>
    /// <remarks>
    ///   <para>s4wear:EmissionProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The acoustic emission of the wearable.</para>
    /// labels<para>Acoustic emission</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4wear/AcousticEmission">https://saref.etsi.org/saref4wear/AcousticEmission</seealso>
    let AcousticEmission = Prefixed_Name(s4wear, "AcousticEmission") |> PrefixedName
    /// <summary>
    ///   <para>s4wear:ElectricalProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class to group those electrical properties related to wearables.</para>
    /// labels<para>Electrical property</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4wear/ElectricalProperty">https://saref.etsi.org/saref4wear/ElectricalProperty</seealso>
    let ElectricalProperty = Prefixed_Name(s4wear, "ElectricalProperty") |> PrefixedName
    /// <summary>
    ///   <para>s4wear:BiometricProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class to group those properties related to the biometric characteristics of wearers.</para>
    /// labels<para>Biometric property</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4wear/BiometricProperty">https://saref.etsi.org/saref4wear/BiometricProperty</seealso>
    let BiometricProperty = Prefixed_Name(s4wear, "BiometricProperty") |> PrefixedName
    /// <summary>
    ///   <para>s4wear:CrowdProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class to group those properties related to crowds.</para>
    /// labels<para>Crowd property</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4wear/CrowdProperty">https://saref.etsi.org/saref4wear/CrowdProperty</seealso>
    let CrowdProperty = Prefixed_Name(s4wear, "CrowdProperty") |> PrefixedName
    /// <summary>
    ///   <para>s4wear:EmissionProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class to group those emission properties related to wearables.</para>
    /// labels<para>Emission property</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4wear/EmissionProperty">https://saref.etsi.org/saref4wear/EmissionProperty</seealso>
    let EmissionProperty = Prefixed_Name(s4wear, "EmissionProperty") |> PrefixedName
    /// <summary>
    ///   <para>s4wear:AirQuality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>s4wear:EnvironmentalProperty</para>
    ///   <para>The quality of air in the environment.</para>
    /// labels<para>Air quality</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4wear/AirQuality">https://saref.etsi.org/saref4wear/AirQuality</seealso>
    let AirQuality = Prefixed_Name(s4wear, "AirQuality") |> PrefixedName

    /// <summary>
    ///   <para>s4wear:ControllingFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A function that allows to control a device from another device.</para>
    /// labels<para>Controlling function</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4wear/ControllingFunction">https://saref.etsi.org/saref4wear/ControllingFunction</seealso>
    let ControllingFunction =
        Prefixed_Name(s4wear, "ControllingFunction") |> PrefixedName

    /// <summary>
    ///   <para>s4wear:CrowdSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>s4wear:CrowdProperty</para>
    ///   <para>The size of a crowd.</para>
    /// labels<para>Crowd size</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4wear/CrowdSize">https://saref.etsi.org/saref4wear/CrowdSize</seealso>
    let CrowdSize = Prefixed_Name(s4wear, "CrowdSize") |> PrefixedName

    /// <summary>
    ///   <para>s4wear:ElectricalSafetyProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class to group those electrical safety properties related to wearables.</para>
    /// labels<para>Electrical safety property</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4wear/ElectricalSafetyProperty">https://saref.etsi.org/saref4wear/ElectricalSafetyProperty</seealso>
    let ElectricalSafetyProperty =
        Prefixed_Name(s4wear, "ElectricalSafetyProperty") |> PrefixedName

    /// <summary>
    ///   <para>s4wear:isLocatedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship specifying the location of a wearer with respect to an in-body wearable.</para>
    /// labels<para>is located in</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4wear/isLocatedIn">https://saref.etsi.org/saref4wear/isLocatedIn</seealso>
    let isLocatedIn = Prefixed_Name(s4wear, "isLocatedIn") |> PrefixedName
    /// <summary>
    ///   <para>s4wear:InBodyWearable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An in-body wearable is a wearable located inside a physical body.</para>
    /// labels<para>In-body wearable</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4wear/InBodyWearable">https://saref.etsi.org/saref4wear/InBodyWearable</seealso>
    let InBodyWearable = Prefixed_Name(s4wear, "InBodyWearable") |> PrefixedName
    /// <summary>
    ///   <para>s4wear:NearBodyWearable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A near-body wearable is a wearable located near a physical body.</para>
    /// labels<para>Near-body wearable</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4wear/NearBodyWearable">https://saref.etsi.org/saref4wear/NearBodyWearable</seealso>
    let NearBodyWearable = Prefixed_Name(s4wear, "NearBodyWearable") |> PrefixedName
    /// <summary>
    ///   <para>s4wear:takesPlaceAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The place where an occurrence takes place.</para>
    /// labels<para>takes place at</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4wear/takesPlaceAt">https://saref.etsi.org/saref4wear/takesPlaceAt</seealso>
    let takesPlaceAt = Prefixed_Name(s4wear, "takesPlaceAt") |> PrefixedName
    /// <summary>
    ///   <para>s4wear:OnBodyWearable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An on-body wearable is a wearable having a direct contact with a physical body.</para>
    /// labels<para>On-body wearable</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4wear/OnBodyWearable">https://saref.etsi.org/saref4wear/OnBodyWearable</seealso>
    let OnBodyWearable = Prefixed_Name(s4wear, "OnBodyWearable") |> PrefixedName
    /// <summary>
    ///   <para>s4wear:Policy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A policy is a set of guidelines adopted during the wearable building process and defining how a wearables operates.</para>
    /// labels<para>Policy</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4wear/Policy">https://saref.etsi.org/saref4wear/Policy</seealso>
    let Policy = Prefixed_Name(s4wear, "Policy") |> PrefixedName
    /// <summary>
    ///   <para>s4wear:PowerSupply</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A power supply is an hardware component intended to plug a device to a power grid.</para>
    /// labels<para>Power supply</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4wear/PowerSupply">https://saref.etsi.org/saref4wear/PowerSupply</seealso>
    let PowerSupply = Prefixed_Name(s4wear, "PowerSupply") |> PrefixedName
    /// <summary>
    ///   <para>s4wear:Software</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A software is a computer program.</para>
    /// labels<para>Software</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4wear/Software">https://saref.etsi.org/saref4wear/Software</seealso>
    let Software = Prefixed_Name(s4wear, "Software") |> PrefixedName
    /// <summary>
    ///   <para>s4wear:TextileBasedSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A textile-based sensor is a sensor directly integrated into a textile artifact.</para>
    /// labels<para>Textile-based sensor</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4wear/TextileBasedSensor">https://saref.etsi.org/saref4wear/TextileBasedSensor</seealso>
    let TextileBasedSensor = Prefixed_Name(s4wear, "TextileBasedSensor") |> PrefixedName
    /// <summary>
    ///   <para>s4wear:WearerTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>s4wear:BiometricProperty</para>
    ///   <para>The temperature of the wearer.</para>
    /// labels<para>Wearer temperature</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4wear/WearerTemperature">https://saref.etsi.org/saref4wear/WearerTemperature</seealso>
    let WearerTemperature = Prefixed_Name(s4wear, "WearerTemperature") |> PrefixedName
    /// <summary>
    ///   <para>s4wear:controlsFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship specifying the features of interest that are controlled by a device.</para>
    /// labels<para>controls feature</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4wear/controlsFeature">https://saref.etsi.org/saref4wear/controlsFeature</seealso>
    let controlsFeature = Prefixed_Name(s4wear, "controlsFeature") |> PrefixedName
    /// <summary>
    ///   <para>s4wear:followsPolicy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship specifying the policy followed by a wearable device.</para>
    /// labels<para>follows policy</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4wear/followsPolicy">https://saref.etsi.org/saref4wear/followsPolicy</seealso>
    let followsPolicy = Prefixed_Name(s4wear, "followsPolicy") |> PrefixedName

    /// <summary>
    ///   <para>s4wear:hasDataTransmissionRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A relationship defining the data transmission rate of a wearable.</para>
    /// labels<para>has data transmission rate</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4wear/hasDataTransmissionRate">https://saref.etsi.org/saref4wear/hasDataTransmissionRate</seealso>
    let hasDataTransmissionRate =
        Prefixed_Name(s4wear, "hasDataTransmissionRate") |> PrefixedName

    /// <summary>
    ///   <para>s4wear:hasLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A relationship defining the length dimension of a wearable.</para>
    /// labels<para>has length</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4wear/hasLength">https://saref.etsi.org/saref4wear/hasLength</seealso>
    let hasLength = Prefixed_Name(s4wear, "hasLength") |> PrefixedName
    /// <summary>
    ///   <para>s4wear:hasSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship specifying a sensor integrated into a device.</para>
    /// labels<para>has sensor</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4wear/hasSensor">https://saref.etsi.org/saref4wear/hasSensor</seealso>
    let hasSensor = Prefixed_Name(s4wear, "hasSensor") |> PrefixedName
    /// <summary>
    ///   <para>s4wear:hasStorage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A relationship defining the storage capacity of a wearable.</para>
    /// labels<para>has storage</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4wear/hasStorage">https://saref.etsi.org/saref4wear/hasStorage</seealso>
    let hasStorage = Prefixed_Name(s4wear, "hasStorage") |> PrefixedName
    /// <summary>
    ///   <para>s4wear:hasWidth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A relationship defining the width dimention of a wearable.</para>
    /// labels<para>has width</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4wear/hasWidth">https://saref.etsi.org/saref4wear/hasWidth</seealso>
    let hasWidth = Prefixed_Name(s4wear, "hasWidth") |> PrefixedName
    /// <summary>
    ///   <para>s4wear:installs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship specifying in which facility a device has been installed.</para>
    /// labels<para>installs</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4wear/installs">https://saref.etsi.org/saref4wear/installs</seealso>
    let installs = Prefixed_Name(s4wear, "installs") |> PrefixedName
    /// <summary>
    ///   <para>s4wear:interactsWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship specifying the interaction between a user and a device.</para>
    /// labels<para>interacts with</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4wear/interactsWith">https://saref.etsi.org/saref4wear/interactsWith</seealso>
    let interactsWith = Prefixed_Name(s4wear, "interactsWith") |> PrefixedName
    /// <summary>
    ///   <para>s4wear:isDetectedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Defines the relationship between an occurrence and the device detecting it.</para>
    /// labels<para>is detected by</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4wear/isDetectedBy">https://saref.etsi.org/saref4wear/isDetectedBy</seealso>
    let isDetectedBy = Prefixed_Name(s4wear, "isDetectedBy") |> PrefixedName
    /// <summary>
    ///   <para>s4wear:triggers</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship specifying the function actuating the work of a device.</para>
    /// labels<para>triggers</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4wear/triggers">https://saref.etsi.org/saref4wear/triggers</seealso>
    let triggers = Prefixed_Name(s4wear, "triggers") |> PrefixedName
    /// <summary>
    ///   <para>s4wear:meansOfTransport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A relationship stating the means of transport on which the wearable is operating.</para>
    /// labels<para>means of transport</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4wear/meansOfTransport">https://saref.etsi.org/saref4wear/meansOfTransport</seealso>
    let meansOfTransport = Prefixed_Name(s4wear, "meansOfTransport") |> PrefixedName
    /// <summary>
    ///   <para>s4wear:measuresFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship specifying the features of interest that are measured by a device.</para>
    /// labels<para>measures feature</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4wear/measuresFeature">https://saref.etsi.org/saref4wear/measuresFeature</seealso>
    let measuresFeature = Prefixed_Name(s4wear, "measuresFeature") |> PrefixedName
    /// <summary>
    ///   <para>s4wear:sendsInformationTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship specifying the sending information operation between two wearables.</para>
    /// labels<para>sends information to</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4wear/sendsInformationTo">https://saref.etsi.org/saref4wear/sendsInformationTo</seealso>
    let sendsInformationTo = Prefixed_Name(s4wear, "sendsInformationTo") |> PrefixedName

    /// <summary>
    ///   <para>s4wear:sendsNotificationsTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship specifying the sending notification operation between two wearables.</para>
    /// labels<para>sends notifications to</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4wear/sendsNotificationsTo">https://saref.etsi.org/saref4wear/sendsNotificationsTo</seealso>
    let sendsNotificationsTo =
        Prefixed_Name(s4wear, "sendsNotificationsTo") |> PrefixedName

    /// <summary>
    ///   <para>s4wear:wearerStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A relationship defining the status of a wearer.</para>
    /// labels<para>wearer status</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4wear/wearerStatus">https://saref.etsi.org/saref4wear/wearerStatus</seealso>
    let wearerStatus = Prefixed_Name(s4wear, "wearerStatus") |> PrefixedName
    /// <summary>
    ///   <para>s4wear:MemoryStorage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A memory storage is an hardware component intended to store data within the device.</para>
    /// labels<para>Memory storage</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4wear/MemoryStorage">https://saref.etsi.org/saref4wear/MemoryStorage</seealso>
    let MemoryStorage = Prefixed_Name(s4wear, "MemoryStorage") |> PrefixedName
    /// <summary>
    ///   <para>s4wear:isLocatedNear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship specifying the location of a wearer with respect to an near-body wearable.</para>
    /// labels<para>is located near</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4wear/isLocatedNear">https://saref.etsi.org/saref4wear/isLocatedNear</seealso>
    let isLocatedNear = Prefixed_Name(s4wear, "isLocatedNear") |> PrefixedName
    /// <summary>
    ///   <para>s4wear:isLocatedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship specifying the location of a wearer with respect to an on-body wearable.</para>
    /// labels<para>is located on</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4wear/isLocatedOn">https://saref.etsi.org/saref4wear/isLocatedOn</seealso>
    let isLocatedOn = Prefixed_Name(s4wear, "isLocatedOn") |> PrefixedName

    /// <summary>
    ///   <para>s4wear:RadioFrequencyEmission</para>
    /// </summary>
    /// <remarks>
    ///   <para>s4wear:EmissionProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The radio frequency emission of the wearable.</para>
    /// labels<para>Radio frequency emission</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4wear/RadioFrequencyEmission">https://saref.etsi.org/saref4wear/RadioFrequencyEmission</seealso>
    let RadioFrequencyEmission =
        Prefixed_Name(s4wear, "RadioFrequencyEmission") |> PrefixedName

    /// <summary>
    ///   <para>s4wear:SoundLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>s4wear:EnvironmentalProperty</para>
    ///   <para>The level of sound in the environment.</para>
    /// labels<para>Sound level</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4wear/SoundLevel">https://saref.etsi.org/saref4wear/SoundLevel</seealso>
    let SoundLevel = Prefixed_Name(s4wear, "SoundLevel") |> PrefixedName
    /// <summary>
    ///   <para>s4wear:Wearer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A wearer is any living organism that is sensed by a wearable.</para>
    /// labels<para>Wearer</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4wear/Wearer">https://saref.etsi.org/saref4wear/Wearer</seealso>
    let Wearer = Prefixed_Name(s4wear, "Wearer") |> PrefixedName
    /// <summary>
    ///   <para>s4wear:NavigatingFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A function that allows a device to provide navigation information.</para>
    /// labels<para>Navigating function</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4wear/NavigatingFunction">https://saref.etsi.org/saref4wear/NavigatingFunction</seealso>
    let NavigatingFunction = Prefixed_Name(s4wear, "NavigatingFunction") |> PrefixedName
    /// <summary>
    ///   <para>s4wear:QueueSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>s4wear:CrowdProperty</para>
    ///   <para>The size of a queue.</para>
    /// labels<para>Queue size</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4wear/QueueSize">https://saref.etsi.org/saref4wear/QueueSize</seealso>
    let QueueSize = Prefixed_Name(s4wear, "QueueSize") |> PrefixedName
    /// <summary>
    ///   <para>s4wear:Temperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>s4wear:EnvironmentalProperty</para>
    ///   <para>The temperature of the environment.</para>
    /// labels<para>Temperature</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4wear/Temperature">https://saref.etsi.org/saref4wear/Temperature</seealso>
    let Temperature = Prefixed_Name(s4wear, "Temperature") |> PrefixedName
    /// <summary>
    ///   <para>s4wear:User</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A user is an entity using a wearable.</para>
    /// labels<para>User</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4wear/User">https://saref.etsi.org/saref4wear/User</seealso>
    let User = Prefixed_Name(s4wear, "User") |> PrefixedName

    /// <summary>
    ///   <para>s4wear:featureIsMeasuredByDevice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship specifying the devices that measure a feature of interest.</para>
    /// labels<para>feature is measured by device</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4wear/featureIsMeasuredByDevice">https://saref.etsi.org/saref4wear/featureIsMeasuredByDevice</seealso>
    let featureIsMeasuredByDevice =
        Prefixed_Name(s4wear, "featureIsMeasuredByDevice") |> PrefixedName

    /// <summary>
    ///   <para>s4wear:featureIsControlledByDevice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship specifying the devices that control a feature of interest.</para>
    /// labels<para>feature is controlled by device</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4wear/featureIsControlledByDevice">https://saref.etsi.org/saref4wear/featureIsControlledByDevice</seealso>
    let featureIsControlledByDevice =
        Prefixed_Name(s4wear, "featureIsControlledByDevice") |> PrefixedName

    /// <summary>
    ///   <para>s4wear:hasCapacity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A relationship defining the capacity of a facility.</para>
    /// labels<para>has capacity</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4wear/hasCapacity">https://saref.etsi.org/saref4wear/hasCapacity</seealso>
    let hasCapacity = Prefixed_Name(s4wear, "hasCapacity") |> PrefixedName
    /// <summary>
    ///   <para>s4wear:hasCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A relationship defining a command triggered by an actuating function.</para>
    /// labels<para>has command</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4wear/hasCommand">https://saref.etsi.org/saref4wear/hasCommand</seealso>
    let hasCommand = Prefixed_Name(s4wear, "hasCommand") |> PrefixedName
    /// <summary>
    ///   <para>s4wear:hasHeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A relationship defining the height dimension of a wearable.</para>
    /// labels<para>has height</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4wear/hasHeight">https://saref.etsi.org/saref4wear/hasHeight</seealso>
    let hasHeight = Prefixed_Name(s4wear, "hasHeight") |> PrefixedName
    /// <summary>
    ///   <para>s4wear:hasPowerSupply</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship specifying the type of power supply equipping a device.</para>
    /// labels<para>has power supply</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4wear/hasPowerSupply">https://saref.etsi.org/saref4wear/hasPowerSupply</seealso>
    let hasPowerSupply = Prefixed_Name(s4wear, "hasPowerSupply") |> PrefixedName
