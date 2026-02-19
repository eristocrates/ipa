namespace Oasis.oslc.auto.Namespace
module auto =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://open-services.net/ns/auto#" (Some "https://docs.oasis-open-projects.org/oslc-op/auto/v2.1/psd01/automation-vocab.ttl") (Some "oasis.oslc.auto") None
    let AutomationPlan = {_prefixID with _localName = "AutomationPlan"}
    let AutomationRequest = {_prefixID with _localName = "AutomationRequest"}
    let AutomationResult = {_prefixID with _localName = "AutomationResult"}
    let ParameterInstance = {_prefixID with _localName = "ParameterInstance"}
    let State = {_prefixID with _localName = "State"}
    let Verdict = {_prefixID with _localName = "Verdict"}
    let binding = {_prefixID with _localName = "binding"}
    let canceled = {_prefixID with _localName = "canceled"}
    let canceling = {_prefixID with _localName = "canceling"}
    let complete = {_prefixID with _localName = "complete"}
    let contribution = {_prefixID with _localName = "contribution"}
    let desiredState = {_prefixID with _localName = "desiredState"}
    let error = {_prefixID with _localName = "error"}
    let executesAutomationPlan = {_prefixID with _localName = "executesAutomationPlan"}
    let failed = {_prefixID with _localName = "failed"}
    let futureAction = {_prefixID with _localName = "futureAction"}
    let inProgress = {_prefixID with _localName = "inProgress"}
    let inputParameter = {_prefixID with _localName = "inputParameter"}
    let ``new`` = {_prefixID with _localName = "new"}
    let outputParameter = {_prefixID with _localName = "outputParameter"}
    let parameterDefinition = {_prefixID with _localName = "parameterDefinition"}
    let passed = {_prefixID with _localName = "passed"}
    let producedByAutomationRequest = {_prefixID with _localName = "producedByAutomationRequest"}
    let progress = {_prefixID with _localName = "progress"}
    let queued = {_prefixID with _localName = "queued"}
    let reportsOnAutomationPlan = {_prefixID with _localName = "reportsOnAutomationPlan"}
    let state = {_prefixID with _localName = "state"}
    let unavailable = {_prefixID with _localName = "unavailable"}
    let usesExecutionEnvironment = {_prefixID with _localName = "usesExecutionEnvironment"}
    let verdict = {_prefixID with _localName = "verdict"}
    let warning = {_prefixID with _localName = "warning"}