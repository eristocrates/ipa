namespace Ottr.wOTTR.shacl.Namespace
module shacl =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://ns.ottr.xyz/0.4/" (Some @"https://spec.ottr.xyz/wOTTR/0.4.5/core-grammar.shacl.ttl") (Some @"ottr.wOTTR.shacl") None
    let ArgumentShape = {_prefixID with _localName = "ArgumentShape"}
    let BaseTemplate = {_prefixID with _localName = "BaseTemplate"}
    let BaseTemplateShape = {_prefixID with _localName = "BaseTemplateShape"}
    let BasicTypeShape = {_prefixID with _localName = "BasicTypeShape"}
    let InstanceShape = {_prefixID with _localName = "InstanceShape"}
    let ModifierShape = {_prefixID with _localName = "ModifierShape"}
    let ParameterShape = {_prefixID with _localName = "ParameterShape"}
    let RDFListShape = {_prefixID with _localName = "RDFListShape"}
    let Signature = {_prefixID with _localName = "Signature"}
    let SignatureShape = {_prefixID with _localName = "SignatureShape"}
    let Template = {_prefixID with _localName = "Template"}
    let TemplateShape = {_prefixID with _localName = "TemplateShape"}
    let TypeListShape = {_prefixID with _localName = "TypeListShape"}
    let TypeShape = {_prefixID with _localName = "TypeShape"}
    let annotation = {_prefixID with _localName = "annotation"}
    let arguments = {_prefixID with _localName = "arguments"}
    let cross = {_prefixID with _localName = "cross"}
    let ``default`` = {_prefixID with _localName = "default"}
    let listExpand = {_prefixID with _localName = "listExpand"}
    let modifier = {_prefixID with _localName = "modifier"}
    let name = {_prefixID with _localName = "name"}
    let nonBlank = {_prefixID with _localName = "nonBlank"}
    let ``of`` = {_prefixID with _localName = "of"}
    let optional = {_prefixID with _localName = "optional"}
    let parameters = {_prefixID with _localName = "parameters"}
    let pattern = {_prefixID with _localName = "pattern"}
    let ``type`` = {_prefixID with _localName = "type"}
    let value = {_prefixID with _localName = "value"}
    let values = {_prefixID with _localName = "values"}
    let variable = {_prefixID with _localName = "variable"}
    let zipMax = {_prefixID with _localName = "zipMax"}
    let zipMin = {_prefixID with _localName = "zipMin"}