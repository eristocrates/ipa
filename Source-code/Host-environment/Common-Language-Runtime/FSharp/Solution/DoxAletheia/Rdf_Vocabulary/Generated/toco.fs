namespace http.purl.org.toco.slash

open DoxAletheia.Rdf_Vocabulary

module toco =
    let _namespace_name = "http://purl.org/toco/"

    /// <summary>
    ///   <see href="http://purl.org/toco/ConceptEntities"></see>
    /// </summary>
    let ConceptEntities =
        Namespaced_IRI.parse _namespace_name "ConceptEntities" |> NamespacedName

    /// <summary>
    /// a wireless access point, or more generally just access point (AP), is a networking hardware device that allows a Wi-Fi/Li-Fi device to connect to a wired network. The AP usually connects to a router (via a wired network) as a standalone device, but it can also be an integral component of the router itself. An AP is differentiated from a hotspot, which is the physical location where Wi-Fi access to a WLAN is available.
    /// <see href="http://purl.org/toco/AccessPoint"></see></summary>
    let AccessPoint =
        Namespaced_IRI.parse _namespace_name "AccessPoint" |> NamespacedName

    /// <summary>
    /// All the physical facilities in the telecommunication system that provide the communication service to uses. For example: base station towers, Wi-Fi access points, switches, servers, etc.
    /// <see href="http://purl.org/toco/SystemDevice"></see></summary>
    let SystemDevice =
        Namespaced_IRI.parse _namespace_name "SystemDevice" |> NamespacedName

    /// <summary>
    /// the action of a flow defined in OpenFlow protocol
    /// <see href="http://purl.org/toco/Action"></see></summary>
    let Action = Namespaced_IRI.parse _namespace_name "Action" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/toco/Attached"></see>
    /// </summary>
    let Attached = Namespaced_IRI.parse _namespace_name "Attached" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/toco/UserDeviceStatus"></see>
    /// </summary>
    let UserDeviceStatus =
        Namespaced_IRI.parse _namespace_name "UserDeviceStatus" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/toco/AudioService"></see>
    /// </summary>
    let AudioService =
        Namespaced_IRI.parse _namespace_name "AudioService" |> NamespacedName

    /// <summary>
    /// a communication service, e.g., voice, video, file uploading/downloading, etc.
    /// <see href="http://purl.org/toco/Service"></see></summary>
    let Service = Namespaced_IRI.parse _namespace_name "Service" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/toco/AudioSession"></see>
    /// </summary>
    let AudioSession =
        Namespaced_IRI.parse _namespace_name "AudioSession" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/toco/Session"></see>
    /// </summary>
    let Session = Namespaced_IRI.parse _namespace_name "Session" |> NamespacedName

    /// <summary>
    /// a "land station in the land mobile service." -- according to the International Telecommunication Union's (ITU) Radio Regulations (RR).
    ///
    /// it is a transceiver connecting a number of other devices to one another and/or to a wider area. In LTE, it is also known as eNodeB.
    /// <see href="http://purl.org/toco/BaseStation"></see></summary>
    let BaseStation =
        Namespaced_IRI.parse _namespace_name "BaseStation" |> NamespacedName

    /// <summary>
    /// User deivce in a Cellular network.
    /// <see href="http://purl.org/toco/CellularUserEquipment"></see></summary>
    let CellularUserEquipment =
        Namespaced_IRI.parse _namespace_name "CellularUserEquipment" |> NamespacedName

    /// <summary>
    /// any device used directly by an end-user to communicate. It can be a hand-held telephone, a laptop computer equipped with a mobile broadband adapter, or any other device.
    /// <see href="http://purl.org/toco/UserEquipment"></see></summary>
    let UserEquipment =
        Namespaced_IRI.parse _namespace_name "UserEquipment" |> NamespacedName

    /// <summary>
    /// Describe all the physical resources in a telecommunication network system, which is divided into three main modules, namely, device, interface, link.
    ///
    /// Please be reminded the electromagnetic wave (which is the links of all wireless communication netwoks), even if it is invisable, physically exists. Thus, it is also described in the subclass of "net;PhysicalInfrastructure".
    /// <see href="http://purl.org/toco/PhysicalInfrastructure"></see></summary>
    let PhysicalInfrastructure =
        Namespaced_IRI.parse _namespace_name "PhysicalInfrastructure" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/toco/Detached"></see>
    /// </summary>
    let Detached = Namespaced_IRI.parse _namespace_name "Detached" |> NamespacedName
    /// <summary>
    /// represent all the devices in the physical infrastructure of telecommunciation system.
    ///
    /// According to its user, could be divided into UserDevice and SystemDevice.
    /// <see href="http://purl.org/toco/Device"></see></summary>
    let Device = Namespaced_IRI.parse _namespace_name "Device" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/toco/Drop"></see>
    /// </summary>
    let Drop = Namespaced_IRI.parse _namespace_name "Drop" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/toco/FileTransferService"></see>
    /// </summary>
    let FileTransferService =
        Namespaced_IRI.parse _namespace_name "FileTransferService" |> NamespacedName

    /// <summary>
    /// the flow entry in a flow table inside a switch or route. Defined by OpenFlow protocol.
    /// <see href="http://purl.org/toco/Flow"></see></summary>
    let Flow = Namespaced_IRI.parse _namespace_name "Flow" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/toco/Forward"></see>
    /// </summary>
    let Forward = Namespaced_IRI.parse _namespace_name "Forward" |> NamespacedName
    /// <summary>
    /// A host is a computer or other device connected to a computer network. It is a network node that is assigned a network address.
    /// <see href="http://purl.org/toco/Host"></see></summary>
    let Host = Namespaced_IRI.parse _namespace_name "Host" |> NamespacedName
    /// <summary>
    /// User Devices, requiring connectivity services, e.g., phones, tablets, laptops, wearable devices, etc.
    /// <see href="http://purl.org/toco/UserDevice"></see></summary>
    let UserDevice = Namespaced_IRI.parse _namespace_name "UserDevice" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/toco/Interface"></see>
    /// </summary>
    let Interface = Namespaced_IRI.parse _namespace_name "Interface" |> NamespacedName

    /// <summary>
    /// the electromagnetic wave carring modulated signal between LTE base station, or eNodeB, and user equipment
    /// <see href="http://purl.org/toco/LTEAssociation"></see></summary>
    let LTEAssociation =
        Namespaced_IRI.parse _namespace_name "LTEAssociation" |> NamespacedName

    /// <summary>
    /// the electromeganetic radio transmiting through wireless channels in wireless network, carring communication data. Depend on its frequency, it could be visiable light, micro waves, radio waves.
    /// <see href="http://purl.org/toco/WirelessAssociation"></see></summary>
    let WirelessAssociation =
        Namespaced_IRI.parse _namespace_name "WirelessAssociation" |> NamespacedName

    /// <summary>
    /// The access point in Li-Fi network. Li-Fi is a wireless optical networking technology that uses light-emitting diodes (LEDs) for data transmission.
    /// <see href="http://purl.org/toco/LiFiAccessPoint"></see></summary>
    let LiFiAccessPoint =
        Namespaced_IRI.parse _namespace_name "LiFiAccessPoint" |> NamespacedName

    /// <summary>
    /// the visiable light carring modulated signals in Li-Fi network. Transmited and received by LiFi user equipment and LiFi access point.
    /// <see href="http://purl.org/toco/LiFiAssociation"></see></summary>
    let LiFiAssociation =
        Namespaced_IRI.parse _namespace_name "LiFiAssociation" |> NamespacedName

    /// <summary>
    /// any device used directly by an end-user to communicate. It can be a hand-held telephone, a laptop computer equipped with a mobile broadband adapter, or any other device.
    /// <see href="http://purl.org/toco/LiFiUserEquipment"></see></summary>
    let LiFiUserEquipment =
        Namespaced_IRI.parse _namespace_name "LiFiUserEquipment" |> NamespacedName

    /// <summary>
    /// WLAN interface on the devices in LIFi network, e.g., LiFi user equipment, LiFi access point.
    /// <see href="http://purl.org/toco/LiFiWLAN"></see></summary>
    let LiFiWLAN = Namespaced_IRI.parse _namespace_name "LiFiWLAN" |> NamespacedName
    /// <summary>
    /// A wireless local area network (WLAN) interface, also known as WLAN, is the interface of a wireless computer network that links two or more devices using wireless communication within a limited area such as a home, school, computer laboratory, or office building.
    /// <see href="http://purl.org/toco/WLAN"></see></summary>
    let WLAN = Namespaced_IRI.parse _namespace_name "WLAN" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/toco/Link"></see>
    /// </summary>
    let Link = Namespaced_IRI.parse _namespace_name "Link" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/toco/Output"></see>
    /// </summary>
    let Output = Namespaced_IRI.parse _namespace_name "Output" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/toco/PathFlow"></see>
    /// </summary>
    let PathFlow = Namespaced_IRI.parse _namespace_name "PathFlow" |> NamespacedName

    /// <summary>
    /// the milli-meter electromagnetic wave carring modulated signal between satellite base stations and ground station.
    /// <see href="http://purl.org/toco/SatelliteAssociation"></see></summary>
    let SatelliteAssociation =
        Namespaced_IRI.parse _namespace_name "SatelliteAssociation" |> NamespacedName

    /// <summary>
    /// used in satellite network. Also known as earth station, or earth terminal, it is a terrestrial radio station designed for extraplanetary telecommunication with spacecraft (constituting part of the ground segment of the spacecraft system), or reception of radio waves from astronomical radio sources. Ground stations may be located either on the surface of the Earth, or in its atmosphere.[1] Earth stations communicate with spacecraft by transmitting and receiving radio waves in the super high frequency or extremely high frequency bands (e.g., microwaves). When a ground station successfully transmits radio waves to a spacecraft (or vice versa), it establishes a telecommunications link. A principal telecommunications device of the ground station is the parabolic antenna.
    /// <see href="http://purl.org/toco/SatelliteGroundStation"></see></summary>
    let SatelliteGroundStation =
        Namespaced_IRI.parse _namespace_name "SatelliteGroundStation" |> NamespacedName

    /// <summary>
    /// An artificial satellite, that relays and amplifies radio telecommunications signals via a transponder; it creates a communication channel between a source transmitter and a receiver at different locations on Earth. Communications satellites are used for television, telephone, radio, internet, and military applications.
    /// <see href="http://purl.org/toco/SatelliteRelayStation"></see></summary>
    let SatelliteRelayStation =
        Namespaced_IRI.parse _namespace_name "SatelliteRelayStation" |> NamespacedName

    /// <summary>
    /// A network switch (also called switching hub, bridging hub, officially MAC bridge) is a computer networking device that connects devices together on a computer network by using packet switching to receive, process, and forward data to the destination device.
    /// <see href="http://purl.org/toco/Switch"></see></summary>
    let Switch = Namespaced_IRI.parse _namespace_name "Switch" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/toco/Text"></see>
    /// </summary>
    let Text = Namespaced_IRI.parse _namespace_name "Text" |> NamespacedName
    /// <summary>
    /// reused from foaf (http://xmlns.com/foaf/0.1/). Represent a user in the telecommunication system.
    /// <see href="http://purl.org/toco/User"></see></summary>
    let User = Namespaced_IRI.parse _namespace_name "User" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/toco/VideoService"></see>
    /// </summary>
    let VideoService =
        Namespaced_IRI.parse _namespace_name "VideoService" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/toco/VideoSession"></see>
    /// </summary>
    let VideoSession =
        Namespaced_IRI.parse _namespace_name "VideoSession" |> NamespacedName

    /// <summary>
    /// An access point in a WiFi network
    /// <see href="http://purl.org/toco/WiFiAccessPoint"></see></summary>
    let WiFiAccessPoint =
        Namespaced_IRI.parse _namespace_name "WiFiAccessPoint" |> NamespacedName

    /// <summary>
    /// the electromagnetic wave carring modulated signal between LTE base station, or eNodeB, and user equipment
    /// <see href="http://purl.org/toco/WiFiAssociation"></see></summary>
    let WiFiAssociation =
        Namespaced_IRI.parse _namespace_name "WiFiAssociation" |> NamespacedName

    /// <summary>
    /// a user quipment in Wi-Fi network
    /// <see href="http://purl.org/toco/WiFiUserEquipment"></see></summary>
    let WiFiUserEquipment =
        Namespaced_IRI.parse _namespace_name "WiFiUserEquipment" |> NamespacedName

    /// <summary>
    /// WLAN interface on the devices in LIFi network, e.g., LiFi user equipment, LiFi access point.
    /// <see href="http://purl.org/toco/WiFiWLAN"></see></summary>
    let WiFiWLAN = Namespaced_IRI.parse _namespace_name "WiFiWLAN" |> NamespacedName
    /// <summary>
    /// wired link through twisted cable, optical fiber, etc.
    /// <see href="http://purl.org/toco/WiredLink"></see></summary>
    let WiredLink = Namespaced_IRI.parse _namespace_name "WiredLink" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/toco/apsInRange"></see>
    /// </summary>
    let apsInRange = Namespaced_IRI.parse _namespace_name "apsInRange" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/toco/belongsTo"></see>
    /// </summary>
    let belongsTo = Namespaced_IRI.parse _namespace_name "belongsTo" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/toco/hasDevice"></see>
    /// </summary>
    let hasDevice = Namespaced_IRI.parse _namespace_name "hasDevice" |> NamespacedName
    /// <summary>
    /// the channel id of a interface.
    /// <see href="http://purl.org/toco/channel"></see></summary>
    let channel = Namespaced_IRI.parse _namespace_name "channel" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/toco/contributor"></see>
    /// </summary>
    let contributor =
        Namespaced_IRI.parse _namespace_name "contributor" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/toco/cookie"></see>
    /// </summary>
    let cookie = Namespaced_IRI.parse _namespace_name "cookie" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/toco/hasFlowProperty"></see>
    /// </summary>
    let hasFlowProperty =
        Namespaced_IRI.parse _namespace_name "hasFlowProperty" |> NamespacedName

    /// <summary>
    /// the Ethernet destination address of the flow. It should be an MAC address, with 6 pairs of hexadecimal digits.
    /// <see href="http://purl.org/toco/dlDst"></see></summary>
    let dlDst = Namespaced_IRI.parse _namespace_name "dlDst" |> NamespacedName
    /// <summary>
    /// the Ethernet source address of the flow. It should be an MAC address with 6 pairs of hexadecimal digits
    /// <see href="http://purl.org/toco/dlSrc"></see></summary>
    let dlSrc = Namespaced_IRI.parse _namespace_name "dlSrc" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/toco/driver"></see>
    /// </summary>
    let driver = Namespaced_IRI.parse _namespace_name "driver" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/toco/flags"></see>
    /// </summary>
    let flags = Namespaced_IRI.parse _namespace_name "flags" |> NamespacedName
    /// <summary>
    /// the frequency of the radio wave transmitted by a wireless interface (WLAN).
    /// <see href="http://purl.org/toco/frequency"></see></summary>
    let frequency = Namespaced_IRI.parse _namespace_name "frequency" |> NamespacedName
    /// <summary>
    /// the source node that the link is transmit from.
    /// <see href="http://purl.org/toco/from"></see></summary>
    let from = Namespaced_IRI.parse _namespace_name "from" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/toco/hardTimeout"></see>
    /// </summary>
    let hardTimeout =
        Namespaced_IRI.parse _namespace_name "hardTimeout" |> NamespacedName

    /// <summary>
    /// the gain of an antenna on the wireless interface.
    /// <see href="http://purl.org/toco/hasAntennaGain"></see></summary>
    let hasAntennaGain =
        Namespaced_IRI.parse _namespace_name "hasAntennaGain" |> NamespacedName

    /// <summary>
    /// the height of the antenna of a wireless interface
    /// <see href="http://purl.org/toco/hasAntennaHeight"></see></summary>
    let hasAntennaHeight =
        Namespaced_IRI.parse _namespace_name "hasAntennaHeight" |> NamespacedName

    /// <summary>
    /// in wireless networks, the user equipments (mobile stations in another term, e.g., phones, laptops, tablets, etc.) that are associated to the access point.
    /// <see href="http://purl.org/toco/hasAssociatedStations"></see></summary>
    let hasAssociatedStations =
        Namespaced_IRI.parse _namespace_name "hasAssociatedStations" |> NamespacedName

    /// <summary>
    /// the bandwidth of the link
    /// <see href="http://purl.org/toco/hasBandwidth"></see></summary>
    let hasBandwidth =
        Namespaced_IRI.parse _namespace_name "hasBandwidth" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/toco/hasLinkProperty"></see>
    /// </summary>
    let hasLinkProperty =
        Namespaced_IRI.parse _namespace_name "hasLinkProperty" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/toco/hasDatarate"></see>
    /// </summary>
    let hasDatarate =
        Namespaced_IRI.parse _namespace_name "hasDatarate" |> NamespacedName

    /// <summary>
    /// the Euclidean distance between the LiFi user equipment and access point.
    /// <see href="http://purl.org/toco/hasDistance"></see></summary>
    let hasDistance =
        Namespaced_IRI.parse _namespace_name "hasDistance" |> NamespacedName

    /// <summary>
    /// The properties of the visiable light association between the LED on LiFi access point and LiFi user equipment.
    /// <see href="http://purl.org/toco/hasLiFiAssociationProperty"></see></summary>
    let hasLiFiAssociationProperty =
        Namespaced_IRI.parse _namespace_name "hasLiFiAssociationProperty" |> NamespacedName

    /// <summary>
    /// the error code of a service.
    /// <see href="http://purl.org/toco/hasErrorCode"></see></summary>
    let hasErrorCode =
        Namespaced_IRI.parse _namespace_name "hasErrorCode" |> NamespacedName

    /// <summary>
    /// Field of view (FOV) is the open observable area where a LiFi user equipment could receive visiable light signal. It is defined by let the incident angle of the LiFi user equipment equals to Pi/2.
    ///
    /// If the incident angle larger than Pi/2, the light ray is out of the FOV, thus cannot be received by the LiFi user equipment.
    /// <see href="http://purl.org/toco/hasFieldOfView"></see></summary>
    let hasFieldOfView =
        Namespaced_IRI.parse _namespace_name "hasFieldOfView" |> NamespacedName

    /// <summary>
    /// properties of LiFi user equipments.
    /// <see href="http://purl.org/toco/hasLiFiUserEquipmentProperty"></see></summary>
    let hasLiFiUserEquipmentProperty =
        Namespaced_IRI.parse _namespace_name "hasLiFiUserEquipmentProperty" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/toco/hasFlow"></see>
    /// </summary>
    let hasFlow = Namespaced_IRI.parse _namespace_name "hasFlow" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/toco/hasFlowAction"></see>
    /// </summary>
    let hasFlowAction =
        Namespaced_IRI.parse _namespace_name "hasFlowAction" |> NamespacedName

    /// <summary>
    /// The gain of the concentrator on the LiFi user equipment, usually equals to 1.
    /// <see href="http://purl.org/toco/hasGainOfConcentrator"></see></summary>
    let hasGainOfConcentrator =
        Namespaced_IRI.parse _namespace_name "hasGainOfConcentrator" |> NamespacedName

    /// <summary>
    /// Gain of optical filter on LiFi access point.
    /// <see href="http://purl.org/toco/hasGainofOpticalFilter"></see></summary>
    let hasGainofOpticalFilter =
        Namespaced_IRI.parse _namespace_name "hasGainofOpticalFilter" |> NamespacedName

    /// <summary>
    /// datatype properties dedicated for LiFi access points
    /// <see href="http://purl.org/toco/hasLiFiAccessPointProperty"></see></summary>
    let hasLiFiAccessPointProperty =
        Namespaced_IRI.parse _namespace_name "hasLiFiAccessPointProperty" |> NamespacedName

    /// <summary>
    /// The angle of half intensity of the LED light transmiting visible light signal in a LiFi access point.
    ///
    /// A fixed value. It is the angle where the radiated intensity will be half as intense as it would be at 0 degrees, or pointing straight ahead.
    ///
    /// Factors that contribute to the angle of half intensity include the amount of diffusing material in the epoxy, the shape of the reflector cup which surrounds the LED chip, the shape of the LED lens, the distance from the LED to the tip of the lens, and the type of emitter chip.
    ///
    /// The most common value is Pi/3.
    /// <see href="http://purl.org/toco/hasHalfIntensityAngle"></see></summary>
    let hasHalfIntensityAngle =
        Namespaced_IRI.parse _namespace_name "hasHalfIntensityAngle" |> NamespacedName

    /// <summary>
    /// the IP address of the interface.
    /// <see href="http://purl.org/toco/hasIP"></see></summary>
    let hasIP = Namespaced_IRI.parse _namespace_name "hasIP" |> NamespacedName

    /// <summary>
    /// The angle of incidence of the LED receiver on LiFi user equipment, which is the angle between the visiable light ray incident on a surface and the line perpendicular to the surface at the point of incidence, called the normal.
    /// <see href="http://purl.org/toco/hasIncidentAngle"></see></summary>
    let hasIncidentAngle =
        Namespaced_IRI.parse _namespace_name "hasIncidentAngle" |> NamespacedName

    /// <summary>
    /// the fact that a device has a interface.
    /// <see href="http://purl.org/toco/hasInterface"></see></summary>
    let hasInterface =
        Namespaced_IRI.parse _namespace_name "hasInterface" |> NamespacedName

    /// <summary>
    /// the relation that a interface belongs to a device. A device can have multiple interfaces, but a interface can be in one and only one device.
    /// <see href="http://purl.org/toco/isIn"></see></summary>
    let isIn = Namespaced_IRI.parse _namespace_name "isIn" |> NamespacedName

    /// <summary>
    /// the port number of an interface
    /// <see href="http://purl.org/toco/hasInterfaceName"></see></summary>
    let hasInterfaceName =
        Namespaced_IRI.parse _namespace_name "hasInterfaceName" |> NamespacedName

    /// <summary>
    /// the join date of the user device
    /// <see href="http://purl.org/toco/hasJoinDate"></see></summary>
    let hasJoinDate =
        Namespaced_IRI.parse _namespace_name "hasJoinDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/toco/hasLTEAssociation"></see>
    /// </summary>
    let hasLTEAssociation =
        Namespaced_IRI.parse _namespace_name "hasLTEAssociation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/toco/hasWirelessAssociation"></see>
    /// </summary>
    let hasWirelessAssociation =
        Namespaced_IRI.parse _namespace_name "hasWirelessAssociation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/toco/hasLiFiAssociation"></see>
    /// </summary>
    let hasLiFiAssociation =
        Namespaced_IRI.parse _namespace_name "hasLiFiAssociation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/toco/hasWirelessLinkProperty"></see>
    /// </summary>
    let hasWirelessLinkProperty =
        Namespaced_IRI.parse _namespace_name "hasWirelessLinkProperty" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/toco/hasLiFiWLAN"></see>
    /// </summary>
    let hasLiFiWLAN =
        Namespaced_IRI.parse _namespace_name "hasLiFiWLAN" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/toco/hasWLAN"></see>
    /// </summary>
    let hasWLAN = Namespaced_IRI.parse _namespace_name "hasWLAN" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/toco/hasLink"></see>
    /// </summary>
    let hasLink = Namespaced_IRI.parse _namespace_name "hasLink" |> NamespacedName
    /// <summary>
    /// the MAC address of the interface.
    /// <see href="http://purl.org/toco/hasMAC"></see></summary>
    let hasMAC = Namespaced_IRI.parse _namespace_name "hasMAC" |> NamespacedName

    /// <summary>
    /// the transmitted power of the LED on the LiFi access point
    /// <see href="http://purl.org/toco/hasOpticalTransmittedPower"></see></summary>
    let hasOpticalTransmittedPower =
        Namespaced_IRI.parse _namespace_name "hasOpticalTransmittedPower" |> NamespacedName

    /// <summary>
    /// the packet loss rate of a link, usually in percentage.
    /// <see href="http://purl.org/toco/hasPacketLoss"></see></summary>
    let hasPacketLoss =
        Namespaced_IRI.parse _namespace_name "hasPacketLoss" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/toco/hasPort"></see>
    /// </summary>
    let hasPort = Namespaced_IRI.parse _namespace_name "hasPort" |> NamespacedName

    /// <summary>
    /// the radiance angle of the light ray transmitted from LED on LiFi access point.
    /// <see href="http://purl.org/toco/hasRadianceAngle"></see></summary>
    let hasRadianceAngle =
        Namespaced_IRI.parse _namespace_name "hasRadianceAngle" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/toco/hasRespansivity"></see>
    /// </summary>
    let hasRespansivity =
        Namespaced_IRI.parse _namespace_name "hasRespansivity" |> NamespacedName

    /// <summary>
    /// the round trip time of a link, which is the time taken for signal travel a round trip via this link.
    /// <see href="http://purl.org/toco/hasRoundTripTime"></see></summary>
    let hasRoundTripTime =
        Namespaced_IRI.parse _namespace_name "hasRoundTripTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/toco/hasSatelliteAssociation"></see>
    /// </summary>
    let hasSatelliteAssociation =
        Namespaced_IRI.parse _namespace_name "hasSatelliteAssociation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/toco/hasService"></see>
    /// </summary>
    let hasService = Namespaced_IRI.parse _namespace_name "hasService" |> NamespacedName

    /// <summary>
    /// the time that a service ends.
    /// <see href="http://purl.org/toco/hasServiceEndTime"></see></summary>
    let hasServiceEndTime =
        Namespaced_IRI.parse _namespace_name "hasServiceEndTime" |> NamespacedName

    /// <summary>
    /// the start time of a service.
    /// <see href="http://purl.org/toco/hasServiceStartTime"></see></summary>
    let hasServiceStartTime =
        Namespaced_IRI.parse _namespace_name "hasServiceStartTime" |> NamespacedName

    /// <summary>
    /// the status of the service.
    /// <see href="http://purl.org/toco/hasServiceStatus"></see></summary>
    let hasServiceStatus =
        Namespaced_IRI.parse _namespace_name "hasServiceStatus" |> NamespacedName

    /// <summary>
    /// the type of communication services, e.g., video, audio, file transmit, text transmiting, etc.
    /// <see href="http://purl.org/toco/hasServiceType"></see></summary>
    let hasServiceType =
        Namespaced_IRI.parse _namespace_name "hasServiceType" |> NamespacedName

    /// <summary>
    /// After multiple round trip time tested on a link, the deviation of these test results.
    /// <see href="http://purl.org/toco/hasStandardDeviation"></see></summary>
    let hasStandardDeviation =
        Namespaced_IRI.parse _namespace_name "hasStandardDeviation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/toco/hasThroughPut"></see>
    /// </summary>
    let hasThroughPut =
        Namespaced_IRI.parse _namespace_name "hasThroughPut" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/toco/hasTransmitPower"></see>
    /// </summary>
    let hasTransmitPower =
        Namespaced_IRI.parse _namespace_name "hasTransmitPower" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/toco/hasTxpower"></see>
    /// </summary>
    let hasTxpower = Namespaced_IRI.parse _namespace_name "hasTxpower" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/toco/hasUserDeviceStatus"></see>
    /// </summary>
    let hasUserDeviceStatus =
        Namespaced_IRI.parse _namespace_name "hasUserDeviceStatus" |> NamespacedName

    /// <summary>
    /// the user ID of the user
    /// <see href="http://purl.org/toco/hasUserID"></see></summary>
    let hasUserID = Namespaced_IRI.parse _namespace_name "hasUserID" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/toco/hasWiFiAssociation"></see>
    /// </summary>
    let hasWiFiAssociation =
        Namespaced_IRI.parse _namespace_name "hasWiFiAssociation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/toco/hasWiFiWLAN"></see>
    /// </summary>
    let hasWiFiWLAN =
        Namespaced_IRI.parse _namespace_name "hasWiFiWLAN" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/toco/hasWiredLink"></see>
    /// </summary>
    let hasWiredLink =
        Namespaced_IRI.parse _namespace_name "hasWiredLink" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/toco/idleTimeout"></see>
    /// </summary>
    let idleTimeout =
        Namespaced_IRI.parse _namespace_name "idleTimeout" |> NamespacedName

    /// <summary>
    /// the port number of the in port of the flow, or could be a keyword, such as "LOCAL"
    /// <see href="http://purl.org/toco/inPort"></see></summary>
    let inPort = Namespaced_IRI.parse _namespace_name "inPort" |> NamespacedName
    /// <summary>
    /// indicate whether a interface is up or not.
    /// <see href="http://purl.org/toco/isUP"></see></summary>
    let isUP = Namespaced_IRI.parse _namespace_name "isUP" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/toco/license"></see>
    /// </summary>
    let license = Namespaced_IRI.parse _namespace_name "license" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/toco/mode"></see>
    /// </summary>
    let mode = Namespaced_IRI.parse _namespace_name "mode" |> NamespacedName
    /// <summary>
    /// network protocol. The nw_proto property of a flow.
    /// <see href="http://purl.org/toco/nwProtocol"></see></summary>
    let nwProtocol = Namespaced_IRI.parse _namespace_name "nwProtocol" |> NamespacedName
    /// <summary>
    /// network type of service. the nw_tos property of a flow. It should be a decimal number with the value between 0-255.
    /// <see href="http://purl.org/toco/nwTos"></see></summary>
    let nwTos = Namespaced_IRI.parse _namespace_name "nwTos" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/toco/priority"></see>
    /// </summary>
    let priority = Namespaced_IRI.parse _namespace_name "priority" |> NamespacedName
    /// <summary>
    /// the signal range of wireless devices, such as WiFi access point, LiFi access point, WiFi mobile station, and LiFi mobile station.
    /// <see href="http://purl.org/toco/range"></see></summary>
    let range = Namespaced_IRI.parse _namespace_name "range" |> NamespacedName
    /// <summary>
    /// in wireless networks, the ssid of the network this device belongs to.
    /// <see href="http://purl.org/toco/ssid"></see></summary>
    let ssid = Namespaced_IRI.parse _namespace_name "ssid" |> NamespacedName

    /// <summary>
    /// in wireless networks (WiFi/LiFi), the mobile stations in the range of the access points.
    /// <see href="http://purl.org/toco/stationsInRange"></see></summary>
    let stationsInRange =
        Namespaced_IRI.parse _namespace_name "stationsInRange" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/toco/tableId"></see>
    /// </summary>
    let tableId = Namespaced_IRI.parse _namespace_name "tableId" |> NamespacedName
    /// <summary>
    /// the destination node of the link.
    /// <see href="http://purl.org/toco/to"></see></summary>
    let to_ = Namespaced_IRI.parse _namespace_name "to" |> NamespacedName
    /// <summary>
    /// the port number of the port forward to defined by the to_port property of the flow action OUTPUT.
    /// <see href="http://purl.org/toco/toPort"></see></summary>
    let toPort = Namespaced_IRI.parse _namespace_name "toPort" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/toco/unReachable"></see>
    /// </summary>
    let unReachable =
        Namespaced_IRI.parse _namespace_name "unReachable" |> NamespacedName
