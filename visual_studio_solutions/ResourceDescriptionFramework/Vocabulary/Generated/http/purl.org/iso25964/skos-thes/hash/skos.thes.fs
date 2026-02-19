namespace Skos.thes.Namespace
module thes =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://purl.org/iso25964/skos-thes#" (Some @"https://www.dublincore.org/specifications/skos-thes/ns/skos-thes.ttl") (Some @"skos.thes") None
    let CompoundEquivalence = {_prefixID with _localName = "CompoundEquivalence"}
    let ConceptGroup = {_prefixID with _localName = "ConceptGroup"}
    let PreferredTerm = {_prefixID with _localName = "PreferredTerm"}
    let SimpleNonPreferredTerm = {_prefixID with _localName = "SimpleNonPreferredTerm"}
    let SplitNonPreferredTerm = {_prefixID with _localName = "SplitNonPreferredTerm"}
    let ThesaurusArray = {_prefixID with _localName = "ThesaurusArray"}
    let broaderGeneric = {_prefixID with _localName = "broaderGeneric"}
    let broaderInstantial = {_prefixID with _localName = "broaderInstantial"}
    let broaderPartitive = {_prefixID with _localName = "broaderPartitive"}
    let microThesaurusOf = {_prefixID with _localName = "microThesaurusOf"}
    let narrowerGeneric = {_prefixID with _localName = "narrowerGeneric"}
    let narrowerInstantial = {_prefixID with _localName = "narrowerInstantial"}
    let narrowerPartitive = {_prefixID with _localName = "narrowerPartitive"}
    let plusUF = {_prefixID with _localName = "plusUF"}
    let plusUFTerm = {_prefixID with _localName = "plusUFTerm"}
    let plusUse = {_prefixID with _localName = "plusUse"}
    let plusUseTerm = {_prefixID with _localName = "plusUseTerm"}
    let status = {_prefixID with _localName = "status"}
    let subGroup = {_prefixID with _localName = "subGroup"}
    let subordinateArray = {_prefixID with _localName = "subordinateArray"}
    let superGroup = {_prefixID with _localName = "superGroup"}
    let superOrdinate = {_prefixID with _localName = "superOrdinate"}