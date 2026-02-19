namespace Ontolex.Namespace
module ontolex =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://www.w3.org/ns/lemon/ontolex#" (Some "http://www.w3.org/ns/lemon/ontolex#") (Some "ontolex") None
    let Affix = {_prefixID with _localName = "Affix"}
    let ConceptSet = {_prefixID with _localName = "ConceptSet"}
    let Form = {_prefixID with _localName = "Form"}
    let LexicalConcept = {_prefixID with _localName = "LexicalConcept"}
    let LexicalEntry = {_prefixID with _localName = "LexicalEntry"}
    let LexicalSense = {_prefixID with _localName = "LexicalSense"}
    let MultiWordExpression = {_prefixID with _localName = "MultiWordExpression"}
    let Word = {_prefixID with _localName = "Word"}
    let canonicalForm = {_prefixID with _localName = "canonicalForm"}
    let concept = {_prefixID with _localName = "concept"}
    let denotes = {_prefixID with _localName = "denotes"}
    let evokes = {_prefixID with _localName = "evokes"}
    let isConceptOf = {_prefixID with _localName = "isConceptOf"}
    let isDenotedBy = {_prefixID with _localName = "isDenotedBy"}
    let isEvokedBy = {_prefixID with _localName = "isEvokedBy"}
    let isLexicalizedSenseOf = {_prefixID with _localName = "isLexicalizedSenseOf"}
    let isReferenceOf = {_prefixID with _localName = "isReferenceOf"}
    let isSenseOf = {_prefixID with _localName = "isSenseOf"}
    let lexicalForm = {_prefixID with _localName = "lexicalForm"}
    let lexicalizedSense = {_prefixID with _localName = "lexicalizedSense"}
    let morphologicalPattern = {_prefixID with _localName = "morphologicalPattern"}
    let otherForm = {_prefixID with _localName = "otherForm"}
    let phoneticRep = {_prefixID with _localName = "phoneticRep"}
    let reference = {_prefixID with _localName = "reference"}
    let representation = {_prefixID with _localName = "representation"}
    let sense = {_prefixID with _localName = "sense"}
    let usage = {_prefixID with _localName = "usage"}
    let writtenRep = {_prefixID with _localName = "writtenRep"}