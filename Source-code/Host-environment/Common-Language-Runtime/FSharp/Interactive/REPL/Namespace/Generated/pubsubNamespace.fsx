#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module pubsub =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://vocab.eccenca.com/pubsub/" "pubsub"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>dcterms:modified : 2016-07-12^^xsd:date</para>
    ///   <para>dcterms:issued : 2016-07-12^^xsd:date</para>
    ///   <para>rdfs:label : callback endpoint</para>
    ///   <para>rdfs:comment : An HTTP endpoint acting as callback of a subscriber.</para>
    ///   <a href="https://vocab.eccenca.com/pubsub/CallbackEndpoint">pubsub:CallbackEndpoint</a>
    /// </summary>
    let CallbackEndpoint = _prefixId.prefix "CallbackEndpoint"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>dcterms:modified : 2016-07-12^^xsd:date</para>
    ///   <para>dcterms:issued : 2016-07-12^^xsd:date</para>
    ///   <para>rdfs:label : endpoint</para>
    ///   <para>rdfs:comment : A PubSubHubbub HTTP endpoint. Individuals of this class MUST be referenced by their URL.</para>
    ///   <a href="https://vocab.eccenca.com/pubsub/Endpoint">pubsub:Endpoint</a>
    /// </summary>
    let Endpoint = _prefixId.prefix "Endpoint"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>dcterms:modified : 2016-07-12^^xsd:date</para>
    ///   <para>dcterms:issued : 2016-07-12^^xsd:date</para>
    ///   <para>rdfs:label : hub endpoint</para>
    ///   <para>rdfs:comment : An HTTP endpoint acting as hub.</para>
    ///   <a href="https://vocab.eccenca.com/pubsub/HubEndpoint">pubsub:HubEndpoint</a>
    /// </summary>
    let HubEndpoint = _prefixId.prefix "HubEndpoint"
    let SUBSCRIPTION_ACTIVE = _prefixId.prefix "SUBSCRIPTION_ACTIVE"
    let SUBSCRIPTION_CANCELED = _prefixId.prefix "SUBSCRIPTION_CANCELED"
    let SUBSCRIPTION_DENIED = _prefixId.prefix "SUBSCRIPTION_DENIED"
    let SUBSCRIPTION_REQUEST_CANCELED = _prefixId.prefix "SUBSCRIPTION_REQUEST_CANCELED"
    let SUBSCRIPTION_REQUEST_DELETED = _prefixId.prefix "SUBSCRIPTION_REQUEST_DELETED"
    let SUBSCRIPTION_REQUEST_DENIED = _prefixId.prefix "SUBSCRIPTION_REQUEST_DENIED"
    let SUBSCRIPTION_REQUEST_PENDING = _prefixId.prefix "SUBSCRIPTION_REQUEST_PENDING"
    let SUBSCRIPTION_REQUEST_VERIFIED = _prefixId.prefix "SUBSCRIPTION_REQUEST_VERIFIED"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : subscription</para>
    ///   <para>dcterms:issued : 2016-07-12^^xsd:date</para>
    ///   <para>dcterms:modified : 2016-07-12^^xsd:date</para>
    ///   <para>rdfs:comment : A unique relation to a topic by a subscriber that indicates it should receive updates for that topic.</para>
    ///   <a href="https://vocab.eccenca.com/pubsub/Subscription">pubsub:Subscription</a>
    /// </summary>
    let Subscription = _prefixId.prefix "Subscription"
    /// <summary>
    ///   <para>dcterms:modified : 2016-07-12^^xsd:date</para>
    ///   <para>rdfs:comment : A request to a hub by a subscriber indicating interest to updates of a topic.</para>
    ///   <para>rdfs:label : subscription request</para>
    ///   <para>vs:term_status : testing</para>
    ///   <para>dcterms:issued : 2016-07-12^^xsd:date</para>
    ///   <a href="https://vocab.eccenca.com/pubsub/SubscriptionRequest">pubsub:SubscriptionRequest</a>
    /// </summary>
    let SubscriptionRequest = _prefixId.prefix "SubscriptionRequest"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>dcterms:modified : 2016-07-12^^xsd:date</para>
    ///   <para>dcterms:issued : 2016-07-12^^xsd:date</para>
    ///   <para>rdfs:label : subscription request state</para>
    ///   <para>rdfs:comment : A state of a subscription request.</para>
    ///   <a href="https://vocab.eccenca.com/pubsub/SubscriptionRequestState">pubsub:SubscriptionRequestState</a>
    /// </summary>
    let SubscriptionRequestState = _prefixId.prefix "SubscriptionRequestState"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>dcterms:modified : 2016-07-12^^xsd:date</para>
    ///   <para>dcterms:issued : 2016-07-12^^xsd:date</para>
    ///   <para>rdfs:label : subscription state</para>
    ///   <para>rdfs:comment : A state of a subscription.</para>
    ///   <a href="https://vocab.eccenca.com/pubsub/SubscriptionState">pubsub:SubscriptionState</a>
    /// </summary>
    let SubscriptionState = _prefixId.prefix "SubscriptionState"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>dcterms:modified : 2016-07-12^^xsd:date</para>
    ///   <para>dcterms:issued : 2016-07-12^^xsd:date</para>
    ///   <para>rdfs:label : has callback URL</para>
    ///   <para>rdfs:comment : The URL at which a subscriber wishes to receive notifications.</para>
    ///   <a href="https://vocab.eccenca.com/pubsub/callback">pubsub:callback</a>
    /// </summary>
    let callback = _prefixId.prefix "callback"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>dcterms:modified : 2016-07-12^^xsd:date</para>
    ///   <para>dcterms:issued : 2016-07-12^^xsd:date</para>
    ///   <para>rdfs:label : has reason for denial</para>
    ///   <para>rdfs:comment : The reason for which the subscription (request) has been denied.</para>
    ///   <a href="https://vocab.eccenca.com/pubsub/deniedReason">pubsub:deniedReason</a>
    /// </summary>
    let deniedReason = _prefixId.prefix "deniedReason"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>dcterms:modified : 2016-07-12^^xsd:date</para>
    ///   <para>dcterms:issued : 2016-07-12^^xsd:date</para>
    ///   <para>rdfs:label : has hub URL</para>
    ///   <para>rdfs:comment : The URL of the hub to which the request is addressed.</para>
    ///   <a href="https://vocab.eccenca.com/pubsub/hub">pubsub:hub</a>
    /// </summary>
    let hub = _prefixId.prefix "hub"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>dcterms:modified : 2016-07-12^^xsd:date</para>
    ///   <para>dcterms:issued : 2016-07-12^^xsd:date</para>
    ///   <para>rdfs:label : has subscription request state</para>
    ///   <para>rdfs:comment : The state of a subscription request.</para>
    ///   <a href="https://vocab.eccenca.com/pubsub/requestState">pubsub:requestState</a>
    /// </summary>
    let requestState = _prefixId.prefix "requestState"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>dcterms:modified : 2016-07-12^^xsd:date</para>
    ///   <para>dcterms:issued : 2016-07-12^^xsd:date</para>
    ///   <para>rdfs:label : has secret</para>
    ///   <para>rdfs:comment : A secret string that will be used to compute an HMAC digest for authorized content distribution. If not supplied, the HMAC digest will not be present for content distribution requests.</para>
    ///   <a href="https://vocab.eccenca.com/pubsub/secret">pubsub:secret</a>
    /// </summary>
    let secret = _prefixId.prefix "secret"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>dcterms:modified : 2016-07-12^^xsd:date</para>
    ///   <para>dcterms:issued : 2016-07-12^^xsd:date</para>
    ///   <para>rdfs:label : has subscription state</para>
    ///   <para>rdfs:comment : The state of a subscription.</para>
    ///   <a href="https://vocab.eccenca.com/pubsub/state">pubsub:state</a>
    /// </summary>
    let state = _prefixId.prefix "state"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>dcterms:modified : 2016-07-12^^xsd:date</para>
    ///   <para>dcterms:issued : 2016-07-12^^xsd:date</para>
    ///   <para>rdfs:label : has topic URI</para>
    ///   <para>rdfs:comment : The resource URI for which updates should be published.</para>
    ///   <a href="https://vocab.eccenca.com/pubsub/topic">pubsub:topic</a>
    /// </summary>
    let topic = _prefixId.prefix "topic"
