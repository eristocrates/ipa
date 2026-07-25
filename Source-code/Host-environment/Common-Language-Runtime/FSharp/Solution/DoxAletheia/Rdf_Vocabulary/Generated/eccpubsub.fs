namespace https.vocab.eccenca.com.pubsub.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module eccpubsub =
    let _namespace_iri = Namespace_Iri eccpubsub |> NamespaceIRI
    /// <summary>
    ///   <para>eccpubsub:HubEndpoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An HTTP endpoint acting as hub.</para>
    /// labels<para>hub endpoint</para></remarks>
    /// <seealso href="https://vocab.eccenca.com/pubsub/HubEndpoint">https://vocab.eccenca.com/pubsub/HubEndpoint</seealso>
    let HubEndpoint = Prefixed_Name(eccpubsub, "HubEndpoint") |> PrefixedName

    /// <summary>
    ///   <para>eccpubsub:SUBSCRIPTION_CANCELED</para>
    /// </summary>
    /// <remarks>
    ///   <para>eccpubsub:SubscriptionState</para>
    ///   <para>Indicates that a susbcription was canceled by the subscriber.</para>
    /// labels<para>canceled</para></remarks>
    /// <seealso href="https://vocab.eccenca.com/pubsub/SUBSCRIPTION_CANCELED">https://vocab.eccenca.com/pubsub/SUBSCRIPTION_CANCELED</seealso>
    let SUBSCRIPTION_CANCELED =
        Prefixed_Name(eccpubsub, "SUBSCRIPTION_CANCELED") |> PrefixedName

    /// <summary>
    ///   <para>eccpubsub:SUBSCRIPTION_DENIED</para>
    /// </summary>
    /// <remarks>
    ///   <para>eccpubsub:SubscriptionState</para>
    ///   <para>Indicates that a subscription was denied by a publisher.</para>
    /// labels<para>denied</para></remarks>
    /// <seealso href="https://vocab.eccenca.com/pubsub/SUBSCRIPTION_DENIED">https://vocab.eccenca.com/pubsub/SUBSCRIPTION_DENIED</seealso>
    let SUBSCRIPTION_DENIED =
        Prefixed_Name(eccpubsub, "SUBSCRIPTION_DENIED") |> PrefixedName

    /// <summary>
    ///   <para>eccpubsub:SUBSCRIPTION_REQUEST_DELETED</para>
    /// </summary>
    /// <remarks>
    ///   <para>eccpubsub:SubscriptionRequestState</para>
    ///   <para>Indicates that a subscription cancellation request was successfully verified.</para>
    /// labels<para>request deleted</para></remarks>
    /// <seealso href="https://vocab.eccenca.com/pubsub/SUBSCRIPTION_REQUEST_DELETED">https://vocab.eccenca.com/pubsub/SUBSCRIPTION_REQUEST_DELETED</seealso>
    let SUBSCRIPTION_REQUEST_DELETED =
        Prefixed_Name(eccpubsub, "SUBSCRIPTION_REQUEST_DELETED") |> PrefixedName

    /// <summary>
    ///   <para>eccpubsub:SUBSCRIPTION_REQUEST_PENDING</para>
    /// </summary>
    /// <remarks>
    ///   <para>eccpubsub:SubscriptionRequestState</para>
    ///   <para>Indicates that a subscription request was successfully sent to the hub but is not yet verified.</para>
    /// labels<para>request pending</para></remarks>
    /// <seealso href="https://vocab.eccenca.com/pubsub/SUBSCRIPTION_REQUEST_PENDING">https://vocab.eccenca.com/pubsub/SUBSCRIPTION_REQUEST_PENDING</seealso>
    let SUBSCRIPTION_REQUEST_PENDING =
        Prefixed_Name(eccpubsub, "SUBSCRIPTION_REQUEST_PENDING") |> PrefixedName

    /// <summary>
    ///   <para>eccpubsub:Subscription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A unique relation to a topic by a subscriber that indicates it should receive updates for that topic.</para>
    /// labels<para>subscription</para></remarks>
    /// <seealso href="https://vocab.eccenca.com/pubsub/Subscription">https://vocab.eccenca.com/pubsub/Subscription</seealso>
    let Subscription = Prefixed_Name(eccpubsub, "Subscription") |> PrefixedName
    /// <summary>
    ///   <para>eccpubsub:state</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The state of a subscription.</para>
    /// labels<para>has subscription state</para></remarks>
    /// <seealso href="https://vocab.eccenca.com/pubsub/state">https://vocab.eccenca.com/pubsub/state</seealso>
    let state = Prefixed_Name(eccpubsub, "state") |> PrefixedName
    /// <summary>
    ///   <para>eccpubsub:secret</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A secret string that will be used to compute an HMAC digest for authorized content distribution. If not supplied, the HMAC digest will not be present for content distribution requests.</para>
    /// labels<para>has secret</para></remarks>
    /// <seealso href="https://vocab.eccenca.com/pubsub/secret">https://vocab.eccenca.com/pubsub/secret</seealso>
    let secret = Prefixed_Name(eccpubsub, "secret") |> PrefixedName
    /// <summary>
    ///   <para>eccpubsub:callback</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The URL at which a subscriber wishes to receive notifications.</para>
    /// labels<para>has callback URL</para></remarks>
    /// <seealso href="https://vocab.eccenca.com/pubsub/callback">https://vocab.eccenca.com/pubsub/callback</seealso>
    let callback = Prefixed_Name(eccpubsub, "callback") |> PrefixedName
    /// <summary>
    ///   <para>eccpubsub:</para>
    /// </summary>
    /// <remarks>
    ///   <para>voaf:Vocabulary</para>
    ///   <para>owl:Ontology</para>
    ///   <para>The eccenca Publish-Subscribe Vocabulary defines concepts and relations to create statements about publishers, subscribers and their subscriptions in a Publish-Subscribe environment based on the PubSubHubbub Core 0.4 specification.</para>
    /// labels<para>eccpubsub: eccenca Publish-Subscribe Vocabulary</para></remarks>
    /// <seealso href="https://vocab.eccenca.com/pubsub/">https://vocab.eccenca.com/pubsub/</seealso>
    let _prefix_iri = Prefixed_Name(eccpubsub, "") |> PrefixedName
    /// <summary>
    ///   <para>eccpubsub:CallbackEndpoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An HTTP endpoint acting as callback of a subscriber.</para>
    /// labels<para>callback endpoint</para></remarks>
    /// <seealso href="https://vocab.eccenca.com/pubsub/CallbackEndpoint">https://vocab.eccenca.com/pubsub/CallbackEndpoint</seealso>
    let CallbackEndpoint = Prefixed_Name(eccpubsub, "CallbackEndpoint") |> PrefixedName
    /// <summary>
    ///   <para>eccpubsub:Endpoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A PubSubHubbub HTTP endpoint. Individuals of this class MUST be referenced by their URL.</para>
    /// labels<para>endpoint</para></remarks>
    /// <seealso href="https://vocab.eccenca.com/pubsub/Endpoint">https://vocab.eccenca.com/pubsub/Endpoint</seealso>
    let Endpoint = Prefixed_Name(eccpubsub, "Endpoint") |> PrefixedName

    /// <summary>
    ///   <para>eccpubsub:SubscriptionState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A state of a subscription.</para>
    /// labels<para>subscription state</para></remarks>
    /// <seealso href="https://vocab.eccenca.com/pubsub/SubscriptionState">https://vocab.eccenca.com/pubsub/SubscriptionState</seealso>
    let SubscriptionState =
        Prefixed_Name(eccpubsub, "SubscriptionState") |> PrefixedName

    /// <summary>
    ///   <para>eccpubsub:SUBSCRIPTION_REQUEST_CANCELED</para>
    /// </summary>
    /// <remarks>
    ///   <para>eccpubsub:SubscriptionRequestState</para>
    ///   <para>Indicates that a subscription cancellation request was successfully sent to the hub but is not yet verified.</para>
    /// labels<para>request canceled</para></remarks>
    /// <seealso href="https://vocab.eccenca.com/pubsub/SUBSCRIPTION_REQUEST_CANCELED">https://vocab.eccenca.com/pubsub/SUBSCRIPTION_REQUEST_CANCELED</seealso>
    let SUBSCRIPTION_REQUEST_CANCELED =
        Prefixed_Name(eccpubsub, "SUBSCRIPTION_REQUEST_CANCELED") |> PrefixedName

    /// <summary>
    ///   <para>eccpubsub:SUBSCRIPTION_ACTIVE</para>
    /// </summary>
    /// <remarks>
    ///   <para>eccpubsub:SubscriptionState</para>
    ///   <para>Indicates that a subscription is valided and verified.</para>
    /// labels<para>active</para></remarks>
    /// <seealso href="https://vocab.eccenca.com/pubsub/SUBSCRIPTION_ACTIVE">https://vocab.eccenca.com/pubsub/SUBSCRIPTION_ACTIVE</seealso>
    let SUBSCRIPTION_ACTIVE =
        Prefixed_Name(eccpubsub, "SUBSCRIPTION_ACTIVE") |> PrefixedName

    /// <summary>
    ///   <para>eccpubsub:SubscriptionRequestState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A state of a subscription request.</para>
    /// labels<para>subscription request state</para></remarks>
    /// <seealso href="https://vocab.eccenca.com/pubsub/SubscriptionRequestState">https://vocab.eccenca.com/pubsub/SubscriptionRequestState</seealso>
    let SubscriptionRequestState =
        Prefixed_Name(eccpubsub, "SubscriptionRequestState") |> PrefixedName

    /// <summary>
    ///   <para>eccpubsub:SUBSCRIPTION_REQUEST_DENIED</para>
    /// </summary>
    /// <remarks>
    ///   <para>eccpubsub:SubscriptionRequestState</para>
    ///   <para>Indicates that a subscription request was denied.</para>
    /// labels<para>request denied</para></remarks>
    /// <seealso href="https://vocab.eccenca.com/pubsub/SUBSCRIPTION_REQUEST_DENIED">https://vocab.eccenca.com/pubsub/SUBSCRIPTION_REQUEST_DENIED</seealso>
    let SUBSCRIPTION_REQUEST_DENIED =
        Prefixed_Name(eccpubsub, "SUBSCRIPTION_REQUEST_DENIED") |> PrefixedName

    /// <summary>
    ///   <para>eccpubsub:SUBSCRIPTION_REQUEST_VERIFIED</para>
    /// </summary>
    /// <remarks>
    ///   <para>eccpubsub:SubscriptionRequestState</para>
    ///   <para>Indicates that a subscription request was successfully validated and verified.</para>
    /// labels<para>request verified</para></remarks>
    /// <seealso href="https://vocab.eccenca.com/pubsub/SUBSCRIPTION_REQUEST_VERIFIED">https://vocab.eccenca.com/pubsub/SUBSCRIPTION_REQUEST_VERIFIED</seealso>
    let SUBSCRIPTION_REQUEST_VERIFIED =
        Prefixed_Name(eccpubsub, "SUBSCRIPTION_REQUEST_VERIFIED") |> PrefixedName

    /// <summary>
    ///   <para>eccpubsub:deniedReason</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The reason for which the subscription (request) has been denied.</para>
    /// labels<para>has reason for denial</para></remarks>
    /// <seealso href="https://vocab.eccenca.com/pubsub/deniedReason">https://vocab.eccenca.com/pubsub/deniedReason</seealso>
    let deniedReason = Prefixed_Name(eccpubsub, "deniedReason") |> PrefixedName

    /// <summary>
    ///   <para>eccpubsub:SubscriptionRequest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A request to a hub by a subscriber indicating interest to updates of a topic.</para>
    /// labels<para>subscription request</para></remarks>
    /// <seealso href="https://vocab.eccenca.com/pubsub/SubscriptionRequest">https://vocab.eccenca.com/pubsub/SubscriptionRequest</seealso>
    let SubscriptionRequest =
        Prefixed_Name(eccpubsub, "SubscriptionRequest") |> PrefixedName

    /// <summary>
    ///   <para>eccpubsub:topic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The resource URI for which updates should be published.</para>
    /// labels<para>has topic URI</para></remarks>
    /// <seealso href="https://vocab.eccenca.com/pubsub/topic">https://vocab.eccenca.com/pubsub/topic</seealso>
    let topic = Prefixed_Name(eccpubsub, "topic") |> PrefixedName
    /// <summary>
    ///   <para>eccpubsub:hub</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The URL of the hub to which the request is addressed.</para>
    /// labels<para>has hub URL</para></remarks>
    /// <seealso href="https://vocab.eccenca.com/pubsub/hub">https://vocab.eccenca.com/pubsub/hub</seealso>
    let hub = Prefixed_Name(eccpubsub, "hub") |> PrefixedName
    /// <summary>
    ///   <para>eccpubsub:requestState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The state of a subscription request.</para>
    /// labels<para>has subscription request state</para></remarks>
    /// <seealso href="https://vocab.eccenca.com/pubsub/requestState">https://vocab.eccenca.com/pubsub/requestState</seealso>
    let requestState = Prefixed_Name(eccpubsub, "requestState") |> PrefixedName
