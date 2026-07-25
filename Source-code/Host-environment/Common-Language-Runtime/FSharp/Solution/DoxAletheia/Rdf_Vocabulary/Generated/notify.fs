namespace http.www.w3.org.ns.solid.notifications.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module notify =
    let _namespace_iri = Namespace_Iri notify |> NamespaceIRI

    /// <summary>
    ///   <para>notify:EventSourceChannel2023</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Class</para>
    ///   <para>A notification channel type that uses the EventSource Web API.</para>
    /// labels<para>EventSourceChannel2023</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/notifications#EventSourceChannel2023">http://www.w3.org/ns/solid/notifications#EventSourceChannel2023</seealso>
    let EventSourceChannel2023 =
        Prefixed_Name(notify, "EventSourceChannel2023") |> PrefixedName

    /// <summary>
    ///   <para>notify:sendTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The property used to identify the resource that can accept notifications.</para>
    /// labels<para>send to</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/notifications#sendTo">http://www.w3.org/ns/solid/notifications#sendTo</seealso>
    let sendTo = Prefixed_Name(notify, "sendTo") |> PrefixedName
    /// <summary>
    ///   <para>notify:sender</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The property used to identify the party that sends notifications.</para>
    /// labels<para>sender</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/notifications#sender">http://www.w3.org/ns/solid/notifications#sender</seealso>
    let sender = Prefixed_Name(notify, "sender") |> PrefixedName

    /// <summary>
    ///   <para>notify:StreamingHTTPChannel2023</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Class</para>
    ///   <para>A notification channel type that uses the Fetch API.</para>
    /// labels<para>StreamingHTTPChannel2023</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/notifications#StreamingHTTPChannel2023">http://www.w3.org/ns/solid/notifications#StreamingHTTPChannel2023</seealso>
    let StreamingHTTPChannel2023 =
        Prefixed_Name(notify, "StreamingHTTPChannel2023") |> PrefixedName

    /// <summary>
    ///   <para>notify:WebhookChannel2023</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Class</para>
    ///   <para>A notification channel type that uses Webhooks.</para>
    /// labels<para>WebhookChannel2023</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/notifications#WebhookChannel2023">http://www.w3.org/ns/solid/notifications#WebhookChannel2023</seealso>
    let WebhookChannel2023 = Prefixed_Name(notify, "WebhookChannel2023") |> PrefixedName
    /// <summary>
    ///   <para>notify:accept</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The media types that are acceptable by the recipient of a notification with value corresponding to the HTTP Accept header value [RFC7231].</para>
    /// labels<para>accept</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/notifications#accept">http://www.w3.org/ns/solid/notifications#accept</seealso>
    let accept = Prefixed_Name(notify, "accept") |> PrefixedName
    /// <summary>
    ///   <para>notify:channel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A property used to indicate an available notification channel.</para>
    /// labels<para>notification channel</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/notifications#channel">http://www.w3.org/ns/solid/notifications#channel</seealso>
    let channel = Prefixed_Name(notify, "channel") |> PrefixedName
    /// <summary>
    ///   <para>notify:endAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The proposed or actual ending date and time of a notification channel with value represented in the xsd:dateTime datatype.</para>
    /// labels<para>end at</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/notifications#endAt">http://www.w3.org/ns/solid/notifications#endAt</seealso>
    let endAt = Prefixed_Name(notify, "endAt") |> PrefixedName
    /// <summary>
    ///   <para>notify:rate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The minimum amount of time to elapse between notifications sent to receiver with value represented in the xsd:duration datatype.</para>
    /// labels<para>rate</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/notifications#rate">http://www.w3.org/ns/solid/notifications#rate</seealso>
    let rate = Prefixed_Name(notify, "rate") |> PrefixedName

    /// <summary>
    ///   <para>notify:WebSocketChannel2023</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Class</para>
    ///   <para>A notification channel type that uses the WebSocket API.</para>
    /// labels<para>WebSocketChannel2023</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/notifications#WebSocketChannel2023">http://www.w3.org/ns/solid/notifications#WebSocketChannel2023</seealso>
    let WebSocketChannel2023 =
        Prefixed_Name(notify, "WebSocketChannel2023") |> PrefixedName

    /// <summary>
    ///   <para>notify:channelType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A property used to indicate the notification channel type.</para>
    /// labels<para>notification channel type</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/notifications#channelType">http://www.w3.org/ns/solid/notifications#channelType</seealso>
    let channelType = Prefixed_Name(notify, "channelType") |> PrefixedName
    /// <summary>
    ///   <para>notify:receiveFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The property used to identify the resource that can be used to establish a connection to receive notifications.</para>
    /// labels<para>receive from</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/notifications#receiveFrom">http://www.w3.org/ns/solid/notifications#receiveFrom</seealso>
    let receiveFrom = Prefixed_Name(notify, "receiveFrom") |> PrefixedName
    /// <summary>
    ///   <para>notify:feature</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A property used to describe the features supported by a particular notification channel.</para>
    /// labels<para>feature</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/notifications#feature">http://www.w3.org/ns/solid/notifications#feature</seealso>
    let feature = Prefixed_Name(notify, "feature") |> PrefixedName
    /// <summary>
    ///   <para>notify:state</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The last known state of a resource (topic) with value represented in the xsd:string datatype.</para>
    /// labels<para>state</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/notifications#state">http://www.w3.org/ns/solid/notifications#state</seealso>
    let state = Prefixed_Name(notify, "state") |> PrefixedName
    /// <summary>
    ///   <para>notify:startAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The proposed or actual starting date and time of a notification channel with value represented in the xsd:dateTime datatype.</para>
    /// labels<para>start at</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/notifications#startAt">http://www.w3.org/ns/solid/notifications#startAt</seealso>
    let startAt = Prefixed_Name(notify, "startAt") |> PrefixedName
    /// <summary>
    ///   <para>notify:subscription</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A property used to indicate an available subscription service.</para>
    /// labels<para>subscription</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/notifications#subscription">http://www.w3.org/ns/solid/notifications#subscription</seealso>
    let subscription = Prefixed_Name(notify, "subscription") |> PrefixedName
    /// <summary>
    ///   <para>notify:topic</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The IRI of a resource about which a client would like to receive notifications.</para>
    /// labels<para>topic</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/notifications#topic">http://www.w3.org/ns/solid/notifications#topic</seealso>
    let topic = Prefixed_Name(notify, "topic") |> PrefixedName
    /// <summary>
    ///   <para>notify:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>The vocabulary used by the Solid Notifications Protocol specification.</para>
    /// labels<para>Solid Notifications</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/notifications#">http://www.w3.org/ns/solid/notifications#</seealso>
    let _prefix_iri = Prefixed_Name(notify, "") |> PrefixedName
    /// <summary>
    ///   <para>notify:LDNChannel2023</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Class</para>
    ///   <para>A notification channel type that uses the Linked Data Notifications protocol.</para>
    /// labels<para>LDNChannel2023</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/notifications#LDNChannel2023">http://www.w3.org/ns/solid/notifications#LDNChannel2023</seealso>
    let LDNChannel2023 = Prefixed_Name(notify, "LDNChannel2023") |> PrefixedName
