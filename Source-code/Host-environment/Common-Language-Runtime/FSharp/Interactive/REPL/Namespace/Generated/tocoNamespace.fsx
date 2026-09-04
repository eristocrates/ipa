#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module toco =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/toco/" "toco"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:comment : a wireless access point, or more generally just access point (AP), is a networking hardware device that allows a Wi-Fi/Li-Fi device to connect to a wired network. The AP usually connects to a router (via a wired network) as a standalone device, but it can also be an integral component of the router itself. An AP is differentiated from a hotspot, which is the physical location where Wi-Fi access to a WLAN is available.^^xsd:string</para>
    ///   <a href="http://purl.org/toco/AccessPoint">toco:AccessPoint</a>
    /// </summary>
    let AccessPoint = _prefixId.prefix "AccessPoint"
    /// <summary>
    ///   <para>rdfs:comment : the action of a flow defined in OpenFlow protocol^^xsd:string</para>
    ///   <a href="http://purl.org/toco/Action">toco:Action</a>
    /// </summary>
    let Action = _prefixId.prefix "Action"
    let Attached = _prefixId.prefix "Attached"
    let AudioService = _prefixId.prefix "AudioService"
    let AudioSession = _prefixId.prefix "AudioSession"
    /// <summary>
    ///   <para>rdfs:comment : a "land station in the land mobile service." -- according to the International Telecommunication Union's (ITU) Radio Regulations (RR).
    ///
    /// it is a transceiver connecting a number of other devices to one another and/or to a wider area. In LTE, it is also known as eNodeB.^^xsd:string</para>
    ///   <a href="http://purl.org/toco/BaseStation">toco:BaseStation</a>
    /// </summary>
    let BaseStation = _prefixId.prefix "BaseStation"
    /// <summary>
    ///   <para>rdfs:comment : User deivce in a Cellular network.^^xsd:string</para>
    ///   <a href="http://purl.org/toco/CellularUserEquipment">toco:CellularUserEquipment</a>
    /// </summary>
    let CellularUserEquipment = _prefixId.prefix "CellularUserEquipment"
    let ConceptEntities = _prefixId.prefix "ConceptEntities"
    let Detached = _prefixId.prefix "Detached"
    /// <summary>
    ///   <para>rdfs:comment : represent all the devices in the physical infrastructure of telecommunciation system.
    ///
    /// According to its user, could be divided into UserDevice and SystemDevice.^^xsd:string</para>
    ///   <a href="http://purl.org/toco/Device">toco:Device</a>
    /// </summary>
    let Device = _prefixId.prefix "Device"
    let Drop = _prefixId.prefix "Drop"
    let FileTransferService = _prefixId.prefix "FileTransferService"
    /// <summary>
    ///   <para>rdfs:comment : the flow entry in a flow table inside a switch or route. Defined by OpenFlow protocol.^^xsd:string</para>
    ///   <a href="http://purl.org/toco/Flow">toco:Flow</a>
    /// </summary>
    let Flow = _prefixId.prefix "Flow"
    let Forward = _prefixId.prefix "Forward"
    /// <summary>
    ///   <para>rdfs:comment : A host is a computer or other device connected to a computer network. It is a network node that is assigned a network address.^^xsd:string</para>
    ///   <a href="http://purl.org/toco/Host">toco:Host</a>
    /// </summary>
    let Host = _prefixId.prefix "Host"
    let Interface = _prefixId.prefix "Interface"
    /// <summary>
    ///   <para>rdfs:comment : the electromagnetic wave carring modulated signal between LTE base station, or eNodeB, and user equipment^^xsd:string</para>
    ///   <a href="http://purl.org/toco/LTEAssociation">toco:LTEAssociation</a>
    /// </summary>
    let LTEAssociation = _prefixId.prefix "LTEAssociation"
    /// <summary>
    ///   <para>rdfs:comment : The access point in Li-Fi network. Li-Fi is a wireless optical networking technology that uses light-emitting diodes (LEDs) for data transmission.^^xsd:string</para>
    ///   <a href="http://purl.org/toco/LiFiAccessPoint">toco:LiFiAccessPoint</a>
    /// </summary>
    let LiFiAccessPoint = _prefixId.prefix "LiFiAccessPoint"
    /// <summary>
    ///   <para>rdfs:comment : the visiable light carring modulated signals in Li-Fi network. Transmited and received by LiFi user equipment and LiFi access point.^^xsd:string</para>
    ///   <a href="http://purl.org/toco/LiFiAssociation">toco:LiFiAssociation</a>
    /// </summary>
    let LiFiAssociation = _prefixId.prefix "LiFiAssociation"
    /// <summary>
    ///   <para>rdfs:comment : any device used directly by an end-user to communicate. It can be a hand-held telephone, a laptop computer equipped with a mobile broadband adapter, or any other device.^^xsd:string</para>
    ///   <a href="http://purl.org/toco/LiFiUserEquipment">toco:LiFiUserEquipment</a>
    /// </summary>
    let LiFiUserEquipment = _prefixId.prefix "LiFiUserEquipment"
    /// <summary>
    ///   <para>rdfs:comment : WLAN interface on the devices in LIFi network, e.g., LiFi user equipment, LiFi access point.^^xsd:string</para>
    ///   <a href="http://purl.org/toco/LiFiWLAN">toco:LiFiWLAN</a>
    /// </summary>
    let LiFiWLAN = _prefixId.prefix "LiFiWLAN"
    let Link = _prefixId.prefix "Link"
    let Output = _prefixId.prefix "Output"
    let PathFlow = _prefixId.prefix "PathFlow"
    /// <summary>
    ///   <para>rdfs:comment : Describe all the physical resources in a telecommunication network system, which is divided into three main modules, namely, device, interface, link.
    ///
    /// Please be reminded the electromagnetic wave (which is the links of all wireless communication netwoks), even if it is invisable, physically exists. Thus, it is also described in the subclass of "net;PhysicalInfrastructure".^^xsd:string</para>
    ///   <a href="http://purl.org/toco/PhysicalInfrastructure">toco:PhysicalInfrastructure</a>
    /// </summary>
    let PhysicalInfrastructure = _prefixId.prefix "PhysicalInfrastructure"
    /// <summary>
    ///   <para>rdfs:comment : the milli-meter electromagnetic wave carring modulated signal between satellite base stations and ground station.^^xsd:string</para>
    ///   <a href="http://purl.org/toco/SatelliteAssociation">toco:SatelliteAssociation</a>
    /// </summary>
    let SatelliteAssociation = _prefixId.prefix "SatelliteAssociation"
    /// <summary>
    ///   <para>rdfs:comment : used in satellite network. Also known as earth station, or earth terminal, it is a terrestrial radio station designed for extraplanetary telecommunication with spacecraft (constituting part of the ground segment of the spacecraft system), or reception of radio waves from astronomical radio sources. Ground stations may be located either on the surface of the Earth, or in its atmosphere.[1] Earth stations communicate with spacecraft by transmitting and receiving radio waves in the super high frequency or extremely high frequency bands (e.g., microwaves). When a ground station successfully transmits radio waves to a spacecraft (or vice versa), it establishes a telecommunications link. A principal telecommunications device of the ground station is the parabolic antenna.^^xsd:string</para>
    ///   <a href="http://purl.org/toco/SatelliteGroundStation">toco:SatelliteGroundStation</a>
    /// </summary>
    let SatelliteGroundStation = _prefixId.prefix "SatelliteGroundStation"
    /// <summary>
    ///   <para>rdfs:comment : An artificial satellite, that relays and amplifies radio telecommunications signals via a transponder; it creates a communication channel between a source transmitter and a receiver at different locations on Earth. Communications satellites are used for television, telephone, radio, internet, and military applications.^^xsd:string</para>
    ///   <a href="http://purl.org/toco/SatelliteRelayStation">toco:SatelliteRelayStation</a>
    /// </summary>
    let SatelliteRelayStation = _prefixId.prefix "SatelliteRelayStation"
    /// <summary>
    ///   <para>rdfs:comment : a communication service, e.g., voice, video, file uploading/downloading, etc.^^xsd:string</para>
    ///   <a href="http://purl.org/toco/Service">toco:Service</a>
    /// </summary>
    let Service = _prefixId.prefix "Service"
    let Session = _prefixId.prefix "Session"
    /// <summary>
    ///   <para>rdfs:comment : A network switch (also called switching hub, bridging hub, officially MAC bridge) is a computer networking device that connects devices together on a computer network by using packet switching to receive, process, and forward data to the destination device.^^xsd:string</para>
    ///   <a href="http://purl.org/toco/Switch">toco:Switch</a>
    /// </summary>
    let Switch = _prefixId.prefix "Switch"
    /// <summary>
    ///   <para>rdfs:comment : All the physical facilities in the telecommunication system that provide the communication service to uses. For example: base station towers, Wi-Fi access points, switches, servers, etc.^^xsd:string</para>
    ///   <a href="http://purl.org/toco/SystemDevice">toco:SystemDevice</a>
    /// </summary>
    let SystemDevice = _prefixId.prefix "SystemDevice"
    let Text = _prefixId.prefix "Text"
    /// <summary>
    ///   <para>rdfs:comment : reused from foaf (http://xmlns.com/foaf/0.1/). Represent a user in the telecommunication system.^^xsd:string</para>
    ///   <a href="http://purl.org/toco/User">toco:User</a>
    /// </summary>
    let User = _prefixId.prefix "User"
    /// <summary>
    ///   <para>rdfs:comment : User Devices, requiring connectivity services, e.g., phones, tablets, laptops, wearable devices, etc.^^xsd:string</para>
    ///   <a href="http://purl.org/toco/UserDevice">toco:UserDevice</a>
    /// </summary>
    let UserDevice = _prefixId.prefix "UserDevice"
    let UserDeviceStatus = _prefixId.prefix "UserDeviceStatus"
    /// <summary>
    ///   <para>rdfs:comment : any device used directly by an end-user to communicate. It can be a hand-held telephone, a laptop computer equipped with a mobile broadband adapter, or any other device.^^xsd:string</para>
    ///   <a href="http://purl.org/toco/UserEquipment">toco:UserEquipment</a>
    /// </summary>
    let UserEquipment = _prefixId.prefix "UserEquipment"
    let VideoService = _prefixId.prefix "VideoService"
    let VideoSession = _prefixId.prefix "VideoSession"
    /// <summary>
    ///   <para>rdfs:comment : A wireless local area network (WLAN) interface, also known as WLAN, is the interface of a wireless computer network that links two or more devices using wireless communication within a limited area such as a home, school, computer laboratory, or office building.^^xsd:string</para>
    ///   <a href="http://purl.org/toco/WLAN">toco:WLAN</a>
    /// </summary>
    let WLAN = _prefixId.prefix "WLAN"
    /// <summary>
    ///   <para>rdfs:comment : An access point in a WiFi network^^xsd:string</para>
    ///   <a href="http://purl.org/toco/WiFiAccessPoint">toco:WiFiAccessPoint</a>
    /// </summary>
    let WiFiAccessPoint = _prefixId.prefix "WiFiAccessPoint"
    /// <summary>
    ///   <para>rdfs:comment : the electromagnetic wave carring modulated signal between LTE base station, or eNodeB, and user equipment^^xsd:string</para>
    ///   <a href="http://purl.org/toco/WiFiAssociation">toco:WiFiAssociation</a>
    /// </summary>
    let WiFiAssociation = _prefixId.prefix "WiFiAssociation"
    /// <summary>
    ///   <para>rdfs:comment : a user quipment in Wi-Fi network^^xsd:string</para>
    ///   <a href="http://purl.org/toco/WiFiUserEquipment">toco:WiFiUserEquipment</a>
    /// </summary>
    let WiFiUserEquipment = _prefixId.prefix "WiFiUserEquipment"
    /// <summary>
    ///   <para>rdfs:comment : WLAN interface on the devices in LIFi network, e.g., LiFi user equipment, LiFi access point.^^xsd:string</para>
    ///   <a href="http://purl.org/toco/WiFiWLAN">toco:WiFiWLAN</a>
    /// </summary>
    let WiFiWLAN = _prefixId.prefix "WiFiWLAN"
    /// <summary>
    ///   <para>rdfs:comment : wired link through twisted cable, optical fiber, etc.^^xsd:string</para>
    ///   <a href="http://purl.org/toco/WiredLink">toco:WiredLink</a>
    /// </summary>
    let WiredLink = _prefixId.prefix "WiredLink"
    /// <summary>
    ///   <para>rdfs:comment : the electromeganetic radio transmiting through wireless channels in wireless network, carring communication data. Depend on its frequency, it could be visiable light, micro waves, radio waves.^^xsd:string</para>
    ///   <a href="http://purl.org/toco/WirelessAssociation">toco:WirelessAssociation</a>
    /// </summary>
    let WirelessAssociation = _prefixId.prefix "WirelessAssociation"
    let apsInRange = _prefixId.prefix "apsInRange"
    let belongsTo = _prefixId.prefix "belongsTo"
    /// <summary>
    ///   <para>rdfs:comment : the channel id of a interface.^^xsd:string</para>
    ///   <a href="http://purl.org/toco/channel">toco:channel</a>
    /// </summary>
    let channel = _prefixId.prefix "channel"
    let contributor = _prefixId.prefix "contributor"
    let cookie = _prefixId.prefix "cookie"
    /// <summary>
    ///   <para>rdfs:comment : the Ethernet destination address of the flow. It should be an MAC address, with 6 pairs of hexadecimal digits.^^xsd:string</para>
    ///   <a href="http://purl.org/toco/dlDst">toco:dlDst</a>
    /// </summary>
    let dlDst = _prefixId.prefix "dlDst"
    /// <summary>
    ///   <para>rdfs:comment : the Ethernet source address of the flow. It should be an MAC address with 6 pairs of hexadecimal digits^^xsd:string</para>
    ///   <a href="http://purl.org/toco/dlSrc">toco:dlSrc</a>
    /// </summary>
    let dlSrc = _prefixId.prefix "dlSrc"
    let driver = _prefixId.prefix "driver"
    let flags = _prefixId.prefix "flags"
    /// <summary>
    ///   <para>rdfs:comment : the frequency of the radio wave transmitted by a wireless interface (WLAN).^^xsd:string</para>
    ///   <a href="http://purl.org/toco/frequency">toco:frequency</a>
    /// </summary>
    let frequency = _prefixId.prefix "frequency"
    /// <summary>
    ///   <para>rdfs:comment : the source node that the link is transmit from.^^xsd:string</para>
    ///   <a href="http://purl.org/toco/from">toco:from</a>
    /// </summary>
    let from = _prefixId.prefix "from"
    let hardTimeout = _prefixId.prefix "hardTimeout"
    /// <summary>
    ///   <para>rdfs:comment : the gain of an antenna on the wireless interface.^^xsd:string</para>
    ///   <a href="http://purl.org/toco/hasAntennaGain">toco:hasAntennaGain</a>
    /// </summary>
    let hasAntennaGain = _prefixId.prefix "hasAntennaGain"
    /// <summary>
    ///   <para>rdfs:comment : the height of the antenna of a wireless interface^^xsd:string</para>
    ///   <a href="http://purl.org/toco/hasAntennaHeight">toco:hasAntennaHeight</a>
    /// </summary>
    let hasAntennaHeight = _prefixId.prefix "hasAntennaHeight"
    /// <summary>
    ///   <para>rdfs:comment : in wireless networks, the user equipments (mobile stations in another term, e.g., phones, laptops, tablets, etc.) that are associated to the access point.^^xsd:string</para>
    ///   <a href="http://purl.org/toco/hasAssociatedStations">toco:hasAssociatedStations</a>
    /// </summary>
    let hasAssociatedStations = _prefixId.prefix "hasAssociatedStations"
    /// <summary>
    ///   <para>rdfs:comment : the bandwidth of the link^^xsd:string</para>
    ///   <a href="http://purl.org/toco/hasBandwidth">toco:hasBandwidth</a>
    /// </summary>
    let hasBandwidth = _prefixId.prefix "hasBandwidth"
    let hasDatarate = _prefixId.prefix "hasDatarate"
    let hasDevice = _prefixId.prefix "hasDevice"
    /// <summary>
    ///   <para>rdfs:comment : the Euclidean distance between the LiFi user equipment and access point.^^xsd:string</para>
    ///   <a href="http://purl.org/toco/hasDistance">toco:hasDistance</a>
    /// </summary>
    let hasDistance = _prefixId.prefix "hasDistance"
    /// <summary>
    ///   <para>rdfs:comment : the error code of a service.^^xsd:string</para>
    ///   <a href="http://purl.org/toco/hasErrorCode">toco:hasErrorCode</a>
    /// </summary>
    let hasErrorCode = _prefixId.prefix "hasErrorCode"
    /// <summary>
    ///   <para>rdfs:comment : Field of view (FOV) is the open observable area where a LiFi user equipment could receive visiable light signal. It is defined by let the incident angle of the LiFi user equipment equals to Pi/2.
    ///
    /// If the incident angle larger than Pi/2, the light ray is out of the FOV, thus cannot be received by the LiFi user equipment.^^xsd:string</para>
    ///   <a href="http://purl.org/toco/hasFieldOfView">toco:hasFieldOfView</a>
    /// </summary>
    let hasFieldOfView = _prefixId.prefix "hasFieldOfView"
    let hasFlow = _prefixId.prefix "hasFlow"
    let hasFlowAction = _prefixId.prefix "hasFlowAction"
    let hasFlowProperty = _prefixId.prefix "hasFlowProperty"
    /// <summary>
    ///   <para>rdfs:comment : The gain of the concentrator on the LiFi user equipment, usually equals to 1.^^xsd:string</para>
    ///   <a href="http://purl.org/toco/hasGainOfConcentrator">toco:hasGainOfConcentrator</a>
    /// </summary>
    let hasGainOfConcentrator = _prefixId.prefix "hasGainOfConcentrator"
    /// <summary>
    ///   <para>rdfs:comment : Gain of optical filter on LiFi access point.^^xsd:string</para>
    ///   <a href="http://purl.org/toco/hasGainofOpticalFilter">toco:hasGainofOpticalFilter</a>
    /// </summary>
    let hasGainofOpticalFilter = _prefixId.prefix "hasGainofOpticalFilter"
    /// <summary>
    ///   <para>rdfs:comment : The angle of half intensity of the LED light transmiting visible light signal in a LiFi access point.
    ///
    /// A fixed value. It is the angle where the radiated intensity will be half as intense as it would be at 0 degrees, or pointing straight ahead.
    ///
    /// Factors that contribute to the angle of half intensity include the amount of diffusing material in the epoxy, the shape of the reflector cup which surrounds the LED chip, the shape of the LED lens, the distance from the LED to the tip of the lens, and the type of emitter chip.
    ///
    /// The most common value is Pi/3.^^xsd:string</para>
    ///   <a href="http://purl.org/toco/hasHalfIntensityAngle">toco:hasHalfIntensityAngle</a>
    /// </summary>
    let hasHalfIntensityAngle = _prefixId.prefix "hasHalfIntensityAngle"
    /// <summary>
    ///   <para>rdfs:comment : the IP address of the interface.^^xsd:string</para>
    ///   <a href="http://purl.org/toco/hasIP">toco:hasIP</a>
    /// </summary>
    let hasIP = _prefixId.prefix "hasIP"
    /// <summary>
    ///   <para>rdfs:comment : The angle of incidence of the LED receiver on LiFi user equipment, which is the angle between the visiable light ray incident on a surface and the line perpendicular to the surface at the point of incidence, called the normal.^^xsd:string</para>
    ///   <a href="http://purl.org/toco/hasIncidentAngle">toco:hasIncidentAngle</a>
    /// </summary>
    let hasIncidentAngle = _prefixId.prefix "hasIncidentAngle"
    /// <summary>
    ///   <para>rdfs:comment : the fact that a device has a interface.^^xsd:string</para>
    ///   <a href="http://purl.org/toco/hasInterface">toco:hasInterface</a>
    /// </summary>
    let hasInterface = _prefixId.prefix "hasInterface"
    /// <summary>
    ///   <para>rdfs:comment : the port number of an interface^^xsd:string</para>
    ///   <a href="http://purl.org/toco/hasInterfaceName">toco:hasInterfaceName</a>
    /// </summary>
    let hasInterfaceName = _prefixId.prefix "hasInterfaceName"
    /// <summary>
    ///   <para>rdfs:comment : the join date of the user device^^xsd:string</para>
    ///   <a href="http://purl.org/toco/hasJoinDate">toco:hasJoinDate</a>
    /// </summary>
    let hasJoinDate = _prefixId.prefix "hasJoinDate"
    let hasLTEAssociation = _prefixId.prefix "hasLTEAssociation"
    /// <summary>
    ///   <para>rdfs:comment : datatype properties dedicated for LiFi access points^^xsd:string</para>
    ///   <a href="http://purl.org/toco/hasLiFiAccessPointProperty">toco:hasLiFiAccessPointProperty</a>
    /// </summary>
    let hasLiFiAccessPointProperty = _prefixId.prefix "hasLiFiAccessPointProperty"
    let hasLiFiAssociation = _prefixId.prefix "hasLiFiAssociation"
    /// <summary>
    ///   <para>rdfs:comment : The properties of the visiable light association between the LED on LiFi access point and LiFi user equipment.^^xsd:string</para>
    ///   <a href="http://purl.org/toco/hasLiFiAssociationProperty">toco:hasLiFiAssociationProperty</a>
    /// </summary>
    let hasLiFiAssociationProperty = _prefixId.prefix "hasLiFiAssociationProperty"
    /// <summary>
    ///   <para>rdfs:comment : properties of LiFi user equipments.^^xsd:string</para>
    ///   <a href="http://purl.org/toco/hasLiFiUserEquipmentProperty">toco:hasLiFiUserEquipmentProperty</a>
    /// </summary>
    let hasLiFiUserEquipmentProperty = _prefixId.prefix "hasLiFiUserEquipmentProperty"
    let hasLiFiWLAN = _prefixId.prefix "hasLiFiWLAN"
    let hasLink = _prefixId.prefix "hasLink"
    let hasLinkProperty = _prefixId.prefix "hasLinkProperty"
    /// <summary>
    ///   <para>rdfs:comment : the MAC address of the interface.^^xsd:string</para>
    ///   <a href="http://purl.org/toco/hasMAC">toco:hasMAC</a>
    /// </summary>
    let hasMAC = _prefixId.prefix "hasMAC"
    /// <summary>
    ///   <para>rdfs:comment : the transmitted power of the LED on the LiFi access point^^xsd:string</para>
    ///   <a href="http://purl.org/toco/hasOpticalTransmittedPower">toco:hasOpticalTransmittedPower</a>
    /// </summary>
    let hasOpticalTransmittedPower = _prefixId.prefix "hasOpticalTransmittedPower"
    /// <summary>
    ///   <para>rdfs:comment : the packet loss rate of a link, usually in percentage.^^xsd:string</para>
    ///   <a href="http://purl.org/toco/hasPacketLoss">toco:hasPacketLoss</a>
    /// </summary>
    let hasPacketLoss = _prefixId.prefix "hasPacketLoss"
    let hasPort = _prefixId.prefix "hasPort"
    /// <summary>
    ///   <para>rdfs:comment : the radiance angle of the light ray transmitted from LED on LiFi access point.^^xsd:string</para>
    ///   <a href="http://purl.org/toco/hasRadianceAngle">toco:hasRadianceAngle</a>
    /// </summary>
    let hasRadianceAngle = _prefixId.prefix "hasRadianceAngle"
    let hasRespansivity = _prefixId.prefix "hasRespansivity"
    /// <summary>
    ///   <para>rdfs:comment : the round trip time of a link, which is the time taken for signal travel a round trip via this link.^^xsd:string</para>
    ///   <a href="http://purl.org/toco/hasRoundTripTime">toco:hasRoundTripTime</a>
    /// </summary>
    let hasRoundTripTime = _prefixId.prefix "hasRoundTripTime"
    let hasSatelliteAssociation = _prefixId.prefix "hasSatelliteAssociation"
    let hasService = _prefixId.prefix "hasService"
    /// <summary>
    ///   <para>rdfs:comment : the time that a service ends.^^xsd:string</para>
    ///   <a href="http://purl.org/toco/hasServiceEndTime">toco:hasServiceEndTime</a>
    /// </summary>
    let hasServiceEndTime = _prefixId.prefix "hasServiceEndTime"
    /// <summary>
    ///   <para>rdfs:comment : the start time of a service.^^xsd:string</para>
    ///   <a href="http://purl.org/toco/hasServiceStartTime">toco:hasServiceStartTime</a>
    /// </summary>
    let hasServiceStartTime = _prefixId.prefix "hasServiceStartTime"
    /// <summary>
    ///   <para>rdfs:comment : the status of the service.^^xsd:string</para>
    ///   <a href="http://purl.org/toco/hasServiceStatus">toco:hasServiceStatus</a>
    /// </summary>
    let hasServiceStatus = _prefixId.prefix "hasServiceStatus"
    /// <summary>
    ///   <para>rdfs:comment : the type of communication services, e.g., video, audio, file transmit, text transmiting, etc.^^xsd:string</para>
    ///   <a href="http://purl.org/toco/hasServiceType">toco:hasServiceType</a>
    /// </summary>
    let hasServiceType = _prefixId.prefix "hasServiceType"
    /// <summary>
    ///   <para>rdfs:comment : After multiple round trip time tested on a link, the deviation of these test results.^^xsd:string</para>
    ///   <a href="http://purl.org/toco/hasStandardDeviation">toco:hasStandardDeviation</a>
    /// </summary>
    let hasStandardDeviation = _prefixId.prefix "hasStandardDeviation"
    let hasThroughPut = _prefixId.prefix "hasThroughPut"
    let hasTransmitPower = _prefixId.prefix "hasTransmitPower"
    let hasTxpower = _prefixId.prefix "hasTxpower"
    let hasUserDeviceStatus = _prefixId.prefix "hasUserDeviceStatus"
    /// <summary>
    ///   <para>rdfs:comment : the user ID of the user^^xsd:string</para>
    ///   <a href="http://purl.org/toco/hasUserID">toco:hasUserID</a>
    /// </summary>
    let hasUserID = _prefixId.prefix "hasUserID"
    let hasWLAN = _prefixId.prefix "hasWLAN"
    let hasWiFiAssociation = _prefixId.prefix "hasWiFiAssociation"
    let hasWiFiWLAN = _prefixId.prefix "hasWiFiWLAN"
    let hasWiredLink = _prefixId.prefix "hasWiredLink"
    let hasWirelessAssociation = _prefixId.prefix "hasWirelessAssociation"
    let hasWirelessLinkProperty = _prefixId.prefix "hasWirelessLinkProperty"
    let idleTimeout = _prefixId.prefix "idleTimeout"
    /// <summary>
    ///   <para>rdfs:comment : the port number of the in port of the flow, or could be a keyword, such as "LOCAL"^^xsd:string</para>
    ///   <a href="http://purl.org/toco/inPort">toco:inPort</a>
    /// </summary>
    let inPort = _prefixId.prefix "inPort"
    /// <summary>
    ///   <para>rdfs:comment : the relation that a interface belongs to a device. A device can have multiple interfaces, but a interface can be in one and only one device.^^xsd:string</para>
    ///   <a href="http://purl.org/toco/isIn">toco:isIn</a>
    /// </summary>
    let isIn = _prefixId.prefix "isIn"
    /// <summary>
    ///   <para>rdfs:comment : indicate whether a interface is up or not.^^xsd:string</para>
    ///   <a href="http://purl.org/toco/isUP">toco:isUP</a>
    /// </summary>
    let isUP = _prefixId.prefix "isUP"
    let license = _prefixId.prefix "license"
    let mode = _prefixId.prefix "mode"
    /// <summary>
    ///   <para>rdfs:comment : network protocol. The nw_proto property of a flow.^^xsd:string</para>
    ///   <a href="http://purl.org/toco/nwProtocol">toco:nwProtocol</a>
    /// </summary>
    let nwProtocol = _prefixId.prefix "nwProtocol"
    /// <summary>
    ///   <para>rdfs:comment : network type of service. the nw_tos property of a flow. It should be a decimal number with the value between 0-255.^^xsd:string</para>
    ///   <a href="http://purl.org/toco/nwTos">toco:nwTos</a>
    /// </summary>
    let nwTos = _prefixId.prefix "nwTos"
    let priority = _prefixId.prefix "priority"
    /// <summary>
    ///   <para>rdfs:comment : the signal range of wireless devices, such as WiFi access point, LiFi access point, WiFi mobile station, and LiFi mobile station.^^xsd:string</para>
    ///   <a href="http://purl.org/toco/range">toco:range</a>
    /// </summary>
    let range = _prefixId.prefix "range"
    /// <summary>
    ///   <para>rdfs:comment : in wireless networks, the ssid of the network this device belongs to.^^xsd:string</para>
    ///   <a href="http://purl.org/toco/ssid">toco:ssid</a>
    /// </summary>
    let ssid = _prefixId.prefix "ssid"
    /// <summary>
    ///   <para>rdfs:comment : in wireless networks (WiFi/LiFi), the mobile stations in the range of the access points.^^xsd:string</para>
    ///   <a href="http://purl.org/toco/stationsInRange">toco:stationsInRange</a>
    /// </summary>
    let stationsInRange = _prefixId.prefix "stationsInRange"
    let tableId = _prefixId.prefix "tableId"
    /// <summary>
    ///   <para>rdfs:comment : the destination node of the link.^^xsd:string</para>
    ///   <a href="http://purl.org/toco/to">toco:to</a>
    /// </summary>
    let to_ = _prefixId.prefix "to"
    /// <summary>
    ///   <para>rdfs:comment : the port number of the port forward to defined by the to_port property of the flow action OUTPUT.^^xsd:string</para>
    ///   <a href="http://purl.org/toco/toPort">toco:toPort</a>
    /// </summary>
    let toPort = _prefixId.prefix "toPort"
    let unReachable = _prefixId.prefix "unReachable"
