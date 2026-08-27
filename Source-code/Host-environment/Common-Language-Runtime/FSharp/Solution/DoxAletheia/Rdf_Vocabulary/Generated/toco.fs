namespace http.purl.org.toco.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module toco =
    let _namespace_iri = Namespace_Iri toco |> NamespaceIRI
    /// <summary>
    ///   <para>toco:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>voaf:Vocabulary</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Version 1.1: creation"</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/">http://purl.org/toco/</seealso>
    let _prefix_iri = Prefixed_Name(toco, "") |> PrefixedName
    /// <summary>
    ///   <para>toco:AccessPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"a wireless access point, or more generally just access point (AP), is a networking hardware device that allows a Wi-Fi/Li-Fi device to connect to a wired network. The AP usually connects to a router (via a wired network) as a standalone device, but it can also be an integral component of the router itself. An AP is differentiated from a hotspot, which is the physical location where Wi-Fi access to a WLAN is available."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/AccessPoint">http://purl.org/toco/AccessPoint</seealso>
    let AccessPoint = Prefixed_Name(toco, "AccessPoint") |> PrefixedName
    /// <summary>
    ///   <para>toco:Action</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"the action of a flow defined in OpenFlow protocol"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/Action">http://purl.org/toco/Action</seealso>
    let Action = Prefixed_Name(toco, "Action") |> PrefixedName
    /// <summary>
    ///   <para>toco:Attached</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/Attached">http://purl.org/toco/Attached</seealso>
    let Attached = Prefixed_Name(toco, "Attached") |> PrefixedName
    /// <summary>
    ///   <para>toco:AudioService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/AudioService">http://purl.org/toco/AudioService</seealso>
    let AudioService = Prefixed_Name(toco, "AudioService") |> PrefixedName
    /// <summary>
    ///   <para>toco:AudioSession</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/AudioSession">http://purl.org/toco/AudioSession</seealso>
    let AudioSession = Prefixed_Name(toco, "AudioSession") |> PrefixedName
    /// <summary>
    ///   <para>toco:BaseStation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"a "land station in the land mobile service." -- according to the International Telecommunication Union's (ITU) Radio Regulations (RR).
    ///
    /// it is a transceiver connecting a number of other devices to one another and/or to a wider area. In LTE, it is also known as eNodeB."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/BaseStation">http://purl.org/toco/BaseStation</seealso>
    let BaseStation = Prefixed_Name(toco, "BaseStation") |> PrefixedName

    /// <summary>
    ///   <para>toco:CellularUserEquipment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"User deivce in a Cellular network."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/CellularUserEquipment">http://purl.org/toco/CellularUserEquipment</seealso>
    let CellularUserEquipment =
        Prefixed_Name(toco, "CellularUserEquipment") |> PrefixedName

    /// <summary>
    ///   <para>toco:ConceptEntities</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/ConceptEntities">http://purl.org/toco/ConceptEntities</seealso>
    let ConceptEntities = Prefixed_Name(toco, "ConceptEntities") |> PrefixedName
    /// <summary>
    ///   <para>toco:Detached</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/Detached">http://purl.org/toco/Detached</seealso>
    let Detached = Prefixed_Name(toco, "Detached") |> PrefixedName
    /// <summary>
    ///   <para>toco:Device</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"represent all the devices in the physical infrastructure of telecommunciation system.
    ///
    /// According to its user, could be divided into UserDevice and SystemDevice."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/Device">http://purl.org/toco/Device</seealso>
    let Device = Prefixed_Name(toco, "Device") |> PrefixedName
    /// <summary>
    ///   <para>toco:Drop</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/Drop">http://purl.org/toco/Drop</seealso>
    let Drop = Prefixed_Name(toco, "Drop") |> PrefixedName
    /// <summary>
    ///   <para>toco:FileTransferService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/FileTransferService">http://purl.org/toco/FileTransferService</seealso>
    let FileTransferService = Prefixed_Name(toco, "FileTransferService") |> PrefixedName
    /// <summary>
    ///   <para>toco:Flow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"the flow entry in a flow table inside a switch or route. Defined by OpenFlow protocol."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/Flow">http://purl.org/toco/Flow</seealso>
    let Flow = Prefixed_Name(toco, "Flow") |> PrefixedName
    /// <summary>
    ///   <para>toco:Forward</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/Forward">http://purl.org/toco/Forward</seealso>
    let Forward = Prefixed_Name(toco, "Forward") |> PrefixedName
    /// <summary>
    ///   <para>toco:Host</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A host is a computer or other device connected to a computer network. It is a network node that is assigned a network address."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/Host">http://purl.org/toco/Host</seealso>
    let Host = Prefixed_Name(toco, "Host") |> PrefixedName
    /// <summary>
    ///   <para>toco:Interface</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/Interface">http://purl.org/toco/Interface</seealso>
    let Interface = Prefixed_Name(toco, "Interface") |> PrefixedName
    /// <summary>
    ///   <para>toco:LTEAssociation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"the electromagnetic wave carring modulated signal between LTE base station, or eNodeB, and user equipment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/LTEAssociation">http://purl.org/toco/LTEAssociation</seealso>
    let LTEAssociation = Prefixed_Name(toco, "LTEAssociation") |> PrefixedName
    /// <summary>
    ///   <para>toco:LiFiAccessPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The access point in Li-Fi network. Li-Fi is a wireless optical networking technology that uses light-emitting diodes (LEDs) for data transmission."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/LiFiAccessPoint">http://purl.org/toco/LiFiAccessPoint</seealso>
    let LiFiAccessPoint = Prefixed_Name(toco, "LiFiAccessPoint") |> PrefixedName
    /// <summary>
    ///   <para>toco:LiFiAssociation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"the visiable light carring modulated signals in Li-Fi network. Transmited and received by LiFi user equipment and LiFi access point."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/LiFiAssociation">http://purl.org/toco/LiFiAssociation</seealso>
    let LiFiAssociation = Prefixed_Name(toco, "LiFiAssociation") |> PrefixedName
    /// <summary>
    ///   <para>toco:LiFiUserEquipment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"any device used directly by an end-user to communicate. It can be a hand-held telephone, a laptop computer equipped with a mobile broadband adapter, or any other device."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/LiFiUserEquipment">http://purl.org/toco/LiFiUserEquipment</seealso>
    let LiFiUserEquipment = Prefixed_Name(toco, "LiFiUserEquipment") |> PrefixedName
    /// <summary>
    ///   <para>toco:LiFiWLAN</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"WLAN interface on the devices in LIFi network, e.g., LiFi user equipment, LiFi access point."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/LiFiWLAN">http://purl.org/toco/LiFiWLAN</seealso>
    let LiFiWLAN = Prefixed_Name(toco, "LiFiWLAN") |> PrefixedName
    /// <summary>
    ///   <para>toco:Link</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/Link">http://purl.org/toco/Link</seealso>
    let Link = Prefixed_Name(toco, "Link") |> PrefixedName
    /// <summary>
    ///   <para>toco:Output</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/Output">http://purl.org/toco/Output</seealso>
    let Output = Prefixed_Name(toco, "Output") |> PrefixedName
    /// <summary>
    ///   <para>toco:PathFlow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/PathFlow">http://purl.org/toco/PathFlow</seealso>
    let PathFlow = Prefixed_Name(toco, "PathFlow") |> PrefixedName

    /// <summary>
    ///   <para>toco:PhysicalInfrastructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Describe all the physical resources in a telecommunication network system, which is divided into three main modules, namely, device, interface, link.
    ///
    /// Please be reminded the electromagnetic wave (which is the links of all wireless communication netwoks), even if it is invisable, physically exists. Thus, it is also described in the subclass of "net;PhysicalInfrastructure"."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/PhysicalInfrastructure">http://purl.org/toco/PhysicalInfrastructure</seealso>
    let PhysicalInfrastructure =
        Prefixed_Name(toco, "PhysicalInfrastructure") |> PrefixedName

    /// <summary>
    ///   <para>toco:SatelliteAssociation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"the milli-meter electromagnetic wave carring modulated signal between satellite base stations and ground station."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/SatelliteAssociation">http://purl.org/toco/SatelliteAssociation</seealso>
    let SatelliteAssociation =
        Prefixed_Name(toco, "SatelliteAssociation") |> PrefixedName

    /// <summary>
    ///   <para>toco:SatelliteGroundStation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"used in satellite network. Also known as earth station, or earth terminal, it is a terrestrial radio station designed for extraplanetary telecommunication with spacecraft (constituting part of the ground segment of the spacecraft system), or reception of radio waves from astronomical radio sources. Ground stations may be located either on the surface of the Earth, or in its atmosphere.[1] Earth stations communicate with spacecraft by transmitting and receiving radio waves in the super high frequency or extremely high frequency bands (e.g., microwaves). When a ground station successfully transmits radio waves to a spacecraft (or vice versa), it establishes a telecommunications link. A principal telecommunications device of the ground station is the parabolic antenna."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/SatelliteGroundStation">http://purl.org/toco/SatelliteGroundStation</seealso>
    let SatelliteGroundStation =
        Prefixed_Name(toco, "SatelliteGroundStation") |> PrefixedName

    /// <summary>
    ///   <para>toco:SatelliteRelayStation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An artificial satellite, that relays and amplifies radio telecommunications signals via a transponder; it creates a communication channel between a source transmitter and a receiver at different locations on Earth. Communications satellites are used for television, telephone, radio, internet, and military applications."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/SatelliteRelayStation">http://purl.org/toco/SatelliteRelayStation</seealso>
    let SatelliteRelayStation =
        Prefixed_Name(toco, "SatelliteRelayStation") |> PrefixedName

    /// <summary>
    ///   <para>toco:Service</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"a communication service, e.g., voice, video, file uploading/downloading, etc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/Service">http://purl.org/toco/Service</seealso>
    let Service = Prefixed_Name(toco, "Service") |> PrefixedName
    /// <summary>
    ///   <para>toco:Session</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/Session">http://purl.org/toco/Session</seealso>
    let Session = Prefixed_Name(toco, "Session") |> PrefixedName
    /// <summary>
    ///   <para>toco:Switch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A network switch (also called switching hub, bridging hub, officially MAC bridge) is a computer networking device that connects devices together on a computer network by using packet switching to receive, process, and forward data to the destination device."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/Switch">http://purl.org/toco/Switch</seealso>
    let Switch = Prefixed_Name(toco, "Switch") |> PrefixedName
    /// <summary>
    ///   <para>toco:SystemDevice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"All the physical facilities in the telecommunication system that provide the communication service to uses. For example: base station towers, Wi-Fi access points, switches, servers, etc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/SystemDevice">http://purl.org/toco/SystemDevice</seealso>
    let SystemDevice = Prefixed_Name(toco, "SystemDevice") |> PrefixedName
    /// <summary>
    ///   <para>toco:Text</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/Text">http://purl.org/toco/Text</seealso>
    let Text = Prefixed_Name(toco, "Text") |> PrefixedName
    /// <summary>
    ///   <para>toco:User</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"reused from foaf (http://xmlns.com/foaf/0.1/). Represent a user in the telecommunication system."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/User">http://purl.org/toco/User</seealso>
    let User = Prefixed_Name(toco, "User") |> PrefixedName
    /// <summary>
    ///   <para>toco:UserDevice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"User Devices, requiring connectivity services, e.g., phones, tablets, laptops, wearable devices, etc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/UserDevice">http://purl.org/toco/UserDevice</seealso>
    let UserDevice = Prefixed_Name(toco, "UserDevice") |> PrefixedName
    /// <summary>
    ///   <para>toco:UserDeviceStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/UserDeviceStatus">http://purl.org/toco/UserDeviceStatus</seealso>
    let UserDeviceStatus = Prefixed_Name(toco, "UserDeviceStatus") |> PrefixedName
    /// <summary>
    ///   <para>toco:UserEquipment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"any device used directly by an end-user to communicate. It can be a hand-held telephone, a laptop computer equipped with a mobile broadband adapter, or any other device."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/UserEquipment">http://purl.org/toco/UserEquipment</seealso>
    let UserEquipment = Prefixed_Name(toco, "UserEquipment") |> PrefixedName
    /// <summary>
    ///   <para>toco:VideoService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/VideoService">http://purl.org/toco/VideoService</seealso>
    let VideoService = Prefixed_Name(toco, "VideoService") |> PrefixedName
    /// <summary>
    ///   <para>toco:VideoSession</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/VideoSession">http://purl.org/toco/VideoSession</seealso>
    let VideoSession = Prefixed_Name(toco, "VideoSession") |> PrefixedName
    /// <summary>
    ///   <para>toco:WLAN</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A wireless local area network (WLAN) interface, also known as WLAN, is the interface of a wireless computer network that links two or more devices using wireless communication within a limited area such as a home, school, computer laboratory, or office building."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/WLAN">http://purl.org/toco/WLAN</seealso>
    let WLAN = Prefixed_Name(toco, "WLAN") |> PrefixedName
    /// <summary>
    ///   <para>toco:WiFiAccessPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An access point in a WiFi network"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/WiFiAccessPoint">http://purl.org/toco/WiFiAccessPoint</seealso>
    let WiFiAccessPoint = Prefixed_Name(toco, "WiFiAccessPoint") |> PrefixedName
    /// <summary>
    ///   <para>toco:WiFiAssociation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"the electromagnetic wave carring modulated signal between LTE base station, or eNodeB, and user equipment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/WiFiAssociation">http://purl.org/toco/WiFiAssociation</seealso>
    let WiFiAssociation = Prefixed_Name(toco, "WiFiAssociation") |> PrefixedName
    /// <summary>
    ///   <para>toco:WiFiUserEquipment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"a user quipment in Wi-Fi network"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/WiFiUserEquipment">http://purl.org/toco/WiFiUserEquipment</seealso>
    let WiFiUserEquipment = Prefixed_Name(toco, "WiFiUserEquipment") |> PrefixedName
    /// <summary>
    ///   <para>toco:WiFiWLAN</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"WLAN interface on the devices in LIFi network, e.g., LiFi user equipment, LiFi access point."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/WiFiWLAN">http://purl.org/toco/WiFiWLAN</seealso>
    let WiFiWLAN = Prefixed_Name(toco, "WiFiWLAN") |> PrefixedName
    /// <summary>
    ///   <para>toco:WiredLink</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"wired link through twisted cable, optical fiber, etc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/WiredLink">http://purl.org/toco/WiredLink</seealso>
    let WiredLink = Prefixed_Name(toco, "WiredLink") |> PrefixedName
    /// <summary>
    ///   <para>toco:WirelessAssociation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"the electromeganetic radio transmiting through wireless channels in wireless network, carring communication data. Depend on its frequency, it could be visiable light, micro waves, radio waves."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/WirelessAssociation">http://purl.org/toco/WirelessAssociation</seealso>
    let WirelessAssociation = Prefixed_Name(toco, "WirelessAssociation") |> PrefixedName
    /// <summary>
    ///   <para>toco:apsInRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/apsInRange">http://purl.org/toco/apsInRange</seealso>
    let apsInRange = Prefixed_Name(toco, "apsInRange") |> PrefixedName
    /// <summary>
    ///   <para>toco:belongsTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/belongsTo">http://purl.org/toco/belongsTo</seealso>
    let belongsTo = Prefixed_Name(toco, "belongsTo") |> PrefixedName
    /// <summary>
    ///   <para>toco:channel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"the channel id of a interface."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/channel">http://purl.org/toco/channel</seealso>
    let channel = Prefixed_Name(toco, "channel") |> PrefixedName
    /// <summary>
    ///   <para>toco:contributor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/contributor">http://purl.org/toco/contributor</seealso>
    let contributor = Prefixed_Name(toco, "contributor") |> PrefixedName
    /// <summary>
    ///   <para>toco:cookie</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/cookie">http://purl.org/toco/cookie</seealso>
    let cookie = Prefixed_Name(toco, "cookie") |> PrefixedName
    /// <summary>
    ///   <para>toco:dlDst</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"the Ethernet destination address of the flow. It should be an MAC address, with 6 pairs of hexadecimal digits."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/dlDst">http://purl.org/toco/dlDst</seealso>
    let dlDst = Prefixed_Name(toco, "dlDst") |> PrefixedName
    /// <summary>
    ///   <para>toco:dlSrc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"the Ethernet source address of the flow. It should be an MAC address with 6 pairs of hexadecimal digits"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/dlSrc">http://purl.org/toco/dlSrc</seealso>
    let dlSrc = Prefixed_Name(toco, "dlSrc") |> PrefixedName
    /// <summary>
    ///   <para>toco:driver</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/driver">http://purl.org/toco/driver</seealso>
    let driver = Prefixed_Name(toco, "driver") |> PrefixedName
    /// <summary>
    ///   <para>toco:flags</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/flags">http://purl.org/toco/flags</seealso>
    let flags = Prefixed_Name(toco, "flags") |> PrefixedName
    /// <summary>
    ///   <para>toco:frequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"the frequency of the radio wave transmitted by a wireless interface (WLAN)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/frequency">http://purl.org/toco/frequency</seealso>
    let frequency = Prefixed_Name(toco, "frequency") |> PrefixedName
    /// <summary>
    ///   <para>toco:from</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"the source node that the link is transmit from."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/from">http://purl.org/toco/from</seealso>
    let from = Prefixed_Name(toco, "from") |> PrefixedName
    /// <summary>
    ///   <para>toco:hardTimeout</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/hardTimeout">http://purl.org/toco/hardTimeout</seealso>
    let hardTimeout = Prefixed_Name(toco, "hardTimeout") |> PrefixedName
    /// <summary>
    ///   <para>toco:hasAntennaGain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"the gain of an antenna on the wireless interface."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/hasAntennaGain">http://purl.org/toco/hasAntennaGain</seealso>
    let hasAntennaGain = Prefixed_Name(toco, "hasAntennaGain") |> PrefixedName
    /// <summary>
    ///   <para>toco:hasAntennaHeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"the height of the antenna of a wireless interface"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/hasAntennaHeight">http://purl.org/toco/hasAntennaHeight</seealso>
    let hasAntennaHeight = Prefixed_Name(toco, "hasAntennaHeight") |> PrefixedName

    /// <summary>
    ///   <para>toco:hasAssociatedStations</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"in wireless networks, the user equipments (mobile stations in another term, e.g., phones, laptops, tablets, etc.) that are associated to the access point."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/hasAssociatedStations">http://purl.org/toco/hasAssociatedStations</seealso>
    let hasAssociatedStations =
        Prefixed_Name(toco, "hasAssociatedStations") |> PrefixedName

    /// <summary>
    ///   <para>toco:hasBandwidth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"the bandwidth of the link"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/hasBandwidth">http://purl.org/toco/hasBandwidth</seealso>
    let hasBandwidth = Prefixed_Name(toco, "hasBandwidth") |> PrefixedName
    /// <summary>
    ///   <para>toco:hasDatarate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/hasDatarate">http://purl.org/toco/hasDatarate</seealso>
    let hasDatarate = Prefixed_Name(toco, "hasDatarate") |> PrefixedName
    /// <summary>
    ///   <para>toco:hasDevice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/hasDevice">http://purl.org/toco/hasDevice</seealso>
    let hasDevice = Prefixed_Name(toco, "hasDevice") |> PrefixedName
    /// <summary>
    ///   <para>toco:hasDistance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"the Euclidean distance between the LiFi user equipment and access point."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/hasDistance">http://purl.org/toco/hasDistance</seealso>
    let hasDistance = Prefixed_Name(toco, "hasDistance") |> PrefixedName
    /// <summary>
    ///   <para>toco:hasErrorCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"the error code of a service."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/hasErrorCode">http://purl.org/toco/hasErrorCode</seealso>
    let hasErrorCode = Prefixed_Name(toco, "hasErrorCode") |> PrefixedName
    /// <summary>
    ///   <para>toco:hasFieldOfView</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Field of view (FOV) is the open observable area where a LiFi user equipment could receive visiable light signal. It is defined by let the incident angle of the LiFi user equipment equals to Pi/2.
    ///
    /// If the incident angle larger than Pi/2, the light ray is out of the FOV, thus cannot be received by the LiFi user equipment."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/hasFieldOfView">http://purl.org/toco/hasFieldOfView</seealso>
    let hasFieldOfView = Prefixed_Name(toco, "hasFieldOfView") |> PrefixedName
    /// <summary>
    ///   <para>toco:hasFlow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/hasFlow">http://purl.org/toco/hasFlow</seealso>
    let hasFlow = Prefixed_Name(toco, "hasFlow") |> PrefixedName
    /// <summary>
    ///   <para>toco:hasFlowAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/hasFlowAction">http://purl.org/toco/hasFlowAction</seealso>
    let hasFlowAction = Prefixed_Name(toco, "hasFlowAction") |> PrefixedName
    /// <summary>
    ///   <para>toco:hasFlowProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/hasFlowProperty">http://purl.org/toco/hasFlowProperty</seealso>
    let hasFlowProperty = Prefixed_Name(toco, "hasFlowProperty") |> PrefixedName

    /// <summary>
    ///   <para>toco:hasGainOfConcentrator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The gain of the concentrator on the LiFi user equipment, usually equals to 1."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/hasGainOfConcentrator">http://purl.org/toco/hasGainOfConcentrator</seealso>
    let hasGainOfConcentrator =
        Prefixed_Name(toco, "hasGainOfConcentrator") |> PrefixedName

    /// <summary>
    ///   <para>toco:hasGainofOpticalFilter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Gain of optical filter on LiFi access point."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/hasGainofOpticalFilter">http://purl.org/toco/hasGainofOpticalFilter</seealso>
    let hasGainofOpticalFilter =
        Prefixed_Name(toco, "hasGainofOpticalFilter") |> PrefixedName

    /// <summary>
    ///   <para>toco:hasHalfIntensityAngle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The angle of half intensity of the LED light transmiting visible light signal in a LiFi access point.
    ///
    /// A fixed value. It is the angle where the radiated intensity will be half as intense as it would be at 0 degrees, or pointing straight ahead.
    ///
    /// Factors that contribute to the angle of half intensity include the amount of diffusing material in the epoxy, the shape of the reflector cup which surrounds the LED chip, the shape of the LED lens, the distance from the LED to the tip of the lens, and the type of emitter chip.
    ///
    /// The most common value is Pi/3."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/hasHalfIntensityAngle">http://purl.org/toco/hasHalfIntensityAngle</seealso>
    let hasHalfIntensityAngle =
        Prefixed_Name(toco, "hasHalfIntensityAngle") |> PrefixedName

    /// <summary>
    ///   <para>toco:hasIP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"the IP address of the interface."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/hasIP">http://purl.org/toco/hasIP</seealso>
    let hasIP = Prefixed_Name(toco, "hasIP") |> PrefixedName
    /// <summary>
    ///   <para>toco:hasIncidentAngle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The angle of incidence of the LED receiver on LiFi user equipment, which is the angle between the visiable light ray incident on a surface and the line perpendicular to the surface at the point of incidence, called the normal."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/hasIncidentAngle">http://purl.org/toco/hasIncidentAngle</seealso>
    let hasIncidentAngle = Prefixed_Name(toco, "hasIncidentAngle") |> PrefixedName
    /// <summary>
    ///   <para>toco:hasInterface</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"the fact that a device has a interface."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/hasInterface">http://purl.org/toco/hasInterface</seealso>
    let hasInterface = Prefixed_Name(toco, "hasInterface") |> PrefixedName
    /// <summary>
    ///   <para>toco:hasInterfaceName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"the port number of an interface"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/hasInterfaceName">http://purl.org/toco/hasInterfaceName</seealso>
    let hasInterfaceName = Prefixed_Name(toco, "hasInterfaceName") |> PrefixedName
    /// <summary>
    ///   <para>toco:hasJoinDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"the join date of the user device"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/hasJoinDate">http://purl.org/toco/hasJoinDate</seealso>
    let hasJoinDate = Prefixed_Name(toco, "hasJoinDate") |> PrefixedName
    /// <summary>
    ///   <para>toco:hasLTEAssociation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/hasLTEAssociation">http://purl.org/toco/hasLTEAssociation</seealso>
    let hasLTEAssociation = Prefixed_Name(toco, "hasLTEAssociation") |> PrefixedName

    /// <summary>
    ///   <para>toco:hasLiFiAccessPointProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"datatype properties dedicated for LiFi access points"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/hasLiFiAccessPointProperty">http://purl.org/toco/hasLiFiAccessPointProperty</seealso>
    let hasLiFiAccessPointProperty =
        Prefixed_Name(toco, "hasLiFiAccessPointProperty") |> PrefixedName

    /// <summary>
    ///   <para>toco:hasLiFiAssociation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/hasLiFiAssociation">http://purl.org/toco/hasLiFiAssociation</seealso>
    let hasLiFiAssociation = Prefixed_Name(toco, "hasLiFiAssociation") |> PrefixedName

    /// <summary>
    ///   <para>toco:hasLiFiAssociationProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The properties of the visiable light association between the LED on LiFi access point and LiFi user equipment."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/hasLiFiAssociationProperty">http://purl.org/toco/hasLiFiAssociationProperty</seealso>
    let hasLiFiAssociationProperty =
        Prefixed_Name(toco, "hasLiFiAssociationProperty") |> PrefixedName

    /// <summary>
    ///   <para>toco:hasLiFiUserEquipmentProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"properties of LiFi user equipments."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/hasLiFiUserEquipmentProperty">http://purl.org/toco/hasLiFiUserEquipmentProperty</seealso>
    let hasLiFiUserEquipmentProperty =
        Prefixed_Name(toco, "hasLiFiUserEquipmentProperty") |> PrefixedName

    /// <summary>
    ///   <para>toco:hasLiFiWLAN</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/hasLiFiWLAN">http://purl.org/toco/hasLiFiWLAN</seealso>
    let hasLiFiWLAN = Prefixed_Name(toco, "hasLiFiWLAN") |> PrefixedName
    /// <summary>
    ///   <para>toco:hasLink</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/hasLink">http://purl.org/toco/hasLink</seealso>
    let hasLink = Prefixed_Name(toco, "hasLink") |> PrefixedName
    /// <summary>
    ///   <para>toco:hasLinkProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/hasLinkProperty">http://purl.org/toco/hasLinkProperty</seealso>
    let hasLinkProperty = Prefixed_Name(toco, "hasLinkProperty") |> PrefixedName
    /// <summary>
    ///   <para>toco:hasMAC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"the MAC address of the interface."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/hasMAC">http://purl.org/toco/hasMAC</seealso>
    let hasMAC = Prefixed_Name(toco, "hasMAC") |> PrefixedName

    /// <summary>
    ///   <para>toco:hasOpticalTransmittedPower</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"the transmitted power of the LED on the LiFi access point"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/hasOpticalTransmittedPower">http://purl.org/toco/hasOpticalTransmittedPower</seealso>
    let hasOpticalTransmittedPower =
        Prefixed_Name(toco, "hasOpticalTransmittedPower") |> PrefixedName

    /// <summary>
    ///   <para>toco:hasPacketLoss</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"the packet loss rate of a link, usually in percentage."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/hasPacketLoss">http://purl.org/toco/hasPacketLoss</seealso>
    let hasPacketLoss = Prefixed_Name(toco, "hasPacketLoss") |> PrefixedName
    /// <summary>
    ///   <para>toco:hasPort</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/hasPort">http://purl.org/toco/hasPort</seealso>
    let hasPort = Prefixed_Name(toco, "hasPort") |> PrefixedName
    /// <summary>
    ///   <para>toco:hasRadianceAngle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"the radiance angle of the light ray transmitted from LED on LiFi access point."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/hasRadianceAngle">http://purl.org/toco/hasRadianceAngle</seealso>
    let hasRadianceAngle = Prefixed_Name(toco, "hasRadianceAngle") |> PrefixedName
    /// <summary>
    ///   <para>toco:hasRespansivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/hasRespansivity">http://purl.org/toco/hasRespansivity</seealso>
    let hasRespansivity = Prefixed_Name(toco, "hasRespansivity") |> PrefixedName
    /// <summary>
    ///   <para>toco:hasRoundTripTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"the round trip time of a link, which is the time taken for signal travel a round trip via this link."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/hasRoundTripTime">http://purl.org/toco/hasRoundTripTime</seealso>
    let hasRoundTripTime = Prefixed_Name(toco, "hasRoundTripTime") |> PrefixedName

    /// <summary>
    ///   <para>toco:hasSatelliteAssociation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/hasSatelliteAssociation">http://purl.org/toco/hasSatelliteAssociation</seealso>
    let hasSatelliteAssociation =
        Prefixed_Name(toco, "hasSatelliteAssociation") |> PrefixedName

    /// <summary>
    ///   <para>toco:hasService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/hasService">http://purl.org/toco/hasService</seealso>
    let hasService = Prefixed_Name(toco, "hasService") |> PrefixedName
    /// <summary>
    ///   <para>toco:hasServiceEndTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"the time that a service ends."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/hasServiceEndTime">http://purl.org/toco/hasServiceEndTime</seealso>
    let hasServiceEndTime = Prefixed_Name(toco, "hasServiceEndTime") |> PrefixedName
    /// <summary>
    ///   <para>toco:hasServiceStartTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"the start time of a service."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/hasServiceStartTime">http://purl.org/toco/hasServiceStartTime</seealso>
    let hasServiceStartTime = Prefixed_Name(toco, "hasServiceStartTime") |> PrefixedName
    /// <summary>
    ///   <para>toco:hasServiceStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"the status of the service."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/hasServiceStatus">http://purl.org/toco/hasServiceStatus</seealso>
    let hasServiceStatus = Prefixed_Name(toco, "hasServiceStatus") |> PrefixedName
    /// <summary>
    ///   <para>toco:hasServiceType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"the type of communication services, e.g., video, audio, file transmit, text transmiting, etc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/hasServiceType">http://purl.org/toco/hasServiceType</seealso>
    let hasServiceType = Prefixed_Name(toco, "hasServiceType") |> PrefixedName

    /// <summary>
    ///   <para>toco:hasStandardDeviation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"After multiple round trip time tested on a link, the deviation of these test results."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/hasStandardDeviation">http://purl.org/toco/hasStandardDeviation</seealso>
    let hasStandardDeviation =
        Prefixed_Name(toco, "hasStandardDeviation") |> PrefixedName

    /// <summary>
    ///   <para>toco:hasThroughPut</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/hasThroughPut">http://purl.org/toco/hasThroughPut</seealso>
    let hasThroughPut = Prefixed_Name(toco, "hasThroughPut") |> PrefixedName
    /// <summary>
    ///   <para>toco:hasTransmitPower</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/hasTransmitPower">http://purl.org/toco/hasTransmitPower</seealso>
    let hasTransmitPower = Prefixed_Name(toco, "hasTransmitPower") |> PrefixedName
    /// <summary>
    ///   <para>toco:hasTxpower</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/hasTxpower">http://purl.org/toco/hasTxpower</seealso>
    let hasTxpower = Prefixed_Name(toco, "hasTxpower") |> PrefixedName
    /// <summary>
    ///   <para>toco:hasUserDeviceStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/hasUserDeviceStatus">http://purl.org/toco/hasUserDeviceStatus</seealso>
    let hasUserDeviceStatus = Prefixed_Name(toco, "hasUserDeviceStatus") |> PrefixedName
    /// <summary>
    ///   <para>toco:hasUserID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"the user ID of the user"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/hasUserID">http://purl.org/toco/hasUserID</seealso>
    let hasUserID = Prefixed_Name(toco, "hasUserID") |> PrefixedName
    /// <summary>
    ///   <para>toco:hasWLAN</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/hasWLAN">http://purl.org/toco/hasWLAN</seealso>
    let hasWLAN = Prefixed_Name(toco, "hasWLAN") |> PrefixedName
    /// <summary>
    ///   <para>toco:hasWiFiAssociation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/hasWiFiAssociation">http://purl.org/toco/hasWiFiAssociation</seealso>
    let hasWiFiAssociation = Prefixed_Name(toco, "hasWiFiAssociation") |> PrefixedName
    /// <summary>
    ///   <para>toco:hasWiFiWLAN</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/hasWiFiWLAN">http://purl.org/toco/hasWiFiWLAN</seealso>
    let hasWiFiWLAN = Prefixed_Name(toco, "hasWiFiWLAN") |> PrefixedName
    /// <summary>
    ///   <para>toco:hasWiredLink</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/hasWiredLink">http://purl.org/toco/hasWiredLink</seealso>
    let hasWiredLink = Prefixed_Name(toco, "hasWiredLink") |> PrefixedName

    /// <summary>
    ///   <para>toco:hasWirelessAssociation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/hasWirelessAssociation">http://purl.org/toco/hasWirelessAssociation</seealso>
    let hasWirelessAssociation =
        Prefixed_Name(toco, "hasWirelessAssociation") |> PrefixedName

    /// <summary>
    ///   <para>toco:hasWirelessLinkProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/hasWirelessLinkProperty">http://purl.org/toco/hasWirelessLinkProperty</seealso>
    let hasWirelessLinkProperty =
        Prefixed_Name(toco, "hasWirelessLinkProperty") |> PrefixedName

    /// <summary>
    ///   <para>toco:idleTimeout</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/idleTimeout">http://purl.org/toco/idleTimeout</seealso>
    let idleTimeout = Prefixed_Name(toco, "idleTimeout") |> PrefixedName
    /// <summary>
    ///   <para>toco:inPort</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"the port number of the in port of the flow, or could be a keyword, such as "LOCAL""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/inPort">http://purl.org/toco/inPort</seealso>
    let inPort = Prefixed_Name(toco, "inPort") |> PrefixedName
    /// <summary>
    ///   <para>toco:isIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"the relation that a interface belongs to a device. A device can have multiple interfaces, but a interface can be in one and only one device."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/isIn">http://purl.org/toco/isIn</seealso>
    let isIn = Prefixed_Name(toco, "isIn") |> PrefixedName
    /// <summary>
    ///   <para>toco:isUP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"indicate whether a interface is up or not."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/isUP">http://purl.org/toco/isUP</seealso>
    let isUP = Prefixed_Name(toco, "isUP") |> PrefixedName
    /// <summary>
    ///   <para>toco:license</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/license">http://purl.org/toco/license</seealso>
    let license = Prefixed_Name(toco, "license") |> PrefixedName
    /// <summary>
    ///   <para>toco:mode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/mode">http://purl.org/toco/mode</seealso>
    let mode = Prefixed_Name(toco, "mode") |> PrefixedName
    /// <summary>
    ///   <para>toco:nwProtocol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"network protocol. The nw_proto property of a flow."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/nwProtocol">http://purl.org/toco/nwProtocol</seealso>
    let nwProtocol = Prefixed_Name(toco, "nwProtocol") |> PrefixedName
    /// <summary>
    ///   <para>toco:nwTos</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"network type of service. the nw_tos property of a flow. It should be a decimal number with the value between 0-255."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/nwTos">http://purl.org/toco/nwTos</seealso>
    let nwTos = Prefixed_Name(toco, "nwTos") |> PrefixedName
    /// <summary>
    ///   <para>toco:priority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/priority">http://purl.org/toco/priority</seealso>
    let priority = Prefixed_Name(toco, "priority") |> PrefixedName
    /// <summary>
    ///   <para>toco:range</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"the signal range of wireless devices, such as WiFi access point, LiFi access point, WiFi mobile station, and LiFi mobile station."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/range">http://purl.org/toco/range</seealso>
    let range = Prefixed_Name(toco, "range") |> PrefixedName
    /// <summary>
    ///   <para>toco:ssid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"in wireless networks, the ssid of the network this device belongs to."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/ssid">http://purl.org/toco/ssid</seealso>
    let ssid = Prefixed_Name(toco, "ssid") |> PrefixedName
    /// <summary>
    ///   <para>toco:stationsInRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"in wireless networks (WiFi/LiFi), the mobile stations in the range of the access points."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/stationsInRange">http://purl.org/toco/stationsInRange</seealso>
    let stationsInRange = Prefixed_Name(toco, "stationsInRange") |> PrefixedName
    /// <summary>
    ///   <para>toco:tableId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/tableId">http://purl.org/toco/tableId</seealso>
    let tableId = Prefixed_Name(toco, "tableId") |> PrefixedName
    /// <summary>
    ///   <para>toco:to</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"the destination node of the link."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/to">http://purl.org/toco/to</seealso>
    let to_ = Prefixed_Name(toco, "to") |> PrefixedName
    /// <summary>
    ///   <para>toco:toPort</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"the port number of the port forward to defined by the to_port property of the flow action OUTPUT."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/toPort">http://purl.org/toco/toPort</seealso>
    let toPort = Prefixed_Name(toco, "toPort") |> PrefixedName
    /// <summary>
    ///   <para>toco:unReachable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/toco/unReachable">http://purl.org/toco/unReachable</seealso>
    let unReachable = Prefixed_Name(toco, "unReachable") |> PrefixedName
