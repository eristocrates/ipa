namespace http.www.w3.org.ns.solid.notifications.hash

open DoxAletheia.Rdf_Vocabulary

module notify =
    let _namespace_name = "http://www.w3.org/ns/solid/notifications#"

    /// <summary>
    /// A notification channel type that uses the EventSource Web API.
    /// <see href="http://www.w3.org/ns/solid/notifications#EventSourceChannel2023"></see></summary>
    let EventSourceChannel2023 =
        Namespaced_IRI.parse _namespace_name "EventSourceChannel2023" |> NamespacedName

    /// <summary>
    /// A notification channel type that uses the Linked Data Notifications protocol.
    /// <see href="http://www.w3.org/ns/solid/notifications#LDNChannel2023"></see></summary>
    let LDNChannel2023 =
        Namespaced_IRI.parse _namespace_name "LDNChannel2023" |> NamespacedName

    /// <summary>
    /// A notification channel type that uses the Fetch API.
    /// <see href="http://www.w3.org/ns/solid/notifications#StreamingHTTPChannel2023"></see></summary>
    let StreamingHTTPChannel2023 =
        Namespaced_IRI.parse _namespace_name "StreamingHTTPChannel2023" |> NamespacedName

    /// <summary>
    /// A notification channel type that uses the WebSocket API.
    /// <see href="http://www.w3.org/ns/solid/notifications#WebSocketChannel2023"></see></summary>
    let WebSocketChannel2023 =
        Namespaced_IRI.parse _namespace_name "WebSocketChannel2023" |> NamespacedName

    /// <summary>
    /// A notification channel type that uses Webhooks.
    /// <see href="http://www.w3.org/ns/solid/notifications#WebhookChannel2023"></see></summary>
    let WebhookChannel2023 =
        Namespaced_IRI.parse _namespace_name "WebhookChannel2023" |> NamespacedName

    /// <summary>
    /// The media types that are acceptable by the recipient of a notification with value corresponding to the HTTP Accept header value [RFC7231].
    /// <see href="http://www.w3.org/ns/solid/notifications#accept"></see></summary>
    let accept = Namespaced_IRI.parse _namespace_name "accept" |> NamespacedName
    /// <summary>
    /// A property used to indicate an available notification channel.
    /// <see href="http://www.w3.org/ns/solid/notifications#channel"></see></summary>
    let channel = Namespaced_IRI.parse _namespace_name "channel" |> NamespacedName

    /// <summary>
    /// A property used to indicate the notification channel type.
    /// <see href="http://www.w3.org/ns/solid/notifications#channelType"></see></summary>
    let channelType =
        Namespaced_IRI.parse _namespace_name "channelType" |> NamespacedName

    /// <summary>
    /// The proposed or actual ending date and time of a notification channel with value represented in the xsd:dateTime datatype.
    /// <see href="http://www.w3.org/ns/solid/notifications#endAt"></see></summary>
    let endAt = Namespaced_IRI.parse _namespace_name "endAt" |> NamespacedName
    /// <summary>
    /// A property used to describe the features supported by a particular notification channel.
    /// <see href="http://www.w3.org/ns/solid/notifications#feature"></see></summary>
    let feature = Namespaced_IRI.parse _namespace_name "feature" |> NamespacedName
    /// <summary>
    /// The minimum amount of time to elapse between notifications sent to receiver with value represented in the xsd:duration datatype.
    /// <see href="http://www.w3.org/ns/solid/notifications#rate"></see></summary>
    let rate = Namespaced_IRI.parse _namespace_name "rate" |> NamespacedName

    /// <summary>
    /// The property used to identify the resource that can be used to establish a connection to receive notifications.
    /// <see href="http://www.w3.org/ns/solid/notifications#receiveFrom"></see></summary>
    let receiveFrom =
        Namespaced_IRI.parse _namespace_name "receiveFrom" |> NamespacedName

    /// <summary>
    /// The property used to identify the resource that can accept notifications.
    /// <see href="http://www.w3.org/ns/solid/notifications#sendTo"></see></summary>
    let sendTo = Namespaced_IRI.parse _namespace_name "sendTo" |> NamespacedName
    /// <summary>
    /// The property used to identify the party that sends notifications.
    /// <see href="http://www.w3.org/ns/solid/notifications#sender"></see></summary>
    let sender = Namespaced_IRI.parse _namespace_name "sender" |> NamespacedName
    /// <summary>
    /// The proposed or actual starting date and time of a notification channel with value represented in the xsd:dateTime datatype.
    /// <see href="http://www.w3.org/ns/solid/notifications#startAt"></see></summary>
    let startAt = Namespaced_IRI.parse _namespace_name "startAt" |> NamespacedName
    /// <summary>
    /// The last known state of a resource (topic) with value represented in the xsd:string datatype.
    /// <see href="http://www.w3.org/ns/solid/notifications#state"></see></summary>
    let state = Namespaced_IRI.parse _namespace_name "state" |> NamespacedName

    /// <summary>
    /// A property used to indicate an available subscription service.
    /// <see href="http://www.w3.org/ns/solid/notifications#subscription"></see></summary>
    let subscription =
        Namespaced_IRI.parse _namespace_name "subscription" |> NamespacedName

    /// <summary>
    /// The IRI of a resource about which a client would like to receive notifications.
    /// <see href="http://www.w3.org/ns/solid/notifications#topic"></see></summary>
    let topic = Namespaced_IRI.parse _namespace_name "topic" |> NamespacedName
