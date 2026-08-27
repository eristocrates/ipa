namespace http.www.w3.org._2007.uwa.context.network.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module net =
    let _namespace_iri = Namespace_Iri net |> NamespaceIRI
    /// <summary>
    ///   <para>net:ANSI-136_800</para>
    /// </summary>
    /// <remarks>
    ///   <para>net:NetworkMode</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#ANSI-136_800">http://www.w3.org/2007/uwa/context/network.owl#ANSI-136_800</seealso>
    let ANSI_136_800 = Prefixed_Name(net, "ANSI-136_800") |> PrefixedName
    /// <summary>
    ///   <para>net:APN</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The Access Point Name associated to a network bearer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"APN"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#APN">http://www.w3.org/2007/uwa/context/network.owl#APN</seealso>
    let APN = Prefixed_Name(net, "APN") |> PrefixedName
    /// <summary>
    ///   <para>net:BandwidthSupport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the bandwith characteristics provided by a Network Bearer Technology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Bandwidth Support"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#BandwidthSupport">http://www.w3.org/2007/uwa/context/network.owl#BandwidthSupport</seealso>
    let BandwidthSupport = Prefixed_Name(net, "BandwidthSupport") |> PrefixedName
    /// <summary>
    ///   <para>net:BearerType_CDPD</para>
    /// </summary>
    /// <remarks>
    ///   <para>net:NetworkBearerTechnology</para>
    ///   <para>"Cellular Digital Packet Data"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#BearerType_CDPD">http://www.w3.org/2007/uwa/context/network.owl#BearerType_CDPD</seealso>
    let BearerType_CDPD = Prefixed_Name(net, "BearerType_CDPD") |> PrefixedName
    /// <summary>
    ///   <para>net:BearerType_CSD</para>
    /// </summary>
    /// <remarks>
    ///   <para>net:NetworkBearerTechnology</para>
    ///   <para>"Circuit Switched Data"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#BearerType_CSD">http://www.w3.org/2007/uwa/context/network.owl#BearerType_CSD</seealso>
    let BearerType_CSD = Prefixed_Name(net, "BearerType_CSD") |> PrefixedName
    /// <summary>
    ///   <para>net:BearerType_EDGE</para>
    /// </summary>
    /// <remarks>
    ///   <para>net:NetworkBearerTechnology</para>
    ///   <para>"Enhanced Data rates for GSM Evolution (EDGE)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#BearerType_EDGE">http://www.w3.org/2007/uwa/context/network.owl#BearerType_EDGE</seealso>
    let BearerType_EDGE = Prefixed_Name(net, "BearerType_EDGE") |> PrefixedName
    /// <summary>
    ///   <para>net:BearerType_FLEX</para>
    /// </summary>
    /// <remarks>
    ///   <para>net:NetworkBearerTechnology</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#BearerType_FLEX">http://www.w3.org/2007/uwa/context/network.owl#BearerType_FLEX</seealso>
    let BearerType_FLEX = Prefixed_Name(net, "BearerType_FLEX") |> PrefixedName
    /// <summary>
    ///   <para>net:BearerType_GHOST</para>
    /// </summary>
    /// <remarks>
    ///   <para>net:NetworkBearerTechnology</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#BearerType_GHOST">http://www.w3.org/2007/uwa/context/network.owl#BearerType_GHOST</seealso>
    let BearerType_GHOST = Prefixed_Name(net, "BearerType_GHOST") |> PrefixedName
    /// <summary>
    ///   <para>net:BearerType_GPRS</para>
    /// </summary>
    /// <remarks>
    ///   <para>net:NetworkBearerTechnology</para>
    ///   <para>"GPRS over GSM networks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#BearerType_GPRS">http://www.w3.org/2007/uwa/context/network.owl#BearerType_GPRS</seealso>
    let BearerType_GPRS = Prefixed_Name(net, "BearerType_GPRS") |> PrefixedName
    /// <summary>
    ///   <para>net:BearerType_GUTS</para>
    /// </summary>
    /// <remarks>
    ///   <para>net:NetworkBearerTechnology</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#BearerType_GUTS">http://www.w3.org/2007/uwa/context/network.owl#BearerType_GUTS</seealso>
    let BearerType_GUTS = Prefixed_Name(net, "BearerType_GUTS") |> PrefixedName
    /// <summary>
    ///   <para>net:BearerType_HSCSD</para>
    /// </summary>
    /// <remarks>
    ///   <para>net:NetworkBearerTechnology</para>
    ///   <para>"High-Speed Circuit-Switched Data"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#BearerType_HSCSD">http://www.w3.org/2007/uwa/context/network.owl#BearerType_HSCSD</seealso>
    let BearerType_HSCSD = Prefixed_Name(net, "BearerType_HSCSD") |> PrefixedName
    /// <summary>
    ///   <para>net:BearerType_HSUPA</para>
    /// </summary>
    /// <remarks>
    ///   <para>net:NetworkBearerTechnology</para>
    ///   <para>"High-Speed Uplink Packet Access"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#BearerType_HSUPA">http://www.w3.org/2007/uwa/context/network.owl#BearerType_HSUPA</seealso>
    let BearerType_HSUPA = Prefixed_Name(net, "BearerType_HSUPA") |> PrefixedName
    /// <summary>
    ///   <para>net:BearerType_MPAK</para>
    /// </summary>
    /// <remarks>
    ///   <para>net:NetworkBearerTechnology</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#BearerType_MPAK">http://www.w3.org/2007/uwa/context/network.owl#BearerType_MPAK</seealso>
    let BearerType_MPAK = Prefixed_Name(net, "BearerType_MPAK") |> PrefixedName
    /// <summary>
    ///   <para>net:BearerType_PACKET</para>
    /// </summary>
    /// <remarks>
    ///   <para>net:NetworkBearerTechnology</para>
    ///   <para>"Generic packet-based bearer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#BearerType_PACKET">http://www.w3.org/2007/uwa/context/network.owl#BearerType_PACKET</seealso>
    let BearerType_PACKET = Prefixed_Name(net, "BearerType_PACKET") |> PrefixedName
    /// <summary>
    ///   <para>net:BearerType_REFLEX</para>
    /// </summary>
    /// <remarks>
    ///   <para>net:NetworkBearerTechnology</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#BearerType_REFLEX">http://www.w3.org/2007/uwa/context/network.owl#BearerType_REFLEX</seealso>
    let BearerType_REFLEX = Prefixed_Name(net, "BearerType_REFLEX") |> PrefixedName
    /// <summary>
    ///   <para>net:BearerType_SDS</para>
    /// </summary>
    /// <remarks>
    ///   <para>net:NetworkBearerTechnology</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#BearerType_SDS">http://www.w3.org/2007/uwa/context/network.owl#BearerType_SDS</seealso>
    let BearerType_SDS = Prefixed_Name(net, "BearerType_SDS") |> PrefixedName
    /// <summary>
    ///   <para>net:BearerType_SMS</para>
    /// </summary>
    /// <remarks>
    ///   <para>net:NetworkBearerTechnology</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#BearerType_SMS">http://www.w3.org/2007/uwa/context/network.owl#BearerType_SMS</seealso>
    let BearerType_SMS = Prefixed_Name(net, "BearerType_SMS") |> PrefixedName
    /// <summary>
    ///   <para>net:BearerType_USSD</para>
    /// </summary>
    /// <remarks>
    ///   <para>net:NetworkBearerTechnology</para>
    ///   <para>"Unstructured Supplementary Service Data is a capability of all GSM phones. It is generally associated with real-time or instant messaging type phone services."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#BearerType_USSD">http://www.w3.org/2007/uwa/context/network.owl#BearerType_USSD</seealso>
    let BearerType_USSD = Prefixed_Name(net, "BearerType_USSD") |> PrefixedName

    /// <summary>
    ///   <para>net:Context_NetworkEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class reprensents the set of all delivery context entities that have  to do with network characteristics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Context Network Entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#Context_NetworkEntity">http://www.w3.org/2007/uwa/context/network.owl#Context_NetworkEntity</seealso>
    let Context_NetworkEntity =
        Prefixed_Name(net, "Context_NetworkEntity") |> PrefixedName

    /// <summary>
    ///   <para>net:GSM_900_1800_1900</para>
    /// </summary>
    /// <remarks>
    ///   <para>net:NetworkMode</para>
    ///   <para>"Typical GSM operation in Europe"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#GSM_900_1800_1900">http://www.w3.org/2007/uwa/context/network.owl#GSM_900_1800_1900</seealso>
    let GSM_900_1800_1900 = Prefixed_Name(net, "GSM_900_1800_1900") |> PrefixedName
    /// <summary>
    ///   <para>net:HttpProxy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It is a forwarding agent, receiving requests for a URI in its absolute form, rewriting all or part of the message, and forwarding the reformatted request toward the server identified by the URI."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Http Proxy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#HttpProxy">http://www.w3.org/2007/uwa/context/network.owl#HttpProxy</seealso>
    let HttpProxy = Prefixed_Name(net, "HttpProxy") |> PrefixedName
    /// <summary>
    ///   <para>net:IS-95_800_1900</para>
    /// </summary>
    /// <remarks>
    ///   <para>net:NetworkMode</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#IS-95_800_1900">http://www.w3.org/2007/uwa/context/network.owl#IS-95_800_1900</seealso>
    let IS_95_800_1900 = Prefixed_Name(net, "IS-95_800_1900") |> PrefixedName
    /// <summary>
    ///   <para>net:Network</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents a  Network in the Delivery Context"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Network"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#Network">http://www.w3.org/2007/uwa/context/network.owl#Network</seealso>
    let Network = Prefixed_Name(net, "Network") |> PrefixedName
    /// <summary>
    ///   <para>net:NetworkBearer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents a network bearer in a delivery context"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Network Bearer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#NetworkBearer">http://www.w3.org/2007/uwa/context/network.owl#NetworkBearer</seealso>
    let NetworkBearer = Prefixed_Name(net, "NetworkBearer") |> PrefixedName

    /// <summary>
    ///   <para>net:NetworkBearerTechnology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents network bearer technologies"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Network Bearer Technology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#NetworkBearerTechnology">http://www.w3.org/2007/uwa/context/network.owl#NetworkBearerTechnology</seealso>
    let NetworkBearerTechnology =
        Prefixed_Name(net, "NetworkBearerTechnology") |> PrefixedName

    /// <summary>
    ///   <para>net:NetworkMode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A mode of operation of a network which includes network technology and operation frequency bands"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Newtwork Mode"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#NetworkMode">http://www.w3.org/2007/uwa/context/network.owl#NetworkMode</seealso>
    let NetworkMode = Prefixed_Name(net, "NetworkMode") |> PrefixedName
    /// <summary>
    ///   <para>net:NetworkSupport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the network characteristics of a device"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Network Support"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#NetworkSupport">http://www.w3.org/2007/uwa/context/network.owl#NetworkSupport</seealso>
    let NetworkSupport = Prefixed_Name(net, "NetworkSupport") |> PrefixedName
    /// <summary>
    ///   <para>net:NetworkTechnology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents different network technologies"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Network Technology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#NetworkTechnology">http://www.w3.org/2007/uwa/context/network.owl#NetworkTechnology</seealso>
    let NetworkTechnology = Prefixed_Name(net, "NetworkTechnology") |> PrefixedName
    /// <summary>
    ///   <para>net:NetworkType_AMPS</para>
    /// </summary>
    /// <remarks>
    ///   <para>net:NetworkTechnology</para>
    ///   <para>"Advanced Mobile Phone System"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#NetworkType_AMPS">http://www.w3.org/2007/uwa/context/network.owl#NetworkType_AMPS</seealso>
    let NetworkType_AMPS = Prefixed_Name(net, "NetworkType_AMPS") |> PrefixedName

    /// <summary>
    ///   <para>net:NetworkType_ANSI-136</para>
    /// </summary>
    /// <remarks>
    ///   <para>net:NetworkTechnology</para>
    ///   <para>"ANSI-136"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#NetworkType_ANSI-136">http://www.w3.org/2007/uwa/context/network.owl#NetworkType_ANSI-136</seealso>
    let NetworkType_ANSI_136 =
        Prefixed_Name(net, "NetworkType_ANSI-136") |> PrefixedName

    /// <summary>
    ///   <para>net:NetworkType_CDMA2000_1xRTT</para>
    /// </summary>
    /// <remarks>
    ///   <para>net:NetworkTechnology</para>
    ///   <para>"CDMA 2000 1xRTT"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#NetworkType_CDMA2000_1xRTT">http://www.w3.org/2007/uwa/context/network.owl#NetworkType_CDMA2000_1xRTT</seealso>
    let NetworkType_CDMA2000_1xRTT =
        Prefixed_Name(net, "NetworkType_CDMA2000_1xRTT") |> PrefixedName

    /// <summary>
    ///   <para>net:NetworkType_CDMA2000_EVDO</para>
    /// </summary>
    /// <remarks>
    ///   <para>net:NetworkTechnology</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#NetworkType_CDMA2000_EVDO">http://www.w3.org/2007/uwa/context/network.owl#NetworkType_CDMA2000_EVDO</seealso>
    let NetworkType_CDMA2000_EVDO =
        Prefixed_Name(net, "NetworkType_CDMA2000_EVDO") |> PrefixedName

    /// <summary>
    ///   <para>net:NetworkType_CDMA2000_EVDV</para>
    /// </summary>
    /// <remarks>
    ///   <para>net:NetworkTechnology</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#NetworkType_CDMA2000_EVDV">http://www.w3.org/2007/uwa/context/network.owl#NetworkType_CDMA2000_EVDV</seealso>
    let NetworkType_CDMA2000_EVDV =
        Prefixed_Name(net, "NetworkType_CDMA2000_EVDV") |> PrefixedName

    /// <summary>
    ///   <para>net:NetworkType_GSM</para>
    /// </summary>
    /// <remarks>
    ///   <para>net:NetworkTechnology</para>
    ///   <para>"Global System for Mobile Communications"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#NetworkType_GSM">http://www.w3.org/2007/uwa/context/network.owl#NetworkType_GSM</seealso>
    let NetworkType_GSM = Prefixed_Name(net, "NetworkType_GSM") |> PrefixedName
    /// <summary>
    ///   <para>net:NetworkType_HSDPA</para>
    /// </summary>
    /// <remarks>
    ///   <para>net:NetworkBearerTechnology</para>
    ///   <para>"High-Speed Downlink Packet Access"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#NetworkType_HSDPA">http://www.w3.org/2007/uwa/context/network.owl#NetworkType_HSDPA</seealso>
    let NetworkType_HSDPA = Prefixed_Name(net, "NetworkType_HSDPA") |> PrefixedName

    /// <summary>
    ///   <para>net:NetworkType_IEEE_802.11a</para>
    /// </summary>
    /// <remarks>
    ///   <para>net:NetworkTechnology</para>
    ///   <para>"WiFi 802.11a"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#NetworkType_IEEE_802.11a">http://www.w3.org/2007/uwa/context/network.owl#NetworkType_IEEE_802.11a</seealso>
    let ``NetworkType_IEEE_802.11a`` =
        Prefixed_Name(net, "NetworkType_IEEE_802.11a") |> PrefixedName

    /// <summary>
    ///   <para>net:NetworkType_IEEE_802.11b</para>
    /// </summary>
    /// <remarks>
    ///   <para>net:NetworkTechnology</para>
    ///   <para>"WiFi 802.11b"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#NetworkType_IEEE_802.11b">http://www.w3.org/2007/uwa/context/network.owl#NetworkType_IEEE_802.11b</seealso>
    let ``NetworkType_IEEE_802.11b`` =
        Prefixed_Name(net, "NetworkType_IEEE_802.11b") |> PrefixedName

    /// <summary>
    ///   <para>net:NetworkType_IEEE_802.11g</para>
    /// </summary>
    /// <remarks>
    ///   <para>net:NetworkTechnology</para>
    ///   <para>"Wi-Fi 802.11g"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#NetworkType_IEEE_802.11g">http://www.w3.org/2007/uwa/context/network.owl#NetworkType_IEEE_802.11g</seealso>
    let ``NetworkType_IEEE_802.11g`` =
        Prefixed_Name(net, "NetworkType_IEEE_802.11g") |> PrefixedName

    /// <summary>
    ///   <para>net:NetworkType_IS-95</para>
    /// </summary>
    /// <remarks>
    ///   <para>net:NetworkTechnology</para>
    ///   <para>"IS-95"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#NetworkType_IS-95">http://www.w3.org/2007/uwa/context/network.owl#NetworkType_IS-95</seealso>
    let NetworkType_IS_95 = Prefixed_Name(net, "NetworkType_IS-95") |> PrefixedName
    /// <summary>
    ///   <para>net:NetworkType_Mobitex</para>
    /// </summary>
    /// <remarks>
    ///   <para>net:NetworkTechnology</para>
    ///   <para>"MobiTex Network"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#NetworkType_Mobitex">http://www.w3.org/2007/uwa/context/network.owl#NetworkType_Mobitex</seealso>
    let NetworkType_Mobitex = Prefixed_Name(net, "NetworkType_Mobitex") |> PrefixedName
    /// <summary>
    ///   <para>net:NetworkType_PDC</para>
    /// </summary>
    /// <remarks>
    ///   <para>net:NetworkTechnology</para>
    ///   <para>"Personal Digital Cellular"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#NetworkType_PDC">http://www.w3.org/2007/uwa/context/network.owl#NetworkType_PDC</seealso>
    let NetworkType_PDC = Prefixed_Name(net, "NetworkType_PDC") |> PrefixedName
    /// <summary>
    ///   <para>net:NetworkType_PHS</para>
    /// </summary>
    /// <remarks>
    ///   <para>net:NetworkTechnology</para>
    ///   <para>"Personal Handy-phone System"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#NetworkType_PHS">http://www.w3.org/2007/uwa/context/network.owl#NetworkType_PHS</seealso>
    let NetworkType_PHS = Prefixed_Name(net, "NetworkType_PHS") |> PrefixedName

    /// <summary>
    ///   <para>net:NetworkType_TD-SCDMA</para>
    /// </summary>
    /// <remarks>
    ///   <para>net:NetworkTechnology</para>
    ///   <para>"Chinese standard"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#NetworkType_TD-SCDMA">http://www.w3.org/2007/uwa/context/network.owl#NetworkType_TD-SCDMA</seealso>
    let NetworkType_TD_SCDMA =
        Prefixed_Name(net, "NetworkType_TD-SCDMA") |> PrefixedName

    /// <summary>
    ///   <para>net:NetworkType_TETRA</para>
    /// </summary>
    /// <remarks>
    ///   <para>net:NetworkTechnology</para>
    ///   <para>"TErrestrial Trunked RAdio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#NetworkType_TETRA">http://www.w3.org/2007/uwa/context/network.owl#NetworkType_TETRA</seealso>
    let NetworkType_TETRA = Prefixed_Name(net, "NetworkType_TETRA") |> PrefixedName

    /// <summary>
    ///   <para>net:NetworkType_UMTS_W-CDMA</para>
    /// </summary>
    /// <remarks>
    ///   <para>net:NetworkTechnology</para>
    ///   <para>"UMTS with W-CDMA air interface"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#NetworkType_UMTS_W-CDMA">http://www.w3.org/2007/uwa/context/network.owl#NetworkType_UMTS_W-CDMA</seealso>
    let NetworkType_UMTS_W_CDMA =
        Prefixed_Name(net, "NetworkType_UMTS_W-CDMA") |> PrefixedName

    /// <summary>
    ///   <para>net:NetworkType_iDEN</para>
    /// </summary>
    /// <remarks>
    ///   <para>net:NetworkTechnology</para>
    ///   <para>"Integrated Digital Enhanced Network"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#NetworkType_iDEN">http://www.w3.org/2007/uwa/context/network.owl#NetworkType_iDEN</seealso>
    let NetworkType_iDEN = Prefixed_Name(net, "NetworkType_iDEN") |> PrefixedName
    /// <summary>
    ///   <para>net:Networks_Disjoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:AllDisjointSet</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#Networks_Disjoint">http://www.w3.org/2007/uwa/context/network.owl#Networks_Disjoint</seealso>
    let Networks_Disjoint = Prefixed_Name(net, "Networks_Disjoint") |> PrefixedName
    /// <summary>
    ///   <para>net:NonTransparentProxy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An HTTP a proxy that modifies the request or response in order to provide some added service to the user agent, such as group annotation services, media type transformation, protocol reduction, or anonymity filtering."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Non Transparent HTTP Proxy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#NonTransparentProxy">http://www.w3.org/2007/uwa/context/network.owl#NonTransparentProxy</seealso>
    let NonTransparentProxy = Prefixed_Name(net, "NonTransparentProxy") |> PrefixedName
    /// <summary>
    ///   <para>net:PDC_800_1500</para>
    /// </summary>
    /// <remarks>
    ///   <para>net:NetworkMode</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#PDC_800_1500">http://www.w3.org/2007/uwa/context/network.owl#PDC_800_1500</seealso>
    let PDC_800_1500 = Prefixed_Name(net, "PDC_800_1500") |> PrefixedName
    /// <summary>
    ///   <para>net:PLMNetwork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A public land mobile network (PLMN) is a network that is established and operated by an administration or by a recognized operating agency (ROA) for the specific purpose of providing land mobile telecommunications services to the public"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Public Land Mobile Network"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#PLMNetwork">http://www.w3.org/2007/uwa/context/network.owl#PLMNetwork</seealso>
    let PLMNetwork = Prefixed_Name(net, "PLMNetwork") |> PrefixedName
    /// <summary>
    ///   <para>net:Proxies_Disjoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:AllDisjointSet</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#Proxies_Disjoint">http://www.w3.org/2007/uwa/context/network.owl#Proxies_Disjoint</seealso>
    let Proxies_Disjoint = Prefixed_Name(net, "Proxies_Disjoint") |> PrefixedName
    /// <summary>
    ///   <para>net:Proxy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A computer network service that allows clients to make indirect network connections to other network services"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Proxy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#Proxy">http://www.w3.org/2007/uwa/context/network.owl#Proxy</seealso>
    let Proxy = Prefixed_Name(net, "Proxy") |> PrefixedName
    /// <summary>
    ///   <para>net:SiblingDisjoint_2</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:AllDisjointSet</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#SiblingDisjoint_2">http://www.w3.org/2007/uwa/context/network.owl#SiblingDisjoint_2</seealso>
    let SiblingDisjoint_2 = Prefixed_Name(net, "SiblingDisjoint_2") |> PrefixedName
    /// <summary>
    ///   <para>net:Sibling_Disjoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:AllDisjointSet</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#Sibling_Disjoint">http://www.w3.org/2007/uwa/context/network.owl#Sibling_Disjoint</seealso>
    let Sibling_Disjoint = Prefixed_Name(net, "Sibling_Disjoint") |> PrefixedName
    /// <summary>
    ///   <para>net:TermGroup_Network</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:TermGroup</para>
    ///   <para>"This group models classes, properties and instances that have to do with the Network characteristics of the Delivery Context"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Network"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#TermGroup_Network">http://www.w3.org/2007/uwa/context/network.owl#TermGroup_Network</seealso>
    let TermGroup_Network = Prefixed_Name(net, "TermGroup_Network") |> PrefixedName
    /// <summary>
    ///   <para>net:Tetra_400_900</para>
    /// </summary>
    /// <remarks>
    ///   <para>net:NetworkMode</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#Tetra_400_900">http://www.w3.org/2007/uwa/context/network.owl#Tetra_400_900</seealso>
    let Tetra_400_900 = Prefixed_Name(net, "Tetra_400_900") |> PrefixedName
    /// <summary>
    ///   <para>net:TransparentProxy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An HTTP proxy that does not modify the request or response beyond what is required for proxy authentication and identification."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Transparent HTTP Proxy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#TransparentProxy">http://www.w3.org/2007/uwa/context/network.owl#TransparentProxy</seealso>
    let TransparentProxy = Prefixed_Name(net, "TransparentProxy") |> PrefixedName
    /// <summary>
    ///   <para>net:UMTS</para>
    /// </summary>
    /// <remarks>
    ///   <para>net:NetworkBearerTechnology</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#UMTS">http://www.w3.org/2007/uwa/context/network.owl#UMTS</seealso>
    let UMTS = Prefixed_Name(net, "UMTS") |> PrefixedName
    /// <summary>
    ///   <para>net:UMTS_2100</para>
    /// </summary>
    /// <remarks>
    ///   <para>net:NetworkMode</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#UMTS_2100">http://www.w3.org/2007/uwa/context/network.owl#UMTS_2100</seealso>
    let UMTS_2100 = Prefixed_Name(net, "UMTS_2100") |> PrefixedName
    /// <summary>
    ///   <para>net:WiFi80211b_2400</para>
    /// </summary>
    /// <remarks>
    ///   <para>net:NetworkMode</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#WiFi80211b_2400">http://www.w3.org/2007/uwa/context/network.owl#WiFi80211b_2400</seealso>
    let WiFi80211b_2400 = Prefixed_Name(net, "WiFi80211b_2400") |> PrefixedName
    /// <summary>
    ///   <para>net:WiFiNetwork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents a WiFi network"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"WiFi Network"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#WiFiNetwork">http://www.w3.org/2007/uwa/context/network.owl#WiFiNetwork</seealso>
    let WiFiNetwork = Prefixed_Name(net, "WiFiNetwork") |> PrefixedName
    /// <summary>
    ///   <para>net:WiredNetwork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents a wired network in general"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Wired Network"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#WiredNetwork">http://www.w3.org/2007/uwa/context/network.owl#WiredNetwork</seealso>
    let WiredNetwork = Prefixed_Name(net, "WiredNetwork") |> PrefixedName

    /// <summary>
    ///   <para>net:availableNetworkBearers</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The available network bearers offered by a Network or available for a Device"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Available Network Bearers"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#availableNetworkBearers">http://www.w3.org/2007/uwa/context/network.owl#availableNetworkBearers</seealso>
    let availableNetworkBearers =
        Prefixed_Name(net, "availableNetworkBearers") |> PrefixedName

    /// <summary>
    ///   <para>net:bandwidthSupport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The bandwidth support offered by a Network Bearer Technology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Bandwidth Support"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#bandwidthSupport">http://www.w3.org/2007/uwa/context/network.owl#bandwidthSupport</seealso>
    let bandwidthSupport = Prefixed_Name(net, "bandwidthSupport") |> PrefixedName
    /// <summary>
    ///   <para>net:bearerNetwork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The network that provides the infraestructure of a Network Bearer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Bearer Network"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#bearerNetwork">http://www.w3.org/2007/uwa/context/network.owl#bearerNetwork</seealso>
    let bearerNetwork = Prefixed_Name(net, "bearerNetwork") |> PrefixedName
    /// <summary>
    ///   <para>net:bearerTechnology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The technology used by a Network Bearer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Network Bearer Technology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#bearerTechnology">http://www.w3.org/2007/uwa/context/network.owl#bearerTechnology</seealso>
    let bearerTechnology = Prefixed_Name(net, "bearerTechnology") |> PrefixedName
    /// <summary>
    ///   <para>net:cellId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The id of the cell to which the device is interacting with in the mobile network"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Cell Identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#cellId">http://www.w3.org/2007/uwa/context/network.owl#cellId</seealso>
    let cellId = Prefixed_Name(net, "cellId") |> PrefixedName
    /// <summary>
    ///   <para>net:connectedNetworks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The networks to which a device is currently connected"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Connected Networks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#connectedNetworks">http://www.w3.org/2007/uwa/context/network.owl#connectedNetworks</seealso>
    let connectedNetworks = Prefixed_Name(net, "connectedNetworks") |> PrefixedName

    /// <summary>
    ///   <para>net:currentDownloadBandwidth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property represents the current download bandwidth offered by a network bearer measured in Kbits/s"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Current Download Bandwidth"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#currentDownloadBandwidth">http://www.w3.org/2007/uwa/context/network.owl#currentDownloadBandwidth</seealso>
    let currentDownloadBandwidth =
        Prefixed_Name(net, "currentDownloadBandwidth") |> PrefixedName

    /// <summary>
    ///   <para>net:currentUploadBandwidth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property represents the current upload bandwidth offered by a Network Bearer measured in Kbits/s"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Current Upload Bandwidth"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#currentUploadBandwidth">http://www.w3.org/2007/uwa/context/network.owl#currentUploadBandwidth</seealso>
    let currentUploadBandwidth =
        Prefixed_Name(net, "currentUploadBandwidth") |> PrefixedName

    /// <summary>
    ///   <para>net:defaultNetworkBearer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property represents the default Network Bearer for a Device"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Default Network Bearer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#defaultNetworkBearer">http://www.w3.org/2007/uwa/context/network.owl#defaultNetworkBearer</seealso>
    let defaultNetworkBearer =
        Prefixed_Name(net, "defaultNetworkBearer") |> PrefixedName

    /// <summary>
    ///   <para>net:homePLMNetwork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The home PLMN network of a device"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Home Network"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#homePLMNetwork">http://www.w3.org/2007/uwa/context/network.owl#homePLMNetwork</seealso>
    let homePLMNetwork = Prefixed_Name(net, "homePLMNetwork") |> PrefixedName
    /// <summary>
    ///   <para>net:iDEN_800</para>
    /// </summary>
    /// <remarks>
    ///   <para>net:NetworkMode</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#iDEN_800">http://www.w3.org/2007/uwa/context/network.owl#iDEN_800</seealso>
    let iDEN_800 = Prefixed_Name(net, "iDEN_800") |> PrefixedName

    /// <summary>
    ///   <para>net:maxDownloadBandwidth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"This property represents a maximum download bandwidth measured in Kbits/s"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Maximum download Bandwidth"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#maxDownloadBandwidth">http://www.w3.org/2007/uwa/context/network.owl#maxDownloadBandwidth</seealso>
    let maxDownloadBandwidth =
        Prefixed_Name(net, "maxDownloadBandwidth") |> PrefixedName

    /// <summary>
    ///   <para>net:maxUploadBandwidth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property represents a maximum upload bandwidth measured in Kbits/s"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Maximum Upload Bandwidth"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#maxUploadBandwidth">http://www.w3.org/2007/uwa/context/network.owl#maxUploadBandwidth</seealso>
    let maxUploadBandwidth = Prefixed_Name(net, "maxUploadBandwidth") |> PrefixedName
    /// <summary>
    ///   <para>net:mcc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property identifies univoquely the country of a mobile network"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mobile Country Code"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#mcc">http://www.w3.org/2007/uwa/context/network.owl#mcc</seealso>
    let mcc = Prefixed_Name(net, "mcc") |> PrefixedName
    /// <summary>
    ///   <para>net:minDownloadBandwith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"This property represents a minimum download bandwidth that can be offered and measured in Kbits/s"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Minimum Download Bandwidth"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#minDownloadBandwith">http://www.w3.org/2007/uwa/context/network.owl#minDownloadBandwith</seealso>
    let minDownloadBandwith = Prefixed_Name(net, "minDownloadBandwith") |> PrefixedName
    /// <summary>
    ///   <para>net:minUploadBandwidth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property represents a minimum upload bandwidth that can be offered measured in Kbits/s"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Minimum Upload Bandwidth"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#minUploadBandwidth">http://www.w3.org/2007/uwa/context/network.owl#minUploadBandwidth</seealso>
    let minUploadBandwidth = Prefixed_Name(net, "minUploadBandwidth") |> PrefixedName
    /// <summary>
    ///   <para>net:mnc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A Mobile Network Code (MNC) is used in combination with a Mobile Country Code (MCC) (also known as a "MCC / MNC tuple") to uniquely identify a mobile phone operator/carrier using the GSM, CDMA, iDEN, TETRA and UMTS public land mobile networks and some satellite mobile networks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mobile Network Code"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#mnc">http://www.w3.org/2007/uwa/context/network.owl#mnc</seealso>
    let mnc = Prefixed_Name(net, "mnc") |> PrefixedName
    /// <summary>
    ///   <para>net:networkMode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property represents the network mode of a Network"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Network Mode"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#networkMode">http://www.w3.org/2007/uwa/context/network.owl#networkMode</seealso>
    let networkMode = Prefixed_Name(net, "networkMode") |> PrefixedName
    /// <summary>
    ///   <para>net:networkSupport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The network-related characteristics of a device"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Network Support"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#networkSupport">http://www.w3.org/2007/uwa/context/network.owl#networkSupport</seealso>
    let networkSupport = Prefixed_Name(net, "networkSupport") |> PrefixedName
    /// <summary>
    ///   <para>net:networkTechnology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"This property holds a network technology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Network Technology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#networkTechnology">http://www.w3.org/2007/uwa/context/network.owl#networkTechnology</seealso>
    let networkTechnology = Prefixed_Name(net, "networkTechnology") |> PrefixedName
    /// <summary>
    ///   <para>net:operationBands</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The frequencies of operation of a network. Frequencies are expressed in  Mhz"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Operation Band"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#operationBands">http://www.w3.org/2007/uwa/context/network.owl#operationBands</seealso>
    let operationBands = Prefixed_Name(net, "operationBands") |> PrefixedName

    /// <summary>
    ///   <para>net:preferredNetworkBearer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"This property represents the preferred network bearer for a Network"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Preferred Network Bearer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#preferredNetworkBearer">http://www.w3.org/2007/uwa/context/network.owl#preferredNetworkBearer</seealso>
    let preferredNetworkBearer =
        Prefixed_Name(net, "preferredNetworkBearer") |> PrefixedName

    /// <summary>
    ///   <para>net:presentNetworks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The networks that are present in the current Environment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Present Networks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#presentNetworks">http://www.w3.org/2007/uwa/context/network.owl#presentNetworks</seealso>
    let presentNetworks = Prefixed_Name(net, "presentNetworks") |> PrefixedName
    /// <summary>
    ///   <para>net:proxy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property represents one or more proxies that can be present while using a Network Bearer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Proxy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#proxy">http://www.w3.org/2007/uwa/context/network.owl#proxy</seealso>
    let proxy = Prefixed_Name(net, "proxy") |> PrefixedName
    /// <summary>
    ///   <para>net:signalStrength</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"This property indicates the relative (from 0 to 100) signal strength offered by a Network in this Context"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Signal Strength"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#signalStrength">http://www.w3.org/2007/uwa/context/network.owl#signalStrength</seealso>
    let signalStrength = Prefixed_Name(net, "signalStrength") |> PrefixedName
    /// <summary>
    ///   <para>net:ssid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The SSID of a WiFi network"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Service Set Identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#ssid">http://www.w3.org/2007/uwa/context/network.owl#ssid</seealso>
    let ssid = Prefixed_Name(net, "ssid") |> PrefixedName

    /// <summary>
    ///   <para>net:supportedNetworkBearers</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property holds the set of network bearers supported by a Network or by a Device."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Supported Network Bearers"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#supportedNetworkBearers">http://www.w3.org/2007/uwa/context/network.owl#supportedNetworkBearers</seealso>
    let supportedNetworkBearers =
        Prefixed_Name(net, "supportedNetworkBearers") |> PrefixedName

    /// <summary>
    ///   <para>net:supportedNetworkModes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The supported Network Modes of a Device"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Supported Network Modes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#supportedNetworkModes">http://www.w3.org/2007/uwa/context/network.owl#supportedNetworkModes</seealso>
    let supportedNetworkModes =
        Prefixed_Name(net, "supportedNetworkModes") |> PrefixedName

    /// <summary>
    ///   <para>net:typicalDownloadBandwith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property represents a typical download bandwidth measured in Kbits/s"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Typical Download Bandwidth"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#typicalDownloadBandwith">http://www.w3.org/2007/uwa/context/network.owl#typicalDownloadBandwith</seealso>
    let typicalDownloadBandwith =
        Prefixed_Name(net, "typicalDownloadBandwith") |> PrefixedName

    /// <summary>
    ///   <para>net:typicalUploadBandwidth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property represents a typical upload bandwith measured in Kbits/s"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Typical Upload Bandwidth"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/network.owl#typicalUploadBandwidth">http://www.w3.org/2007/uwa/context/network.owl#typicalUploadBandwidth</seealso>
    let typicalUploadBandwidth =
        Prefixed_Name(net, "typicalUploadBandwidth") |> PrefixedName
