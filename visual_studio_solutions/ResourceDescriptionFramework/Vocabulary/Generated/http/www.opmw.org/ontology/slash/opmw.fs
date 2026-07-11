namespace Opmw.Namespace
module opmw =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://www.opmw.org/ontology/" (Some "https://www.opmw.org/model/OPMW/opmw3.1.owl") (Some "opmw") None
    let DataVariable = {_prefixID with _localName = "DataVariable"}
    let ParameterVariable = {_prefixID with _localName = "ParameterVariable"}
    let WorkflowExecutionAccount = {_prefixID with _localName = "WorkflowExecutionAccount"}
    let WorkflowExecutionArtifact = {_prefixID with _localName = "WorkflowExecutionArtifact"}
    let WorkflowExecutionProcess = {_prefixID with _localName = "WorkflowExecutionProcess"}
    let WorkflowTemplate = {_prefixID with _localName = "WorkflowTemplate"}
    let WorkflowTemplateArtifact = {_prefixID with _localName = "WorkflowTemplateArtifact"}
    let WorkflowTemplateProcess = {_prefixID with _localName = "WorkflowTemplateProcess"}
    let correspondsToTemplate = {_prefixID with _localName = "correspondsToTemplate"}
    let correspondsToTemplateArtifact = {_prefixID with _localName = "correspondsToTemplateArtifact"}
    let correspondsToTemplateProcess = {_prefixID with _localName = "correspondsToTemplateProcess"}
    let createdInWorkflowSystem = {_prefixID with _localName = "createdInWorkflowSystem"}
    let executedInWorkflowSystem = {_prefixID with _localName = "executedInWorkflowSystem"}
    let hasDimensionality = {_prefixID with _localName = "hasDimensionality"}
    let hasDocumentation = {_prefixID with _localName = "hasDocumentation"}
    let hasExecutableComponent = {_prefixID with _localName = "hasExecutableComponent"}
    let hasExecutionDiagram = {_prefixID with _localName = "hasExecutionDiagram"}
    let hasFileName = {_prefixID with _localName = "hasFileName"}
    let hasLocation = {_prefixID with _localName = "hasLocation"}
    let hasNativeSystemTemplate = {_prefixID with _localName = "hasNativeSystemTemplate"}
    let hasOriginalLogFile = {_prefixID with _localName = "hasOriginalLogFile"}
    let hasSize = {_prefixID with _localName = "hasSize"}
    let hasStatus = {_prefixID with _localName = "hasStatus"}
    let hasTemplateDiagram = {_prefixID with _localName = "hasTemplateDiagram"}
    let hasValue = {_prefixID with _localName = "hasValue"}
    let isConcrete = {_prefixID with _localName = "isConcrete"}
    let isGeneratedBy = {_prefixID with _localName = "isGeneratedBy"}
    let isParameterOfTemplate = {_prefixID with _localName = "isParameterOfTemplate"}
    let isStepOfTemplate = {_prefixID with _localName = "isStepOfTemplate"}
    let isVariableOfTemplate = {_prefixID with _localName = "isVariableOfTemplate"}
    let overallEndTime = {_prefixID with _localName = "overallEndTime"}
    let overallStartTime = {_prefixID with _localName = "overallStartTime"}
    let uses = {_prefixID with _localName = "uses"}
    let versionNumber = {_prefixID with _localName = "versionNumber"}