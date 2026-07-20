namespace http.purl.org.toco.slash

open DoxAletheia

module toco =
    let _namespace_name = "http://purl.org/toco/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/toco/ConceptEntities"></see>
    /// </summary>
    let ConceptEntities = _prefix "ConceptEntities"
    /// <summary>
    /// a wireless access point, or more generally just access point (AP), is a networking hardware device that allows a Wi-Fi/Li-Fi device to connect to a wired network. The AP usually connects to a router (via a wired network) as a standalone device, but it can also be an integral component of the router itself. An AP is differentiated from a hotspot, which is the physical location where Wi-Fi access to a WLAN is available.
    /// <see href="http://purl.org/toco/AccessPoint"></see></summary>
    let AccessPoint = _prefix "AccessPoint"
    /// <summary>
    /// All the physical facilities in the telecommunication system that provide the communication service to uses. For example: base station towers, Wi-Fi access points, switches, servers, etc.
    /// <see href="http://purl.org/toco/SystemDevice"></see></summary>
    let SystemDevice = _prefix "SystemDevice"
    /// <summary>
    /// the action of a flow defined in OpenFlow protocol
    /// <see href="http://purl.org/toco/Action"></see></summary>
    let Action = _prefix "Action"
    /// <summary>
    ///   <see href="http://purl.org/toco/Attached"></see>
    /// </summary>
    let Attached = _prefix "Attached"
    /// <summary>
    ///   <see href="http://purl.org/toco/UserDeviceStatus"></see>
    /// </summary>
    let UserDeviceStatus = _prefix "UserDeviceStatus"
    /// <summary>
    ///   <see href="http://purl.org/toco/AudioService"></see>
    /// </summary>
    let AudioService = _prefix "AudioService"
    /// <summary>
    /// a communication service, e.g., voice, video, file uploading/downloading, etc.
    /// <see href="http://purl.org/toco/Service"></see></summary>
    let Service = _prefix "Service"
    /// <summary>
    ///   <see href="http://purl.org/toco/AudioSession"></see>
    /// </summary>
    let AudioSession = _prefix "AudioSession"
    /// <summary>
    ///   <see href="http://purl.org/toco/Session"></see>
    /// </summary>
    let Session = _prefix "Session"
    /// <summary>
    /// a "land station in the land mobile service." -- according to the International Telecommunication Union's (ITU) Radio Regulations (RR).
    ///
    /// it is a transceiver connecting a number of other devices to one another and/or to a wider area. In LTE, it is also known as eNodeB.
    /// <see href="http://purl.org/toco/BaseStation"></see></summary>
    let BaseStation = _prefix "BaseStation"
    /// <summary>
    /// User deivce in a Cellular network.
    /// <see href="http://purl.org/toco/CellularUserEquipment"></see></summary>
    let CellularUserEquipment = _prefix "CellularUserEquipment"
    /// <summary>
    /// any device used directly by an end-user to communicate. It can be a hand-held telephone, a laptop computer equipped with a mobile broadband adapter, or any other device.
    /// <see href="http://purl.org/toco/UserEquipment"></see></summary>
    let UserEquipment = _prefix "UserEquipment"
    /// <summary>
    /// Describe all the physical resources in a telecommunication network system, which is divided into three main modules, namely, device, interface, link.
    ///
    /// Please be reminded the electromagnetic wave (which is the links of all wireless communication netwoks), even if it is invisable, physically exists. Thus, it is also described in the subclass of "net;PhysicalInfrastructure".
    /// <see href="http://purl.org/toco/PhysicalInfrastructure"></see></summary>
    let PhysicalInfrastructure = _prefix "PhysicalInfrastructure"
    /// <summary>
    ///   <see href="http://purl.org/toco/Detached"></see>
    /// </summary>
    let Detached = _prefix "Detached"
    /// <summary>
    /// represent all the devices in the physical infrastructure of telecommunciation system.
    ///
    /// According to its user, could be divided into UserDevice and SystemDevice.
    /// <see href="http://purl.org/toco/Device"></see></summary>
    let Device = _prefix "Device"
    /// <summary>
    ///   <see href="http://purl.org/toco/Drop"></see>
    /// </summary>
    let Drop = _prefix "Drop"
    /// <summary>
    ///   <see href="http://purl.org/toco/FileTransferService"></see>
    /// </summary>
    let FileTransferService = _prefix "FileTransferService"
    /// <summary>
    /// the flow entry in a flow table inside a switch or route. Defined by OpenFlow protocol.
    /// <see href="http://purl.org/toco/Flow"></see></summary>
    let Flow = _prefix "Flow"
    /// <summary>
    ///   <see href="http://purl.org/toco/Forward"></see>
    /// </summary>
    let Forward = _prefix "Forward"
    /// <summary>
    /// A host is a computer or other device connected to a computer network. It is a network node that is assigned a network address.
    /// <see href="http://purl.org/toco/Host"></see></summary>
    let Host = _prefix "Host"
    /// <summary>
    /// User Devices, requiring connectivity services, e.g., phones, tablets, laptops, wearable devices, etc.
    /// <see href="http://purl.org/toco/UserDevice"></see></summary>
    let UserDevice = _prefix "UserDevice"
    /// <summary>
    ///   <see href="http://purl.org/toco/Interface"></see>
    /// </summary>
    let Interface = _prefix "Interface"
    /// <summary>
    /// the electromagnetic wave carring modulated signal between LTE base station, or eNodeB, and user equipment
    /// <see href="http://purl.org/toco/LTEAssociation"></see></summary>
    let LTEAssociation = _prefix "LTEAssociation"
    /// <summary>
    /// the electromeganetic radio transmiting through wireless channels in wireless network, carring communication data. Depend on its frequency, it could be visiable light, micro waves, radio waves.
    /// <see href="http://purl.org/toco/WirelessAssociation"></see></summary>
    let WirelessAssociation = _prefix "WirelessAssociation"
    /// <summary>
    /// The access point in Li-Fi network. Li-Fi is a wireless optical networking technology that uses light-emitting diodes (LEDs) for data transmission.
    /// <see href="http://purl.org/toco/LiFiAccessPoint"></see></summary>
    let LiFiAccessPoint = _prefix "LiFiAccessPoint"
    /// <summary>
    /// the visiable light carring modulated signals in Li-Fi network. Transmited and received by LiFi user equipment and LiFi access point.
    /// <see href="http://purl.org/toco/LiFiAssociation"></see></summary>
    let LiFiAssociation = _prefix "LiFiAssociation"
    /// <summary>
    /// any device used directly by an end-user to communicate. It can be a hand-held telephone, a laptop computer equipped with a mobile broadband adapter, or any other device.
    /// <see href="http://purl.org/toco/LiFiUserEquipment"></see></summary>
    let LiFiUserEquipment = _prefix "LiFiUserEquipment"
    /// <summary>
    /// WLAN interface on the devices in LIFi network, e.g., LiFi user equipment, LiFi access point.
    /// <see href="http://purl.org/toco/LiFiWLAN"></see></summary>
    let LiFiWLAN = _prefix "LiFiWLAN"
    /// <summary>
    /// A wireless local area network (WLAN) interface, also known as WLAN, is the interface of a wireless computer network that links two or more devices using wireless communication within a limited area such as a home, school, computer laboratory, or office building.
    /// <see href="http://purl.org/toco/WLAN"></see></summary>
    let WLAN = _prefix "WLAN"
    /// <summary>
    ///   <see href="http://purl.org/toco/Link"></see>
    /// </summary>
    let Link = _prefix "Link"
    /// <summary>
    ///   <see href="http://purl.org/toco/Output"></see>
    /// </summary>
    let Output = _prefix "Output"
    /// <summary>
    ///   <see href="http://purl.org/toco/PathFlow"></see>
    /// </summary>
    let PathFlow = _prefix "PathFlow"
    /// <summary>
    /// the milli-meter electromagnetic wave carring modulated signal between satellite base stations and ground station.
    /// <see href="http://purl.org/toco/SatelliteAssociation"></see></summary>
    let SatelliteAssociation = _prefix "SatelliteAssociation"
    /// <summary>
    /// used in satellite network. Also known as earth station, or earth terminal, it is a terrestrial radio station designed for extraplanetary telecommunication with spacecraft (constituting part of the ground segment of the spacecraft system), or reception of radio waves from astronomical radio sources. Ground stations may be located either on the surface of the Earth, or in its atmosphere.[1] Earth stations communicate with spacecraft by transmitting and receiving radio waves in the super high frequency or extremely high frequency bands (e.g., microwaves). When a ground station successfully transmits radio waves to a spacecraft (or vice versa), it establishes a telecommunications link. A principal telecommunications device of the ground station is the parabolic antenna.
    /// <see href="http://purl.org/toco/SatelliteGroundStation"></see></summary>
    let SatelliteGroundStation = _prefix "SatelliteGroundStation"
    /// <summary>
    /// An artificial satellite, that relays and amplifies radio telecommunications signals via a transponder; it creates a communication channel between a source transmitter and a receiver at different locations on Earth. Communications satellites are used for television, telephone, radio, internet, and military applications.
    /// <see href="http://purl.org/toco/SatelliteRelayStation"></see></summary>
    let SatelliteRelayStation = _prefix "SatelliteRelayStation"
    /// <summary>
    /// A network switch (also called switching hub, bridging hub, officially MAC bridge) is a computer networking device that connects devices together on a computer network by using packet switching to receive, process, and forward data to the destination device.
    /// <see href="http://purl.org/toco/Switch"></see></summary>
    let Switch = _prefix "Switch"
    /// <summary>
    ///   <see href="http://purl.org/toco/Text"></see>
    /// </summary>
    let Text = _prefix "Text"
    /// <summary>
    /// reused from foaf (http://xmlns.com/foaf/0.1/). Represent a user in the telecommunication system.
    /// <see href="http://purl.org/toco/User"></see></summary>
    let User = _prefix "User"
    /// <summary>
    ///   <see href="http://purl.org/toco/VideoService"></see>
    /// </summary>
    let VideoService = _prefix "VideoService"
    /// <summary>
    ///   <see href="http://purl.org/toco/VideoSession"></see>
    /// </summary>
    let VideoSession = _prefix "VideoSession"
    /// <summary>
    /// An access point in a WiFi network
    /// <see href="http://purl.org/toco/WiFiAccessPoint"></see></summary>
    let WiFiAccessPoint = _prefix "WiFiAccessPoint"
    /// <summary>
    /// the electromagnetic wave carring modulated signal between LTE base station, or eNodeB, and user equipment
    /// <see href="http://purl.org/toco/WiFiAssociation"></see></summary>
    let WiFiAssociation = _prefix "WiFiAssociation"
    /// <summary>
    /// a user quipment in Wi-Fi network
    /// <see href="http://purl.org/toco/WiFiUserEquipment"></see></summary>
    let WiFiUserEquipment = _prefix "WiFiUserEquipment"
    /// <summary>
    /// WLAN interface on the devices in LIFi network, e.g., LiFi user equipment, LiFi access point.
    /// <see href="http://purl.org/toco/WiFiWLAN"></see></summary>
    let WiFiWLAN = _prefix "WiFiWLAN"
    /// <summary>
    /// wired link through twisted cable, optical fiber, etc.
    /// <see href="http://purl.org/toco/WiredLink"></see></summary>
    let WiredLink = _prefix "WiredLink"
    /// <summary>
    ///   <see href="http://purl.org/toco/apsInRange"></see>
    /// </summary>
    let apsInRange = _prefix "apsInRange"
    /// <summary>
    ///   <see href="http://purl.org/toco/belongsTo"></see>
    /// </summary>
    let belongsTo = _prefix "belongsTo"
    /// <summary>
    ///   <see href="http://purl.org/toco/hasDevice"></see>
    /// </summary>
    let hasDevice = _prefix "hasDevice"
    /// <summary>
    /// the channel id of a interface.
    /// <see href="http://purl.org/toco/channel"></see></summary>
    let channel = _prefix "channel"
    /// <summary>
    ///   <see href="http://purl.org/toco/contributor"></see>
    /// </summary>
    let contributor = _prefix "contributor"
    /// <summary>
    ///   <see href="http://purl.org/toco/cookie"></see>
    /// </summary>
    let cookie = _prefix "cookie"
    /// <summary>
    ///   <see href="http://purl.org/toco/hasFlowProperty"></see>
    /// </summary>
    let hasFlowProperty = _prefix "hasFlowProperty"
    /// <summary>
    /// the Ethernet destination address of the flow. It should be an MAC address, with 6 pairs of hexadecimal digits.
    /// <see href="http://purl.org/toco/dlDst"></see></summary>
    let dlDst = _prefix "dlDst"
    /// <summary>
    /// the Ethernet source address of the flow. It should be an MAC address with 6 pairs of hexadecimal digits
    /// <see href="http://purl.org/toco/dlSrc"></see></summary>
    let dlSrc = _prefix "dlSrc"
    /// <summary>
    ///   <see href="http://purl.org/toco/driver"></see>
    /// </summary>
    let driver = _prefix "driver"
    /// <summary>
    ///   <see href="http://purl.org/toco/flags"></see>
    /// </summary>
    let flags = _prefix "flags"
    /// <summary>
    /// the frequency of the radio wave transmitted by a wireless interface (WLAN).
    /// <see href="http://purl.org/toco/frequency"></see></summary>
    let frequency = _prefix "frequency"
    /// <summary>
    /// the source node that the link is transmit from.
    /// <see href="http://purl.org/toco/from"></see></summary>
    let from = _prefix "from"
    /// <summary>
    ///   <see href="http://purl.org/toco/hardTimeout"></see>
    /// </summary>
    let hardTimeout = _prefix "hardTimeout"
    /// <summary>
    /// the gain of an antenna on the wireless interface.
    /// <see href="http://purl.org/toco/hasAntennaGain"></see></summary>
    let hasAntennaGain = _prefix "hasAntennaGain"
    /// <summary>
    /// the height of the antenna of a wireless interface
    /// <see href="http://purl.org/toco/hasAntennaHeight"></see></summary>
    let hasAntennaHeight = _prefix "hasAntennaHeight"
    /// <summary>
    /// in wireless networks, the user equipments (mobile stations in another term, e.g., phones, laptops, tablets, etc.) that are associated to the access point.
    /// <see href="http://purl.org/toco/hasAssociatedStations"></see></summary>
    let hasAssociatedStations = _prefix "hasAssociatedStations"
    /// <summary>
    /// the bandwidth of the link
    /// <see href="http://purl.org/toco/hasBandwidth"></see></summary>
    let hasBandwidth = _prefix "hasBandwidth"
    /// <summary>
    ///   <see href="http://purl.org/toco/hasLinkProperty"></see>
    /// </summary>
    let hasLinkProperty = _prefix "hasLinkProperty"
    /// <summary>
    ///   <see href="http://purl.org/toco/hasDatarate"></see>
    /// </summary>
    let hasDatarate = _prefix "hasDatarate"
    /// <summary>
    /// the Euclidean distance between the LiFi user equipment and access point.
    /// <see href="http://purl.org/toco/hasDistance"></see></summary>
    let hasDistance = _prefix "hasDistance"
    /// <summary>
    /// The properties of the visiable light association between the LED on LiFi access point and LiFi user equipment.
    /// <see href="http://purl.org/toco/hasLiFiAssociationProperty"></see></summary>
    let hasLiFiAssociationProperty = _prefix "hasLiFiAssociationProperty"
    /// <summary>
    /// the error code of a service.
    /// <see href="http://purl.org/toco/hasErrorCode"></see></summary>
    let hasErrorCode = _prefix "hasErrorCode"
    /// <summary>
    /// Field of view (FOV) is the open observable area where a LiFi user equipment could receive visiable light signal. It is defined by let the incident angle of the LiFi user equipment equals to Pi/2.
    ///
    /// If the incident angle larger than Pi/2, the light ray is out of the FOV, thus cannot be received by the LiFi user equipment.
    /// <see href="http://purl.org/toco/hasFieldOfView"></see></summary>
    let hasFieldOfView = _prefix "hasFieldOfView"
    /// <summary>
    /// properties of LiFi user equipments.
    /// <see href="http://purl.org/toco/hasLiFiUserEquipmentProperty"></see></summary>
    let hasLiFiUserEquipmentProperty = _prefix "hasLiFiUserEquipmentProperty"
    /// <summary>
    ///   <see href="http://purl.org/toco/hasFlow"></see>
    /// </summary>
    let hasFlow = _prefix "hasFlow"
    /// <summary>
    ///   <see href="http://purl.org/toco/hasFlowAction"></see>
    /// </summary>
    let hasFlowAction = _prefix "hasFlowAction"
    /// <summary>
    /// The gain of the concentrator on the LiFi user equipment, usually equals to 1.
    /// <see href="http://purl.org/toco/hasGainOfConcentrator"></see></summary>
    let hasGainOfConcentrator = _prefix "hasGainOfConcentrator"
    /// <summary>
    /// Gain of optical filter on LiFi access point.
    /// <see href="http://purl.org/toco/hasGainofOpticalFilter"></see></summary>
    let hasGainofOpticalFilter = _prefix "hasGainofOpticalFilter"
    /// <summary>
    /// datatype properties dedicated for LiFi access points
    /// <see href="http://purl.org/toco/hasLiFiAccessPointProperty"></see></summary>
    let hasLiFiAccessPointProperty = _prefix "hasLiFiAccessPointProperty"
    /// <summary>
    /// The angle of half intensity of the LED light transmiting visible light signal in a LiFi access point.
    ///
    /// A fixed value. It is the angle where the radiated intensity will be half as intense as it would be at 0 degrees, or pointing straight ahead.
    ///
    /// Factors that contribute to the angle of half intensity include the amount of diffusing material in the epoxy, the shape of the reflector cup which surrounds the LED chip, the shape of the LED lens, the distance from the LED to the tip of the lens, and the type of emitter chip.
    ///
    /// The most common value is Pi/3.
    /// <see href="http://purl.org/toco/hasHalfIntensityAngle"></see></summary>
    let hasHalfIntensityAngle = _prefix "hasHalfIntensityAngle"
    /// <summary>
    /// the IP address of the interface.
    /// <see href="http://purl.org/toco/hasIP"></see></summary>
    let hasIP = _prefix "hasIP"
    /// <summary>
    /// The angle of incidence of the LED receiver on LiFi user equipment, which is the angle between the visiable light ray incident on a surface and the line perpendicular to the surface at the point of incidence, called the normal.
    /// <see href="http://purl.org/toco/hasIncidentAngle"></see></summary>
    let hasIncidentAngle = _prefix "hasIncidentAngle"
    /// <summary>
    /// the fact that a device has a interface.
    /// <see href="http://purl.org/toco/hasInterface"></see></summary>
    let hasInterface = _prefix "hasInterface"
    /// <summary>
    /// the relation that a interface belongs to a device. A device can have multiple interfaces, but a interface can be in one and only one device.
    /// <see href="http://purl.org/toco/isIn"></see></summary>
    let isIn = _prefix "isIn"
    /// <summary>
    /// the port number of an interface
    /// <see href="http://purl.org/toco/hasInterfaceName"></see></summary>
    let hasInterfaceName = _prefix "hasInterfaceName"
    /// <summary>
    /// the join date of the user device
    /// <see href="http://purl.org/toco/hasJoinDate"></see></summary>
    let hasJoinDate = _prefix "hasJoinDate"
    /// <summary>
    ///   <see href="http://purl.org/toco/hasLTEAssociation"></see>
    /// </summary>
    let hasLTEAssociation = _prefix "hasLTEAssociation"
    /// <summary>
    ///   <see href="http://purl.org/toco/hasWirelessAssociation"></see>
    /// </summary>
    let hasWirelessAssociation = _prefix "hasWirelessAssociation"
    /// <summary>
    ///   <see href="http://purl.org/toco/hasLiFiAssociation"></see>
    /// </summary>
    let hasLiFiAssociation = _prefix "hasLiFiAssociation"
    /// <summary>
    ///   <see href="http://purl.org/toco/hasWirelessLinkProperty"></see>
    /// </summary>
    let hasWirelessLinkProperty = _prefix "hasWirelessLinkProperty"
    /// <summary>
    ///   <see href="http://purl.org/toco/hasLiFiWLAN"></see>
    /// </summary>
    let hasLiFiWLAN = _prefix "hasLiFiWLAN"
    /// <summary>
    ///   <see href="http://purl.org/toco/hasWLAN"></see>
    /// </summary>
    let hasWLAN = _prefix "hasWLAN"
    /// <summary>
    ///   <see href="http://purl.org/toco/hasLink"></see>
    /// </summary>
    let hasLink = _prefix "hasLink"
    /// <summary>
    /// the MAC address of the interface.
    /// <see href="http://purl.org/toco/hasMAC"></see></summary>
    let hasMAC = _prefix "hasMAC"
    /// <summary>
    /// the transmitted power of the LED on the LiFi access point
    /// <see href="http://purl.org/toco/hasOpticalTransmittedPower"></see></summary>
    let hasOpticalTransmittedPower = _prefix "hasOpticalTransmittedPower"
    /// <summary>
    /// the packet loss rate of a link, usually in percentage.
    /// <see href="http://purl.org/toco/hasPacketLoss"></see></summary>
    let hasPacketLoss = _prefix "hasPacketLoss"
    /// <summary>
    ///   <see href="http://purl.org/toco/hasPort"></see>
    /// </summary>
    let hasPort = _prefix "hasPort"
    /// <summary>
    /// the radiance angle of the light ray transmitted from LED on LiFi access point.
    /// <see href="http://purl.org/toco/hasRadianceAngle"></see></summary>
    let hasRadianceAngle = _prefix "hasRadianceAngle"
    /// <summary>
    ///   <see href="http://purl.org/toco/hasRespansivity"></see>
    /// </summary>
    let hasRespansivity = _prefix "hasRespansivity"
    /// <summary>
    /// the round trip time of a link, which is the time taken for signal travel a round trip via this link.
    /// <see href="http://purl.org/toco/hasRoundTripTime"></see></summary>
    let hasRoundTripTime = _prefix "hasRoundTripTime"
    /// <summary>
    ///   <see href="http://purl.org/toco/hasSatelliteAssociation"></see>
    /// </summary>
    let hasSatelliteAssociation = _prefix "hasSatelliteAssociation"
    /// <summary>
    ///   <see href="http://purl.org/toco/hasService"></see>
    /// </summary>
    let hasService = _prefix "hasService"
    /// <summary>
    /// the time that a service ends.
    /// <see href="http://purl.org/toco/hasServiceEndTime"></see></summary>
    let hasServiceEndTime = _prefix "hasServiceEndTime"
    /// <summary>
    /// the start time of a service.
    /// <see href="http://purl.org/toco/hasServiceStartTime"></see></summary>
    let hasServiceStartTime = _prefix "hasServiceStartTime"
    /// <summary>
    /// the status of the service.
    /// <see href="http://purl.org/toco/hasServiceStatus"></see></summary>
    let hasServiceStatus = _prefix "hasServiceStatus"
    /// <summary>
    /// the type of communication services, e.g., video, audio, file transmit, text transmiting, etc.
    /// <see href="http://purl.org/toco/hasServiceType"></see></summary>
    let hasServiceType = _prefix "hasServiceType"
    /// <summary>
    /// After multiple round trip time tested on a link, the deviation of these test results.
    /// <see href="http://purl.org/toco/hasStandardDeviation"></see></summary>
    let hasStandardDeviation = _prefix "hasStandardDeviation"
    /// <summary>
    ///   <see href="http://purl.org/toco/hasThroughPut"></see>
    /// </summary>
    let hasThroughPut = _prefix "hasThroughPut"
    /// <summary>
    ///   <see href="http://purl.org/toco/hasTransmitPower"></see>
    /// </summary>
    let hasTransmitPower = _prefix "hasTransmitPower"
    /// <summary>
    ///   <see href="http://purl.org/toco/hasTxpower"></see>
    /// </summary>
    let hasTxpower = _prefix "hasTxpower"
    /// <summary>
    ///   <see href="http://purl.org/toco/hasUserDeviceStatus"></see>
    /// </summary>
    let hasUserDeviceStatus = _prefix "hasUserDeviceStatus"
    /// <summary>
    /// the user ID of the user
    /// <see href="http://purl.org/toco/hasUserID"></see></summary>
    let hasUserID = _prefix "hasUserID"
    /// <summary>
    ///   <see href="http://purl.org/toco/hasWiFiAssociation"></see>
    /// </summary>
    let hasWiFiAssociation = _prefix "hasWiFiAssociation"
    /// <summary>
    ///   <see href="http://purl.org/toco/hasWiFiWLAN"></see>
    /// </summary>
    let hasWiFiWLAN = _prefix "hasWiFiWLAN"
    /// <summary>
    ///   <see href="http://purl.org/toco/hasWiredLink"></see>
    /// </summary>
    let hasWiredLink = _prefix "hasWiredLink"
    /// <summary>
    ///   <see href="http://purl.org/toco/idleTimeout"></see>
    /// </summary>
    let idleTimeout = _prefix "idleTimeout"
    /// <summary>
    /// the port number of the in port of the flow, or could be a keyword, such as "LOCAL"
    /// <see href="http://purl.org/toco/inPort"></see></summary>
    let inPort = _prefix "inPort"
    /// <summary>
    /// indicate whether a interface is up or not.
    /// <see href="http://purl.org/toco/isUP"></see></summary>
    let isUP = _prefix "isUP"
    /// <summary>
    ///   <see href="http://purl.org/toco/license"></see>
    /// </summary>
    let license = _prefix "license"
    /// <summary>
    ///   <see href="http://purl.org/toco/mode"></see>
    /// </summary>
    let mode = _prefix "mode"
    /// <summary>
    /// network protocol. The nw_proto property of a flow.
    /// <see href="http://purl.org/toco/nwProtocol"></see></summary>
    let nwProtocol = _prefix "nwProtocol"
    /// <summary>
    /// network type of service. the nw_tos property of a flow. It should be a decimal number with the value between 0-255.
    /// <see href="http://purl.org/toco/nwTos"></see></summary>
    let nwTos = _prefix "nwTos"
    /// <summary>
    ///   <see href="http://purl.org/toco/priority"></see>
    /// </summary>
    let priority = _prefix "priority"
    /// <summary>
    /// the signal range of wireless devices, such as WiFi access point, LiFi access point, WiFi mobile station, and LiFi mobile station.
    /// <see href="http://purl.org/toco/range"></see></summary>
    let range = _prefix "range"
    /// <summary>
    /// in wireless networks, the ssid of the network this device belongs to.
    /// <see href="http://purl.org/toco/ssid"></see></summary>
    let ssid = _prefix "ssid"
    /// <summary>
    /// in wireless networks (WiFi/LiFi), the mobile stations in the range of the access points.
    /// <see href="http://purl.org/toco/stationsInRange"></see></summary>
    let stationsInRange = _prefix "stationsInRange"
    /// <summary>
    ///   <see href="http://purl.org/toco/tableId"></see>
    /// </summary>
    let tableId = _prefix "tableId"
    /// <summary>
    /// the destination node of the link.
    /// <see href="http://purl.org/toco/to"></see></summary>
    let to_ = _prefix "to"
    /// <summary>
    /// the port number of the port forward to defined by the to_port property of the flow action OUTPUT.
    /// <see href="http://purl.org/toco/toPort"></see></summary>
    let toPort = _prefix "toPort"
    /// <summary>
    ///   <see href="http://purl.org/toco/unReachable"></see>
    /// </summary>
    let unReachable = _prefix "unReachable"
