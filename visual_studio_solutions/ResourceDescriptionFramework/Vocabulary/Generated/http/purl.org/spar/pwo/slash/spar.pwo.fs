namespace Spar.pwo.Namespace
module pwo =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://purl.org/spar/pwo/" (Some "http://purl.org/spar/pwo.ttl") (Some "spar.pwo") None
    let ``2017-06-01`` = {_prefixID with _localName = "2017-06-01"}
    let Action = {_prefixID with _localName = "Action"}
    let Step = {_prefixID with _localName = "Step"}
    let Workflow = {_prefixID with _localName = "Workflow"}
    let WorkflowExecution = {_prefixID with _localName = "WorkflowExecution"}
    let executes = {_prefixID with _localName = "executes"}
    let happened = {_prefixID with _localName = "happened"}
    let hasFirstStep = {_prefixID with _localName = "hasFirstStep"}
    let hasNextStep = {_prefixID with _localName = "hasNextStep"}
    let hasPreviousStep = {_prefixID with _localName = "hasPreviousStep"}
    let hasStep = {_prefixID with _localName = "hasStep"}
    let involvesAction = {_prefixID with _localName = "involvesAction"}
    let isActionInvolvedIn = {_prefixID with _localName = "isActionInvolvedIn"}
    let isExecutedBy = {_prefixID with _localName = "isExecutedBy"}
    let isIntervalFor = {_prefixID with _localName = "isIntervalFor"}
    let isNeededBy = {_prefixID with _localName = "isNeededBy"}
    let isProducedBy = {_prefixID with _localName = "isProducedBy"}
    let isStepOf = {_prefixID with _localName = "isStepOf"}
    let needs = {_prefixID with _localName = "needs"}
    let produces = {_prefixID with _localName = "produces"}
    let ``pwo.png`` = {_prefixID with _localName = "pwo.png"}