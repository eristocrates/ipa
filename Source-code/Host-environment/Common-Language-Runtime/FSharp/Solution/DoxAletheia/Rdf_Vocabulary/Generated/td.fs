namespace https.www.w3.org._2019.wot.td.hash

open DoxAletheia.Rdf_Vocabulary

module td =
    let _namespace_name = "https://www.w3.org/2019/wot/td#"

    /// <summary>
    /// An Interaction Affordance that allows to invoke a function of the Thing, which manipulates state (e.g., toggling a lamp on or off) or triggers a process on the Thing (e.g., dimm a lamp over time).
    /// <see href="https://www.w3.org/2019/wot/td#ActionAffordance"></see></summary>
    let ActionAffordance =
        Namespaced_IRI.parse _namespace_name "ActionAffordance" |> NamespacedName

    /// <summary>
    /// Metadata of a Thing that shows the possible choices to Consumers, thereby suggesting how Consumers may interact with the Thing. There are many types of potential affordances, but W3C WoT defines three types of Interaction Affordances: Properties, Actions, and Events.
    /// <see href="https://www.w3.org/2019/wot/td#InteractionAffordance"></see></summary>
    let InteractionAffordance =
        Namespaced_IRI.parse _namespace_name "InteractionAffordance" |> NamespacedName

    /// <summary>
    /// An Interaction Affordance that describes an event source, which asynchronously pushes event data to Consumers (e.g., overheating alerts).
    /// <see href="https://www.w3.org/2019/wot/td#EventAffordance"></see></summary>
    let EventAffordance =
        Namespaced_IRI.parse _namespace_name "EventAffordance" |> NamespacedName

    /// <summary>
    /// Enumeration of well-known operation types necessary to implement the WoT interaction model
    /// <see href="https://www.w3.org/2019/wot/td#OperationType"></see></summary>
    let OperationType =
        Namespaced_IRI.parse _namespace_name "OperationType" |> NamespacedName

    /// <summary>
    /// An Interaction Affordance that exposes state of the Thing. This state can then be retrieved (read) and optionally updated (write). Things can also choose to make Properties observable by pushing the new state after a change.
    /// <see href="https://www.w3.org/2019/wot/td#PropertyAffordance"></see></summary>
    let PropertyAffordance =
        Namespaced_IRI.parse _namespace_name "PropertyAffordance" |> NamespacedName

    /// <summary>
    /// An abstraction of a physical or a virtual entity whose metadata and interfaces are described by a WoT Thing Description, whereas a virtual entity is the composition of one or more Things.
    /// <see href="https://www.w3.org/2019/wot/td#Thing"></see></summary>
    let Thing = Namespaced_IRI.parse _namespace_name "Thing" |> NamespacedName

    /// <summary>
    /// All Action-based interaction affordance of the Thing.
    /// <see href="https://www.w3.org/2019/wot/td#hasActionAffordance"></see></summary>
    let hasActionAffordance =
        Namespaced_IRI.parse _namespace_name "hasActionAffordance" |> NamespacedName

    /// <summary>
    /// Offers an affordance to interact with the Thing
    /// <see href="https://www.w3.org/2019/wot/td#hasInteractionAffordance"></see></summary>
    let hasInteractionAffordance =
        Namespaced_IRI.parse _namespace_name "hasInteractionAffordance" |> NamespacedName

    /// <summary>
    /// Defines any data that needs to be passed to cancel a subscription, e.g., a specific message to remove a Webhook
    /// <see href="https://www.w3.org/2019/wot/td#hasCancellationSchema"></see></summary>
    let hasCancellationSchema =
        Namespaced_IRI.parse _namespace_name "hasCancellationSchema" |> NamespacedName

    /// <summary>
    /// All Event-based interaction affordance of the Thing.
    /// <see href="https://www.w3.org/2019/wot/td#hasEventAffordance"></see></summary>
    let hasEventAffordance =
        Namespaced_IRI.parse _namespace_name "hasEventAffordance" |> NamespacedName

    /// <summary>
    /// Set of form hypermedia controls that describe how an operation can be performed. Forms are serializations of Protocol Bindings.
    /// <see href="https://www.w3.org/2019/wot/td#hasForm"></see></summary>
    let hasForm = Namespaced_IRI.parse _namespace_name "hasForm" |> NamespacedName

    /// <summary>
    /// Used to define the input data schema of the action.
    /// <see href="https://www.w3.org/2019/wot/td#hasInputSchema"></see></summary>
    let hasInputSchema =
        Namespaced_IRI.parse _namespace_name "hasInputSchema" |> NamespacedName

    /// <summary>
    /// Provides Web links to arbitrary resources that relate to the specified Thing Description.
    /// <see href="https://www.w3.org/2019/wot/td#hasLink"></see></summary>
    let hasLink = Namespaced_IRI.parse _namespace_name "hasLink" |> NamespacedName

    /// <summary>
    /// Defines the data schema of the Event instance messages pushed by the Thing.
    /// <see href="https://www.w3.org/2019/wot/td#hasNotificationSchema"></see></summary>
    let hasNotificationSchema =
        Namespaced_IRI.parse _namespace_name "hasNotificationSchema" |> NamespacedName

    /// <summary>
    /// Used to define the output data schema of the action.
    /// <see href="https://www.w3.org/2019/wot/td#hasOutputSchema"></see></summary>
    let hasOutputSchema =
        Namespaced_IRI.parse _namespace_name "hasOutputSchema" |> NamespacedName

    /// <summary>
    /// All Property-based interaction affordance of the Thing.
    /// <see href="https://www.w3.org/2019/wot/td#hasPropertyAffordance"></see></summary>
    let hasPropertyAffordance =
        Namespaced_IRI.parse _namespace_name "hasPropertyAffordance" |> NamespacedName

    /// <summary>
    /// Set of security definition names, chosen from those defined in securityDefinitions.  These must all be satisfied for access to resources.
    /// <see href="https://www.w3.org/2019/wot/td#hasSecurityConfiguration"></see></summary>
    let hasSecurityConfiguration =
        Namespaced_IRI.parse _namespace_name "hasSecurityConfiguration" |> NamespacedName

    /// <summary>
    /// Defines data that needs to be passed upon subscription, e.g., filters or message format for setting up Webhooks.
    /// <see href="https://www.w3.org/2019/wot/td#hasSubscriptionSchema"></see></summary>
    let hasSubscriptionSchema =
        Namespaced_IRI.parse _namespace_name "hasSubscriptionSchema" |> NamespacedName

    /// <summary>
    /// Define URI template variables as collection based on schema specifications.
    /// <see href="https://www.w3.org/2019/wot/td#hasUriTemplateSchema"></see></summary>
    let hasUriTemplateSchema =
        Namespaced_IRI.parse _namespace_name "hasUriTemplateSchema" |> NamespacedName

    /// <summary>
    /// Provides a version identicator of this TD instance.
    /// <see href="https://www.w3.org/2019/wot/td#instance"></see></summary>
    let instance = Namespaced_IRI.parse _namespace_name "instance" |> NamespacedName

    /// <summary>
    /// Operation type of forms used to read a property value
    /// <see href="https://www.w3.org/2019/wot/td#invokeAction"></see></summary>
    let invokeAction =
        Namespaced_IRI.parse _namespace_name "invokeAction" |> NamespacedName

    /// <summary>
    /// Indicates whether the action is idempotent (=true) or not. Informs whether the action can be called repeatedly with the same result, if present, based on the same input.
    /// <see href="https://www.w3.org/2019/wot/td#isIdempotent"></see></summary>
    let isIdempotent =
        Namespaced_IRI.parse _namespace_name "isIdempotent" |> NamespacedName

    /// <summary>
    /// A hint that indicates whether Servients hosting the Thing and Intermediaries should provide a Protocol Binding that supports the &lt;code&gt;observeproperty&lt;/code&gt; operation for this Property.
    /// <see href="https://www.w3.org/2019/wot/td#isObservable"></see></summary>
    let isObservable =
        Namespaced_IRI.parse _namespace_name "isObservable" |> NamespacedName

    /// <summary>
    /// Signals if the action is safe (=true) or not. Used to signal if there is no internal state (cf. resource state) is changed when invoking an Action. In that case responses can be cached as example.
    /// <see href="https://www.w3.org/2019/wot/td#isSafe"></see></summary>
    let isSafe = Namespaced_IRI.parse _namespace_name "isSafe" |> NamespacedName
    /// <summary>
    /// Indexing property to store entity names when serializing them in a JSON-LD @index container.
    /// <see href="https://www.w3.org/2019/wot/td#name"></see></summary>
    let name = Namespaced_IRI.parse _namespace_name "name" |> NamespacedName

    /// <summary>
    /// Operation type of forms used to read a property value
    /// <see href="https://www.w3.org/2019/wot/td#observeProperty"></see></summary>
    let observeProperty =
        Namespaced_IRI.parse _namespace_name "observeProperty" |> NamespacedName

    /// <summary>
    /// Operation type of forms used to read a property value
    /// <see href="https://www.w3.org/2019/wot/td#readAllProperties"></see></summary>
    let readAllProperties =
        Namespaced_IRI.parse _namespace_name "readAllProperties" |> NamespacedName

    /// <summary>
    /// Operation type of forms used to read a property value
    /// <see href="https://www.w3.org/2019/wot/td#readMultipleProperties"></see></summary>
    let readMultipleProperties =
        Namespaced_IRI.parse _namespace_name "readMultipleProperties" |> NamespacedName

    /// <summary>
    /// Operation type of forms used to read a property value
    /// <see href="https://www.w3.org/2019/wot/td#readProperty"></see></summary>
    let readProperty =
        Namespaced_IRI.parse _namespace_name "readProperty" |> NamespacedName

    /// <summary>
    /// Operation type of forms used to read a property value
    /// <see href="https://www.w3.org/2019/wot/td#subscribeEvent"></see></summary>
    let subscribeEvent =
        Namespaced_IRI.parse _namespace_name "subscribeEvent" |> NamespacedName

    /// <summary>
    /// Provides information about the TD maintainer as URI scheme (e.g., mailto [[RFC6068]], tel [[RFC3966]], https).
    /// <see href="https://www.w3.org/2019/wot/td#supportContact"></see></summary>
    let supportContact =
        Namespaced_IRI.parse _namespace_name "supportContact" |> NamespacedName

    /// <summary>
    /// Operation type of forms used to read a property value
    /// <see href="https://www.w3.org/2019/wot/td#unobserveProperty"></see></summary>
    let unobserveProperty =
        Namespaced_IRI.parse _namespace_name "unobserveProperty" |> NamespacedName

    /// <summary>
    /// Operation type of forms used to read a property value
    /// <see href="https://www.w3.org/2019/wot/td#unsubscribeEvent"></see></summary>
    let unsubscribeEvent =
        Namespaced_IRI.parse _namespace_name "unsubscribeEvent" |> NamespacedName

    /// <summary>
    /// Provides version information.
    /// <see href="https://www.w3.org/2019/wot/td#versionInfo"></see></summary>
    let versionInfo =
        Namespaced_IRI.parse _namespace_name "versionInfo" |> NamespacedName

    /// <summary>
    /// Operation type of forms used to read a property value
    /// <see href="https://www.w3.org/2019/wot/td#writeAllProperties"></see></summary>
    let writeAllProperties =
        Namespaced_IRI.parse _namespace_name "writeAllProperties" |> NamespacedName

    /// <summary>
    /// Operation type of forms used to read a property value
    /// <see href="https://www.w3.org/2019/wot/td#writeMultipleProperties"></see></summary>
    let writeMultipleProperties =
        Namespaced_IRI.parse _namespace_name "writeMultipleProperties" |> NamespacedName

    /// <summary>
    /// Operation type of forms used to read a property value
    /// <see href="https://www.w3.org/2019/wot/td#writeProperty"></see></summary>
    let writeProperty =
        Namespaced_IRI.parse _namespace_name "writeProperty" |> NamespacedName
