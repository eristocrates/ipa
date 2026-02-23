namespace Fibo.FND.DatesAndTimes.Occurrences.Namespace
module Occurrences =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/Occurrences/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/FND/DatesAndTimes/Occurrences.rdf") (Some @"fibo.FND.DatesAndTimes.Occurrences") None
    let Calculation = {_prefixID with _localName = "Calculation"}
    let CalculationEvent = {_prefixID with _localName = "CalculationEvent"}
    let Occurrence = {_prefixID with _localName = "Occurrence"}
    let OccurrenceBasedDate = {_prefixID with _localName = "OccurrenceBasedDate"}
    let OccurrenceKind = {_prefixID with _localName = "OccurrenceKind"}
    let hasEventDate = {_prefixID with _localName = "hasEventDate"}
    let hasEventDateValue = {_prefixID with _localName = "hasEventDateValue"}
    let hasInput = {_prefixID with _localName = "hasInput"}
    let hasOccurrence = {_prefixID with _localName = "hasOccurrence"}
    let hasOutput = {_prefixID with _localName = "hasOutput"}
    let isInputTo = {_prefixID with _localName = "isInputTo"}
    let isOutputFrom = {_prefixID with _localName = "isOutputFrom"}
    let isTriggeredBy = {_prefixID with _localName = "isTriggeredBy"}