namespace http.www.w3.org._2007.uwa.context.push.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module push =
    let _namespace_iri = Namespace_Iri push |> NamespaceIRI
    /// <summary>
    ///   <para>push:MmsClient</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A user agent capable of managing MMS Messages"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"MMS User Agent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/push.owl#MmsClient">http://www.w3.org/2007/uwa/context/push.owl#MmsClient</seealso>
    let MmsClient = Prefixed_Name(push, "MmsClient") |> PrefixedName
    /// <summary>
    ///   <para>push:PushClient</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents user agents capable of receiving and processing push requests"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Push Client"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/push.owl#PushClient">http://www.w3.org/2007/uwa/context/push.owl#PushClient</seealso>
    let PushClient = Prefixed_Name(push, "PushClient") |> PrefixedName
    /// <summary>
    ///   <para>push:WapPushClient</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A user agent capable of managing WAP Push incoming messages"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"WAP Push Client"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/push.owl#WapPushClient">http://www.w3.org/2007/uwa/context/push.owl#WapPushClient</seealso>
    let WapPushClient = Prefixed_Name(push, "WapPushClient") |> PrefixedName
    /// <summary>
    ///   <para>push:applicationIds</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property represents the list of types of Push-enabled applications supported by the device. Application identifiers are represented on absolute URI format. A wildcard ("*") may be used to indicate support for any application"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Push Application Ids"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/push.owl#applicationIds">http://www.w3.org/2007/uwa/context/push.owl#applicationIds</seealso>
    let applicationIds = Prefixed_Name(push, "applicationIds") |> PrefixedName
    /// <summary>
    ///   <para>push:defaultMmsClient</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The default MMS client on the device"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Default MMS Client"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/push.owl#defaultMmsClient">http://www.w3.org/2007/uwa/context/push.owl#defaultMmsClient</seealso>
    let defaultMmsClient = Prefixed_Name(push, "defaultMmsClient") |> PrefixedName

    /// <summary>
    ///   <para>push:defaultWapPushClient</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The default WAP Push Client on a device"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Default WAP Push Client"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/push.owl#defaultWapPushClient">http://www.w3.org/2007/uwa/context/push.owl#defaultWapPushClient</seealso>
    let defaultWapPushClient =
        Prefixed_Name(push, "defaultWapPushClient") |> PrefixedName

    /// <summary>
    ///   <para>push:maxMmsMessageSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The maximum size of an interchanged message in byes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"MMS Maximum Message Size"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/push.owl#maxMmsMessageSize">http://www.w3.org/2007/uwa/context/push.owl#maxMmsMessageSize</seealso>
    let maxMmsMessageSize = Prefixed_Name(push, "maxMmsMessageSize") |> PrefixedName

    /// <summary>
    ///   <para>push:maxWapPushMessageSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"THe maximum message size supported by the WAP Push User Agent in bytes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"WAP Push Maximum Message Size"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/push.owl#maxWapPushMessageSize">http://www.w3.org/2007/uwa/context/push.owl#maxWapPushMessageSize</seealso>
    let maxWapPushMessageSize =
        Prefixed_Name(push, "maxWapPushMessageSize") |> PrefixedName

    /// <summary>
    ///   <para>push:maxWapPushRequests</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The maximum number of WAP Push requests that the WAP Push User Agent is capable to deal with"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"WAP Push Maximum Number of Requests"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/push.owl#maxWapPushRequests">http://www.w3.org/2007/uwa/context/push.owl#maxWapPushRequests</seealso>
    let maxWapPushRequests = Prefixed_Name(push, "maxWapPushRequests") |> PrefixedName
    /// <summary>
    ///   <para>push:mmsVersions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The supported MMS versions"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"MMS versions"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/push.owl#mmsVersions">http://www.w3.org/2007/uwa/context/push.owl#mmsVersions</seealso>
    let mmsVersions = Prefixed_Name(push, "mmsVersions") |> PrefixedName
    /// <summary>
    ///   <para>push:wapPushVersions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Represents the versions of the (WAP) Push enabler supported"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"WAP Push Versions"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/push.owl#wapPushVersions">http://www.w3.org/2007/uwa/context/push.owl#wapPushVersions</seealso>
    let wapPushVersions = Prefixed_Name(push, "wapPushVersions") |> PrefixedName
