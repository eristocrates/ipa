namespace Ssn.Namespace
module ssn =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://www.w3.org/ns/ssn/" (Some "http://www.w3.org/ns/ssn/") (Some "ssn") None
    let Deployment = {_prefixID with _localName = "Deployment"}
    let Input = {_prefixID with _localName = "Input"}
    let Output = {_prefixID with _localName = "Output"}
    let Property = {_prefixID with _localName = "Property"}
    let Stimulus = {_prefixID with _localName = "Stimulus"}
    let System = {_prefixID with _localName = "System"}
    let deployedOnPlatform = {_prefixID with _localName = "deployedOnPlatform"}
    let deployedSystem = {_prefixID with _localName = "deployedSystem"}
    let detects = {_prefixID with _localName = "detects"}
    let forProperty = {_prefixID with _localName = "forProperty"}
    let hasDeployment = {_prefixID with _localName = "hasDeployment"}
    let hasInput = {_prefixID with _localName = "hasInput"}
    let hasOutput = {_prefixID with _localName = "hasOutput"}
    let hasProperty = {_prefixID with _localName = "hasProperty"}
    let hasSubSystem = {_prefixID with _localName = "hasSubSystem"}
    let implementedBy = {_prefixID with _localName = "implementedBy"}
    let implements = {_prefixID with _localName = "implements"}
    let inDeployment = {_prefixID with _localName = "inDeployment"}
    let isPropertyOf = {_prefixID with _localName = "isPropertyOf"}
    let isProxyFor = {_prefixID with _localName = "isProxyFor"}
    let wasOriginatedBy = {_prefixID with _localName = "wasOriginatedBy"}