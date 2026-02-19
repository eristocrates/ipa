namespace Pplan.Namespace
module pplan =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://purl.org/net/p-plan#" (Some "http://purl.org/net/p-plan#") (Some "pplan") None
    let Activity = {_prefixID with _localName = "Activity"}
    let Bundle = {_prefixID with _localName = "Bundle"}
    let Entity = {_prefixID with _localName = "Entity"}
    let MultiStep = {_prefixID with _localName = "MultiStep"}
    let Plan = {_prefixID with _localName = "Plan"}
    let Step = {_prefixID with _localName = "Step"}
    let Variable = {_prefixID with _localName = "Variable"}
    let correspondsToStep = {_prefixID with _localName = "correspondsToStep"}
    let correspondsToVariable = {_prefixID with _localName = "correspondsToVariable"}
    let hasInputVar = {_prefixID with _localName = "hasInputVar"}
    let hasOutputVar = {_prefixID with _localName = "hasOutputVar"}
    let isDecomposedAsPlan = {_prefixID with _localName = "isDecomposedAsPlan"}
    let isInputVarOf = {_prefixID with _localName = "isInputVarOf"}
    let isOutputVarOf = {_prefixID with _localName = "isOutputVarOf"}
    let isPrecededBy = {_prefixID with _localName = "isPrecededBy"}
    let isStepOfPlan = {_prefixID with _localName = "isStepOfPlan"}
    let isSubPlanOfPlan = {_prefixID with _localName = "isSubPlanOfPlan"}
    let isVariableOfPlan = {_prefixID with _localName = "isVariableOfPlan"}