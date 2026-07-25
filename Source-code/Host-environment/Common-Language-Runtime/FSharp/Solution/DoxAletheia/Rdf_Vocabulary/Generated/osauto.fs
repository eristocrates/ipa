namespace http.open_services.net.ns.auto.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module osauto =
    let _namespace_iri = Namespace_Iri osauto |> NamespaceIRI
    /// <summary>
    ///   <para>osauto:AutomationPlan</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The Automation Plan resource.</para>
    /// labels<para>AutomationPlan</para></remarks>
    /// <seealso href="http://open-services.net/ns/auto#AutomationPlan">http://open-services.net/ns/auto#AutomationPlan</seealso>
    let AutomationPlan = Prefixed_Name(osauto, "AutomationPlan") |> PrefixedName
    /// <summary>
    ///   <para>osauto:failed</para>
    /// </summary>
    /// <remarks>
    ///   <para>osauto:Verdict</para>
    ///   <para>Used to indicate an automation result represents a failed execution.</para>
    /// labels<para>fail</para></remarks>
    /// <seealso href="http://open-services.net/ns/auto#failed">http://open-services.net/ns/auto#failed</seealso>
    let failed = Prefixed_Name(osauto, "failed") |> PrefixedName

    /// <summary>
    ///   <para>osauto:producedByAutomationRequest</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Automation Request which produced the Automation Result. It is likely that the target resource will be an oslc_auto:AutomationResult but that is not necessarily the case.</para>
    /// labels<para>producedByAutomationRequest</para></remarks>
    /// <seealso href="http://open-services.net/ns/auto#producedByAutomationRequest">http://open-services.net/ns/auto#producedByAutomationRequest</seealso>
    let producedByAutomationRequest =
        Prefixed_Name(osauto, "producedByAutomationRequest") |> PrefixedName

    /// <summary>
    ///   <para>osauto:state</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Used to indicate the state of the automation request based on values defined  by the service provider. Most often a read-only property. It is expected that this will  be a resource reference to a definition of a valid automation request state on the service provider.</para>
    /// labels<para>state</para></remarks>
    /// <seealso href="http://open-services.net/ns/auto#state">http://open-services.net/ns/auto#state</seealso>
    let state = Prefixed_Name(osauto, "state") |> PrefixedName
    /// <summary>
    ///   <para>osauto:warning</para>
    /// </summary>
    /// <remarks>
    ///   <para>osauto:Verdict</para>
    ///   <para>Used to indicate an automation result represents an execution which encountered conditions which prevented successful execution but did not result in a failed execution.</para>
    /// labels<para>warning</para></remarks>
    /// <seealso href="http://open-services.net/ns/auto#warning">http://open-services.net/ns/auto#warning</seealso>
    let warning = Prefixed_Name(osauto, "warning") |> PrefixedName
    /// <summary>
    ///   <para>osauto:ParameterInstance</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The Automation Parameter Instance resource.</para>
    /// labels<para>ParameterInstance</para></remarks>
    /// <seealso href="http://open-services.net/ns/auto#ParameterInstance">http://open-services.net/ns/auto#ParameterInstance</seealso>
    let ParameterInstance = Prefixed_Name(osauto, "ParameterInstance") |> PrefixedName
    /// <summary>
    ///   <para>osauto:contribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A result contribution associated with this automation result. It is recommended that the  contribution be an inline resource which can be retrieved with the automation result. The recommended  attributes beyond the contribution itself are dcterms:title, dcterms:description and dcterms:type to  provide a description of the contribution which would be appropriate for display in a simple UI for   an automation result.</para>
    /// labels<para>hasContribution</para></remarks>
    /// <seealso href="http://open-services.net/ns/auto#contribution">http://open-services.net/ns/auto#contribution</seealso>
    let contribution = Prefixed_Name(osauto, "contribution") |> PrefixedName
    /// <summary>
    ///   <para>osauto:inProgress</para>
    /// </summary>
    /// <remarks>
    ///   <para>osauto:State</para>
    ///   <para>Used to indicate an automation request or result is active in the service provider.</para>
    /// labels<para>inProgress</para></remarks>
    /// <seealso href="http://open-services.net/ns/auto#inProgress">http://open-services.net/ns/auto#inProgress</seealso>
    let inProgress = Prefixed_Name(osauto, "inProgress") |> PrefixedName

    /// <summary>
    ///   <para>osauto:parameterDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The definition of a parameter for this Automation Plan. parameterDefinitions are either a local (inline) or referenced resource and use the attributes (the range) of the oslc:Property resource with one exception. When used in the context of an oslc_auto:parameterDefinition, the  cardinality of oslc:propertyDefinition becomes zero-or-one instead of exactly-one. Automation consumers  creating Automation Requests MUST use the oslc:occurs attribute of the parameterDefinition, if  present, to determine if a given parameter is required when creating the Automation Request.  If the oslc:occurs attribute indicates the parameter is required (exactly-one or one-or-more), the  service provider must guarantee the named parameter will be present in the Automation Result either  as an oslc_auto:inputParmeter when unmodified during execution, or as an oslc_auto:outputParameter  when modified during execution.</para>
    /// labels<para>parameterDefinition</para></remarks>
    /// <seealso href="http://open-services.net/ns/auto#parameterDefinition">http://open-services.net/ns/auto#parameterDefinition</seealso>
    let parameterDefinition =
        Prefixed_Name(osauto, "parameterDefinition") |> PrefixedName

    /// <summary>
    ///   <para>osauto:progress</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A percentage (0-100) of completion.</para>
    /// labels<para>progress</para></remarks>
    /// <seealso href="http://open-services.net/ns/auto#progress">http://open-services.net/ns/auto#progress</seealso>
    let progress = Prefixed_Name(osauto, "progress") |> PrefixedName
    /// <summary>
    ///   <para>osauto:unavailable</para>
    /// </summary>
    /// <remarks>
    ///   <para>osauto:Verdict</para>
    ///   <para>Used to indicate an automation result is in a state where a final verdict such as oslc:auto_pass or oslc_auto:fail is not yet available. Usually used when the result is in a state other than oslc_auto:complete.</para>
    /// labels<para>unavailable</para></remarks>
    /// <seealso href="http://open-services.net/ns/auto#unavailable">http://open-services.net/ns/auto#unavailable</seealso>
    let unavailable = Prefixed_Name(osauto, "unavailable") |> PrefixedName
    /// <summary>
    ///   <para>osauto:verdict</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Used to indicate the verdict of the automation result based on values defined by the service provider. Most often a read-only property. It is expected that this will be a resource reference to a   definition of a valid automation result verdict on the service provider.</para>
    /// labels<para>verdict</para></remarks>
    /// <seealso href="http://open-services.net/ns/auto#verdict">http://open-services.net/ns/auto#verdict</seealso>
    let verdict = Prefixed_Name(osauto, "verdict") |> PrefixedName
    /// <summary>
    ///   <para>osauto:binding</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A resource providing instructions that a client can follow to immediately execute the action, when the client is ready to do so. In this context (a deferred execution creation dialog), each binding is likely to be an immediate-execution binding, used during the execution phase of the deferred execution dialog interaction pattern.</para>
    /// labels<para>binding</para></remarks>
    /// <seealso href="http://open-services.net/ns/auto#binding">http://open-services.net/ns/auto#binding</seealso>
    let binding = Prefixed_Name(osauto, "binding") |> PrefixedName
    /// <summary>
    ///   <para>osauto:desiredState</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Used to indicate the desired state of the automation request based on values defined  by the service provider.</para>
    /// labels<para>desiredState</para></remarks>
    /// <seealso href="http://open-services.net/ns/auto#desiredState">http://open-services.net/ns/auto#desiredState</seealso>
    let desiredState = Prefixed_Name(osauto, "desiredState") |> PrefixedName

    /// <summary>
    ///   <para>osauto:executesAutomationPlan</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Automation Plan run by the Automation Request. It is likely that the target resource will be an  oslc_auto:AutomationPlan but that is not necessarily the case.</para>
    /// labels<para>executesAutomationPlan</para></remarks>
    /// <seealso href="http://open-services.net/ns/auto#executesAutomationPlan">http://open-services.net/ns/auto#executesAutomationPlan</seealso>
    let executesAutomationPlan =
        Prefixed_Name(osauto, "executesAutomationPlan") |> PrefixedName

    /// <summary>
    ///   <para>osauto:futureAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A resource representing actions that will become available on Automation Results that result from execution of this Plan. The resource is likely to be of type oslc:Action,
    /// but it can be of any type. Automation defines oslc_auto:TeardownAction as one kind of future action.</para>
    /// labels<para>futureAction</para></remarks>
    /// <seealso href="http://open-services.net/ns/auto#futureAction">http://open-services.net/ns/auto#futureAction</seealso>
    let futureAction = Prefixed_Name(osauto, "futureAction") |> PrefixedName
    /// <summary>
    ///   <para>osauto:new</para>
    /// </summary>
    /// <remarks>
    ///   <para>osauto:State</para>
    ///   <para>Used to indicate an automation request or result has just been created in the service  provider and has not yet been acted upon.</para>
    /// labels<para>new</para></remarks>
    /// <seealso href="http://open-services.net/ns/auto#new">http://open-services.net/ns/auto#new</seealso>
    let new_ = Prefixed_Name(osauto, "new") |> PrefixedName
    /// <summary>
    ///   <para>osauto:passed</para>
    /// </summary>
    /// <remarks>
    ///   <para>osauto:Verdict</para>
    ///   <para>Used to indicate an automation result represents a passed execution.</para>
    /// labels<para>passed</para></remarks>
    /// <seealso href="http://open-services.net/ns/auto#passed">http://open-services.net/ns/auto#passed</seealso>
    let passed = Prefixed_Name(osauto, "passed") |> PrefixedName
    /// <summary>
    ///   <para>osauto:queued</para>
    /// </summary>
    /// <remarks>
    ///   <para>osauto:State</para>
    ///   <para>Primarily used to indicate an automation request or result is queued for additional actions by the service provider.</para>
    /// labels<para>queued</para></remarks>
    /// <seealso href="http://open-services.net/ns/auto#queued">http://open-services.net/ns/auto#queued</seealso>
    let queued = Prefixed_Name(osauto, "queued") |> PrefixedName

    /// <summary>
    ///   <para>osauto:usesExecutionEnvironment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A resource representing the environment(s) which this Automation Plan can be executed in. The execution environment resource could represent a grouping of
    /// environmental details such as operating system, database, browser, compiler, etc. See also the execution environments section.</para>
    /// labels<para>usesExecutionEnvironment</para></remarks>
    /// <seealso href="http://open-services.net/ns/auto#usesExecutionEnvironment">http://open-services.net/ns/auto#usesExecutionEnvironment</seealso>
    let usesExecutionEnvironment =
        Prefixed_Name(osauto, "usesExecutionEnvironment") |> PrefixedName

    /// <summary>
    ///   <para>osauto:canceled</para>
    /// </summary>
    /// <remarks>
    ///   <para>osauto:State</para>
    ///   <para>Used to indicate that an automation request or result has been canceled.</para>
    /// labels<para>canceled</para></remarks>
    /// <seealso href="http://open-services.net/ns/auto#canceled">http://open-services.net/ns/auto#canceled</seealso>
    let canceled = Prefixed_Name(osauto, "canceled") |> PrefixedName
    /// <summary>
    ///   <para>osauto:complete</para>
    /// </summary>
    /// <remarks>
    ///   <para>osauto:State</para>
    ///   <para>Used to indicate that an automation request or result is complete.</para>
    /// labels<para>complete</para></remarks>
    /// <seealso href="http://open-services.net/ns/auto#complete">http://open-services.net/ns/auto#complete</seealso>
    let complete = Prefixed_Name(osauto, "complete") |> PrefixedName
    /// <summary>
    ///   <para>osauto:error</para>
    /// </summary>
    /// <remarks>
    ///   <para>osauto:Verdict</para>
    ///   <para>Used to indicate an automation result has completed but did not run successfully due to some error. This could be a timeout, automation coding error, network problem or other error which prevented the automation from running successfully to a pass, warning or fail verdict.</para>
    /// labels<para>error</para></remarks>
    /// <seealso href="http://open-services.net/ns/auto#error">http://open-services.net/ns/auto#error</seealso>
    let error = Prefixed_Name(osauto, "error") |> PrefixedName
    /// <summary>
    ///   <para>osauto:inputParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Parameters provided when Automation Requests are created. These include parameters provided  by the creator of the Automation Request (whether by delegated UI or HTTP POST) and MAY include  additional parameters added by the service provider during Automation Request creation. See the  definition of the oslc_auto:parameterDefinition attribute of the Automation Plan for additional guidance  on determining which parameters are required. Creators of Automation Requests MAY provide parameters beyond  those defined in the Automation Plan without guarantee the service provider will recognize or honor them.  It is expected that this attribute is write-able on Automation Request creation and read-only thereafter.</para>
    /// labels<para>inputParameter</para></remarks>
    /// <seealso href="http://open-services.net/ns/auto#inputParameter">http://open-services.net/ns/auto#inputParameter</seealso>
    let inputParameter = Prefixed_Name(osauto, "inputParameter") |> PrefixedName
    /// <summary>
    ///   <para>osauto:outputParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Automation Result output parameters are parameters associated with the result other than the oslc_auto:inputParameter resources. These could be parameters added during automation execution by the service provider or external agents. They could also be copies of input parameters with values changed during execution.</para>
    /// labels<para>outputParameter</para></remarks>
    /// <seealso href="http://open-services.net/ns/auto#outputParameter">http://open-services.net/ns/auto#outputParameter</seealso>
    let outputParameter = Prefixed_Name(osauto, "outputParameter") |> PrefixedName

    /// <summary>
    ///   <para>osauto:reportsOnAutomationPlan</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Automation Plan which the Automation Result reports on. It is likely that the target resource
    /// will be an oslc_auto:AutomationPlan but that is not necessarily the case.</para>
    /// labels<para>reportsOnAutomationPlan</para></remarks>
    /// <seealso href="http://open-services.net/ns/auto#reportsOnAutomationPlan">http://open-services.net/ns/auto#reportsOnAutomationPlan</seealso>
    let reportsOnAutomationPlan =
        Prefixed_Name(osauto, "reportsOnAutomationPlan") |> PrefixedName

    /// <summary>
    ///   <para>osauto:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>OSLC Automation (AUTO) Vocabulary</para></remarks>
    /// <seealso href="http://open-services.net/ns/auto#">http://open-services.net/ns/auto#</seealso>
    let _prefix_iri = Prefixed_Name(osauto, "") |> PrefixedName
    /// <summary>
    ///   <para>osauto:AutomationRequest</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The Automation Request resource.</para>
    /// labels<para>AutomationRequest</para></remarks>
    /// <seealso href="http://open-services.net/ns/auto#AutomationRequest">http://open-services.net/ns/auto#AutomationRequest</seealso>
    let AutomationRequest = Prefixed_Name(osauto, "AutomationRequest") |> PrefixedName
    /// <summary>
    ///   <para>osauto:AutomationResult</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The Automation Result resource.</para>
    /// labels<para>AutomationResult</para></remarks>
    /// <seealso href="http://open-services.net/ns/auto#AutomationResult">http://open-services.net/ns/auto#AutomationResult</seealso>
    let AutomationResult = Prefixed_Name(osauto, "AutomationResult") |> PrefixedName
    /// <summary>
    ///   <para>osauto:State</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Defines the possible oslc_auto:state property values.</para>
    /// labels<para>State</para></remarks>
    /// <seealso href="http://open-services.net/ns/auto#State">http://open-services.net/ns/auto#State</seealso>
    let State = Prefixed_Name(osauto, "State") |> PrefixedName
    /// <summary>
    ///   <para>osauto:Verdict</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Defines the possible oslc_auto:verdict property values.</para>
    /// labels<para>Verdict</para></remarks>
    /// <seealso href="http://open-services.net/ns/auto#Verdict">http://open-services.net/ns/auto#Verdict</seealso>
    let Verdict = Prefixed_Name(osauto, "Verdict") |> PrefixedName
    /// <summary>
    ///   <para>osauto:canceling</para>
    /// </summary>
    /// <remarks>
    ///   <para>osauto:State</para>
    ///   <para>Used to indicate the service provider is in the process of canceling an automation request or result.</para>
    /// labels<para>canceling</para></remarks>
    /// <seealso href="http://open-services.net/ns/auto#canceling">http://open-services.net/ns/auto#canceling</seealso>
    let canceling = Prefixed_Name(osauto, "canceling") |> PrefixedName
