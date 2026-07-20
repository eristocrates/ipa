namespace http.www.tele.pw.edu.pl._sims_onto.ConnectivityType.owl.hash

open DoxAletheia

module ct =
    let _namespace_name = "http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Defines type of address supported in network and associated with bearer. Specific addresses are modelled as instances e.g. GSM_MSISDN describe type of address used in GSM network.
    /// <see href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#BearerAddressType"></see></summary>
    let BearerAddressType = _prefix "BearerAddressType"
    /// <summary>
    /// Defines transmission technology used to transfer voice or data in network.
    /// <see href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#BearerType"></see></summary>
    let BearerType = _prefix "BearerType"
    /// <summary>
    /// Defines Bluetooth connectivity.
    /// <see href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#BluetoothConnectivity"></see></summary>
    let BluetoothConnectivity = _prefix "BluetoothConnectivity"
    /// <summary>
    /// Short range wireless connectivity type (WiFi, Bluetooth)
    /// <see href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#ShortRangeConnectivityType"></see></summary>
    let ShortRangeConnectivityType = _prefix "ShortRangeConnectivityType"
    /// <summary>
    /// Circuit Switched Data (CSD) is the original form of data transmission developed for the time division multiple access (TDMA)-based mobile phone systems like Global System for Mobile Communications (GSM).
    /// <see href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#CSD"></see></summary>
    let CSD = _prefix "CSD"
    /// <summary>
    /// Cellular connectivity, e.g., GSM
    /// <see href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#CellularConnectivityType"></see></summary>
    let CellularConnectivityType = _prefix "CellularConnectivityType"
    /// <summary>
    /// Long range wireless connectivity, such as WiMAX or GSM
    /// <see href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#LongRangeConnectivityType"></see></summary>
    let LongRangeConnectivityType = _prefix "LongRangeConnectivityType"
    /// <summary>
    /// Defines bearer capable to transmit data.
    /// <see href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#DataBearerService"></see></summary>
    let DataBearerService = _prefix "DataBearerService"
    /// <summary>
    /// Defines network bearer service that allows transmission of information signals between network interfaces. E.g. transmission of MMS in GSM network is modelled as instance 'GSM_GPRS_IPV4'. Bearer capabilities are modeled as sublasses.
    /// <see href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#NetworkBearerService"></see></summary>
    let NetworkBearerService = _prefix "NetworkBearerService"
    /// <summary>
    /// Defnes Enhanced Data rates for GSM Evolution technology which allows to increase data transmission rate.
    /// <see href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#EDGE"></see></summary>
    let EDGE = _prefix "EDGE"
    /// <summary>
    /// General Packet Radio Service (GPRS) is a Mobile Data Service available to users of Global System for Mobile Communications (GSM) and IS-136 mobile phones.
    /// <see href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#GPRS"></see></summary>
    let GPRS = _prefix "GPRS"
    /// <summary>
    /// The Global System for Mobile communications is the most popular standard for mobile phones in the world. GSM is a cellular network, which means that mobile phones connect to it by searching for cells in the immediate vicinity.
    /// <see href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#GSM"></see></summary>
    let GSM = _prefix "GSM"
    /// <summary>
    /// Defines general term for telecommunication network.
    /// <see href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#Network"></see></summary>
    let Network = _prefix "Network"
    /// <summary>
    /// Defines GSM connectivity.
    /// <see href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#GSMConnectivity"></see></summary>
    let GSMConnectivity = _prefix "GSMConnectivity"
    /// <summary>
    /// Defines network bearers supported by connectivity type.
    /// <see href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#hasNetworkBearerService"></see></summary>
    let hasNetworkBearerService = _prefix "hasNetworkBearerService"
    /// <summary>
    /// Defines bearer service in GSM network which use MSISDN address type and CSD bearer. Type of voice transfer bearer in GSM network.
    /// <see href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#GSM_CSD_MSISDN"></see></summary>
    let GSM_CSD_MSISDN = _prefix "GSM_CSD_MSISDN"
    /// <summary>
    /// Defines SMS bearer service in GSM network using GSM_MSISDN address type.
    /// <see href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#GSM_SMS_MSISDN"></see></summary>
    let GSM_SMS_MSISDN = _prefix "GSM_SMS_MSISDN"
    /// <summary>
    /// Defines bearer service in GSM network which use IPv4 address type and CSD bearer. Type of data transfer bearer in GSM network.
    /// <see href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#GSM_CSD_IPv4"></see></summary>
    let GSM_CSD_IPv4 = _prefix "GSM_CSD_IPv4"
    /// <summary>
    /// Defines GPRS bearer service in GSM network using IPv4 address type. Type of data transfer bearer in GSM network.
    /// <see href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#GSM_GPRS_IPV4"></see></summary>
    let GSM_GPRS_IPV4 = _prefix "GSM_GPRS_IPV4"
    /// <summary>
    /// Defines transmission technology.
    /// <see href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#hasBearerType"></see></summary>
    let hasBearerType = _prefix "hasBearerType"
    /// <summary>
    /// Defines network address type used by network bearer type.
    /// <see href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#referesToAddress"></see></summary>
    let referesToAddress = _prefix "referesToAddress"
    /// <summary>
    /// IP address (Internet Protocol address) is a unique address that certain electronic devices use in order to identify and communicate with each other on a computer network utilizing the Internet Protocol standard (IP). IPv4 uses 32-bit (4 byte) addresses.
    /// <see href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#IPv4"></see></summary>
    let IPv4 = _prefix "IPv4"
    /// <summary>
    /// Defines network which supports bearer.
    /// <see href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#referesToNetwork"></see></summary>
    let referesToNetwork = _prefix "referesToNetwork"
    /// <summary>
    /// MSISDN (Mobile Subscriber ISDN Number) refers to the telephone number of a mobile subscriber. MSISDN by ITU-T is at most 15 digits long and consists of: * CC - Country Code ( 1-3 digits e.g."48" for Poland), * NDC - National Destination Code (e.g. 3 digits in Poland), * SN - Subscriber Number (e.g. 6 remaining digits (123456)).
    /// <see href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#GSM_MSISDN"></see></summary>
    let GSM_MSISDN = _prefix "GSM_MSISDN"
    /// <summary>
    /// Defines bearer capable to transmit voice.
    /// <see href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#VoiceBearerService"></see></summary>
    let VoiceBearerService = _prefix "VoiceBearerService"
    /// <summary>
    /// Defines EDGE bearer service in GSM network with IPv4 address protocol.
    /// <see href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#GSM_EDGE_IPv4"></see></summary>
    let GSM_EDGE_IPv4 = _prefix "GSM_EDGE_IPv4"
    /// <summary>
    /// Defines HSCSD bearer service in GSM network with IP v4 address protocol.
    /// <see href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#GSM_HSCSD_IPv4"></see></summary>
    let GSM_HSCSD_IPv4 = _prefix "GSM_HSCSD_IPv4"
    /// <summary>
    /// Defines High-Speed Circuit-Switched Data, data transmission mechanism in GSM Network, enhancement of CSD.
    /// <see href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#HSCSD"></see></summary>
    let HSCSD = _prefix "HSCSD"
    /// <summary>
    /// Defines transmission technology used in GSM network to transmit SMS messages.
    /// <see href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#SMS_BearerType"></see></summary>
    let SMS_BearerType = _prefix "SMS_BearerType"
    /// <summary>
    /// Defines bearer capable to transmit text. E.g. bearer responsible for SMS transfer.
    /// <see href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#TextBearerService"></see></summary>
    let TextBearerService = _prefix "TextBearerService"
    /// <summary>
    /// USSD is a technology built into the GSM standard for support of transmitting information over the signaling channels of the GSM network. USSD provides session-based communication. Defined within the GSM standard in the documents GSM 02.90 (USSD Stage 1) and GSM 03.90 (USSD Stage 2).
    /// <see href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#GSM_USSD"></see></summary>
    let GSM_USSD = _prefix "GSM_USSD"
    /// <summary>
    /// Defines bearer capable to transmit information over the signaling channels of the GSM network.
    /// <see href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#USSD"></see></summary>
    let USSD = _prefix "USSD"
    /// <summary>
    /// IP address (Internet Protocol address) is a unique address that certain electronic devices use in order to identify and communicate with each other on a computer network utilizing the Internet Protocol standard (IP). IPv6 uses 128-bit addresses.
    /// <see href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#IPv6"></see></summary>
    let IPv6 = _prefix "IPv6"
    /// <summary>
    /// Interim Standard 95 (IS-95), is the first CDMA-based digital cellular standard pioneered by Qualcomm. CDMA or "code division multiple access" is a digital radio system that transmits streams of bits (PN Sequences).
    /// <see href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#IS-95"></see></summary>
    let ``IS-95`` = _prefix "IS-95"
    /// <summary>
    /// Defines IrDA connectivity.
    /// <see href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#IrDAConnectivity"></see></summary>
    let IrDAConnectivity = _prefix "IrDAConnectivity"
    /// <summary>
    /// Wireless connectivity type (e.g., GSM connectivity)
    /// <see href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#WirelessConnectivityType"></see></summary>
    let WirelessConnectivityType = _prefix "WirelessConnectivityType"
    /// <summary>
    /// Universal Mobile Telecommunications System (UMTS) is one of the third-generation (3G) cell phone technologies.
    /// <see href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#UMTS"></see></summary>
    let UMTS = _prefix "UMTS"
    /// <summary>
    /// Defines UMTS connectivity
    /// <see href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#UMTSConnectivity"></see></summary>
    let UMTSConnectivity = _prefix "UMTSConnectivity"
    /// <summary>
    /// Defines video bearer in UMTS network which use IPv6 address type. It is bearer capable to transfer video.
    /// <see href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#UMTS_Video_IPv6"></see></summary>
    let UMTS_Video_IPv6 = _prefix "UMTS_Video_IPv6"
    /// <summary>
    /// Defines bearer capable to tansfer video data in UMTS networks.
    /// <see href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#UMTS_VideoBearer"></see></summary>
    let UMTS_VideoBearer = _prefix "UMTS_VideoBearer"
    /// <summary>
    /// Defines bearer capable to transmit video.
    /// <see href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#VideoBearerService"></see></summary>
    let VideoBearerService = _prefix "VideoBearerService"
    /// <summary>
    /// Defines wireless LAN network type.
    /// <see href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#WLAN"></see></summary>
    let WLAN = _prefix "WLAN"
    /// <summary>
    /// Defines bearer accessible in wireless LAN networks specified in 802.11 IEEE standars.
    /// <see href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#WLANBearer"></see></summary>
    let WLANBearer = _prefix "WLANBearer"
    /// <summary>
    /// Defines bearer service in WLAN networks with IPv4 address protocol.
    /// <see href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#WLAN_IPv4"></see></summary>
    let WLAN_IPv4 = _prefix "WLAN_IPv4"
    /// <summary>
    /// Defines wi-fi connectivity.
    /// <see href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#WiFiConnectivity"></see></summary>
    let WiFiConnectivity = _prefix "WiFiConnectivity"
    /// <summary>
    /// Defines WiMax connectivity.
    /// <see href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#WiMAXConnectivity"></see></summary>
    let WiMAXConnectivity = _prefix "WiMAXConnectivity"
    /// <summary>
    /// Fixed, wireline connectivity type (e.g., PSTN)
    /// <see href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#WirelineConnectivityType"></see></summary>
    let WirelineConnectivityType = _prefix "WirelineConnectivityType"
