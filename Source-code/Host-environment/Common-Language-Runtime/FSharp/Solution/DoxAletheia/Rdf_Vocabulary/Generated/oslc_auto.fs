namespace http.open_services.net.ns.auto.hash

open DoxAletheia.Rdf_Vocabulary

module oslc_auto =
    let _namespace_name = "http://open-services.net/ns/auto#"

    /// <summary>
    /// The Automation Plan resource.
    /// <see href="http://open-services.net/ns/auto#AutomationPlan"></see></summary>
    let AutomationPlan =
        Namespaced_IRI.parse _namespace_name "AutomationPlan" |> NamespacedName

    /// <summary>
    /// The Automation Request resource.
    /// <see href="http://open-services.net/ns/auto#AutomationRequest"></see></summary>
    let AutomationRequest =
        Namespaced_IRI.parse _namespace_name "AutomationRequest" |> NamespacedName

    /// <summary>
    /// The Automation Result resource.
    /// <see href="http://open-services.net/ns/auto#AutomationResult"></see></summary>
    let AutomationResult =
        Namespaced_IRI.parse _namespace_name "AutomationResult" |> NamespacedName

    /// <summary>
    /// The Automation Parameter Instance resource.
    /// <see href="http://open-services.net/ns/auto#ParameterInstance"></see></summary>
    let ParameterInstance =
        Namespaced_IRI.parse _namespace_name "ParameterInstance" |> NamespacedName

    /// <summary>
    /// Defines the possible oslc_auto:state property values.
    /// <see href="http://open-services.net/ns/auto#State"></see></summary>
    let State = Namespaced_IRI.parse _namespace_name "State" |> NamespacedName
    /// <summary>
    /// Defines the possible oslc_auto:verdict property values.
    /// <see href="http://open-services.net/ns/auto#Verdict"></see></summary>
    let Verdict = Namespaced_IRI.parse _namespace_name "Verdict" |> NamespacedName
    /// <summary>
    /// A resource providing instructions that a client can follow to immediately execute the action, when the client is ready to do so. In this context (a deferred execution creation dialog), each binding is likely to be an immediate-execution binding, used during the execution phase of the deferred execution dialog interaction pattern.
    /// <see href="http://open-services.net/ns/auto#binding"></see></summary>
    let binding = Namespaced_IRI.parse _namespace_name "binding" |> NamespacedName
    /// <summary>
    /// Used to indicate that an automation request or result has been canceled.
    /// <see href="http://open-services.net/ns/auto#canceled"></see></summary>
    let canceled = Namespaced_IRI.parse _namespace_name "canceled" |> NamespacedName
    /// <summary>
    /// Used to indicate the service provider is in the process of canceling an automation request or result.
    /// <see href="http://open-services.net/ns/auto#canceling"></see></summary>
    let canceling = Namespaced_IRI.parse _namespace_name "canceling" |> NamespacedName
    /// <summary>
    /// Used to indicate that an automation request or result is complete.
    /// <see href="http://open-services.net/ns/auto#complete"></see></summary>
    let complete = Namespaced_IRI.parse _namespace_name "complete" |> NamespacedName

    /// <summary>
    /// A result contribution associated with this automation result. It is recommended that the  contribution be an inline resource which can be retrieved with the automation result. The recommended  attributes beyond the contribution itself are dcterms:title, dcterms:description and dcterms:type to  provide a description of the contribution which would be appropriate for display in a simple UI for   an automation result.
    /// <see href="http://open-services.net/ns/auto#contribution"></see></summary>
    let contribution =
        Namespaced_IRI.parse _namespace_name "contribution" |> NamespacedName

    /// <summary>
    /// Used to indicate the desired state of the automation request based on values defined  by the service provider.
    /// <see href="http://open-services.net/ns/auto#desiredState"></see></summary>
    let desiredState =
        Namespaced_IRI.parse _namespace_name "desiredState" |> NamespacedName

    /// <summary>
    /// Used to indicate an automation result has completed but did not run successfully due to some error. This could be a timeout, automation coding error, network problem or other error which prevented the automation from running successfully to a pass, warning or fail verdict.
    /// <see href="http://open-services.net/ns/auto#error"></see></summary>
    let error = Namespaced_IRI.parse _namespace_name "error" |> NamespacedName

    /// <summary>
    /// Automation Plan run by the Automation Request. It is likely that the target resource will be an  oslc_auto:AutomationPlan but that is not necessarily the case.
    /// <see href="http://open-services.net/ns/auto#executesAutomationPlan"></see></summary>
    let executesAutomationPlan =
        Namespaced_IRI.parse _namespace_name "executesAutomationPlan" |> NamespacedName

    /// <summary>
    /// Used to indicate an automation result represents a failed execution.
    /// <see href="http://open-services.net/ns/auto#failed"></see></summary>
    let failed = Namespaced_IRI.parse _namespace_name "failed" |> NamespacedName

    /// <summary>
    /// A resource representing actions that will become available on Automation Results that result from execution of this Plan. The resource is likely to be of type oslc:Action,
    /// but it can be of any type. Automation defines oslc_auto:TeardownAction as one kind of future action.
    /// <see href="http://open-services.net/ns/auto#futureAction"></see></summary>
    let futureAction =
        Namespaced_IRI.parse _namespace_name "futureAction" |> NamespacedName

    /// <summary>
    /// Used to indicate an automation request or result is active in the service provider.
    /// <see href="http://open-services.net/ns/auto#inProgress"></see></summary>
    let inProgress = Namespaced_IRI.parse _namespace_name "inProgress" |> NamespacedName

    /// <summary>
    /// Parameters provided when Automation Requests are created. These include parameters provided  by the creator of the Automation Request (whether by delegated UI or HTTP POST) and MAY include  additional parameters added by the service provider during Automation Request creation. See the  definition of the oslc_auto:parameterDefinition attribute of the Automation Plan for additional guidance  on determining which parameters are required. Creators of Automation Requests MAY provide parameters beyond  those defined in the Automation Plan without guarantee the service provider will recognize or honor them.  It is expected that this attribute is write-able on Automation Request creation and read-only thereafter.
    /// <see href="http://open-services.net/ns/auto#inputParameter"></see></summary>
    let inputParameter =
        Namespaced_IRI.parse _namespace_name "inputParameter" |> NamespacedName

    /// <summary>
    /// Used to indicate an automation request or result has just been created in the service  provider and has not yet been acted upon.
    /// <see href="http://open-services.net/ns/auto#new"></see></summary>
    let new_ = Namespaced_IRI.parse _namespace_name "new" |> NamespacedName

    /// <summary>
    /// Automation Result output parameters are parameters associated with the result other than the oslc_auto:inputParameter resources. These could be parameters added during automation execution by the service provider or external agents. They could also be copies of input parameters with values changed during execution.
    /// <see href="http://open-services.net/ns/auto#outputParameter"></see></summary>
    let outputParameter =
        Namespaced_IRI.parse _namespace_name "outputParameter" |> NamespacedName

    /// <summary>
    /// The definition of a parameter for this Automation Plan. parameterDefinitions are either a local (inline) or referenced resource and use the attributes (the range) of the oslc:Property resource with one exception. When used in the context of an oslc_auto:parameterDefinition, the  cardinality of oslc:propertyDefinition becomes zero-or-one instead of exactly-one. Automation consumers  creating Automation Requests MUST use the oslc:occurs attribute of the parameterDefinition, if  present, to determine if a given parameter is required when creating the Automation Request.  If the oslc:occurs attribute indicates the parameter is required (exactly-one or one-or-more), the  service provider must guarantee the named parameter will be present in the Automation Result either  as an oslc_auto:inputParmeter when unmodified during execution, or as an oslc_auto:outputParameter  when modified during execution.
    /// <see href="http://open-services.net/ns/auto#parameterDefinition"></see></summary>
    let parameterDefinition =
        Namespaced_IRI.parse _namespace_name "parameterDefinition" |> NamespacedName

    /// <summary>
    /// Used to indicate an automation result represents a passed execution.
    /// <see href="http://open-services.net/ns/auto#passed"></see></summary>
    let passed = Namespaced_IRI.parse _namespace_name "passed" |> NamespacedName

    /// <summary>
    /// Automation Request which produced the Automation Result. It is likely that the target resource will be an oslc_auto:AutomationResult but that is not necessarily the case.
    /// <see href="http://open-services.net/ns/auto#producedByAutomationRequest"></see></summary>
    let producedByAutomationRequest =
        Namespaced_IRI.parse _namespace_name "producedByAutomationRequest" |> NamespacedName

    /// <summary>
    /// A percentage (0-100) of completion.
    /// <see href="http://open-services.net/ns/auto#progress"></see></summary>
    let progress = Namespaced_IRI.parse _namespace_name "progress" |> NamespacedName
    /// <summary>
    /// Primarily used to indicate an automation request or result is queued for additional actions by the service provider.
    /// <see href="http://open-services.net/ns/auto#queued"></see></summary>
    let queued = Namespaced_IRI.parse _namespace_name "queued" |> NamespacedName

    /// <summary>
    /// Automation Plan which the Automation Result reports on. It is likely that the target resource
    /// will be an oslc_auto:AutomationPlan but that is not necessarily the case.
    /// <see href="http://open-services.net/ns/auto#reportsOnAutomationPlan"></see></summary>
    let reportsOnAutomationPlan =
        Namespaced_IRI.parse _namespace_name "reportsOnAutomationPlan" |> NamespacedName

    /// <summary>
    /// Used to indicate the state of the automation request based on values defined  by the service provider. Most often a read-only property. It is expected that this will  be a resource reference to a definition of a valid automation request state on the service provider.
    /// <see href="http://open-services.net/ns/auto#state"></see></summary>
    let state = Namespaced_IRI.parse _namespace_name "state" |> NamespacedName

    /// <summary>
    /// Used to indicate an automation result is in a state where a final verdict such as oslc:auto_pass or oslc_auto:fail is not yet available. Usually used when the result is in a state other than oslc_auto:complete.
    /// <see href="http://open-services.net/ns/auto#unavailable"></see></summary>
    let unavailable =
        Namespaced_IRI.parse _namespace_name "unavailable" |> NamespacedName

    /// <summary>
    /// A resource representing the environment(s) which this Automation Plan can be executed in. The execution environment resource could represent a grouping of
    /// environmental details such as operating system, database, browser, compiler, etc. See also the execution environments section.
    /// <see href="http://open-services.net/ns/auto#usesExecutionEnvironment"></see></summary>
    let usesExecutionEnvironment =
        Namespaced_IRI.parse _namespace_name "usesExecutionEnvironment" |> NamespacedName

    /// <summary>
    /// Used to indicate the verdict of the automation result based on values defined by the service provider. Most often a read-only property. It is expected that this will be a resource reference to a   definition of a valid automation result verdict on the service provider.
    /// <see href="http://open-services.net/ns/auto#verdict"></see></summary>
    let verdict = Namespaced_IRI.parse _namespace_name "verdict" |> NamespacedName
    /// <summary>
    /// Used to indicate an automation result represents an execution which encountered conditions which prevented successful execution but did not result in a failed execution.
    /// <see href="http://open-services.net/ns/auto#warning"></see></summary>
    let warning = Namespaced_IRI.parse _namespace_name "warning" |> NamespacedName
