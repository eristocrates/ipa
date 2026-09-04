#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ct =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#" "ct"

    /// <summary>
    ///   <para>rdfs:comment : Defines type of address supported in network and associated with bearer. Specific addresses are modelled as instances e.g. GSM_MSISDN describe type of address used in GSM network.^^xsd:string</para>
    ///   <a href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#BearerAddressType">ct:BearerAddressType</a>
    /// </summary>
    let BearerAddressType = _prefixId.prefix "BearerAddressType"
    /// <summary>
    ///   <para>rdfs:comment : Defines transmission technology used to transfer voice or data in network.^^xsd:string</para>
    ///   <a href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#BearerType">ct:BearerType</a>
    /// </summary>
    let BearerType = _prefixId.prefix "BearerType"
    let BluetoothConnectivity = _prefixId.prefix "BluetoothConnectivity"
    let CSD = _prefixId.prefix "CSD"
    /// <summary>
    ///   <para>rdfs:comment : Cellular connectivity, e.g., GSM^^xsd:string</para>
    ///   <a href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#CellularConnectivityType">ct:CellularConnectivityType</a>
    /// </summary>
    let CellularConnectivityType = _prefixId.prefix "CellularConnectivityType"
    /// <summary>
    ///   <para>rdfs:comment : Defines bearer capable to transmit data.^^xsd:string</para>
    ///   <a href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#DataBearerService">ct:DataBearerService</a>
    /// </summary>
    let DataBearerService = _prefixId.prefix "DataBearerService"
    let EDGE = _prefixId.prefix "EDGE"
    let GPRS = _prefixId.prefix "GPRS"
    let GSM = _prefixId.prefix "GSM"
    let GSMConnectivity = _prefixId.prefix "GSMConnectivity"
    let GSM_CSD_IPv4 = _prefixId.prefix "GSM_CSD_IPv4"
    let GSM_CSD_MSISDN = _prefixId.prefix "GSM_CSD_MSISDN"
    let GSM_EDGE_IPv4 = _prefixId.prefix "GSM_EDGE_IPv4"
    let GSM_GPRS_IPV4 = _prefixId.prefix "GSM_GPRS_IPV4"
    let GSM_HSCSD_IPv4 = _prefixId.prefix "GSM_HSCSD_IPv4"
    let GSM_MSISDN = _prefixId.prefix "GSM_MSISDN"
    let GSM_SMS_MSISDN = _prefixId.prefix "GSM_SMS_MSISDN"
    let GSM_USSD = _prefixId.prefix "GSM_USSD"
    let HSCSD = _prefixId.prefix "HSCSD"
    let IPv4 = _prefixId.prefix "IPv4"
    let IPv6 = _prefixId.prefix "IPv6"
    let IS_95 = _prefixId.prefix "IS-95"
    let IrDAConnectivity = _prefixId.prefix "IrDAConnectivity"
    /// <summary>
    ///   <para>rdfs:comment : Long range wireless connectivity, such as WiMAX or GSM^^xsd:string</para>
    ///   <a href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#LongRangeConnectivityType">ct:LongRangeConnectivityType</a>
    /// </summary>
    let LongRangeConnectivityType = _prefixId.prefix "LongRangeConnectivityType"
    /// <summary>
    ///   <para>rdfs:comment : Defines general term for telecommunication network.^^xsd:string</para>
    ///   <a href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#Network">ct:Network</a>
    /// </summary>
    let Network = _prefixId.prefix "Network"
    /// <summary>
    ///   <para>rdfs:comment : Defines network bearer service that allows transmission of information signals between network interfaces. E.g. transmission of MMS in GSM network is modelled as instance 'GSM_GPRS_IPV4'. Bearer capabilities are modeled as sublasses.^^xsd:string</para>
    ///   <a href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#NetworkBearerService">ct:NetworkBearerService</a>
    /// </summary>
    let NetworkBearerService = _prefixId.prefix "NetworkBearerService"
    let SMS_BearerType = _prefixId.prefix "SMS_BearerType"
    /// <summary>
    ///   <para>rdfs:comment : Short range wireless connectivity type (WiFi, Bluetooth)^^xsd:string</para>
    ///   <a href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#ShortRangeConnectivityType">ct:ShortRangeConnectivityType</a>
    /// </summary>
    let ShortRangeConnectivityType = _prefixId.prefix "ShortRangeConnectivityType"
    /// <summary>
    ///   <para>rdfs:comment : Defines bearer capable to transmit text. E.g. bearer responsible for SMS transfer.^^xsd:string</para>
    ///   <a href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#TextBearerService">ct:TextBearerService</a>
    /// </summary>
    let TextBearerService = _prefixId.prefix "TextBearerService"
    let UMTS = _prefixId.prefix "UMTS"
    let UMTSConnectivity = _prefixId.prefix "UMTSConnectivity"
    let UMTS_VideoBearer = _prefixId.prefix "UMTS_VideoBearer"
    let UMTS_Video_IPv6 = _prefixId.prefix "UMTS_Video_IPv6"
    let USSD = _prefixId.prefix "USSD"
    /// <summary>
    ///   <para>rdfs:comment : Defines bearer capable to transmit video.^^xsd:string</para>
    ///   <a href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#VideoBearerService">ct:VideoBearerService</a>
    /// </summary>
    let VideoBearerService = _prefixId.prefix "VideoBearerService"
    /// <summary>
    ///   <para>rdfs:comment : Defines bearer capable to transmit voice.^^xsd:string</para>
    ///   <a href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#VoiceBearerService">ct:VoiceBearerService</a>
    /// </summary>
    let VoiceBearerService = _prefixId.prefix "VoiceBearerService"
    let WLAN = _prefixId.prefix "WLAN"
    let WLANBearer = _prefixId.prefix "WLANBearer"
    let WLAN_IPv4 = _prefixId.prefix "WLAN_IPv4"
    let WiFiConnectivity = _prefixId.prefix "WiFiConnectivity"
    let WiMAXConnectivity = _prefixId.prefix "WiMAXConnectivity"
    /// <summary>
    ///   <para>rdfs:comment : Wireless connectivity type (e.g., GSM connectivity)^^xsd:string</para>
    ///   <a href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#WirelessConnectivityType">ct:WirelessConnectivityType</a>
    /// </summary>
    let WirelessConnectivityType = _prefixId.prefix "WirelessConnectivityType"
    /// <summary>
    ///   <para>rdfs:comment : Fixed, wireline connectivity type (e.g., PSTN)^^xsd:string</para>
    ///   <a href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#WirelineConnectivityType">ct:WirelineConnectivityType</a>
    /// </summary>
    let WirelineConnectivityType = _prefixId.prefix "WirelineConnectivityType"
    /// <summary>
    ///   <para>rdfs:comment : Defines transmission technology.^^xsd:string</para>
    ///   <a href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#hasBearerType">ct:hasBearerType</a>
    /// </summary>
    let hasBearerType = _prefixId.prefix "hasBearerType"
    /// <summary>
    ///   <para>rdfs:comment : Defines network bearers supported by connectivity type.^^xsd:string</para>
    ///   <a href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#hasNetworkBearerService">ct:hasNetworkBearerService</a>
    /// </summary>
    let hasNetworkBearerService = _prefixId.prefix "hasNetworkBearerService"
    /// <summary>
    ///   <para>rdfs:comment : Defines network address type used by network bearer type.^^xsd:string</para>
    ///   <a href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#referesToAddress">ct:referesToAddress</a>
    /// </summary>
    let referesToAddress = _prefixId.prefix "referesToAddress"
    /// <summary>
    ///   <para>rdfs:comment : Defines network which supports bearer.^^xsd:string</para>
    ///   <a href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#referesToNetwork">ct:referesToNetwork</a>
    /// </summary>
    let referesToNetwork = _prefixId.prefix "referesToNetwork"
