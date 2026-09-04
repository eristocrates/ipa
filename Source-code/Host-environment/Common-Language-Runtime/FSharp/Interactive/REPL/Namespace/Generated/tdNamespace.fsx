#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module td =
    let _prefixId = PrefixId.fromNamespaceLabel "https://www.w3.org/2019/wot/td#" "td"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:comment : An Interaction Affordance that allows to invoke a function of the Thing, which manipulates state (e.g., toggling a lamp on or off) or triggers a process on the Thing (e.g., dimm a lamp over time).</para>
    ///   <para>rdfs:label : ActionAffordance^^xsd:string</para>
    ///   <a href="https://www.w3.org/2019/wot/td#ActionAffordance">td:ActionAffordance</a>
    /// </summary>
    let ActionAffordance = _prefixId.prefix "ActionAffordance"
    /// <summary>
    ///   <para>rdfs:comment : An Interaction Affordance that describes an event source, which asynchronously pushes event data to Consumers (e.g., overheating alerts).</para>
    ///   <para>rdfs:label : EventAffordance^^xsd:string</para>
    ///   <a href="https://www.w3.org/2019/wot/td#EventAffordance">td:EventAffordance</a>
    /// </summary>
    let EventAffordance = _prefixId.prefix "EventAffordance"
    /// <summary>
    ///   <para>rdfs:comment : Metadata of a Thing that shows the possible choices to Consumers, thereby suggesting how Consumers may interact with the Thing. There are many types of potential affordances, but W3C WoT defines three types of Interaction Affordances: Properties, Actions, and Events.</para>
    ///   <para>rdfs:label : InteractionAffordance^^xsd:string</para>
    ///   <a href="https://www.w3.org/2019/wot/td#InteractionAffordance">td:InteractionAffordance</a>
    /// </summary>
    let InteractionAffordance = _prefixId.prefix "InteractionAffordance"
    /// <summary>
    ///   <para>rdfs:comment : Enumeration of well-known operation types necessary to implement the WoT interaction model</para>
    ///   <para>rdfs:label : OperationType^^xsd:string</para>
    ///   <a href="https://www.w3.org/2019/wot/td#OperationType">td:OperationType</a>
    /// </summary>
    let OperationType = _prefixId.prefix "OperationType"
    /// <summary>
    ///   <para>rdfs:comment : An Interaction Affordance that exposes state of the Thing. This state can then be retrieved (read) and optionally updated (write). Things can also choose to make Properties observable by pushing the new state after a change.</para>
    ///   <para>rdfs:label : PropertyAffordance^^xsd:string</para>
    ///   <a href="https://www.w3.org/2019/wot/td#PropertyAffordance">td:PropertyAffordance</a>
    /// </summary>
    let PropertyAffordance = _prefixId.prefix "PropertyAffordance"
    /// <summary>
    ///   <para>rdfs:comment : An abstraction of a physical or a virtual entity whose metadata and interfaces are described by a WoT Thing Description, whereas a virtual entity is the composition of one or more Things.</para>
    ///   <para>rdfs:label : Thing</para>
    ///   <a href="https://www.w3.org/2019/wot/td#Thing">td:Thing</a>
    /// </summary>
    let Thing = _prefixId.prefix "Thing"
    /// <summary>
    ///   <para>rdfs:comment : All Action-based interaction affordance of the Thing.</para>
    ///   <para>rdfs:label : hasActionAffordance^^xsd:string</para>
    ///   <a href="https://www.w3.org/2019/wot/td#hasActionAffordance">td:hasActionAffordance</a>
    /// </summary>
    let hasActionAffordance = _prefixId.prefix "hasActionAffordance"
    /// <summary>
    ///   <para>rdfs:comment : Defines any data that needs to be passed to cancel a subscription, e.g., a specific message to remove a Webhook</para>
    ///   <para>rdfs:label : hasCancellationSchema^^xsd:string</para>
    ///   <a href="https://www.w3.org/2019/wot/td#hasCancellationSchema">td:hasCancellationSchema</a>
    /// </summary>
    let hasCancellationSchema = _prefixId.prefix "hasCancellationSchema"
    /// <summary>
    ///   <para>rdfs:comment : All Event-based interaction affordance of the Thing.</para>
    ///   <para>rdfs:label : hasEventAffordance^^xsd:string</para>
    ///   <a href="https://www.w3.org/2019/wot/td#hasEventAffordance">td:hasEventAffordance</a>
    /// </summary>
    let hasEventAffordance = _prefixId.prefix "hasEventAffordance"
    /// <summary>
    ///   <para>rdfs:comment : Set of form hypermedia controls that describe how an operation can be performed. Forms are serializations of Protocol Bindings.</para>
    ///   <para>rdfs:label : hasForm^^xsd:string</para>
    ///   <a href="https://www.w3.org/2019/wot/td#hasForm">td:hasForm</a>
    /// </summary>
    let hasForm = _prefixId.prefix "hasForm"
    /// <summary>
    ///   <para>rdfs:comment : Used to define the input data schema of the action.</para>
    ///   <para>rdfs:label : hasInputSchema^^xsd:string</para>
    ///   <a href="https://www.w3.org/2019/wot/td#hasInputSchema">td:hasInputSchema</a>
    /// </summary>
    let hasInputSchema = _prefixId.prefix "hasInputSchema"
    /// <summary>
    ///   <para>rdfs:comment : Offers an affordance to interact with the Thing</para>
    ///   <para>rdfs:label : hasInteractionAffordance^^xsd:string</para>
    ///   <a href="https://www.w3.org/2019/wot/td#hasInteractionAffordance">td:hasInteractionAffordance</a>
    /// </summary>
    let hasInteractionAffordance = _prefixId.prefix "hasInteractionAffordance"
    /// <summary>
    ///   <para>rdfs:comment : Provides Web links to arbitrary resources that relate to the specified Thing Description.</para>
    ///   <para>rdfs:label : hasLink^^xsd:string</para>
    ///   <a href="https://www.w3.org/2019/wot/td#hasLink">td:hasLink</a>
    /// </summary>
    let hasLink = _prefixId.prefix "hasLink"
    /// <summary>
    ///   <para>rdfs:comment : Defines the data schema of the Event instance messages pushed by the Thing.</para>
    ///   <para>rdfs:label : hasNotificationSchema^^xsd:string</para>
    ///   <a href="https://www.w3.org/2019/wot/td#hasNotificationSchema">td:hasNotificationSchema</a>
    /// </summary>
    let hasNotificationSchema = _prefixId.prefix "hasNotificationSchema"
    /// <summary>
    ///   <para>rdfs:comment : Used to define the output data schema of the action.</para>
    ///   <para>rdfs:label : hasOutputSchema^^xsd:string</para>
    ///   <a href="https://www.w3.org/2019/wot/td#hasOutputSchema">td:hasOutputSchema</a>
    /// </summary>
    let hasOutputSchema = _prefixId.prefix "hasOutputSchema"
    /// <summary>
    ///   <para>rdfs:comment : All Property-based interaction affordance of the Thing.</para>
    ///   <para>rdfs:label : hasPropertyAffordance^^xsd:string</para>
    ///   <a href="https://www.w3.org/2019/wot/td#hasPropertyAffordance">td:hasPropertyAffordance</a>
    /// </summary>
    let hasPropertyAffordance = _prefixId.prefix "hasPropertyAffordance"
    /// <summary>
    ///   <para>rdfs:comment : Set of security definition names, chosen from those defined in securityDefinitions.  These must all be satisfied for access to resources.</para>
    ///   <para>rdfs:label : hasSecurityConfiguration^^xsd:string</para>
    ///   <a href="https://www.w3.org/2019/wot/td#hasSecurityConfiguration">td:hasSecurityConfiguration</a>
    /// </summary>
    let hasSecurityConfiguration = _prefixId.prefix "hasSecurityConfiguration"
    /// <summary>
    ///   <para>rdfs:comment : Defines data that needs to be passed upon subscription, e.g., filters or message format for setting up Webhooks.</para>
    ///   <para>rdfs:label : hasSubscriptionSchema^^xsd:string</para>
    ///   <a href="https://www.w3.org/2019/wot/td#hasSubscriptionSchema">td:hasSubscriptionSchema</a>
    /// </summary>
    let hasSubscriptionSchema = _prefixId.prefix "hasSubscriptionSchema"
    /// <summary>
    ///   <para>rdfs:comment : Define URI template variables as collection based on schema specifications.</para>
    ///   <para>rdfs:label : hasUriTemplateSchema^^xsd:string</para>
    ///   <a href="https://www.w3.org/2019/wot/td#hasUriTemplateSchema">td:hasUriTemplateSchema</a>
    /// </summary>
    let hasUriTemplateSchema = _prefixId.prefix "hasUriTemplateSchema"
    /// <summary>
    ///   <para>rdfs:comment : Provides a version identicator of this TD instance.</para>
    ///   <para>rdfs:label : instance^^xsd:string</para>
    ///   <a href="https://www.w3.org/2019/wot/td#instance">td:instance</a>
    /// </summary>
    let instance = _prefixId.prefix "instance"
    let invokeAction = _prefixId.prefix "invokeAction"
    /// <summary>
    ///   <para>rdfs:comment : Indicates whether the action is idempotent (=true) or not. Informs whether the action can be called repeatedly with the same result, if present, based on the same input.</para>
    ///   <para>rdfs:label : isIdempotent^^xsd:string</para>
    ///   <a href="https://www.w3.org/2019/wot/td#isIdempotent">td:isIdempotent</a>
    /// </summary>
    let isIdempotent = _prefixId.prefix "isIdempotent"
    /// <summary>
    ///   <para>rdfs:comment : A hint that indicates whether Servients hosting the Thing and Intermediaries should provide a Protocol Binding that supports the &lt;code&gt;observeproperty&lt;/code&gt; operation for this Property.</para>
    ///   <para>rdfs:label : isObservable^^xsd:string</para>
    ///   <a href="https://www.w3.org/2019/wot/td#isObservable">td:isObservable</a>
    /// </summary>
    let isObservable = _prefixId.prefix "isObservable"
    /// <summary>
    ///   <para>rdfs:comment : Signals if the action is safe (=true) or not. Used to signal if there is no internal state (cf. resource state) is changed when invoking an Action. In that case responses can be cached as example.</para>
    ///   <para>rdfs:label : isSafe^^xsd:string</para>
    ///   <a href="https://www.w3.org/2019/wot/td#isSafe">td:isSafe</a>
    /// </summary>
    let isSafe = _prefixId.prefix "isSafe"
    /// <summary>
    ///   <para>rdfs:comment : Indexing property to store entity names when serializing them in a JSON-LD @index container.</para>
    ///   <para>rdfs:label : name^^xsd:string</para>
    ///   <a href="https://www.w3.org/2019/wot/td#name">td:name</a>
    /// </summary>
    let name = _prefixId.prefix "name"
    let observeProperty = _prefixId.prefix "observeProperty"
    let readAllProperties = _prefixId.prefix "readAllProperties"
    let readMultipleProperties = _prefixId.prefix "readMultipleProperties"
    let readProperty = _prefixId.prefix "readProperty"
    let subscribeEvent = _prefixId.prefix "subscribeEvent"
    /// <summary>
    ///   <para>rdfs:comment : Provides information about the TD maintainer as URI scheme (e.g., mailto [[RFC6068]], tel [[RFC3966]], https).</para>
    ///   <para>rdfs:label : supportContact^^xsd:string</para>
    ///   <a href="https://www.w3.org/2019/wot/td#supportContact">td:supportContact</a>
    /// </summary>
    let supportContact = _prefixId.prefix "supportContact"
    let unobserveProperty = _prefixId.prefix "unobserveProperty"
    let unsubscribeEvent = _prefixId.prefix "unsubscribeEvent"
    /// <summary>
    ///   <para>rdfs:comment : Provides version information.</para>
    ///   <para>rdfs:label : versionInfo^^xsd:string</para>
    ///   <a href="https://www.w3.org/2019/wot/td#versionInfo">td:versionInfo</a>
    /// </summary>
    let versionInfo = _prefixId.prefix "versionInfo"
    let writeAllProperties = _prefixId.prefix "writeAllProperties"
    let writeMultipleProperties = _prefixId.prefix "writeMultipleProperties"
    let writeProperty = _prefixId.prefix "writeProperty"
