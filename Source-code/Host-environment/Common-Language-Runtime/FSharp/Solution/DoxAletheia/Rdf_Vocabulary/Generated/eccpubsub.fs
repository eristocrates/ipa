namespace https.vocab.eccenca.com.pubsub.slash

open DoxAletheia.Rdf_Vocabulary

module eccpubsub =
    let _namespace_name = "https://vocab.eccenca.com/pubsub/"

    /// <summary>
    /// An HTTP endpoint acting as callback of a subscriber.
    /// <see href="https://vocab.eccenca.com/pubsub/CallbackEndpoint"></see></summary>
    let CallbackEndpoint =
        Namespaced_IRI.parse _namespace_name "CallbackEndpoint" |> NamespacedName

    /// <summary>
    /// A PubSubHubbub HTTP endpoint. Individuals of this class MUST be referenced by their URL.
    /// <see href="https://vocab.eccenca.com/pubsub/Endpoint"></see></summary>
    let Endpoint = Namespaced_IRI.parse _namespace_name "Endpoint" |> NamespacedName

    /// <summary>
    /// An HTTP endpoint acting as hub.
    /// <see href="https://vocab.eccenca.com/pubsub/HubEndpoint"></see></summary>
    let HubEndpoint =
        Namespaced_IRI.parse _namespace_name "HubEndpoint" |> NamespacedName

    /// <summary>
    /// Indicates that a subscription is valided and verified.
    /// <see href="https://vocab.eccenca.com/pubsub/SUBSCRIPTION_ACTIVE"></see></summary>
    let SUBSCRIPTION_ACTIVE =
        Namespaced_IRI.parse _namespace_name "SUBSCRIPTION_ACTIVE" |> NamespacedName

    /// <summary>
    /// A state of a subscription.
    /// <see href="https://vocab.eccenca.com/pubsub/SubscriptionState"></see></summary>
    let SubscriptionState =
        Namespaced_IRI.parse _namespace_name "SubscriptionState" |> NamespacedName

    /// <summary>
    /// Indicates that a susbcription was canceled by the subscriber.
    /// <see href="https://vocab.eccenca.com/pubsub/SUBSCRIPTION_CANCELED"></see></summary>
    let SUBSCRIPTION_CANCELED =
        Namespaced_IRI.parse _namespace_name "SUBSCRIPTION_CANCELED" |> NamespacedName

    /// <summary>
    /// Indicates that a subscription was denied by a publisher.
    /// <see href="https://vocab.eccenca.com/pubsub/SUBSCRIPTION_DENIED"></see></summary>
    let SUBSCRIPTION_DENIED =
        Namespaced_IRI.parse _namespace_name "SUBSCRIPTION_DENIED" |> NamespacedName

    /// <summary>
    /// Indicates that a subscription cancellation request was successfully sent to the hub but is not yet verified.
    /// <see href="https://vocab.eccenca.com/pubsub/SUBSCRIPTION_REQUEST_CANCELED"></see></summary>
    let SUBSCRIPTION_REQUEST_CANCELED =
        Namespaced_IRI.parse _namespace_name "SUBSCRIPTION_REQUEST_CANCELED" |> NamespacedName

    /// <summary>
    /// A state of a subscription request.
    /// <see href="https://vocab.eccenca.com/pubsub/SubscriptionRequestState"></see></summary>
    let SubscriptionRequestState =
        Namespaced_IRI.parse _namespace_name "SubscriptionRequestState" |> NamespacedName

    /// <summary>
    /// Indicates that a subscription cancellation request was successfully verified.
    /// <see href="https://vocab.eccenca.com/pubsub/SUBSCRIPTION_REQUEST_DELETED"></see></summary>
    let SUBSCRIPTION_REQUEST_DELETED =
        Namespaced_IRI.parse _namespace_name "SUBSCRIPTION_REQUEST_DELETED" |> NamespacedName

    /// <summary>
    /// Indicates that a subscription request was denied.
    /// <see href="https://vocab.eccenca.com/pubsub/SUBSCRIPTION_REQUEST_DENIED"></see></summary>
    let SUBSCRIPTION_REQUEST_DENIED =
        Namespaced_IRI.parse _namespace_name "SUBSCRIPTION_REQUEST_DENIED" |> NamespacedName

    /// <summary>
    /// Indicates that a subscription request was successfully sent to the hub but is not yet verified.
    /// <see href="https://vocab.eccenca.com/pubsub/SUBSCRIPTION_REQUEST_PENDING"></see></summary>
    let SUBSCRIPTION_REQUEST_PENDING =
        Namespaced_IRI.parse _namespace_name "SUBSCRIPTION_REQUEST_PENDING" |> NamespacedName

    /// <summary>
    /// Indicates that a subscription request was successfully validated and verified.
    /// <see href="https://vocab.eccenca.com/pubsub/SUBSCRIPTION_REQUEST_VERIFIED"></see></summary>
    let SUBSCRIPTION_REQUEST_VERIFIED =
        Namespaced_IRI.parse _namespace_name "SUBSCRIPTION_REQUEST_VERIFIED" |> NamespacedName

    /// <summary>
    /// A unique relation to a topic by a subscriber that indicates it should receive updates for that topic.
    /// <see href="https://vocab.eccenca.com/pubsub/Subscription"></see></summary>
    let Subscription =
        Namespaced_IRI.parse _namespace_name "Subscription" |> NamespacedName

    /// <summary>
    /// The state of a subscription.
    /// <see href="https://vocab.eccenca.com/pubsub/state"></see></summary>
    let state = Namespaced_IRI.parse _namespace_name "state" |> NamespacedName
    /// <summary>
    /// A secret string that will be used to compute an HMAC digest for authorized content distribution. If not supplied, the HMAC digest will not be present for content distribution requests.
    /// <see href="https://vocab.eccenca.com/pubsub/secret"></see></summary>
    let secret = Namespaced_IRI.parse _namespace_name "secret" |> NamespacedName

    /// <summary>
    /// The reason for which the subscription (request) has been denied.
    /// <see href="https://vocab.eccenca.com/pubsub/deniedReason"></see></summary>
    let deniedReason =
        Namespaced_IRI.parse _namespace_name "deniedReason" |> NamespacedName

    /// <summary>
    /// The URL at which a subscriber wishes to receive notifications.
    /// <see href="https://vocab.eccenca.com/pubsub/callback"></see></summary>
    let callback = Namespaced_IRI.parse _namespace_name "callback" |> NamespacedName
    /// <summary>
    /// The resource URI for which updates should be published.
    /// <see href="https://vocab.eccenca.com/pubsub/topic"></see></summary>
    let topic = Namespaced_IRI.parse _namespace_name "topic" |> NamespacedName

    /// <summary>
    /// A request to a hub by a subscriber indicating interest to updates of a topic.
    /// <see href="https://vocab.eccenca.com/pubsub/SubscriptionRequest"></see></summary>
    let SubscriptionRequest =
        Namespaced_IRI.parse _namespace_name "SubscriptionRequest" |> NamespacedName

    /// <summary>
    /// The state of a subscription request.
    /// <see href="https://vocab.eccenca.com/pubsub/requestState"></see></summary>
    let requestState =
        Namespaced_IRI.parse _namespace_name "requestState" |> NamespacedName

    /// <summary>
    /// The URL of the hub to which the request is addressed.
    /// <see href="https://vocab.eccenca.com/pubsub/hub"></see></summary>
    let hub = Namespaced_IRI.parse _namespace_name "hub" |> NamespacedName
