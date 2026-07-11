namespace Swap.workflow.Namespace
module workflow =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://eulersharp.sourceforge.net/2003/03swap/workflow#" (Some "http://eulersharp.sourceforge.net/2003/03swap/workflow") (Some "swap.workflow") None
    let Action = {_prefixID with _localName = "Action"}
    let Agent = {_prefixID with _localName = "Agent"}
    let ExclusiveChoice = {_prefixID with _localName = "ExclusiveChoice"}
    let Input = {_prefixID with _localName = "Input"}
    let Output = {_prefixID with _localName = "Output"}
    let ParallelSplit = {_prefixID with _localName = "ParallelSplit"}
    let Pattern = {_prefixID with _localName = "Pattern"}
    let Resource = {_prefixID with _localName = "Resource"}
    let Role = {_prefixID with _localName = "Role"}
    let Sequence = {_prefixID with _localName = "Sequence"}
    let SimpleMerge = {_prefixID with _localName = "SimpleMerge"}
    let Synchronization = {_prefixID with _localName = "Synchronization"}
    let Workflow = {_prefixID with _localName = "Workflow"}
    let actionOf = {_prefixID with _localName = "actionOf"}
    let hasAction = {_prefixID with _localName = "hasAction"}
    let hasWorkflow = {_prefixID with _localName = "hasWorkflow"}