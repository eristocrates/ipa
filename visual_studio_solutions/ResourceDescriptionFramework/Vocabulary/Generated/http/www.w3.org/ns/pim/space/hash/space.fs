namespace Space.Namespace
module space =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://www.w3.org/ns/pim/space#" (Some "http://www.w3.org/ns/pim/space#") (Some "space") None
    let ConfigurationFile = {_prefixID with _localName = "ConfigurationFile"}
    let ControlledStorage = {_prefixID with _localName = "ControlledStorage"}
    let MasterWorkspace = {_prefixID with _localName = "MasterWorkspace"}
    let PersonalStorage = {_prefixID with _localName = "PersonalStorage"}
    let PreferencesWorkspace = {_prefixID with _localName = "PreferencesWorkspace"}
    let PrivateWorkspace = {_prefixID with _localName = "PrivateWorkspace"}
    let PublicStorage = {_prefixID with _localName = "PublicStorage"}
    let PublicWorkspace = {_prefixID with _localName = "PublicWorkspace"}
    let SharedWorkspace = {_prefixID with _localName = "SharedWorkspace"}
    let Storage = {_prefixID with _localName = "Storage"}
    let Workspace = {_prefixID with _localName = "Workspace"}
    let masterWorkspace = {_prefixID with _localName = "masterWorkspace"}
    let preferencesFile = {_prefixID with _localName = "preferencesFile"}
    let storage = {_prefixID with _localName = "storage"}
    let uriPrefix = {_prefixID with _localName = "uriPrefix"}
    let workspace = {_prefixID with _localName = "workspace"}