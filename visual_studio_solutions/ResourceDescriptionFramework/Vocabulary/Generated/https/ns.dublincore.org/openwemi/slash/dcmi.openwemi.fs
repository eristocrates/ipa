namespace Dcmi.openwemi.Namespace
module openwemi =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://ns.dublincore.org/openwemi/" (Some @"https://dcmi.github.io/openwemi/ns/openWEMI.ttl") (Some @"dcmi.openwemi") None
    let Endeavor = {_prefixID with _localName = "Endeavor"}
    let Expression = {_prefixID with _localName = "Expression"}
    let Item = {_prefixID with _localName = "Item"}
    let Manifestation = {_prefixID with _localName = "Manifestation"}
    let Work = {_prefixID with _localName = "Work"}
    let commonEndeavor = {_prefixID with _localName = "commonEndeavor"}
    let commonExpression = {_prefixID with _localName = "commonExpression"}
    let commonItem = {_prefixID with _localName = "commonItem"}
    let commonManifestation = {_prefixID with _localName = "commonManifestation"}
    let commonWork = {_prefixID with _localName = "commonWork"}
    let expressedBy = {_prefixID with _localName = "expressedBy"}
    let expresses = {_prefixID with _localName = "expresses"}
    let instantiatedBy = {_prefixID with _localName = "instantiatedBy"}
    let instantiates = {_prefixID with _localName = "instantiates"}
    let manifestedBy = {_prefixID with _localName = "manifestedBy"}
    let manifests = {_prefixID with _localName = "manifests"}
    let relatedExpression = {_prefixID with _localName = "relatedExpression"}
    let relatedItem = {_prefixID with _localName = "relatedItem"}
    let relatedManifestation = {_prefixID with _localName = "relatedManifestation"}
    let relatedWork = {_prefixID with _localName = "relatedWork"}