namespace http.www.w3.org.ns.solid.notifications.hash

open DoxAletheia

module notify =
    let _namespace_name = "http://www.w3.org/ns/solid/notifications#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A notification channel type that uses the EventSource Web API.
    /// <see href="http://www.w3.org/ns/solid/notifications#EventSourceChannel2023"></see></summary>
    let EventSourceChannel2023 = _prefix "EventSourceChannel2023"
    /// <summary>
    /// A notification channel type that uses the Linked Data Notifications protocol.
    /// <see href="http://www.w3.org/ns/solid/notifications#LDNChannel2023"></see></summary>
    let LDNChannel2023 = _prefix "LDNChannel2023"
    /// <summary>
    /// A notification channel type that uses the Fetch API.
    /// <see href="http://www.w3.org/ns/solid/notifications#StreamingHTTPChannel2023"></see></summary>
    let StreamingHTTPChannel2023 = _prefix "StreamingHTTPChannel2023"
    /// <summary>
    /// A notification channel type that uses the WebSocket API.
    /// <see href="http://www.w3.org/ns/solid/notifications#WebSocketChannel2023"></see></summary>
    let WebSocketChannel2023 = _prefix "WebSocketChannel2023"
    /// <summary>
    /// A notification channel type that uses Webhooks.
    /// <see href="http://www.w3.org/ns/solid/notifications#WebhookChannel2023"></see></summary>
    let WebhookChannel2023 = _prefix "WebhookChannel2023"
    /// <summary>
    /// The media types that are acceptable by the recipient of a notification with value corresponding to the HTTP Accept header value [RFC7231].
    /// <see href="http://www.w3.org/ns/solid/notifications#accept"></see></summary>
    let accept = _prefix "accept"
    /// <summary>
    /// A property used to indicate an available notification channel.
    /// <see href="http://www.w3.org/ns/solid/notifications#channel"></see></summary>
    let channel = _prefix "channel"
    /// <summary>
    /// A property used to indicate the notification channel type.
    /// <see href="http://www.w3.org/ns/solid/notifications#channelType"></see></summary>
    let channelType = _prefix "channelType"
    /// <summary>
    /// The proposed or actual ending date and time of a notification channel with value represented in the xsd:dateTime datatype.
    /// <see href="http://www.w3.org/ns/solid/notifications#endAt"></see></summary>
    let endAt = _prefix "endAt"
    /// <summary>
    /// A property used to describe the features supported by a particular notification channel.
    /// <see href="http://www.w3.org/ns/solid/notifications#feature"></see></summary>
    let feature = _prefix "feature"
    /// <summary>
    /// The minimum amount of time to elapse between notifications sent to receiver with value represented in the xsd:duration datatype.
    /// <see href="http://www.w3.org/ns/solid/notifications#rate"></see></summary>
    let rate = _prefix "rate"
    /// <summary>
    /// The property used to identify the resource that can be used to establish a connection to receive notifications.
    /// <see href="http://www.w3.org/ns/solid/notifications#receiveFrom"></see></summary>
    let receiveFrom = _prefix "receiveFrom"
    /// <summary>
    /// The property used to identify the resource that can accept notifications.
    /// <see href="http://www.w3.org/ns/solid/notifications#sendTo"></see></summary>
    let sendTo = _prefix "sendTo"
    /// <summary>
    /// The property used to identify the party that sends notifications.
    /// <see href="http://www.w3.org/ns/solid/notifications#sender"></see></summary>
    let sender = _prefix "sender"
    /// <summary>
    /// The proposed or actual starting date and time of a notification channel with value represented in the xsd:dateTime datatype.
    /// <see href="http://www.w3.org/ns/solid/notifications#startAt"></see></summary>
    let startAt = _prefix "startAt"
    /// <summary>
    /// The last known state of a resource (topic) with value represented in the xsd:string datatype.
    /// <see href="http://www.w3.org/ns/solid/notifications#state"></see></summary>
    let state = _prefix "state"
    /// <summary>
    /// A property used to indicate an available subscription service.
    /// <see href="http://www.w3.org/ns/solid/notifications#subscription"></see></summary>
    let subscription = _prefix "subscription"
    /// <summary>
    /// The IRI of a resource about which a client would like to receive notifications.
    /// <see href="http://www.w3.org/ns/solid/notifications#topic"></see></summary>
    let topic = _prefix "topic"
