namespace https.www.w3.org._2019.wot.td.hash

open DoxAletheia

module td =
    let _namespace_name = "https://www.w3.org/2019/wot/td#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// An Interaction Affordance that allows to invoke a function of the Thing, which manipulates state (e.g., toggling a lamp on or off) or triggers a process on the Thing (e.g., dimm a lamp over time).
    /// <see href="https://www.w3.org/2019/wot/td#ActionAffordance"></see></summary>
    let ActionAffordance = _prefix "ActionAffordance"
    /// <summary>
    /// Metadata of a Thing that shows the possible choices to Consumers, thereby suggesting how Consumers may interact with the Thing. There are many types of potential affordances, but W3C WoT defines three types of Interaction Affordances: Properties, Actions, and Events.
    /// <see href="https://www.w3.org/2019/wot/td#InteractionAffordance"></see></summary>
    let InteractionAffordance = _prefix "InteractionAffordance"
    /// <summary>
    /// An Interaction Affordance that describes an event source, which asynchronously pushes event data to Consumers (e.g., overheating alerts).
    /// <see href="https://www.w3.org/2019/wot/td#EventAffordance"></see></summary>
    let EventAffordance = _prefix "EventAffordance"
    /// <summary>
    /// Enumeration of well-known operation types necessary to implement the WoT interaction model
    /// <see href="https://www.w3.org/2019/wot/td#OperationType"></see></summary>
    let OperationType = _prefix "OperationType"
    /// <summary>
    /// An Interaction Affordance that exposes state of the Thing. This state can then be retrieved (read) and optionally updated (write). Things can also choose to make Properties observable by pushing the new state after a change.
    /// <see href="https://www.w3.org/2019/wot/td#PropertyAffordance"></see></summary>
    let PropertyAffordance = _prefix "PropertyAffordance"
    /// <summary>
    /// An abstraction of a physical or a virtual entity whose metadata and interfaces are described by a WoT Thing Description, whereas a virtual entity is the composition of one or more Things.
    /// <see href="https://www.w3.org/2019/wot/td#Thing"></see></summary>
    let Thing = _prefix "Thing"
    /// <summary>
    /// All Action-based interaction affordance of the Thing.
    /// <see href="https://www.w3.org/2019/wot/td#hasActionAffordance"></see></summary>
    let hasActionAffordance = _prefix "hasActionAffordance"
    /// <summary>
    /// Offers an affordance to interact with the Thing
    /// <see href="https://www.w3.org/2019/wot/td#hasInteractionAffordance"></see></summary>
    let hasInteractionAffordance = _prefix "hasInteractionAffordance"
    /// <summary>
    /// Defines any data that needs to be passed to cancel a subscription, e.g., a specific message to remove a Webhook
    /// <see href="https://www.w3.org/2019/wot/td#hasCancellationSchema"></see></summary>
    let hasCancellationSchema = _prefix "hasCancellationSchema"
    /// <summary>
    /// All Event-based interaction affordance of the Thing.
    /// <see href="https://www.w3.org/2019/wot/td#hasEventAffordance"></see></summary>
    let hasEventAffordance = _prefix "hasEventAffordance"
    /// <summary>
    /// Set of form hypermedia controls that describe how an operation can be performed. Forms are serializations of Protocol Bindings.
    /// <see href="https://www.w3.org/2019/wot/td#hasForm"></see></summary>
    let hasForm = _prefix "hasForm"
    /// <summary>
    /// Used to define the input data schema of the action.
    /// <see href="https://www.w3.org/2019/wot/td#hasInputSchema"></see></summary>
    let hasInputSchema = _prefix "hasInputSchema"
    /// <summary>
    /// Provides Web links to arbitrary resources that relate to the specified Thing Description.
    /// <see href="https://www.w3.org/2019/wot/td#hasLink"></see></summary>
    let hasLink = _prefix "hasLink"
    /// <summary>
    /// Defines the data schema of the Event instance messages pushed by the Thing.
    /// <see href="https://www.w3.org/2019/wot/td#hasNotificationSchema"></see></summary>
    let hasNotificationSchema = _prefix "hasNotificationSchema"
    /// <summary>
    /// Used to define the output data schema of the action.
    /// <see href="https://www.w3.org/2019/wot/td#hasOutputSchema"></see></summary>
    let hasOutputSchema = _prefix "hasOutputSchema"
    /// <summary>
    /// All Property-based interaction affordance of the Thing.
    /// <see href="https://www.w3.org/2019/wot/td#hasPropertyAffordance"></see></summary>
    let hasPropertyAffordance = _prefix "hasPropertyAffordance"
    /// <summary>
    /// Set of security definition names, chosen from those defined in securityDefinitions.  These must all be satisfied for access to resources.
    /// <see href="https://www.w3.org/2019/wot/td#hasSecurityConfiguration"></see></summary>
    let hasSecurityConfiguration = _prefix "hasSecurityConfiguration"
    /// <summary>
    /// Defines data that needs to be passed upon subscription, e.g., filters or message format for setting up Webhooks.
    /// <see href="https://www.w3.org/2019/wot/td#hasSubscriptionSchema"></see></summary>
    let hasSubscriptionSchema = _prefix "hasSubscriptionSchema"
    /// <summary>
    /// Define URI template variables as collection based on schema specifications.
    /// <see href="https://www.w3.org/2019/wot/td#hasUriTemplateSchema"></see></summary>
    let hasUriTemplateSchema = _prefix "hasUriTemplateSchema"
    /// <summary>
    /// Provides a version identicator of this TD instance.
    /// <see href="https://www.w3.org/2019/wot/td#instance"></see></summary>
    let instance = _prefix "instance"
    /// <summary>
    /// Operation type of forms used to read a property value
    /// <see href="https://www.w3.org/2019/wot/td#invokeAction"></see></summary>
    let invokeAction = _prefix "invokeAction"
    /// <summary>
    /// Indicates whether the action is idempotent (=true) or not. Informs whether the action can be called repeatedly with the same result, if present, based on the same input.
    /// <see href="https://www.w3.org/2019/wot/td#isIdempotent"></see></summary>
    let isIdempotent = _prefix "isIdempotent"
    /// <summary>
    /// A hint that indicates whether Servients hosting the Thing and Intermediaries should provide a Protocol Binding that supports the &lt;code&gt;observeproperty&lt;/code&gt; operation for this Property.
    /// <see href="https://www.w3.org/2019/wot/td#isObservable"></see></summary>
    let isObservable = _prefix "isObservable"
    /// <summary>
    /// Signals if the action is safe (=true) or not. Used to signal if there is no internal state (cf. resource state) is changed when invoking an Action. In that case responses can be cached as example.
    /// <see href="https://www.w3.org/2019/wot/td#isSafe"></see></summary>
    let isSafe = _prefix "isSafe"
    /// <summary>
    /// Indexing property to store entity names when serializing them in a JSON-LD @index container.
    /// <see href="https://www.w3.org/2019/wot/td#name"></see></summary>
    let name = _prefix "name"
    /// <summary>
    /// Operation type of forms used to read a property value
    /// <see href="https://www.w3.org/2019/wot/td#observeProperty"></see></summary>
    let observeProperty = _prefix "observeProperty"
    /// <summary>
    /// Operation type of forms used to read a property value
    /// <see href="https://www.w3.org/2019/wot/td#readAllProperties"></see></summary>
    let readAllProperties = _prefix "readAllProperties"
    /// <summary>
    /// Operation type of forms used to read a property value
    /// <see href="https://www.w3.org/2019/wot/td#readMultipleProperties"></see></summary>
    let readMultipleProperties = _prefix "readMultipleProperties"
    /// <summary>
    /// Operation type of forms used to read a property value
    /// <see href="https://www.w3.org/2019/wot/td#readProperty"></see></summary>
    let readProperty = _prefix "readProperty"
    /// <summary>
    /// Operation type of forms used to read a property value
    /// <see href="https://www.w3.org/2019/wot/td#subscribeEvent"></see></summary>
    let subscribeEvent = _prefix "subscribeEvent"
    /// <summary>
    /// Provides information about the TD maintainer as URI scheme (e.g., mailto [[RFC6068]], tel [[RFC3966]], https).
    /// <see href="https://www.w3.org/2019/wot/td#supportContact"></see></summary>
    let supportContact = _prefix "supportContact"
    /// <summary>
    /// Operation type of forms used to read a property value
    /// <see href="https://www.w3.org/2019/wot/td#unobserveProperty"></see></summary>
    let unobserveProperty = _prefix "unobserveProperty"
    /// <summary>
    /// Operation type of forms used to read a property value
    /// <see href="https://www.w3.org/2019/wot/td#unsubscribeEvent"></see></summary>
    let unsubscribeEvent = _prefix "unsubscribeEvent"
    /// <summary>
    /// Provides version information.
    /// <see href="https://www.w3.org/2019/wot/td#versionInfo"></see></summary>
    let versionInfo = _prefix "versionInfo"
    /// <summary>
    /// Operation type of forms used to read a property value
    /// <see href="https://www.w3.org/2019/wot/td#writeAllProperties"></see></summary>
    let writeAllProperties = _prefix "writeAllProperties"
    /// <summary>
    /// Operation type of forms used to read a property value
    /// <see href="https://www.w3.org/2019/wot/td#writeMultipleProperties"></see></summary>
    let writeMultipleProperties = _prefix "writeMultipleProperties"
    /// <summary>
    /// Operation type of forms used to read a property value
    /// <see href="https://www.w3.org/2019/wot/td#writeProperty"></see></summary>
    let writeProperty = _prefix "writeProperty"
