namespace https.www.w3.org._2019.wot.td.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module td =
    let _namespace_iri = Namespace_Iri td |> NamespaceIRI
    /// <summary>
    ///   <para>td:ActionAffordance</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>An Interaction Affordance that allows to invoke a function of the Thing, which manipulates state (e.g., toggling a lamp on or off) or triggers a process on the Thing (e.g., dimm a lamp over time).</para>
    /// labels<para>ActionAffordance</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/td#ActionAffordance">https://www.w3.org/2019/wot/td#ActionAffordance</seealso>
    let ActionAffordance = Prefixed_Name(td, "ActionAffordance") |> PrefixedName
    /// <summary>
    ///   <para>td:hasUriTemplateSchema</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Define URI template variables as collection based on schema specifications.</para>
    /// labels<para>hasUriTemplateSchema</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/td#hasUriTemplateSchema">https://www.w3.org/2019/wot/td#hasUriTemplateSchema</seealso>
    let hasUriTemplateSchema = Prefixed_Name(td, "hasUriTemplateSchema") |> PrefixedName
    /// <summary>
    ///   <para>td:PropertyAffordance</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>An Interaction Affordance that exposes state of the Thing. This state can then be retrieved (read) and optionally updated (write). Things can also choose to make Properties observable by pushing the new state after a change.</para>
    /// labels<para>PropertyAffordance</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/td#PropertyAffordance">https://www.w3.org/2019/wot/td#PropertyAffordance</seealso>
    let PropertyAffordance = Prefixed_Name(td, "PropertyAffordance") |> PrefixedName

    /// <summary>
    ///   <para>td:hasCancellationSchema</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Defines any data that needs to be passed to cancel a subscription, e.g., a specific message to remove a Webhook</para>
    /// labels<para>hasCancellationSchema</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/td#hasCancellationSchema">https://www.w3.org/2019/wot/td#hasCancellationSchema</seealso>
    let hasCancellationSchema =
        Prefixed_Name(td, "hasCancellationSchema") |> PrefixedName

    /// <summary>
    ///   <para>td:OperationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>Enumeration of well-known operation types necessary to implement the WoT interaction model</para>
    /// labels<para>OperationType</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/td#OperationType">https://www.w3.org/2019/wot/td#OperationType</seealso>
    let OperationType = Prefixed_Name(td, "OperationType") |> PrefixedName

    /// <summary>
    ///   <para>td:InteractionAffordance</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>Metadata of a Thing that shows the possible choices to Consumers, thereby suggesting how Consumers may interact with the Thing. There are many types of potential affordances, but W3C WoT defines three types of Interaction Affordances: Properties, Actions, and Events.</para>
    /// labels<para>InteractionAffordance</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/td#InteractionAffordance">https://www.w3.org/2019/wot/td#InteractionAffordance</seealso>
    let InteractionAffordance =
        Prefixed_Name(td, "InteractionAffordance") |> PrefixedName

    /// <summary>
    ///   <para>td:hasForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Set of form hypermedia controls that describe how an operation can be performed. Forms are serializations of Protocol Bindings.</para>
    /// labels<para>hasForm</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/td#hasForm">https://www.w3.org/2019/wot/td#hasForm</seealso>
    let hasForm = Prefixed_Name(td, "hasForm") |> PrefixedName
    /// <summary>
    ///   <para>td:hasLink</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Provides Web links to arbitrary resources that relate to the specified Thing Description.</para>
    /// labels<para>hasLink</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/td#hasLink">https://www.w3.org/2019/wot/td#hasLink</seealso>
    let hasLink = Prefixed_Name(td, "hasLink") |> PrefixedName
    /// <summary>
    ///   <para>td:hasOutputSchema</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Used to define the output data schema of the action.</para>
    /// labels<para>hasOutputSchema</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/td#hasOutputSchema">https://www.w3.org/2019/wot/td#hasOutputSchema</seealso>
    let hasOutputSchema = Prefixed_Name(td, "hasOutputSchema") |> PrefixedName

    /// <summary>
    ///   <para>td:hasPropertyAffordance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>All Property-based interaction affordance of the Thing.</para>
    /// labels<para>hasPropertyAffordance</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/td#hasPropertyAffordance">https://www.w3.org/2019/wot/td#hasPropertyAffordance</seealso>
    let hasPropertyAffordance =
        Prefixed_Name(td, "hasPropertyAffordance") |> PrefixedName

    /// <summary>
    ///   <para>td:hasSecurityConfiguration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Set of security definition names, chosen from those defined in securityDefinitions.  These must all be satisfied for access to resources.</para>
    /// labels<para>hasSecurityConfiguration</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/td#hasSecurityConfiguration">https://www.w3.org/2019/wot/td#hasSecurityConfiguration</seealso>
    let hasSecurityConfiguration =
        Prefixed_Name(td, "hasSecurityConfiguration") |> PrefixedName

    /// <summary>
    ///   <para>td:hasSubscriptionSchema</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Defines data that needs to be passed upon subscription, e.g., filters or message format for setting up Webhooks.</para>
    /// labels<para>hasSubscriptionSchema</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/td#hasSubscriptionSchema">https://www.w3.org/2019/wot/td#hasSubscriptionSchema</seealso>
    let hasSubscriptionSchema =
        Prefixed_Name(td, "hasSubscriptionSchema") |> PrefixedName

    /// <summary>
    ///   <para>td:instance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>Provides a version identicator of this TD instance.</para>
    /// labels<para>instance</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/td#instance">https://www.w3.org/2019/wot/td#instance</seealso>
    let instance = Prefixed_Name(td, "instance") |> PrefixedName
    /// <summary>
    ///   <para>td:invokeAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>td:OperationType</para>
    ///   <para>Operation type of forms used to read a property value</para>
    /// labels<para>invokeAction</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/td#invokeAction">https://www.w3.org/2019/wot/td#invokeAction</seealso>
    let invokeAction = Prefixed_Name(td, "invokeAction") |> PrefixedName
    /// <summary>
    ///   <para>td:isIdempotent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates whether the action is idempotent (=true) or not. Informs whether the action can be called repeatedly with the same result, if present, based on the same input.</para>
    /// labels<para>isIdempotent</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/td#isIdempotent">https://www.w3.org/2019/wot/td#isIdempotent</seealso>
    let isIdempotent = Prefixed_Name(td, "isIdempotent") |> PrefixedName
    /// <summary>
    ///   <para>td:isObservable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A hint that indicates whether Servients hosting the Thing and Intermediaries should provide a Protocol Binding that supports the &lt;code&gt;observeproperty&lt;/code&gt; operation for this Property.</para>
    /// labels<para>isObservable</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/td#isObservable">https://www.w3.org/2019/wot/td#isObservable</seealso>
    let isObservable = Prefixed_Name(td, "isObservable") |> PrefixedName
    /// <summary>
    ///   <para>td:name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indexing property to store entity names when serializing them in a JSON-LD @index container.</para>
    /// labels<para>name</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/td#name">https://www.w3.org/2019/wot/td#name</seealso>
    let name = Prefixed_Name(td, "name") |> PrefixedName
    /// <summary>
    ///   <para>td:EventAffordance</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>An Interaction Affordance that describes an event source, which asynchronously pushes event data to Consumers (e.g., overheating alerts).</para>
    /// labels<para>EventAffordance</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/td#EventAffordance">https://www.w3.org/2019/wot/td#EventAffordance</seealso>
    let EventAffordance = Prefixed_Name(td, "EventAffordance") |> PrefixedName
    /// <summary>
    ///   <para>td:Thing</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>An abstraction of a physical or a virtual entity whose metadata and interfaces are described by a WoT Thing Description, whereas a virtual entity is the composition of one or more Things.</para>
    /// labels<para>Thing</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/td#Thing">https://www.w3.org/2019/wot/td#Thing</seealso>
    let Thing = Prefixed_Name(td, "Thing") |> PrefixedName

    /// <summary>
    ///   <para>td:hasInteractionAffordance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Offers an affordance to interact with the Thing</para>
    /// labels<para>hasInteractionAffordance</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/td#hasInteractionAffordance">https://www.w3.org/2019/wot/td#hasInteractionAffordance</seealso>
    let hasInteractionAffordance =
        Prefixed_Name(td, "hasInteractionAffordance") |> PrefixedName

    /// <summary>
    ///   <para>td:hasActionAffordance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>All Action-based interaction affordance of the Thing.</para>
    /// labels<para>hasActionAffordance</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/td#hasActionAffordance">https://www.w3.org/2019/wot/td#hasActionAffordance</seealso>
    let hasActionAffordance = Prefixed_Name(td, "hasActionAffordance") |> PrefixedName
    /// <summary>
    ///   <para>td:hasEventAffordance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>All Event-based interaction affordance of the Thing.</para>
    /// labels<para>hasEventAffordance</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/td#hasEventAffordance">https://www.w3.org/2019/wot/td#hasEventAffordance</seealso>
    let hasEventAffordance = Prefixed_Name(td, "hasEventAffordance") |> PrefixedName
    /// <summary>
    ///   <para>td:hasInputSchema</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Used to define the input data schema of the action.</para>
    /// labels<para>hasInputSchema</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/td#hasInputSchema">https://www.w3.org/2019/wot/td#hasInputSchema</seealso>
    let hasInputSchema = Prefixed_Name(td, "hasInputSchema") |> PrefixedName

    /// <summary>
    ///   <para>td:hasNotificationSchema</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Defines the data schema of the Event instance messages pushed by the Thing.</para>
    /// labels<para>hasNotificationSchema</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/td#hasNotificationSchema">https://www.w3.org/2019/wot/td#hasNotificationSchema</seealso>
    let hasNotificationSchema =
        Prefixed_Name(td, "hasNotificationSchema") |> PrefixedName

    /// <summary>
    ///   <para>td:observeProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>td:OperationType</para>
    ///   <para>Operation type of forms used to read a property value</para>
    /// labels<para>observeProperty</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/td#observeProperty">https://www.w3.org/2019/wot/td#observeProperty</seealso>
    let observeProperty = Prefixed_Name(td, "observeProperty") |> PrefixedName

    /// <summary>
    ///   <para>td:readMultipleProperties</para>
    /// </summary>
    /// <remarks>
    ///   <para>td:OperationType</para>
    ///   <para>Operation type of forms used to read a property value</para>
    /// labels<para>readMultipleProperties</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/td#readMultipleProperties">https://www.w3.org/2019/wot/td#readMultipleProperties</seealso>
    let readMultipleProperties =
        Prefixed_Name(td, "readMultipleProperties") |> PrefixedName

    /// <summary>
    ///   <para>td:supportContact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>Provides information about the TD maintainer as URI scheme (e.g., mailto [[RFC6068]], tel [[RFC3966]], https).</para>
    /// labels<para>supportContact</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/td#supportContact">https://www.w3.org/2019/wot/td#supportContact</seealso>
    let supportContact = Prefixed_Name(td, "supportContact") |> PrefixedName
    /// <summary>
    ///   <para>td:readAllProperties</para>
    /// </summary>
    /// <remarks>
    ///   <para>td:OperationType</para>
    ///   <para>Operation type of forms used to read a property value</para>
    /// labels<para>readAllProperties</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/td#readAllProperties">https://www.w3.org/2019/wot/td#readAllProperties</seealso>
    let readAllProperties = Prefixed_Name(td, "readAllProperties") |> PrefixedName
    /// <summary>
    ///   <para>td:subscribeEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>td:OperationType</para>
    ///   <para>Operation type of forms used to read a property value</para>
    /// labels<para>subscribeEvent</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/td#subscribeEvent">https://www.w3.org/2019/wot/td#subscribeEvent</seealso>
    let subscribeEvent = Prefixed_Name(td, "subscribeEvent") |> PrefixedName
    /// <summary>
    ///   <para>td:unsubscribeEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>td:OperationType</para>
    ///   <para>Operation type of forms used to read a property value</para>
    /// labels<para>unsubscribeEvent</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/td#unsubscribeEvent">https://www.w3.org/2019/wot/td#unsubscribeEvent</seealso>
    let unsubscribeEvent = Prefixed_Name(td, "unsubscribeEvent") |> PrefixedName
    /// <summary>
    ///   <para>td:versionInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>Provides version information.</para>
    /// labels<para>versionInfo</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/td#versionInfo">https://www.w3.org/2019/wot/td#versionInfo</seealso>
    let versionInfo = Prefixed_Name(td, "versionInfo") |> PrefixedName
    /// <summary>
    ///   <para>td:writeAllProperties</para>
    /// </summary>
    /// <remarks>
    ///   <para>td:OperationType</para>
    ///   <para>Operation type of forms used to read a property value</para>
    /// labels<para>writeAllProperties</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/td#writeAllProperties">https://www.w3.org/2019/wot/td#writeAllProperties</seealso>
    let writeAllProperties = Prefixed_Name(td, "writeAllProperties") |> PrefixedName
    /// <summary>
    ///   <para>td:readProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>td:OperationType</para>
    ///   <para>Operation type of forms used to read a property value</para>
    /// labels<para>readProperty</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/td#readProperty">https://www.w3.org/2019/wot/td#readProperty</seealso>
    let readProperty = Prefixed_Name(td, "readProperty") |> PrefixedName
    /// <summary>
    ///   <para>td:unobserveProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>td:OperationType</para>
    ///   <para>Operation type of forms used to read a property value</para>
    /// labels<para>unobserveProperty</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/td#unobserveProperty">https://www.w3.org/2019/wot/td#unobserveProperty</seealso>
    let unobserveProperty = Prefixed_Name(td, "unobserveProperty") |> PrefixedName

    /// <summary>
    ///   <para>td:writeMultipleProperties</para>
    /// </summary>
    /// <remarks>
    ///   <para>td:OperationType</para>
    ///   <para>Operation type of forms used to read a property value</para>
    /// labels<para>writeMultipleProperties</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/td#writeMultipleProperties">https://www.w3.org/2019/wot/td#writeMultipleProperties</seealso>
    let writeMultipleProperties =
        Prefixed_Name(td, "writeMultipleProperties") |> PrefixedName

    /// <summary>
    ///   <para>td:writeProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>td:OperationType</para>
    ///   <para>Operation type of forms used to read a property value</para>
    /// labels<para>writeProperty</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/td#writeProperty">https://www.w3.org/2019/wot/td#writeProperty</seealso>
    let writeProperty = Prefixed_Name(td, "writeProperty") |> PrefixedName
    /// <summary>
    ///   <para>td:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>This ontology aims to model the Web of Things domain according to the W3C Interest Group (http://w3c.github.io/wot/)</para>
    /// </remarks>
    /// <seealso href="https://www.w3.org/2019/wot/td#">https://www.w3.org/2019/wot/td#</seealso>
    let _prefix_iri = Prefixed_Name(td, "") |> PrefixedName
    /// <summary>
    ///   <para>td:isSafe</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Signals if the action is safe (=true) or not. Used to signal if there is no internal state (cf. resource state) is changed when invoking an Action. In that case responses can be cached as example.</para>
    /// labels<para>isSafe</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/td#isSafe">https://www.w3.org/2019/wot/td#isSafe</seealso>
    let isSafe = Prefixed_Name(td, "isSafe") |> PrefixedName
