namespace Owl_s.Profile.Namespace
module Profile =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://www.daml.org/services/owl-s/1.2/Profile.owl#" (Some "http://www.daml.org/services/owl-s/1.2/Profile.owl") (Some "owl_s.Profile") None
    let Profile = {_prefixID with _localName = "Profile"}
    let ServiceCategory = {_prefixID with _localName = "ServiceCategory"}
    let ServiceParameter = {_prefixID with _localName = "ServiceParameter"}
    let categoryName = {_prefixID with _localName = "categoryName"}
    let code = {_prefixID with _localName = "code"}
    let contactInformation = {_prefixID with _localName = "contactInformation"}
    let hasInput = {_prefixID with _localName = "hasInput"}
    let hasOutput = {_prefixID with _localName = "hasOutput"}
    let hasParameter = {_prefixID with _localName = "hasParameter"}
    let hasPrecondition = {_prefixID with _localName = "hasPrecondition"}
    let hasResult = {_prefixID with _localName = "hasResult"}
    let has_process = {_prefixID with _localName = "has_process"}
    let sParameter = {_prefixID with _localName = "sParameter"}
    let serviceCategory = {_prefixID with _localName = "serviceCategory"}
    let serviceClassification = {_prefixID with _localName = "serviceClassification"}
    let serviceName = {_prefixID with _localName = "serviceName"}
    let serviceParameter = {_prefixID with _localName = "serviceParameter"}
    let serviceParameterName = {_prefixID with _localName = "serviceParameterName"}
    let serviceProduct = {_prefixID with _localName = "serviceProduct"}
    let taxonomy = {_prefixID with _localName = "taxonomy"}
    let textDescription = {_prefixID with _localName = "textDescription"}
    let value = {_prefixID with _localName = "value"}