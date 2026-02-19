namespace Ontolex.synsem.Namespace
module synsem =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://www.w3.org/ns/lemon/synsem#" (Some "http://www.w3.org/ns/lemon/synsem#") (Some "ontolex.synsem") None
    let OntoMap = {_prefixID with _localName = "OntoMap"}
    let SyntacticArgument = {_prefixID with _localName = "SyntacticArgument"}
    let SyntacticFrame = {_prefixID with _localName = "SyntacticFrame"}
    let condition = {_prefixID with _localName = "condition"}
    let isA = {_prefixID with _localName = "isA"}
    let marker = {_prefixID with _localName = "marker"}
    let objOfProp = {_prefixID with _localName = "objOfProp"}
    let ontoCorrespondence = {_prefixID with _localName = "ontoCorrespondence"}
    let ontoMapping = {_prefixID with _localName = "ontoMapping"}
    let optional = {_prefixID with _localName = "optional"}
    let propertyDomain = {_prefixID with _localName = "propertyDomain"}
    let propertyRange = {_prefixID with _localName = "propertyRange"}
    let subjOfProp = {_prefixID with _localName = "subjOfProp"}
    let submap = {_prefixID with _localName = "submap"}
    let synArg = {_prefixID with _localName = "synArg"}
    let synBehavior = {_prefixID with _localName = "synBehavior"}