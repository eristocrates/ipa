namespace http.www.tele.pw.edu.pl._sims_onto.ConnectivityType.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module connectype =
    let _namespace_iri = Namespace_Iri connectype |> NamespaceIRI

    /// <summary>
    ///   <para>connectype:BearerAddressType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Defines type of address supported in network and associated with bearer. Specific addresses are modelled as instances e.g. GSM_MSISDN describe type of address used in GSM network."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#BearerAddressType">http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#BearerAddressType</seealso>
    let BearerAddressType =
        Prefixed_Name(connectype, "BearerAddressType") |> PrefixedName

    /// <summary>
    ///   <para>connectype:BearerType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Defines transmission technology used to transfer voice or data in network."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#BearerType">http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#BearerType</seealso>
    let BearerType = Prefixed_Name(connectype, "BearerType") |> PrefixedName

    /// <summary>
    ///   <para>connectype:BluetoothConnectivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>connectype:ShortRangeConnectivityType</para>
    ///   <para>"Defines Bluetooth connectivity."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#BluetoothConnectivity">http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#BluetoothConnectivity</seealso>
    let BluetoothConnectivity =
        Prefixed_Name(connectype, "BluetoothConnectivity") |> PrefixedName

    /// <summary>
    ///   <para>connectype:CSD</para>
    /// </summary>
    /// <remarks>
    ///   <para>connectype:BearerType</para>
    ///   <para>"Circuit Switched Data (CSD) is the original form of data transmission developed for the time division multiple access (TDMA)-based mobile phone systems like Global System for Mobile Communications (GSM)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#CSD">http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#CSD</seealso>
    let CSD = Prefixed_Name(connectype, "CSD") |> PrefixedName

    /// <summary>
    ///   <para>connectype:CellularConnectivityType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Cellular connectivity, e.g., GSM"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#CellularConnectivityType">http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#CellularConnectivityType</seealso>
    let CellularConnectivityType =
        Prefixed_Name(connectype, "CellularConnectivityType") |> PrefixedName

    /// <summary>
    ///   <para>connectype:DataBearerService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Defines bearer capable to transmit data."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#DataBearerService">http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#DataBearerService</seealso>
    let DataBearerService =
        Prefixed_Name(connectype, "DataBearerService") |> PrefixedName

    /// <summary>
    ///   <para>connectype:EDGE</para>
    /// </summary>
    /// <remarks>
    ///   <para>connectype:BearerType</para>
    ///   <para>"Defnes Enhanced Data rates for GSM Evolution technology which allows to increase data transmission rate."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#EDGE">http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#EDGE</seealso>
    let EDGE = Prefixed_Name(connectype, "EDGE") |> PrefixedName
    /// <summary>
    ///   <para>connectype:GPRS</para>
    /// </summary>
    /// <remarks>
    ///   <para>connectype:BearerType</para>
    ///   <para>"General Packet Radio Service (GPRS) is a Mobile Data Service available to users of Global System for Mobile Communications (GSM) and IS-136 mobile phones."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#GPRS">http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#GPRS</seealso>
    let GPRS = Prefixed_Name(connectype, "GPRS") |> PrefixedName
    /// <summary>
    ///   <para>connectype:GSM</para>
    /// </summary>
    /// <remarks>
    ///   <para>connectype:Network</para>
    ///   <para>"The Global System for Mobile communications is the most popular standard for mobile phones in the world. GSM is a cellular network, which means that mobile phones connect to it by searching for cells in the immediate vicinity."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#GSM">http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#GSM</seealso>
    let GSM = Prefixed_Name(connectype, "GSM") |> PrefixedName
    /// <summary>
    ///   <para>connectype:GSMConnectivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>connectype:CellularConnectivityType</para>
    ///   <para>"Defines GSM connectivity."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#GSMConnectivity">http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#GSMConnectivity</seealso>
    let GSMConnectivity = Prefixed_Name(connectype, "GSMConnectivity") |> PrefixedName
    /// <summary>
    ///   <para>connectype:GSM_CSD_IPv4</para>
    /// </summary>
    /// <remarks>
    ///   <para>connectype:DataBearerService</para>
    ///   <para>"Defines bearer service in GSM network which use IPv4 address type and CSD bearer. Type of data transfer bearer in GSM network."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#GSM_CSD_IPv4">http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#GSM_CSD_IPv4</seealso>
    let GSM_CSD_IPv4 = Prefixed_Name(connectype, "GSM_CSD_IPv4") |> PrefixedName
    /// <summary>
    ///   <para>connectype:GSM_CSD_MSISDN</para>
    /// </summary>
    /// <remarks>
    ///   <para>connectype:VoiceBearerService</para>
    ///   <para>"Defines bearer service in GSM network which use MSISDN address type and CSD bearer. Type of voice transfer bearer in GSM network."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#GSM_CSD_MSISDN">http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#GSM_CSD_MSISDN</seealso>
    let GSM_CSD_MSISDN = Prefixed_Name(connectype, "GSM_CSD_MSISDN") |> PrefixedName
    /// <summary>
    ///   <para>connectype:GSM_EDGE_IPv4</para>
    /// </summary>
    /// <remarks>
    ///   <para>connectype:DataBearerService</para>
    ///   <para>"Defines EDGE bearer service in GSM network with IPv4 address protocol."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#GSM_EDGE_IPv4">http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#GSM_EDGE_IPv4</seealso>
    let GSM_EDGE_IPv4 = Prefixed_Name(connectype, "GSM_EDGE_IPv4") |> PrefixedName
    /// <summary>
    ///   <para>connectype:GSM_GPRS_IPV4</para>
    /// </summary>
    /// <remarks>
    ///   <para>connectype:DataBearerService</para>
    ///   <para>"Defines GPRS bearer service in GSM network using IPv4 address type. Type of data transfer bearer in GSM network."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#GSM_GPRS_IPV4">http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#GSM_GPRS_IPV4</seealso>
    let GSM_GPRS_IPV4 = Prefixed_Name(connectype, "GSM_GPRS_IPV4") |> PrefixedName
    /// <summary>
    ///   <para>connectype:GSM_HSCSD_IPv4</para>
    /// </summary>
    /// <remarks>
    ///   <para>connectype:DataBearerService</para>
    ///   <para>"Defines HSCSD bearer service in GSM network with IP v4 address protocol."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#GSM_HSCSD_IPv4">http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#GSM_HSCSD_IPv4</seealso>
    let GSM_HSCSD_IPv4 = Prefixed_Name(connectype, "GSM_HSCSD_IPv4") |> PrefixedName
    /// <summary>
    ///   <para>connectype:GSM_MSISDN</para>
    /// </summary>
    /// <remarks>
    ///   <para>connectype:BearerAddressType</para>
    ///   <para>"MSISDN (Mobile Subscriber ISDN Number) refers to the telephone number of a mobile subscriber. MSISDN by ITU-T is at most 15 digits long and consists of: * CC - Country Code ( 1-3 digits e.g."48" for Poland), * NDC - National Destination Code (e.g. 3 digits in Poland), * SN - Subscriber Number (e.g. 6 remaining digits (123456))."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#GSM_MSISDN">http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#GSM_MSISDN</seealso>
    let GSM_MSISDN = Prefixed_Name(connectype, "GSM_MSISDN") |> PrefixedName
    /// <summary>
    ///   <para>connectype:GSM_SMS_MSISDN</para>
    /// </summary>
    /// <remarks>
    ///   <para>connectype:TextBearerService</para>
    ///   <para>"Defines SMS bearer service in GSM network using GSM_MSISDN address type."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#GSM_SMS_MSISDN">http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#GSM_SMS_MSISDN</seealso>
    let GSM_SMS_MSISDN = Prefixed_Name(connectype, "GSM_SMS_MSISDN") |> PrefixedName
    /// <summary>
    ///   <para>connectype:GSM_USSD</para>
    /// </summary>
    /// <remarks>
    ///   <para>connectype:DataBearerService</para>
    ///   <para>"USSD is a technology built into the GSM standard for support of transmitting information over the signaling channels of the GSM network. USSD provides session-based communication. Defined within the GSM standard in the documents GSM 02.90 (USSD Stage 1) and GSM 03.90 (USSD Stage 2)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#GSM_USSD">http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#GSM_USSD</seealso>
    let GSM_USSD = Prefixed_Name(connectype, "GSM_USSD") |> PrefixedName
    /// <summary>
    ///   <para>connectype:HSCSD</para>
    /// </summary>
    /// <remarks>
    ///   <para>connectype:BearerType</para>
    ///   <para>"Defines High-Speed Circuit-Switched Data, data transmission mechanism in GSM Network, enhancement of CSD."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#HSCSD">http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#HSCSD</seealso>
    let HSCSD = Prefixed_Name(connectype, "HSCSD") |> PrefixedName
    /// <summary>
    ///   <para>connectype:IPv4</para>
    /// </summary>
    /// <remarks>
    ///   <para>connectype:BearerAddressType</para>
    ///   <para>"IP address (Internet Protocol address) is a unique address that certain electronic devices use in order to identify and communicate with each other on a computer network utilizing the Internet Protocol standard (IP). IPv4 uses 32-bit (4 byte) addresses."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#IPv4">http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#IPv4</seealso>
    let IPv4 = Prefixed_Name(connectype, "IPv4") |> PrefixedName
    /// <summary>
    ///   <para>connectype:IPv6</para>
    /// </summary>
    /// <remarks>
    ///   <para>connectype:BearerAddressType</para>
    ///   <para>"IP address (Internet Protocol address) is a unique address that certain electronic devices use in order to identify and communicate with each other on a computer network utilizing the Internet Protocol standard (IP). IPv6 uses 128-bit addresses."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#IPv6">http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#IPv6</seealso>
    let IPv6 = Prefixed_Name(connectype, "IPv6") |> PrefixedName
    /// <summary>
    ///   <para>connectype:IS-95</para>
    /// </summary>
    /// <remarks>
    ///   <para>connectype:Network</para>
    ///   <para>"Interim Standard 95 (IS-95), is the first CDMA-based digital cellular standard pioneered by Qualcomm. CDMA or "code division multiple access" is a digital radio system that transmits streams of bits (PN Sequences)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#IS-95">http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#IS-95</seealso>
    let IS_95 = Prefixed_Name(connectype, "IS-95") |> PrefixedName
    /// <summary>
    ///   <para>connectype:IrDAConnectivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>connectype:ShortRangeConnectivityType</para>
    ///   <para>"Defines IrDA connectivity."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#IrDAConnectivity">http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#IrDAConnectivity</seealso>
    let IrDAConnectivity = Prefixed_Name(connectype, "IrDAConnectivity") |> PrefixedName

    /// <summary>
    ///   <para>connectype:LongRangeConnectivityType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Long range wireless connectivity, such as WiMAX or GSM"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#LongRangeConnectivityType">http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#LongRangeConnectivityType</seealso>
    let LongRangeConnectivityType =
        Prefixed_Name(connectype, "LongRangeConnectivityType") |> PrefixedName

    /// <summary>
    ///   <para>connectype:Network</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Defines general term for telecommunication network."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#Network">http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#Network</seealso>
    let Network = Prefixed_Name(connectype, "Network") |> PrefixedName

    /// <summary>
    ///   <para>connectype:NetworkBearerService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Defines network bearer service that allows transmission of information signals between network interfaces. E.g. transmission of MMS in GSM network is modelled as instance 'GSM_GPRS_IPV4'. Bearer capabilities are modeled as sublasses."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#NetworkBearerService">http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#NetworkBearerService</seealso>
    let NetworkBearerService =
        Prefixed_Name(connectype, "NetworkBearerService") |> PrefixedName

    /// <summary>
    ///   <para>connectype:SMS_BearerType</para>
    /// </summary>
    /// <remarks>
    ///   <para>connectype:BearerType</para>
    ///   <para>"Defines transmission technology used in GSM network to transmit SMS messages."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#SMS_BearerType">http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#SMS_BearerType</seealso>
    let SMS_BearerType = Prefixed_Name(connectype, "SMS_BearerType") |> PrefixedName

    /// <summary>
    ///   <para>connectype:ShortRangeConnectivityType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Short range wireless connectivity type (WiFi, Bluetooth)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#ShortRangeConnectivityType">http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#ShortRangeConnectivityType</seealso>
    let ShortRangeConnectivityType =
        Prefixed_Name(connectype, "ShortRangeConnectivityType") |> PrefixedName

    /// <summary>
    ///   <para>connectype:TextBearerService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Defines bearer capable to transmit text. E.g. bearer responsible for SMS transfer."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#TextBearerService">http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#TextBearerService</seealso>
    let TextBearerService =
        Prefixed_Name(connectype, "TextBearerService") |> PrefixedName

    /// <summary>
    ///   <para>connectype:UMTS</para>
    /// </summary>
    /// <remarks>
    ///   <para>connectype:Network</para>
    ///   <para>"Universal Mobile Telecommunications System (UMTS) is one of the third-generation (3G) cell phone technologies."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#UMTS">http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#UMTS</seealso>
    let UMTS = Prefixed_Name(connectype, "UMTS") |> PrefixedName
    /// <summary>
    ///   <para>connectype:UMTSConnectivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>connectype:CellularConnectivityType</para>
    ///   <para>"Defines UMTS connectivity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#UMTSConnectivity">http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#UMTSConnectivity</seealso>
    let UMTSConnectivity = Prefixed_Name(connectype, "UMTSConnectivity") |> PrefixedName
    /// <summary>
    ///   <para>connectype:UMTS_VideoBearer</para>
    /// </summary>
    /// <remarks>
    ///   <para>connectype:BearerType</para>
    ///   <para>"Defines bearer capable to tansfer video data in UMTS networks."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#UMTS_VideoBearer">http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#UMTS_VideoBearer</seealso>
    let UMTS_VideoBearer = Prefixed_Name(connectype, "UMTS_VideoBearer") |> PrefixedName
    /// <summary>
    ///   <para>connectype:UMTS_Video_IPv6</para>
    /// </summary>
    /// <remarks>
    ///   <para>connectype:VideoBearerService</para>
    ///   <para>"Defines video bearer in UMTS network which use IPv6 address type. It is bearer capable to transfer video."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#UMTS_Video_IPv6">http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#UMTS_Video_IPv6</seealso>
    let UMTS_Video_IPv6 = Prefixed_Name(connectype, "UMTS_Video_IPv6") |> PrefixedName
    /// <summary>
    ///   <para>connectype:USSD</para>
    /// </summary>
    /// <remarks>
    ///   <para>connectype:BearerType</para>
    ///   <para>"Defines bearer capable to transmit information over the signaling channels of the GSM network."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#USSD">http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#USSD</seealso>
    let USSD = Prefixed_Name(connectype, "USSD") |> PrefixedName

    /// <summary>
    ///   <para>connectype:VideoBearerService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Defines bearer capable to transmit video."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#VideoBearerService">http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#VideoBearerService</seealso>
    let VideoBearerService =
        Prefixed_Name(connectype, "VideoBearerService") |> PrefixedName

    /// <summary>
    ///   <para>connectype:VoiceBearerService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Defines bearer capable to transmit voice."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#VoiceBearerService">http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#VoiceBearerService</seealso>
    let VoiceBearerService =
        Prefixed_Name(connectype, "VoiceBearerService") |> PrefixedName

    /// <summary>
    ///   <para>connectype:WLAN</para>
    /// </summary>
    /// <remarks>
    ///   <para>connectype:Network</para>
    ///   <para>"Defines wireless LAN network type."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#WLAN">http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#WLAN</seealso>
    let WLAN = Prefixed_Name(connectype, "WLAN") |> PrefixedName
    /// <summary>
    ///   <para>connectype:WLANBearer</para>
    /// </summary>
    /// <remarks>
    ///   <para>connectype:BearerType</para>
    ///   <para>"Defines bearer accessible in wireless LAN networks specified in 802.11 IEEE standars."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#WLANBearer">http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#WLANBearer</seealso>
    let WLANBearer = Prefixed_Name(connectype, "WLANBearer") |> PrefixedName
    /// <summary>
    ///   <para>connectype:WLAN_IPv4</para>
    /// </summary>
    /// <remarks>
    ///   <para>connectype:DataBearerService</para>
    ///   <para>"Defines bearer service in WLAN networks with IPv4 address protocol."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#WLAN_IPv4">http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#WLAN_IPv4</seealso>
    let WLAN_IPv4 = Prefixed_Name(connectype, "WLAN_IPv4") |> PrefixedName
    /// <summary>
    ///   <para>connectype:WiFiConnectivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>connectype:ShortRangeConnectivityType</para>
    ///   <para>"Defines wi-fi connectivity."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#WiFiConnectivity">http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#WiFiConnectivity</seealso>
    let WiFiConnectivity = Prefixed_Name(connectype, "WiFiConnectivity") |> PrefixedName

    /// <summary>
    ///   <para>connectype:WiMAXConnectivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>connectype:LongRangeConnectivityType</para>
    ///   <para>"Defines WiMax connectivity."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#WiMAXConnectivity">http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#WiMAXConnectivity</seealso>
    let WiMAXConnectivity =
        Prefixed_Name(connectype, "WiMAXConnectivity") |> PrefixedName

    /// <summary>
    ///   <para>connectype:WirelessConnectivityType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Wireless connectivity type (e.g., GSM connectivity)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#WirelessConnectivityType">http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#WirelessConnectivityType</seealso>
    let WirelessConnectivityType =
        Prefixed_Name(connectype, "WirelessConnectivityType") |> PrefixedName

    /// <summary>
    ///   <para>connectype:WirelineConnectivityType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Fixed, wireline connectivity type (e.g., PSTN)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#WirelineConnectivityType">http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#WirelineConnectivityType</seealso>
    let WirelineConnectivityType =
        Prefixed_Name(connectype, "WirelineConnectivityType") |> PrefixedName

    /// <summary>
    ///   <para>connectype:hasBearerType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Defines transmission technology."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#hasBearerType">http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#hasBearerType</seealso>
    let hasBearerType = Prefixed_Name(connectype, "hasBearerType") |> PrefixedName

    /// <summary>
    ///   <para>connectype:hasNetworkBearerService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Defines network bearers supported by connectivity type."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#hasNetworkBearerService">http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#hasNetworkBearerService</seealso>
    let hasNetworkBearerService =
        Prefixed_Name(connectype, "hasNetworkBearerService") |> PrefixedName

    /// <summary>
    ///   <para>connectype:referesToAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Defines network address type used by network bearer type."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#referesToAddress">http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#referesToAddress</seealso>
    let referesToAddress = Prefixed_Name(connectype, "referesToAddress") |> PrefixedName
    /// <summary>
    ///   <para>connectype:referesToNetwork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Defines network which supports bearer."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#referesToNetwork">http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#referesToNetwork</seealso>
    let referesToNetwork = Prefixed_Name(connectype, "referesToNetwork") |> PrefixedName
