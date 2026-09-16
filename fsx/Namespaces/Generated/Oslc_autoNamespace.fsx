#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module oslc_auto =
    let _prefixId = PrefixId.fromNamespaceLabel "http://open-services.net/ns/auto#" "oslc_auto"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:comment : The Automation Plan resource.^^xsd:string</para>
    ///   <para>rdfs:label : AutomationPlan^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/auto#AutomationPlan">oslc_auto:AutomationPlan</a>
    /// </summary>
    let AutomationPlan = _prefixId.prefix "AutomationPlan"
    /// <summary>
    ///   <para>rdfs:comment : The Automation Request resource.^^xsd:string</para>
    ///   <para>rdfs:label : AutomationRequest^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/auto#AutomationRequest">oslc_auto:AutomationRequest</a>
    /// </summary>
    let AutomationRequest = _prefixId.prefix "AutomationRequest"
    /// <summary>
    ///   <para>rdfs:comment : The Automation Result resource.^^xsd:string</para>
    ///   <para>rdfs:label : AutomationResult^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/auto#AutomationResult">oslc_auto:AutomationResult</a>
    /// </summary>
    let AutomationResult = _prefixId.prefix "AutomationResult"
    /// <summary>
    ///   <para>rdfs:comment : The Automation Parameter Instance resource.^^xsd:string</para>
    ///   <para>rdfs:label : ParameterInstance^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/auto#ParameterInstance">oslc_auto:ParameterInstance</a>
    /// </summary>
    let ParameterInstance = _prefixId.prefix "ParameterInstance"
    /// <summary>
    ///   <para>rdfs:label : State^^xsd:string</para>
    ///   <para>rdfs:comment : Defines the possible oslc_auto:state property values.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/auto#State">oslc_auto:State</a>
    /// </summary>
    let State = _prefixId.prefix "State"
    /// <summary>
    ///   <para>rdfs:label : Verdict^^xsd:string</para>
    ///   <para>rdfs:comment : Defines the possible oslc_auto:verdict property values.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/auto#Verdict">oslc_auto:Verdict</a>
    /// </summary>
    let Verdict = _prefixId.prefix "Verdict"
    /// <summary>
    ///   <para>rdfs:comment : A resource providing instructions that a client can follow to immediately execute the action, when the client is ready to do so. In this context (a deferred execution creation dialog), each binding is likely to be an immediate-execution binding, used during the execution phase of the deferred execution dialog interaction pattern.^^xsd:string</para>
    ///   <para>rdfs:label : binding^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/auto#binding">oslc_auto:binding</a>
    /// </summary>
    let binding = _prefixId.prefix "binding"
    let canceled = _prefixId.prefix "canceled"
    let canceling = _prefixId.prefix "canceling"
    let complete = _prefixId.prefix "complete"
    /// <summary>
    ///   <para>rdfs:comment : A result contribution associated with this automation result. It is recommended that the  contribution be an inline resource which can be retrieved with the automation result. The recommended  attributes beyond the contribution itself are dcterms:title, dcterms:description and dcterms:type to  provide a description of the contribution which would be appropriate for display in a simple UI for   an automation result.^^xsd:string</para>
    ///   <para>rdfs:label : hasContribution^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/auto#contribution">oslc_auto:contribution</a>
    /// </summary>
    let contribution = _prefixId.prefix "contribution"
    /// <summary>
    ///   <para>rdfs:comment : Used to indicate the desired state of the automation request based on values defined  by the service provider.^^xsd:string</para>
    ///   <para>rdfs:label : desiredState^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/auto#desiredState">oslc_auto:desiredState</a>
    /// </summary>
    let desiredState = _prefixId.prefix "desiredState"
    let error = _prefixId.prefix "error"
    /// <summary>
    ///   <para>rdfs:comment : Automation Plan run by the Automation Request. It is likely that the target resource will be an  oslc_auto:AutomationPlan but that is not necessarily the case.^^xsd:string</para>
    ///   <para>rdfs:label : executesAutomationPlan^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/auto#executesAutomationPlan">oslc_auto:executesAutomationPlan</a>
    /// </summary>
    let executesAutomationPlan = _prefixId.prefix "executesAutomationPlan"
    let failed = _prefixId.prefix "failed"
    /// <summary>
    ///   <para>rdfs:comment : A resource representing actions that will become available on Automation Results that result from execution of this Plan. The resource is likely to be of type oslc:Action,
    /// but it can be of any type. Automation defines oslc_auto:TeardownAction as one kind of future action.^^xsd:string</para>
    ///   <para>rdfs:label : futureAction^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/auto#futureAction">oslc_auto:futureAction</a>
    /// </summary>
    let futureAction = _prefixId.prefix "futureAction"
    let inProgress = _prefixId.prefix "inProgress"
    /// <summary>
    ///   <para>rdfs:comment : Parameters provided when Automation Requests are created. These include parameters provided  by the creator of the Automation Request (whether by delegated UI or HTTP POST) and MAY include  additional parameters added by the service provider during Automation Request creation. See the  definition of the oslc_auto:parameterDefinition attribute of the Automation Plan for additional guidance  on determining which parameters are required. Creators of Automation Requests MAY provide parameters beyond  those defined in the Automation Plan without guarantee the service provider will recognize or honor them.  It is expected that this attribute is write-able on Automation Request creation and read-only thereafter.^^xsd:string</para>
    ///   <para>rdfs:label : inputParameter^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/auto#inputParameter">oslc_auto:inputParameter</a>
    /// </summary>
    let inputParameter = _prefixId.prefix "inputParameter"
    let new_ = _prefixId.prefix "new"
    /// <summary>
    ///   <para>rdfs:comment : Automation Result output parameters are parameters associated with the result other than the oslc_auto:inputParameter resources. These could be parameters added during automation execution by the service provider or external agents. They could also be copies of input parameters with values changed during execution.^^xsd:string</para>
    ///   <para>rdfs:label : outputParameter^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/auto#outputParameter">oslc_auto:outputParameter</a>
    /// </summary>
    let outputParameter = _prefixId.prefix "outputParameter"
    /// <summary>
    ///   <para>rdfs:comment : The definition of a parameter for this Automation Plan. parameterDefinitions are either a local (inline) or referenced resource and use the attributes (the range) of the oslc:Property resource with one exception. When used in the context of an oslc_auto:parameterDefinition, the  cardinality of oslc:propertyDefinition becomes zero-or-one instead of exactly-one. Automation consumers  creating Automation Requests MUST use the oslc:occurs attribute of the parameterDefinition, if  present, to determine if a given parameter is required when creating the Automation Request.  If the oslc:occurs attribute indicates the parameter is required (exactly-one or one-or-more), the  service provider must guarantee the named parameter will be present in the Automation Result either  as an oslc_auto:inputParmeter when unmodified during execution, or as an oslc_auto:outputParameter  when modified during execution.^^xsd:string</para>
    ///   <para>rdfs:label : parameterDefinition^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/auto#parameterDefinition">oslc_auto:parameterDefinition</a>
    /// </summary>
    let parameterDefinition = _prefixId.prefix "parameterDefinition"
    let passed = _prefixId.prefix "passed"
    /// <summary>
    ///   <para>rdfs:comment : Automation Request which produced the Automation Result. It is likely that the target resource will be an oslc_auto:AutomationResult but that is not necessarily the case.^^xsd:string</para>
    ///   <para>rdfs:label : producedByAutomationRequest^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/auto#producedByAutomationRequest">oslc_auto:producedByAutomationRequest</a>
    /// </summary>
    let producedByAutomationRequest = _prefixId.prefix "producedByAutomationRequest"
    /// <summary>
    ///   <para>rdfs:comment : A percentage (0-100) of completion.^^xsd:string</para>
    ///   <para>rdfs:label : progress^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/auto#progress">oslc_auto:progress</a>
    /// </summary>
    let progress = _prefixId.prefix "progress"
    let queued = _prefixId.prefix "queued"
    /// <summary>
    ///   <para>rdfs:comment : Automation Plan which the Automation Result reports on. It is likely that the target resource
    /// will be an oslc_auto:AutomationPlan but that is not necessarily the case.^^xsd:string</para>
    ///   <para>rdfs:label : reportsOnAutomationPlan^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/auto#reportsOnAutomationPlan">oslc_auto:reportsOnAutomationPlan</a>
    /// </summary>
    let reportsOnAutomationPlan = _prefixId.prefix "reportsOnAutomationPlan"
    /// <summary>
    ///   <para>rdfs:comment : Used to indicate the state of the automation request based on values defined  by the service provider. Most often a read-only property. It is expected that this will  be a resource reference to a definition of a valid automation request state on the service provider.^^xsd:string</para>
    ///   <para>rdfs:label : state^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/auto#state">oslc_auto:state</a>
    /// </summary>
    let state = _prefixId.prefix "state"
    let unavailable = _prefixId.prefix "unavailable"
    /// <summary>
    ///   <para>rdfs:comment : A resource representing the environment(s) which this Automation Plan can be executed in. The execution environment resource could represent a grouping of
    /// environmental details such as operating system, database, browser, compiler, etc. See also the execution environments section.^^xsd:string</para>
    ///   <para>rdfs:label : usesExecutionEnvironment^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/auto#usesExecutionEnvironment">oslc_auto:usesExecutionEnvironment</a>
    /// </summary>
    let usesExecutionEnvironment = _prefixId.prefix "usesExecutionEnvironment"
    /// <summary>
    ///   <para>rdfs:comment : Used to indicate the verdict of the automation result based on values defined by the service provider. Most often a read-only property. It is expected that this will be a resource reference to a   definition of a valid automation result verdict on the service provider.^^xsd:string</para>
    ///   <para>rdfs:label : verdict^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/auto#verdict">oslc_auto:verdict</a>
    /// </summary>
    let verdict = _prefixId.prefix "verdict"
    let warning = _prefixId.prefix "warning"
