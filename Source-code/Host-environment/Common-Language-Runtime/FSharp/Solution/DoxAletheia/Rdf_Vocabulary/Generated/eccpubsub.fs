namespace https.vocab.eccenca.com.pubsub.slash

open DoxAletheia

module eccpubsub =
    let _namespace_name = "https://vocab.eccenca.com/pubsub/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// An HTTP endpoint acting as callback of a subscriber.
    /// <see href="https://vocab.eccenca.com/pubsub/CallbackEndpoint"></see></summary>
    let CallbackEndpoint = _prefix "CallbackEndpoint"
    /// <summary>
    /// A PubSubHubbub HTTP endpoint. Individuals of this class MUST be referenced by their URL.
    /// <see href="https://vocab.eccenca.com/pubsub/Endpoint"></see></summary>
    let Endpoint = _prefix "Endpoint"
    /// <summary>
    /// An HTTP endpoint acting as hub.
    /// <see href="https://vocab.eccenca.com/pubsub/HubEndpoint"></see></summary>
    let HubEndpoint = _prefix "HubEndpoint"
    /// <summary>
    /// Indicates that a subscription is valided and verified.
    /// <see href="https://vocab.eccenca.com/pubsub/SUBSCRIPTION_ACTIVE"></see></summary>
    let SUBSCRIPTION_ACTIVE = _prefix "SUBSCRIPTION_ACTIVE"
    /// <summary>
    /// A state of a subscription.
    /// <see href="https://vocab.eccenca.com/pubsub/SubscriptionState"></see></summary>
    let SubscriptionState = _prefix "SubscriptionState"
    /// <summary>
    /// Indicates that a susbcription was canceled by the subscriber.
    /// <see href="https://vocab.eccenca.com/pubsub/SUBSCRIPTION_CANCELED"></see></summary>
    let SUBSCRIPTION_CANCELED = _prefix "SUBSCRIPTION_CANCELED"
    /// <summary>
    /// Indicates that a subscription was denied by a publisher.
    /// <see href="https://vocab.eccenca.com/pubsub/SUBSCRIPTION_DENIED"></see></summary>
    let SUBSCRIPTION_DENIED = _prefix "SUBSCRIPTION_DENIED"
    /// <summary>
    /// Indicates that a subscription cancellation request was successfully sent to the hub but is not yet verified.
    /// <see href="https://vocab.eccenca.com/pubsub/SUBSCRIPTION_REQUEST_CANCELED"></see></summary>
    let SUBSCRIPTION_REQUEST_CANCELED = _prefix "SUBSCRIPTION_REQUEST_CANCELED"
    /// <summary>
    /// A state of a subscription request.
    /// <see href="https://vocab.eccenca.com/pubsub/SubscriptionRequestState"></see></summary>
    let SubscriptionRequestState = _prefix "SubscriptionRequestState"
    /// <summary>
    /// Indicates that a subscription cancellation request was successfully verified.
    /// <see href="https://vocab.eccenca.com/pubsub/SUBSCRIPTION_REQUEST_DELETED"></see></summary>
    let SUBSCRIPTION_REQUEST_DELETED = _prefix "SUBSCRIPTION_REQUEST_DELETED"
    /// <summary>
    /// Indicates that a subscription request was denied.
    /// <see href="https://vocab.eccenca.com/pubsub/SUBSCRIPTION_REQUEST_DENIED"></see></summary>
    let SUBSCRIPTION_REQUEST_DENIED = _prefix "SUBSCRIPTION_REQUEST_DENIED"
    /// <summary>
    /// Indicates that a subscription request was successfully sent to the hub but is not yet verified.
    /// <see href="https://vocab.eccenca.com/pubsub/SUBSCRIPTION_REQUEST_PENDING"></see></summary>
    let SUBSCRIPTION_REQUEST_PENDING = _prefix "SUBSCRIPTION_REQUEST_PENDING"
    /// <summary>
    /// Indicates that a subscription request was successfully validated and verified.
    /// <see href="https://vocab.eccenca.com/pubsub/SUBSCRIPTION_REQUEST_VERIFIED"></see></summary>
    let SUBSCRIPTION_REQUEST_VERIFIED = _prefix "SUBSCRIPTION_REQUEST_VERIFIED"
    /// <summary>
    /// A unique relation to a topic by a subscriber that indicates it should receive updates for that topic.
    /// <see href="https://vocab.eccenca.com/pubsub/Subscription"></see></summary>
    let Subscription = _prefix "Subscription"
    /// <summary>
    /// The state of a subscription.
    /// <see href="https://vocab.eccenca.com/pubsub/state"></see></summary>
    let state = _prefix "state"
    /// <summary>
    /// A secret string that will be used to compute an HMAC digest for authorized content distribution. If not supplied, the HMAC digest will not be present for content distribution requests.
    /// <see href="https://vocab.eccenca.com/pubsub/secret"></see></summary>
    let secret = _prefix "secret"
    /// <summary>
    /// The reason for which the subscription (request) has been denied.
    /// <see href="https://vocab.eccenca.com/pubsub/deniedReason"></see></summary>
    let deniedReason = _prefix "deniedReason"
    /// <summary>
    /// The URL at which a subscriber wishes to receive notifications.
    /// <see href="https://vocab.eccenca.com/pubsub/callback"></see></summary>
    let callback = _prefix "callback"
    /// <summary>
    /// The resource URI for which updates should be published.
    /// <see href="https://vocab.eccenca.com/pubsub/topic"></see></summary>
    let topic = _prefix "topic"
    /// <summary>
    /// A request to a hub by a subscriber indicating interest to updates of a topic.
    /// <see href="https://vocab.eccenca.com/pubsub/SubscriptionRequest"></see></summary>
    let SubscriptionRequest = _prefix "SubscriptionRequest"
    /// <summary>
    /// The state of a subscription request.
    /// <see href="https://vocab.eccenca.com/pubsub/requestState"></see></summary>
    let requestState = _prefix "requestState"
    /// <summary>
    /// The URL of the hub to which the request is addressed.
    /// <see href="https://vocab.eccenca.com/pubsub/hub"></see></summary>
    let hub = _prefix "hub"
