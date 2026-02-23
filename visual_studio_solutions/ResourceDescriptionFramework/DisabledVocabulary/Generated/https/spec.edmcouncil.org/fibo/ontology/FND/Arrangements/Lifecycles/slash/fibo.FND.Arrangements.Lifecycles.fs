namespace Fibo.FND.Arrangements.Lifecycles.Namespace
module Lifecycles =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Lifecycles/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/FND/Arrangements/Lifecycles.rdf") (Some @"fibo.FND.Arrangements.Lifecycles") None
    let Lifecycle = {_prefixID with _localName = "Lifecycle"}
    let LifecycleEvent = {_prefixID with _localName = "LifecycleEvent"}
    let LifecycleEventOccurrence = {_prefixID with _localName = "LifecycleEventOccurrence"}
    let LifecycleOccurrence = {_prefixID with _localName = "LifecycleOccurrence"}
    let LifecycleStage = {_prefixID with _localName = "LifecycleStage"}
    let LifecycleStageOccurrence = {_prefixID with _localName = "LifecycleStageOccurrence"}
    let LifecycleStatus = {_prefixID with _localName = "LifecycleStatus"}
    let hasLifecycle = {_prefixID with _localName = "hasLifecycle"}
    let hasStage = {_prefixID with _localName = "hasStage"}
    let isLifecycleOf = {_prefixID with _localName = "isLifecycleOf"}
    let isStageOf = {_prefixID with _localName = "isStageOf"}