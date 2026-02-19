namespace Ontolex.termlex.Namespace
module termlex =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://termlex.oeg.fi.upm.es/termlex#" (Some @"https://termlex.oeg.fi.upm.es/static/termlex.rdf") (Some @"ontolex.termlex") None
    let ``1`` = {_prefixID with _localName = "1"}
    let ``2`` = {_prefixID with _localName = "2"}
    let ``3`` = {_prefixID with _localName = "3"}
    let ``4`` = {_prefixID with _localName = "4"}
    let ``5`` = {_prefixID with _localName = "5"}
    let Definition = {_prefixID with _localName = "Definition"}
    let Note = {_prefixID with _localName = "Note"}
    let ReliabilityCode = {_prefixID with _localName = "ReliabilityCode"}
    let Source = {_prefixID with _localName = "Source"}
    let TerminologicalConcept = {_prefixID with _localName = "TerminologicalConcept"}
    let Usage = {_prefixID with _localName = "Usage"}
    let concept = {_prefixID with _localName = "concept"}
    let evokes = {_prefixID with _localName = "evokes"}
    let isConceptOf = {_prefixID with _localName = "isConceptOf"}
    let isEvokedBy = {_prefixID with _localName = "isEvokedBy"}
    let isLexicalizedSenseOf = {_prefixID with _localName = "isLexicalizedSenseOf"}
    let lexicalizedSense = {_prefixID with _localName = "lexicalizedSense"}
    let reliabilityCode = {_prefixID with _localName = "reliabilityCode"}