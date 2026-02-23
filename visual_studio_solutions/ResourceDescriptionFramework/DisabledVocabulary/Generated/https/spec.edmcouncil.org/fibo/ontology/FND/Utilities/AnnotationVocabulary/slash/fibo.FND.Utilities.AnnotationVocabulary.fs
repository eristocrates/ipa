namespace Fibo.FND.Utilities.AnnotationVocabulary.Namespace
module AnnotationVocabulary =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/AnnotationVocabulary/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/FND/Utilities/AnnotationVocabulary.rdf") (Some @"fibo.FND.Utilities.AnnotationVocabulary") None
    let Informative = {_prefixID with _localName = "Informative"}
    let MaturityLevel = {_prefixID with _localName = "MaturityLevel"}
    let Module = {_prefixID with _localName = "Module"}
    let Provisional = {_prefixID with _localName = "Provisional"}
    let Release = {_prefixID with _localName = "Release"}
    let commonDesignation = {_prefixID with _localName = "commonDesignation"}
    let definitionOrigin = {_prefixID with _localName = "definitionOrigin"}
    let hasMaturityLevel = {_prefixID with _localName = "hasMaturityLevel"}
    let preferredDesignation = {_prefixID with _localName = "preferredDesignation"}
    let termOrigin = {_prefixID with _localName = "termOrigin"}