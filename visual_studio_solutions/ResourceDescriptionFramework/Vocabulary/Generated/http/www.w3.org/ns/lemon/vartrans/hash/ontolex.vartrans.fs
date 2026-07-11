namespace Ontolex.vartrans.Namespace
module vartrans =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://www.w3.org/ns/lemon/vartrans#" (Some "http://www.w3.org/ns/lemon/vartrans#") (Some "ontolex.vartrans") None
    let ConceptualRelation = {_prefixID with _localName = "ConceptualRelation"}
    let LexicalRelation = {_prefixID with _localName = "LexicalRelation"}
    let LexicoSemanticRelation = {_prefixID with _localName = "LexicoSemanticRelation"}
    let SenseRelation = {_prefixID with _localName = "SenseRelation"}
    let TerminologicalRelation = {_prefixID with _localName = "TerminologicalRelation"}
    let Translation = {_prefixID with _localName = "Translation"}
    let TranslationSet = {_prefixID with _localName = "TranslationSet"}
    let category = {_prefixID with _localName = "category"}
    let conceptRel = {_prefixID with _localName = "conceptRel"}
    let imports = {_prefixID with _localName = "imports"}
    let lexicalRel = {_prefixID with _localName = "lexicalRel"}
    let relates = {_prefixID with _localName = "relates"}
    let senseRel = {_prefixID with _localName = "senseRel"}
    let source = {_prefixID with _localName = "source"}
    let target = {_prefixID with _localName = "target"}
    let trans = {_prefixID with _localName = "trans"}
    let translatableAs = {_prefixID with _localName = "translatableAs"}
    let translation = {_prefixID with _localName = "translation"}
    let versionInfo = {_prefixID with _localName = "versionInfo"}